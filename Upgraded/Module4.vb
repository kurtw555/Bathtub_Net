Option Strict Off
Option Explicit On
Imports Excel = Microsoft.Office.Interop.Excel
Imports Microsoft.VisualBasic
Imports System
Imports UpgradeHelpers.Helpers
Module Module4
	Function SheetExists(ByVal ShtName As String) As Boolean
		'returns true if sheet exists in the active workbook
		'UPGRADE_TODO: (1069) Error handling statement (On Error Resume Next) was converted to a pattern that might have a different behavior. More Information: https://docs.mobilize.net/vbuc/ewis/todos#id-1069
		Dim result As Boolean = False
		Try
			Dim X99 As Object = Excel_Global_definst.ActiveWorkbook.Sheets(ShtName)
			If Information.Err().Number = 0 Then result = True Else result = False
			Information.Err().Clear()

		Catch exc As Exception
			NotUpgradedHelper.NotifyNotUpgradedElement("Resume in On-Error-Resume-Next Block")
		End Try
		Return result
	End Function

	Function FileExists(ByVal Fname As String) As Boolean
		'returns true if the file exists
		'UPGRADE_WARNING: (2099) Return value for Dir has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-2099
		Dim X99 As String = FileSystem.Dir(Fname)
		'MsgBox( "fileexists: " & Fname & " " & ss
		Return X99 <> ""
	End Function

	Function WorkbookIsOpen(ByVal wbname As String) As Boolean
		'returns true if workbook is open
		'UPGRADE_TODO: (1069) Error handling statement (On Error Resume Next) was converted to a pattern that might have a different behavior. More Information: https://docs.mobilize.net/vbuc/ewis/todos#id-1069
		Dim result As Boolean = False
		Try
			Dim X99 As Excel.Workbook = Excel_Global_definst.Workbooks(wbname)
			If Information.Err().Number = 0 Then result = True Else result = False
			Information.Err().Clear()

		Catch exc As Exception
			NotUpgradedHelper.NotifyNotUpgradedElement("Resume in On-Error-Resume-Next Block")
		End Try
		Return result
	End Function

	Function PathExists(ByVal Pname As String) As Boolean
		'returns true if path exists
		'UPGRADE_TODO: (1069) Error handling statement (On Error Resume Next) was converted to a pattern that might have a different behavior. More Information: https://docs.mobilize.net/vbuc/ewis/todos#id-1069
		Dim result As Boolean = False
		Try
			Dim X99 As String = CStr(FileSystem.GetAttr(Pname) <> FileAttribute.Normal And 0)
			If StringsHelper.ToDoubleSafe(Conversion.ErrorToString()) = 0 Then result = True Else result = False

		Catch exc As Exception
			NotUpgradedHelper.NotifyNotUpgradedElement("Resume in On-Error-Resume-Next Block")
		End Try
		Return result
	End Function

	Function ExtractPath(ByVal Spec As String) As String
		'extract pathname from filename
		Dim SpecLen As Integer = Strings.Len(Spec)
		For i As Integer = SpecLen To 1 Step -1
			If Spec.Substring(Math.Min(i - 1, Spec.Length), Math.Min(1, Math.Max(0, Spec.Length - (i - 1)))) = "\" Then
				Return Spec.Substring(0, Math.Min(i - 1, Spec.Length))
			End If
		Next i
		Return ""
	End Function

	Function ExtractFile(ByVal Spec As String) As String
		'extract file name from filename
		Dim SpecLen As Integer = Strings.Len(Spec)
		For i As Integer = SpecLen To 1 Step -1
			If Spec.Substring(Math.Min(i - 1, Spec.Length), Math.Min(1, Math.Max(0, Spec.Length - (i - 1)))) = "\" Then
				Return Spec.Substring(Math.Min(i, Spec.Length))
			End If
		Next i
		Return ""
	End Function


	Function FormatF(ByVal xx As Double, ByVal fs As String) As String
		'fixed length format
		Dim i As Integer = Strings.Len(fs)
		Dim s As String = StringsHelper.Format(xx, fs)
		Dim k As Integer = Strings.Len(s)
		Return New String(" "c, i - k) & s
	End Function


	'Sub SelectTest()
	'StartUp
	'ReadInputs
	'SelectSegment3
	'SelectCalib
	'SelectSegment

	'i = JSegs(Nseg + 1)
	'i = Jtribs(n)
	'MsgBox( "Selected = " & i

	'Call SelSegs(Nseg)

	'End Sub
	'Sub SelectOne(nN, choiceS, capT, helpiD, isel)
	'select single value
	'isel = 0
	'If nN = 0 Then Exit Sub

	'If nN = 1 Then
	'    SelectOne = 1
	'    Exit Function
	'    End If

	'adjust dimensions
	'kd = 300
	'ioff = MIn(nN, 20) * kd
	'frmSelectOne.Height = ioff + 10 * kd
	'frmSelectOne.ListBox1.Height = ioff
	'frmSelectOne.CancelButton.top = ioff + kd
	'frmSelectOne.OKButton.top = ioff + kd
	'frmSelectOne.HelpButton.top = ioff + kd

	'frmSelectOne.Caption = capT
	'frmSelectOne.ListBox1.MultiSelect = 0
	'Ihelp = helpiD
	'MsgBox( "setting up form"
	'With frmSelectOne.ListBox1
	'    .Clear
	'    For i = 1 To nN
	'        .AddItem Format(i, "00") & " " & choiceS(i)
	'        Next i
	'    End With
	'frmSelectOne.Show vbModal

	'MsgBox( "returning from form"
	'If Ichoice > 0 Then
	'    isel = Ichoice
	'    'MsgBox( "Selected Item =" & Ichoice & " " & choiceS(Ichoice)
	'    End If
	''nd Sub

	'Sub SelectMany(nN, choiceS, capT, helpiD, isel)
	'
	'For i = 1 To nN
	'    isel(i) = 0
	'    Next i
	'If nN = 0 Then Exit Sub
	'
	'If nN = 1 Then
	'    SelectOne = 1
	'    Exit Function
	'    End If

	'adjust dimensions
	'ioff = MIn(nN, 20) * 11
	'frmSelectOne.Height = ioff + 60
	'frmSelectOne.ListBox1.Height = ioff
	'frmSelectOne.CancelButton.top = ioff + 11
	'frmSelectOne.OKButton.top = ioff + 11
	'frmSelectOne.HelpButton.top = ioff + 11
	'frmSelectOne.Caption = capT
	'frmSelectOne.ListBox1.MultiSelect = 1
	'Ihelp = helpiD
	'MsgBox( ioff
	'With frmSelectOne.ListBox1
	'    .RowSource = ""
	'    For i = 1 To nN
	'        .AddItem Format(i, "00") & " " & choiceS(i)
	'        Next i
	'    End With
	'frmSelectOne.Show
	'End Sub

	'Sub SelectSegment()
	'select single segment
	'If Nseg = 1 Then
	'    jseG = 1
	'    Exit Sub
	'    End If

	'adjust dimensions
	'ioff = Nseg * 11
	'SegmentForm.Height = ioff + 60
	'SegmentForm.ListBox1.Height = ioff
	'SegmentForm.CancelButton.Top = ioff + 11
	'SegmentForm.OKButton.Top = ioff + 11
	'SegmentForm.HelpButton.Top = ioff + 11

	'With SegmentForm.ListBox1
	'    .Clear
	'    For i = 1 To Nseg
	'        .AddItem Format(i, "00") & " " & SegName(i)
	'        Next i
	'    End With
	'SegmentForm.Show
	'If jseG > 0 Then MsgBox( "Selected Segment =" & jseG & " " & SegName(jseG)
	'End Sub
	'Sub SelSegs(mx)
	'c select segments to be used, sets iwork>0

	'        Call pcharc(0, 0, Dummy, 32)
	'        For i = 1 To mx
	'          write(dlabel(i),'(i2.2,1x,a16)') i,SegName(i)
	'          Next
	'        dlabel(MX+1)='SEGMENT'
	'        Call jselec(Iwork, mx, Dlabel, 24)
	'        Call clr(0)

	'        SelectMultipleSegments

	'    Call SelectMany(mx, SegName, "Select Segments", 3, Iwork)

	'   For i = 1 To Nseg
	'      Iwork(i) = 1
	'      Next i

	'    ms = "Selected Segments:"
	'    For i = 1 To mx
	'        If Iwork(i) > 0 Then ms = ms & vbCrLf & Format(i, "00") & " " & SegName(i)
	''        Next i
	'   MsgBox( ms

	'       End Sub


	'Sub SelVar(mx)
	'c select observed variables

	'       Iwork = 0
	'       dummy='SELECT VARIABLES'
	'       Call pcharc(0, 0, Dummy, 32)
	'          For i = 1 To mx
	'            Dlabel(i) = Cname(i)
	'            Next
	'          dlabel(mx+1)='VARIABLE'
	'       Call jselec(Iwork, mx, Dlabel, 24)
	'       Call clr(0)

	'SelectCalib
	'For i = 1 To mx
	'Iwork(i) = 0
	'Next i
	'Iwork(2) = 1
	'Iwork(3) = 1


	'End Sub

	'Function JSegs(mx)
	'select one segment
	'          Call lcopy(mx, SegName, Iout, Dlabel, 0)
	'          dlabel(mx+1)='SEGMENT------OUTFLOW SEG'
	'          call pcharc(0,0,'SELECT SEGMENT, <ESC> TO QUIT',29)
	'          jsegs = iselec(mx, Dlabel, 24)

	'Call SelectOne(mx, SegName, "Select Segment", 3, i)
	'JSegs = i
	'          MsgBox( "seg: " & SegName(i)
	'End Function

	'Function Jtribs(mx)
	'c select one tributary
	''$include:'net.inc'
	'        Call lcopy(mx, TribName, Iseg, Dlabel, 0)
	'        dlabel(mx+1)='TRIBUTARY--------SEGMENT'
	'        call pcharc(0,0,'SELECT TRIBUTARY, <ESC> TO QUIT',31)
	'        jtribs = iselec(mx, Dlabel, 24)
	'Call SelectOne(mx, TribName, "Select Tributary", 1, i)
	'Jtribs = i
	'MsgBox( "trib: " & TribName(i)
	'End Function
End Module