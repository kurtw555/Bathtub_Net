Option Strict Off
Option Explicit On
Imports BT2Support.UpgradeStubs
Imports System
Imports System.Windows.Forms
Imports UpgradeHelpers.Gui.Controls
Imports UpgradeHelpers.Helpers
Partial Friend Class frmModels
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
	End Sub


	Private Sub frmModels_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		If Not (UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm Is eventSender) Then
			UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm = eventSender
		End If
	End Sub
	Private Changed As Boolean

	Private Sub Combo1_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _Combo1_11.SelectedIndexChanged, _Combo1_10.SelectedIndexChanged, _Combo1_9.SelectedIndexChanged, _Combo1_8.SelectedIndexChanged, _Combo1_7.SelectedIndexChanged, _Combo1_6.SelectedIndexChanged, _Combo1_5.SelectedIndexChanged, _Combo1_4.SelectedIndexChanged, _Combo1_3.SelectedIndexChanged, _Combo1_2.SelectedIndexChanged, _Combo1_1.SelectedIndexChanged, _Combo1_0.SelectedIndexChanged
		Dim index As Integer = Array.IndexOf(Me.Combo1, eventSender)
		Dim j As Integer = Iwork(index + 1)
		Iwork(index + 1) = Combo1(index).SelectedIndex
		If j <> Combo1(index).SelectedIndex Then Changed = True
	End Sub

	'UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-2080
	Private Sub Form_Load()
		Dim fn As String = ""

		For i As Double = 1 To NOptions
			Iwork(CInt(i)) = Iop(CInt(i))
			For j As Integer = 1 To Mop(CInt(i))
				fn = StringsHelper.Format(j - 1, "00") & " " & OptionName(CInt(i), j)
				If j - 1 = IopDefault(CInt(i)) Then fn = fn & " *"
				Combo1(CInt(i - 1)).AddItem(fn)

			Next j
			Combo1(CInt(i - 1)).SelectedIndex = Iwork(CInt(i))
			'UPGRADE_ISSUE: (2064) Form property frmModels.HelpContextID was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2064
			'UPGRADE_ISSUE: (2064) ComboBox property Combo1.HelpContextID was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2064
			Combo1(CInt(i - 1)).setHelpContextID(Me.getHelpContextID())
		Next i
		'    Changed = False
	End Sub

	Private Sub Toolbar1_ButtonClick(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles Toolbar1_Buttons_Button1.Click, Toolbar1_Buttons_Button2.Click, Toolbar1_Buttons_Button3.Click, Toolbar1_Buttons_Button4.Click, Toolbar1_Buttons_Button5.Click
		Dim Button As ToolStripItem = CType(eventSender, ToolStripItem)


		Select Case Button.Text
			Case "Defaults"
				If MessageBox.Show("Assign Default Values for All Options?", My.Application.Info.Title, MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
					For i As Double = 1 To NOptions
						Iwork(CInt(i)) = IopDefault(CInt(i))
						Combo1(CInt(i - 1)).SelectedIndex = Iwork(CInt(i))
					Next i
					'    Changed = True
				End If

			Case "Undo"
				'   If MsgBox("Assign Previously Saved Values?", vbYesNo) = vbYes Then
				For i As Double = 1 To NOptions
					Iwork(CInt(i)) = Iop(CInt(i))
					Combo1(CInt(i - 1)).SelectedIndex = Iwork(CInt(i))
				Next i
				'      Changed = False
				'    End If

			Case "Help"
				'UPGRADE_ISSUE: (2064) Form property frmModels.HelpContextID was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2064
				ShowHelp(Me.getHelpContextID())

			Case "Cancel"
				Me.Close()

			Case "OK"

				'If Changed = True Then
				's = MsgBox("Save Edits?", vbYesNoCancel)
				'    If s = vbCancel Then Exit Sub
				'    If s = vbYes Then
				For i As Double = 1 To NOptions
					Iop(CInt(i)) = Iwork(CInt(i))
				Next i
				'        End If
				'     End If
				Icalc = 0
				FormUpdate()
				Me.Close()

		End Select

	End Sub
	Private Sub Form_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
	End Sub
End Class