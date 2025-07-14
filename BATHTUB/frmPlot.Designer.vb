<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPlot
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As frmPlot
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As frmPlot
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = CreateInstance()
				m_InitializingDefInstance = False
			End If
			Return m_vb6FormDefInstance
		End Get
		Set(ByVal Value As frmPlot)
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region
#Region "Windows Form Designer generated code "
	Public Shared Function CreateInstance() As frmPlot
		Dim theInstance As New frmPlot()
		theInstance.Form_Load()
		Return theInstance
	End Function
	Private visualControls() As String = New String() {"components", "ToolTipMain", "chkLogScale", "txtBarWidth", "chkObserved", "Toolbar1_Buttons_Button1", "Toolbar1_Buttons_Button2", "Toolbar1_Buttons_Button3", "Toolbar1_Buttons_Button4", "Toolbar1_Buttons_Button5", "Toolbar1", "btnListVar", "Combo1", "Label1", "Image1", "commandButtonHelper1"}
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTipMain As System.Windows.Forms.ToolTip
	Public WithEvents chkLogScale As System.Windows.Forms.CheckBox
	Public WithEvents txtBarWidth As System.Windows.Forms.TextBox
	Public WithEvents chkObserved As System.Windows.Forms.CheckBox
	Public WithEvents Toolbar1_Buttons_Button1 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Buttons_Button2 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Buttons_Button3 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Buttons_Button4 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Buttons_Button5 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1 As System.Windows.Forms.ToolStrip
	Public WithEvents btnListVar As System.Windows.Forms.Button
	Public WithEvents Combo1 As System.Windows.Forms.ComboBox
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Image1 As System.Windows.Forms.PictureBox
	Public commandButtonHelper1 As UpgradeHelpers.Gui.Controls.CommandButtonHelper
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPlot))
        ToolTipMain = New ToolTip(components)
        chkLogScale = New CheckBox()
        txtBarWidth = New TextBox()
        chkObserved = New CheckBox()
        btnListVar = New Button()
        Toolbar1 = New ToolStrip()
        Toolbar1_Buttons_Button1 = New ToolStripButton()
        Toolbar1_Buttons_Button2 = New ToolStripButton()
        Toolbar1_Buttons_Button3 = New ToolStripButton()
        Toolbar1_Buttons_Button4 = New ToolStripButton()
        Toolbar1_Buttons_Button5 = New ToolStripButton()
        Combo1 = New ComboBox()
        Label1 = New Label()
        Image1 = New PictureBox()
        commandButtonHelper1 = New UpgradeHelpers.Gui.Controls.CommandButtonHelper(components)
        Toolbar1.SuspendLayout()
        CType(Image1, ComponentModel.ISupportInitialize).BeginInit()
        CType(commandButtonHelper1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' chkLogScale
        ' 
        chkLogScale.AllowDrop = True
        chkLogScale.BackColor = SystemColors.Control
        chkLogScale.Font = New Font("Microsoft Sans Serif", 9.6F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        chkLogScale.ForeColor = SystemColors.ControlText
        chkLogScale.Location = New Point(520, 88)
        chkLogScale.Name = "chkLogScale"
        chkLogScale.RightToLeft = RightToLeft.No
        chkLogScale.Size = New Size(121, 25)
        chkLogScale.TabIndex = 6
        chkLogScale.Text = "Log Scale"
        ToolTipMain.SetToolTip(chkLogScale, "Plot observed values")
        chkLogScale.UseVisualStyleBackColor = False
        ' 
        ' txtBarWidth
        ' 
        txtBarWidth.AcceptsReturn = True
        txtBarWidth.AllowDrop = True
        txtBarWidth.BackColor = SystemColors.Window
        txtBarWidth.Cursor = Cursors.IBeam
        txtBarWidth.Font = New Font("Microsoft Sans Serif", 9.6F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtBarWidth.ForeColor = SystemColors.WindowText
        txtBarWidth.Location = New Point(464, 72)
        txtBarWidth.MaxLength = 0
        txtBarWidth.Name = "txtBarWidth"
        txtBarWidth.RightToLeft = RightToLeft.No
        txtBarWidth.Size = New Size(33, 22)
        txtBarWidth.TabIndex = 4
        txtBarWidth.Text = "1"
        txtBarWidth.TextAlign = HorizontalAlignment.Center
        ToolTipMain.SetToolTip(txtBarWidth, "Width of error bars (number of standard errors)")
        ' 
        ' chkObserved
        ' 
        chkObserved.AllowDrop = True
        chkObserved.BackColor = SystemColors.Control
        chkObserved.Checked = True
        chkObserved.CheckState = CheckState.Checked
        chkObserved.Font = New Font("Microsoft Sans Serif", 9.6F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        chkObserved.ForeColor = SystemColors.ControlText
        chkObserved.Location = New Point(520, 56)
        chkObserved.Name = "chkObserved"
        chkObserved.RightToLeft = RightToLeft.No
        chkObserved.Size = New Size(121, 25)
        chkObserved.TabIndex = 3
        chkObserved.Text = "Plot Observed"
        ToolTipMain.SetToolTip(chkObserved, "Plot observed values")
        chkObserved.UseVisualStyleBackColor = False
        ' 
        ' btnListVar
        ' 
        btnListVar.AllowDrop = True
        btnListVar.BackColor = SystemColors.Control
        commandButtonHelper1.SetCorrectEventsBehavior(btnListVar, True)
        commandButtonHelper1.SetDisabledPicture(btnListVar, Nothing)
        commandButtonHelper1.SetDownPicture(btnListVar, Nothing)
        btnListVar.Font = New Font("Microsoft Sans Serif", 9.6F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnListVar.ForeColor = SystemColors.ControlText
        btnListVar.Location = New Point(248, 64)
        commandButtonHelper1.SetMaskColor(btnListVar, Color.Silver)
        btnListVar.Name = "btnListVar"
        btnListVar.RightToLeft = RightToLeft.No
        btnListVar.Size = New Size(97, 41)
        commandButtonHelper1.SetStyle(btnListVar, 0)
        btnListVar.TabIndex = 1
        btnListVar.Text = "Variable Descriptions"
        btnListVar.TextImageRelation = TextImageRelation.ImageAboveText
        ToolTipMain.SetToolTip(btnListVar, "List discriptions of model output variables that can be plotted")
        btnListVar.UseVisualStyleBackColor = False
        ' 
        ' Toolbar1
        ' 
        Toolbar1.AllowDrop = True
        Toolbar1.Font = New Font("Microsoft Sans Serif", 9.6F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Toolbar1.Items.AddRange(New ToolStripItem() {Toolbar1_Buttons_Button1, Toolbar1_Buttons_Button2, Toolbar1_Buttons_Button3, Toolbar1_Buttons_Button4, Toolbar1_Buttons_Button5})
        Toolbar1.Location = New Point(0, 0)
        Toolbar1.Name = "Toolbar1"
        Toolbar1.Size = New Size(664, 25)
        Toolbar1.TabIndex = 2
        ' 
        ' Toolbar1_Buttons_Button1
        ' 
        Toolbar1_Buttons_Button1.ImageScaling = ToolStripItemImageScaling.None
        Toolbar1_Buttons_Button1.Name = "Toolbar1_Buttons_Button1"
        Toolbar1_Buttons_Button1.Size = New Size(34, 22)
        Toolbar1_Buttons_Button1.Text = "Plot"
        Toolbar1_Buttons_Button1.TextImageRelation = TextImageRelation.ImageAboveText
        Toolbar1_Buttons_Button1.ToolTipText = "View plot for selected variable"
        ' 
        ' Toolbar1_Buttons_Button2
        ' 
        Toolbar1_Buttons_Button2.ImageScaling = ToolStripItemImageScaling.None
        Toolbar1_Buttons_Button2.Name = "Toolbar1_Buttons_Button2"
        Toolbar1_Buttons_Button2.Size = New Size(63, 22)
        Toolbar1_Buttons_Button2.Text = "List Data"
        Toolbar1_Buttons_Button2.TextImageRelation = TextImageRelation.ImageAboveText
        Toolbar1_Buttons_Button2.ToolTipText = "List plotted data"
        ' 
        ' Toolbar1_Buttons_Button3
        ' 
        Toolbar1_Buttons_Button3.ImageScaling = ToolStripItemImageScaling.None
        Toolbar1_Buttons_Button3.Name = "Toolbar1_Buttons_Button3"
        Toolbar1_Buttons_Button3.Size = New Size(40, 22)
        Toolbar1_Buttons_Button3.Text = "Help"
        Toolbar1_Buttons_Button3.TextImageRelation = TextImageRelation.ImageAboveText
        Toolbar1_Buttons_Button3.ToolTipText = "Get help"
        ' 
        ' Toolbar1_Buttons_Button4
        ' 
        Toolbar1_Buttons_Button4.ImageScaling = ToolStripItemImageScaling.None
        Toolbar1_Buttons_Button4.Name = "Toolbar1_Buttons_Button4"
        Toolbar1_Buttons_Button4.Size = New Size(77, 22)
        Toolbar1_Buttons_Button4.Text = "Copy Chart"
        Toolbar1_Buttons_Button4.TextImageRelation = TextImageRelation.ImageAboveText
        Toolbar1_Buttons_Button4.ToolTipText = "Copy chart to windows clipboard"
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
        ' Combo1
        ' 
        Combo1.AllowDrop = True
        Combo1.BackColor = SystemColors.Window
        Combo1.DropDownStyle = ComboBoxStyle.DropDownList
        Combo1.Font = New Font("Microsoft Sans Serif", 9.6F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Combo1.ForeColor = SystemColors.WindowText
        Combo1.Location = New Point(8, 72)
        Combo1.Name = "Combo1"
        Combo1.RightToLeft = RightToLeft.No
        Combo1.Size = New Size(217, 24)
        Combo1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AllowDrop = True
        Label1.BackColor = SystemColors.Control
        Label1.Font = New Font("Microsoft Sans Serif", 9.6F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlText
        Label1.Location = New Point(352, 72)
        Label1.MinimumSize = New Size(105, 17)
        Label1.Name = "Label1"
        Label1.RightToLeft = RightToLeft.No
        Label1.Size = New Size(105, 17)
        Label1.TabIndex = 5
        Label1.Text = "Error Bar Width:"
        Label1.TextAlign = ContentAlignment.TopRight
        ' 
        ' Image1
        ' 
        Image1.AllowDrop = True
        Image1.BorderStyle = BorderStyle.Fixed3D
        Image1.Font = New Font("Microsoft Sans Serif", 9.6F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Image1.Location = New Point(8, 120)
        Image1.Name = "Image1"
        Image1.Size = New Size(649, 417)
        Image1.TabIndex = 7
        Image1.TabStop = False
        ' 
        ' frmPlot
        ' 
        AllowDrop = True
        AutoScaleDimensions = New SizeF(8F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(664, 545)
        Controls.Add(chkLogScale)
        Controls.Add(txtBarWidth)
        Controls.Add(chkObserved)
        Controls.Add(Toolbar1)
        Controls.Add(btnListVar)
        Controls.Add(Combo1)
        Controls.Add(Label1)
        Controls.Add(Image1)
        Font = New Font("Microsoft Sans Serif", 9.6F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Location = New Point(4, 24)
        Name = "frmPlot"
        RightToLeft = RightToLeft.No
        Text = "Bathtub Output Plot"
        Toolbar1.ResumeLayout(False)
        Toolbar1.PerformLayout()
        CType(Image1, ComponentModel.ISupportInitialize).EndInit()
        CType(commandButtonHelper1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Sub ReLoadForm(ByVal addEvents As Boolean)
		form_initialize()
		If addEvents Then
			AddHandler MyBase.Closed, AddressOf Form_Closed
			AddHandler Activated, AddressOf frmPlot_Activated
		End If
	End Sub
#End Region
End Class