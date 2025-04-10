Option Strict Off
Option Explicit On
Imports BT2Support.UpgradeStubs
Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Partial Friend Class frmCoefficients
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


	Private Sub frmCoefficients_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		If Not (UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm Is eventSender) Then
			UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm = eventSender
		End If
	End Sub
	Const nboX As Integer = 28

	Private Sub Toolbar1_ButtonClick(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles Toolbar1_Buttons_Button1.Click, Toolbar1_Buttons_Button2.Click, Toolbar1_Buttons_Button3.Click, Toolbar1_Buttons_Button4.Click, Toolbar1_Buttons_Button5.Click
		Dim Button As ToolStripItem = CType(eventSender, ToolStripItem)


		Select Case Button.Text
			Case "Undo"
				'UPGRADE_ISSUE: (2070) Constant Monochrome was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2070
				UpdateCoefValues(BT2Support.UpgradeStubs.stdole_LoadPictureConstants.getMonochrome())

			Case "Cancel"

				Me.Close()

			Case "OK"
				Icalc = 0
				'UPGRADE_ISSUE: (2070) Constant VgaColor was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2070
				UpdateCoefValues(BT2Support.UpgradeStubs.stdole_LoadPictureConstants.getVgaColor())
				Me.Close()

			Case "Help"
				'UPGRADE_ISSUE: (2064) Form property frmCoefficients.HelpContextID was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2064
				ShowHelp(Me.getHelpContextID())

			Case "Defaults"
				If MessageBox.Show("Assign Default Values for Each Coefficient?", My.Application.Info.Title, MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
					'UPGRADE_ISSUE: (2068) stdole.LoadPictureConstants object was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2068
					UpdateCoefValues(3)
				End If

		End Select
	End Sub
	'UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-2080
	Private Sub Form_Load()
		SetToolTips()
		'UPGRADE_ISSUE: (2070) Constant Monochrome was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2070
		UpdateCoefValues(BT2Support.UpgradeStubs.stdole_LoadPictureConstants.getMonochrome())
	End Sub
	'UPGRADE_ISSUE: (2068) stdole.LoadPictureConstants object was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2068
	Private Sub UpdateCoefValues(ByVal io As BT2Support.UpgradeStubs.stdole_LoadPictureConstantsEnum)
		'io=1 copy source values to temporary array
		'io=2 copy from temporary array to original
		'io=3 copy defaults

		'UPGRADE_ISSUE: (2070) Constant Default was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2070

		Select Case io
			Case 1 'fill temporary array

				For j As Double = 1 To NXk
					Text1(CInt(j - 1)).Text = CStr(Xk(CInt(j)))
					If j < 13 Then Text1(CInt(j + 16)).Text = CStr(CvXk(CInt(j)))
				Next j


			Case 2 'copy from temporary array back to original values

				For j As Double = 1 To NXk
					Xk(CInt(j)) = CSng(Text1(CInt(j - 1)).Text)
					If j < 13 Then CvXk(CInt(j)) = CSng(Text1(CInt(j + 16)).Text)
				Next j


			Case 3 'set defaults

				For j As Double = 1 To NXk
					Text1(CInt(j - 1)).Text = CStr(XkDefault(CInt(j)))
					If j < 13 Then Text1(CInt(j + 16)).Text = CStr(CvXkDefault(CInt(j)))
				Next j

			Case BT2Support.UpgradeStubs.stdole_LoadPictureConstants.getdefault()

		End Select

	End Sub
	Private Sub Form_MouseMove(ByVal eventSender As Object, ByVal eventArgs As MouseEventArgs) Handles MyBase.MouseMove
		Dim Button As Integer = IIf(eventArgs.Button = MouseButtons.Left, 1, IIf(eventArgs.Button = MouseButtons.Right, 2, 4))
		Dim Shift As Integer = Control.ModifierKeys / 65536
		Dim x As Single = eventArgs.X * 15
		Dim y As Single = eventArgs.Y * 15
		lblDefinitions.Text = ""
	End Sub

	Private Sub SetToolTips()
		ToolTipMain.SetToolTip(Text1(0), "Calibration Factor Longitudinal Dispersion")
		ToolTipMain.SetToolTip(Text1(1), "Calibration Factor for Total P")
		ToolTipMain.SetToolTip(Text1(2), "Calibration Factor for Total N")
		ToolTipMain.SetToolTip(Text1(3), "Calibration Factor for Chlorophyll-a")
		ToolTipMain.SetToolTip(Text1(4), "Calibration Factor for Secchi Depth")
		ToolTipMain.SetToolTip(Text1(5), "Calibration Factor for Organic Nitrogen")
		ToolTipMain.SetToolTip(Text1(6), "Calibration Factor for Total P - Ortho P")
		ToolTipMain.SetToolTip(Text1(7), "Calibration Factor for Hypolimnetic Oxygen Depletion")
		ToolTipMain.SetToolTip(Text1(8), "Calibration Factor for Metalimnetic Oxygen Depletion")
		ToolTipMain.SetToolTip(Text1(9), "Slope of 1/Secchi vs. Chl-a Plot (m2/mg)")
		ToolTipMain.SetToolTip(Text1(10), "Minimum Water Load for P & N Sedimentation Models")
		ToolTipMain.SetToolTip(Text1(11), "Flushing Factor in Chlorophyll-a Model")
		ToolTipMain.SetToolTip(Text1(12), "Chlorophyll-a Temporal Coef. of Variation")
		ToolTipMain.SetToolTip(Text1(13), "Total P Availability Factor")
		ToolTipMain.SetToolTip(Text1(14), "Ortho P Availability Factor")
		ToolTipMain.SetToolTip(Text1(15), "Total N Availability Factor")
		ToolTipMain.SetToolTip(Text1(16), "Inorganic N Availibility Factor")

		ToolTipMain.SetToolTip(Text1(17), "Model Error CV Longitudinal Dispersion")
		ToolTipMain.SetToolTip(Text1(18), "Model Error CV for Total P")
		ToolTipMain.SetToolTip(Text1(19), "Model Error CV for Total N")
		ToolTipMain.SetToolTip(Text1(20), "Model Error CV for Chlorophyll-a")
		ToolTipMain.SetToolTip(Text1(21), "Model Error CV for Secchi Depth")
		ToolTipMain.SetToolTip(Text1(22), "Model Error CV for Organic Nitrogen")
		ToolTipMain.SetToolTip(Text1(23), "Model Error CV for Total P - Ortho P")
		ToolTipMain.SetToolTip(Text1(24), "Model Error CV for Hypolimnetic Oxygen Depletion")
		ToolTipMain.SetToolTip(Text1(25), "Model Error CV for Metalimnetic Oxygen Depletion")
		ToolTipMain.SetToolTip(Text1(26), "CV of Slope of 1/Secchi vs. Chl-a Plot (m2/mg)")
		ToolTipMain.SetToolTip(Text1(27), "CV of Minimum Water Load for P & N Sedimentation Models")
		ToolTipMain.SetToolTip(Text1(28), "CV of Flushing Factor in Chlorophyll-a Model")

	End Sub

	Private isInitializingComponent As Boolean
	Private Sub text1_TextChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Text1_11.TextChanged, _Text1_28.TextChanged, _Text1_0.TextChanged, _Text1_1.TextChanged, _Text1_2.TextChanged, _Text1_3.TextChanged, _Text1_4.TextChanged, _Text1_5.TextChanged, _Text1_6.TextChanged, _Text1_7.TextChanged, _Text1_8.TextChanged, _Text1_9.TextChanged, _Text1_10.TextChanged, _Text1_12.TextChanged, _Text1_27.TextChanged, _Text1_26.TextChanged, _Text1_25.TextChanged, _Text1_24.TextChanged, _Text1_23.TextChanged, _Text1_22.TextChanged, _Text1_21.TextChanged, _Text1_20.TextChanged, _Text1_19.TextChanged, _Text1_18.TextChanged, _Text1_17.TextChanged, _Text1_16.TextChanged, _Text1_15.TextChanged, _Text1_14.TextChanged, _Text1_13.TextChanged
		Dim index As Integer = Array.IndexOf(Me.Text1, eventSender)
		If isInitializingComponent Then
			Exit Sub
		End If
		If Not VerifyPositive(Text1(index).Text) Then Text1(index).Text = ""
	End Sub
	Private Sub text1_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Text1_11.Leave, _Text1_28.Leave, _Text1_0.Leave, _Text1_1.Leave, _Text1_2.Leave, _Text1_3.Leave, _Text1_4.Leave, _Text1_5.Leave, _Text1_6.Leave, _Text1_7.Leave, _Text1_8.Leave, _Text1_9.Leave, _Text1_10.Leave, _Text1_12.Leave, _Text1_27.Leave, _Text1_26.Leave, _Text1_25.Leave, _Text1_24.Leave, _Text1_23.Leave, _Text1_22.Leave, _Text1_21.Leave, _Text1_20.Leave, _Text1_19.Leave, _Text1_18.Leave, _Text1_17.Leave, _Text1_16.Leave, _Text1_15.Leave, _Text1_14.Leave, _Text1_13.Leave
		Dim index As Integer = Array.IndexOf(Me.Text1, eventSender)
		If Text1(index).Text = "" Then Text1(index).Text = CStr(0)
	End Sub

	Private Sub text1_MouseMove(ByVal eventSender As Object, ByVal eventArgs As MouseEventArgs) Handles _Text1_11.MouseMove, _Text1_28.MouseMove, _Text1_0.MouseMove, _Text1_1.MouseMove, _Text1_2.MouseMove, _Text1_3.MouseMove, _Text1_4.MouseMove, _Text1_5.MouseMove, _Text1_6.MouseMove, _Text1_7.MouseMove, _Text1_8.MouseMove, _Text1_9.MouseMove, _Text1_10.MouseMove, _Text1_12.MouseMove, _Text1_27.MouseMove, _Text1_26.MouseMove, _Text1_25.MouseMove, _Text1_24.MouseMove, _Text1_23.MouseMove, _Text1_22.MouseMove, _Text1_21.MouseMove, _Text1_20.MouseMove, _Text1_19.MouseMove, _Text1_18.MouseMove, _Text1_17.MouseMove, _Text1_16.MouseMove, _Text1_15.MouseMove, _Text1_14.MouseMove, _Text1_13.MouseMove
		Dim index As Integer = Array.IndexOf(Me.Text1, eventSender)
		Dim Button As Integer = IIf(eventArgs.Button = MouseButtons.Left, 1, IIf(eventArgs.Button = MouseButtons.Right, 2, 4))
		Dim Shift As Integer = Control.ModifierKeys / 65536
		Dim x As Single = eventArgs.X * 15
		Dim y As Single = eventArgs.Y * 15
		lblDefinitions.Text = ToolTipMain.GetToolTip(Text1(index))
	End Sub
	Private Sub Form_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
	End Sub
End Class