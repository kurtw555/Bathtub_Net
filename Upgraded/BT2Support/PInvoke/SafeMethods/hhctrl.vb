Imports System
Imports System.Runtime.InteropServices
Imports System.Drawing
Imports UpgradeHelpers.Helpers
Namespace SafeNative
	Public Module hhctrl
		Public Function HTMLHelp(ByVal hwnd As Integer, ByRef lpHelpFile As String, ByVal wCommand As Integer, ByVal dwData As Integer) As Integer
			Return BT2Support.UnsafeNative.hhctrl.HTMLHelp(hwnd, lpHelpFile, wCommand, dwData)
		End Function
		Public Function HTMLHelpCallSearch(ByVal hwnd As Integer, ByRef lpHelpFile As String, ByVal wCommand As Integer, ByRef dwData As BT2Support.UnsafeNative.Structures.tagHH_FTS_QUERY) As Integer
			Return BT2Support.UnsafeNative.hhctrl.HTMLHelpCallSearch(hwnd, lpHelpFile, wCommand, dwData)
		End Function
		Public Function HTMLHelpKeyWord(ByVal hwnd As Integer, ByRef lpHelpFile As String, ByVal wCommand As Integer, ByRef dwData As BT2Support.UnsafeNative.Structures.tagHH_AKLINK) As Integer
			Return BT2Support.UnsafeNative.hhctrl.HTMLHelpKeyWord(hwnd, lpHelpFile, wCommand, dwData)
		End Function
		Public Function htmlHelpTextPopup(ByVal hwnd As Integer, ByRef lpHelpFile As String, ByVal wCommand As Integer, ByRef dwData As BT2Support.UnsafeNative.Structures.tagHH_POPUP) As Integer
			Return BT2Support.UnsafeNative.hhctrl.htmlHelpTextPopup(hwnd, lpHelpFile, wCommand, dwData)
		End Function
		Public Function htmlHelpTopic(ByVal hwnd As Integer, ByRef lpHelpFile As String, ByVal wCommand As Integer, ByRef dwData As String) As Integer
			Return BT2Support.UnsafeNative.hhctrl.htmlHelpTopic(hwnd, lpHelpFile, wCommand, dwData)
		End Function
	End Module
End Namespace