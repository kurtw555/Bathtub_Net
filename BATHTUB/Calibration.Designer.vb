<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalibration
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As frmCalibration
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As frmCalibration
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = CreateInstance()
				m_InitializingDefInstance = False
			End If
			Return m_vb6FormDefInstance
		End Get
		Set(ByVal Value As frmCalibration)
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region
#Region "Windows Form Designer generated code "
	Public Shared Function CreateInstance() As frmCalibration
		Dim theInstance As New frmCalibration()
		theInstance.Form_Load()
		Return theInstance
	End Function
	Private visualControls() As String = New String() {"components", "ToolTipMain", "_OptOption_1", "_OptOption_0", "Frame5", "txtCalib", "Frame4", "List1", "Frame3", "_optMethod_2", "_optMethod_1", "_optMethod_0", "Frame2", "Toolbar1_Buttons_Button1", "Toolbar1_Buttons_Button2", "Toolbar1_Buttons_Button3", "Toolbar1_Buttons_Button4", "Toolbar1_Buttons_Button5", "Toolbar1_Buttons_Button6", "Toolbar1", "_chkVariable_3", "_chkVariable_2", "_chkVariable_1", "_chkVariable_0", "Frame1", "lblDefinitions", "OptOption", "chkVariable", "optMethod", "listBoxHelper1", "optionButtonHelper1"}
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTipMain As System.Windows.Forms.ToolTip
	Private WithEvents _OptOption_1 As System.Windows.Forms.RadioButton
	Private WithEvents _OptOption_0 As System.Windows.Forms.RadioButton
	Public WithEvents Frame5 As System.Windows.Forms.GroupBox
	Public WithEvents txtCalib As System.Windows.Forms.TextBox
	Public WithEvents Frame4 As System.Windows.Forms.GroupBox
	Public WithEvents List1 As System.Windows.Forms.ListBox
	Public WithEvents Frame3 As System.Windows.Forms.GroupBox
	Private WithEvents _optMethod_2 As System.Windows.Forms.RadioButton
	Private WithEvents _optMethod_1 As System.Windows.Forms.RadioButton
	Private WithEvents _optMethod_0 As System.Windows.Forms.RadioButton
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents Toolbar1_Buttons_Button1 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Buttons_Button2 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Buttons_Button3 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Buttons_Button4 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Buttons_Button5 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Buttons_Button6 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1 As System.Windows.Forms.ToolStrip
	Private WithEvents _chkVariable_3 As System.Windows.Forms.CheckBox
	Private WithEvents _chkVariable_2 As System.Windows.Forms.CheckBox
	Private WithEvents _chkVariable_1 As System.Windows.Forms.CheckBox
	Private WithEvents _chkVariable_0 As System.Windows.Forms.CheckBox
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents lblDefinitions As System.Windows.Forms.Label
	Public OptOption(1) As System.Windows.Forms.RadioButton
	Public chkVariable(3) As System.Windows.Forms.CheckBox
	Public optMethod(2) As System.Windows.Forms.RadioButton
	Public listBoxHelper1 As UpgradeHelpers.Gui.Controls.ListBoxHelper
	Public optionButtonHelper1 As UpgradeHelpers.Gui.Controls.OptionButtonHelper
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	 Private Sub InitializeComponent()
		components = New System.ComponentModel.Container()
		Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(frmCalibration))
		ToolTipMain = New System.Windows.Forms.ToolTip(components)
		Frame5 = New System.Windows.Forms.GroupBox()
		_OptOption_1 = New System.Windows.Forms.RadioButton()
		_OptOption_0 = New System.Windows.Forms.RadioButton()
		Frame4 = New System.Windows.Forms.GroupBox()
		txtCalib = New System.Windows.Forms.TextBox()
		Frame3 = New System.Windows.Forms.GroupBox()
		List1 = New System.Windows.Forms.ListBox()
		Frame2 = New System.Windows.Forms.GroupBox()
		_optMethod_2 = New System.Windows.Forms.RadioButton()
		_optMethod_1 = New System.Windows.Forms.RadioButton()
		_optMethod_0 = New System.Windows.Forms.RadioButton()
		Toolbar1 = New System.Windows.Forms.ToolStrip()
		Toolbar1_Buttons_Button1 = New System.Windows.Forms.ToolStripButton()
		Toolbar1_Buttons_Button2 = New System.Windows.Forms.ToolStripButton()
		Toolbar1_Buttons_Button3 = New System.Windows.Forms.ToolStripButton()
		Toolbar1_Buttons_Button4 = New System.Windows.Forms.ToolStripButton()
		Toolbar1_Buttons_Button5 = New System.Windows.Forms.ToolStripButton()
		Toolbar1_Buttons_Button6 = New System.Windows.Forms.ToolStripButton()
		Frame1 = New System.Windows.Forms.GroupBox()
		_chkVariable_3 = New System.Windows.Forms.CheckBox()
		_chkVariable_2 = New System.Windows.Forms.CheckBox()
		_chkVariable_1 = New System.Windows.Forms.CheckBox()
		_chkVariable_0 = New System.Windows.Forms.CheckBox()
		lblDefinitions = New System.Windows.Forms.Label()
		Frame5.SuspendLayout()
		Frame4.SuspendLayout()
		Frame3.SuspendLayout()
		Frame2.SuspendLayout()
		Toolbar1.SuspendLayout()
		Frame1.SuspendLayout()
		SuspendLayout()
		listBoxHelper1 = New UpgradeHelpers.Gui.Controls.ListBoxHelper(components)
		optionButtonHelper1 = New UpgradeHelpers.Gui.Controls.OptionButtonHelper(components)
		' 
		'Frame5
		' 
		Frame5.AllowDrop = True
		Frame5.BackColor = System.Drawing.SystemColors.Control
		Frame5.Controls.Add(_OptOption_1)
		Frame5.Controls.Add(_OptOption_0)
		Frame5.Cursor = UpgradeHelpers.Helpers.CursorHelper.CursorDefault
		Frame5.Enabled = True
		Frame5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		Frame5.ForeColor = System.Drawing.SystemColors.ControlText
		Frame5.Location = New System.Drawing.Point(16, 240)
		Frame5.Name = "Frame5"
		Frame5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Frame5.Size = New System.Drawing.Size(241, 89)
		Frame5.TabIndex = 15
		Frame5.Text = "Calibration Factors Apply To"
		Frame5.Visible = True
		' 
		'_OptOption_1
		' 
		_OptOption_1.AllowDrop = True
		_OptOption_1.BackColor = System.Drawing.SystemColors.Control
		_OptOption_1.CausesValidation = True
		_OptOption_1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		_OptOption_1.Checked = False
		_OptOption_1.Enabled = True
		_OptOption_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_OptOption_1.ForeColor = System.Drawing.SystemColors.ControlText
		_OptOption_1.Location = New System.Drawing.Point(16, 56)
		_OptOption_1.Name = "_OptOption_1"
		_OptOption_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		_OptOption_1.Size = New System.Drawing.Size(209, 17)
		_OptOption_1.TabIndex = 17
		_OptOption_1.TabStop = True
		_OptOption_1.Text = "Predicted Concentrations"
		_OptOption_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		_OptOption_1.Visible = True
		' 
		'_OptOption_0
		' 
		_OptOption_0.AllowDrop = True
		_OptOption_0.BackColor = System.Drawing.SystemColors.Control
		_OptOption_0.CausesValidation = True
		_OptOption_0.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		_OptOption_0.Checked = True
		_OptOption_0.Enabled = True
		_OptOption_0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_OptOption_0.ForeColor = System.Drawing.SystemColors.ControlText
		_OptOption_0.Location = New System.Drawing.Point(16, 32)
		_OptOption_0.Name = "_OptOption_0"
		_OptOption_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		_OptOption_0.Size = New System.Drawing.Size(201, 17)
		_OptOption_0.TabIndex = 16
		_OptOption_0.TabStop = True
		_OptOption_0.Text = "Sedimentation Rates (default)"
		_OptOption_0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		_OptOption_0.Visible = True
		' 
		'Frame4
		' 
		Frame4.AllowDrop = True
		Frame4.BackColor = System.Drawing.SystemColors.Control
		Frame4.Controls.Add(txtCalib)
		Frame4.Cursor = UpgradeHelpers.Helpers.CursorHelper.CursorDefault
		Frame4.Enabled = True
		Frame4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		Frame4.ForeColor = System.Drawing.SystemColors.ControlText
		Frame4.Location = New System.Drawing.Point(16, 336)
		Frame4.Name = "Frame4"
		Frame4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Frame4.Size = New System.Drawing.Size(513, 201)
		Frame4.TabIndex = 13
		Frame4.Text = "Calculations"
		Frame4.Visible = True
		' 
		'txtCalib
		' 
		txtCalib.AcceptsReturn = True
		txtCalib.AllowDrop = True
		txtCalib.BackColor = System.Drawing.SystemColors.Window
		txtCalib.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		txtCalib.Cursor = System.Windows.Forms.Cursors.IBeam
		txtCalib.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		txtCalib.ForeColor = System.Drawing.SystemColors.WindowText
		txtCalib.Location = New System.Drawing.Point(16, 24)
		txtCalib.MaxLength = 0
		txtCalib.Multiline = True
		txtCalib.Name = "txtCalib"
		txtCalib.RightToLeft = System.Windows.Forms.RightToLeft.No
		txtCalib.ScrollBars = System.Windows.Forms.ScrollBars.Both
		txtCalib.Size = New System.Drawing.Size(481, 137)
		txtCalib.TabIndex = 14
		txtCalib.Text = "Text1"
		txtCalib.WordWrap = False
		' 
		'Frame3
		' 
		Frame3.AllowDrop = True
		Frame3.BackColor = System.Drawing.SystemColors.Control
		Frame3.Controls.Add(List1)
		Frame3.Cursor = UpgradeHelpers.Helpers.CursorHelper.CursorDefault
		Frame3.Enabled = True
		Frame3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		Frame3.ForeColor = System.Drawing.SystemColors.ControlText
		Frame3.Location = New System.Drawing.Point(360, 96)
		Frame3.Name = "Frame3"
		Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Frame3.Size = New System.Drawing.Size(169, 233)
		Frame3.TabIndex = 11
		Frame3.Text = "Select Segments"
		Frame3.Visible = True
		' 
		'List1
		' 
		List1.AllowDrop = True
		List1.BackColor = System.Drawing.SystemColors.Window
		List1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		List1.CausesValidation = True
		List1.Enabled = True
		List1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		List1.ForeColor = System.Drawing.SystemColors.WindowText
		List1.IntegralHeight = True
		List1.Location = New System.Drawing.Point(8, 24)
		List1.MultiColumn = False
		List1.Name = "List1"
		List1.RightToLeft = System.Windows.Forms.RightToLeft.No
		List1.Size = New System.Drawing.Size(153, 199)
		List1.Sorted = False
		List1.TabIndex = 12
		List1.TabStop = True
		List1.Visible = True
		' 
		'Frame2
		' 
		Frame2.AllowDrop = True
		Frame2.BackColor = System.Drawing.SystemColors.Control
		Frame2.Controls.Add(_optMethod_2)
		Frame2.Controls.Add(_optMethod_1)
		Frame2.Controls.Add(_optMethod_0)
		Frame2.Cursor = UpgradeHelpers.Helpers.CursorHelper.CursorDefault
		Frame2.Enabled = True
		Frame2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		Frame2.ForeColor = System.Drawing.SystemColors.ControlText
		Frame2.Location = New System.Drawing.Point(192, 104)
		Frame2.Name = "Frame2"
		Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Frame2.Size = New System.Drawing.Size(153, 105)
		Frame2.TabIndex = 7
		Frame2.Text = "Calibration Type"
		Frame2.Visible = True
		' 
		'_optMethod_2
		' 
		_optMethod_2.AllowDrop = True
		_optMethod_2.BackColor = System.Drawing.SystemColors.Control
		_optMethod_2.CausesValidation = True
		_optMethod_2.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		_optMethod_2.Checked = False
		_optMethod_2.Enabled = True
		_optMethod_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_optMethod_2.ForeColor = System.Drawing.SystemColors.ControlText
		_optMethod_2.Location = New System.Drawing.Point(8, 64)
		_optMethod_2.Name = "_optMethod_2"
		_optMethod_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		_optMethod_2.Size = New System.Drawing.Size(137, 33)
		_optMethod_2.TabIndex = 10
		_optMethod_2.TabStop = True
		_optMethod_2.Text = "By Segment"
		_optMethod_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		_optMethod_2.Visible = True
		' 
		'_optMethod_1
		' 
		_optMethod_1.AllowDrop = True
		_optMethod_1.BackColor = System.Drawing.SystemColors.Control
		_optMethod_1.CausesValidation = True
		_optMethod_1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		_optMethod_1.Checked = False
		_optMethod_1.Enabled = True
		_optMethod_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_optMethod_1.ForeColor = System.Drawing.SystemColors.ControlText
		_optMethod_1.Location = New System.Drawing.Point(8, 40)
		_optMethod_1.Name = "_optMethod_1"
		_optMethod_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		_optMethod_1.Size = New System.Drawing.Size(137, 33)
		_optMethod_1.TabIndex = 9
		_optMethod_1.TabStop = True
		_optMethod_1.Text = "By Segment Group"
		_optMethod_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		_optMethod_1.Visible = True
		' 
		'_optMethod_0
		' 
		_optMethod_0.AllowDrop = True
		_optMethod_0.BackColor = System.Drawing.SystemColors.Control
		_optMethod_0.CausesValidation = True
		_optMethod_0.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		_optMethod_0.Checked = True
		_optMethod_0.Enabled = True
		_optMethod_0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_optMethod_0.ForeColor = System.Drawing.SystemColors.ControlText
		_optMethod_0.Location = New System.Drawing.Point(8, 16)
		_optMethod_0.Name = "_optMethod_0"
		_optMethod_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		_optMethod_0.Size = New System.Drawing.Size(137, 33)
		_optMethod_0.TabIndex = 8
		_optMethod_0.TabStop = True
		_optMethod_0.Text = "Global"
		_optMethod_0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		_optMethod_0.Visible = True
		' 
		'Toolbar1
		' 
		Toolbar1.AllowDrop = True
		Toolbar1.Dock = System.Windows.Forms.DockStyle.Top
		Toolbar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		Toolbar1.Location = New System.Drawing.Point(0, 0)
		Toolbar1.Name = "Toolbar1"
		Toolbar1.ShowItemToolTips = True
		Toolbar1.Size = New System.Drawing.Size(543, 42)
		Toolbar1.TabIndex = 0
		Toolbar1.Items.Add(Toolbar1_Buttons_Button1)
		Toolbar1.Items.Add(Toolbar1_Buttons_Button2)
		Toolbar1.Items.Add(Toolbar1_Buttons_Button3)
		Toolbar1.Items.Add(Toolbar1_Buttons_Button4)
		Toolbar1.Items.Add(Toolbar1_Buttons_Button5)
		Toolbar1.Items.Add(Toolbar1_Buttons_Button6)
		' 
		'Toolbar1_Buttons_Button1
		' 
		Toolbar1_Buttons_Button1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Toolbar1_Buttons_Button1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Toolbar1_Buttons_Button1.Name = "btnRun"
		Toolbar1_Buttons_Button1.Size = New System.Drawing.Size(50, 37)
		Toolbar1_Buttons_Button1.Text = "Run"
		Toolbar1_Buttons_Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Toolbar1_Buttons_Button1.ToolTipText = "Run calibration"
		' 
		'Toolbar1_Buttons_Button2
		' 
		Toolbar1_Buttons_Button2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Toolbar1_Buttons_Button2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Toolbar1_Buttons_Button2.Name = "btnReset"
		Toolbar1_Buttons_Button2.Size = New System.Drawing.Size(50, 37)
		Toolbar1_Buttons_Button2.Text = "Reset"
		Toolbar1_Buttons_Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Toolbar1_Buttons_Button2.ToolTipText = "Reset calibration factors for selected variables and segments"
		' 
		'Toolbar1_Buttons_Button3
		' 
		Toolbar1_Buttons_Button3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Toolbar1_Buttons_Button3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Toolbar1_Buttons_Button3.Name = "btnResetAll"
		Toolbar1_Buttons_Button3.Size = New System.Drawing.Size(50, 37)
		Toolbar1_Buttons_Button3.Text = "Reset All"
		Toolbar1_Buttons_Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Toolbar1_Buttons_Button3.ToolTipText = "Reset calibration factors for all segments and variables"
		' 
		'Toolbar1_Buttons_Button4
		' 
		Toolbar1_Buttons_Button4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Toolbar1_Buttons_Button4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Toolbar1_Buttons_Button4.Name = "btnList"
		Toolbar1_Buttons_Button4.Size = New System.Drawing.Size(50, 37)
		Toolbar1_Buttons_Button4.Text = "List"
		Toolbar1_Buttons_Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Toolbar1_Buttons_Button4.ToolTipText = "List calibration results"
		' 
		'Toolbar1_Buttons_Button5
		' 
		Toolbar1_Buttons_Button5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Toolbar1_Buttons_Button5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Toolbar1_Buttons_Button5.Name = "btnHelp"
		Toolbar1_Buttons_Button5.Size = New System.Drawing.Size(50, 37)
		Toolbar1_Buttons_Button5.Text = "Help"
		Toolbar1_Buttons_Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Toolbar1_Buttons_Button5.ToolTipText = "Get help"
		' 
		'Toolbar1_Buttons_Button6
		' 
		Toolbar1_Buttons_Button6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Toolbar1_Buttons_Button6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Toolbar1_Buttons_Button6.Name = "btnQuit"
		Toolbar1_Buttons_Button6.Size = New System.Drawing.Size(50, 37)
		Toolbar1_Buttons_Button6.Text = "Quit"
		Toolbar1_Buttons_Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Toolbar1_Buttons_Button6.ToolTipText = "Return to program menu"
		' 
		'Frame1
		' 
		Frame1.AllowDrop = True
		Frame1.BackColor = System.Drawing.SystemColors.Control
		Frame1.Controls.Add(_chkVariable_3)
		Frame1.Controls.Add(_chkVariable_2)
		Frame1.Controls.Add(_chkVariable_1)
		Frame1.Controls.Add(_chkVariable_0)
		Frame1.Cursor = UpgradeHelpers.Helpers.CursorHelper.CursorDefault
		Frame1.Enabled = True
		Frame1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Frame1.Location = New System.Drawing.Point(16, 104)
		Frame1.Name = "Frame1"
		Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Frame1.Size = New System.Drawing.Size(161, 121)
		Frame1.TabIndex = 2
		Frame1.Text = "Calibration Variables"
		Frame1.Visible = True
		' 
		'_chkVariable_3
		' 
		_chkVariable_3.AllowDrop = True
		_chkVariable_3.Appearance = System.Windows.Forms.Appearance.Normal
		_chkVariable_3.BackColor = System.Drawing.SystemColors.Control
		_chkVariable_3.CausesValidation = True
		_chkVariable_3.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		_chkVariable_3.CheckState = System.Windows.Forms.CheckState.Unchecked
		_chkVariable_3.Enabled = True
		_chkVariable_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_chkVariable_3.ForeColor = System.Drawing.SystemColors.ControlText
		_chkVariable_3.Location = New System.Drawing.Point(8, 88)
		_chkVariable_3.Name = "_chkVariable_3"
		_chkVariable_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		_chkVariable_3.Size = New System.Drawing.Size(129, 25)
		_chkVariable_3.TabIndex = 6
		_chkVariable_3.TabStop = True
		_chkVariable_3.Text = "Chlorophyll-a"
		_chkVariable_3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		_chkVariable_3.Visible = True
		' 
		'_chkVariable_2
		' 
		_chkVariable_2.AllowDrop = True
		_chkVariable_2.Appearance = System.Windows.Forms.Appearance.Normal
		_chkVariable_2.BackColor = System.Drawing.SystemColors.Control
		_chkVariable_2.CausesValidation = True
		_chkVariable_2.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		_chkVariable_2.CheckState = System.Windows.Forms.CheckState.Unchecked
		_chkVariable_2.Enabled = True
		_chkVariable_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_chkVariable_2.ForeColor = System.Drawing.SystemColors.ControlText
		_chkVariable_2.Location = New System.Drawing.Point(8, 64)
		_chkVariable_2.Name = "_chkVariable_2"
		_chkVariable_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		_chkVariable_2.Size = New System.Drawing.Size(97, 25)
		_chkVariable_2.TabIndex = 5
		_chkVariable_2.TabStop = True
		_chkVariable_2.Text = "Total N"
		_chkVariable_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		_chkVariable_2.Visible = True
		' 
		'_chkVariable_1
		' 
		_chkVariable_1.AllowDrop = True
		_chkVariable_1.Appearance = System.Windows.Forms.Appearance.Normal
		_chkVariable_1.BackColor = System.Drawing.SystemColors.Control
		_chkVariable_1.CausesValidation = True
		_chkVariable_1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		_chkVariable_1.CheckState = System.Windows.Forms.CheckState.Checked
		_chkVariable_1.Enabled = True
		_chkVariable_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_chkVariable_1.ForeColor = System.Drawing.SystemColors.ControlText
		_chkVariable_1.Location = New System.Drawing.Point(8, 40)
		_chkVariable_1.Name = "_chkVariable_1"
		_chkVariable_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		_chkVariable_1.Size = New System.Drawing.Size(145, 25)
		_chkVariable_1.TabIndex = 4
		_chkVariable_1.TabStop = True
		_chkVariable_1.Text = "Total P"
		_chkVariable_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		_chkVariable_1.Visible = True
		' 
		'_chkVariable_0
		' 
		_chkVariable_0.AllowDrop = True
		_chkVariable_0.Appearance = System.Windows.Forms.Appearance.Normal
		_chkVariable_0.BackColor = System.Drawing.SystemColors.Control
		_chkVariable_0.CausesValidation = True
		_chkVariable_0.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		_chkVariable_0.CheckState = System.Windows.Forms.CheckState.Unchecked
		_chkVariable_0.Enabled = True
		_chkVariable_0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_chkVariable_0.ForeColor = System.Drawing.SystemColors.ControlText
		_chkVariable_0.Location = New System.Drawing.Point(8, 16)
		_chkVariable_0.Name = "_chkVariable_0"
		_chkVariable_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		_chkVariable_0.Size = New System.Drawing.Size(145, 25)
		_chkVariable_0.TabIndex = 3
		_chkVariable_0.TabStop = True
		_chkVariable_0.Text = "Conservative Subst"
		_chkVariable_0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		_chkVariable_0.Visible = True
		' 
		'lblDefinitions
		' 
		lblDefinitions.AllowDrop = True
		lblDefinitions.BackColor = System.Drawing.SystemColors.Control
		lblDefinitions.BorderStyle = System.Windows.Forms.BorderStyle.None
		lblDefinitions.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		lblDefinitions.ForeColor = System.Drawing.SystemColors.Highlight
		lblDefinitions.Location = New System.Drawing.Point(8, 56)
		lblDefinitions.MinimumSize = New System.Drawing.Size(265, 25)
		lblDefinitions.Name = "lblDefinitions"
		lblDefinitions.RightToLeft = System.Windows.Forms.RightToLeft.No
		lblDefinitions.Size = New System.Drawing.Size(265, 25)
		lblDefinitions.TabIndex = 1
		lblDefinitions.Text = "Label2"
		lblDefinitions.TextAlign = System.Drawing.ContentAlignment.TopCenter
		' 
		'frmCalibration
		' 
		AllowDrop = True
		AutoScaleDimensions = New System.Drawing.SizeF(7, 15)
		AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		BackColor = System.Drawing.SystemColors.Control
		ClientSize = New System.Drawing.Size(543, 546)
		Controls.Add(Frame5)
		Controls.Add(Frame4)
		Controls.Add(Frame3)
		Controls.Add(Frame2)
		Controls.Add(Toolbar1)
		Controls.Add(Frame1)
		Controls.Add(lblDefinitions)
		Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		Location = New System.Drawing.Point(4, 23)
		MaximizeBox = True
		MinimizeBox = True
		Name = "frmCalibration"
		RightToLeft = System.Windows.Forms.RightToLeft.No
		Text = "Calibration"
		listBoxHelper1.SetSelectionMode(List1, System.Windows.Forms.SelectionMode.MultiSimple)
		optionButtonHelper1.SetStyle(_OptOption_1, 0)
		optionButtonHelper1.SetStyle(_OptOption_0, 0)
		optionButtonHelper1.SetStyle(_optMethod_2, 0)
		optionButtonHelper1.SetStyle(_optMethod_1, 0)
		optionButtonHelper1.SetStyle(_optMethod_0, 0)
		ToolTipMain.SetToolTip(Frame5, "Calibration Method")
		ToolTipMain.SetToolTip(txtCalib, "Shows progress of calibration calculations")
		ToolTipMain.SetToolTip(List1, "Select Segments to be Used in Calibration (not available if calibration type = global)")
		ToolTipMain.SetToolTip(_optMethod_2, "Global applies to all segments")
		ToolTipMain.SetToolTip(Frame1, "Select variables to be calibrated (in sequence)")
		Frame5.ResumeLayout(False)
		Frame5.PerformLayout()
		Frame4.ResumeLayout(False)
		Frame4.PerformLayout()
		Frame3.ResumeLayout(False)
		Frame3.PerformLayout()
		Frame2.ResumeLayout(False)
		Frame2.PerformLayout()
		Toolbar1.ResumeLayout(False)
		Toolbar1.PerformLayout()
		Frame1.ResumeLayout(False)
		Frame1.PerformLayout()
		ResumeLayout(False)
		PerformLayout()
	End Sub
	Sub ReLoadForm(ByVal addEvents As Boolean)
		InitializeoptMethod()
		InitializechkVariable()
		InitializeOptOption()
		If addEvents Then
			AddHandler MyBase.Closed, AddressOf Form_Closed
			AddHandler Activated, AddressOf frmCalibration_Activated
		End If
	End Sub
	Sub InitializeoptMethod()
		ReDim optMethod(2)
		optMethod(2) = _optMethod_2
		optMethod(1) = _optMethod_1
		optMethod(0) = _optMethod_0
	End Sub
	Sub InitializechkVariable()
		ReDim chkVariable(3)
		chkVariable(3) = _chkVariable_3
		chkVariable(2) = _chkVariable_2
		chkVariable(1) = _chkVariable_1
		chkVariable(0) = _chkVariable_0
	End Sub
	Sub InitializeOptOption()
		ReDim OptOption(1)
		OptOption(1) = _OptOption_1
		OptOption(0) = _OptOption_0
	End Sub
#End Region
End Class