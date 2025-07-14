Imports System
Imports System.Runtime.InteropServices
Imports System.Drawing
Imports UpgradeHelpers.Helpers
Namespace SafeNative
	Public Module kernel32
		Public Sub CopyMem(Of T As Structure)(ByRef Destination As T, ByVal Source As Integer, ByVal Length As Integer)
			Dim handle2 As GCHandle = GCHandle.Alloc(Source, GCHandleType.Pinned)
			Try
				Dim tmpPtr2 As IntPtr = handle2.AddrOfPinnedObject()
				Dim tmpPtr As IntPtr = Marshal.AllocHGlobal(Marshal.SizeOf(Destination))
				Marshal.StructureToPtr(Destination, tmpPtr, True)
				BT2Support.UnsafeNative.kernel32.CopyMem(tmpPtr, tmpPtr2, Length)
				Source = Marshal.ReadInt32(tmpPtr2)
				Destination = CType(Marshal.PtrToStructure(tmpPtr, Destination.GetType()), T)
			Finally 
				handle2.Free()
			End Try
		End Sub
		Public Function ExpandEnvironmentStrings(ByRef lpSrc As String, ByRef lpDst As String, ByVal nSize As Integer) As Integer
			Return BT2Support.UnsafeNative.kernel32.ExpandEnvironmentStrings(lpSrc, lpDst, nSize)
		End Function
		Public Function FindClose(ByVal hFindFile As Integer) As Integer
			Return BT2Support.UnsafeNative.kernel32.FindClose(hFindFile)
		End Function
		Public Function FindFirstFile(ByRef lpFileName As String, ByRef lpFindFileData As BT2Support.UnsafeNative.Structures.WIN32_FIND_DATA) As Integer
			Return BT2Support.UnsafeNative.kernel32.FindFirstFile(lpFileName, lpFindFileData)
		End Function
		Public Function GetLongPathName(ByRef pszShortPath As String, ByRef lpszLongPath As String, ByVal cchBuffer As Integer) As Integer
			Return BT2Support.UnsafeNative.kernel32.GetLongPathName(pszShortPath, lpszLongPath, cchBuffer)
		End Function
		Public Function GetVersionExA(ByRef lpVersionInformation As BT2Support.UnsafeNative.Structures.OSVERSIONINFO) As Short
			Return BT2Support.UnsafeNative.kernel32.GetVersionExA(lpVersionInformation)
		End Function
	End Module
End Namespace