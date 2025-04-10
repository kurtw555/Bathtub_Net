Option Strict Off
Option Explicit On
Imports Excel = Microsoft.Office.Interop.Excel
Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Imports UpgradeHelpers.Gui.Controls
Imports UpgradeHelpers.Helpers
Partial Friend Class frmResponse
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
		isInitializingComponent = True
		InitializeComponent()
		isInitializingComponent = False
		ReLoadForm(False)
		If mustCallFormLoad And Not (m_vb6FormDefInstance Is Nothing) Then
			m_vb6FormDefInstance.Form_Load()
		End If
	End Sub


	Private Sub frmResponse_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		If Not (UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm Is eventSender) Then
			UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm = eventSender
		End If
	End Sub
	Dim ShowStash As Boolean
	'Dim CurrentWKChart As Object 'Excel.Chart
	Dim reD As Boolean
	Dim Fname As String = ""

	Sub ClearIt()
		Dim realversion As Double = CDbl(Wka.Version)
		If (realversion < 15) Then Wka.WindowState = Excel.XlWindowState.xlMinimized
		Image1.Image = Image.FromFile("")
		reD = False
	End Sub
	Private Sub cmbSegment_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmbSegment.SelectedIndexChanged
		If reD Then ClearIt()
	End Sub
	Private Sub cmbtrib_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmbTrib.SelectedIndexChanged
		If reD Then ClearIt()
	End Sub
	Private Sub cmbvariable_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmbVariable.SelectedIndexChanged
		If reD Then ClearIt()
	End Sub
	Private Sub cmboption_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmbOption.SelectedIndexChanged
		If reD Then ClearIt()
	End Sub
	Private Sub RunModels()
		Dim Lindex As Integer
		Dim icount As Integer
		If MessageBox.Show("  This Will Take A While - OK to Proceed?  ", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.No Then Exit Sub
		For RespVarCode As Integer = 1 To 12 'Full run is 12
			Lindex = RespVarCode
			If Lindex > 1 Then Lindex += 1
			If Lindex > 4 Then Lindex += 14
			cmbVariable.SelectedIndex = Lindex
			For Model_type As Integer = 0 To 1
				cmbOption.SelectedIndex = Model_type
				ShowStash = ShowWarnings
				ShowWarnings = False
				ClearIt()
				Run_Response()
				If Ier = 0 Then
					'Restored 7/3/2009 DMS
					If DebugMode Then MessageBox.Show("frmresponse N25: chart Object Count=" & Conversion.Str(Wkb.Sheets("plot response").ChartObjects(Type.Missing).Count), My.Application.Info.Title)
					CurrentWKChart = ReflectionHelper.GetMember(Wkb.Sheets("plot response").ChartObjects(Type.Missing)(1), "Chart")
					Fname = Directory & "temp.gif"
					'UPGRADE_WARNING: (7006) The Named argument FilterName was not resolved and corresponds to the following expression GIF More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-7006
					'UPGRADE_WARNING: (7006) The Named argument FileName was not resolved and corresponds to the following expression Fname More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-7006
					ReflectionHelper.Invoke(CurrentWKChart, "Export", New Object() {Fname, "GIF"}, New String() {"FileName", "FilterName"})
					CurrentWKChart = ReflectionHelper.GetMember(Wkb.Sheets("plot response").ChartObjects(Type.Missing)(1), "Chart")
					Image1.Image = Image.FromFile(Fname)
					If DebugMode Then MessageBox.Show("frmresponse N26: About to Delete " & Directory & "temp.gif", My.Application.Info.Title)
					File.Delete(Fname)
					'=====================================



					reD = True
				End If
				ShowWarnings = ShowStash

				If reD Then
					ViewSheet("load response")
					'Copy to MetaModels
					With Wko
						If .Sheets.Count > 2 Then
							gSheetout = .Worksheets("MetaModels")
							ResponseCount += 10
						Else
							ResponseCount = 2
							Wkb.Sheets("MetaModels").Copy(Type.Missing, .Worksheets("load response"))
							ReflectionHelper.LetMember(.ActiveSheet, "Name", "MetaModels")
							gSheetout = .ActiveSheet
							Wka.ActiveWindow.DisplayGridlines = False
						End If
					End With
					ReflectionHelper.Invoke(ReflectionHelper.Invoke(gLSht, "Rows", New Object() {"11:20"}), "Copy", New Object() {ReflectionHelper.Invoke(gSheetout, "Range", New Object() {"A" & ResponseCount})})
					'Copy ancillary info on parameter and model type
					For j As Integer = ResponseCount To ResponseCount + 9
						ReflectionHelper.LetMember(gSheetout, "Cells", cmbVariable.SelectedIndex, j, "I")
						ReflectionHelper.LetMember(gSheetout, "Cells", cmbOption.SelectedIndex, j, "J")
						icount = cmbSegment.SelectedIndex + 1
						If icount = cmbSegment.Items.Count Then icount = 0
						ReflectionHelper.LetMember(gSheetout, "Cells", icount, j, "K")
						ReflectionHelper.LetMember(gSheetout, "Cells", cmbVariable.Text, j, "L")
						ReflectionHelper.LetMember(gSheetout, "Cells", cmbOption.Text, j, "M")
						ReflectionHelper.LetMember(gSheetout, "Cells", cmbSegment.Text, j, "N")
					Next j
				End If
			Next Model_type
		Next RespVarCode
		Wko.Sheets("load response").Delete()
		Wko.Sheets("MetaModels").Activate()

	End Sub 'Run_Models
	'UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-2080
	Private Sub Form_Load()

		reD = True
		'build boxes
		With cmbTrib
			.Items.Clear()
			.AddItem("All")
			For i As Double = 1 To NTrib
				.AddItem(StringsHelper.Format(i, "00") & " " & TribName(CInt(i)))
			Next i
			.SelectedIndex = 0
		End With

		With cmbSegment
			.Items.Clear()
			For i As Double = 1 To Nseg + 1
				If i <= Nseg Then
					.AddItem(StringsHelper.Format(i, "00") & " " & SegName(CInt(i)))
				Else
					.AddItem(SegName(CInt(i)))
				End If
			Next i
			.SelectedIndex = Nseg
		End With

		With cmbVariable
			.Items.Clear()
			For i As Double = 1 To NDiagnostics
				.AddItem(DiagName(CInt(i)))
			Next i
			.SelectedIndex = 1
		End With

		With cmbOption
			.Items.Clear()
			.AddItem("Vary Inflow Concs")
			.AddItem("Vary Flows")
			.SelectedIndex = 0
		End With

		ClearIt()
		If gRunMetaModels Then RunModels()

	End Sub



	Private Sub Toolbar1_ButtonClick(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles Toolbar1_Buttons_Button1.Click, Toolbar1_Buttons_Button2.Click, Toolbar1_Buttons_Button3.Click, Toolbar1_Buttons_Button4.Click, Toolbar1_Buttons_Button5.Click, Toolbar1_Buttons_Button6.Click
		Dim Button As ToolStripItem = CType(eventSender, ToolStripItem)
		Dim DebugCount As Integer
		Dim i As Double


		Select Case Button.Text
			Case "Run"
				ShowStash = ShowWarnings
				ShowWarnings = False
				ClearIt()
				Run_Response()
				If Ier = 0 Then
					i = Wkb.Sheets("plot response").ChartObjects(Type.Missing).Count
					If DebugMode Then MessageBox.Show("frmresponse: N15: Creating CurrentWkChart of " & Conversion.Str(i), My.Application.Info.Title)
					DebugCount += 1
					'Need to Destroy the old sheet before you do this
					'CurrentWKChart is an Excel Chart Object
					'Point the object at Chart1
					CurrentWKChart = ReflectionHelper.GetMember(Wkb.Sheets("plot response").ChartObjects(Type.Missing)(1), "Chart")
					Fname = Directory & "temp.gif"
					'UPGRADE_WARNING: (7006) The Named argument FilterName was not resolved and corresponds to the following expression GIF More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-7006
					'UPGRADE_WARNING: (7006) The Named argument FileName was not resolved and corresponds to the following expression Fname More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-7006
					ReflectionHelper.Invoke(CurrentWKChart, "Export", New Object() {Fname, "GIF"}, New String() {"FileName", "FilterName"})
					'Clear any existing picture - give a little delay for export before reload
					Image1.Image = Nothing
					Image1.Image = Image.FromFile(Fname)
					File.Delete(Fname)
					reD = True
				End If
				ShowWarnings = ShowStash


			Case "List"
				If reD Then ViewSheet("load response")

			Case "Metamodel" 'SEGMENT ADDED BY DMS 8/6/2008
				RunModels()

			Case "Help"
				ShowHelp(1009)

			Case "Quit"
				Me.Close()

			Case "Copy Chart"
				If reD Then
					Clipboard.Clear()
					Clipboard.SetData(DataFormats.Bitmap, Image1.Image)
				End If

		End Select
		'Set CurrentWKChart = DestroyObject ' WAS DEACTIVATED BY DMS

	End Sub
	Private isInitializingComponent As Boolean
	Private Sub txtScale_TextChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtScale_1.TextChanged, _txtScale_0.TextChanged
		Dim index As Integer = Array.IndexOf(Me.txtScale, eventSender)
		If isInitializingComponent Then
			Exit Sub
		End If
		ClearIt()
		If Not VerifyPositive(txtScale(index).Text) Then txtScale(index).Text = ""
	End Sub

	Private Sub txtScale_Validating(ByVal eventSender As Object, ByVal eventArgs As CancelEventArgs) Handles _txtScale_1.Validating, _txtScale_0.Validating
		Dim index As Integer = Array.IndexOf(Me.txtScale, eventSender)
		Dim Cancel As Boolean = eventArgs.Cancel
		Try
			If txtScale(index).Text = "" Then Cancel = True
			ClearIt()
		Finally 
			eventArgs.Cancel = Cancel
		End Try
	End Sub
	Private Sub Form_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
	End Sub
End Class