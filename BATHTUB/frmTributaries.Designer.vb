<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTribs
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As frmTribs
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As frmTribs
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = CreateInstance()
				m_InitializingDefInstance = False
			End If
			Return m_vb6FormDefInstance
		End Get
		Set(ByVal Value As frmTribs)
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region
#Region "Windows Form Designer generated code "
	Public Shared Function CreateInstance() As frmTribs
		Dim theInstance As New frmTribs()
		theInstance.Form_Load()
		Return theInstance
	End Function
	Private visualControls() As String = New String() {"components", "ToolTipMain", "Toolbar1_Buttons_Button1", "Toolbar1_Buttons_Button2", "Toolbar1_Buttons_Button3", "Toolbar1_Buttons_Button4", "Toolbar1_Buttons_Button5", "Toolbar1_Buttons_Button6", "Toolbar1_Buttons_Button7", "Toolbar1_Buttons_Button8", "Toolbar1_Buttons_Button9", "Toolbar1", "_lblLabel_0", "_lblLabel_1", "_lblLabel_2", "_lblLabel_3", "_lblLabel_4", "_lblLabel_5", "_lblLabel_6", "_lblLabel_7", "_lblLabel_8", "_lblLabel_9", "_lblLabel_10", "_lblLabel_11", "_txtText_22", "cmbTribSeg", "_txtText_0", "_txtText_1", "_txtText_2", "_txtText_3", "_txtText_4", "_txtText_5", "_txtText_6", "_txtText_7", "_txtText_8", "_txtText_9", "_txtText_10", "_txtText_11", "_txtText_12", "_txtText_13", "_txtText_23", "cmbTribType", "_SSTab1_TabPage0", "_lblLabel_13", "_lblLabel_14", "_lblLabel_15", "_lblLabel_12", "_lblLabel_17", "_lblLabel_18", "_lblLabel_19", "_lblLabel_16", "_lblLabel_20", "_lblLabel_21", "_txtText_14", "_txtText_15", "_txtText_16", "_txtText_17", "_txtText_18", "_txtText_19", "_txtText_20", "_txtText_21", "_SSTab1_TabPage1", "SSTab1", "Combo1", "lblCount", "lblDefinitions", "lblLabel", "txtText"}
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTipMain As System.Windows.Forms.ToolTip
	Public WithEvents Toolbar1_Buttons_Button1 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Buttons_Button2 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Buttons_Button3 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Buttons_Button4 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Buttons_Button5 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Buttons_Button6 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Buttons_Button7 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Buttons_Button8 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Buttons_Button9 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1 As System.Windows.Forms.ToolStrip
	Private WithEvents _lblLabel_0 As System.Windows.Forms.Label
	Private WithEvents _lblLabel_1 As System.Windows.Forms.Label
	Private WithEvents _lblLabel_2 As System.Windows.Forms.Label
	Private WithEvents _lblLabel_3 As System.Windows.Forms.Label
	Private WithEvents _lblLabel_4 As System.Windows.Forms.Label
	Private WithEvents _lblLabel_5 As System.Windows.Forms.Label
	Private WithEvents _lblLabel_6 As System.Windows.Forms.Label
	Private WithEvents _lblLabel_7 As System.Windows.Forms.Label
	Private WithEvents _lblLabel_8 As System.Windows.Forms.Label
	Private WithEvents _lblLabel_9 As System.Windows.Forms.Label
	Private WithEvents _lblLabel_10 As System.Windows.Forms.Label
	Private WithEvents _lblLabel_11 As System.Windows.Forms.Label
	Private WithEvents _txtText_22 As System.Windows.Forms.TextBox
	Public WithEvents cmbTribSeg As System.Windows.Forms.ComboBox
	Private WithEvents _txtText_0 As System.Windows.Forms.TextBox
	Private WithEvents _txtText_1 As System.Windows.Forms.TextBox
	Private WithEvents _txtText_2 As System.Windows.Forms.TextBox
	Private WithEvents _txtText_3 As System.Windows.Forms.TextBox
	Private WithEvents _txtText_4 As System.Windows.Forms.TextBox
	Private WithEvents _txtText_5 As System.Windows.Forms.TextBox
	Private WithEvents _txtText_6 As System.Windows.Forms.TextBox
	Private WithEvents _txtText_7 As System.Windows.Forms.TextBox
	Private WithEvents _txtText_8 As System.Windows.Forms.TextBox
	Private WithEvents _txtText_9 As System.Windows.Forms.TextBox
	Private WithEvents _txtText_10 As System.Windows.Forms.TextBox
	Private WithEvents _txtText_11 As System.Windows.Forms.TextBox
	Private WithEvents _txtText_12 As System.Windows.Forms.TextBox
	Private WithEvents _txtText_13 As System.Windows.Forms.TextBox
	Private WithEvents _txtText_23 As System.Windows.Forms.TextBox
	Public WithEvents cmbTribType As System.Windows.Forms.ComboBox
	Private WithEvents _SSTab1_TabPage0 As System.Windows.Forms.TabPage
	Private WithEvents _lblLabel_13 As System.Windows.Forms.Label
	Private WithEvents _lblLabel_14 As System.Windows.Forms.Label
	Private WithEvents _lblLabel_15 As System.Windows.Forms.Label
	Private WithEvents _lblLabel_12 As System.Windows.Forms.Label
	Private WithEvents _lblLabel_17 As System.Windows.Forms.Label
	Private WithEvents _lblLabel_18 As System.Windows.Forms.Label
	Private WithEvents _lblLabel_19 As System.Windows.Forms.Label
	Private WithEvents _lblLabel_16 As System.Windows.Forms.Label
	Private WithEvents _lblLabel_20 As System.Windows.Forms.Label
	Private WithEvents _lblLabel_21 As System.Windows.Forms.Label
	Private WithEvents _txtText_14 As System.Windows.Forms.TextBox
	Private WithEvents _txtText_15 As System.Windows.Forms.TextBox
	Private WithEvents _txtText_16 As System.Windows.Forms.TextBox
	Private WithEvents _txtText_17 As System.Windows.Forms.TextBox
	Private WithEvents _txtText_18 As System.Windows.Forms.TextBox
	Private WithEvents _txtText_19 As System.Windows.Forms.TextBox
	Private WithEvents _txtText_20 As System.Windows.Forms.TextBox
	Private WithEvents _txtText_21 As System.Windows.Forms.TextBox
	Private WithEvents _SSTab1_TabPage1 As System.Windows.Forms.TabPage
	Public WithEvents SSTab1 As UpgradeHelpers.Gui.Controls.TabControlExtension
	Public WithEvents Combo1 As System.Windows.Forms.ComboBox
	Public WithEvents lblCount As System.Windows.Forms.Label
	Public WithEvents lblDefinitions As System.Windows.Forms.Label
	Public lblLabel(21) As System.Windows.Forms.Label
	Public txtText(23) As System.Windows.Forms.TextBox
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTribs))
        ToolTipMain = New ToolTip(components)
        _lblLabel_8 = New Label()
        cmbTribSeg = New ComboBox()
        cmbTribType = New ComboBox()
        Combo1 = New ComboBox()
        Toolbar1 = New ToolStrip()
        Toolbar1_Buttons_Button1 = New ToolStripButton()
        Toolbar1_Buttons_Button2 = New ToolStripButton()
        Toolbar1_Buttons_Button3 = New ToolStripButton()
        Toolbar1_Buttons_Button4 = New ToolStripButton()
        Toolbar1_Buttons_Button5 = New ToolStripButton()
        Toolbar1_Buttons_Button6 = New ToolStripButton()
        Toolbar1_Buttons_Button7 = New ToolStripButton()
        Toolbar1_Buttons_Button8 = New ToolStripButton()
        Toolbar1_Buttons_Button9 = New ToolStripButton()
        SSTab1 = New UpgradeHelpers.Gui.Controls.TabControlExtension()
        _SSTab1_TabPage0 = New TabPage()
        _lblLabel_0 = New Label()
        _lblLabel_1 = New Label()
        _lblLabel_2 = New Label()
        _lblLabel_3 = New Label()
        _lblLabel_4 = New Label()
        _lblLabel_5 = New Label()
        _lblLabel_6 = New Label()
        _lblLabel_7 = New Label()
        _lblLabel_9 = New Label()
        _lblLabel_10 = New Label()
        _lblLabel_11 = New Label()
        _txtText_22 = New TextBox()
        _txtText_0 = New TextBox()
        _txtText_1 = New TextBox()
        _txtText_2 = New TextBox()
        _txtText_3 = New TextBox()
        _txtText_4 = New TextBox()
        _txtText_5 = New TextBox()
        _txtText_6 = New TextBox()
        _txtText_7 = New TextBox()
        _txtText_8 = New TextBox()
        _txtText_9 = New TextBox()
        _txtText_10 = New TextBox()
        _txtText_11 = New TextBox()
        _txtText_12 = New TextBox()
        _txtText_13 = New TextBox()
        _txtText_23 = New TextBox()
        _SSTab1_TabPage1 = New TabPage()
        _lblLabel_13 = New Label()
        _lblLabel_14 = New Label()
        _lblLabel_15 = New Label()
        _lblLabel_12 = New Label()
        _lblLabel_17 = New Label()
        _lblLabel_18 = New Label()
        _lblLabel_19 = New Label()
        _lblLabel_16 = New Label()
        _lblLabel_20 = New Label()
        _lblLabel_21 = New Label()
        _txtText_14 = New TextBox()
        _txtText_15 = New TextBox()
        _txtText_16 = New TextBox()
        _txtText_17 = New TextBox()
        _txtText_18 = New TextBox()
        _txtText_19 = New TextBox()
        _txtText_20 = New TextBox()
        _txtText_21 = New TextBox()
        lblCount = New Label()
        lblDefinitions = New Label()
        Toolbar1.SuspendLayout()
        SSTab1.SuspendLayout()
        _SSTab1_TabPage0.SuspendLayout()
        _SSTab1_TabPage1.SuspendLayout()
        SuspendLayout()
        ' 
        ' _lblLabel_8
        ' 
        _lblLabel_8.AllowDrop = True
        _lblLabel_8.BackColor = SystemColors.Control
        _lblLabel_8.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        _lblLabel_8.ForeColor = SystemColors.ControlText
        _lblLabel_8.Location = New Point(328, 140)
        _lblLabel_8.MinimumSize = New Size(49, 25)
        _lblLabel_8.Name = "_lblLabel_8"
        _lblLabel_8.RightToLeft = RightToLeft.No
        _lblLabel_8.Size = New Size(49, 25)
        _lblLabel_8.TabIndex = 27
        _lblLabel_8.Text = "CV"
        _lblLabel_8.TextAlign = ContentAlignment.TopCenter
        ToolTipMain.SetToolTip(_lblLabel_8, "Coefficient of Variation = Standard Error / Mean")
        ' 
        ' cmbTribSeg
        ' 
        cmbTribSeg.AllowDrop = True
        cmbTribSeg.BackColor = SystemColors.Window
        cmbTribSeg.DropDownStyle = ComboBoxStyle.DropDownList
        cmbTribSeg.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbTribSeg.ForeColor = SystemColors.WindowText
        cmbTribSeg.Location = New Point(152, 68)
        cmbTribSeg.Name = "cmbTribSeg"
        cmbTribSeg.RightToLeft = RightToLeft.No
        cmbTribSeg.Size = New Size(233, 24)
        cmbTribSeg.TabIndex = 2
        ToolTipMain.SetToolTip(cmbTribSeg, "Select Segment Associated with This Tributary")
        ' 
        ' cmbTribType
        ' 
        cmbTribType.AllowDrop = True
        cmbTribType.BackColor = SystemColors.Window
        cmbTribType.DropDownStyle = ComboBoxStyle.DropDownList
        cmbTribType.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbTribType.ForeColor = SystemColors.WindowText
        cmbTribType.Location = New Point(152, 100)
        cmbTribType.Name = "cmbTribType"
        cmbTribType.RightToLeft = RightToLeft.No
        cmbTribType.Size = New Size(233, 24)
        cmbTribType.TabIndex = 3
        ToolTipMain.SetToolTip(cmbTribType, "Select Tributary Type")
        ' 
        ' Combo1
        ' 
        Combo1.AllowDrop = True
        Combo1.BackColor = SystemColors.Window
        Combo1.DropDownStyle = ComboBoxStyle.DropDownList
        Combo1.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Combo1.ForeColor = SystemColors.WindowText
        Combo1.Location = New Point(8, 56)
        Combo1.Name = "Combo1"
        Combo1.RightToLeft = RightToLeft.No
        Combo1.Size = New Size(225, 24)
        Combo1.TabIndex = 0
        ToolTipMain.SetToolTip(Combo1, "Select Tributary to be Edited")
        ' 
        ' Toolbar1
        ' 
        Toolbar1.AllowDrop = True
        Toolbar1.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Toolbar1.Items.AddRange(New ToolStripItem() {Toolbar1_Buttons_Button1, Toolbar1_Buttons_Button2, Toolbar1_Buttons_Button3, Toolbar1_Buttons_Button4, Toolbar1_Buttons_Button5, Toolbar1_Buttons_Button6, Toolbar1_Buttons_Button7, Toolbar1_Buttons_Button8, Toolbar1_Buttons_Button9})
        Toolbar1.Location = New Point(0, 0)
        Toolbar1.Name = "Toolbar1"
        Toolbar1.Size = New Size(467, 25)
        Toolbar1.TabIndex = 51
        ' 
        ' Toolbar1_Buttons_Button1
        ' 
        Toolbar1_Buttons_Button1.ImageScaling = ToolStripItemImageScaling.None
        Toolbar1_Buttons_Button1.Name = "Toolbar1_Buttons_Button1"
        Toolbar1_Buttons_Button1.Size = New Size(27, 22)
        Toolbar1_Buttons_Button1.Text = "List"
        Toolbar1_Buttons_Button1.TextImageRelation = TextImageRelation.ImageAboveText
        Toolbar1_Buttons_Button1.ToolTipText = "List segment & tributary network"
        ' 
        ' Toolbar1_Buttons_Button2
        ' 
        Toolbar1_Buttons_Button2.ImageScaling = ToolStripItemImageScaling.None
        Toolbar1_Buttons_Button2.Name = "Toolbar1_Buttons_Button2"
        Toolbar1_Buttons_Button2.Size = New Size(30, 22)
        Toolbar1_Buttons_Button2.Text = "Add"
        Toolbar1_Buttons_Button2.TextImageRelation = TextImageRelation.ImageAboveText
        Toolbar1_Buttons_Button2.ToolTipText = "Add a new tributary at end of the current list"
        ' 
        ' Toolbar1_Buttons_Button3
        ' 
        Toolbar1_Buttons_Button3.ImageScaling = ToolStripItemImageScaling.None
        Toolbar1_Buttons_Button3.Name = "Toolbar1_Buttons_Button3"
        Toolbar1_Buttons_Button3.Size = New Size(37, 22)
        Toolbar1_Buttons_Button3.Text = "Insert"
        Toolbar1_Buttons_Button3.TextImageRelation = TextImageRelation.ImageAboveText
        Toolbar1_Buttons_Button3.ToolTipText = "Insert a new tributary after the currently selected one"
        ' 
        ' Toolbar1_Buttons_Button4
        ' 
        Toolbar1_Buttons_Button4.ImageScaling = ToolStripItemImageScaling.None
        Toolbar1_Buttons_Button4.Name = "Toolbar1_Buttons_Button4"
        Toolbar1_Buttons_Button4.Size = New Size(42, 22)
        Toolbar1_Buttons_Button4.Text = "Delete"
        Toolbar1_Buttons_Button4.TextImageRelation = TextImageRelation.ImageAboveText
        Toolbar1_Buttons_Button4.ToolTipText = "Delete the selected tributary"
        ' 
        ' Toolbar1_Buttons_Button5
        ' 
        Toolbar1_Buttons_Button5.ImageScaling = ToolStripItemImageScaling.None
        Toolbar1_Buttons_Button5.Name = "Toolbar1_Buttons_Button5"
        Toolbar1_Buttons_Button5.Size = New Size(35, 22)
        Toolbar1_Buttons_Button5.Text = "Clear"
        Toolbar1_Buttons_Button5.TextImageRelation = TextImageRelation.ImageAboveText
        Toolbar1_Buttons_Button5.ToolTipText = "Assign default values to selected tributary"
        ' 
        ' Toolbar1_Buttons_Button6
        ' 
        Toolbar1_Buttons_Button6.ImageScaling = ToolStripItemImageScaling.None
        Toolbar1_Buttons_Button6.Name = "Toolbar1_Buttons_Button6"
        Toolbar1_Buttons_Button6.Size = New Size(37, 22)
        Toolbar1_Buttons_Button6.Text = "Undo"
        Toolbar1_Buttons_Button6.TextImageRelation = TextImageRelation.ImageAboveText
        Toolbar1_Buttons_Button6.ToolTipText = "Restore initial values"
        ' 
        ' Toolbar1_Buttons_Button7
        ' 
        Toolbar1_Buttons_Button7.ImageScaling = ToolStripItemImageScaling.None
        Toolbar1_Buttons_Button7.Name = "Toolbar1_Buttons_Button7"
        Toolbar1_Buttons_Button7.Size = New Size(33, 22)
        Toolbar1_Buttons_Button7.Text = "Help"
        Toolbar1_Buttons_Button7.TextImageRelation = TextImageRelation.ImageAboveText
        Toolbar1_Buttons_Button7.ToolTipText = "Get help"
        ' 
        ' Toolbar1_Buttons_Button8
        ' 
        Toolbar1_Buttons_Button8.ImageScaling = ToolStripItemImageScaling.None
        Toolbar1_Buttons_Button8.Name = "Toolbar1_Buttons_Button8"
        Toolbar1_Buttons_Button8.Size = New Size(44, 22)
        Toolbar1_Buttons_Button8.Text = "Cancel"
        Toolbar1_Buttons_Button8.TextImageRelation = TextImageRelation.ImageAboveText
        Toolbar1_Buttons_Button8.ToolTipText = "Ignore edits & return to program menu"
        ' 
        ' Toolbar1_Buttons_Button9
        ' 
        Toolbar1_Buttons_Button9.ImageScaling = ToolStripItemImageScaling.None
        Toolbar1_Buttons_Button9.Name = "Toolbar1_Buttons_Button9"
        Toolbar1_Buttons_Button9.Size = New Size(26, 22)
        Toolbar1_Buttons_Button9.Text = "OK"
        Toolbar1_Buttons_Button9.TextImageRelation = TextImageRelation.ImageAboveText
        Toolbar1_Buttons_Button9.ToolTipText = "Save edits & return to program menu"
        ' 
        ' SSTab1
        ' 
        SSTab1.AllowDrop = True
        SSTab1.Caption = "&Monitored Inputs|&Land Uses|"
        SSTab1.Controls.Add(_SSTab1_TabPage0)
        SSTab1.Controls.Add(_SSTab1_TabPage1)
        SSTab1.DrawMode = TabDrawMode.OwnerDrawFixed
        SSTab1.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SSTab1.ItemSize = New Size(143, 18)
        SSTab1.Location = New Point(16, 144)
        SSTab1.Multiline = True
        SSTab1.Name = "SSTab1"
        SSTab1.SelectedIndex = 0
        SSTab1.Size = New Size(437, 461)
        SSTab1.SizeMode = TabSizeMode.Fixed
        SSTab1.TabIndex = 4
        SSTab1.Text = "&Monitored Inputs|&Land Uses|"
        ' 
        ' _SSTab1_TabPage0
        ' 
        _SSTab1_TabPage0.Controls.Add(_lblLabel_0)
        _SSTab1_TabPage0.Controls.Add(_lblLabel_1)
        _SSTab1_TabPage0.Controls.Add(_lblLabel_2)
        _SSTab1_TabPage0.Controls.Add(_lblLabel_3)
        _SSTab1_TabPage0.Controls.Add(_lblLabel_4)
        _SSTab1_TabPage0.Controls.Add(_lblLabel_5)
        _SSTab1_TabPage0.Controls.Add(_lblLabel_6)
        _SSTab1_TabPage0.Controls.Add(_lblLabel_7)
        _SSTab1_TabPage0.Controls.Add(_lblLabel_8)
        _SSTab1_TabPage0.Controls.Add(_lblLabel_9)
        _SSTab1_TabPage0.Controls.Add(_lblLabel_10)
        _SSTab1_TabPage0.Controls.Add(_lblLabel_11)
        _SSTab1_TabPage0.Controls.Add(cmbTribSeg)
        _SSTab1_TabPage0.Controls.Add(_txtText_0)
        _SSTab1_TabPage0.Controls.Add(_txtText_1)
        _SSTab1_TabPage0.Controls.Add(_txtText_2)
        _SSTab1_TabPage0.Controls.Add(_txtText_3)
        _SSTab1_TabPage0.Controls.Add(_txtText_4)
        _SSTab1_TabPage0.Controls.Add(_txtText_5)
        _SSTab1_TabPage0.Controls.Add(_txtText_6)
        _SSTab1_TabPage0.Controls.Add(_txtText_7)
        _SSTab1_TabPage0.Controls.Add(_txtText_8)
        _SSTab1_TabPage0.Controls.Add(_txtText_9)
        _SSTab1_TabPage0.Controls.Add(_txtText_10)
        _SSTab1_TabPage0.Controls.Add(_txtText_11)
        _SSTab1_TabPage0.Controls.Add(_txtText_12)
        _SSTab1_TabPage0.Controls.Add(_txtText_13)
        _SSTab1_TabPage0.Controls.Add(cmbTribType)
        _SSTab1_TabPage0.Controls.Add(_txtText_22)
        _SSTab1_TabPage0.Controls.Add(_txtText_23)
        _SSTab1_TabPage0.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _SSTab1_TabPage0.Location = New Point(4, 22)
        _SSTab1_TabPage0.Name = "_SSTab1_TabPage0"
        _SSTab1_TabPage0.Size = New Size(429, 435)
        _SSTab1_TabPage0.TabIndex = 0
        _SSTab1_TabPage0.Text = "Monitored Inputs"
        ' 
        ' _lblLabel_0
        ' 
        _lblLabel_0.AllowDrop = True
        _lblLabel_0.BackColor = SystemColors.Control
        _lblLabel_0.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _lblLabel_0.ForeColor = SystemColors.ControlText
        _lblLabel_0.Location = New Point(40, 164)
        _lblLabel_0.MinimumSize = New Size(177, 25)
        _lblLabel_0.Name = "_lblLabel_0"
        _lblLabel_0.RightToLeft = RightToLeft.No
        _lblLabel_0.Size = New Size(177, 25)
        _lblLabel_0.TabIndex = 6
        _lblLabel_0.Text = "Total Watershed Area (km2):"
        _lblLabel_0.TextAlign = ContentAlignment.TopRight
        ' 
        ' _lblLabel_1
        ' 
        _lblLabel_1.AllowDrop = True
        _lblLabel_1.BackColor = SystemColors.Control
        _lblLabel_1.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _lblLabel_1.ForeColor = SystemColors.ControlText
        _lblLabel_1.Location = New Point(40, 203)
        _lblLabel_1.MinimumSize = New Size(177, 25)
        _lblLabel_1.Name = "_lblLabel_1"
        _lblLabel_1.RightToLeft = RightToLeft.No
        _lblLabel_1.Size = New Size(177, 25)
        _lblLabel_1.TabIndex = 9
        _lblLabel_1.Text = "Annual Flow Rate (hm3/yr):"
        _lblLabel_1.TextAlign = ContentAlignment.TopRight
        ' 
        ' _lblLabel_2
        ' 
        _lblLabel_2.AllowDrop = True
        _lblLabel_2.BackColor = SystemColors.Control
        _lblLabel_2.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _lblLabel_2.ForeColor = SystemColors.ControlText
        _lblLabel_2.Location = New Point(40, 242)
        _lblLabel_2.MinimumSize = New Size(177, 25)
        _lblLabel_2.Name = "_lblLabel_2"
        _lblLabel_2.RightToLeft = RightToLeft.No
        _lblLabel_2.Size = New Size(177, 25)
        _lblLabel_2.TabIndex = 14
        _lblLabel_2.Text = "Total P Conc (ppb):"
        _lblLabel_2.TextAlign = ContentAlignment.TopRight
        ' 
        ' _lblLabel_3
        ' 
        _lblLabel_3.AllowDrop = True
        _lblLabel_3.BackColor = SystemColors.Control
        _lblLabel_3.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _lblLabel_3.ForeColor = SystemColors.ControlText
        _lblLabel_3.Location = New Point(40, 280)
        _lblLabel_3.MinimumSize = New Size(177, 25)
        _lblLabel_3.Name = "_lblLabel_3"
        _lblLabel_3.RightToLeft = RightToLeft.No
        _lblLabel_3.Size = New Size(177, 25)
        _lblLabel_3.TabIndex = 15
        _lblLabel_3.Text = "Ortho P Conc (ppb):"
        _lblLabel_3.TextAlign = ContentAlignment.TopRight
        ' 
        ' _lblLabel_4
        ' 
        _lblLabel_4.AllowDrop = True
        _lblLabel_4.BackColor = SystemColors.Control
        _lblLabel_4.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _lblLabel_4.ForeColor = SystemColors.ControlText
        _lblLabel_4.Location = New Point(40, 319)
        _lblLabel_4.MinimumSize = New Size(177, 25)
        _lblLabel_4.Name = "_lblLabel_4"
        _lblLabel_4.RightToLeft = RightToLeft.No
        _lblLabel_4.Size = New Size(177, 25)
        _lblLabel_4.TabIndex = 17
        _lblLabel_4.Text = "Total N Conc (ppb):"
        _lblLabel_4.TextAlign = ContentAlignment.TopRight
        ' 
        ' _lblLabel_5
        ' 
        _lblLabel_5.AllowDrop = True
        _lblLabel_5.BackColor = SystemColors.Control
        _lblLabel_5.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _lblLabel_5.ForeColor = SystemColors.ControlText
        _lblLabel_5.Location = New Point(40, 358)
        _lblLabel_5.MinimumSize = New Size(177, 25)
        _lblLabel_5.Name = "_lblLabel_5"
        _lblLabel_5.RightToLeft = RightToLeft.No
        _lblLabel_5.Size = New Size(177, 25)
        _lblLabel_5.TabIndex = 20
        _lblLabel_5.Text = "Inorganic N Conc (ppb):"
        _lblLabel_5.TextAlign = ContentAlignment.TopRight
        ' 
        ' _lblLabel_6
        ' 
        _lblLabel_6.AllowDrop = True
        _lblLabel_6.BackColor = SystemColors.Control
        _lblLabel_6.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _lblLabel_6.ForeColor = SystemColors.ControlText
        _lblLabel_6.Location = New Point(16, 396)
        _lblLabel_6.MinimumSize = New Size(201, 25)
        _lblLabel_6.Name = "_lblLabel_6"
        _lblLabel_6.RightToLeft = RightToLeft.No
        _lblLabel_6.Size = New Size(201, 25)
        _lblLabel_6.TabIndex = 23
        _lblLabel_6.Text = "Conservative Subst. Conc (ppb):"
        _lblLabel_6.TextAlign = ContentAlignment.TopRight
        ' 
        ' _lblLabel_7
        ' 
        _lblLabel_7.AllowDrop = True
        _lblLabel_7.BackColor = SystemColors.Control
        _lblLabel_7.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        _lblLabel_7.ForeColor = SystemColors.ControlText
        _lblLabel_7.Location = New Point(240, 140)
        _lblLabel_7.MinimumSize = New Size(65, 25)
        _lblLabel_7.Name = "_lblLabel_7"
        _lblLabel_7.RightToLeft = RightToLeft.No
        _lblLabel_7.Size = New Size(65, 25)
        _lblLabel_7.TabIndex = 26
        _lblLabel_7.Text = "Mean"
        _lblLabel_7.TextAlign = ContentAlignment.TopCenter
        ' 
        ' _lblLabel_9
        ' 
        _lblLabel_9.AllowDrop = True
        _lblLabel_9.BackColor = SystemColors.Control
        _lblLabel_9.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _lblLabel_9.ForeColor = SystemColors.ControlText
        _lblLabel_9.Location = New Point(24, 68)
        _lblLabel_9.MinimumSize = New Size(113, 25)
        _lblLabel_9.Name = "_lblLabel_9"
        _lblLabel_9.RightToLeft = RightToLeft.No
        _lblLabel_9.Size = New Size(113, 25)
        _lblLabel_9.TabIndex = 28
        _lblLabel_9.Text = "Segment:"
        _lblLabel_9.TextAlign = ContentAlignment.TopRight
        ' 
        ' _lblLabel_10
        ' 
        _lblLabel_10.AllowDrop = True
        _lblLabel_10.BackColor = SystemColors.Control
        _lblLabel_10.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _lblLabel_10.ForeColor = SystemColors.ControlText
        _lblLabel_10.Location = New Point(24, 100)
        _lblLabel_10.MinimumSize = New Size(113, 25)
        _lblLabel_10.Name = "_lblLabel_10"
        _lblLabel_10.RightToLeft = RightToLeft.No
        _lblLabel_10.Size = New Size(113, 25)
        _lblLabel_10.TabIndex = 29
        _lblLabel_10.Text = "Tributary Type:"
        _lblLabel_10.TextAlign = ContentAlignment.TopRight
        ' 
        ' _lblLabel_11
        ' 
        _lblLabel_11.AllowDrop = True
        _lblLabel_11.BackColor = SystemColors.Control
        _lblLabel_11.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _lblLabel_11.ForeColor = SystemColors.ControlText
        _lblLabel_11.Location = New Point(24, 36)
        _lblLabel_11.MinimumSize = New Size(113, 25)
        _lblLabel_11.Name = "_lblLabel_11"
        _lblLabel_11.RightToLeft = RightToLeft.No
        _lblLabel_11.Size = New Size(113, 25)
        _lblLabel_11.TabIndex = 30
        _lblLabel_11.Text = "Tributary Name:"
        _lblLabel_11.TextAlign = ContentAlignment.TopRight
        ' 
        ' _txtText_22
        ' 
        _txtText_22.AcceptsReturn = True
        _txtText_22.AllowDrop = True
        _txtText_22.BackColor = SystemColors.Window
        _txtText_22.Cursor = Cursors.IBeam
        _txtText_22.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _txtText_22.ForeColor = SystemColors.WindowText
        _txtText_22.Location = New Point(152, 68)
        _txtText_22.MaxLength = 0
        _txtText_22.Name = "_txtText_22"
        _txtText_22.RightToLeft = RightToLeft.No
        _txtText_22.Size = New Size(217, 21)
        _txtText_22.TabIndex = 48
        _txtText_22.Text = "0"
        _txtText_22.TextAlign = HorizontalAlignment.Center
        ' 
        ' _txtText_0
        ' 
        _txtText_0.AcceptsReturn = True
        _txtText_0.AllowDrop = True
        _txtText_0.BackColor = SystemColors.Window
        _txtText_0.Cursor = Cursors.IBeam
        _txtText_0.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _txtText_0.ForeColor = SystemColors.WindowText
        _txtText_0.Location = New Point(232, 164)
        _txtText_0.MaxLength = 0
        _txtText_0.Name = "_txtText_0"
        _txtText_0.RightToLeft = RightToLeft.No
        _txtText_0.Size = New Size(81, 22)
        _txtText_0.TabIndex = 7
        _txtText_0.Text = "0"
        _txtText_0.TextAlign = HorizontalAlignment.Center
        ' 
        ' _txtText_1
        ' 
        _txtText_1.AcceptsReturn = True
        _txtText_1.AllowDrop = True
        _txtText_1.BackColor = SystemColors.Window
        _txtText_1.Cursor = Cursors.IBeam
        _txtText_1.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _txtText_1.ForeColor = SystemColors.WindowText
        _txtText_1.Location = New Point(232, 203)
        _txtText_1.MaxLength = 0
        _txtText_1.Name = "_txtText_1"
        _txtText_1.RightToLeft = RightToLeft.No
        _txtText_1.Size = New Size(81, 22)
        _txtText_1.TabIndex = 8
        _txtText_1.Text = "0"
        _txtText_1.TextAlign = HorizontalAlignment.Center
        ' 
        ' _txtText_2
        ' 
        _txtText_2.AcceptsReturn = True
        _txtText_2.AllowDrop = True
        _txtText_2.BackColor = SystemColors.Window
        _txtText_2.Cursor = Cursors.IBeam
        _txtText_2.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _txtText_2.ForeColor = SystemColors.WindowText
        _txtText_2.Location = New Point(328, 204)
        _txtText_2.MaxLength = 0
        _txtText_2.Name = "_txtText_2"
        _txtText_2.RightToLeft = RightToLeft.No
        _txtText_2.Size = New Size(54, 22)
        _txtText_2.TabIndex = 19
        _txtText_2.Text = "0"
        _txtText_2.TextAlign = HorizontalAlignment.Center
        ' 
        ' _txtText_3
        ' 
        _txtText_3.AcceptsReturn = True
        _txtText_3.AllowDrop = True
        _txtText_3.BackColor = SystemColors.Window
        _txtText_3.Cursor = Cursors.IBeam
        _txtText_3.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _txtText_3.ForeColor = SystemColors.WindowText
        _txtText_3.Location = New Point(232, 242)
        _txtText_3.MaxLength = 0
        _txtText_3.Name = "_txtText_3"
        _txtText_3.RightToLeft = RightToLeft.No
        _txtText_3.Size = New Size(81, 22)
        _txtText_3.TabIndex = 10
        _txtText_3.Text = "0"
        _txtText_3.TextAlign = HorizontalAlignment.Center
        ' 
        ' _txtText_4
        ' 
        _txtText_4.AcceptsReturn = True
        _txtText_4.AllowDrop = True
        _txtText_4.BackColor = SystemColors.Window
        _txtText_4.Cursor = Cursors.IBeam
        _txtText_4.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _txtText_4.ForeColor = SystemColors.WindowText
        _txtText_4.Location = New Point(328, 243)
        _txtText_4.MaxLength = 0
        _txtText_4.Name = "_txtText_4"
        _txtText_4.RightToLeft = RightToLeft.No
        _txtText_4.Size = New Size(54, 22)
        _txtText_4.TabIndex = 11
        _txtText_4.Text = "0"
        _txtText_4.TextAlign = HorizontalAlignment.Center
        ' 
        ' _txtText_5
        ' 
        _txtText_5.AcceptsReturn = True
        _txtText_5.AllowDrop = True
        _txtText_5.BackColor = SystemColors.Window
        _txtText_5.Cursor = Cursors.IBeam
        _txtText_5.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _txtText_5.ForeColor = SystemColors.WindowText
        _txtText_5.Location = New Point(232, 280)
        _txtText_5.MaxLength = 0
        _txtText_5.Name = "_txtText_5"
        _txtText_5.RightToLeft = RightToLeft.No
        _txtText_5.Size = New Size(81, 22)
        _txtText_5.TabIndex = 12
        _txtText_5.Text = "0"
        _txtText_5.TextAlign = HorizontalAlignment.Center
        ' 
        ' _txtText_6
        ' 
        _txtText_6.AcceptsReturn = True
        _txtText_6.AllowDrop = True
        _txtText_6.BackColor = SystemColors.Window
        _txtText_6.Cursor = Cursors.IBeam
        _txtText_6.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _txtText_6.ForeColor = SystemColors.WindowText
        _txtText_6.Location = New Point(328, 281)
        _txtText_6.MaxLength = 0
        _txtText_6.Name = "_txtText_6"
        _txtText_6.RightToLeft = RightToLeft.No
        _txtText_6.Size = New Size(54, 22)
        _txtText_6.TabIndex = 13
        _txtText_6.Text = "0"
        _txtText_6.TextAlign = HorizontalAlignment.Center
        ' 
        ' _txtText_7
        ' 
        _txtText_7.AcceptsReturn = True
        _txtText_7.AllowDrop = True
        _txtText_7.BackColor = SystemColors.Window
        _txtText_7.Cursor = Cursors.IBeam
        _txtText_7.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _txtText_7.ForeColor = SystemColors.WindowText
        _txtText_7.Location = New Point(232, 319)
        _txtText_7.MaxLength = 0
        _txtText_7.Name = "_txtText_7"
        _txtText_7.RightToLeft = RightToLeft.No
        _txtText_7.Size = New Size(81, 22)
        _txtText_7.TabIndex = 16
        _txtText_7.Text = "0"
        _txtText_7.TextAlign = HorizontalAlignment.Center
        ' 
        ' _txtText_8
        ' 
        _txtText_8.AcceptsReturn = True
        _txtText_8.AllowDrop = True
        _txtText_8.BackColor = SystemColors.Window
        _txtText_8.Cursor = Cursors.IBeam
        _txtText_8.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _txtText_8.ForeColor = SystemColors.WindowText
        _txtText_8.Location = New Point(328, 319)
        _txtText_8.MaxLength = 0
        _txtText_8.Name = "_txtText_8"
        _txtText_8.RightToLeft = RightToLeft.No
        _txtText_8.Size = New Size(54, 22)
        _txtText_8.TabIndex = 18
        _txtText_8.Text = "0"
        _txtText_8.TextAlign = HorizontalAlignment.Center
        ' 
        ' _txtText_9
        ' 
        _txtText_9.AcceptsReturn = True
        _txtText_9.AllowDrop = True
        _txtText_9.BackColor = SystemColors.Window
        _txtText_9.Cursor = Cursors.IBeam
        _txtText_9.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _txtText_9.ForeColor = SystemColors.WindowText
        _txtText_9.Location = New Point(232, 358)
        _txtText_9.MaxLength = 0
        _txtText_9.Name = "_txtText_9"
        _txtText_9.RightToLeft = RightToLeft.No
        _txtText_9.Size = New Size(81, 22)
        _txtText_9.TabIndex = 21
        _txtText_9.Text = "0"
        _txtText_9.TextAlign = HorizontalAlignment.Center
        ' 
        ' _txtText_10
        ' 
        _txtText_10.AcceptsReturn = True
        _txtText_10.AllowDrop = True
        _txtText_10.BackColor = SystemColors.Window
        _txtText_10.Cursor = Cursors.IBeam
        _txtText_10.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _txtText_10.ForeColor = SystemColors.WindowText
        _txtText_10.Location = New Point(328, 358)
        _txtText_10.MaxLength = 0
        _txtText_10.Name = "_txtText_10"
        _txtText_10.RightToLeft = RightToLeft.No
        _txtText_10.Size = New Size(54, 22)
        _txtText_10.TabIndex = 22
        _txtText_10.Text = "0"
        _txtText_10.TextAlign = HorizontalAlignment.Center
        ' 
        ' _txtText_11
        ' 
        _txtText_11.AcceptsReturn = True
        _txtText_11.AllowDrop = True
        _txtText_11.BackColor = SystemColors.Window
        _txtText_11.Cursor = Cursors.IBeam
        _txtText_11.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _txtText_11.ForeColor = SystemColors.WindowText
        _txtText_11.Location = New Point(232, 396)
        _txtText_11.MaxLength = 0
        _txtText_11.Name = "_txtText_11"
        _txtText_11.RightToLeft = RightToLeft.No
        _txtText_11.Size = New Size(81, 22)
        _txtText_11.TabIndex = 24
        _txtText_11.Text = "0"
        _txtText_11.TextAlign = HorizontalAlignment.Center
        ' 
        ' _txtText_12
        ' 
        _txtText_12.AcceptsReturn = True
        _txtText_12.AllowDrop = True
        _txtText_12.BackColor = SystemColors.Window
        _txtText_12.Cursor = Cursors.IBeam
        _txtText_12.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _txtText_12.ForeColor = SystemColors.WindowText
        _txtText_12.Location = New Point(328, 396)
        _txtText_12.MaxLength = 0
        _txtText_12.Name = "_txtText_12"
        _txtText_12.RightToLeft = RightToLeft.No
        _txtText_12.Size = New Size(54, 22)
        _txtText_12.TabIndex = 25
        _txtText_12.Text = "0"
        _txtText_12.TextAlign = HorizontalAlignment.Center
        ' 
        ' _txtText_13
        ' 
        _txtText_13.AcceptsReturn = True
        _txtText_13.AllowDrop = True
        _txtText_13.BackColor = SystemColors.Window
        _txtText_13.Cursor = Cursors.IBeam
        _txtText_13.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _txtText_13.ForeColor = SystemColors.WindowText
        _txtText_13.Location = New Point(152, 36)
        _txtText_13.MaxLength = 0
        _txtText_13.Name = "_txtText_13"
        _txtText_13.RightToLeft = RightToLeft.No
        _txtText_13.Size = New Size(233, 22)
        _txtText_13.TabIndex = 1
        _txtText_13.Text = "0"
        ' 
        ' _txtText_23
        ' 
        _txtText_23.AcceptsReturn = True
        _txtText_23.AllowDrop = True
        _txtText_23.BackColor = SystemColors.Window
        _txtText_23.Cursor = Cursors.IBeam
        _txtText_23.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _txtText_23.ForeColor = SystemColors.WindowText
        _txtText_23.Location = New Point(152, 100)
        _txtText_23.MaxLength = 0
        _txtText_23.Name = "_txtText_23"
        _txtText_23.RightToLeft = RightToLeft.No
        _txtText_23.Size = New Size(153, 21)
        _txtText_23.TabIndex = 49
        _txtText_23.Text = "0"
        _txtText_23.TextAlign = HorizontalAlignment.Center
        ' 
        ' _SSTab1_TabPage1
        ' 
        _SSTab1_TabPage1.Controls.Add(_lblLabel_13)
        _SSTab1_TabPage1.Controls.Add(_lblLabel_14)
        _SSTab1_TabPage1.Controls.Add(_lblLabel_15)
        _SSTab1_TabPage1.Controls.Add(_lblLabel_12)
        _SSTab1_TabPage1.Controls.Add(_lblLabel_17)
        _SSTab1_TabPage1.Controls.Add(_lblLabel_18)
        _SSTab1_TabPage1.Controls.Add(_lblLabel_19)
        _SSTab1_TabPage1.Controls.Add(_lblLabel_16)
        _SSTab1_TabPage1.Controls.Add(_lblLabel_20)
        _SSTab1_TabPage1.Controls.Add(_lblLabel_21)
        _SSTab1_TabPage1.Controls.Add(_txtText_14)
        _SSTab1_TabPage1.Controls.Add(_txtText_15)
        _SSTab1_TabPage1.Controls.Add(_txtText_16)
        _SSTab1_TabPage1.Controls.Add(_txtText_17)
        _SSTab1_TabPage1.Controls.Add(_txtText_18)
        _SSTab1_TabPage1.Controls.Add(_txtText_19)
        _SSTab1_TabPage1.Controls.Add(_txtText_20)
        _SSTab1_TabPage1.Controls.Add(_txtText_21)
        _SSTab1_TabPage1.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _SSTab1_TabPage1.Location = New Point(4, 22)
        _SSTab1_TabPage1.Name = "_SSTab1_TabPage1"
        _SSTab1_TabPage1.Size = New Size(429, 435)
        _SSTab1_TabPage1.TabIndex = 1
        _SSTab1_TabPage1.Text = "Land Uses"
        ' 
        ' _lblLabel_13
        ' 
        _lblLabel_13.AllowDrop = True
        _lblLabel_13.BackColor = SystemColors.Control
        _lblLabel_13.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _lblLabel_13.ForeColor = SystemColors.ControlText
        _lblLabel_13.Location = New Point(24, 132)
        _lblLabel_13.MinimumSize = New Size(177, 25)
        _lblLabel_13.Name = "_lblLabel_13"
        _lblLabel_13.RightToLeft = RightToLeft.No
        _lblLabel_13.Size = New Size(177, 25)
        _lblLabel_13.TabIndex = 33
        _lblLabel_13.Text = "Category 2:"
        _lblLabel_13.TextAlign = ContentAlignment.TopRight
        ' 
        ' _lblLabel_14
        ' 
        _lblLabel_14.AllowDrop = True
        _lblLabel_14.BackColor = SystemColors.Control
        _lblLabel_14.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _lblLabel_14.ForeColor = SystemColors.ControlText
        _lblLabel_14.Location = New Point(24, 172)
        _lblLabel_14.MinimumSize = New Size(177, 25)
        _lblLabel_14.Name = "_lblLabel_14"
        _lblLabel_14.RightToLeft = RightToLeft.No
        _lblLabel_14.Size = New Size(177, 25)
        _lblLabel_14.TabIndex = 34
        _lblLabel_14.Text = "Category 3:"
        _lblLabel_14.TextAlign = ContentAlignment.TopRight
        ' 
        ' _lblLabel_15
        ' 
        _lblLabel_15.AllowDrop = True
        _lblLabel_15.BackColor = SystemColors.Control
        _lblLabel_15.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _lblLabel_15.ForeColor = SystemColors.ControlText
        _lblLabel_15.Location = New Point(24, 212)
        _lblLabel_15.MinimumSize = New Size(177, 25)
        _lblLabel_15.Name = "_lblLabel_15"
        _lblLabel_15.RightToLeft = RightToLeft.No
        _lblLabel_15.Size = New Size(177, 25)
        _lblLabel_15.TabIndex = 36
        _lblLabel_15.Text = "Category 4:"
        _lblLabel_15.TextAlign = ContentAlignment.TopRight
        ' 
        ' _lblLabel_12
        ' 
        _lblLabel_12.AllowDrop = True
        _lblLabel_12.BackColor = SystemColors.Control
        _lblLabel_12.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _lblLabel_12.ForeColor = SystemColors.ControlText
        _lblLabel_12.Location = New Point(24, 92)
        _lblLabel_12.MinimumSize = New Size(177, 25)
        _lblLabel_12.Name = "_lblLabel_12"
        _lblLabel_12.RightToLeft = RightToLeft.No
        _lblLabel_12.Size = New Size(177, 25)
        _lblLabel_12.TabIndex = 38
        _lblLabel_12.Text = "Category 1:"
        _lblLabel_12.TextAlign = ContentAlignment.TopRight
        ' 
        ' _lblLabel_17
        ' 
        _lblLabel_17.AllowDrop = True
        _lblLabel_17.BackColor = SystemColors.Control
        _lblLabel_17.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _lblLabel_17.ForeColor = SystemColors.ControlText
        _lblLabel_17.Location = New Point(24, 284)
        _lblLabel_17.MinimumSize = New Size(177, 25)
        _lblLabel_17.Name = "_lblLabel_17"
        _lblLabel_17.RightToLeft = RightToLeft.No
        _lblLabel_17.Size = New Size(177, 25)
        _lblLabel_17.TabIndex = 41
        _lblLabel_17.Text = "Category 6:"
        _lblLabel_17.TextAlign = ContentAlignment.TopRight
        ' 
        ' _lblLabel_18
        ' 
        _lblLabel_18.AllowDrop = True
        _lblLabel_18.BackColor = SystemColors.Control
        _lblLabel_18.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _lblLabel_18.ForeColor = SystemColors.ControlText
        _lblLabel_18.Location = New Point(24, 324)
        _lblLabel_18.MinimumSize = New Size(177, 25)
        _lblLabel_18.Name = "_lblLabel_18"
        _lblLabel_18.RightToLeft = RightToLeft.No
        _lblLabel_18.Size = New Size(177, 25)
        _lblLabel_18.TabIndex = 42
        _lblLabel_18.Text = "Category 7:"
        _lblLabel_18.TextAlign = ContentAlignment.TopRight
        ' 
        ' _lblLabel_19
        ' 
        _lblLabel_19.AllowDrop = True
        _lblLabel_19.BackColor = SystemColors.Control
        _lblLabel_19.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _lblLabel_19.ForeColor = SystemColors.ControlText
        _lblLabel_19.Location = New Point(24, 364)
        _lblLabel_19.MinimumSize = New Size(177, 25)
        _lblLabel_19.Name = "_lblLabel_19"
        _lblLabel_19.RightToLeft = RightToLeft.No
        _lblLabel_19.Size = New Size(177, 25)
        _lblLabel_19.TabIndex = 44
        _lblLabel_19.Text = "Category 8:"
        _lblLabel_19.TextAlign = ContentAlignment.TopRight
        ' 
        ' _lblLabel_16
        ' 
        _lblLabel_16.AllowDrop = True
        _lblLabel_16.BackColor = SystemColors.Control
        _lblLabel_16.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _lblLabel_16.ForeColor = SystemColors.ControlText
        _lblLabel_16.Location = New Point(24, 252)
        _lblLabel_16.MinimumSize = New Size(177, 25)
        _lblLabel_16.Name = "_lblLabel_16"
        _lblLabel_16.RightToLeft = RightToLeft.No
        _lblLabel_16.Size = New Size(177, 25)
        _lblLabel_16.TabIndex = 46
        _lblLabel_16.Text = "Category 5:"
        _lblLabel_16.TextAlign = ContentAlignment.TopRight
        ' 
        ' _lblLabel_20
        ' 
        _lblLabel_20.AllowDrop = True
        _lblLabel_20.BackColor = SystemColors.Control
        _lblLabel_20.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        _lblLabel_20.ForeColor = SystemColors.ControlText
        _lblLabel_20.Location = New Point(200, 44)
        _lblLabel_20.MinimumSize = New Size(137, 25)
        _lblLabel_20.Name = "_lblLabel_20"
        _lblLabel_20.RightToLeft = RightToLeft.No
        _lblLabel_20.Size = New Size(137, 25)
        _lblLabel_20.TabIndex = 47
        _lblLabel_20.Text = " Drainage Area (km2)"
        _lblLabel_20.TextAlign = ContentAlignment.TopCenter
        ' 
        ' _lblLabel_21
        ' 
        _lblLabel_21.AllowDrop = True
        _lblLabel_21.BackColor = SystemColors.Control
        _lblLabel_21.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        _lblLabel_21.ForeColor = SystemColors.ControlText
        _lblLabel_21.Location = New Point(72, 44)
        _lblLabel_21.MinimumSize = New Size(137, 25)
        _lblLabel_21.Name = "_lblLabel_21"
        _lblLabel_21.RightToLeft = RightToLeft.No
        _lblLabel_21.Size = New Size(137, 25)
        _lblLabel_21.TabIndex = 50
        _lblLabel_21.Text = " Landuse Category"
        _lblLabel_21.TextAlign = ContentAlignment.TopCenter
        ' 
        ' _txtText_14
        ' 
        _txtText_14.AcceptsReturn = True
        _txtText_14.AllowDrop = True
        _txtText_14.BackColor = SystemColors.Window
        _txtText_14.Cursor = Cursors.IBeam
        _txtText_14.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _txtText_14.ForeColor = SystemColors.WindowText
        _txtText_14.Location = New Point(216, 84)
        _txtText_14.MaxLength = 0
        _txtText_14.Name = "_txtText_14"
        _txtText_14.RightToLeft = RightToLeft.No
        _txtText_14.Size = New Size(81, 22)
        _txtText_14.TabIndex = 31
        _txtText_14.Text = "0"
        _txtText_14.TextAlign = HorizontalAlignment.Center
        ' 
        ' _txtText_15
        ' 
        _txtText_15.AcceptsReturn = True
        _txtText_15.AllowDrop = True
        _txtText_15.BackColor = SystemColors.Window
        _txtText_15.Cursor = Cursors.IBeam
        _txtText_15.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _txtText_15.ForeColor = SystemColors.WindowText
        _txtText_15.Location = New Point(216, 124)
        _txtText_15.MaxLength = 0
        _txtText_15.Name = "_txtText_15"
        _txtText_15.RightToLeft = RightToLeft.No
        _txtText_15.Size = New Size(81, 22)
        _txtText_15.TabIndex = 32
        _txtText_15.Text = "0"
        _txtText_15.TextAlign = HorizontalAlignment.Center
        ' 
        ' _txtText_16
        ' 
        _txtText_16.AcceptsReturn = True
        _txtText_16.AllowDrop = True
        _txtText_16.BackColor = SystemColors.Window
        _txtText_16.Cursor = Cursors.IBeam
        _txtText_16.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _txtText_16.ForeColor = SystemColors.WindowText
        _txtText_16.Location = New Point(216, 164)
        _txtText_16.MaxLength = 0
        _txtText_16.Name = "_txtText_16"
        _txtText_16.RightToLeft = RightToLeft.No
        _txtText_16.Size = New Size(81, 22)
        _txtText_16.TabIndex = 35
        _txtText_16.Text = "0"
        _txtText_16.TextAlign = HorizontalAlignment.Center
        ' 
        ' _txtText_17
        ' 
        _txtText_17.AcceptsReturn = True
        _txtText_17.AllowDrop = True
        _txtText_17.BackColor = SystemColors.Window
        _txtText_17.Cursor = Cursors.IBeam
        _txtText_17.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _txtText_17.ForeColor = SystemColors.WindowText
        _txtText_17.Location = New Point(216, 204)
        _txtText_17.MaxLength = 0
        _txtText_17.Name = "_txtText_17"
        _txtText_17.RightToLeft = RightToLeft.No
        _txtText_17.Size = New Size(81, 22)
        _txtText_17.TabIndex = 37
        _txtText_17.Text = "0"
        _txtText_17.TextAlign = HorizontalAlignment.Center
        ' 
        ' _txtText_18
        ' 
        _txtText_18.AcceptsReturn = True
        _txtText_18.AllowDrop = True
        _txtText_18.BackColor = SystemColors.Window
        _txtText_18.Cursor = Cursors.IBeam
        _txtText_18.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _txtText_18.ForeColor = SystemColors.WindowText
        _txtText_18.Location = New Point(216, 244)
        _txtText_18.MaxLength = 0
        _txtText_18.Name = "_txtText_18"
        _txtText_18.RightToLeft = RightToLeft.No
        _txtText_18.Size = New Size(81, 22)
        _txtText_18.TabIndex = 39
        _txtText_18.Text = "0"
        _txtText_18.TextAlign = HorizontalAlignment.Center
        ' 
        ' _txtText_19
        ' 
        _txtText_19.AcceptsReturn = True
        _txtText_19.AllowDrop = True
        _txtText_19.BackColor = SystemColors.Window
        _txtText_19.Cursor = Cursors.IBeam
        _txtText_19.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _txtText_19.ForeColor = SystemColors.WindowText
        _txtText_19.Location = New Point(216, 284)
        _txtText_19.MaxLength = 0
        _txtText_19.Name = "_txtText_19"
        _txtText_19.RightToLeft = RightToLeft.No
        _txtText_19.Size = New Size(81, 22)
        _txtText_19.TabIndex = 40
        _txtText_19.Text = "0"
        _txtText_19.TextAlign = HorizontalAlignment.Center
        ' 
        ' _txtText_20
        ' 
        _txtText_20.AcceptsReturn = True
        _txtText_20.AllowDrop = True
        _txtText_20.BackColor = SystemColors.Window
        _txtText_20.Cursor = Cursors.IBeam
        _txtText_20.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _txtText_20.ForeColor = SystemColors.WindowText
        _txtText_20.Location = New Point(216, 324)
        _txtText_20.MaxLength = 0
        _txtText_20.Name = "_txtText_20"
        _txtText_20.RightToLeft = RightToLeft.No
        _txtText_20.Size = New Size(81, 22)
        _txtText_20.TabIndex = 43
        _txtText_20.Text = "0"
        _txtText_20.TextAlign = HorizontalAlignment.Center
        ' 
        ' _txtText_21
        ' 
        _txtText_21.AcceptsReturn = True
        _txtText_21.AllowDrop = True
        _txtText_21.BackColor = SystemColors.Window
        _txtText_21.Cursor = Cursors.IBeam
        _txtText_21.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _txtText_21.ForeColor = SystemColors.WindowText
        _txtText_21.Location = New Point(216, 364)
        _txtText_21.MaxLength = 0
        _txtText_21.Name = "_txtText_21"
        _txtText_21.RightToLeft = RightToLeft.No
        _txtText_21.Size = New Size(81, 22)
        _txtText_21.TabIndex = 45
        _txtText_21.Text = "0"
        _txtText_21.TextAlign = HorizontalAlignment.Center
        ' 
        ' lblCount
        ' 
        lblCount.AllowDrop = True
        lblCount.BackColor = SystemColors.Control
        lblCount.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblCount.ForeColor = SystemColors.ControlText
        lblCount.Location = New Point(256, 56)
        lblCount.MinimumSize = New Size(185, 17)
        lblCount.Name = "lblCount"
        lblCount.RightToLeft = RightToLeft.No
        lblCount.Size = New Size(185, 17)
        lblCount.TabIndex = 52
        lblCount.Text = "Total Number of Tribs. ="
        ' 
        ' lblDefinitions
        ' 
        lblDefinitions.AllowDrop = True
        lblDefinitions.BackColor = SystemColors.Control
        lblDefinitions.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDefinitions.ForeColor = SystemColors.Highlight
        lblDefinitions.Location = New Point(40, 104)
        lblDefinitions.MinimumSize = New Size(425, 25)
        lblDefinitions.Name = "lblDefinitions"
        lblDefinitions.RightToLeft = RightToLeft.No
        lblDefinitions.Size = New Size(425, 25)
        lblDefinitions.TabIndex = 5
        lblDefinitions.Text = "Label1"
        lblDefinitions.TextAlign = ContentAlignment.TopCenter
        ' 
        ' frmTribs
        ' 
        AllowDrop = True
        AutoScaleDimensions = New SizeF(6F, 13F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(467, 619)
        Controls.Add(Toolbar1)
        Controls.Add(SSTab1)
        Controls.Add(Combo1)
        Controls.Add(lblCount)
        Controls.Add(lblDefinitions)
        Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedDialog
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Location = New Point(3, 22)
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmTribs"
        RightToLeft = RightToLeft.No
        ShowInTaskbar = False
        Text = "Edit Tributary Data"
        Toolbar1.ResumeLayout(False)
        Toolbar1.PerformLayout()
        SSTab1.ResumeLayout(False)
        _SSTab1_TabPage0.ResumeLayout(False)
        _SSTab1_TabPage0.PerformLayout()
        _SSTab1_TabPage1.ResumeLayout(False)
        _SSTab1_TabPage1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Sub ReLoadForm(ByVal addEvents As Boolean)
		InitializetxtText()
		InitializelblLabel()
		If addEvents Then
			AddHandler MyBase.MouseMove, AddressOf Form_MouseMove
			AddHandler MyBase.Closed, AddressOf Form_Closed
			AddHandler Activated, AddressOf frmTribs_Activated
		End If
	End Sub
	Sub InitializetxtText()
		ReDim txtText(23)
		txtText(23) = _txtText_23
		txtText(21) = _txtText_21
		txtText(20) = _txtText_20
		txtText(19) = _txtText_19
		txtText(18) = _txtText_18
		txtText(17) = _txtText_17
		txtText(16) = _txtText_16
		txtText(15) = _txtText_15
		txtText(14) = _txtText_14
		txtText(13) = _txtText_13
		txtText(12) = _txtText_12
		txtText(11) = _txtText_11
		txtText(10) = _txtText_10
		txtText(9) = _txtText_9
		txtText(8) = _txtText_8
		txtText(7) = _txtText_7
		txtText(6) = _txtText_6
		txtText(5) = _txtText_5
		txtText(4) = _txtText_4
		txtText(3) = _txtText_3
		txtText(2) = _txtText_2
		txtText(1) = _txtText_1
		txtText(0) = _txtText_0
		txtText(22) = _txtText_22
	End Sub
	Sub InitializelblLabel()
		ReDim lblLabel(21)
		lblLabel(21) = _lblLabel_21
		lblLabel(20) = _lblLabel_20
		lblLabel(16) = _lblLabel_16
		lblLabel(19) = _lblLabel_19
		lblLabel(18) = _lblLabel_18
		lblLabel(17) = _lblLabel_17
		lblLabel(12) = _lblLabel_12
		lblLabel(15) = _lblLabel_15
		lblLabel(14) = _lblLabel_14
		lblLabel(13) = _lblLabel_13
		lblLabel(11) = _lblLabel_11
		lblLabel(10) = _lblLabel_10
		lblLabel(9) = _lblLabel_9
		lblLabel(8) = _lblLabel_8
		lblLabel(7) = _lblLabel_7
		lblLabel(6) = _lblLabel_6
		lblLabel(5) = _lblLabel_5
		lblLabel(4) = _lblLabel_4
		lblLabel(3) = _lblLabel_3
		lblLabel(2) = _lblLabel_2
		lblLabel(1) = _lblLabel_1
		lblLabel(0) = _lblLabel_0
	End Sub
#End Region
End Class