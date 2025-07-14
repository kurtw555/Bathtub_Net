Imports System
Imports System.Runtime.InteropServices
Imports System.Drawing
Imports UpgradeHelpers.Helpers
Namespace UnsafeNative
	<System.Security.SuppressUnmanagedCodeSecurity> _
	 Public Module user32
		Declare Function DefWindowProc Lib "user32"  Alias "DefWindowProcA"(ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
		Declare Function DeleteMenu Lib "user32" (ByVal hMenu As Integer, ByVal nPosition As Integer, ByVal wFlags As Integer) As Integer
		'UPGRADE_TODO: (1050) Structure POINTAPI may require marshalling attributes to be passed as an argument in this Declare statement. More Information: https://docs.mobilize.net/vbuc/ewis/todos#id-1050
		Declare Function GetCursorPos Lib "user32" (ByRef lpPoint As BT2Support.UnsafeNative.Structures.POINTAPI) As Integer
		Declare Function GetSystemMenu Lib "user32" (ByVal hwnd As Integer, ByVal bRevert As Integer) As Integer
		Declare Function IsWindow Lib "user32" (ByVal hwnd As Integer) As Integer
		'UPGRADE_TODO: (1050) Structure MSGBOXPARAMS may require marshalling attributes to be passed as an argument in this Declare statement. More Information: https://docs.mobilize.net/vbuc/ewis/todos#id-1050
		Declare Function MessageBoxIndirect Lib "user32"  Alias "MessageBoxIndirectA"(ByRef lpMsgBoxParams As BT2Support.UnsafeNative.Structures.MSGBOXPARAMS) As Integer
	End Module
End Namespace