Imports System
Imports System.Runtime.InteropServices
Imports System.Drawing
Imports UpgradeHelpers.Helpers
Namespace UnsafeNative
	<System.Security.SuppressUnmanagedCodeSecurity> _
	 Public Module kernel32
		Declare Sub CopyMem Lib "kernel32"  Alias "RtlMoveMemory"(ByVal Destination As Integer, ByVal Source As Integer, ByVal Length As Integer)
		Declare Function ExpandEnvironmentStrings Lib "kernel32"  Alias "ExpandEnvironmentStringsA"(ByVal lpSrc As String, ByVal lpDst As String, ByVal nSize As Integer) As Integer
		Declare Function FindClose Lib "kernel32" (ByVal hFindFile As Integer) As Integer
		'UPGRADE_TODO: (1050) Structure WIN32_FIND_DATA may require marshalling attributes to be passed as an argument in this Declare statement. More Information: https://docs.mobilize.net/vbuc/ewis/todos#id-1050
		Declare Function FindFirstFile Lib "kernel32"  Alias "FindFirstFileA"(ByVal lpFileName As String, ByRef lpFindFileData As BT2Support.UnsafeNative.Structures.WIN32_FIND_DATA) As Integer
		Declare Function GetLongPathName Lib "kernel32" (ByRef pszShortPath As String, ByRef lpszLongPath As String, ByVal cchBuffer As Integer) As Integer
		'UPGRADE_TODO: (1050) Structure OSVERSIONINFO may require marshalling attributes to be passed as an argument in this Declare statement. More Information: https://docs.mobilize.net/vbuc/ewis/todos#id-1050
		Declare Function GetVersionExA Lib "kernel32" (ByRef lpVersionInformation As BT2Support.UnsafeNative.Structures.OSVERSIONINFO) As Short
	End Module
End Namespace