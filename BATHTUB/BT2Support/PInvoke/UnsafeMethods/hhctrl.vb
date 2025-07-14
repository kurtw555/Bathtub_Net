Imports System
Imports System.Runtime.InteropServices
Imports System.Drawing
Imports UpgradeHelpers.Helpers
Namespace UnsafeNative
	<System.Security.SuppressUnmanagedCodeSecurity> _
	 Public Module hhctrl
		Declare Function HTMLHelp Lib "hhctrl"  Alias "HtmlHelpA"(ByVal hwnd As Integer, ByVal lpHelpFile As String, ByVal wCommand As Integer, ByVal dwData As Integer) As Integer
		'UPGRADE_TODO: (1050) Structure tagHH_FTS_QUERY may require marshalling attributes to be passed as an argument in this Declare statement. More Information: https://docs.mobilize.net/vbuc/ewis/todos#id-1050
		Declare Function HTMLHelpCallSearch Lib "hhctrl"  Alias "HtmlHelpA"(ByVal hwnd As Integer, ByVal lpHelpFile As String, ByVal wCommand As Integer, ByRef dwData As BT2Support.UnsafeNative.Structures.tagHH_FTS_QUERY) As Integer
		'UPGRADE_TODO: (1050) Structure tagHH_AKLINK may require marshalling attributes to be passed as an argument in this Declare statement. More Information: https://docs.mobilize.net/vbuc/ewis/todos#id-1050
		Declare Function HTMLHelpKeyWord Lib "hhctrl"  Alias "HtmlHelpA"(ByVal hwnd As Integer, ByVal lpHelpFile As String, ByVal wCommand As Integer, ByRef dwData As BT2Support.UnsafeNative.Structures.tagHH_AKLINK) As Integer
		'UPGRADE_TODO: (1050) Structure tagHH_POPUP may require marshalling attributes to be passed as an argument in this Declare statement. More Information: https://docs.mobilize.net/vbuc/ewis/todos#id-1050
		Declare Function htmlHelpTextPopup Lib "hhctrl"  Alias "HtmlHelpA"(ByVal hwnd As Integer, ByVal lpHelpFile As String, ByVal wCommand As Integer, ByRef dwData As BT2Support.UnsafeNative.Structures.tagHH_POPUP) As Integer
		Declare Function htmlHelpTopic Lib "hhctrl"  Alias "HtmlHelpA"(ByVal hwnd As Integer, ByVal lpHelpFile As String, ByVal wCommand As Integer, ByVal dwData As String) As Integer
	End Module
End Namespace