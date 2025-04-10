Option Strict Off
Option Explicit On
Imports Excel = Microsoft.Office.Interop.Excel
Imports System
Imports System.Text
Imports UpgradeHelpers.Helpers
Module Module3
	Sub Output_Init()
		'initialize output list parameters

		ShowWarnings = True

		NGlobals = 4
		GlobalName(1) = "AVERAGING PERIOD (YRS)"
		GlobalName(2) = "PRECIPITATION (METERS)"
		GlobalName(3) = "EVAPORATION (METERS)"
		GlobalName(4) = "INCREASE IN STORAGE (METERS)"

		'input concentrations
		NVariables = 5
		VariableName(1) = "CONSERVATIVE SUBST."
		VariableName(2) = "TOTAL P"
		VariableName(3) = "TOTAL N"
		VariableName(4) = "ORTHO P"
		VariableName(5) = "INORGANIC N"

		'map components
		Imap(1) = 1
		Imap(2) = 6
		Imap(3) = 7

		'mass balance type labels
		MassBalName(0) = "Observed"
		MassBalName(1) = "Predicted"

		'type codes
		N_Type_Codes = 5
		Type_Code(1) = "Monitored Inflow"
		Type_Code(2) = "Non Point Inflow"
		Type_Code(3) = "Point Source"
		Type_Code(4) = "Reservoir Outflow"
		Type_Code(5) = "Downstream Boundary"
		'Type_Code(6) = "Internal Load"


		'term names
		NtermS = 18
		TermName(1) = "PRECIPITATION"
		TermName(2) = "EXTERNAL INFLOW"
		TermName(3) = "***EVAPORATION"
		TermName(4) = "GAUGED OUTFLOW"
		TermName(5) = "***RETENTION"
		TermName(6) = "ADVECTIVE INFLOW"
		TermName(7) = "ADVECTIVE OUTFLOW"
		TermName(8) = "DIFFUSIVE INFLOW"
		TermName(9) = "***TOTAL INFLOW"
		TermName(10) = "***TOTAL OUTFLOW"
		TermName(11) = "***STORAGE INCREASE"
		TermName(12) = "DIFFUSIVE OUTFLOW"
		TermName(13) = "NET DIFFUSIVE INFLOW"
		TermName(14) = "NET DIFFUSIVE OUTFLOW"
		TermName(15) = "INTERNAL LOAD"
		TermName(16) = "TRIBUTARY INFLOW"
		TermName(17) = "NONPOINT INFLOW"
		TermName(18) = "POINT-SOURCE INFLOW"

		'C SEGMENT MASS BALANCE TERMS TO BE PRINTED FORMAT 1

		Njord = 15
		Jord(1) = 1
		Jord(2) = 15
		Jord(3) = 16
		Jord(4) = 17
		Jord(5) = 18
		Jord(6) = 6
		Jord(7) = 13
		Jord(8) = 9
		Jord(9) = 4
		Jord(10) = 7
		Jord(11) = 14
		Jord(12) = 10
		Jord(13) = 3
		Jord(14) = 11
		Jord(15) = 5
		'      data njord/15/
		'      data jord/1,15,16,17,18,6,13,9,4,7,14,10,3,11,5/

		'C GROSS MASS BALANCE TERMS TO BE PRINTED

		Nkord = 14
		Kord(1) = 1
		Kord(2) = 15
		Kord(3) = 16
		Kord(4) = 17
		Kord(5) = 18
		Kord(6) = 13
		Kord(7) = 9
		Kord(8) = 4
		Kord(9) = 7
		Kord(10) = 14
		Kord(11) = 10
		Kord(12) = 3
		Kord(13) = 11
		Kord(14) = 5

		'   DATA NKORD/14/,KORD/1,15,16,17,18,13,9,4,7,14,10,3,11,5,1*0/

		'mass balance terms format2
		'  DATA MORD/8/,LORD/2,1,6,11,7,4,8,3,0,0/

		Mord = 8
		Lord(1) = 2
		Lord(2) = 1
		Lord(3) = 6
		Lord(4) = 11
		Lord(5) = 7
		Lord(6) = 4
		Lord(7) = 8
		Lord(8) = 3

	End Sub

	Sub List_All()
		Dim sN As String = ""
		'MsgBox( "minimizing Excel Template"
		Dim realversion As Double = CDbl(Wka.Version)
		If (realversion < 15) Then Wka.WindowState = Excel.XlWindowState.xlMinimized
		For i As Integer = 0 To 9
			Select Case i
				Case 9 'reversed the order to accomodate excel .ADD behavior
					List_Inputs()
				Case 8
					List_Tree()
				Case 7
					List_Hydraulics()
				Case 6
					List_GrossBalances()
				Case 5
					If Not NoviceUser Then List_SegBalances()
				Case 4
					If Not NoviceUser Then List_Terms()
				Case 3
					List_Diagnostics(1)
				Case 2
					If Not NoviceUser Then List_Profiles()
				Case 1
					If Not NoviceUser Then List_TTests()
				Case 0
					If Not NoviceUser Then List_Fits()

			End Select

			sN = ReflectionHelper.GetMember(Of String)(gLSht, "Name")
			Status("Listing: " & sN)
			'MsgBox( ("About to Copy " & sN)
			SheetCopy((sN))
		Next i
		Status("Ready")
		Wka.WindowState = Excel.XlWindowState.xlNormal

	End Sub 'List_All

	Sub StartSheet(ByVal sN As String) 'sN is Sheet Name
		'start new output sheet
		'    If DebugMode Then MsgBox( ("Loading Excel from Module3, StartSheet " & sN)
		'UPGRADE_ERROR: (1010) The preceding line couldn't be parsed. More Information: https://docs.mobilize.net/vbuc/ewis#id-#1010
		'LoadExcel
		'MsgBox( "N22: StartSheet (module3) is Calling ClearOutput"
		'ClearOutput
		Status((sN))
		Wkb.Sheets(sN).Cells.Clear()
		'MsgBox( "Cleared Cells in " & Wkb.Name & " " & sN
		gLSht = Wkb.Sheets(sN)
		With gLSht
			'     If DebugMode Then MsgBox( "StartSheet Clearing: " & Wkb.Name & "." & gLSht.Name & "  " & Title
			'UPGRADE_ERROR: (1010) The preceding line couldn't be parsed. More Information: https://docs.mobilize.net/vbuc/ewis#id-#1010
			'.Cells.Clear
			ReflectionHelper.LetMember(gLSht, "Range", Title, "A1")
			ReflectionHelper.LetMember(ReflectionHelper.GetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"a1", "b2"}), "Font"), "Bold", True)
			ReflectionHelper.LetMember(gLSht, "Range", "File:", "A2")
			ReflectionHelper.LetMember(gLSht, "Range", CaseFile, "b2")
		End With
	End Sub
	Sub List_Hydraulics()

		Dim atoT, vtoT As Single

		StartSheet("Hydraulics")
		line_no = 0
		With ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"})
			ReflectionHelper.Invoke(ReflectionHelper.Invoke(Hdr, "Range", New Object() {"Header_Hydrau"}), "Copy", New Object() {})
			'UPGRADE_WARNING: (7006) The Named argument Destination was not resolved and corresponds to the following expression gLSht.Range().Offset() More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-7006
			ReflectionHelper.Invoke(gLSht, "Paste", New Object() {ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 0})}, New String() {"Destination"})
			line_no += 3
			For i As Double = 1 To Nseg
				line_no += 1
				Hydrau(i)
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", i, line_no, 0)
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 0}), "HorizontalAlignment", Excel.Constants.xlCenter)
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", SegName(CInt(i)), line_no, 1)
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", Iout(CInt(i)), line_no, 2)
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 2}), "HorizontalAlignment", Excel.Constants.xlCenter)
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", Qnet(CInt(i)), line_no, 3)
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 3}), "NumberFormat", "0.0")
				For k As Integer = 3 To 8
					ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", x(k), line_no, 1 + k)
					If k = 3 Then
						ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 1 + k}), "NumberFormat", "0.0000")
					Else
						ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 1 + k}), "NumberFormat", "0.0")
					End If
				Next k
			Next i


			line_no += 2
			atoT = 0
			vtoT = 0
			ReflectionHelper.Invoke(ReflectionHelper.Invoke(Hdr, "Range", New Object() {"Header_Morpho"}), "Copy", New Object() {})
			'UPGRADE_WARNING: (7006) The Named argument Destination was not resolved and corresponds to the following expression gLSht.Range().Offset() More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-7006
			ReflectionHelper.Invoke(gLSht, "Paste", New Object() {ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 0})}, New String() {"Destination"})
			line_no += 2
			For i As Double = 1 To Nseg
				line_no += 1
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", i, line_no, 0)
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 0}), "HorizontalAlignment", Excel.Constants.xlCenter)
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", SegName(CInt(i)), line_no, 1)
				x(1) = Area(CInt(i))
				x(2) = Zmn(CInt(i))
				x(3) = Zmx(CInt(i))
				x(4) = Slen(CInt(i))
				x(5) = Area(CInt(i)) * Zmn(CInt(i))
				atoT += Area(CInt(i))
				vtoT += x(5)
				x(6) = Ratv(Area(CInt(i)), Slen(CInt(i)))
				x(7) = Ratv(Slen(CInt(i)), x(6))
				For j As Integer = 1 To 7
					ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", x(j), line_no, j + 1)
					ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, j + 1}), "NumberFormat", "0.0")
				Next j
			Next i
			line_no += 1
			ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", "Totals", line_no, 0)
			ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 2}), "NumberFormat", "0.0")
			ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 3}), "NumberFormat", "0.0")
			ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 6}), "NumberFormat", "0.0")
			ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", atoT, line_no, 2)
			ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", vtoT, line_no, 6)
			ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", Ratv(vtoT, atoT), line_no, 3)

		End With
	End Sub

	Sub List_GrossBalances()
		Dim Export, i, jseG, k As Double
		Dim Tf As Single

		Dim Da(20) As Single
		Dim runofF, vaR, xL, cV, cU, pV1, pL, cvQ, qU, tW As Single

		'C kPRINT=3 GROSS WATER AND NUTRIENT BALANCES

		'c water balances
		If NTrib <= 0 Then Exit Sub
		'Call Balan
		MassBalanceTerms()

		StartSheet("Overall Balances")
		line_no = 0
		With ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"})
			ReflectionHelper.Invoke(ReflectionHelper.Invoke(Hdr, "Range", New Object() {"Header_gwbal"}), "Copy", New Object() {})
			'UPGRADE_WARNING: (7006) The Named argument Destination was not resolved and corresponds to the following expression gLSht.Range().Offset() More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-7006
			ReflectionHelper.Invoke(gLSht, "Paste", New Object() {ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 0})}, New String() {"Destination"})
			ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", P(1), line_no + 2, 7)
			line_no += 4

			For i = 1 To 18
				Da(CInt(k)) = 0
			Next i

			For i = 1 To NTrib
				If Icode(CInt(i)) <= 4 Then
					If Icode(CInt(i)) = 4 Then
						k = 4
					Else
						k = 15 + Icode(CInt(i))
					End If
					Da(CInt(k)) += Darea(CInt(i))
					qU = Flow(CInt(i))
					cvQ = CvFlow(CInt(i))
					If Icode(CInt(i)) = 2 Then
						qU = FlowL(CInt(i))
						cvQ = CvFlowL(CInt(i))
					End If
					runofF = Ratv(qU, Darea(CInt(i)))
					vaR = (cvQ * qU) ^ 2
					If qU > 0 Then
						line_no += 1
						ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", i, line_no, 0)
						ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 0}), "HorizontalAlignment", Excel.Constants.xlCenter)
						ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", Icode(CInt(i)), line_no, 1)
						ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 1}), "HorizontalAlignment", Excel.Constants.xlCenter)
						ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", Iseg(CInt(i)), line_no, 2)
						ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 2}), "HorizontalAlignment", Excel.Constants.xlCenter)
						ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", TribName(CInt(i)), line_no, 3)
						If Darea(CInt(i)) > 0 Then ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", Darea(CInt(i)), line_no, 4)
						ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 4}), "NumberFormat", "0.0")
						ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", qU, line_no, 5)
						ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 5}), "NumberFormat", "0.0")
						ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", vaR, line_no, 6)
						ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 6}), "NumberFormat", "0.00E+00")
						If qU > 0 Then ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", cvQ, line_no, 7)
						ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 7}), "NumberFormat", "0.00")
						If runofF > 0 Then ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", runofF, line_no, 8)
						ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 8}), "NumberFormat", "0.00")
					End If

				End If
			Next i

			'C DRAINAGE AREAS
			'c total external
			Da(2) = Da(16) + Da(17) + Da(18)
			'c precip
			Da(1) = Area(Nseg + 1)
			'C TOTAL IN
			Da(9) = Da(1) + Da(2)
			'C put da error in advective outflow
			Da(7) = Da(9) - Da(4)
			Da(10) = Da(9)
			Da(5) = 0

			'c Summary
			For j As Integer = 1 To Nkord
				i = Kord(j)
				If Not (i = 5 Or i = 15 Or Term(1, CInt(i)) = 0) Then
					line_no += 1
					runofF = Ratv(Term(1, CInt(i)), Da(CInt(i)))
					cV = MIn(Ratv(Math.Sqrt(CvTerm(1, CInt(i))), Math.Abs(Term(1, CInt(i)))), 9.99)
					ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", TermName(CInt(i)), line_no, 0)
					If Da(CInt(i)) > 0 Then ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", Da(CInt(i)), line_no, 4)
					ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 4}), "NumberFormat", "0.0")
					ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", Term(1, CInt(i)), line_no, 5)
					ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 5}), "NumberFormat", "0.0")
					ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", CvTerm(1, CInt(i)), line_no, 6)
					ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 6}), "NumberFormat", "0.00E+00")
					ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", cV, line_no, 7)
					ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 7}), "NumberFormat", "0.00")
					If runofF > 0 Then ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", runofF, line_no, 8)
					ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 8}), "NumberFormat", "0.00")
				End If

			Next j

			'c gross nutrient balances

			For iC As Integer = 1 To 3
				If Iop(iC) > 0 Then

					line_no += 3
					ReflectionHelper.Invoke(ReflectionHelper.Invoke(Hdr, "Range", New Object() {"Header_Gross"}), "Copy", New Object() {})
					'UPGRADE_WARNING: (7006) The Named argument Destination was not resolved and corresponds to the following expression gLSht.Range().Offset() More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-7006
					ReflectionHelper.Invoke(gLSht, "Paste", New Object() {ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 0})}, New String() {"Destination"})

					ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", MassBalName(Iop(11)), line_no, 4)
					ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", VariableName(Imap(iC)), line_no + 1, 4)
					line_no += 3
					tW = Term(iC + 1, 9) 'total load
					Tf = Term(1, 9) 'total flow

					For i = 1 To NTrib
						If Icode(CInt(i)) < 5 And Iseg(CInt(i)) > 0 Then
							'    If (Icode(i) >= 5 Or Iseg(i) <= 0) Then Next i
							jseG = Iseg(CInt(i))
							If Icode(CInt(i)) = 2 Then
								cU = Concil(CInt(i), Imap(iC))
								cV = CvCil(CInt(i), Imap(iC))
								qU = FlowL(CInt(i))
								cvQ = CvFlowL(CInt(i))
							Else
								cU = Conci(CInt(i), Imap(iC))
								cV = CvCi(CInt(i), Imap(iC))
								qU = Flow(CInt(i))
								cvQ = CvFlow(CInt(i))
							End If
							'If Icode(i) = 4 And Iop(11) = 1 Then
							'    cU = Cest(jseG, iC)
							If Icode(CInt(i)) = 4 Then
								cU = Cuse(Cobs(CInt(jseG), iC), Cest(CInt(jseG), iC), Iop(11))
								cV = Ratv(Math.Sqrt(CvCest(CInt(jseG), iC)), cU)
							End If
							xL = qU * cU
							vaR = (cV ^ 2 + cvQ ^ 2) * xL ^ 2
							Export = Ratv(xL, Darea(CInt(i)))
							cV = Ratv(Math.Sqrt(vaR), xL)
							pL = Ratv(xL, tW)
							pV1 = Ratv(vaR, CvTerm(iC + 1, 9))
							If xL > 0 Then
								line_no += 1
								ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", i, line_no, 0)
								ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 0}), "HorizontalAlignment", Excel.Constants.xlCenter)
								ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", Icode(CInt(i)), line_no, 1)
								ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 1}), "HorizontalAlignment", Excel.Constants.xlCenter)
								ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", Iseg(CInt(i)), line_no, 2)
								ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 2}), "HorizontalAlignment", Excel.Constants.xlCenter)
								ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", TribName(CInt(i)), line_no, 3)
								ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", xL, line_no, 4)
								ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 4}), "NumberFormat", "0.0")
								If pL > 0 And Icode(CInt(i)) <> 4 Then
									ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", pL, line_no, 5)
									ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 5}), "NumberFormat", "0.0%")
								End If
								ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", vaR, line_no, 6)
								ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 6}), "NumberFormat", "0.00E+00")
								If pV1 > 0 And Icode(CInt(i)) <> 4 Then
									ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", pV1, line_no, 7)
									ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 7}), "NumberFormat", "0.0%")
								End If
								ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", cV, line_no, 8)
								ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 8}), "NumberFormat", "0.00")
								If cU > 0 Then ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", cU, line_no, 9)
								ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 9}), "NumberFormat", "0.0")
								If Export > 0 Then ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", Export, line_no, 10)
								ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 10}), "NumberFormat", "0.0")
							End If
						End If
					Next i
					'summary terms
					For j As Integer = 1 To Nkord
						i = Kord(j)
						If i <> 3 And Term(iC + 1, CInt(i)) <> 0 Then
							cU = 0
							Export = 0
							cV = 0
							If Not (i = 5 Or i = 15) Then
								cU = Ratv(Term(iC + 1, CInt(i)), Term(1, CInt(i)))
								Export = Ratv(Term(iC + 1, CInt(i)), Da(CInt(i)))
							End If
							cV = Ratv(Math.Sqrt(CvTerm(iC + 1, CInt(i))), Math.Abs(Term(iC + 1, CInt(i))))
							cV = MIn(cV, 9.999)
							pL = Ratv(Term(iC + 1, CInt(i)), tW)
							If i <= 2 Or i = 9 Or i = 13 Or i > 14 Then
								pV1 = Ratv(CvTerm(iC + 1, CInt(i)), CvTerm(iC + 1, 9))
							Else
								pV1 = 0
							End If
							line_no += 1
							ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", TermName(CInt(i)), line_no, 0)
							ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", Term(iC + 1, CInt(i)), line_no, 4)
							ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 4}), "NumberFormat", "0.0")
							If pL > 0 Then ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", pL, line_no, 5)
							ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 5}), "NumberFormat", "0.0%")
							ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", CvTerm(iC + 1, CInt(i)), line_no, 6)
							ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 6}), "NumberFormat", "0.00E+00")
							If pV1 > 0 Then ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", pV1, line_no, 7)
							ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 7}), "NumberFormat", "0.0%")
							ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", cV, line_no, 8)
							ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 8}), "NumberFormat", "0.00")
							If cU > 0 Then ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", cU, line_no, 9)
							ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 9}), "NumberFormat", "0.0")
							If Export > 0 Then ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", Export, line_no, 10)
							ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 10}), "NumberFormat", "0.0")

						End If
					Next j

					'C MASS BALANCE STATISTICS
					For i = 1 To 8
						x(CInt(i)) = 0
					Next i

					'C OVERFLOW RATE M/YR  BASED ON NET INFLOW
					If Area(Nseg + 1) > 0 Then x(1) = MAx((Term(1, 9) - Term(1, 3)) / Area(Nseg + 1), 0)

					'C RESIDENCE TIME (YRS)
					If x(1) > 0 Then x(2) = Zmn(Nseg + 1) / x(1)

					'C MEAN POOL CONC
					'        x(3) = Cobs(Nseg + 1, iC)
					'If iO > 1 Then x(3) = Cest(Nseg + 1, ic)  ' ?????
					'        If Iop(11) = 1 Or x(3) <= 0 Then x(3) = Cest(Nseg + 1, iC) ' fixed 4/1/2004
					x(3) = Cuse(Cobs(Nseg + 1, iC), Cest(Nseg + 1, iC), Iop(11))

					'C NUTRIENT RESIDENCE TIME
					x(4) = Ratv(Area(Nseg + 1) * Zmn(Nseg + 1) * x(3), Term(iC + 1, 9))

					'C TURNOVER RATIO
					x(5) = Ratv(P(1), x(4))

					'C RETENTION COEF
					x(6) = Ratv(Term(iC + 1, 5), Term(iC + 1, 9))


					line_no += 2
					ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", "Overflow Rate (m/yr)", line_no, 1)
					ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 4}), "NumberFormat", "0.0")
					ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", x(1), line_no, 4)

					line_no += 1
					ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", "Hydraulic Resid. Time (yrs)", line_no, 1)
					ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", x(2), line_no, 4)
					ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 4}), "NumberFormat", "0.0000")

					line_no += 1
					ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", "Reservoir Conc (mg/m3)", line_no, 1)
					ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", x(3), line_no, 4)
					ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 4}), "NumberFormat", "0")

					line_no -= 2
					ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", "Nutrient Resid. Time (yrs)", line_no, 6)
					ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", x(4), line_no, 9)
					ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 9}), "NumberFormat", "0.0000")

					line_no += 1
					ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", "Turnover Ratio", line_no, 6)
					ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", x(5), line_no, 9)
					ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 9}), "NumberFormat", "0.0")

					line_no += 1
					ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", "Retention Coef.", line_no, 6)
					ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", x(6), line_no, 9)
					ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 9}), "NumberFormat", "0.000")


				End If
			Next iC
		End With

	End Sub

	Sub Dumpa(ByVal io As Integer)
		Dim ioff As Integer

		'save mass balance solution matrix - debugging

		With Wkb.Sheets("matrix").Range("A1")
			If io = 0 Then
				ioff = 0
				.Cells.Clear()
				'.Range("A1:z999").ClearContents
			Else
				ioff = io * 12
			End If

			For i As Double = 1 To Nseg
				For j As Double = 1 To Nseg + 1
					If io < 2 Then
						NotUpgradedHelper.NotifyNotUpgradedElement("The following assignment/return was commented because it has incompatible types")
						'.Offset(i + ioff, j - 1) = A(CInt(i), CInt(j))
					Else
						NotUpgradedHelper.NotifyNotUpgradedElement("The following assignment/return was commented because it has incompatible types")
						'.Offset(i + ioff, j - 1) = Q(CInt(i), CInt(j))
					End If
				Next j
			Next i

		End With
	End Sub

	Sub List_Terms()
		Dim j As Integer

		'C IPRINT=5 SEGMENT WATER AND MASS BALANCES - FORMAT 2

		Dim k, iC As Integer

		'terms

		If NTrib <= 0 Then Exit Sub

		StartSheet("Summary Balances")

		With ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"})
			line_no = 0
			For jc As Integer = 1 To 4
				iC = jc - 1

				If Not (iC > 0 And Iop(iC) <= 0) Then

					For i As Integer = 1 To 10
						y(i) = 0
					Next i

					If iC = 0 Then

						Lord(8) = 3 'water balance - uses evaporation in last slot
						line_no += 1
						ReflectionHelper.Invoke(ReflectionHelper.Invoke(Hdr, "Range", New Object() {"Header_Wbal"}), "Copy", New Object() {})
						'UPGRADE_WARNING: (7006) The Named argument Destination was not resolved and corresponds to the following expression gLSht.Range().Offset() More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-7006
						ReflectionHelper.Invoke(gLSht, "Paste", New Object() {ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", New Object() {line_no, 0})}, New String() {"Destination"})
						ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", P(1), line_no, 5) 'Averaging Period

					Else

						Lord(8) = 5 'mass balance - uses net retention in last slot
						line_no += 2
						ReflectionHelper.Invoke(ReflectionHelper.Invoke(Hdr, "Range", New Object() {"Header_Mbal"}), "Copy", New Object() {})
						'UPGRADE_WARNING: (7006) The Named argument Destination was not resolved and corresponds to the following expression gLSht.Range().Offset() More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-7006
						ReflectionHelper.Invoke(gLSht, "Paste", New Object() {ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", New Object() {line_no, 0})}, New String() {"Destination"})
						ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", VariableName(Imap(iC)), line_no, 8)
						ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", MassBalName(Iop(11)), line_no, 3)
					End If
					line_no += 2

					For jseG As Double = 1 To Nseg
						k = MAx(iC, 1)
						Balas(jseG, k, Iop(11))
						For i As Integer = 1 To Mord
							j = Lord(i)
							If iC = 0 Then
								x(i) = Qt(j)
							Else
								x(i) = Bt(j)
							End If
						Next i


						If iC > 0 Then
							x(8) = Bt(5) - Bt(15) 'retention - internal load
							'x(7) = Bt(12) - Bt(8)   'net diffusive output
							x(7) = Bt(14) - Bt(13)
						Else
							x(7) = Exch(CInt(jseG))
						End If

						If Iout(CInt(jseG)) = 0 Then y(5) += x(5)
						For i As Integer = 1 To Mord
							If (i <> 5) Then y(i) += x(i)
						Next i
						line_no += 1
						ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", jseG, line_no, 0)
						ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", New Object() {line_no, 0}), "HorizontalAlignment", Excel.Constants.xlCenter)
						ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", SegName(CInt(jseG)), line_no, 1)
						For i As Integer = 1 To Mord
							ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", x(i), line_no, i + 1)
							ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", New Object() {line_no, i + 1}), "NumberFormat", "0")
						Next i

					Next jseG

					y(3) = 0
					y(7) = 0
					line_no += 1
					ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", "Net", line_no, 0)
					For i As Integer = 1 To Mord
						ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", y(i), line_no, i + 1)
						ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", New Object() {line_no, i + 1}), "NumberFormat", "0")
					Next i

				End If
			Next jc

		End With
	End Sub

	Sub List_SegBalances()
		Dim qU, Tf, tW, xL As Double

		'C IPRINT=4  WATER AND NUTRIENT BALANCES BY SEGMENT
		Dim i As Integer
		Dim cU As Single

		If NTrib <= 0 Then Exit Sub
		StartSheet("Segment Balances")

		With ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"})

			line_no = 0
			ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", "Segment Mass Balance Based Upon " & MassBalName(Iop(11)) & " Concentrations", line_no, 0)
			ReflectionHelper.LetMember(ReflectionHelper.GetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 0}), "Font"), "Bold", True)

			For jseG As Double = 1 To Nseg
				If Izap(CInt(jseG)) = 0 Then

					For iC As Integer = 1 To 3
						If Iop(iC) > 0 Then
							Balas(jseG, iC, Iop(11))

							line_no += 2
							ReflectionHelper.Invoke(ReflectionHelper.Invoke(Hdr, "Range", New Object() {"Header_segbal"}), "Copy", New Object() {})
							'UPGRADE_WARNING: (7006) The Named argument Destination was not resolved and corresponds to the following expression gLSht.Range().Offset() More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-7006
							ReflectionHelper.Invoke(gLSht, "Paste", New Object() {ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 0})}, New String() {"Destination"})
							ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", VariableName(Imap(iC)), line_no, 2)
							ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", jseG, line_no, 5)
							ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 5}), "HorizontalAlignment", Excel.Constants.xlCenter)
							ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", SegName(CInt(jseG)), line_no, 6)
							line_no += 2

							' 393    WRITE(NOUT,301) VariableName(IC),JSEG,SegName(JSEG)
							' 301    FORMAT(' COMPONENT: ',A8,20x,
							'     * '  SEGMENT:',I3,1X,a16/24x,
							'     * '     --- FLOW ---       --- LOAD ---         CONC'/
							'     * ' ID  T LOCATION         ',
							'     * '     HM3/YR      %       KG/YR      %       MG/M3')

							'C EXTERNAL LOAD COMPONENTS

							Tf = Qt(9)
							tW = Bt(9)
							For i = 1 To NTrib
								If Not (Iseg(i) <> jseG Or Icode(i) >= 5) Then
									If Icode(i) = 2 Then
										cU = Concil(i, Imap(iC))
										qU = FlowL(i)
									Else
										cU = Conci(i, Imap(iC))
										qU = Flow(i)
									End If
									'           If Icode(i) > 3 And Iop(11) = 1 Then cU = Cest(jseG, iC)
									If Icode(i) > 3 Then cU = Cuse(Cobs(CInt(jseG), iC), Cest(CInt(jseG), iC), Iop(11)) '4/11/2004

									xL = qU * cU
									If xL > 0 Then
										line_no += 1
										ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", i, line_no, 0)
										ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 0}), "HorizontalAlignment", Excel.Constants.xlCenter)
										ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", Icode(i), line_no, 1)
										ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 1}), "HorizontalAlignment", Excel.Constants.xlCenter)
										ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", TribName(i), line_no, 2)
										ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", qU, line_no, 3)
										ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 3}), "NumberFormat", "0.0")
										ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", Ratv(qU, Tf), line_no, 4)
										ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 4}), "NumberFormat", "0.0%")
										ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", xL, line_no, 5)
										ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 5}), "NumberFormat", "0.0")
										ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", Ratv(xL, tW), line_no, 6)
										ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 6}), "NumberFormat", "0.0%")
										If cU > 0 Then ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", cU, line_no, 7)
										ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 7}), "NumberFormat", "0")
									End If
								End If
							Next i

							'C SUMMARY TERMS

							For j As Integer = 1 To Njord
								i = Jord(j)
								If Not (j < Njord And Bt(i) = 0# And Qt(i) = 0#) Then
									cU = 0
									If (i <> 5 And i <> 15) Then cU = Ratv(Bt(i), Qt(i))
									line_no += 1
									ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", TermName(i), line_no, 0)
									ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", Qt(i), line_no, 3)
									ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 3}), "NumberFormat", "0.0")
									ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", Ratv(Qt(i), Tf), line_no, 4)
									ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 4}), "NumberFormat", "0.0%")
									ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", Bt(i), line_no, 5)
									ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 5}), "NumberFormat", "0.0")
									ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", Ratv(Bt(i), tW), line_no, 6)
									ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 6}), "NumberFormat", "0.0%")
									If cU > 0 Then
										ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", cU, line_no, 7)
										ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 7}), "NumberFormat", "0")
									End If
								End If
							Next j

							Hydrau(jseG)

							'        WRITE(NOUT,333) x'(3),x(4),zmn(jseg)
							'333    FORMAT(
							'   * ' RESID. TIME =',F8.3,' YRS, OVERFLOW RATE =',F8.1,' M/YR',
							'  * ', DEPTH =',F6.1,' M')

							line_no += 2
							ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", "Hyd. Residence Time =", line_no, 0)
							ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", x(3), line_no, 3)
							ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 3}), "NumberFormat", "0.0000")
							ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", " yrs", line_no, 4)

							line_no += 1
							ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", "Overflow Rate =", line_no, 0)
							ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", x(4), line_no, 3)
							ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 3}), "NumberFormat", "0.0")
							ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", " m/yr", line_no, 4)

							line_no += 1
							ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", "Mean Depth =", line_no, 0)
							ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", Zmn(CInt(jseG)), line_no, 3)
							ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 3}), "NumberFormat", "0.0")
							ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", " m", line_no, 4)


						End If
					Next iC
				End If
			Next jseG
		End With
	End Sub

	Sub List_TTests()
		Dim cV, i As Double
		Dim j, nord1 As Integer

		'C IPRINT=6 PRINT OBSERVED AND PREDICTED WQ

		line_no = 0
		StartSheet("T tests")

		With ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"})

			ReflectionHelper.Invoke(ReflectionHelper.Invoke(Hdr, "Range", New Object() {"Header_ttest1"}), "Copy", New Object() {})
			'UPGRADE_WARNING: (7006) The Named argument Destination was not resolved and corresponds to the following expression gLSht.Range().Offset() More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-7006
			ReflectionHelper.Invoke(gLSht, "Paste", New Object() {ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 0})}, New String() {"Destination"})
			line_no += 3

			For ii As Double = 1 To Nseg + 1
				If ii = 1 Then
					i = Nseg + 1
				Else
					i = ii - 1
				End If

				If Izap(CInt(i)) = 0 And Not (Nseg = 1 And ii = 1) Then

					line_no += 2
					ReflectionHelper.Invoke(ReflectionHelper.Invoke(Hdr, "Range", New Object() {"Header_ttest2"}), "Copy", New Object() {})
					'UPGRADE_WARNING: (7006) The Named argument Destination was not resolved and corresponds to the following expression gLSht.Range().Offset() More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-7006
					ReflectionHelper.Invoke(gLSht, "Paste", New Object() {ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 0})}, New String() {"Destination"})
					If i <= Nseg Then ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", i, line_no, 1)
					ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 1}), "HorizontalAlignment", Excel.Constants.xlCenter)
					ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", SegName(CInt(i)), line_no, 2)
					line_no += 2

					nord1 = 13
					For l As Integer = 1 To nord1
						j = Iord(l)
						If Cobs(CInt(i), j) > 0 And Cest(CInt(i), j) > 0 Then 'list only paired results
							For k As Integer = 1 To 4
								x(k) = 0
							Next k
							cV = Ratv(Math.Sqrt(CvCest(CInt(i), j)), Cest(CInt(i), j))
							If Cest(CInt(i), j) > 0 And Cobs(CInt(i), j) > 0 Then
								x(1) = Cobs(CInt(i), j) / Cest(CInt(i), j)
								y(1) = CvCobs(CInt(i), j)
								y(2) = Stat(j, 3)
								y(3) = Math.Sqrt(cV ^ 2 + CvCobs(CInt(i), j) ^ 2)
								y(4) = Math.Log(x(1))
								For k As Integer = 1 To 3
									If y(k) > 0 Then x(k + 1) = y(4) / y(k)
								Next k
								If Iop(9) <= 0 Then x(4) = 0
							End If
							line_no += 1
							ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", DiagName(j), line_no, 0)
							If Cobs(CInt(i), j) > 0 Then
								ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", Cobs(CInt(i), j), line_no, 1)
								ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 1}), "NumberFormat", "0.0")
								ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", CvCobs(CInt(i), j), line_no, 2)
								ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 2}), "NumberFormat", "0.00")
							End If
							ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", Cest(CInt(i), j), line_no, 3)
							ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 3}), "NumberFormat", "0.0")
							ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", cV, line_no, 4)
							ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 4}), "NumberFormat", "0.00")
							For k As Integer = 1 To 4
								If x(1) > 0 And x(k) <> 0 Then
									ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", x(k), line_no, 4 + k)
									ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 4 + k}), "NumberFormat", "0.00")
								End If
							Next k
						End If
					Next l

				End If
			Next ii
		End With
	End Sub

	Sub List_Diagnostics(ByVal io As Integer)
		Dim i As Double
		Dim j, k As Integer
		Dim kseG, p1, p2, t As Double

		'c iprint=7 diagnostics  io=0 predicted, io=1 predicted & observed

		line_no = 0
		StartSheet("Diagnostics")

		If io = 0 Then
			Status("Predicted")
		Else
			Status("Predicted & Observed")
		End If

		With ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"})
			If io = 1 Then
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", "Predicted & Observed Values Ranked Against CE Model Development Dataset", 0, 0)
			Else
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", "Predicted Values Ranked Against CE Model Development Dataset", 0, 0)
			End If
			ReflectionHelper.LetMember(ReflectionHelper.GetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {0, 0}), "Font"), "Bold", True)

			If Nseg = 1 Then
				kseG = 1
			Else
				kseG = Nseg + 1
			End If

			For ii As Double = 1 To kseG
				If ii = 1 Then
					i = kseG
				Else
					i = ii - 1
				End If

				If Izap(CInt(i)) = 0 Then

					line_no += 2
					If io = 0 Then
						ReflectionHelper.Invoke(ReflectionHelper.Invoke(Hdr, "Range", New Object() {"header_diag_0"}), "Copy", New Object() {})
					Else
						ReflectionHelper.Invoke(ReflectionHelper.Invoke(Hdr, "Range", New Object() {"Header_diag"}), "Copy", New Object() {})
					End If
					'UPGRADE_WARNING: (7006) The Named argument Destination was not resolved and corresponds to the following expression gLSht.Range().Offset() More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-7006
					ReflectionHelper.Invoke(gLSht, "Paste", New Object() {ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 0})}, New String() {"Destination"})

					ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", i, line_no, 1)
					ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 1}), "HorizontalAlignment", Excel.Constants.xlCenter)
					ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", SegName(CInt(i)), line_no, 2)
					line_no += 2

					For l As Integer = 1 To Nord
						j = Iord(l)
						If Not (Cobs(CInt(i), j) <= 0 And Cest(CInt(i), j) <= 0) Then

							'ranking
							If j > 19 And j < 26 Then 'chla freq
								k = 4
							ElseIf j = 26 Then  'tsip
								k = 2
							ElseIf j = 27 Then  'tsi chla
								k = 4
							ElseIf j = 28 Then  'tsi secchi
								k = 5
							Else
								k = j
							End If
							p1 = 0
							If Cobs(CInt(i), k) > 0 Then Rank(Cobs(CInt(i), k), Stat(k, 1), Stat(k, 2), t, p1)
							p2 = 0
							If Cest(CInt(i), k) > 0 Then Rank(Cest(CInt(i), k), Stat(k, 1), Stat(k, 2), t, p2)
							If j = 28 Then 'reverse ranking for
								If p1 > 0 Then p1 = 1 - p1
								If p2 > 0 Then p2 = 1 - p2
							End If

							line_no += 1
							ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", DiagName(j), line_no, 0)

							If Cest(CInt(i), j) > 0 Then
								ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", Cest(CInt(i), j), line_no, 1)
								If CvCest(CInt(i), j) > 0 Then ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", Math.Sqrt(CvCest(CInt(i), j)) / Cest(CInt(i), j), line_no, 2)
								If p2 > 0 Then ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", p2, line_no, 3)
								ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 3}), "NumberFormat", "0.0%")
								ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 1}), "NumberFormat", "0.0")
								ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 2}), "NumberFormat", "0.00")
							End If

							If Cobs(CInt(i), j) > 0 And io > 0 Then
								ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", Cobs(CInt(i), j), line_no, 4)
								If CvCobs(CInt(i), j) > 0 Then ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", CvCobs(CInt(i), j), line_no, 5)
								If p1 > 0 Then ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", p1, line_no, 6)
								ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 6}), "NumberFormat", "0.0%")
								ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 4}), "NumberFormat", "0.0")
								ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 5}), "NumberFormat", "0.00")
							End If



						End If

					Next l
				End If

			Next ii

		End With
	End Sub

	Sub Rank(ByVal x1 As Double, ByVal z1 As Double, ByVal z2 As Double, ByRef t As Double, ByRef perc As Double)
		perc = 0.5
		t = 0
		If x1 = z1 Then Exit Sub
		perc = 0
		If z2 * z1 <= 0 Or x1 <= 0 Then Exit Sub
		t = Math.Log(x1 / z1) / z2
		perc = Excel_Global_definst.Application.WorksheetFunction.NormSDist(t)
	End Sub

	Sub List_Profiles()
		Dim i, nord1 As Double

		'C IPRINT=8 PRINT PROFILES
		Dim kseG As Integer
		Dim sN As String = ""
		Dim kU As Integer

		line_no = 0
		StartSheet("Profiles")
		With ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"})

			If Nseg = 1 Then
				kseG = 1
			Else
				kseG = Nseg + 1
			End If

			ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", "Segment", line_no, 0)
			ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", " Name", line_no, 1)
			ReflectionHelper.LetMember(ReflectionHelper.GetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 1}), "Font"), "Bold", True)
			ReflectionHelper.LetMember(ReflectionHelper.GetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 0}), "Font"), "Bold", True)
			ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 0}), "HorizontalAlignment", Excel.Constants.xlCenter)
			For j As Double = 1 To kseG
				line_no += 1
				If j = Nseg + 1 Then
					ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", "Mean", line_no, 0)
					ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 0}), "HorizontalAlignment", Excel.Constants.xlRight)
				Else
					ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", j, line_no, 0)
				End If
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", " " & SegName(CInt(j)), line_no, 1)
			Next j

			line_no += 1

			For io As Integer = 1 To 5
				Select Case io
					Case 1
						sN = "PREDICTED CONCENTRATIONS:"
					Case 2
						sN = "OBSERVED CONCENTRATIONS:"
					Case 3
						sN = "OBSERVED/PREDICTED RATIOS:"
					Case 4
						sN = "OBSERVED STANDARD ERRORS"
					Case 5
						sN = "PREDICTED STANDARD ERRORS"
				End Select

				line_no += 2
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", sN, line_no, 0)
				ReflectionHelper.LetMember(ReflectionHelper.GetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 0}), "Font"), "Bold", True)

				line_no += 1

				'With .Range(.Offset(0, 0), .Offset(0, kseG + 1)).Font
				'    .Bold = True
				'    .Underline = True
				'End With

				For i = 1 To kseG
					ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", "Variable  Segment-->", line_no, 0)
					If i = Nseg + 1 Then
						ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", "Mean", line_no, i + 1)
						ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, i + 1}), "HorizontalAlignment", Excel.Constants.xlRight)
					Else
						ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", i, line_no, i + 1)
					End If
					ReflectionHelper.LetMember(ReflectionHelper.GetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 0}), "Font"), "Bold", True)
					ReflectionHelper.LetMember(ReflectionHelper.GetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, i + 1}), "Font"), "Bold", True)
					ReflectionHelper.LetMember(ReflectionHelper.GetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 0}), "Font"), "Underline", True)
					ReflectionHelper.LetMember(ReflectionHelper.GetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, i + 1}), "Font"), "Underline", True)
				Next i

				'       nord1 = 10
				nord1 = NDiagnostics
				For j As Double = 1 To nord1
					i = Iord(CInt(j))
					kU = 0
					For k As Double = 1 To kseG
						x(CInt(k)) = 0

						Select Case io
							Case 1
								x(CInt(k)) = Cest(CInt(k), CInt(i))
							Case 2
								x(CInt(k)) = Cobs(CInt(k), CInt(i))
							Case 3
								x(CInt(k)) = Ratv(Cobs(CInt(k), CInt(i)), Cest(CInt(k), CInt(i)))
							Case 4
								x(CInt(k)) = CvCobs(CInt(k), CInt(i)) * Cobs(CInt(k), CInt(i))
							Case 5
								x(CInt(k)) = Math.Sqrt(CvCest(CInt(k), CInt(i)))
						End Select
						If x(CInt(k)) > 0 Then kU = 1
					Next k

					If kU > 0 Then
						line_no += 1
						ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", DiagName(CInt(i)), line_no, 0)
						For k As Double = 1 To kseG
							If x(CInt(k)) > 0 Then ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", x(CInt(k)), line_no, k + 1)
							ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, k + 1}), "NumberFormat", "0.0")
						Next k
					End If

				Next j

			Next io

		End With

	End Sub

	Sub List_Verify()
		Dim be, j, wbe As Double
		'c verify segment balances

		If Iop(1) > 0 Then
			j = 1
		Else
			j = 2
		End If

		StartSheet("verify")
		line_no = 0
		With ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"})
			ReflectionHelper.Invoke(ReflectionHelper.Invoke(Hdr, "Range", New Object() {"header_verify"}), "Copy", New Object() {})
			'UPGRADE_WARNING: (7006) The Named argument Destination was not resolved and corresponds to the following expression gLSht.Range().Offset() More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-7006
			ReflectionHelper.Invoke(gLSht, "Paste", New Object() {ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {0, 0})}, New String() {"Destination"})
			ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", VariableName(CInt(j)), 0, 4)
			line_no += 2

			For i As Double = 1 To Nseg
				'Call Balas(i, j, 2)
				Balas(i, j, 1)
				wbe = Ratv(Qt(5), Qt(9))
				be = Ratv(Bt(5), Bt(9))
				line_no += 1
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", i, line_no, 0)
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 0}), "HorizontalAlignment", Excel.Constants.xlCenter)
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", SegName(CInt(i)), line_no, 1)
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", Qt(9), line_no, 2)
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 2}), "NumberFormat", "0")
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", Qt(5), line_no, 3)
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 3}), "NumberFormat", "0")
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", wbe, line_no, 4)
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 4}), "NumberFormat", "0.0%")
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", Bt(9), line_no, 5)
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 5}), "NumberFormat", "0")
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", Bt(5), line_no, 6)
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 6}), "NumberFormat", "0")
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", be, line_no, 7)
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 7}), "NumberFormat", "0.0%")
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", Qadv(CInt(i)), line_no, 8)
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 8}), "NumberFormat", "0")
			Next i

		End With

		'          write(nout,12) i,SegName(i),qt(9),qt(5),wbe,bt(9),bt(5),be,
		'     &      qadv(i)
		' 12     format(i3,1x,a8,f11.2,f10.2,f6.2,f11.2,f10.2,f6.2,f10.2)

	End Sub
	Function StrSp(ByVal j As Integer, ByVal s As String) As String
		'returns string of fixed length j
		Return (s & New String(" "c, j)).Substring(0, Math.Min(j, (s & New String(" "c, j)).Length))
	End Function

	Sub List_Tree()
		'List Segment & Tributary Network

		SegName(0) = "Out of Reservoir"
		StartSheet("Segment Network")
		line_no = 0
		With ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"})

			ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", "Segment & Tributary Network", line_no, 0)
			ReflectionHelper.LetMember(ReflectionHelper.GetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 0}), "Font"), "Bold", True)

			For i As Double = 1 To Nseg

				line_no += 2
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", "--------Segment:", line_no, 0)
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 0}), "HorizontalAlignment", Excel.Constants.xlRight)
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", i, line_no, 1)
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 1}), "HorizontalAlignment", Excel.Constants.xlCenter)
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", SegName(CInt(i)), line_no, 2)

				line_no += 1
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", "Outflow Segment:", line_no, 0)
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 0}), "HorizontalAlignment", Excel.Constants.xlRight)
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", Iout(CInt(i)), line_no, 1)
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 1}), "HorizontalAlignment", Excel.Constants.xlCenter)
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", SegName(Iout(CInt(i))), line_no, 2)

				For j As Double = 1 To NTrib
					If Iseg(CInt(j)) = i Then
						line_no += 1
						ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", "Tributary:", line_no, 0)
						ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 0}), "HorizontalAlignment", Excel.Constants.xlRight)
						ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", j, line_no, 1)
						ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 1}), "HorizontalAlignment", Excel.Constants.xlCenter)
						ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", TribName(CInt(j)), line_no, 2)
						ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", "Type:", line_no, 3)
						ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 3}), "HorizontalAlignment", Excel.Constants.xlRight)
						ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", Type_Code(Icode(CInt(j))), line_no, 4)
					End If
				Next j

				For j As Double = 1 To Npipe

					If Ifr(CInt(j)) = i Then
						line_no += 1
						ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", "Channel:", line_no, 0)
						ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 0}), "HorizontalAlignment", Excel.Constants.xlRight)
						ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", j, line_no, 1)
						ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 1}), "HorizontalAlignment", Excel.Constants.xlCenter)
						ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", PipeName(CInt(j)), line_no, 2)
						ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", " To Segment:", line_no, 3)
						ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", New Object() {line_no, 3}), "HorizontalAlignment", Excel.Constants.xlRight)
						ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A4"}), "Offset", StringsHelper.Format(Ito(CInt(j)), "00") & " " & SegName(Ito(CInt(j))), line_no, 4)
					End If
				Next j

			Next i
		End With
	End Sub

	Sub List_Tree2()
		Dim npipes As Double
		'List Segment & Tributary Network


		SegName(0) = "Out of Reservoir"
		Dim txt As New StringBuilder()
		txt.Append(Title & Environment.NewLine)
		txt.Append("Segment & Tributary Network" & Environment.NewLine & Environment.NewLine)

		For i As Double = 1 To Nseg
			txt.Append("----Segment: " & StringsHelper.Format(i, "00") & " " & SegName(CInt(i)) & Environment.NewLine)
			txt.Append("Outflow Seg: " & StringsHelper.Format(Iout(CInt(i)), "00") & " " & SegName(Iout(CInt(i))) & Environment.NewLine)
			For j As Double = 1 To NTrib
				If Iseg(CInt(j)) = i Then txt.Append("  Tributary: " & StringsHelper.Format(j, "00") & " " & StrSp(20, TribName(CInt(j))) & "   Type: " & Type_Code(Icode(CInt(j))) & Environment.NewLine)
			Next j
			For j As Double = 1 To npipes
				If Ifr(CInt(j)) = i Then txt.Append("    Channel: " & StringsHelper.Format(j, "00") & " " & StrSp(20, PipeName(CInt(j))) & "    To Segment: " & Ito(CInt(j)).ToString() & " " & SegName(Ito(CInt(j))) & Environment.NewLine)
			Next j
			txt.Append(Environment.NewLine)
		Next i

		With frmBox.DefInstance
			.txtBox.Text = txt.ToString()
			.txtBox.SelectionStart = 0
			.ShowDialog()
		End With

	End Sub
	Sub List_inss()
		Status("Inputs")
		gLSht = Wkb.Sheets("Inputs")
		Save_xls() 'save inputs to wkb
		If Ier > 0 Then Exit Sub
		'    Set gLSht = Wkb.Worksheets("inputs")
		ViewSheet("inputs")
		Status("Ready")

	End Sub
	Sub List_Inputs()
		Dim t As Double
		Dim k As Integer
		StartSheet("Case Data")

		line_no = 0
		With ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"})

			ReflectionHelper.Invoke(ReflectionHelper.Invoke(Hdr, "Range", New Object() {"header_in_top"}), "Copy", New Object() {ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", New Object() {line_no, 0})})

			For i As Integer = 1 To 10
				line_no += 1
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", Note(i), line_no, 1)
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", New Object() {line_no, 1}), "WrapText", False)
			Next i

			'global variables
			line_no += 2
			k = line_no
			For i As Integer = 1 To 4
				line_no += 1
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", P(i), line_no, 2)
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", Cp(i), line_no, 3)
			Next i

			'atmospheric loads
			line_no += 2
			For i As Integer = 1 To NVariables
				line_no += 1
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", New Object() {line_no, 2}), "Value", Atm(i))
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", New Object() {line_no, 3}), "Value", CvAtm(i))
			Next i

			'Model Options
			line_no = k
			For i As Integer = 1 To NOptions
				line_no += 1
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", Iop(i), line_no, 9)
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", New Object() {line_no, 9}), "HorizontalAlignment", Excel.Constants.xlCenter)
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", OptionName(i, Iop(i) + 1), line_no, 10)
			Next i

			'segment list
			line_no += 4
			For i As Integer = 1 To Nseg
				line_no += 1
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", i, line_no, 0)
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", New Object() {line_no, 0}), "HorizontalAlignment", Excel.Constants.xlCenter)
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", SegName(i), line_no, 1)
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", Iout(i), line_no, 3)
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", Iag(i), line_no, 4)
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", Area(i), line_no, 5)
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", Zmn(i), line_no, 6)
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", Slen(i), line_no, 7)
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", Zmx(i), line_no, 8)
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", CvZmx(i), line_no, 9)
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", Zhyp(i), line_no, 10)
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", CvZhyp(i), line_no, 11)
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", Turbi(i), line_no, 12)
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", CvTurbi(i), line_no, 13)
				For j As Integer = 1 To 3
					ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", InternalLoad(i, j), line_no, 12 + j * 2)
					ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", CvInternalLoad(i, j), line_no, 12 + j * 2 + 1)
				Next j
			Next i
			line_no += 2

			'segment observed water quality
			ReflectionHelper.Invoke(ReflectionHelper.Invoke(Hdr, "Range", New Object() {"header_in_obswq"}), "Copy", New Object() {ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", New Object() {line_no, 0})})
			line_no += 2
			For i As Integer = 1 To Nseg
				line_no += 1
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", i, line_no, 0)
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", New Object() {line_no, 0}), "HorizontalAlignment", Excel.Constants.xlCenter)
				For j As Integer = 1 To 9
					ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", Cobs(i, j), line_no, -1 + j * 2)
					ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", CvCobs(i, j), line_no, 0 + j * 2)
				Next j
			Next i

			line_no += 2

			'calibration factors
			ReflectionHelper.Invoke(ReflectionHelper.Invoke(Hdr, "Range", New Object() {"header_in_calibfactors"}), "Copy", New Object() {ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", New Object() {line_no, 0})})
			line_no += 2
			For i As Integer = 1 To Nseg
				line_no += 1
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", i, line_no, 0)
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", New Object() {line_no, 0}), "HorizontalAlignment", Excel.Constants.xlCenter)
				For j As Integer = 1 To 9
					ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", Cal(i, j), line_no, -1 + j * 2)
					ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", CvCal(i, j), line_no, 0 + j * 2)
				Next j
			Next i

			'tributaries
			line_no += 2
			ReflectionHelper.Invoke(ReflectionHelper.Invoke(Hdr, "Range", New Object() {"header_in_tribs"}), "Copy", New Object() {ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", New Object() {line_no, 0})})
			line_no += 2
			For i As Integer = 1 To NTrib
				line_no += 1
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", i, line_no, 0)
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", New Object() {line_no, 0}), "HorizontalAlignment", Excel.Constants.xlCenter)
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", TribName(i), line_no, 1)
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", Iseg(i), line_no, 3)
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", Icode(i), line_no, 4)
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", Darea(i), line_no, 5)
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", Flow(i), line_no, 6)
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", CvFlow(i), line_no, 7)
				For j As Integer = 1 To NVariables
					ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", Conci(i, j), line_no, 6 + 2 * j)
					ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", CvCi(i, j), line_no, 7 + 2 * j)
				Next j
			Next i

			'trib nonpoint areas
			t = 0
			For i As Integer = 1 To NTrib
				For j As Integer = 1 To NCAT
					t += Warea(i, j)
				Next j
			Next i

			If t > 0 Then
				line_no += 2
				ReflectionHelper.Invoke(ReflectionHelper.Invoke(Hdr, "Range", New Object() {"header_in_areas"}), "Copy", New Object() {ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", New Object() {line_no, 0})})
				line_no += 2
				For i As Integer = 1 To NTrib
					line_no += 1
					ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", i, line_no, 0)
					ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", New Object() {line_no, 0}), "HorizontalAlignment", Excel.Constants.xlCenter)
					ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", TribName(i), line_no, 1)
					For j As Integer = 1 To NCAT
						ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", Warea(i, j), line_no, 2 + j)
					Next j
				Next i
			End If

			' Channels

			If Npipe > 0 Then
				line_no += 2
				ReflectionHelper.Invoke(ReflectionHelper.Invoke(Hdr, "Range", New Object() {"header_in_transport"}), "Copy", New Object() {ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", New Object() {line_no, 0})})
				line_no += 2
				For i As Integer = 1 To Npipe
					line_no += 1
					ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", i, line_no, 0)
					ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", New Object() {line_no, 0}), "HorizontalAlignment", Excel.Constants.xlCenter)
					ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", PipeName(i), line_no, 1)
					ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", Ifr(i), line_no, 3)
					ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", Ito(i), line_no, 4)
					ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", Qpipe(i), line_no, 5)
					ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", CvQpipe(i), line_no, 6)
					ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", Epipe(i), line_no, 7)
					ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", CvEpipe(i), line_no, 8)
				Next i
			End If

			'export categories
			t = 0
			For i As Integer = 1 To NCAT
				t += Ur(i)
			Next i

			If t > 0 Then
				line_no += 2
				ReflectionHelper.Invoke(ReflectionHelper.Invoke(Hdr, "Range", New Object() {"header_in_export"}), "Copy", New Object() {ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", New Object() {line_no, 0})})
				line_no += 2
				For i As Integer = 1 To NCAT
					line_no += 1
					ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", i, line_no, 0)
					ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", New Object() {line_no, 14}), "HorizontalAlignment", Excel.Constants.xlCenter)
					ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", LandUseName(i), line_no, 1)
					ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", Ur(i), line_no, 3)
					ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", CvUr(i), line_no, 4)
					For k = 1 To NVariables
						ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", Uc(i, k), line_no, 3 + k * 2)
						ReflectionHelper.LetMember(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", CvUc(i, k), line_no, 4 + k * 2)
					Next k
				Next i
			End If

			'coefficients
			line_no += 2
			ReflectionHelper.Invoke(ReflectionHelper.Invoke(Hdr, "Range", New Object() {"header_in_last"}), "Copy", New Object() {ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", New Object() {line_no, 0})})
			For i As Integer = 1 To NXk
				line_no += 1
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", New Object() {line_no, 3}), "Value", Xk(i))
				ReflectionHelper.LetMember(ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Range", New Object() {"A3"}), "Offset", New Object() {line_no, 4}), "Value", CvXk(i))
			Next i

		End With
	End Sub
End Module