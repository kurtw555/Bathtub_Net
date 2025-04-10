Option Strict Off
Option Explicit On
Option Compare Text
Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Specialized
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Text
Imports UpgradeHelpers.Helpers
Friend Class HTMLHelp
	' ********************************************************
	' HTML Help class module version 3.0h
	' (c)December 1999, Delmar Computing Services
	'
	' For use with Microsoft Visual Basic(r) 5 and 6
	'
	' Developed by David Liske, Tipton, Michigan, USA
	' Microsoft HTML Help MVP 1999
	' http://htmlhelpcenter.hypermart.net
	'
	' Proof-of-concept testing and some HTML Help
	' API research provided by Robert Chandler,
	' The HelpWare Group, and Varian Corporation,
	' Melbourne, Vic, Australia
	' Microsoft HTML Help MVP 1999
	' http://www.helpware.net
	'
	' Please send any performance or functionality
	' modifications of this file to delmar@tc3net.com
	' ________________________________________________________
	'
	' Full technical review by
	' Leonardo Presciuttini, FBM-Hudson Italiana SpA
	' Bergamo, Italy
	'
	' Some registry functionality re-developed from
	' original code written by Dave Scarmozzino
	' http://www.TheScarms.com
	'
	' Beta testing (July 1999):
	' Lani Hardage, MDL Information Systems, Inc.
	' Steve Hsu, TREEV, Inc.
	' John Hunt, Lotus Development Corporation
	' Shirley Kelly, Corbel, A SunGard Company
	' Valerie A. Lipow, Compuware Corporation
	' Leyden Martinez, Copextel, S.A., Cuba
	' Alejandro Sicilia, Copextel, S.A., Cuba
	'
	' Further testing by Dana Cline,
	' Lucent Technologies, Winchester, Colorado
	' Microsoft HTML Help MVP 1998, 1999
	'
	' GetLongPath_Legacy logic checks and code modifications,
	' and all-around support of a programming geek's
	' chocolate and strange snacking needs, by:
	' Marnella Liske, RN, BSN
	' University of Michigan Medical Center
	'
	' ********************************************************


	' Public declarations
	Public frm As Object
	Public hwnd As Integer
	Public lpPrevWndFunc As Integer

	Public Enum PopupType
		HH_CHM_POPUP = &H1s
		HH_RESOURCE_POPUP = &H2s
		HH_TEXT_POPUP = &H4s
	End Enum

	Public Enum HHVersion_RenamedEnum
		HH_1_0 = &H10s
		HH_1_1 = &H11s
		HH_1_1A = &H12s
		HH_1_1B = &H13s
		HH_1_2 = &H14s
		HH_1_21 = &H15s
		HH_1_21A = &H16s
		HH_1_22 = &H17s
		HH_1_3_WIN2K_BETA = &H18s
		HH_1_3_IE5_5_BETA = &H19s
		HH_1_3 = &H1As
	End Enum

	' IE versions are derived from shdocvw.dll as per
	' Q164539, and are updated periodically

	Public Enum IEVersion_RenamedEnum
		IE_3_0 = &H100s
		IE_3_0_OSR2 = &H101s
		IE_3_01 = &H102s
		IE_3_02 = &H103s
		IE_4_0_PP2 = &H104s
		IE_4_0 = &H105s
		IE_4_01 = &H106s
		IE_4_01_SP1 = &H107s
		IE_4_01_SP2 = &H108s
		IE_5_0_Beta1 = &H109s
		IE_5_0_Beta2 = &H10As
		IE_5_0 = &H10Bs
		IE_5_0A = &H10Cs
		IE_5_0B = &H10Ds
		IE_5_0C = &H10Es
		IE_5_0D = &H10Fs
		IE_5_Win2K_RC1 = &H110s
		IE_5_Win2K_RC2 = &H111s
		IE_5_01 = &H112s
		IE_5_5_PLAT_PREV = &H113s
	End Enum

	' HTML Help Version Constants
	Private Const extHH_1_0 As String = "4.72.7290"
	Private Const extHH_1_1 As String = "4.72.7323"
	Private Const extHH_1_1A As String = "4.72.7325"
	Private Const extHH_1_1B As String = "4.72.8164.0"
	Private Const extHH_1_2 As String = "4.73.8252"
	Private Const extHH_1_21 As String = "4.73.8412"
	Private Const extHH_1_21A As String = "4.73.8474"
	Private Const extHH_1_22 As String = "4.73.8561"
	Private Const extHH_1_3_WIN2K_BETA As String = "4.74.8566"
	Private Const extHH_1_3_IE5_5_BETA As String = "4.74.8637"
	Private Const extHH_1_3 As String = "4.74.8702"

	' Internet Explorer Version Constants
	Private Const extIE_3_0 As String = "4.70.1155"
	Private Const extIE_3_0_OSR2 As String = "4.70.1158"
	Private Const extIE_3_01 As String = "4.70.1215"
	Private Const extIE_3_02 As String = "4.70.1300"
	Private Const extIE_4_0_PP2 As String = "4.71.1008.3"
	Private Const extIE_4_0 As String = "4.71.1712.5"
	Private Const extIE_4_01 As String = "4.72.2106.7"
	Private Const extIE_4_01_SP1 As String = "4.72.3110.03"
	Private Const extIE_4_01_SP2 As String = "4.72.3612.1707"
	Private Const extIE_5_0_Beta1 As String = "5.00.0518.5"
	Private Const extIE_5_0_Beta2 As String = "5.00.0910.1308"
	Private Const extIE_5_0 As String = "5.00.2014.213"
	Private Const extIE_5_0A As String = "5.00.2314.1000"
	Private Const extIE_5_0B As String = "5.00.2614.3500"
	Private Const extIE_5_0C As String = "5.0.2717.2000"
	Private Const extIE_5_0D As String = "5.00.2721.1400"
	Private Const extIE_5_Win2K_RC1 As String = "5.00.2919.800"
	Private Const extIE_5_Win2K_RC2 As String = "5.00.2919.3800"
	Private Const extIE_5_01 As String = "5.00.2919.6307"
	Private Const extIE_5_5_PLAT_PREV As String = "5.50.3825.1300"

	Private Const extUNKNOWN As String = "unknown"

	' HTML Help Constants
	Private Const HH_DISPLAY_TOPIC As Integer = &H0s ' WinHelp equivalent
	Private Const HH_DISPLAY_TOC As Integer = &H1s ' WinHelp equivalent
	Private Const HH_DISPLAY_INDEX As Integer = &H2s ' WinHelp equivalent
	Private Const HH_DISPLAY_SEARCH As Integer = &H3s ' WinHelp equivalent
	Private Const HH_SET_WIN_TYPE As Integer = &H4s
	Private Const HH_GET_WIN_TYPE As Integer = &H5s
	Private Const HH_GET_WIN_HANDLE As Integer = &H6s
	Private Const HH_SYNC As Integer = &H9s
	Private Const HH_ADD_NAV_UI As Integer = &HAs ' not currently implemented
	Private Const HH_ADD_BUTTON As Integer = &HBs ' not currently implemented
	Private Const HH_GETBROWSER_APP As Integer = &HCs ' not currently implemented
	Private Const HH_KEYWORD_LOOKUP As Integer = &HDs ' WinHelp equivalent
	Private Const HH_DISPLAY_TEXT_POPUP As Integer = &HEs ' display string resource id
	' or text in a popup window
	' value in dwData
	Private Const HH_HELP_CONTEXT As Integer = &HFs ' display mapped numeric
	Private Const HH_CLOSE_ALL As Integer = &H12s ' WinHelp equivalent
	Private Const HH_ALINK_LOOKUP As Integer = &H13s ' ALink version of
	' HH_KEYWORD_LOOKUP
	Private Const HH_SET_GUID As Integer = &H1As ' For Microsoft Installer -- dwData is a pointer to the GUID string

	' HTML Help window constants. These are also used
	' in the window definitions in HHP files
	' and are included here for reference only
	Private Const HHWIN_PROP_ONTOP As Integer = &H2s ' Top-most window (not currently implemented)
	Private Const HHWIN_PROP_NOTITLEBAR As Integer = &H4s ' no title bar
	Private Const HHWIN_PROP_NODEF_STYLES As Integer = &H8s ' no default window styles (only HH_WINTYPE.dwStyles)
	Private Const HHWIN_PROP_NODEF_EXSTYLES As Integer = &H10s ' no default extended window styles (only HH_WINTYPE.dwExStyles)
	Private Const HHWIN_PROP_TRI_PANE As Integer = &H20s ' use a tri-pane window
	Private Const HHWIN_PROP_NOTB_TEXT As Integer = &H40s ' no text on toolbar buttons
	Private Const HHWIN_PROP_POST_QUIT As Integer = &H80s ' post WM_QUIT message when window closes
	Private Const HHWIN_PROP_AUTO_SYNC As Integer = &H100s ' automatically ssync contents and index
	Private Const HHWIN_PROP_TRACKING As Integer = &H200s ' send tracking notification messages
	Private Const HHWIN_PROP_TAB_SEARCH As Integer = &H400s ' include search tab in navigation pane
	Private Const HHWIN_PROP_TAB_HISTORY As Integer = &H800s ' include history tab in navigation pane
	Private Const HHWIN_PROP_TAB_BOOKMARKS As Integer = &H1000s ' include bookmark tab in navigation pane
	Private Const HHWIN_PROP_CHANGE_TITLE As Integer = &H2000s ' Put current HTML title in title bar
	Private Const HHWIN_PROP_NAV_ONLY_WIN As Integer = &H4000s ' Only display the navigation window
	Private Const HHWIN_PROP_NO_TOOLBAR As Integer = &H8000s ' Don't display a toolbar
	Private Const HHWIN_PROP_MENU As Integer = &H10000 ' Menu
	Private Const HHWIN_PROP_TAB_ADVSEARCH As Integer = &H20000 ' Advanced FTS UI.
	Private Const HHWIN_PROP_USER_POS As Integer = &H40000 ' After initial creation, user controls window size/position

	Private Const HHWIN_PARAM_PROPERTIES As Integer = &H2s ' valid fsWinProperties
	Private Const HHWIN_PARAM_STYLES As Integer = &H4s ' valid dwStyles
	Private Const HHWIN_PARAM_EXSTYLES As Integer = &H8s ' valid dwExStyles
	Private Const HHWIN_PARAM_RECT As Integer = &H10s ' valid rcWindowPos
	Private Const HHWIN_PARAM_NAV_WIDTH As Integer = &H20s ' valid iNavWidth
	Private Const HHWIN_PARAM_SHOWSTATE As Integer = &H40s ' valid nShowState
	Private Const HHWIN_PARAM_INFOTYPES As Integer = &H80s ' valid apInfoTypes
	Private Const HHWIN_PARAM_TB_FLAGS As Integer = &H100s ' valid fsToolBarFlags
	Private Const HHWIN_PARAM_EXPANSION As Integer = &H200s ' valid fNotExpanded
	Private Const HHWIN_PARAM_TABPOS As Integer = &H400s ' valid tabpos
	Private Const HHWIN_PARAM_TABORDER As Integer = &H800s ' valid taborder
	Private Const HHWIN_PARAM_HISTORY_COUNT As Integer = &H1000s ' valid cHistory
	Private Const HHWIN_PARAM_CUR_TAB As Integer = &H2000s ' valid curNavType

	Private Const HHWIN_BUTTON_EXPAND As Integer = &H2s ' Expand/contract button
	Private Const HHWIN_BUTTON_BACK As Integer = &H4s ' Back button
	Private Const HHWIN_BUTTON_FORWARD As Integer = &H8s ' Forward button
	Private Const HHWIN_BUTTON_STOP As Integer = &H10s ' Stop button
	Private Const HHWIN_BUTTON_REFRESH As Integer = &H20s ' Refresh button
	Private Const HHWIN_BUTTON_HOME As Integer = &H40s ' Home button
	Private Const HHWIN_BUTTON_BROWSE_FWD As Integer = &H80s ' not implemented
	Private Const HHWIN_BUTTON_BROWSE_BCK As Integer = &H100s ' not implemented
	Private Const HHWIN_BUTTON_NOTES As Integer = &H200s ' not implemented
	Private Const HHWIN_BUTTON_CONTENTS As Integer = &H400s ' not implemented
	Private Const HHWIN_BUTTON_SYNC As Integer = &H800s ' Locate button
	Private Const HHWIN_BUTTON_OPTIONS As Integer = &H1000s ' Options button
	Private Const HHWIN_BUTTON_PRINT As Integer = &H2000s ' Print button
	Private Const HHWIN_BUTTON_INDEX As Integer = &H4000s ' not implemented
	Private Const HHWIN_BUTTON_SEARCH As Integer = &H8000s ' not implemented
	Private Const HHWIN_BUTTON_HISTORY As Integer = &H10000 ' not implemented
	Private Const HHWIN_BUTTON_BOOKMARKS As Integer = &H20000 ' not implemented
	Private Const HHWIN_BUTTON_JUMP1 As Integer = &H40000 ' Jump1 button
	Private Const HHWIN_BUTTON_JUMP2 As Integer = &H80000 ' Jump2 button
	Private Const HHWIN_BUTTON_ZOOM As Integer = &H100000 ' Font sizing button
	Private Const HHWIN_BUTTON_TOC_NEXT As Integer = &H200000 ' Browse next TOC topic button
	Private Const HHWIN_BUTTON_TOC_PREV As Integer = &H400000 ' Browse previous TOC topic button

	' Default button set
	Shared ReadOnly Private HHWIN_DEF_BUTTONS As Integer = (HHWIN_BUTTON_EXPAND Or HHWIN_BUTTON_BACK Or HHWIN_BUTTON_OPTIONS Or HHWIN_BUTTON_PRINT)

	' Button IDs
	Private Const IDTB_EXPAND As Integer = 200
	Private Const IDTB_CONTRACT As Integer = 201
	Private Const IDTB_STOP As Integer = 202
	Private Const IDTB_REFRESH As Integer = 203
	Private Const IDTB_BACK As Integer = 204
	Private Const IDTB_HOME As Integer = 205
	Private Const IDTB_SYNC As Integer = 206
	Private Const IDTB_PRINT As Integer = 207
	Private Const IDTB_OPTIONS As Integer = 208
	Private Const IDTB_FORWARD As Integer = 209
	Private Const IDTB_NOTES As Integer = 210 ' not implemented
	Private Const IDTB_BROWSE_FWD As Integer = 211
	Private Const IDTB_BROWSE_BACK As Integer = 212
	Private Const IDTB_CONTENTS As Integer = 213 ' not implemented
	Private Const IDTB_INDEX As Integer = 214 ' not implemented
	Private Const IDTB_SEARCH As Integer = 215 ' not implemented
	Private Const IDTB_HISTORY As Integer = 216 ' not implemented
	Private Const IDTB_BOOKMARKS As Integer = 217 ' not implemented
	Private Const IDTB_JUMP1 As Integer = 218
	Private Const IDTB_JUMP2 As Integer = 219
	Private Const IDTB_CUSTOMIZE As Integer = 221
	Private Const IDTB_ZOOM As Integer = 222
	Private Const IDTB_TOC_NEXT As Integer = 223
	Private Const IDTB_TOC_PREV As Integer = 224

	Private Enum HHACT_
		HHACT_TAB_CONTENTS
		HHACT_TAB_INDEX
		HHACT_TAB_SEARCH
		HHACT_TAB_HISTORY
		HHACT_TAB_FAVORITES
		HHACT_EXPAND
		HHACT_CONTRACT
		HHACT_BACK
		HHACT_FORWARD
		HHACT_STOP
		HHACT_REFRESH
		HHACT_HOME
		HHACT_SYNC
		HHACT_OPTIONS
		HHACT_PRINT
		HHACT_HIGHLIGHT
		HHACT_CUSTOMIZE
		HHACT_JUMP1
		HHACT_JUMP2
		HHACT_ZOOM
		HHACT_TOC_NEXT
		HHACT_TOC_PREV
		HHACT_NOTES
		HHACT_LAST_ENUM
	End Enum

	Private Enum HHWIN_NAVTYPE_
		HHWIN_NAVTYPE_TOC
		HHWIN_NAVTYPE_INDEX
		HHWIN_NAVTYPE_SEARCH
		HHWIN_NAVTYPE_HISTORY ' not implemented
		HHWIN_NAVTYPE_FAVORITES ' not implemented
	End Enum

	Public Enum HHWIN_NAVTAB_
		HHWIN_NAVTAB_TOP
		HHWIN_NAVTAB_LEFT
		HHWIN_NAVTAB_BOTTOM
	End Enum

	Private Const HH_MAX_TABS As Integer = 19 ' maximum number of tabs

	Private Enum HH_TAB_
		HH_TAB_CONTENTS
		HH_TAB_INDEX
		HH_TAB_SEARCH
		HH_TAB_HISTORY
		HH_TAB_FAVORITES
	End Enum


	<Serializable> _
	 _
	Private Structure tagHH_WINTYPE
		Dim cbStruct As Integer ' IN: size of this structure including all Information Types
		Dim fUniCodeStrings As Integer ' IN/OUT: TRUE if all strings are in UNICODE
		Dim pszType As String ' IN/OUT: Name of a type of window
		Dim fsValidMembers As Integer ' IN: Bit flag of valid members (HHWIN_PARAM_)
		Dim fsWinProperties As Integer ' IN/OUT: Properties/attributes of the window (HHWIN_)
		Dim pszCaption As String ' IN/OUT: Window title
		Dim dwStyles As Integer ' IN/OUT: Window styles
		Dim dwExStyles As Integer ' IN/OUT: Extended Window styles
		Dim rcWindowPos As BT2Support.UnsafeNative.Structures.RECT ' IN: Starting position, OUT: current position
		Dim nShowState As Integer ' IN: show state (e.g., SW_SHOW)
		Dim hwndHelp As Integer ' OUT: window handle
		Dim hwndCaller As Integer ' OUT: who called this window
		Dim paInfoTypes As Integer ' IN: Pointer to an array of Information Types
		' The following members are only valid if HHWIN_PROP_TRI_PANE is set
		Dim hwndToolBar As Integer ' OUT: toolbar window in tri-pane window
		Dim hwndNavigation As Integer ' OUT: navigation window in tri-pane window
		Dim hwndHTML As Integer ' OUT: window displaying HTML in tri-pane window
		Dim iNavWidth As Integer ' IN/OUT: width of navigation window
		Dim rcHTML As BT2Support.UnsafeNative.Structures.RECT ' OUT: HTML window coordinates
		Dim pszToc As String ' IN: Location of the table of contents file
		Dim pszIndex As String ' IN: Location of the index file
		Dim pszFile As String ' IN: Default location of the html file
		Dim pszHome As String ' IN/OUT: html file to display when Home button is clicked
		Dim fsToolBarFlags As Integer ' IN: flags controling the appearance of the toolbar
		Dim fNotExpanded As Integer ' IN: TRUE/FALSE to contract or expand, OUT: current state
		Dim curNavType As Integer ' IN/OUT: UI to display in the navigational pane
		Dim tabpos As HHWIN_NAVTAB_ ' IN/OUT: HHWIN_NAVTAB_TOP, HHWIN_NAVTAB_LEFT, or HHWIN_NAVTAB_BOTTOM
		Dim idNotify As Integer ' IN: ID to use for WM_NOTIFY messages
		<Microsoft.VisualBasic.VBFixedArray(HH_MAX_TABS)> _
		Dim tabOrder() As Byte ' IN/OUT: tab order: Contents, Index, Search, History, Favorites, Reserved 1-5, Custom tabs
		Dim cHistory As Integer ' IN/OUT: number of history items to keep (default is 30)
		Dim pszJump1 As String ' Text for HHWIN_BUTTON_JUMP1
		Dim pszJump2 As String ' Text for HHWIN_BUTTON_JUMP2
		Dim pszUrlJump1 As String ' URL for HHWIN_BUTTON_JUMP1
		Dim pszUrlJump2 As String ' URL for HHWIN_BUTTON_JUMP2
		Dim rcMinSize As BT2Support.UnsafeNative.Structures.RECT ' Minimum size for window (ignored in version 1)
		Dim cbInfoTypes As Integer ' size of paInfoTypes;
		Public Shared Function CreateInstance() As tagHH_WINTYPE
			Dim result As New tagHH_WINTYPE()
			result.pszType = String.Empty
			result.pszCaption = String.Empty
			result.pszToc = String.Empty
			result.pszIndex = String.Empty
			result.pszFile = String.Empty
			result.pszHome = String.Empty
			ReDim result.tabOrder(HH_MAX_TABS)
			result.pszJump1 = String.Empty
			result.pszJump2 = String.Empty
			result.pszUrlJump1 = String.Empty
			result.pszUrlJump2 = String.Empty
			Return result
		End Function
	End Structure

	' UDT for mouse cursor position

	' UDT for text popups

	' UDT for keyword and ALink searches

	' UDT for accessing the Search tab

	' Constants for converting the cursor to What's This Help
	Private Const WM_SYSCOMMAND As Integer = &H112s
	Private Const SC_CONTEXTHELP As Integer = &HF180

	' Message Box Constants
	Private Const MB_ABORTRETRYIGNORE As Integer = &H2
	Private Const MB_APPLMODAL As Integer = &H0
	Private Const MB_COMPOSITE As Integer = &H2s
	Private Const MB_DEFAULT_DESKTOP_ONLY As Integer = &H20000
	Private Const MB_DEFBUTTON1 As Integer = &H0
	Private Const MB_DEFBUTTON2 As Integer = &H100
	Private Const MB_DEFBUTTON3 As Integer = &H200
	Private Const MB_DEFMASK As Integer = &HF00
	Private Const MB_ICONASTERISK As Integer = &H40
	Private Const MB_ICONEXCLAMATION As Integer = &H30
	Private Const MB_ICONHAND As Integer = &H10
	Private Const MB_ICONINFORMATION As Integer = MB_ICONASTERISK
	Private Const MB_ICONMASK As Integer = &HF0
	Private Const MB_ICONQUESTION As Integer = &H20
	Private Const MB_ICONSTOP As Integer = MB_ICONHAND
	Private Const MB_MISCMASK As Integer = &HC000
	Private Const MB_MODEMASK As Integer = &H3000
	Private Const MB_NOFOCUS As Integer = &H8000
	Private Const MB_OK As Integer = &H0
	Private Const MB_OKCANCEL As Integer = &H1
	Private Const MB_PRECOMPOSED As Integer = &H1s
	Private Const MB_RETRYCANCEL As Integer = &H5
	Private Const MB_SETFOREGROUND As Integer = &H10000
	Private Const MB_SYSTEMMODAL As Integer = &H1000
	Private Const MB_TASKMODAL As Integer = &H2000
	Private Const MB_TYPEMASK As Integer = &HF
	Private Const MB_USEGLYPHCHARS As Integer = &H4s
	Private Const MB_YESNO As Integer = &H4
	Private Const MB_YESNOCANCEL As Integer = &H3

	' Registry API call Constants
	Private Const HKEY_LOCAL_MACHINE As Integer = &H80000002
	Private Const ERROR_SUCCESS As Integer = 0
	Private Const STANDARD_RIGHTS_ALL As Integer = &H1F0000
	Private Const KEY_QUERY_VALUE As Integer = &H1s
	Private Const KEY_SET_VALUE As Integer = &H2s
	Private Const KEY_CREATE_SUB_KEY As Integer = &H4s
	Private Const KEY_ENUMERATE_SUB_KEYS As Integer = &H8s
	Private Const KEY_NOTIFY As Integer = &H10s
	Private Const KEY_CREATE_LINK As Integer = &H20s
	Private Const SYNCHRONIZE As Integer = &H100000
	Shared ReadOnly Private KEY_ALL_ACCESS As Integer = ((STANDARD_RIGHTS_ALL Or KEY_QUERY_VALUE Or KEY_SET_VALUE Or KEY_CREATE_SUB_KEY Or KEY_ENUMERATE_SUB_KEYS Or KEY_NOTIFY Or KEY_CREATE_LINK) And (Not SYNCHRONIZE))

	Private Const MAX_PATH As Integer = 260
	Private Const INVALID_HANDLE_VALUE As Integer = -1

	' RegCreateKeyEx options
	Private Const REG_OPTION_NON_VOLATILE As Integer = 0

	' Registry data types
	Private Const REG_NONE As Integer = 0
	Private Const REG_SZ As Integer = 1
	Private Const REG_EXPAND_SZ As Integer = 2
	Private Const REG_BINARY As Integer = 3
	Private Const REG_DWORD As Integer = 4

	' FindFirstFile return values
	Private Const ERROR_FILE_NOT_FOUND As Integer = 2
	Private Const ERROR_MORE_DATA As Integer = 234
	Private Const ERROR_NO_MORE_ITEMS As Integer = 259

	' Constants for Registry top-level keys
	Private Const HKEY_CURRENT_USER As Integer = &H80000001
	Private Const HKEY_USERS As Integer = &H80000003
	Private Const HKEY_DYN_DATA As Integer = &H80000006
	Private Const HKEY_CURRENT_CONFIG As Integer = &H80000005
	Private Const HKEY_CLASSES_ROOT As Integer = &H80000000

	Private Const MAX_SIZE As Integer = 2048
	Private Const MAX_INISIZE As Integer = 8192

	Private Const GWL_STYLE As Integer = (-16)
	Private Const GWL_EXSTYLE As Integer = (-20)
	Private Const GWL_WNDPROC As Integer = (-4)

	' Constants for GetLongPath_Legacy
	Private Const SINGLE_QUOTE As String = """"

	' Constants for determining OS
	Private Const VER_PLATFORM_WIN32s As Integer = 0
	Private Const VER_PLATFORM_WIN32_WINDOWS As Integer = 1
	Private Const VER_PLATFORM_WIN32_NT As Integer = 2

	Private Const UNKNOWN_OS As Integer = 0
	Private Const WINDOWS_NT_3_51 As Integer = 1
	Private Const WINDOWS_95 As Integer = 2
	Private Const WINDOWS_NT_4 As Integer = 3
	Private Const WINDOWS_98 As Integer = 4
	Private Const WINDOWS_2000 As Integer = 5

	' UDT for determining OS

	' UDT for message box API calls

	' Registry UDT's

	<Serializable> _
	 _
	Private Structure HH_REG_VALUES
		Dim pszFileName As String
		Dim pszFilePath As String
		Public Shared Function CreateInstance() As HH_REG_VALUES
			Dim result As New HH_REG_VALUES()
			result.pszFileName = String.Empty
			result.pszFilePath = String.Empty
			Return result
		End Function
	End Structure



	<Serializable> _
	 _
	Private Structure VS_FIXEDFILEINFO
		Dim dwSignature As Integer
		Dim dwStrucVersionl As Short '  e.g. = &h0000 = 0
		Dim dwStrucVersionh As Short '  e.g. = &h0042 = .42
		Dim dwFileVersionMSl As Short '  e.g. = &h0003 = 3
		Dim dwFileVersionMSh As Short '  e.g. = &h0075 = .75
		Dim dwFileVersionLSl As Short '  e.g. = &h0000 = 0
		Dim dwFileVersionLSh As Short '  e.g. = &h0031 = .31
		Dim dwProductVersionMSl As Short '  e.g. = &h0003 = 3
		Dim dwProductVersionMSh As Short '  e.g. = &h0010 = .1
		Dim dwProductVersionLSl As Short '  e.g. = &h0000 = 0
		Dim dwProductVersionLSh As Short '  e.g. = &h0031 = .31
		Dim dwFileFlagsMask As Integer '  = &h3F for version "0.42"
		Dim dwFileFlags As Integer '  e.g. VFF_DEBUG Or VFF_PRERELEASE
		Dim dwFileOS As Integer '  e.g. VOS_DOS_WINDOWS16
		Dim dwFileType As Integer '  e.g. VFT_DRIVER
		Dim dwFileSubtype As Integer '  e.g. VFT2_DRV_KEYBOARD
		Dim dwFileDateMS As Integer '  e.g. 0
		Dim dwFileDateLS As Integer '  e.g. 0
	End Structure

	' HTML Help API declarations
	'UPGRADE_NOTE: (2041) The following line was commented. More Information: https://docs.mobilize.net/vbuc/ewis/notes#id-2041
	'Private Declare Function HTMLHelp Lib "hhctrl"  Alias "HtmlHelpA"(ByVal hwnd As Integer, ByVal lpHelpFile As String, ByVal wCommand As Integer, ByVal dwData As Integer) As Integer

	'UPGRADE_NOTE: (2041) The following line was commented. More Information: https://docs.mobilize.net/vbuc/ewis/notes#id-2041
	''UPGRADE_TODO: (1050) Structure tagHH_FTS_QUERY may require marshalling attributes to be passed as an argument in this Declare statement. More Information: https://docs.mobilize.net/vbuc/ewis/todos#id-1050
	'Private Declare Function HTMLHelpCallSearch Lib "hhctrl"  Alias "HtmlHelpA"(ByVal hwnd As Integer, ByVal lpHelpFile As String, ByVal wCommand As Integer, ByRef dwData As BT2Support.UnsafeNative.Structures.tagHH_FTS_QUERY) As Integer

	'UPGRADE_NOTE: (2041) The following line was commented. More Information: https://docs.mobilize.net/vbuc/ewis/notes#id-2041
	''UPGRADE_TODO: (1050) Structure tagHH_AKLINK may require marshalling attributes to be passed as an argument in this Declare statement. More Information: https://docs.mobilize.net/vbuc/ewis/todos#id-1050
	'Private Declare Function HTMLHelpKeyWord Lib "hhctrl"  Alias "HtmlHelpA"(ByVal hwnd As Integer, ByVal lpHelpFile As String, ByVal wCommand As Integer, ByRef dwData As BT2Support.UnsafeNative.Structures.tagHH_AKLINK) As Integer

	'UPGRADE_NOTE: (2041) The following line was commented. More Information: https://docs.mobilize.net/vbuc/ewis/notes#id-2041
	''UPGRADE_TODO: (1050) Structure tagHH_POPUP may require marshalling attributes to be passed as an argument in this Declare statement. More Information: https://docs.mobilize.net/vbuc/ewis/todos#id-1050
	'Private Declare Function htmlHelpTextPopup Lib "hhctrl"  Alias "HtmlHelpA"(ByVal hwnd As Integer, ByVal lpHelpFile As String, ByVal wCommand As Integer, ByRef dwData As BT2Support.UnsafeNative.Structures.tagHH_POPUP) As Integer

	'UPGRADE_NOTE: (2041) The following line was commented. More Information: https://docs.mobilize.net/vbuc/ewis/notes#id-2041
	'Private Declare Function htmlHelpTopic Lib "hhctrl"  Alias "HtmlHelpA"(ByVal hwnd As Integer, ByVal lpHelpFile As String, ByVal wCommand As Integer, ByVal dwData As String) As Integer

	' Subclassing API declarations
	'UPGRADE_NOTE: (2041) The following line was commented. More Information: https://docs.mobilize.net/vbuc/ewis/notes#id-2041
	'Private Declare Function DefWindowProc Lib "user32"  Alias "DefWindowProcA"(ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer

	' Registry API declarations
	'UPGRADE_NOTE: (2041) The following line was commented. More Information: https://docs.mobilize.net/vbuc/ewis/notes#id-2041
	''UPGRADE_TODO: (1050) Structure SECURITY_ATTRIBUTES may require marshalling attributes to be passed as an argument in this Declare statement. More Information: https://docs.mobilize.net/vbuc/ewis/todos#id-1050
	'Private Declare Function RegCreateKeyEx Lib "advapi32"  Alias "RegCreateKeyExA"(ByVal hKey As Integer, ByVal lpSubKey As String, ByVal Reserved As Integer, ByVal lpClass As String, ByVal dwOptions As Integer, ByVal samDesired As Integer, ByRef lpSecurityAttributes As BT2Support.UnsafeNative.Structures.SECURITY_ATTRIBUTES, ByRef phkResult As Integer, ByRef lpdwDisposition As Integer) As Integer

	'UPGRADE_NOTE: (2041) The following line was commented. More Information: https://docs.mobilize.net/vbuc/ewis/notes#id-2041
	'Private Declare Function ExpandEnvironmentStrings Lib "kernel32"  Alias "ExpandEnvironmentStringsA"(ByVal lpSrc As String, ByVal lpDst As String, ByVal nSize As Integer) As Integer

	'UPGRADE_NOTE: (2041) The following line was commented. More Information: https://docs.mobilize.net/vbuc/ewis/notes#id-2041
	'Private Declare Function RegCloseKey Lib "advapi32" (ByVal hKey As Integer) As Integer

	'UPGRADE_NOTE: (2041) The following line was commented. More Information: https://docs.mobilize.net/vbuc/ewis/notes#id-2041
	'Private Declare Function RegDeleteValue Lib "advapi32"  Alias "RegDeleteValueA"(ByVal hKey As Integer, ByVal lpValueName As String) As Integer

	'UPGRADE_NOTE: (2041) The following line was commented. More Information: https://docs.mobilize.net/vbuc/ewis/notes#id-2041
	'Private Declare Function RegEnumKey Lib "advapi32"  Alias "RegEnumKeyA"(ByVal hKey As Integer, ByVal dwIndex As Integer, ByVal lpName As String, ByVal cbName As Integer) As Integer

	'UPGRADE_NOTE: (2041) The following line was commented. More Information: https://docs.mobilize.net/vbuc/ewis/notes#id-2041
	'Private Declare Function RegEnumValue Lib "advapi32"  Alias "RegEnumValueA"(ByVal hKey As Integer, ByVal dwIndex As Integer, ByVal lpValueName As String, ByRef lpcbValueName As Integer, ByVal lpReserved As Integer, ByRef lpType As Integer, ByVal lpData As Integer, ByRef lpcbData As Integer) As Integer

	'UPGRADE_NOTE: (2041) The following line was commented. More Information: https://docs.mobilize.net/vbuc/ewis/notes#id-2041
	'Private Declare Function RegOpenKeyEx Lib "advapi32"  Alias "RegOpenKeyExA"(ByVal hKey As Integer, ByVal lpSubKey As String, ByVal ulOptions As Integer, ByVal samDesired As Integer, ByRef phkResult As Integer) As Integer

	'UPGRADE_NOTE: (2041) The following line was commented. More Information: https://docs.mobilize.net/vbuc/ewis/notes#id-2041
	'Private Declare Function RegQueryValue Lib "advapi32"  Alias "RegQueryValueA"(ByVal hKey As Integer, ByVal lpSubKey As String, ByVal lpValue As String, ByRef lpcbValue As Integer) As Integer

	'UPGRADE_NOTE: (2041) The following line was commented. More Information: https://docs.mobilize.net/vbuc/ewis/notes#id-2041
	'Private Declare Function RegQueryValueEx Lib "advapi32"  Alias "RegQueryValueExA"(ByVal hKey As Integer, ByVal lpValueName As String, ByVal lpReserved As Integer, ByRef lpType As Integer, ByVal lpData As Integer, ByRef lpcbData As Integer) As Integer

	'UPGRADE_NOTE: (2041) The following line was commented. More Information: https://docs.mobilize.net/vbuc/ewis/notes#id-2041
	'Private Declare Function RegSetValueEx Lib "advapi32"  Alias "RegSetValueExA"(ByVal hKey As Integer, ByVal lpValueName As String, ByVal Reserved As Integer, ByVal dwType As Integer, ByVal lpData As Integer, ByVal cbData As Integer) As Integer

	' Calls to find actual file
	'UPGRADE_NOTE: (2041) The following line was commented. More Information: https://docs.mobilize.net/vbuc/ewis/notes#id-2041
	'Private Declare Function FindClose Lib "kernel32" (ByVal hFindFile As Integer) As Integer

	'UPGRADE_NOTE: (2041) The following line was commented. More Information: https://docs.mobilize.net/vbuc/ewis/notes#id-2041
	''UPGRADE_TODO: (1050) Structure WIN32_FIND_DATA may require marshalling attributes to be passed as an argument in this Declare statement. More Information: https://docs.mobilize.net/vbuc/ewis/todos#id-1050
	'Private Declare Function FindFirstFile Lib "kernel32"  Alias "FindFirstFileA"(ByVal lpFileName As String, ByRef lpFindFileData As BT2Support.UnsafeNative.Structures.WIN32_FIND_DATA) As Integer

	' Declarations to retrieve version information
	'UPGRADE_NOTE: (2041) The following line was commented. More Information: https://docs.mobilize.net/vbuc/ewis/notes#id-2041
	'Private Declare Function GetFileVersionInfo Lib "version"  Alias "GetFileVersionInfoA"(ByVal lptstrFilename As String, ByVal dwHandle As Integer, ByVal dwLen As Integer, ByRef lpData As Byte) As Integer

	'UPGRADE_NOTE: (2041) The following line was commented. More Information: https://docs.mobilize.net/vbuc/ewis/notes#id-2041
	'Private Declare Function GetFileVersionInfoSize Lib "version"  Alias "GetFileVersionInfoSizeA"(ByVal lptstrFilename As String, ByRef lpdwHandle As Integer) As Integer

	'UPGRADE_NOTE: (2041) The following line was commented. More Information: https://docs.mobilize.net/vbuc/ewis/notes#id-2041
	'Private Declare Function VerQueryValue Lib "version"  Alias "VerQueryValueA"(ByRef pBlock As Byte, ByVal lpSubBlock As String, ByRef lpBuffer As Integer, ByRef puLen As Integer) As Integer

	' Declaration to copy memory contents from one area to another
	'UPGRADE_NOTE: (2041) The following line was commented. More Information: https://docs.mobilize.net/vbuc/ewis/notes#id-2041
	'Private Declare Sub CopyMem Lib "kernel32"  Alias "RtlMoveMemory"(ByVal Destination As Integer, ByVal Source As Integer, ByVal Length As Integer)

	' Call to get the current mouse position
	'UPGRADE_NOTE: (2041) The following line was commented. More Information: https://docs.mobilize.net/vbuc/ewis/notes#id-2041
	''UPGRADE_TODO: (1050) Structure POINTAPI may require marshalling attributes to be passed as an argument in this Declare statement. More Information: https://docs.mobilize.net/vbuc/ewis/todos#id-1050
	'Private Declare Function GetCursorPos Lib "user32" (ByRef lpPoint As BT2Support.UnsafeNative.Structures.POINTAPI) As Integer

	' Call to translate short file path to long file path
	' (Win98 and Win2k and above only - see comments for the
	' GetLongFilePath_Legacy procedure)
	'UPGRADE_NOTE: (2041) The following line was commented. More Information: https://docs.mobilize.net/vbuc/ewis/notes#id-2041
	'Private Declare Function GetLongPathName Lib "kernel32" (ByRef pszShortPath As String, ByRef lpszLongPath As String, ByVal cchBuffer As Integer) As Integer

	' Call to determine OS version
	'UPGRADE_NOTE: (2041) The following line was commented. More Information: https://docs.mobilize.net/vbuc/ewis/notes#id-2041
	''UPGRADE_TODO: (1050) Structure OSVERSIONINFO may require marshalling attributes to be passed as an argument in this Declare statement. More Information: https://docs.mobilize.net/vbuc/ewis/todos#id-1050
	'Private Declare Function GetVersionExA Lib "kernel32" (ByRef lpVersionInformation As BT2Support.UnsafeNative.Structures.OSVERSIONINFO) As Short

	' Message box API declaration
	'UPGRADE_NOTE: (2041) The following line was commented. More Information: https://docs.mobilize.net/vbuc/ewis/notes#id-2041
	''UPGRADE_TODO: (1050) Structure MSGBOXPARAMS may require marshalling attributes to be passed as an argument in this Declare statement. More Information: https://docs.mobilize.net/vbuc/ewis/todos#id-1050
	'Private Declare Function MessageBoxIndirect Lib "user32"  Alias "MessageBoxIndirectA"(ByRef lpMsgBoxParams As BT2Support.UnsafeNative.Structures.MSGBOXPARAMS) As Integer

	' Declarations for system menu manipulations
	Private Const MF_BYCOMMAND As Integer = &H0
	Private Const CS_SYSMNU_HH_JUMP_TO_URL As Integer = 61439
	'UPGRADE_NOTE: (2041) The following line was commented. More Information: https://docs.mobilize.net/vbuc/ewis/notes#id-2041
	'Private Declare Function GetSystemMenu Lib "user32" (ByVal hwnd As Integer, ByVal bRevert As Integer) As Integer
	'UPGRADE_NOTE: (2041) The following line was commented. More Information: https://docs.mobilize.net/vbuc/ewis/notes#id-2041
	'Private Declare Function DeleteMenu Lib "user32" (ByVal hMenu As Integer, ByVal nPosition As Integer, ByVal wFlags As Integer) As Integer

	' Declaration to test for existence of HH window
	'UPGRADE_NOTE: (2041) The following line was commented. More Information: https://docs.mobilize.net/vbuc/ewis/notes#id-2041
	'Private Declare Function IsWindow Lib "user32" (ByVal hwnd As Integer) As Integer

	'local variable(s) to hold property value(s)
	Private mvarCHMFile As String = ""
	Private mvarHHALink As String = ""
	Private mvarHHDefaultURL As String = ""
	Private mvarHHInstalled As Boolean
	Private mvarHHKeyword As String = ""
	Private mvarHHMsgText As String = ""
	Private mvarHHMsgTitle As String = ""
	Private mvarHHShowOnTop As Boolean
	Private mvarHHTopicID As Integer
	Private mvarHHTopicURL As String = ""
	Private mvarHHWindow As String = ""
	Private mvarHHRegFileName As String = ""
	Private mvarHHRegFilePath As String = ""
	Private mvarHHRegFileExists As Boolean
	Private mvarHHPopupFile As String = ""
	Private mvarHHPopupType As PopupType
	Private mvarHHPopupText As String = ""
	Private mvarHHPopupID As Integer
	Private mvarHHPopupTextColor As Color
	Private mvarHHPopupBackColor As Color
	Private mvarHHPopupCustomTextColor As Integer
	Private mvarHHPopupCustomBackColor As Integer
	Private mvarHHPopupCustomColors As Boolean
	Private mvarHHPopupTextFont As String = ""
	Private mvarHHPopupTextSize As String = ""
	Private mvarHHPopupTextBold As Boolean
	Private mvarHHPopupTextItalic As Boolean
	Private mvarHHPopupTextUnderline As Boolean
	Private mvarHHCtrlPath As String = ""
	Private mvarHHVersion As String = ""
	Private mvarIEVersion As String = ""
	Private mvarHHFriendlyName As String = ""
	Private mvarIEFriendlyName As String = ""
	Private mvarHHWndHandle As Integer

	' Module-level variables
	Private strHTMLHelpPath As String = ""
	Private strWindow As String = ""
	Private strTopic As String = ""
	Private lngTopicID As Integer

	' ********************************************************
	'
	'  Methods
	'
	' ********************************************************

	Public Sub HHDeleteJumpURLSysMenu(ByVal HH_hWnd As Integer)


		Dim hsysmnu As Integer = BT2Support.SafeNative.user32.GetSystemMenu(HH_hWnd, False)
		BT2Support.SafeNative.user32.DeleteMenu(hsysmnu, CS_SYSMNU_HH_JUMP_TO_URL, MF_BYCOMMAND)

	End Sub

	Public Sub HHDisplayTopicURL(Optional ByVal CallingForm As Integer = 0)

		' Displays a specific topic via the HHTopicURL property

		Try

			Dim hwnd As Integer

			If Not ValidHHFile(mvarCHMFile) Then
				Exit Sub
			End If

			If Not EnsureFileExists(mvarCHMFile) Then
				Exit Sub
			End If

			If mvarHHWindow.Trim() = "" Then
				If mvarHHShowOnTop Then
					mvarHHWndHandle = BT2Support.SafeNative.hhctrl.htmlHelpTopic(CallingForm, mvarCHMFile, HH_DISPLAY_TOPIC, mvarHHTopicURL)
				Else
					mvarHHWndHandle = BT2Support.SafeNative.hhctrl.htmlHelpTopic(hwnd, mvarCHMFile, HH_DISPLAY_TOPIC, mvarHHTopicURL)
				End If
			Else
				If mvarHHShowOnTop Then
					mvarHHWndHandle = BT2Support.SafeNative.hhctrl.htmlHelpTopic(CallingForm, mvarCHMFile & ">" & mvarHHWindow, HH_DISPLAY_TOPIC, mvarHHTopicURL)
				Else
					mvarHHWndHandle = BT2Support.SafeNative.hhctrl.htmlHelpTopic(hwnd, mvarCHMFile & ">" & mvarHHWindow, HH_DISPLAY_TOPIC, mvarHHTopicURL)
				End If
			End If

		Catch

			Select Case Information.Err().Number
				Case 91
					MessageBoxExclamation("The HHDisplayContents method was called " &  _
					                      "without a form being specified, while HHShowOnTop " &  _
					                      "was set to True.")
					Exit Sub
				Case Else
					'UPGRADE_TODO: (1065) Error handling statement (Resume Next) could not be converted. More Information: https://docs.mobilize.net/vbuc/ewis/todos#id-1065
					UpgradeHelpers.Helpers.NotUpgradedHelper.NotifyNotUpgradedElement("Resume Next Statement")
			End Select
		End Try

	End Sub

	Public Sub HHDisplayTopicID(Optional ByVal CallingForm As Integer = 0)

		' Displays a specific topic via the HHTopicID property

		Try

			Dim hwnd As Integer

			If Not ValidHHFile(mvarCHMFile) Then
				Exit Sub
			End If

			If Not EnsureFileExists(mvarCHMFile) Then
				Exit Sub
			End If

			If mvarHHWindow.Trim() = "" Then
				If mvarHHShowOnTop Then
					mvarHHWndHandle = BT2Support.SafeNative.hhctrl.HTMLHelp(CallingForm, mvarCHMFile, HH_HELP_CONTEXT, mvarHHTopicID)
				Else
					mvarHHWndHandle = BT2Support.SafeNative.hhctrl.HTMLHelp(hwnd, mvarCHMFile, HH_HELP_CONTEXT, mvarHHTopicID)
				End If
			Else
				If mvarHHShowOnTop Then
					mvarHHWndHandle = BT2Support.SafeNative.hhctrl.HTMLHelp(CallingForm, mvarCHMFile & ">" & mvarHHWindow, HH_HELP_CONTEXT, mvarHHTopicID)
				Else
					mvarHHWndHandle = BT2Support.SafeNative.hhctrl.HTMLHelp(hwnd, mvarCHMFile & ">" & mvarHHWindow, HH_HELP_CONTEXT, mvarHHTopicID)
				End If
			End If

		Catch

			Select Case Information.Err().Number
				Case 91
					MessageBoxExclamation("The HHDisplayContents method was called " &  _
					                      "without a form being specified, while HHShowOnTop " &  _
					                      "was set to True.")
					Exit Sub
				Case Else
					'UPGRADE_TODO: (1065) Error handling statement (Resume Next) could not be converted. More Information: https://docs.mobilize.net/vbuc/ewis/todos#id-1065
					UpgradeHelpers.Helpers.NotUpgradedHelper.NotifyNotUpgradedElement("Resume Next Statement")
			End Select
		End Try

	End Sub

	Public Sub HHDisplaySearch(Optional ByVal CallingForm As Integer = 0)

		' Forces the Help window to display the Search tab

		Try

			Dim hwnd As Integer

			If Not ValidHHFile(mvarCHMFile) Then
				Exit Sub
			End If

			If Not EnsureFileExists(mvarCHMFile) Then
				Exit Sub
			End If

			Dim HH_FTS_QUERY As BT2Support.UnsafeNative.Structures.tagHH_FTS_QUERY = BT2Support.UnsafeNative.Structures.tagHH_FTS_QUERY.CreateInstance()

			With HH_FTS_QUERY
				'UPGRADE_WARNING: (2081) Len has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-2081
				.cbStruct = Marshal.SizeOf(HH_FTS_QUERY)
				.fUniCodeStrings = 0
				.pszSearchQuery = ""
				.iProximity = 0
				.fStemmedSearch = 0
				.fTitleOnly = 0
				.fExecute = 1
				.pszWindow = ""
			End With

			If mvarHHWindow.Trim() = "" Then
				If mvarHHShowOnTop Then
					mvarHHWndHandle = BT2Support.SafeNative.hhctrl.HTMLHelpCallSearch(CallingForm, mvarCHMFile, HH_DISPLAY_SEARCH, HH_FTS_QUERY)
				Else
					mvarHHWndHandle = BT2Support.SafeNative.hhctrl.HTMLHelpCallSearch(hwnd, mvarCHMFile, HH_DISPLAY_SEARCH, HH_FTS_QUERY)
				End If
			Else
				If mvarHHShowOnTop Then
					mvarHHWndHandle = BT2Support.SafeNative.hhctrl.HTMLHelpCallSearch(CallingForm, mvarCHMFile & ">" & mvarHHWindow, HH_DISPLAY_SEARCH, HH_FTS_QUERY)
				Else
					mvarHHWndHandle = BT2Support.SafeNative.hhctrl.HTMLHelpCallSearch(hwnd, mvarCHMFile & ">" & mvarHHWindow, HH_DISPLAY_SEARCH, HH_FTS_QUERY)
				End If
			End If

		Catch

			Select Case Information.Err().Number
				Case 91
					MessageBoxExclamation("The HHDisplayContents method was called " &  _
					                      "without a form being specified, while HHShowOnTop " &  _
					                      "was set to True.")
					Exit Sub
				Case Else
					'UPGRADE_TODO: (1065) Error handling statement (Resume Next) could not be converted. More Information: https://docs.mobilize.net/vbuc/ewis/todos#id-1065
					UpgradeHelpers.Helpers.NotUpgradedHelper.NotifyNotUpgradedElement("Resume Next Statement")
			End Select
		End Try
	End Sub

	Public Sub HHDisplayKeyword(Optional ByVal CallingForm As Integer = 0)

		' Displays a topic specified by the HHKeyword property.
		' This will search for a KLink keyword in the topics
		' themselves.  Also searches the entries of an Index
		' file (*.hhk) used in a tripane window.

		Try

			Dim hwnd As Integer

			If Not ValidHHFile(mvarCHMFile) Then
				Exit Sub
			End If

			If Not EnsureFileExists(mvarCHMFile) Then
				Exit Sub
			End If

			If mvarHHShowOnTop Then
				mvarHHWndHandle = BT2Support.SafeNative.hhctrl.htmlHelpTopic(CallingForm, mvarCHMFile, HH_DISPLAY_TOPIC, Nothing)
			Else
				mvarHHWndHandle = BT2Support.SafeNative.hhctrl.htmlHelpTopic(hwnd, mvarCHMFile, HH_DISPLAY_TOPIC, Nothing)
			End If

			Dim ALinkStruct As BT2Support.UnsafeNative.Structures.tagHH_AKLINK = BT2Support.UnsafeNative.Structures.tagHH_AKLINK.CreateInstance()

			'UPGRADE_WARNING: (2081) Len has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-2081
			ALinkStruct.cbStruct = Marshal.SizeOf(ALinkStruct)
			ALinkStruct.fReserved = False
			ALinkStruct.pszKeywords = mvarHHKeyword

			' Translate empty strings to Null strings
			If mvarHHDefaultURL = "" Then
				mvarHHDefaultURL = String.Empty
			End If

			If mvarHHMsgText = "" Then
				mvarHHMsgText = String.Empty
			End If

			If mvarHHMsgTitle = "" Then
				mvarHHMsgTitle = String.Empty
			End If

			' Set up the default topic to use if the
			' specified keyword is not found.  This is
			' set via the HHDefaultURL property.
			ALinkStruct.pszUrl = mvarHHDefaultURL

			' Set up the message box to display if the
			' specified keyword is not found.  These are
			' set via the HHMsgText and HHMshgTitle properties.
			ALinkStruct.pszMsgText = mvarHHMsgText
			ALinkStruct.pszMsgTitle = mvarHHMsgTitle

			' Use the HHWindow property if it's set.
			If mvarHHWindow.Trim() <> "" Then
				ALinkStruct.pszWindow = mvarHHWindow
			End If

			' Set to False to enable the default URL
			' and message box functions.
			ALinkStruct.fIndexOnFail = False

			If mvarHHShowOnTop Then
				mvarHHWndHandle = BT2Support.SafeNative.hhctrl.HTMLHelpKeyWord(CallingForm, mvarCHMFile, HH_KEYWORD_LOOKUP, ALinkStruct)
			Else
				mvarHHWndHandle = BT2Support.SafeNative.hhctrl.HTMLHelpKeyWord(hwnd, mvarCHMFile, HH_KEYWORD_LOOKUP, ALinkStruct)
			End If

		Catch

			Select Case Information.Err().Number
				Case 91
					MessageBoxExclamation("The HHDisplayKeyword method was called " &  _
					                      "without a form being specified, while HHShowOnTop " &  _
					                      "was set to True.")
					Exit Sub
				Case Else
					'UPGRADE_TODO: (1065) Error handling statement (Resume Next) could not be converted. More Information: https://docs.mobilize.net/vbuc/ewis/todos#id-1065
					UpgradeHelpers.Helpers.NotUpgradedHelper.NotifyNotUpgradedElement("Resume Next Statement")
			End Select
		End Try

	End Sub

	Public Sub HHDisplayIndex(Optional ByVal CallingForm As Integer = 0)

		' Force the Help window to display the Index file
		' (*.hhk) in the left pane

		Try

			Dim hwnd As Integer

			If Not ValidHHFile(mvarCHMFile) Then
				Exit Sub
			End If

			If Not EnsureFileExists(mvarCHMFile) Then
				Exit Sub
			End If

			If mvarHHWindow.Trim() = "" Then
				If mvarHHShowOnTop Then
					BT2Support.SafeNative.hhctrl.HTMLHelp(CallingForm, mvarCHMFile, HH_DISPLAY_INDEX, 0)
				Else
					BT2Support.SafeNative.hhctrl.HTMLHelp(hwnd, mvarCHMFile, HH_DISPLAY_INDEX, 0)
				End If
			Else
				If mvarHHShowOnTop Then
					mvarHHWndHandle = BT2Support.SafeNative.hhctrl.HTMLHelp(CallingForm, mvarCHMFile & ">" & mvarHHWindow, HH_DISPLAY_INDEX, 0)
				Else
					mvarHHWndHandle = BT2Support.SafeNative.hhctrl.HTMLHelp(hwnd, mvarCHMFile & ">" & mvarHHWindow, HH_DISPLAY_INDEX, 0)
				End If
			End If

		Catch

			Select Case Information.Err().Number
				Case 91
					MessageBoxExclamation("The HHDisplayContents method was called " &  _
					                      "without a form being specified, while HHShowOnTop " &  _
					                      "was set to True.")
					Exit Sub
				Case Else
					'UPGRADE_TODO: (1065) Error handling statement (Resume Next) could not be converted. More Information: https://docs.mobilize.net/vbuc/ewis/todos#id-1065
					UpgradeHelpers.Helpers.NotUpgradedHelper.NotifyNotUpgradedElement("Resume Next Statement")
			End Select
		End Try

	End Sub

	Public Sub HHDisplayContents(Optional ByVal CallingForm As Integer = 0)

		' Force the Help window to display the Contents file
		' (*.hhc) in the left pane

		Try

			Dim hwnd As Integer

			If Not ValidHHFile(mvarCHMFile) Then
				Exit Sub
			End If

			If Not EnsureFileExists(mvarCHMFile) Then
				Exit Sub
			End If

			If mvarHHWindow.Trim() = "" Then
				If mvarHHShowOnTop Then
					mvarHHWndHandle = BT2Support.SafeNative.hhctrl.HTMLHelp(CallingForm, mvarCHMFile, HH_DISPLAY_TOC, 0)
				Else
					mvarHHWndHandle = BT2Support.SafeNative.hhctrl.HTMLHelp(hwnd, mvarCHMFile, HH_DISPLAY_TOC, 0)
				End If
			Else
				If mvarHHShowOnTop Then
					mvarHHWndHandle = BT2Support.SafeNative.hhctrl.HTMLHelp(CallingForm, mvarCHMFile & ">" & mvarHHWindow, HH_DISPLAY_TOC, 0)
				Else
					mvarHHWndHandle = BT2Support.SafeNative.hhctrl.HTMLHelp(hwnd, mvarCHMFile & ">" & mvarHHWindow, HH_DISPLAY_TOC, 0)
				End If
			End If

		Catch

			Select Case Information.Err().Number
				Case 91
					MessageBoxExclamation("The HHDisplayContents method was called " &  _
					                      "without a form being specified, while HHShowOnTop " &  _
					                      "was set to True.")
					Exit Sub
				Case Else
					'UPGRADE_TODO: (1065) Error handling statement (Resume Next) could not be converted. More Information: https://docs.mobilize.net/vbuc/ewis/todos#id-1065
					UpgradeHelpers.Helpers.NotUpgradedHelper.NotifyNotUpgradedElement("Resume Next Statement")
			End Select
		End Try

	End Sub

	Public Sub HHDisplayALink(Optional ByVal CallingForm As Integer = 0)

		' Displays a topic specified by the HHALink property.

		Try

			Dim hwnd As Integer

			If Not ValidHHFile(mvarCHMFile) Then
				Exit Sub
			End If

			If Not EnsureFileExists(mvarCHMFile) Then
				Exit Sub
			End If

			Dim ALinkStruct As BT2Support.UnsafeNative.Structures.tagHH_AKLINK = BT2Support.UnsafeNative.Structures.tagHH_AKLINK.CreateInstance()

			'UPGRADE_WARNING: (2081) Len has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-2081
			ALinkStruct.cbStruct = Marshal.SizeOf(ALinkStruct)
			ALinkStruct.fReserved = False
			ALinkStruct.pszKeywords = mvarHHALink

			' Translate empty strings to Null strings
			If mvarHHDefaultURL = "" Then
				mvarHHDefaultURL = String.Empty
			End If

			If mvarHHMsgText = "" Then
				mvarHHMsgText = String.Empty
			End If

			If mvarHHMsgTitle = "" Then
				mvarHHMsgTitle = String.Empty
			End If

			' Set up the default topic to use if the
			' specified keyword is not found.  This is
			' set via the HHDefaultURL property.
			ALinkStruct.pszUrl = mvarHHDefaultURL

			' Set up the message box to display if the
			' specified keyword is not found.  These are
			' set via the HHMsgText and HHMshgTitle properties.
			ALinkStruct.pszMsgText = mvarHHMsgText
			ALinkStruct.pszMsgTitle = mvarHHMsgTitle

			' Use the HHWindow property if it's set.
			If mvarHHWindow.Trim() <> "" Then
				ALinkStruct.pszWindow = mvarHHWindow
			End If

			' Set to False to enable the default URL
			' and message box functions.
			ALinkStruct.fIndexOnFail = False

			If mvarHHShowOnTop Then
				mvarHHWndHandle = BT2Support.SafeNative.hhctrl.HTMLHelpKeyWord(CallingForm, mvarCHMFile, HH_ALINK_LOOKUP, ALinkStruct)
			Else
				mvarHHWndHandle = BT2Support.SafeNative.hhctrl.HTMLHelpKeyWord(hwnd, mvarCHMFile, HH_ALINK_LOOKUP, ALinkStruct)
			End If

		Catch

			Select Case Information.Err().Number
				Case 91
					MessageBoxExclamation("The HHDisplayContents method was called " &  _
					                      "without a form being specified, while HHShowOnTop " &  _
					                      "was set to True.")
					Exit Sub
				Case Else
					'UPGRADE_TODO: (1065) Error handling statement (Resume Next) could not be converted. More Information: https://docs.mobilize.net/vbuc/ewis/todos#id-1065
					UpgradeHelpers.Helpers.NotUpgradedHelper.NotifyNotUpgradedElement("Resume Next Statement")
			End Select
		End Try

	End Sub

	Public Sub HHRegister(ByRef FileToRegister As String)

		' Registers the specified HTML Help file in
		' HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\HTML Help

		Dim lngHandle, lngDisposition, lngLenData, lngResult As Integer
		Dim strValue As String = ""
		Dim secSecAttributes As New BT2Support.UnsafeNative.Structures.SECURITY_ATTRIBUTES()
		Dim intPosition, intLength As Integer

		If FileToRegister = "" Then Exit Sub

		If Not ValidHHFile(FileToRegister) Then Exit Sub

		HHCheckRegistry(FileToRegister)

		If mvarHHRegFileName <> "" Then

			' The file is registered to begin with,
			' so we need to say so and exit.
			MessageBoxInformation("The file " & FileToRegister & " is already registered.  " &  _
			                      "HHRegister will not be run as no action need be taken.")
			Exit Sub

		End If

		' Copy it to get the path later
		Dim strFilePath As String = FileToRegister

		If Not ValidHHFile(FileToRegister) Then
			Exit Sub
		Else

			If Not EnsureFileExists(FileToRegister) Then
				Exit Sub
			End If
			If (FileToRegister.IndexOf("\"c) + 1) = 0 Then
				MessageBoxExclamation("Cannot register " & FileToRegister & " without having a supplied path.""")
				Exit Sub
			Else
				' strip the file name itself off the path
				intPosition = 1

				Do While intPosition <> 0
					intLength = Strings.Len(FileToRegister)
					intPosition = (FileToRegister.IndexOf("\"c) + 1)
					FileToRegister = FileToRegister.Substring(Math.Max(FileToRegister.Length - (intLength - intPosition), 0))
				Loop 

				' Get the registered path
				strFilePath = strFilePath.Substring(0, Math.Min(Strings.Len(strFilePath) - Strings.Len(FileToRegister), strFilePath.Length))

				' Register it
				lngResult = 99

				lngResult = BT2Support.SafeNative.advapi32.RegCreateKeyEx(HKEY_LOCAL_MACHINE, "Software\Microsoft\Windows\HTML Help", 0, "", REG_OPTION_NON_VOLATILE, KEY_CREATE_SUB_KEY Or KEY_SET_VALUE, secSecAttributes, lngHandle, lngDisposition)

				If lngResult <> ERROR_SUCCESS Then
					GoTo WriteRegValueError
				End If

				strValue = strFilePath
				lngLenData = Strings.Len(strValue) + 1
				lngResult = BT2Support.SafeNative.advapi32.RegSetValueEx(lngHandle, FileToRegister, 0, REG_SZ, strValue, lngLenData)

				If lngResult = ERROR_SUCCESS Then
					lngResult = BT2Support.SafeNative.advapi32.RegCloseKey(lngHandle)
					Exit Sub
				End If

			End If
		End If

		HHCheckRegistry(FileToRegister)

		Exit Sub

WriteRegValueError:
		MessageBoxExclamation("HTML Help Class: HHRegister Error")

	End Sub

	Public Sub HHUnRegister(ByRef FileToUnRegister As String)

		' Deletes the entry for the specified HTML Help file from
		' HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\HTML Help

		Dim intLength As Integer
		Dim lngHandle As Integer

		If FileToUnRegister = "" Then Exit Sub

		If Not ValidHHFile(FileToUnRegister) Then Exit Sub

		HHCheckRegistry(FileToUnRegister)

		If mvarHHRegFileName = "" Then

			' The file isn't registered to begin with,
			' so we need to say so and exit.
			MessageBoxInformation("The file " & FileToUnRegister & " is not registered.  " &  _
			                      "HHUnRegister will not be run as no action need be taken.")

			Exit Sub

		End If

		' strip the file name itself off the path
		Dim intPosition As Integer = 1

		Do While intPosition <> 0
			intLength = Strings.Len(FileToUnRegister)
			intPosition = (FileToUnRegister.IndexOf("\"c) + 1)
			FileToUnRegister = FileToUnRegister.Substring(Math.Max(FileToUnRegister.Length - (intLength - intPosition), 0))
		Loop 

		' Delete the entry
		Dim lngResult As Integer = BT2Support.SafeNative.advapi32.RegOpenKeyEx(HKEY_LOCAL_MACHINE, "Software\Microsoft\Windows\HTML Help", 0, KEY_SET_VALUE, lngHandle)

		If lngResult = ERROR_SUCCESS Then
			lngResult = BT2Support.SafeNative.advapi32.RegDeleteValue(lngHandle, FileToUnRegister)
		End If

		HHCheckRegistry(FileToUnRegister)

	End Sub

	Public Function HHCheckRegistry(ByVal FileToCheck As String) As Boolean

		' Verifies the specified HTML Help file has been registered in
		' HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\HTML Help

		Dim result As Boolean = False
		Dim sValues As String = ""
		Dim intLength As Integer
		Dim boolResult As Boolean
		Dim intPosition As Integer
		Dim varRegValues As HH_REG_VALUES = HH_REG_VALUES.CreateInstance()

		' Reassign the file name so the original
		' doesn't become mangled
		Dim strTempFileName As String = FileToCheck

		If strTempFileName = "" Then
			Return result
		End If

		mvarHHRegFileExists = False

		Dim tempHHRegFilePath As String = ""
		Dim lpFindFileData As BT2Support.UnsafeNative.Structures.WIN32_FIND_DATA
		If Not ValidHHFile(strTempFileName) Then
			Return result
		Else
			' strip the file name itself off the path
			intPosition = 1

			Do While intPosition <> 0
				intLength = Strings.Len(strTempFileName)
				intPosition = (strTempFileName.IndexOf("\"c) + 1)
				strTempFileName = strTempFileName.Substring(Math.Max(strTempFileName.Length - (intLength - intPosition), 0))
			Loop 

			' Verify it
			varRegValues = EnumRegValue("HKLM", "Software\Microsoft\Windows\HTML Help", sValues, strTempFileName)

			With varRegValues
				If .pszFileName = strTempFileName Then

					' Load the verified file name into the HHRegFileName
					' property, and the registered path of the file into
					' the HHRegFilePath property.
					mvarHHRegFileName = .pszFileName
					tempHHRegFilePath = .pszFilePath.Substring(Math.Max(.pszFilePath.Length - (Strings.Len(.pszFilePath) - (.pszFilePath.IndexOf("="c) + 1)), 0))
					mvarHHRegFilePath = tempHHRegFilePath.Substring(0, Math.Min(Strings.Len(tempHHRegFilePath) - 2, tempHHRegFilePath.Length))

					'UPGRADE_WARNING: (1063) Arrays in structure lpFindFileData may need to be initialized before they can be used. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-1063
					lpFindFileData = BT2Support.UnsafeNative.Structures.WIN32_FIND_DATA.CreateInstance()

					' Verify the HTML Help file exists according to the
					' registry data.
					boolResult = EnsureFileExists(mvarHHRegFilePath & "\" & mvarHHRegFileName)

					If boolResult Then

						' If the file's in the registered location,
						' set HHRegFileExists to True.
						mvarHHRegFileExists = True

					End If
				Else

					' If the file isn't registered, clear the
					' HHRegFileName and HHRegFilePath properties.
					mvarHHRegFileName = ""
					mvarHHRegFilePath = ""

				End If
			End With

		End If

		Return result
	End Function

	Public Sub HHClose()

		' Closes all open HTML Help windows.  Be careful when
		' using this as it closes everything, not just the
		' HTML Help windows for this app.

		'UPGRADE_TODO: (1069) Error handling statement (On Error Resume Next) was converted to a pattern that might have a different behavior. More Information: https://docs.mobilize.net/vbuc/ewis/todos#id-1069
		Try

			Dim hwnd As Integer

			BT2Support.SafeNative.hhctrl.HTMLHelp(0, "", HH_CLOSE_ALL, 0)

		Catch exc As Exception
			NotUpgradedHelper.NotifyNotUpgradedElement("Resume in On-Error-Resume-Next Block")
		End Try

	End Sub

	Public Sub HHDisplayPopup(ByVal CallingForm As Integer)

		' Displays a text popup from any of three sources
		' and with a number of options

		If mvarHHPopupType = 0 Then
			Exit Sub
		End If

		Dim pPoint As New BT2Support.UnsafeNative.Structures.POINTAPI()
		Dim hPopup As BT2Support.UnsafeNative.Structures.tagHH_POPUP = BT2Support.UnsafeNative.Structures.tagHH_POPUP.CreateInstance()
		Dim rRect As New BT2Support.UnsafeNative.Structures.RECT()
		Dim strFontString As String = ""

		If mvarHHPopupType = PopupType.HH_CHM_POPUP Then

			' Check for a valid CHM if that option is selected

			If Not ValidHHFile(mvarCHMFile) Then
				Exit Sub
			End If

			If Not EnsureFileExists(mvarCHMFile) Then
				Exit Sub
			End If

		End If

		' Get the current mouse pointer position
		BT2Support.SafeNative.user32.GetCursorPos(pPoint)

		' Set the margins of the popup
		With rRect
			.Bottom = -1
			.Left = -1
			.Right = -1
			.Top = -1
		End With

		Dim strBold As String = "", strItalic As String = "", strUnderline As String = ""
		With hPopup
			'UPGRADE_WARNING: (2081) Len has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-2081
			.cbStruct = Marshal.SizeOf(hPopup)

			' Clear any previously used color scheme
			.clrForeground = Color.Black
			.clrBackground = Color.Black

			If mvarHHPopupType = PopupType.HH_RESOURCE_POPUP Then

				' Fudge the Resource function by actually
				' using HH_TEXT_POPUP
				'.pszText = My.Resources.ResourceManager.GetString("str" + CStr(mvarHHPopupID))
				.pszText = "Not implemented yet"
				.hinst = 0

			ElseIf mvarHHPopupType = PopupType.HH_TEXT_POPUP Then 

				.idString = 0

				' End the sub if no string is supplied
				If mvarHHPopupText = "" Then
					Exit Sub
				End If
				.pszText = mvarHHPopupText

			Else

				.idString = mvarHHPopupID
				.pszText = String.Empty

			End If

			' Match the popup coordinates to the current
			' mouse pointer coordinates
			.pt = pPoint

			If mvarHHPopupCustomColors Then
				.clrForeground = ColorTranslator.FromOle(mvarHHPopupCustomTextColor)
				.clrBackground = ColorTranslator.FromOle(mvarHHPopupCustomBackColor)
			Else
				.clrForeground = mvarHHPopupTextColor
				.clrBackground = mvarHHPopupBackColor
			End If

			.rcMargins = rRect


			If mvarHHPopupTextFont = "" Then
				mvarHHPopupTextFont = "Arial"
			End If

			If mvarHHPopupTextSize = "" Then
				mvarHHPopupTextSize = "10"
			End If

			If mvarHHPopupTextBold Then
				strBold = "Bold "
			Else
				strBold = ""
			End If

			If mvarHHPopupTextItalic Then
				strItalic = "Italic "
			Else
				strItalic = ""
			End If

			If mvarHHPopupTextUnderline Then
				strUnderline = "Underline"
			Else
				strUnderline = ""
			End If

			strFontString = mvarHHPopupTextFont & ", " &  _
			                mvarHHPopupTextSize & ", ascii, " &  _
			                strBold & strItalic & strUnderline

			.pszFont = strFontString

		End With

		Select Case mvarHHPopupType
			Case PopupType.HH_CHM_POPUP

				If Not ValidPopupFile(mvarHHPopupFile) Then
					Exit Sub
				Else
					BT2Support.SafeNative.hhctrl.htmlHelpTextPopup(CallingForm, mvarCHMFile & "::/" & mvarHHPopupFile, HH_DISPLAY_TEXT_POPUP, hPopup)
				End If

			Case PopupType.HH_RESOURCE_POPUP, PopupType.HH_TEXT_POPUP
				BT2Support.SafeNative.hhctrl.htmlHelpTextPopup(CallingForm, Nothing, HH_DISPLAY_TEXT_POPUP, hPopup)

			Case Else
				Exit Sub
		End Select

		' Clear the color and font scheme before the next use
		mvarHHPopupCustomTextColor = 0
		mvarHHPopupCustomBackColor = 0
		mvarHHPopupTextColor = Color.Black
		mvarHHPopupBackColor = Color.Black
		mvarHHPopupTextFont = "Arial"
		mvarHHPopupTextSize = "10"
		mvarHHPopupTextBold = False
		mvarHHPopupTextItalic = False
		mvarHHPopupTextUnderline = False

	End Sub

	Public Sub HHInvokeWhatsThisHelp(ByVal CallingForm As Integer)

		' Sets the mouse pointer to the What's This pointer.
		' When the left button is clicked again, What's This
		' is invoked for the control below the cursor.

		BT2Support.SafeNative.user32.DefWindowProc(CallingForm, WM_SYSCOMMAND, SC_CONTEXTHELP, 0)

	End Sub

	Public Function HHVerifyMinConfig(ByVal MinHHVersion As HHVersion_RenamedEnum, ByVal MinIEVersion As IEVersion_RenamedEnum) As Boolean

		' Verifies the minimum HTML Help and IE versions
		' as specified by the developer.

		Dim boolHHVerified, boolIEVerified As Boolean

		GetHHVersionSub()

		GetIEVersionSub()


		Select Case MinHHVersion
			Case HHVersion_RenamedEnum.HH_1_0
				If mvarHHVersion >= extHH_1_0 Then
					boolHHVerified = True
				End If
			Case HHVersion_RenamedEnum.HH_1_1
				If mvarHHVersion >= extHH_1_1 Then
					boolHHVerified = True
				End If
			Case HHVersion_RenamedEnum.HH_1_1A
				If mvarHHVersion >= extHH_1_1A Then
					boolHHVerified = True
				End If
			Case HHVersion_RenamedEnum.HH_1_1B
				If mvarHHVersion >= extHH_1_1B Then
					boolHHVerified = True
				End If
			Case HHVersion_RenamedEnum.HH_1_2
				If mvarHHVersion >= extHH_1_2 Then
					boolHHVerified = True
				End If
			Case HHVersion_RenamedEnum.HH_1_21
				If mvarHHVersion >= extHH_1_21 Then
					boolHHVerified = True
				End If
			Case HHVersion_RenamedEnum.HH_1_21A
				If mvarHHVersion >= extHH_1_21A Then
					boolHHVerified = True
				End If
			Case HHVersion_RenamedEnum.HH_1_22
				If mvarHHVersion >= extHH_1_22 Then
					boolHHVerified = True
				End If
			Case HHVersion_RenamedEnum.HH_1_3_WIN2K_BETA
				If mvarHHVersion >= extHH_1_3_WIN2K_BETA Then
					boolHHVerified = True
				End If
			Case HHVersion_RenamedEnum.HH_1_3_IE5_5_BETA
				If mvarHHVersion >= extHH_1_3_IE5_5_BETA Then
					boolHHVerified = True
				End If
			Case HHVersion_RenamedEnum.HH_1_3
				If mvarHHVersion >= extHH_1_3 Then
					boolHHVerified = True
				End If
			Case Else
				mvarHHVersion = extUNKNOWN
		End Select

		Select Case CStr(MinIEVersion)
			Case CStr(IEVersion_RenamedEnum.IE_3_0)
				If mvarIEVersion >= extIE_3_0 Then
					boolIEVerified = True
				End If
			Case CStr(IEVersion_RenamedEnum.IE_3_0_OSR2)
				If mvarIEVersion >= extIE_3_0_OSR2 Then
					boolIEVerified = True
				End If
			Case CStr(IEVersion_RenamedEnum.IE_3_01)
				If mvarIEVersion >= extIE_3_01 Then
					boolIEVerified = True
				End If
			Case CStr(IEVersion_RenamedEnum.IE_3_02)
				If mvarIEVersion >= extIE_3_02 Then
					boolIEVerified = True
				End If
			Case CStr(IEVersion_RenamedEnum.IE_4_0_PP2)
				If mvarIEVersion >= extIE_4_0_PP2 Then
					boolIEVerified = True
				End If
			Case CStr(IEVersion_RenamedEnum.IE_4_0)
				If mvarIEVersion >= extIE_4_0 Then
					boolIEVerified = True
				End If
			Case CStr(IEVersion_RenamedEnum.IE_4_01)
				If mvarIEVersion >= extIE_4_01 Then
					boolIEVerified = True
				End If
			Case CStr(IEVersion_RenamedEnum.IE_4_01_SP1)
				If mvarIEVersion >= extIE_4_01_SP1 Then
					boolIEVerified = True
				End If
			Case CStr(IEVersion_RenamedEnum.IE_4_01_SP2)
				If mvarIEVersion >= extIE_4_01_SP2 Then
					boolIEVerified = True
				End If
			Case CStr(IEVersion_RenamedEnum.IE_5_0_Beta1)
				If mvarIEVersion >= extIE_5_0_Beta1 Then
					boolIEVerified = True
				End If
			Case CStr(IEVersion_RenamedEnum.IE_5_0_Beta2)
				If mvarIEVersion >= extIE_5_0_Beta2 Then
					boolIEVerified = True
				End If
			Case CStr(IEVersion_RenamedEnum.IE_5_0)
				If mvarIEVersion >= extIE_5_0 Then
					boolIEVerified = True
				End If
			Case CStr(IEVersion_RenamedEnum.IE_5_0A)
				If mvarIEVersion >= extIE_5_0A Then
					boolIEVerified = True
				End If
			Case CStr(IEVersion_RenamedEnum.IE_5_0B)
				If mvarIEVersion >= extIE_5_0B Then
					boolIEVerified = True
				End If
			Case CStr(IEVersion_RenamedEnum.IE_5_0C)
				If mvarIEVersion >= extIE_5_0C Then
					boolIEVerified = True
				End If
			Case CStr(IEVersion_RenamedEnum.IE_5_0D)
				If mvarIEVersion >= extIE_5_0D Then
					boolIEVerified = True
				End If
			Case CStr(IEVersion_RenamedEnum.IE_5_Win2K_RC1)
				If mvarIEVersion >= extIE_5_Win2K_RC1 Then
					boolIEVerified = True
				End If
			Case CStr(IEVersion_RenamedEnum.IE_5_Win2K_RC2)
				If mvarIEVersion >= extIE_5_Win2K_RC2 Then
					boolIEVerified = True
				End If
			Case extIE_5_01
				If mvarIEVersion >= extIE_5_01 Then
					boolIEVerified = True
				End If
			Case extIE_5_5_PLAT_PREV
				If mvarIEVersion >= extIE_5_5_PLAT_PREV Then
					boolIEVerified = True
				End If
			Case Else
				mvarIEVersion = extUNKNOWN
		End Select

		GetHHFriendlyNameSub()
		GetIEFriendlyNameSub()

		Return boolHHVerified And boolIEVerified

	End Function

	Public Function EnsureFileExists(ByRef FileToFind As String) As Boolean

		' Ensures the specified file exists in its specified location

		'UPGRADE_WARNING: (1063) Arrays in structure lpFindFileData may need to be initialized before they can be used. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-1063
		Dim result As Boolean = False
		Dim lpFindFileData As BT2Support.UnsafeNative.Structures.WIN32_FIND_DATA = BT2Support.UnsafeNative.Structures.WIN32_FIND_DATA.CreateInstance()

		result = True

		If (FileToFind.IndexOf("\"c) + 1) = 0 Then
			' Check to see if the file is registered
			HHCheckRegistry(FileToFind)

			If mvarHHRegFileName <> "" Then
				' If it's registered, use the registry info
				FileToFind = mvarHHRegFilePath & mvarHHRegFileName
			Else
				' Otherwise, assume it's in App.Path
				FileToFind = My.Application.Info.DirectoryPath & "\" & FileToFind
			End If
		End If

		Dim lngHandle As Integer = BT2Support.SafeNative.kernel32.FindFirstFile(FileToFind, lpFindFileData)

		If (lngHandle) = INVALID_HANDLE_VALUE Then

			MessageBoxExclamation("The file " & FileToFind & " does not exist." & Strings.Chr(10).ToString() &  _
			                      "Please make sure the correct path and file name have been specified.")

			result = False

		Else

			BT2Support.SafeNative.kernel32.FindClose(lngHandle)

		End If

		Return result
	End Function

	' ********************************************************
	'
	' Helper Functions
	'
	' ********************************************************

	Public Function HHSetHelpFile(ByVal intSelHelpFile As Integer) As String

		' Set the string variable to
		' include the application path
		Dim result As String = ""
		Select Case intSelHelpFile
			Case 1
				result = My.Application.Info.DirectoryPath & "\Library.chm"
			Case 2
				' Popup text file for the above CHM
				result = "Library.txt"
			Case Else
				' list other HTML Help files here
		End Select

		Return result
	End Function

	Private Function GetVersionInfo(ByVal FileName As String) As String

		' Retrieves the file version information for
		' the specified file

		Dim result As String = ""
		Dim varVersionHwnd As Integer
		Dim ffi As New VS_FIXEDFILEINFO()
		Dim ffiAddr, ffiLen As Integer

		Dim varVersionSize As Integer = BT2Support.SafeNative.version.GetFileVersionInfoSize(FileName, varVersionHwnd)
		If varVersionSize > 64000 Then varVersionSize = 64000

		Dim bytVerBuf(varVersionSize + 1) As Byte

		Dim lngResult As Integer = BT2Support.SafeNative.version.GetFileVersionInfo(FileName, varVersionHwnd, varVersionSize, bytVerBuf(0))
		Dim di As Integer = BT2Support.SafeNative.version.VerQueryValue(bytVerBuf(0), "\", ffiAddr, ffiLen)

		'UPGRADE_WARNING: (2081) Len has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-2081
		BT2Support.SafeNative.kernel32.CopyMem(ffi, ffiAddr, Marshal.SizeOf(ffi))

		result = ffi.dwFileVersionMSh.ToString() & "." &  _
		         StringsHelper.Format(ffi.dwFileVersionMSl, "00") & "."

		If ffi.dwFileVersionLSh > 0 Then
			Return result & StringsHelper.Format(ffi.dwFileVersionLSh, "00") & "." &  _
			                                     StringsHelper.Format(ffi.dwFileVersionLSl, "00")
		Else
			Return result & StringsHelper.Format(ffi.dwFileVersionLSl, "0000")
		End If

	End Function

	Private Function ValidHHFile(ByVal FileToVerify As String) As Boolean

		' Verifies the suffix for the specified CHM
		' Note this procedure does not verify actual CHM

		Dim result As Boolean = False
		result = True

		If FileToVerify.Substring(Math.Max(FileToVerify.Length - 3, 0)) <> "chm" Then
			MessageBoxExclamation(FileToVerify & " is not a valid HTML Help file.")
			Return result
		End If

		Return result
	End Function

	Private Function ValidPopupFile(ByVal FileToVerify As String) As Boolean

		' Verifies the suffix for the specified popup text file
		' Note this procedure does not verify actual popup text file

		Dim result As Boolean = False
		result = True

		If FileToVerify.Substring(Math.Max(FileToVerify.Length - 3, 0)) <> "txt" Then
			MessageBoxExclamation("The file specified as the text popup source, '" &  _
			                      FileToVerify & "', is not a valid popup file.")
			Return result
		End If

		Return result
	End Function

	Private Function EnumRegValue(ByVal strTopKey As String, ByVal strSubKey As String, ByRef strValues As String, ByVal FileToCheck As String) As HH_REG_VALUES

		' Enumerates registry values

		Dim result As HH_REG_VALUES = HH_REG_VALUES.CreateInstance()
		Dim strTempFileName As String = ""
		Dim lngTopKey, lngHandle, lngResult, lngValueLen, lngIndex, lngValueType, lngData, lngDataLen As Integer
		Dim boolDone As Boolean
		Dim strValueName As String = "", strValue As String = "", strValueEx As String = ""
		Dim HHRegValues As HH_REG_VALUES = HH_REG_VALUES.CreateInstance()

		Try

			' Reassign the file name so the original
			' doesn't become mangled
			strTempFileName = FileToCheck

			' Clear any previous result
			result.pszFileName = ""
			result.pszFilePath = ""

			lngResult = 99
			lngTopKey = RegKeyID(strTopKey)

			If lngTopKey = 0 Then Throw New Exception()

			lngResult = BT2Support.SafeNative.advapi32.RegOpenKeyEx(lngTopKey, strSubKey, 0, KEY_QUERY_VALUE, lngHandle)
			If lngResult <> ERROR_SUCCESS Then Throw New Exception()

			Do While Not boolDone

				lngDataLen = MAX_SIZE
				lngValueLen = lngDataLen
				strValueName = New String(" "c, lngDataLen)

				lngResult = BT2Support.SafeNative.advapi32.RegEnumValue(lngHandle, lngIndex, strValueName, lngValueLen, 0, lngValueType, lngData, lngDataLen)

				If lngResult = ERROR_SUCCESS Then

					Select Case lngValueType
						Case REG_SZ, REG_EXPAND_SZ
							strValue = New String(" "c, lngDataLen)
							strValueName = strValueName.Substring(0, Math.Min(lngValueLen, strValueName.Length))

							If strValueName = strTempFileName Then
								HHRegValues.pszFileName = strTempFileName
								lngResult = BT2Support.SafeNative.advapi32.RegQueryValueEx(lngHandle, strValueName, 0, lngValueType, strValue, lngDataLen)

								If lngValueType = REG_EXPAND_SZ Then
									strValueEx = strValue
									strValue = New String(" ", MAX_SIZE)
									lngValueLen = BT2Support.SafeNative.kernel32.ExpandEnvironmentStrings(strValueEx, strValue, MAX_SIZE)
								End If

								If lngResult = ERROR_SUCCESS Then
									strValues = strValues & strValueName &  _
									            "=" & strValue & Constants.vbCr
									HHRegValues.pszFilePath = strValues

								Else
									Throw New Exception()
								End If

								GoTo ExitRoutine

							End If

						Case Else
					End Select

					lngIndex += 1

				Else
					boolDone = True

				End If
			Loop 

ExitRoutine:
			strValues = strValues & Constants.vbCr
			If Strings.Len(strValues) = 1 Then strValues = strValues & Constants.vbCr

			lngResult = BT2Support.SafeNative.advapi32.RegCloseKey(lngHandle)
			result = HHRegValues

			' Clear any previous arguments
			strTopKey = ""
			strSubKey = ""
			strValues = ""
			strTempFileName = ""

		Catch

			result = HHRegValues
		End Try

		Return result
	End Function

	Private Function GetKeyInfo(ByVal key_name As String, ByVal indent As Integer) As Boolean

		' Used with HHInstalled method to verify whether or not
		' HTML Help is installed on the system.

		Dim result As Boolean = False
		Dim subkey_name As String = "", subkey_value As String = ""
		Dim Length, hKey As Integer
		Dim txt As New StringBuilder()

		result = True

		Dim subkeys As New OrderedDictionary()
		Dim subkey_values As New OrderedDictionary()

		If BT2Support.SafeNative.advapi32.RegOpenKeyEx(HKEY_LOCAL_MACHINE, key_name, 0, KEY_ALL_ACCESS, hKey) <> ERROR_SUCCESS Then
			Return False
		End If

		Dim subkey_num As Integer = 0
		Do 
			Length = 256
			subkey_name = New String(" "c, Length)

			If BT2Support.SafeNative.advapi32.RegEnumKey(hKey, subkey_num, subkey_name, Length) <> ERROR_SUCCESS Then Exit Do

			subkey_num += 1

			subkey_name = subkey_name.Substring(0, Math.Min(subkey_name.IndexOf(Strings.Chr(0).ToString()), subkey_name.Length))
			subkeys.Add(Guid.NewGuid().ToString(), subkey_name)

			Length = 256
			subkey_value = New String(" "c, Length)
			If BT2Support.SafeNative.advapi32.RegQueryValue(hKey, subkey_name, subkey_value, Length) <> ERROR_SUCCESS Then
				subkey_values.Add(Guid.NewGuid().ToString(), "Error")
			Else
				subkey_value = subkey_value.Substring(0, Math.Min(Length - 1, subkey_value.Length))
				subkey_values.Add(Guid.NewGuid().ToString(), subkey_value)
			End If
		Loop 

		If BT2Support.SafeNative.advapi32.RegCloseKey(hKey) <> ERROR_SUCCESS Then
			result = False
		End If

		For subkey_num = 1 To subkeys.Count
			txt.Append(CStr(subkeys(subkey_num - 1)) &  _
			           ": " & CStr(subkey_values(subkey_num - 1)) &  _
			           Environment.NewLine)
		Next subkey_num

		Return result
	End Function

	Private Function RegKeyID(ByVal strTopKeyOrFile As String) As Integer

		' Translates the registry key constants

		Dim result As Integer = 0
		Dim strDir As String = ""

		Select Case strTopKeyOrFile.ToUpper()
			Case "HKCU"
				result = HKEY_CURRENT_USER
			Case "HKLM"
				result = HKEY_LOCAL_MACHINE
			Case "HKU"
				result = HKEY_USERS
			Case "HKDD"
				result = HKEY_DYN_DATA
			Case "HKCC"
				result = HKEY_CURRENT_CONFIG
			Case "HKCR"
				result = HKEY_CLASSES_ROOT
			Case Else
				'UPGRADE_TODO: (1069) Error handling statement (On Error Resume Next) was converted to a pattern that might have a different behavior. More Information: https://docs.mobilize.net/vbuc/ewis/todos#id-1069
				Try
					'UPGRADE_WARNING: (2099) Return value for Dir has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-2099
					strDir = FileSystem.Dir(strTopKeyOrFile)
					If Information.Err().Number = 0 And strDir <> "" Then result = 1

				Catch exc As Exception
					NotUpgradedHelper.NotifyNotUpgradedElement("Resume in On-Error-Resume-Next Block")
				End Try
		End Select
		Return result

	End Function

	Private Function GetLongPath_Legacy(ByVal strShortName As String) As String

		' Translates a short path name into its actual long path
		' name.  On Windows 98 and 2000 systems and later, uses
		' the GetLongPathName API call in kernel32.  This is used
		' on these systems as it renders a slightly faster
		' processing time. GetLongPath_Legacy is set up to make it
		' compatible with the GetLongPathName API call:
		'
		' strShortName:
		'     Pointer to a null-terminated path to be converted.
		' strLongName:
		'     Pointer to the buffer to receive the long path.
		' lngBufferLength:
		'     Specifies the size of the buffer, in characters.

		' If the function succeeds, the return value is strLongName

		Dim result As String = ""
		Dim strLongName As String = ""
		Try

			Dim lngResult As Integer
			Dim strTempLongName As String = "", strTemp As String = "", strPathTemp As String = ""
			Dim intLength, intPosition, intStart As Integer
			Dim lngHandle As Integer
			'UPGRADE_WARNING: (1063) Arrays in structure lpFindFileData may need to be initialized before they can be used. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-1063
			Dim lpFindFileData As BT2Support.UnsafeNative.Structures.WIN32_FIND_DATA = BT2Support.UnsafeNative.Structures.WIN32_FIND_DATA.CreateInstance()

			' If it's already a long name, don't worry about it.
			' The GetLongPathName API call will hiccup if we don't
			' do this.
			If (strShortName.IndexOf("~"c) + 1) = 0 Then
				Return strShortName
			End If

			If GetWindowsVersion() >= WINDOWS_98 Then
				' For Windows 98 and later, and Windows 2000
				' and later, use the following API call:
				BT2Support.SafeNative.kernel32.GetLongPathName(strShortName, strLongName, 256)
				Return strLongName
			End If

			result = ""

			' If stored in the registry, in some cases it's
			' enclosed in double-quotes, so we need to delete them
			If strShortName.StartsWith(SINGLE_QUOTE, StringComparison.Ordinal) Then strShortName = strShortName.Substring(Math.Max(strShortName.Length - (Strings.Len(strShortName) - 1), 0))
			If strShortName.Substring(Math.Max(strShortName.Length - 1, 0)) = SINGLE_QUOTE Then strShortName = strShortName.Substring(0, Math.Min(Strings.Len(strShortName) - 1, strShortName.Length))

			' Add \ to short name to prevent Instr from failing
			If strShortName.Substring(Math.Max(strShortName.Length - 1, 0)) <> "\" Then strShortName = strShortName.Substring(0, Math.Min(CInt(CStr(Strings.Len(strShortName)) & "\"), strShortName.Length))

			' Save the drive letter for later
			strLongName = strShortName.Substring(0, Math.Min(2, strShortName.Length))

			' Strip the drive letter off the temporary string
			strPathTemp = strShortName.Substring(Math.Max(strShortName.Length - (Strings.Len(strShortName) - 3), 0))

			' Find the first backslash
			intPosition = (strPathTemp.IndexOf("\"c) + 1)

			Do While intPosition <> 0

				' Get the individual component of the path name
				strTemp = strPathTemp.Substring(0, Math.Min(intPosition - 1, strPathTemp.Length))

				' Translate the short path component into its
				' actual long path component as found by FindFirstFile
				lngHandle = BT2Support.SafeNative.kernel32.FindFirstFile(strLongName & "\" & strTemp, lpFindFileData)

				If (lngHandle) = INVALID_HANDLE_VALUE Then

					' The folder or file does not exist
					Return result

				End If

				' Get rid of any null characters retrieved if
				' from the registry
				strTempLongName = StripNulls(lpFindFileData.cFileName)

				' Build the long path name, starting with the
				' previously-saved drive letter
				strLongName = strLongName & "\" & strTempLongName

				' Delete the short path component we just used
				strPathTemp = strPathTemp.Substring(Math.Max(strPathTemp.Length - (Strings.Len(strPathTemp) - (Strings.Len(strTemp) + 1)), 0))

				' Find the next backslash
				intPosition = (strPathTemp.IndexOf("\"c) + 1)

			Loop 

			' Add the remainder, which is the name of the file

			Return strLongName & "\" & strPathTemp

		Catch

			Select Case Information.Err().Number
				Case 52
					strLongName = ""
					Return result
				Case Else
					'UPGRADE_TODO: (1065) Error handling statement (Resume Next) could not be converted. More Information: https://docs.mobilize.net/vbuc/ewis/todos#id-1065
					UpgradeHelpers.Helpers.NotUpgradedHelper.NotifyNotUpgradedElement("Resume Next Statement")
			End Select
		End Try
		Return result
	End Function

	Private Function StripNulls(ByRef OriginalStr As String) As String

		' Strips any trailing nulls from path names retrieved
		' from the registry. This function is found in the
		' following Microsoft(r) knowledge base articles:
		' Q183009 "HOWTO: Enumerate Windows Using the WIN32 API"
		' Q185476 "HOWTO: Search Directories to Find or List Files"
		' Q190218 "HOWTO: Retrieve Settings From a Printer Driver"

		If OriginalStr.IndexOf(Strings.Chr(0).ToString()) >= 0 Then
			OriginalStr = OriginalStr.Substring(0, Math.Min(OriginalStr.IndexOf(Strings.Chr(0).ToString()), OriginalStr.Length))
		End If

		Return OriginalStr

	End Function

	Private Sub GetHHVersionSub()

		' Retrieves the version of HTML Help on the system

		Dim sHHValues As String = "", strTempHHctrlPath As String = "", strHHctrlPath As String = ""

		' Get the path of the registered copy of hhctrl.ocx
		Dim varHHRegValues As HH_REG_VALUES = EnumRegValue("HKCR", "CLSID\{4662DAB0-D393-11D0-9A56-00C04FB68B66}\InprocServer32", sHHValues, "")

		' If hhctrl.ocx isn't registered, go past the next block.
		Dim lpFindFileData As BT2Support.UnsafeNative.Structures.WIN32_FIND_DATA
		Dim lngHandle As Integer
		If Strings.Len(varHHRegValues.pszFilePath) = 0 Then
			MessageBoxCritical("Hhctrl.ocx is not registered.  " &  _
			                   "Please install HTML Help.")

		Else
			strHHctrlPath = varHHRegValues.pszFilePath.Substring(Math.Max(varHHRegValues.pszFilePath.Length - (Strings.Len(varHHRegValues.pszFilePath) - 1), 0))

			'UPGRADE_WARNING: (1063) Arrays in structure lpFindFileData may need to be initialized before they can be used. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-1063
			lpFindFileData = BT2Support.UnsafeNative.Structures.WIN32_FIND_DATA.CreateInstance()

			strTempHHctrlPath = StripNulls(strHHctrlPath)

			' Translate short path name if registered that way
			strHHctrlPath = GetLongPath_Legacy(strTempHHctrlPath)

			' Verify the HTML Help control exists according
			' to the registry data.
			lngHandle = BT2Support.SafeNative.kernel32.FindFirstFile(strHHctrlPath, lpFindFileData)

			If (lngHandle) = INVALID_HANDLE_VALUE Then
				MessageBoxCritical("Hhctrl.ocx is not in its registered location.  " &  _
				                   "Please reinstall HTML Help.")
				Exit Sub

			End If

			mvarHHVersion = GetVersionInfo(strHHctrlPath)

		End If

	End Sub

	Private Sub GetIEVersionSub()

		' Retrieves the version of Internet Explorer on the system

		Dim sIEValues As String = "", strShdocvwPath As String = ""
		Dim lngHandle As Integer
		'UPGRADE_WARNING: (1063) Arrays in structure lpFindFileData may need to be initialized before they can be used. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-1063
		Dim lpFindFileData As BT2Support.UnsafeNative.Structures.WIN32_FIND_DATA = BT2Support.UnsafeNative.Structures.WIN32_FIND_DATA.CreateInstance()

		' Get the path of the registered copy of shdocvw.dll
		Dim varIERegValues As HH_REG_VALUES = EnumRegValue("HKCR", "CLSID\{0A89A860-D7B1-11CE-8350-444553540000}\InProcServer32", sIEValues, "")

		' If shdocvw.dll isn't registered, go past the next block.
		If Strings.Len(varIERegValues.pszFilePath) = 0 Then
			MessageBoxCritical("Shdocvw.dll is not registered.  " &  _
			                   "Please install Internet Explorer.")
		Else

			strShdocvwPath = varIERegValues.pszFilePath.Substring(Math.Max(varIERegValues.pszFilePath.Length - (Strings.Len(varIERegValues.pszFilePath) - 1), 0))

			' Translate short path name if registered that way
			strShdocvwPath = GetLongPath_Legacy(StripNulls(strShdocvwPath))

			' Verify shdocvw.dll exists according
			' to the registry data.
			lngHandle = BT2Support.SafeNative.kernel32.FindFirstFile(strShdocvwPath, lpFindFileData)

			If (lngHandle) = INVALID_HANDLE_VALUE Then
				MessageBoxCritical("Internet Explorer is not in its registered location.  " &  _
				                   "Please reinstall Internet Explorer.")
				Exit Sub

			End If

			mvarIEVersion = GetVersionInfo(strShdocvwPath)

		End If

	End Sub

	Private Function GetHHFriendlyNameSub() As String

		' Retrieves the friendly name of HTML Help as installed

		If mvarHHVersion = "" Then
			GetHHVersionSub()
		End If
		' Take into account how this module
		' returns version numbers
		Select Case mvarHHVersion
			Case "4.72.7290.00"
				mvarHHFriendlyName = "1.0"
			Case "4.72.7323.00"
				mvarHHFriendlyName = "1.1"
			Case "4.72.7325.00"
				mvarHHFriendlyName = "1.1a"
			Case "4.72.8164.00"
				mvarHHFriendlyName = "1.1b"
			Case "4.73.8252.00"
				mvarHHFriendlyName = "1.2"
			Case "4.73.8412.00"
				mvarHHFriendlyName = "1.21"
			Case "4.73.8474.00"
				mvarHHFriendlyName = "1.21a"
			Case "4.73.8561.00"
				mvarHHFriendlyName = "1.22"
			Case "4.74.8566.00"
				mvarHHFriendlyName = "1.3 Windows 2000 Beta"
			Case "4.74.8637.00"
				mvarHHFriendlyName = "1.3 IE 5.5 Platform Preview Beta"
			Case "4.74.8702.00"
				mvarHHFriendlyName = "1.3"
			Case Else
				mvarHHFriendlyName = "unknown"
		End Select

	End Function

	Private Function GetIEFriendlyNameSub() As String

		' Retrieves the friendly name of Internet Explorer
		' as installed

		If mvarIEVersion = "" Then
			GetIEVersionSub()
		End If

		' Take into account how this module
		' returns version numbers
		Select Case mvarIEVersion
			Case "4.70.1155.0000"
				mvarIEFriendlyName = "3.0"
			Case "4.70.1158.0000"
				mvarIEFriendlyName = "3.0 OSR2"
			Case "4.70.1215.0000", "4.70.1300.0000"
				mvarIEFriendlyName = "3.02"
			Case "4.71.1008.3000"
				mvarIEFriendlyName = "4.0 PP2"
			Case "4.71.1712.5000"
				mvarIEFriendlyName = "4.0"
			Case "4.72.2106.7000"
				mvarIEFriendlyName = "4.01"
			Case "4.72.3110.0300"
				mvarIEFriendlyName = "4.0 SP1"
			Case "4.72.3612.1707"
				mvarIEFriendlyName = "4.0 SP2"
			Case "5.00.0518.5000"
				mvarIEFriendlyName = "5.0 beta 1"
			Case "5.00.0910.1308"
				mvarIEFriendlyName = "5.0 beta 2"
			Case "5.00.2014.2130"
				mvarIEFriendlyName = "5.0"
			Case "5.00.2314.1000"
				mvarIEFriendlyName = "5.0a (Office 2000)"
			Case "5.00.2614.3500"
				mvarIEFriendlyName = "5.0b (Windows 98 SE)"
			Case "5.00.2717.2000"
				mvarIEFriendlyName = "5.0c (Icon Security Issue Update)"
			Case "5.00.2721.1400"
				mvarIEFriendlyName = "5.0d (ImportExport Favorites Issue Update)"
			Case "5.00.2919.800"
				mvarIEFriendlyName = "5.x (Windows 2000 RC1, build 5.00.2072)"
			Case "5.00.2919.3800"
				mvarIEFriendlyName = "5.x (Windows 2000 RC2, build 5.00.2128)"
			Case "5.00.2919.6307"
				mvarIEFriendlyName = "5.01"
			Case "5.50.3825.1300"
				mvarIEFriendlyName = "5.5 Platform Preview"
			Case Else
				mvarIEFriendlyName = "unknown"
		End Select

	End Function

	Private Function GetWindowsVersion() As Integer

		'UPGRADE_WARNING: (1063) Arrays in structure osinfo may need to be initialized before they can be used. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-1063
		Dim result As Integer = 0
		Dim osinfo As BT2Support.UnsafeNative.Structures.OSVERSIONINFO = BT2Support.UnsafeNative.Structures.OSVERSIONINFO.CreateInstance()

		osinfo.dwOSVersionInfoSize = 148
		osinfo.szCSDVersion = StringsHelper.GetFixedLengthString(New String(" "c, 128), 128)
		Dim retvalue As Integer = BT2Support.SafeNative.kernel32.GetVersionExA(osinfo)

		With osinfo
			Select Case .dwPlatformId
				Case VER_PLATFORM_WIN32_WINDOWS
					If .dwMinorVersion = 0 Then
						result = WINDOWS_95
					ElseIf .dwMinorVersion = 10 Then 
						result = WINDOWS_98
					End If
				Case VER_PLATFORM_WIN32_NT
					If .dwMajorVersion = 3 Then
						result = WINDOWS_NT_3_51
					ElseIf .dwMajorVersion = 4 Then 
						result = WINDOWS_NT_4
					ElseIf .dwMajorVersion = 5 Then 
						result = WINDOWS_2000
					End If
				Case Else
					result = UNKNOWN_OS
			End Select
		End With

		Return result
	End Function

	Private Function MessageBoxCritical(ByVal strMessage As String) As Integer

		' Displays a message box with a "critical" icon

		Dim mbpParams As BT2Support.UnsafeNative.Structures.MSGBOXPARAMS = BT2Support.UnsafeNative.Structures.MSGBOXPARAMS.CreateInstance()

		'UPGRADE_WARNING: (2081) Len has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-2081
		mbpParams.cbSize = Marshal.SizeOf(mbpParams)
		mbpParams.dwStyle = MB_OK Or MB_ICONSTOP
		mbpParams.lpszCaption = "HTML Help Class"
		mbpParams.lpszText = strMessage

		Return BT2Support.SafeNative.user32.MessageBoxIndirect(mbpParams)

	End Function

	Private Function MessageBoxExclamation(ByVal strMessage As String) As Integer

		' Displays a message box with an "exclamation" icon

		Dim mbpParams As BT2Support.UnsafeNative.Structures.MSGBOXPARAMS = BT2Support.UnsafeNative.Structures.MSGBOXPARAMS.CreateInstance()

		'UPGRADE_WARNING: (2081) Len has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-2081
		mbpParams.cbSize = Marshal.SizeOf(mbpParams)
		mbpParams.dwStyle = MB_OK Or MB_ICONEXCLAMATION
		mbpParams.lpszCaption = "HTML Help Class"
		mbpParams.lpszText = strMessage

		Return BT2Support.SafeNative.user32.MessageBoxIndirect(mbpParams)

	End Function

	Private Function MessageBoxInformation(ByVal strMessage As String) As Integer

		' Displays a message box with an "information" icon

		Dim mbpParams As BT2Support.UnsafeNative.Structures.MSGBOXPARAMS = BT2Support.UnsafeNative.Structures.MSGBOXPARAMS.CreateInstance()

		'UPGRADE_WARNING: (2081) Len has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-2081
		mbpParams.cbSize = Marshal.SizeOf(mbpParams)
		mbpParams.dwStyle = MB_OK Or MB_ICONINFORMATION
		mbpParams.lpszCaption = "HTML Help Class"
		mbpParams.lpszText = strMessage

		Return BT2Support.SafeNative.user32.MessageBoxIndirect(mbpParams)

	End Function

	' ********************************************************
	'
	'  Properties
	'
	' ********************************************************


	Public Property HHWindow() As String
		Get

			Dim result As String = ""
			Try

				result = mvarHHWindow

			Catch
			End Try

			Return result
		End Get
		Set(ByVal Value As String)

			' Specifies the HTML Help window for use
			' with various methods.

			Try

				mvarHHWindow = Value

			Catch
			End Try

		End Set
	End Property


	Public Property HHTopicURL() As String
		Get

			Dim result As String = ""
			Try

				result = mvarHHTopicURL

			Catch
			End Try

			Return result
		End Get
		Set(ByVal Value As String)

			' Specifies the topic path and file name for the
			' HHDisplayTopicURL method

			mvarHHTopicURL = Value

		End Set
	End Property


	Public Property HHTopicID() As Integer
		Get

			Dim result As Integer = 0
			Try

				result = mvarHHTopicID

			Catch
			End Try

			Return result
		End Get
		Set(ByVal Value As Integer)

			' Specifies the context integer for the
			' HHDisplayTopicID method

			Try

				mvarHHTopicID = Value

			Catch
			End Try

		End Set
	End Property


	Public Property HHMsgTitle() As String
		Get

			Dim result As String = ""
			Try

				result = mvarHHMsgTitle

			Catch
			End Try

			Return result
		End Get
		Set(ByVal Value As String)

			' Specifies the title to display on a message box if
			' a keyword cannot be found

			Try

				mvarHHMsgTitle = Value

			Catch
			End Try

		End Set
	End Property


	Public Property HHMsgText() As String
		Get

			Dim result As String = ""
			Try

				result = mvarHHMsgText

			Catch
			End Try

			Return result
		End Get
		Set(ByVal Value As String)

			' Specifies the text to display in a message box if
			' a keyword cannot be found

			Try

				mvarHHMsgText = Value

			Catch
			End Try

		End Set
	End Property


	Public Property HHKeyword() As String
		Get

			Dim result As String = ""
			Try

				result = mvarHHKeyword

			Catch
			End Try

			Return result
		End Get
		Set(ByVal Value As String)

			' Specifies a keyword to search for using HHDisplayKeyword

			Try

				mvarHHKeyword = Value

			Catch
			End Try

		End Set
	End Property


	Public Property HHDefaultURL() As String
		Get

			Dim result As String = ""
			Try

				result = mvarHHDefaultURL

			Catch
			End Try

			Return result
		End Get
		Set(ByVal Value As String)

			' Specifies the URL to use if a keyword cannot be found

			Try

				mvarHHDefaultURL = Value

			Catch
			End Try

		End Set
	End Property


	Public Property HHALink() As String
		Get

			Dim result As String = ""
			Try

				result = mvarHHALink

			Catch
			End Try

			Return result
		End Get
		Set(ByVal Value As String)

			' Specifies an ALink keyword to search for using
			' HHDisplayALink

			Try

				mvarHHALink = Value

			Catch
			End Try

		End Set
	End Property


	Public Property CHMFile() As String
		Get

			Dim result As String = ""
			Try

				result = mvarCHMFile

			Catch
			End Try

			Return result
		End Get
		Set(ByVal Value As String)

			' Path and file name of the HTML Help file to display

			Try

				mvarCHMFile = Value

			Catch
			End Try

		End Set
	End Property


	Public Property HHShowOnTop() As Boolean
		Get

			Dim result As Boolean = False
			Try

				result = mvarHHShowOnTop

			Catch
			End Try

			Return result
		End Get
		Set(ByVal Value As Boolean)

			' If set to True, the HTML Help window will be set as
			' a sibling of the calling window

			Try

				mvarHHShowOnTop = Value

			Catch
			End Try

		End Set
	End Property

	Public ReadOnly Property HHRegFileName() As String
		Get

			' Used in conjunction with HHCheckRegistry,
			' returns the confirmed CHM file name

			Dim result As String = ""
			Try

				result = mvarHHRegFileName

			Catch
			End Try

			Return result
		End Get
	End Property

	Public ReadOnly Property HHRegFilePath() As String
		Get

			' Used in conjunction with HHCheckRegistry,
			' returns the path of the confirmed CHM file name

			Dim result As String = ""
			Try

				result = mvarHHRegFilePath

			Catch
			End Try

			Return result
		End Get
	End Property

	Public ReadOnly Property HHRegFileExists() As Boolean
		Get

			' Used in conjunction with HHCheckRegistry, returns
			' True if the file exists at the registered path,
			' False if it doesn't

			Dim result As Boolean = False
			Try

				result = mvarHHRegFileExists

			Catch
			End Try

			Return result
		End Get
	End Property

	Public WriteOnly Property HHPopupFile() As String
		Set(ByVal Value As String)

			' Specifies the text file containing the popup text as
			' listed in the [TEXT POPUPS] section of a CHM

			Try

				mvarHHPopupFile = Value

			Catch
			End Try

		End Set
	End Property

	Public WriteOnly Property HHPopupID() As Integer
		Set(ByVal Value As Integer)

			' Specifies the resource containing the to retrieve
			' popup text from as listed in a Visual Basic project
			' or the context integer of a popup topic as specified
			' in a valid popup file in a CHM

			Try

				mvarHHPopupID = Value

			Catch
			End Try

		End Set
	End Property

	Public WriteOnly Property HHPopupText() As String
		Set(ByVal Value As String)

			' Specifies the text to display in a simple text popup

			Try

				mvarHHPopupText = Value

			Catch
			End Try

		End Set
	End Property

	Public WriteOnly Property HHPopupType() As PopupType
		Set(ByVal Value As PopupType)

			' The type of popup to be generated by HHDisplayPopup

			Try

				mvarHHPopupType = Value

			Catch
			End Try

		End Set
	End Property

	Public WriteOnly Property HHPopupTextColor() As Color
		Set(ByVal Value As Color)

			' Sets the text color for a popup generated with HHDisplayPopup using
			' the standard VB color constants

			Try

				mvarHHPopupTextColor = Value

			Catch
			End Try

		End Set
	End Property

	Public WriteOnly Property HHPopupBackColor() As Color
		Set(ByVal Value As Color)

			' Sets the back color of a popup generated with HHDisplayPopup using
			' the standard VB color constants

			Try

				mvarHHPopupBackColor = Value

			Catch
			End Try

		End Set
	End Property

	Public WriteOnly Property HHPopupCustomTextColor() As Integer
		Set(ByVal Value As Integer)

			' Sets the text color for a popup generated with
			' HHDisplayPopup using custom colors in the form &HBBGGRR.

			Try

				mvarHHPopupCustomTextColor = Value

			Catch
			End Try

		End Set
	End Property

	Public WriteOnly Property HHPopupCustomBackColor() As Integer
		Set(ByVal Value As Integer)

			' Sets the back color of a popup generated with
			' HHDisplayPopup using custom colors in the form &HBBGGRR

			Try

				mvarHHPopupCustomBackColor = Value

			Catch
			End Try

		End Set
	End Property


	Public Property HHPopupCustomColors() As Boolean
		Get

			Dim result As Boolean = False
			Try

				result = mvarHHPopupCustomColors

			Catch
			End Try

			Return result
		End Get
		Set(ByVal Value As Boolean)

			' True of the HHPopupCustomTextColor and HHPopupCustomBackColor
			' are going to be used, False if not

			Try

				mvarHHPopupCustomColors = Value

			Catch
			End Try

		End Set
	End Property

	Public WriteOnly Property HHPopupTextFont() As String
		Set(ByVal Value As String)

			' Name of the font to be used in a text popup

			Try

				mvarHHPopupTextFont = Value

			Catch
			End Try

		End Set
	End Property

	Public WriteOnly Property HHPopupTextSize() As String
		Set(ByVal Value As String)

			' Point size of the font used in a text popup

			Try

				mvarHHPopupTextSize = Value

			Catch
			End Try

		End Set
	End Property

	Public WriteOnly Property HHPopupTextBold() As Boolean
		Set(ByVal Value As Boolean)

			' Set to True to make the popup text bold, False otherwise

			Try

				mvarHHPopupTextBold = Value

			Catch
			End Try

		End Set
	End Property

	Public WriteOnly Property HHPopupTextItalic() As Boolean
		Set(ByVal Value As Boolean)

			' Set to True to make the popup text italicized, False otherwise

			Try

				mvarHHPopupTextItalic = Value

			Catch
			End Try

		End Set
	End Property

	Public WriteOnly Property HHPopupTextUnderline() As Boolean
		Set(ByVal Value As Boolean)

			' Set to True to make the popup text underlined, False otherwise

			Try

				mvarHHPopupTextUnderline = Value

			Catch
			End Try

		End Set
	End Property

	Public ReadOnly Property HHInstalled() As Boolean
		Get

			' Verifies whether or not HTML Help is installed on
			' the system.  This is done by checking the existence of
			' HKEY_LOCAL_MACHINE\Software\CLASSES\TypeLib\{ADB880A2-D8FF-11CF-9377-00AA003B7A11}

			mvarHHInstalled = GetKeyInfo("SOFTWARE\Classes\TypeLib\{ADB880A2-D8FF-11CF-9377-00AA003B7A11}", 0)

			Return mvarHHInstalled

		End Get
	End Property

	Public ReadOnly Property HHVersion() As String
		Get

			' Returns the current version of HTML Help on the
			' system as a String expression

			'UPGRADE_TODO: (1069) Error handling statement (On Error Resume Next) was converted to a pattern that might have a different behavior. More Information: https://docs.mobilize.net/vbuc/ewis/todos#id-1069
			Dim result As String = ""
			Try

				GetHHVersionSub()

				result = mvarHHVersion

			Catch exc As Exception
				NotUpgradedHelper.NotifyNotUpgradedElement("Resume in On-Error-Resume-Next Block")
			End Try

			Return result
		End Get
	End Property

	Public ReadOnly Property IEVersion() As String
		Get

			' Returns the current version of Internet Explorer on
			' the system as a String expression

			'UPGRADE_TODO: (1069) Error handling statement (On Error Resume Next) was converted to a pattern that might have a different behavior. More Information: https://docs.mobilize.net/vbuc/ewis/todos#id-1069
			Dim result As String = ""
			Try

				GetIEVersionSub()

				result = mvarIEVersion

			Catch exc As Exception
				NotUpgradedHelper.NotifyNotUpgradedElement("Resume in On-Error-Resume-Next Block")
			End Try

			Return result
		End Get
	End Property

	Public ReadOnly Property HHFriendlyName() As String
		Get

			' Returns the friendly name of the HTML Help version
			' as a String expression (i.e, "1.21a")

			'UPGRADE_TODO: (1069) Error handling statement (On Error Resume Next) was converted to a pattern that might have a different behavior. More Information: https://docs.mobilize.net/vbuc/ewis/todos#id-1069
			Dim result As String = ""
			Try

				GetHHFriendlyNameSub()

				result = mvarHHFriendlyName

			Catch exc As Exception
				NotUpgradedHelper.NotifyNotUpgradedElement("Resume in On-Error-Resume-Next Block")
			End Try

			Return result
		End Get
	End Property

	Public ReadOnly Property IEFriendlyName() As String
		Get

			' Returns the friendly name of the Internet Explorer
			' version as a String expression (i.e, "5.0d")

			'UPGRADE_TODO: (1069) Error handling statement (On Error Resume Next) was converted to a pattern that might have a different behavior. More Information: https://docs.mobilize.net/vbuc/ewis/todos#id-1069
			Dim result As String = ""
			Try

				GetIEFriendlyNameSub()

				result = mvarIEFriendlyName

			Catch exc As Exception
				NotUpgradedHelper.NotifyNotUpgradedElement("Resume in On-Error-Resume-Next Block")
			End Try

			Return result
		End Get
	End Property

	Public ReadOnly Property HHWndHandle() As Integer
		Get

			' Returns the handle of the HTML Help window
			' opened by one of the HHDisplay* methods
			' except HHDisplayPopup

			Dim result As Integer = 0
			If mvarHHWndHandle = 0 Then
				MessageBoxInformation("No HTML Help window handle to retrieve.")
				Return result
			End If

			'UPGRADE_TODO: (1069) Error handling statement (On Error Resume Next) was converted to a pattern that might have a different behavior. More Information: https://docs.mobilize.net/vbuc/ewis/todos#id-1069
			Try

				If BT2Support.SafeNative.user32.IsWindow(mvarHHWndHandle) Then
					result = mvarHHWndHandle
				Else
					MessageBoxInformation("The last HTML Help window opened has been closed.")
					mvarHHWndHandle = 0
					result = mvarHHWndHandle
				End If

			Catch exc As Exception
				NotUpgradedHelper.NotifyNotUpgradedElement("Resume in On-Error-Resume-Next Block")
			End Try

			Return result
		End Get
	End Property
End Class