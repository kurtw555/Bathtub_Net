Option Strict Off
Option Explicit On
Imports System
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Reflection
Imports System.Windows.Forms
Imports Microsoft.Office.Interop.Excel
Imports UpgradeHelpers.Gui.Controls
Imports UpgradeHelpers.Helpers
Imports Excel = Microsoft.Office.Interop.Excel
Module Module1

    ' BathTub Version 6.14e
    ' This uses Microsoft Excel 12.0 Object Library (see References under the Project Tab)
    ' However 12.0 is NOT fully compatible with newer versions of Excel like 16 (see below)
    ' Nov 2016. cmbVariable on frmResponse form is NOT responding to user selections with
    ' Excel ver 16
    ' April 2015 Image1 in frmResponse is not getting refreshed with NEW gif file
    ' when user runs a new response.
    ' April 2013 Excel object ignores Add(after), so SheetCopy needed logic reworked,
    ' as did List_all

    ' 09/24/2011 changes to the averaging period in globals now WARNS
    ' 09/23/2011 substantial mods in LOADEXCEL to accomodate EXCEL's repeated plotting
    ' 09/09/2011 minor mods to accomodate debug
    ' BATHTUB TASTR Version 6.14 April 2, 2012
    ' LATE BINDING OF EXCEL
    ' The "TASTR" mode of Bathtub is determined in startup
    ' Specifically in the frmMenu, Form_Load() event.  Based on the Command String
    ' A NULL command string means NON-TASTR mode

    ' TO RUN IN DEBUG MODE "Bath14.exe debug"

    ' Excel Version 15 (see wka.version and Debug 10 and Debug 10b) has switched to SDI vs. MDI and the minimize command does not work.
    ' Also version 15: Wka.EnableEvents = True causes problems??



    'CRITICAL NOTES:
    ' Late binding required some coding change because
    'references to a generic OBJECT is a little different than direct refs to specific


    'NOTE THERE ARE ALSO PROBLEMS WITH THE WAY EXCEL DEALS WITH COLLECTIONS
    'IN LATER VERSIONS - COMMENTED OUT THE .DELETE Action in "FOR EACH" Loop


    ' CONFIDENCE INTERVALS:  Walker assumes errors are log-normally distributed
    ' SEE PAGE 1-9 of the Bathtub Manual
    '==============================================================
    'THIS IS THE TASTR VERSION.  IT HAS BEEN MODIFIED TO ACCOMODATE
    'AUTO START (input case specified as .exe parameter
    'AND AUTOMATIC GENERATION OF METAMODEL OUTPUT
    'SEE FORM_LOAD, gCase_Name, and gRunMetaModels
    'IT ALSO INCLUDES ABILITY TO READ FROM AN XLS CASE FILE

    'CONSIDER USE OF DoEvents statement as equivalent of Application.ProcessMessages
    'While waiting for EXCEL to exit or edit to complete.
    '====================================================================

    Public frmMenu As frmMenu
    Public frm_Globals As frmGlobals
    Public frm_Models As frmModels
    Public frm_Tributaries As frmTribs
    Public frm_Segments As frmSegments
    Public frm_LandUse As frmLandUse
	'Public Const gVersionNumber As String = "6.14f (04/28/2015)" 'program version
	Public Const gVersionNumber As String = "7.0 Alpha (06/20/2025)" 'program version
	'Public Const Directory As String = "c:\0jobs\bathtub\"       'program directory'
	Public Directory As String = "" 'bathtub.exe folder
    Public WorkingDirectory As String = "" 'user's working directory'
    Public Const BathtubHelpFile As String = "bathtub.chm" 'help file
    'Public Const BathBook As String = "bath.xla" 'bathtub workbook
    Public Const BathBook As String = "bath.xlsx" 'bathtub workbook
	Public Const BathOutXLS As String = "bathtub_output.xlsx" 'bathtub output workbook
	Public Const BackupFile As String = "edit_backup.btx" 'backup file used to undo edits
    Public ContextId As Integer
    Public XLSWorkBk As Excel.Workbook
    'LATE BINDING APPROACH FOLLOWS
    Public Hdr As Excel.Worksheet        'header sheet
    Public Wko As Excel.Workbook 'Excel.Workbook         'output workbook used for bath_output.xls
    Public gSheetout As Worksheet 'Excel.Worksheet        'current output sheet
	'Public XLSApp As Object
	Dim XLSInputApp As Excel.Application
	Public Wka As Excel.Application 'Excel.Application
    Public Wkb As Excel.Workbook 'Excel Workbook pointing at Template Bath.xla
    Public CurrentWKChart As Object 'Excel.Chart
    Public gLSht As Excel.Worksheet 'Excel Worksheet used for Holding results
    '======================================================
    Public CaseFile As String = "" 'name of case file
    Public TestObj As Object

	'Private _hHelp As HTMLHelp = Nothing
	'Public Property hHelp() As HTMLHelp
	'    Get
	'        If _hHelp Is Nothing Then
	'            _hHelp = New HTMLHelp()
	'        End If
	'        Return _hHelp
	'    End Get
	'    Set(ByVal Value As HTMLHelp)
	'        _hHelp = Value
	'    End Set
	'End Property 'html help object
	Public ErrTxt As String = "" 'error message string
    Public NoviceUser As Boolean 'user mode

    'constant dimensions
    Public gxla_Loaded As Boolean
    Public gTASTRMode As Boolean
    Public DebugMode As Boolean 'show debug messages set in frmmenu Sub Form_Load
    Public DebugMode2 As Boolean 'Type 2 debug messages only
    Public DebugMode3 As Boolean 'type 3 debug messages only
    Public DebugCVMode As Boolean 'debugging confidence intervals
    Public ShowWarnings As Boolean 'show warning messages
    Public gRunMetaModels As Boolean 'run metamodels from start
    Public gReturnFromXLS As Boolean 'flag return from edit_xls
    Public gKeepEdits As Boolean 'xls edits
    Public gShowEditXLSNote As Boolean 'One time flag

    Public DebugMsgCount As Integer 'Keeps count of debug messages sent
    Public NGlobals As Integer 'global inputs
    Public Const NCAT As Integer = 8 'land use types dimension
    Public Const NSMAX As Integer = 50 'segment dimension

    Public Const NPMAX As Integer = 10 'pipe dimension
    Public Const NTMAX As Integer = 100 'tributary dimension
    Public NXk As Integer
    Public NDiagnostics As Integer 'diagnostic / output  variables
    Public NtermS As Integer 'number of mass balance terms
    Public NVariables As Integer 'concentration variables in input file
    Public NOptions As Integer 'model options
    Public Const MAXIT As Integer = 100 'maximum iterations

    Public Ihelp As Integer
    Public Ichoice As Integer
    Public Title As String = ""
    Public GlobalName(10) As String
    Public Cfile As String = ""
    Public Key As String = ""
    Public Note(10) As String
    Public Nmsg As Integer
    Public XkName(20) As String
    Public Cshort_Renamed(28) As String
    Public OptionName(12, 12) As String
    Public gCase_Name As String = "" 'added by DMS 8/04/08

    Public VariableName(10) As String
    Public TribName(NTMAX) As String
    Public LandUseName(NCAT) As String
    Public SegName(NSMAX + 1) As String
    Public DiagName(50) As String
    Public PipeName(NPMAX) As String
    Public CalibName(10) As String
    Public NCalib As Integer
    Public ResponseCount As Integer

    Public Darea(NTMAX) As Single
    Public Stat(30, 5) As Single
    Public x(500) As Single
    Public y(500) As Single
    Public Fav(8) As Single
    Public Conc(NSMAX + 1) As Single
    Public Agreg(NSMAX + 1, 6) As Single
    Public Wt(NSMAX + 1) As Single

    Public N_Type_Codes As Integer
    Public Type_Code(8) As String

    '    Public Pmax(2) As Single
    '    Public Qmin(2) As Single
    '    Public Fmax(2) As Single
    '    Public Ecod(2) As Single
    '    Public Ipri(NSMAX + 1) As Integer
    Public Targ(NSMAX + 1) As Single
    Public Icrit(NSMAX + 1) As Integer
    Public Jsg(NSMAX + 1) As Integer
    Public Ecoreg(NTMAX) As Single
    Public Dareal(NTMAX) As Single
    Public Concil(NTMAX, 7) As Single
    Public CvCil(NTMAX, 7) As Single
    Public FlowL(NTMAX) As Single
    Public CvFlowL(NTMAX) As Single
    Public Wi(NSMAX + 1) As Single
    Public Q(NSMAX + 1, NSMAX + 1) As Single
    Public E(NSMAX + 1, NSMAX + 1) As Single
    Public Qt(20) As Single
    Public Bt(20) As Single

    Public A(NSMAX + 1, NSMAX + 1) As Single
    Public Dx(NSMAX + 1, NSMAX + 1) As Single
    Public Qnet(NSMAX + 1) As Single
    Public Xp(500) As Single
    Public Yp(500) As Single

    Public Warea(NTMAX, NCAT) As Single
    Public Ur(NCAT) As Single
    Public Uc(NCAT, 7) As Single
    Public CvUr(NCAT) As Single
    Public CvUc(NCAT, 7) As Single

    Public Qadv(NSMAX + 1) As Single
    Public Exch(NSMAX + 1) As Single
    Public Area(NSMAX + 1) As Single
    Public Zmn(NSMAX + 1) As Single
    Public Slen(NSMAX + 1) As Single
    Public Iag(NSMAX + 1) As Integer
    Public Iout(NSMAX + 1) As Integer
    Public Iseg(NTMAX) As Integer
    Public NTrib As Integer
    Public Nseg As Integer
    Public Npipe As Integer
    Public Icode(NTMAX) As Integer
    Public Iop(12) As Integer
    Public IopDefault(12) As Integer

    Public Iord(28) As Integer
    Public Nord As Integer

    Public Ier As Integer
    Public Izap(NSMAX + 1) As Integer
    Public Mop(12) As Integer
    Public Imap(3) As Integer

    Public Iwork(100) As Integer
    Public Ilogd(28) As Integer
    Public Icalc As Integer

    Public Ito(NPMAX) As Integer
    Public Ifr(NPMAX) As Integer
    Public Icoef(4) As Integer
    Public Turbi(NSMAX + 1) As Single
    Public CvTurbi(NSMAX + 1) As Single
    Public Imsg As Integer
    Public line_no As Integer
    Public Tol As Single
    Public Sigma As Single

    Public Xk(20) As Single
    Public Cal(NSMAX + 1, 9) As Single
    Public Atm(7) As Single
    Public P(9) As Single 'P are from Global Vars Screen
    'P(1) = Avr. Period (years)
    'P(2) = Precip (meters)
    'P(3) = Evap (meters)
    'P(4) = Increase in Storage(m)
    Public Conci(NTMAX, 9) As Single
    Public Flow(NTMAX) As Single
    Public Cobs(NSMAX + 1, 30) As Single 'Observed conc?
    Public Zmx(NSMAX + 1) As Single 'used in calculations
    Public Zmxi(NSMAX + 1) As Single 'input
    Public CvZmxi(NSMAX + 1) As Single
    Public Zhyp(NSMAX + 1) As Single

    Public Turb(NSMAX + 1) As Single
    Public Qpipe(NPMAX) As Single
    Public Epipe(NPMAX) As Single
    Public CvXk(20) As Single
    Public CvCal(NSMAX + 1, 9) As Single
    Public CvAtm(7) As Single
    Public Cp(9) As Single
    Public CvCi(NTMAX, 7) As Single
    Public CvFlow(NTMAX) As Single
    Public CvCobs(NSMAX + 1, 30) As Single
    Public CvZmx(NSMAX + 1) As Single
    Public CvZhyp(NSMAX + 1) As Single
    Public InternalLoad(NSMAX + 1, 7) As Single
    Public CvInternalLoad(NSMAX + 1, 7) As Single

    Public CvTurb(NSMAX + 1) As Single
    Public CvQpipe(NPMAX) As Single
    Public CvEpipe(NPMAX) As Single
    Public Term(4, 20) As Single
    Public Cest(NSMAX + 1, 30) As Single
    Public CvTerm(4, 20) As Single
    Public CvCest(NSMAX + 1, 30) As Single

    Public XkDefault(20) As Single
    Public CvXkDefault(20) As Single

    Public TermName(20) As String
    Public Nkord As Integer
    Public Kord(20) As Integer
    Public Njord As Integer
    Public Jord(20) As Integer
    Public MassBalName(2) As String
    Public Mord As Integer
    Public Lord(10) As Integer

    Public Xe(10000) As Single 'error analysis swap vectors
    Public Cxe(10000) As Single
    Public Nxe As Integer
    Public Nxe_1 As Integer
    Public Ye(10000) As Single
    Public Cye(10000) As Single
    Public Nye As Integer
    Public Ysave(3000) As Single


	'Public Sub Main()
	'    'Create an instance of frmMenu And run it
	'    System.Windows.Forms.Application.EnableVisualStyles()
	'    System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(False)
	'    'StartUp()
	'    System.Windows.Forms.Application.Run(New frmMenu())

	'End Sub

	'Public Sub Main()
	'	StartUp()
	'End Sub
	Sub StartUp()
        Dim DebugCount As Integer
		Dim LoadErr As String = ""
		Dim location = Assembly.GetCallingAssembly().Location 'Get the assembly name
        Directory = Path.GetDirectoryName(location) 'Get the directory of the assembly
        Directory = Directory & Path.DirectorySeparatorChar 'Ensure it ends with a separator
        'start up program
        frmAbout.lblTitle(0).Text = "Bathtub for Windows Version " & gVersionNumber
        If Not gTASTRMode Then
            'frmSplash.Show vbModal
            'the FrmAbout.show event initializes a number of important variables
            frmAbout.ShowDialog() 'Needed to show this form to get paths assigned in NON-TASTR Mode
			'Dim Directory2 = My.Application.Info.DirectoryPath




		Else
			'TASTR MODE ONLY: the following was moved here From FrmAbout
			'Directory = My.Application.Info.DirectoryPath & Wka.Application.PathSeparator
			'UPGRADE_ISSUE: (2064) VB method VB.Global was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2064
			'UPGRADE_ISSUE: (2070) Constant App was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2070
			'UPGRADE_ISSUE: (2064) App property App.HelpFile was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2064
			'BT2Support.UpgradeStubs.VB.getGlobal().getApp().setHelpFile(Directory & BathtubHelpFile)
			'hHelp.CHMFile = Directory & BathtubHelpFile
		End If
		'==================================================================
		'======     C H E C K    F O R   M I S S I N G    F I L E S   =====
		'==================================================================

		'If Not FileExists(Directory & "\" & "Bath.xla") Then
		If Not FileExists("Bath.xlsx") Then
			MessageBox.Show("BathTub Must Abort, Missing Critical File: " & Directory & "\" & "Bath.xlsx", My.Application.Info.Title)
			GoTo Abhort
		End If

		'If Not FileExists(Directory & "\" & "Default.btb") Then
		If Not FileExists("Default.btb") Then
			MessageBox.Show("BathTub Must Abort, Missing Critical File: " & Directory & "\" & "Default.btb", My.Application.Info.Title)
			GoTo Abhort
		End If

		DebugCVMode = False

		Icalc = 0
		Ier = 0
		'KW
		Status("Starting Up")

		XLSInputApp = New Excel.Application() 'excel object for input
		Wka = New Excel.Application()
		'Wko = Wka.ActiveWorkbook
		Wka.DisplayAlerts = False
		gxla_Loaded = False
		'Set Wkb = CreateObject("Excel.Workbooks") we don't create these anymore here but
		'Set Wko = CreateObject("Excel.Workbooks")

		If DebugMode Then MsgBox("Loading Excel at Startup to Test Availability")

		'LoadExcel()

		'    If DebugMode Then MsgBox(("DEBUG 03 Excel Load Attempt Completed " & Str(DebugCount))

		DebugCount += 1
		LoadErr = "Error Loading Excel"
		If Ier > 0 Then GoTo Abhort
		LoadErr = "Initialization Step - Output_Init "
		On Error GoTo Abhort
		Output_Init() 'initialize variables

		If DebugMode Then MsgBox("DEBUG 04 @ Module 1 Read Defaults " & Str(DebugCount))
		DebugCount += 1
		LoadErr = "Unable to Read Defaults"
		ReadDefaults()
		If Ier > 0 Then GoTo Abhort
		'KW
		Status("Ready")

		'    If DebugMode Then MsgBox(("DEBUG 05 @ Module1 RUN " & Str(DebugCount))		
		DebugCount += 1
		LoadErr = "Unable to Run Model (CALCON)"
		Run()

		LoadErr = "Unable to Update Main Form (FormUpdate)"
		'    FormUpdate()

		gShowEditXLSNote = True
		Exit Sub

Abhort:
		Ier = 1
		MsgBox("Program Could Not Start: " & LoadErr & " Check Installation ")
		CleanUp()
	End Sub

	Sub ReadDefaults()
		'read default input file & assign values

		If (Wko Is Nothing) Then
			LoadExcel()
		End If

		ReadKey()                         'read parameter key		
		If Ier > 0 Then Exit Sub


		RemoveHandler frmMenu.cmbUserMode.SelectedIndexChanged, AddressOf frmMenu.cmbUserMode_SelectedIndexChanged
		With frmMenu.cmbUserMode
			.Items.Clear()
			.Items.Add("Standard Mode")
			.Items.Add("Advanced Mode")
			.SelectedIndex = 1
		End With
		AddHandler frmMenu.cmbUserMode.SelectedIndexChanged, AddressOf frmMenu.cmbUserMode_SelectedIndexChanged

		RemoveHandler frmMenu.cmbOutputDest.SelectedIndexChanged, AddressOf frmMenu.cmbOutputDest_SelectedIndexChanged
		With frmMenu.cmbOutputDest
			.Items.Clear()
			For i As Integer = 1 To 3
				.AddItem(OptionName(12, i))
			Next i
			.SelectedIndex = 1
		End With
		AddHandler frmMenu.cmbOutputDest.SelectedIndexChanged, AddressOf frmMenu.cmbOutputDest_SelectedIndexChanged

		frmMenu.SetUserMode(1)
		FormUpdate()

		CaseFile = gCase_Name
		If gCase_Name = "" Then CaseFile = Directory & "\default.btb"
		Read_btb((CaseFile)) 'read default case
		If Ier > 0 Then Exit Sub

		'assign defaults
		For i As Integer = 1 To NOptions
			IopDefault(i) = Iop(i)
		Next i

		For i As Integer = 1 To NXk
			XkDefault(i) = Xk(i)
			CvXkDefault(i) = CvXk(i)
		Next i
	End Sub
	Sub CleanUp()
		Dim savechanges As Boolean
		'Dim XLSInputApp As Object
		'clear all instances of excel that have bath.xls or bath_output.xls

		'UPGRADE_TODO: (1069) Error handling statement (On Error Resume Next) was converted to a pattern that might have a different behavior. More Information: https://docs.mobilize.net/vbuc/ewis/todos#id-1069
		Try
			'MsgBox( ("clearing excel")
			Wko.Saved = True
			Wko.Close(Not savechanges)
			Wko = Nothing
			XLSWorkBk.Close(Not savechanges)
			If XLSInputApp IsNot Nothing Then
				XLSInputApp.Quit()
				XLSInputApp = Nothing
			End If
			Wka.EnableEvents = False
			Wka.Quit()
			Wka = Nothing
			Wkb = Nothing
			XLSWorkBk = Nothing
			'hHelp.HHClose()
			'hHelp = Nothing

		Catch exc As Exception
			'NotUpgradedHelper.NotifyNotUpgradedElement("Resume in On-Error-Resume-Next Block")
		End Try

	End Sub
	Sub RefreshMainTextBox()
		'fill text box on main menu screen
		Dim txt As String = "File: " & ExtractFile(CaseFile) & Environment.NewLine
		txt = txt & "Title: " & Title & Environment.NewLine
		txt = txt & "Segments: " & CStr(Nseg) & "  Tributaries: " & CStr(NTrib) & Environment.NewLine
		If Nmsg > 0 Then txt = txt & "Error Messages: " & CStr(Nmsg) & Environment.NewLine
		If Icalc > 0 Then
			txt = txt & "Predicted Area-Weighted Means:" & Environment.NewLine
			If Iop(2) > 0 Then txt = txt & "---Total P(ppb) = " & StringsHelper.Format(Cest(Nseg + 1, 2), "###0") & Environment.NewLine
			If Iop(3) > 0 Then txt = txt & "---Total N(ppb) = " & StringsHelper.Format(Cest(Nseg + 1, 3), "###0") & Environment.NewLine
			If Iop(4) > 0 Then txt = txt & "---Chl-a(ppb)   = " & StringsHelper.Format(Cest(Nseg + 1, 4), "###0") & Environment.NewLine
			If Iop(5) > 0 Then txt = txt & "---Secchi(m)    = " & StringsHelper.Format(Cest(Nseg + 1, 5), "#0.0")
		End If
		frmMenu.txtReport.Text = txt
		'frmMenu.txtReport.SetFocus

		'If Wka is nothing Then
		'what does this REALLY want from Excel?? this LOADEXCEL is REQUIRED downstream,
		'but what part?
		'If DebugMode2 Then MsgBox( ("N456: RefreshMainTextBox: LoadExcel")
		'LOADEXCEL REQUIRES/ASSUMES WKA and WKB are OK
		'LoadExcel()

		'ClearOutput
		'End If
		'frmMenu.lblOutputWorkbook.Text = Wko.Name
		SegName(Nseg + 1) = "Area-Wtd Mean"
		If NoviceUser Then
			frmMenu.cmbUserMode.SelectedIndex = 0
		Else
			frmMenu.cmbUserMode.SelectedIndex = 1
		End If

	End Sub 'RefreshMainTextBox
	Sub FormUpdate()
		'update main form & menu entries
		'  On Error GoTo quitshow
		'If DebugMode2 Then MsgBox( "FormUpdate"
		RefreshMainTextBox()

		If Icalc = 0 Then ClearOutputWorkbook()

		With frmMenu
			.CheckWarnings()
			'.btnErrorMessages.Visible = Nmsg > 0
			If Nmsg > 0 Then
				.btnErrorMessages.Visible = True
			Else
				.btnErrorMessages.Visible = False
			End If
			Try
				RemoveHandler frmMenu.cmbOutputDest.SelectedIndexChanged, AddressOf frmMenu.cmbOutputDest_SelectedIndexChanged
				frmMenu.cmbOutputDest.SelectedIndex = Iop(12)
				AddHandler frmMenu.cmbOutputDest.SelectedIndexChanged, AddressOf frmMenu.cmbOutputDest_SelectedIndexChanged

			Catch
			End Try
		End With

		Exit Sub

	End Sub

	Sub Run()
		Dim DebugCount As Integer
		Status("Running...")
		Nmsg = 0 'error message count

		'    If DebugMode Then MsgBox(("DEBUG 06 @ Module1 CalCon " & Str(DebugCount))

		DebugCount += 1
		Calcon()
		If Ier > 0 Then
			Status("Errors")
			Icalc = 0
		Else
			Status("Ready")
			Icalc = 1
		End If

		If Nmsg > 0 And ShowWarnings Then List_Errors()


	End Sub
	Sub List_Errors()
		ContextId = 196
		With frmBox.DefInstance
			.Text = "Error Messages"
			.txtBox.Text = ErrTxt
			.ShowDialog()
		End With
	End Sub

	Sub Read_bin_btb(ByVal infilE As String)
		Dim Abhort As Boolean = False
		Dim j, k As Double
		Dim vers1 As Object
		'read input file created by translation utility 'convert.exe'

		Ier = 0
		Try
			Abhort = True

			Dim junk As String = ""
			'Dim sReader = FileSystem.OpenTextFileReader(infilE)

			FileSystem.FileOpen(1, infilE, OpenMode.Input)

			AllZero() 'zero all input variables

			'header
			FileSystem.Input(1, vers1)
			FileSystem.Input(1, Title)

			'dimensions
			FileSystem.Input(1, junk)
			FileSystem.Input(1, Nseg)
			FileSystem.Input(1, NTrib)
			FileSystem.Input(1, Npipe)

			' Parameters & Options
			FileSystem.Input(1, junk)
			For i As Double = 1 To NGlobals + 4
				FileSystem.Input(1, P(CInt(i)))
				FileSystem.Input(1, Cp(CInt(i)))
			Next i

			'Model Options
			FileSystem.Input(1, junk)
			For i As Double = 1 To 11
				FileSystem.Input(1, Iop(CInt(i)))
			Next i

			'Print options  'not used
			FileSystem.Input(1, junk)
			For i As Double = 1 To 10
				FileSystem.Input(1, j)
			Next i

			'Globals
			FileSystem.Input(1, junk)
			Xk(1) = P(6)
			CvXk(1) = Cp(6)
			For i As Double = 1 To 12
				FileSystem.Input(1, Xk(CInt(i + 1)))
				FileSystem.Input(1, CvXk(CInt(i + 1)))
			Next i

			'Atmospherics
			FileSystem.Input(1, junk)
			For i As Double = 1 To NVariables
				FileSystem.Input(1, junk)
				FileSystem.Input(1, Atm(CInt(i)))
				FileSystem.Input(1, CvAtm(CInt(i)))
				FileSystem.Input(1, Fav(CInt(i)))
			Next i
			Xk(14) = Fav(2)
			Xk(15) = Fav(4)
			Xk(16) = Fav(3)
			Xk(17) = Fav(5)

			'Segments
			FileSystem.Input(1, junk)
			For i As Double = 1 To Nseg
				FileSystem.Input(1, SegName(CInt(i)))
				FileSystem.Input(1, Iout(CInt(i)))
				FileSystem.Input(1, Iag(CInt(i)))
				FileSystem.Input(1, Area(CInt(i)))
				FileSystem.Input(1, Zmn(CInt(i)))
				FileSystem.Input(1, Slen(CInt(i)))
				FileSystem.Input(1, Zmxi(CInt(i)))
				FileSystem.Input(1, CvZmxi(CInt(i)))
				FileSystem.Input(1, Zhyp(CInt(i)))
				FileSystem.Input(1, CvZhyp(CInt(i)))
				FileSystem.Input(1, Turbi(CInt(i)))
				FileSystem.Input(1, CvTurbi(CInt(i)))
				For j = 1 To 9
					FileSystem.Input(1, Cobs(CInt(i), CInt(j)))
					FileSystem.Input(1, CvCobs(CInt(i), CInt(j)))
				Next j
				For j = 1 To 6
					If j = 6 Then
						k = 1
					Else
						k = j + 1
					End If
					FileSystem.Input(1, Cal(CInt(i), CInt(k)))
					FileSystem.Input(1, CvCal(CInt(i), CInt(k)))
				Next j

				FileSystem.Input(1, k)
				FileSystem.Input(1, Icrit(CInt(i)))
				FileSystem.Input(1, Targ(CInt(i)))
				'Input #1, x(1), x(2)
			Next i

			' c Tribs
			FileSystem.Input(1, junk)
			For i As Double = 1 To NTrib
				FileSystem.Input(1, TribName(CInt(i)))
				FileSystem.Input(1, Iseg(CInt(i)))
				FileSystem.Input(1, Icode(CInt(i)))
				FileSystem.Input(1, Darea(CInt(i)))
				FileSystem.Input(1, Flow(CInt(i)))
				FileSystem.Input(1, CvFlow(CInt(i)))
				For j = 1 To NVariables
					FileSystem.Input(1, Conci(CInt(i), CInt(j)))
					FileSystem.Input(1, CvCi(CInt(i), CInt(j)))
				Next j
				For j = 1 To NCAT
					FileSystem.Input(1, Warea(CInt(i), CInt(j)))
				Next j
				'Input #1, Ecoreg(i)
				FileSystem.Input(1, x(1))
			Next i

			' Channels
			FileSystem.Input(1, junk)
			For i As Double = 1 To Npipe
				FileSystem.Input(1, PipeName(CInt(i)))
				FileSystem.Input(1, Ifr(CInt(i)))
				FileSystem.Input(1, Ito(CInt(i)))
				FileSystem.Input(1, Qpipe(CInt(i)))
				FileSystem.Input(1, CvQpipe(CInt(i)))
				FileSystem.Input(1, Epipe(CInt(i)))
				FileSystem.Input(1, CvEpipe(CInt(i)))
			Next i

			'export categories
			FileSystem.Input(1, junk)
			For i As Double = 1 To NCAT
				FileSystem.Input(1, LandUseName(CInt(i)))
				FileSystem.Input(1, Ur(CInt(i)))
				FileSystem.Input(1, CvUr(CInt(i)))
				For k = 1 To NVariables
					FileSystem.Input(1, Uc(CInt(i), CInt(k)))
					FileSystem.Input(1, CvUc(CInt(i), CInt(k)))
				Next k
			Next i

			' notes
			FileSystem.Input(1, junk)
			For i As Double = 1 To 10
				FileSystem.Input(1, Note(CInt(i)))
			Next i

			'Allocation
			'    Input #1, junk
			'    For i = 1 To 2
			'        Input #1, Fmax(i), Ecod(i), Qmin(i), Pmax(i)
			'        Next i
			'    Input #1, Ipri(1), Ipri(2), Ipri(3)

			FileSystem.FileClose(1)
			Abhort = False


			'translate type=2 tribs
			For i As Double = 1 To NTrib
				If Icode(CInt(i)) = 2 Then
					x(1) = 0
					For k = 1 To NCAT
						x(1) += Warea(CInt(i), CInt(k))
					Next k
					If x(1) = 0 And Flow(CInt(i)) > 0 Then
						Icode(CInt(i)) = 1
						'                MsgBox(("Type Code for Trib " & i & " " & TribName(i) & " Changed from 2 to 1")

					End If
				End If
			Next i

			'translate internal loads
			For i As Double = NTrib To 1 Step -1
				If Icode(CInt(i)) = 5 Then
					For j = 1 To NVariables
						InternalLoad(Iseg(CInt(i)), CInt(j)) = Conci(CInt(i), CInt(j))
						CvInternalLoad(Iseg(CInt(i)), CInt(j)) = CvCi(CInt(i), CInt(j))
					Next j
					TribEdit(i, 0)
					'            MsgBox("Tributary " & i & " " & TribName(i) & " Handled as Internal Load"

				End If
			Next i
			For i As Double = 1 To NTrib
				If Icode(CInt(i)) = 6 Then Icode(CInt(i)) = 5
			Next i

			'translate mixed layer depths
			For i As Double = 1 To Nseg
				If Zmxi(CInt(i)) <= 0 Then
					Zmxi(CInt(i)) = ZmixEst(Zmn(CInt(i)))
					CvZmx(CInt(i)) = 0.12
				End If
			Next i

			'translate non-algal turbidity
			For i As Double = 1 To Nseg
				If Turbi(CInt(i)) <= 0 Then
					TurbEst(Cobs(CInt(i), 4), CvCobs(CInt(i), 4), Cobs(CInt(i), 5), CvCobs(CInt(i), 5), x(1), x(2))
					Turbi(CInt(i)) = x(1)
					CvTurbi(CInt(i)) = x(2)
				End If
			Next i

		Catch excep As Exception
			If Not Abhort Then
				Throw excep
			End If

			If Abhort Then

				FileSystem.FileClose(1)
				Ier = 1
				'    MsgBox("Error in Translating File "

			End If
		End Try

	End Sub
	Sub Read_btb(ByVal infilE As String)
		Dim Abhort As Boolean = False
		'KW
		'Dim j, k As Double
		Dim j, k As Integer
		Dim vers1 As String
		Dim name As String
		'read standard bathtub input file

		Ier = 0
		Try
			Abhort = True

			Dim junk As String = ""

			'    MsgBox( "Reading: " & infilE
			'FileSystem.Open
			FileSystem.FileOpen(1, infilE, OpenMode.Input)

			AllZero() 'zero all input variables

			'header
			FileSystem.Input(1, vers1)
			Title = FileSystem.LineInput(1)

			' Parameters & Options
			FileSystem.Input(1, junk)
			FileSystem.Input(1, junk)
			'FileSystem.Input(1, junk)
			For i As Integer = 1 To NGlobals
				FileSystem.Input(1, j)
				FileSystem.Input(1, junk)
				FileSystem.Input(1, P(i))
				FileSystem.Input(1, Cp(i))
			Next i

			'Model Options
			'KW
			'FileSystem.Input(1, j)
			FileSystem.Input(1, NOptions)
			FileSystem.Input(1, junk)
			For i As Integer = 1 To NOptions
				FileSystem.Input(1, j)
				FileSystem.Input(1, junk)
				FileSystem.Input(1, Iop(i))
			Next i

			'Globals
			'KW
			FileSystem.Input(1, NXk)
			FileSystem.Input(1, junk)
			For i As Integer = 1 To NXk
				FileSystem.Input(1, j)
				FileSystem.Input(1, junk)
				FileSystem.Input(1, Xk(i))
				FileSystem.Input(1, CvXk(i))
			Next i

			'Atmospherics
			'KW
			'FileSystem.Input(1, j)
			FileSystem.Input(1, NVariables)
			FileSystem.Input(1, junk)
			For i As Integer = 1 To NVariables
				FileSystem.Input(1, j)
				FileSystem.Input(1, junk)
				FileSystem.Input(1, Atm(i))
				FileSystem.Input(1, CvAtm(i))
			Next i

			'Segments
			'KW
			FileSystem.Input(1, Nseg)
			FileSystem.Input(1, junk)
			For i As Integer = 1 To Nseg
				FileSystem.Input(1, j)
				FileSystem.Input(1, SegName(i))
				FileSystem.Input(1, Iout(i))
				FileSystem.Input(1, Iag(i))
				FileSystem.Input(1, Area(i))
				FileSystem.Input(1, Zmn(i))
				FileSystem.Input(1, Slen(i))
				FileSystem.Input(1, Zmxi(i))
				FileSystem.Input(1, CvZmxi(i))
				FileSystem.Input(1, Zhyp(i))
				FileSystem.Input(1, CvZhyp(i))
				FileSystem.Input(1, Turbi(i))
				FileSystem.Input(1, CvTurbi(i))
				FileSystem.Input(1, Icrit(i))
				FileSystem.Input(1, Targ(i))
				For j = 1 To 3
					FileSystem.Input(1, k)
					FileSystem.Input(1, junk)
					FileSystem.Input(1, InternalLoad((i), j))
					FileSystem.Input(1, CvInternalLoad(i, j))
				Next j
				For j = 1 To 9
					FileSystem.Input(1, k)
					FileSystem.Input(1, junk)
					FileSystem.Input(1, Cobs(i, j))
					FileSystem.Input(1, CvCobs(i, j))
					FileSystem.Input(1, Cal(i, j))
					FileSystem.Input(1, CvCal(i, j))
				Next j
			Next i

			' c Tribs
			'KW
			FileSystem.Input(1, NTrib)
			FileSystem.Input(1, junk)
			For i As Integer = 1 To NTrib
				FileSystem.Input(1, j)
				FileSystem.Input(1, TribName(i))
				FileSystem.Input(1, Iseg(i))
				FileSystem.Input(1, Icode(i))
				FileSystem.Input(1, Darea(i))
				FileSystem.Input(1, Flow(i))
				FileSystem.Input(1, CvFlow(i))
				FileSystem.Input(1, Ecoreg(i))
				For j = 1 To NVariables
					FileSystem.Input(1, k)
					FileSystem.Input(1, junk)
					FileSystem.Input(1, Conci(i, j))
					FileSystem.Input(1, CvCi(i, j))
				Next j

				FileSystem.Input(1, k)
				FileSystem.Input(1, junk)
				FileSystem.Input(1, Warea(i, 1))
				FileSystem.Input(1, Warea(i, 2))
				FileSystem.Input(1, Warea(i, 3))
				FileSystem.Input(1, Warea(i, 4))
				FileSystem.Input(1, Warea(i, 5))
				FileSystem.Input(1, Warea(i, 6))
				FileSystem.Input(1, Warea(i, 7))
				FileSystem.Input(1, Warea(i, 8))
			Next i

			' Channels
			'KW
			FileSystem.Input(1, Npipe)
			FileSystem.Input(1, junk)
			For i As Integer = 1 To Npipe
				FileSystem.Input(1, j)
				FileSystem.Input(1, PipeName(i))
				FileSystem.Input(1, Ifr(i))
				FileSystem.Input(1, Ito(i))
				FileSystem.Input(1, Qpipe(i))
				FileSystem.Input(1, CvQpipe(i))
				FileSystem.Input(1, Epipe(i))
				FileSystem.Input(1, CvEpipe(i))
			Next i

			'export categories
			'KW
			FileSystem.Input(1, NCAT)
			FileSystem.Input(1, junk)
			For i As Integer = 1 To NCAT
				FileSystem.Input(1, j)
				FileSystem.Input(1, LandUseName(i))
				FileSystem.Input(1, j)
				FileSystem.Input(1, junk)
				FileSystem.Input(1, Ur(i))
				FileSystem.Input(1, CvUr(i))
				For k = 1 To NVariables
					FileSystem.Input(1, j)
					FileSystem.Input(1, junk)
					FileSystem.Input(1, Uc(i, k))
					FileSystem.Input(1, CvUc(i, k))
				Next k
			Next i

			' notes
			FileSystem.Input(1, junk)
			For i As Integer = 1 To 10
				Note(i) = FileSystem.LineInput(1)
			Next i

			'Allocation
			'    Input #1, junk
			'    For i = 1 To 2
			'        Input #1, Fmax(i), Ecod(i), Qmin(i), Pmax(i)
			'        Next i
			'    Input #1, Ipri(1), Ipri(2), Ipri(3)

			FileSystem.FileClose(1)

			Abhort = False
			'MsgBox( "output destination " & OptionName(12, Iop(12) + 1)
			CaseFile = infilE
			WorkingDirectory = ExtractPath(infilE)
			Icalc = 0
			'    If DebugMode Then MsgBox(("N3: clear output from readbtb in Module1")

			ClearOutput()

			'    On Error Resume Next 'next statement will fail at startup
			'frmMenu.cmbOutputDest.ListIndex = Iop(12)
			'frmMenu.DefInstance.Check_OutputDest()
			frmMenu.Check_OutputDest()
			Status("Ready")

			Abhort = False

		Catch excep As Exception
			If Not Abhort Then
				Throw excep
			End If

			If Abhort Then

				FileSystem.FileClose(1)
				Ier = 1
				'    MsgBox("Input File Error", vbCritical

			End If
		End Try
	End Sub


	Sub Save_btb(ByVal Lout As String)

		'writes output file to disk in ascii format


		'    MsgBox( "saving : " & outfilE
		FileSystem.FileOpen(1, Lout, OpenMode.Output)

		'header
		FileSystem.PrintLine(1, "Vers " & gVersionNumber)
		FileSystem.PrintLine(1, Title)

		' Parameters & Options
		FileSystem.WriteLine(1, CStr(NGlobals), "Global Parmameters")
		For i As Double = 1 To NGlobals
			FileSystem.WriteLine(1, CStr(i), GlobalName(CInt(i)), CStr(P(CInt(i))), CStr(Cp(CInt(i))))
		Next i

		'Model Options
		FileSystem.WriteLine(1, CStr(NOptions), "Model Options")
		For i As Double = 1 To NOptions
			FileSystem.WriteLine(1, CStr(i), OptionName(CInt(i), 0), CStr(Iop(CInt(i))))
		Next i

		'Print options
		'  Write #1, "Print Options"
		'  For i = 1 To 10
		'      Write #1, j
		'      Next i

		'Globals
		FileSystem.WriteLine(1, CStr(NXk), "Model Coefficients")
		For i As Double = 1 To NXk
			FileSystem.WriteLine(1, CStr(i), XkName(CInt(i)), CStr(Xk(CInt(i))), CStr(CvXk(CInt(i))))
		Next i

		'Atmospherics
		FileSystem.WriteLine(1, CStr(NVariables), "Atmospheric Loads")
		For i As Double = 1 To NVariables
			FileSystem.WriteLine(1, CStr(i), VariableName(CInt(i)), CStr(Atm(CInt(i))), CStr(CvAtm(CInt(i))))
		Next i

		'Segments
		FileSystem.WriteLine(1, CStr(Nseg), "Segments")
		For i As Double = 1 To Nseg
			FileSystem.WriteLine(1, CStr(i), SegName(CInt(i)), CStr(Iout(CInt(i))), CStr(Iag(CInt(i))), CStr(Area(CInt(i))), CStr(Zmn(CInt(i))), CStr(Slen(CInt(i))), CStr(Zmxi(CInt(i))), CStr(CvZmxi(CInt(i))), CStr(Zhyp(CInt(i))), CStr(CvZhyp(CInt(i))), CStr(Turbi(CInt(i))), CStr(CvTurbi(CInt(i))), CStr(Icrit(CInt(i))), CStr(Targ(CInt(i))))
			For j As Double = 1 To 3
				FileSystem.WriteLine(1, CStr(i), VariableName(CInt(j)), CStr(InternalLoad(CInt(i), CInt(j))), CStr(CvInternalLoad(CInt(i), CInt(j))))
			Next j
			For j As Double = 1 To 9
				FileSystem.WriteLine(1, CStr(i), DiagName(CInt(j)), CStr(Cobs(CInt(i), CInt(j))), CStr(CvCobs(CInt(i), CInt(j))), CStr(Cal(CInt(i), CInt(j))), CStr(CvCal(CInt(i), CInt(j))))
			Next j
		Next i

		' c Tribs
		FileSystem.WriteLine(1, CStr(NTrib), "Tributaries")
		For i As Double = 1 To NTrib
			FileSystem.WriteLine(1, CStr(i), TribName(CInt(i)), CStr(Iseg(CInt(i))), CStr(Icode(CInt(i))), CStr(Darea(CInt(i))), CStr(Flow(CInt(i))), CStr(CvFlow(CInt(i))), CStr(Ecoreg(CInt(i))))
			For j As Double = 1 To NVariables
				FileSystem.WriteLine(1, CStr(i), VariableName(CInt(j)), CStr(Conci(CInt(i), CInt(j))), CStr(CvCi(CInt(i), CInt(j))))
			Next j
			FileSystem.WriteLine(1, CStr(i), "LandUses", CStr(Warea(CInt(i), 1)), CStr(Warea(CInt(i), 2)), CStr(Warea(CInt(i), 3)), CStr(Warea(CInt(i), 4)), CStr(Warea(CInt(i), 5)), CStr(Warea(CInt(i), 6)), CStr(Warea(CInt(i), 7)), CStr(Warea(CInt(i), 8)))
		Next i

		' Channels
		FileSystem.WriteLine(1, CStr(Npipe), "Channels")
		For i As Double = 1 To Npipe
			FileSystem.WriteLine(1, CStr(i), PipeName(CInt(i)), CStr(Ifr(CInt(i))), CStr(Ito(CInt(i))), CStr(Qpipe(CInt(i))), CStr(CvQpipe(CInt(i))), CStr(Epipe(CInt(i))), CStr(CvEpipe(CInt(i))))
		Next i

		'export categories
		FileSystem.WriteLine(1, CStr(NCAT), "Land Use Export Categories")
		For i As Double = 1 To NCAT
			FileSystem.WriteLine(1, CStr(i), LandUseName(CInt(i)))
			FileSystem.WriteLine(1, CStr(i), "Runoff", CStr(Ur(CInt(i))), CStr(CvUr(CInt(i))))
			For k As Double = 1 To NVariables
				FileSystem.WriteLine(1, CStr(i), VariableName(CInt(k)), CStr(Uc(CInt(i), CInt(k))), CStr(CvUc(CInt(i), CInt(k))))
			Next k
		Next i

		' notes
		FileSystem.WriteLine(1, "Notes")
		For i As Double = 1 To 10
			FileSystem.PrintLine(1, Note(CInt(i)))
		Next i

		'Allocation
		'    Write #1, "Allocation"
		'    For i = 1 To 2
		'        Write #1, Fmax(i), Ecod(i), Qmin(i), Pmax(i)
		'        Next i
		'    Write #1, Ipri(1), Ipri(2), Ipri(3)
		FileSystem.FileClose(1)

	End Sub
	Sub Edit_xls()
		Dim realversion As Double
		'edit inputs on worksheet

		Status("Loading Worksheet")
		Ier = 0
		'If DebugMode Then
		'    MsgBox(("Loading Excel from sub Edit_xls")

		LoadExcel()

		If Ier > 0 Then Exit Sub
		gLSht = Wkb.Worksheets("Inputs")
		'    Save_xls()              'writes current inputs to "inputs" sheet of WKB

		If Ier > 0 Then Exit Sub

		'Copy the filled-in template to the WKO workbook
		Wkb.Worksheets("Inputs").Copy(Wko.Sheets(1))
		gSheetout = Wko.Worksheets("Inputs")

		If Ier > 0 Then Exit Sub
		Status("Edit Worksheet")
		frmMenu.ContinueBtn.Visible = True
		Dim Lstring As String = "Click On the Bathtub <CONTINUE> Button When Done Editing in EXCEL" & Strings.Chr(13).ToString()
		Lstring = Lstring & "          When Done Editing, No Worksheet Cells Can Be Active."
		If gShowEditXLSNote Then
			MsgBox("DO NOT CLOSE EXCEL MANUALLY")

		End If
		gShowEditXLSNote = False
		'frmMenu.WindowState = vbMinimized
		Wka.WindowState = Excel.XlWindowState.xlNormal
		gSheetout.Range("C3").Select()
		gReturnFromXLS = True
		Do While gReturnFromXLS
			System.Windows.Forms.Application.DoEvents()
		Loop
		frmMenu.ContinueBtn.Visible = False
		' After user edits are done

		If gKeepEdits Then
			On Error GoTo Quit 'in case user closes window
			gSheetout.UsedRange.Copy(gLSht.Range("A1"))
			XLSWorkBk = Wko
			Read_xls("Inputs")
		End If
		Wka.DisplayAlerts = False
		gSheetout.Delete()
		realversion = CDbl(Wka.Version)
		If (realversion < 15) Then Wka.WindowState = Excel.XlWindowState.xlMinimized
		Wka.DisplayAlerts = True
Quit:
		XLSWorkBk = Nothing
		Status("Ready")
	End Sub


	Sub Save_xls()

		'writes input data to excel sheet without saving to disk
		'first update main screen

		Try

			With CType(gLSht, Excel.Worksheet)

				.Range("C3:HA1000").ClearContents()

				'header
				.Range("title").Value = Title

				'dimensions
				.Range("Nseg").Value = Nseg
				.Range("Ntrib").Value = NTrib
				.Range("Npipe").Value = Npipe

				' Parameters & Options
				Dim globalFactors = .Range("global_factors")
				For i As Integer = 1 To 4
					globalFactors.Offset(i, 2).Value = P(i)
					globalFactors.Offset(i, 3).Value = Cp(i)
				Next i

				'Model Options
				Dim modelOptions = .Range("model_options")
				For i As Integer = 1 To NOptions
					modelOptions.Offset(i, 2).Value = Iop(i)
				Next i

				'Globals
				Dim calibrationFactors = .Range("calibration_factors")
				For i As Integer = 1 To NXk
					calibrationFactors.Offset(i, 2).Value = Xk(i)
					calibrationFactors.Offset(i, 3).Value = CvXk(i)
				Next i

				'Atmospherics
				Dim atmosLoads = .Range("atmos_loads")
				For i As Integer = 1 To NVariables
					' atmosLoads.Offset(i, 1).Value = VariableName(i) ' Uncomment if needed
					atmosLoads.Offset(i, 2).Value = Atm(i)
					atmosLoads.Offset(i, 3).Value = CvAtm(i)
				Next i


				'Segments
				Dim segmentData = gLSht.Range("segment_data").Offset(0, 1)
				For i As Integer = 1 To Nseg
					segmentData.Offset(i, 1).Value = i
					segmentData.Offset(i, 2).Value = SegName(i)
					segmentData.Offset(i, 3).Value = Iout(i)
					segmentData.Offset(i, 4).Value = Iag(i)
					segmentData.Offset(i, 6).Value = Area(i)
					segmentData.Offset(i, 7).Value = Zmn(i)
					segmentData.Offset(i, 8).Value = Slen(i)
					segmentData.Offset(i, 9).Value = Zmxi(i)
					segmentData.Offset(i, 10).Value = CvZmxi(i)
					segmentData.Offset(i, 11).Value = Zhyp(i)
					segmentData.Offset(i, 12).Value = CvZhyp(i)
					segmentData.Offset(i, 14).Value = Turbi(i)
					segmentData.Offset(i, 15).Value = CvTurbi(i)

					For j As Integer = 1 To 9
						segmentData.Offset(14 + j * 2, i).Value = Cobs(i, j)
						segmentData.Offset(14 + j * 2 + 1, i).Value = CvCobs(i, j)
					Next j

					For j As Integer = 1 To 9
						segmentData.Offset(33 + j * 2, i).Value = Cal(i, j)
						segmentData.Offset(33 + j * 2 + 1, i).Value = CvCal(i, j)
					Next j

					For j As Integer = 1 To 3
						segmentData.Offset(53 + j * 2, i).Value = InternalLoad(i, j)
						segmentData.Offset(53 + j * 2 + 1, i).Value = CvInternalLoad(i, j)
					Next j

					'Write #1, k, Icrit(i), Targ(i)
				Next i


				' c Tribs
				Dim tribData = gLSht.Range("Tributary_data").Offset(0, 1)
				For i As Integer = 1 To NTrib
					tribData.Offset(i, 1).Value = i
					tribData.Offset(i, 2).Value = TribName(i)
					tribData.Offset(i, 3).Value = Iseg(i)
					tribData.Offset(i, 4).Value = Icode(i)
					tribData.Offset(i, 5).Value = Darea(i)
					tribData.Offset(i, 6).Value = Flow(i)
					tribData.Offset(i, 7).Value = CvFlow(i)

					For j As Integer = 1 To NVariables
						tribData.Offset(6 + 2 * j, i).Value = Conci(i, j)
						tribData.Offset(6 + 2 * j + 1, i).Value = CvCi(i, j)
					Next j

					For j As Integer = 1 To NCAT
						tribData.Offset(18 + j, i).Value = Warea(i, j)
					Next j
				Next i

				' Channels
				Dim channelData = gLSht.Range("transport_channels").Offset(0, 1)
				For i As Integer = 1 To Npipe
					channelData.Offset(i, 1).Value = i
					channelData.Offset(i, 2).Value = PipeName(i)
					channelData.Offset(i, 3).Value = Ifr(i)
					channelData.Offset(i, 4).Value = Ito(i)
					channelData.Offset(i, 5).Value = Qpipe(i)
					channelData.Offset(i, 6).Value = CvQpipe(i)
					channelData.Offset(i, 7).Value = Epipe(i)
					channelData.Offset(i, 8).Value = CvEpipe(i)
				Next i

				' export categories
				Dim catData = gLSht.Range("categories").Offset(0, 1)
				For i As Integer = 1 To NCAT
					catData.Offset(i, 1).Value = i
					catData.Offset(i, 2).Value = LandUseName(i)
					catData.Offset(i, 3).Value = Ur(i)
					catData.Offset(i, 4).Value = CvUr(i)
					For k As Integer = 1 To NVariables
						catData.Offset(3 + k * 2, i).Value = Uc(i, k)
						catData.Offset(3 + k * 2 + 1, i).Value = CvUc(i, k)
					Next k
				Next i

				' notes
				Dim notesData = gLSht.Range("notes")
				For i As Integer = 1 To 10
					notesData.Offset(i - 1, 0).Value = Note(i)
				Next i
			End With
			'Allocation
			'    Write #1, "Allocation"
			'    For i = 1 To 2
			'        Write #1, Fmax(i), Ecod(i), Qmin(i), Pmax(i)
			'        Next i
			'    Write #1, Ipri(1), Ipri(2), Ipri(3)

			'    Close #1
			'   MsgBox( "Input Data Copied to Bathtub worksheet"

			'copy

		Catch

			'    MsgBox("Error Writing Input Data to Excel Workbook"

			Ier = 1
		End Try
	End Sub
	Sub Read_xls(ByVal pSheetName As String)
		Dim Versx As Object

		'PROGRAM OVERALL APPROACH
		' 1. Load bath.xla template
		' 2. Read heading/label material from named ranges in bath.xla
		' 3. ?? WKB disappears when done... so template is unaltered.

		' NOTE THIS SUB USES GLOBAL XLSWORKBK - I'm unable to pass as an argument.


		'reads input data from excel sheet "WKB" formated according to BATH.XLA

		Try
			Ier = 0
			AllZero()


			With XLSWorkBk.Sheets(pSheetName)
				'header
				Versx = .Range("version").Value
				Title = .Range("title").Value

				'dimensions
				Nseg = .Range("Nseg").Value
				NTrib = .Range("Ntrib").Value
				Npipe = .Range("Npipe").Value

				' Parameters & Options
				With .Range("global_factors")
					For i As Integer = 1 To 4
						P(i) = .Offset(i, 2).Value
						Cp(i) = .Offset(i, 3).Value
					Next i
				End With

				'Model Options
				With .Range("model_options")
					For i As Integer = 1 To NOptions
						Iop(i) = .Offset(i, 2).Value
					Next i
				End With

				'Globals
				With .Range("calibration_factors")
					For i As Integer = 1 To NXk
						'XkName(i) = .Offset(i, 0)
						Xk(i) = .Offset(i, 2).Value
						CvXk(i) = .Offset(i, 3).Value
					Next i
				End With

				'Atmospherics
				With .Range("atmos_loads")
					For i As Integer = 1 To NVariables
						'VariableName(i) = .Offset(i, 0)
						Atm(i) = .Offset(i, 2).Value
						CvAtm(i) = .Offset(i, 3).Value
					Next i
				End With

				'Segments
				With .Range("segment_data").Offset(0, 1)
					For i As Integer = 1 To Nseg
						'i = .Offset(1, i)
						SegName(i) = .Offset(2, i).Value
						Iout(i) = .Offset(3, i).Value
						Iag(i) = .Offset(4, i).Value
						Area(i) = .Offset(6, i).Value
						Zmn(i) = .Offset(7, i).Value
						Slen(i) = .Offset(8, i).Value
						Zmxi(i) = .Offset(9, i).Value
						CvZmxi(i) = .Offset(10, i).Value
						Zhyp(i) = .Offset(11, i).Value
						CvZhyp(i) = .Offset(12, i).Value
						Turbi(i) = .Offset(14, i).Value
						CvTurbi(i) = .Offset(15, i).Value

						For j As Integer = 1 To 9
							Cobs(i, j) = .Offset(14 + j * 2, i).Value
							CvCobs(i, j) = .Offset(14 + j * 2 + 1, i).Value
						Next j

						For j As Integer = 1 To 9
							Cal(i, j) = .Offset(33 + j * 2, i).Value
							CvCal(i, j) = .Offset(33 + j * 2 + 1, i).Value
						Next j

						For j As Integer = 1 To 3
							InternalLoad(i, j) = .Offset(53 + j * 2, i).Value
							CvInternalLoad(i, j) = .Offset(53 + j * 2 + 1, i).Value
						Next j

						'Write #1, k, Icrit(i), Targ(i)
					Next i
				End With
				SegName(Nseg + 1) = "AREA-WTD MEAN"

				' c Tribs
				With .Range("Tributary_data").Offset(0, 1)
					For i As Integer = 1 To NTrib
						TribName(i) = .Offset(2, i).Value
						Iseg(i) = .Offset(3, i).Value
						Icode(i) = .Offset(4, i).Value
						Darea(i) = .Offset(5, i).Value
						Flow(i) = .Offset(6, i).Value
						CvFlow(i) = .Offset(7, i).Value

						For j As Integer = 1 To NVariables
							Conci(i, j) = .Offset(6 + 2 * j, i).Value
							CvCi(i, j) = .Offset(6 + 2 * j + 1, i).Value
						Next j

						For j As Integer = 1 To NCAT
							Warea(i, j) = .Offset(18 + j, i).Value
						Next j

						'   Write #1, Ecoreg(i)
					Next i
				End With

				' Channels
				With .Range("transport_channels").Offset(0, 1)
					For i As Integer = 1 To Npipe
						PipeName(i) = .Offset(2, i).Value
						Ifr(i) = .Offset(3, i).Value
						Ito(i) = .Offset(4, i).Value
						Qpipe(i) = .Offset(5, i).Value
						CvQpipe(i) = .Offset(6, i).Value
						Epipe(i) = .Offset(7, i).Value
						CvEpipe(i) = .Offset(8, i).Value
					Next i
				End With

				'export categories
				With .Range("categories").Offset(0, 1)
					For i As Integer = 1 To NCAT
						Dim idx As Integer = .Offset(1, i).Value
						LandUseName(idx) = .Offset(2, i).Value
						Ur(idx) = .Offset(3, i).Value
						CvUr(idx) = .Offset(4, i).Value

						For k As Integer = 1 To NVariables
							Uc(idx, k) = .Offset(3 + k * 2, i).Value
							CvUc(idx, k) = .Offset(3 + k * 2 + 1, i).Value
						Next k
					Next i
				End With

				' notes
				With .Range("notes")
					For i As Integer = 1 To 10
						Note(i) = .Offset(i - 1, 0).Value
					Next i
				End With

				'        MsgBox(("Read_xls: 501: Done Reading Ranges from " & pSheetName)

				'Allocation
				'    Write #1, "Allocation"
				'    For i = 1 To 2
				'        Write #1, Fmax(i), Ecod(i), Qmin(i), Pmax(i)
				'        Next i
				'    Write #1, Ipri(1), Ipri(2), Ipri(3)

				'    Close #1
				'MsgBox( "Input Data Saved"

			End With

		Catch

			'    MsgBox("Error Reading Worksheet - Remember Named Ranges Required"

			Ier = 1
		End Try

	End Sub
	Sub ReadKey()
		Dim k As Integer
		Dim j As Integer

		Try


			'c read key file
			Ier = 0
			Dim wksheet = Wkb.Sheets("Key")
			Dim namedRange As Excel.Name = Wkb.Names.Item("sigma")
			Dim range As Excel.Range = namedRange.RefersToRange
			'With Wkb.Sheets("key")
			Sigma = range.Value2

			namedRange = Wkb.Names.Item("tolerance")
			range = namedRange.RefersToRange
			Tol = range.Value2

			'Dim val2 = .Names.Item("sigma")
			'Dim vals3 = .Names.Item("sigma")

			'Sigma = .Names.Item("sigma").Value2
			'Sigma = .("sigma").Value 'number of standard errors plotted around predicted & observed values
			'Sigma = .Range("sigma").Value 'number of standard errors plotted around predicted & observed values
			'Tol = .Range("tolerance").Value 'tolerance for convergence of mass balance solution


			'diagnostic variables
			namedRange = Wkb.Names.Item("Ndiagnostics")
			range = namedRange.RefersToRange
			NDiagnostics = range.Value2

			For i As Integer = 1 To NDiagnostics
				j = range.Offset(i + 1, 0).Value
				Iord(i) = j
				Ilogd(j) = range.Offset(i + 1, 1).Value
				Cshort_Renamed(j) = range.Offset(i + 1, 2).Value
				DiagName(j) = range.Offset(i + 1, 3).Value
				For k2 As Integer = 1 To 5
					Stat(j, k2) = range.Offset(i + 1, k2 + 3).Value
				Next k2
			Next i

			Nord = NDiagnostics
			'range("ndiagnostics").Offset(1, 0)
			'	For i As Integer = 1 To NDiagnostics
			'		j = .Offset(i, 0).Value 'variable number
			'		Iord(i) = j
			'		Ilogd(j) = .Offset(i, 1).Value
			'		Cshort_Renamed(j) = .Offset(i, 2).Value
			'		DiagName(j) = .Offset(i, 3).Value
			'		For k2 As Integer = 1 To 5
			'			Stat(j, k2) = .Offset(i, k2 + 3).Value
			'		Next k2
			'	Next i
			'End With

			namedRange = Wkb.Names.Item("noptions")
			range = namedRange.RefersToRange
			NOptions = range.Value2
			k = 1
			For i As Integer = 1 To NOptions
				k = k + 1
				Mop(i) = range.Offset(k, 0).Value 'number of options for
				OptionName(i, 0) = range.Offset(k, 1).Value 'option name
				IopDefault(i) = 0
				For j2 As Integer = 1 To Mop(i)
					k = k + 1
					OptionName(i, j2) = range.Offset(k, 1).Value 'label for selection
					If range.Offset(k, 2).Value > 0 Then IopDefault(i) = j2 - 1
				Next j2
				k = k + 1
			Next i
			'End With

			'coefficient labels
			namedRange = Wkb.Names.Item("Ncoef")
			range = namedRange.RefersToRange
			NXk = range.Value2

			'range("ncoef").Offset(1, 0)
			For i As Integer = 1 To NXk
				XkName(i) = range.Offset(i + 1, 1).Value
				XkDefault(i) = range.Offset(i + 1, 2).Value
				CvXkDefault(i) = range.Offset(i + 1, 3).Value
			Next i

			Exit Sub
		Catch ex As Exception
			Dim msg As String = ex.Message
		End Try
		'    MsgBox("Invalid Key File"

		Ier = 1

	End Sub
	Sub ScreenOff()
		Wka.Application.ScreenUpdating = False
	End Sub
	Sub ScreenOn()
		Wka.Application.ScreenUpdating = True
	End Sub
	Function ValidFile(ByVal s As String) As Boolean

		If s = "" Or s.IndexOf("*"c) >= 0 Or (s.ToUpper().IndexOf(".BTB") + 1) = 0 Then
			Return False
		Else
			Return True
		End If

	End Function

	'Sub restric()
	'c restrict output segments
	'If (Nseg <= 0) Then Exit Sub
	'Dummy = "INCLUDED <*> or EXCLUDED < >"
	'Call swint(Izap, Iwork, Nseg + 1)
	'Call SelSeg(Nseg + 1)
	'Call swint(Iwork, Izap, Nseg + 1)
	'Call clr(0)
	'         End Sub

	Sub ShowHelp(ByVal ctxtiD As Integer)
		'0=contents, >0=contexid
		'uses special class module downloaded from internet ----
		Try

			'.CHMFile = Directory & BathtubHelpFile
			'.HHWindow = "main"
			If ctxtiD <= 0 Then
				'hHelp.HHDisplayContents()
			Else
				'hHelp.HHTopicID = ctxtiD
				'hHelp.HHDisplayTopicID()
			End If

		Catch
		End Try


	End Sub
	Sub ListOneSheet(ByVal io As Object)
		'KW
		'Dim sN As String = [sheet_selected]
		Dim sN As String = "sheet_selected"
		ViewSheet(sN)
		Wka.Sheets("menu").Activate()
	End Sub
	Sub Status(ByVal Msg As String)
		'update status box
		If Msg = "Ready" Then
			frmMenu.lblStatus.BackColor = SystemColors.InactiveBorder
		Else
			frmMenu.lblStatus.BackColor = SystemColors.HighlightText
		End If
		frmMenu.lblStatus.Text = Msg
		System.Windows.Forms.Application.DoEvents()
	End Sub

	Sub ViewFileTextBox(ByVal fna As String)
		'view a file as a text box (outputdest=2)
		Dim txt As String = ""

		If FileExists(fna) Then
			FileSystem.FileOpen(1, fna, OpenMode.Input)
			txt = FileSystem.InputString(1, FileSystem.LOF(1))
			' Input #1, txt
			'  Do Until EOF(1)
			'     Line Input #1, lstring
			'      wmax = MAx(wmax, Len(lstring))
			'      txt = txt & lstring & vbCrLf
			'      i = i + 1
			'     Loop
			FileSystem.FileClose(1)

			With frmBox.DefInstance
				.Text = gLSht.Name
				.txtBox.Text = txt
				.txtBox.SelectionStart = 0
				.ShowDialog()
			End With

		End If
	End Sub 'viewfiletextbox

	'Sub ViewSheetRichTextBox(ShtName)
	'view a file as a rich text box (outputdest=2)

	'    gLSht.UsedRange.Copy
	'    frmRtb.Show

	'With frmRtb
	'.rtbOutput.Text = txT
	'.rtbOutput.SelStart = 0
	'.Show
	'End With

	'End Sub
	Sub ViewFileNotepad(ByVal fna As String)
		Dim cline As String = ""
		Dim j As Double
		'view a text file in notepad (outputdest=1)
		If FileExists(fna) Then
			cline = "Notepad " & fna
			'UPGRADE_TODO: (7005) parameters (if any) must be set using the Arguments property of ProcessStartInfo More Information: https://docs.mobilize.net/vbuc/ewis/todos#id-7005
			Dim startInfo As ProcessStartInfo = New ProcessStartInfo(cline)
			startInfo.WindowStyle = ProcessWindowStyle.Normal
			j = Process.Start(startInfo).Id
		End If
	End Sub

	'Sub ViewSheetImage(ShtName As String)
	'view sheet as image not ready
	'    gLSht.UsedRange.CopyPicture Appearance:=xlPrinter, Format:=xlPicture
	'    frmPicture.Show
	'End Sub
	Function VerifyNumber(ByVal s As String) As Boolean
		Return Information.IsNumeric(s) Or s = "." Or s = "-"
	End Function
	Function VerifyPositive(ByVal s As String) As Boolean
		Dim result As Boolean = False
		result = VerifyNumber(s)
		If result Then
			If Conversion.Val(s) < 0 Then result = False
		End If
		Return result
	End Function
	Sub ViewSheet(ByVal SheetName As String)
		Dim savechanges As Object
		'Copy gLSHT (aka wkb.sheet (activesheet?)) to WKO.Sheetname
		'WKO has been set to wka.activeWorkbook
		SheetCopy((SheetName))

		Dim fworK As String = ""
		If Iop(12) = 2 Then
			If Not gRunMetaModels Then
				Wka.Visible = True
				Wka.WindowState = Excel.XlWindowState.xlNormal
			End If
		Else
			fworK = Directory & SheetName & ".prn"
			If FileExists(fworK) Then File.Delete(fworK)
			Wko.Save()
			Wko.SaveAs(fworK, Excel.XlFileFormat.xlTextPrinter, Type.Missing, Type.Missing, Type.Missing, False)
			Wko.Saved = True
			Wko.Close(Not savechanges)
			Wka.Workbooks.Open(Directory & BathOutXLS)
			Wko = Wka.ActiveWorkbook

			If Iop(12) = 1 Then
				ViewFileNotepad(fworK)
			Else
				ViewFileTextBox(fworK)
			End If
			File.Delete(fworK)
		End If

		Status("Ready")
	End Sub 'ViewSheet

	Sub SheetCopy(ByVal SheetName As String)
		Dim j As Integer
		'this is supposed to copy Sheetname from X to WKo (gSheetOut)
		Try 'restart after error stmt
			'WKO is the Bathtub_output.xls workbook
			With Wko
				.Worksheets("Sheet1").Delete()
				.Worksheets("Sheet2").Delete()
				gSheetout = .Worksheets(SheetName)
				.Worksheets(SheetName).Activate()
				If Information.Err().Number > 0 Then
					'MsgBox( ("There is no Sheet in WKo called " & SheetName)
					.Worksheets.Add() 'Create a New Sheet. The (AFTER) option kills the action entirely?
					.Sheets(1).Name = SheetName 'was .activesheet.name Give it the desired name
					gSheetout = .Sheets(1) '.ActiveSheet       'Use it
					.Worksheets("sheet3").Delete() 'now this can be dumped
					Wka.ActiveWindow.DisplayGridlines = False
				End If
			End With

		Catch
		End Try
		'On error, bail out and let the caller handle any errors 'Exit
		gSheetout.Cells.Clear() 'Start with a Clean Output Sheet

		'WKB is the basic template called Bath.xla
		Wkb.Worksheets(SheetName).Activate()
		If Information.Err().Number > 0 Then
			MsgBox("PgmErr 22: " & SheetName & " Is not in the Template?")
		End If
		gLSht = Wkb.Worksheets(SheetName)

		With CType(gLSht, Excel.Worksheet)
			' Get the number of columns in the used range
			j = .UsedRange.Columns.Count
			' Save the Column Widths from the Template A column for use below
			For i As Integer = 1 To j
				x(i) = .Range("A1").Offset(0, i - 1).ColumnWidth
			Next i
			' Copy the used range to gSheetout at A1
			.UsedRange.Copy(gSheetout.Range("A1"))
		End With

		gSheetout.Activate()
		' Reset the Column Widths
		For i As Integer = 1 To j
			gSheetout.Range("A1").Offset(0, i - 1).ColumnWidth = x(i)
		Next i
		gSheetout.Range("A1").Select()

		Wka.CutCopyMode = False
		'    ScreenOn()

	End Sub
	'End of SheetCopy

	'Sub RestartExcel()
	'Ier = 0
	'    On Error GoTo Abhort
	'        Set Wko = Nothing
	'        Set Wkb = Nothing
	'        Set Wka = Nothing
	'        Set Wka = New Excel.Application
	'        Wka.Workbooks.Open FileName:=Directory & BathBook
	'        Set Wkb = Wka.Workbooks(BathBook)
	'        Set Hdr = Wkb.Sheets("headers")   'table headings sheet'
	'        Wka.WindowState = xlMinimized
	'        Wka.Workbooks.Add
	'        Kill Directory & BathOutXLS
	'        Wka.ActiveWorkbook.SaveAs FileName:=Directory & BathOutXLS
	'        Set Wko = Wka.ActiveWorkbook       'bathtub_output.xls workbook
	'        Exit Sub
	'Abhort:
	'    Ier = 1
	'    MsgBox( "Could not load Excel - can't continue"
	'    Err.Clear
	'End Sub


	'Sub LoadXLSInputApp(ByVal pFilename As String)
	'	Ier = 0
	'	'UPGRADE_TODO: (1069) Error handling statement (On Error Resume Next) was converted to a pattern that might have a different behavior. More Information: https://docs.mobilize.net/vbuc/ewis/todos#id-1069
	'	Try
	'		'
	'		'Err.Clear
	'		'On Error GoTo Abhort

	'		'    MsgBox(("load xlsinputapp")
	'		
	'		Dim XLSInputApp As New Excel.Application()
	'		XLSInputApp.Workbooks.Open(pFilename)
	'		'Set XLSInputBook = XLSInputApp.Workbooks(pBookName)
	'		Dim XLSInputSheet As Object = XLSInputApp.Sheets(0)


	'		'Abhort:
	'		'MsgBox( "Could not load Excel (can't continue)- try closing Excel then restarting BATHTUB"
	'		'Ier = 1
	'		'Err.Clear

	'	Catch exc As Exception
	'		NotUpgradedHelper.NotifyNotUpgradedElement("Resume in On-Error-Resume-Next Block")
	'	End Try

	'End Sub


	Sub LoadExcel()
		Dim savechange As Object
		Dim DebugCount, i As Integer
		Dim realversion As Double
		'Dim LWrkbooks As Workbooks
		Ier = 0
		'UPGRADE_TODO: (1069) Error handling statement (On Error Resume Next) was converted to a pattern that might have a different behavior. More Information: https://docs.mobilize.net/vbuc/ewis/todos#id-1069
		Dim resume2 As Boolean = True
		Try
			Dim Abend2 As Boolean = False
			Dim Abhort As Boolean = False

			If DebugMode Then
				i = Wkb.Worksheets.Count
				'        MsgBox(("Wkb worksheets.count=" & Str(i))

			End If

			Try
				If Information.Err().Number = 0 And i > 0 Then 'do nothing
				Else
					Information.Err().Clear()
					Abhort = True
					Abend2 = False

					' NO! DEFINE NEW EXCEL OBJECTS
					' XLSInputApp is now set in main ONCE
					' Set XLSInputApp = CreateObject("Excel.Application") 'excel object for input
					'NO! Set Wka = Nothing
					'NO! Set Wka = CreateObject("Excel.Application")
					'But we must CLEAR wka (close it) if it is open.
					If DebugMode Then MsgBox("DEBUG 07 Excel Version: " & Wka.Version & " " & Str(DebugCount))

					DebugCount += 1
					If (Wka Is Nothing) Then MsgBox("N399: Fatal Error, Input Worksheet does not exist")

					'KW
					frmMenu.VersionofExcel.Text = Wka.Version
					'If Wka.Workbooks.Count > 0 Then
					'For Each Lwb In Wka.Workbooks
					'   MsgBox( (Lwb.Name)
					'  Next Lwb
					'End If

					Dim bath_book As String = Directory & BathBook
					'Dim bath_book As String = "D:\Bathtub\XLA_Reader\XLA_Reader\bin\Debug\net8.0-windows\bath.xlsx"					
					If gxla_Loaded = False Then ' Start fresh
						If DebugMode2 Then MsgBox("Opening WKA.Workbooks " & bath_book)

						Wka.Workbooks.Open(bath_book)
						If DebugMode Then MsgBox("DEBUG 08 Open Wka workbook " & BathBook & " " & Str(DebugCount))
						DebugCount += 1
					Else
						'MAJOR CHANGE - CLOSE OUT ANY EXISTING BATHOUTXLS
						'This is the key to changing content of the output, we must close the
						'bathtub_output.xls before RELOADING
						If Wka.Workbooks.Count > 0 Then
							If DebugMode2 Then MsgBox("LoadExcel is closing wko")

							Wka.Workbooks(BathOutXLS).Close(Not CBool(savechange))
						End If
					End If
					Wkb = Wka.Workbooks(BathBook)
					'Wko = Wka.ActiveWorkbook

					If Wkb Is Nothing Then MsgBox("N555: FATAL wkb is null")
					If DebugMode Then MsgBox("DEBUG 09 set wkB to Workbooks OK" & Str(DebugCount))
					DebugCount += 1

					gxla_Loaded = True
					'MsgBox( ("opened " & BathBook)
					'Wka.Calculation = xlCalculationManual
					' NO NO If Wkb <> Then Wkb.Close False

					Hdr = Wkb.Sheets("headers") 'table headings sheet
					If DebugMode Then MsgBox("DEBUG 10 set Excel Sheet Hdr OK" & Str(DebugCount))

					DebugCount += 1
					If Not DebugMode Then Wka.EnableEvents = True
					If DebugMode Then MsgBox("DEBUG 10B Excel.EnableEvents Skipped" & Str(DebugCount))

					DebugCount += 1
					realversion = CDbl(Wka.Version)
					If (realversion < 15) Then Wka.WindowState = Excel.XlWindowState.xlMinimized
					If DebugMode Then MsgBox("DEBUG 11 EXCEL.WindowState xlMinimized OK" & Str(DebugCount))

					DebugCount += 1
					Wka.Visible = True

					If DebugMode Then MsgBox("DEBUG 12 Excel Setup Done" & Str(DebugCount))

					DebugCount += 1
				End If

				'bathtub_output.xls				
				resume2 = True

				If DebugMode Then MsgBox("DEBUG 13 Talking to Excel OK" & Str(DebugCount))
				DebugCount += 1
				'i = Wko.Worksheets.Count
				If Information.Err().Number = 0 And i > 0 Then 'do nothing
					'MessageBox.Show("WKO Worksheet is OK to use")
				Else
					'MessageBox.Show("Creating Output Worksheet- this is NOT a separate workbook!")
					Information.Err().Clear()
					Abend2 = True
					Abhort = False
					'Create the new output workbook
					'Dispose of any old junk first
					If DebugMode Then MsgBox("DEBUG 13a Ready to Add Workbooks to Wka")
					If FileExists(Directory & BathOutXLS) Then File.Delete(Directory & BathOutXLS)
					Wka.Workbooks.Add()
					Wka.ActiveWorkbook.SaveAs(Directory & BathOutXLS, XlFileFormat.xlWorkbookDefault)
					If DebugMode2 Then MsgBox("N1: Loadexcel Init of bathtub_output.xls")
					Wko = Wka.ActiveWorkbook 'bathtub_output.xls workbook
					If DebugMode Then MsgBox("DEBUG 14 Output Workbook (WKO) Set @dbg " & Str(DebugCount))
					DebugCount += 1
					Wka.Application.Calculation = Excel.XlCalculation.xlCalculationManual
				End If

				resume2 = False
				'    Status "end load"
				Exit Sub

			Catch excep As Exception
				If Not Abend2 And Not Abhort Then
					Throw excep
				End If

				If Abend2 Then

					MsgBox("E102: Could not Create an Output Workbook in Excel - Bathtub Must Abort")
					Ier = 1
					Information.Err().Clear()
					Exit Sub


				End If
				If Abhort Or Abend2 Then
					MessageBox.Show("E101: Failure in Sub LoadExcel (Bathtub Can't Continue)- try closing Excel then restarting BATHTUB")
					Ier = 1
					Information.Err().Clear()
				End If
			End Try

		Catch exc As Exception
			NotUpgradedHelper.NotifyNotUpgradedElement("Resume in On-Error-Resume-Next Block")
			If Not resume2 Then
				Throw exc
			End If
		End Try
	End Sub

	Sub LoadExcel4()
		'Dim savechange As Object
		Dim DebugCount, i As Integer
		Dim realversion As Double
		Ier = 0
		Try
			If DebugMode Then
				i = Wka.Worksheets.Count
				MessageBox.Show("Wkb worksheets.count=" & i.ToString())
			End If

			If Wka.Workbooks.Count = 0 Then
				If DebugMode Then MessageBox.Show("DEBUG 07 Excel Version: " & Wka.Version & " " & DebugCount.ToString())
				DebugCount += 1

				If Wka Is Nothing Then
					MessageBox.Show("N399: Fatal Error, Input Worksheet does not exist")
					Return
				End If

				' Assuming frmMenu is a form with a label control named VersionofExcel
				' frmMenu.VersionofExcel.Text = Wka.Version

				If Not gxla_Loaded Then
					If DebugMode2 Then MessageBox.Show("Opening WKA.Workbooks " & Directory & BathBook)
					Wka.Workbooks.Open(Path.Combine(Directory, BathBook))
					If DebugMode Then MessageBox.Show("DEBUG 08 Open Wka workbook " & BathBook & " " & DebugCount.ToString())
					DebugCount += 1
				Else
					If Wka.Workbooks.Count > 0 Then
						If DebugMode2 Then MessageBox.Show("LoadExcel is closing wko")
						Wka.Workbooks(BathOutXLS).Close(SaveChanges:=False)
					End If
				End If

				Wkb = Wka.Workbooks(BathBook)
				Wko = Wka.ActiveWorkbook
				If Wkb Is Nothing Then
					MessageBox.Show("N555: FATAL wkb is null")
					Return
				End If

				If DebugMode Then MessageBox.Show("DEBUG 09 set wkB to Workbooks OK" & DebugCount.ToString())
				DebugCount += 1

				gxla_Loaded = True

				Hdr = Wkb.Sheets("headers")
				If DebugMode Then MessageBox.Show("DEBUG 10 set Excel Sheet Hdr OK" & DebugCount.ToString())
				DebugCount += 1

				If Not DebugMode Then Wka.EnableEvents = True
				If DebugMode Then MessageBox.Show("DEBUG 10B Excel.EnableEvents Skipped" & DebugCount.ToString())
				DebugCount += 1

				realversion = Convert.ToDouble(Wka.Version)
				If realversion < 15 Then Wka.WindowState = XlWindowState.xlMinimized
				If DebugMode Then MessageBox.Show("DEBUG 11 EXCEL.WindowState xlMinimized OK" & DebugCount.ToString())
				DebugCount += 1

				Wka.Visible = True

				If DebugMode Then MessageBox.Show("DEBUG 12 Excel Setup Done" & DebugCount.ToString())
				DebugCount += 1
			End If

			If DebugMode Then MessageBox.Show("DEBUG 13 Talking to Excel OK" & DebugCount.ToString())
			DebugCount += 1
			i = Wko.Worksheets.Count
			If i > 0 Then
				Exit Sub
			End If


			'If Wka.Workbooks.Count = 0 Then
			If DebugMode Then MessageBox.Show("DEBUG 13a Ready to Add Workbooks to Wka")
			If File.Exists(Path.Combine(Directory, BathOutXLS)) Then File.Delete(Path.Combine(Directory, BathOutXLS))
			Wka.Workbooks.Add()
			Wka.ActiveWorkbook.SaveAs(Filename:=Path.Combine(Directory, BathOutXLS), FileFormat:=XlFileFormat.xlWorkbookDefault)
			If DebugMode2 Then MessageBox.Show("N1: Loadexcel Init of bathtub_output.xls")
			Wko = Wka.ActiveWorkbook
			If DebugMode Then MessageBox.Show("DEBUG 14 Output Workbook (WKO) Set @dbg " & DebugCount.ToString())
			DebugCount += 1
			Wka.Application.Calculation = XlCalculation.xlCalculationManual


		Catch ex As Exception
			MessageBox.Show("E101: Failure in Sub LoadExcel")
			Ier = 1
		Finally

		End Try
	End Sub

	Sub SetPrintArea()
		' set print area to all used cells in the current worksheet
		gLSht.UsedRange.Name = "print_area"
	End Sub
	Sub ClearOutputWorkbook()
		Dim i As Integer
		'clears output workbook without changing name
		'this runs after existing case is edited
		If (Wko Is Nothing) Then
			'If DebugMode Then MessageBox.Show("Module1 N32: WKO is Nothing")
			Exit Sub
		End If
		With Wko
			i = .Sheets.Count
			If i <= 0 Then Exit Sub
			Wka.DisplayAlerts = False
			For j As Integer = 1 To i - 1
				.Sheets(1).Delete()
			Next j
			.Sheets(1).Cells.Clear()
			.Sheets(1).Name = "Sheet1"
		End With
		Wka.DisplayAlerts = True
	End Sub

	Sub ClearOutput()
		'start a new output workbook
		'this runs whenenever output destination is changed or new case is read		
		Try

			If Wka Is Nothing Then
				If DebugMode Then MessageBox.Show("Module1 N33: Loading Excel")
				If DebugMode2 Then MsgBox("ClearOutput is Loading Excel again")
				LoadExcel()
				If Ier > 0 Then Exit Sub
			End If

			If Wko IsNot Nothing Then
				Wko.Close(False)
				Wko = Nothing
			End If

			If DebugMode Then MsgBox("Module1 N30: WKO Closed: " & Wko.Name)

		Catch exc As Exception

		End Try
		FormUpdate()
		Dim realversion As Double = CDbl(Wka.Version)
		If (realversion < 15) Then Wka.WindowState = Excel.XlWindowState.xlMinimized
	End Sub

	Sub Backup(ByVal io As Integer)
		Dim IfilE As String = ""
		' io=0 backup file, 1=restore backup
		Dim Ofile As String = ""

		Try

			Ofile = Directory & BackupFile
			If io = 0 Then
				'save
				Save_btb((Ofile))
				If Ier > 0 Then Throw New Exception()
			Else
				'restore
				IfilE = CaseFile
				Read_btb((Ofile))
				If Ier > 0 Then Throw New Exception()
				CaseFile = IfilE
				WorkingDirectory = ExtractPath(CaseFile)
			End If

		Catch
			MessageBox.Show("Error Creating or Restoring Edit Backup File")
		End Try
	End Sub

	Public Function GetFileName(ByVal flname As String) As String

		Dim fileNameWithoutExtension As String = Path.GetFileNameWithoutExtension(flname)
		Return fileNameWithoutExtension

		''Get the filename without the path or extension.
		''Input Values:
		''   flname - path and filename of file.
		''Return Value:
		''   GetFileName - name of file without the extension.


		'Dim posn As Integer = 0
		''find the position of the last "\" character in filename
		'For i As Integer = 1 To Strings.Len(flname)
		'	If (flname.Substring(Math.Min(i - 1, flname.Length), Math.Min(1, Math.Max(0, flname.Length - (i - 1)))) = "\") Then posn = i
		'Next i

		''get filename without path
		'Dim Fname As String = flname.Substring(Math.Max(flname.Length - (Strings.Len(flname) - posn), 0))

		''get filename without extension
		'posn = (Fname.IndexOf("."c) + 1)
		'If posn <> 0 Then
		'	Fname = Fname.Substring(0, Math.Min(posn - 1, Fname.Length))
		'End If
		'Return Fname
	End Function
End Module