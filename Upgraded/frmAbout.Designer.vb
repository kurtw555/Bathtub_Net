<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As frmAbout
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As frmAbout
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = CreateInstance()
				m_InitializingDefInstance = False
			End If
			Return m_vb6FormDefInstance
		End Get
		Set(ByVal Value As frmAbout)
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region
#Region "Windows Form Designer generated code "
	Public Shared Function CreateInstance() As frmAbout
		Dim theInstance As New frmAbout()
		theInstance.Form_Load()
		Return theInstance
	End Function
	Private visualControls() As String = New String() {"components", "ToolTipMain", "Command2", "Command1", "picIcon", "cmdOK", "_lblTitle_2", "_lblTitle_1", "_lblTitle_0", "_Line1_0", "Line1", "lblTitle", "commandButtonHelper1"}
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTipMain As System.Windows.Forms.ToolTip
	Public WithEvents Command2 As System.Windows.Forms.Button
	Public WithEvents Command1 As System.Windows.Forms.Button
	Public WithEvents picIcon As System.Windows.Forms.PictureBox
	Public WithEvents cmdOK As System.Windows.Forms.Button
	Private WithEvents _lblTitle_2 As System.Windows.Forms.Label
	Private WithEvents _lblTitle_1 As System.Windows.Forms.Label
	Private WithEvents _lblTitle_0 As System.Windows.Forms.Label
	Private WithEvents _Line1_0 As System.Windows.Forms.Label
	Public Line1(0) As System.Windows.Forms.Label
	Public lblTitle(2) As System.Windows.Forms.Label
	Public commandButtonHelper1 As UpgradeHelpers.Gui.Controls.CommandButtonHelper
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbout))
        ToolTipMain = New ToolTip(components)
        Command2 = New Button()
        Command1 = New Button()
        cmdOK = New Button()
        picIcon = New PictureBox()
        _lblTitle_2 = New Label()
        _lblTitle_1 = New Label()
        _lblTitle_0 = New Label()
        _Line1_0 = New Label()
        commandButtonHelper1 = New UpgradeHelpers.Gui.Controls.CommandButtonHelper(components)
        CType(picIcon, ComponentModel.ISupportInitialize).BeginInit()
        CType(commandButtonHelper1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Command2
        ' 
        Command2.AllowDrop = True
        Command2.BackColor = SystemColors.Control
        commandButtonHelper1.SetCorrectEventsBehavior(Command2, True)
        commandButtonHelper1.SetDisabledPicture(Command2, Nothing)
        commandButtonHelper1.SetDownPicture(Command2, Nothing)
        Command2.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Command2.ForeColor = SystemColors.ControlText
        Command2.Location = New Point(176, 152)
        commandButtonHelper1.SetMaskColor(Command2, Color.Silver)
        Command2.Name = "Command2"
        Command2.RightToLeft = RightToLeft.No
        Command2.Size = New Size(76, 25)
        commandButtonHelper1.SetStyle(Command2, 0)
        Command2.TabIndex = 5
        Command2.Text = "Disclaimer"
        Command2.TextImageRelation = TextImageRelation.ImageAboveText
        ToolTipMain.SetToolTip(Command2, "Read disclaimer statement")
        Command2.UseVisualStyleBackColor = False
        ' 
        ' Command1
        ' 
        Command1.AllowDrop = True
        Command1.BackColor = SystemColors.Control
        commandButtonHelper1.SetCorrectEventsBehavior(Command1, True)
        commandButtonHelper1.SetDisabledPicture(Command1, Nothing)
        commandButtonHelper1.SetDownPicture(Command1, Nothing)
        Command1.Enabled = False
        Command1.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Command1.ForeColor = SystemColors.ControlText
        Command1.Location = New Point(56, 152)
        commandButtonHelper1.SetMaskColor(Command1, Color.Silver)
        Command1.Name = "Command1"
        Command1.RightToLeft = RightToLeft.No
        Command1.Size = New Size(100, 25)
        commandButtonHelper1.SetStyle(Command1, 0)
        Command1.TabIndex = 1
        Command1.Text = "Documentation"
        Command1.TextImageRelation = TextImageRelation.ImageAboveText
        ToolTipMain.SetToolTip(Command1, "View documentation & help screens")
        Command1.UseVisualStyleBackColor = False
        ' 
        ' cmdOK
        ' 
        cmdOK.AllowDrop = True
        cmdOK.BackColor = SystemColors.Control
        commandButtonHelper1.SetCorrectEventsBehavior(cmdOK, True)
        commandButtonHelper1.SetDisabledPicture(cmdOK, Nothing)
        commandButtonHelper1.SetDownPicture(cmdOK, Nothing)
        cmdOK.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        cmdOK.ForeColor = SystemColors.ControlText
        cmdOK.Location = New Point(272, 152)
        commandButtonHelper1.SetMaskColor(cmdOK, Color.Silver)
        cmdOK.Name = "cmdOK"
        cmdOK.RightToLeft = RightToLeft.No
        cmdOK.Size = New Size(52, 25)
        commandButtonHelper1.SetStyle(cmdOK, 0)
        cmdOK.TabIndex = 2
        cmdOK.Text = "OK"
        cmdOK.TextImageRelation = TextImageRelation.ImageAboveText
        ToolTipMain.SetToolTip(cmdOK, "Start program")
        cmdOK.UseVisualStyleBackColor = False
        ' 
        ' picIcon
        ' 
        picIcon.AllowDrop = True
        picIcon.BackColor = SystemColors.Control
        picIcon.BorderStyle = BorderStyle.Fixed3D
        picIcon.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        picIcon.Image = CType(resources.GetObject("picIcon.Image"), Image)
        picIcon.Location = New Point(8, 8)
        picIcon.Name = "picIcon"
        picIcon.Size = New Size(36, 36)
        picIcon.SizeMode = PictureBoxSizeMode.AutoSize
        picIcon.TabIndex = 0
        ' 
        ' _lblTitle_2
        ' 
        _lblTitle_2.AllowDrop = True
        _lblTitle_2.BackColor = SystemColors.Control
        _lblTitle_2.Font = New Font("Microsoft Sans Serif", 8.4F, FontStyle.Regular, GraphicsUnit.Point)
        _lblTitle_2.ForeColor = Color.Black
        _lblTitle_2.Location = New Point(96, 104)
        _lblTitle_2.MinimumSize = New Size(187, 32)
        _lblTitle_2.Name = "_lblTitle_2"
        _lblTitle_2.RightToLeft = RightToLeft.No
        _lblTitle_2.Size = New Size(187, 32)
        _lblTitle_2.TabIndex = 6
        _lblTitle_2.Text = "U.S. Army Corps of Engineers Waterways Experiment Station"
        _lblTitle_2.TextAlign = ContentAlignment.TopCenter
        ' 
        ' _lblTitle_1
        ' 
        _lblTitle_1.AllowDrop = True
        _lblTitle_1.BackColor = SystemColors.Control
        _lblTitle_1.Font = New Font("Microsoft Sans Serif", 9.6F, FontStyle.Regular, GraphicsUnit.Point)
        _lblTitle_1.ForeColor = Color.Black
        _lblTitle_1.Location = New Point(56, 64)
        _lblTitle_1.MinimumSize = New Size(259, 40)
        _lblTitle_1.Name = "_lblTitle_1"
        _lblTitle_1.RightToLeft = RightToLeft.No
        _lblTitle_1.Size = New Size(259, 40)
        _lblTitle_1.TabIndex = 4
        _lblTitle_1.Text = "Simplified Techniques for Eutrophication Assessment and Prediction"
        _lblTitle_1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' _lblTitle_0
        ' 
        _lblTitle_0.AllowDrop = True
        _lblTitle_0.BackColor = SystemColors.Control
        _lblTitle_0.Font = New Font("Microsoft Sans Serif", 9.6F, FontStyle.Bold, GraphicsUnit.Point)
        _lblTitle_0.ForeColor = Color.Black
        _lblTitle_0.Location = New Point(64, 16)
        _lblTitle_0.MinimumSize = New Size(259, 40)
        _lblTitle_0.Name = "_lblTitle_0"
        _lblTitle_0.RightToLeft = RightToLeft.No
        _lblTitle_0.Size = New Size(259, 40)
        _lblTitle_0.TabIndex = 3
        _lblTitle_0.Text = "Bathtub for Windows Version 6.14"
        _lblTitle_0.TextAlign = ContentAlignment.TopCenter
        ' 
        ' _Line1_0
        ' 
        _Line1_0.AllowDrop = True
        _Line1_0.BackColor = Color.White
        _Line1_0.Enabled = False
        _Line1_0.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        _Line1_0.Location = New Point(0, 160)
        _Line1_0.Name = "_Line1_0"
        _Line1_0.Size = New Size(308, 1)
        _Line1_0.TabIndex = 7
        ' 
        ' frmAbout
        ' 
        AcceptButton = cmdOK
        AllowDrop = True
        AutoScaleDimensions = New SizeF(6F, 13F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        CancelButton = cmdOK
        ClientSize = New Size(376, 192)
        Controls.Add(Command2)
        Controls.Add(Command1)
        Controls.Add(picIcon)
        Controls.Add(cmdOK)
        Controls.Add(_lblTitle_2)
        Controls.Add(_lblTitle_1)
        Controls.Add(_lblTitle_0)
        Controls.Add(_Line1_0)
        Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Location = New Point(156, 129)
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmAbout"
        RightToLeft = RightToLeft.No
        ShowInTaskbar = False
        Text = "Program Information"
        CType(picIcon, ComponentModel.ISupportInitialize).EndInit()
        CType(commandButtonHelper1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Sub ReLoadForm(ByVal addEvents As Boolean)
		InitializelblTitle()
		InitializeLine1()
		form_initialize()
		If addEvents Then
			AddHandler MyBase.Closed, AddressOf Form_Closed
			AddHandler Activated, AddressOf frmAbout_Activated
		End If
	End Sub
	Sub InitializelblTitle()
		ReDim lblTitle(2)
		lblTitle(2) = _lblTitle_2
		lblTitle(1) = _lblTitle_1
		lblTitle(0) = _lblTitle_0
	End Sub
	Sub InitializeLine1()
		ReDim Line1(0)
		Line1(0) = _Line1_0
	End Sub
#End Region
End Class