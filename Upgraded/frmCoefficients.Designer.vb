<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCoefficients
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As frmCoefficients
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As frmCoefficients
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = CreateInstance()
				m_InitializingDefInstance = False
			End If
			Return m_vb6FormDefInstance
		End Get
		Set(ByVal Value As frmCoefficients)
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region
#Region "Windows Form Designer generated code "
	Public Shared Function CreateInstance() As frmCoefficients
		Dim theInstance As New frmCoefficients()
		theInstance.Form_Load()
		Return theInstance
	End Function
	Private visualControls() As String = New String() {"components", "ToolTipMain", "_Text1_11", "_Text1_28", "_Text1_0", "_Text1_1", "_Text1_2", "_Text1_3", "_Text1_4", "_Text1_5", "_Text1_6", "_Text1_7", "_Text1_8", "_Text1_9", "_Text1_10", "_Text1_12", "_Text1_27", "_Text1_26", "_Text1_25", "_Text1_24", "_Text1_23", "_Text1_22", "_Text1_21", "_Text1_20", "_Text1_19", "_Text1_18", "_Text1_17", "_Text1_16", "_Text1_15", "_Text1_14", "_Text1_13", "Toolbar1_Buttons_Button1", "Toolbar1_Buttons_Button2", "Toolbar1_Buttons_Button3", "Toolbar1_Buttons_Button4", "Toolbar1_Buttons_Button5", "Toolbar1", "_Label1_19", "_Label1_13", "lblDefinitions", "_Label1_10", "_Label1_7", "_Label1_18", "_Label1_17", "_Label1_16", "_Label1_15", "_Label1_14", "_Label1_12", "_Label1_11", "_Label1_9", "_Label1_8", "_Label1_6", "_Label1_5", "_Label1_4", "_Label1_3", "_Label1_2", "_Label1_1", "_Label1_0", "Label1", "Text1"}
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTipMain As System.Windows.Forms.ToolTip
	Private WithEvents _Text1_11 As System.Windows.Forms.TextBox
	Private WithEvents _Text1_28 As System.Windows.Forms.TextBox
	Private WithEvents _Text1_0 As System.Windows.Forms.TextBox
	Private WithEvents _Text1_1 As System.Windows.Forms.TextBox
	Private WithEvents _Text1_2 As System.Windows.Forms.TextBox
	Private WithEvents _Text1_3 As System.Windows.Forms.TextBox
	Private WithEvents _Text1_4 As System.Windows.Forms.TextBox
	Private WithEvents _Text1_5 As System.Windows.Forms.TextBox
	Private WithEvents _Text1_6 As System.Windows.Forms.TextBox
	Private WithEvents _Text1_7 As System.Windows.Forms.TextBox
	Private WithEvents _Text1_8 As System.Windows.Forms.TextBox
	Private WithEvents _Text1_9 As System.Windows.Forms.TextBox
	Private WithEvents _Text1_10 As System.Windows.Forms.TextBox
	Private WithEvents _Text1_12 As System.Windows.Forms.TextBox
	Private WithEvents _Text1_27 As System.Windows.Forms.TextBox
	Private WithEvents _Text1_26 As System.Windows.Forms.TextBox
	Private WithEvents _Text1_25 As System.Windows.Forms.TextBox
	Private WithEvents _Text1_24 As System.Windows.Forms.TextBox
	Private WithEvents _Text1_23 As System.Windows.Forms.TextBox
	Private WithEvents _Text1_22 As System.Windows.Forms.TextBox
	Private WithEvents _Text1_21 As System.Windows.Forms.TextBox
	Private WithEvents _Text1_20 As System.Windows.Forms.TextBox
	Private WithEvents _Text1_19 As System.Windows.Forms.TextBox
	Private WithEvents _Text1_18 As System.Windows.Forms.TextBox
	Private WithEvents _Text1_17 As System.Windows.Forms.TextBox
	Private WithEvents _Text1_16 As System.Windows.Forms.TextBox
	Private WithEvents _Text1_15 As System.Windows.Forms.TextBox
	Private WithEvents _Text1_14 As System.Windows.Forms.TextBox
	Private WithEvents _Text1_13 As System.Windows.Forms.TextBox
	Public WithEvents Toolbar1_Buttons_Button1 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Buttons_Button2 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Buttons_Button3 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Buttons_Button4 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Buttons_Button5 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1 As System.Windows.Forms.ToolStrip
	Private WithEvents _Label1_19 As System.Windows.Forms.Label
	Private WithEvents _Label1_13 As System.Windows.Forms.Label
	Public WithEvents lblDefinitions As System.Windows.Forms.Label
	Private WithEvents _Label1_10 As System.Windows.Forms.Label
	Private WithEvents _Label1_7 As System.Windows.Forms.Label
	Private WithEvents _Label1_18 As System.Windows.Forms.Label
	Private WithEvents _Label1_17 As System.Windows.Forms.Label
	Private WithEvents _Label1_16 As System.Windows.Forms.Label
	Private WithEvents _Label1_15 As System.Windows.Forms.Label
	Private WithEvents _Label1_14 As System.Windows.Forms.Label
	Private WithEvents _Label1_12 As System.Windows.Forms.Label
	Private WithEvents _Label1_11 As System.Windows.Forms.Label
	Private WithEvents _Label1_9 As System.Windows.Forms.Label
	Private WithEvents _Label1_8 As System.Windows.Forms.Label
	Private WithEvents _Label1_6 As System.Windows.Forms.Label
	Private WithEvents _Label1_5 As System.Windows.Forms.Label
	Private WithEvents _Label1_4 As System.Windows.Forms.Label
	Private WithEvents _Label1_3 As System.Windows.Forms.Label
	Private WithEvents _Label1_2 As System.Windows.Forms.Label
	Private WithEvents _Label1_1 As System.Windows.Forms.Label
	Private WithEvents _Label1_0 As System.Windows.Forms.Label
	Public Label1(19) As System.Windows.Forms.Label
	Public Text1(28) As System.Windows.Forms.TextBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	 Private Sub InitializeComponent()
		components = New System.ComponentModel.Container()
		Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(frmCoefficients))
		ToolTipMain = New System.Windows.Forms.ToolTip(components)
		_Text1_11 = New System.Windows.Forms.TextBox()
		_Text1_28 = New System.Windows.Forms.TextBox()
		_Text1_0 = New System.Windows.Forms.TextBox()
		_Text1_1 = New System.Windows.Forms.TextBox()
		_Text1_2 = New System.Windows.Forms.TextBox()
		_Text1_3 = New System.Windows.Forms.TextBox()
		_Text1_4 = New System.Windows.Forms.TextBox()
		_Text1_5 = New System.Windows.Forms.TextBox()
		_Text1_6 = New System.Windows.Forms.TextBox()
		_Text1_7 = New System.Windows.Forms.TextBox()
		_Text1_8 = New System.Windows.Forms.TextBox()
		_Text1_9 = New System.Windows.Forms.TextBox()
		_Text1_10 = New System.Windows.Forms.TextBox()
		_Text1_12 = New System.Windows.Forms.TextBox()
		_Text1_27 = New System.Windows.Forms.TextBox()
		_Text1_26 = New System.Windows.Forms.TextBox()
		_Text1_25 = New System.Windows.Forms.TextBox()
		_Text1_24 = New System.Windows.Forms.TextBox()
		_Text1_23 = New System.Windows.Forms.TextBox()
		_Text1_22 = New System.Windows.Forms.TextBox()
		_Text1_21 = New System.Windows.Forms.TextBox()
		_Text1_20 = New System.Windows.Forms.TextBox()
		_Text1_19 = New System.Windows.Forms.TextBox()
		_Text1_18 = New System.Windows.Forms.TextBox()
		_Text1_17 = New System.Windows.Forms.TextBox()
		_Text1_16 = New System.Windows.Forms.TextBox()
		_Text1_15 = New System.Windows.Forms.TextBox()
		_Text1_14 = New System.Windows.Forms.TextBox()
		_Text1_13 = New System.Windows.Forms.TextBox()
		Toolbar1 = New System.Windows.Forms.ToolStrip()
		Toolbar1_Buttons_Button1 = New System.Windows.Forms.ToolStripButton()
		Toolbar1_Buttons_Button2 = New System.Windows.Forms.ToolStripButton()
		Toolbar1_Buttons_Button3 = New System.Windows.Forms.ToolStripButton()
		Toolbar1_Buttons_Button4 = New System.Windows.Forms.ToolStripButton()
		Toolbar1_Buttons_Button5 = New System.Windows.Forms.ToolStripButton()
		_Label1_19 = New System.Windows.Forms.Label()
		_Label1_13 = New System.Windows.Forms.Label()
		lblDefinitions = New System.Windows.Forms.Label()
		_Label1_10 = New System.Windows.Forms.Label()
		_Label1_7 = New System.Windows.Forms.Label()
		_Label1_18 = New System.Windows.Forms.Label()
		_Label1_17 = New System.Windows.Forms.Label()
		_Label1_16 = New System.Windows.Forms.Label()
		_Label1_15 = New System.Windows.Forms.Label()
		_Label1_14 = New System.Windows.Forms.Label()
		_Label1_12 = New System.Windows.Forms.Label()
		_Label1_11 = New System.Windows.Forms.Label()
		_Label1_9 = New System.Windows.Forms.Label()
		_Label1_8 = New System.Windows.Forms.Label()
		_Label1_6 = New System.Windows.Forms.Label()
		_Label1_5 = New System.Windows.Forms.Label()
		_Label1_4 = New System.Windows.Forms.Label()
		_Label1_3 = New System.Windows.Forms.Label()
		_Label1_2 = New System.Windows.Forms.Label()
		_Label1_1 = New System.Windows.Forms.Label()
		_Label1_0 = New System.Windows.Forms.Label()
		Toolbar1.SuspendLayout()
		SuspendLayout()
		' 
		'_Text1_11
		' 
		_Text1_11.AcceptsReturn = True
		_Text1_11.AllowDrop = True
		_Text1_11.BackColor = System.Drawing.SystemColors.Window
		_Text1_11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		_Text1_11.Cursor = System.Windows.Forms.Cursors.IBeam
		_Text1_11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Text1_11.ForeColor = System.Drawing.SystemColors.WindowText
		_Text1_11.Location = New System.Drawing.Point(216, 453)
		_Text1_11.MaxLength = 0
		_Text1_11.Name = "_Text1_11"
		_Text1_11.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Text1_11.Size = New System.Drawing.Size(80, 19)
		_Text1_11.TabIndex = 49
		_Text1_11.Text = "Text1"
		_Text1_11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		' 
		'_Text1_28
		' 
		_Text1_28.AcceptsReturn = True
		_Text1_28.AllowDrop = True
		_Text1_28.BackColor = System.Drawing.SystemColors.Window
		_Text1_28.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		_Text1_28.Cursor = System.Windows.Forms.Cursors.IBeam
		_Text1_28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Text1_28.ForeColor = System.Drawing.SystemColors.WindowText
		_Text1_28.Location = New System.Drawing.Point(312, 453)
		_Text1_28.MaxLength = 0
		_Text1_28.Name = "_Text1_28"
		_Text1_28.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Text1_28.Size = New System.Drawing.Size(65, 19)
		_Text1_28.TabIndex = 48
		_Text1_28.Text = "Text1"
		_Text1_28.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		' 
		'_Text1_0
		' 
		_Text1_0.AcceptsReturn = True
		_Text1_0.AllowDrop = True
		_Text1_0.BackColor = System.Drawing.SystemColors.Window
		_Text1_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		_Text1_0.Cursor = System.Windows.Forms.Cursors.IBeam
		_Text1_0.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Text1_0.ForeColor = System.Drawing.SystemColors.WindowText
		_Text1_0.Location = New System.Drawing.Point(216, 112)
		_Text1_0.MaxLength = 0
		_Text1_0.Name = "_Text1_0"
		_Text1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Text1_0.Size = New System.Drawing.Size(80, 19)
		_Text1_0.TabIndex = 46
		_Text1_0.Text = "Text1"
		_Text1_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		' 
		'_Text1_1
		' 
		_Text1_1.AcceptsReturn = True
		_Text1_1.AllowDrop = True
		_Text1_1.BackColor = System.Drawing.SystemColors.Window
		_Text1_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		_Text1_1.Cursor = System.Windows.Forms.Cursors.IBeam
		_Text1_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Text1_1.ForeColor = System.Drawing.SystemColors.WindowText
		_Text1_1.Location = New System.Drawing.Point(216, 143)
		_Text1_1.MaxLength = 0
		_Text1_1.Name = "_Text1_1"
		_Text1_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Text1_1.Size = New System.Drawing.Size(80, 19)
		_Text1_1.TabIndex = 45
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
		_Text1_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Text1_2.ForeColor = System.Drawing.SystemColors.WindowText
		_Text1_2.Location = New System.Drawing.Point(216, 174)
		_Text1_2.MaxLength = 0
		_Text1_2.Name = "_Text1_2"
		_Text1_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Text1_2.Size = New System.Drawing.Size(80, 19)
		_Text1_2.TabIndex = 44
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
		_Text1_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Text1_3.ForeColor = System.Drawing.SystemColors.WindowText
		_Text1_3.Location = New System.Drawing.Point(216, 205)
		_Text1_3.MaxLength = 0
		_Text1_3.Name = "_Text1_3"
		_Text1_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Text1_3.Size = New System.Drawing.Size(80, 19)
		_Text1_3.TabIndex = 43
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
		_Text1_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Text1_4.ForeColor = System.Drawing.SystemColors.WindowText
		_Text1_4.Location = New System.Drawing.Point(216, 236)
		_Text1_4.MaxLength = 0
		_Text1_4.Name = "_Text1_4"
		_Text1_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Text1_4.Size = New System.Drawing.Size(80, 19)
		_Text1_4.TabIndex = 42
		_Text1_4.Text = "Text1"
		_Text1_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
		_Text1_5.Location = New System.Drawing.Point(216, 267)
		_Text1_5.MaxLength = 0
		_Text1_5.Name = "_Text1_5"
		_Text1_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Text1_5.Size = New System.Drawing.Size(80, 19)
		_Text1_5.TabIndex = 41
		_Text1_5.Text = "Text1"
		_Text1_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
		_Text1_6.Location = New System.Drawing.Point(216, 298)
		_Text1_6.MaxLength = 0
		_Text1_6.Name = "_Text1_6"
		_Text1_6.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Text1_6.Size = New System.Drawing.Size(80, 19)
		_Text1_6.TabIndex = 40
		_Text1_6.Text = "Text1"
		_Text1_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		' 
		'_Text1_7
		' 
		_Text1_7.AcceptsReturn = True
		_Text1_7.AllowDrop = True
		_Text1_7.BackColor = System.Drawing.SystemColors.Window
		_Text1_7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		_Text1_7.Cursor = System.Windows.Forms.Cursors.IBeam
		_Text1_7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Text1_7.ForeColor = System.Drawing.SystemColors.WindowText
		_Text1_7.Location = New System.Drawing.Point(216, 329)
		_Text1_7.MaxLength = 0
		_Text1_7.Name = "_Text1_7"
		_Text1_7.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Text1_7.Size = New System.Drawing.Size(80, 19)
		_Text1_7.TabIndex = 39
		_Text1_7.Text = "Text1"
		_Text1_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		' 
		'_Text1_8
		' 
		_Text1_8.AcceptsReturn = True
		_Text1_8.AllowDrop = True
		_Text1_8.BackColor = System.Drawing.SystemColors.Window
		_Text1_8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		_Text1_8.Cursor = System.Windows.Forms.Cursors.IBeam
		_Text1_8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Text1_8.ForeColor = System.Drawing.SystemColors.WindowText
		_Text1_8.Location = New System.Drawing.Point(216, 360)
		_Text1_8.MaxLength = 0
		_Text1_8.Name = "_Text1_8"
		_Text1_8.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Text1_8.Size = New System.Drawing.Size(80, 19)
		_Text1_8.TabIndex = 38
		_Text1_8.Text = "Text1"
		_Text1_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		' 
		'_Text1_9
		' 
		_Text1_9.AcceptsReturn = True
		_Text1_9.AllowDrop = True
		_Text1_9.BackColor = System.Drawing.SystemColors.Window
		_Text1_9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		_Text1_9.Cursor = System.Windows.Forms.Cursors.IBeam
		_Text1_9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Text1_9.ForeColor = System.Drawing.SystemColors.WindowText
		_Text1_9.Location = New System.Drawing.Point(216, 391)
		_Text1_9.MaxLength = 0
		_Text1_9.Name = "_Text1_9"
		_Text1_9.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Text1_9.Size = New System.Drawing.Size(80, 19)
		_Text1_9.TabIndex = 37
		_Text1_9.Text = "Text1"
		_Text1_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		' 
		'_Text1_10
		' 
		_Text1_10.AcceptsReturn = True
		_Text1_10.AllowDrop = True
		_Text1_10.BackColor = System.Drawing.SystemColors.Window
		_Text1_10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		_Text1_10.Cursor = System.Windows.Forms.Cursors.IBeam
		_Text1_10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Text1_10.ForeColor = System.Drawing.SystemColors.WindowText
		_Text1_10.Location = New System.Drawing.Point(216, 422)
		_Text1_10.MaxLength = 0
		_Text1_10.Name = "_Text1_10"
		_Text1_10.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Text1_10.Size = New System.Drawing.Size(80, 19)
		_Text1_10.TabIndex = 36
		_Text1_10.Text = "Text1"
		_Text1_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		' 
		'_Text1_12
		' 
		_Text1_12.AcceptsReturn = True
		_Text1_12.AllowDrop = True
		_Text1_12.BackColor = System.Drawing.SystemColors.Window
		_Text1_12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		_Text1_12.Cursor = System.Windows.Forms.Cursors.IBeam
		_Text1_12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Text1_12.ForeColor = System.Drawing.SystemColors.WindowText
		_Text1_12.Location = New System.Drawing.Point(576, 116)
		_Text1_12.MaxLength = 0
		_Text1_12.Name = "_Text1_12"
		_Text1_12.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Text1_12.Size = New System.Drawing.Size(80, 19)
		_Text1_12.TabIndex = 35
		_Text1_12.Text = "Text1"
		_Text1_12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		' 
		'_Text1_27
		' 
		_Text1_27.AcceptsReturn = True
		_Text1_27.AllowDrop = True
		_Text1_27.BackColor = System.Drawing.SystemColors.Window
		_Text1_27.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		_Text1_27.Cursor = System.Windows.Forms.Cursors.IBeam
		_Text1_27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Text1_27.ForeColor = System.Drawing.SystemColors.WindowText
		_Text1_27.Location = New System.Drawing.Point(312, 422)
		_Text1_27.MaxLength = 0
		_Text1_27.Name = "_Text1_27"
		_Text1_27.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Text1_27.Size = New System.Drawing.Size(65, 19)
		_Text1_27.TabIndex = 11
		_Text1_27.Text = "Text1"
		_Text1_27.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		' 
		'_Text1_26
		' 
		_Text1_26.AcceptsReturn = True
		_Text1_26.AllowDrop = True
		_Text1_26.BackColor = System.Drawing.SystemColors.Window
		_Text1_26.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		_Text1_26.Cursor = System.Windows.Forms.Cursors.IBeam
		_Text1_26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Text1_26.ForeColor = System.Drawing.SystemColors.WindowText
		_Text1_26.Location = New System.Drawing.Point(312, 391)
		_Text1_26.MaxLength = 0
		_Text1_26.Name = "_Text1_26"
		_Text1_26.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Text1_26.Size = New System.Drawing.Size(65, 19)
		_Text1_26.TabIndex = 10
		_Text1_26.Text = "Text1"
		_Text1_26.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		' 
		'_Text1_25
		' 
		_Text1_25.AcceptsReturn = True
		_Text1_25.AllowDrop = True
		_Text1_25.BackColor = System.Drawing.SystemColors.Window
		_Text1_25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		_Text1_25.Cursor = System.Windows.Forms.Cursors.IBeam
		_Text1_25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Text1_25.ForeColor = System.Drawing.SystemColors.WindowText
		_Text1_25.Location = New System.Drawing.Point(312, 360)
		_Text1_25.MaxLength = 0
		_Text1_25.Name = "_Text1_25"
		_Text1_25.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Text1_25.Size = New System.Drawing.Size(65, 19)
		_Text1_25.TabIndex = 9
		_Text1_25.Text = "Text1"
		_Text1_25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		' 
		'_Text1_24
		' 
		_Text1_24.AcceptsReturn = True
		_Text1_24.AllowDrop = True
		_Text1_24.BackColor = System.Drawing.SystemColors.Window
		_Text1_24.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		_Text1_24.Cursor = System.Windows.Forms.Cursors.IBeam
		_Text1_24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Text1_24.ForeColor = System.Drawing.SystemColors.WindowText
		_Text1_24.Location = New System.Drawing.Point(312, 329)
		_Text1_24.MaxLength = 0
		_Text1_24.Name = "_Text1_24"
		_Text1_24.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Text1_24.Size = New System.Drawing.Size(65, 19)
		_Text1_24.TabIndex = 8
		_Text1_24.Text = "Text1"
		_Text1_24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		' 
		'_Text1_23
		' 
		_Text1_23.AcceptsReturn = True
		_Text1_23.AllowDrop = True
		_Text1_23.BackColor = System.Drawing.SystemColors.Window
		_Text1_23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		_Text1_23.Cursor = System.Windows.Forms.Cursors.IBeam
		_Text1_23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Text1_23.ForeColor = System.Drawing.SystemColors.WindowText
		_Text1_23.Location = New System.Drawing.Point(312, 298)
		_Text1_23.MaxLength = 0
		_Text1_23.Name = "_Text1_23"
		_Text1_23.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Text1_23.Size = New System.Drawing.Size(65, 19)
		_Text1_23.TabIndex = 7
		_Text1_23.Text = "Text1"
		_Text1_23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		' 
		'_Text1_22
		' 
		_Text1_22.AcceptsReturn = True
		_Text1_22.AllowDrop = True
		_Text1_22.BackColor = System.Drawing.SystemColors.Window
		_Text1_22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		_Text1_22.Cursor = System.Windows.Forms.Cursors.IBeam
		_Text1_22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Text1_22.ForeColor = System.Drawing.SystemColors.WindowText
		_Text1_22.Location = New System.Drawing.Point(312, 267)
		_Text1_22.MaxLength = 0
		_Text1_22.Name = "_Text1_22"
		_Text1_22.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Text1_22.Size = New System.Drawing.Size(65, 19)
		_Text1_22.TabIndex = 6
		_Text1_22.Text = "Text1"
		_Text1_22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		' 
		'_Text1_21
		' 
		_Text1_21.AcceptsReturn = True
		_Text1_21.AllowDrop = True
		_Text1_21.BackColor = System.Drawing.SystemColors.Window
		_Text1_21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		_Text1_21.Cursor = System.Windows.Forms.Cursors.IBeam
		_Text1_21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Text1_21.ForeColor = System.Drawing.SystemColors.WindowText
		_Text1_21.Location = New System.Drawing.Point(312, 236)
		_Text1_21.MaxLength = 0
		_Text1_21.Name = "_Text1_21"
		_Text1_21.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Text1_21.Size = New System.Drawing.Size(65, 19)
		_Text1_21.TabIndex = 5
		_Text1_21.Text = "Text1"
		_Text1_21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		' 
		'_Text1_20
		' 
		_Text1_20.AcceptsReturn = True
		_Text1_20.AllowDrop = True
		_Text1_20.BackColor = System.Drawing.SystemColors.Window
		_Text1_20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		_Text1_20.Cursor = System.Windows.Forms.Cursors.IBeam
		_Text1_20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Text1_20.ForeColor = System.Drawing.SystemColors.WindowText
		_Text1_20.Location = New System.Drawing.Point(312, 205)
		_Text1_20.MaxLength = 0
		_Text1_20.Name = "_Text1_20"
		_Text1_20.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Text1_20.Size = New System.Drawing.Size(65, 19)
		_Text1_20.TabIndex = 4
		_Text1_20.Text = "Text1"
		_Text1_20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		' 
		'_Text1_19
		' 
		_Text1_19.AcceptsReturn = True
		_Text1_19.AllowDrop = True
		_Text1_19.BackColor = System.Drawing.SystemColors.Window
		_Text1_19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		_Text1_19.Cursor = System.Windows.Forms.Cursors.IBeam
		_Text1_19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Text1_19.ForeColor = System.Drawing.SystemColors.WindowText
		_Text1_19.Location = New System.Drawing.Point(312, 174)
		_Text1_19.MaxLength = 0
		_Text1_19.Name = "_Text1_19"
		_Text1_19.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Text1_19.Size = New System.Drawing.Size(65, 19)
		_Text1_19.TabIndex = 3
		_Text1_19.Text = "Text1"
		_Text1_19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		' 
		'_Text1_18
		' 
		_Text1_18.AcceptsReturn = True
		_Text1_18.AllowDrop = True
		_Text1_18.BackColor = System.Drawing.SystemColors.Window
		_Text1_18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		_Text1_18.Cursor = System.Windows.Forms.Cursors.IBeam
		_Text1_18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Text1_18.ForeColor = System.Drawing.SystemColors.WindowText
		_Text1_18.Location = New System.Drawing.Point(312, 143)
		_Text1_18.MaxLength = 0
		_Text1_18.Name = "_Text1_18"
		_Text1_18.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Text1_18.Size = New System.Drawing.Size(65, 19)
		_Text1_18.TabIndex = 2
		_Text1_18.Text = "Text1"
		_Text1_18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		' 
		'_Text1_17
		' 
		_Text1_17.AcceptsReturn = True
		_Text1_17.AllowDrop = True
		_Text1_17.BackColor = System.Drawing.SystemColors.Window
		_Text1_17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		_Text1_17.Cursor = System.Windows.Forms.Cursors.IBeam
		_Text1_17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Text1_17.ForeColor = System.Drawing.SystemColors.WindowText
		_Text1_17.Location = New System.Drawing.Point(312, 112)
		_Text1_17.MaxLength = 0
		_Text1_17.Name = "_Text1_17"
		_Text1_17.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Text1_17.Size = New System.Drawing.Size(65, 19)
		_Text1_17.TabIndex = 1
		_Text1_17.Text = "Text1"
		_Text1_17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		' 
		'_Text1_16
		' 
		_Text1_16.AcceptsReturn = True
		_Text1_16.AllowDrop = True
		_Text1_16.BackColor = System.Drawing.SystemColors.Window
		_Text1_16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		_Text1_16.Cursor = System.Windows.Forms.Cursors.IBeam
		_Text1_16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Text1_16.ForeColor = System.Drawing.SystemColors.WindowText
		_Text1_16.Location = New System.Drawing.Point(576, 240)
		_Text1_16.MaxLength = 0
		_Text1_16.Name = "_Text1_16"
		_Text1_16.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Text1_16.Size = New System.Drawing.Size(80, 19)
		_Text1_16.TabIndex = 15
		_Text1_16.Text = "Text1"
		_Text1_16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		' 
		'_Text1_15
		' 
		_Text1_15.AcceptsReturn = True
		_Text1_15.AllowDrop = True
		_Text1_15.BackColor = System.Drawing.SystemColors.Window
		_Text1_15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		_Text1_15.Cursor = System.Windows.Forms.Cursors.IBeam
		_Text1_15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Text1_15.ForeColor = System.Drawing.SystemColors.WindowText
		_Text1_15.Location = New System.Drawing.Point(576, 209)
		_Text1_15.MaxLength = 0
		_Text1_15.Name = "_Text1_15"
		_Text1_15.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Text1_15.Size = New System.Drawing.Size(80, 19)
		_Text1_15.TabIndex = 14
		_Text1_15.Text = "Text1"
		_Text1_15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		' 
		'_Text1_14
		' 
		_Text1_14.AcceptsReturn = True
		_Text1_14.AllowDrop = True
		_Text1_14.BackColor = System.Drawing.SystemColors.Window
		_Text1_14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		_Text1_14.Cursor = System.Windows.Forms.Cursors.IBeam
		_Text1_14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Text1_14.ForeColor = System.Drawing.SystemColors.WindowText
		_Text1_14.Location = New System.Drawing.Point(576, 178)
		_Text1_14.MaxLength = 0
		_Text1_14.Name = "_Text1_14"
		_Text1_14.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Text1_14.Size = New System.Drawing.Size(80, 19)
		_Text1_14.TabIndex = 13
		_Text1_14.Text = "Text1"
		_Text1_14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		' 
		'_Text1_13
		' 
		_Text1_13.AcceptsReturn = True
		_Text1_13.AllowDrop = True
		_Text1_13.BackColor = System.Drawing.SystemColors.Window
		_Text1_13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		_Text1_13.Cursor = System.Windows.Forms.Cursors.IBeam
		_Text1_13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Text1_13.ForeColor = System.Drawing.SystemColors.WindowText
		_Text1_13.Location = New System.Drawing.Point(576, 147)
		_Text1_13.MaxLength = 0
		_Text1_13.Name = "_Text1_13"
		_Text1_13.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Text1_13.Size = New System.Drawing.Size(80, 19)
		_Text1_13.TabIndex = 12
		_Text1_13.Text = "Text1"
		_Text1_13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		' 
		'Toolbar1
		' 
		Toolbar1.AllowDrop = True
		Toolbar1.Dock = System.Windows.Forms.DockStyle.Top
		Toolbar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		Toolbar1.Location = New System.Drawing.Point(0, 0)
		Toolbar1.Name = "Toolbar1"
		Toolbar1.ShowItemToolTips = True
		Toolbar1.Size = New System.Drawing.Size(678, 42)
		Toolbar1.TabIndex = 34
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
		Toolbar1_Buttons_Button1.Name = "bthDefaults"
		Toolbar1_Buttons_Button1.Size = New System.Drawing.Size(48, 37)
		Toolbar1_Buttons_Button1.Text = "Defaults"
		Toolbar1_Buttons_Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Toolbar1_Buttons_Button1.ToolTipText = "Assign default values to all input values"
		' 
		'Toolbar1_Buttons_Button2
		' 
		Toolbar1_Buttons_Button2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Toolbar1_Buttons_Button2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Toolbar1_Buttons_Button2.Name = "btnUndo"
		Toolbar1_Buttons_Button2.Size = New System.Drawing.Size(48, 37)
		Toolbar1_Buttons_Button2.Text = "Undo"
		Toolbar1_Buttons_Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Toolbar1_Buttons_Button2.ToolTipText = "Restore initial values"
		' 
		'Toolbar1_Buttons_Button3
		' 
		Toolbar1_Buttons_Button3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Toolbar1_Buttons_Button3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Toolbar1_Buttons_Button3.Name = "btnHelp"
		Toolbar1_Buttons_Button3.Size = New System.Drawing.Size(48, 37)
		Toolbar1_Buttons_Button3.Text = "Help"
		Toolbar1_Buttons_Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Toolbar1_Buttons_Button3.ToolTipText = "Get Help"
		' 
		'Toolbar1_Buttons_Button4
		' 
		Toolbar1_Buttons_Button4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Toolbar1_Buttons_Button4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Toolbar1_Buttons_Button4.Name = "btnCancel"
		Toolbar1_Buttons_Button4.Size = New System.Drawing.Size(48, 37)
		Toolbar1_Buttons_Button4.Text = "Cancel"
		Toolbar1_Buttons_Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Toolbar1_Buttons_Button4.ToolTipText = "Ignore edits & return to menu"
		' 
		'Toolbar1_Buttons_Button5
		' 
		Toolbar1_Buttons_Button5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Toolbar1_Buttons_Button5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Toolbar1_Buttons_Button5.Name = "btnOK"
		Toolbar1_Buttons_Button5.Size = New System.Drawing.Size(48, 37)
		Toolbar1_Buttons_Button5.Text = "OK"
		Toolbar1_Buttons_Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Toolbar1_Buttons_Button5.ToolTipText = "Save edits & return to menu"
		' 
		'_Label1_19
		' 
		_Label1_19.AllowDrop = True
		_Label1_19.BackColor = System.Drawing.SystemColors.Control
		_Label1_19.BorderStyle = System.Windows.Forms.BorderStyle.None
		_Label1_19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Label1_19.ForeColor = System.Drawing.SystemColors.ControlText
		_Label1_19.Location = New System.Drawing.Point(576, 88)
		_Label1_19.MinimumSize = New System.Drawing.Size(57, 13)
		_Label1_19.Name = "_Label1_19"
		_Label1_19.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Label1_19.Size = New System.Drawing.Size(57, 13)
		_Label1_19.TabIndex = 50
		_Label1_19.Text = "Mean"
		_Label1_19.TextAlign = System.Drawing.ContentAlignment.TopCenter
		' 
		'_Label1_13
		' 
		_Label1_13.AllowDrop = True
		_Label1_13.BackColor = System.Drawing.SystemColors.Control
		_Label1_13.BorderStyle = System.Windows.Forms.BorderStyle.None
		_Label1_13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Label1_13.ForeColor = System.Drawing.SystemColors.ControlText
		_Label1_13.Location = New System.Drawing.Point(40, 453)
		_Label1_13.MinimumSize = New System.Drawing.Size(161, 19)
		_Label1_13.Name = "_Label1_13"
		_Label1_13.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Label1_13.Size = New System.Drawing.Size(161, 19)
		_Label1_13.TabIndex = 47
		_Label1_13.Text = "Chl-a Flushing Term"
		_Label1_13.TextAlign = System.Drawing.ContentAlignment.TopRight
		' 
		'lblDefinitions
		' 
		lblDefinitions.AllowDrop = True
		lblDefinitions.BackColor = System.Drawing.SystemColors.Control
		lblDefinitions.BorderStyle = System.Windows.Forms.BorderStyle.None
		lblDefinitions.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		lblDefinitions.ForeColor = System.Drawing.SystemColors.Highlight
		lblDefinitions.Location = New System.Drawing.Point(104, 48)
		lblDefinitions.MinimumSize = New System.Drawing.Size(345, 25)
		lblDefinitions.Name = "lblDefinitions"
		lblDefinitions.RightToLeft = System.Windows.Forms.RightToLeft.No
		lblDefinitions.Size = New System.Drawing.Size(345, 25)
		lblDefinitions.TabIndex = 33
		lblDefinitions.Text = "Label1"
		lblDefinitions.TextAlign = System.Drawing.ContentAlignment.TopCenter
		' 
		'_Label1_10
		' 
		_Label1_10.AllowDrop = True
		_Label1_10.BackColor = System.Drawing.SystemColors.Control
		_Label1_10.BorderStyle = System.Windows.Forms.BorderStyle.None
		_Label1_10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Label1_10.ForeColor = System.Drawing.SystemColors.ControlText
		_Label1_10.Location = New System.Drawing.Point(312, 88)
		_Label1_10.MinimumSize = New System.Drawing.Size(57, 14)
		_Label1_10.Name = "_Label1_10"
		_Label1_10.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Label1_10.Size = New System.Drawing.Size(57, 14)
		_Label1_10.TabIndex = 32
		_Label1_10.Text = "CV"
		_Label1_10.TextAlign = System.Drawing.ContentAlignment.TopCenter
		' 
		'_Label1_7
		' 
		_Label1_7.AllowDrop = True
		_Label1_7.BackColor = System.Drawing.SystemColors.Control
		_Label1_7.BorderStyle = System.Windows.Forms.BorderStyle.None
		_Label1_7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Label1_7.ForeColor = System.Drawing.SystemColors.ControlText
		_Label1_7.Location = New System.Drawing.Point(232, 88)
		_Label1_7.MinimumSize = New System.Drawing.Size(57, 13)
		_Label1_7.Name = "_Label1_7"
		_Label1_7.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Label1_7.Size = New System.Drawing.Size(57, 13)
		_Label1_7.TabIndex = 31
		_Label1_7.Text = "Mean"
		_Label1_7.TextAlign = System.Drawing.ContentAlignment.TopCenter
		' 
		'_Label1_18
		' 
		_Label1_18.AllowDrop = True
		_Label1_18.BackColor = System.Drawing.SystemColors.Control
		_Label1_18.BorderStyle = System.Windows.Forms.BorderStyle.None
		_Label1_18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Label1_18.ForeColor = System.Drawing.SystemColors.ControlText
		_Label1_18.Location = New System.Drawing.Point(400, 240)
		_Label1_18.MinimumSize = New System.Drawing.Size(161, 19)
		_Label1_18.Name = "_Label1_18"
		_Label1_18.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Label1_18.Size = New System.Drawing.Size(161, 19)
		_Label1_18.TabIndex = 30
		_Label1_18.Text = "Inorganic N Avail. Factor"
		_Label1_18.TextAlign = System.Drawing.ContentAlignment.TopRight
		' 
		'_Label1_17
		' 
		_Label1_17.AllowDrop = True
		_Label1_17.BackColor = System.Drawing.SystemColors.Control
		_Label1_17.BorderStyle = System.Windows.Forms.BorderStyle.None
		_Label1_17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Label1_17.ForeColor = System.Drawing.SystemColors.ControlText
		_Label1_17.Location = New System.Drawing.Point(400, 209)
		_Label1_17.MinimumSize = New System.Drawing.Size(161, 19)
		_Label1_17.Name = "_Label1_17"
		_Label1_17.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Label1_17.Size = New System.Drawing.Size(161, 19)
		_Label1_17.TabIndex = 29
		_Label1_17.Text = "Total N Avail. Factor"
		_Label1_17.TextAlign = System.Drawing.ContentAlignment.TopRight
		' 
		'_Label1_16
		' 
		_Label1_16.AllowDrop = True
		_Label1_16.BackColor = System.Drawing.SystemColors.Control
		_Label1_16.BorderStyle = System.Windows.Forms.BorderStyle.None
		_Label1_16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Label1_16.ForeColor = System.Drawing.SystemColors.ControlText
		_Label1_16.Location = New System.Drawing.Point(400, 178)
		_Label1_16.MinimumSize = New System.Drawing.Size(161, 19)
		_Label1_16.Name = "_Label1_16"
		_Label1_16.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Label1_16.Size = New System.Drawing.Size(161, 19)
		_Label1_16.TabIndex = 28
		_Label1_16.Text = "Ortho P Avail. Factor"
		_Label1_16.TextAlign = System.Drawing.ContentAlignment.TopRight
		' 
		'_Label1_15
		' 
		_Label1_15.AllowDrop = True
		_Label1_15.BackColor = System.Drawing.SystemColors.Control
		_Label1_15.BorderStyle = System.Windows.Forms.BorderStyle.None
		_Label1_15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Label1_15.ForeColor = System.Drawing.SystemColors.ControlText
		_Label1_15.Location = New System.Drawing.Point(400, 147)
		_Label1_15.MinimumSize = New System.Drawing.Size(161, 19)
		_Label1_15.Name = "_Label1_15"
		_Label1_15.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Label1_15.Size = New System.Drawing.Size(161, 19)
		_Label1_15.TabIndex = 27
		_Label1_15.Text = "Total P Avail. Factor"
		_Label1_15.TextAlign = System.Drawing.ContentAlignment.TopRight
		' 
		'_Label1_14
		' 
		_Label1_14.AllowDrop = True
		_Label1_14.BackColor = System.Drawing.SystemColors.Control
		_Label1_14.BorderStyle = System.Windows.Forms.BorderStyle.None
		_Label1_14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Label1_14.ForeColor = System.Drawing.SystemColors.ControlText
		_Label1_14.Location = New System.Drawing.Point(400, 116)
		_Label1_14.MinimumSize = New System.Drawing.Size(161, 19)
		_Label1_14.Name = "_Label1_14"
		_Label1_14.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Label1_14.Size = New System.Drawing.Size(161, 19)
		_Label1_14.TabIndex = 26
		_Label1_14.Text = "Chl-a Temporal CV"
		_Label1_14.TextAlign = System.Drawing.ContentAlignment.TopRight
		' 
		'_Label1_12
		' 
		_Label1_12.AllowDrop = True
		_Label1_12.BackColor = System.Drawing.SystemColors.Control
		_Label1_12.BorderStyle = System.Windows.Forms.BorderStyle.None
		_Label1_12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Label1_12.ForeColor = System.Drawing.SystemColors.ControlText
		_Label1_12.Location = New System.Drawing.Point(40, 422)
		_Label1_12.MinimumSize = New System.Drawing.Size(161, 19)
		_Label1_12.Name = "_Label1_12"
		_Label1_12.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Label1_12.Size = New System.Drawing.Size(161, 19)
		_Label1_12.TabIndex = 25
		_Label1_12.Text = "Minimum Qs (m/yr)"
		_Label1_12.TextAlign = System.Drawing.ContentAlignment.TopRight
		' 
		'_Label1_11
		' 
		_Label1_11.AllowDrop = True
		_Label1_11.BackColor = System.Drawing.SystemColors.Control
		_Label1_11.BorderStyle = System.Windows.Forms.BorderStyle.None
		_Label1_11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Label1_11.ForeColor = System.Drawing.SystemColors.ControlText
		_Label1_11.Location = New System.Drawing.Point(16, 391)
		_Label1_11.MinimumSize = New System.Drawing.Size(185, 19)
		_Label1_11.Name = "_Label1_11"
		_Label1_11.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Label1_11.Size = New System.Drawing.Size(185, 19)
		_Label1_11.TabIndex = 24
		_Label1_11.Text = "Secchi/Chl-a Slope (mg/m2)"
		_Label1_11.TextAlign = System.Drawing.ContentAlignment.TopRight
		' 
		'_Label1_9
		' 
		_Label1_9.AllowDrop = True
		_Label1_9.BackColor = System.Drawing.SystemColors.Control
		_Label1_9.BorderStyle = System.Windows.Forms.BorderStyle.None
		_Label1_9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Label1_9.ForeColor = System.Drawing.SystemColors.ControlText
		_Label1_9.Location = New System.Drawing.Point(40, 360)
		_Label1_9.MinimumSize = New System.Drawing.Size(161, 19)
		_Label1_9.Name = "_Label1_9"
		_Label1_9.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Label1_9.Size = New System.Drawing.Size(161, 19)
		_Label1_9.TabIndex = 23
		_Label1_9.Text = "Metalim. Oxygen Depletion"
		_Label1_9.TextAlign = System.Drawing.ContentAlignment.TopRight
		' 
		'_Label1_8
		' 
		_Label1_8.AllowDrop = True
		_Label1_8.BackColor = System.Drawing.SystemColors.Control
		_Label1_8.BorderStyle = System.Windows.Forms.BorderStyle.None
		_Label1_8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Label1_8.ForeColor = System.Drawing.SystemColors.ControlText
		_Label1_8.Location = New System.Drawing.Point(40, 329)
		_Label1_8.MinimumSize = New System.Drawing.Size(161, 19)
		_Label1_8.Name = "_Label1_8"
		_Label1_8.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Label1_8.Size = New System.Drawing.Size(161, 19)
		_Label1_8.TabIndex = 22
		_Label1_8.Text = "Hypol. Oxygen Depletion"
		_Label1_8.TextAlign = System.Drawing.ContentAlignment.TopRight
		' 
		'_Label1_6
		' 
		_Label1_6.AllowDrop = True
		_Label1_6.BackColor = System.Drawing.SystemColors.Control
		_Label1_6.BorderStyle = System.Windows.Forms.BorderStyle.None
		_Label1_6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Label1_6.ForeColor = System.Drawing.SystemColors.ControlText
		_Label1_6.Location = New System.Drawing.Point(40, 298)
		_Label1_6.MinimumSize = New System.Drawing.Size(161, 19)
		_Label1_6.Name = "_Label1_6"
		_Label1_6.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Label1_6.Size = New System.Drawing.Size(161, 19)
		_Label1_6.TabIndex = 21
		_Label1_6.Text = "Total P - Ortho P"
		_Label1_6.TextAlign = System.Drawing.ContentAlignment.TopRight
		' 
		'_Label1_5
		' 
		_Label1_5.AllowDrop = True
		_Label1_5.BackColor = System.Drawing.SystemColors.Control
		_Label1_5.BorderStyle = System.Windows.Forms.BorderStyle.None
		_Label1_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Label1_5.ForeColor = System.Drawing.SystemColors.ControlText
		_Label1_5.Location = New System.Drawing.Point(40, 267)
		_Label1_5.MinimumSize = New System.Drawing.Size(161, 19)
		_Label1_5.Name = "_Label1_5"
		_Label1_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Label1_5.Size = New System.Drawing.Size(161, 19)
		_Label1_5.TabIndex = 20
		_Label1_5.Text = "Organic Nitrogen"
		_Label1_5.TextAlign = System.Drawing.ContentAlignment.TopRight
		' 
		'_Label1_4
		' 
		_Label1_4.AllowDrop = True
		_Label1_4.BackColor = System.Drawing.SystemColors.Control
		_Label1_4.BorderStyle = System.Windows.Forms.BorderStyle.None
		_Label1_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Label1_4.ForeColor = System.Drawing.SystemColors.ControlText
		_Label1_4.Location = New System.Drawing.Point(40, 236)
		_Label1_4.MinimumSize = New System.Drawing.Size(161, 19)
		_Label1_4.Name = "_Label1_4"
		_Label1_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Label1_4.Size = New System.Drawing.Size(161, 19)
		_Label1_4.TabIndex = 19
		_Label1_4.Text = "Secchi Depth"
		_Label1_4.TextAlign = System.Drawing.ContentAlignment.TopRight
		' 
		'_Label1_3
		' 
		_Label1_3.AllowDrop = True
		_Label1_3.BackColor = System.Drawing.SystemColors.Control
		_Label1_3.BorderStyle = System.Windows.Forms.BorderStyle.None
		_Label1_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Label1_3.ForeColor = System.Drawing.SystemColors.ControlText
		_Label1_3.Location = New System.Drawing.Point(40, 205)
		_Label1_3.MinimumSize = New System.Drawing.Size(161, 19)
		_Label1_3.Name = "_Label1_3"
		_Label1_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Label1_3.Size = New System.Drawing.Size(161, 19)
		_Label1_3.TabIndex = 18
		_Label1_3.Text = "Chlorophyll-a"
		_Label1_3.TextAlign = System.Drawing.ContentAlignment.TopRight
		' 
		'_Label1_2
		' 
		_Label1_2.AllowDrop = True
		_Label1_2.BackColor = System.Drawing.SystemColors.Control
		_Label1_2.BorderStyle = System.Windows.Forms.BorderStyle.None
		_Label1_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Label1_2.ForeColor = System.Drawing.SystemColors.ControlText
		_Label1_2.Location = New System.Drawing.Point(40, 174)
		_Label1_2.MinimumSize = New System.Drawing.Size(161, 19)
		_Label1_2.Name = "_Label1_2"
		_Label1_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Label1_2.Size = New System.Drawing.Size(161, 19)
		_Label1_2.TabIndex = 17
		_Label1_2.Text = "Total Nitrogen"
		_Label1_2.TextAlign = System.Drawing.ContentAlignment.TopRight
		' 
		'_Label1_1
		' 
		_Label1_1.AllowDrop = True
		_Label1_1.BackColor = System.Drawing.SystemColors.Control
		_Label1_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		_Label1_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Label1_1.ForeColor = System.Drawing.SystemColors.ControlText
		_Label1_1.Location = New System.Drawing.Point(40, 143)
		_Label1_1.MinimumSize = New System.Drawing.Size(161, 19)
		_Label1_1.Name = "_Label1_1"
		_Label1_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Label1_1.Size = New System.Drawing.Size(161, 19)
		_Label1_1.TabIndex = 16
		_Label1_1.Text = "Total Phosphorus"
		_Label1_1.TextAlign = System.Drawing.ContentAlignment.TopRight
		' 
		'_Label1_0
		' 
		_Label1_0.AllowDrop = True
		_Label1_0.BackColor = System.Drawing.SystemColors.Control
		_Label1_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		_Label1_0.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		_Label1_0.ForeColor = System.Drawing.SystemColors.ControlText
		_Label1_0.Location = New System.Drawing.Point(40, 112)
		_Label1_0.MinimumSize = New System.Drawing.Size(161, 19)
		_Label1_0.Name = "_Label1_0"
		_Label1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		_Label1_0.Size = New System.Drawing.Size(161, 19)
		_Label1_0.TabIndex = 0
		_Label1_0.Text = "Dispersion Rate"
		_Label1_0.TextAlign = System.Drawing.ContentAlignment.TopRight
		' 
		'frmCoefficients
		' 
		AllowDrop = True
		AutoScaleDimensions = New System.Drawing.SizeF(7, 15)
		AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		BackColor = System.Drawing.SystemColors.Control
		ClientSize = New System.Drawing.Size(678, 487)
		Controls.Add(_Text1_11)
		Controls.Add(_Text1_28)
		Controls.Add(_Text1_0)
		Controls.Add(_Text1_1)
		Controls.Add(_Text1_2)
		Controls.Add(_Text1_3)
		Controls.Add(_Text1_4)
		Controls.Add(_Text1_5)
		Controls.Add(_Text1_6)
		Controls.Add(_Text1_7)
		Controls.Add(_Text1_8)
		Controls.Add(_Text1_9)
		Controls.Add(_Text1_10)
		Controls.Add(_Text1_12)
		Controls.Add(_Text1_27)
		Controls.Add(_Text1_26)
		Controls.Add(_Text1_25)
		Controls.Add(_Text1_24)
		Controls.Add(_Text1_23)
		Controls.Add(_Text1_22)
		Controls.Add(_Text1_21)
		Controls.Add(_Text1_20)
		Controls.Add(_Text1_19)
		Controls.Add(_Text1_18)
		Controls.Add(_Text1_17)
		Controls.Add(_Text1_16)
		Controls.Add(_Text1_15)
		Controls.Add(_Text1_14)
		Controls.Add(_Text1_13)
		Controls.Add(Toolbar1)
		Controls.Add(_Label1_19)
		Controls.Add(_Label1_13)
		Controls.Add(lblDefinitions)
		Controls.Add(_Label1_10)
		Controls.Add(_Label1_7)
		Controls.Add(_Label1_18)
		Controls.Add(_Label1_17)
		Controls.Add(_Label1_16)
		Controls.Add(_Label1_15)
		Controls.Add(_Label1_14)
		Controls.Add(_Label1_12)
		Controls.Add(_Label1_11)
		Controls.Add(_Label1_9)
		Controls.Add(_Label1_8)
		Controls.Add(_Label1_6)
		Controls.Add(_Label1_5)
		Controls.Add(_Label1_4)
		Controls.Add(_Label1_3)
		Controls.Add(_Label1_2)
		Controls.Add(_Label1_1)
		Controls.Add(_Label1_0)
		Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Location = New System.Drawing.Point(3, 22)
		MaximizeBox = False
		MinimizeBox = False
		Name = "frmCoefficients"
		RightToLeft = System.Windows.Forms.RightToLeft.No
		ShowInTaskbar = False
		Text = "Edit Model Coefficients"
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
			AddHandler Activated, AddressOf frmCoefficients_Activated
		End If
	End Sub
	Sub InitializeText1()
		ReDim Text1(28)
		Text1(11) = _Text1_11
		Text1(28) = _Text1_28
		Text1(0) = _Text1_0
		Text1(1) = _Text1_1
		Text1(2) = _Text1_2
		Text1(3) = _Text1_3
		Text1(4) = _Text1_4
		Text1(5) = _Text1_5
		Text1(6) = _Text1_6
		Text1(7) = _Text1_7
		Text1(8) = _Text1_8
		Text1(9) = _Text1_9
		Text1(10) = _Text1_10
		Text1(12) = _Text1_12
		Text1(27) = _Text1_27
		Text1(26) = _Text1_26
		Text1(25) = _Text1_25
		Text1(24) = _Text1_24
		Text1(23) = _Text1_23
		Text1(22) = _Text1_22
		Text1(21) = _Text1_21
		Text1(20) = _Text1_20
		Text1(19) = _Text1_19
		Text1(18) = _Text1_18
		Text1(17) = _Text1_17
		Text1(16) = _Text1_16
		Text1(15) = _Text1_15
		Text1(14) = _Text1_14
		Text1(13) = _Text1_13
	End Sub
	Sub InitializeLabel1()
		ReDim Label1(19)
		Label1(19) = _Label1_19
		Label1(13) = _Label1_13
		Label1(10) = _Label1_10
		Label1(7) = _Label1_7
		Label1(18) = _Label1_18
		Label1(17) = _Label1_17
		Label1(16) = _Label1_16
		Label1(15) = _Label1_15
		Label1(14) = _Label1_14
		Label1(12) = _Label1_12
		Label1(11) = _Label1_11
		Label1(9) = _Label1_9
		Label1(8) = _Label1_8
		Label1(6) = _Label1_6
		Label1(5) = _Label1_5
		Label1(4) = _Label1_4
		Label1(3) = _Label1_3
		Label1(2) = _Label1_2
		Label1(1) = _Label1_1
		Label1(0) = _Label1_0
	End Sub
#End Region
End Class