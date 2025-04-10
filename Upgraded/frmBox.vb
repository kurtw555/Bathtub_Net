Option Strict Off
Option Explicit On
Imports BT2Support.UpgradeStubs
Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Partial Friend Class frmBox
	Inherits System.Windows.Forms.Form
	Public Sub New()
		MyBase.New()
		If m_vb6FormDefInstance Is Nothing Then
			If m_InitializingDefInstance Then
				m_vb6FormDefInstance = Me
			Else
				Try
					'For the start-up form, the first instance created is the default instance.
					If Not (System.Reflection.Assembly.GetExecutingAssembly().EntryPoint Is Nothing) AndAlso System.Reflection.Assembly.GetExecutingAssembly().EntryPoint.DeclaringType Is Me.GetType() Then
						m_vb6FormDefInstance = Me
					End If

				Catch
				End Try
			End If
		End If
		'This call is required by the Windows Form Designer.
		isInitializingComponent = True
		InitializeComponent()
		isInitializingComponent = False
		ReLoadForm(False)
	End Sub


	Private Sub frmBox_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		If Not (UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm Is eventSender) Then
			UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm = eventSender
		End If
	End Sub
	Private Sub Toolbar1_ButtonClick(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles Toolbar1_Buttons_Button1.Click, Toolbar1_Buttons_Button2.Click, Toolbar1_Buttons_Button3.Click, Toolbar1_Buttons_Button4.Click
		Dim Button As ToolStripItem = CType(eventSender, ToolStripItem)

		Dim outfilE As String = ""


		Select Case Button.Text
			Case "Save"

				'UPGRADE_ISSUE: (6012) CommonDialog variable was not upgraded More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-6012
				With CommonDialog1
					'UPGRADE_ISSUE: (2064) MSComDlg.CommonDialog property CommonDialog1.FileName was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2064
					.setFileName("*.txt")
					'UPGRADE_ISSUE: (2064) MSComDlg.CommonDialog property CommonDialog1.Filter was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2064
					'UPGRADE_WARNING: (2081) Filter has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-2081
					.setFilter("Text File(*.txt)|*.txt|")
					'UPGRADE_ISSUE: (2064) MSComDlg.CommonDialog property CommonDialog1.FilterIndex was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2064
					.setFilterIndex(1)
					CommonDialog1Save.ShowDialog()
					'UPGRADE_ISSUE: (2064) MSComDlg.CommonDialog property CommonDialog1.FileName was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2064
					outfilE = .getFileName()
				End With

				If outfilE = "" Or outfilE.IndexOf("*"c) >= 0 Then Exit Sub

				'If Not ValidFile(outfilE) Then Exit Sub
				If FileExists(outfilE) Then
					If MessageBox.Show("File: " & outfilE & " already exists, overwrite?", My.Application.Info.Title, MessageBoxButtons.YesNo) <> System.Windows.Forms.DialogResult.Yes Then Exit Sub
				End If

				FileSystem.FileOpen(1, outfilE, OpenMode.Output)
				FileSystem.WriteLine(1, txtBox.Text)
				FileSystem.FileClose(1)
				MessageBox.Show("File: " & outfilE & " saved", My.Application.Info.Title)

				'Case "Print"

				'    PrintForm

			Case "Help"
				ShowHelp((ContextId))

			Case "Copy Table"
				Clipboard.Clear()
				'UPGRADE_WARNING: (2081) Clipboard.SetText has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-2081
				Clipboard.SetText(txtBox.Text)

			Case "Close"
				Me.Close()

		End Select

	End Sub

	Private isInitializingComponent As Boolean
	Private Sub txtBox_TextChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles txtBox.TextChanged
		If isInitializingComponent Then
			Exit Sub
		End If
		Dim h, w As Double

		'frmBox.Visible = False
		'frmBox.WindowState = 2

		Dim txt As String = txtBox.Text
		TextDim(txt, w, h)
		Dim F As Decimal = txtBox.Font.SizeInPoints
		Dim Fw As Decimal = F * 14
		Dim Fh As Decimal = F * 32
		Dim dw As Integer = 500
		Dim dh As Integer = 1200

		txtBox.Width = MAx(dw * 7, Fw * w) / 15
		txtBox.Height = MAx(dh * 2, Fh * MIn(h, 50)) / 15
		Me.Width = txtBox.Width + dw / 15
		Me.Height = txtBox.Height + dh / 15
		'UPGRADE_ISSUE: (2064) Form property frmBox.HelpContextID was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2064
		Me.setHelpContextID(ContextId)
		'frmBox.Visible = True
		'frmBox.WindowState = 0
	End Sub


	Sub TextDim(ByVal txt As String, ByRef w As Double, ByRef h As Double)
		Dim j As Integer
		'count lines & maximum width of text string

		Dim n1 As Double = Strings.Len(txt)
		n1 = MIn(n1, 2000)
		h = 0
		Dim i As Integer = 1
		w = 0
		Dim w1 As Double = 0
		Do Until i >= n1
			j = Strings.InStr(i, txt, Environment.NewLine)
			w1 = j - i + 1
			w = MAx(w, w1)
			h += 1
			i = j + 1
		Loop 
		'MsgBox "width = " & w & "  height = " & h
	End Sub
	Private Sub Form_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
	End Sub
End Class