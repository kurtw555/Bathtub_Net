Option Strict Off
Option Explicit On
Imports Excel = Microsoft.Office.Interop.Excel
Imports System
Imports UpgradeHelpers.Helpers
Module Module2
	Sub Calcon()
		' control calculations

		Icalc = 0
		Ier = 0
		Nmsg = 0
		ErrTxt = ""

		'c turn on error messages
		Imsg = 1

		'c screen input values
		Prelim()
		If Not (Ier > 0) Then

			'c basic model
			Model()
			If Not (Ier > 0) Then

				'c turn off error messages for error analysis
				Imsg = 0

				'c error analysis
				ErrorAnalysis()

				'c calc switch
				Icalc = 1
				Exit Sub

				'c fatal error
			End If
		End If

		Elist(1, "Fatal Errors Occurred...")
		Icalc = 0

	End Sub

	Sub Model()
		'c WATER AND MASS BALANCE CALCULATIONS

		Icalc = 0
		Ier = 0

		'c water balance
		WaterBalance()
		If Ier > 0 Then Exit Sub

		If NTrib > 0 Then

			'c setup for mass balance
			MassBalance(0)
			If Ier > 0 Then Exit Sub

			'c mass balance solution
			For jc As Integer = 1 To 3
				If Iop(jc) > 0 Then
					MassBalance(jc)
					If Ier > 0 Then Exit Sub
				End If
			Next jc
		End If

		'C response submodels
		ResponseModels()
		If Ier > 0 Then Exit Sub

		'C store gross mass-balance terms
		If NTrib > 0 Then MassBalanceTerms()

		'model executed
		Icalc = 1
	End Sub
	Sub MassBalance(ByVal jc As Integer)
		Dim C0, ICONC As Double
		Dim IDEPTH As Integer
		Dim t1, t2 As Double
		'c mass-balance for component jc
		Dim Iter, j, k, kmaP As Integer
		Dim vV As Single
		Dim jaG As Integer
		Dim xx As Single

		'c jc=0 setup for mass balances
		If jc <= 0 Then

			'C Calc Hydraulics and check for negative water balance
			For i As Integer = 1 To Nseg
				Hydrau(i)
				Exch(i) = x(8)
				xx = Qnet(i) - Area(i) * P(4) / P(1)
				'c negative water balance (warning)
				If xx < 0 Then
					'     Call Elist(13, i, 0)
					Elist(0, "Warning: Negative Water Balance for Segment " & i)
				End If
			Next i

			'c reset q matrix = advective +diffusive flows
			For i As Integer = 1 To Nseg
				For j = 1 To Nseg
					Q(i, j) = 0
				Next j
			Next i

			'c add withdrawal flows to main diagonal
			For i As Integer = 1 To NTrib
				If Icode(i) = 4 And Iseg(i) > 0 Then
					j = Iseg(i)
					Q(j, j) += Flow(i)
				End If
			Next i

			'c add pipes
			For i As Integer = 1 To Npipe
				j = Ifr(i)
				k = Ito(i)
				Q(j, j) = Q(j, j) + Qpipe(i) + Epipe(i)
				Q(k, j) = Q(k, j) - Qpipe(i) - Epipe(i)
				Q(k, k) += Epipe(i)
				Q(j, k) -= Epipe(i)
			Next i

			'C ADD STORAGE, ADVECTIVE, AND EXCHANGE FLOWS TO MATRIX
			For i As Integer = 1 To Nseg
				j = Iout(i)

				'C INCREASE IN STORAGE ON MAIN DIAGONAL
				Q(i, i) += Area(i) * P(4) / P(1)

				If j = 0 Or Qadv(i) >= 0 Then

					'C POSITIVE ADVECTIVE OUTFLOW OR ADVECTION OUT OF SYSTEM
					Q(i, i) += Qadv(i)
					If (j > 0) Then Q(j, i) -= Qadv(i)
				Else
					'C NEGATIVE ADVECTIVE OUTFLOW  (REVERSAL OF FLOW DIRECTION)
					Q(j, j) -= Qadv(i)
					Q(i, j) += Qadv(i)
				End If

				'c Exchange terms
				Q(i, i) += Exch(i)
				If j > 0 Then
					Q(j, j) += Exch(i)
					Q(i, j) -= Exch(i)
					Q(j, i) -= Exch(i)
				End If
			Next i

		Else

			'C COMPONENTS JC=1=CONS,2=TP,3=TN

			'c Imap() = 1, 6, 7

			kmaP = Imap(jc)
			'C initialize source y() and conc() guess
			'c  trib sources wt() and internal sources wi()
			Iter = 0
			For i As Integer = 1 To Nseg
				Conc(i) = MAx(Cest(i, jc), 1) '????
				Wt(i) = 0
				Wi(i) = 0
				y(i) = Area(i) * Atm(kmaP) + Area(i) * InternalLoad(i, kmaP) * 365.25
			Next i

			'C LOOP AROUND SOURCES
			For i As Integer = 1 To NTrib
				j = Iseg(i)
				If j > 0 Then

					'c downstream exchange
					If Icode(i) = 5 Then
						y(j) += Flow(i) * Conci(i, kmaP)

						'c internal load conci in mg/m2-d
						'           ElseIf Icode(i) = 5 Then
						'               y(j) = y(j) + Area(j) * Conci(i, kmap) * 365.25

						'  ElseIf Icode(i) <= 3 Then
					ElseIf Icode(i) = 2 Then  'nonpoint
						y(j) += FlowL(i) * Concil(i, kmaP)
						Wt(j) += FlowL(i) * Concil(i, jc)
						Wi(j) += FlowL(i) * Concil(i, jc + 2)
					ElseIf Icode(i) = 1 Then 
						y(j) += Flow(i) * Conci(i, kmaP)
						Wt(j) += Flow(i) * Conci(i, jc) 'trib total load
						Wi(j) += Flow(i) * Conci(i, jc + 2) 'trib inorganic load
					ElseIf Icode(i) = 3 Then 
						y(j) += Flow(i) * Conci(i, kmaP)
					End If

				End If
			Next i

			'C CONSERVATIVE SUBSTANCE SOLUTION jc=1
			If jc = 1 Then

				For j = 1 To Nseg
					For i As Integer = 1 To Nseg
						A(i, j) = Q(i, j)
					Next i
					A(j, Nseg + 1) = y(j)
				Next j

				'      Call Blin(Dx, A, Y, Nseg, Ml, Mu, Isym, kER)
				SolveLinear()
				If Ier > 0 Then
					Elist(1, "Invalid Solution for Conservative Substance")
					Exit Sub
				End If

				For i As Integer = 1 To Nseg
					Conc(i) = A(i, Nseg + 1)
				Next i

			Else

				'C ITERATE FOR P, N SOLUTION JC = 2 or 3
