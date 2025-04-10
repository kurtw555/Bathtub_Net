Option Strict Off
Option Explicit On
Imports BT2Support.UpgradeStubs
Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports UpgradeHelpers.Gui.Controls
Imports UpgradeHelpers.Helpers
Partial Friend Class frmSegments
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


	Private Sub frmSegments_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		If Not (UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm Is eventSender) Then
			UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm = eventSender
		End If
	End Sub
	Private jseG As Integer
	Private Const nboX As Integer = 54

	Private Sub Toolbar1_ButtonClick(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles Toolbar1_Buttons_Button1.Click, Toolbar1_Buttons_Button2.Click, Toolbar1_Buttons_Button3.Click, Toolbar1_Buttons_Button4.Click, Toolbar1_Buttons_Button5.Click, Toolbar1_Buttons_Button6.Click, Toolbar1_Buttons_Button7.Click, Toolbar1_Buttons_Button8.Click, Toolbar1_Buttons_Button9.Click
		Dim Button As ToolStripItem = CType(eventSender, ToolStripItem)
		Dim s As String = ""
		Dim j As Integer


		Select Case Button.Text
			Case "List"
				'UPGRADE_ISSUE: (2070) Constant VgaColor was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2070
				UpdateSegmentValues(BT2Support.UpgradeStubs.stdole_LoadPictureConstants.getVgaColor())
				'UPGRADE_ISSUE: (2064) Menu property mnuListNetwork.HelpContextID was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2064
				'KW
				'ContextId = frmMenu.DefInstance.mnuListNetwork.HelpContextID
				List_Tree()
				ViewSheet("Segment Network")

			Case "Add"
				If Nseg = NSMAX - 1 Then
					MessageBox.Show("Too many segments", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
				Else
					If MessageBox.Show("Add New Segment ?", My.Application.Info.Title, MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
						'UPGRADE_ISSUE: (2070) Constant VgaColor was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2070
						UpdateSegmentValues(BT2Support.UpgradeStubs.stdole_LoadPictureConstants.getVgaColor())
						If CheckValues() Then
							SegmentEdit(Nseg, 1)
							jseG = Nseg
							UpdateCombos()
							'UPGRADE_ISSUE: (2070) Constant Monochrome was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2070
							UpdateSegmentValues(BT2Support.UpgradeStubs.stdole_LoadPictureConstants.getMonochrome())
						End If
					End If
				End If

			Case "Insert"
				If Nseg = NSMAX - 1 Then
					MessageBox.Show("Too many segments", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
				Else
					If MessageBox.Show("Insert New Segment ?", My.Application.Info.Title, MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
						'UPGRADE_ISSUE: (2070) Constant VgaColor was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2070
						UpdateSegmentValues(BT2Support.UpgradeStubs.stdole_LoadPictureConstants.getVgaColor())
						If CheckValues() Then
							SegmentEdit(jseG, 1)
							jseG += 1
							UpdateCombos()
							'UPGRADE_ISSUE: (2070) Constant Monochrome was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2070
							UpdateSegmentValues(BT2Support.UpgradeStubs.stdole_LoadPictureConstants.getMonochrome())
						End If
					End If
				End If

			Case "Delete"
				If Nseg <= 1 Then
					MessageBox.Show("You can't delete the only segment", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
				Else
					If MessageBox.Show("Delete Segment " & jseG & " " & SegName(jseG) & " ?", My.Application.Info.Title, MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
						SegmentEdit(jseG, 0)
						jseG = 1
						UpdateCombos()
						'UPGRADE_ISSUE: (2070) Constant Monochrome was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2070
						UpdateSegmentValues(BT2Support.UpgradeStubs.stdole_LoadPictureConstants.getMonochrome())
					End If
				End If


			Case "Clear"
				If MessageBox.Show("Clear All Input Values for Selected Segment?", My.Application.Info.Title, MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
					s = SegName(jseG)
					j = Iout(jseG)
					SegZero(jseG)
					Iout(jseG) = j
					SegName(jseG) = s
					UpdateCombos()
					'UPGRADE_ISSUE: (2070) Constant Monochrome was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2070
					UpdateSegmentValues(BT2Support.UpgradeStubs.stdole_LoadPictureConstants.getMonochrome())
				End If

			Case "Undo"
				jseG = 1
				Backup(1)
				UpdateCombos()
				'UPGRADE_ISSUE: (2070) Constant Monochrome was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2070
				UpdateSegmentValues(BT2Support.UpgradeStubs.stdole_LoadPictureConstants.getMonochrome())

			Case "Help"
				'UPGRADE_ISSUE: (2064) Form property frmSegments.HelpContextID was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2064
				ShowHelp(Me.getHelpContextID())

			Case "Cancel"
				Backup(1)
				Me.Close()

			Case "OK"
				'UPGRADE_ISSUE: (2070) Constant VgaColor was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2070
				UpdateSegmentValues(BT2Support.UpgradeStubs.stdole_LoadPictureConstants.getVgaColor())
				If CheckValues() Then
					Icalc = 0
					Me.Close()
				End If

		End Select

	End Sub
	Private Sub Combo2_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles Combo2.SelectedIndexChanged
		'select outflow segment
		'store outflow segment number in hidden text box behind combo box

		'If Combo2.ListIndex = jseG Then
		'    MsgBox "The outflow segment cannot equal the selected segment", vbExclamation
		'    Else
		'      txtSegment(2) = Combo2.ListIndex
		'    End If

	End Sub

	'UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-2080
	Private Sub Form_Load()
		jseG = 1
		UpdateCombos()
		SetToolTips()
		'UPGRADE_ISSUE: (2070) Constant Monochrome was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2070
		UpdateSegmentValues(BT2Support.UpgradeStubs.stdole_LoadPictureConstants.getMonochrome())
	End Sub

	Private Sub Combo1_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles Combo1.SelectedIndexChanged
		'load new segment
		Dim j As Double = Combo1.SelectedIndex + 1
		If j <> jseG Then
			'UPGRADE_ISSUE: (2070) Constant VgaColor was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2070
			UpdateSegmentValues(BT2Support.UpgradeStubs.stdole_LoadPictureConstants.getVgaColor())
			If CheckValues() Then jseG = j
			Combo1.SelectedIndex = jseG - 1
			'UPGRADE_ISSUE: (2070) Constant Monochrome was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2070
			UpdateSegmentValues(BT2Support.UpgradeStubs.stdole_LoadPictureConstants.getMonochrome())
		End If
		'    UpdateCombos

	End Sub

	Sub UpdateCombos()

		lblCount.Text = "Number of Segments = " & Nseg

		With Combo1
			.Items.Clear()
			For i As Double = 1 To Nseg
				.AddItem(StringsHelper.Format(i, "00") & " " & SegName(CInt(i)))
			Next i
			.SelectedIndex = jseG - 1
		End With

		With Combo2
			.Items.Clear()
			.AddItem("Out of Reservoir")
			For i As Double = 1 To Nseg
				.AddItem(StringsHelper.Format(i, "00") & " " & SegName(CInt(i)))
			Next i
			.SelectedIndex = Iout(jseG)
		End With

	End Sub

	'UPGRADE_ISSUE: (2068) stdole.LoadPictureConstants object was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2068
	Sub UpdateSegmentValues(ByVal io As BT2Support.UpgradeStubs.stdole_LoadPictureConstantsEnum)
		Dim k As Integer
		'io=1 copy source values to temporary array
		'io=2 copy from temporary array to original
		'io=3 copy from text boxes to temporary array
		'io=4 copy from temporary array to text boxes
		'io=5 clear temporary array to default values

		'UPGRADE_ISSUE: (2070) Constant Default was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2070

		Select Case io
			Case 1 'fill temporary array

				txtSegment(0).Text = CStr(jseG) 'segment number
				txtSegment(1).Text = SegName(jseG) 'segment label
				'txtSegment(2) = Iout(jseG)
				txtSegment(3).Text = CStr(Iag(jseG))
				txtSegment(4).Text = CStr(Area(jseG))
				txtSegment(5).Text = CStr(Zmn(jseG))
				txtSegment(6).Text = CStr(Slen(jseG))
				txtSegment(7).Text = CStr(Zmxi(jseG))
				txtSegment(8).Text = CStr(CvZmxi(jseG))
				txtSegment(9).Text = CStr(Zhyp(jseG))
				txtSegment(10).Text = CStr(CvZhyp(jseG))
				txtSegment(11).Text = CStr(Turbi(jseG))
				txtSegment(12).Text = CStr(CvTurbi(jseG))
				lblSegments(22).Text = StringsHelper.Format(ZmixEst(Zmn(jseG)), "0.0")

				k = 11
				For i As Integer = 2 To 9
					k += 2
					txtSegment(k).Text = CStr(Cobs(jseG, i)) 'tp
					txtSegment(k + 1).Text = CStr(CvCobs(jseG, i))
				Next i
				txtSegment(29).Text = CStr(Cobs(jseG, 1)) 'conserv
				txtSegment(30).Text = CStr(CvCobs(jseG, 1))

				AssignTurb()
				k = 29
				For i As Integer = 1 To 9
					k += 2
					txtSegment(k).Text = CStr(Cal(jseG, i))
					txtSegment(k + 1).Text = CStr(CvCal(jseG, i))
				Next i
				For i As Integer = 1 To 3
					k += 2
					txtSegment(k).Text = CStr(InternalLoad(jseG, i))
					txtSegment(k + 1).Text = CStr(CvInternalLoad(jseG, i))
				Next i
				Combo2.SelectedIndex = Iout(jseG)

				'Changed = False

			Case 2 'copy from temporary array back to original values


				Combo1.SetListItem(jseG - 1, StringsHelper.Format(jseG, "00") & " " & txtSegment(1).Text)
				Iout(jseG) = Combo2.SelectedIndex
				jseG = CInt(txtSegment(0).Text)
				SegName(jseG) = txtSegment(1).Text
				'Iout(jseG) = txtSegment(2)
				Iag(jseG) = CInt(txtSegment(3).Text)
				Area(jseG) = CSng(txtSegment(4).Text)
				Zmn(jseG) = CSng(txtSegment(5).Text)
				Slen(jseG) = CSng(txtSegment(6).Text)
				Zmxi(jseG) = CSng(txtSegment(7).Text)
				CvZmxi(jseG) = CSng(txtSegment(8).Text)
				Zhyp(jseG) = CSng(txtSegment(9).Text)
				CvZhyp(jseG) = CSng(txtSegment(10).Text)

				Turbi(jseG) = CSng(txtSegment(11).Text)
				CvTurbi(jseG) = CSng(txtSegment(12).Text)
				lblSegments(22).Text = StringsHelper.Format(ZmixEst(Zmn(jseG)), "0.0")

				k = 11
				For i As Integer = 2 To 9
					k += 2
					Cobs(jseG, i) = CSng(txtSegment(k).Text)
					CvCobs(jseG, i) = CSng(txtSegment(k + 1).Text)
				Next i
				Cobs(jseG, 1) = CSng(txtSegment(29).Text)
				CvCobs(jseG, 1) = CSng(txtSegment(30).Text)
				AssignTurb()
				k = 29
				For i As Integer = 1 To 9
					k += 2
					Cal(jseG, i) = CSng(txtSegment(k).Text)
					CvCal(jseG, i) = CSng(txtSegment(k + 1).Text)
				Next i
				For i As Integer = 1 To 3
					k += 2
					InternalLoad(jseG, i) = CSng(txtSegment(k).Text)
					CvInternalLoad(jseG, i) = CSng(txtSegment(k + 1).Text)
				Next i

			Case 3 'set defaults
				'    Changed = True
				'    For j = 2 To nboX
				'        txtSegment(j).Text = 0
				'        Next j
				'    txtSegment(2) = 0
				'    txtSegment(3) = 1     'calibration factors
				'    txtSegment(31) = 1
				'    txtSegment(33) = 1
				'    txtSegment(35) = 1
				'    txtSegment(37) = 1
				'    txtSegment(39) = 1
				'    txtSegment(41) = 1

			Case BT2Support.UpgradeStubs.stdole_LoadPictureConstants.getdefault()

		End Select

	End Sub

	Private Function CheckValues() As Boolean

		Dim result As Boolean = False
		If Iout(jseG) = jseG Then
			MessageBox.Show("The outflow segment cannot equal the selected segment", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
		ElseIf Area(jseG) <= 0 Or Slen(jseG) <= 0 Or Zmn(jseG) <= 0 Then 
			MessageBox.Show("Positive values required for area, length, & depth", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
		Else
			result = True
		End If

		Return result
	End Function

	Private Sub SetToolTips()
		For i As Integer = 3 To nboX
			txtSegment(i).TabIndex = i
		Next i

		'tab 0 morphometry
		ToolTipMain.SetToolTip(txtSegment(0), "Segment Number")
		ToolTipMain.SetToolTip(txtSegment(1), "Name of the Segment")
		ToolTipMain.SetToolTip(txtSegment(2), "Outflow Segment Number (0 = Reservoir Outflow)")
		ToolTipMain.SetToolTip(txtSegment(3), "Segment Group Number (=1 if all segments are in same reservoir)")
		ToolTipMain.SetToolTip(txtSegment(4), "Surface area (km2)")
		ToolTipMain.SetToolTip(txtSegment(5), "Mean depth (meters)")
		ToolTipMain.SetToolTip(txtSegment(6), "Segment length (km2)")
		ToolTipMain.SetToolTip(txtSegment(7), "Mean Depth of Mixed Layer (meters)")
		ToolTipMain.SetToolTip(txtSegment(8), "Coefficient of Variation for Mixed Layer")
		ToolTipMain.SetToolTip(txtSegment(9), "Mean Hypolimnetic Depth (meters)")
		ToolTipMain.SetToolTip(txtSegment(10), "Coefficient of Variation for Hypolimnetic Depth")
		'tab 1 observed water quality
		ToolTipMain.SetToolTip(txtSegment(11), "Non-Algal Turbidity = 1/secchi - .025x chla")
		ToolTipMain.SetToolTip(txtSegment(12), "Coefficient of Variation for Non-Agal Turbidity")
		ToolTipMain.SetToolTip(txtSegment(13), "Observed Mean Total Phosphorus (ppb)")
		ToolTipMain.SetToolTip(txtSegment(14), "Coefficient of Variation for Observed Mean Phosphorus")
		ToolTipMain.SetToolTip(txtSegment(15), "Observed Mean Total Nitrogen(ppb)")
		ToolTipMain.SetToolTip(txtSegment(16), "Coefficient of Variation for Observed Mean Nitrogen")
		ToolTipMain.SetToolTip(txtSegment(17), "Observed Mean Chlorophyll-A (ppb)")
		ToolTipMain.SetToolTip(txtSegment(18), "Coefficient of Variation for Observed Mean Chlorophyll-a")
		ToolTipMain.SetToolTip(txtSegment(19), "Observed Mean Secchi Depth (meters)")
		ToolTipMain.SetToolTip(txtSegment(20), "Coefficient of Variation for Observed Mean Secchi")
		ToolTipMain.SetToolTip(txtSegment(21), "Observed Mean Organic Nitrogen(ppb)")
		ToolTipMain.SetToolTip(txtSegment(22), "Coefficient of Variation for Observed Mean Organic Nitrogen")
		ToolTipMain.SetToolTip(txtSegment(23), "Observed Total P - Ortho P (ppb)")
		ToolTipMain.SetToolTip(txtSegment(24), "Coefficient of Variation for Observed Total P - Ortho P")
		ToolTipMain.SetToolTip(txtSegment(25), "Hypolimnetic Oxygen Depletion (mg/m3 - day)")
		ToolTipMain.SetToolTip(txtSegment(26), "Coefficient of Variation for Hypolimnetic Oxygen Depletion")
		ToolTipMain.SetToolTip(txtSegment(27), "Metalimnetic Oxygen Depletion (mg/m3 - day)")
		ToolTipMain.SetToolTip(txtSegment(28), "Coefficient of Variation for Metalimnetic Oxygen Depletion")
		ToolTipMain.SetToolTip(txtSegment(29), "Observed Mean Conservative Substance Conc (-)")
		ToolTipMain.SetToolTip(txtSegment(30), "Coefficient of Variation for Observed Mean Conservative Substance")

		'tab 3 calibration factors
		ToolTipMain.SetToolTip(txtSegment(31), "Dispersion Calibration Factor (-)")
		ToolTipMain.SetToolTip(txtSegment(32), "Coefficient of Variation for Dispersion Calibration Factor")
		ToolTipMain.SetToolTip(txtSegment(33), "Calibration Factor for Total Phosphorus (1.0)")
		ToolTipMain.SetToolTip(txtSegment(34), "Coefficient of Variation for Phosphorus Calibration Factor")
		ToolTipMain.SetToolTip(txtSegment(35), "Calibration Factor for Total Nitrogen (1.0)")
		ToolTipMain.SetToolTip(txtSegment(36), "Coefficient of Variation for Nitrogen Calibration Factor")
		ToolTipMain.SetToolTip(txtSegment(37), "Calibration Factor for Chlorophyll-A (1.0)")
		ToolTipMain.SetToolTip(txtSegment(38), "Coefficient of Variation for Chlorophyll-A Calibration Factor")
		ToolTipMain.SetToolTip(txtSegment(39), "Calibration Factor for Secchi Depth (1.0)")
		ToolTipMain.SetToolTip(txtSegment(40), "Coefficient of Variation for Secchi Depth Calibration Factor")
		ToolTipMain.SetToolTip(txtSegment(41), "Calibration Factor for Organic Nitrogen (1.0)")
		ToolTipMain.SetToolTip(txtSegment(42), "Coefficient of Variation for Organic Nitrogen Calibration Factor")
		ToolTipMain.SetToolTip(txtSegment(43), "Calibration Factor for Total P - Ortho P (1.0)")
		ToolTipMain.SetToolTip(txtSegment(44), "Coefficient of Variation for Total P - Ortho P Calibration Factor")
		ToolTipMain.SetToolTip(txtSegment(45), "Calibration Factor for Hypolimnetic Oxygen Depletion (1.0)")
		ToolTipMain.SetToolTip(txtSegment(46), "Coefficient of Variation for Oxygen Depletion Calibration Factor")
		ToolTipMain.SetToolTip(txtSegment(47), "Calibration Factor for Metalimnetic Oxygen Depletion (1.0)")
		ToolTipMain.SetToolTip(txtSegment(48), "Coefficient of Variation for Oxygen Depletion Calibration Factor")

		'tab4 - internal loads
		ToolTipMain.SetToolTip(txtSegment(49), "Internal Load of Conservative Substance (mg/m2-day)")
		ToolTipMain.SetToolTip(txtSegment(50), "Coefficient of Variation for Internal Load of Conservative Substance")
		ToolTipMain.SetToolTip(txtSegment(51), "Internal Load for Total Phosphorus (mg/m2-day)")
		ToolTipMain.SetToolTip(txtSegment(52), "Coefficient of Variation for Internal Load of Total Phosphorus")
		ToolTipMain.SetToolTip(txtSegment(53), "Internal Load for Total Nitrogen (mg/m2-day)")
		ToolTipMain.SetToolTip(txtSegment(54), "Coefficient of Variation for Internal Load of Total Nitrogen")


	End Sub

	Private Sub Form_MouseMove(ByVal eventSender As Object, ByVal eventArgs As MouseEventArgs) Handles MyBase.MouseMove
		Dim Button As Integer = IIf(eventArgs.Button = MouseButtons.Left, 1, IIf(eventArgs.Button = MouseButtons.Right, 2, 4))
		Dim Shift As Integer = Control.ModifierKeys / 65536
		Dim x As Single = eventArgs.X * 15
		Dim y As Single = eventArgs.Y * 15
		lblDefinitions.Text = ""
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
	'UPGRADE_NOTE: (7001) The following declaration (SSTab3_MouseMove) seems to be dead code More Information: https://docs.mobilize.net/vbuc/ewis/notes#id-7001
	'Private Sub SSTab3_MouseMove(ByVal Button As Integer, ByVal Shift As Integer, ByVal x As Single, ByVal y As Single)
		'lblDefinitions.Text = ""
	'End Sub
	'UPGRADE_NOTE: (7001) The following declaration (SSTab4_MouseMove) seems to be dead code More Information: https://docs.mobilize.net/vbuc/ewis/notes#id-7001
	'Private Sub SSTab4_MouseMove(ByVal Button As Integer, ByVal Shift As Integer, ByVal x As Single, ByVal y As Single)
		'lblDefinitions.Text = ""
	'End Sub

	Private isInitializingComponent As Boolean
	Private Sub txtSegment_TextChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtSegment_15.TextChanged, _txtSegment_27.TextChanged, _txtSegment_25.TextChanged, _txtSegment_23.TextChanged, _txtSegment_21.TextChanged, _txtSegment_19.TextChanged, _txtSegment_17.TextChanged, _txtSegment_29.TextChanged, _txtSegment_12.TextChanged, _txtSegment_11.TextChanged, _txtSegment_13.TextChanged, _txtSegment_47.TextChanged, _txtSegment_48.TextChanged, _txtSegment_45.TextChanged, _txtSegment_46.TextChanged, _txtSegment_43.TextChanged, _txtSegment_44.TextChanged, _txtSegment_49.TextChanged, _txtSegment_50.TextChanged, _txtSegment_51.TextChanged, _txtSegment_52.TextChanged, _txtSegment_53.TextChanged, _txtSegment_54.TextChanged, _txtSegment_42.TextChanged, _txtSegment_41.TextChanged, _txtSegment_40.TextChanged, _txtSegment_39.TextChanged, _txtSegment_38.TextChanged, _txtSegment_37.TextChanged, _txtSegment_36.TextChanged, _txtSegment_35.TextChanged, _txtSegment_34.TextChanged, _txtSegment_31.TextChanged, _txtSegment_32.TextChanged, _txtSegment_33.TextChanged, _txtSegment_14.TextChanged, _txtSegment_16.TextChanged, _txtSegment_18.TextChanged, _txtSegment_20.TextChanged, _txtSegment_22.TextChanged, _txtSegment_24.TextChanged, _txtSegment_26.TextChanged, _txtSegment_28.TextChanged, _txtSegment_30.TextChanged, _txtSegment_1.TextChanged, _txtSegment_3.TextChanged, _txtSegment_4.TextChanged, _txtSegment_5.TextChanged, _txtSegment_6.TextChanged, _txtSegment_7.TextChanged, _txtSegment_8.TextChanged, _txtSegment_9.TextChanged, _txtSegment_10.TextChanged, _txtSegment_2.TextChanged, _txtSegment_0.TextChanged
		Dim index As Integer = Array.IndexOf(Me.txtSegment, eventSender)
		If isInitializingComponent Then
			Exit Sub
		End If
		lblDefinitions.Text = ToolTipMain.GetToolTip(txtSegment(index))
		If index <> 1 Then
			If Not VerifyPositive(txtSegment(index).Text) Then txtSegment(index).Text = ""
		End If
	End Sub

	Private Sub txtSegment_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _txtSegment_15.Leave, _txtSegment_27.Leave, _txtSegment_25.Leave, _txtSegment_23.Leave, _txtSegment_21.Leave, _txtSegment_19.Leave, _txtSegment_17.Leave, _txtSegment_29.Leave, _txtSegment_12.Leave, _txtSegment_11.Leave, _txtSegment_13.Leave, _txtSegment_47.Leave, _txtSegment_48.Leave, _txtSegment_45.Leave, _txtSegment_46.Leave, _txtSegment_43.Leave, _txtSegment_44.Leave, _txtSegment_49.Leave, _txtSegment_50.Leave, _txtSegment_51.Leave, _txtSegment_52.Leave, _txtSegment_53.Leave, _txtSegment_54.Leave, _txtSegment_42.Leave, _txtSegment_41.Leave, _txtSegment_40.Leave, _txtSegment_39.Leave, _txtSegment_38.Leave, _txtSegment_37.Leave, _txtSegment_36.Leave, _txtSegment_35.Leave, _txtSegment_34.Leave, _txtSegment_31.Leave, _txtSegment_32.Leave, _txtSegment_33.Leave, _txtSegment_14.Leave, _txtSegment_16.Leave, _txtSegment_18.Leave, _txtSegment_20.Leave, _txtSegment_22.Leave, _txtSegment_24.Leave, _txtSegment_26.Leave, _txtSegment_28.Leave, _txtSegment_30.Leave, _txtSegment_1.Leave, _txtSegment_3.Leave, _txtSegment_4.Leave, _txtSegment_5.Leave, _txtSegment_6.Leave, _txtSegment_7.Leave, _txtSegment_8.Leave, _txtSegment_9.Leave, _txtSegment_10.Leave, _txtSegment_2.Leave, _txtSegment_0.Leave
		Dim index As Integer = Array.IndexOf(Me.txtSegment, eventSender)
		If index <> 1 Then
			If txtSegment(index).Text = "" Then txtSegment(index).Text = CStr(0)
		End If
		If index = 5 Then lblSegments(22).Text = StringsHelper.Format(ZmixEst(Conversion.Val(txtSegment(index).Text)), "0.0")
		If index > 16 And index < 21 Then AssignTurb()

	End Sub

	Private Sub txtSegment_MouseMove(ByVal eventSender As Object, ByVal eventArgs As MouseEventArgs) Handles _txtSegment_15.MouseMove, _txtSegment_27.MouseMove, _txtSegment_25.MouseMove, _txtSegment_23.MouseMove, _txtSegment_21.MouseMove, _txtSegment_19.MouseMove, _txtSegment_17.MouseMove, _txtSegment_29.MouseMove, _txtSegment_12.MouseMove, _txtSegment_11.MouseMove, _txtSegment_13.MouseMove, _txtSegment_47.MouseMove, _txtSegment_48.MouseMove, _txtSegment_45.MouseMove, _txtSegment_46.MouseMove, _txtSegment_43.MouseMove, _txtSegment_44.MouseMove, _txtSegment_49.MouseMove, _txtSegment_50.MouseMove, _txtSegment_51.MouseMove, _txtSegment_52.MouseMove, _txtSegment_53.MouseMove, _txtSegment_54.MouseMove, _txtSegment_42.MouseMove, _txtSegment_41.MouseMove, _txtSegment_40.MouseMove, _txtSegment_39.MouseMove, _txtSegment_38.MouseMove, _txtSegment_37.MouseMove, _txtSegment_36.MouseMove, _txtSegment_35.MouseMove, _txtSegment_34.MouseMove, _txtSegment_31.MouseMove, _txtSegment_32.MouseMove, _txtSegment_33.MouseMove, _txtSegment_14.MouseMove, _txtSegment_16.MouseMove, _txtSegment_18.MouseMove, _txtSegment_20.MouseMove, _txtSegment_22.MouseMove, _txtSegment_24.MouseMove, _txtSegment_26.MouseMove, _txtSegment_28.MouseMove, _txtSegment_30.MouseMove, _txtSegment_1.MouseMove, _txtSegment_3.MouseMove, _txtSegment_4.MouseMove, _txtSegment_5.MouseMove, _txtSegment_6.MouseMove, _txtSegment_7.MouseMove, _txtSegment_8.MouseMove, _txtSegment_9.MouseMove, _txtSegment_10.MouseMove, _txtSegment_2.MouseMove, _txtSegment_0.MouseMove
		Dim index As Integer = Array.IndexOf(Me.txtSegment, eventSender)
		Dim Button As Integer = IIf(eventArgs.Button = MouseButtons.Left, 1, IIf(eventArgs.Button = MouseButtons.Right, 2, 4))
		Dim Shift As Integer = Control.ModifierKeys / 65536
		Dim x As Single = eventArgs.X * 15
		Dim y As Single = eventArgs.Y * 15
		lblDefinitions.Text = ToolTipMain.GetToolTip(txtSegment(index))
		'WhatsThisHelp = txtSegment(Index).HelpContextID

	End Sub

	Sub AssignTurb()
		'estimate non-algal turbidity
		x(1) = Conversion.Val(txtSegment(17).Text) 'chla mean & cv
		x(2) = Conversion.Val(txtSegment(18).Text)
		x(3) = Conversion.Val(txtSegment(19).Text) 'secchi mean & cv
		x(4) = Conversion.Val(txtSegment(20).Text)
		TurbEst(x(1), x(2), x(3), x(4), x(5), x(6))
		lblSegments(35).Text = StringsHelper.Format(x(5), "0.00")
		lblSegments(36).Text = StringsHelper.Format(x(6), "0.00")
	End Sub
	Private Sub Form_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
	End Sub
End Class