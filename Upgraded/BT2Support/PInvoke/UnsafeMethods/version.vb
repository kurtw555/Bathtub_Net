Imports System
Imports System.Runtime.InteropServices
Imports System.Drawing
Imports UpgradeHelpers.Helpers
Namespace UnsafeNative
	<System.Security.SuppressUnmanagedCodeSecurity> _
	 Public Module version
		Declare Function GetFileVersionInfo Lib "version"  Alias "GetFileVersionInfoA"(ByVal lptstrFilename As String, ByVal dwHandle As Integer, ByVal dwLen As Integer, ByRef lpData As Byte) As Integer
		Declare Function GetFileVersionInfoSize Lib "version"  Alias "GetFileVersionInfoSizeA"(ByVal lptstrFilename As String, ByRef lpdwHandle As Integer) As Integer
		Declare Function VerQueryValue Lib "version"  Alias "VerQueryValueA"(ByRef pBlock As Byte, ByVal lpSubBlock As String, ByRef lpBuffer As Integer, ByRef puLen As Integer) As Integer
	End Module
End Namespace