S760:
				Iter += 1
				If Iter > MAXIT Then
					Elist(1, "Maximum Iterations Exceeded for Solution to Mass Balance, Variable = " & VariableName(kmaP))
					Exit Sub
				End If

				'c update segment groups
				AggregateVariables()
				If Ier > 0 Then Exit Sub

				'C NEWTON 'S METHOD
				jaG = 0
				For i As Integer = 1 To Nseg

					'C UPDATE COEFFICIENTS IF SEGMENT GROUP CHANGES
					If jaG <> Iag(i) Then
						Coefs(jc, C0, ICONC, IDEPTH, Iag(i))
						If Ier > 0 Then
							Elist(1, "Invalid Sedimentation Coefficient for Segment Group: " & Iag(i))
							Exit Sub
						End If
						jaG = Iag(i)
					End If

					'C SEDIMENTATION TERM
					If Zmn(i) > 0 Then
						'cc           VV=C0*xk(jc-1)*AREA(I)*(CONC(I)**(ICONC-1))*
						'cc     &         zmn(i)**(idepth+1)
						vV = C0 * Area(i) * (Conc(i) ^ (ICONC - 1)) * Zmn(i) ^ (IDEPTH + 1)
					Else
						vV = 0
					End If

					'c add calibration factors
					'cc        IF(IOP(JC+5)=1) VV=VV*CAL(I,JC-1)
					If Iop(jc + 5) = 1 Then vV = vV * Cal(i, jc) * Xk(jc)

					'C FUNCTION AND FIRST DERIVATIVES
					x(i) = y(i) - vV * Conc(i)
					For j = 1 To Nseg
						x(i) -= Q(i, j) * Conc(j)
						A(i, j) = Q(i, j)
					Next j
					'c main diagonal
					A(i, i) += ICONC * vV
				Next i
				For i As Integer = 1 To Nseg
					A(i, Nseg + 1) = x(i)
				Next i

				'C SOLVE MASS BALANCE EQUATIONS

				SolveLinear()
				If Ier > 0 Then
					Elist(1, "Could Not Solve Mass Balance for: " & VariableName(jc) & " Check Segment Linkage")
					Exit Sub
				End If

				'C TEST FOR CONVERGENCE
				t2 = 0
				For i As Integer = 1 To Nseg
					x(i) = A(i, Nseg + 1)
					Conc(i) += x(i)
					t1 = Math.Abs(x(i) / Conc(i))
					t2 = MAx(t2, t1)
				Next i

				If t2 > Tol Then GoTo S760

				'c mass-balance achieved
			End If

			'c save solution
			For i As Integer = 1 To Nseg
				'c test for positivity
				If Conc(i) < 0 Then
					Elist(1, "Negative Predicted Conc, Segment = " & i & " " & SegName(jc))
					Exit Sub
				End If
				Cest(i, jc) = Conc(i)

				'apply calibration factor
				If Iop(jc + 5) >= 2 And jc > 1 Then Cest(i, jc) = Conc(i) * Cal(i, jc) * Xk(jc)

			Next i
		End If

	End Sub

	Sub WaterBalance()
		'$include:'net.inc'

		'c SET UP FLOW SOLUTION MATRIX
		Dim j, k As Integer

		For i As Integer = 1 To Nseg
			For j = 1 To Nseg
				A(i, j) = 0
			Next j
		Next i

		For i As Integer = 1 To Nseg

			'c qnet() will contain net inflows WHY DIVIDE THESE BY Averaging Period??
			Qnet(i) = Area(i) * (P(2) - P(3)) / P(1)

			'C Qadv() will contain advective outflow from segment, excluding pipes
			Qadv(i) = Qnet(i) - P(4) * Area(i) / P(1)

			'c DIAGONAL
			A(i, i) = 1

			'c advection
			If Iout(i) > 0 Then A(Iout(i), i) = -1

		Next i
		'c pipes
		For i As Integer = 1 To Npipe
			j = Ifr(i)
			k = Ito(i)
			Qadv(j) -= Qpipe(i)
			Qadv(k) += Qpipe(i)
		Next i

		If NTrib <= 0 Then Exit Sub

		'C EXTERNAL SOURCES,WITHDRAWALS
		For i As Integer = 1 To NTrib
			k = Iseg(i)
			If k > 0 Then
				'           If Icode(i) <= 3 Then
				If Icode(i) = 2 Then 'nonpoint
					Qadv(k) += FlowL(i)
					Qnet(k) += FlowL(i)
				ElseIf Icode(i) <= 3 Then  'trib or point source
					Qadv(k) += Flow(i)
					Qnet(k) += Flow(i)
				ElseIf Icode(i) = 4 Then  'outflow
					Qadv(k) -= Flow(i)
				End If
			End If
		Next i

		For i As Integer = 1 To Nseg
			A(i, Nseg + 1) = Qadv(i)
		Next i

		'C SOLVE FLOW BALANCE - returns advective outflows qadv()
		'       Call Blin(Dx, A, Qadv, Nseg, Ml, Mu, Isym, kER)
		SolveLinear()
		If Ier > 0 Then
			Elist(1, "Could Not Solve Water Balance")
			Exit Sub
		End If
		For i As Integer = 1 To Nseg
			Qadv(i) = A(i, Nseg + 1)
		Next i

		'C NET INFLOWS
		For i As Integer = 1 To Nseg
			j = Iout(i)
			If j > 0 Then
				'C REVERSE FLOW DIRECTION IF QADV IS NEGATIVE
				If Qadv(i) < 0 Then j = i
				Qnet(j) += Math.Abs(Qadv(i))
			End If
		Next i

	End Sub

	Sub AggregateVariables()

		'c compute segment group statistics

		'C SEG GROUP VECTOR AGREG(JAG,K), JAG=SEGMENT GROUP REFERENCE,
		'C   1 = TOTAL AREA   2 = TOTAL VOLUME     3 = NET INFLOW (IN+PREC-EVAP)
		'C   4 = TOTAL LOAD   5 = TRIB TOTAL LOAD  6 = TRIB INORG LOAD
		Dim j, k As Integer


		For i As Integer = 1 To Nseg
			For j = 1 To 6
				Agreg(i, j) = 0
			Next j
		Next i
		Dim nag As Integer = 0

		For i As Integer = 1 To Nseg
			j = Iag(i)
			nag = CInt(MAx(nag, j))
			Agreg(j, 1) += Area(i)
			Agreg(j, 2) += Area(i) * Zmn(i)
			Agreg(j, 3) += Qnet(i)
			Agreg(j, 4) += y(i)
			Agreg(j, 5) += Wt(i)
			Agreg(j, 6) += Wi(i)

			'c subtract internal advection terms
			k = Iout(i)
			If k > 0 And Iag(k) = j Then Agreg(j, 3) -= Math.Abs(Qadv(i))

			'c add advection from other segment groups to total load
			If k > 0 And Iag(k) <> j Then
				If Qadv(i) >= 0 Then
					Agreg(Iag(k), 4) += Qadv(i) * Conc(i)
				Else
					Agreg(Iag(i), 4) -= Qadv(i) * Conc(k)
				End If
			End If
		Next i

		'c add pipes
		For i As Integer = 1 To Npipe
			If Iag(Ito(i)) <> Iag(Ifr(i)) Then
				Agreg(Ito(i), 4) += Qpipe(i) * Conc(Ifr(i))
			End If
		Next

	End Sub

	Sub Balas(ByVal kseG As Double, ByVal k As Double, ByVal io As Integer)

		'c water and mass balances for segment kseg, component kcomp
		'c water balance in QT(), mass balance in BT()
		'c k=1 cl, k=2 p, k=3 tn

		'$include:'NET.inc'

		'C IO=1  USE OBSERVED POOL AND OUTFLOW CONCS
		'C IO=2  USE ESTIMATED POOL CONCS

		'c 1 = PRECIPITATION
		'C 2 = EXTERNAL INPUT
		'c 3 = EVAPORATION
		'c 4 = withdrawal / DISCHARGE
		'C 5 = NET RETENTION
		'C 6 = ADVECTIVE INPUT   includes pipe transfers
		'C 7 = ADVECTIVE OUTPUT  "
		'C 8 = DIFFUSIVE INPUT   "
		'C 12 = DIFFUSIVE OUTPUT  "
		'c 13 = net diffusive input "
		'c 14 = net diffusive output "
		'C 9 = TOTAL INPUT
		'C 10 = TOTAL OUTPUT
		'C 11 = STORAGE INCREASE
		'c 15 = Internal Load
		'c 16 = Gauged Tribs
		'c 17 = Nonpoint Watersheds
		'c 18 = Point Sources
		Dim j As Integer
		Dim cU, cD As Single

		Dim NtermS As Integer = 18
		For j = 1 To NtermS
			Bt(j) = 0
			Qt(j) = 0
		Next j

		'c segment concentration used in mass-balance
		Dim cF As Single = Cuse(Cobs(CInt(kseG), CInt(k)), Cest(CInt(kseG), CInt(k)), io) 'current segment

		'c advection and diffusion due to pipes
		For i As Double = 1 To Npipe

			If Ifr(CInt(i)) = kseG Then
				'c diffusion
				cD = Cuse(Cobs(Ito(CInt(i)), CInt(k)), Cest(Ito(CInt(i)), CInt(k)), io) 'downstream segment
				Qt(12) += Epipe(CInt(i))
				Bt(12) += Epipe(CInt(i)) * cF
				Qt(8) += Epipe(CInt(i))
				Bt(8) += Epipe(CInt(i)) * cD
				'c advection out
				Qt(7) += Qpipe(CInt(i))
				Bt(7) += Qpipe(CInt(i)) * cF

			ElseIf (Ito(CInt(i)) = kseG) Then 
				cU = Cuse(Cobs(Ifr(CInt(i)), CInt(k)), Cest(Ifr(CInt(i)), CInt(k)), io)
				'c advection in
				Qt(6) += Qpipe(CInt(i))
				Bt(6) += Qpipe(CInt(i)) * cU
				'c diffusion out & in
				Qt(12) += Epipe(CInt(i))
				Qt(8) += Epipe(CInt(i))
				Bt(12) += Epipe(CInt(i)) * cF 'out
				Bt(8) += Epipe(CInt(i)) * cU 'in
			End If
		Next i

		'internal load
		Bt(15) = Area(CInt(kseG)) * InternalLoad(CInt(kseG), Imap(CInt(k))) * 365.25

		'C external inflows and withdrawals
		For i As Double = 1 To NTrib
			If Iseg(CInt(i)) = kseG Then
				'c trib concentration
				cU = Conci(CInt(i), Imap(CInt(k)))
				'c withdrawal
				If Icode(CInt(i)) = 4 Then
					Qt(4) += Flow(CInt(i))
					If (cU <= 0 Or io = 1) Then cU = cF 'was io=2
					Bt(4) += Flow(CInt(i)) * cU
					'c internal load conc in mg/m2-day
					'           ElseIf (Icode(i) = 5) Then
					'                Bt(15) = Bt(15) + Area(kseg) * cu * 365.25
					'c diffusion inputs and outputs
				ElseIf Icode(CInt(i)) = 5 Then 
					Qt(8) += Flow(CInt(i))
					Bt(8) += Flow(CInt(i)) * cU
					Qt(12) += Flow(CInt(i))
					Bt(12) += Flow(CInt(i)) * cF
				Else
					j = 15 + Icode(CInt(i))
					'c external input
					If Icode(CInt(i)) = 2 Then
						Qt(j) += FlowL(CInt(i))
						Bt(j) += FlowL(CInt(i)) * Concil(CInt(i), Imap(CInt(k)))
					Else
						Qt(j) += Flow(CInt(i))
						Bt(j) += Flow(CInt(i)) * Conci(CInt(i), Imap(CInt(k)))
					End If
				End If
			End If
		Next i

		'c precip WHY DIVIDE BY AVERAGING PERIOD?
		Qt(1) = Area(CInt(kseG)) * P(2) / P(1)
		Bt(1) = Area(CInt(kseG)) * Atm(Imap(CInt(k)))

		'c evap  WHY DIVIDE BY AVERAGING PERIOD?
		Qt(3) = Area(CInt(kseG)) * P(3) / P(1)

		'c storage
		Qt(11) = Area(CInt(kseG)) * P(4) / P(1)
		Bt(11) = Qt(11) * cF

		'c downstream conc
		j = Iout(CInt(kseG))
		If j > 0 Then
			cD = Cuse(Cobs(j, CInt(k)), Cest(j, CInt(k)), io)
		Else
			cD = 0
		End If

		'c advective outflows
		If Qadv(CInt(kseG)) > 0 Or j <= 0 Then
			Qt(7) += Qadv(CInt(kseG))
			Bt(7) += Qadv(CInt(kseG)) * cF
		Else
			Qt(6) -= Qadv(CInt(kseG))
			Bt(6) -= Qadv(CInt(kseG)) * cD
		End If

		'c diffusive transport with downstream segment
		If j > 0 Then
			Qt(8) += Exch(CInt(kseG))
			Qt(12) += Exch(CInt(kseG))
			Bt(8) += Exch(CInt(kseG)) * cD
			Bt(12) += Exch(CInt(kseG)) * cF
		End If

		'c advective inflows and diffusive with upstream segment
		For i As Double = 1 To Nseg
			If Iout(CInt(i)) = kseG Then
				'c upstream conc
				cU = Cuse(Cobs(CInt(i), CInt(k)), Cest(CInt(i), CInt(k)), io)
				'c advection
				If Qadv(CInt(i)) >= 0 Then
					'c normal flow from upstream segment
					Qt(6) += Qadv(CInt(i))
					Bt(6) += Qadv(CInt(i)) * cU
				Else
					'c backflow
					Qt(7) -= Qadv(CInt(i))
					Bt(7) -= Qadv(CInt(i)) * cF
				End If
				'c diffusion
				Qt(8) += Exch(CInt(i))
				Qt(12) += Exch(CInt(i))
				Bt(8) += Exch(CInt(i)) * cU
				Bt(12) += Exch(CInt(i)) * cF
			End If
		Next i

		'c net diffusive transport terms

		If Bt(8) > Bt(12) Then
			Bt(13) = Bt(8) - Bt(12)
		Else
			Bt(14) = Bt(12) - Bt(8)
		End If

		'c External Inflow
		Qt(2) = Qt(16) + Qt(17) + Qt(18)
		Bt(2) = Bt(16) + Bt(17) + Bt(18)

		'C Total Inflow
		'    Internal+ EXTERNAL  ADVECTIVE  PRECIP   + net DIFFUSIVE
		Qt(9) = Qt(2) + Qt(6) + Qt(1) + Qt(13)
		Bt(9) = Bt(15) + Bt(2) + Bt(6) + Bt(1) + Bt(13)

		'C Total Outflow
		'C                   GAUGED    ADVECTIVE   net DIFFUSIVE
		Qt(10) = Qt(4) + Qt(7) + Qt(14)
		Bt(10) = Bt(4) + Bt(7) + Bt(14)

		'C Retention by Difference
		'C                    INPUT     OUTFLOW     EVAP     STORAGE
		Qt(5) = Qt(9) - Qt(10) - Qt(3) - Qt(11)
		Bt(5) = Bt(9) - Bt(10) - Bt(3) - Bt(11)


	End Sub

	Sub Prelim()
		Dim NOP As Double

		'c preliminary calculations following input of new case


		'      SegName(Nseg + 1) = "AREA-WTD MEAN"
		'      SegName(Nseg + 2) = "MODEL SEGMENTS"
		'      TribName(N + 1) = "TRIBUTARIES"

		'c check model options
		For i As Integer = 1 To CInt(NOP)
			If Iop(i) < 0 Or Iop(i) > Mop(i) Then Elist(1, "Invalid Code for Option " & OptionName(i, Iop(i) + 1))
		Next i

		'c period length

		If P(1) <= 0 Then Elist(1, "Invalid Averaging Period = " & P(1))

		'c calculate nonpoint loads
		Nps()

		'c adjust for availability factors
		Avail()

		'c check tributary records and rescale flows
		For i As Integer = 1 To NTrib
			'c diffusive source
			If Icode(i) = 5 Then
				Darea(i) = 0
				'c internal loads
				''        ElseIf (Icode(i) = 5) Then
				'                Flow(i) = 0
				'                CvFlow(i) = 0
				'                Darea(i) = 0
				'c type=2 use nps model
			ElseIf Icode(i) = 2 Then 
				If FlowL(i) = 0 Then Elist(0, "Warning: No Flow for Trib " & i & " Predicted from Land Use")
				'                Flow(i) = FlowL(i)
				'                CvFlow(i) = CvFlowL(i)
				'                For iv = 1 To 7
				'                   Conci(i, iv) = Concil(i, iv)
				'                   CvCi(i, iv) = CvCil(i, iv)
				'                   Next
				If Flow(i) > 0 Then Elist(0, "Warning: Flow for Trib " & i & " Predicted from Land Use - Specified Flow Ignored")
			End If

			'invalid type code
			If Icode(i) < 1 Or Icode(i) > 5 Then Elist(1, "Invalid Type Code for Trib " & i)
			'invalid segment
			If Iseg(i) < 0 Or Iseg(i) > Nseg Then Elist(1, "Invalid Segment Code for Trib " & i)
			'outflow segment = 0
			If Iseg(i) = 0 Then Elist(0, "Warning: Segment Code = 0 for Trib " & i & " - Data Ignored")
			'c no flow
			If Flow(i) <= 0 And Icode(i) <> 5 And Icode(i) <> 2 Then Elist(0, "Warning: No Flow for Trib " & i)
		Next i

		'c no segments
		If Nseg <= 0 Then
			Elist(1, "No Segments Defined")
			Exit Sub
		End If

		For i As Integer = 1 To Nseg
			If Iout(i) < 0 Or Iout(i) > Nseg Or Iout(i) = i Then Elist(1, "Seg " & i & " Discharges to Invalid Seg " & CStr(Iout(i)))
			If Iag(i) < 1 Or Iag(i) > Nseg Then Elist(1, "Invalid Segment Group Assigned to Segment " & i)
			If Slen(i) * Area(i) * Zmn(i) <= 0 Then Elist(1, "Invalid Length, Area, or Depth for Segment " & i)

			'c segment calibration factors
			For j As Integer = 1 To 9
				If (Cal(i, j) < 0) Then Elist(1, "Negative Calibration Factor for Segment " & i)
			Next j

		Next i

		'c global calibration factors
		For j As Integer = 1 To NXk
			If Xk(j) < 0 Then Elist(1, "Negative Value for Model Coefficient: " & XkName(j))
		Next j

		'c check channels
		For i As Integer = 1 To Npipe
			If Ifr(i) > Nseg Or Ifr(i) <= 0 Or Ito(i) > Nseg Or Ito(i) <= 0 Or Qpipe(i) < 0 Or Epipe(i) < 0 Then Elist(1, "Invalid Specifications for Channel " & i & " " & PipeName(i))
		Next i

		'c calculate mixed layer depths
		Mixed()

		'c calc turbidities and composite nutrient concs
		x(1) = 0
		x(2) = 0
		For j As Integer = 1 To Nseg

			' check non-algal turbidities
			Turb(j) = Turbi(j)
			CvTurb(j) = CvTurbi(j)
			If Turb(j) <= 0 Then
				If (Iop(4) < 3 And Iop(4) > 0 Or Iop(5) = 1) Then Elist(1, "Missing Non-Algal Turbidity for Segment " & j)
			End If
			x(1) += Turb(j) * Area(j)
			x(2) += Turb(j) * Area(j) * CvTurb(j)

			'C COMPOSITE NUTRIENT CONC
			Cobs(j, 10) = 0
			CvCobs(j, 10) = 0
			If Cobs(j, 2) * Cobs(j, 3) > 0 Then
				x(3) = (MAx(Cobs(j, 3), 160) - 150) / 12
				Cobs(j, 10) = 1 / Math.Sqrt(1 / Cobs(j, 2) ^ 2 + 1 / x(3) ^ 2)
				x(4) = 1 / (1 + x(3) / Cobs(j, 2))
				CvCobs(j, 10) = CvCobs(j, 2) * (1 - x(4)) + CvCobs(j, 3) * x(4)
			End If

		Next j 'next segment

		Turb(Nseg + 1) = 0
		CvTurb(Nseg + 1) = 0
		If (Area(Nseg + 1) > 0) Then Turb(Nseg + 1) = x(1) / Area(Nseg + 1)
		If x(1) > 0 Then CvTurb(Nseg + 1) = x(2) / x(1)

		'C COMPUTE AREA-WEIGHTED OBSERVED CONCS AND CV'S
		'C ASSUME CV'S CORRELATED ACROSS STATIONS

		For j As Integer = 1 To 10 'j Parameter Loop for segment i
			x(1) = 0
			x(2) = 0
			x(3) = 0
			Cobs(Nseg + 1, j) = 0 'clear diagnostics
			CvCobs(Nseg + 1, j) = 0
			For i As Integer = 1 To Nseg
				If Cobs(i, j) > 0 Then
					x(1) += Area(i)
					x(2) += Area(i) * Cobs(i, j)
					x(3) += Area(i) * CvCobs(i, j) * Cobs(i, j)
				End If
			Next i

			If (x(1) > 0) Then Cobs(Nseg + 1, j) = x(2) / x(1)
			If (x(2) > 0) Then CvCobs(Nseg + 1, j) = x(3) / x(2)
		Next j

		SegName(Nseg + 1) = "Area-Wtd Mean"

		'c initialize estimated concentrations ???

		For j As Integer = 1 To 3
			For i As Integer = 1 To Nseg + 1
				Cest(i, j) = Cobs(i, j)
			Next i
		Next j

	End Sub

	Sub Nps()
		Dim qq As Double
		'c calculate flows and loads based upon land use
		'c    calculate watershed flows and concentrations
		'c  flowl(N),concil(n,),cvcil(n,),dareal

		Dim sa, sq, sq2, w, w2 As Single

		For i As Integer = 1 To NTrib
			If Icode(i) = 2 Then 'check added in conversion
				sa = 0
				sq = 0
				sq2 = 0
				For iC As Integer = 1 To NVariables
					y(iC) = 0
					x(iC) = 0
				Next iC

				'c loop through categories
				For iu As Integer = 1 To NCAT
					sa += Warea(i, iu)
					qq = Warea(i, iu) * Ur(iu)
					sq += qq
					sq2 += (qq * CvUr(iu)) ^ 2

					For iC As Integer = 1 To NVariables
						w = qq * Uc(iu, iC)
						w2 = w * w * (CvUc(iu, iC) ^ 2 + CvUr(iu) ^ 2)
						x(iC) += w
						y(iC) += w2
					Next iC
				Next iu

				Dareal(i) = sa
				FlowL(i) = sq
				CvFlowL(i) = Ratv(Math.Sqrt(sq2), sq)
				For iC As Integer = 1 To NVariables
					Concil(i, iC) = Ratv(x(iC), sq)
					If x(iC) <= 0 Then
						CvCil(i, iC) = 0
					Else
						y(iC) -= sq2 * (Concil(i, iC) ^ 2)
						CvCil(i, iC) = Math.Sqrt(MAx(0, y(iC))) / x(iC)
					End If
				Next iC

			End If
		Next i

	End Sub

	Sub Mixed()
		'c compute mixed layer depths & mean total depth over all segments

		Zmx(Nseg + 1) = 0
		Area(Nseg + 1) = 0
		Zmn(Nseg + 1) = 0
		For j As Double = 1 To Nseg
			Area(Nseg + 1) += Area(CInt(j))
			Zmn(Nseg + 1) += Area(CInt(j)) * Zmn(CInt(j))
			Zmx(CInt(j)) = Zmxi(CInt(j))
			CvZmx(CInt(j)) = CvZmxi(CInt(j))
			If Zmx(CInt(j)) <= 0 Then Elist(0, "Warning: Mixed Layer Depth = 0 in Segment " & j)
			If Zmx(CInt(j)) > Zmn(CInt(j)) Then Elist(0, "Warning: Mixed Layer Depth > Mean Depth in Segment " & j)
			Zmx(Nseg + 1) += Area(CInt(j)) * Zmx(CInt(j))
		Next j
		Zmn(Nseg + 1) = Ratv(Zmn(Nseg + 1), Area(Nseg + 1))
		Zmx(Nseg + 1) = Ratv(Zmx(Nseg + 1), Area(Nseg + 1))

	End Sub
	Function ZmixEst(ByVal z As Double) As Double
		'c estimate mixed layer depth from mean depth
		Dim zl As Single
		If z <= 2 Then
			Return z
		Else
			zl = Math.Log(MIn(z, 40)) / 2.303
			Return MIn(10 ^ (-0.06 + 1.36 * zl - 0.47 * zl * zl), z)
		End If

	End Function

	Sub Avail()

		'C ADJUST LOADS AND ERRORS FOR P AND N AVAILABILITY FACTORS
		'C ASSUME TP/OP AND TN/IN CORRELATED

		Dim kmaP As Integer

		' p availability factors
		If Iop(10) = 0 Or Iop(2) = 2 Or (Iop(10) = 1 And Iop(2) <> 1) Then
			VariableName(6) = "TOTAL P"
			Fav(2) = 1
			Fav(4) = 0
		Else
			If Xk(15) = 0 Then
				VariableName(6) = "TOTAL P"
			Else
				VariableName(6) = "AVAILABLE P"
				If Iop(2) > 1 Then Elist(0, "Warning: Availability Factors Applied to Phosphorus Loads")
			End If
			Fav(2) = Xk(14)
			Fav(4) = Xk(15)
		End If

		'n availability factors
		If Iop(10) = 0 Or Iop(3) = 2 Or (Iop(10) = 1 And Iop(3) <> 1) Then
			VariableName(7) = "TOTAL N"
			Fav(3) = 1
			Fav(5) = 0
		Else
			If Xk(17) = 0 Then
				VariableName(7) = "TOTAL N"
			Else
				VariableName(7) = "AVAILABLE N"
				If Iop(3) > 1 Then Elist(0, "Warning: Availability Factors Applied to Nitrogen Loads")
			End If
			Fav(3) = Xk(16)
			Fav(5) = Xk(17)


		End If


		For k As Integer = 2 To 3
			If Iop(k) > 0 Then
				kmaP = Imap(k)

				'internal loads - ignore availability factors
				For i As Integer = 1 To Nseg
					InternalLoad(i, kmaP) = InternalLoad(i, k)
					CvInternalLoad(i, kmaP) = CvInternalLoad(i, k)
				Next i

				'C set availability factors
				If Fav(k) + Fav(k + 2) <= 0 Then Elist(1, "Invalid Availability Factors for " & VariableName(k))

				'atmospheric loads
				CvAtm(kmaP) = CvAtm(k) * Atm(k) * Fav(k) + CvAtm(k + 2) * Atm(k + 2) * Fav(k + 2)
				Atm(kmaP) = Atm(k) * Fav(k) + Atm(k + 2) * Fav(k + 2)
				CvAtm(kmaP) = Ratv(CvAtm(kmaP), Atm(kmaP))
				If Atm(k + 2) <= 0 And Fav(k + 2) > 0 Then Elist(0, "Warning: No Atmospheric Load for " & VariableName(k + 2))

				'C EXTERNAL LOADS AND FLOWS
				For i As Integer = 1 To NTrib

					'outflow stream or diffusive
					If Icode(i) >= 4 Then
						CvCi(i, kmaP) = CvCi(i, k)
						Conci(i, kmaP) = Conci(i, k)
						CvCil(i, kmaP) = CvCil(i, k)
						Concil(i, kmaP) = Concil(i, k)
					Else

						'c inflow stream
						CvCi(i, kmaP) = CvCi(i, k) * Conci(i, k) * Fav(k) + CvCi(i, k + 2) * Conci(i, k + 2) * Fav(k + 2)
						Conci(i, kmaP) = Conci(i, k) * Fav(k) + Conci(i, k + 2) * Fav(k + 2)
						CvCi(i, kmaP) = Ratv(CvCi(i, kmaP), Conci(i, kmaP))

						For j As Integer = k To k + 2 Step 2
							If Fav(j) > 0 Then
								If Icode(i) <> 2 Then
									If Conci(i, j) <= 0 Then Elist(0, "Warning: Inflow Conc <=0 for Trib " & i & " " & VariableName(j))
								Else
									If Concil(i, j) <= 0 Then Elist(0, "Warning: Inflow Conc <=0 for Non-Point Inflow Trib " & i & " " & VariableName(j))
								End If
							End If
						Next j

						'c Nps
						CvCil(i, kmaP) = CvCil(i, k) * Concil(i, k) * Fav(k) + CvCil(i, k + 2) * Conci(i, k + 2) * Fav(k + 2)
						Concil(i, kmaP) = Concil(i, k) * Fav(k) + Concil(i, k + 2) * Fav(k + 2)
						CvCil(i, kmaP) = Ratv(CvCil(i, kmaP), Concil(i, kmaP))
					End If

				Next i

			End If
		Next k

	End Sub

	Sub Coefs(ByVal iC As Integer, ByRef C0 As Double, ByRef ICONC As Double, ByRef IDEPTH As Integer, ByVal jaG As Double)
		Dim Vload As Double

		'C COMPUTE DECAY COEFFICIENTS:  C0, ICONC, IDEPTH FOR SEGMENT GROUP JAG

		'C                                 ICONC      IDEPTH
		'C  DECAY TERM =  VOLUME * C0  CONC      DEPTH

		'C SEG GROUP VECTOR AGREG(JAG,K), JAG=SEGMENT GROUP REFERENCE, K=TERM=
		'C      1 = TOTAL AREA   2 = TOTAL VOLUME     3 = NET INFLOW (IN+PREC-EVAP)
		'C      4 = TOTAL LOAD   5 = TRIB TOTAL LOAD  6 = TRIB INORG LOAD
		Dim ratiO, rhO As Single

		'c Initialize

		Dim ofloW As Single = MAx(0, Agreg(CInt(jaG), 3))

		'C RESTRICT OVERFLOW RATE QS TO RANGE OF CE DATA SET < 4 M/YR

		IDEPTH = 0
		ICONC = 1
		C0 = 0
		If Agreg(CInt(jaG), 1) <= 0 Then Exit Sub
		Dim qS As Single = MAx(ofloW / Agreg(CInt(jaG), 1), Xk(11))
		If Agreg(CInt(jaG), 2) > 0 Then
			Vload = Agreg(CInt(jaG), 4) / Agreg(CInt(jaG), 2)
		Else
			Vload = 0
		End If

		'       GO TO (5,7,100),IC

		'C COMPONENT 2 = PHOSPHORUS
		If iC = 2 Then

			'       GO TO (10,15,20,30,40,50,60),J


			Select Case Iop(iC)
				'C SECOND ORDER QS - AVAILABLE P
				Case 1
					ICONC = 2
					C0 = 0.17 * qS / (qS + 13.3)

				Case 2
					'C SECOND ORDER / QS - DECAY RATE

					ICONC = 2
					If Agreg(CInt(jaG), 5) <= 0 Or Agreg(CInt(jaG), 6) <= 0 Then
						Ier = 1
						Elist(1, "Invalid Inorganic / Total Load for Segment Group " & jaG)
						Exit Sub
					End If
					ratiO = Agreg(CInt(jaG), 6) / Agreg(CInt(jaG), 5)
					C0 = 0.056 * qS / ((qS + 13.3) * ratiO)

					'C SECOND ORDER / FIXED
				Case 3
					C0 = 0.1
					ICONC = 2

					'c CANFIELD / BACHMAN - reservoirs
				Case 4
					If Vload > 0 Then C0 = 0.114 * Vload ^ 0.589

					'c VOLLENWEIDER/LARSEN MERCIER
				Case 5
					If Agreg(CInt(jaG), 2) > 0 Then
						rhO = ofloW / Agreg(CInt(jaG), 2)
					Else
						rhO = 0
					End If
					If rhO > 0 Then C0 = rhO ^ 0.5

					'C SIMPLE FIRST ORDER
				Case 6
					C0 = 1

					'C FIRST ORDER SETTLING
				Case 7
					C0 = 1
					IDEPTH = -1

					'c CANFIELD / BACHMAN - lakes
				Case 8
					If Vload > 0 Then C0 = 0.162 * Vload ^ 0.458

					'c CANFIELD / BACHMAN - lakes+ reservoirs
				Case 9
					If Vload > 0 Then C0 = 0.129 * Vload ^ 0.549


			End Select

			'C NITROGEN MODELS
		ElseIf iC = 3 Then 

			'        GO TO (110,115,120,130,140,50,60),J


			Select Case Iop(iC)
				Case 1
					'C SECOND ORDER / QS AVAILABLE N
					ICONC = 2
					C0 = 0.0045 * qS / (qS + 7.2)

				Case 2
					'C SECOND ORDER / QS RATIO
					ICONC = 2
					If Agreg(CInt(jaG), 5) <= 0 Or Agreg(CInt(jaG), 6) <= 0 Then
						Ier = 1
						Elist(1, "Invalid Inorganic / Total Load for Seg Group " & jaG)
						Exit Sub
					End If

					ratiO = Agreg(CInt(jaG), 6) / Agreg(CInt(jaG), 5)
					C0 = 0.0035 * qS * (ratiO ^ (-0.59)) / (qS + 17.3)

				Case 3
					'C SECOND ORDER / FIXED
					C0 = 0.00315
					ICONC = 2

				Case 4
					'C BACHMAN VOLUMETRIC LOAD
					If Agreg(CInt(jaG), 2) > 0 Then
						Vload = Agreg(CInt(jaG), 4) / Agreg(CInt(jaG), 2)
					Else
						Vload = 0
					End If
					If Vload > 0 Then C0 = 0.0159 * Vload ^ 0.59

					'C BACHMAN FLUSHING RATE
				Case 5
					If Agreg(CInt(jaG), 2) > 0 Then
						rhO = ofloW / Agreg(CInt(jaG), 2)
					Else
						rhO = 0
					End If
					If (rhO > 0) Then C0 = 0.693 * rhO ^ 0.55

			End Select
		End If

	End Sub

	Sub ResponseModels()
		Dim bX, CW, g As Double
		Dim Iter As Integer
		Dim j, jaG As Double

		'C EUTROPHICATION RESPONSE MODELS

		'C INPUT:  1 = CONSERVATIVE SUB, 2 = TOTAL P  3 = TOTAL N
		'C OUTPUT: 4 = CHLA   5 = SECCHI  6 = ORGN  7 = PP
		'C OUTPUT: 8 = HODV   9 = MODV   10=XPN

		'C VECTOR X CONTAINS WTD-MEAN CHL-A FOR EACH SEG GROUP (USED FOR HOD)
		'C VECTOR Y CONTAINS AREA FOR EACH SEGMENT GROUP         ""

		Dim Xpn, Zu, zl, Flush As Single


		For i As Double = 1 To NSMAX
			y(CInt(i)) = 0
			x(CInt(i)) = 0
		Next i

		For i As Double = 1 To Nseg
			'c Initialize
			For j = 4 To 12 'Chl through diagnostics
				Cest(CInt(i), CInt(j)) = 0
			Next j

			'c branch out if zero volume segment

			If Area(CInt(i)) * Zmn(CInt(i)) <= 0 Then GoTo S100

			'C SET ESTIMATED = OBSERVED IF NO CONSERVATIVE SUBST, P OR N SUBMODEL
			For j = 1 To 3
				If Iop(CInt(j)) <= 0 Then Cest(CInt(i), CInt(j)) = Cobs(CInt(i), CInt(j))
			Next j

			'C COMPOSITE NUTRIENT CONC

			If Cest(CInt(i), 2) > 0 And Cest(CInt(i), 3) > 0 Then
				Xpn = Cest(CInt(i), 3)
				If Xpn < 160 Then Xpn = 160
				Xpn = (Xpn - 150) / 12
				Cest(CInt(i), 10) = 1 / Math.Sqrt(1 / Cest(CInt(i), 2) ^ 2 + 1 / Xpn ^ 2)
			End If

			'c CHLOROPHYLL - A And SECCHI
			Iter = 0
			jaG = Iag(CInt(i))
			Flush = Xk(12) * MAx(Agreg(CInt(jaG), 3), 0) / Agreg(CInt(jaG), 2)

			If Cest(CInt(i), 2) <= 0 Then GoTo S100 'end if phosphorus not predicted


			Select Case Iop(4)
				Case 0
					Cest(CInt(i), CInt(j)) = 0

				Case 1 To 2

					Zu = Zmx(CInt(i))
