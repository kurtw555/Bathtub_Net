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
	<System.Diagnostics.DebuggerStepThrough()> _
	 Private Sub InitializeComponent()
		components = New System.ComponentModel.Container()
		Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(frmLandUse))
		ToolTipMain = New System.Windows.Forms.ToolTip(components)
		_Text1_12 = New System.Windows.Forms.TextBox()
		_Text1_11 = New System.Windows.Forms.TextBox()
		_Text1_10 = New System.Windows.Forms.TextBox()
		_Text1_9 = New System.Windows.Forms.TextBox()
		_Text1_8 = New System.Windows.Forms.TextBox()
		_Text1_7 = New System.Windows.Forms.TextBox()
		_Text1_6 = New System.Windows.Forms.TextBox()
		_Text1_5 = New System.Windows.Forms.TextBox()
		_Text1_4 = New System.Windows.Forms.TextBox()
		_Text1_3 = New System.Windows.Forms.TextBox()
		_Text1_2 = New System.Windows.Forms.TextBox()
		_Text1_1 = New System.Windows.Forms.TextBox()
		_Text1_0 = New System.Windows.Forms.TextBox()
		Combo1 = New System.Windows.Forms.ComboBox()
		Toolbar1 = New System.Windows.Forms.ToolStrip()
		Toolbar1_Buttons_Button1 = New System.Windows.Forms.ToolStripButton()
		Toolbar1_Buttons_Button2 = New System.Windows.Forms.ToolStripButton()
		Toolbar1_Buttons_Button3 = New System.Windows.Forms.ToolStripButton()
		Toolbar1_Buttons_Button4 = New System.Windows.Forms.ToolStripButton()
		Toolbar1_Buttons_Button5 = New System.Windows.Forms.ToolStripButton()
		lblDefinitions = New System.Windows.Forms.Label()
		_Label1_7 = New System.Windows.Forms.Label()
		_Label1_3 = New System.Windows.Forms.Label()
		_Label1_6 = New System.Windows.Forms.Label()
		_Label1_5 = New System.Windows.Forms.Label()
		_Label1_4 = New System.Windows.Forms.Label()
		_frmLandUses_3 = New System.Windows.Forms.Label()
		_Label1_2 = New System.Windows.Forms.Label()
		_Label1_1 = New System.Windows.Forms.Label()
		_Label1_0 = New System.Windows.Forms.Label()
		Toolbar1.SuspendLayout()
		SuspendLayout()
		' 
		'_Text1_12
		' 
		_Text1_12.AcceptsReturn = True
		_Text1_12.AllowDrop = True
		_Text1_12.BackColor = System.Drawing.SystemColors.Window
		_Text1_12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		_Text1_12.Cursor = System.Windows.Forms.Cursors.IBeam
		_Text1_12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Text1_12.ForeColor = System.Drawing.SystemColors.WindowText
		_Text1_12.Location = New System.Drawing.Point(320, 400)
		_Text1_12.MaxLength = 0
		_Text1_12.Name = "_Text1_12"
		_Text1_12.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Text1_12.Size = New System.Drawing.Size(65, 25)
		_Text1_12.TabIndex = 13
		_Text1_12.Text = "Text1"
		_Text1_12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		' 
		'_Text1_11
		' 
		_Text1_11.AcceptsReturn = True
		_Text1_11.AllowDrop = True
		_Text1_11.BackColor = System.Drawing.SystemColors.Window
		_Text1_11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		_Text1_11.Cursor = System.Windows.Forms.Cursors.IBeam
		_Text1_11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Text1_11.ForeColor = System.Drawing.SystemColors.WindowText
		_Text1_11.Location = New System.Drawing.Point(216, 400)
		_Text1_11.MaxLength = 0
		_Text1_11.Name = "_Text1_11"
		_Text1_11.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Text1_11.Size = New System.Drawing.Size(89, 25)
		_Text1_11.TabIndex = 12
		_Text1_11.Text = "Text1"
		_Text1_11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		' 
		'_Text1_10
		' 
		_Text1_10.AcceptsReturn = True
		_Text1_10.AllowDrop = True
		_Text1_10.BackColor = System.Drawing.SystemColors.Window
		_Text1_10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		_Text1_10.Cursor = System.Windows.Forms.Cursors.IBeam
		_Text1_10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Text1_10.ForeColor = System.Drawing.SystemColors.WindowText
		_Text1_10.Location = New System.Drawing.Point(320, 360)
		_Text1_10.MaxLength = 0
		_Text1_10.Name = "_Text1_10"
		_Text1_10.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Text1_10.Size = New System.Drawing.Size(65, 25)
		_Text1_10.TabIndex = 11
		_Text1_10.Text = "Text1"
		_Text1_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		' 
		'_Text1_9
		' 
		_Text1_9.AcceptsReturn = True
		_Text1_9.AllowDrop = True
		_Text1_9.BackColor = System.Drawing.SystemColors.Window
		_Text1_9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		_Text1_9.Cursor = System.Windows.Forms.Cursors.IBeam
		_Text1_9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Text1_9.ForeColor = System.Drawing.SystemColors.WindowText
		_Text1_9.Location = New System.Drawing.Point(216, 360)
		_Text1_9.MaxLength = 0
		_Text1_9.Name = "_Text1_9"
		_Text1_9.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Text1_9.Size = New System.Drawing.Size(89, 25)
		_Text1_9.TabIndex = 10
		_Text1_9.Text = "Text1"
		_Text1_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		' 
		'_Text1_8
		' 
		_Text1_8.AcceptsReturn = True
		_Text1_8.AllowDrop = True
		_Text1_8.BackColor = System.Drawing.SystemColors.Window
		_Text1_8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		_Text1_8.Cursor = System.Windows.Forms.Cursors.IBeam
		_Text1_8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Text1_8.ForeColor = System.Drawing.SystemColors.WindowText
		_Text1_8.Location = New System.Drawing.Point(320, 320)
		_Text1_8.MaxLength = 0
		_Text1_8.Name = "_Text1_8"
		_Text1_8.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Text1_8.Size = New System.Drawing.Size(65, 25)
		_Text1_8.TabIndex = 9
		_Text1_8.Text = "Text1"
		_Text1_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		' 
		'_Text1_7
		' 
		_Text1_7.AcceptsReturn = True
		_Text1_7.AllowDrop = True
		_Text1_7.BackColor = System.Drawing.SystemColors.Window
		_Text1_7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		_Text1_7.Cursor = System.Windows.Forms.Cursors.IBeam
		_Text1_7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Text1_7.ForeColor = System.Drawing.SystemColors.WindowText
		_Text1_7.Location = New System.Drawing.Point(216, 320)
		_Text1_7.MaxLength = 0
		_Text1_7.Name = "_Text1_7"
		_Text1_7.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Text1_7.Size = New System.Drawing.Size(89, 25)
		_Text1_7.TabIndex = 8
		_Text1_7.Text = "Text1"
		_Text1_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		' 
		'_Text1_6
		' 
		_Text1_6.AcceptsReturn = True
		_Text1_6.AllowDrop = True
		_Text1_6.BackColor = System.Drawing.SystemColors.Window
		_Text1_6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		_Text1_6.Cursor = System.Windows.Forms.Cursors.IBeam
		_Text1_6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Text1_6.ForeColor = System.Drawing.SystemColors.WindowText
		_Text1_6.Location = New System.Drawing.Point(320, 280)
		_Text1_6.MaxLength = 0
		_Text1_6.Name = "_Text1_6"
		_Text1_6.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Text1_6.Size = New System.Drawing.Size(65, 25)
		_Text1_6.TabIndex = 7
		_Text1_6.Text = "Text1"
		_Text1_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		' 
		'_Text1_5
		' 
		_Text1_5.AcceptsReturn = True
		_Text1_5.AllowDrop = True
		_Text1_5.BackColor = System.Drawing.SystemColors.Window
		_Text1_5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		_Text1_5.Cursor = System.Windows.Forms.Cursors.IBeam
		_Text1_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Text1_5.ForeColor = System.Drawing.SystemColors.WindowText
		_Text1_5.Location = New System.Drawing.Point(216, 280)
		_Text1_5.MaxLength = 0
		_Text1_5.Name = "_Text1_5"
		_Text1_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Text1_5.Size = New System.Drawing.Size(89, 25)
		_Text1_5.TabIndex = 6
		_Text1_5.Text = "Text1"
		_Text1_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
		_Text1_4.Location = New System.Drawing.Point(320, 240)
		_Text1_4.MaxLength = 0
		_Text1_4.Name = "_Text1_4"
		_Text1_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Text1_4.Size = New System.Drawing.Size(65, 25)
		_Text1_4.TabIndex = 5
		_Text1_4.Text = "Text1"
		_Text1_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
		_Text1_3.Location = New System.Drawing.Point(216, 240)
		_Text1_3.MaxLength = 0
		_Text1_3.Name = "_Text1_3"
		_Text1_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Text1_3.Size = New System.Drawing.Size(89, 25)
		_Text1_3.TabIndex = 4
		_Text1_3.Text = "Text1"
		_Text1_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
		_Text1_2.Location = New System.Drawing.Point(320, 200)
		_Text1_2.MaxLength = 0
		_Text1_2.Name = "_Text1_2"
		_Text1_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Text1_2.Size = New System.Drawing.Size(65, 25)
		_Text1_2.TabIndex = 3
		_Text1_2.Text = "Text1"
		_Text1_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
		_Text1_1.Location = New System.Drawing.Point(216, 200)
		_Text1_1.MaxLength = 0
		_Text1_1.Name = "_Text1_1"
		_Text1_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Text1_1.Size = New System.Drawing.Size(89, 25)
		_Text1_1.TabIndex = 2
		_Text1_1.Text = "Text1"
		_Text1_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
		_Text1_0.Location = New System.Drawing.Point(224, 136)
		_Text1_0.MaxLength = 0
		_Text1_0.Name = "_Text1_0"
		_Text1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Text1_0.Size = New System.Drawing.Size(145, 25)
		_Text1_0.TabIndex = 1
		_Text1_0.Text = "Text1"
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
		Combo1.Location = New System.Drawing.Point(16, 56)
		Combo1.Name = "Combo1"
		Combo1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Combo1.Size = New System.Drawing.Size(161, 24)
		Combo1.Sorted = False
		Combo1.TabIndex = 0
		Combo1.TabStop = True
		Combo1.Visible = True
		' 
		'Toolbar1
		' 
		Toolbar1.AllowDrop = True
		Toolbar1.Dock = System.Windows.Forms.DockStyle.Top
		Toolbar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		Toolbar1.Location = New System.Drawing.Point(0, 0)
		Toolbar1.Name = "Toolbar1"
		Toolbar1.ShowItemToolTips = True
		Toolbar1.Size = New System.Drawing.Size(409, 42)
		Toolbar1.TabIndex = 24
		Toolbar1.Items.Add(Toolbar1_Buttons_Button1)
		Toolbar1.Items.Add(Toolbar1_Buttons_Button2)
		Toolbar1.Items.Add(Toolbar1_Buttons_Button3)
		Toolbar1.Items.Add(Toolbar1_Buttons_Button4)
		Toolbar1.Items.Add(Toolbar1_Buttons_Button5)
		' 
		'Toolbar1_Buttons_Button1
		' 
		Toolbar1_Buttons_Button1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Toolbar1_Buttons_Button1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Toolbar1_Buttons_Button1.Name = "bthClear"
		Toolbar1_Buttons_Button1.Size = New System.Drawing.Size(40, 37)
		Toolbar1_Buttons_Button1.Text = "Clear"
		Toolbar1_Buttons_Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Toolbar1_Buttons_Button1.ToolTipText = "Clear values for current land use"
		' 
		'Toolbar1_Buttons_Button2
		' 
		Toolbar1_Buttons_Button2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Toolbar1_Buttons_Button2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Toolbar1_Buttons_Button2.Name = "btnUndo"
		Toolbar1_Buttons_Button2.Size = New System.Drawing.Size(40, 37)
		Toolbar1_Buttons_Button2.Text = "Undo"
		Toolbar1_Buttons_Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Toolbar1_Buttons_Button2.ToolTipText = "Restore initial values for all land uses"
		' 
		'Toolbar1_Buttons_Button3
		' 
		Toolbar1_Buttons_Button3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Toolbar1_Buttons_Button3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Toolbar1_Buttons_Button3.Name = "btnHelp"
		Toolbar1_Buttons_Button3.Size = New System.Drawing.Size(40, 37)
		Toolbar1_Buttons_Button3.Text = "Help"
		Toolbar1_Buttons_Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Toolbar1_Buttons_Button3.ToolTipText = "Get Help"
		' 
		'Toolbar1_Buttons_Button4
		' 
		Toolbar1_Buttons_Button4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Toolbar1_Buttons_Button4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Toolbar1_Buttons_Button4.Name = "btnCancel"
		Toolbar1_Buttons_Button4.Size = New System.Drawing.Size(40, 37)
		Toolbar1_Buttons_Button4.Text = "Cancel"
		Toolbar1_Buttons_Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Toolbar1_Buttons_Button4.ToolTipText = "Ignore edits & return to program menu"
		' 
		'Toolbar1_Buttons_Button5
		' 
		Toolbar1_Buttons_Button5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Toolbar1_Buttons_Button5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Toolbar1_Buttons_Button5.Name = "btnOK"
		Toolbar1_Buttons_Button5.Size = New System.Drawing.Size(40, 37)
		Toolbar1_Buttons_Button5.Text = "OK"
		Toolbar1_Buttons_Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Toolbar1_Buttons_Button5.ToolTipText = "Save edits & return to program menu"
		' 
		'lblDefinitions
		' 
		lblDefinitions.AllowDrop = True
		lblDefinitions.BackColor = System.Drawing.SystemColors.Control
		lblDefinitions.BorderStyle = System.Windows.Forms.BorderStyle.None
		lblDefinitions.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		lblDefinitions.ForeColor = System.Drawing.SystemColors.Highlight
		lblDefinitions.Location = New System.Drawing.Point(56, 96)
		lblDefinitions.MinimumSize = New System.Drawing.Size(321, 17)
		lblDefinitions.Name = "lblDefinitions"
		lblDefinitions.RightToLeft = System.Windows.Forms.RightToLeft.No
		lblDefinitions.Size = New System.Drawing.Size(321, 17)
		lblDefinitions.TabIndex = 23
		lblDefinitions.Text = "Label2"
		lblDefinitions.TextAlign = System.Drawing.ContentAlignment.TopCenter
		' 
		'_Label1_7
		' 
		_Label1_7.AllowDrop = True
		_Label1_7.BackColor = System.Drawing.SystemColors.Control
		_Label1_7.BorderStyle = System.Windows.Forms.BorderStyle.None
		_Label1_7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Label1_7.ForeColor = System.Drawing.SystemColors.ControlText
		_Label1_7.Location = New System.Drawing.Point(320, 168)
		_Label1_7.MinimumSize = New System.Drawing.Size(57, 25)
		_Label1_7.Name = "_Label1_7"
		_Label1_7.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Label1_7.Size = New System.Drawing.Size(57, 25)
		_Label1_7.TabIndex = 22
		_Label1_7.Text = "CV"
		_Label1_7.TextAlign = System.Drawing.ContentAlignment.TopCenter
		' 
		'_Label1_3
		' 
		_Label1_3.AllowDrop = True
		_Label1_3.BackColor = System.Drawing.SystemColors.Control
		_Label1_3.BorderStyle = System.Windows.Forms.BorderStyle.None
		_Label1_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Label1_3.ForeColor = System.Drawing.SystemColors.ControlText
		_Label1_3.Location = New System.Drawing.Point(224, 168)
		_Label1_3.MinimumSize = New System.Drawing.Size(57, 25)
		_Label1_3.Name = "_Label1_3"
		_Label1_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Label1_3.Size = New System.Drawing.Size(57, 25)
		_Label1_3.TabIndex = 21
		_Label1_3.Text = "Mean"
		_Label1_3.TextAlign = System.Drawing.ContentAlignment.TopCenter
		' 
		'_Label1_6
		' 
		_Label1_6.AllowDrop = True
		_Label1_6.BackColor = System.Drawing.SystemColors.Control
		_Label1_6.BorderStyle = System.Windows.Forms.BorderStyle.None
		_Label1_6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Label1_6.ForeColor = System.Drawing.SystemColors.ControlText
		_Label1_6.Location = New System.Drawing.Point(16, 136)
		_Label1_6.MinimumSize = New System.Drawing.Size(177, 25)
		_Label1_6.Name = "_Label1_6"
		_Label1_6.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Label1_6.Size = New System.Drawing.Size(177, 25)
		_Label1_6.TabIndex = 20
		_Label1_6.Text = "Landuse Category Name:"
		_Label1_6.TextAlign = System.Drawing.ContentAlignment.TopRight
		' 
		'_Label1_5
		' 
		_Label1_5.AllowDrop = True
		_Label1_5.BackColor = System.Drawing.SystemColors.Control
		_Label1_5.BorderStyle = System.Windows.Forms.BorderStyle.None
		_Label1_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Label1_5.ForeColor = System.Drawing.SystemColors.ControlText
		_Label1_5.Location = New System.Drawing.Point(0, 400)
		_Label1_5.MinimumSize = New System.Drawing.Size(193, 25)
		_Label1_5.Name = "_Label1_5"
		_Label1_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Label1_5.Size = New System.Drawing.Size(193, 25)
		_Label1_5.TabIndex = 19
		_Label1_5.Text = "Conservative Subst. Conc (-):"
		_Label1_5.TextAlign = System.Drawing.ContentAlignment.TopRight
		' 
		'_Label1_4
		' 
		_Label1_4.AllowDrop = True
		_Label1_4.BackColor = System.Drawing.SystemColors.Control
		_Label1_4.BorderStyle = System.Windows.Forms.BorderStyle.None
		_Label1_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Label1_4.ForeColor = System.Drawing.SystemColors.ControlText
		_Label1_4.Location = New System.Drawing.Point(24, 360)
		_Label1_4.MinimumSize = New System.Drawing.Size(169, 25)
		_Label1_4.Name = "_Label1_4"
		_Label1_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Label1_4.Size = New System.Drawing.Size(169, 25)
		_Label1_4.TabIndex = 18
		_Label1_4.Text = "Inorganic N Conc (mg/m3):"
		_Label1_4.TextAlign = System.Drawing.ContentAlignment.TopRight
		' 
		'_frmLandUses_3
		' 
		_frmLandUses_3.AllowDrop = True
		_frmLandUses_3.BackColor = System.Drawing.SystemColors.Control
		_frmLandUses_3.BorderStyle = System.Windows.Forms.BorderStyle.None
		_frmLandUses_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_frmLandUses_3.ForeColor = System.Drawing.SystemColors.ControlText
		_frmLandUses_3.Location = New System.Drawing.Point(48, 320)
		_frmLandUses_3.MinimumSize = New System.Drawing.Size(145, 25)
		_frmLandUses_3.Name = "_frmLandUses_3"
		_frmLandUses_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		_frmLandUses_3.Size = New System.Drawing.Size(145, 25)
		_frmLandUses_3.TabIndex = 17
		_frmLandUses_3.Text = "Total N Conc (mg/m3):"
		_frmLandUses_3.TextAlign = System.Drawing.ContentAlignment.TopRight
		' 
		'_Label1_2
		' 
		_Label1_2.AllowDrop = True
		_Label1_2.BackColor = System.Drawing.SystemColors.Control
		_Label1_2.BorderStyle = System.Windows.Forms.BorderStyle.None
		_Label1_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Label1_2.ForeColor = System.Drawing.SystemColors.ControlText
		_Label1_2.Location = New System.Drawing.Point(48, 280)
		_Label1_2.MinimumSize = New System.Drawing.Size(145, 25)
		_Label1_2.Name = "_Label1_2"
		_Label1_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Label1_2.Size = New System.Drawing.Size(145, 25)
		_Label1_2.TabIndex = 16
		_Label1_2.Text = "Ortho P Conc (mg/m3):"
		_Label1_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		' 
		'_Label1_1
		' 
		_Label1_1.AllowDrop = True
		_Label1_1.BackColor = System.Drawing.SystemColors.Control
		_Label1_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		_Label1_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Label1_1.ForeColor = System.Drawing.SystemColors.ControlText
		_Label1_1.Location = New System.Drawing.Point(48, 240)
		_Label1_1.MinimumSize = New System.Drawing.Size(145, 25)
		_Label1_1.Name = "_Label1_1"
		_Label1_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Label1_1.Size = New System.Drawing.Size(145, 25)
		_Label1_1.TabIndex = 15
		_Label1_1.Text = "Total P Conc (mg/m3):"
		_Label1_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		' 
		'_Label1_0
		' 
		_Label1_0.AllowDrop = True
		_Label1_0.BackColor = System.Drawing.SystemColors.Control
		_Label1_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		_Label1_0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Label1_0.ForeColor = System.Drawing.SystemColors.ControlText
		_Label1_0.Location = New System.Drawing.Point(48, 200)
		_Label1_0.MinimumSize = New System.Drawing.Size(145, 25)
		_Label1_0.Name = "_Label1_0"
		_Label1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Label1_0.Size = New System.Drawing.Size(145, 25)
		_Label1_0.TabIndex = 14
		_Label1_0.Text = "Runoff (m/yr):"
		_Label1_0.TextAlign = System.Drawing.ContentAlignment.TopRight
		' 
		'frmLandUse
		' 
		AllowDrop = True
		AutoScaleDimensions = New System.Drawing.SizeF(6, 13)
		AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		BackColor = System.Drawing.SystemColors.Control
		ClientSize = New System.Drawing.Size(409, 444)
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
		Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Location = New System.Drawing.Point(3, 22)
		MaximizeBox = False
		MinimizeBox = False
		Name = "frmLandUse"
		RightToLeft = System.Windows.Forms.RightToLeft.No
		ShowInTaskbar = False
		Text = "Edit NonPoint Source Export Coefficients"
		ToolTipMain.SetToolTip(Combo1, "Select Land Use to be Edited")
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