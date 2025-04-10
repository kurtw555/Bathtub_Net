Option Strict Off
Option Explicit On
Imports BT2Support.UpgradeStubs
Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports UpgradeHelpers.Gui.Controls
Imports UpgradeHelpers.Helpers
Partial Friend Class frmTribs
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


	Private Sub frmTribs_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		If Not (UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm Is eventSender) Then
			UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm = eventSender
		End If
	End Sub
	Private jtriB As Integer
	Private Const nboX As Integer = 23

	Private Sub Toolbar1_ButtonClick(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles Toolbar1_Buttons_Button1.Click, Toolbar1_Buttons_Button2.Click, Toolbar1_Buttons_Button3.Click, Toolbar1_Buttons_Button4.Click, Toolbar1_Buttons_Button5.Click, Toolbar1_Buttons_Button6.Click, Toolbar1_Buttons_Button7.Click, Toolbar1_Buttons_Button8.Click, Toolbar1_Buttons_Button9.Click
		Dim Button As ToolStripItem = CType(eventSender, ToolStripItem)
		Dim i As Double
		Dim j As Integer
		Dim jseG As Byte
		Dim s As String = ""


		Select Case Button.Text
			Case "List"
				'UPGRADE_ISSUE: (2070) Constant VgaColor was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2070
				UpdateTribValues(BT2Support.UpgradeStubs.stdole_LoadPictureConstants.getVgaColor())
				'UPGRADE_ISSUE: (2064) Menu property mnuListNetwork.HelpContextID was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2064
				'KW
				'ContextId = frmMenu.DefInstance.mnuListNetwork.HelpContextID
				List_Tree()
				ViewSheet("Segment Network")

			Case "Add"
				If NTrib = NTMAX Then
					MessageBox.Show("Too many tributaries", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

				Else
					If MessageBox.Show("Add New Tributary ?", My.Application.Info.Title, MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
						'UPGRADE_ISSUE: (2070) Constant VgaColor was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2070
						UpdateTribValues(BT2Support.UpgradeStubs.stdole_LoadPictureConstants.getVgaColor())
						TribEdit(NTrib, 1)
						jtriB = NTrib
						UpdateCombo1()
						'UPGRADE_ISSUE: (2070) Constant Monochrome was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2070
						UpdateTribValues(BT2Support.UpgradeStubs.stdole_LoadPictureConstants.getMonochrome())
					End If
				End If

			Case "Insert"

				If NTrib = NTMAX Then
					MessageBox.Show("Too many tributaries", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
				Else
					If MessageBox.Show("Insert New Tributary ?", My.Application.Info.Title, MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
						'UPGRADE_ISSUE: (2070) Constant VgaColor was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2070
						UpdateTribValues(BT2Support.UpgradeStubs.stdole_LoadPictureConstants.getVgaColor())
						TribEdit(jtriB, 1)
						jtriB += 1
						UpdateCombo1()
						'UPGRADE_ISSUE: (2070) Constant Monochrome was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2070
						UpdateTribValues(BT2Support.UpgradeStubs.stdole_LoadPictureConstants.getMonochrome())
					End If
				End If

			Case "Delete"
				If MessageBox.Show("Delete Tributary " & TribName(jseG) & " ?", My.Application.Info.Title, MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
					TribEdit(jtriB, 0)
					jtriB = 1
					UpdateCombo1()
					'UPGRADE_ISSUE: (2070) Constant Monochrome was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2070
					UpdateTribValues(BT2Support.UpgradeStubs.stdole_LoadPictureConstants.getMonochrome())
				End If

			Case "Clear"
				If MessageBox.Show("Clear All Input Values for Selected Tributary?", My.Application.Info.Title, MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
					s = TribName(jtriB)
					i = Iseg(jtriB)
					j = Icode(jtriB)
					TribZero(jtriB) 'exclude name, segment number, & type
					TribName(jtriB) = s
					Iseg(jtriB) = i
					Icode(jtriB) = j
					UpdateCombo1()
					'UPGRADE_ISSUE: (2070) Constant Monochrome was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2070
					UpdateTribValues(BT2Support.UpgradeStubs.stdole_LoadPictureConstants.getMonochrome())
				End If

			Case "Undo"
				Backup(1)
				jtriB = 1
				UpdateCombo1()
				'UPGRADE_ISSUE: (2070) Constant Monochrome was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2070
				UpdateTribValues(BT2Support.UpgradeStubs.stdole_LoadPictureConstants.getMonochrome())

			Case "Help"
				'UPGRADE_ISSUE: (2064) Form property frmTribs.HelpContextID was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2064
				ShowHelp(Me.getHelpContextID())

			Case "Cancel"
				Backup(1)
				Me.Close()

			Case "OK"
				'UPGRADE_ISSUE: (2070) Constant VgaColor was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2070
				UpdateTribValues(BT2Support.UpgradeStubs.stdole_LoadPictureConstants.getVgaColor())
				Icalc = 0
				Me.Close()

		End Select
	End Sub

	'Private Sub cmbTribSeg_Click()
	'changed segment assignment
	'    txtText(22) = cmbTribSeg.ListIndex
	'End Sub

	'Private Sub cmbTribType_Click()
	'changed tributary type code
	'    txtText(23) = cmbTribType.ListIndex + 1
	'End Sub

	'UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-2080
	Private Sub Form_Load()
		Backup(0)
		jtriB = 1
		UpdateCombo1()
		UpdateSegBox()
		UpdateTribTypeBox()
		SetToolTips()
		'UPGRADE_ISSUE: (2070) Constant Monochrome was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2070
		UpdateTribValues(BT2Support.UpgradeStubs.stdole_LoadPictureConstants.getMonochrome())

		'land use category labels
		For i As Double = 1 To NCAT
			lblLabel(CInt(i + 11)).Text = LandUseName(CInt(i))
		Next i

	End Sub

	Sub UpdateSegBox()
		If Iseg(jtriB) = 0 Then MessageBox.Show("segment=0", My.Application.Info.Title)
		With cmbTribSeg
			.Items.Clear()
			.AddItem("No Segment - Trib. Ignored")
			For i As Double = 1 To Nseg
				.AddItem(StringsHelper.Format(i, "00") & " " & SegName(CInt(i)))
			Next i
			.SelectedIndex = Iseg(jtriB)
		End With
	End Sub

	Sub UpdateTribTypeBox()
		With cmbTribType
			.Items.Clear()
			For i As Integer = 1 To N_Type_Codes
				.AddItem(StringsHelper.Format(i, "00") & " " & Type_Code(i))
			Next i
			.SelectedIndex = Icode(jtriB) - 1
		End With
	End Sub

	Private Sub Combo1_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles Combo1.SelectedIndexChanged
		'load new Trib
		Dim j As Double = Combo1.SelectedIndex + 1
		If j <> jtriB Then
			'UPGRADE_ISSUE: (2070) Constant VgaColor was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2070
			UpdateTribValues(BT2Support.UpgradeStubs.stdole_LoadPictureConstants.getVgaColor())
		End If
		jtriB = j
		Combo1.SelectedIndex = jtriB - 1
		UpdateSegBox()
		UpdateTribTypeBox()
		'UPGRADE_ISSUE: (2070) Constant Monochrome was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2070
		UpdateTribValues(BT2Support.UpgradeStubs.stdole_LoadPictureConstants.getMonochrome())
	End Sub

	Sub UpdateCombo1()
		lblCount.Text = "Number of Tributaries = " & NTrib
		With Combo1
			.Items.Clear()
			For i As Double = 1 To NTrib
				.AddItem(StringsHelper.Format(i, "00") & " " & TribName(CInt(i)))
			Next i
			.SelectedIndex = jtriB - 1
		End With
	End Sub

	'UPGRADE_ISSUE: (2068) stdole.LoadPictureConstants object was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2068
	Sub UpdateTribValues(ByVal io As BT2Support.UpgradeStubs.stdole_LoadPictureConstantsEnum)
		'io=1 copy source values to txttextorary array
		'io=2 copy from txttextorary array to original
		'io=3 copy from text boxes to txttextorary array
		'io=4 copy from txttextorary array to text boxes
		'io=5 clear txttextorary array to default values

		'UPGRADE_ISSUE: (2070) Constant Default was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2070

		Select Case io
			Case 1 'fill txttextorary array

				txtText(13).Text = TribName(jtriB)
				txtText(0).Text = CStr(Darea(jtriB)) 'Trib number
				txtText(1).Text = CStr(Flow(jtriB)) 'Trib label
				txtText(2).Text = CStr(CvFlow(jtriB))
				txtText(3).Text = CStr(Conci(jtriB, 2))
				txtText(4).Text = CStr(CvCi(jtriB, 2))
				txtText(5).Text = CStr(Conci(jtriB, 4))
				txtText(6).Text = CStr(CvCi(jtriB, 4))
				txtText(7).Text = CStr(Conci(jtriB, 3))
				txtText(8).Text = CStr(CvCi(jtriB, 3))
				txtText(9).Text = CStr(Conci(jtriB, 5))
				txtText(10).Text = CStr(CvCi(jtriB, 5))
				txtText(11).Text = CStr(Conci(jtriB, 1))
				txtText(12).Text = CStr(CvCi(jtriB, 1))

				txtText(14).Text = CStr(Warea(jtriB, 1))
				txtText(15).Text = CStr(Warea(jtriB, 2))
				txtText(16).Text = CStr(Warea(jtriB, 3))
				txtText(17).Text = CStr(Warea(jtriB, 4))
				txtText(18).Text = CStr(Warea(jtriB, 5))
				txtText(19).Text = CStr(Warea(jtriB, 6))
				txtText(20).Text = CStr(Warea(jtriB, 7))
				txtText(21).Text = CStr(Warea(jtriB, 8))
				'txtText(22) = Iseg(jtriB)
				'txtText(23) = Icode(jtriB)
				cmbTribSeg.SelectedIndex = Iseg(jtriB)
				cmbTribType.SelectedIndex = Icode(jtriB) - 1

				'Changed = False

			Case 2 'copy from text array back to original values

				Combo1.SetListItem(jtriB - 1, StringsHelper.Format(jtriB - 1, "00") & " " & txtText(13).Text)
				TribName(jtriB) = txtText(13).Text
				Darea(jtriB) = CSng(txtText(0).Text)
				Flow(jtriB) = CSng(txtText(1).Text)
				CvFlow(jtriB) = CSng(txtText(2).Text)
				Conci(jtriB, 2) = CSng(txtText(3).Text)
				CvCi(jtriB, 2) = CSng(txtText(4).Text)
				Conci(jtriB, 4) = CSng(txtText(5).Text)
				CvCi(jtriB, 4) = CSng(txtText(6).Text)
				Conci(jtriB, 3) = CSng(txtText(7).Text)
				CvCi(jtriB, 3) = CSng(txtText(8).Text)
				Conci(jtriB, 5) = CSng(txtText(9).Text)
				CvCi(jtriB, 5) = CSng(txtText(10).Text)
				Conci(jtriB, 1) = CSng(txtText(11).Text)
				CvCi(jtriB, 1) = CSng(txtText(12).Text)

				Warea(jtriB, 1) = CSng(txtText(14).Text)
				Warea(jtriB, 2) = CSng(txtText(15).Text)
				Warea(jtriB, 3) = CSng(txtText(16).Text)
				Warea(jtriB, 4) = CSng(txtText(17).Text)
				Warea(jtriB, 5) = CSng(txtText(18).Text)
				Warea(jtriB, 6) = CSng(txtText(19).Text)
				Warea(jtriB, 7) = CSng(txtText(20).Text)
				Warea(jtriB, 8) = CSng(txtText(21).Text)

				'Iseg(jtriB) = txtText(22)
				'Icode(jtriB) = txtText(23)
				Iseg(jtriB) = cmbTribSeg.SelectedIndex
				Icode(jtriB) = cmbTribType.SelectedIndex + 1

			Case 3 'set defaults
				'   For j = 0 To nboX
				'       If j <> 13 And j <> 22 And j <> 23 Then txtText(j) = 0
				'       Next j
				'   'txtText(22) = 1
				'   'txtText(23) = 1
				'   Changed = True

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

		For i As Integer = 0 To 21
			txtText(i).TabIndex = i
		Next i

		'tab 0 monitored inputs
		ToolTipMain.SetToolTip(txtText(13), "Tributary Name")
		ToolTipMain.SetToolTip(txtText(22), "Segment Name")
		ToolTipMain.SetToolTip(txtText(23), "Tributary Type")

		ToolTipMain.SetToolTip(txtText(0), "Total Drainage Area (km2)")
		ToolTipMain.SetToolTip(txtText(1), "Flow (hm3/yr)")
		ToolTipMain.SetToolTip(txtText(2), "Coefficient of Variation for Total Flow")
		ToolTipMain.SetToolTip(txtText(3), "Total Phosphorus Conc (ppb)")
		ToolTipMain.SetToolTip(txtText(4), "Coefficient of Variation for Total P Concentration")

		ToolTipMain.SetToolTip(txtText(5), "Ortho Phosphorus Conc (ppb)")
		ToolTipMain.SetToolTip(txtText(6), "Coefficient of Variation for Ortho P Concentration")
		ToolTipMain.SetToolTip(txtText(7), "Total Nitrogen Conc (ppb)")
		ToolTipMain.SetToolTip(txtText(8), "Coefficient of Variation for Total P Nitrogen")
		ToolTipMain.SetToolTip(txtText(9), "Inorganic Nitrogen Conc (ppb)")
		ToolTipMain.SetToolTip(txtText(10), "Coefficient of Variation for Inorganic N Concentration")
		ToolTipMain.SetToolTip(txtText(11), "Conservative Substance Conc (ppb)")
		ToolTipMain.SetToolTip(txtText(12), "Coefficient of Variation for Conservative Substance Concentration")

		'tab 1 nonpoint watersheds
		ToolTipMain.SetToolTip(txtText(14), "Drainage Area in LandUse Category 1")
		ToolTipMain.SetToolTip(txtText(15), "Drainage Area in LandUse Category 2")
		ToolTipMain.SetToolTip(txtText(16), "Drainage Area in LandUse Category 3")
		ToolTipMain.SetToolTip(txtText(17), "Drainage Area in LandUse Category 4")
		ToolTipMain.SetToolTip(txtText(18), "Drainage Area in LandUse Category 5")
		ToolTipMain.SetToolTip(txtText(19), "Drainage Area in LandUse Category 6")
		ToolTipMain.SetToolTip(txtText(20), "Drainage Area in LandUse Category 7")
		ToolTipMain.SetToolTip(txtText(21), "Drainage Area in LandUse Category 8")

	End Sub


	Private isInitializingComponent As Boolean
	Private Sub txtText_TextChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtText_23.TextChanged, _txtText_21.TextChanged, _txtText_20.TextChanged, _txtText_19.TextChanged, _txtText_18.TextChanged, _txtText_17.TextChanged, _txtText_16.TextChanged, _txtText_15.TextChanged, _txtText_14.TextChanged, _txtText_13.TextChanged, _txtText_12.TextChanged, _txtText_11.TextChanged, _txtText_10.TextChanged, _txtText_9.TextChanged, _txtText_8.TextChanged, _txtText_7.TextChanged, _txtText_6.TextChanged, _txtText_5.TextChanged, _txtText_4.TextChanged, _txtText_3.TextChanged, _txtText_2.TextChanged, _txtText_1.TextChanged, _txtText_0.TextChanged, _txtText_22.TextChanged
		Dim index As Integer = Array.IndexOf(Me.txtText, eventSender)
		If isInitializingComponent Then
			Exit Sub
		End If

		lblDefinitions.Text = ToolTipMain.GetToolTip(txtText(index))

		'allow numeric entries only
		If index <> 13 And index <> 22 And index <> 23 Then
			If Not VerifyPositive(txtText(index).Text) Then txtText(index).Text = ""
		End If

	End Sub
	Private Sub txtText_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtText_23.Leave, _txtText_21.Leave, _txtText_20.Leave, _txtText_19.Leave, _txtText_18.Leave, _txtText_17.Leave, _txtText_16.Leave, _txtText_15.Leave, _txtText_14.Leave, _txtText_13.Leave, _txtText_12.Leave, _txtText_11.Leave, _txtText_10.Leave, _txtText_9.Leave, _txtText_8.Leave, _txtText_7.Leave, _txtText_6.Leave, _txtText_5.Leave, _txtText_4.Leave, _txtText_3.Leave, _txtText_2.Leave, _txtText_1.Leave, _txtText_0.Leave, _txtText_22.Leave
		Dim index As Integer = Array.IndexOf(Me.txtText, eventSender)

		If index <> 13 And index <> 22 And index <> 23 Then
			If txtText(index).Text = "" Then txtText(index).Text = CStr(0)
		End If

	End Sub

	Private Sub txtText_MouseMove(ByVal eventSender As Object, ByVal eventArgs As MouseEventArgs) Handles _txtText_23.MouseMove, _txtText_21.MouseMove, _txtText_20.MouseMove, _txtText_19.MouseMove, _txtText_18.MouseMove, _txtText_17.MouseMove, _txtText_16.MouseMove, _txtText_15.MouseMove, _txtText_14.MouseMove, _txtText_13.MouseMove, _txtText_12.MouseMove, _txtText_11.MouseMove, _txtText_10.MouseMove, _txtText_9.MouseMove, _txtText_8.MouseMove, _txtText_7.MouseMove, _txtText_6.MouseMove, _txtText_5.MouseMove, _txtText_4.MouseMove, _txtText_3.MouseMove, _txtText_2.MouseMove, _txtText_1.MouseMove, _txtText_0.MouseMove, _txtText_22.MouseMove
		Dim index As Integer = Array.IndexOf(Me.txtText, eventSender)
		Dim Button As Integer = IIf(eventArgs.Button = MouseButtons.Left, 1, IIf(eventArgs.Button = MouseButtons.Right, 2, 4))
		Dim Shift As Integer = Control.ModifierKeys / 65536
		Dim x As Single = eventArgs.X * 15
		Dim y As Single = eventArgs.Y * 15
		lblDefinitions.Text = ToolTipMain.GetToolTip(txtText(index))
	End Sub

	Private Sub SSTab1_MouseMove(ByVal eventSender As Object, ByVal eventArgs As MouseEventArgs) Handles SSTab1.MouseMove
		Dim Button As Integer = IIf(eventArgs.Button = MouseButtons.Left, 1, IIf(eventArgs.Button = MouseButtons.Right, 2, 4))
		Dim Shift As Integer = Control.ModifierKeys / 65536
		Dim x As Single = eventArgs.X * 15
		Dim y As Single = eventArgs.Y * 15
		lblDefinitions.Text = ""
	End Sub
	'UPGRADE_NOTE: (7001) The following declaration (SSTab2_MouseMove) seems to be dead code More Information: https://docs.mobilize.net/vbuc/ewis/notes#id-7001
	'Private Sub SSTab2_MouseMove(ByVal Button As Integer, ByVal Shift As Integer, ByVal x As Single, ByVal y As Single)
		'lblDefinitions.Text = ""
	'End Sub
	Private Sub Form_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
	End Sub
End Class