S11:
					zl = Zu

					If Zu <= 0 Then
						Elist(1, "Missing Mixed Layer Depth in Segment " & i)
						Exit Sub
					End If

					'C MODEL 1:  N , P , LIGHT, T
					If Iop(4) = 1 Then
						If Cest(CInt(i), 10) <= 0 Then
							Elist(1, "Invalid Chlorophyll-a Model Option (N & P Required)")
							Exit Sub ' no composite nutrient
						End If
						bX = (Cest(CInt(i), 10) ^ 1.33) / 4.31
						g = Zu * (0.14 + 0.0039 * Flush)
					Else
						'C MODEL 2:  P , LIGHT, T
						bX = (Cest(CInt(i), 2) ^ 1.37) / 4.88
						g = Zu * (0.19 + 0.0042 * Flush)
					End If

					'C CHECK FOR CONVERGENCE ZMIX/SECCHI >=2

					Cest(CInt(i), 4) = Xk(4) * Cal(CInt(i), 4) * bX / ((1 + Xk(10) * bX * g) * (1 + g * Turb(CInt(i))))
					Cest(CInt(i), 5) = Cal(CInt(i), 5) * Xk(5) / (Xk(9) * Cest(CInt(i), 4) + Turb(CInt(i)))

					'c disabled 4/8/95
					If Cest(CInt(i), 4) <= 0 Or Cest(CInt(i), 5) <= 0 Then GoTo S51

					Iter += 1
					'If Iter > 1 Then MsgBox( "Seg, Iter, chla" & i & " " & Iter & " " & Cest(i, 4)
					If Zu / Cest(CInt(i), 5) >= 2 Or Iter > 10 Then GoTo S51
					Zu = 2 * Cest(CInt(i), 5)

					If (Math.Abs(zl / Zu - 1) > 0.01) Then GoTo S11

					'C MODEL 3: P,N  LOW-TURBIDITY

				Case 3
					If Cest(CInt(i), 10) <= 0 Then Exit Sub
					Cest(CInt(i), 4) = 0.2 * Xk(4) * Cal(CInt(i), 4) * (Cest(CInt(i), 10) ^ 1.25)

					'C MODEL 4: P  LINEAR
				Case 4
					Cest(CInt(i), 4) = 0.28 * Xk(4) * Cal(CInt(i), 4) * Cest(CInt(i), 2)

					'C MODEL 5: JONES / BACHMAN ET AL

				Case 5
					Cest(CInt(i), 4) = 0.081 * Xk(4) * Cal(CInt(i), 4) * (Cest(CInt(i), 2) ^ 1.46)

					'model 6 carlson tsi

				Case 6
					Cest(CInt(i), 4) = Xk(4) * Cal(CInt(i), 4) * 0.087 * (Cest(CInt(i), 2) ^ 1.45)

			End Select

