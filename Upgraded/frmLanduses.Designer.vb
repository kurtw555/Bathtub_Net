<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLandUse
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As frmLandUse
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As frmLandUse
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = CreateInstance()
				m_InitializingDefInstance = False
			End If
			Return m_vb6FormDefInstance
		End Get
		Set(ByVal Value As frmLandUse)
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region
#Region "Windows Form Designer generated code "
	Public Shared Function CreateInstance() As frmLandUse
		Dim theInstance As New frmLandUse()
		theInstance.Form_Load()
		Return theInstance
	End Function
	Private visualControls() As String = New String() {"components", "ToolTipMain", "_Text1_12", "_Text1_11", "_Text1_10", "_Text1_9", "_Text1_8", "_Text1_7", "_Text1_6", "_Text1_5", "_Text1_4", "_Text1_3", "_Text1_2", "_Text1_1", "_Text1_0", "Combo1", "Toolbar1_Buttons_Button1", "Toolbar1_Buttons_Button2", "Toolbar1_Buttons_Button3", "Toolbar1_Buttons_Button4", "Toolbar1_Buttons_Button5", "Toolbar1", "lblDefinitions", "_Label1_7", "_Label1_3", "_Label1_6", "_Label1_5", "_Label1_4", "_frmLandUses_3", "_Label1_2", "_Label1_1", "_Label1_0", "Label1", "Text1", "frmLandUses"}
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTipMain As System.Windows.Forms.ToolTip
	Private WithEvents _Text1_12 As System.Windows.Forms.TextBox
	Private WithEvents _Text1_11 As System.Windows.Forms.TextBox
	Private WithEvents _Text1_10 As System.Windows.Forms.TextBox
	Private WithEvents _Text1_9 As System.Windows.Forms.TextBox
	Private WithEvents _Text1_8 As System.Windows.Forms.TextBox
	Private WithEvents _Text1_7 As System.Windows.Forms.TextBox
	Private WithEvents _Text1_6 As System.Windows.Forms.TextBox
	Private WithEvents _Text1_5 As System.Windows.Forms.TextBox
	Private WithEvents _Text1_4 As System.Windows.Forms.TextBox
	Private WithEvents _Text1_3 As System.Windows.Forms.TextBox
	Private WithEvents _Text1_2 As System.Windows.Forms.TextBox
	Private WithEvents _Text1_1 As System.Windows.Forms.TextBox
	Private WithEvents _Text1_0 As System.Windows.Forms.TextBox
	Public WithEvents Combo1 As System.Windows.Forms.ComboBox
	Public WithEvents Toolbar1_Buttons_Button1 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Buttons_Button2 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Buttons_Button3 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Buttons_Button4 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Buttons_Button5 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1 As System.Windows.Forms.ToolStrip
	Public WithEvents lblDefinitions As System.Windows.Forms.Label
	Private WithEvents _Label1_7 As System.Windows.Forms.Label
	Private WithEvents _Label1_3 As System.Windows.Forms.Label
	Private WithEvents _Label1_6 As System.Windows.Forms.Label
	Private WithEvents _Label1_5 As System.Windows.Forms.Label
	Private WithEvents _Label1_4 As System.Windows.Forms.Label
	Private WithEvents _frmLandUses_3 As System.Windows.Forms.Label
	Private WithEvents _Label1_2 As System.Windows.Forms.Label
	Private WithEvents _Label1_1 As System.Windows.Forms.Label
	Private WithEvents _Label1_0 As System.Windows.Forms.Label
	Public Label1(7) As System.Windows.Forms.Label
	Public Text1(12) As System.Windows.Forms.TextBox
	Public frmLandUses(3) As System.Windows.Forms.Label
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        ToolTipMain = New ToolTip(components)
        Combo1 = New ComboBox()
        _Text1_12 = New TextBox()
        _Text1_11 = New TextBox()
        _Text1_10 = New TextBox()
        _Text1_9 = New TextBox()
        _Text1_8 = New TextBox()
        _Text1_7 = New TextBox()
        _Text1_6 = New TextBox()
        _Text1_5 = New TextBox()
        _Text1_4 = New TextBox()
        _Text1_3 = New TextBox()
        _Text1_2 = New TextBox()
        _Text1_1 = New TextBox()
        _Text1_0 = New TextBox()
        Toolbar1 = New ToolStrip()
        Toolbar1_Buttons_Button1 = New ToolStripButton()
        Toolbar1_Buttons_Button2 = New ToolStripButton()
        Toolbar1_Buttons_Button3 = New ToolStripButton()
        Toolbar1_Buttons_Button4 = New ToolStripButton()
        Toolbar1_Buttons_Button5 = New ToolStripButton()
        lblDefinitions = New Label()
        _Label1_7 = New Label()
        _Label1_3 = New Label()
        _Label1_6 = New Label()
        _Label1_5 = New Label()
        _Label1_4 = New Label()
        _frmLandUses_3 = New Label()
        _Label1_2 = New Label()
        _Label1_1 = New Label()
        _Label1_0 = New Label()
        Toolbar1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Combo1
        ' 
        Combo1.AllowDrop = True
        Combo1.BackColor = SystemColors.Window
        Combo1.DropDownStyle = ComboBoxStyle.DropDownList
        Combo1.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Combo1.ForeColor = SystemColors.WindowText
        Combo1.Location = New Point(16, 56)
        Combo1.Name = "Combo1"
        Combo1.RightToLeft = RightToLeft.No
        Combo1.Size = New Size(161, 24)
        Combo1.TabIndex = 0
        ToolTipMain.SetToolTip(Combo1, "Select Land Use to be Edited")
        ' 
        ' _Text1_12
        ' 
        _Text1_12.AcceptsReturn = True
        _Text1_12.AllowDrop = True
        _Text1_12.BackColor = SystemColors.Window
        _Text1_12.Cursor = Cursors.IBeam
        _Text1_12.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _Text1_12.ForeColor = SystemColors.WindowText
        _Text1_12.Location = New Point(320, 400)
        _Text1_12.MaxLength = 0
        _Text1_12.Name = "_Text1_12"
        _Text1_12.RightToLeft = RightToLeft.No
        _Text1_12.Size = New Size(65, 22)
        _Text1_12.TabIndex = 13
        _Text1_12.Text = "0"
        _Text1_12.TextAlign = HorizontalAlignment.Center
        ' 
        ' _Text1_11
        ' 
        _Text1_11.AcceptsReturn = True
        _Text1_11.AllowDrop = True
        _Text1_11.BackColor = SystemColors.Window
        _Text1_11.Cursor = Cursors.IBeam
        _Text1_11.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _Text1_11.ForeColor = SystemColors.WindowText
        _Text1_11.Location = New Point(216, 400)
        _Text1_11.MaxLength = 0
        _Text1_11.Name = "_Text1_11"
        _Text1_11.RightToLeft = RightToLeft.No
        _Text1_11.Size = New Size(89, 22)
        _Text1_11.TabIndex = 12
        _Text1_11.Text = "0"
        _Text1_11.TextAlign = HorizontalAlignment.Center
        ' 
        ' _Text1_10
        ' 
        _Text1_10.AcceptsReturn = True
        _Text1_10.AllowDrop = True
        _Text1_10.BackColor = SystemColors.Window
        _Text1_10.Cursor = Cursors.IBeam
        _Text1_10.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _Text1_10.ForeColor = SystemColors.WindowText
        _Text1_10.Location = New Point(320, 360)
        _Text1_10.MaxLength = 0
        _Text1_10.Name = "_Text1_10"
        _Text1_10.RightToLeft = RightToLeft.No
        _Text1_10.Size = New Size(65, 22)
        _Text1_10.TabIndex = 11
        _Text1_10.Text = "0"
        _Text1_10.TextAlign = HorizontalAlignment.Center
        ' 
        ' _Text1_9
        ' 
        _Text1_9.AcceptsReturn = True
        _Text1_9.AllowDrop = True
        _Text1_9.BackColor = SystemColors.Window
        _Text1_9.Cursor = Cursors.IBeam
        _Text1_9.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _Text1_9.ForeColor = SystemColors.WindowText
        _Text1_9.Location = New Point(216, 360)
        _Text1_9.MaxLength = 0
        _Text1_9.Name = "_Text1_9"
        _Text1_9.RightToLeft = RightToLeft.No
        _Text1_9.Size = New Size(89, 22)
        _Text1_9.TabIndex = 10
        _Text1_9.Text = "0"
        _Text1_9.TextAlign = HorizontalAlignment.Center
        ' 
        ' _Text1_8
        ' 
        _Text1_8.AcceptsReturn = True
        _Text1_8.AllowDrop = True
        _Text1_8.BackColor = SystemColors.Window
        _Text1_8.Cursor = Cursors.IBeam
        _Text1_8.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _Text1_8.ForeColor = SystemColors.WindowText
        _Text1_8.Location = New Point(320, 320)
        _Text1_8.MaxLength = 0
        _Text1_8.Name = "_Text1_8"
        _Text1_8.RightToLeft = RightToLeft.No
        _Text1_8.Size = New Size(65, 22)
        _Text1_8.TabIndex = 9
        _Text1_8.Text = "0"
        _Text1_8.TextAlign = HorizontalAlignment.Center
        ' 
        ' _Text1_7
        ' 
        _Text1_7.AcceptsReturn = True
        _Text1_7.AllowDrop = True
        _Text1_7.BackColor = SystemColors.Window
        _Text1_7.Cursor = Cursors.IBeam
        _Text1_7.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _Text1_7.ForeColor = SystemColors.WindowText
        _Text1_7.Location = New Point(216, 320)
        _Text1_7.MaxLength = 0
        _Text1_7.Name = "_Text1_7"
        _Text1_7.RightToLeft = RightToLeft.No
        _Text1_7.Size = New Size(89, 22)
        _Text1_7.TabIndex = 8
        _Text1_7.Text = "0"
        _Text1_7.TextAlign = HorizontalAlignment.Center
        ' 
        ' _Text1_6
        ' 
        _Text1_6.AcceptsReturn = True
        _Text1_6.AllowDrop = True
        _Text1_6.BackColor = SystemColors.Window
        _Text1_6.Cursor = Cursors.IBeam
        _Text1_6.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _Text1_6.ForeColor = SystemColors.WindowText
        _Text1_6.Location = New Point(320, 280)
        _Text1_6.MaxLength = 0
        _Text1_6.Name = "_Text1_6"
        _Text1_6.RightToLeft = RightToLeft.No
        _Text1_6.Size = New Size(65, 22)
        _Text1_6.TabIndex = 7
        _Text1_6.Text = "0"
        _Text1_6.TextAlign = HorizontalAlignment.Center
        ' 
        ' _Text1_5
        ' 
        _Text1_5.AcceptsReturn = True
        _Text1_5.AllowDrop = True
        _Text1_5.BackColor = SystemColors.Window
        _Text1_5.Cursor = Cursors.IBeam
        _Text1_5.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _Text1_5.ForeColor = SystemColors.WindowText
        _Text1_5.Location = New Point(216, 280)
        _Text1_5.MaxLength = 0
        _Text1_5.Name = "_Text1_5"
        _Text1_5.RightToLeft = RightToLeft.No
        _Text1_5.Size = New Size(89, 22)
        _Text1_5.TabIndex = 6
        _Text1_5.Text = "0"
        _Text1_5.TextAlign = HorizontalAlignment.Center
        ' 
        ' _Text1_4
        ' 
        _Text1_4.AcceptsReturn = True
        _Text1_4.AllowDrop = True
        _Text1_4.BackColor = SystemColors.Window
        _Text1_4.Cursor = Cursors.IBeam
        _Text1_4.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _Text1_4.ForeColor = SystemColors.WindowText
        _Text1_4.Location = New Point(320, 240)
        _Text1_4.MaxLength = 0
        _Text1_4.Name = "_Text1_4"
        _Text1_4.RightToLeft = RightToLeft.No
        _Text1_4.Size = New Size(65, 22)
        _Text1_4.TabIndex = 5
        _Text1_4.Text = "0"
        _Text1_4.TextAlign = HorizontalAlignment.Center
        ' 
        ' _Text1_3
        ' 
        _Text1_3.AcceptsReturn = True
        _Text1_3.AllowDrop = True
        _Text1_3.BackColor = SystemColors.Window
        _Text1_3.Cursor = Cursors.IBeam
        _Text1_3.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _Text1_3.ForeColor = SystemColors.WindowText
        _Text1_3.Location = New Point(216, 240)
        _Text1_3.MaxLength = 0
        _Text1_3.Name = "_Text1_3"
        _Text1_3.RightToLeft = RightToLeft.No
        _Text1_3.Size = New Size(89, 22)
        _Text1_3.TabIndex = 4
        _Text1_3.Text = "0"
        _Text1_3.TextAlign = HorizontalAlignment.Center
        ' 
        ' _Text1_2
        ' 
        _Text1_2.AcceptsReturn = True
        _Text1_2.AllowDrop = True
        _Text1_2.BackColor = SystemColors.Window
        _Text1_2.Cursor = Cursors.IBeam
        _Text1_2.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _Text1_2.ForeColor = SystemColors.WindowText
        _Text1_2.Location = New Point(320, 200)
        _Text1_2.MaxLength = 0
        _Text1_2.Name = "_Text1_2"
        _Text1_2.RightToLeft = RightToLeft.No
        _Text1_2.Size = New Size(65, 22)
        _Text1_2.TabIndex = 3
        _Text1_2.Text = "0"
        _Text1_2.TextAlign = HorizontalAlignment.Center
        ' 
        ' _Text1_1
        ' 
        _Text1_1.AcceptsReturn = True
        _Text1_1.AllowDrop = True
        _Text1_1.BackColor = SystemColors.Window
        _Text1_1.Cursor = Cursors.IBeam
        _Text1_1.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _Text1_1.ForeColor = SystemColors.WindowText
        _Text1_1.Location = New Point(216, 200)
        _Text1_1.MaxLength = 0
        _Text1_1.Name = "_Text1_1"
        _Text1_1.RightToLeft = RightToLeft.No
        _Text1_1.Size = New Size(89, 22)
        _Text1_1.TabIndex = 2
        _Text1_1.Text = "0"
        _Text1_1.TextAlign = HorizontalAlignment.Center
        ' 
        ' _Text1_0
        ' 
        _Text1_0.AcceptsReturn = True
        _Text1_0.AllowDrop = True
        _Text1_0.BackColor = SystemColors.Window
        _Text1_0.Cursor = Cursors.IBeam
        _Text1_0.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _Text1_0.ForeColor = SystemColors.WindowText
        _Text1_0.Location = New Point(224, 136)
        _Text1_0.MaxLength = 0
        _Text1_0.Name = "_Text1_0"
        _Text1_0.RightToLeft = RightToLeft.No
        _Text1_0.Size = New Size(145, 22)
        _Text1_0.TabIndex = 1
        _Text1_0.Text = "0"
        ' 
        ' Toolbar1
        ' 
        Toolbar1.AllowDrop = True
        Toolbar1.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Toolbar1.Items.AddRange(New ToolStripItem() {Toolbar1_Buttons_Button1, Toolbar1_Buttons_Button2, Toolbar1_Buttons_Button3, Toolbar1_Buttons_Button4, Toolbar1_Buttons_Button5})
        Toolbar1.Location = New Point(0, 0)
        Toolbar1.Name = "Toolbar1"
        Toolbar1.Size = New Size(409, 25)
        Toolbar1.TabIndex = 24
        ' 
        ' Toolbar1_Buttons_Button1
        ' 
        Toolbar1_Buttons_Button1.ImageScaling = ToolStripItemImageScaling.None
        Toolbar1_Buttons_Button1.Name = "Toolbar1_Buttons_Button1"
        Toolbar1_Buttons_Button1.Size = New Size(35, 22)
        Toolbar1_Buttons_Button1.Text = "Clear"
        Toolbar1_Buttons_Button1.TextImageRelation = TextImageRelation.ImageAboveText
        Toolbar1_Buttons_Button1.ToolTipText = "Clear values for current land use"
        ' 
        ' Toolbar1_Buttons_Button2
        ' 
        Toolbar1_Buttons_Button2.ImageScaling = ToolStripItemImageScaling.None
        Toolbar1_Buttons_Button2.Name = "Toolbar1_Buttons_Button2"
        Toolbar1_Buttons_Button2.Size = New Size(37, 22)
        Toolbar1_Buttons_Button2.Text = "Undo"
        Toolbar1_Buttons_Button2.TextImageRelation = TextImageRelation.ImageAboveText
        Toolbar1_Buttons_Button2.ToolTipText = "Restore initial values for all land uses"
        ' 
        ' Toolbar1_Buttons_Button3
        ' 
        Toolbar1_Buttons_Button3.ImageScaling = ToolStripItemImageScaling.None
        Toolbar1_Buttons_Button3.Name = "Toolbar1_Buttons_Button3"
        Toolbar1_Buttons_Button3.Size = New Size(33, 22)
        Toolbar1_Buttons_Button3.Text = "Help"
        Toolbar1_Buttons_Button3.TextImageRelation = TextImageRelation.ImageAboveText
        Toolbar1_Buttons_Button3.ToolTipText = "Get Help"
        ' 
        ' Toolbar1_Buttons_Button4
        ' 
        Toolbar1_Buttons_Button4.ImageScaling = ToolStripItemImageScaling.None
        Toolbar1_Buttons_Button4.Name = "Toolbar1_Buttons_Button4"
        Toolbar1_Buttons_Button4.Size = New Size(44, 22)
        Toolbar1_Buttons_Button4.Text = "Cancel"
        Toolbar1_Buttons_Button4.TextImageRelation = TextImageRelation.ImageAboveText
        Toolbar1_Buttons_Button4.ToolTipText = "Ignore edits & return to program menu"
        ' 
        ' Toolbar1_Buttons_Button5
        ' 
        Toolbar1_Buttons_Button5.ImageScaling = ToolStripItemImageScaling.None
        Toolbar1_Buttons_Button5.Name = "Toolbar1_Buttons_Button5"
        Toolbar1_Buttons_Button5.Size = New Size(26, 22)
        Toolbar1_Buttons_Button5.Text = "OK"
        Toolbar1_Buttons_Button5.TextImageRelation = TextImageRelation.ImageAboveText
        Toolbar1_Buttons_Button5.ToolTipText = "Save edits & return to program menu"
        ' 
        ' lblDefinitions
        ' 
        lblDefinitions.AllowDrop = True
        lblDefinitions.BackColor = SystemColors.Control
        lblDefinitions.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDefinitions.ForeColor = SystemColors.Highlight
        lblDefinitions.Location = New Point(56, 96)
        lblDefinitions.MinimumSize = New Size(321, 17)
        lblDefinitions.Name = "lblDefinitions"
        lblDefinitions.RightToLeft = RightToLeft.No
        lblDefinitions.Size = New Size(321, 17)
        lblDefinitions.TabIndex = 23
        lblDefinitions.Text = "Label2"
        lblDefinitions.TextAlign = ContentAlignment.TopCenter
        ' 
        ' _Label1_7
        ' 
        _Label1_7.AllowDrop = True
        _Label1_7.BackColor = SystemColors.Control
        _Label1_7.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        _Label1_7.ForeColor = SystemColors.ControlText
        _Label1_7.Location = New Point(320, 168)
        _Label1_7.MinimumSize = New Size(57, 25)
        _Label1_7.Name = "_Label1_7"
        _Label1_7.RightToLeft = RightToLeft.No
        _Label1_7.Size = New Size(57, 25)
        _Label1_7.TabIndex = 22
        _Label1_7.Text = "CV"
        _Label1_7.TextAlign = ContentAlignment.TopCenter
        ' 
        ' _Label1_3
        ' 
        _Label1_3.AllowDrop = True
        _Label1_3.BackColor = SystemColors.Control
        _Label1_3.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        _Label1_3.ForeColor = SystemColors.ControlText
        _Label1_3.Location = New Point(224, 168)
        _Label1_3.MinimumSize = New Size(57, 25)
        _Label1_3.Name = "_Label1_3"
        _Label1_3.RightToLeft = RightToLeft.No
        _Label1_3.Size = New Size(57, 25)
        _Label1_3.TabIndex = 21
        _Label1_3.Text = "Mean"
        _Label1_3.TextAlign = ContentAlignment.TopCenter
        ' 
        ' _Label1_6
        ' 
        _Label1_6.AllowDrop = True
        _Label1_6.BackColor = SystemColors.Control
        _Label1_6.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _Label1_6.ForeColor = SystemColors.ControlText
        _Label1_6.Location = New Point(16, 136)
        _Label1_6.MinimumSize = New Size(177, 25)
        _Label1_6.Name = "_Label1_6"
        _Label1_6.RightToLeft = RightToLeft.No
        _Label1_6.Size = New Size(177, 25)
        _Label1_6.TabIndex = 20
        _Label1_6.Text = "Landuse Category Name:"
        _Label1_6.TextAlign = ContentAlignment.TopRight
        ' 
        ' _Label1_5
        ' 
        _Label1_5.AllowDrop = True
        _Label1_5.BackColor = SystemColors.Control
        _Label1_5.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _Label1_5.ForeColor = SystemColors.ControlText
        _Label1_5.Location = New Point(0, 400)
        _Label1_5.MinimumSize = New Size(193, 25)
        _Label1_5.Name = "_Label1_5"
        _Label1_5.RightToLeft = RightToLeft.No
        _Label1_5.Size = New Size(193, 25)
        _Label1_5.TabIndex = 19
        _Label1_5.Text = "Conservative Subst. Conc (-):"
        _Label1_5.TextAlign = ContentAlignment.TopRight
        ' 
        ' _Label1_4
        ' 
        _Label1_4.AllowDrop = True
        _Label1_4.BackColor = SystemColors.Control
        _Label1_4.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _Label1_4.ForeColor = SystemColors.ControlText
        _Label1_4.Location = New Point(24, 360)
        _Label1_4.MinimumSize = New Size(169, 25)
        _Label1_4.Name = "_Label1_4"
        _Label1_4.RightToLeft = RightToLeft.No
        _Label1_4.Size = New Size(169, 25)
        _Label1_4.TabIndex = 18
        _Label1_4.Text = "Inorganic N Conc (mg/m3):"
        _Label1_4.TextAlign = ContentAlignment.TopRight
        ' 
        ' _frmLandUses_3
        ' 
        _frmLandUses_3.AllowDrop = True
        _frmLandUses_3.BackColor = SystemColors.Control
        _frmLandUses_3.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _frmLandUses_3.ForeColor = SystemColors.ControlText
        _frmLandUses_3.Location = New Point(48, 320)
        _frmLandUses_3.MinimumSize = New Size(145, 25)
        _frmLandUses_3.Name = "_frmLandUses_3"
        _frmLandUses_3.RightToLeft = RightToLeft.No
        _frmLandUses_3.Size = New Size(145, 25)
        _frmLandUses_3.TabIndex = 17
        _frmLandUses_3.Text = "Total N Conc (mg/m3):"
        _frmLandUses_3.TextAlign = ContentAlignment.TopRight
        ' 
        ' _Label1_2
        ' 
        _Label1_2.AllowDrop = True
        _Label1_2.BackColor = SystemColors.Control
        _Label1_2.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _Label1_2.ForeColor = SystemColors.ControlText
        _Label1_2.Location = New Point(48, 280)
        _Label1_2.MinimumSize = New Size(145, 25)
        _Label1_2.Name = "_Label1_2"
        _Label1_2.RightToLeft = RightToLeft.No
        _Label1_2.Size = New Size(145, 25)
        _Label1_2.TabIndex = 16
        _Label1_2.Text = "Ortho P Conc (mg/m3):"
        _Label1_2.TextAlign = ContentAlignment.TopRight
        ' 
        ' _Label1_1
        ' 
        _Label1_1.AllowDrop = True
        _Label1_1.BackColor = SystemColors.Control
        _Label1_1.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _Label1_1.ForeColor = SystemColors.ControlText
        _Label1_1.Location = New Point(48, 240)
        _Label1_1.MinimumSize = New Size(145, 25)
        _Label1_1.Name = "_Label1_1"
        _Label1_1.RightToLeft = RightToLeft.No
        _Label1_1.Size = New Size(145, 25)
        _Label1_1.TabIndex = 15
        _Label1_1.Text = "Total P Conc (mg/m3):"
        _Label1_1.TextAlign = ContentAlignment.TopRight
        ' 
        ' _Label1_0
        ' 
        _Label1_0.AllowDrop = True
        _Label1_0.BackColor = SystemColors.Control
        _Label1_0.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _Label1_0.ForeColor = SystemColors.ControlText
        _Label1_0.Location = New Point(48, 200)
        _Label1_0.MinimumSize = New Size(145, 25)
        _Label1_0.Name = "_Label1_0"
        _Label1_0.RightToLeft = RightToLeft.No
        _Label1_0.Size = New Size(145, 25)
        _Label1_0.TabIndex = 14
        _Label1_0.Text = "Runoff (m/yr):"
        _Label1_0.TextAlign = ContentAlignment.TopRight
        ' 
        ' frmLandUse
        ' 
        AllowDrop = True
        AutoScaleDimensions = New SizeF(6.0F, 13.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(409, 444)
        Controls.Add(_Text1_12)
        Controls.Add(_Text1_11)
        Controls.Add(_Text1_10)
        Controls.Add(_Text1_9)
        Controls.Add(_Text1_8)
        Controls.Add(_Text1_7)
        Controls.Add(_Text1_6)
        Controls.Add(_Text1_5)
        Controls.Add(_Text1_4)
        Controls.Add(_Text1_3)
        Controls.Add(_Text1_2)
        Controls.Add(_Text1_1)
        Controls.Add(_Text1_0)
        Controls.Add(Combo1)
        Controls.Add(Toolbar1)
        Controls.Add(lblDefinitions)
        Controls.Add(_Label1_7)
        Controls.Add(_Label1_3)
        Controls.Add(_Label1_6)
        Controls.Add(_Label1_5)
        Controls.Add(_Label1_4)
        Controls.Add(_frmLandUses_3)
        Controls.Add(_Label1_2)
        Controls.Add(_Label1_1)
        Controls.Add(_Label1_0)
        Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedDialog
        Location = New Point(3, 22)
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmLandUse"
        RightToLeft = RightToLeft.No
        ShowInTaskbar = False
        Text = "Edit NonPoint Source Export Coefficients"
        Toolbar1.ResumeLayout(False)
        Toolbar1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Sub ReLoadForm(ByVal addEvents As Boolean)
		InitializefrmLandUses()
		InitializeText1()
		InitializeLabel1()
		If addEvents Then
			AddHandler MyBase.MouseMove, AddressOf Form_MouseMove
			AddHandler MyBase.Closed, AddressOf Form_Closed
			AddHandler Activated, AddressOf frmLandUse_Activated
		End If
	End Sub
	Sub InitializefrmLandUses()
		ReDim frmLandUses(3)
		frmLandUses(3) = _frmLandUses_3
	End Sub
	Sub InitializeText1()
		ReDim Text1(12)
		Text1(12) = _Text1_12
		Text1(11) = _Text1_11
		Text1(10) = _Text1_10
		Text1(9) = _Text1_9
		Text1(8) = _Text1_8
		Text1(7) = _Text1_7
		Text1(6) = _Text1_6
		Text1(5) = _Text1_5
		Text1(4) = _Text1_4
		Text1(3) = _Text1_3
		Text1(2) = _Text1_2
		Text1(1) = _Text1_1
		Text1(0) = _Text1_0
	End Sub
	Sub InitializeLabel1()
		ReDim Label1(7)
		Label1(7) = _Label1_7
		Label1(3) = _Label1_3
		Label1(6) = _Label1_6
		Label1(5) = _Label1_5
		Label1(4) = _Label1_4
		Label1(2) = _Label1_2
		Label1(1) = _Label1_1
		Label1(0) = _Label1_0
	End Sub
#End Region
End Class