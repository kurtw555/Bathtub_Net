<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModels
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As frmModels
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As frmModels
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = CreateInstance()
				m_InitializingDefInstance = False
			End If
			Return m_vb6FormDefInstance
		End Get
		Set(ByVal Value As frmModels)
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region
#Region "Windows Form Designer generated code "
	Public Shared Function CreateInstance() As frmModels
		Dim theInstance As New frmModels()
		theInstance.Form_Load()
		Return theInstance
	End Function
	Private visualControls() As String = New String() {"components", "ToolTipMain", "_Combo1_11", "_Combo1_10", "_Combo1_9", "_Combo1_8", "_Combo1_7", "_Combo1_6", "_Combo1_5", "_Combo1_4", "_Combo1_3", "_Combo1_2", "_Combo1_1", "_Combo1_0", "Toolbar1_Buttons_Button1", "Toolbar1_Buttons_Button2", "Toolbar1_Buttons_Button3", "Toolbar1_Buttons_Button4", "Toolbar1_Buttons_Button5", "Toolbar1", "Label2", "_Label1_11", "_Label1_10", "_Label1_9", "_Label1_8", "_Label1_7", "_Label1_6", "_Label1_5", "_Label1_4", "_Label1_3", "_Label1_2", "_Label1_1", "_Label1_0", "Combo1", "Label1"}
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTipMain As System.Windows.Forms.ToolTip
	Private WithEvents _Combo1_11 As System.Windows.Forms.ComboBox
	Private WithEvents _Combo1_10 As System.Windows.Forms.ComboBox
	Private WithEvents _Combo1_9 As System.Windows.Forms.ComboBox
	Private WithEvents _Combo1_8 As System.Windows.Forms.ComboBox
	Private WithEvents _Combo1_7 As System.Windows.Forms.ComboBox
	Private WithEvents _Combo1_6 As System.Windows.Forms.ComboBox
	Private WithEvents _Combo1_5 As System.Windows.Forms.ComboBox
	Private WithEvents _Combo1_4 As System.Windows.Forms.ComboBox
	Private WithEvents _Combo1_3 As System.Windows.Forms.ComboBox
	Private WithEvents _Combo1_2 As System.Windows.Forms.ComboBox
	Private WithEvents _Combo1_1 As System.Windows.Forms.ComboBox
	Private WithEvents _Combo1_0 As System.Windows.Forms.ComboBox
	Public WithEvents Toolbar1_Buttons_Button1 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Buttons_Button2 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Buttons_Button3 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Buttons_Button4 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Buttons_Button5 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1 As System.Windows.Forms.ToolStrip
	Public WithEvents Label2 As System.Windows.Forms.Label
	Private WithEvents _Label1_11 As System.Windows.Forms.Label
	Private WithEvents _Label1_10 As System.Windows.Forms.Label
	Private WithEvents _Label1_9 As System.Windows.Forms.Label
	Private WithEvents _Label1_8 As System.Windows.Forms.Label
	Private WithEvents _Label1_7 As System.Windows.Forms.Label
	Private WithEvents _Label1_6 As System.Windows.Forms.Label
	Private WithEvents _Label1_5 As System.Windows.Forms.Label
	Private WithEvents _Label1_4 As System.Windows.Forms.Label
	Private WithEvents _Label1_3 As System.Windows.Forms.Label
	Private WithEvents _Label1_2 As System.Windows.Forms.Label
	Private WithEvents _Label1_1 As System.Windows.Forms.Label
	Private WithEvents _Label1_0 As System.Windows.Forms.Label
	Public Combo1(11) As System.Windows.Forms.ComboBox
	Public Label1(11) As System.Windows.Forms.Label
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        ToolTipMain = New ToolTip(components)
        _Combo1_11 = New ComboBox()
        _Combo1_10 = New ComboBox()
        _Combo1_9 = New ComboBox()
        _Combo1_8 = New ComboBox()
        _Combo1_7 = New ComboBox()
        _Combo1_6 = New ComboBox()
        _Combo1_5 = New ComboBox()
        _Combo1_4 = New ComboBox()
        _Combo1_3 = New ComboBox()
        _Combo1_2 = New ComboBox()
        _Combo1_1 = New ComboBox()
        _Combo1_0 = New ComboBox()
        Toolbar1 = New ToolStrip()
        Toolbar1_Buttons_Button1 = New ToolStripButton()
        Toolbar1_Buttons_Button2 = New ToolStripButton()
        Toolbar1_Buttons_Button3 = New ToolStripButton()
        Toolbar1_Buttons_Button4 = New ToolStripButton()
        Toolbar1_Buttons_Button5 = New ToolStripButton()
        Label2 = New Label()
        _Label1_11 = New Label()
        _Label1_10 = New Label()
        _Label1_9 = New Label()
        _Label1_8 = New Label()
        _Label1_7 = New Label()
        _Label1_6 = New Label()
        _Label1_5 = New Label()
        _Label1_4 = New Label()
        _Label1_3 = New Label()
        _Label1_2 = New Label()
        _Label1_1 = New Label()
        _Label1_0 = New Label()
        Toolbar1.SuspendLayout()
        SuspendLayout()
        ' 
        ' _Combo1_11
        ' 
        _Combo1_11.AllowDrop = True
        _Combo1_11.BackColor = SystemColors.Window
        _Combo1_11.DropDownStyle = ComboBoxStyle.DropDownList
        _Combo1_11.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _Combo1_11.ForeColor = SystemColors.WindowText
        _Combo1_11.Location = New Point(552, 249)
        _Combo1_11.Name = "_Combo1_11"
        _Combo1_11.RightToLeft = RightToLeft.No
        _Combo1_11.Size = New Size(217, 24)
        _Combo1_11.TabIndex = 23
        ' 
        ' _Combo1_10
        ' 
        _Combo1_10.AllowDrop = True
        _Combo1_10.BackColor = SystemColors.Window
        _Combo1_10.DropDownStyle = ComboBoxStyle.DropDownList
        _Combo1_10.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _Combo1_10.ForeColor = SystemColors.WindowText
        _Combo1_10.Location = New Point(552, 209)
        _Combo1_10.Name = "_Combo1_10"
        _Combo1_10.RightToLeft = RightToLeft.No
        _Combo1_10.Size = New Size(217, 24)
        _Combo1_10.TabIndex = 21
        ' 
        ' _Combo1_9
        ' 
        _Combo1_9.AllowDrop = True
        _Combo1_9.BackColor = SystemColors.Window
        _Combo1_9.DropDownStyle = ComboBoxStyle.DropDownList
        _Combo1_9.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _Combo1_9.ForeColor = SystemColors.WindowText
        _Combo1_9.Location = New Point(552, 169)
        _Combo1_9.Name = "_Combo1_9"
        _Combo1_9.RightToLeft = RightToLeft.No
        _Combo1_9.Size = New Size(217, 24)
        _Combo1_9.TabIndex = 19
        ' 
        ' _Combo1_8
        ' 
        _Combo1_8.AllowDrop = True
        _Combo1_8.BackColor = SystemColors.Window
        _Combo1_8.DropDownStyle = ComboBoxStyle.DropDownList
        _Combo1_8.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _Combo1_8.ForeColor = SystemColors.WindowText
        _Combo1_8.Location = New Point(552, 129)
        _Combo1_8.Name = "_Combo1_8"
        _Combo1_8.RightToLeft = RightToLeft.No
        _Combo1_8.Size = New Size(217, 24)
        _Combo1_8.TabIndex = 17
        ' 
        ' _Combo1_7
        ' 
        _Combo1_7.AllowDrop = True
        _Combo1_7.BackColor = SystemColors.Window
        _Combo1_7.DropDownStyle = ComboBoxStyle.DropDownList
        _Combo1_7.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _Combo1_7.ForeColor = SystemColors.WindowText
        _Combo1_7.Location = New Point(552, 89)
        _Combo1_7.Name = "_Combo1_7"
        _Combo1_7.RightToLeft = RightToLeft.No
        _Combo1_7.Size = New Size(217, 24)
        _Combo1_7.TabIndex = 15
        ' 
        ' _Combo1_6
        ' 
        _Combo1_6.AllowDrop = True
        _Combo1_6.BackColor = SystemColors.Window
        _Combo1_6.DropDownStyle = ComboBoxStyle.DropDownList
        _Combo1_6.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _Combo1_6.ForeColor = SystemColors.WindowText
        _Combo1_6.Location = New Point(552, 49)
        _Combo1_6.Name = "_Combo1_6"
        _Combo1_6.RightToLeft = RightToLeft.No
        _Combo1_6.Size = New Size(217, 24)
        _Combo1_6.TabIndex = 13
        ' 
        ' _Combo1_5
        ' 
        _Combo1_5.AllowDrop = True
        _Combo1_5.BackColor = SystemColors.Window
        _Combo1_5.DropDownStyle = ComboBoxStyle.DropDownList
        _Combo1_5.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _Combo1_5.ForeColor = SystemColors.WindowText
        _Combo1_5.Location = New Point(176, 249)
        _Combo1_5.Name = "_Combo1_5"
        _Combo1_5.RightToLeft = RightToLeft.No
        _Combo1_5.Size = New Size(217, 24)
        _Combo1_5.TabIndex = 11
        ' 
        ' _Combo1_4
        ' 
        _Combo1_4.AllowDrop = True
        _Combo1_4.BackColor = SystemColors.Window
        _Combo1_4.DropDownStyle = ComboBoxStyle.DropDownList
        _Combo1_4.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _Combo1_4.ForeColor = SystemColors.WindowText
        _Combo1_4.Location = New Point(176, 209)
        _Combo1_4.Name = "_Combo1_4"
        _Combo1_4.RightToLeft = RightToLeft.No
        _Combo1_4.Size = New Size(217, 24)
        _Combo1_4.TabIndex = 9
        ' 
        ' _Combo1_3
        ' 
        _Combo1_3.AllowDrop = True
        _Combo1_3.BackColor = SystemColors.Window
        _Combo1_3.DropDownStyle = ComboBoxStyle.DropDownList
        _Combo1_3.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _Combo1_3.ForeColor = SystemColors.WindowText
        _Combo1_3.Location = New Point(176, 169)
        _Combo1_3.Name = "_Combo1_3"
        _Combo1_3.RightToLeft = RightToLeft.No
        _Combo1_3.Size = New Size(217, 24)
        _Combo1_3.TabIndex = 7
        ' 
        ' _Combo1_2
        ' 
        _Combo1_2.AllowDrop = True
        _Combo1_2.BackColor = SystemColors.Window
        _Combo1_2.DropDownStyle = ComboBoxStyle.DropDownList
        _Combo1_2.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _Combo1_2.ForeColor = SystemColors.WindowText
        _Combo1_2.Location = New Point(176, 129)
        _Combo1_2.Name = "_Combo1_2"
        _Combo1_2.RightToLeft = RightToLeft.No
        _Combo1_2.Size = New Size(217, 24)
        _Combo1_2.TabIndex = 5
        ' 
        ' _Combo1_1
        ' 
        _Combo1_1.AllowDrop = True
        _Combo1_1.BackColor = SystemColors.Window
        _Combo1_1.DropDownStyle = ComboBoxStyle.DropDownList
        _Combo1_1.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _Combo1_1.ForeColor = SystemColors.WindowText
        _Combo1_1.Location = New Point(176, 89)
        _Combo1_1.Name = "_Combo1_1"
        _Combo1_1.RightToLeft = RightToLeft.No
        _Combo1_1.Size = New Size(217, 24)
        _Combo1_1.TabIndex = 3
        ' 
        ' _Combo1_0
        ' 
        _Combo1_0.AllowDrop = True
        _Combo1_0.BackColor = SystemColors.Window
        _Combo1_0.DropDownStyle = ComboBoxStyle.DropDownList
        _Combo1_0.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _Combo1_0.ForeColor = SystemColors.WindowText
        _Combo1_0.Location = New Point(176, 49)
        _Combo1_0.Name = "_Combo1_0"
        _Combo1_0.RightToLeft = RightToLeft.No
        _Combo1_0.Size = New Size(217, 24)
        _Combo1_0.TabIndex = 1
        ' 
        ' Toolbar1
        ' 
        Toolbar1.AllowDrop = True
        Toolbar1.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Toolbar1.Items.AddRange(New ToolStripItem() {Toolbar1_Buttons_Button1, Toolbar1_Buttons_Button2, Toolbar1_Buttons_Button3, Toolbar1_Buttons_Button4, Toolbar1_Buttons_Button5})
        Toolbar1.Location = New Point(0, 0)
        Toolbar1.Name = "Toolbar1"
        Toolbar1.Size = New Size(789, 25)
        Toolbar1.TabIndex = 0
        ' 
        ' Toolbar1_Buttons_Button1
        ' 
        Toolbar1_Buttons_Button1.ImageScaling = ToolStripItemImageScaling.None
        Toolbar1_Buttons_Button1.Name = "Toolbar1_Buttons_Button1"
        Toolbar1_Buttons_Button1.Size = New Size(60, 22)
        Toolbar1_Buttons_Button1.Text = "Defaults"
        Toolbar1_Buttons_Button1.TextImageRelation = TextImageRelation.ImageAboveText
        Toolbar1_Buttons_Button1.ToolTipText = "Assign default values to all input values"
        ' 
        ' Toolbar1_Buttons_Button2
        ' 
        Toolbar1_Buttons_Button2.ImageScaling = ToolStripItemImageScaling.None
        Toolbar1_Buttons_Button2.Name = "Toolbar1_Buttons_Button2"
        Toolbar1_Buttons_Button2.Size = New Size(44, 22)
        Toolbar1_Buttons_Button2.Text = "Undo"
        Toolbar1_Buttons_Button2.TextImageRelation = TextImageRelation.ImageAboveText
        Toolbar1_Buttons_Button2.ToolTipText = "Restore initial values"
        ' 
        ' Toolbar1_Buttons_Button3
        ' 
        Toolbar1_Buttons_Button3.ImageScaling = ToolStripItemImageScaling.None
        Toolbar1_Buttons_Button3.Name = "Toolbar1_Buttons_Button3"
        Toolbar1_Buttons_Button3.Size = New Size(40, 22)
        Toolbar1_Buttons_Button3.Text = "Help"
        Toolbar1_Buttons_Button3.TextImageRelation = TextImageRelation.ImageAboveText
        Toolbar1_Buttons_Button3.ToolTipText = "Get Help"
        ' 
        ' Toolbar1_Buttons_Button4
        ' 
        Toolbar1_Buttons_Button4.ImageScaling = ToolStripItemImageScaling.None
        Toolbar1_Buttons_Button4.Name = "Toolbar1_Buttons_Button4"
        Toolbar1_Buttons_Button4.Size = New Size(53, 22)
        Toolbar1_Buttons_Button4.Text = "Cancel"
        Toolbar1_Buttons_Button4.TextImageRelation = TextImageRelation.ImageAboveText
        Toolbar1_Buttons_Button4.ToolTipText = "Ignore edits & return to menu"
        ' 
        ' Toolbar1_Buttons_Button5
        ' 
        Toolbar1_Buttons_Button5.ImageScaling = ToolStripItemImageScaling.None
        Toolbar1_Buttons_Button5.Name = "Toolbar1_Buttons_Button5"
        Toolbar1_Buttons_Button5.Size = New Size(29, 22)
        Toolbar1_Buttons_Button5.Text = "OK"
        Toolbar1_Buttons_Button5.TextImageRelation = TextImageRelation.ImageAboveText
        Toolbar1_Buttons_Button5.ToolTipText = "Save edits & return to program menu"
        ' 
        ' Label2
        ' 
        Label2.AllowDrop = True
        Label2.BackColor = SystemColors.Control
        Label2.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.Highlight
        Label2.Location = New Point(240, 296)
        Label2.MinimumSize = New Size(329, 25)
        Label2.Name = "Label2"
        Label2.RightToLeft = RightToLeft.No
        Label2.Size = New Size(329, 25)
        Label2.TabIndex = 25
        Label2.Text = "Select Box and Hit F1 to Get Help,    *=Default"
        Label2.TextAlign = ContentAlignment.TopCenter
        ' 
        ' _Label1_11
        ' 
        _Label1_11.AllowDrop = True
        _Label1_11.BackColor = SystemColors.Control
        _Label1_11.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _Label1_11.ForeColor = SystemColors.ControlText
        _Label1_11.Location = New Point(408, 256)
        _Label1_11.MinimumSize = New Size(147, 17)
        _Label1_11.Name = "_Label1_11"
        _Label1_11.RightToLeft = RightToLeft.No
        _Label1_11.Size = New Size(147, 17)
        _Label1_11.TabIndex = 24
        _Label1_11.Text = "Output Destination"
        ' 
        ' _Label1_10
        ' 
        _Label1_10.AllowDrop = True
        _Label1_10.BackColor = SystemColors.Control
        _Label1_10.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _Label1_10.ForeColor = SystemColors.ControlText
        _Label1_10.Location = New Point(408, 216)
        _Label1_10.MinimumSize = New Size(147, 17)
        _Label1_10.Name = "_Label1_10"
        _Label1_10.RightToLeft = RightToLeft.No
        _Label1_10.Size = New Size(147, 17)
        _Label1_10.TabIndex = 22
        _Label1_10.Text = "Mass Balance Tables"
        ' 
        ' _Label1_9
        ' 
        _Label1_9.AllowDrop = True
        _Label1_9.BackColor = SystemColors.Control
        _Label1_9.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _Label1_9.ForeColor = SystemColors.ControlText
        _Label1_9.Location = New Point(408, 176)
        _Label1_9.MinimumSize = New Size(147, 17)
        _Label1_9.Name = "_Label1_9"
        _Label1_9.RightToLeft = RightToLeft.No
        _Label1_9.Size = New Size(147, 17)
        _Label1_9.TabIndex = 20
        _Label1_9.Text = "Availability Factors"
        ' 
        ' _Label1_8
        ' 
        _Label1_8.AllowDrop = True
        _Label1_8.BackColor = SystemColors.Control
        _Label1_8.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _Label1_8.ForeColor = SystemColors.ControlText
        _Label1_8.Location = New Point(408, 136)
        _Label1_8.MinimumSize = New Size(147, 17)
        _Label1_8.Name = "_Label1_8"
        _Label1_8.RightToLeft = RightToLeft.No
        _Label1_8.Size = New Size(147, 17)
        _Label1_8.TabIndex = 18
        _Label1_8.Text = "Error Analysis"
        ' 
        ' _Label1_7
        ' 
        _Label1_7.AllowDrop = True
        _Label1_7.BackColor = SystemColors.Control
        _Label1_7.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _Label1_7.ForeColor = SystemColors.ControlText
        _Label1_7.Location = New Point(408, 96)
        _Label1_7.MinimumSize = New Size(147, 17)
        _Label1_7.Name = "_Label1_7"
        _Label1_7.RightToLeft = RightToLeft.No
        _Label1_7.Size = New Size(147, 17)
        _Label1_7.TabIndex = 16
        _Label1_7.Text = "Nitrogen Calibration "
        ' 
        ' _Label1_6
        ' 
        _Label1_6.AllowDrop = True
        _Label1_6.BackColor = SystemColors.Control
        _Label1_6.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _Label1_6.ForeColor = SystemColors.ControlText
        _Label1_6.Location = New Point(408, 56)
        _Label1_6.MinimumSize = New Size(147, 17)
        _Label1_6.Name = "_Label1_6"
        _Label1_6.RightToLeft = RightToLeft.No
        _Label1_6.Size = New Size(147, 17)
        _Label1_6.TabIndex = 14
        _Label1_6.Text = "Phosphorus Calibration "
        ' 
        ' _Label1_5
        ' 
        _Label1_5.AllowDrop = True
        _Label1_5.BackColor = SystemColors.Control
        _Label1_5.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _Label1_5.ForeColor = SystemColors.ControlText
        _Label1_5.Location = New Point(16, 256)
        _Label1_5.MinimumSize = New Size(160, 17)
        _Label1_5.Name = "_Label1_5"
        _Label1_5.RightToLeft = RightToLeft.No
        _Label1_5.Size = New Size(160, 17)
        _Label1_5.TabIndex = 12
        _Label1_5.Text = "Longitudinal Dispersion"
        ' 
        ' _Label1_4
        ' 
        _Label1_4.AllowDrop = True
        _Label1_4.BackColor = SystemColors.Control
        _Label1_4.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _Label1_4.ForeColor = SystemColors.ControlText
        _Label1_4.Location = New Point(16, 216)
        _Label1_4.MinimumSize = New Size(160, 17)
        _Label1_4.Name = "_Label1_4"
        _Label1_4.RightToLeft = RightToLeft.No
        _Label1_4.Size = New Size(160, 17)
        _Label1_4.TabIndex = 10
        _Label1_4.Text = "Transparency"
        ' 
        ' _Label1_3
        ' 
        _Label1_3.AllowDrop = True
        _Label1_3.BackColor = SystemColors.Control
        _Label1_3.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _Label1_3.ForeColor = SystemColors.ControlText
        _Label1_3.Location = New Point(16, 176)
        _Label1_3.MinimumSize = New Size(160, 17)
        _Label1_3.Name = "_Label1_3"
        _Label1_3.RightToLeft = RightToLeft.No
        _Label1_3.Size = New Size(160, 17)
        _Label1_3.TabIndex = 8
        _Label1_3.Text = "Chlorophyll-a"
        ' 
        ' _Label1_2
        ' 
        _Label1_2.AllowDrop = True
        _Label1_2.BackColor = SystemColors.Control
        _Label1_2.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _Label1_2.ForeColor = SystemColors.ControlText
        _Label1_2.Location = New Point(16, 136)
        _Label1_2.MinimumSize = New Size(160, 17)
        _Label1_2.Name = "_Label1_2"
        _Label1_2.RightToLeft = RightToLeft.No
        _Label1_2.Size = New Size(160, 17)
        _Label1_2.TabIndex = 6
        _Label1_2.Text = "Total Nitrogen"
        ' 
        ' _Label1_1
        ' 
        _Label1_1.AllowDrop = True
        _Label1_1.BackColor = SystemColors.Control
        _Label1_1.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _Label1_1.ForeColor = SystemColors.ControlText
        _Label1_1.Location = New Point(16, 96)
        _Label1_1.MinimumSize = New Size(160, 17)
        _Label1_1.Name = "_Label1_1"
        _Label1_1.RightToLeft = RightToLeft.No
        _Label1_1.Size = New Size(160, 17)
        _Label1_1.TabIndex = 4
        _Label1_1.Text = "Total Phosphorus"
        ' 
        ' _Label1_0
        ' 
        _Label1_0.AllowDrop = True
        _Label1_0.BackColor = SystemColors.Control
        _Label1_0.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        _Label1_0.ForeColor = SystemColors.ControlText
        _Label1_0.Location = New Point(16, 56)
        _Label1_0.MinimumSize = New Size(160, 17)
        _Label1_0.Name = "_Label1_0"
        _Label1_0.RightToLeft = RightToLeft.No
        _Label1_0.Size = New Size(160, 17)
        _Label1_0.TabIndex = 2
        _Label1_0.Text = "Conservative Substance"
        ' 
        ' frmModels
        ' 
        AllowDrop = True
        AutoScaleDimensions = New SizeF(8F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(789, 342)
        Controls.Add(_Combo1_11)
        Controls.Add(_Combo1_10)
        Controls.Add(_Combo1_9)
        Controls.Add(_Combo1_8)
        Controls.Add(_Combo1_7)
        Controls.Add(_Combo1_6)
        Controls.Add(_Combo1_5)
        Controls.Add(_Combo1_4)
        Controls.Add(_Combo1_3)
        Controls.Add(_Combo1_2)
        Controls.Add(_Combo1_1)
        Controls.Add(_Combo1_0)
        Controls.Add(Toolbar1)
        Controls.Add(Label2)
        Controls.Add(_Label1_11)
        Controls.Add(_Label1_10)
        Controls.Add(_Label1_9)
        Controls.Add(_Label1_8)
        Controls.Add(_Label1_7)
        Controls.Add(_Label1_6)
        Controls.Add(_Label1_5)
        Controls.Add(_Label1_4)
        Controls.Add(_Label1_3)
        Controls.Add(_Label1_2)
        Controls.Add(_Label1_1)
        Controls.Add(_Label1_0)
        Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Location = New Point(4, 23)
        Name = "frmModels"
        RightToLeft = RightToLeft.No
        Text = "Select Models"
        Toolbar1.ResumeLayout(False)
        Toolbar1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Sub ReLoadForm(ByVal addEvents As Boolean)
		InitializeLabel1()
		InitializeCombo1()
		If addEvents Then
			AddHandler MyBase.Closed, AddressOf Form_Closed
			AddHandler Activated, AddressOf frmModels_Activated
		End If
	End Sub
	Sub InitializeLabel1()
		ReDim Label1(11)
		Label1(11) = _Label1_11
		Label1(10) = _Label1_10
		Label1(9) = _Label1_9
		Label1(8) = _Label1_8
		Label1(7) = _Label1_7
		Label1(6) = _Label1_6
		Label1(5) = _Label1_5
		Label1(4) = _Label1_4
		Label1(3) = _Label1_3
		Label1(2) = _Label1_2
		Label1(1) = _Label1_1
		Label1(0) = _Label1_0
	End Sub
	Sub InitializeCombo1()
		ReDim Combo1(11)
		Combo1(11) = _Combo1_11
		Combo1(10) = _Combo1_10
		Combo1(9) = _Combo1_9
		Combo1(8) = _Combo1_8
		Combo1(7) = _Combo1_7
		Combo1(6) = _Combo1_6
		Combo1(5) = _Combo1_5
		Combo1(4) = _Combo1_4
		Combo1(3) = _Combo1_3
		Combo1(2) = _Combo1_2
		Combo1(1) = _Combo1_1
		Combo1(0) = _Combo1_0
	End Sub
#End Region
End Class