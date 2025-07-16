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
        components = New ComponentModel.Container()
        ToolTipMain = New ToolTip(components)
        Frame5 = New GroupBox()
        _OptOption_1 = New RadioButton()
        _OptOption_0 = New RadioButton()
        txtCalib = New TextBox()
        List1 = New ListBox()
        _optMethod_2 = New RadioButton()
        Frame1 = New GroupBox()
        _chkVariable_3 = New CheckBox()
        _chkVariable_2 = New CheckBox()
        _chkVariable_1 = New CheckBox()
        _chkVariable_0 = New CheckBox()
        Frame4 = New GroupBox()
        Frame3 = New GroupBox()
        Frame2 = New GroupBox()
        _optMethod_1 = New RadioButton()
        _optMethod_0 = New RadioButton()
        Toolbar1 = New ToolStrip()
        Toolbar1_Buttons_Button1 = New ToolStripButton()
        Toolbar1_Buttons_Button2 = New ToolStripButton()
        Toolbar1_Buttons_Button3 = New ToolStripButton()
        Toolbar1_Buttons_Button4 = New ToolStripButton()
        Toolbar1_Buttons_Button5 = New ToolStripButton()
        Toolbar1_Buttons_Button6 = New ToolStripButton()
        lblDefinitions = New Label()
        listBoxHelper1 = New UpgradeHelpers.Gui.Controls.ListBoxHelper(components)
        optionButtonHelper1 = New UpgradeHelpers.Gui.Controls.OptionButtonHelper(components)
        Frame5.SuspendLayout()
        Frame1.SuspendLayout()
        Frame4.SuspendLayout()
        Frame3.SuspendLayout()
        Frame2.SuspendLayout()
        Toolbar1.SuspendLayout()
        CType(optionButtonHelper1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Frame5
        ' 
        Frame5.AllowDrop = True
        Frame5.BackColor = SystemColors.Control
        Frame5.Controls.Add(_OptOption_1)
        Frame5.Controls.Add(_OptOption_0)
        Frame5.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Frame5.ForeColor = SystemColors.ControlText
        Frame5.Location = New Point(16, 240)
        Frame5.Name = "Frame5"
        Frame5.RightToLeft = RightToLeft.No
        Frame5.Size = New Size(241, 89)
        Frame5.TabIndex = 15
        Frame5.TabStop = False
        Frame5.Text = "Calibration Factors Apply To"
        ToolTipMain.SetToolTip(Frame5, "Calibration Method")
        ' 
        ' _OptOption_1
        ' 
        _OptOption_1.AllowDrop = True
        _OptOption_1.BackColor = SystemColors.Control
        optionButtonHelper1.SetDisabledPicture(_OptOption_1, Nothing)
        optionButtonHelper1.SetDownPicture(_OptOption_1, Nothing)
        _OptOption_1.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _OptOption_1.ForeColor = SystemColors.ControlText
        _OptOption_1.Location = New Point(16, 56)
        _OptOption_1.Name = "_OptOption_1"
        _OptOption_1.RightToLeft = RightToLeft.No
        _OptOption_1.Size = New Size(209, 17)
        optionButtonHelper1.SetStyle(_OptOption_1, 0)
        _OptOption_1.TabIndex = 17
        _OptOption_1.TabStop = True
        _OptOption_1.Text = "Predicted Concentrations"
        _OptOption_1.UseVisualStyleBackColor = False
        ' 
        ' _OptOption_0
        ' 
        _OptOption_0.AllowDrop = True
        _OptOption_0.BackColor = SystemColors.Control
        _OptOption_0.Checked = True
        optionButtonHelper1.SetDisabledPicture(_OptOption_0, Nothing)
        optionButtonHelper1.SetDownPicture(_OptOption_0, Nothing)
        _OptOption_0.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _OptOption_0.ForeColor = SystemColors.ControlText
        _OptOption_0.Location = New Point(16, 32)
        _OptOption_0.Name = "_OptOption_0"
        _OptOption_0.RightToLeft = RightToLeft.No
        _OptOption_0.Size = New Size(201, 17)
        optionButtonHelper1.SetStyle(_OptOption_0, 0)
        _OptOption_0.TabIndex = 16
        _OptOption_0.TabStop = True
        _OptOption_0.Text = "Sedimentation Rates (default)"
        _OptOption_0.UseVisualStyleBackColor = False
        ' 
        ' txtCalib
        ' 
        txtCalib.AcceptsReturn = True
        txtCalib.AllowDrop = True
        txtCalib.BackColor = SystemColors.Window
        txtCalib.Cursor = Cursors.IBeam
        txtCalib.Font = New Font("Courier New", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtCalib.ForeColor = SystemColors.WindowText
        txtCalib.Location = New Point(16, 24)
        txtCalib.MaxLength = 0
        txtCalib.Multiline = True
        txtCalib.Name = "txtCalib"
        txtCalib.RightToLeft = RightToLeft.No
        txtCalib.ScrollBars = ScrollBars.Both
        txtCalib.Size = New Size(481, 137)
        txtCalib.TabIndex = 14
        txtCalib.Text = "Text1"
        ToolTipMain.SetToolTip(txtCalib, "Shows progress of calibration calculations")
        txtCalib.WordWrap = False
        ' 
        ' List1
        ' 
        List1.AllowDrop = True
        List1.BackColor = SystemColors.Window
        List1.DrawMode = DrawMode.OwnerDrawFixed
        List1.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        List1.ForeColor = SystemColors.WindowText
        List1.Location = New Point(8, 24)
        List1.Name = "List1"
        List1.RightToLeft = RightToLeft.No
        listBoxHelper1.SetSelectionMode(List1, SelectionMode.MultiSimple)
        List1.SelectionMode = SelectionMode.MultiSimple
        List1.Size = New Size(153, 196)
        List1.TabIndex = 12
        ToolTipMain.SetToolTip(List1, "Select Segments to be Used in Calibration (not available if calibration type = global)")
        ' 
        ' _optMethod_2
        ' 
        _optMethod_2.AllowDrop = True
        _optMethod_2.BackColor = SystemColors.Control
        optionButtonHelper1.SetDisabledPicture(_optMethod_2, Nothing)
        optionButtonHelper1.SetDownPicture(_optMethod_2, Nothing)
        _optMethod_2.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _optMethod_2.ForeColor = SystemColors.ControlText
        _optMethod_2.Location = New Point(8, 64)
        _optMethod_2.Name = "_optMethod_2"
        _optMethod_2.RightToLeft = RightToLeft.No
        _optMethod_2.Size = New Size(137, 33)
        optionButtonHelper1.SetStyle(_optMethod_2, 0)
        _optMethod_2.TabIndex = 10
        _optMethod_2.TabStop = True
        _optMethod_2.Text = "By Segment"
        ToolTipMain.SetToolTip(_optMethod_2, "Global applies to all segments")
        _optMethod_2.UseVisualStyleBackColor = False
        ' 
        ' Frame1
        ' 
        Frame1.AllowDrop = True
        Frame1.BackColor = SystemColors.Control
        Frame1.Controls.Add(_chkVariable_3)
        Frame1.Controls.Add(_chkVariable_2)
        Frame1.Controls.Add(_chkVariable_1)
        Frame1.Controls.Add(_chkVariable_0)
        Frame1.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Frame1.ForeColor = SystemColors.ControlText
        Frame1.Location = New Point(16, 104)
        Frame1.Name = "Frame1"
        Frame1.RightToLeft = RightToLeft.No
        Frame1.Size = New Size(161, 121)
        Frame1.TabIndex = 2
        Frame1.TabStop = False
        Frame1.Text = "Calibration Variables"
        ToolTipMain.SetToolTip(Frame1, "Select variables to be calibrated (in sequence)")
        ' 
        ' _chkVariable_3
        ' 
        _chkVariable_3.AllowDrop = True
        _chkVariable_3.BackColor = SystemColors.Control
        _chkVariable_3.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _chkVariable_3.ForeColor = SystemColors.ControlText
        _chkVariable_3.Location = New Point(8, 88)
        _chkVariable_3.Name = "_chkVariable_3"
        _chkVariable_3.RightToLeft = RightToLeft.No
        _chkVariable_3.Size = New Size(129, 25)
        _chkVariable_3.TabIndex = 6
        _chkVariable_3.Text = "Chlorophyll-a"
        _chkVariable_3.UseVisualStyleBackColor = False
        ' 
        ' _chkVariable_2
        ' 
        _chkVariable_2.AllowDrop = True
        _chkVariable_2.BackColor = SystemColors.Control
        _chkVariable_2.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _chkVariable_2.ForeColor = SystemColors.ControlText
        _chkVariable_2.Location = New Point(8, 64)
        _chkVariable_2.Name = "_chkVariable_2"
        _chkVariable_2.RightToLeft = RightToLeft.No
        _chkVariable_2.Size = New Size(97, 25)
        _chkVariable_2.TabIndex = 5
        _chkVariable_2.Text = "Total N"
        _chkVariable_2.UseVisualStyleBackColor = False
        ' 
        ' _chkVariable_1
        ' 
        _chkVariable_1.AllowDrop = True
        _chkVariable_1.BackColor = SystemColors.Control
        _chkVariable_1.Checked = True
        _chkVariable_1.CheckState = CheckState.Checked
        _chkVariable_1.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _chkVariable_1.ForeColor = SystemColors.ControlText
        _chkVariable_1.Location = New Point(8, 40)
        _chkVariable_1.Name = "_chkVariable_1"
        _chkVariable_1.RightToLeft = RightToLeft.No
        _chkVariable_1.Size = New Size(145, 25)
        _chkVariable_1.TabIndex = 4
        _chkVariable_1.Text = "Total P"
        _chkVariable_1.UseVisualStyleBackColor = False
        ' 
        ' _chkVariable_0
        ' 
        _chkVariable_0.AllowDrop = True
        _chkVariable_0.BackColor = SystemColors.Control
        _chkVariable_0.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _chkVariable_0.ForeColor = SystemColors.ControlText
        _chkVariable_0.Location = New Point(8, 16)
        _chkVariable_0.Name = "_chkVariable_0"
        _chkVariable_0.RightToLeft = RightToLeft.No
        _chkVariable_0.Size = New Size(145, 25)
        _chkVariable_0.TabIndex = 3
        _chkVariable_0.Text = "Conservative Subst"
        _chkVariable_0.UseVisualStyleBackColor = False
        ' 
        ' Frame4
        ' 
        Frame4.AllowDrop = True
        Frame4.BackColor = SystemColors.Control
        Frame4.Controls.Add(txtCalib)
        Frame4.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Frame4.ForeColor = SystemColors.ControlText
        Frame4.Location = New Point(16, 336)
        Frame4.Name = "Frame4"
        Frame4.RightToLeft = RightToLeft.No
        Frame4.Size = New Size(513, 201)
        Frame4.TabIndex = 13
        Frame4.TabStop = False
        Frame4.Text = "Calculations"
        ' 
        ' Frame3
        ' 
        Frame3.AllowDrop = True
        Frame3.BackColor = SystemColors.Control
        Frame3.Controls.Add(List1)
        Frame3.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Frame3.ForeColor = SystemColors.ControlText
        Frame3.Location = New Point(360, 96)
        Frame3.Name = "Frame3"
        Frame3.RightToLeft = RightToLeft.No
        Frame3.Size = New Size(169, 233)
        Frame3.TabIndex = 11
        Frame3.TabStop = False
        Frame3.Text = "Select Segments"
        ' 
        ' Frame2
        ' 
        Frame2.AllowDrop = True
        Frame2.BackColor = SystemColors.Control
        Frame2.Controls.Add(_optMethod_2)
        Frame2.Controls.Add(_optMethod_1)
        Frame2.Controls.Add(_optMethod_0)
        Frame2.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Frame2.ForeColor = SystemColors.ControlText
        Frame2.Location = New Point(192, 104)
        Frame2.Name = "Frame2"
        Frame2.RightToLeft = RightToLeft.No
        Frame2.Size = New Size(153, 105)
        Frame2.TabIndex = 7
        Frame2.TabStop = False
        Frame2.Text = "Calibration Type"
        ' 
        ' _optMethod_1
        ' 
        _optMethod_1.AllowDrop = True
        _optMethod_1.BackColor = SystemColors.Control
        optionButtonHelper1.SetDisabledPicture(_optMethod_1, Nothing)
        optionButtonHelper1.SetDownPicture(_optMethod_1, Nothing)
        _optMethod_1.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _optMethod_1.ForeColor = SystemColors.ControlText
        _optMethod_1.Location = New Point(8, 40)
        _optMethod_1.Name = "_optMethod_1"
        _optMethod_1.RightToLeft = RightToLeft.No
        _optMethod_1.Size = New Size(137, 33)
        optionButtonHelper1.SetStyle(_optMethod_1, 0)
        _optMethod_1.TabIndex = 9
        _optMethod_1.TabStop = True
        _optMethod_1.Text = "By Segment Group"
        _optMethod_1.UseVisualStyleBackColor = False
        ' 
        ' _optMethod_0
        ' 
        _optMethod_0.AllowDrop = True
        _optMethod_0.BackColor = SystemColors.Control
        _optMethod_0.Checked = True
        optionButtonHelper1.SetDisabledPicture(_optMethod_0, Nothing)
        optionButtonHelper1.SetDownPicture(_optMethod_0, Nothing)
        _optMethod_0.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _optMethod_0.ForeColor = SystemColors.ControlText
        _optMethod_0.Location = New Point(8, 16)
        _optMethod_0.Name = "_optMethod_0"
        _optMethod_0.RightToLeft = RightToLeft.No
        _optMethod_0.Size = New Size(137, 33)
        optionButtonHelper1.SetStyle(_optMethod_0, 0)
        _optMethod_0.TabIndex = 8
        _optMethod_0.TabStop = True
        _optMethod_0.Text = "Global"
        _optMethod_0.UseVisualStyleBackColor = False
        ' 
        ' Toolbar1
        ' 
        Toolbar1.AllowDrop = True
        Toolbar1.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Toolbar1.Items.AddRange(New ToolStripItem() {Toolbar1_Buttons_Button1, Toolbar1_Buttons_Button2, Toolbar1_Buttons_Button3, Toolbar1_Buttons_Button4, Toolbar1_Buttons_Button5, Toolbar1_Buttons_Button6})
        Toolbar1.Location = New Point(0, 0)
        Toolbar1.Name = "Toolbar1"
        Toolbar1.Size = New Size(543, 25)
        Toolbar1.TabIndex = 0
        ' 
        ' Toolbar1_Buttons_Button1
        ' 
        Toolbar1_Buttons_Button1.ImageScaling = ToolStripItemImageScaling.None
        Toolbar1_Buttons_Button1.Name = "Toolbar1_Buttons_Button1"
        Toolbar1_Buttons_Button1.Size = New Size(35, 22)
        Toolbar1_Buttons_Button1.Text = "Run"
        Toolbar1_Buttons_Button1.TextImageRelation = TextImageRelation.ImageAboveText
        Toolbar1_Buttons_Button1.ToolTipText = "Run calibration"
        ' 
        ' Toolbar1_Buttons_Button2
        ' 
        Toolbar1_Buttons_Button2.ImageScaling = ToolStripItemImageScaling.None
        Toolbar1_Buttons_Button2.Name = "Toolbar1_Buttons_Button2"
        Toolbar1_Buttons_Button2.Size = New Size(47, 22)
        Toolbar1_Buttons_Button2.Text = "Reset"
        Toolbar1_Buttons_Button2.TextImageRelation = TextImageRelation.ImageAboveText
        Toolbar1_Buttons_Button2.ToolTipText = "Reset calibration factors for selected variables and segments"
        ' 
        ' Toolbar1_Buttons_Button3
        ' 
        Toolbar1_Buttons_Button3.ImageScaling = ToolStripItemImageScaling.None
        Toolbar1_Buttons_Button3.Name = "Toolbar1_Buttons_Button3"
        Toolbar1_Buttons_Button3.Size = New Size(65, 22)
        Toolbar1_Buttons_Button3.Text = "Reset All"
        Toolbar1_Buttons_Button3.TextImageRelation = TextImageRelation.ImageAboveText
        Toolbar1_Buttons_Button3.ToolTipText = "Reset calibration factors for all segments and variables"
        ' 
        ' Toolbar1_Buttons_Button4
        ' 
        Toolbar1_Buttons_Button4.ImageScaling = ToolStripItemImageScaling.None
        Toolbar1_Buttons_Button4.Name = "Toolbar1_Buttons_Button4"
        Toolbar1_Buttons_Button4.Size = New Size(31, 22)
        Toolbar1_Buttons_Button4.Text = "List"
        Toolbar1_Buttons_Button4.TextImageRelation = TextImageRelation.ImageAboveText
        Toolbar1_Buttons_Button4.ToolTipText = "List calibration results"
        ' 
        ' Toolbar1_Buttons_Button5
        ' 
        Toolbar1_Buttons_Button5.ImageScaling = ToolStripItemImageScaling.None
        Toolbar1_Buttons_Button5.Name = "Toolbar1_Buttons_Button5"
        Toolbar1_Buttons_Button5.Size = New Size(40, 22)
        Toolbar1_Buttons_Button5.Text = "Help"
        Toolbar1_Buttons_Button5.TextImageRelation = TextImageRelation.ImageAboveText
        Toolbar1_Buttons_Button5.ToolTipText = "Get help"
        ' 
        ' Toolbar1_Buttons_Button6
        ' 
        Toolbar1_Buttons_Button6.ImageScaling = ToolStripItemImageScaling.None
        Toolbar1_Buttons_Button6.Name = "Toolbar1_Buttons_Button6"
        Toolbar1_Buttons_Button6.Size = New Size(34, 22)
        Toolbar1_Buttons_Button6.Text = "Quit"
        Toolbar1_Buttons_Button6.TextImageRelation = TextImageRelation.ImageAboveText
        Toolbar1_Buttons_Button6.ToolTipText = "Return to program menu"
        ' 
        ' lblDefinitions
        ' 
        lblDefinitions.AllowDrop = True
        lblDefinitions.BackColor = SystemColors.Control
        lblDefinitions.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDefinitions.ForeColor = SystemColors.Highlight
        lblDefinitions.Location = New Point(8, 56)
        lblDefinitions.MinimumSize = New Size(265, 25)
        lblDefinitions.Name = "lblDefinitions"
        lblDefinitions.RightToLeft = RightToLeft.No
        lblDefinitions.Size = New Size(265, 25)
        lblDefinitions.TabIndex = 1
        lblDefinitions.Text = "Label2"
        lblDefinitions.TextAlign = ContentAlignment.TopCenter
        ' 
        ' frmCalibration
        ' 
        AllowDrop = True
        AutoScaleDimensions = New SizeF(8F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(543, 546)
        Controls.Add(Frame5)
        Controls.Add(Frame4)
        Controls.Add(Frame3)
        Controls.Add(Frame2)
        Controls.Add(Toolbar1)
        Controls.Add(Frame1)
        Controls.Add(lblDefinitions)
        Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Location = New Point(4, 23)
        Name = "frmCalibration"
        RightToLeft = RightToLeft.No
        Text = "Calibration"
        Frame5.ResumeLayout(False)
        Frame1.ResumeLayout(False)
        Frame4.ResumeLayout(False)
        Frame4.PerformLayout()
        Frame3.ResumeLayout(False)
        Frame2.ResumeLayout(False)
        Toolbar1.ResumeLayout(False)
        Toolbar1.PerformLayout()
        CType(optionButtonHelper1, ComponentModel.ISupportInitialize).EndInit()
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