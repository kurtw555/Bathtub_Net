Imports System
Imports System.Runtime.InteropServices
Imports System.Drawing
Imports UpgradeHelpers.Helpers
Namespace SafeNative
	Public Module advapi32
		Public Function RegCloseKey(ByVal hKey As Integer) As Integer
			Return BT2Support.UnsafeNative.advapi32.RegCloseKey(hKey)
		End Function
		Public Function RegCreateKeyEx(ByVal hKey As Integer, ByRef lpSubKey As String, ByVal Reserved As Integer, ByRef lpClass As String, ByVal dwOptions As Integer, ByVal samDesired As Integer, ByRef lpSecurityAttributes As BT2Support.UnsafeNative.Structures.SECURITY_ATTRIBUTES, ByRef phkResult As Integer, ByRef lpdwDisposition As Integer) As Integer
			Return BT2Support.UnsafeNative.advapi32.RegCreateKeyEx(hKey, lpSubKey, Reserved, lpClass, dwOptions, samDesired, lpSecurityAttributes, phkResult, lpdwDisposition)
		End Function
		Public Function RegDeleteValue(ByVal hKey As Integer, ByRef lpValueName As String) As Integer
			Return BT2Support.UnsafeNative.advapi32.RegDeleteValue(hKey, lpValueName)
		End Function
		Public Function RegEnumKey(ByVal hKey As Integer, ByVal dwIndex As Integer, ByRef lpName As String, ByVal cbName As Integer) As Integer
			Return BT2Support.UnsafeNative.advapi32.RegEnumKey(hKey, dwIndex, lpName, cbName)
		End Function
		Public Function RegEnumValue(ByVal hKey As Integer, ByVal dwIndex As Integer, ByRef lpValueName As String, ByRef lpcbValueName As Integer, ByVal lpReserved As Integer, ByRef lpType As Integer, ByVal lpData As Integer, ByRef lpcbData As Integer) As Integer
			Dim result As Integer = 0
			Dim handle As GCHandle = GCHandle.Alloc(lpData, GCHandleType.Pinned)
			Try
				Dim tmpPtr As IntPtr = handle.AddrOfPinnedObject()
				result = BT2Support.UnsafeNative.advapi32.RegEnumValue(hKey, dwIndex, lpValueName, lpcbValueName, lpReserved, lpType, tmpPtr, lpcbData)
				lpData = Marshal.ReadInt32(tmpPtr)
			Finally 
				handle.Free()
			End Try
			Return result
		End Function
		Public Function RegOpenKeyEx(ByVal hKey As Integer, ByRef lpSubKey As String, ByVal ulOptions As Integer, ByVal samDesired As Integer, ByRef phkResult As Integer) As Integer
			Return BT2Support.UnsafeNative.advapi32.RegOpenKeyEx(hKey, lpSubKey, ulOptions, samDesired, phkResult)
		End Function
		Public Function RegQueryValue(ByVal hKey As Integer, ByRef lpSubKey As String, ByRef lpValue As String, ByRef lpcbValue As Integer) As Integer
			Return BT2Support.UnsafeNative.advapi32.RegQueryValue(hKey, lpSubKey, lpValue, lpcbValue)
		End Function
		Public Function RegQueryValueEx(ByVal hKey As Integer, ByRef lpValueName As String, ByVal lpReserved As Integer, ByRef lpType As Integer, ByRef lpData As String, ByRef lpcbData As Integer) As Integer
			Dim result As Integer = 0
			Dim tmpPtr As IntPtr = Marshal.StringToHGlobalAnsi(lpData)
			Try
				result = BT2Support.UnsafeNative.advapi32.RegQueryValueEx(hKey, lpValueName, lpReserved, lpType, tmpPtr, lpcbData)
				lpData = Marshal.PtrToStringAnsi(tmpPtr)
			Finally 
				Marshal.FreeHGlobal(tmpPtr)
			End Try
			Return result
		End Function
		Public Function RegSetValueEx(ByVal hKey As Integer, ByRef lpValueName As String, ByVal Reserved As Integer, ByVal dwType As Integer, ByRef lpData As String, ByVal cbData As Integer) As Integer
			Dim result As Integer = 0
			Dim tmpPtr As IntPtr = Marshal.StringToHGlobalAnsi(lpData)
			Try
				result = BT2Support.UnsafeNative.advapi32.RegSetValueEx(hKey, lpValueName, Reserved, dwType, tmpPtr, cbData)
				lpData = Marshal.PtrToStringAnsi(tmpPtr)
			Finally 
				Marshal.FreeHGlobal(tmpPtr)
			End Try
			Return result
		End Function
	End Module
End Namespace