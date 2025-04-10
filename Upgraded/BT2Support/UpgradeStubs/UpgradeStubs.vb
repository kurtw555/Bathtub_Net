Imports System.ComponentModel
Imports System.Windows.Forms
Namespace UpgradeStubs
	Public Class AxMSComDlg_AxCommonDialog
		Inherits System.Windows.Forms.Control
		Public Function getFileName() As String
			UpgradeHelpers.Helpers.NotUpgradedHelper.NotifyNotUpgradedElement("MSComDlg.CommonDialog.FileName")
			Return ""
		End Function
		Public Sub setCancelError(ByVal CancelError As Boolean)
			UpgradeHelpers.Helpers.NotUpgradedHelper.NotifyNotUpgradedElement("MSComDlg.CommonDialog.CancelError")
		End Sub
		Public Sub setFileName(ByVal FileName As String)
			UpgradeHelpers.Helpers.NotUpgradedHelper.NotifyNotUpgradedElement("MSComDlg.CommonDialog.FileName")
		End Sub
		Public Sub setFilter(ByVal Filter As String)
			UpgradeHelpers.Helpers.NotUpgradedHelper.NotifyNotUpgradedElement("MSComDlg.CommonDialog.Filter")
		End Sub
		Public Sub setFilterIndex(ByVal FilterIndex As Integer)
			UpgradeHelpers.Helpers.NotUpgradedHelper.NotifyNotUpgradedElement("MSComDlg.CommonDialog.FilterIndex")
		End Sub
		Public Sub setHelpContext(ByVal HelpContext As Integer)
			UpgradeHelpers.Helpers.NotUpgradedHelper.NotifyNotUpgradedElement("MSComDlg.CommonDialog.HelpContext")
		End Sub
	End Class
	Public Class stdole
	End Class
	Public Class stdole_LoadPictureConstants
		Public Shared Function getdefault() As BT2Support.UpgradeStubs.stdole_LoadPictureConstantsEnum
			UpgradeHelpers.Helpers.NotUpgradedHelper.NotifyNotUpgradedElement("stdole.LoadPictureConstants.default")
			'Return CType(stdole_LoadPictureConstantsEnum.default, BT2Support.UpgradeStubs.stdole_LoadPictureConstantsEnum)
			Return CType(stdole_LoadPictureConstantsEnum.default_Renamed, BT2Support.UpgradeStubs.stdole_LoadPictureConstantsEnum)
		End Function
		Public Shared Function getMonochrome() As BT2Support.UpgradeStubs.stdole_LoadPictureConstantsEnum
			UpgradeHelpers.Helpers.NotUpgradedHelper.NotifyNotUpgradedElement("stdole.LoadPictureConstants.Monochrome")
			Return CType(stdole_LoadPictureConstantsEnum.Monochrome, BT2Support.UpgradeStubs.stdole_LoadPictureConstantsEnum)
		End Function
		Public Shared Function getVgaColor() As BT2Support.UpgradeStubs.stdole_LoadPictureConstantsEnum
			UpgradeHelpers.Helpers.NotUpgradedHelper.NotifyNotUpgradedElement("stdole.LoadPictureConstants.VgaColor")
			Return CType(stdole_LoadPictureConstantsEnum.VgaColor, BT2Support.UpgradeStubs.stdole_LoadPictureConstantsEnum)
		End Function
	End Class
	Public Module System_Windows_Forms_Control
		<System.Runtime.CompilerServices.Extension()> _
		 Public Function getHelpContextID(ByVal instance As Control) As Integer
			UpgradeHelpers.Helpers.NotUpgradedHelper.NotifyNotUpgradedElement("VB.Control.HelpContextID")
			Return 0
		End Function
		<System.Runtime.CompilerServices.Extension()> _
		 Public Function getHelpContextID(ByVal instance As Component) As Integer
			UpgradeHelpers.Helpers.NotUpgradedHelper.NotifyNotUpgradedElement("VB.Control.HelpContextID")
			Return 0
		End Function
		<System.Runtime.CompilerServices.Extension()> _
		 Public Sub setHelpContextID(ByVal instance As Control, ByVal HelpContextID As Integer)
			UpgradeHelpers.Helpers.NotUpgradedHelper.NotifyNotUpgradedElement("VB.Control.HelpContextID")
		End Sub
		<System.Runtime.CompilerServices.Extension()> _
		 Public Sub setHelpContextID(ByVal instance As Component, ByVal HelpContextID As Integer)
			UpgradeHelpers.Helpers.NotUpgradedHelper.NotifyNotUpgradedElement("VB.Control.HelpContextID")
		End Sub
	End Module
	Public Module System_Windows_Forms_Form
		<System.Runtime.CompilerServices.Extension()> _
		 Public Function getHelpContextID(ByVal instance As Form) As Integer
			UpgradeHelpers.Helpers.NotUpgradedHelper.NotifyNotUpgradedElement("VB.Form.HelpContextID")
			Return 0
		End Function
		<System.Runtime.CompilerServices.Extension()> _
		 Public Sub setHelpContextID(ByVal instance As Form, ByVal HelpContextID As Integer)
			UpgradeHelpers.Helpers.NotUpgradedHelper.NotifyNotUpgradedElement("VB.Form.HelpContextID")
		End Sub
	End Module
	Public Class VB
		Public Shared Function getGlobal() As BT2Support.UpgradeStubs.VB_Global
			UpgradeHelpers.Helpers.NotUpgradedHelper.NotifyNotUpgradedElement("VB.Global")
			Return Nothing
		End Function
	End Class
	Public Class VB_App
		Public Sub setHelpFile(ByVal HelpFile As String)
			UpgradeHelpers.Helpers.NotUpgradedHelper.NotifyNotUpgradedElement("VB.App.HelpFile")
		End Sub
	End Class
	Public Class VB_Global
		Public Function getApp() As BT2Support.UpgradeStubs.VB_App
			UpgradeHelpers.Helpers.NotUpgradedHelper.NotifyNotUpgradedElement("VB.Global.App")
			Return Nothing
		End Function
	End Class
	Public Enum stdole_LoadPictureConstantsEnum
		default_Renamed = 0
		Monochrome = 1
		VgaColor = 2
	End Enum
End Namespace