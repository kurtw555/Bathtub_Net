<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As frmMenu
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As frmMenu
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = CreateInstance()
				m_InitializingDefInstance = False
			End If
			Return m_vb6FormDefInstance
		End Get
		Set(ByVal Value As frmMenu)
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region
#Region "Windows Form Designer generated code "
	Public Shared Function CreateInstance() As frmMenu
		Dim theInstance As New frmMenu()
		theInstance.Form_Load()
		Return theInstance
	End Function
	Dim fTerminateCalled_form_terminate As Boolean
	Private visualControls() As String = New String() {"components", "ToolTipMain", "mnuRead_CaseFile", "mnuRead_Worksheet", "mnuReadCase", "mnuTranslateCase", "mnuSaveCase", "mnuSaveCaseAs", "mnuNewCase", "mnuReadDefault", "mnuSaveWorksheet", "mnuReadWorksheet", "mnuCase", "mnuModels", "mnuGlobals", "mnuSegments", "mnuTributaries", "mnuLandUses", "mnuChannels", "mnuCoefficients", "mnuWorksheet", "mnuEdit", "mnuRunModel", "mnuRunSensitivity", "mnuLoadResponse", "mnuCalibration", "mnuRun", "mnuListInputs", "mnuListNetwork", "mnuListHydraulics", "mnuListGrossBalances", "mnuListSegBal", "mnuListSummary", "mnuListErrors", "mnuMassBalances", "_mnuListDiagnostics_0", "_mnuListDiagnostics_1", "mnuListProfiles", "mnuListTTests", "mnuListStatistics", "mnuListErrorMessages", "mnnListAll", "mnuList", "mnuChart", "_mnuwarnings_0", "_mnuwarnings_1", "_mnuwarn_0", "_mnuUser_0", "_mnuUser_1", "mnu_debugMode", "mnuU", "mnuOptions", "mnuHelpContents", "mnuAbout", "mnuHelp", "mnuQuit", "MainMenu1", "btnClearOutput", "btnSaveOutput", "ContinueBtn", "cmbUserMode", "cmbOutputDest", "btnRun", "btnErrorMessages", "txtReport", "CommonDialog1Open", "CommonDialog1Save", "CommonDialog1", "ExcelVersionLabel", "Label1", "VersionofExcel", "Label2", "lblOutputWorkbook", "StatusLabel", "lblStatus", "mnuListDiagnostics", "mnuUser", "mnuwarn", "mnuwarnings", "commandButtonHelper1"}
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTipMain As System.Windows.Forms.ToolTip
	Public WithEvents mnuRead_CaseFile As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuRead_Worksheet As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuReadCase As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuTranslateCase As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuSaveCase As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuSaveCaseAs As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuNewCase As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuReadDefault As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuSaveWorksheet As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuReadWorksheet As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuCase As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuModels As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuGlobals As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuSegments As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuTributaries As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuLandUses As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuChannels As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuCoefficients As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuWorksheet As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuEdit As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuRunModel As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuRunSensitivity As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuLoadResponse As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuCalibration As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuRun As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuListInputs As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuListNetwork As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuListHydraulics As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuListGrossBalances As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuListSegBal As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuListSummary As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuListErrors As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuMassBalances As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents _mnuListDiagnostics_0 As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents _mnuListDiagnostics_1 As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuListProfiles As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuListTTests As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuListStatistics As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuListErrorMessages As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnnListAll As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuList As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuChart As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents _mnuwarnings_0 As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents _mnuwarnings_1 As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents _mnuwarn_0 As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents _mnuUser_0 As System.Windows.Forms.ToolStripMenuItem
	Private WithEvents _mnuUser_1 As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnu_debugMode As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuU As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuOptions As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuHelpContents As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuAbout As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuHelp As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuQuit As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents MainMenu1 As System.Windows.Forms.MenuStrip
	Public WithEvents btnClearOutput As System.Windows.Forms.Button
	Public WithEvents btnSaveOutput As System.Windows.Forms.Button
	Public WithEvents ContinueBtn As System.Windows.Forms.Button
	Public WithEvents cmbUserMode As System.Windows.Forms.ComboBox
	Public WithEvents cmbOutputDest As System.Windows.Forms.ComboBox
	Public WithEvents btnRun As System.Windows.Forms.Button
	Public WithEvents btnErrorMessages As System.Windows.Forms.Button
	Public WithEvents txtReport As System.Windows.Forms.TextBox
	Public CommonDialog1Open As System.Windows.Forms.OpenFileDialog
	Public CommonDialog1Save As System.Windows.Forms.SaveFileDialog
	Public CommonDialog1 As BT2Support.UpgradeStubs.AxMSComDlg_AxCommonDialog
	Public WithEvents ExcelVersionLabel As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents VersionofExcel As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents lblOutputWorkbook As System.Windows.Forms.Label
	Public WithEvents StatusLabel As System.Windows.Forms.Label
	Public WithEvents lblStatus As System.Windows.Forms.Label
	Public mnuListDiagnostics(1) As System.Windows.Forms.ToolStripItem
	Public mnuUser(1) As System.Windows.Forms.ToolStripItem
	Public mnuwarn(0) As System.Windows.Forms.ToolStripItem
	Public mnuwarnings(1) As System.Windows.Forms.ToolStripItem
	Public commandButtonHelper1 As UpgradeHelpers.Gui.Controls.CommandButtonHelper
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        ToolTipMain = New ToolTip(components)
        btnClearOutput = New Button()
        btnSaveOutput = New Button()
        ContinueBtn = New Button()
        cmbUserMode = New ComboBox()
        cmbOutputDest = New ComboBox()
        btnRun = New Button()
        btnErrorMessages = New Button()
        txtReport = New TextBox()
        lblOutputWorkbook = New Label()
        lblStatus = New Label()
        MainMenu1 = New MenuStrip()
        mnuCase = New ToolStripMenuItem()
        mnuReadCase = New ToolStripMenuItem()
        mnuRead_CaseFile = New ToolStripMenuItem()
        mnuRead_Worksheet = New ToolStripMenuItem()
        mnuTranslateCase = New ToolStripMenuItem()
        mnuSaveCase = New ToolStripMenuItem()
        mnuSaveCaseAs = New ToolStripMenuItem()
        mnuNewCase = New ToolStripMenuItem()
        mnuReadDefault = New ToolStripMenuItem()
        mnuSaveWorksheet = New ToolStripMenuItem()
        mnuReadWorksheet = New ToolStripMenuItem()
        mnuEdit = New ToolStripMenuItem()
        mnuModels = New ToolStripMenuItem()
        mnuGlobals = New ToolStripMenuItem()
        mnuSegments = New ToolStripMenuItem()
        mnuTributaries = New ToolStripMenuItem()
        mnuLandUses = New ToolStripMenuItem()
        mnuChannels = New ToolStripMenuItem()
        mnuCoefficients = New ToolStripMenuItem()
        mnuWorksheet = New ToolStripMenuItem()
        mnuRun = New ToolStripMenuItem()
        mnuRunModel = New ToolStripMenuItem()
        mnuRunSensitivity = New ToolStripMenuItem()
        mnuLoadResponse = New ToolStripMenuItem()
        mnuCalibration = New ToolStripMenuItem()
        mnuList = New ToolStripMenuItem()
        mnuListInputs = New ToolStripMenuItem()
        mnuListNetwork = New ToolStripMenuItem()
        mnuListHydraulics = New ToolStripMenuItem()
        mnuMassBalances = New ToolStripMenuItem()
        mnuListGrossBalances = New ToolStripMenuItem()
        mnuListSegBal = New ToolStripMenuItem()
        mnuListSummary = New ToolStripMenuItem()
        mnuListErrors = New ToolStripMenuItem()
        _mnuListDiagnostics_0 = New ToolStripMenuItem()
        _mnuListDiagnostics_1 = New ToolStripMenuItem()
        mnuListProfiles = New ToolStripMenuItem()
        mnuListTTests = New ToolStripMenuItem()
        mnuListStatistics = New ToolStripMenuItem()
        mnuListErrorMessages = New ToolStripMenuItem()
        mnnListAll = New ToolStripMenuItem()
        mnuChart = New ToolStripMenuItem()
        mnuOptions = New ToolStripMenuItem()
        _mnuwarn_0 = New ToolStripMenuItem()
        _mnuwarnings_0 = New ToolStripMenuItem()
        _mnuwarnings_1 = New ToolStripMenuItem()
        mnuU = New ToolStripMenuItem()
        _mnuUser_0 = New ToolStripMenuItem()
        _mnuUser_1 = New ToolStripMenuItem()
        mnu_debugMode = New ToolStripMenuItem()
        mnuHelp = New ToolStripMenuItem()
        mnuHelpContents = New ToolStripMenuItem()
        mnuAbout = New ToolStripMenuItem()
        mnuQuit = New ToolStripMenuItem()
        CommonDialog1Open = New OpenFileDialog()
        CommonDialog1Save = New SaveFileDialog()
        CommonDialog1 = New BT2Support.UpgradeStubs.AxMSComDlg_AxCommonDialog()
        ExcelVersionLabel = New Label()
        Label1 = New Label()
        VersionofExcel = New Label()
        Label2 = New Label()
        StatusLabel = New Label()
        commandButtonHelper1 = New UpgradeHelpers.Gui.Controls.CommandButtonHelper(components)
        MainMenu1.SuspendLayout()
        CType(commandButtonHelper1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnClearOutput
        ' 
        btnClearOutput.AllowDrop = True
        btnClearOutput.BackColor = SystemColors.Control
        commandButtonHelper1.SetCorrectEventsBehavior(btnClearOutput, True)
        commandButtonHelper1.SetDisabledPicture(btnClearOutput, Nothing)
        commandButtonHelper1.SetDownPicture(btnClearOutput, Nothing)
        btnClearOutput.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnClearOutput.ForeColor = SystemColors.ControlText
        btnClearOutput.Location = New Point(72, 384)
        commandButtonHelper1.SetMaskColor(btnClearOutput, Color.Silver)
        btnClearOutput.Name = "btnClearOutput"
        btnClearOutput.RightToLeft = RightToLeft.No
        btnClearOutput.Size = New Size(90, 33)
        commandButtonHelper1.SetStyle(btnClearOutput, 0)
        btnClearOutput.TabIndex = 14
        btnClearOutput.Text = "Clear Output"
        btnClearOutput.TextImageRelation = TextImageRelation.ImageAboveText
        ToolTipMain.SetToolTip(btnClearOutput, "Clear all sheets in excel output workbook")
        btnClearOutput.UseVisualStyleBackColor = False
        ' 
        ' btnSaveOutput
        ' 
        btnSaveOutput.AllowDrop = True
        btnSaveOutput.BackColor = SystemColors.Control
        commandButtonHelper1.SetCorrectEventsBehavior(btnSaveOutput, True)
        commandButtonHelper1.SetDisabledPicture(btnSaveOutput, Nothing)
        commandButtonHelper1.SetDownPicture(btnSaveOutput, Nothing)
        btnSaveOutput.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnSaveOutput.ForeColor = SystemColors.ControlText
        btnSaveOutput.Location = New Point(200, 384)
        commandButtonHelper1.SetMaskColor(btnSaveOutput, Color.Silver)
        btnSaveOutput.Name = "btnSaveOutput"
        btnSaveOutput.RightToLeft = RightToLeft.No
        btnSaveOutput.Size = New Size(90, 33)
        commandButtonHelper1.SetStyle(btnSaveOutput, 0)
        btnSaveOutput.TabIndex = 13
        btnSaveOutput.Text = "Save Output"
        btnSaveOutput.TextImageRelation = TextImageRelation.ImageAboveText
        ToolTipMain.SetToolTip(btnSaveOutput, "Save current output workbook to a new file")
        btnSaveOutput.UseVisualStyleBackColor = False
        ' 
        ' ContinueBtn
        ' 
        ContinueBtn.AllowDrop = True
        ContinueBtn.BackColor = SystemColors.Control
        commandButtonHelper1.SetCorrectEventsBehavior(ContinueBtn, True)
        commandButtonHelper1.SetDisabledPicture(ContinueBtn, Nothing)
        commandButtonHelper1.SetDownPicture(ContinueBtn, Nothing)
        ContinueBtn.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        ContinueBtn.ForeColor = SystemColors.ControlText
        ContinueBtn.Location = New Point(280, 75)
        commandButtonHelper1.SetMaskColor(ContinueBtn, Color.Silver)
        ContinueBtn.Name = "ContinueBtn"
        ContinueBtn.RightToLeft = RightToLeft.No
        ContinueBtn.Size = New Size(73, 33)
        commandButtonHelper1.SetStyle(ContinueBtn, 0)
        ContinueBtn.TabIndex = 9
        ContinueBtn.Text = "Continue"
        ContinueBtn.TextImageRelation = TextImageRelation.ImageAboveText
        ToolTipMain.SetToolTip(ContinueBtn, "List error messages")
        ContinueBtn.UseVisualStyleBackColor = False
        ContinueBtn.Visible = False
        ' 
        ' cmbUserMode
        ' 
        cmbUserMode.AllowDrop = True
        cmbUserMode.BackColor = SystemColors.Window
        cmbUserMode.DropDownStyle = ComboBoxStyle.DropDownList
        cmbUserMode.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        cmbUserMode.ForeColor = SystemColors.WindowText
        cmbUserMode.Location = New Point(8, 80)
        cmbUserMode.Name = "cmbUserMode"
        cmbUserMode.RightToLeft = RightToLeft.No
        cmbUserMode.Size = New Size(129, 24)
        cmbUserMode.TabIndex = 8
        ToolTipMain.SetToolTip(cmbUserMode, "Select user mode (standard or advanced)")
        ' 
        ' cmbOutputDest
        ' 
        cmbOutputDest.AllowDrop = True
        cmbOutputDest.BackColor = SystemColors.Window
        cmbOutputDest.DropDownStyle = ComboBoxStyle.DropDownList
        cmbOutputDest.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        cmbOutputDest.ForeColor = SystemColors.WindowText
        cmbOutputDest.Location = New Point(136, 280)
        cmbOutputDest.Name = "cmbOutputDest"
        cmbOutputDest.RightToLeft = RightToLeft.No
        cmbOutputDest.Size = New Size(169, 24)
        cmbOutputDest.TabIndex = 6
        ToolTipMain.SetToolTip(cmbOutputDest, "Select destination for output listings")
        ' 
        ' btnRun
        ' 
        btnRun.AllowDrop = True
        btnRun.BackColor = SystemColors.Control
        commandButtonHelper1.SetCorrectEventsBehavior(btnRun, True)
        commandButtonHelper1.SetDisabledPicture(btnRun, Nothing)
        commandButtonHelper1.SetDownPicture(btnRun, Nothing)
        btnRun.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnRun.ForeColor = SystemColors.ControlText
        btnRun.Location = New Point(152, 75)
        commandButtonHelper1.SetMaskColor(btnRun, Color.Silver)
        btnRun.Name = "btnRun"
        btnRun.RightToLeft = RightToLeft.No
        btnRun.Size = New Size(57, 33)
        commandButtonHelper1.SetStyle(btnRun, 0)
        btnRun.TabIndex = 4
        btnRun.Text = "Run"
        btnRun.TextImageRelation = TextImageRelation.ImageAboveText
        ToolTipMain.SetToolTip(btnRun, "Run the model")
        btnRun.UseVisualStyleBackColor = False
        ' 
        ' btnErrorMessages
        ' 
        btnErrorMessages.AllowDrop = True
        btnErrorMessages.BackColor = SystemColors.Control
        commandButtonHelper1.SetCorrectEventsBehavior(btnErrorMessages, True)
        commandButtonHelper1.SetDisabledPicture(btnErrorMessages, Nothing)
        commandButtonHelper1.SetDownPicture(btnErrorMessages, Nothing)
        btnErrorMessages.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnErrorMessages.ForeColor = SystemColors.ControlText
        btnErrorMessages.Location = New Point(208, 75)
        commandButtonHelper1.SetMaskColor(btnErrorMessages, Color.Silver)
        btnErrorMessages.Name = "btnErrorMessages"
        btnErrorMessages.RightToLeft = RightToLeft.No
        btnErrorMessages.Size = New Size(73, 33)
        commandButtonHelper1.SetStyle(btnErrorMessages, 0)
        btnErrorMessages.TabIndex = 3
        btnErrorMessages.Text = "Errors"
        btnErrorMessages.TextImageRelation = TextImageRelation.ImageAboveText
        ToolTipMain.SetToolTip(btnErrorMessages, "List error messages")
        btnErrorMessages.UseVisualStyleBackColor = False
        ' 
        ' txtReport
        ' 
        txtReport.AcceptsReturn = True
        txtReport.AllowDrop = True
        txtReport.BackColor = SystemColors.InactiveBorder
        txtReport.Cursor = Cursors.IBeam
        txtReport.Font = New Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtReport.ForeColor = SystemColors.WindowText
        txtReport.Location = New Point(8, 120)
        txtReport.MaxLength = 0
        txtReport.Multiline = True
        txtReport.Name = "txtReport"
        txtReport.ReadOnly = True
        txtReport.RightToLeft = RightToLeft.No
        txtReport.Size = New Size(361, 145)
        txtReport.TabIndex = 1
        txtReport.Text = "Text1"
        ToolTipMain.SetToolTip(txtReport, "Description of current case")
        ' 
        ' lblOutputWorkbook
        ' 
        lblOutputWorkbook.AllowDrop = True
        lblOutputWorkbook.BackColor = SystemColors.Control
        lblOutputWorkbook.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblOutputWorkbook.ForeColor = SystemColors.ControlText
        lblOutputWorkbook.Location = New Point(136, 320)
        lblOutputWorkbook.MinimumSize = New Size(233, 25)
        lblOutputWorkbook.Name = "lblOutputWorkbook"
        lblOutputWorkbook.RightToLeft = RightToLeft.No
        lblOutputWorkbook.Size = New Size(233, 25)
        lblOutputWorkbook.TabIndex = 5
        lblOutputWorkbook.Text = "Label2"
        ToolTipMain.SetToolTip(lblOutputWorkbook, "Name of the Excel workbook used to store output")
        ' 
        ' lblStatus
        ' 
        lblStatus.AllowDrop = True
        lblStatus.BackColor = SystemColors.InactiveBorder
        lblStatus.BorderStyle = BorderStyle.Fixed3D
        lblStatus.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        lblStatus.ForeColor = SystemColors.WindowText
        lblStatus.Location = New Point(76, 40)
        lblStatus.MinimumSize = New Size(193, 25)
        lblStatus.Name = "lblStatus"
        lblStatus.RightToLeft = RightToLeft.No
        lblStatus.Size = New Size(193, 25)
        lblStatus.TabIndex = 0
        lblStatus.Text = "Ready"
        lblStatus.TextAlign = ContentAlignment.TopCenter
        ToolTipMain.SetToolTip(lblStatus, "Program Activity")
        ' 
        ' MainMenu1
        ' 
        MainMenu1.Items.AddRange(New ToolStripItem() {mnuCase, mnuEdit, mnuRun, mnuList, mnuChart, mnuOptions, mnuHelp, mnuQuit})
        MainMenu1.Location = New Point(0, 0)
        MainMenu1.Name = "MainMenu1"
        MainMenu1.Size = New Size(378, 24)
        MainMenu1.TabIndex = 15
        ' 
        ' mnuCase
        ' 
        mnuCase.DropDownItems.AddRange(New ToolStripItem() {mnuReadCase, mnuTranslateCase, mnuSaveCase, mnuSaveCaseAs, mnuNewCase, mnuReadDefault, mnuSaveWorksheet, mnuReadWorksheet})
        mnuCase.Name = "mnuCase"
        mnuCase.Size = New Size(44, 20)
        mnuCase.Text = "&Case"
        ' 
        ' mnuReadCase
        ' 
        mnuReadCase.DropDownItems.AddRange(New ToolStripItem() {mnuRead_CaseFile, mnuRead_Worksheet})
        mnuReadCase.Name = "mnuReadCase"
        mnuReadCase.Size = New Size(159, 22)
        mnuReadCase.Text = "&Read"
        ' 
        ' mnuRead_CaseFile
        ' 
        mnuRead_CaseFile.Name = "mnuRead_CaseFile"
        mnuRead_CaseFile.Size = New Size(166, 22)
        mnuRead_CaseFile.Text = "Case File (.btb)"
        ' 
        ' mnuRead_Worksheet
        ' 
        mnuRead_Worksheet.Name = "mnuRead_Worksheet"
        mnuRead_Worksheet.Size = New Size(166, 22)
        mnuRead_Worksheet.Text = "Spreadsheet (.xls)"
        ' 
        ' mnuTranslateCase
        ' 
        mnuTranslateCase.Name = "mnuTranslateCase"
        mnuTranslateCase.Size = New Size(159, 22)
        mnuTranslateCase.Text = "&Translate"
        ' 
        ' mnuSaveCase
        ' 
        mnuSaveCase.Name = "mnuSaveCase"
        mnuSaveCase.Size = New Size(159, 22)
        mnuSaveCase.Text = "&Save"
        ' 
        ' mnuSaveCaseAs
        ' 
        mnuSaveCaseAs.Name = "mnuSaveCaseAs"
        mnuSaveCaseAs.Size = New Size(159, 22)
        mnuSaveCaseAs.Text = "Save &As"
        ' 
        ' mnuNewCase
        ' 
        mnuNewCase.Name = "mnuNewCase"
        mnuNewCase.Size = New Size(159, 22)
        mnuNewCase.Text = "&New"
        ' 
        ' mnuReadDefault
        ' 
        mnuReadDefault.Name = "mnuReadDefault"
        mnuReadDefault.Size = New Size(159, 22)
        mnuReadDefault.Text = "Read &Default"
        ' 
        ' mnuSaveWorksheet
        ' 
        mnuSaveWorksheet.Enabled = False
        mnuSaveWorksheet.Name = "mnuSaveWorksheet"
        mnuSaveWorksheet.Size = New Size(159, 22)
        mnuSaveWorksheet.Text = "&Save Worksheet"
        ' 
        ' mnuReadWorksheet
        ' 
        mnuReadWorksheet.Enabled = False
        mnuReadWorksheet.Name = "mnuReadWorksheet"
        mnuReadWorksheet.Size = New Size(159, 22)
        mnuReadWorksheet.Text = "&Read Worksheet"
        ' 
        ' mnuEdit
        ' 
        mnuEdit.DropDownItems.AddRange(New ToolStripItem() {mnuModels, mnuGlobals, mnuSegments, mnuTributaries, mnuLandUses, mnuChannels, mnuCoefficients, mnuWorksheet})
        mnuEdit.Name = "mnuEdit"
        mnuEdit.Size = New Size(39, 20)
        mnuEdit.Text = "&Edit"
        ' 
        ' mnuModels
        ' 
        mnuModels.Name = "mnuModels"
        mnuModels.Size = New Size(174, 22)
        mnuModels.Text = "&Model Selections"
        ' 
        ' mnuGlobals
        ' 
        mnuGlobals.Name = "mnuGlobals"
        mnuGlobals.Size = New Size(174, 22)
        mnuGlobals.Text = "&Global Variables"
        ' 
        ' mnuSegments
        ' 
        mnuSegments.Name = "mnuSegments"
        mnuSegments.Size = New Size(174, 22)
        mnuSegments.Text = "&Segments"
        ' 
        ' mnuTributaries
        ' 
        mnuTributaries.Name = "mnuTributaries"
        mnuTributaries.Size = New Size(174, 22)
        mnuTributaries.Text = "&Tributaries"
        ' 
        ' mnuLandUses
        ' 
        mnuLandUses.Name = "mnuLandUses"
        mnuLandUses.Size = New Size(174, 22)
        mnuLandUses.Text = "&Export Coefficients"
        ' 
        ' mnuChannels
        ' 
        mnuChannels.Name = "mnuChannels"
        mnuChannels.Size = New Size(174, 22)
        mnuChannels.Text = "&Channels"
        ' 
        ' mnuCoefficients
        ' 
        mnuCoefficients.Name = "mnuCoefficients"
        mnuCoefficients.Size = New Size(174, 22)
        mnuCoefficients.Text = "Model &Coefficients"
        ' 
        ' mnuWorksheet
        ' 
        mnuWorksheet.Name = "mnuWorksheet"
        mnuWorksheet.Size = New Size(174, 22)
        mnuWorksheet.Text = "&Worksheet"
        ' 
        ' mnuRun
        ' 
        mnuRun.DropDownItems.AddRange(New ToolStripItem() {mnuRunModel, mnuRunSensitivity, mnuLoadResponse, mnuCalibration})
        mnuRun.Name = "mnuRun"
        mnuRun.Size = New Size(40, 20)
        mnuRun.Text = "&Run"
        ' 
        ' mnuRunModel
        ' 
        mnuRunModel.Name = "mnuRunModel"
        mnuRunModel.Size = New Size(173, 22)
        mnuRunModel.Text = "&Model"
        ' 
        ' mnuRunSensitivity
        ' 
        mnuRunSensitivity.Name = "mnuRunSensitivity"
        mnuRunSensitivity.Size = New Size(173, 22)
        mnuRunSensitivity.Text = "&Sensitivity Analysis"
        ' 
        ' mnuLoadResponse
        ' 
        mnuLoadResponse.Name = "mnuLoadResponse"
        mnuLoadResponse.Size = New Size(173, 22)
        mnuLoadResponse.Text = "&Load Response"
        ' 
        ' mnuCalibration
        ' 
        mnuCalibration.Name = "mnuCalibration"
        mnuCalibration.Size = New Size(173, 22)
        mnuCalibration.Text = "&Calibration"
        ' 
        ' mnuList
        ' 
        mnuList.DropDownItems.AddRange(New ToolStripItem() {mnuListInputs, mnuListNetwork, mnuListHydraulics, mnuMassBalances, _mnuListDiagnostics_0, _mnuListDiagnostics_1, mnuListProfiles, mnuListTTests, mnuListStatistics, mnuListErrorMessages, mnnListAll})
        mnuList.Name = "mnuList"
        mnuList.Size = New Size(37, 20)
        mnuList.Text = "&List"
        ' 
        ' mnuListInputs
        ' 
        mnuListInputs.Name = "mnuListInputs"
        mnuListInputs.Size = New Size(218, 22)
        mnuListInputs.Text = "&Inputs"
        ' 
        ' mnuListNetwork
        ' 
        mnuListNetwork.Name = "mnuListNetwork"
        mnuListNetwork.Size = New Size(218, 22)
        mnuListNetwork.Text = "Segment &Network"
        ' 
        ' mnuListHydraulics
        ' 
        mnuListHydraulics.Name = "mnuListHydraulics"
        mnuListHydraulics.Size = New Size(218, 22)
        mnuListHydraulics.Text = "&Hydraulics + Morphometry"
        ' 
        ' mnuMassBalances
        ' 
        mnuMassBalances.DropDownItems.AddRange(New ToolStripItem() {mnuListGrossBalances, mnuListSegBal, mnuListSummary, mnuListErrors})
        mnuMassBalances.Name = "mnuMassBalances"
        mnuMassBalances.Size = New Size(218, 22)
        mnuMassBalances.Text = "&Mass Balances"
        ' 
        ' mnuListGrossBalances
        ' 
        mnuListGrossBalances.Name = "mnuListGrossBalances"
        mnuListGrossBalances.Size = New Size(137, 22)
        mnuListGrossBalances.Text = "&Overall"
        ' 
        ' mnuListSegBal
        ' 
        mnuListSegBal.Name = "mnuListSegBal"
        mnuListSegBal.Size = New Size(137, 22)
        mnuListSegBal.Text = "&By Segment"
        ' 
        ' mnuListSummary
        ' 
        mnuListSummary.Name = "mnuListSummary"
        mnuListSummary.Size = New Size(137, 22)
        mnuListSummary.Text = "S&ummary"
        ' 
        ' mnuListErrors
        ' 
        mnuListErrors.Enabled = False
        mnuListErrors.Name = "mnuListErrors"
        mnuListErrors.Size = New Size(137, 22)
        mnuListErrors.Text = "&Errors"
        ' 
        ' _mnuListDiagnostics_0
        ' 
        _mnuListDiagnostics_0.Name = "_mnuListDiagnostics_0"
        _mnuListDiagnostics_0.Size = New Size(218, 22)
        _mnuListDiagnostics_0.Text = "&Predicted Concentrations"
        ' 
        ' _mnuListDiagnostics_1
        ' 
        _mnuListDiagnostics_1.Name = "_mnuListDiagnostics_1"
        _mnuListDiagnostics_1.Size = New Size(218, 22)
        _mnuListDiagnostics_1.Text = "Predicted + &Observed"
        ' 
        ' mnuListProfiles
        ' 
        mnuListProfiles.Name = "mnuListProfiles"
        mnuListProfiles.Size = New Size(218, 22)
        mnuListProfiles.Text = "Pro&files"
        ' 
        ' mnuListTTests
        ' 
        mnuListTTests.Name = "mnuListTTests"
        mnuListTTests.Size = New Size(218, 22)
        mnuListTTests.Text = "&T-Tests"
        ' 
        ' mnuListStatistics
        ' 
        mnuListStatistics.Name = "mnuListStatistics"
        mnuListStatistics.Size = New Size(218, 22)
        mnuListStatistics.Text = "&Calibration Statistics"
        ' 
        ' mnuListErrorMessages
        ' 
        mnuListErrorMessages.Name = "mnuListErrorMessages"
        mnuListErrorMessages.Size = New Size(218, 22)
        mnuListErrorMessages.Text = "&Error Messages"
        ' 
        ' mnnListAll
        ' 
        mnnListAll.Name = "mnnListAll"
        mnnListAll.Size = New Size(218, 22)
        mnnListAll.Text = "All to Workbook"
        ' 
        ' mnuChart
        ' 
        mnuChart.Name = "mnuChart"
        mnuChart.Size = New Size(40, 20)
        mnuChart.Text = "&Plot"
        ' 
        ' mnuOptions
        ' 
        mnuOptions.DropDownItems.AddRange(New ToolStripItem() {_mnuwarn_0, mnuU})
        mnuOptions.Name = "mnuOptions"
        mnuOptions.Size = New Size(61, 20)
        mnuOptions.Text = "O&ptions"
        ' 
        ' _mnuwarn_0
        ' 
        _mnuwarn_0.DropDownItems.AddRange(New ToolStripItem() {_mnuwarnings_0, _mnuwarnings_1})
        _mnuwarn_0.Name = "_mnuwarn_0"
        _mnuwarn_0.Size = New Size(173, 22)
        _mnuwarn_0.Text = "&Warning Messages"
        ' 
        ' _mnuwarnings_0
        ' 
        _mnuwarnings_0.Checked = True
        _mnuwarnings_0.CheckState = CheckState.Checked
        _mnuwarnings_0.Name = "_mnuwarnings_0"
        _mnuwarnings_0.Size = New Size(135, 22)
        _mnuwarnings_0.Text = "&Show"
        ' 
        ' _mnuwarnings_1
        ' 
        _mnuwarnings_1.Name = "_mnuwarnings_1"
        _mnuwarnings_1.Size = New Size(135, 22)
        _mnuwarnings_1.Text = "&Don't Show"
        ' 
        ' mnuU
        ' 
        mnuU.DropDownItems.AddRange(New ToolStripItem() {_mnuUser_0, _mnuUser_1, mnu_debugMode})
        mnuU.Name = "mnuU"
        mnuU.Size = New Size(173, 22)
        mnuU.Text = "&User Mode"
        ' 
        ' _mnuUser_0
        ' 
        _mnuUser_0.Checked = True
        _mnuUser_0.CheckState = CheckState.Checked
        _mnuUser_0.Name = "_mnuUser_0"
        _mnuUser_0.Size = New Size(127, 22)
        _mnuUser_0.Text = "&Standard"
        ' 
        ' _mnuUser_1
        ' 
        _mnuUser_1.Name = "_mnuUser_1"
        _mnuUser_1.Size = New Size(127, 22)
        _mnuUser_1.Text = "&Advanced"
        ' 
        ' mnu_debugMode
        ' 
        mnu_debugMode.Enabled = False
        mnu_debugMode.Name = "mnu_debugMode"
        mnu_debugMode.Size = New Size(127, 22)
        mnu_debugMode.Text = "&Debug"
        ' 
        ' mnuHelp
        ' 
        mnuHelp.DropDownItems.AddRange(New ToolStripItem() {mnuHelpContents, mnuAbout})
        mnuHelp.Name = "mnuHelp"
        mnuHelp.Size = New Size(44, 20)
        mnuHelp.Text = "&Help"
        ' 
        ' mnuHelpContents
        ' 
        mnuHelpContents.Name = "mnuHelpContents"
        mnuHelpContents.Size = New Size(150, 22)
        mnuHelpContents.Text = "Help Contents"
        ' 
        ' mnuAbout
        ' 
        mnuAbout.Name = "mnuAbout"
        mnuAbout.Size = New Size(150, 22)
        mnuAbout.Text = "About"
        ' 
        ' mnuQuit
        ' 
        mnuQuit.Name = "mnuQuit"
        mnuQuit.Size = New Size(42, 20)
        mnuQuit.Text = "&Quit"
        ' 
        ' CommonDialog1
        ' 
        CommonDialog1.Location = New Point(0, 0)
        CommonDialog1.Name = "CommonDialog1"
        CommonDialog1.Size = New Size(0, 0)
        CommonDialog1.TabIndex = 0
        ' 
        ' ExcelVersionLabel
        ' 
        ExcelVersionLabel.AllowDrop = True
        ExcelVersionLabel.BackColor = SystemColors.Control
        ExcelVersionLabel.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        ExcelVersionLabel.ForeColor = SystemColors.ControlText
        ExcelVersionLabel.Location = New Point(8, 352)
        ExcelVersionLabel.MinimumSize = New Size(113, 17)
        ExcelVersionLabel.Name = "ExcelVersionLabel"
        ExcelVersionLabel.RightToLeft = RightToLeft.No
        ExcelVersionLabel.Size = New Size(113, 17)
        ExcelVersionLabel.TabIndex = 12
        ExcelVersionLabel.Text = "Excel Version:"
        ' 
        ' Label1
        ' 
        Label1.AllowDrop = True
        Label1.BackColor = SystemColors.Control
        Label1.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ControlText
        Label1.Location = New Point(8, 320)
        Label1.MinimumSize = New Size(113, 17)
        Label1.Name = "Label1"
        Label1.RightToLeft = RightToLeft.No
        Label1.Size = New Size(113, 17)
        Label1.TabIndex = 11
        Label1.Text = "Output Workbook:"
        ' 
        ' VersionofExcel
        ' 
        VersionofExcel.AllowDrop = True
        VersionofExcel.BackColor = SystemColors.Control
        VersionofExcel.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        VersionofExcel.ForeColor = SystemColors.ControlText
        VersionofExcel.Location = New Point(136, 352)
        VersionofExcel.MinimumSize = New Size(113, 17)
        VersionofExcel.Name = "VersionofExcel"
        VersionofExcel.RightToLeft = RightToLeft.No
        VersionofExcel.Size = New Size(113, 17)
        VersionofExcel.TabIndex = 10
        VersionofExcel.Text = "<version>"
        ' 
        ' Label2
        ' 
        Label2.AllowDrop = True
        Label2.BackColor = SystemColors.Control
        Label2.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ControlText
        Label2.Location = New Point(8, 288)
        Label2.MinimumSize = New Size(113, 17)
        Label2.Name = "Label2"
        Label2.RightToLeft = RightToLeft.No
        Label2.Size = New Size(113, 17)
        Label2.TabIndex = 7
        Label2.Text = "Output Destination:"
        ' 
        ' StatusLabel
        ' 
        StatusLabel.AllowDrop = True
        StatusLabel.BackColor = SystemColors.Control
        StatusLabel.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        StatusLabel.ForeColor = SystemColors.ControlText
        StatusLabel.Location = New Point(16, 40)
        StatusLabel.MinimumSize = New Size(49, 25)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.RightToLeft = RightToLeft.No
        StatusLabel.Size = New Size(54, 25)
        StatusLabel.TabIndex = 2
        StatusLabel.Text = "Status:"
        ' 
        ' frmMenu
        ' 
        AllowDrop = True
        AutoScaleDimensions = New SizeF(16F, 31F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(378, 433)
        Controls.Add(btnClearOutput)
        Controls.Add(btnSaveOutput)
        Controls.Add(ContinueBtn)
        Controls.Add(cmbUserMode)
        Controls.Add(cmbOutputDest)
        Controls.Add(btnRun)
        Controls.Add(btnErrorMessages)
        Controls.Add(txtReport)
        Controls.Add(ExcelVersionLabel)
        Controls.Add(Label1)
        Controls.Add(VersionofExcel)
        Controls.Add(Label2)
        Controls.Add(lblOutputWorkbook)
        Controls.Add(StatusLabel)
        Controls.Add(lblStatus)
        Controls.Add(MainMenu1)
        Font = New Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        ForeColor = SystemColors.WindowText
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Location = New Point(10, 48)
        MaximizeBox = False
        Name = "frmMenu"
        RightToLeft = RightToLeft.No
        Text = "Bathtub Version 6.13"
        MainMenu1.ResumeLayout(False)
        MainMenu1.PerformLayout()
        CType(commandButtonHelper1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Sub ReLoadForm(ByVal addEvents As Boolean)
		Initializemnuwarnings()
		Initializemnuwarn()
		InitializemnuUser()
		InitializemnuListDiagnostics()
		If addEvents Then
			AddHandler MyBase.Click, AddressOf Form_Click
			AddHandler MyBase.FormClosing, AddressOf Form_FormClosing
			AddHandler Activated, AddressOf frmMenu_Activated
		End If
	End Sub
	Sub Initializemnuwarnings()
		ReDim mnuwarnings(1)
		mnuwarnings(0) = _mnuwarnings_0
		mnuwarnings(1) = _mnuwarnings_1
	End Sub
	Sub Initializemnuwarn()
		ReDim mnuwarn(0)
		mnuwarn(0) = _mnuwarn_0
	End Sub
	Sub InitializemnuUser()
		ReDim mnuUser(1)
		mnuUser(0) = _mnuUser_0
		mnuUser(1) = _mnuUser_1
	End Sub
	Sub InitializemnuListDiagnostics()
		ReDim mnuListDiagnostics(1)
		mnuListDiagnostics(0) = _mnuListDiagnostics_0
		mnuListDiagnostics(1) = _mnuListDiagnostics_1
	End Sub
#End Region
End Class