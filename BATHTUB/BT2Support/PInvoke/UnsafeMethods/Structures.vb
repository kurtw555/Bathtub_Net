Imports System
Imports System.Runtime.InteropServices
Imports System.Drawing
Imports UpgradeHelpers.Helpers
Namespace UnsafeNative
	<System.Security.SuppressUnmanagedCodeSecurity> _
	 Public Module Structures
		<Serializable> _
		<StructLayout(LayoutKind.Sequential)> _
		 _
		Public Structure tagHH_FTS_QUERY
			Dim cbStruct As Integer
			Dim fUniCodeStrings As Integer
			Dim pszSearchQuery As String
			Dim iProximity As Integer
			Dim fStemmedSearch As Integer
			Dim fTitleOnly As Integer
			Dim fExecute As Integer
			Dim pszWindow As String
			Private Shared Sub InitStruct(ByRef result As tagHH_FTS_QUERY, ByVal init As Boolean)
				If init Then
					result.pszSearchQuery = String.Empty
					result.pszWindow = String.Empty
				End If
			End Sub
			Public Shared Function CreateInstance() As tagHH_FTS_QUERY
				Dim result As New tagHH_FTS_QUERY()
				InitStruct(result, True)
				Return result
			End Function
			Public Function Clone() As tagHH_FTS_QUERY
				Dim result As tagHH_FTS_QUERY = Me
				InitStruct(result, False)
				Return result
			End Function
		End Structure
		<Serializable> _
		<StructLayout(LayoutKind.Sequential)> _
		 _
		Public Structure MSGBOXPARAMS
			Dim cbSize As Integer
			Dim hWndOwner As Integer
			Dim hInstance As Integer
			Dim lpszText As String
			Dim lpszCaption As String
			Dim dwStyle As Integer
			Dim lpszIcon As String
			Dim dwContextHelpId As Integer
			Dim lpfnMsgBoxCallback As Integer
			Dim dwLanguageId As Integer
			Private Shared Sub InitStruct(ByRef result As MSGBOXPARAMS, ByVal init As Boolean)
				If init Then
					result.lpszText = String.Empty
					result.lpszCaption = String.Empty
					result.lpszIcon = String.Empty
				End If
			End Sub
			Public Shared Function CreateInstance() As MSGBOXPARAMS
				Dim result As New MSGBOXPARAMS()
				InitStruct(result, True)
				Return result
			End Function
			Public Function Clone() As MSGBOXPARAMS
				Dim result As MSGBOXPARAMS = Me
				InitStruct(result, False)
				Return result
			End Function
		End Structure
		<Serializable> _
		<StructLayout(LayoutKind.Sequential)> _
		 _
		Public Structure tagHH_POPUP
			Dim cbStruct As Short
			Dim hinst As Integer
			Dim idString As Integer
			Dim pszText As String
			Dim pt As BT2Support.UnsafeNative.Structures.POINTAPI
			Dim clrForeground As Color
			Dim clrBackground As Color
			Dim rcMargins As BT2Support.UnsafeNative.Structures.RECT
			Dim pszFont As String
			Private Shared Sub InitStruct(ByRef result As tagHH_POPUP, ByVal init As Boolean)
				If init Then
					result.pszText = String.Empty
					result.pszFont = String.Empty
				End If
			End Sub
			Public Shared Function CreateInstance() As tagHH_POPUP
				Dim result As New tagHH_POPUP()
				InitStruct(result, True)
				Return result
			End Function
			Public Function Clone() As tagHH_POPUP
				Dim result As tagHH_POPUP = Me
				InitStruct(result, False)
				Return result
			End Function
		End Structure
		<Serializable> _
		<StructLayout(LayoutKind.Sequential)> _
		 _
		Public Structure POINTAPI
			Dim x As Integer
			Dim y As Integer
		End Structure
		<Serializable> _
		<StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Ansi)> _
		 _
		Public Structure WIN32_FIND_DATA
			Dim dwFileAttributes As Integer
			Dim ftCreationTime As BT2Support.UnsafeNative.Structures.FILETIME
			Dim ftLastAccessTime As BT2Support.UnsafeNative.Structures.FILETIME
			Dim ftLastWriteTime As BT2Support.UnsafeNative.Structures.FILETIME
			Dim nFileSizeHigh As Integer
			Dim nFileSizeLow As Integer
			Dim dwReserved0 As Integer
			Dim dwReserved1 As Integer
			<Microsoft.VisualBasic.VBFixedArray(259)> _
			<System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst:=260)> _
			Private _cFileName() As Char
			<Microsoft.VisualBasic.VBFixedArray(13)> _
			<System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst:=14)> _
			Private _cAlternate() As Char
			Public Property cFileName() As String
				Get
					Return New String(_cFileName)
				End Get
				Set(ByVal Value As String)
					ArraysHelper.CopyStringToCharArray(_cFileName, Value)
				End Set
			End Property
			Public Property cAlternate() As String
				Get
					Return New String(_cAlternate)
				End Get
				Set(ByVal Value As String)
					ArraysHelper.CopyStringToCharArray(_cAlternate, Value)
				End Set
			End Property
			Private Shared Sub InitStruct(ByRef result As WIN32_FIND_DATA, ByVal init As Boolean)
				ReDim result._cFileName(259)
				ReDim result._cAlternate(13)
			End Sub
			Public Shared Function CreateInstance() As WIN32_FIND_DATA
				Dim result As New WIN32_FIND_DATA()
				InitStruct(result, True)
				Return result
			End Function
			Public Function Clone() As WIN32_FIND_DATA
				Dim result As WIN32_FIND_DATA = Me
				InitStruct(result, False)
				Array.Copy(Me._cFileName, result._cFileName, 260)
				Array.Copy(Me._cAlternate, result._cAlternate, 14)
				Return result
			End Function
		End Structure
		<Serializable> _
		<StructLayout(LayoutKind.Sequential)> _
		 _
		Public Structure RECT
			Dim Left As Integer
			Dim Top As Integer
			Dim Right As Integer
			Dim Bottom As Integer
		End Structure
		<Serializable> _
		<StructLayout(LayoutKind.Sequential)> _
		 _
		Public Structure FILETIME
			Dim dwLowDateTime As Integer
			Dim dwHighDateTime As Integer
		End Structure
		<Serializable> _
		<StructLayout(LayoutKind.Sequential)> _
		 _
		Public Structure SECURITY_ATTRIBUTES
			Dim nLength As Integer
			Dim lpSecurityDescriptor As Integer
			Dim bInheritHandle As Integer
		End Structure
		<Serializable> _
		<StructLayout(LayoutKind.Sequential)> _
		 _
		Public Structure tagHH_AKLINK
			Dim cbStruct As Integer
			Dim fReserved As Boolean
			Dim pszKeywords As String
			Dim pszUrl As String
			Dim pszMsgText As String
			Dim pszMsgTitle As String
			Dim pszWindow As String
			Dim fIndexOnFail As Boolean
			Private Shared Sub InitStruct(ByRef result As tagHH_AKLINK, ByVal init As Boolean)
				If init Then
					result.pszKeywords = String.Empty
					result.pszUrl = String.Empty
					result.pszMsgText = String.Empty
					result.pszMsgTitle = String.Empty
					result.pszWindow = String.Empty
				End If
			End Sub
			Public Shared Function CreateInstance() As tagHH_AKLINK
				Dim result As New tagHH_AKLINK()
				InitStruct(result, True)
				Return result
			End Function
			Public Function Clone() As tagHH_AKLINK
				Dim result As tagHH_AKLINK = Me
				InitStruct(result, False)
				Return result
			End Function
		End Structure
		<Serializable> _
		<StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Ansi)> _
		 _
		Public Structure OSVERSIONINFO
			Dim dwOSVersionInfoSize As Integer
			Dim dwMajorVersion As Integer
			Dim dwMinorVersion As Integer
			Dim dwBuildNumber As Integer
			Dim dwPlatformId As Integer
			<Microsoft.VisualBasic.VBFixedArray(127)> _
			<System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst:=128)> _
			Private _szCSDVersion() As Char
			Public Property szCSDVersion() As String
				Get
					Return New String(_szCSDVersion)
				End Get
				Set(ByVal Value As String)
					ArraysHelper.CopyStringToCharArray(_szCSDVersion, Value)
				End Set
			End Property
			Private Shared Sub InitStruct(ByRef result As OSVERSIONINFO, ByVal init As Boolean)
				ReDim result._szCSDVersion(127)
			End Sub
			Public Shared Function CreateInstance() As OSVERSIONINFO
				Dim result As New OSVERSIONINFO()
				InitStruct(result, True)
				Return result
			End Function
			Public Function Clone() As OSVERSIONINFO
				Dim result As OSVERSIONINFO = Me
				InitStruct(result, False)
				Array.Copy(Me._szCSDVersion, result._szCSDVersion, 128)
				Return result
			End Function
		End Structure
	End Module
End Namespace