S51:
			If Cest(CInt(i), 4) > 0 Then
				x(CInt(jaG)) += Area(CInt(i)) * Cest(CInt(i), 4)
				y(CInt(jaG)) += Area(CInt(i))

			ElseIf Iop(4) > 0 Then 
				Elist(1, "Invalid Solution for Chlorophyll-a in Segment " & i)
			End If

			'C SECCHI DEPTH

			Cest(CInt(i), 5) = 0
			'        j = Iop(5)
			'        GO TO (551,552,553), J
			'        GoTo 555


			Select Case Iop(5)
				Case 0
					Cest(CInt(i), 5) = 0

					' SECCHI MODEL 1 - VS. TURBIDITY AND CHL-A

				Case 1
					If (Cest(CInt(i), 4) > 0 And Turb(CInt(i)) > 0) Then Cest(CInt(i), 5) = Cal(CInt(i), 5) * Xk(5) / (Xk(10) * Cest(CInt(i), 4) + Turb(CInt(i)))

					' SECCHI MODEL 2 - REGRESSION VS. COMPOSITE NUTRIENT

				Case 2
					If (Cest(CInt(i), 10) > 0) Then Cest(CInt(i), 5) = Xk(5) * 16.2 * Cal(CInt(i), 5) / Cest(CInt(i), 10) ^ 0.79

					' SECCHI MODEL 3 - REGRESSION VS. P

				Case 3
					If (Cest(CInt(i), 2) > 0) Then Cest(CInt(i), 5) = Xk(5) * 17.8 * Cal(CInt(i), 5) / (Cest(CInt(i), 2) ^ 0.76)

				Case 4
					'model 4 carlson tsi
					If Cest(CInt(i), 2) > 0 Then Cest(CInt(i), 5) = Xk(5) * Cal(CInt(i), 5) * 48 / Cest(CInt(i), 2)

			End Select


			If Cest(CInt(i), 4) > 0 And Turb(CInt(i)) > 0 Then

				'C ORGANIC N

				Cest(CInt(i), 6) = Cal(CInt(i), 6) * Xk(6) * (157 + 22.8 * Cest(CInt(i), 4) + 75.3 * Turb(CInt(i)))

				'C PARTICULATE P

				Cest(CInt(i), 7) = -4.1 + 1.78 * Cest(CInt(i), 4) + 23.7 * Turb(CInt(i))
				Cest(CInt(i), 7) = Cal(CInt(i), 7) * Xk(7) * MAx(Cest(CInt(i), 7), 1)

			End If

