Option Strict Off
Option Explicit On
Imports BT2Support.UpgradeStubs
Imports Microsoft.VisualBasic
Imports System
Imports System.Text
Imports System.Windows.Forms
Partial Friend Class frmGlobals
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


	Private Sub frmGlobals_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		If Not (UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm Is eventSender) Then
			UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm = eventSender
		End If
	End Sub
	Private Const nboX As Integer = 18

	Dim glAvrPeriod As Single
	Private Sub Toolbar1_ButtonClick(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles Toolbar1_Buttons_Button1.Click, Toolbar1_Buttons_Button2.Click, Toolbar1_Buttons_Button3.Click, Toolbar1_Buttons_Button4.Click, Toolbar1_Buttons_Button5.Click
		Dim Button As ToolStripItem = CType(eventSender, ToolStripItem)

		Select Case Button.Text
			Case "Undo"
				Backup(1)
				'UPGRADE_ISSUE: (2070) Constant Monochrome was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2070
				UpdateGlobalValues(BT2Support.UpgradeStubs.stdole_LoadPictureConstants.getMonochrome())

			Case "Cancel"
				Backup(1)
				Me.Close()

			Case "OK"
				'UPGRADE_ISSUE: (2070) Constant VgaColor was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2070
				If Not UpdateGlobalValues(BT2Support.UpgradeStubs.stdole_LoadPictureConstants.getVgaColor()) Then Exit Sub
				If CheckValues() Then
					Icalc = 0
					Me.Close()
				End If

			Case "Help"
				'UPGRADE_ISSUE: (2064) Form property frmGlobals.HelpContextID was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2064
				ShowHelp(Me.getHelpContextID())

			Case "Clear"

				If MessageBox.Show("Clear All Values?", My.Application.Info.Title, MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
					'UPGRADE_ISSUE: (2068) stdole.LoadPictureConstants object was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2068
					UpdateGlobalValues(3)
				End If

		End Select

	End Sub
	Private Function CheckValues() As Boolean
		If P(1) <= 0 Then
			MessageBox.Show("Averaging period must be > 0", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
			Return False
		Else
			Return True
		End If
	End Function
	'UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-2080
	Private Sub Form_Load()
		SetToolTips()
		Backup(0)
		'UPGRADE_ISSUE: (2070) Constant Monochrome was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2070
		UpdateGlobalValues(BT2Support.UpgradeStubs.stdole_LoadPictureConstants.getMonochrome())
		glAvrPeriod = P(1) ' hold original value

	End Sub

	'UPGRADE_ISSUE: (2068) stdole.LoadPictureConstants object was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2068
	Private Function UpdateGlobalValues(ByVal io As BT2Support.UpgradeStubs.stdole_LoadPictureConstantsEnum) As Boolean
		Dim result As Boolean = False
		Dim Changed As Boolean
		Dim i As Integer
		Dim s As String = ""
		Dim txt As New StringBuilder()

		'io=1 copy source values to temporary array
		'io=2 copy from temporary array to original
		'io=3 copy from text boxes to temporary array
		'io=4 copy from temporary array to text boxes
		'io=5 clear temporary array to default values
		'UPGRADE_ISSUE: (2070) Constant Default was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2070

		Select Case io
			Case 1 'fill temporary array

				txtGlobal(0).Text = CStr(P(1)) 'Averaging Period (yrs)
				txtGlobal(1).Text = CStr(P(2)) 'precip (m) PER averaging period
				txtGlobal(2).Text = CStr(Cp(2))
				txtGlobal(3).Text = CStr(P(3)) 'evap (m)  PER averaging period
				txtGlobal(4).Text = CStr(Cp(3))
				txtGlobal(5).Text = CStr(P(4)) 'storage increase (m) per averaging period
				txtGlobal(6).Text = CStr(Cp(4))
				txtGlobal(7).Text = CStr(Atm(2)) 'tp
				txtGlobal(8).Text = CStr(CvAtm(2))
				txtGlobal(9).Text = CStr(Atm(4)) 'orthop
				txtGlobal(10).Text = CStr(CvAtm(4))
				txtGlobal(11).Text = CStr(Atm(3)) 'tn
				txtGlobal(12).Text = CStr(CvAtm(3))
				txtGlobal(13).Text = CStr(Atm(5)) 'inorgn
				txtGlobal(14).Text = CStr(CvAtm(5))
				txtGlobal(15).Text = CStr(Atm(1)) 'cl
				txtGlobal(16).Text = CStr(CvAtm(1))
				txtGlobal(17).Text = Title
				txt = New StringBuilder("")
				For i = 1 To 10
					txt.Append(Note(i) & Environment.NewLine)
				Next i
				txtGlobal(18).Text = txt.ToString()


			Case 2 'copy from temporary array back to original values
				'check if averaging period has changed & warn
				P(1) = CSng(txtGlobal(0).Text) 'averaging period
				If Not (P(1) = glAvrPeriod) Then
					If MessageBox.Show("Remember that Precipitation, Evaporation, and Storage Are PER AVERAGING PERIOD", "Averaging Period Changed", MessageBoxButtons.OKCancel) = System.Windows.Forms.DialogResult.Cancel Then Return result
				End If
				P(2) = CSng(txtGlobal(1).Text) 'precip
				Cp(2) = CSng(txtGlobal(2).Text)
				P(3) = CSng(txtGlobal(3).Text) 'evap
				Cp(3) = CSng(txtGlobal(4).Text)
				P(4) = CSng(txtGlobal(5).Text) 'storage
				Cp(4) = CSng(txtGlobal(6).Text)
				Atm(2) = CSng(txtGlobal(7).Text) 'tp
				CvAtm(2) = CSng(txtGlobal(8).Text)
				Atm(4) = CSng(txtGlobal(9).Text) 'orthop
				CvAtm(4) = CSng(txtGlobal(10).Text)
				Atm(3) = CSng(txtGlobal(11).Text) 'tn
				CvAtm(3) = CSng(txtGlobal(12).Text)
				Atm(5) = CSng(txtGlobal(13).Text) 'inorgn
				CvAtm(5) = CSng(txtGlobal(14).Text)
				Atm(1) = CSng(txtGlobal(15).Text) 'cl
				CvAtm(1) = CSng(txtGlobal(16).Text)
				Title = txtGlobal(17).Text
				'notes
				i = 1
				Note(i) = ""
				For j As Integer = 1 To Strings.Len(txtGlobal(18).Text)
					s = txtGlobal(18).Text.Substring(Math.Min(j - 1, txtGlobal(18).Text.Length), Math.Min(1, Math.Max(0, txtGlobal(18).Text.Length - (j - 1))))
					If s = Environment.NewLine Then
						i += 1
						If i > 10 Then Exit For
						Note(i) = ""
					Else
						Note(i) = Note(i) & s
					End If
				Next j
				For j As Integer = i + 1 To 10
					Note(j) = ""
				Next j


			Case 3 'set defaults
				txtGlobal(18).Text = ""
				txtGlobal(17).Text = ""
				For j As Integer = 1 To 16
					txtGlobal(j).Text = CStr(0)
				Next j
				txtGlobal(0).Text = CStr(1)
				Changed = True

			Case BT2Support.UpgradeStubs.stdole_LoadPictureConstants.getdefault()

		End Select
		Return True
	End Function
	Private Sub Form_MouseMove(ByVal eventSender As Object, ByVal eventArgs As MouseEventArgs) Handles MyBase.MouseMove
		Dim Button As Integer = IIf(eventArgs.Button = MouseButtons.Left, 1, IIf(eventArgs.Button = MouseButtons.Right, 2, 4))
		Dim Shift As Integer = Control.ModifierKeys / 65536
		Dim x As Single = eventArgs.X * 15
		Dim y As Single = eventArgs.Y * 15
		lblDefinitions.Text = ""
	End Sub


	Private Sub SetToolTips()
		ToolTipMain.SetToolTip(txtGlobal(0), "Length of Averaging Period for Mass Balance (years)")
		ToolTipMain.SetToolTip(txtGlobal(1), "Total Precipitation (m)")
		ToolTipMain.SetToolTip(txtGlobal(2), "CV of Total Preciptation")
		ToolTipMain.SetToolTip(txtGlobal(3), "Evaporation(m)")
		ToolTipMain.SetToolTip(txtGlobal(4), "CV of Evaporation")
		ToolTipMain.SetToolTip(txtGlobal(5), "Increase in Water Surface Elevation (m)")
		ToolTipMain.SetToolTip(txtGlobal(6), "CV of Storage Increase")
		ToolTipMain.SetToolTip(txtGlobal(7), "Atmospheric Load of Total P (mg/m2-yr)")
		ToolTipMain.SetToolTip(txtGlobal(8), "CV of Atmospheric Total P Load")
		ToolTipMain.SetToolTip(txtGlobal(9), "Atmospheric Load of Ortho P (mg/m2-yr)")
		ToolTipMain.SetToolTip(txtGlobal(10), "CV of Atmospheric Ortho P Load")
		ToolTipMain.SetToolTip(txtGlobal(11), "Atmospheric Load of Total N (mg/m2-yr)")
		ToolTipMain.SetToolTip(txtGlobal(12), "CV of Atmospheric Total N Load")
		ToolTipMain.SetToolTip(txtGlobal(13), "Atmospheric Load of Inorganic N (mg/m2-yr)")
		ToolTipMain.SetToolTip(txtGlobal(14), "CV of Atmospheric Inorganic N Load")
		ToolTipMain.SetToolTip(txtGlobal(15), "Atmospheric Load of Conservative Substance (mg/m2-yr)")
		ToolTipMain.SetToolTip(txtGlobal(16), "CV of Atmospheric Conservative Substance Load")
		ToolTipMain.SetToolTip(txtGlobal(17), "Title for Labeling Output")
		ToolTipMain.SetToolTip(txtGlobal(18), "User Notes")
	End Sub

	Private isInitializingComponent As Boolean
	Private Sub txtglobal_TextChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtGlobal_18.TextChanged, _txtGlobal_17.TextChanged, _txtGlobal_16.TextChanged, _txtGlobal_15.TextChanged, _txtGlobal_14.TextChanged, _txtGlobal_13.TextChanged, _txtGlobal_12.TextChanged, _txtGlobal_11.TextChanged, _txtGlobal_10.TextChanged, _txtGlobal_9.TextChanged, _txtGlobal_8.TextChanged, _txtGlobal_7.TextChanged, _txtGlobal_6.TextChanged, _txtGlobal_5.TextChanged, _txtGlobal_4.TextChanged, _txtGlobal_3.TextChanged, _txtGlobal_2.TextChanged, _txtGlobal_1.TextChanged, _txtGlobal_0.TextChanged
		Dim index As Integer = Array.IndexOf(Me.txtGlobal, eventSender)
		If isInitializingComponent Then
			Exit Sub
		End If
		If index = 0 Then
			'MsgBox ("Remember that Precipitation, Evaporation, and Storage Are PER AVERAGING PERIOD")
		End If
		If index = 5 Then
			If Not VerifyNumber(txtGlobal(index).Text) Then txtGlobal(index).Text = ""
		ElseIf index < 17 Then 
			If Not VerifyPositive(txtGlobal(index).Text) Then txtGlobal(index).Text = ""
		End If
		Dim Changed As Boolean = True
	End Sub
	Private Sub txtglobal_MouseMove(ByVal eventSender As Object, ByVal eventArgs As MouseEventArgs) Handles _txtGlobal_18.MouseMove, _txtGlobal_17.MouseMove, _txtGlobal_16.MouseMove, _txtGlobal_15.MouseMove, _txtGlobal_14.MouseMove, _txtGlobal_13.MouseMove, _txtGlobal_12.MouseMove, _txtGlobal_11.MouseMove, _txtGlobal_10.MouseMove, _txtGlobal_9.MouseMove, _txtGlobal_8.MouseMove, _txtGlobal_7.MouseMove, _txtGlobal_6.MouseMove, _txtGlobal_5.MouseMove, _txtGlobal_4.MouseMove, _txtGlobal_3.MouseMove, _txtGlobal_2.MouseMove, _txtGlobal_1.MouseMove, _txtGlobal_0.MouseMove
		Dim index As Integer = Array.IndexOf(Me.txtGlobal, eventSender)
		Dim Button As Integer = IIf(eventArgs.Button = MouseButtons.Left, 1, IIf(eventArgs.Button = MouseButtons.Right, 2, 4))
		Dim Shift As Integer = Control.ModifierKeys / 65536
		Dim x As Single = eventArgs.X * 15
		Dim y As Single = eventArgs.Y * 15
		lblDefinitions.Text = ToolTipMain.GetToolTip(txtGlobal(index))
	End Sub
	'Private Sub txtGlobal_Validate(Index As Integer, Cancel As Boolean)
	'    If txtGlobal(Index) = "" Then Cancel = True
	'End Sub

	Private Sub txtGlobal_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtGlobal_18.Leave, _txtGlobal_17.Leave, _txtGlobal_16.Leave, _txtGlobal_15.Leave, _txtGlobal_14.Leave, _txtGlobal_13.Leave, _txtGlobal_12.Leave, _txtGlobal_11.Leave, _txtGlobal_10.Leave, _txtGlobal_9.Leave, _txtGlobal_8.Leave, _txtGlobal_7.Leave, _txtGlobal_6.Leave, _txtGlobal_5.Leave, _txtGlobal_4.Leave, _txtGlobal_3.Leave, _txtGlobal_2.Leave, _txtGlobal_1.Leave, _txtGlobal_0.Leave
		Dim index As Integer = Array.IndexOf(Me.txtGlobal, eventSender)
		If index < 17 And txtGlobal(index).Text = "" Then txtGlobal(index).Text = CStr(0)
	End Sub
	Private Sub Form_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
	End Sub
End Class