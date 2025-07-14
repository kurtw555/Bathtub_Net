<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResponse
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As frmResponse
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As frmResponse
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = CreateInstance()
				m_InitializingDefInstance = False
			End If
			Return m_vb6FormDefInstance
		End Get
		Set(ByVal Value As frmResponse)
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region
#Region "Windows Form Designer generated code "
	Public Shared Function CreateInstance() As frmResponse
		Dim theInstance As New frmResponse()
		theInstance.Form_Load()
		Return theInstance
	End Function
	Private visualControls() As String = New String() {"components", "ToolTipMain", "cmbOption", "_txtScale_1", "_txtScale_0", "cmbVariable", "cmbSegment", "cmbTrib", "Toolbar1_Buttons_Button1", "Toolbar1_Buttons_Button2", "Toolbar1_Buttons_Button3", "Toolbar1_Buttons_Button4", "Toolbar1_Buttons_Button5", "Toolbar1_Buttons_Button6", "_Label1_4", "Toolbar1", "_Label1_7", "Image1", "_Label1_6", "_Label1_5", "lblStatus", "_Label1_3", "_Label1_2", "_Label1_1", "_Label1_0", "Label1", "txtScale"}
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTipMain As System.Windows.Forms.ToolTip
	Public WithEvents cmbOption As System.Windows.Forms.ComboBox
	Private WithEvents _txtScale_1 As System.Windows.Forms.TextBox
	Private WithEvents _txtScale_0 As System.Windows.Forms.TextBox
	Public WithEvents cmbVariable As System.Windows.Forms.ComboBox
	Public WithEvents cmbSegment As System.Windows.Forms.ComboBox
	Public WithEvents cmbTrib As System.Windows.Forms.ComboBox
	Public WithEvents Toolbar1_Buttons_Button1 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Buttons_Button2 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Buttons_Button3 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Buttons_Button4 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Buttons_Button5 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Buttons_Button6 As System.Windows.Forms.ToolStripButton
	Private WithEvents _Label1_4 As System.Windows.Forms.Label
	Public WithEvents Toolbar1 As System.Windows.Forms.ToolStrip
	Private WithEvents _Label1_7 As System.Windows.Forms.Label
	Public WithEvents Image1 As System.Windows.Forms.PictureBox
	Private WithEvents _Label1_6 As System.Windows.Forms.Label
	Private WithEvents _Label1_5 As System.Windows.Forms.Label
	Public WithEvents lblStatus As System.Windows.Forms.Label
	Private WithEvents _Label1_3 As System.Windows.Forms.Label
	Private WithEvents _Label1_2 As System.Windows.Forms.Label
	Private WithEvents _Label1_1 As System.Windows.Forms.Label
	Private WithEvents _Label1_0 As System.Windows.Forms.Label
	Public Label1(7) As System.Windows.Forms.Label
	Public txtScale(1) As System.Windows.Forms.TextBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	 Private Sub InitializeComponent()
		components = New System.ComponentModel.Container()
		Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(frmResponse))
		ToolTipMain = New System.Windows.Forms.ToolTip(components)
		cmbOption = New System.Windows.Forms.ComboBox()
		_txtScale_1 = New System.Windows.Forms.TextBox()
		_txtScale_0 = New System.Windows.Forms.TextBox()
		cmbVariable = New System.Windows.Forms.ComboBox()
		cmbSegment = New System.Windows.Forms.ComboBox()
		cmbTrib = New System.Windows.Forms.ComboBox()
		Toolbar1 = New System.Windows.Forms.ToolStrip()
		Toolbar1_Buttons_Button1 = New System.Windows.Forms.ToolStripButton()
		Toolbar1_Buttons_Button2 = New System.Windows.Forms.ToolStripButton()
		Toolbar1_Buttons_Button3 = New System.Windows.Forms.ToolStripButton()
		Toolbar1_Buttons_Button4 = New System.Windows.Forms.ToolStripButton()
		Toolbar1_Buttons_Button5 = New System.Windows.Forms.ToolStripButton()
		Toolbar1_Buttons_Button6 = New System.Windows.Forms.ToolStripButton()
		_Label1_4 = New System.Windows.Forms.Label()
		_Label1_7 = New System.Windows.Forms.Label()
		Image1 = New System.Windows.Forms.PictureBox()
		_Label1_6 = New System.Windows.Forms.Label()
		_Label1_5 = New System.Windows.Forms.Label()
		lblStatus = New System.Windows.Forms.Label()
		_Label1_3 = New System.Windows.Forms.Label()
		_Label1_2 = New System.Windows.Forms.Label()
		_Label1_1 = New System.Windows.Forms.Label()
		_Label1_0 = New System.Windows.Forms.Label()
		Toolbar1.SuspendLayout()
		SuspendLayout()
		' 
		'cmbOption
		' 
		cmbOption.AllowDrop = True
		cmbOption.BackColor = System.Drawing.SystemColors.Window
		cmbOption.CausesValidation = True
		cmbOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		cmbOption.Enabled = True
		cmbOption.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		cmbOption.ForeColor = System.Drawing.SystemColors.WindowText
		cmbOption.IntegralHeight = True
		cmbOption.Location = New System.Drawing.Point(368, 152)
		cmbOption.Name = "cmbOption"
		cmbOption.RightToLeft = System.Windows.Forms.RightToLeft.No
		cmbOption.Size = New System.Drawing.Size(153, 24)
		cmbOption.Sorted = False
		cmbOption.TabIndex = 14
		cmbOption.TabStop = True
		cmbOption.Visible = True
		' 
		'_txtScale_1
		' 
		_txtScale_1.AcceptsReturn = True
		_txtScale_1.AllowDrop = True
		_txtScale_1.BackColor = System.Drawing.SystemColors.Window
		_txtScale_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		_txtScale_1.Cursor = System.Windows.Forms.Cursors.IBeam
		_txtScale_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_txtScale_1.ForeColor = System.Drawing.SystemColors.WindowText
		_txtScale_1.Location = New System.Drawing.Point(512, 96)
		_txtScale_1.MaxLength = 0
		_txtScale_1.Name = "_txtScale_1"
		_txtScale_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		_txtScale_1.Size = New System.Drawing.Size(33, 25)
		_txtScale_1.TabIndex = 13
		_txtScale_1.Text = "2.0"
		_txtScale_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		' 
		'_txtScale_0
		' 
		_txtScale_0.AcceptsReturn = True
		_txtScale_0.AllowDrop = True
		_txtScale_0.BackColor = System.Drawing.SystemColors.Window
		_txtScale_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		_txtScale_0.Cursor = System.Windows.Forms.Cursors.IBeam
		_txtScale_0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_txtScale_0.ForeColor = System.Drawing.SystemColors.WindowText
		_txtScale_0.Location = New System.Drawing.Point(432, 96)
		_txtScale_0.MaxLength = 0
		_txtScale_0.Name = "_txtScale_0"
		_txtScale_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		_txtScale_0.Size = New System.Drawing.Size(33, 25)
		_txtScale_0.TabIndex = 12
		_txtScale_0.Text = "0.2"
		_txtScale_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		' 
		'cmbVariable
		' 
		cmbVariable.AllowDrop = True
		cmbVariable.BackColor = System.Drawing.SystemColors.Window
		cmbVariable.CausesValidation = True
		cmbVariable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		cmbVariable.Enabled = True
		cmbVariable.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		cmbVariable.ForeColor = System.Drawing.SystemColors.WindowText
		cmbVariable.IntegralHeight = True
		cmbVariable.Location = New System.Drawing.Point(72, 160)
		cmbVariable.Name = "cmbVariable"
		cmbVariable.RightToLeft = System.Windows.Forms.RightToLeft.No
		cmbVariable.Size = New System.Drawing.Size(201, 24)
		cmbVariable.Sorted = False
		cmbVariable.TabIndex = 2
		cmbVariable.TabStop = True
		cmbVariable.Visible = True
		' 
		'cmbSegment
		' 
		cmbSegment.AllowDrop = True
		cmbSegment.BackColor = System.Drawing.SystemColors.Window
		cmbSegment.CausesValidation = True
		cmbSegment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		cmbSegment.Enabled = True
		cmbSegment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		cmbSegment.ForeColor = System.Drawing.SystemColors.WindowText
		cmbSegment.IntegralHeight = True
		cmbSegment.Location = New System.Drawing.Point(72, 128)
		cmbSegment.Name = "cmbSegment"
		cmbSegment.RightToLeft = System.Windows.Forms.RightToLeft.No
		cmbSegment.Size = New System.Drawing.Size(201, 24)
		cmbSegment.Sorted = False
		cmbSegment.TabIndex = 1
		cmbSegment.TabStop = True
		cmbSegment.Visible = True
		' 
		'cmbTrib
		' 
		cmbTrib.AllowDrop = True
		cmbTrib.BackColor = System.Drawing.SystemColors.Window
		cmbTrib.CausesValidation = True
		cmbTrib.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		cmbTrib.Enabled = True
		cmbTrib.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		cmbTrib.ForeColor = System.Drawing.SystemColors.WindowText
		cmbTrib.IntegralHeight = True
		cmbTrib.Location = New System.Drawing.Point(72, 96)
		cmbTrib.Name = "cmbTrib"
		cmbTrib.RightToLeft = System.Windows.Forms.RightToLeft.No
		cmbTrib.Size = New System.Drawing.Size(201, 24)
		cmbTrib.Sorted = False
		cmbTrib.TabIndex = 0
		cmbTrib.TabStop = True
		cmbTrib.Visible = True
		' 
		'Toolbar1
		' 
		Toolbar1.AllowDrop = True
		Toolbar1.Dock = System.Windows.Forms.DockStyle.Top
		Toolbar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		Toolbar1.Location = New System.Drawing.Point(0, 0)
		Toolbar1.Name = "Toolbar1"
		Toolbar1.ShowItemToolTips = True
		Toolbar1.Size = New System.Drawing.Size(567, 42)
		Toolbar1.TabIndex = 6
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
		Toolbar1_Buttons_Button1.Size = New System.Drawing.Size(63, 37)
		Toolbar1_Buttons_Button1.Text = "Run"
		Toolbar1_Buttons_Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Toolbar1_Buttons_Button1.ToolTipText = "Run Model"
		' 
		'Toolbar1_Buttons_Button2
		' 
		Toolbar1_Buttons_Button2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Toolbar1_Buttons_Button2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Toolbar1_Buttons_Button2.Size = New System.Drawing.Size(63, 37)
		Toolbar1_Buttons_Button2.Text = "List"
		Toolbar1_Buttons_Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Toolbar1_Buttons_Button2.ToolTipText = "List Results"
		' 
		'Toolbar1_Buttons_Button3
		' 
		Toolbar1_Buttons_Button3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Toolbar1_Buttons_Button3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Toolbar1_Buttons_Button3.Size = New System.Drawing.Size(63, 37)
		Toolbar1_Buttons_Button3.Text = "Copy Chart"
		Toolbar1_Buttons_Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		' 
		'Toolbar1_Buttons_Button4
		' 
		Toolbar1_Buttons_Button4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Toolbar1_Buttons_Button4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Toolbar1_Buttons_Button4.Size = New System.Drawing.Size(63, 37)
		Toolbar1_Buttons_Button4.Text = "Help"
		Toolbar1_Buttons_Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Toolbar1_Buttons_Button4.ToolTipText = "Get Help"
		' 
		'Toolbar1_Buttons_Button5
		' 
		Toolbar1_Buttons_Button5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Toolbar1_Buttons_Button5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Toolbar1_Buttons_Button5.Size = New System.Drawing.Size(63, 37)
		Toolbar1_Buttons_Button5.Text = "Quit"
		Toolbar1_Buttons_Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Toolbar1_Buttons_Button5.ToolTipText = "Return to program menu"
		' 
		'Toolbar1_Buttons_Button6
		' 
		Toolbar1_Buttons_Button6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Toolbar1_Buttons_Button6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Toolbar1_Buttons_Button6.Size = New System.Drawing.Size(63, 37)
		Toolbar1_Buttons_Button6.Text = "Metamodel"
		Toolbar1_Buttons_Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		' 
		'_Label1_4
		' 
		_Label1_4.AllowDrop = True
		_Label1_4.BackColor = System.Drawing.SystemColors.Control
		_Label1_4.BorderStyle = System.Windows.Forms.BorderStyle.None
		_Label1_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Label1_4.ForeColor = System.Drawing.SystemColors.ControlText
		_Label1_4.Location = New System.Drawing.Point(64, 232)
		_Label1_4.MinimumSize = New System.Drawing.Size(200, 60)
		_Label1_4.Name = "_Label1_4"
		_Label1_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Label1_4.Size = New System.Drawing.Size(200, 60)
		_Label1_4.TabIndex = 9
		_Label1_4.Text = "Variable:"
		_Label1_4.TextAlign = System.Drawing.ContentAlignment.TopRight
		' 
		'_Label1_7
		' 
		_Label1_7.AllowDrop = True
		_Label1_7.BackColor = System.Drawing.SystemColors.Control
		_Label1_7.BorderStyle = System.Windows.Forms.BorderStyle.None
		_Label1_7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Label1_7.ForeColor = System.Drawing.SystemColors.ControlText
		_Label1_7.Location = New System.Drawing.Point(304, 152)
		_Label1_7.MinimumSize = New System.Drawing.Size(49, 25)
		_Label1_7.Name = "_Label1_7"
		_Label1_7.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Label1_7.Size = New System.Drawing.Size(49, 25)
		_Label1_7.TabIndex = 15
		_Label1_7.Text = "Method:"
		_Label1_7.TextAlign = System.Drawing.ContentAlignment.TopRight
		' 
		'Image1
		' 
		Image1.AllowDrop = True
		Image1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Image1.Enabled = True
		Image1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		Image1.Location = New System.Drawing.Point(8, 200)
		Image1.Name = "Image1"
		Image1.Size = New System.Drawing.Size(553, 385)
		Image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Image1.Visible = True
		' 
		'_Label1_6
		' 
		_Label1_6.AllowDrop = True
		_Label1_6.BackColor = System.Drawing.SystemColors.Control
		_Label1_6.BorderStyle = System.Windows.Forms.BorderStyle.None
		_Label1_6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Label1_6.ForeColor = System.Drawing.SystemColors.ControlText
		_Label1_6.Location = New System.Drawing.Point(472, 96)
		_Label1_6.MinimumSize = New System.Drawing.Size(33, 25)
		_Label1_6.Name = "_Label1_6"
		_Label1_6.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Label1_6.Size = New System.Drawing.Size(33, 25)
		_Label1_6.TabIndex = 11
		_Label1_6.Text = "High:"
		_Label1_6.TextAlign = System.Drawing.ContentAlignment.TopRight
		' 
		'_Label1_5
		' 
		_Label1_5.AllowDrop = True
		_Label1_5.BackColor = System.Drawing.SystemColors.Control
		_Label1_5.BorderStyle = System.Windows.Forms.BorderStyle.None
		_Label1_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Label1_5.ForeColor = System.Drawing.SystemColors.ControlText
		_Label1_5.Location = New System.Drawing.Point(296, 96)
		_Label1_5.MinimumSize = New System.Drawing.Size(129, 25)
		_Label1_5.Name = "_Label1_5"
		_Label1_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Label1_5.Size = New System.Drawing.Size(129, 25)
		_Label1_5.TabIndex = 10
		_Label1_5.Text = "TP Load Scale   Low:"
		_Label1_5.TextAlign = System.Drawing.ContentAlignment.TopRight
		' 
		'lblStatus
		' 
		lblStatus.AllowDrop = True
		lblStatus.BackColor = System.Drawing.SystemColors.InactiveCaptionText
		lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.None
		lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		lblStatus.ForeColor = System.Drawing.SystemColors.ControlText
		lblStatus.Location = New System.Drawing.Point(72, 64)
		lblStatus.MinimumSize = New System.Drawing.Size(185, 25)
		lblStatus.Name = "lblStatus"
		lblStatus.RightToLeft = System.Windows.Forms.RightToLeft.No
		lblStatus.Size = New System.Drawing.Size(185, 25)
		lblStatus.TabIndex = 8
		lblStatus.Text = "Ready"
		lblStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter
		' 
		'_Label1_3
		' 
		_Label1_3.AllowDrop = True
		_Label1_3.BackColor = System.Drawing.SystemColors.Control
		_Label1_3.BorderStyle = System.Windows.Forms.BorderStyle.None
		_Label1_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Label1_3.ForeColor = System.Drawing.SystemColors.ControlText
		_Label1_3.Location = New System.Drawing.Point(0, 64)
		_Label1_3.MinimumSize = New System.Drawing.Size(57, 25)
		_Label1_3.Name = "_Label1_3"
		_Label1_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Label1_3.Size = New System.Drawing.Size(57, 25)
		_Label1_3.TabIndex = 7
		_Label1_3.Text = "Status:"
		_Label1_3.TextAlign = System.Drawing.ContentAlignment.TopRight
		' 
		'_Label1_2
		' 
		_Label1_2.AllowDrop = True
		_Label1_2.BackColor = System.Drawing.SystemColors.Control
		_Label1_2.BorderStyle = System.Windows.Forms.BorderStyle.None
		_Label1_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Label1_2.ForeColor = System.Drawing.SystemColors.ControlText
		_Label1_2.Location = New System.Drawing.Point(-8, 168)
		_Label1_2.MinimumSize = New System.Drawing.Size(65, 17)
		_Label1_2.Name = "_Label1_2"
		_Label1_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Label1_2.Size = New System.Drawing.Size(65, 17)
		_Label1_2.TabIndex = 5
		_Label1_2.Text = "Variable:"
		_Label1_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		' 
		'_Label1_1
		' 
		_Label1_1.AllowDrop = True
		_Label1_1.BackColor = System.Drawing.SystemColors.Control
		_Label1_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		_Label1_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Label1_1.ForeColor = System.Drawing.SystemColors.ControlText
		_Label1_1.Location = New System.Drawing.Point(-8, 136)
		_Label1_1.MinimumSize = New System.Drawing.Size(65, 17)
		_Label1_1.Name = "_Label1_1"
		_Label1_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Label1_1.Size = New System.Drawing.Size(65, 17)
		_Label1_1.TabIndex = 4
		_Label1_1.Text = "Segment:"
		_Label1_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		' 
		'_Label1_0
		' 
		_Label1_0.AllowDrop = True
		_Label1_0.BackColor = System.Drawing.SystemColors.Control
		_Label1_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		_Label1_0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Label1_0.ForeColor = System.Drawing.SystemColors.ControlText
		_Label1_0.Location = New System.Drawing.Point(-8, 104)
		_Label1_0.MinimumSize = New System.Drawing.Size(65, 17)
		_Label1_0.Name = "_Label1_0"
		_Label1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Label1_0.Size = New System.Drawing.Size(65, 17)
		_Label1_0.TabIndex = 3
		_Label1_0.Text = "Tributary:"
		_Label1_0.TextAlign = System.Drawing.ContentAlignment.TopRight
		' 
		'frmResponse
		' 
		AllowDrop = True
		AutoScaleDimensions = New System.Drawing.SizeF(7, 15)
		AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		BackColor = System.Drawing.SystemColors.Control
		ClientSize = New System.Drawing.Size(567, 595)
		Controls.Add(cmbOption)
		Controls.Add(_txtScale_1)
		Controls.Add(_txtScale_0)
		Controls.Add(cmbVariable)
		Controls.Add(cmbSegment)
		Controls.Add(cmbTrib)
		Controls.Add(Toolbar1)
		Controls.Add(_Label1_7)
		Controls.Add(Image1)
		Controls.Add(_Label1_6)
		Controls.Add(_Label1_5)
		Controls.Add(lblStatus)
		Controls.Add(_Label1_3)
		Controls.Add(_Label1_2)
		Controls.Add(_Label1_1)
		Controls.Add(_Label1_0)
		Controls.Add(_Label1_4)
		Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		Icon = CType(resources.GetObject("frmResponse.Icon"), System.Drawing.Icon)
		Location = New System.Drawing.Point(4, 23)
		MaximizeBox = True
		MinimizeBox = True
		Name = "frmResponse"
		RightToLeft = System.Windows.Forms.RightToLeft.No
		Text = "Load Response"
		ToolTipMain.SetToolTip(cmbOption, "Select method for varying loads")
		ToolTipMain.SetToolTip(_txtScale_0, "Scale factors applied to existing loads")
		ToolTipMain.SetToolTip(cmbVariable, "Test this response variable")
		ToolTipMain.SetToolTip(cmbSegment, "Test response of this segment")
		ToolTipMain.SetToolTip(cmbTrib, "Vary P load in this tributary")
		ToolTipMain.SetToolTip(Image1, "Load/Response Plot")
		Toolbar1.ResumeLayout(False)
		Toolbar1.PerformLayout()
		ResumeLayout(False)
		PerformLayout()
	End Sub
	Sub ReLoadForm(ByVal addEvents As Boolean)
		InitializetxtScale()
		InitializeLabel1()
		If addEvents Then
			AddHandler MyBase.Closed, AddressOf Form_Closed
			AddHandler Activated, AddressOf frmResponse_Activated
		End If
	End Sub
	Sub InitializetxtScale()
		ReDim txtScale(1)
		txtScale(1) = _txtScale_1
		txtScale(0) = _txtScale_0
	End Sub
	Sub InitializeLabel1()
		ReDim Label1(7)
		Label1(4) = _Label1_4
		Label1(7) = _Label1_7
		Label1(6) = _Label1_6
		Label1(5) = _Label1_5
		Label1(3) = _Label1_3
		Label1(2) = _Label1_2
		Label1(1) = _Label1_1
		Label1(0) = _Label1_0
	End Sub
#End Region
End Class