S100:

			'segment loop
		Next i

		'C HODV AND MODV BASED ON AREA-WEIGHTED CHLA IN SEGMENT GROUP

		For i As Double = 1 To Nseg
			jaG = Iag(CInt(i))
			If y(CInt(jaG)) > 0 Then

				'C WTD MEAN CHLA FOR AGGREGATE
				'Y is total area for segment group jaG
				'X is area-weighted mean CHL for segment group jag
				CW = x(CInt(jaG)) / y(CInt(jaG)) 'Areal CHL conc.

				If Zhyp(CInt(i)) * CW > 0 Then
					'c HODV
					Cest(CInt(i), 8) = Cal(CInt(i), 8) * Xk(8) * 240 * Math.Sqrt(CW) / Zhyp(CInt(i))
					'c MODV
					Cest(CInt(i), 9) = Xk(9) * Cal(CInt(i), 9) * 0.4 * Cest(CInt(i), 8) * Zhyp(CInt(i)) ^ 0.38
				End If
			End If

			'After Cload, diagnostic variables (x & y) will contain
			'measured (x) & predicted (y) variables for segment i

			Cload(i)

			For k As Double = 11 To NDiagnostics
				Cest(CInt(i), CInt(k)) = y(CInt(k))
				Cobs(CInt(i), CInt(k)) = x(CInt(k))
			Next k

		Next i

		'C AREA-WEIGHTED MEANS OVER ALL SEGMENTS STORED IN CEST(NSEG+1,...)
		For j = 1 To NDiagnostics
			Cest(Nseg + 1, CInt(j)) = 0
			Cobs(Nseg + 1, CInt(j)) = 0
			x(1) = 0
			y(1) = 0
			For i As Double = 1 To Nseg
				If Cest(CInt(i), CInt(j)) > 0 Then
					Cest(Nseg + 1, CInt(j)) += Cest(CInt(i), CInt(j)) * Area(CInt(i))
					x(1) += Area(CInt(i))
				End If
				If Cobs(CInt(i), CInt(j)) > 0 Then
					Cobs(Nseg + 1, CInt(j)) += Cobs(CInt(i), CInt(j)) * Area(CInt(i))
					y(1) += Area(CInt(i))
				End If
			Next i
			If x(1) > 0 Then Cest(Nseg + 1, CInt(j)) /= x(1)
			If y(1) > 0 Then Cobs(Nseg + 1, CInt(j)) /= y(1)
		Next j

	End Sub

	Sub MassBalanceTerms()
		Dim dd As Single
		Dim jseG As Double

		'C COMPUTE GROSS MASS BALANCE TERMS FOR WATER AND NUTRIENTS

		'$include:'NET.inc'
		'c term(i, j)

		'c i = COMPONENT
		'C 1=WATER, 2=CONS, 3=AVAIL P, 4=AVAIL N
		'c
		'C J= MASS BALANCE TERMS CONSIDERED
		'c 1 = PRECIPITATION
		'C 2 = EXTERNAL INPUT
		'c 3 = EVAPORATION
		'C 5 = NET RETENTION   (=ERROR FOR WATER BALANCE)
		'C 9 = TOTAL INPUT
		'C10 = TOTAL OUTFLOW
		'C11 = INCREASE IN STORAGE
		'c12=diffusive out
		'c13=net diffusive in
		'c14=net diffusive out
		'c 4 = gauged outflow
		'c 7 = advective outflow
		'c 8=diffusive inflow
		'c 15 = Internal
		'c 16 = trib
		'c 17 = nonpoint
		'c 18 = Point
		'c 19 = diffusion
		Dim j As Integer
		Dim cU, cs As Single


		'c Initialize
		For j = 1 To 19
			For k As Integer = 1 To 4
				Term(k, j) = 0
			Next k
		Next j

		'C INFLOWS TERM=2 AND gauged OUTFLOWS TERM=4
		For i As Integer = 1 To NTrib

			If Iseg(i) > 0 Then

				If Icode(i) = 4 Then
					j = 4
					'         ElseIf Icode(i) = 5 Then
					'             j = 15
				ElseIf Icode(i) = 5 Then 
					j = 8
					Term(1, 12) += Flow(i)
				Else
					j = 15 + Icode(i)
				End If
				If Icode(i) = 2 Then
					Term(1, j) += FlowL(i)
				Else
					Term(1, j) += Flow(i)
				End If
				jseG = Iseg(i)

				For k As Integer = 1 To 3

					cU = Conci(i, Imap(k))
					cs = Cuse(Cobs(CInt(jseG), k), Cest(CInt(jseG), k), Iop(11))
					'      If Icode(i) = 5 Then
					'         Term(k + 1, j) = Term(k + 1, j) + Area(jseG) * 365.25 * cu
					If Icode(i) = 5 Then
						'c diffusve in , & out
						Term(k + 1, 8) += Flow(i) * cU
						Term(k + 1, 12) += Flow(i) * cs
					ElseIf Icode(i) = 4 Then 
						Term(k + 1, j) += Flow(i) * cs
					ElseIf Icode(i) = 2 Then 
						Term(k + 1, j) += FlowL(i) * Concil(i, Imap(k))
					Else
						Term(k + 1, j) += Flow(i) * cU
					End If
				Next k
			End If
		Next i

		'c net diffusive terms
		For k As Integer = 1 To 4
			dd = Term(k, 8) - Term(k, 12)
			If dd > 0 Then
				Term(k, 13) = dd
			Else
				Term(k, 14) = -dd
			End If
		Next k

		For j = 1 To Nseg
			'           'precip = 1
			Term(1, 1) += Area(j) * P(2) / P(1) 'why divide by Averaging Period?
			'           'Evap = 3
			Term(1, 3) += Area(j) * P(3) / P(1)
			'           'Storage Increase =11
			Term(1, 11) += Area(j) * P(4) / P(1)
			'           'Advective outflow=7
			If Iout(j) = 0 Then
				Term(1, 7) += Qadv(j)
				For k As Integer = 1 To 3
					cU = Cuse(Cobs(j, k), Cest(j, k), Iop(11))
					Term(k + 1, 7) += Qadv(j) * cU
				Next k
			End If
		Next j

		'C MASS BALANCES  CONS, P , N

		For k As Integer = 1 To 3

			'c precip = 1
			Term(k + 1, 1) = Area(Nseg + 1) * Atm(Imap(k))

			'C INCREASE IN STORAGE  = 11 & internal load = 15
			For j = 1 To Nseg
				cU = Cuse(Cest(j, k), Cobs(j, k), Iop(11))
				Term(k + 1, 11) += cU * Area(j) * P(4) / P(1)
				Term(k + 1, 15) += InternalLoad(j, Imap(k)) * Area(j) * 365.25
			Next j

		Next k

		'C TOTAL INPUTS=9 AND NET=5  outputs=10

		For k As Integer = 1 To 4
			'c external inputs
			Term(k, 2) = Term(k, 16) + Term(k, 17) + Term(k, 18)
			'c outflows
			Term(k, 10) = Term(k, 7) + Term(k, 4) + Term(k, 14)
			'c total inputs
			Term(k, 9) = Term(k, 2) + Term(k, 1) + Term(k, 15) + Term(k, 13)
			'c net
			Term(k, 5) = Term(k, 9) - Term(k, 10) - Term(k, 11) - Term(k, 3)
		Next k


	End Sub

	Sub Hydrau(ByVal i As Double)

		'c computes segment hydraulic properties segment i

		'C check for zero volume segment


		Dim w As Single = 0
		Dim xsec As Single = 0
		Dim vel As Single = 0
		Dim dnum As Single = 0
		Dim thyd As Single = 0
		Dim excha As Single = 0
		Dim dispe As Single = 0
		Dim qS As Single = 0

		If Slen(CInt(i)) * Area(CInt(i)) * Zmn(CInt(i)) > 0 Then

			'c mean width

			w = Area(CInt(i)) / Slen(CInt(i))

			'c CROSS-SECTION  KM*M

			xsec = Area(CInt(i)) * Zmn(CInt(i)) / Slen(CInt(i))

			'C VELOCITY  KM/YR

			vel = Qnet(CInt(i)) / xsec

			' OVERFLOW RATE M/YR

			qS = Qnet(CInt(i)) / Area(CInt(i))

			' NUMERIC DISPERSION

			dnum = MAx(Slen(CInt(i)) * vel / 2, 0)

			' RESIDENCE TIME

			thyd = 0
			If vel > 0 Then thyd = Slen(CInt(i)) / vel

			' MINIMUM VELOCITY for exchange rate computation

			vel = MAx(vel, 1)

			'Dispersion & Exchange Rates

			'C INPUT EXCHANGE
			If Iop(6) = 3 Then
				excha = Xk(1) * Cal(CInt(i), 1)
				dispe = 0

				'C FISCHER DISPERSION  KM2/YR
			ElseIf Iop(6) = 1 Or Iop(6) = 4 Then 
				dispe = Xk(1) * Cal(CInt(i), 1) * 100 * w * w * vel / (Zmn(CInt(i)) ^ 0.84)

				'C CONSTANT DISPERSION   1000 KM2/YR
			ElseIf Iop(6) = 2 Or Iop(6) = 5 Then 
				dispe = Xk(1) * Cal(CInt(i), 1) * 1000

			End If

			'C EXCHANGE RATE
			If Iop(6) <> 3 Then
				excha = dispe
				If Iop(6) <= 2 Then excha = dispe - dnum
				If excha < 0 Then excha = 0
				excha = excha * xsec / Slen(CInt(i))
			End If

			'C SET EXCHANGE RATE TO 0. IF SEGMENT DISCHARGES OUT OF NETWORK

		End If

		If Iout(CInt(i)) = 0 Then excha = 0

		'c check for type=5 trib (estuary)
		For j As Double = 1 To NTrib
			If Iseg(CInt(j)) = i And Icode(CInt(j)) = 5 Then excha += Flow(CInt(j))
		Next j

		'C assign hydraulic variables
		x(1) = w
		x(2) = xsec
		x(3) = thyd
		x(4) = qS
		x(5) = vel
		x(6) = dispe
		x(7) = dnum
		x(8) = excha

	End Sub
	Sub DiagnosticVariables(ByVal x() As Double, ByVal ZMIX As Double)

		'C CALC DIAGNOSTIC VARIABLES

		'        Dim X(1)

		' INPUT:  1=  CONS 2 = TOTAL P 3 = TOTAL N
		'         4 = CHLA 5 = SECCHI  6 = ORGN  7 = PP
		'         8 = HODV 9 = MODV   10=XPN   18 = TURB

		' diagnostics:

		' 11 = PC - 1, 12 = PC - 2
		' 13 = (n - 150) / p, 14 = ALPHA * zmix, 15 = zmix/secchi, 16 = b * S
		'  17 = CHLA/TOTAL P,   18 = TURBIDITY   19 = INORG N/P

		'c Initialize
		For i As Integer = 11 To 28
			If i <> 18 Then x(i) = 0
		Next i

		' PRINCIPAL COMPONENTS
		If x(4) > 0 And x(5) > 0 Then

			If x(10) > 0 And x(6) > 0 Then

				'C PCS - USING ALL DATA
				x(11) = (x(4) ^ 0.554) * (x(6) ^ 0.359) * (x(10) ^ 0.583) * (x(5) ^ (-0.474))
				x(12) = (x(4) ^ 0.689) * (x(6) ^ 0.162) * (x(10) ^ (-0.205)) * (x(5) ^ 0.676)
			Else

				'C PCS - USING CHL-A AND SECCHI ONLY
				x(11) = 29.79 * (x(4) ^ 0.949) * (x(5) ^ (-0.932))
				x(12) = 1.36 * (x(4) ^ 0.673) * (x(5) ^ 0.779)

			End If
		End If

		'C N/P RATIOS
		If x(2) > 0 And x(3) > 0 Then

			'c (n - 150) / p
			x(13) = MAx(x(3) - 150, 10) / x(2)

			'C INORG N/P
			If x(6) > 0 And x(7) > 0 Then x(19) = MAx(x(3) - x(6), 1) / MAx(x(2) - x(7), 1)
		End If

		'c ALPHA * z
		x(14) = ZMIX * x(18)

		'c ZMIX / SECCHI
		If x(5) > 0 Then x(15) = ZMIX / x(5)

		'c CHLA * SECCHI
		x(16) = x(5) * x(4)

		'C CHL-A/TOTAL P
		If x(2) > 0 Then x(17) = x(4) / x(2)

		'c carlson tsi-p
		If x(2) > 0 Then x(26) = 14.42 * Math.Log(x(2)) + 4.15

		'c carlson tsi-chla
		If x(4) > 0 Then x(27) = 9.81 * Math.Log(x(4)) + 30.6

		'c carlson tsi-secchi
		If x(5) > 0 Then x(28) = 60 - 14.41 * Math.Log(x(5))

		'c nuisance level frequencies
		If x(4) <= 0 Or Xk(13) <= 0 Then Exit Sub
		Dim xx As Double = 10
		For i As Integer = 20 To 25
			x(i) = Cnlf(x(4), Xk(13), xx)
			xx += 10
		Next i

	End Sub

	Function Cnlf(ByVal cm As Double, ByVal cV As Double, ByVal cstar As Double) As Double
		Dim result As Double = 0
		Dim v, w, z As Double

		'c returns probability(%) that c > cstar for lognormal distribution
		'c with arithmetic mean=cm and geometric cv=cv

		If cV <= 0 Or cm <= 0 Or cstar <= 0 Then
			If cstar >= cm Then
				Return 0
			Else
				Return 100
			End If

		Else

			v = cV
			w = Math.Log(cm) - 0.5 * v * v
			z = (Math.Log(cstar) - w) / v

			v = Math.Exp((-z) * z / 2) / 2.507
			w = 1 / (1 + 0.33267 * Math.Abs(z))
			result = v * w * (0.4361684 - 0.1201676 * w + 0.937298 * w * w)
			If z <= 0 Then result = 1 - result
			Return 100 * result
		End If

	End Function
	Sub Cload(ByVal i As Double)

		'c segment = i
		'c load observed variables into vector x
		'c load estimated variables into vector y


		For j As Integer = 1 To 10
			x(j) = Cobs(CInt(i), j)
			y(j) = Cest(CInt(i), j)
		Next j

		x(18) = Turb(CInt(i))
		y(18) = Turb(CInt(i))

		DiagnosticVariables(ArraysHelper.CastArray(Of Double())(x), Zmx(CInt(i)))
		DiagnosticVariables(ArraysHelper.CastArray(Of Double())(y), Zmx(CInt(i)))

	End Sub

	Sub SolveLinear()

		'c solve linear system of equations of form:
		'  a(1,1) x(1) + a(1,2) x(2) + ... + a(1,n) x(n) = a(1,n+1)
		'  ...
		'  a(n,1) x(1) + a(n,2) x(2) + ... + a(n,n) x(n) = a(n,n+1)
		' a(i,n+1) contains constant vector on input, solution on output

		Dim y1 As Single
		Dim i As Integer

		'Call Dumpa(0)


		For j As Integer = 1 To Nseg

			For i = j To Nseg
				If A(i, j) <> 0 Then GoTo s120
			Next i
			' singular
			Elist(1, "Invalid Solution Matrix for Water or Mass Balance")
			Ier = 1
			Exit Sub
