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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmResponse))
        ToolTipMain = New ToolTip(components)
        cmbOption = New ComboBox()
        _txtScale_0 = New TextBox()
        cmbVariable = New ComboBox()
        cmbSegment = New ComboBox()
        cmbTrib = New ComboBox()
        Image1 = New PictureBox()
        _txtScale_1 = New TextBox()
        Toolbar1 = New ToolStrip()
        Toolbar1_Buttons_Button1 = New ToolStripButton()
        Toolbar1_Buttons_Button2 = New ToolStripButton()
        Toolbar1_Buttons_Button3 = New ToolStripButton()
        Toolbar1_Buttons_Button4 = New ToolStripButton()
        Toolbar1_Buttons_Button5 = New ToolStripButton()
        Toolbar1_Buttons_Button6 = New ToolStripButton()
        _Label1_4 = New Label()
        _Label1_7 = New Label()
        _Label1_6 = New Label()
        _Label1_5 = New Label()
        lblStatus = New Label()
        _Label1_3 = New Label()
        _Label1_2 = New Label()
        _Label1_1 = New Label()
        _Label1_0 = New Label()
        CType(Image1, ComponentModel.ISupportInitialize).BeginInit()
        Toolbar1.SuspendLayout()
        SuspendLayout()
        ' 
        ' cmbOption
        ' 
        cmbOption.AllowDrop = True
        cmbOption.BackColor = SystemColors.Window
        cmbOption.DropDownStyle = ComboBoxStyle.DropDownList
        cmbOption.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbOption.ForeColor = SystemColors.WindowText
        cmbOption.Location = New Point(368, 152)
        cmbOption.Name = "cmbOption"
        cmbOption.RightToLeft = RightToLeft.No
        cmbOption.Size = New Size(153, 24)
        cmbOption.TabIndex = 14
        ToolTipMain.SetToolTip(cmbOption, "Select method for varying loads")
        ' 
        ' _txtScale_0
        ' 
        _txtScale_0.AcceptsReturn = True
        _txtScale_0.AllowDrop = True
        _txtScale_0.BackColor = SystemColors.Window
        _txtScale_0.Cursor = Cursors.IBeam
        _txtScale_0.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _txtScale_0.ForeColor = SystemColors.WindowText
        _txtScale_0.Location = New Point(432, 96)
        _txtScale_0.MaxLength = 0
        _txtScale_0.Name = "_txtScale_0"
        _txtScale_0.RightToLeft = RightToLeft.No
        _txtScale_0.Size = New Size(33, 22)
        _txtScale_0.TabIndex = 12
        _txtScale_0.Text = "0.2"
        _txtScale_0.TextAlign = HorizontalAlignment.Center
        ToolTipMain.SetToolTip(_txtScale_0, "Scale factors applied to existing loads")
        ' 
        ' cmbVariable
        ' 
        cmbVariable.AllowDrop = True
        cmbVariable.BackColor = SystemColors.Window
        cmbVariable.DropDownStyle = ComboBoxStyle.DropDownList
        cmbVariable.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbVariable.ForeColor = SystemColors.WindowText
        cmbVariable.Location = New Point(72, 160)
        cmbVariable.Name = "cmbVariable"
        cmbVariable.RightToLeft = RightToLeft.No
        cmbVariable.Size = New Size(201, 24)
        cmbVariable.TabIndex = 2
        ToolTipMain.SetToolTip(cmbVariable, "Test this response variable")
        ' 
        ' cmbSegment
        ' 
        cmbSegment.AllowDrop = True
        cmbSegment.BackColor = SystemColors.Window
        cmbSegment.DropDownStyle = ComboBoxStyle.DropDownList
        cmbSegment.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbSegment.ForeColor = SystemColors.WindowText
        cmbSegment.Location = New Point(72, 128)
        cmbSegment.Name = "cmbSegment"
        cmbSegment.RightToLeft = RightToLeft.No
        cmbSegment.Size = New Size(201, 24)
        cmbSegment.TabIndex = 1
        ToolTipMain.SetToolTip(cmbSegment, "Test response of this segment")
        ' 
        ' cmbTrib
        ' 
        cmbTrib.AllowDrop = True
        cmbTrib.BackColor = SystemColors.Window
        cmbTrib.DropDownStyle = ComboBoxStyle.DropDownList
        cmbTrib.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbTrib.ForeColor = SystemColors.WindowText
        cmbTrib.Location = New Point(72, 96)
        cmbTrib.Name = "cmbTrib"
        cmbTrib.RightToLeft = RightToLeft.No
        cmbTrib.Size = New Size(201, 24)
        cmbTrib.TabIndex = 0
        ToolTipMain.SetToolTip(cmbTrib, "Vary P load in this tributary")
        ' 
        ' Image1
        ' 
        Image1.AllowDrop = True
        Image1.BorderStyle = BorderStyle.Fixed3D
        Image1.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Image1.Location = New Point(8, 200)
        Image1.Name = "Image1"
        Image1.Size = New Size(553, 385)
        Image1.TabIndex = 16
        Image1.TabStop = False
        ToolTipMain.SetToolTip(Image1, "Load/Response Plot")
        ' 
        ' _txtScale_1
        ' 
        _txtScale_1.AcceptsReturn = True
        _txtScale_1.AllowDrop = True
        _txtScale_1.BackColor = SystemColors.Window
        _txtScale_1.Cursor = Cursors.IBeam
        _txtScale_1.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _txtScale_1.ForeColor = SystemColors.WindowText
        _txtScale_1.Location = New Point(512, 96)
        _txtScale_1.MaxLength = 0
        _txtScale_1.Name = "_txtScale_1"
        _txtScale_1.RightToLeft = RightToLeft.No
        _txtScale_1.Size = New Size(33, 22)
        _txtScale_1.TabIndex = 13
        _txtScale_1.Text = "2.0"
        _txtScale_1.TextAlign = HorizontalAlignment.Center
        ' 
        ' Toolbar1
        ' 
        Toolbar1.AllowDrop = True
        Toolbar1.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Toolbar1.Items.AddRange(New ToolStripItem() {Toolbar1_Buttons_Button1, Toolbar1_Buttons_Button2, Toolbar1_Buttons_Button3, Toolbar1_Buttons_Button4, Toolbar1_Buttons_Button5, Toolbar1_Buttons_Button6})
        Toolbar1.Location = New Point(0, 0)
        Toolbar1.Name = "Toolbar1"
        Toolbar1.Size = New Size(567, 25)
        Toolbar1.TabIndex = 6
        ' 
        ' Toolbar1_Buttons_Button1
        ' 
        Toolbar1_Buttons_Button1.ImageScaling = ToolStripItemImageScaling.None
        Toolbar1_Buttons_Button1.Name = "Toolbar1_Buttons_Button1"
        Toolbar1_Buttons_Button1.Size = New Size(35, 22)
        Toolbar1_Buttons_Button1.Text = "Run"
        Toolbar1_Buttons_Button1.TextImageRelation = TextImageRelation.ImageAboveText
        Toolbar1_Buttons_Button1.ToolTipText = "Run Model"
        ' 
        ' Toolbar1_Buttons_Button2
        ' 
        Toolbar1_Buttons_Button2.ImageScaling = ToolStripItemImageScaling.None
        Toolbar1_Buttons_Button2.Name = "Toolbar1_Buttons_Button2"
        Toolbar1_Buttons_Button2.Size = New Size(31, 22)
        Toolbar1_Buttons_Button2.Text = "List"
        Toolbar1_Buttons_Button2.TextImageRelation = TextImageRelation.ImageAboveText
        Toolbar1_Buttons_Button2.ToolTipText = "List Results"
        ' 
        ' Toolbar1_Buttons_Button3
        ' 
        Toolbar1_Buttons_Button3.ImageScaling = ToolStripItemImageScaling.None
        Toolbar1_Buttons_Button3.Name = "Toolbar1_Buttons_Button3"
        Toolbar1_Buttons_Button3.Size = New Size(77, 22)
        Toolbar1_Buttons_Button3.Text = "Copy Chart"
        Toolbar1_Buttons_Button3.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' Toolbar1_Buttons_Button4
        ' 
        Toolbar1_Buttons_Button4.ImageScaling = ToolStripItemImageScaling.None
        Toolbar1_Buttons_Button4.Name = "Toolbar1_Buttons_Button4"
        Toolbar1_Buttons_Button4.Size = New Size(40, 22)
        Toolbar1_Buttons_Button4.Text = "Help"
        Toolbar1_Buttons_Button4.TextImageRelation = TextImageRelation.ImageAboveText
        Toolbar1_Buttons_Button4.ToolTipText = "Get Help"
        ' 
        ' Toolbar1_Buttons_Button5
        ' 
        Toolbar1_Buttons_Button5.ImageScaling = ToolStripItemImageScaling.None
        Toolbar1_Buttons_Button5.Name = "Toolbar1_Buttons_Button5"
        Toolbar1_Buttons_Button5.Size = New Size(34, 22)
        Toolbar1_Buttons_Button5.Text = "Quit"
        Toolbar1_Buttons_Button5.TextImageRelation = TextImageRelation.ImageAboveText
        Toolbar1_Buttons_Button5.ToolTipText = "Return to program menu"
        ' 
        ' Toolbar1_Buttons_Button6
        ' 
        Toolbar1_Buttons_Button6.ImageScaling = ToolStripItemImageScaling.None
        Toolbar1_Buttons_Button6.Name = "Toolbar1_Buttons_Button6"
        Toolbar1_Buttons_Button6.Size = New Size(79, 22)
        Toolbar1_Buttons_Button6.Text = "Metamodel"
        Toolbar1_Buttons_Button6.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' _Label1_4
        ' 
        _Label1_4.AllowDrop = True
        _Label1_4.BackColor = SystemColors.Control
        _Label1_4.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _Label1_4.ForeColor = SystemColors.ControlText
        _Label1_4.Location = New Point(64, 232)
        _Label1_4.MinimumSize = New Size(200, 60)
        _Label1_4.Name = "_Label1_4"
        _Label1_4.RightToLeft = RightToLeft.No
        _Label1_4.Size = New Size(200, 60)
        _Label1_4.TabIndex = 9
        _Label1_4.Text = "Variable:"
        _Label1_4.TextAlign = ContentAlignment.TopRight
        ' 
        ' _Label1_7
        ' 
        _Label1_7.AllowDrop = True
        _Label1_7.BackColor = SystemColors.Control
        _Label1_7.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _Label1_7.ForeColor = SystemColors.ControlText
        _Label1_7.Location = New Point(304, 152)
        _Label1_7.MinimumSize = New Size(49, 25)
        _Label1_7.Name = "_Label1_7"
        _Label1_7.RightToLeft = RightToLeft.No
        _Label1_7.Size = New Size(49, 25)
        _Label1_7.TabIndex = 15
        _Label1_7.Text = "Method:"
        _Label1_7.TextAlign = ContentAlignment.TopRight
        ' 
        ' _Label1_6
        ' 
        _Label1_6.AllowDrop = True
        _Label1_6.BackColor = SystemColors.Control
        _Label1_6.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _Label1_6.ForeColor = SystemColors.ControlText
        _Label1_6.Location = New Point(472, 96)
        _Label1_6.MinimumSize = New Size(33, 25)
        _Label1_6.Name = "_Label1_6"
        _Label1_6.RightToLeft = RightToLeft.No
        _Label1_6.Size = New Size(33, 25)
        _Label1_6.TabIndex = 11
        _Label1_6.Text = "High:"
        _Label1_6.TextAlign = ContentAlignment.TopRight
        ' 
        ' _Label1_5
        ' 
        _Label1_5.AllowDrop = True
        _Label1_5.BackColor = SystemColors.Control
        _Label1_5.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _Label1_5.ForeColor = SystemColors.ControlText
        _Label1_5.Location = New Point(296, 96)
        _Label1_5.MinimumSize = New Size(129, 25)
        _Label1_5.Name = "_Label1_5"
        _Label1_5.RightToLeft = RightToLeft.No
        _Label1_5.Size = New Size(129, 25)
        _Label1_5.TabIndex = 10
        _Label1_5.Text = "TP Load Scale   Low:"
        _Label1_5.TextAlign = ContentAlignment.TopRight
        ' 
        ' lblStatus
        ' 
        lblStatus.AllowDrop = True
        lblStatus.BackColor = SystemColors.InactiveCaptionText
        lblStatus.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStatus.ForeColor = SystemColors.ControlText
        lblStatus.Location = New Point(72, 64)
        lblStatus.MinimumSize = New Size(185, 25)
        lblStatus.Name = "lblStatus"
        lblStatus.RightToLeft = RightToLeft.No
        lblStatus.Size = New Size(185, 25)
        lblStatus.TabIndex = 8
        lblStatus.Text = "Ready"
        lblStatus.TextAlign = ContentAlignment.TopCenter
        ' 
        ' _Label1_3
        ' 
        _Label1_3.AllowDrop = True
        _Label1_3.BackColor = SystemColors.Control
        _Label1_3.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _Label1_3.ForeColor = SystemColors.ControlText
        _Label1_3.Location = New Point(0, 64)
        _Label1_3.MinimumSize = New Size(57, 25)
        _Label1_3.Name = "_Label1_3"
        _Label1_3.RightToLeft = RightToLeft.No
        _Label1_3.Size = New Size(57, 25)
        _Label1_3.TabIndex = 7
        _Label1_3.Text = "Status:"
        _Label1_3.TextAlign = ContentAlignment.TopRight
        ' 
        ' _Label1_2
        ' 
        _Label1_2.AllowDrop = True
        _Label1_2.BackColor = SystemColors.Control
        _Label1_2.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _Label1_2.ForeColor = SystemColors.ControlText
        _Label1_2.Location = New Point(-8, 168)
        _Label1_2.MinimumSize = New Size(65, 17)
        _Label1_2.Name = "_Label1_2"
        _Label1_2.RightToLeft = RightToLeft.No
        _Label1_2.Size = New Size(65, 17)
        _Label1_2.TabIndex = 5
        _Label1_2.Text = "Variable:"
        _Label1_2.TextAlign = ContentAlignment.TopRight
        ' 
        ' _Label1_1
        ' 
        _Label1_1.AllowDrop = True
        _Label1_1.BackColor = SystemColors.Control
        _Label1_1.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _Label1_1.ForeColor = SystemColors.ControlText
        _Label1_1.Location = New Point(-8, 136)
        _Label1_1.MinimumSize = New Size(65, 17)
        _Label1_1.Name = "_Label1_1"
        _Label1_1.RightToLeft = RightToLeft.No
        _Label1_1.Size = New Size(65, 17)
        _Label1_1.TabIndex = 4
        _Label1_1.Text = "Segment:"
        _Label1_1.TextAlign = ContentAlignment.TopRight
        ' 
        ' _Label1_0
        ' 
        _Label1_0.AllowDrop = True
        _Label1_0.BackColor = SystemColors.Control
        _Label1_0.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _Label1_0.ForeColor = SystemColors.ControlText
        _Label1_0.Location = New Point(-8, 104)
        _Label1_0.MinimumSize = New Size(65, 17)
        _Label1_0.Name = "_Label1_0"
        _Label1_0.RightToLeft = RightToLeft.No
        _Label1_0.Size = New Size(65, 17)
        _Label1_0.TabIndex = 3
        _Label1_0.Text = "Tributary:"
        _Label1_0.TextAlign = ContentAlignment.TopRight
        ' 
        ' frmResponse
        ' 
        AllowDrop = True
        AutoScaleDimensions = New SizeF(8F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(567, 595)
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
        Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Location = New Point(4, 23)
        Name = "frmResponse"
        RightToLeft = RightToLeft.No
        Text = "Load Response"
        CType(Image1, ComponentModel.ISupportInitialize).EndInit()
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