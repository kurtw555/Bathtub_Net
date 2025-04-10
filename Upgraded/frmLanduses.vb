Option Strict Off
Option Explicit On
Imports BT2Support.UpgradeStubs
Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports UpgradeHelpers.Gui.Controls
Imports UpgradeHelpers.Helpers
Partial Friend Class frmLandUse
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


	Private Sub frmLandUse_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		If Not (UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm Is eventSender) Then
			UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm = eventSender
		End If
	End Sub
	Private Const nboX As Integer = 12
	Private Changed As Boolean
	Private jusE As Integer
	Private Sub Toolbar1_ButtonClick(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles Toolbar1_Buttons_Button1.Click, Toolbar1_Buttons_Button2.Click, Toolbar1_Buttons_Button3.Click, Toolbar1_Buttons_Button4.Click, Toolbar1_Buttons_Button5.Click
		Dim Button As ToolStripItem = CType(eventSender, ToolStripItem)


		Select Case Button.Text
			Case "Undo"
				'restore original values for current coef
				'    If Changed Then
				'    If MsgBox("Restore All Input Values to Previously Saved Values ?", vbYesNo) = vbYes Then
				'        UpdateLandUseValues (1)
				'        End If
				'        End If
				Backup(1)
				jusE = 1
				UpdateCombo1()
				'UPGRADE_ISSUE: (2070) Constant Monochrome was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2070
				UpdateLandUseValues(BT2Support.UpgradeStubs.stdole_LoadPictureConstants.getMonochrome())

			Case "OK"
				'If Changed Then
				'       If MsgBox("Save Edits?", vbYesNo) = vbYes Then UpdateLandUseValues (2)
				'       End If
				'UPGRADE_ISSUE: (2070) Constant VgaColor was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2070
				UpdateLandUseValues(BT2Support.UpgradeStubs.stdole_LoadPictureConstants.getVgaColor())
				Icalc = 0
				Me.Close()

			Case "Cancel"
				Backup(1)
				Me.Close()

			Case "Help"
				'UPGRADE_ISSUE: (2064) Form property frmLandUse.HelpContextID was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2064
				ShowHelp(Me.getHelpContextID())

			Case "Clear"

				If MessageBox.Show("Clear all inputs for current land use?", My.Application.Info.Title, MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
					'UPGRADE_ISSUE: (2068) stdole.LoadPictureConstants object was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2068
					UpdateLandUseValues(3)
					'UPGRADE_ISSUE: (2070) Constant VgaColor was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2070
					UpdateLandUseValues(BT2Support.UpgradeStubs.stdole_LoadPictureConstants.getVgaColor())
				End If
		End Select

	End Sub

	'UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-2080
	Private Sub Form_Load()
		jusE = 1
		Backup(0)
		UpdateCombo1()
		SetToolTips()
		'UPGRADE_ISSUE: (2070) Constant Monochrome was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2070
		UpdateLandUseValues(BT2Support.UpgradeStubs.stdole_LoadPictureConstants.getMonochrome())
	End Sub

	Private Sub Combo1_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles Combo1.SelectedIndexChanged
		'load new LandUse
		Dim j As Integer = Combo1.SelectedIndex + 1
		If j <> jusE Then
			'    If Changed Then
			'        If MsgBox("Save Edits for LandUse " & jusE & LandUseName(jusE) & " ?", vbYesNo) Then UpdateLandUseValues (2)
			'         End If
			'UPGRADE_ISSUE: (2070) Constant VgaColor was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2070
			UpdateLandUseValues(BT2Support.UpgradeStubs.stdole_LoadPictureConstants.getVgaColor())
			jusE = j
			Combo1.SelectedIndex = jusE - 1
			'UPGRADE_ISSUE: (2070) Constant Monochrome was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2070
			UpdateLandUseValues(BT2Support.UpgradeStubs.stdole_LoadPictureConstants.getMonochrome())
		End If
	End Sub

	Sub UpdateCombo1()
		With Combo1
			.Items.Clear()
			For i As Double = 1 To NCAT
				.AddItem(StringsHelper.Format(i, "00") & " " & LandUseName(CInt(i)))
			Next i
			.SelectedIndex = jusE - 1
		End With
	End Sub

	'UPGRADE_ISSUE: (2068) stdole.LoadPictureConstants object was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2068
	Sub UpdateLandUseValues(ByVal io As BT2Support.UpgradeStubs.stdole_LoadPictureConstantsEnum)
		'io=1 copy source values to temporary array
		'io=2 copy from temporary array to original
		'io=3 clear temporary array to default values

		'UPGRADE_ISSUE: (2070) Constant Default was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2070

		Select Case io
			Case 1 'fill temporary array

				Text1(0).Text = LandUseName(jusE) 'LandUse label
				Text1(1).Text = CStr(Ur(jusE)) 'unit runoff
				Text1(2).Text = CStr(CvUr(jusE)) 'unit runoff
				Text1(3).Text = CStr(Uc(jusE, 2)) 'tp
				Text1(4).Text = CStr(CvUc(jusE, 2))
				Text1(5).Text = CStr(Uc(jusE, 4)) 'srp
				Text1(6).Text = CStr(CvUc(jusE, 4))
				Text1(7).Text = CStr(Uc(jusE, 3)) 'tn
				Text1(8).Text = CStr(CvUc(jusE, 3))
				Text1(9).Text = CStr(Uc(jusE, 5)) 'inorgn
				Text1(10).Text = CStr(CvUc(jusE, 5))
				Text1(11).Text = CStr(Uc(jusE, 1)) 'cons
				Text1(12).Text = CStr(CvUc(jusE, 1))
				Changed = False

			Case 2 'copy from temporary array back to original values

				Combo1.SetListItem(jusE - 1, StringsHelper.Format(jusE - 1, "00") & " " & Text1(0).Text)
				LandUseName(jusE) = Text1(0).Text 'LandUse label
				Ur(jusE) = CSng(Text1(1).Text) 'unit runoff
				CvUr(jusE) = CSng(Text1(2).Text) 'unit runoff
				Uc(jusE, 2) = CSng(Text1(3).Text) 'tp
				CvUc(jusE, 2) = CSng(Text1(4).Text)
				Uc(jusE, 4) = CSng(Text1(5).Text) 'srp
				CvUc(jusE, 4) = CSng(Text1(6).Text)
				Uc(jusE, 3) = CSng(Text1(7).Text) 'tn
				CvUc(jusE, 3) = CSng(Text1(8).Text)
				Uc(jusE, 5) = CSng(Text1(9).Text) 'inorgn
				CvUc(jusE, 5) = CSng(Text1(10).Text)
				Uc(jusE, 1) = CSng(Text1(11).Text) 'cons
				CvUc(jusE, 1) = CSng(Text1(12).Text)
				Changed = False

			Case 3 'set defaults
				Text1(0).Text = "Landuse " & jusE
				For j As Integer = 1 To nboX
					Text1(j).Text = CStr(0)
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
		ToolTipMain.SetToolTip(Text1(0), "Land Use Name")
		ToolTipMain.SetToolTip(Text1(1), "Unit Area Runoff (m/yr)")
		ToolTipMain.SetToolTip(Text1(2), "CV of Unit Area Runoff (m/yr)")
		ToolTipMain.SetToolTip(Text1(3), "Runoff Total P Conc (ppb)")
		ToolTipMain.SetToolTip(Text1(4), "CV of Runoff Total P Conc (ppb)")
		ToolTipMain.SetToolTip(Text1(5), "Runoff Ortho P Conc (ppb)")
		ToolTipMain.SetToolTip(Text1(6), "CV of Runoff Ortho P Conc (ppb)")
		ToolTipMain.SetToolTip(Text1(7), "Runoff Total N Conc (ppb)")
		ToolTipMain.SetToolTip(Text1(8), "CV of Runoff Total N Conc (ppb)")
		ToolTipMain.SetToolTip(Text1(9), "Runoff Inorganic N Conc (ppb)")
		ToolTipMain.SetToolTip(Text1(10), "CV of Runoff Inorganic N Conc (ppb)")
		ToolTipMain.SetToolTip(Text1(11), "Runoff Conservative Substance Conc (ppb)")
		ToolTipMain.SetToolTip(Text1(12), "CV of Runoff Conservative Substance Conc (ppb)")
	End Sub

	Private isInitializingComponent As Boolean
	Private Sub text1_TextChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Text1_12.TextChanged, _Text1_11.TextChanged, _Text1_10.TextChanged, _Text1_9.TextChanged, _Text1_8.TextChanged, _Text1_7.TextChanged, _Text1_6.TextChanged, _Text1_5.TextChanged, _Text1_4.TextChanged, _Text1_3.TextChanged, _Text1_2.TextChanged, _Text1_1.TextChanged, _Text1_0.TextChanged
		Dim index As Integer = Array.IndexOf(Me.Text1, eventSender)
		If isInitializingComponent Then
			Exit Sub
		End If
		If index <> 0 Then
			If Not VerifyPositive(Text1(index).Text) Then Text1(index).Text = ""
		End If
	End Sub

	Private Sub text1_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Text1_12.Leave, _Text1_11.Leave, _Text1_10.Leave, _Text1_9.Leave, _Text1_8.Leave, _Text1_7.Leave, _Text1_6.Leave, _Text1_5.Leave, _Text1_4.Leave, _Text1_3.Leave, _Text1_2.Leave, _Text1_1.Leave, _Text1_0.Leave
		Dim index As Integer = Array.IndexOf(Me.Text1, eventSender)
		If index <> 0 Then
			If Text1(index).Text = "" Then Text1(index).Text = CStr(0)
		End If
	End Sub


	Private Sub text1_MouseMove(ByVal eventSender As Object, ByVal eventArgs As MouseEventArgs) Handles _Text1_12.MouseMove, _Text1_11.MouseMove, _Text1_10.MouseMove, _Text1_9.MouseMove, _Text1_8.MouseMove, _Text1_7.MouseMove, _Text1_6.MouseMove, _Text1_5.MouseMove, _Text1_4.MouseMove, _Text1_3.MouseMove, _Text1_2.MouseMove, _Text1_1.MouseMove, _Text1_0.MouseMove
		Dim index As Integer = Array.IndexOf(Me.Text1, eventSender)
		Dim Button As Integer = IIf(eventArgs.Button = MouseButtons.Left, 1, IIf(eventArgs.Button = MouseButtons.Right, 2, 4))
		Dim Shift As Integer = Control.ModifierKeys / 65536
		Dim x As Single = eventArgs.X * 15
		Dim y As Single = eventArgs.Y * 15
		lblDefinitions.Text = ToolTipMain.GetToolTip(Text1(index))
	End Sub

	Private Sub Toolbar1_MouseMove(ByVal eventSender As Object, ByVal eventArgs As MouseEventArgs) Handles Toolbar1.MouseMove, Toolbar1_Buttons_Button1.MouseMove, Toolbar1_Buttons_Button2.MouseMove, Toolbar1_Buttons_Button3.MouseMove, Toolbar1_Buttons_Button4.MouseMove, Toolbar1_Buttons_Button5.MouseMove
		Dim Button As Integer = IIf(eventArgs.Button = MouseButtons.Left, 1, IIf(eventArgs.Button = MouseButtons.Right, 2, 4))
		Dim Shift As Integer = Control.ModifierKeys / 65536
		Dim x As Single = eventArgs.X * 15
		Dim y As Single = eventArgs.Y * 15
		'MsgBox "button number : " & Button
		'lblDefinitions.Caption = Toolbar1.Buttons(Button).ToolTipText
	End Sub
	Private Sub Form_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
	End Sub
End Class