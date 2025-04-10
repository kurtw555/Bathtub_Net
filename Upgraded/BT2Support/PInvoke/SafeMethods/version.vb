Imports System
Imports System.Runtime.InteropServices
Imports System.Drawing
Imports UpgradeHelpers.Helpers
Namespace SafeNative
	Public Module version
		Public Function GetFileVersionInfo(ByRef lptstrFilename As String, ByVal dwHandle As Integer, ByVal dwLen As Integer, ByRef lpData As Byte) As Integer
			Return BT2Support.UnsafeNative.version.GetFileVersionInfo(lptstrFilename, dwHandle, dwLen, lpData)
		End Function
		Public Function GetFileVersionInfoSize(ByRef lptstrFilename As String, ByRef lpdwHandle As Integer) As Integer
			Return BT2Support.UnsafeNative.version.GetFileVersionInfoSize(lptstrFilename, lpdwHandle)
		End Function
		Public Function VerQueryValue(ByRef pBlock As Byte, ByRef lpSubBlock As String, ByRef lpBuffer As Integer, ByRef puLen As Integer) As Integer
			Return BT2Support.UnsafeNative.version.VerQueryValue(pBlock, lpSubBlock, lpBuffer, puLen)
		End Function
	End Module
End Namespace