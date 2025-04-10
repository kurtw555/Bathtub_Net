Option Strict Off
Option Explicit On
Imports System
Module Module7
	'seg & tributary edits
	Sub SegmentEdit(ByVal jseG As Double, ByVal io As Integer)
		Dim j As Double

		'c io=0 delete, io=1 insert, io=2 copy, a segment


		Select Case io
			'c delete segment
			Case 0
				'c first update segment references
				If Nseg <= 1 Then Exit Sub
				For i As Double = 1 To Nseg
					If Iout(CInt(i)) = jseG Then Iout(CInt(i)) = Iout(CInt(jseG))
				Next i

				For i As Double = 1 To Nseg
					If (Iout(CInt(i)) > jseG) Then Iout(CInt(i)) -= 1
				Next i

				'c now copy segments after deleted one
				For i As Double = jseG To Nseg - 1
					SegCopy(i + 1, i)
				Next i
				SegZero(Nseg)
				Nseg -= 1

				'c update tributary refs
				For i As Double = 1 To NTrib
					If Iseg(CInt(i)) = jseG Then
						'                    MsgBox( "Tributary " & i & " " & TribName(i) & " Assigned to Segment 0"
						'UPGRADE_ERROR: (1010) The preceding line couldn't be parsed. More Information: https://docs.mobilize.net/vbuc/ewis#id-#1010
						Iseg(CInt(i)) = 0
					ElseIf (Iseg(CInt(i)) > jseG) Then 
						Iseg(CInt(i)) -= 1
					End If
				Next i

				'c update pipe references
				For i As Double = 1 To Npipe
					If Ifr(CInt(i)) = jseG Or Ito(CInt(i)) = jseG Then
						'                    MsgBox( "Channel " & i & " " & PipeName(i) & " Assigned to Segment 0"
						'UPGRADE_ERROR: (1010) The preceding line couldn't be parsed. More Information: https://docs.mobilize.net/vbuc/ewis#id-#1010
						Ifr(CInt(i)) = 0
						Ito(CInt(i)) = 0
					End If
					If (Ifr(CInt(i)) > jseG) Then Ifr(CInt(i)) -= 1
					If (Ito(CInt(i)) > jseG) Then Ito(CInt(i)) -= 1
				Next i

				'c insert segment
			Case 1

				'c first update segment references
				If Nseg >= NSMAX - 1 Then Exit Sub
				For i As Double = 1 To Nseg
					If (Iout(CInt(i)) > jseG) Then Iout(CInt(i)) += 1
				Next i

				'c insert a new segment after jseg
				j = Nseg + 1
				For i As Double = jseG + 1 To Nseg
					j -= 1
					SegCopy(j, j + 1)
				Next i
				'             Call SegCopy(NSMAX, jseg + 1)
				SegZero(jseG + 1)
				SegName(CInt(jseG + 1)) = "????????"
				Nseg += 1

				'c update trib references
				For i As Double = 1 To NTrib
					If (Iseg(CInt(i)) > jseG) Then Iseg(CInt(i)) += 1
				Next i

				'c update pipe references
				For i As Double = 1 To Npipe
					If (Ifr(CInt(i)) > jseG) Then Ifr(CInt(i)) += 1
					If (Ito(CInt(i)) > jseG) Then Ito(CInt(i)) += 1
				Next i

		End Select

	End Sub

	Sub SegCopy(ByVal i As Double, ByVal j As Double)

		'c copy segment data from segment i to segment j

		Area(CInt(j)) = Area(CInt(i))
		Zmn(CInt(j)) = Zmn(CInt(i))
		Zmx(CInt(j)) = Zmxi(CInt(i))
		SegName(CInt(j)) = SegName(CInt(i))
		Iout(CInt(j)) = Iout(CInt(i))
		Iag(CInt(j)) = Iag(CInt(i))
		Zhyp(CInt(j)) = Zhyp(CInt(i))
		Slen(CInt(j)) = Slen(CInt(i))
		CvZmxi(CInt(j)) = CvZmxi(CInt(i))
		CvZhyp(CInt(j)) = CvZhyp(CInt(i))
		Turbi(CInt(j)) = Turbi(CInt(i))
		CvTurbi(CInt(j)) = CvTurbi(CInt(i))
		Targ(CInt(j)) = Targ(CInt(i))

		For k As Integer = 1 To 7
			CvCal(CInt(j), k) = CvCal(CInt(i), k)
			Cal(CInt(j), k) = Cal(CInt(i), k)
			InternalLoad(CInt(j), k) = InternalLoad(CInt(i), k)
			CvInternalLoad(CInt(j), k) = CvInternalLoad(CInt(i), k)
		Next k

		For k As Integer = 1 To 9
			Cobs(CInt(j), k) = Cobs(CInt(i), k)
			CvCobs(CInt(j), k) = CvCobs(CInt(i), k)
		Next k

	End Sub
	Sub SegZero(ByVal j As Double)
		'c zero data for segment j

		Area(CInt(j)) = 0
		Zmn(CInt(j)) = 0
		Zmxi(CInt(j)) = 0
		SegName(CInt(j)) = ""
		Iout(CInt(j)) = 0
		Iag(CInt(j)) = 1
		Zhyp(CInt(j)) = 0
		Slen(CInt(j)) = 0
		CvZmxi(CInt(j)) = 0
		CvZhyp(CInt(j)) = 0
		Turbi(CInt(j)) = 0
		CvTurbi(CInt(j)) = 0
		Targ(CInt(j)) = 0
		Izap(CInt(j)) = 0

		For k As Integer = 1 To 7
			InternalLoad(CInt(j), k) = 0
			CvInternalLoad(CInt(j), k) = 0
		Next k

		For k As Integer = 1 To 9
			CvCal(CInt(j), k) = 0
			Cal(CInt(j), k) = 1
			Cobs(CInt(j), k) = 0
			CvCobs(CInt(j), k) = 0
		Next k

	End Sub
	Sub TribEdit(ByVal jtriB As Double, ByVal io As Integer)
		Dim j As Double

		'c delete, insert, copy, a tribtary


		'             write(*,11) (i,tname(i),i=1 to Ntrib)
		' 11          format(' CURRENT TRIBUTARY LIST:'/ 3(i3,' = ',a14))
		'             write(*,*)
		'             If (io <= 0) Then
		'                write(*,*) 'SELECT TRIBUTARY  TO DELETE'
		'             else if(io = 1) then
		'                write(*,*) 'INSERT NEW TRIBUTARY AFTER '
		'             Else
		'                write(*,*) 'SELECT TRIBUTARY TO COPY FROM '
		'             End If

		'             jtrib=iinp(0,'enter tributary , <0> to quit ?   ')
		'             if(inbet(jtrib,1 to Ntrib) <= 0) return


		Select Case io
			'c delete trib
			Case 0
				If NTrib <= 1 Then Exit Sub
				For i As Double = jtriB To NTrib - 1
					TribCopy(i + 1, i)
				Next i
				TribZero(NTrib)
				NTrib -= 1
			Case 1

				'c insert a new tributary after jtrib
				If NTrib >= NTMAX - 1 Then Exit Sub
				j = NTrib + 1
				For i As Double = jtriB + 1 To NTrib
					j -= 1
					TribCopy(j, j + 1)
				Next i
				'        Area(NSMAX) = 0
				'        Zmn(NSMAX) = 0
				'        Call Tcopy(NTMAX, jtrib + 1)
				TribZero(jtriB + 1)
				TribName(CInt(jtriB + 1)) = "????????"
				NTrib += 1

				'c copy a number of tribs

				'              write(*,41) jtrib
				'  41          format(' copy trib ',i3, ' to tribs  A thru B')
				'              j1=iinp(0,'enter first output trib A ?   ')
				'              if(inbet(j1 to 1 to ntmax) <= 0) return
				'              j2=iinp(0,'enter last output trib B ?   ')
				'              if(inbet(j2,1 to ntmax) <= 0 or j2 < j1) return

				'              For i = j1 To j2
				'                 Call Tcopy(Jtrib, i)
				'                 Next i
				'              NTrib = MAx(n, j2)

		End Select

		'             Call clr(0)
		'             write(*,*)
		'     &       'NOW EDIT TRIBUTARY DATA TO CORRECT SEGMENT REFERENCES'
		'             i = ihold(0)
		'             Call clr(0)
		'             Call edit(4)
		'             GoTo 10
	End Sub

	Sub TribCopy(ByVal i As Double, ByVal j As Double)
		'c copy trib data from trib i to trib j

		Darea(CInt(j)) = Darea(CInt(i))
		TribName(CInt(j)) = TribName(CInt(i))
		Iseg(CInt(j)) = Iseg(CInt(i))
		Icode(CInt(j)) = Icode(CInt(i))
		Flow(CInt(j)) = Flow(CInt(i))
		CvFlow(CInt(j)) = CvFlow(CInt(i))
		Ecoreg(CInt(j)) = Ecoreg(CInt(i))

		For k As Double = 1 To NCAT
			Warea(CInt(j), CInt(k)) = Warea(CInt(i), CInt(k))
		Next k

		For k As Double = 1 To 7
			Conci(CInt(j), CInt(k)) = Conci(CInt(i), CInt(k))
			CvCi(CInt(j), CInt(k)) = CvCi(CInt(i), CInt(k))
		Next k

	End Sub
	Sub TribZero(ByVal j As Double)
		'reset all data for trib j
		Darea(CInt(j)) = 0
		TribName(CInt(j)) = ""
		Iseg(CInt(j)) = 1
		Icode(CInt(j)) = 1
		Flow(CInt(j)) = 0
		CvFlow(CInt(j)) = 0
		Ecoreg(CInt(j)) = 0

		For k As Double = 1 To NCAT
			Warea(CInt(j), CInt(k)) = 0
		Next k

		For k As Double = 1 To 7
			Conci(CInt(j), CInt(k)) = 0
			CvCi(CInt(j), CInt(k)) = 0
		Next k
	End Sub
	Sub PipeZero(ByVal k As Double)
		'reset all data for pipe j

		PipeName(CInt(k)) = ""
		Ito(CInt(k)) = 0
		Ifr(CInt(k)) = 0
		Qpipe(CInt(k)) = 0
		CvQpipe(CInt(k)) = 0
		Epipe(CInt(k)) = 0
		CvEpipe(CInt(k)) = 0

	End Sub

	Sub PipeCopy(ByVal i As Double, ByVal j As Integer)
		'copy data from pipe i to pipe j

		PipeName(j) = PipeName(CInt(i))
		Ito(j) = Ito(CInt(i))
		Ifr(j) = Ifr(CInt(i))
		Qpipe(j) = Qpipe(CInt(i))
		CvQpipe(j) = CvQpipe(CInt(i))
		Epipe(j) = Epipe(CInt(i))
		CvEpipe(j) = CvEpipe(CInt(i))

	End Sub

	Sub AllZero()
		Dim NOPptions As Double
		'zero all input values

		'reset output variables
		Ycopy_In()
		For i As Double = 1 To Nye
			Cye(CInt(i)) = 0
		Next i
		Ycopy_Out()

		'reset all input variables
		For i As Double = 0 To NTMAX
			TribZero(i)
		Next i
		For i As Double = 0 To NSMAX
			SegZero(i)
		Next i
		For i As Double = 0 To NPMAX
			PipeZero(i)
		Next i

		For i As Double = 0 To NOPptions
			Iop(CInt(i)) = IopDefault(CInt(i))
		Next i

		For i As Double = 0 To NXk
			Xk(CInt(i)) = XkDefault(CInt(i))
			CvXk(CInt(i)) = CvXkDefault(CInt(i))
		Next i

		For i As Double = 1 To NCAT
			Ur(CInt(i)) = 0
			CvUr(CInt(i)) = 0
			For j As Double = 1 To NVariables
				Uc(CInt(i), CInt(j)) = 0
				CvUc(CInt(i), CInt(j)) = 0
			Next j
		Next i

		Nseg = 1
		NTrib = 1
		Npipe = 0

		SegName(1) = "Segment 1"
		TribName(1) = "Trib 1"

		For i As Double = 1 To NGlobals
			P(CInt(i)) = 0
			Cp(CInt(i)) = 0
		Next i
		P(1) = 1 'period length

		For i As Double = 1 To 10
			Note(CInt(i)) = ""
		Next i

		Title = ""
		ErrTxt = ""
		Nmsg = 0
		Icalc = 0

	End Sub
End Module