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
		components = New System.ComponentModel.Container()
		Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(frmChannels))
		ToolTipMain = New System.Windows.Forms.ToolTip(components)
		Combo3 = New System.Windows.Forms.ComboBox()
		Combo2 = New System.Windows.Forms.ComboBox()
		Combo1 = New System.Windows.Forms.ComboBox()
		_Text1_0 = New System.Windows.Forms.TextBox()
		_Text1_1 = New System.Windows.Forms.TextBox()
		_Text1_2 = New System.Windows.Forms.TextBox()
		_Text1_3 = New System.Windows.Forms.TextBox()
		_Text1_4 = New System.Windows.Forms.TextBox()
		_Text1_6 = New System.Windows.Forms.TextBox()
		_Text1_5 = New System.Windows.Forms.TextBox()
		Toolbar1 = New System.Windows.Forms.ToolStrip()
		Toolbar1_Buttons_Button1 = New System.Windows.Forms.ToolStripButton()
		Toolbar1_Buttons_Button2 = New System.Windows.Forms.ToolStripButton()
		Toolbar1_Buttons_Button3 = New System.Windows.Forms.ToolStripButton()
		Toolbar1_Buttons_Button4 = New System.Windows.Forms.ToolStripButton()
		Toolbar1_Buttons_Button5 = New System.Windows.Forms.ToolStripButton()
		Toolbar1_Buttons_Button6 = New System.Windows.Forms.ToolStripButton()
		Toolbar1_Buttons_Button7 = New System.Windows.Forms.ToolStripButton()
		Toolbar1_Buttons_Button8 = New System.Windows.Forms.ToolStripButton()
		Label2 = New System.Windows.Forms.Label()
		_Label1_4 = New System.Windows.Forms.Label()
		_Label1_2 = New System.Windows.Forms.Label()
		_Label1_0 = New System.Windows.Forms.Label()
		_Label1_1 = New System.Windows.Forms.Label()
		_Label1_6 = New System.Windows.Forms.Label()
		_Label1_3 = New System.Windows.Forms.Label()
		_Label1_7 = New System.Windows.Forms.Label()
		lblDefinitions = New System.Windows.Forms.Label()
		Toolbar1.SuspendLayout()
		SuspendLayout()
		' 
		'Combo3
		' 
		Combo3.AllowDrop = True
		Combo3.BackColor = System.Drawing.SystemColors.Window
		Combo3.CausesValidation = True
		Combo3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Combo3.Enabled = True
		Combo3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		Combo3.ForeColor = System.Drawing.SystemColors.WindowText
		Combo3.IntegralHeight = True
		Combo3.Location = New System.Drawing.Point(200, 184)
		Combo3.Name = "Combo3"
		Combo3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Combo3.Size = New System.Drawing.Size(161, 24)
		Combo3.Sorted = False
		Combo3.TabIndex = 2
		Combo3.TabStop = True
		Combo3.Visible = True
		' 
		'Combo2
		' 
		Combo2.AllowDrop = True
		Combo2.BackColor = System.Drawing.SystemColors.Window
		Combo2.CausesValidation = True
		Combo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Combo2.Enabled = True
		Combo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		Combo2.ForeColor = System.Drawing.SystemColors.WindowText
		Combo2.IntegralHeight = True
		Combo2.Location = New System.Drawing.Point(200, 224)
		Combo2.Name = "Combo2"
		Combo2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Combo2.Size = New System.Drawing.Size(161, 24)
		Combo2.Sorted = False
		Combo2.TabIndex = 3
		Combo2.TabStop = True
		Combo2.Visible = True
		' 
		'Combo1
		' 
		Combo1.AllowDrop = True
		Combo1.BackColor = System.Drawing.SystemColors.Window
		Combo1.CausesValidation = True
		Combo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Combo1.Enabled = True
		Combo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		Combo1.ForeColor = System.Drawing.SystemColors.WindowText
		Combo1.IntegralHeight = True
		Combo1.Location = New System.Drawing.Point(0, 64)
		Combo1.Name = "Combo1"
		Combo1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Combo1.Size = New System.Drawing.Size(161, 24)
		Combo1.Sorted = False
		Combo1.TabIndex = 0
		Combo1.TabStop = True
		Combo1.Visible = True
		' 
		'_Text1_0
		' 
		_Text1_0.AcceptsReturn = True
		_Text1_0.AllowDrop = True
		_Text1_0.BackColor = System.Drawing.SystemColors.Window
		_Text1_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		_Text1_0.Cursor = System.Windows.Forms.Cursors.IBeam
		_Text1_0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Text1_0.ForeColor = System.Drawing.SystemColors.WindowText
		_Text1_0.Location = New System.Drawing.Point(200, 144)
		_Text1_0.MaxLength = 0
		_Text1_0.Name = "_Text1_0"
		_Text1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Text1_0.Size = New System.Drawing.Size(161, 25)
		_Text1_0.TabIndex = 1
		_Text1_0.Text = "Text1"
		' 
		'_Text1_1
		' 
		_Text1_1.AcceptsReturn = True
		_Text1_1.AllowDrop = True
		_Text1_1.BackColor = System.Drawing.SystemColors.Window
		_Text1_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		_Text1_1.Cursor = System.Windows.Forms.Cursors.IBeam
		_Text1_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Text1_1.ForeColor = System.Drawing.SystemColors.WindowText
		_Text1_1.Location = New System.Drawing.Point(208, 296)
		_Text1_1.MaxLength = 0
		_Text1_1.Name = "_Text1_1"
		_Text1_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Text1_1.Size = New System.Drawing.Size(89, 25)
		_Text1_1.TabIndex = 4
		_Text1_1.Text = "Text1"
		_Text1_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		' 
		'_Text1_2
		' 
		_Text1_2.AcceptsReturn = True
		_Text1_2.AllowDrop = True
		_Text1_2.BackColor = System.Drawing.SystemColors.Window
		_Text1_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		_Text1_2.Cursor = System.Windows.Forms.Cursors.IBeam
		_Text1_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Text1_2.ForeColor = System.Drawing.SystemColors.WindowText
		_Text1_2.Location = New System.Drawing.Point(312, 296)
		_Text1_2.MaxLength = 0
		_Text1_2.Name = "_Text1_2"
		_Text1_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Text1_2.Size = New System.Drawing.Size(65, 25)
		_Text1_2.TabIndex = 5
		_Text1_2.Text = "Text1"
		_Text1_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		' 
		'_Text1_3
		' 
		_Text1_3.AcceptsReturn = True
		_Text1_3.AllowDrop = True
		_Text1_3.BackColor = System.Drawing.SystemColors.Window
		_Text1_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		_Text1_3.Cursor = System.Windows.Forms.Cursors.IBeam
		_Text1_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Text1_3.ForeColor = System.Drawing.SystemColors.WindowText
		_Text1_3.Location = New System.Drawing.Point(208, 336)
		_Text1_3.MaxLength = 0
		_Text1_3.Name = "_Text1_3"
		_Text1_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Text1_3.Size = New System.Drawing.Size(89, 25)
		_Text1_3.TabIndex = 6
		_Text1_3.Text = "Text1"
		_Text1_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		' 
		'_Text1_4
		' 
		_Text1_4.AcceptsReturn = True
		_Text1_4.AllowDrop = True
		_Text1_4.BackColor = System.Drawing.SystemColors.Window
		_Text1_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		_Text1_4.Cursor = System.Windows.Forms.Cursors.IBeam
		_Text1_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Text1_4.ForeColor = System.Drawing.SystemColors.WindowText
		_Text1_4.Location = New System.Drawing.Point(312, 336)
		_Text1_4.MaxLength = 0
		_Text1_4.Name = "_Text1_4"
		_Text1_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Text1_4.Size = New System.Drawing.Size(65, 25)
		_Text1_4.TabIndex = 7
		_Text1_4.Text = "Text1"
		_Text1_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		' 
		'_Text1_6
		' 
		_Text1_6.AcceptsReturn = True
		_Text1_6.AllowDrop = True
		_Text1_6.BackColor = System.Drawing.SystemColors.Window
		_Text1_6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		_Text1_6.Cursor = System.Windows.Forms.Cursors.IBeam
		_Text1_6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Text1_6.ForeColor = System.Drawing.SystemColors.WindowText
		_Text1_6.Location = New System.Drawing.Point(240, 224)
		_Text1_6.MaxLength = 0
		_Text1_6.Name = "_Text1_6"
		_Text1_6.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Text1_6.Size = New System.Drawing.Size(65, 23)
		_Text1_6.TabIndex = 17
		_Text1_6.Text = "Text1"
		' 
		'_Text1_5
		' 
		_Text1_5.AcceptsReturn = True
		_Text1_5.AllowDrop = True
		_Text1_5.BackColor = System.Drawing.SystemColors.Window
		_Text1_5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		_Text1_5.Cursor = System.Windows.Forms.Cursors.IBeam
		_Text1_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Text1_5.ForeColor = System.Drawing.SystemColors.WindowText
		_Text1_5.Location = New System.Drawing.Point(240, 184)
		_Text1_5.MaxLength = 0
		_Text1_5.Name = "_Text1_5"
		_Text1_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Text1_5.Size = New System.Drawing.Size(65, 19)
		_Text1_5.TabIndex = 16
		_Text1_5.Text = "Text1"
		' 
		'Toolbar1
		' 
		Toolbar1.AllowDrop = True
		Toolbar1.Dock = System.Windows.Forms.DockStyle.Top
		Toolbar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		Toolbar1.Location = New System.Drawing.Point(0, 0)
		Toolbar1.Name = "Toolbar1"
		Toolbar1.ShowItemToolTips = True
		Toolbar1.Size = New System.Drawing.Size(435, 42)
		Toolbar1.TabIndex = 19
		Toolbar1.Items.Add(Toolbar1_Buttons_Button1)
		Toolbar1.Items.Add(Toolbar1_Buttons_Button2)
		Toolbar1.Items.Add(Toolbar1_Buttons_Button3)
		Toolbar1.Items.Add(Toolbar1_Buttons_Button4)
		Toolbar1.Items.Add(Toolbar1_Buttons_Button5)
		Toolbar1.Items.Add(Toolbar1_Buttons_Button6)
		Toolbar1.Items.Add(Toolbar1_Buttons_Button7)
		Toolbar1.Items.Add(Toolbar1_Buttons_Button8)
		' 
		'Toolbar1_Buttons_Button1
		' 
		Toolbar1_Buttons_Button1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Toolbar1_Buttons_Button1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Toolbar1_Buttons_Button1.Name = "btnList"
		Toolbar1_Buttons_Button1.Size = New System.Drawing.Size(48, 37)
		Toolbar1_Buttons_Button1.Text = "List"
		Toolbar1_Buttons_Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Toolbar1_Buttons_Button1.ToolTipText = "List segment, tributary, & channel network"
		' 
		'Toolbar1_Buttons_Button2
		' 
		Toolbar1_Buttons_Button2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Toolbar1_Buttons_Button2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Toolbar1_Buttons_Button2.Name = "btnAdd"
		Toolbar1_Buttons_Button2.Size = New System.Drawing.Size(48, 37)
		Toolbar1_Buttons_Button2.Text = "Add"
		Toolbar1_Buttons_Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Toolbar1_Buttons_Button2.ToolTipText = "Add a new channel"
		' 
		'Toolbar1_Buttons_Button3
		' 
		Toolbar1_Buttons_Button3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Toolbar1_Buttons_Button3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Toolbar1_Buttons_Button3.Name = "btnDelete"
		Toolbar1_Buttons_Button3.Size = New System.Drawing.Size(48, 37)
		Toolbar1_Buttons_Button3.Text = "Delete"
		Toolbar1_Buttons_Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Toolbar1_Buttons_Button3.ToolTipText = "Delete selected channel"
		' 
		'Toolbar1_Buttons_Button4
		' 
		Toolbar1_Buttons_Button4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Toolbar1_Buttons_Button4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Toolbar1_Buttons_Button4.Name = "bthDefaults"
		Toolbar1_Buttons_Button4.Size = New System.Drawing.Size(48, 37)
		Toolbar1_Buttons_Button4.Text = "Defaults"
		Toolbar1_Buttons_Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Toolbar1_Buttons_Button4.ToolTipText = "Assign default values to all input values for selected channel"
		' 
		'Toolbar1_Buttons_Button5
		' 
		Toolbar1_Buttons_Button5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Toolbar1_Buttons_Button5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Toolbar1_Buttons_Button5.Name = "btnUndo"
		Toolbar1_Buttons_Button5.Size = New System.Drawing.Size(48, 37)
		Toolbar1_Buttons_Button5.Text = "Undo"
		Toolbar1_Buttons_Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Toolbar1_Buttons_Button5.ToolTipText = "Restore initial values for all channels"
		' 
		'Toolbar1_Buttons_Button6
		' 
		Toolbar1_Buttons_Button6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Toolbar1_Buttons_Button6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Toolbar1_Buttons_Button6.Name = "btnHelp"
		Toolbar1_Buttons_Button6.Size = New System.Drawing.Size(48, 37)
		Toolbar1_Buttons_Button6.Text = "Help"
		Toolbar1_Buttons_Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Toolbar1_Buttons_Button6.ToolTipText = "Get Help"
		' 
		'Toolbar1_Buttons_Button7
		' 
		Toolbar1_Buttons_Button7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Toolbar1_Buttons_Button7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Toolbar1_Buttons_Button7.Name = "btnCancel"
		Toolbar1_Buttons_Button7.Size = New System.Drawing.Size(48, 37)
		Toolbar1_Buttons_Button7.Text = "Cancel"
		Toolbar1_Buttons_Button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Toolbar1_Buttons_Button7.ToolTipText = "Ignore all edits & return to program menu"
		' 
		'Toolbar1_Buttons_Button8
		' 
		Toolbar1_Buttons_Button8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Toolbar1_Buttons_Button8.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Toolbar1_Buttons_Button8.Name = "btnOK"
		Toolbar1_Buttons_Button8.Size = New System.Drawing.Size(48, 37)
		Toolbar1_Buttons_Button8.Text = "OK"
		Toolbar1_Buttons_Button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Toolbar1_Buttons_Button8.ToolTipText = "Save edits & return to program menu"
		' 
		'Label2
		' 
		Label2.AllowDrop = True
		Label2.BackColor = System.Drawing.SystemColors.Control
		Label2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		Label2.ForeColor = System.Drawing.SystemColors.ControlText
		Label2.Location = New System.Drawing.Point(208, 64)
		Label2.MinimumSize = New System.Drawing.Size(145, 17)
		Label2.Name = "Label2"
		Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Label2.Size = New System.Drawing.Size(145, 17)
		Label2.TabIndex = 18
		Label2.Text = "Label2"
		' 
		'_Label1_4
		' 
		_Label1_4.AllowDrop = True
		_Label1_4.BackColor = System.Drawing.SystemColors.Control
		_Label1_4.BorderStyle = System.Windows.Forms.BorderStyle.None
		_Label1_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Label1_4.ForeColor = System.Drawing.SystemColors.ControlText
		_Label1_4.Location = New System.Drawing.Point(64, 232)
		_Label1_4.MinimumSize = New System.Drawing.Size(121, 25)
		_Label1_4.Name = "_Label1_4"
		_Label1_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Label1_4.Size = New System.Drawing.Size(121, 25)
		_Label1_4.TabIndex = 15
		_Label1_4.Text = "To Segment:"
		_Label1_4.TextAlign = System.Drawing.ContentAlignment.TopRight
		' 
		'_Label1_2
		' 
		_Label1_2.AllowDrop = True
		_Label1_2.BackColor = System.Drawing.SystemColors.Control
		_Label1_2.BorderStyle = System.Windows.Forms.BorderStyle.None
		_Label1_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Label1_2.ForeColor = System.Drawing.SystemColors.ControlText
		_Label1_2.Location = New System.Drawing.Point(64, 184)
		_Label1_2.MinimumSize = New System.Drawing.Size(121, 25)
		_Label1_2.Name = "_Label1_2"
		_Label1_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Label1_2.Size = New System.Drawing.Size(121, 25)
		_Label1_2.TabIndex = 14
		_Label1_2.Text = "From Segment:"
		_Label1_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		' 
		'_Label1_0
		' 
		_Label1_0.AllowDrop = True
		_Label1_0.BackColor = System.Drawing.SystemColors.Control
		_Label1_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		_Label1_0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Label1_0.ForeColor = System.Drawing.SystemColors.ControlText
		_Label1_0.Location = New System.Drawing.Point(40, 296)
		_Label1_0.MinimumSize = New System.Drawing.Size(145, 25)
		_Label1_0.Name = "_Label1_0"
		_Label1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Label1_0.Size = New System.Drawing.Size(145, 25)
		_Label1_0.TabIndex = 13
		_Label1_0.Text = "Advective Flow (hm3/yr):"
		_Label1_0.TextAlign = System.Drawing.ContentAlignment.TopRight
		' 
		'_Label1_1
		' 
		_Label1_1.AllowDrop = True
		_Label1_1.BackColor = System.Drawing.SystemColors.Control
		_Label1_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		_Label1_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Label1_1.ForeColor = System.Drawing.SystemColors.ControlText
		_Label1_1.Location = New System.Drawing.Point(40, 336)
		_Label1_1.MinimumSize = New System.Drawing.Size(145, 25)
		_Label1_1.Name = "_Label1_1"
		_Label1_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Label1_1.Size = New System.Drawing.Size(145, 25)
		_Label1_1.TabIndex = 12
		_Label1_1.Text = "Exchange Flow (hm3/yr):"
		_Label1_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		' 
		'_Label1_6
		' 
		_Label1_6.AllowDrop = True
		_Label1_6.BackColor = System.Drawing.SystemColors.Control
		_Label1_6.BorderStyle = System.Windows.Forms.BorderStyle.None
		_Label1_6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Label1_6.ForeColor = System.Drawing.SystemColors.ControlText
		_Label1_6.Location = New System.Drawing.Point(64, 144)
		_Label1_6.MinimumSize = New System.Drawing.Size(121, 25)
		_Label1_6.Name = "_Label1_6"
		_Label1_6.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Label1_6.Size = New System.Drawing.Size(121, 25)
		_Label1_6.TabIndex = 11
		_Label1_6.Text = "Channel Name:"
		_Label1_6.TextAlign = System.Drawing.ContentAlignment.TopRight
		' 
		'_Label1_3
		' 
		_Label1_3.AllowDrop = True
		_Label1_3.BackColor = System.Drawing.SystemColors.Control
		_Label1_3.BorderStyle = System.Windows.Forms.BorderStyle.None
		_Label1_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Label1_3.ForeColor = System.Drawing.SystemColors.ControlText
		_Label1_3.Location = New System.Drawing.Point(216, 264)
		_Label1_3.MinimumSize = New System.Drawing.Size(57, 25)
		_Label1_3.Name = "_Label1_3"
		_Label1_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Label1_3.Size = New System.Drawing.Size(57, 25)
		_Label1_3.TabIndex = 10
		_Label1_3.Text = "Mean"
		_Label1_3.TextAlign = System.Drawing.ContentAlignment.TopCenter
		' 
		'_Label1_7
		' 
		_Label1_7.AllowDrop = True
		_Label1_7.BackColor = System.Drawing.SystemColors.Control
		_Label1_7.BorderStyle = System.Windows.Forms.BorderStyle.None
		_Label1_7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Label1_7.ForeColor = System.Drawing.SystemColors.ControlText
		_Label1_7.Location = New System.Drawing.Point(312, 264)
		_Label1_7.MinimumSize = New System.Drawing.Size(57, 25)
		_Label1_7.Name = "_Label1_7"
		_Label1_7.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Label1_7.Size = New System.Drawing.Size(57, 25)
		_Label1_7.TabIndex = 9
		_Label1_7.Text = "CV"
		_Label1_7.TextAlign = System.Drawing.ContentAlignment.TopCenter
		' 
		'lblDefinitions
		' 
		lblDefinitions.AllowDrop = True
		lblDefinitions.BackColor = System.Drawing.SystemColors.Control
		lblDefinitions.BorderStyle = System.Windows.Forms.BorderStyle.None
		lblDefinitions.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		lblDefinitions.ForeColor = System.Drawing.SystemColors.Highlight
		lblDefinitions.Location = New System.Drawing.Point(96, 104)
		lblDefinitions.MinimumSize = New System.Drawing.Size(257, 17)
		lblDefinitions.Name = "lblDefinitions"
		lblDefinitions.RightToLeft = System.Windows.Forms.RightToLeft.No
		lblDefinitions.Size = New System.Drawing.Size(257, 17)
		lblDefinitions.TabIndex = 8
		lblDefinitions.Text = "Label2"
		lblDefinitions.TextAlign = System.Drawing.ContentAlignment.TopCenter
		' 
		'frmChannels
		' 
		AllowDrop = True
		AutoScaleDimensions = New System.Drawing.SizeF(6, 13)
		AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		BackColor = System.Drawing.SystemColors.Control
		ClientSize = New System.Drawing.Size(435, 393)
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
		Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Icon = CType(resources.GetObject("frmChannels.Icon"), System.Drawing.Icon)
		Location = New System.Drawing.Point(3, 22)
		MaximizeBox = False
		MinimizeBox = False
		Name = "frmChannels"
		RightToLeft = System.Windows.Forms.RightToLeft.No
		ShowInTaskbar = False
		Text = "Edit Transport Channels"
		ToolTipMain.SetToolTip(Combo3, "Select Upstream Segment ")
		ToolTipMain.SetToolTip(Combo2, "Select Downstream Segment")
		ToolTipMain.SetToolTip(Combo1, "Select Channel to be Edited")
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