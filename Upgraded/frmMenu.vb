Option Strict Off
Option Explicit On
Imports BT2Support.UpgradeStubs
Imports Excel = Microsoft.Office.Interop.Excel
Imports Microsoft.VisualBasic
Imports System
Imports System.Diagnostics
Imports System.IO
Imports System.Linq
Imports System.Windows.Forms
'Imports UpgradeHelpers.Gui.Controls
Imports UpgradeHelpers.Helpers
Partial Friend Class frmMenu
	Inherits System.Windows.Forms.Form
	Public Sub New()
		MyBase.New()
		Dim mustCallFormLoad As Boolean = False
		If m_vb6FormDefInstance Is Nothing Then
			If m_InitializingDefInstance Then
				m_vb6FormDefInstance = Me
			Else
				Try
					'For the start-up form, the first instance created is the default instance.
					If Not (System.Reflection.Assembly.GetExecutingAssembly().EntryPoint Is Nothing) AndAlso System.Reflection.Assembly.GetExecutingAssembly().EntryPoint.DeclaringType Is Me.GetType() Then
						m_vb6FormDefInstance = Me
					End If
				Finally 
					mustCallFormLoad = True
				End Try
			End If
		End If
		'This call is required by the Windows Form Designer.
		InitializeComponent()
		ReLoadForm(False)
        If mustCallFormLoad And Not (m_vb6FormDefInstance Is Nothing) Then
            m_vb6FormDefInstance.Form_Load()
        End If
        Module1.frmMenu = Me
    End Sub


	Private Sub frmMenu_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		'If Not (UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm Is eventSender) Then
		'UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm = eventSender
		'End If
	End Sub

	'Public WithEvents Wko As Excel.Workbook
	Private Sub btnClearOutput_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles btnClearOutput.Click
		'start a new output workbook
		If DebugMode Then MessageBox.Show("frmMenu N1: clearing output from btnclear", My.Application.Info.Title)
		ClearOutput()
	End Sub

	Private Sub btnSaveOutput_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles btnSaveOutput.Click
		Dim realversion As Double
		Dim outfilE As String = ""

		Try

			realversion = CDbl(Wka.Version)
			If (realversion < 15) Then Wka.WindowState = Excel.XlWindowState.xlMinimized
			outfilE = Wko.Name
			'UPGRADE_ISSUE: (6012) CommonDialog variable was not upgraded More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-6012
			With CommonDialog1
				'UPGRADE_ISSUE: (2064) MSComDlg.CommonDialog property CommonDialog1.FileName was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2064
				.setFileName(outfilE)
				'UPGRADE_ISSUE: (2064) MSComDlg.CommonDialog property CommonDialog1.Filter was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2064
				'UPGRADE_WARNING: (2081) Filter has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-2081
				.setFilter("Excel Files (*.xls)|*.xls|")
				'UPGRADE_ISSUE: (2064) MSComDlg.CommonDialog property CommonDialog1.FilterIndex was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2064
				.setFilterIndex(1)
				'UPGRADE_ISSUE: (2064) CommandButton property btnSaveOutput.HelpContextID was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2064
				'UPGRADE_ISSUE: (2064) MSComDlg.CommonDialog property CommonDialog1.HelpContext was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2064
				.setHelpContext(btnSaveOutput.getHelpContextID())
				'UPGRADE_ISSUE: (2064) MSComDlg.CommonDialog property CommonDialog1.CancelError was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2064
				.setCancelError(True)
				CommonDialog1Save.ShowDialog()
				'UPGRADE_ISSUE: (2064) MSComDlg.CommonDialog property CommonDialog1.FileName was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2064
				outfilE = .getFileName()
			End With

			If outfilE = "" Then Throw New Exception()

			Wka.WindowState = Excel.XlWindowState.xlNormal
			Wko.Sheets(1).Activate()
			Wko.SaveAs(outfilE)
			realversion = CDbl(Wka.Version)
			If (realversion < 15) Then Wka.WindowState = Excel.XlWindowState.xlMinimized

		Catch
		End Try

		FormUpdate()

	End Sub

	Private Sub btnErrorMessages_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles btnErrorMessages.Click
		List_Errors()
	End Sub
	'UPGRADE_NOTE: (7001) The following declaration (btnModelOptions_Click) seems to be dead code More Information: https://docs.mobilize.net/vbuc/ewis/notes#id-7001
	'Private Sub btnModelOptions_Click()
		'Dim ListIndex As Integer
		'SetUserMode((ListIndex))
		''   mnuModels_Click
	'End Sub
	Private Sub btnRun_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles btnRun.Click
		mnuRunModel_Click(mnuRunModel, New EventArgs())
	End Sub
	Private Sub cmbUserMode_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmbUserMode.SelectedIndexChanged
		SetUserMode(cmbUserMode.SelectedIndex)
		FormUpdate()
		'    mnuUser_Click (ListIndex)
		Try
			Me.txtReport.Focus()

		Catch
		End Try
	End Sub
	Private Sub launchModels()
		StatList()
		If Icalc > 0 Then
			'UPGRADE_ISSUE: (2064) Menu property mnuLoadResponse.HelpContextID was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2064
			'KW
			'ContextId = mnuLoadResponse.HelpContextID
			'frmResponse.DefInstance.ShowDialog()
			frmResponse.ShowDialog()
			FormUpdate()
		End If
		Status("Ready")
	End Sub

	Private Sub ContinueBtn_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles ContinueBtn.Click
		If gReturnFromXLS Then
			gKeepEdits = False
			If MessageBox.Show("Keep Edits ?", My.Application.Info.Title, MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
				gKeepEdits = True
			End If
			gReturnFromXLS = False
		End If
	End Sub

	Private Sub Form_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Click
		If gReturnFromXLS Then
			gKeepEdits = False
			If MessageBox.Show("Keep Edits ?", My.Application.Info.Title, MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
				gKeepEdits = True
			End If
			gReturnFromXLS = False
		End If

	End Sub

	'UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-2080
	Private Sub Form_Load()
		Dim Lpos As Integer

		Me.txtReport.Text = " "
		'Get the command string to see what's going on here
		Dim Lstring As String = string.Join(" ", Environment.GetCommandLineArgs().Skip(1).ToArray())
		gCase_Name = ""
		gReturnFromXLS = False
		gRunMetaModels = False
		gTASTRMode = False
		DebugMode = False
		DebugMode2 = False
		DebugMode3 = False
		Dim DebugCount As Double = 0
		Lstring = Lstring.ToUpper()
		If Lstring = "DEBUG3" Then
			DebugMode3 = True
		End If
		If Lstring = "DEBUG" Then
			DebugMode = True
		ElseIf Lstring <> "" Then 
			gTASTRMode = True
			gCase_Name = Lstring
			Lpos = (Lstring.IndexOf(","c) + 1)
			If Lpos > 0 Then
				gCase_Name = Lstring.Substring(0, Math.Min(Lpos - 1, Lstring.Length))
				Lstring = Lstring.Substring(Math.Max(Lstring.Length - 1, 0))
				If Lstring = "1" Then gRunMetaModels = True
			End If
		End If


		Me.Text = "Bathtub Version " & gVersionNumber
		If gTASTRMode Then Me.Text = Me.Text & " (TASTR Mode)"

		'CALL THE STARTUP ROUTINE in Module 1
		StartUp()
		If Ier > 0 Then
			If DebugMode Then MessageBox.Show("DEBUG 01 @ Unload Required" & Conversion.Str(DebugCount), My.Application.Info.Title)
			DebugCount += 1
			Me.Close()
			Exit Sub
		End If
		If DebugMode Then MessageBox.Show("DEBUG 02 End of Load" & Conversion.Str(DebugCount), My.Application.Info.Title)
		DebugCount += 1
		Show()
		If gRunMetaModels Then launchModels()

	End Sub

	Sub Check_OutputDest()
		Dim nil As Object
		Dim realversion As Double

		With Me
			.cmbOutputDest.SelectedIndex = Iop(12)
			If Iop(12) = 2 Then
				.Label1.Visible = True
				.btnSaveOutput.Visible = True
				.btnClearOutput.Visible = True
				.lblOutputWorkbook.Visible = True
				If Wka._Default <> ReflectionHelper.GetPrimitiveValue(Of String)(nil) Then Wka.Visible = True
			Else
				.Label1.Visible = False
				.btnSaveOutput.Visible = False
				.btnClearOutput.Visible = False
				.lblOutputWorkbook.Visible = False
				realversion = CDbl(Wka.Version)
				If (realversion < 15) Then Wka.WindowState = Excel.XlWindowState.xlMinimized
				'         Wka.Visible = False
			End If
			Try
				.txtReport.Focus()

			Catch
			End Try
		End With

	End Sub 'Check_OutputDest

	Private Sub cmbOutputDest_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmbOutputDest.SelectedIndexChanged
		Dim j As Integer = Iop(12)
		Iop(12) = cmbOutputDest.SelectedIndex
		Dim realversion As Double = CDbl(Wka.Version)
		If j <> Iop(12) Then
			If j = 2 Then
				If (realversion < 15) Then Wka.WindowState = Excel.XlWindowState.xlMinimized
				If MessageBox.Show("Save Previous Output Workbook " & Wko.Name & " ?", My.Application.Info.Title, MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then btnSaveOutput_Click(btnSaveOutput, New EventArgs())
				ClearOutput()
			End If
			If Iop(12) = 2 Then ClearOutput()
			If DebugMode Then MessageBox.Show("clear output from OutputDestClick", My.Application.Info.Title)
		End If

		Check_OutputDest()
	End Sub

	Private Sub Form_FormClosing(ByVal eventSender As Object, ByVal eventArgs As FormClosingEventArgs) Handles MyBase.FormClosing
		Dim Cancel As Integer = IIf(eventArgs.Cancel, 1, 0)
		Dim UnloadMode As Integer = CInt(eventArgs.CloseReason)
		Try
			If gReturnFromXLS Then
				MessageBox.Show("You Must Exit From EXCEL Editing FIRST" & Strings.Chr(13).ToString() & "Please Press Bathtub Continue Button", My.Application.Info.Title)
				Cancel = 1
			End If
		Finally 
			eventArgs.Cancel = Cancel <> 0
		End Try
	End Sub

	Private Sub form_terminate()
		CleanUp()
	End Sub

	Function GetOutputFileName(ByVal default_Renamed As String) As String
		Dim result As String = ""
		Try
			result = default_Renamed
			'UPGRADE_ISSUE: (6012) CommonDialog variable was not upgraded More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-6012
			With CommonDialog1
				'UPGRADE_ISSUE: (2064) MSComDlg.CommonDialog property CommonDialog1.FileName was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2064
				.setFileName(result)
				'UPGRADE_ISSUE: (2064) MSComDlg.CommonDialog property CommonDialog1.Filter was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2064
				'UPGRADE_WARNING: (2081) Filter has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-2081
				.setFilter("Bathtub Version 6 Files (*.btb)|*.btb|")
				'UPGRADE_ISSUE: (2064) MSComDlg.CommonDialog property CommonDialog1.FilterIndex was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2064
				.setFilterIndex(1)
				'UPGRADE_ISSUE: (2064) MSComDlg.CommonDialog property CommonDialog1.HelpContext was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2064
				.setHelpContext(ContextId)
				CommonDialog1Save.ShowDialog()
				'UPGRADE_ISSUE: (2064) MSComDlg.CommonDialog property CommonDialog1.CancelError was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2064
				.setCancelError(True)
				'UPGRADE_ISSUE: (2064) MSComDlg.CommonDialog property CommonDialog1.FileName was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2064
				result = .getFileName()
			End With

		Catch
			result = ""
		End Try
		Return result
	End Function

	Public Sub mnuListInputs_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles mnuListInputs.Click
		If DebugMode Then MessageBox.Show("Loading Excel from MnuListInputs", My.Application.Info.Title)
		'LoadExcel
		ClearOutput()
		If Ier > 0 Then Exit Sub
		'UPGRADE_ISSUE: (2064) Menu property mnuListInputs.HelpContextID was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2064
		'KW
		'ContextId = mnuListInputs.HelpContextID
		List_Inputs()
		ViewSheet("Case Data")
	End Sub

	Public Sub mnnListAll_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles mnnListAll.Click
		StatList()
		If Icalc > 0 Then List_All()
	End Sub

	Public Sub mnuCalibration_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles mnuCalibration.Click
		StatList()
		If Icalc > 0 Then
			'frmCalibration.DefInstance.ShowDialog()
			frmCalibration.ShowDialog()
			'    Icalc = 0
			FormUpdate()
		End If
	End Sub
	Public Sub mnuChannels_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles mnuChannels.Click
		'frmChannels.DefInstance.ShowDialog()
		frmChannels.ShowDialog()
		Icalc = 0
		FormUpdate()
	End Sub

	Public Sub mnuCoefficients_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles mnuCoefficients.Click
		'frmCoefficients.DefInstance.ShowDialog()
		frmCoefficients.ShowDialog()
		'    Icalc = 0
		FormUpdate()
	End Sub

	Public Sub mnuLoadResponse_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles mnuLoadResponse.Click
		StatList()
		If Icalc > 0 Then
			'UPGRADE_ISSUE: (2064) Menu property mnuLoadResponse.HelpContextID was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2064
			'KW
			'ContextId = mnuLoadResponse.HelpContextID
			'frmResponse.DefInstance.ShowDialog()
			frmResponse.ShowDialog()
			FormUpdate()
		End If
		Status("Ready")
	End Sub

	Public Sub mnuNewCase_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles mnuNewCase.Click
		Dim n1 As String = "", n2 As String = "", s As String = ""
        If MessageBox.Show("Create New Case ?", My.Application.Info.Title, MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
			n1 = InputBox("Number of Segments?")
			'n1 = InputBoxHelper.InputBox("Number of Segments?")
			If StringsHelper.ToDoubleSafe(n1) <= 0 Then Exit Sub
            n2 = InputBox("Number of Tributaries?")
            'n2 = InputBoxHelper.InputBox("Number of Tributaries?")
            If StringsHelper.ToDoubleSafe(n2) <= 0 Then Exit Sub
            s = InputBox("Title?")
            's = InputBoxHelper.InputBox("Title?")
            AllZero()
			Nseg = CInt(n1)
			NTrib = CInt(n2)
			For i As Double = 1 To Nseg
				SegName(CInt(i)) = "Segname " & i
				If i = Nseg Then
					Iout(CInt(i)) = 0
				Else
					Iout(CInt(i)) = i + 1
				End If
			Next i
			For i As Double = 1 To NTrib
				TribName(CInt(i)) = "Trib " & i
				Iseg(CInt(i)) = 1
			Next i
			mnuSaveCaseAs_Click(mnuSaveCaseAs, New EventArgs())
			Icalc = 0
			FormUpdate()
		End If
	End Sub

	Public Sub mnuRead_CaseFile_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles mnuRead_CaseFile.Click

		Dim infilE As String = "", outfilE As String = ""

		Try
			infilE = "*.btb"
			'UPGRADE_ISSUE: (2064) Menu property mnuReadCase.HelpContextID was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2064
			'KW
			'ContextId = mnuReadCase.HelpContextID
			'UPGRADE_ISSUE: (6012) CommonDialog variable was not upgraded More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-6012
			Dim ofd As New OpenFileDialog()
			ofd.FileName = infilE
			ofd.Filter = "Bathtub Files (*.btb)|*.btb"
			ofd.FilterIndex = 1
			ofd.Title = "Select Bathtub Case File"
			Dim result = ofd.ShowDialog()
			infilE = ofd.FileName
			'         With CommonDialog1
			'	'UPGRADE_ISSUE: (2064) MSComDlg.CommonDialog property CommonDialog1.FileName was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2064
			'	.setFileName(infilE)
			'	'.Filter = "Bathtub Files (*.btb)|*.btb|Version 5 Files (*.bin)|*.bin|Excel Files (*.xls)|*.xls|"
			'	'UPGRADE_ISSUE: (2064) MSComDlg.CommonDialog property CommonDialog1.Filter was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2064
			'	'UPGRADE_WARNING: (2081) Filter has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-2081
			'	.setFilter("Bathtub Files (*.btb)|*.btb|")
			'	'UPGRADE_ISSUE: (2064) MSComDlg.CommonDialog property CommonDialog1.FilterIndex was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2064
			'	.setFilterIndex(1)
			'	'UPGRADE_ISSUE: (2064) MSComDlg.CommonDialog property CommonDialog1.CancelError was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2064
			'	.setCancelError(True)
			'	'UPGRADE_ISSUE: (2064) MSComDlg.CommonDialog property CommonDialog1.HelpContext was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2064
			'	.setHelpContext(ContextId)
			'	CommonDialog1Open.ShowDialog()
			'	'UPGRADE_ISSUE: (2064) MSComDlg.CommonDialog property CommonDialog1.FileName was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2064
			'	infilE = .getFileName()
			'End With

			If Not (Not ValidFile(infilE) Or Not FileExists(infilE)) Then

				'MsgBox infilE
				Status("Reading Case File...")

				Read_btb((infilE))
				If Ier = 0 Then Exit Sub

			End If

			MessageBox.Show("File Not Read: " & infilE, My.Application.Info.Title)

		Catch ex As Exception
			Dim msg = ex.Message
        End Try

		Status("Ready")
		Icalc = 0
		FormUpdate()
	End Sub

	Public Sub mnuRead_Worksheet_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles mnuRead_Worksheet.Click
		Dim infilE As String = ""
		Dim savechanges As Boolean
		Dim XLSInputApp As Excel.Application

		Dim pFilename As String = "", Lstring As String = "", outfilE As String = ""
		Try
			infilE = "*.xls"
			'UPGRADE_ISSUE: (2064) Menu property mnuReadCase.HelpContextID was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2064
			'KW
			'ContextId = mnuReadCase.HelpContextID
			'UPGRADE_ISSUE: (6012) CommonDialog variable was not upgraded More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-6012
			With CommonDialog1
				'UPGRADE_ISSUE: (2064) MSComDlg.CommonDialog property CommonDialog1.FileName was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2064
				.setFileName(infilE)
				'UPGRADE_ISSUE: (2064) MSComDlg.CommonDialog property CommonDialog1.Filter was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2064
				'UPGRADE_WARNING: (2081) Filter has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-2081
				.setFilter("Bathtub XLS Files (*.xls)|*.xls")
				'.Filter = "Bathtub Files (*.btb)|*.btb|"
				'UPGRADE_ISSUE: (2064) MSComDlg.CommonDialog property CommonDialog1.FilterIndex was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2064
				.setFilterIndex(1)
				'UPGRADE_ISSUE: (2064) MSComDlg.CommonDialog property CommonDialog1.CancelError was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2064
				.setCancelError(True)
				'UPGRADE_ISSUE: (2064) MSComDlg.CommonDialog property CommonDialog1.HelpContext was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2064
				.setHelpContext(ContextId)
				CommonDialog1Open.ShowDialog()
				'UPGRADE_ISSUE: (2064) MSComDlg.CommonDialog property CommonDialog1.FileName was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2064
				pFilename = .getFileName()
			End With

			If Not FileExists(pFilename) Then
				MessageBox.Show("Input File Not Found " & pFilename, My.Application.Info.Title)
				Throw New Exception()
			End If

			Lstring = GetFileName(pFilename) & ".xls"

			'MsgBox infilE
			Status("Opening Worksheet")
			'Load EXCEL and Setup XLSInputbook;

			XLSInputApp = Nothing
			Wka = Nothing
			'Set Wka = New Excel.Application

			'DEFINE EXCEL OBJECTS

			XLSInputApp = New Excel.Application() 'excel object for input
			'NO! Wka = CreateObject("Excel.Application")
			XLSInputApp.Workbooks.Open(pFilename)
			XLSWorkBk = XLSInputApp.ActiveWorkbook 'Workbooks(Lstring)

			XLSInputApp.EnableEvents = True
			XLSInputApp.WindowState = Excel.XlWindowState.xlMinimized
			XLSInputApp.Visible = True
			MessageBox.Show("N304: calling Read_XLS", My.Application.Info.Title)
			Read_xls("Inputs") 'Reads from XLSWorkBk
			MessageBox.Show("N305: done with input, Now Closing XlsWorkBk", My.Application.Info.Title)
			MessageBox.Show("just a placeholder to force processing", My.Application.Info.Title)
			'XLSWorkBk.Close (savechanges = False) TEMPORARY
			'XLSInputApp.Quit
			'Set XLSInputApp = Nothing
			'If Ier = 0 Then Exit Sub
			MessageBox.Show("N305: Pointing WKa to XLSInputApp", My.Application.Info.Title)
			'KW
			'Wka._Default = XLSInputApp._Default
			Wka = XLSInputApp
			MessageBox.Show("N306: Jumping to Done and End Sub", My.Application.Info.Title)

		Catch

			MessageBox.Show("starting Abhort2 in mnuRead_Worksheet_Click", My.Application.Info.Title)
			Lstring = "E300: Unable to Read Worksheet: ' " & pFilename & Strings.Chr(13).ToString()
			MessageBox.Show(Lstring & "Be Sure Named Fields in Inputs Worksheet Conform to Template Bath.xla.xls", My.Application.Info.Title)
			XLSWorkBk.Close(Not savechanges)
			'KW
			'Wka._Default = XLSInputApp._Default
			Wka = XLSInputApp
			XLSInputApp.Quit()
			XLSInputApp = Nothing

		Finally 
			MessageBox.Show("Now Starting DONE", My.Application.Info.Title)
			Status("Ready")
			Icalc = 0
			If Wka Is Nothing Then MessageBox.Show("N403: ERROR! Cannot leave here with a null WKA", My.Application.Info.Title)
			FormUpdate()
		End Try
	End Sub

	Public Sub mnuSaveCase_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles mnuSaveCase.Click
		Dim Lname As String = (Directory & "DEFAULT.BTB").ToUpper()
		If CaseFile = "" Then mnuSaveCaseAs_Click(mnuSaveCaseAs, New EventArgs())
		Status("Saving File...")
		Dim LoutFile As String = CaseFile
		Dim Msg As String = "THIS OVERWRITES THE DEFAULT CASE, PROCEED ANYWAY"
		If Lname.IndexOf(LoutFile.ToUpper()) >= 0 Then '4 is YES NO
			If MessageBox.Show(Msg, "OverWrite Default?", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.No Then Exit Sub
		End If
		Save_btb((LoutFile))
		FormUpdate()
		Status("Ready")
	End Sub
	Public Sub mnuSaveCaseAs_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles mnuSaveCaseAs.Click
		'save

		Dim outfilE As String = ""
		Try

			'UPGRADE_ISSUE: (2064) Menu property mnuSaveCaseAs.HelpContextID was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2064
			'KW
			'ContextId = mnuSaveCaseAs.HelpContextID
			outfilE = GetOutputFileName("*.btb")
			If Not ValidFile(outfilE) Then Throw New Exception()

			If FileExists(outfilE) Then
				If MessageBox.Show("File: " & outfilE & " already exists, overwrite?", My.Application.Info.Title, MessageBoxButtons.YesNo) <> System.Windows.Forms.DialogResult.Yes Then Throw New Exception()
			End If

			Status("Saving Case...")

			Save_btb((outfilE))
			MessageBox.Show(outfilE & " saved", My.Application.Info.Title)
			WorkingDirectory = ExtractPath(outfilE)
			CaseFile = outfilE
			FormUpdate()
			Status("Ready")

		Catch

			MessageBox.Show("File Not Saved: " & outfilE, My.Application.Info.Title)
			Status("Ready")
		End Try
	End Sub
	Public Sub mnuTranslateCase_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles mnuTranslateCase.Click
		Dim _OUtFlag3, _OUtFlag2, _OUtFlag As Boolean
		Dim result As Double
		'translate bin file

		Dim TmpFile As String = "", sN As String = "", infilE As String = "", outfilE As String = "", WhenerroR As String = "", InfileDir As String = "", InfileName As String = ""

		Ier = 0

		'UPGRADE_TODO: (1065) Error handling statement (On Error Goto) could not be converted. More Information: https://docs.mobilize.net/vbuc/ewis/todos#id-1065
		UpgradeHelpers.Helpers.NotUpgradedHelper.NotifyNotUpgradedElement("On Error Goto Label (OUt)")
		'UPGRADE_ISSUE: (2064) Menu property mnuTranslateCase.HelpContextID was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2064
		'KW
		'ContextId = mnuTranslateCase.HelpContextID
		infilE = "*.bin"
		'UPGRADE_ISSUE: (6012) CommonDialog variable was not upgraded More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-6012
		With CommonDialog1
			'UPGRADE_ISSUE: (2064) MSComDlg.CommonDialog property CommonDialog1.FileName was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2064
			.setFileName(infilE)
			'UPGRADE_ISSUE: (2064) MSComDlg.CommonDialog property CommonDialog1.Filter was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2064
			'UPGRADE_WARNING: (2081) Filter has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-2081
			.setFilter("Bathtub Version 5 Files (*.bin)|*.bin")
			'UPGRADE_ISSUE: (2064) MSComDlg.CommonDialog property CommonDialog1.FilterIndex was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2064
			.setFilterIndex(1)
			'UPGRADE_ISSUE: (2064) MSComDlg.CommonDialog property CommonDialog1.CancelError was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2064
			.setCancelError(True)
			CommonDialog1Open.ShowDialog()
			'UPGRADE_ISSUE: (2064) MSComDlg.CommonDialog property CommonDialog1.HelpContext was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2064
			.setHelpContext(ContextId)
			'UPGRADE_ISSUE: (2064) MSComDlg.CommonDialog property CommonDialog1.FileName was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2064
			infilE = .getFileName()
		End With
		If infilE = "" Or infilE.IndexOf("*"c) >= 0 Or Not FileExists(infilE) Then _OUtFlag = True
			GoTo OUtTryBlock
		InfileDir = ExtractPath(infilE)
		InfileName = ExtractFile(infilE)

		sN = infilE
		Mid(sN, Strings.Len(sN) - 2) = "btb"
		MessageBox.Show("Now specify a new file to store translated case (*.btb)", My.Application.Info.Title)
		outfilE = Me.GetOutputFileName(sN)
		If Not ValidFile(outfilE) Then _OUtFlag2 = True
			GoTo OUtTryBlock2
		If FileExists(outfilE) Then
			If MessageBox.Show("File: " & outfilE & " already exists, overwrite?", My.Application.Info.Title, MessageBoxButtons.YesNo) <> System.Windows.Forms.DialogResult.Yes Then _OUtFlag3 = True
				GoTo OUtTryBlock3
		End If

		'first create temporary translation file
		'TmpFile = Directory & "bin_btb.btb"
		System.IO.Directory.SetCurrentDirectory(InfileDir)
		TmpFile = "bin_btb.btb"
		If FileExists(TmpFile) Then File.Delete(TmpFile)
		sN = Directory & "convert.exe" & " " & InfileName & " " & TmpFile
		'execute dos conversion program
		WhenerroR = "in Convert.exe"
		'UPGRADE_TODO: (1065) Error handling statement (On Error Goto) could not be converted. More Information: https://docs.mobilize.net/vbuc/ewis/todos#id-1065
		UpgradeHelpers.Helpers.NotUpgradedHelper.NotifyNotUpgradedElement("On Error Goto Label (Abhort)")
		'UPGRADE_TODO: (7005) parameters (if any) must be set using the Arguments property of ProcessStartInfo More Information: https://docs.mobilize.net/vbuc/ewis/todos#id-7005
		Dim startInfo As ProcessStartInfo = New ProcessStartInfo(sN)
		startInfo.WindowStyle = ProcessWindowStyle.Hidden
		result = Process.Start(startInfo).Id
		'UPGRADE_TODO: (1069) Error handling statement (On Error Resume Next) was converted to a pattern that might have a different behavior. More Information: https://docs.mobilize.net/vbuc/ewis/todos#id-1069
OUtTryBlock:
OUtTryBlock2:
OUtTryBlock3:
		Try
			If _OUtFlag3 Then GoTo OUt
			If _OUtFlag2 Then GoTo OUt
			If _OUtFlag Then GoTo OUt
			MessageBox.Show("Translating File: " & infilE & " to File: " & outfilE, My.Application.Info.Title)

			'now read translated file & copy
			If Not Information.Err().Number And FileExists(TmpFile) Then
				Read_bin_btb((TmpFile))
				WhenerroR = "in Step 2"
				If Ier > 0 Then GoTo Abhort
				If FileExists(TmpFile) Then File.Delete(TmpFile)
				Save_btb((outfilE))
				If Ier > 0 Then
					WhenerroR = "in Step 3"
					GoTo Abhort
				End If

				Read_btb((outfilE))
				Icalc = 0
				If Ier = 0 Then Exit Sub
			End If

Abhort:
			MessageBox.Show("File Not Translated: " & WhenerroR & " " & infilE, My.Application.Info.Title)
			Icalc = 0
OUt:
			FormUpdate()
			Status("Ready")
			Information.Err().Clear()
			System.IO.Directory.SetCurrentDirectory(WorkingDirectory)

		Catch exc As Exception
			NotUpgradedHelper.NotifyNotUpgradedElement("Resume in On-Error-Resume-Next Block")
		End Try
	End Sub
    Public Sub mnuAbout_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles mnuAbout.Click
        Dim frmAbout As New frmAbout()
        frmAbout.lblTitle(0).Text = "Bathtub for Windows Version " & gVersionNumber
		'frmAbout.DefInstance.lblTitle(0).Text = "Bathtub for Windows Version " & gVersionNumber
		'frmAbout.DefInstance.ShowDialog()
		frmAbout.ShowDialog()
	End Sub
	Public Sub mnuChart_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles mnuChart.Click
		StatList()
		'If Icalc > 0 Then frmPlot.DefInstance.Show()
		If Icalc > 0 Then frmPlot.Show()
		Status("Ready")
	End Sub

	Public Sub mnuGlobals_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles mnuGlobals.Click
		'frmGlobals.DefInstance.ShowDialog()
		frmGlobals.ShowDialog()
		'    Icalc = 0
		FormUpdate()
	End Sub
	Public Sub mnuLandUses_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles mnuLandUses.Click
		'frmLandUse.DefInstance.ShowDialog()
		frmLandUse.ShowDialog()
		'    Icalc = 0
		FormUpdate()
	End Sub

	Public Sub mnuListDiagnostics_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _mnuListDiagnostics_0.Click, _mnuListDiagnostics_1.Click
		Dim index As Integer = Array.IndexOf(Me.mnuListDiagnostics, eventSender)
		'index=0 predicted index=1 both
		StatList()
		If Icalc > 0 Then
			'UPGRADE_ISSUE: (2064) Menu property mnuListDiagnostics.HelpContextID was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2064
			'KW
			'ContextId = mnuListDiagnostics(index).HelpContextID
			List_Diagnostics((index))
			ViewSheet("Diagnostics")
		End If
	End Sub

	Public Sub mnuListErrorMessages_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles mnuListErrorMessages.Click
		List_Errors()
		' StatList
		' Set gLSht = Wkb.Worksheets("errors")
		' ViewSheet ("errors")
	End Sub

	Public Sub mnuListErrors_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles mnuListErrors.Click
		StatList()
		If Icalc > 0 Then
			'UPGRADE_ISSUE: (2064) Menu property mnuListErrors.HelpContextID was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2064
			'KW
			'ContextId = mnuListErrors.HelpContextID
			List_Verify()
			ViewSheet("Verify")
		End If
	End Sub
	Public Sub mnuListNetwork_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles mnuListNetwork.Click
		'UPGRADE_ISSUE: (2064) Menu property mnuListNetwork.HelpContextID was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2064
		'KW
		'ContextId = mnuListNetwork.HelpContextID
		List_Tree()
		ViewSheet("Segment Network")
	End Sub
	Public Sub mnuListGrossBalances_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles mnuListGrossBalances.Click
		StatList()
		If Icalc > 0 Then
			'UPGRADE_ISSUE: (2064) Menu property mnuListGrossBalances.HelpContextID was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2064
			'KW
			'ContextId = mnuListGrossBalances.HelpContextID
			List_GrossBalances()
			ViewSheet("Overall Balances")
		End If
	End Sub

	Sub StatList()
		If Icalc = 0 Then
			MessageBox.Show("You Must Run the Model First", My.Application.Info.Title)
		Else
			'ContextId = HelpContextID
			ScreenOff()
			If DebugMode Then MessageBox.Show("Loading Excel from StatList", My.Application.Info.Title)
			'LoadExcel
			ClearOutput()
			'        Status ("Creating Output")
		End If
	End Sub

	Public Sub mnuListHydraulics_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles mnuListHydraulics.Click
		StatList()
		If Icalc > 0 Then
			'UPGRADE_ISSUE: (2064) Menu property mnuListHydraulics.HelpContextID was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2064
			'KW
			'ContextId = mnuListHydraulics.HelpContextID
			List_Hydraulics()
			ViewSheet("Hydraulics")
		End If
	End Sub
	Public Sub mnuListStatistics_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles mnuListStatistics.Click
		StatList()
		If Icalc > 0 Then
			'UPGRADE_ISSUE: (2064) Menu property mnuListStatistics.HelpContextID was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2064
			'KW
			'ContextId = mnuListStatistics.HelpContextID
			List_Fits()
			ViewSheet("Calibrations")
		End If
	End Sub

	Public Sub mnuModels_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles mnuModels.Click
		Icalc = 0
		'frmModels.DefInstance.ShowDialog()
		frmModels.ShowDialog()
		FormUpdate()
	End Sub

	Public Sub mnuListProfiles_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles mnuListProfiles.Click
		StatList()
		If Icalc > 0 Then
			'UPGRADE_ISSUE: (2064) Menu property mnuListProfiles.HelpContextID was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2064
			'KW
			'ContextId = mnuListProfiles.HelpContextID
			List_Profiles()
			ViewSheet("Profiles")
		End If
	End Sub

	Public Sub mnuQuit_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles mnuQuit.Click
		'end of program
		'    Wkb.Saved = True
		If MessageBox.Show("Quit?", "End Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
			CleanUp()
			Me.Close()
		End If
	End Sub
	Public Sub mnuReadDefault_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles mnuReadDefault.Click
		Dim infilE As String = Directory & "default.btb"
		Read_btb((infilE)) 'read default case
	End Sub

	Public Sub mnuRunModel_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles mnuRunModel.Click
		Run()
		FormUpdate()
	End Sub

	Public Sub mnuRunSensitivity_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles mnuRunSensitivity.Click
		StatList()
		If Icalc > 0 Then
			'UPGRADE_ISSUE: (2064) Menu property mnuRunSensitivity.HelpContextID was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2064
			'KW
			'ContextId = mnuRunSensitivity.HelpContextID
			Run_Sensitivity()
			If Ier > 0 Then Exit Sub
			If Icalc > 0 Then ViewSheet("Sensitivity")
		End If
	End Sub
	Public Sub mnuListSegBal_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles mnuListSegBal.Click
		StatList()
		If Icalc > 0 Then
			'UPGRADE_ISSUE: (2064) Menu property mnuListSegBal.HelpContextID was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2064
			'KW
			'ContextId = mnuListSegBal.HelpContextID
			List_SegBalances()
			ViewSheet("Segment Balances")
		End If
	End Sub
	Public Sub mnuListSummary_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles mnuListSummary.Click
		StatList()
		If Icalc > 0 Then
			'UPGRADE_ISSUE: (2064) Menu property mnuListSummary.HelpContextID was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2064
			'KW
			'ContextId = mnuListSummary.HelpContextID
			List_Terms()
			ViewSheet("Summary Balances")
		End If
	End Sub

	Public Sub mnuListTTests_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles mnuListTTests.Click
		StatList()
		If Icalc > 0 Then
			'UPGRADE_ISSUE: (2064) Menu property mnuListTTests.HelpContextID was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2064
			'KW
			'ContextId = mnuListTTests.HelpContextID
			List_TTests()
			ContextId = 25
			ViewSheet("T tests")
		End If
	End Sub
	Public Sub mnuSegments_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles mnuSegments.Click
		'frmSegments.DefInstance.ShowDialog()
		frmSegments.ShowDialog()
		'    Icalc = 0
		FormUpdate()
	End Sub

	Public Sub mnuTributaries_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles mnuTributaries.Click
		'frmTribs.DefInstance.ShowDialog()
		frmTribs.ShowDialog()
		'    Icalc = 0
		FormUpdate()
	End Sub

	Public Sub mnuUser_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _mnuUser_0.Click, _mnuUser_1.Click
		Dim index As Integer = Array.IndexOf(Me.mnuUser, eventSender)
		'set user mode
		SetUserMode((index))
		FormUpdate()
	End Sub
	Sub SetUserMode(ByVal index As Integer)
		If index = 0 Then
			CType(mnuUser(0), ToolStripMenuItem).Checked = True
			CType(mnuUser(1), ToolStripMenuItem).Checked = False
			NoviceUser = True
			mnuListTTests.Enabled = False
			mnuWorksheet.Enabled = False
			mnuRunSensitivity.Enabled = False
			mnuCalibration.Enabled = False
			mnuListSummary.Enabled = False
			mnuListStatistics.Enabled = False
			mnuCoefficients.Enabled = False
			mnuChannels.Enabled = False
			mnuLoadResponse.Enabled = False
			mnuListProfiles.Enabled = False
		Else
			CType(mnuUser(1), ToolStripMenuItem).Checked = True
			CType(mnuUser(0), ToolStripMenuItem).Checked = False
			NoviceUser = False
			mnuListProfiles.Enabled = True
			mnuListTTests.Enabled = True
			mnuWorksheet.Enabled = True
			mnuRunSensitivity.Enabled = True
			mnuCalibration.Enabled = True
			mnuListSummary.Enabled = True
			mnuListStatistics.Enabled = True
			mnuCoefficients.Enabled = True
			mnuChannels.Enabled = True
			mnuLoadResponse.Enabled = True
		End If
	End Sub

	Public Sub mnuWorksheet_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles mnuWorksheet.Click
		'UPGRADE_ISSUE: (2064) Menu property mnuWorksheet.HelpContextID was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2064
		'KW
		'ContextId = mnuWorksheet.HelpContextID
		Edit_xls()
		'    Icalc = 0
		FormUpdate()
		Status("Ready")
	End Sub

	Public Sub mnuwarnings_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _mnuwarnings_0.Click, _mnuwarnings_1.Click
		Dim index As Integer = Array.IndexOf(Me.mnuwarnings, eventSender)
		ShowWarnings = index = 0
		CheckWarnings()
	End Sub
	Sub CheckWarnings()
		If ShowWarnings Then
			CType(mnuwarnings(0), ToolStripMenuItem).Checked = True
			CType(mnuwarnings(1), ToolStripMenuItem).Checked = False
		Else
			CType(mnuwarnings(1), ToolStripMenuItem).Checked = True
			CType(mnuwarnings(0), ToolStripMenuItem).Checked = False
		End If
	End Sub

	Public Sub mnuHelpContents_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles mnuHelpContents.Click
		ShowHelp(0)
	End Sub
	Public Sub mnureadWorksheet_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles mnuReadWorksheet.Click
		'Wka.Visible = True
		' THIS IS NEVER CALLED
		Status("Reading Worksheet")
		Read_xls("Inputs")
		If Ier = 0 Then MessageBox.Show("Input Data Read from Worksheet", My.Application.Info.Title)
		Status("Ready")
	End Sub

	Public Sub mnuSaveWorksheet_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles mnuSaveWorksheet.Click
		'Wka.Visible = True
		Status("Saving Worksheet")
		Save_xls()
		If Ier = 0 Then MessageBox.Show("Input Data Saved to Worksheet", My.Application.Info.Title)
		Status("Ready")
	End Sub

	'Private Sub Wko_BeforeClose(Cancel As Boolean)
	'MsgBox "you should not close this workbook"
	'Cancel = True
	'End Sub
	'UPGRADE_NOTE: (7001) The following declaration (Read_CaseFile_Click) seems to be dead code More Information: https://docs.mobilize.net/vbuc/ewis/notes#id-7001
	'Private Sub Read_CaseFile_Click()
		'
	'End Sub
End Class