s120:
			For k As Integer = 1 To Nseg + 1
				y1 = A(j, k)
				A(j, k) = A(i, k)
				A(i, k) = y1
			Next k

			y1 = 1 / A(j, j)

			For k As Integer = 1 To Nseg + 1
				A(j, k) = y1 * A(j, k)
			Next k

			For i = 1 To Nseg
				'      If i = j Or A(i, j) = 0 Then Next i
				If i <> j And A(i, j) <> 0 Then
					y1 = -A(i, j)
					'For k = 1 To n1
					For k As Integer = 1 To Nseg + 1
						A(i, k) += y1 * A(j, k)
					Next k
				End If
			Next i
		Next j
		'Call Dumpa(1)

	End Sub

	Function Cuse(ByVal Cobs As Double, ByVal Cest As Double, ByVal io As Integer) As Double

		'c returns concentration used for mass balance table

		If io >= 1 Or Cobs <= 0 Then
			Return Cest
		Else
			Return Cobs
		End If

	End Function

	Sub Ycopy_In()
		Dim k As Integer = 0
		For i As Double = 1 To 4
			For j As Double = 1 To NtermS
				k += 1
				Ye(k) = Term(CInt(i), CInt(j))
			Next j
		Next i

		For j As Double = 1 To NDiagnostics
			For i As Double = 1 To Nseg + 1
				k += 1
				Ye(k) = Cest(CInt(i), CInt(j))
			Next i
		Next j

		For j As Double = 11 To NDiagnostics
			For i As Double = 1 To Nseg + 1
				k += 1
				Ye(k) = Cobs(CInt(i), CInt(j))
			Next i
		Next j

		Nye = k

	End Sub

	Sub Ycopy_Out()

		Dim k As Integer = 0
		For i As Double = 1 To 4
			For j As Double = 1 To NtermS
				k += 1
				CvTerm(CInt(i), CInt(j)) = Cye(k)
			Next j
		Next i

		For j As Double = 1 To NDiagnostics
			For i As Double = 1 To Nseg + 1
				k += 1
				CvCest(CInt(i), CInt(j)) = Cye(k)
			Next i
		Next j

		For j As Double = 11 To NDiagnostics
			For i As Double = 1 To Nseg + 1
				k += 1
				CvCobs(CInt(i), CInt(j)) = Ratv(Math.Sqrt(Cye(k)), Ye(k))
			Next i
		Next j

		'With Sheets("eran").Range("A1")
		'For k = 1 To Nye
		'.Offset(k, 0) = k
		'.Offset(k, 1) = Ye(k)
		'.Offset(k, 2) = Cye(k)
		'If Ye(k) > 0 Then .Offset(k, 3) = Sqr(Cye(k)) / Ye(k)
		'Next k
		'End With

	End Sub

	Sub Xcopy_In()

		Dim k As Integer = 0
		For i As Double = 1 To NXk
			k += 1
			Xe(k) = Xk(CInt(i))
			Cxe(k) = CvXk(CInt(i))
		Next i

		For i As Double = 1 To Nseg
			For j As Integer = 1 To 9
				k += 1
				Xe(k) = Cal(CInt(i), j)
				Cxe(k) = CvCal(CInt(i), j)
			Next j
		Next i

		Nxe_1 = k

		For i As Double = 1 To 7
			k += 1
			Xe(k) = Atm(CInt(i))
			Cxe(k) = CvAtm(CInt(i))
		Next i

		For i As Double = 1 To 4
			k += 1
			Xe(k) = P(CInt(i))
			Cxe(k) = Cp(CInt(i))
		Next i

		For i As Double = 1 To Nseg + 1
			k += 1
			Xe(k) = Zmx(CInt(i))
			Cxe(k) = CvZmx(CInt(i))
			k += 1
			Xe(k) = Zhyp(CInt(i))
			Cxe(k) = CvZhyp(CInt(i))
			k += 1
			Xe(k) = Turb(CInt(i))
			Cxe(k) = CvTurb(CInt(i))
			For j As Integer = 1 To 10
				k += 1
				Xe(k) = Cobs(CInt(i), j)
				Cxe(k) = CvCobs(CInt(i), j)
			Next j
			For j As Integer = 1 To 7
				k += 1
				Xe(k) = InternalLoad(CInt(i), j)
				Cxe(k) = CvInternalLoad(CInt(i), j)
			Next j

		Next i

		For i As Double = 1 To NTrib
			For j As Integer = 1 To 7
				k += 1
				If Icode(CInt(i)) = 2 Then
					Xe(k) = Concil(CInt(i), j)
					Cxe(k) = CvCil(CInt(i), j)
				Else
					Xe(k) = Conci(CInt(i), j)
					Cxe(k) = CvCi(CInt(i), j)
				End If
			Next j
			k += 1
			If Icode(CInt(i)) = 2 Then
				Xe(k) = FlowL(CInt(i))
				Cxe(k) = CvFlowL(CInt(i))
			Else
				Xe(k) = Flow(CInt(i))
				Cxe(k) = CvFlow(CInt(i))
			End If
		Next i

		For i As Double = 1 To Npipe
			k += 1
			Xe(k) = Qpipe(CInt(i))
			Cxe(k) = CvQpipe(CInt(i))
			k += 1
			Xe(k) = Epipe(CInt(i))
			Cxe(k) = CvEpipe(CInt(i))
		Next i

		Nxe = k

	End Sub


	Sub Xcopy_Out()
		Dim k As Integer = 0
		For i As Double = 1 To NXk
			k += 1
			Xk(CInt(i)) = Xe(k)
		Next i

		For i As Double = 1 To Nseg
			For j As Integer = 1 To 9
				k += 1
				Cal(CInt(i), j) = Xe(k)
			Next j
		Next i

		For i As Double = 1 To 7
			k += 1
			Atm(CInt(i)) = Xe(k)
		Next i

		For i As Double = 1 To 4
			k += 1
			P(CInt(i)) = Xe(k)
		Next i

		For i As Double = 1 To Nseg + 1
			k += 1
			Zmx(CInt(i)) = Xe(k)
			k += 1
			Zhyp(CInt(i)) = Xe(k)
			k += 1
			Turb(CInt(i)) = Xe(k)

			For j As Integer = 1 To 10
				k += 1
				Cobs(CInt(i), j) = Xe(k)
			Next j
			For j As Integer = 1 To 7
				k += 1
				InternalLoad(CInt(i), j) = Xe(k)
			Next j
		Next i

		For i As Double = 1 To NTrib
			For j As Integer = 1 To 7
				k += 1
				If Icode(CInt(i)) = 2 Then
					Concil(CInt(i), j) = Xe(k)
				Else
					Conci(CInt(i), j) = Xe(k)
				End If
			Next j
			k += 1
			If Icode(CInt(i)) = 2 Then
				FlowL(CInt(i)) = Xe(k)
			Else
				Flow(CInt(i)) = Xe(k)
			End If
		Next i

		For i As Double = 1 To Npipe
			k += 1
			Qpipe(CInt(i)) = Xe(k)
			k += 1
			Epipe(CInt(i)) = Xe(k)
		Next i

	End Sub

	Sub ErrorAnalysis()

		'FIRST-ORDER ANALYSIS

		Dim dydX, stasH As Single
		Dim i1, i2 As Integer

		'       If Iop(9) = 0 Then Exit Sub

		'C INITIALIZE VARIANCES AND MEAN OUTPUTS

		Dim deL As Single = 1.03 'scale factor for derivative calcs
		Ycopy_In() 'var  -> ye
		Xcopy_In() 'var --> xe
		For j As Double = 1 To Nye
			Cye(CInt(j)) = 0
			Ysave(CInt(j)) = Ye(CInt(j))
		Next j

		Select Case Iop(9)
			Case 0
				i1 = 0
				i2 = -1
			Case 1
				i1 = 1 'all
				i2 = Nxe
			Case 2
				i1 = 1 'model only
				i2 = Nxe_1
			Case 3
				i1 = Nxe_1 + 1 'data only
				i2 = Nxe
		End Select

		'C TEST INPUTS

		For i As Integer = i1 To i2
			If Cxe(i) > 0 And Xe(i) > 0 Then
				stasH = Xe(i)
				Xe(i) *= deL
				Xcopy_Out() 'xe - > var
				Model()
				If Ier > 0 Then
					Elist(1, "Solution Error Testing Input Variable " & i)
					Exit Sub
				End If
				Ycopy_In() 'var --> ye
				For j As Double = 1 To Nye
					dydX = (Ye(CInt(j)) - Ysave(CInt(j))) / (Xe(i) - stasH)
					Cye(CInt(j)) += (dydX * Cxe(i) * stasH) ^ 2
				Next j
				Xe(i) = stasH

			End If
		Next i

		'c reset model
		Ycopy_Out() 'cye ---> var
		Xcopy_Out() 'xe --> var
		Model()

	End Sub

	Sub Run_Sensitivity()

		'C SENSITIVITY ANALYSIS - MASS BALANCES VS. DECAY AND DISPERSION RATES

		Dim xS, xD, dsavE, xsavE, sfaC, dfaC As Single
		Dim nS, nD As Integer

		StartSheet("Sensitivity")

		line_no = 0

		With ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"})

			For kvaR As Integer = 1 To 3
				If Iop(kvaR) > 0 Then

					ReflectionHelper.Invoke(ReflectionHelper.Invoke(Hdr, "Range", New Object() {"header_sensit"}), "Copy", New Object() {})
					'UPGRADE_WARNING: (7006) The Named argument Destination was not resolved and corresponds to the following expression gLSht.Range().Offset() More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-7006
					ReflectionHelper.Invoke(Wko.ActiveSheet, "Paste", New Object() {ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 0})}, New String() {"Destination"})
					ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", VariableName(kvaR), line_no, 4)
					ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", " Segment ->", line_no + 1, 2)
					For i As Integer = 1 To Nseg + 1
						If i = Nseg + 1 Then
							ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", "Mean", line_no + 2, 1 + i)
							ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no + 2, 1 + i}), "HorizontalAlignment", Excel.Constants.xlRight)
						Else
							ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", i, line_no + 2, 1 + i)
						End If
						ReflectionHelper.LetMember(ReflectionHelper.GetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no + 2, 1 + i}), "Font"), "Underline", Excel.XlUnderlineStyle.xlUnderlineStyleSingle)
						ReflectionHelper.LetMember(ReflectionHelper.GetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no + 2, 1 + i}), "Font"), "FontStyle", "Bold")
					Next i
					line_no += 3

					'dispersion factors
					If Nseg = 1 Then
						nD = 1
						dfaC = 1
					Else
						nD = 3
						dfaC = 4
					End If
					dsavE = Xk(1)

					'sedimentation factors
					If kvaR = 1 Then
						nS = 1
						sfaC = 1
						xsavE = 1
					Else
						nS = 3
						sfaC = 2
						xsavE = Xk(kvaR)
					End If
					xS = 1 / (sfaC * sfaC)

					'C Sedimentation Loop

					For i As Integer = 1 To nS

						xS *= sfaC
						If kvaR <> 1 Then Xk(kvaR) = xsavE * xS
						xD = 1 / (dfaC * dfaC)


						'C DISPERSION LOOP
						For j As Integer = 1 To nD
							xD *= dfaC
							Xk(1) = dsavE * xD
							Model()
							If Ier > 0 Then GoTo s900

							line_no += 1
							ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", xS, line_no, 0)
							ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 0}), "NumberFormat", "0.00")
							ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", xD, line_no, 1)
							ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 1}), "NumberFormat", "0.00")
							For k As Integer = 1 To Nseg + 1
								ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", Cest(k, kvaR), line_no, 1 + k)
								ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 1 + k}), "NumberFormat", "0")
							Next k

						Next j
					Next i
					line_no += 2
					ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", "Observed:", line_no, 0)
					For k As Integer = 1 To Nseg + 1
						If Cobs(k, kvaR) > 0 Then ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", Cobs(k, kvaR), line_no, k + 1)
						ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, k + 1}), "NumberFormat", "0")
					Next k
