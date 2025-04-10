Option Strict Off
Option Explicit On
Imports System
Imports System.Reflection
Imports System.Windows.Forms
Imports Microsoft.Office.Interop.Excel
Imports UpgradeHelpers.Helpers
Partial Friend Class frmAbout
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


	Private Sub frmAbout_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		If Not (UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm Is eventSender) Then
			UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm = eventSender
		End If
	End Sub
	'Private Sub Check1_Click(Index As Integer)
	' frmMenu.mnuUser_Click (Index)
	'End Sub

	Private Sub cmdOK_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdOK.Click
		Me.Close()
	End Sub

	Private Sub Command1_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles Command1.Click
		ShowHelp(100)
	End Sub

	Private Sub Command2_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles Command2.Click
		ShowHelp(31)
	End Sub

	Private Sub form_initialize()
		'define help
		'UPGRADE_TODO: (1069) Error handling statement (On Error Resume Next) was converted to a pattern that might have a different behavior. More Information: https://docs.mobilize.net/vbuc/ewis/todos#id-1069
		Try
            'In some installations the App.path returns a null string - read/write privileges?
            Dim Directory = Assembly.GetExecutingAssembly().GetExecutingAssembly().Location

			'If (My.Application.Info.DirectoryPath = "") Then MessageBox.Show("FrmAbout: WARNING: App.Path is Null - could be read/write privilege issue", My.Application.Info.Title)
			'Directory = My.Application.Info.DirectoryPath & Excel_Global_definst.Application.PathSeparator
			'UPGRADE_ISSUE: (2064) VB method VB.Global was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2064
			'UPGRADE_ISSUE: (2070) Constant App was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2070
			'UPGRADE_ISSUE: (2064) App property App.HelpFile was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2064
			'BT2Support.UpgradeStubs.VB.getGlobal().getApp().setHelpFile(Directory & BathtubHelpFile)
			'hHelp.CHMFile = Directory & BathtubHelpFile
			'If DebugMode Then MessageBox.Show("frmAbout: ROOT DIRECTORY is established as " & Directory, My.Application.Info.Title)

		Catch exc As Exception
			NotUpgradedHelper.NotifyNotUpgradedElement("Resume in On-Error-Resume-Next Block")
		End Try
	End Sub

	'UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-2080
	Private Sub Form_Load()
		'If Check1(0).Value = Checked Then
		'    Index = 0
		'    Else
		'    Index = 1
		'    End If
		'frmMenu.mnuUser_Click (Index)

	End Sub
	Private Sub Form_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
	End Sub
End Class