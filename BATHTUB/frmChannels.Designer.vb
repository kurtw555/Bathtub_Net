<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChannels
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As frmChannels
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As frmChannels
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = CreateInstance()
				m_InitializingDefInstance = False
			End If
			Return m_vb6FormDefInstance
		End Get
		Set(ByVal Value As frmChannels)
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region
#Region "Windows Form Designer generated code "
	Public Shared Function CreateInstance() As frmChannels
		Dim theInstance As New frmChannels()
		theInstance.Form_Load()
		Return theInstance
	End Function
	Private visualControls() As String = New String() {"components", "ToolTipMain", "Combo3", "Combo2", "Combo1", "_Text1_0", "_Text1_1", "_Text1_2", "_Text1_3", "_Text1_4", "_Text1_6", "_Text1_5", "Toolbar1_Buttons_Button1", "Toolbar1_Buttons_Button2", "Toolbar1_Buttons_Button3", "Toolbar1_Buttons_Button4", "Toolbar1_Buttons_Button5", "Toolbar1_Buttons_Button6", "Toolbar1_Buttons_Button7", "Toolbar1_Buttons_Button8", "Toolbar1", "Label2", "_Label1_4", "_Label1_2", "_Label1_0", "_Label1_1", "_Label1_6", "_Label1_3", "_Label1_7", "lblDefinitions", "Label1", "Text1"}
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTipMain As System.Windows.Forms.ToolTip
	Public WithEvents Combo3 As System.Windows.Forms.ComboBox
	Public WithEvents Combo2 As System.Windows.Forms.ComboBox
	Public WithEvents Combo1 As System.Windows.Forms.ComboBox
	Private WithEvents _Text1_0 As System.Windows.Forms.TextBox
	Private WithEvents _Text1_1 As System.Windows.Forms.TextBox
	Private WithEvents _Text1_2 As System.Windows.Forms.TextBox
	Private WithEvents _Text1_3 As System.Windows.Forms.TextBox
	Private WithEvents _Text1_4 As System.Windows.Forms.TextBox
	Private WithEvents _Text1_6 As System.Windows.Forms.TextBox
	Private WithEvents _Text1_5 As System.Windows.Forms.TextBox
	Public WithEvents Toolbar1_Buttons_Button1 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Buttons_Button2 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Buttons_Button3 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Buttons_Button4 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Buttons_Button5 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Buttons_Button6 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Buttons_Button7 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Buttons_Button8 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1 As System.Windows.Forms.ToolStrip
	Public WithEvents Label2 As System.Windows.Forms.Label
	Private WithEvents _Label1_4 As System.Windows.Forms.Label
	Private WithEvents _Label1_2 As System.Windows.Forms.Label
	Private WithEvents _Label1_0 As System.Windows.Forms.Label
	Private WithEvents _Label1_1 As System.Windows.Forms.Label
	Private WithEvents _Label1_6 As System.Windows.Forms.Label
	Private WithEvents _Label1_3 As System.Windows.Forms.Label
	Private WithEvents _Label1_7 As System.Windows.Forms.Label
	Public WithEvents lblDefinitions As System.Windows.Forms.Label
	Public Label1(7) As System.Windows.Forms.Label
	Public Text1(6) As System.Windows.Forms.TextBox
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChannels))
        ToolTipMain = New ToolTip(components)
        Combo3 = New ComboBox()
        Combo2 = New ComboBox()
        Combo1 = New ComboBox()
        _Text1_0 = New TextBox()
        _Text1_1 = New TextBox()
        _Text1_2 = New TextBox()
        _Text1_3 = New TextBox()
        _Text1_4 = New TextBox()
        _Text1_6 = New TextBox()
        _Text1_5 = New TextBox()
        Toolbar1 = New ToolStrip()
        Toolbar1_Buttons_Button1 = New ToolStripButton()
        Toolbar1_Buttons_Button2 = New ToolStripButton()
        Toolbar1_Buttons_Button3 = New ToolStripButton()
        Toolbar1_Buttons_Button4 = New ToolStripButton()
        Toolbar1_Buttons_Button5 = New ToolStripButton()
        Toolbar1_Buttons_Button6 = New ToolStripButton()
        Toolbar1_Buttons_Button7 = New ToolStripButton()
        Toolbar1_Buttons_Button8 = New ToolStripButton()
        Label2 = New Label()
        _Label1_4 = New Label()
        _Label1_2 = New Label()
        _Label1_0 = New Label()
        _Label1_1 = New Label()
        _Label1_6 = New Label()
        _Label1_3 = New Label()
        _Label1_7 = New Label()
        lblDefinitions = New Label()
        Toolbar1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Combo3
        ' 
        Combo3.AllowDrop = True
        Combo3.BackColor = SystemColors.Window
        Combo3.DropDownStyle = ComboBoxStyle.DropDownList
        Combo3.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Combo3.ForeColor = SystemColors.WindowText
        Combo3.Location = New Point(200, 184)
        Combo3.Name = "Combo3"
        Combo3.RightToLeft = RightToLeft.No
        Combo3.Size = New Size(161, 24)
        Combo3.TabIndex = 2
        ToolTipMain.SetToolTip(Combo3, "Select Upstream Segment ")
        ' 
        ' Combo2
        ' 
        Combo2.AllowDrop = True
        Combo2.BackColor = SystemColors.Window
        Combo2.DropDownStyle = ComboBoxStyle.DropDownList
        Combo2.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Combo2.ForeColor = SystemColors.WindowText
        Combo2.Location = New Point(200, 224)
        Combo2.Name = "Combo2"
        Combo2.RightToLeft = RightToLeft.No
        Combo2.Size = New Size(161, 24)
        Combo2.TabIndex = 3
        ToolTipMain.SetToolTip(Combo2, "Select Downstream Segment")
        ' 
        ' Combo1
        ' 
        Combo1.AllowDrop = True
        Combo1.BackColor = SystemColors.Window
        Combo1.DropDownStyle = ComboBoxStyle.DropDownList
        Combo1.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Combo1.ForeColor = SystemColors.WindowText
        Combo1.Location = New Point(0, 64)
        Combo1.Name = "Combo1"
        Combo1.RightToLeft = RightToLeft.No
        Combo1.Size = New Size(161, 24)
        Combo1.TabIndex = 0
        ToolTipMain.SetToolTip(Combo1, "Select Channel to be Edited")
        ' 
        ' _Text1_0
        ' 
        _Text1_0.AcceptsReturn = True
        _Text1_0.AllowDrop = True
        _Text1_0.BackColor = SystemColors.Window
        _Text1_0.Cursor = Cursors.IBeam
        _Text1_0.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _Text1_0.ForeColor = SystemColors.WindowText
        _Text1_0.Location = New Point(200, 144)
        _Text1_0.MaxLength = 0
        _Text1_0.Name = "_Text1_0"
        _Text1_0.RightToLeft = RightToLeft.No
        _Text1_0.Size = New Size(161, 22)
        _Text1_0.TabIndex = 1
        _Text1_0.Text = "Text1"
        ' 
        ' _Text1_1
        ' 
        _Text1_1.AcceptsReturn = True
        _Text1_1.AllowDrop = True
        _Text1_1.BackColor = SystemColors.Window
        _Text1_1.Cursor = Cursors.IBeam
        _Text1_1.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _Text1_1.ForeColor = SystemColors.WindowText
        _Text1_1.Location = New Point(208, 296)
        _Text1_1.MaxLength = 0
        _Text1_1.Name = "_Text1_1"
        _Text1_1.RightToLeft = RightToLeft.No
        _Text1_1.Size = New Size(89, 22)
        _Text1_1.TabIndex = 4
        _Text1_1.Text = "Text1"
        _Text1_1.TextAlign = HorizontalAlignment.Center
        ' 
        ' _Text1_2
        ' 
        _Text1_2.AcceptsReturn = True
        _Text1_2.AllowDrop = True
        _Text1_2.BackColor = SystemColors.Window
        _Text1_2.Cursor = Cursors.IBeam
        _Text1_2.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _Text1_2.ForeColor = SystemColors.WindowText
        _Text1_2.Location = New Point(312, 296)
        _Text1_2.MaxLength = 0
        _Text1_2.Name = "_Text1_2"
        _Text1_2.RightToLeft = RightToLeft.No
        _Text1_2.Size = New Size(65, 22)
        _Text1_2.TabIndex = 5
        _Text1_2.Text = "Text1"
        _Text1_2.TextAlign = HorizontalAlignment.Center
        ' 
        ' _Text1_3
        ' 
        _Text1_3.AcceptsReturn = True
        _Text1_3.AllowDrop = True
        _Text1_3.BackColor = SystemColors.Window
        _Text1_3.Cursor = Cursors.IBeam
        _Text1_3.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _Text1_3.ForeColor = SystemColors.WindowText
        _Text1_3.Location = New Point(208, 336)
        _Text1_3.MaxLength = 0
        _Text1_3.Name = "_Text1_3"
        _Text1_3.RightToLeft = RightToLeft.No
        _Text1_3.Size = New Size(89, 22)
        _Text1_3.TabIndex = 6
        _Text1_3.Text = "Text1"
        _Text1_3.TextAlign = HorizontalAlignment.Center
        ' 
        ' _Text1_4
        ' 
        _Text1_4.AcceptsReturn = True
        _Text1_4.AllowDrop = True
        _Text1_4.BackColor = SystemColors.Window
        _Text1_4.Cursor = Cursors.IBeam
        _Text1_4.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _Text1_4.ForeColor = SystemColors.WindowText
        _Text1_4.Location = New Point(312, 336)
        _Text1_4.MaxLength = 0
        _Text1_4.Name = "_Text1_4"
        _Text1_4.RightToLeft = RightToLeft.No
        _Text1_4.Size = New Size(65, 22)
        _Text1_4.TabIndex = 7
        _Text1_4.Text = "Text1"
        _Text1_4.TextAlign = HorizontalAlignment.Center
        ' 
        ' _Text1_6
        ' 
        _Text1_6.AcceptsReturn = True
        _Text1_6.AllowDrop = True
        _Text1_6.BackColor = SystemColors.Window
        _Text1_6.Cursor = Cursors.IBeam
        _Text1_6.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _Text1_6.ForeColor = SystemColors.WindowText
        _Text1_6.Location = New Point(240, 224)
        _Text1_6.MaxLength = 0
        _Text1_6.Name = "_Text1_6"
        _Text1_6.RightToLeft = RightToLeft.No
        _Text1_6.Size = New Size(65, 20)
        _Text1_6.TabIndex = 17
        _Text1_6.Text = "Text1"
        ' 
        ' _Text1_5
        ' 
        _Text1_5.AcceptsReturn = True
        _Text1_5.AllowDrop = True
        _Text1_5.BackColor = SystemColors.Window
        _Text1_5.Cursor = Cursors.IBeam
        _Text1_5.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _Text1_5.ForeColor = SystemColors.WindowText
        _Text1_5.Location = New Point(240, 184)
        _Text1_5.MaxLength = 0
        _Text1_5.Name = "_Text1_5"
        _Text1_5.RightToLeft = RightToLeft.No
        _Text1_5.Size = New Size(65, 20)
        _Text1_5.TabIndex = 16
        _Text1_5.Text = "Text1"
        ' 
        ' Toolbar1
        ' 
        Toolbar1.AllowDrop = True
        Toolbar1.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Toolbar1.Items.AddRange(New ToolStripItem() {Toolbar1_Buttons_Button1, Toolbar1_Buttons_Button2, Toolbar1_Buttons_Button3, Toolbar1_Buttons_Button4, Toolbar1_Buttons_Button5, Toolbar1_Buttons_Button6, Toolbar1_Buttons_Button7, Toolbar1_Buttons_Button8})
        Toolbar1.Location = New Point(0, 0)
        Toolbar1.Name = "Toolbar1"
        Toolbar1.Size = New Size(435, 25)
        Toolbar1.TabIndex = 19
        ' 
        ' Toolbar1_Buttons_Button1
        ' 
        Toolbar1_Buttons_Button1.ImageScaling = ToolStripItemImageScaling.None
        Toolbar1_Buttons_Button1.Name = "Toolbar1_Buttons_Button1"
        Toolbar1_Buttons_Button1.Size = New Size(27, 22)
        Toolbar1_Buttons_Button1.Text = "List"
        Toolbar1_Buttons_Button1.TextImageRelation = TextImageRelation.ImageAboveText
        Toolbar1_Buttons_Button1.ToolTipText = "List segment, tributary, & channel network"
        ' 
        ' Toolbar1_Buttons_Button2
        ' 
        Toolbar1_Buttons_Button2.ImageScaling = ToolStripItemImageScaling.None
        Toolbar1_Buttons_Button2.Name = "Toolbar1_Buttons_Button2"
        Toolbar1_Buttons_Button2.Size = New Size(30, 22)
        Toolbar1_Buttons_Button2.Text = "Add"
        Toolbar1_Buttons_Button2.TextImageRelation = TextImageRelation.ImageAboveText
        Toolbar1_Buttons_Button2.ToolTipText = "Add a new channel"
        ' 
        ' Toolbar1_Buttons_Button3
        ' 
        Toolbar1_Buttons_Button3.ImageScaling = ToolStripItemImageScaling.None
        Toolbar1_Buttons_Button3.Name = "Toolbar1_Buttons_Button3"
        Toolbar1_Buttons_Button3.Size = New Size(42, 22)
        Toolbar1_Buttons_Button3.Text = "Delete"
        Toolbar1_Buttons_Button3.TextImageRelation = TextImageRelation.ImageAboveText
        Toolbar1_Buttons_Button3.ToolTipText = "Delete selected channel"
        ' 
        ' Toolbar1_Buttons_Button4
        ' 
        Toolbar1_Buttons_Button4.ImageScaling = ToolStripItemImageScaling.None
        Toolbar1_Buttons_Button4.Name = "Toolbar1_Buttons_Button4"
        Toolbar1_Buttons_Button4.Size = New Size(50, 22)
        Toolbar1_Buttons_Button4.Text = "Defaults"
        Toolbar1_Buttons_Button4.TextImageRelation = TextImageRelation.ImageAboveText
        Toolbar1_Buttons_Button4.ToolTipText = "Assign default values to all input values for selected channel"
        ' 
        ' Toolbar1_Buttons_Button5
        ' 
        Toolbar1_Buttons_Button5.ImageScaling = ToolStripItemImageScaling.None
        Toolbar1_Buttons_Button5.Name = "Toolbar1_Buttons_Button5"
        Toolbar1_Buttons_Button5.Size = New Size(37, 22)
        Toolbar1_Buttons_Button5.Text = "Undo"
        Toolbar1_Buttons_Button5.TextImageRelation = TextImageRelation.ImageAboveText
        Toolbar1_Buttons_Button5.ToolTipText = "Restore initial values for all channels"
        ' 
        ' Toolbar1_Buttons_Button6
        ' 
        Toolbar1_Buttons_Button6.ImageScaling = ToolStripItemImageScaling.None
        Toolbar1_Buttons_Button6.Name = "Toolbar1_Buttons_Button6"
        Toolbar1_Buttons_Button6.Size = New Size(33, 22)
        Toolbar1_Buttons_Button6.Text = "Help"
        Toolbar1_Buttons_Button6.TextImageRelation = TextImageRelation.ImageAboveText
        Toolbar1_Buttons_Button6.ToolTipText = "Get Help"
        ' 
        ' Toolbar1_Buttons_Button7
        ' 
        Toolbar1_Buttons_Button7.ImageScaling = ToolStripItemImageScaling.None
        Toolbar1_Buttons_Button7.Name = "Toolbar1_Buttons_Button7"
        Toolbar1_Buttons_Button7.Size = New Size(44, 22)
        Toolbar1_Buttons_Button7.Text = "Cancel"
        Toolbar1_Buttons_Button7.TextImageRelation = TextImageRelation.ImageAboveText
        Toolbar1_Buttons_Button7.ToolTipText = "Ignore all edits & return to program menu"
        ' 
        ' Toolbar1_Buttons_Button8
        ' 
        Toolbar1_Buttons_Button8.ImageScaling = ToolStripItemImageScaling.None
        Toolbar1_Buttons_Button8.Name = "Toolbar1_Buttons_Button8"
        Toolbar1_Buttons_Button8.Size = New Size(26, 22)
        Toolbar1_Buttons_Button8.Text = "OK"
        Toolbar1_Buttons_Button8.TextImageRelation = TextImageRelation.ImageAboveText
        Toolbar1_Buttons_Button8.ToolTipText = "Save edits & return to program menu"
        ' 
        ' Label2
        ' 
        Label2.AllowDrop = True
        Label2.BackColor = SystemColors.Control
        Label2.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ControlText
        Label2.Location = New Point(208, 64)
        Label2.MinimumSize = New Size(145, 17)
        Label2.Name = "Label2"
        Label2.RightToLeft = RightToLeft.No
        Label2.Size = New Size(145, 17)
        Label2.TabIndex = 18
        Label2.Text = "Label2"
        ' 
        ' _Label1_4
        ' 
        _Label1_4.AllowDrop = True
        _Label1_4.BackColor = SystemColors.Control
        _Label1_4.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _Label1_4.ForeColor = SystemColors.ControlText
        _Label1_4.Location = New Point(64, 232)
        _Label1_4.MinimumSize = New Size(121, 25)
        _Label1_4.Name = "_Label1_4"
        _Label1_4.RightToLeft = RightToLeft.No
        _Label1_4.Size = New Size(121, 25)
        _Label1_4.TabIndex = 15
        _Label1_4.Text = "To Segment:"
        _Label1_4.TextAlign = ContentAlignment.TopRight
        ' 
        ' _Label1_2
        ' 
        _Label1_2.AllowDrop = True
        _Label1_2.BackColor = SystemColors.Control
        _Label1_2.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _Label1_2.ForeColor = SystemColors.ControlText
        _Label1_2.Location = New Point(64, 184)
        _Label1_2.MinimumSize = New Size(121, 25)
        _Label1_2.Name = "_Label1_2"
        _Label1_2.RightToLeft = RightToLeft.No
        _Label1_2.Size = New Size(121, 25)
        _Label1_2.TabIndex = 14
        _Label1_2.Text = "From Segment:"
        _Label1_2.TextAlign = ContentAlignment.TopRight
        ' 
        ' _Label1_0
        ' 
        _Label1_0.AllowDrop = True
        _Label1_0.BackColor = SystemColors.Control
        _Label1_0.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _Label1_0.ForeColor = SystemColors.ControlText
        _Label1_0.Location = New Point(40, 296)
        _Label1_0.MinimumSize = New Size(145, 25)
        _Label1_0.Name = "_Label1_0"
        _Label1_0.RightToLeft = RightToLeft.No
        _Label1_0.Size = New Size(145, 25)
        _Label1_0.TabIndex = 13
        _Label1_0.Text = "Advective Flow (hm3/yr):"
        _Label1_0.TextAlign = ContentAlignment.TopRight
        ' 
        ' _Label1_1
        ' 
        _Label1_1.AllowDrop = True
        _Label1_1.BackColor = SystemColors.Control
        _Label1_1.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _Label1_1.ForeColor = SystemColors.ControlText
        _Label1_1.Location = New Point(40, 336)
        _Label1_1.MinimumSize = New Size(145, 25)
        _Label1_1.Name = "_Label1_1"
        _Label1_1.RightToLeft = RightToLeft.No
        _Label1_1.Size = New Size(145, 25)
        _Label1_1.TabIndex = 12
        _Label1_1.Text = "Exchange Flow (hm3/yr):"
        _Label1_1.TextAlign = ContentAlignment.TopRight
        ' 
        ' _Label1_6
        ' 
        _Label1_6.AllowDrop = True
        _Label1_6.BackColor = SystemColors.Control
        _Label1_6.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _Label1_6.ForeColor = SystemColors.ControlText
        _Label1_6.Location = New Point(64, 144)
        _Label1_6.MinimumSize = New Size(121, 25)
        _Label1_6.Name = "_Label1_6"
        _Label1_6.RightToLeft = RightToLeft.No
        _Label1_6.Size = New Size(121, 25)
        _Label1_6.TabIndex = 11
        _Label1_6.Text = "Channel Name:"
        _Label1_6.TextAlign = ContentAlignment.TopRight
        ' 
        ' _Label1_3
        ' 
        _Label1_3.AllowDrop = True
        _Label1_3.BackColor = SystemColors.Control
        _Label1_3.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        _Label1_3.ForeColor = SystemColors.ControlText
        _Label1_3.Location = New Point(216, 264)
        _Label1_3.MinimumSize = New Size(57, 25)
        _Label1_3.Name = "_Label1_3"
        _Label1_3.RightToLeft = RightToLeft.No
        _Label1_3.Size = New Size(57, 25)
        _Label1_3.TabIndex = 10
        _Label1_3.Text = "Mean"
        _Label1_3.TextAlign = ContentAlignment.TopCenter
        ' 
        ' _Label1_7
        ' 
        _Label1_7.AllowDrop = True
        _Label1_7.BackColor = SystemColors.Control
        _Label1_7.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        _Label1_7.ForeColor = SystemColors.ControlText
        _Label1_7.Location = New Point(312, 264)
        _Label1_7.MinimumSize = New Size(57, 25)
        _Label1_7.Name = "_Label1_7"
        _Label1_7.RightToLeft = RightToLeft.No
        _Label1_7.Size = New Size(57, 25)
        _Label1_7.TabIndex = 9
        _Label1_7.Text = "CV"
        _Label1_7.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lblDefinitions
        ' 
        lblDefinitions.AllowDrop = True
        lblDefinitions.BackColor = SystemColors.Control
        lblDefinitions.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDefinitions.ForeColor = SystemColors.Highlight
        lblDefinitions.Location = New Point(96, 104)
        lblDefinitions.MinimumSize = New Size(257, 17)
        lblDefinitions.Name = "lblDefinitions"
        lblDefinitions.RightToLeft = RightToLeft.No
        lblDefinitions.Size = New Size(257, 17)
        lblDefinitions.TabIndex = 8
        lblDefinitions.Text = "Label2"
        lblDefinitions.TextAlign = ContentAlignment.TopCenter
        ' 
        ' frmChannels
        ' 
        AllowDrop = True
        AutoScaleDimensions = New SizeF(6F, 13F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(435, 393)
        Controls.Add(Combo3)
        Controls.Add(Combo2)
        Controls.Add(Combo1)
        Controls.Add(_Text1_0)
        Controls.Add(_Text1_1)
        Controls.Add(_Text1_2)
        Controls.Add(_Text1_3)
        Controls.Add(_Text1_4)
        Controls.Add(_Text1_6)
        Controls.Add(_Text1_5)
        Controls.Add(Toolbar1)
        Controls.Add(Label2)
        Controls.Add(_Label1_4)
        Controls.Add(_Label1_2)
        Controls.Add(_Label1_0)
        Controls.Add(_Label1_1)
        Controls.Add(_Label1_6)
        Controls.Add(_Label1_3)
        Controls.Add(_Label1_7)
        Controls.Add(lblDefinitions)
        Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedDialog
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Location = New Point(3, 22)
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmChannels"
        RightToLeft = RightToLeft.No
        ShowInTaskbar = False
        Text = "Edit Transport Channels"
        Toolbar1.ResumeLayout(False)
        Toolbar1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Sub ReLoadForm(ByVal addEvents As Boolean)
		InitializeText1()
		InitializeLabel1()
		If addEvents Then
			AddHandler MyBase.MouseMove, AddressOf Form_MouseMove
			AddHandler MyBase.Closed, AddressOf Form_Closed
			AddHandler Activated, AddressOf frmChannels_Activated
		End If
	End Sub
	Sub InitializeText1()
		ReDim Text1(6)
		Text1(0) = _Text1_0
		Text1(1) = _Text1_1
		Text1(2) = _Text1_2
		Text1(3) = _Text1_3
		Text1(4) = _Text1_4
		Text1(6) = _Text1_6
		Text1(5) = _Text1_5
	End Sub
	Sub InitializeLabel1()
		ReDim Label1(7)
		Label1(4) = _Label1_4
		Label1(2) = _Label1_2
		Label1(0) = _Label1_0
		Label1(1) = _Label1_1
		Label1(6) = _Label1_6
		Label1(3) = _Label1_3
		Label1(7) = _Label1_7
	End Sub
#End Region
End Class