s900:
					If kvaR <> 1 Then Xk(kvaR) = xsavE
					Xk(1) = dsavE
					Model()
					line_no += 2
				End If
			Next kvaR
		End With

	End Sub
	Function MAx(ByVal x1 As Double, ByVal x2 As Double) As Double
		If x2 > x1 Then
			Return x2
		Else
			Return x1
		End If
	End Function
	Function MIn(ByVal x1 As Double, ByVal x2 As Double) As Double
		If x2 > x1 Then
			Return x1
		Else
			Return x2
		End If
	End Function

	Function Ratv(ByVal x1 As Double, ByVal x2 As Double) As Double
		'Dim Ratv As Single
		'quotient x1/x2, =0 if x2=0
		If x2 <> 0 Then
			Return x1 / x2
		Else
			Return 0
		End If
	End Function

	Sub Elist(ByVal io As Integer, ByVal em As String)
		'c io<0 clear, io=0 nonfatal message, io=1 fatal message
		'c return if error messages turned off (for error analysis)

		If Imsg = 0 Then Exit Sub
		If Nmsg = 0 Then ErrTxt = ""
		If io < 0 Then Exit Sub

		Nmsg += 1
		ErrTxt = ErrTxt & em & Environment.NewLine
		'       If (ShowWarnings And Nmsg = 1) Or io > 0 Then MsgBox( em
		'UPGRADE_ERROR: (1010) The preceding line couldn't be parsed. More Information: https://docs.mobilize.net/vbuc/ewis#id-#1010
		If io > 0 Then Ier = 1

	End Sub



	Sub Run_Response()
		Dim frmresposne As Object
		Dim jseG As Integer
		Dim jtriB As Double

		'run load response
		Dim factoR, qtesT, ltesT As Single
		Dim jvaR As Integer
		Dim faC, f_miN, f_maX, dF As Single
		Const nF As Integer = 10
		Dim jopT As Integer
		Dim Lpics As Integer


		'case parameters
		With frmResponse.DefInstance
			jtriB = .cmbTrib.SelectedIndex
			jseG = .cmbSegment.SelectedIndex + 1
			jvaR = .cmbVariable.SelectedIndex + 1
			jopT = .cmbOption.SelectedIndex
			f_miN = CSng(.txtScale(0).Text)
			f_maX = CSng(.txtScale(1).Text)
			If f_maX < f_miN Then
				'                MsgBox( "Illegal Range for Load Scale"
				'UPGRADE_ERROR: (1010) The preceding line couldn't be parsed. More Information: https://docs.mobilize.net/vbuc/ewis#id-#1010
				Ier = 1
				Exit Sub
			End If
			.lblStatus.Text = "Running..."
		End With

		'save inflow concentrations total p & ortho p
		For i As Double = 1 To NTrib
			If jopT = 0 Then
				Xp(CInt(i)) = Conci(CInt(i), 2)
				Xp(CInt(i + NTMAX)) = Concil(CInt(i), 2)
				Yp(CInt(i)) = Conci(CInt(i), 4)
				Yp(CInt(i + NTMAX)) = Concil(CInt(i), 4)
			Else
				Xp(CInt(i)) = Flow(CInt(i))
				Xp(CInt(i + NTMAX)) = FlowL(CInt(i))
			End If
		Next i

		'load/response table

		'.Sheets("load response").Paste Destination:=.Sheets("load response").Range("A3")
		StartSheet("Load Response") 'StartSheet assigns and clears glSht
		line_no = 0
		With ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"})
			ReflectionHelper.Invoke(ReflectionHelper.Invoke(Hdr, "Range", New Object() {"Header_response"}), "Copy", New Object() {})
			'UPGRADE_WARNING: (7006) The Named argument Destination was not resolved and corresponds to the following expression gLSht.Range().Offset() More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-7006
			ReflectionHelper.Invoke(gLSht, "Paste", New Object() {ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", New Object() {line_no, 0})}, New String() {"Destination"})
			ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", frmResponse.DefInstance.cmbTrib.Text, line_no + 1, 1)
			ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", frmResponse.DefInstance.cmbSegment.Text, line_no + 2, 1)
			ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", DiagName(jvaR), line_no + 3, 1)
			ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", " " & DiagName(jvaR), line_no + 5, 4)
			ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", New Object() {line_no + 5, 4}), "HorizontalAlignment", Excel.Constants.xlLeft)
			line_no += 6

			dF = (f_maX - f_miN) / (nF - 1)

			For ii As Integer = 0 To nF

				If ii = 0 Then
					factoR = 1
				Else
					factoR = f_miN + (ii - 1) * dF
				End If
				'adjust load
				For i As Double = 1 To NTrib
					If jtriB = 0 Or jtriB = i Then
						If jopT = 0 Then
							Concil(CInt(i), 2) = Xp(CInt(i + NTMAX)) * factoR
							Concil(CInt(i), 4) = Yp(CInt(i + NTMAX)) * factoR
							Conci(CInt(i), 2) = Xp(CInt(i)) * factoR
							Conci(CInt(i), 4) = Yp(CInt(i)) * factoR
						Else
							FlowL(CInt(i)) = Xp(CInt(i + NTMAX)) * factoR
							Flow(CInt(i)) = Xp(CInt(i)) * factoR
						End If
					End If
				Next i

				'run model without warmups
				Imsg = 0
				Avail()
				Model()
				If Ier > 0 Then GoTo Quit
				ErrorAnalysis()

				If Ier > 0 Then GoTo Quit

				qtesT = 0
				ltesT = 0
				For i As Double = 1 To NTrib
					If jtriB = 0 Or jtriB = i Then
						qtesT += Flow(CInt(i))
						ltesT += Flow(CInt(i)) * Conci(CInt(i), 2)
					End If
				Next i

				faC = Ratv(Math.Sqrt(CvCest(jseG, jvaR)), Cest(jseG, jvaR))
				line_no += 1
				If ii = 0 Then
					ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", "Base:", line_no, 0)
					ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", New Object() {line_no, 0}), "HorizontalAlignment", Excel.Constants.xlRight)
				Else
					ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", factoR, line_no, 0)
				End If
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", New Object() {line_no, 0}), "NumberFormat", "0.00")
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", qtesT, line_no, 1)
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", ltesT, line_no, 2)
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", Ratv(ltesT, qtesT), line_no, 3)
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", Cest(jseG, jvaR), line_no, 4)
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", faC, line_no, 5)
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", Cest(jseG, jvaR) / (1 + faC), line_no, 6)
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", Cest(jseG, jvaR) * (1 + faC), line_no, 7)
				For j As Integer = 1 To 7
					ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", New Object() {line_no, j}), "NumberFormat", "0.0")
				Next j
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", New Object() {line_no, 5}), "NumberFormat", "0.00")

			Next ii
		End With

		'reset
		For i As Double = 1 To NTrib
			If jtriB = 0 Or jtriB = i Then
				If jopT = 0 Then
					Conci(CInt(i), 2) = Xp(CInt(i))
					Conci(CInt(i), 4) = Yp(CInt(i))
					Concil(CInt(i), 2) = Xp(CInt(i + NTMAX))
					Concil(CInt(i), 4) = Yp(CInt(i + NTMAX))
				Else
					Flow(CInt(i)) = Xp(CInt(i))
					FlowL(CInt(i)) = Xp(CInt(i + NTMAX))
				End If
			End If
		Next i
		Excel_Global_definst.Calculate()
		Calcon()
		Icalc = 1


		Lpics = ReflectionHelper.GetMember(Of Integer)(ReflectionHelper.GetMember(gLSht, "Shapes"), "Count")
		For i As Double = 1 To Lpics
			'If gDebugCVmode Then MsgBox( ("Shapes in glSht: " & gLSht.Shapes.Count)
			ReflectionHelper.Invoke(ReflectionHelper.Invoke(ReflectionHelper.GetMember(gLSht, "Shapes"), "Item", New Object() {i}), "Delete", New Object() {})
		Next i


		If Not gRunMetaModels Then
			With Wkb
				.Sheets("plot response").ChartObjects(Type.Missing)(1).CopyPicture()
				'.Sheets("load response").Activate


				'NO: .Sheets("load response").Range("A22:A99").Select
				'NO:.Sheets("load response").Pictures.Paste 'Range("A22"))
				'OK, but not in right place: .Sheets("load response").Pictures.Paste.Select
				'==================================================================
				'HAD A HELL OF A TIME TRANSLATING THE PASTE Method TO OBJECT MODE (see above)
				'BUT IT TURNS OUT, I JUST NEEDED TO SPECIFY THE DESTINATION RANGE _FULLY_:
				.Sheets("load response").Paste(.Sheets("load response").Range("A22").Value)
				If Iop(12) = 2 Then .Sheets("load response").Range("i43").Value = " "
			End With
		End If
		frmResponse.DefInstance.lblStatus.Text = "Ready"
		Exit Sub

Quit:
		Icalc = 0
		ReflectionHelper.LetMember(ReflectionHelper.GetMember(frmresposne, "lblStatus"), "Caption", "Ready")

	End Sub

	Sub TurbEst(ByVal chla_m As Single, ByVal chla_cv As Single, ByVal s_m As Single, ByVal s_cv As Single, ByRef turb_m As Single, ByRef turb_cv As Single)
		'estimate non-algal turbidity mean & Cv

		If chla_m > 0 And s_m > 0 Then
			turb_m = MAx(0.08, 1 / s_m - Xk(10) * chla_m)
			turb_cv = (Xk(10) * chla_m * chla_cv) ^ 2 + (s_cv / s_m) ^ 2
			turb_cv = Math.Sqrt(turb_cv) / turb_m
		Else
			turb_m = 0.08
			turb_cv = 0.2
		End If
	End Sub
End Module