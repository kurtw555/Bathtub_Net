Option Strict Off
Option Explicit On
Imports BT2Support.UpgradeStubs
Imports System
Imports System.Windows.Forms
Imports UpgradeHelpers.Gui.Controls
Imports UpgradeHelpers.Helpers
Partial Friend Class frmCalibration
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


	Private Sub frmCalibration_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		If Not (UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm Is eventSender) Then
			UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm = eventSender
		End If
	End Sub
	'UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-2080
	Private Sub Form_Load()
		Dim k As Integer

		Dim i As Double = MAx(0, MIn(2, Iop(7) - 1))
		OptOption(CInt(i)).Checked = True

		lblDefinitions.Text = "Ready"
		txtCalib.Text = ""
		For j As Integer = 1 To 4
			chkVariable(j - 1).CheckState = CheckState.Unchecked
			chkVariable(j - 1).Enabled = False
			k = 0
			For i = 1 To Nseg
				If Cobs(CInt(i), j) > 0 Then k += 1
			Next i
			If k > 0 And Iop(j) > 0 Then chkVariable(j - 1).Enabled = True
		Next j
		If chkVariable(1).Enabled Then chkVariable(1).CheckState = CheckState.Checked

		With List1
			.Items.Clear()
			For i = 1 To Nseg
				.AddItem(StringsHelper.Format(i, "00") & " " & SegName(CInt(i)))
			Next i
			ListBoxHelper.SetSelectedIndex(List1, 1)
		End With

		optMethod(0).Checked = True

		'segment list
		List1.Enabled = Not optMethod(0).Checked

	End Sub

	Function optM() As Integer
		Dim result As Integer = 0
		For i As Integer = 0 To 2
			If optMethod(i).Checked Then result = i
		Next i
		Return result
	End Function

	Private isInitializingComponent As Boolean
	Private Sub optMethod_CheckedChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _optMethod_2.CheckedChanged, _optMethod_1.CheckedChanged, _optMethod_0.CheckedChanged
		Dim index As Integer = Array.IndexOf(Me.optMethod, eventSender)
		If eventSender.Checked Then
			If isInitializingComponent Then
				Exit Sub
			End If

			List1.Enabled = index <> 0

		End If
	End Sub

	Private Sub OptOption_CheckedChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _OptOption_1.CheckedChanged, _OptOption_0.CheckedChanged
		Dim index As Integer = Array.IndexOf(Me.OptOption, eventSender)
		If eventSender.Checked Then
			If isInitializingComponent Then
				Exit Sub
			End If
			Iop(7) = index + 1
			Iop(8) = index + 1
		End If
	End Sub

	Private Sub Toolbar1_ButtonClick(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles Toolbar1_Buttons_Button1.Click, Toolbar1_Buttons_Button2.Click, Toolbar1_Buttons_Button3.Click, Toolbar1_Buttons_Button4.Click, Toolbar1_Buttons_Button5.Click, Toolbar1_Buttons_Button6.Click
		Dim Button As ToolStripItem = CType(eventSender, ToolStripItem)


		Select Case Button.Text
			Case "Run"

				Select Case optM()
					Case 0 'global
						GlobalCalib(2)
					Case 1 'regional
						LocalCalib(1)
					Case 2 'local
						LocalCalib(0)
				End Select
				FitUpdate()

			Case "Reset All"
				txtCalib.Text = ""
				For j As Integer = 1 To 4
					Xk(j) = 1
					For i As Double = 1 To Nseg
						Cal(CInt(i), j) = 1
					Next i
				Next j
				Model()
				FitUpdate()

			Case "Reset"
				txtCalib.Text = ""
				For j As Integer = 1 To 4
					If chkVariable(j - 1).CheckState <> CheckState.Unchecked Then
						If optM() = 0 Then
							Xk(j) = 1
						Else
							For i As Double = 1 To Nseg
								If ListBoxHelper.GetSelected(List1, i - 1) Then Cal(CInt(i), j) = 1
							Next i
						End If
					End If
				Next j
				Model()
				FitUpdate()

			Case "List"
				Model()
				'UPGRADE_ISSUE: (2064) Form property frmCalibration.HelpContextID was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2064
				ContextId = Me.getHelpContextID()
				FitUpdate()

			Case "Help"
				'UPGRADE_ISSUE: (2064) Form property frmCalibration.HelpContextID was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2064
				ShowHelp(Me.getHelpContextID())

			Case "Quit"
				Icalc = 0
				FormUpdate()
				Me.Close()
		End Select

	End Sub
	Sub FitUpdate()
		If Icalc = 0 Then Exit Sub
		lblDefinitions.Text = "Listing Results..."
		List_Fits()
		ViewSheet("calibrations")
		lblDefinitions.Text = "Ready"
	End Sub
	Private Sub Form_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
	End Sub
End Class