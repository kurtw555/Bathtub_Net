Imports System
Imports System.Runtime.InteropServices
Imports System.Drawing
Imports UpgradeHelpers.Helpers
Namespace UnsafeNative
	<System.Security.SuppressUnmanagedCodeSecurity> _
	 Public Module advapi32
		Declare Function RegCloseKey Lib "advapi32" (ByVal hKey As Integer) As Integer
		'UPGRADE_TODO: (1050) Structure SECURITY_ATTRIBUTES may require marshalling attributes to be passed as an argument in this Declare statement. More Information: https://docs.mobilize.net/vbuc/ewis/todos#id-1050
		Declare Function RegCreateKeyEx Lib "advapi32"  Alias "RegCreateKeyExA"(ByVal hKey As Integer, ByVal lpSubKey As String, ByVal Reserved As Integer, ByVal lpClass As String, ByVal dwOptions As Integer, ByVal samDesired As Integer, ByRef lpSecurityAttributes As BT2Support.UnsafeNative.Structures.SECURITY_ATTRIBUTES, ByRef phkResult As Integer, ByRef lpdwDisposition As Integer) As Integer
		Declare Function RegDeleteValue Lib "advapi32"  Alias "RegDeleteValueA"(ByVal hKey As Integer, ByVal lpValueName As String) As Integer
		Declare Function RegEnumKey Lib "advapi32"  Alias "RegEnumKeyA"(ByVal hKey As Integer, ByVal dwIndex As Integer, ByVal lpName As String, ByVal cbName As Integer) As Integer
		Declare Function RegEnumValue Lib "advapi32"  Alias "RegEnumValueA"(ByVal hKey As Integer, ByVal dwIndex As Integer, ByVal lpValueName As String, ByRef lpcbValueName As Integer, ByVal lpReserved As Integer, ByRef lpType As Integer, ByVal lpData As Integer, ByRef lpcbData As Integer) As Integer
		Declare Function RegOpenKeyEx Lib "advapi32"  Alias "RegOpenKeyExA"(ByVal hKey As Integer, ByVal lpSubKey As String, ByVal ulOptions As Integer, ByVal samDesired As Integer, ByRef phkResult As Integer) As Integer
		Declare Function RegQueryValue Lib "advapi32"  Alias "RegQueryValueA"(ByVal hKey As Integer, ByVal lpSubKey As String, ByVal lpValue As String, ByRef lpcbValue As Integer) As Integer
		Declare Function RegQueryValueEx Lib "advapi32"  Alias "RegQueryValueExA"(ByVal hKey As Integer, ByVal lpValueName As String, ByVal lpReserved As Integer, ByRef lpType As Integer, ByVal lpData As Integer, ByRef lpcbData As Integer) As Integer
		Declare Function RegSetValueEx Lib "advapi32"  Alias "RegSetValueExA"(ByVal hKey As Integer, ByVal lpValueName As String, ByVal Reserved As Integer, ByVal dwType As Integer, ByVal lpData As Integer, ByVal cbData As Integer) As Integer
	End Module
End Namespace