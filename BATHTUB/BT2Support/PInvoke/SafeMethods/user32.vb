Imports System
Imports System.Runtime.InteropServices
Imports System.Drawing
Imports UpgradeHelpers.Helpers
Namespace SafeNative
	Public Module user32
		Public Function DefWindowProc(ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
			Return BT2Support.UnsafeNative.user32.DefWindowProc(hwnd, wMsg, wParam, lParam)
		End Function
		Public Function DeleteMenu(ByVal hMenu As Integer, ByVal nPosition As Integer, ByVal wFlags As Integer) As Integer
			Return BT2Support.UnsafeNative.user32.DeleteMenu(hMenu, nPosition, wFlags)
		End Function
		Public Function GetCursorPos(ByRef lpPoint As BT2Support.UnsafeNative.Structures.POINTAPI) As Integer
			Return BT2Support.UnsafeNative.user32.GetCursorPos(lpPoint)
		End Function
		Public Function GetSystemMenu(ByVal hwnd As Integer, ByVal bRevert As Integer) As Integer
			Return BT2Support.UnsafeNative.user32.GetSystemMenu(hwnd, bRevert)
		End Function
		Public Function IsWindow(ByVal hwnd As Integer) As Integer
			Return BT2Support.UnsafeNative.user32.IsWindow(hwnd)
		End Function
		Public Function MessageBoxIndirect(ByRef lpMsgBoxParams As BT2Support.UnsafeNative.Structures.MSGBOXPARAMS) As Integer
			Return BT2Support.UnsafeNative.user32.MessageBoxIndirect(lpMsgBoxParams)
		End Function
	End Module
End Namespace