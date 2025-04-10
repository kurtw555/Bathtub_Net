Option Strict Off
Option Explicit On
Imports BT2Support.UpgradeStubs
Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports UpgradeHelpers.Gui.Controls
Imports UpgradeHelpers.Helpers
Partial Friend Class frmChannels
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


	Private Sub frmChannels_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		If Not (UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm Is eventSender) Then
			UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm = eventSender
		End If
	End Sub
	Const nboX As Integer = 4
	Dim jpipE As Integer

	Private Sub Toolbar1_ButtonClick(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles Toolbar1_Buttons_Button1.Click, Toolbar1_Buttons_Button2.Click, Toolbar1_Buttons_Button3.Click, Toolbar1_Buttons_Button4.Click, Toolbar1_Buttons_Button5.Click, Toolbar1_Buttons_Button6.Click, Toolbar1_Buttons_Button7.Click, Toolbar1_Buttons_Button8.Click
		Dim Button As ToolStripItem = CType(eventSender, ToolStripItem)
		Dim k As Integer


		Select Case Button.Text
			Case "List"
				List_Tree()

			Case "Add"
				If Npipe = NPMAX Then
					MessageBox.Show("Too many channels!", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
				Else
					If Npipe > 0 Then
						'UPGRADE_ISSUE: (2070) Constant VgaColor was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2070
						UpdateChannelValues(BT2Support.UpgradeStubs.stdole_LoadPictureConstants.getVgaColor())
					End If 'save current channel
					If CheckValues() Then
						Npipe += 1
						jpipE = Npipe
						PipeZero(jpipE)
						PipeName(jpipE) = "New Channel"
						UpdateCombos()
						'UPGRADE_ISSUE: (2070) Constant Monochrome was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2070
						UpdateChannelValues(BT2Support.UpgradeStubs.stdole_LoadPictureConstants.getMonochrome())
					End If
				End If

			Case "Delete"

				'delete a pipe
				If Npipe = 0 Or jpipE = Npipe + 1 Then Exit Sub
				If MessageBox.Show("Delete This Channel?", My.Application.Info.Title, MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
					k = 0
					For i As Double = 1 To Npipe
						If i <> jpipE Then
							k += 1
							PipeCopy(i, k)
						End If
					Next i
					PipeZero(Npipe)
					Npipe -= 1
					jpipE = 1
					UpdateCombos()
					'UPGRADE_ISSUE: (2070) Constant Monochrome was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2070
					UpdateChannelValues(BT2Support.UpgradeStubs.stdole_LoadPictureConstants.getMonochrome())
				End If

			Case "Clear"
				If MessageBox.Show("Clear Values for Current Channel?", My.Application.Info.Title, MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
					'UPGRADE_ISSUE: (2068) stdole.LoadPictureConstants object was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2068
					UpdateChannelValues(3)
					'UPGRADE_ISSUE: (2070) Constant VgaColor was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2070
					UpdateChannelValues(BT2Support.UpgradeStubs.stdole_LoadPictureConstants.getVgaColor())
					UpdateCombos()
				End If

			Case "Undo"
				Backup(1)
				jpipE = 1
				UpdateCombos()
				'UPGRADE_ISSUE: (2070) Constant Monochrome was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2070
				UpdateChannelValues(BT2Support.UpgradeStubs.stdole_LoadPictureConstants.getMonochrome())

			Case "Help"
				'UPGRADE_ISSUE: (2064) Form property frmChannels.HelpContextID was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2064
				ShowHelp(Me.getHelpContextID())

			Case "Cancel"
				Backup(1)
				Me.Close()

			Case "OK"
				'UPGRADE_ISSUE: (2070) Constant VgaColor was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2070
				UpdateChannelValues(BT2Support.UpgradeStubs.stdole_LoadPictureConstants.getVgaColor())
				If CheckValues() Then
					Icalc = 0
					Me.Close()
				End If

		End Select

	End Sub

	'UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-2080
	Private Sub Form_Load()
		jpipE = 1
		UpdateCombos()
		SetToolTips()
		Backup(0) 'save backup file
		'UPGRADE_ISSUE: (2070) Constant Monochrome was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2070
		UpdateChannelValues(BT2Support.UpgradeStubs.stdole_LoadPictureConstants.getMonochrome())
	End Sub
	Private Sub Combo1_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles Combo1.SelectedIndexChanged
		'load new channel
		Dim j As Double = Combo1.SelectedIndex + 1
		'UpdateChannelValues (2)
		If j <> jpipE And jpipE <= Npipe Then
			'UPGRADE_ISSUE: (2070) Constant VgaColor was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2070
			UpdateChannelValues(BT2Support.UpgradeStubs.stdole_LoadPictureConstants.getVgaColor())
			If Not CheckValues() Then
				Combo1.SelectedIndex = jpipE - 1
				Exit Sub
			End If
		End If

		jpipE = j
		Combo1.SelectedIndex = jpipE - 1
		'UPGRADE_ISSUE: (2070) Constant Monochrome was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2070
		UpdateChannelValues(BT2Support.UpgradeStubs.stdole_LoadPictureConstants.getMonochrome())
	End Sub

	Private Sub UpdateCombos()

		With Combo1
			.Items.Clear()
			For i As Double = 1 To Npipe
				.AddItem(StringsHelper.Format(i, "00") & " " & PipeName(CInt(i)))
				'End If
			Next i
			.AddItem(" ")
			.SelectedIndex = jpipE - 1
		End With

		Label2.Text = "Total Channels = " & Npipe

		With Combo2
			.Items.Clear()
			.AddItem("None")
			For i As Double = 1 To Nseg
				.AddItem(StringsHelper.Format(i, "00") & " " & SegName(CInt(i)))
			Next i
			.SelectedIndex = Ito(jpipE)
		End With

		With Combo3
			.Items.Clear()
			.AddItem("None")
			For i As Double = 1 To Nseg
				.AddItem(StringsHelper.Format(i, "00") & " " & SegName(CInt(i)))
			Next i
			.SelectedIndex = Ifr(jpipE)
		End With

		If Npipe > 0 And PipeName(jpipE) <> "New Channel" And Ifr(jpipE) = Ito(jpipE) Then MessageBox.Show("The inflow segment cannot equal the outflow segment", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)


	End Sub

	Private Sub Combo3_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles Combo3.SelectedIndexChanged
		'change to segment
		Text1(5).Text = CStr(Combo3.SelectedIndex)
	End Sub
	Private Sub Combo2_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles Combo2.SelectedIndexChanged
		'change from segment
		Text1(6).Text = CStr(Combo2.SelectedIndex)
	End Sub

	'UPGRADE_ISSUE: (2068) stdole.LoadPictureConstants object was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2068
	Private Sub UpdateChannelValues(ByVal io As BT2Support.UpgradeStubs.stdole_LoadPictureConstantsEnum)
		'io=1 copy source values to temporary array
		'io=2 copy from temporary array to original
		'io=3 copy defaults

		'UPGRADE_ISSUE: (2070) Constant Default was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2070

		Select Case io
			Case 1 'fill temporary array

				Text1(0).Text = PipeName(jpipE) 'channel label
				Text1(1).Text = CStr(Qpipe(jpipE))
				Text1(2).Text = CStr(CvQpipe(jpipE))
				Text1(3).Text = CStr(Epipe(jpipE))
				Text1(4).Text = CStr(CvEpipe(jpipE))
				Text1(5).Text = CStr(Ifr(jpipE))
				Text1(6).Text = CStr(Ito(jpipE))
				'UPGRADE_TODO: (1069) Error handling statement (On Error Resume Next) was converted to a pattern that might have a different behavior. More Information: https://docs.mobilize.net/vbuc/ewis/todos#id-1069
				Try
					Combo2.SelectedIndex = Ito(jpipE)
					Combo3.SelectedIndex = Ifr(jpipE)

				Catch exc As Exception
					NotUpgradedHelper.NotifyNotUpgradedElement("Resume in On-Error-Resume-Next Block")
				End Try

			Case 2 'copy from temporary array back to original values
				If jpipE <= Npipe Then
					PipeName(jpipE) = Text1(0).Text 'channel label
					Qpipe(jpipE) = CSng(Text1(1).Text)
					CvQpipe(jpipE) = CSng(Text1(2).Text)
					Epipe(jpipE) = CSng(Text1(3).Text)
					CvEpipe(jpipE) = CSng(Text1(4).Text)
					Ifr(jpipE) = CInt(Text1(5).Text)
					Ito(jpipE) = CInt(Text1(6).Text)
					Try
						Combo1.SetListItem(jpipE - 1, StringsHelper.Format(jpipE, "00") & " " & Text1(0).Text)

					Catch
					End Try
				End If

			Case 3 'set defaults

				For j As Integer = 1 To 4
					Text1(j).Text = CStr(0)
				Next j

			Case BT2Support.UpgradeStubs.stdole_LoadPictureConstants.getdefault()

		End Select

	End Sub

	Function CheckValues() As Boolean

		If Npipe > 0 And (Ifr(jpipE) = 0 Or Ito(jpipE) = 0 Or Ito(jpipE) = Ifr(jpipE)) Then
			MessageBox.Show("Invalid source or downstream segment", My.Application.Info.Title)
			Return False
		Else
			Return True
		End If

	End Function

	Private Sub Form_MouseMove(ByVal eventSender As Object, ByVal eventArgs As MouseEventArgs) Handles MyBase.MouseMove
		Dim Button As Integer = IIf(eventArgs.Button = MouseButtons.Left, 1, IIf(eventArgs.Button = MouseButtons.Right, 2, 4))
		Dim Shift As Integer = Control.ModifierKeys / 65536
		Dim x As Single = eventArgs.X * 15
		Dim y As Single = eventArgs.Y * 15
		lblDefinitions.Text = ""
	End Sub

	Private Sub SetToolTips()
		ToolTipMain.SetToolTip(Text1(0), "Channel Name")
		ToolTipMain.SetToolTip(Text1(1), "Advective Flow (hm3/yr)")
		ToolTipMain.SetToolTip(Text1(2), "CV of Advective Flow")
		ToolTipMain.SetToolTip(Text1(3), "Exchange Flow (hm3/yr)")
		ToolTipMain.SetToolTip(Text1(4), "CV of Exchange Flow")
		ToolTipMain.SetToolTip(Text1(5), "Source Segment")
		ToolTipMain.SetToolTip(Text1(6), "Downstream Segment")
	End Sub

	Private isInitializingComponent As Boolean
	Private Sub text1_TextChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Text1_0.TextChanged, _Text1_1.TextChanged, _Text1_2.TextChanged, _Text1_3.TextChanged, _Text1_4.TextChanged, _Text1_6.TextChanged, _Text1_5.TextChanged
		Dim index As Integer = Array.IndexOf(Me.Text1, eventSender)
		If isInitializingComponent Then
			Exit Sub
		End If
		If index <> 0 Then
			If Not VerifyPositive(Text1(index).Text) Then Text1(index).Text = ""
		End If

	End Sub
	Private Sub text1_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Text1_0.Leave, _Text1_1.Leave, _Text1_2.Leave, _Text1_3.Leave, _Text1_4.Leave, _Text1_6.Leave, _Text1_5.Leave
		Dim index As Integer = Array.IndexOf(Me.Text1, eventSender)
		If index <> 0 Then
			If Text1(index).Text = "" Then Text1(index).Text = CStr(0)
		End If

	End Sub
	Private Sub text1_MouseMove(ByVal eventSender As Object, ByVal eventArgs As MouseEventArgs) Handles _Text1_0.MouseMove, _Text1_1.MouseMove, _Text1_2.MouseMove, _Text1_3.MouseMove, _Text1_4.MouseMove, _Text1_6.MouseMove, _Text1_5.MouseMove
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