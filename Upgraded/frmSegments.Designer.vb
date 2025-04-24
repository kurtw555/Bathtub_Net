<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSegments
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As frmSegments
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As frmSegments
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = CreateInstance()
				m_InitializingDefInstance = False
			End If
			Return m_vb6FormDefInstance
		End Get
		Set(ByVal Value As frmSegments)
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region
#Region "Windows Form Designer generated code "
	Public Shared Function CreateInstance() As frmSegments
		Dim theInstance As New frmSegments()
		theInstance.Form_Load()
		Return theInstance
	End Function
	Private visualControls() As String = New String() {"components", "ToolTipMain", "Combo1", "_Label3_5", "_Label3_4", "_lblSegment_6", "_lblSegment_5", "_lblSegment_4", "_lblSegment_3", "_lblSegments_1", "_lblSegments_0", "_lblSegment_7", "_lblSegment_0", "_lblSegments_20", "_lblSegments_22", "_lblSegments_33", "_txtSegment_2", "_txtSegment_10", "_txtSegment_9", "_txtSegment_8", "_txtSegment_7", "_txtSegment_6", "_txtSegment_5", "_txtSegment_4", "_txtSegment_3", "_txtSegment_1", "Combo2", "_SSTab1_TabPage0", "_Label3_3", "_Label3_2", "_lblSegments_4", "_lblSegments_12", "_lblSegments_11", "_lblSegments_10", "_lblSegments_9", "_lblSegments_8", "_lblSegments_7", "_lblSegments_6", "_lblSegments_5", "_lblSegments_34", "_lblSegments_36", "Label1", "_lblSegments_35", "_lblSegments_3", "_txtSegment_30", "_txtSegment_28", "_txtSegment_26", "_txtSegment_24", "_txtSegment_22", "_txtSegment_20", "_txtSegment_18", "_txtSegment_16", "_txtSegment_14", "_txtSegment_13", "_txtSegment_11", "_txtSegment_12", "_txtSegment_29", "_txtSegment_17", "_txtSegment_19", "_txtSegment_21", "_txtSegment_23", "_txtSegment_25", "_txtSegment_27", "_txtSegment_15", "_SSTab1_TabPage1", "_Label3_1", "_lblSegments_17", "_lblSegments_16", "_lblSegments_15", "_lblSegments_14", "_lblSegments_13", "_lblSegments_2", "_Label3_0", "_lblSegments_21", "_lblSegments_25", "_lblSegments_26", "_lblSegments_27", "_lblSegments_29", "_lblSegments_28", "_txtSegment_33", "_txtSegment_32", "_txtSegment_31", "_txtSegment_34", "_txtSegment_35", "_txtSegment_36", "_txtSegment_37", "_txtSegment_38", "_txtSegment_39", "_txtSegment_40", "_txtSegment_41", "_txtSegment_42", "_txtSegment_44", "_txtSegment_43", "_txtSegment_46", "_txtSegment_45", "_txtSegment_48", "_txtSegment_47", "_SSTab1_TabPage2", "_txtSegment_49", "_txtSegment_50", "_txtSegment_51", "_txtSegment_52", "_txtSegment_53", "_txtSegment_54", "_lblSegments_32", "_lblSegments_31", "_lblSegments_30", "_lblSegments_18", "_lblSegments_19", "_lblSegments_23", "_Label3_6", "_Label3_7", "_Label3_8", "_SSTab1_TabPage3", "SSTab1", "_txtSegment_0", "Toolbar1_Buttons_Button1", "Toolbar1_Buttons_Button2", "Toolbar1_Buttons_Button3", "Toolbar1_Buttons_Button4", "Toolbar1_Buttons_Button5", "Toolbar1_Buttons_Button6", "Toolbar1_Buttons_Button7", "Toolbar1_Buttons_Button8", "Toolbar1_Buttons_Button9", "Toolbar1", "_lblSegments_24", "lblCount", "lblDefinitions", "Label3", "lblSegment", "lblSegments", "txtSegment"}
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTipMain As System.Windows.Forms.ToolTip
	Public WithEvents Combo1 As System.Windows.Forms.ComboBox
	Private WithEvents _Label3_5 As System.Windows.Forms.Label
	Private WithEvents _Label3_4 As System.Windows.Forms.Label
	Private WithEvents _lblSegment_6 As System.Windows.Forms.Label
	Private WithEvents _lblSegment_5 As System.Windows.Forms.Label
	Private WithEvents _lblSegment_4 As System.Windows.Forms.Label
	Private WithEvents _lblSegment_3 As System.Windows.Forms.Label
	Private WithEvents _lblSegments_1 As System.Windows.Forms.Label
	Private WithEvents _lblSegments_0 As System.Windows.Forms.Label
	Private WithEvents _lblSegment_7 As System.Windows.Forms.Label
	Private WithEvents _lblSegment_0 As System.Windows.Forms.Label
	Private WithEvents _lblSegments_20 As System.Windows.Forms.Label
	Private WithEvents _lblSegments_22 As System.Windows.Forms.Label
	Private WithEvents _lblSegments_33 As System.Windows.Forms.Label
	Private WithEvents _txtSegment_2 As System.Windows.Forms.TextBox
	Private WithEvents _txtSegment_10 As System.Windows.Forms.TextBox
	Private WithEvents _txtSegment_9 As System.Windows.Forms.TextBox
	Private WithEvents _txtSegment_8 As System.Windows.Forms.TextBox
	Private WithEvents _txtSegment_7 As System.Windows.Forms.TextBox
	Private WithEvents _txtSegment_6 As System.Windows.Forms.TextBox
	Private WithEvents _txtSegment_5 As System.Windows.Forms.TextBox
	Private WithEvents _txtSegment_4 As System.Windows.Forms.TextBox
	Private WithEvents _txtSegment_3 As System.Windows.Forms.TextBox
	Private WithEvents _txtSegment_1 As System.Windows.Forms.TextBox
	Public WithEvents Combo2 As System.Windows.Forms.ComboBox
	Private WithEvents _SSTab1_TabPage0 As System.Windows.Forms.TabPage
	Private WithEvents _Label3_3 As System.Windows.Forms.Label
	Private WithEvents _Label3_2 As System.Windows.Forms.Label
	Private WithEvents _lblSegments_4 As System.Windows.Forms.Label
	Private WithEvents _lblSegments_12 As System.Windows.Forms.Label
	Private WithEvents _lblSegments_11 As System.Windows.Forms.Label
	Private WithEvents _lblSegments_10 As System.Windows.Forms.Label
	Private WithEvents _lblSegments_9 As System.Windows.Forms.Label
	Private WithEvents _lblSegments_8 As System.Windows.Forms.Label
	Private WithEvents _lblSegments_7 As System.Windows.Forms.Label
	Private WithEvents _lblSegments_6 As System.Windows.Forms.Label
	Private WithEvents _lblSegments_5 As System.Windows.Forms.Label
	Private WithEvents _lblSegments_34 As System.Windows.Forms.Label
	Private WithEvents _lblSegments_36 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Private WithEvents _lblSegments_35 As System.Windows.Forms.Label
	Private WithEvents _lblSegments_3 As System.Windows.Forms.Label
	Private WithEvents _txtSegment_30 As System.Windows.Forms.TextBox
	Private WithEvents _txtSegment_28 As System.Windows.Forms.TextBox
	Private WithEvents _txtSegment_26 As System.Windows.Forms.TextBox
	Private WithEvents _txtSegment_24 As System.Windows.Forms.TextBox
	Private WithEvents _txtSegment_22 As System.Windows.Forms.TextBox
	Private WithEvents _txtSegment_20 As System.Windows.Forms.TextBox
	Private WithEvents _txtSegment_18 As System.Windows.Forms.TextBox
	Private WithEvents _txtSegment_16 As System.Windows.Forms.TextBox
	Private WithEvents _txtSegment_14 As System.Windows.Forms.TextBox
	Private WithEvents _txtSegment_13 As System.Windows.Forms.TextBox
	Private WithEvents _txtSegment_11 As System.Windows.Forms.TextBox
	Private WithEvents _txtSegment_12 As System.Windows.Forms.TextBox
	Private WithEvents _txtSegment_29 As System.Windows.Forms.TextBox
	Private WithEvents _txtSegment_17 As System.Windows.Forms.TextBox
	Private WithEvents _txtSegment_19 As System.Windows.Forms.TextBox
	Private WithEvents _txtSegment_21 As System.Windows.Forms.TextBox
	Private WithEvents _txtSegment_23 As System.Windows.Forms.TextBox
	Private WithEvents _txtSegment_25 As System.Windows.Forms.TextBox
	Private WithEvents _txtSegment_27 As System.Windows.Forms.TextBox
	Private WithEvents _txtSegment_15 As System.Windows.Forms.TextBox
	Private WithEvents _SSTab1_TabPage1 As System.Windows.Forms.TabPage
	Private WithEvents _Label3_1 As System.Windows.Forms.Label
	Private WithEvents _lblSegments_17 As System.Windows.Forms.Label
	Private WithEvents _lblSegments_16 As System.Windows.Forms.Label
	Private WithEvents _lblSegments_15 As System.Windows.Forms.Label
	Private WithEvents _lblSegments_14 As System.Windows.Forms.Label
	Private WithEvents _lblSegments_13 As System.Windows.Forms.Label
	Private WithEvents _lblSegments_2 As System.Windows.Forms.Label
	Private WithEvents _Label3_0 As System.Windows.Forms.Label
	Private WithEvents _lblSegments_21 As System.Windows.Forms.Label
	Private WithEvents _lblSegments_25 As System.Windows.Forms.Label
	Private WithEvents _lblSegments_26 As System.Windows.Forms.Label
	Private WithEvents _lblSegments_27 As System.Windows.Forms.Label
	Private WithEvents _lblSegments_29 As System.Windows.Forms.Label
	Private WithEvents _lblSegments_28 As System.Windows.Forms.Label
	Private WithEvents _txtSegment_33 As System.Windows.Forms.TextBox
	Private WithEvents _txtSegment_32 As System.Windows.Forms.TextBox
	Private WithEvents _txtSegment_31 As System.Windows.Forms.TextBox
	Private WithEvents _txtSegment_34 As System.Windows.Forms.TextBox
	Private WithEvents _txtSegment_35 As System.Windows.Forms.TextBox
	Private WithEvents _txtSegment_36 As System.Windows.Forms.TextBox
	Private WithEvents _txtSegment_37 As System.Windows.Forms.TextBox
	Private WithEvents _txtSegment_38 As System.Windows.Forms.TextBox
	Private WithEvents _txtSegment_39 As System.Windows.Forms.TextBox
	Private WithEvents _txtSegment_40 As System.Windows.Forms.TextBox
	Private WithEvents _txtSegment_41 As System.Windows.Forms.TextBox
	Private WithEvents _txtSegment_42 As System.Windows.Forms.TextBox
	Private WithEvents _txtSegment_44 As System.Windows.Forms.TextBox
	Private WithEvents _txtSegment_43 As System.Windows.Forms.TextBox
	Private WithEvents _txtSegment_46 As System.Windows.Forms.TextBox
	Private WithEvents _txtSegment_45 As System.Windows.Forms.TextBox
	Private WithEvents _txtSegment_48 As System.Windows.Forms.TextBox
	Private WithEvents _txtSegment_47 As System.Windows.Forms.TextBox
	Private WithEvents _SSTab1_TabPage2 As System.Windows.Forms.TabPage
	Private WithEvents _txtSegment_49 As System.Windows.Forms.TextBox
	Private WithEvents _txtSegment_50 As System.Windows.Forms.TextBox
	Private WithEvents _txtSegment_51 As System.Windows.Forms.TextBox
	Private WithEvents _txtSegment_52 As System.Windows.Forms.TextBox
	Private WithEvents _txtSegment_53 As System.Windows.Forms.TextBox
	Private WithEvents _txtSegment_54 As System.Windows.Forms.TextBox
	Private WithEvents _lblSegments_32 As System.Windows.Forms.Label
	Private WithEvents _lblSegments_31 As System.Windows.Forms.Label
	Private WithEvents _lblSegments_30 As System.Windows.Forms.Label
	Private WithEvents _lblSegments_18 As System.Windows.Forms.Label
	Private WithEvents _lblSegments_19 As System.Windows.Forms.Label
	Private WithEvents _lblSegments_23 As System.Windows.Forms.Label
	Private WithEvents _Label3_6 As System.Windows.Forms.Label
	Private WithEvents _Label3_7 As System.Windows.Forms.Label
	Private WithEvents _Label3_8 As System.Windows.Forms.Label
	Private WithEvents _SSTab1_TabPage3 As System.Windows.Forms.TabPage
	Public WithEvents SSTab1 As UpgradeHelpers.Gui.Controls.TabControlExtension
	Private WithEvents _txtSegment_0 As System.Windows.Forms.TextBox
	Public WithEvents Toolbar1_Buttons_Button1 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Buttons_Button2 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Buttons_Button3 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Buttons_Button4 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Buttons_Button5 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Buttons_Button6 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Buttons_Button7 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Buttons_Button8 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Buttons_Button9 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1 As System.Windows.Forms.ToolStrip
	Private WithEvents _lblSegments_24 As System.Windows.Forms.Label
	Public WithEvents lblCount As System.Windows.Forms.Label
	Public WithEvents lblDefinitions As System.Windows.Forms.Label
	Public Label3(8) As System.Windows.Forms.Label
	Public lblSegment(7) As System.Windows.Forms.Label
	Public lblSegments(36) As System.Windows.Forms.Label
	Public txtSegment(54) As System.Windows.Forms.TextBox
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSegments))
        ToolTipMain = New ToolTip(components)
        Combo1 = New ComboBox()
        _lblSegments_22 = New Label()
        Combo2 = New ComboBox()
        _lblSegments_35 = New Label()
        SSTab1 = New UpgradeHelpers.Gui.Controls.TabControlExtension()
        _SSTab1_TabPage0 = New TabPage()
        _Label3_5 = New Label()
        _Label3_4 = New Label()
        _lblSegment_6 = New Label()
        _lblSegment_5 = New Label()
        _lblSegment_4 = New Label()
        _lblSegment_3 = New Label()
        _lblSegments_1 = New Label()
        _lblSegments_0 = New Label()
        _lblSegment_7 = New Label()
        _lblSegment_0 = New Label()
        _lblSegments_20 = New Label()
        _lblSegments_33 = New Label()
        _txtSegment_2 = New TextBox()
        _txtSegment_10 = New TextBox()
        _txtSegment_9 = New TextBox()
        _txtSegment_8 = New TextBox()
        _txtSegment_7 = New TextBox()
        _txtSegment_6 = New TextBox()
        _txtSegment_5 = New TextBox()
        _txtSegment_4 = New TextBox()
        _txtSegment_3 = New TextBox()
        _txtSegment_1 = New TextBox()
        _SSTab1_TabPage1 = New TabPage()
        _Label3_3 = New Label()
        _Label3_2 = New Label()
        _lblSegments_4 = New Label()
        _lblSegments_12 = New Label()
        _lblSegments_11 = New Label()
        _lblSegments_10 = New Label()
        _lblSegments_9 = New Label()
        _lblSegments_8 = New Label()
        _lblSegments_7 = New Label()
        _lblSegments_6 = New Label()
        _lblSegments_5 = New Label()
        _lblSegments_34 = New Label()
        _lblSegments_36 = New Label()
        Label1 = New Label()
        _lblSegments_3 = New Label()
        _txtSegment_30 = New TextBox()
        _txtSegment_28 = New TextBox()
        _txtSegment_26 = New TextBox()
        _txtSegment_24 = New TextBox()
        _txtSegment_22 = New TextBox()
        _txtSegment_20 = New TextBox()
        _txtSegment_18 = New TextBox()
        _txtSegment_16 = New TextBox()
        _txtSegment_14 = New TextBox()
        _txtSegment_13 = New TextBox()
        _txtSegment_11 = New TextBox()
        _txtSegment_12 = New TextBox()
        _txtSegment_29 = New TextBox()
        _txtSegment_17 = New TextBox()
        _txtSegment_19 = New TextBox()
        _txtSegment_21 = New TextBox()
        _txtSegment_23 = New TextBox()
        _txtSegment_25 = New TextBox()
        _txtSegment_27 = New TextBox()
        _txtSegment_15 = New TextBox()
        _SSTab1_TabPage2 = New TabPage()
        _Label3_1 = New Label()
        _lblSegments_17 = New Label()
        _lblSegments_16 = New Label()
        _lblSegments_15 = New Label()
        _lblSegments_14 = New Label()
        _lblSegments_13 = New Label()
        _lblSegments_2 = New Label()
        _Label3_0 = New Label()
        _lblSegments_21 = New Label()
        _lblSegments_25 = New Label()
        _lblSegments_26 = New Label()
        _lblSegments_27 = New Label()
        _lblSegments_29 = New Label()
        _lblSegments_28 = New Label()
        _txtSegment_33 = New TextBox()
        _txtSegment_32 = New TextBox()
        _txtSegment_31 = New TextBox()
        _txtSegment_34 = New TextBox()
        _txtSegment_35 = New TextBox()
        _txtSegment_36 = New TextBox()
        _txtSegment_37 = New TextBox()
        _txtSegment_38 = New TextBox()
        _txtSegment_39 = New TextBox()
        _txtSegment_40 = New TextBox()
        _txtSegment_41 = New TextBox()
        _txtSegment_42 = New TextBox()
        _txtSegment_44 = New TextBox()
        _txtSegment_43 = New TextBox()
        _txtSegment_46 = New TextBox()
        _txtSegment_45 = New TextBox()
        _txtSegment_48 = New TextBox()
        _txtSegment_47 = New TextBox()
        _SSTab1_TabPage3 = New TabPage()
        _txtSegment_49 = New TextBox()
        _txtSegment_50 = New TextBox()
        _txtSegment_51 = New TextBox()
        _txtSegment_52 = New TextBox()
        _txtSegment_53 = New TextBox()
        _txtSegment_54 = New TextBox()
        _lblSegments_32 = New Label()
        _lblSegments_31 = New Label()
        _lblSegments_30 = New Label()
        _lblSegments_18 = New Label()
        _lblSegments_19 = New Label()
        _lblSegments_23 = New Label()
        _Label3_6 = New Label()
        _Label3_7 = New Label()
        _Label3_8 = New Label()
        _txtSegment_0 = New TextBox()
        Toolbar1 = New ToolStrip()
        Toolbar1_Buttons_Button1 = New ToolStripButton()
        Toolbar1_Buttons_Button2 = New ToolStripButton()
        Toolbar1_Buttons_Button3 = New ToolStripButton()
        Toolbar1_Buttons_Button4 = New ToolStripButton()
        Toolbar1_Buttons_Button5 = New ToolStripButton()
        Toolbar1_Buttons_Button6 = New ToolStripButton()
        Toolbar1_Buttons_Button7 = New ToolStripButton()
        Toolbar1_Buttons_Button8 = New ToolStripButton()
        Toolbar1_Buttons_Button9 = New ToolStripButton()
        _lblSegments_24 = New Label()
        lblCount = New Label()
        lblDefinitions = New Label()
        SSTab1.SuspendLayout()
        _SSTab1_TabPage0.SuspendLayout()
        _SSTab1_TabPage1.SuspendLayout()
        _SSTab1_TabPage2.SuspendLayout()
        _SSTab1_TabPage3.SuspendLayout()
        Toolbar1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Combo1
        ' 
        Combo1.AllowDrop = True
        Combo1.BackColor = SystemColors.Window
        Combo1.DropDownStyle = ComboBoxStyle.DropDownList
        Combo1.Font = New Font("Microsoft Sans Serif", 9.75F)
        Combo1.ForeColor = SystemColors.WindowText
        Combo1.Location = New Point(8, 56)
        Combo1.Name = "Combo1"
        Combo1.RightToLeft = RightToLeft.No
        Combo1.Size = New Size(233, 24)
        Combo1.TabIndex = 0
        ToolTipMain.SetToolTip(Combo1, "Select Segment to Be Edited")
        ' 
        ' _lblSegments_22
        ' 
        _lblSegments_22.AllowDrop = True
        _lblSegments_22.BackColor = SystemColors.Control
        _lblSegments_22.Font = New Font("Microsoft Sans Serif", 9.75F)
        _lblSegments_22.ForeColor = SystemColors.ControlText
        _lblSegments_22.Location = New Point(248, 308)
        _lblSegments_22.MinimumSize = New Size(73, 26)
        _lblSegments_22.Name = "_lblSegments_22"
        _lblSegments_22.RightToLeft = RightToLeft.No
        _lblSegments_22.Size = New Size(73, 26)
        _lblSegments_22.TabIndex = 96
        _lblSegments_22.Text = "0"
        _lblSegments_22.TextAlign = ContentAlignment.TopCenter
        ToolTipMain.SetToolTip(_lblSegments_22, "Mixed Layer Depth Predicted from Mean Depth")
        ' 
        ' Combo2
        ' 
        Combo2.AllowDrop = True
        Combo2.BackColor = SystemColors.Window
        Combo2.DropDownStyle = ComboBoxStyle.DropDownList
        Combo2.Font = New Font("Microsoft Sans Serif", 9.75F)
        Combo2.ForeColor = SystemColors.WindowText
        Combo2.Location = New Point(192, 76)
        Combo2.Name = "Combo2"
        Combo2.RightToLeft = RightToLeft.No
        Combo2.Size = New Size(217, 24)
        Combo2.TabIndex = 2
        ToolTipMain.SetToolTip(Combo2, "Segment Downstream of Current Segment ( 0 = Out of Reservoir )")
        ' 
        ' _lblSegments_35
        ' 
        _lblSegments_35.AllowDrop = True
        _lblSegments_35.BackColor = SystemColors.Control
        _lblSegments_35.Font = New Font("Microsoft Sans Serif", 9.75F)
        _lblSegments_35.ForeColor = SystemColors.ControlText
        _lblSegments_35.Location = New Point(272, 84)
        _lblSegments_35.MinimumSize = New Size(81, 25)
        _lblSegments_35.Name = "_lblSegments_35"
        _lblSegments_35.RightToLeft = RightToLeft.No
        _lblSegments_35.Size = New Size(81, 25)
        _lblSegments_35.TabIndex = 112
        _lblSegments_35.Text = "0"
        _lblSegments_35.TextAlign = ContentAlignment.TopCenter
        ToolTipMain.SetToolTip(_lblSegments_35, "Non-algal turbidity estimated from observed chl-a & secchi")
        ' 
        ' SSTab1
        ' 
        SSTab1.AllowDrop = True
        SSTab1.Caption = "&Morphometry|&Observed WQ|&Calibration Factors|&Internal Load|"
        SSTab1.Controls.Add(_SSTab1_TabPage0)
        SSTab1.Controls.Add(_SSTab1_TabPage1)
        SSTab1.Controls.Add(_SSTab1_TabPage2)
        SSTab1.Controls.Add(_SSTab1_TabPage3)
        SSTab1.DrawMode = TabDrawMode.OwnerDrawFixed
        SSTab1.Font = New Font("Microsoft Sans Serif", 8.25F)
        SSTab1.ItemSize = New Size(129, 18)
        SSTab1.Location = New Point(16, 136)
        SSTab1.Multiline = True
        SSTab1.Name = "SSTab1"
        SSTab1.SelectedIndex = 0
        SSTab1.Size = New Size(525, 429)
        SSTab1.SizeMode = TabSizeMode.Fixed
        SSTab1.TabIndex = 7
        SSTab1.Text = "&Morphometry|&Observed WQ|&Calibration Factors|&Internal Load|"
        ' 
        ' _SSTab1_TabPage0
        ' 
        _SSTab1_TabPage0.Controls.Add(_Label3_5)
        _SSTab1_TabPage0.Controls.Add(_Label3_4)
        _SSTab1_TabPage0.Controls.Add(_lblSegment_6)
        _SSTab1_TabPage0.Controls.Add(_lblSegment_5)
        _SSTab1_TabPage0.Controls.Add(_lblSegment_4)
        _SSTab1_TabPage0.Controls.Add(_lblSegment_3)
        _SSTab1_TabPage0.Controls.Add(_lblSegments_1)
        _SSTab1_TabPage0.Controls.Add(_lblSegments_0)
        _SSTab1_TabPage0.Controls.Add(_lblSegment_7)
        _SSTab1_TabPage0.Controls.Add(_lblSegment_0)
        _SSTab1_TabPage0.Controls.Add(_lblSegments_20)
        _SSTab1_TabPage0.Controls.Add(_lblSegments_22)
        _SSTab1_TabPage0.Controls.Add(_lblSegments_33)
        _SSTab1_TabPage0.Controls.Add(_txtSegment_2)
        _SSTab1_TabPage0.Controls.Add(_txtSegment_10)
        _SSTab1_TabPage0.Controls.Add(_txtSegment_9)
        _SSTab1_TabPage0.Controls.Add(_txtSegment_8)
        _SSTab1_TabPage0.Controls.Add(_txtSegment_7)
        _SSTab1_TabPage0.Controls.Add(_txtSegment_6)
        _SSTab1_TabPage0.Controls.Add(_txtSegment_5)
        _SSTab1_TabPage0.Controls.Add(_txtSegment_4)
        _SSTab1_TabPage0.Controls.Add(_txtSegment_3)
        _SSTab1_TabPage0.Controls.Add(_txtSegment_1)
        _SSTab1_TabPage0.Controls.Add(Combo2)
        _SSTab1_TabPage0.Font = New Font("Microsoft Sans Serif", 8.25F)
        _SSTab1_TabPage0.Location = New Point(4, 22)
        _SSTab1_TabPage0.Name = "_SSTab1_TabPage0"
        _SSTab1_TabPage0.Size = New Size(517, 403)
        _SSTab1_TabPage0.TabIndex = 0
        _SSTab1_TabPage0.Text = "Morphometry"
        ' 
        ' _Label3_5
        ' 
        _Label3_5.AllowDrop = True
        _Label3_5.BackColor = SystemColors.Control
        _Label3_5.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Underline)
        _Label3_5.ForeColor = SystemColors.ControlText
        _Label3_5.Location = New Point(256, 140)
        _Label3_5.MinimumSize = New Size(57, 25)
        _Label3_5.Name = "_Label3_5"
        _Label3_5.RightToLeft = RightToLeft.No
        _Label3_5.Size = New Size(57, 25)
        _Label3_5.TabIndex = 12
        _Label3_5.Text = "Mean"
        _Label3_5.TextAlign = ContentAlignment.TopCenter
        ' 
        ' _Label3_4
        ' 
        _Label3_4.AllowDrop = True
        _Label3_4.BackColor = SystemColors.Control
        _Label3_4.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Underline)
        _Label3_4.ForeColor = SystemColors.ControlText
        _Label3_4.Location = New Point(344, 140)
        _Label3_4.MinimumSize = New Size(57, 25)
        _Label3_4.Name = "_Label3_4"
        _Label3_4.RightToLeft = RightToLeft.No
        _Label3_4.Size = New Size(57, 25)
        _Label3_4.TabIndex = 13
        _Label3_4.Text = "CV"
        _Label3_4.TextAlign = ContentAlignment.TopCenter
        ' 
        ' _lblSegment_6
        ' 
        _lblSegment_6.AllowDrop = True
        _lblSegment_6.BackColor = SystemColors.Control
        _lblSegment_6.Font = New Font("Microsoft Sans Serif", 9.75F)
        _lblSegment_6.ForeColor = SystemColors.ControlText
        _lblSegment_6.Location = New Point(144, 244)
        _lblSegment_6.MinimumSize = New Size(97, 17)
        _lblSegment_6.Name = "_lblSegment_6"
        _lblSegment_6.RightToLeft = RightToLeft.No
        _lblSegment_6.Size = New Size(97, 17)
        _lblSegment_6.TabIndex = 14
        _lblSegment_6.Text = " Length (km):"
        _lblSegment_6.TextAlign = ContentAlignment.TopRight
        ' 
        ' _lblSegment_5
        ' 
        _lblSegment_5.AllowDrop = True
        _lblSegment_5.BackColor = SystemColors.Control
        _lblSegment_5.Font = New Font("Microsoft Sans Serif", 9.75F)
        _lblSegment_5.ForeColor = SystemColors.ControlText
        _lblSegment_5.Location = New Point(112, 212)
        _lblSegment_5.MinimumSize = New Size(129, 17)
        _lblSegment_5.Name = "_lblSegment_5"
        _lblSegment_5.RightToLeft = RightToLeft.No
        _lblSegment_5.Size = New Size(129, 17)
        _lblSegment_5.TabIndex = 15
        _lblSegment_5.Text = "Mean Depth (m):"
        _lblSegment_5.TextAlign = ContentAlignment.TopRight
        ' 
        ' _lblSegment_4
        ' 
        _lblSegment_4.AllowDrop = True
        _lblSegment_4.BackColor = SystemColors.Control
        _lblSegment_4.Font = New Font("Microsoft Sans Serif", 9.75F)
        _lblSegment_4.ForeColor = SystemColors.ControlText
        _lblSegment_4.Location = New Point(96, 180)
        _lblSegment_4.MinimumSize = New Size(145, 17)
        _lblSegment_4.Name = "_lblSegment_4"
        _lblSegment_4.RightToLeft = RightToLeft.No
        _lblSegment_4.Size = New Size(145, 17)
        _lblSegment_4.TabIndex = 16
        _lblSegment_4.Text = "Surface Area (km2):"
        _lblSegment_4.TextAlign = ContentAlignment.TopRight
        ' 
        ' _lblSegment_3
        ' 
        _lblSegment_3.AllowDrop = True
        _lblSegment_3.BackColor = SystemColors.Control
        _lblSegment_3.Font = New Font("Microsoft Sans Serif", 9.75F)
        _lblSegment_3.ForeColor = SystemColors.ControlText
        _lblSegment_3.Location = New Point(72, 116)
        _lblSegment_3.MinimumSize = New Size(113, 17)
        _lblSegment_3.Name = "_lblSegment_3"
        _lblSegment_3.RightToLeft = RightToLeft.No
        _lblSegment_3.Size = New Size(113, 17)
        _lblSegment_3.TabIndex = 17
        _lblSegment_3.Text = "Segment Group:"
        _lblSegment_3.TextAlign = ContentAlignment.TopRight
        ' 
        ' _lblSegments_1
        ' 
        _lblSegments_1.AllowDrop = True
        _lblSegments_1.BackColor = SystemColors.Control
        _lblSegments_1.Font = New Font("Microsoft Sans Serif", 9.75F)
        _lblSegments_1.ForeColor = SystemColors.ControlText
        _lblSegments_1.Location = New Point(56, 340)
        _lblSegments_1.MinimumSize = New Size(185, 25)
        _lblSegments_1.Name = "_lblSegments_1"
        _lblSegments_1.RightToLeft = RightToLeft.No
        _lblSegments_1.Size = New Size(185, 25)
        _lblSegments_1.TabIndex = 18
        _lblSegments_1.Text = "Hypolimnetic Thickness (m):"
        _lblSegments_1.TextAlign = ContentAlignment.TopRight
        ' 
        ' _lblSegments_0
        ' 
        _lblSegments_0.AllowDrop = True
        _lblSegments_0.BackColor = SystemColors.Control
        _lblSegments_0.Font = New Font("Microsoft Sans Serif", 9.75F)
        _lblSegments_0.ForeColor = SystemColors.ControlText
        _lblSegments_0.Location = New Point(64, 276)
        _lblSegments_0.MinimumSize = New Size(177, 25)
        _lblSegments_0.Name = "_lblSegments_0"
        _lblSegments_0.RightToLeft = RightToLeft.No
        _lblSegments_0.Size = New Size(177, 25)
        _lblSegments_0.TabIndex = 19
        _lblSegments_0.Text = "Mixed Layer Depth (m):"
        _lblSegments_0.TextAlign = ContentAlignment.TopRight
        ' 
        ' _lblSegment_7
        ' 
        _lblSegment_7.AllowDrop = True
        _lblSegment_7.BackColor = SystemColors.Control
        _lblSegment_7.Font = New Font("Microsoft Sans Serif", 9.75F)
        _lblSegment_7.ForeColor = SystemColors.ControlText
        _lblSegment_7.Location = New Point(72, 44)
        _lblSegment_7.MinimumSize = New Size(113, 17)
        _lblSegment_7.Name = "_lblSegment_7"
        _lblSegment_7.RightToLeft = RightToLeft.No
        _lblSegment_7.Size = New Size(113, 17)
        _lblSegment_7.TabIndex = 20
        _lblSegment_7.Text = "Segment Name:"
        _lblSegment_7.TextAlign = ContentAlignment.TopRight
        ' 
        ' _lblSegment_0
        ' 
        _lblSegment_0.AllowDrop = True
        _lblSegment_0.BackColor = SystemColors.Control
        _lblSegment_0.Font = New Font("Microsoft Sans Serif", 9.75F)
        _lblSegment_0.ForeColor = SystemColors.ControlText
        _lblSegment_0.Location = New Point(72, 76)
        _lblSegment_0.MinimumSize = New Size(113, 17)
        _lblSegment_0.Name = "_lblSegment_0"
        _lblSegment_0.RightToLeft = RightToLeft.No
        _lblSegment_0.Size = New Size(113, 17)
        _lblSegment_0.TabIndex = 74
        _lblSegment_0.Text = "Outflow Segment:"
        _lblSegment_0.TextAlign = ContentAlignment.TopRight
        ' 
        ' _lblSegments_20
        ' 
        _lblSegments_20.AllowDrop = True
        _lblSegments_20.BackColor = SystemColors.Control
        _lblSegments_20.Font = New Font("Microsoft Sans Serif", 9.75F)
        _lblSegments_20.ForeColor = SystemColors.ControlText
        _lblSegments_20.Location = New Point(64, 308)
        _lblSegments_20.MinimumSize = New Size(177, 25)
        _lblSegments_20.Name = "_lblSegments_20"
        _lblSegments_20.RightToLeft = RightToLeft.No
        _lblSegments_20.Size = New Size(177, 25)
        _lblSegments_20.TabIndex = 95
        _lblSegments_20.Text = "Estimated Mixed Depth (m):"
        _lblSegments_20.TextAlign = ContentAlignment.TopRight
        ' 
        ' _lblSegments_33
        ' 
        _lblSegments_33.AllowDrop = True
        _lblSegments_33.BackColor = SystemColors.Control
        _lblSegments_33.Font = New Font("Microsoft Sans Serif", 9.75F)
        _lblSegments_33.ForeColor = SystemColors.ControlText
        _lblSegments_33.Location = New Point(344, 308)
        _lblSegments_33.MinimumSize = New Size(57, 26)
        _lblSegments_33.Name = "_lblSegments_33"
        _lblSegments_33.RightToLeft = RightToLeft.No
        _lblSegments_33.Size = New Size(57, 26)
        _lblSegments_33.TabIndex = 97
        _lblSegments_33.Text = "0.12"
        _lblSegments_33.TextAlign = ContentAlignment.TopCenter
        ' 
        ' _txtSegment_2
        ' 
        _txtSegment_2.AcceptsReturn = True
        _txtSegment_2.AllowDrop = True
        _txtSegment_2.BackColor = SystemColors.Window
        _txtSegment_2.Cursor = Cursors.IBeam
        _txtSegment_2.Font = New Font("Microsoft Sans Serif", 8.25F)
        _txtSegment_2.ForeColor = SystemColors.WindowText
        _txtSegment_2.Location = New Point(216, 76)
        _txtSegment_2.MaxLength = 0
        _txtSegment_2.Name = "_txtSegment_2"
        _txtSegment_2.RightToLeft = RightToLeft.No
        _txtSegment_2.Size = New Size(193, 20)
        _txtSegment_2.TabIndex = 75
        _txtSegment_2.Text = "0"
        _txtSegment_2.TextAlign = HorizontalAlignment.Center
        ' 
        ' _txtSegment_10
        ' 
        _txtSegment_10.AcceptsReturn = True
        _txtSegment_10.AllowDrop = True
        _txtSegment_10.BackColor = SystemColors.Window
        _txtSegment_10.Cursor = Cursors.IBeam
        _txtSegment_10.Font = New Font("Microsoft Sans Serif", 9.75F)
        _txtSegment_10.ForeColor = SystemColors.WindowText
        _txtSegment_10.Location = New Point(344, 340)
        _txtSegment_10.MaxLength = 0
        _txtSegment_10.Name = "_txtSegment_10"
        _txtSegment_10.RightToLeft = RightToLeft.No
        _txtSegment_10.Size = New Size(57, 22)
        _txtSegment_10.TabIndex = 8
        _txtSegment_10.Text = "0"
        _txtSegment_10.TextAlign = HorizontalAlignment.Center
        ' 
        ' _txtSegment_9
        ' 
        _txtSegment_9.AcceptsReturn = True
        _txtSegment_9.AllowDrop = True
        _txtSegment_9.BackColor = SystemColors.Window
        _txtSegment_9.Cursor = Cursors.IBeam
        _txtSegment_9.Font = New Font("Microsoft Sans Serif", 9.75F)
        _txtSegment_9.ForeColor = SystemColors.WindowText
        _txtSegment_9.Location = New Point(248, 340)
        _txtSegment_9.MaxLength = 0
        _txtSegment_9.Name = "_txtSegment_9"
        _txtSegment_9.RightToLeft = RightToLeft.No
        _txtSegment_9.Size = New Size(73, 22)
        _txtSegment_9.TabIndex = 9
        _txtSegment_9.Text = "0"
        _txtSegment_9.TextAlign = HorizontalAlignment.Center
        ' 
        ' _txtSegment_8
        ' 
        _txtSegment_8.AcceptsReturn = True
        _txtSegment_8.AllowDrop = True
        _txtSegment_8.BackColor = SystemColors.Window
        _txtSegment_8.Cursor = Cursors.IBeam
        _txtSegment_8.Font = New Font("Microsoft Sans Serif", 9.75F)
        _txtSegment_8.ForeColor = SystemColors.WindowText
        _txtSegment_8.Location = New Point(344, 273)
        _txtSegment_8.MaxLength = 0
        _txtSegment_8.Name = "_txtSegment_8"
        _txtSegment_8.RightToLeft = RightToLeft.No
        _txtSegment_8.Size = New Size(57, 22)
        _txtSegment_8.TabIndex = 10
        _txtSegment_8.Text = "0"
        _txtSegment_8.TextAlign = HorizontalAlignment.Center
        ' 
        ' _txtSegment_7
        ' 
        _txtSegment_7.AcceptsReturn = True
        _txtSegment_7.AllowDrop = True
        _txtSegment_7.BackColor = SystemColors.Window
        _txtSegment_7.Cursor = Cursors.IBeam
        _txtSegment_7.Font = New Font("Microsoft Sans Serif", 9.75F)
        _txtSegment_7.ForeColor = SystemColors.WindowText
        _txtSegment_7.Location = New Point(248, 273)
        _txtSegment_7.MaxLength = 0
        _txtSegment_7.Name = "_txtSegment_7"
        _txtSegment_7.RightToLeft = RightToLeft.No
        _txtSegment_7.Size = New Size(73, 22)
        _txtSegment_7.TabIndex = 11
        _txtSegment_7.Text = "0"
        _txtSegment_7.TextAlign = HorizontalAlignment.Center
        ' 
        ' _txtSegment_6
        ' 
        _txtSegment_6.AcceptsReturn = True
        _txtSegment_6.AllowDrop = True
        _txtSegment_6.BackColor = SystemColors.Window
        _txtSegment_6.Cursor = Cursors.IBeam
        _txtSegment_6.Font = New Font("Microsoft Sans Serif", 9.75F)
        _txtSegment_6.ForeColor = SystemColors.WindowText
        _txtSegment_6.Location = New Point(248, 240)
        _txtSegment_6.MaxLength = 0
        _txtSegment_6.Name = "_txtSegment_6"
        _txtSegment_6.RightToLeft = RightToLeft.No
        _txtSegment_6.Size = New Size(73, 22)
        _txtSegment_6.TabIndex = 6
        _txtSegment_6.Text = "0"
        _txtSegment_6.TextAlign = HorizontalAlignment.Center
        ' 
        ' _txtSegment_5
        ' 
        _txtSegment_5.AcceptsReturn = True
        _txtSegment_5.AllowDrop = True
        _txtSegment_5.BackColor = SystemColors.Window
        _txtSegment_5.Cursor = Cursors.IBeam
        _txtSegment_5.Font = New Font("Microsoft Sans Serif", 9.75F)
        _txtSegment_5.ForeColor = SystemColors.WindowText
        _txtSegment_5.Location = New Point(248, 206)
        _txtSegment_5.MaxLength = 0
        _txtSegment_5.Name = "_txtSegment_5"
        _txtSegment_5.RightToLeft = RightToLeft.No
        _txtSegment_5.Size = New Size(73, 22)
        _txtSegment_5.TabIndex = 5
        _txtSegment_5.Text = "0"
        _txtSegment_5.TextAlign = HorizontalAlignment.Center
        ' 
        ' _txtSegment_4
        ' 
        _txtSegment_4.AcceptsReturn = True
        _txtSegment_4.AllowDrop = True
        _txtSegment_4.BackColor = SystemColors.Window
        _txtSegment_4.Cursor = Cursors.IBeam
        _txtSegment_4.Font = New Font("Microsoft Sans Serif", 9.75F)
        _txtSegment_4.ForeColor = SystemColors.WindowText
        _txtSegment_4.Location = New Point(248, 173)
        _txtSegment_4.MaxLength = 0
        _txtSegment_4.Name = "_txtSegment_4"
        _txtSegment_4.RightToLeft = RightToLeft.No
        _txtSegment_4.Size = New Size(73, 22)
        _txtSegment_4.TabIndex = 4
        _txtSegment_4.Text = "0"
        _txtSegment_4.TextAlign = HorizontalAlignment.Center
        ' 
        ' _txtSegment_3
        ' 
        _txtSegment_3.AcceptsReturn = True
        _txtSegment_3.AllowDrop = True
        _txtSegment_3.BackColor = SystemColors.Window
        _txtSegment_3.Cursor = Cursors.IBeam
        _txtSegment_3.Font = New Font("Microsoft Sans Serif", 9.75F)
        _txtSegment_3.ForeColor = SystemColors.WindowText
        _txtSegment_3.Location = New Point(192, 116)
        _txtSegment_3.MaxLength = 0
        _txtSegment_3.Name = "_txtSegment_3"
        _txtSegment_3.RightToLeft = RightToLeft.No
        _txtSegment_3.Size = New Size(49, 22)
        _txtSegment_3.TabIndex = 3
        _txtSegment_3.Text = "0"
        _txtSegment_3.TextAlign = HorizontalAlignment.Center
        ' 
        ' _txtSegment_1
        ' 
        _txtSegment_1.AcceptsReturn = True
        _txtSegment_1.AllowDrop = True
        _txtSegment_1.BackColor = SystemColors.Window
        _txtSegment_1.Cursor = Cursors.IBeam
        _txtSegment_1.Font = New Font("Microsoft Sans Serif", 9.75F)
        _txtSegment_1.ForeColor = SystemColors.WindowText
        _txtSegment_1.Location = New Point(192, 44)
        _txtSegment_1.MaxLength = 0
        _txtSegment_1.Name = "_txtSegment_1"
        _txtSegment_1.RightToLeft = RightToLeft.No
        _txtSegment_1.Size = New Size(217, 22)
        _txtSegment_1.TabIndex = 1
        _txtSegment_1.Text = "0"
        ' 
        ' _SSTab1_TabPage1
        ' 
        _SSTab1_TabPage1.Controls.Add(_Label3_3)
        _SSTab1_TabPage1.Controls.Add(_Label3_2)
        _SSTab1_TabPage1.Controls.Add(_lblSegments_4)
        _SSTab1_TabPage1.Controls.Add(_lblSegments_12)
        _SSTab1_TabPage1.Controls.Add(_lblSegments_11)
        _SSTab1_TabPage1.Controls.Add(_lblSegments_10)
        _SSTab1_TabPage1.Controls.Add(_lblSegments_9)
        _SSTab1_TabPage1.Controls.Add(_lblSegments_8)
        _SSTab1_TabPage1.Controls.Add(_lblSegments_7)
        _SSTab1_TabPage1.Controls.Add(_lblSegments_6)
        _SSTab1_TabPage1.Controls.Add(_lblSegments_5)
        _SSTab1_TabPage1.Controls.Add(_lblSegments_34)
        _SSTab1_TabPage1.Controls.Add(_lblSegments_36)
        _SSTab1_TabPage1.Controls.Add(Label1)
        _SSTab1_TabPage1.Controls.Add(_lblSegments_35)
        _SSTab1_TabPage1.Controls.Add(_lblSegments_3)
        _SSTab1_TabPage1.Controls.Add(_txtSegment_30)
        _SSTab1_TabPage1.Controls.Add(_txtSegment_28)
        _SSTab1_TabPage1.Controls.Add(_txtSegment_26)
        _SSTab1_TabPage1.Controls.Add(_txtSegment_24)
        _SSTab1_TabPage1.Controls.Add(_txtSegment_22)
        _SSTab1_TabPage1.Controls.Add(_txtSegment_20)
        _SSTab1_TabPage1.Controls.Add(_txtSegment_18)
        _SSTab1_TabPage1.Controls.Add(_txtSegment_16)
        _SSTab1_TabPage1.Controls.Add(_txtSegment_14)
        _SSTab1_TabPage1.Controls.Add(_txtSegment_13)
        _SSTab1_TabPage1.Controls.Add(_txtSegment_11)
        _SSTab1_TabPage1.Controls.Add(_txtSegment_12)
        _SSTab1_TabPage1.Controls.Add(_txtSegment_29)
        _SSTab1_TabPage1.Controls.Add(_txtSegment_17)
        _SSTab1_TabPage1.Controls.Add(_txtSegment_19)
        _SSTab1_TabPage1.Controls.Add(_txtSegment_21)
        _SSTab1_TabPage1.Controls.Add(_txtSegment_23)
        _SSTab1_TabPage1.Controls.Add(_txtSegment_25)
        _SSTab1_TabPage1.Controls.Add(_txtSegment_27)
        _SSTab1_TabPage1.Controls.Add(_txtSegment_15)
        _SSTab1_TabPage1.Font = New Font("Microsoft Sans Serif", 8.25F)
        _SSTab1_TabPage1.Location = New Point(4, 22)
        _SSTab1_TabPage1.Name = "_SSTab1_TabPage1"
        _SSTab1_TabPage1.Size = New Size(517, 403)
        _SSTab1_TabPage1.TabIndex = 1
        _SSTab1_TabPage1.Text = "Observed WQ"
        ' 
        ' _Label3_3
        ' 
        _Label3_3.AllowDrop = True
        _Label3_3.BackColor = SystemColors.Control
        _Label3_3.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Underline)
        _Label3_3.ForeColor = SystemColors.ControlText
        _Label3_3.Location = New Point(280, 20)
        _Label3_3.MinimumSize = New Size(57, 25)
        _Label3_3.Name = "_Label3_3"
        _Label3_3.RightToLeft = RightToLeft.No
        _Label3_3.Size = New Size(57, 25)
        _Label3_3.TabIndex = 30
        _Label3_3.Text = "Mean"
        _Label3_3.TextAlign = ContentAlignment.TopCenter
        ' 
        ' _Label3_2
        ' 
        _Label3_2.AllowDrop = True
        _Label3_2.BackColor = SystemColors.Control
        _Label3_2.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Underline)
        _Label3_2.ForeColor = SystemColors.ControlText
        _Label3_2.Location = New Point(368, 20)
        _Label3_2.MinimumSize = New Size(57, 25)
        _Label3_2.Name = "_Label3_2"
        _Label3_2.RightToLeft = RightToLeft.No
        _Label3_2.Size = New Size(57, 25)
        _Label3_2.TabIndex = 31
        _Label3_2.Text = "CV"
        _Label3_2.TextAlign = ContentAlignment.TopCenter
        ' 
        ' _lblSegments_4
        ' 
        _lblSegments_4.AllowDrop = True
        _lblSegments_4.BackColor = SystemColors.Control
        _lblSegments_4.Font = New Font("Microsoft Sans Serif", 9.75F)
        _lblSegments_4.ForeColor = SystemColors.ControlText
        _lblSegments_4.Location = New Point(72, 116)
        _lblSegments_4.MinimumSize = New Size(193, 24)
        _lblSegments_4.Name = "_lblSegments_4"
        _lblSegments_4.RightToLeft = RightToLeft.No
        _lblSegments_4.Size = New Size(193, 24)
        _lblSegments_4.TabIndex = 32
        _lblSegments_4.Text = "Total Phosphorus (ppb):"
        _lblSegments_4.TextAlign = ContentAlignment.TopRight
        ' 
        ' _lblSegments_12
        ' 
        _lblSegments_12.AllowDrop = True
        _lblSegments_12.BackColor = SystemColors.Control
        _lblSegments_12.Font = New Font("Microsoft Sans Serif", 9.75F)
        _lblSegments_12.ForeColor = SystemColors.ControlText
        _lblSegments_12.Location = New Point(16, 364)
        _lblSegments_12.MinimumSize = New Size(249, 24)
        _lblSegments_12.Name = "_lblSegments_12"
        _lblSegments_12.RightToLeft = RightToLeft.No
        _lblSegments_12.Size = New Size(249, 24)
        _lblSegments_12.TabIndex = 33
        _lblSegments_12.Text = "Conservative Substance (ppb):"
        _lblSegments_12.TextAlign = ContentAlignment.TopRight
        ' 
        ' _lblSegments_11
        ' 
        _lblSegments_11.AllowDrop = True
        _lblSegments_11.BackColor = SystemColors.Control
        _lblSegments_11.Font = New Font("Microsoft Sans Serif", 9.75F)
        _lblSegments_11.ForeColor = SystemColors.ControlText
        _lblSegments_11.Location = New Point(32, 333)
        _lblSegments_11.MinimumSize = New Size(233, 24)
        _lblSegments_11.Name = "_lblSegments_11"
        _lblSegments_11.RightToLeft = RightToLeft.No
        _lblSegments_11.Size = New Size(233, 24)
        _lblSegments_11.TabIndex = 34
        _lblSegments_11.Text = "Metalimnetic O2 Depletion (ppb/d):"
        _lblSegments_11.TextAlign = ContentAlignment.TopRight
        ' 
        ' _lblSegments_10
        ' 
        _lblSegments_10.AllowDrop = True
        _lblSegments_10.BackColor = SystemColors.Control
        _lblSegments_10.Font = New Font("Microsoft Sans Serif", 9.75F)
        _lblSegments_10.ForeColor = SystemColors.ControlText
        _lblSegments_10.Location = New Point(32, 302)
        _lblSegments_10.MinimumSize = New Size(233, 24)
        _lblSegments_10.Name = "_lblSegments_10"
        _lblSegments_10.RightToLeft = RightToLeft.No
        _lblSegments_10.Size = New Size(233, 24)
        _lblSegments_10.TabIndex = 35
        _lblSegments_10.Text = "Hypolimnetic O2 Depletion (ppb/d):"
        _lblSegments_10.TextAlign = ContentAlignment.TopRight
        ' 
        ' _lblSegments_9
        ' 
        _lblSegments_9.AllowDrop = True
        _lblSegments_9.BackColor = SystemColors.Control
        _lblSegments_9.Font = New Font("Microsoft Sans Serif", 9.75F)
        _lblSegments_9.ForeColor = SystemColors.ControlText
        _lblSegments_9.Location = New Point(72, 271)
        _lblSegments_9.MinimumSize = New Size(193, 24)
        _lblSegments_9.Name = "_lblSegments_9"
        _lblSegments_9.RightToLeft = RightToLeft.No
        _lblSegments_9.Size = New Size(193, 24)
        _lblSegments_9.TabIndex = 36
        _lblSegments_9.Text = "Total P - Ortho P (ppb):"
        _lblSegments_9.TextAlign = ContentAlignment.TopRight
        ' 
        ' _lblSegments_8
        ' 
        _lblSegments_8.AllowDrop = True
        _lblSegments_8.BackColor = SystemColors.Control
        _lblSegments_8.Font = New Font("Microsoft Sans Serif", 9.75F)
        _lblSegments_8.ForeColor = SystemColors.ControlText
        _lblSegments_8.Location = New Point(48, 240)
        _lblSegments_8.MinimumSize = New Size(217, 24)
        _lblSegments_8.Name = "_lblSegments_8"
        _lblSegments_8.RightToLeft = RightToLeft.No
        _lblSegments_8.Size = New Size(217, 24)
        _lblSegments_8.TabIndex = 37
        _lblSegments_8.Text = "Organic Nitrogen (ppb):"
        _lblSegments_8.TextAlign = ContentAlignment.TopRight
        ' 
        ' _lblSegments_7
        ' 
        _lblSegments_7.AllowDrop = True
        _lblSegments_7.BackColor = SystemColors.Control
        _lblSegments_7.Font = New Font("Microsoft Sans Serif", 9.75F)
        _lblSegments_7.ForeColor = SystemColors.ControlText
        _lblSegments_7.Location = New Point(72, 209)
        _lblSegments_7.MinimumSize = New Size(193, 24)
        _lblSegments_7.Name = "_lblSegments_7"
        _lblSegments_7.RightToLeft = RightToLeft.No
        _lblSegments_7.Size = New Size(193, 24)
        _lblSegments_7.TabIndex = 38
        _lblSegments_7.Text = "Secchi Depth (m):"
        _lblSegments_7.TextAlign = ContentAlignment.TopRight
        ' 
        ' _lblSegments_6
        ' 
        _lblSegments_6.AllowDrop = True
        _lblSegments_6.BackColor = SystemColors.Control
        _lblSegments_6.Font = New Font("Microsoft Sans Serif", 9.75F)
        _lblSegments_6.ForeColor = SystemColors.ControlText
        _lblSegments_6.Location = New Point(72, 178)
        _lblSegments_6.MinimumSize = New Size(193, 24)
        _lblSegments_6.Name = "_lblSegments_6"
        _lblSegments_6.RightToLeft = RightToLeft.No
        _lblSegments_6.Size = New Size(193, 24)
        _lblSegments_6.TabIndex = 39
        _lblSegments_6.Text = "Chlorophyll-a  (ppb):"
        _lblSegments_6.TextAlign = ContentAlignment.TopRight
        ' 
        ' _lblSegments_5
        ' 
        _lblSegments_5.AllowDrop = True
        _lblSegments_5.BackColor = SystemColors.Control
        _lblSegments_5.Font = New Font("Microsoft Sans Serif", 9.75F)
        _lblSegments_5.ForeColor = SystemColors.ControlText
        _lblSegments_5.Location = New Point(72, 147)
        _lblSegments_5.MinimumSize = New Size(193, 24)
        _lblSegments_5.Name = "_lblSegments_5"
        _lblSegments_5.RightToLeft = RightToLeft.No
        _lblSegments_5.Size = New Size(193, 24)
        _lblSegments_5.TabIndex = 40
        _lblSegments_5.Text = "Total Nitrogen  (ppb):"
        _lblSegments_5.TextAlign = ContentAlignment.TopRight
        ' 
        ' _lblSegments_34
        ' 
        _lblSegments_34.AllowDrop = True
        _lblSegments_34.BackColor = SystemColors.Control
        _lblSegments_34.Font = New Font("Microsoft Sans Serif", 9.75F)
        _lblSegments_34.ForeColor = SystemColors.ControlText
        _lblSegments_34.Location = New Point(16, 84)
        _lblSegments_34.MinimumSize = New Size(249, 24)
        _lblSegments_34.Name = "_lblSegments_34"
        _lblSegments_34.RightToLeft = RightToLeft.No
        _lblSegments_34.Size = New Size(249, 24)
        _lblSegments_34.TabIndex = 98
        _lblSegments_34.Text = "Non-Algal Turb Est. (1/Secchi - 0.025*Chl):"
        _lblSegments_34.TextAlign = ContentAlignment.TopRight
        ' 
        ' _lblSegments_36
        ' 
        _lblSegments_36.AllowDrop = True
        _lblSegments_36.BackColor = SystemColors.Control
        _lblSegments_36.Font = New Font("Microsoft Sans Serif", 9.75F)
        _lblSegments_36.ForeColor = SystemColors.ControlText
        _lblSegments_36.Location = New Point(368, 84)
        _lblSegments_36.MinimumSize = New Size(57, 25)
        _lblSegments_36.Name = "_lblSegments_36"
        _lblSegments_36.RightToLeft = RightToLeft.No
        _lblSegments_36.Size = New Size(57, 25)
        _lblSegments_36.TabIndex = 99
        _lblSegments_36.Text = "0"
        _lblSegments_36.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label1
        ' 
        Label1.AllowDrop = True
        Label1.BackColor = SystemColors.Control
        Label1.Font = New Font("Microsoft Sans Serif", 8.25F)
        Label1.ForeColor = SystemColors.ControlText
        Label1.Location = New Point(424, 84)
        Label1.MinimumSize = New Size(73, 17)
        Label1.Name = "Label1"
        Label1.RightToLeft = RightToLeft.No
        Label1.Size = New Size(90, 24)
        Label1.TabIndex = 100
        Label1.Text = "(min = 0.08/m)"
        ' 
        ' _lblSegments_3
        ' 
        _lblSegments_3.AllowDrop = True
        _lblSegments_3.BackColor = SystemColors.Control
        _lblSegments_3.Font = New Font("Microsoft Sans Serif", 9.75F)
        _lblSegments_3.ForeColor = SystemColors.ControlText
        _lblSegments_3.Location = New Point(48, 52)
        _lblSegments_3.MinimumSize = New Size(217, 24)
        _lblSegments_3.Name = "_lblSegments_3"
        _lblSegments_3.RightToLeft = RightToLeft.No
        _lblSegments_3.Size = New Size(217, 24)
        _lblSegments_3.TabIndex = 113
        _lblSegments_3.Text = "Non-Algal Turb. (1/m):"
        _lblSegments_3.TextAlign = ContentAlignment.TopRight
        ' 
        ' _txtSegment_30
        ' 
        _txtSegment_30.AcceptsReturn = True
        _txtSegment_30.AllowDrop = True
        _txtSegment_30.BackColor = SystemColors.Window
        _txtSegment_30.Cursor = Cursors.IBeam
        _txtSegment_30.Font = New Font("Microsoft Sans Serif", 9.75F)
        _txtSegment_30.ForeColor = SystemColors.WindowText
        _txtSegment_30.Location = New Point(368, 364)
        _txtSegment_30.MaxLength = 0
        _txtSegment_30.Name = "_txtSegment_30"
        _txtSegment_30.RightToLeft = RightToLeft.No
        _txtSegment_30.Size = New Size(57, 22)
        _txtSegment_30.TabIndex = 21
        _txtSegment_30.Text = "0"
        _txtSegment_30.TextAlign = HorizontalAlignment.Center
        ' 
        ' _txtSegment_28
        ' 
        _txtSegment_28.AcceptsReturn = True
        _txtSegment_28.AllowDrop = True
        _txtSegment_28.BackColor = SystemColors.Window
        _txtSegment_28.Cursor = Cursors.IBeam
        _txtSegment_28.Font = New Font("Microsoft Sans Serif", 9.75F)
        _txtSegment_28.ForeColor = SystemColors.WindowText
        _txtSegment_28.Location = New Point(368, 333)
        _txtSegment_28.MaxLength = 0
        _txtSegment_28.Name = "_txtSegment_28"
        _txtSegment_28.RightToLeft = RightToLeft.No
        _txtSegment_28.Size = New Size(57, 22)
        _txtSegment_28.TabIndex = 22
        _txtSegment_28.Text = "0"
        _txtSegment_28.TextAlign = HorizontalAlignment.Center
        ' 
        ' _txtSegment_26
        ' 
        _txtSegment_26.AcceptsReturn = True
        _txtSegment_26.AllowDrop = True
        _txtSegment_26.BackColor = SystemColors.Window
        _txtSegment_26.Cursor = Cursors.IBeam
        _txtSegment_26.Font = New Font("Microsoft Sans Serif", 9.75F)
        _txtSegment_26.ForeColor = SystemColors.WindowText
        _txtSegment_26.Location = New Point(368, 302)
        _txtSegment_26.MaxLength = 0
        _txtSegment_26.Name = "_txtSegment_26"
        _txtSegment_26.RightToLeft = RightToLeft.No
        _txtSegment_26.Size = New Size(57, 22)
        _txtSegment_26.TabIndex = 23
        _txtSegment_26.Text = "0"
        _txtSegment_26.TextAlign = HorizontalAlignment.Center
        ' 
        ' _txtSegment_24
        ' 
        _txtSegment_24.AcceptsReturn = True
        _txtSegment_24.AllowDrop = True
        _txtSegment_24.BackColor = SystemColors.Window
        _txtSegment_24.Cursor = Cursors.IBeam
        _txtSegment_24.Font = New Font("Microsoft Sans Serif", 9.75F)
        _txtSegment_24.ForeColor = SystemColors.WindowText
        _txtSegment_24.Location = New Point(368, 271)
        _txtSegment_24.MaxLength = 0
        _txtSegment_24.Name = "_txtSegment_24"
        _txtSegment_24.RightToLeft = RightToLeft.No
        _txtSegment_24.Size = New Size(57, 22)
        _txtSegment_24.TabIndex = 24
        _txtSegment_24.Text = "0"
        _txtSegment_24.TextAlign = HorizontalAlignment.Center
        ' 
        ' _txtSegment_22
        ' 
        _txtSegment_22.AcceptsReturn = True
        _txtSegment_22.AllowDrop = True
        _txtSegment_22.BackColor = SystemColors.Window
        _txtSegment_22.Cursor = Cursors.IBeam
        _txtSegment_22.Font = New Font("Microsoft Sans Serif", 9.75F)
        _txtSegment_22.ForeColor = SystemColors.WindowText
        _txtSegment_22.Location = New Point(368, 240)
        _txtSegment_22.MaxLength = 0
        _txtSegment_22.Name = "_txtSegment_22"
        _txtSegment_22.RightToLeft = RightToLeft.No
        _txtSegment_22.Size = New Size(57, 22)
        _txtSegment_22.TabIndex = 25
        _txtSegment_22.Text = "0"
        _txtSegment_22.TextAlign = HorizontalAlignment.Center
        ' 
        ' _txtSegment_20
        ' 
        _txtSegment_20.AcceptsReturn = True
        _txtSegment_20.AllowDrop = True
        _txtSegment_20.BackColor = SystemColors.Window
        _txtSegment_20.Cursor = Cursors.IBeam
        _txtSegment_20.Font = New Font("Microsoft Sans Serif", 9.75F)
        _txtSegment_20.ForeColor = SystemColors.WindowText
        _txtSegment_20.Location = New Point(368, 209)
        _txtSegment_20.MaxLength = 0
        _txtSegment_20.Name = "_txtSegment_20"
        _txtSegment_20.RightToLeft = RightToLeft.No
        _txtSegment_20.Size = New Size(57, 22)
        _txtSegment_20.TabIndex = 26
        _txtSegment_20.Text = "0"
        _txtSegment_20.TextAlign = HorizontalAlignment.Center
        ' 
        ' _txtSegment_18
        ' 
        _txtSegment_18.AcceptsReturn = True
        _txtSegment_18.AllowDrop = True
        _txtSegment_18.BackColor = SystemColors.Window
        _txtSegment_18.Cursor = Cursors.IBeam
        _txtSegment_18.Font = New Font("Microsoft Sans Serif", 9.75F)
        _txtSegment_18.ForeColor = SystemColors.WindowText
        _txtSegment_18.Location = New Point(368, 178)
        _txtSegment_18.MaxLength = 0
        _txtSegment_18.Name = "_txtSegment_18"
        _txtSegment_18.RightToLeft = RightToLeft.No
        _txtSegment_18.Size = New Size(57, 22)
        _txtSegment_18.TabIndex = 27
        _txtSegment_18.Text = "0"
        _txtSegment_18.TextAlign = HorizontalAlignment.Center
        ' 
        ' _txtSegment_16
        ' 
        _txtSegment_16.AcceptsReturn = True
        _txtSegment_16.AllowDrop = True
        _txtSegment_16.BackColor = SystemColors.Window
        _txtSegment_16.Cursor = Cursors.IBeam
        _txtSegment_16.Font = New Font("Microsoft Sans Serif", 9.75F)
        _txtSegment_16.ForeColor = SystemColors.WindowText
        _txtSegment_16.Location = New Point(368, 147)
        _txtSegment_16.MaxLength = 0
        _txtSegment_16.Name = "_txtSegment_16"
        _txtSegment_16.RightToLeft = RightToLeft.No
        _txtSegment_16.Size = New Size(57, 22)
        _txtSegment_16.TabIndex = 28
        _txtSegment_16.Text = "0"
        _txtSegment_16.TextAlign = HorizontalAlignment.Center
        ' 
        ' _txtSegment_14
        ' 
        _txtSegment_14.AcceptsReturn = True
        _txtSegment_14.AllowDrop = True
        _txtSegment_14.BackColor = SystemColors.Window
        _txtSegment_14.Cursor = Cursors.IBeam
        _txtSegment_14.Font = New Font("Microsoft Sans Serif", 9.75F)
        _txtSegment_14.ForeColor = SystemColors.WindowText
        _txtSegment_14.Location = New Point(368, 116)
        _txtSegment_14.MaxLength = 0
        _txtSegment_14.Name = "_txtSegment_14"
        _txtSegment_14.RightToLeft = RightToLeft.No
        _txtSegment_14.Size = New Size(57, 22)
        _txtSegment_14.TabIndex = 29
        _txtSegment_14.Text = "0"
        _txtSegment_14.TextAlign = HorizontalAlignment.Center
        ' 
        ' _txtSegment_13
        ' 
        _txtSegment_13.AcceptsReturn = True
        _txtSegment_13.AllowDrop = True
        _txtSegment_13.BackColor = SystemColors.Window
        _txtSegment_13.Cursor = Cursors.IBeam
        _txtSegment_13.Font = New Font("Microsoft Sans Serif", 9.75F)
        _txtSegment_13.ForeColor = SystemColors.WindowText
        _txtSegment_13.Location = New Point(272, 116)
        _txtSegment_13.MaxLength = 0
        _txtSegment_13.Name = "_txtSegment_13"
        _txtSegment_13.RightToLeft = RightToLeft.No
        _txtSegment_13.Size = New Size(81, 22)
        _txtSegment_13.TabIndex = 101
        _txtSegment_13.Text = "0"
        _txtSegment_13.TextAlign = HorizontalAlignment.Center
        ' 
        ' _txtSegment_11
        ' 
        _txtSegment_11.AcceptsReturn = True
        _txtSegment_11.AllowDrop = True
        _txtSegment_11.BackColor = SystemColors.Window
        _txtSegment_11.Cursor = Cursors.IBeam
        _txtSegment_11.Font = New Font("Microsoft Sans Serif", 9.75F)
        _txtSegment_11.ForeColor = SystemColors.WindowText
        _txtSegment_11.Location = New Point(272, 52)
        _txtSegment_11.MaxLength = 0
        _txtSegment_11.Name = "_txtSegment_11"
        _txtSegment_11.RightToLeft = RightToLeft.No
        _txtSegment_11.Size = New Size(81, 22)
        _txtSegment_11.TabIndex = 102
        _txtSegment_11.Text = "0"
        _txtSegment_11.TextAlign = HorizontalAlignment.Center
        ' 
        ' _txtSegment_12
        ' 
        _txtSegment_12.AcceptsReturn = True
        _txtSegment_12.AllowDrop = True
        _txtSegment_12.BackColor = SystemColors.Window
        _txtSegment_12.Cursor = Cursors.IBeam
        _txtSegment_12.Font = New Font("Microsoft Sans Serif", 9.75F)
        _txtSegment_12.ForeColor = SystemColors.WindowText
        _txtSegment_12.Location = New Point(368, 52)
        _txtSegment_12.MaxLength = 0
        _txtSegment_12.Name = "_txtSegment_12"
        _txtSegment_12.RightToLeft = RightToLeft.No
        _txtSegment_12.Size = New Size(57, 22)
        _txtSegment_12.TabIndex = 103
        _txtSegment_12.Text = "0"
        _txtSegment_12.TextAlign = HorizontalAlignment.Center
        ' 
        ' _txtSegment_29
        ' 
        _txtSegment_29.AcceptsReturn = True
        _txtSegment_29.AllowDrop = True
        _txtSegment_29.BackColor = SystemColors.Window
        _txtSegment_29.Cursor = Cursors.IBeam
        _txtSegment_29.Font = New Font("Microsoft Sans Serif", 9.75F)
        _txtSegment_29.ForeColor = SystemColors.WindowText
        _txtSegment_29.Location = New Point(272, 364)
        _txtSegment_29.MaxLength = 0
        _txtSegment_29.Name = "_txtSegment_29"
        _txtSegment_29.RightToLeft = RightToLeft.No
        _txtSegment_29.Size = New Size(81, 22)
        _txtSegment_29.TabIndex = 104
        _txtSegment_29.Text = "0"
        _txtSegment_29.TextAlign = HorizontalAlignment.Center
        ' 
        ' _txtSegment_17
        ' 
        _txtSegment_17.AcceptsReturn = True
        _txtSegment_17.AllowDrop = True
        _txtSegment_17.BackColor = SystemColors.Window
        _txtSegment_17.Cursor = Cursors.IBeam
        _txtSegment_17.Font = New Font("Microsoft Sans Serif", 9.75F)
        _txtSegment_17.ForeColor = SystemColors.WindowText
        _txtSegment_17.Location = New Point(272, 178)
        _txtSegment_17.MaxLength = 0
        _txtSegment_17.Name = "_txtSegment_17"
        _txtSegment_17.RightToLeft = RightToLeft.No
        _txtSegment_17.Size = New Size(81, 22)
        _txtSegment_17.TabIndex = 105
        _txtSegment_17.Text = "0"
        _txtSegment_17.TextAlign = HorizontalAlignment.Center
        ' 
        ' _txtSegment_19
        ' 
        _txtSegment_19.AcceptsReturn = True
        _txtSegment_19.AllowDrop = True
        _txtSegment_19.BackColor = SystemColors.Window
        _txtSegment_19.Cursor = Cursors.IBeam
        _txtSegment_19.Font = New Font("Microsoft Sans Serif", 9.75F)
        _txtSegment_19.ForeColor = SystemColors.WindowText
        _txtSegment_19.Location = New Point(272, 209)
        _txtSegment_19.MaxLength = 0
        _txtSegment_19.Name = "_txtSegment_19"
        _txtSegment_19.RightToLeft = RightToLeft.No
        _txtSegment_19.Size = New Size(81, 22)
        _txtSegment_19.TabIndex = 106
        _txtSegment_19.Text = "0"
        _txtSegment_19.TextAlign = HorizontalAlignment.Center
        ' 
        ' _txtSegment_21
        ' 
        _txtSegment_21.AcceptsReturn = True
        _txtSegment_21.AllowDrop = True
        _txtSegment_21.BackColor = SystemColors.Window
        _txtSegment_21.Cursor = Cursors.IBeam
        _txtSegment_21.Font = New Font("Microsoft Sans Serif", 9.75F)
        _txtSegment_21.ForeColor = SystemColors.WindowText
        _txtSegment_21.Location = New Point(272, 240)
        _txtSegment_21.MaxLength = 0
        _txtSegment_21.Name = "_txtSegment_21"
        _txtSegment_21.RightToLeft = RightToLeft.No
        _txtSegment_21.Size = New Size(81, 22)
        _txtSegment_21.TabIndex = 107
        _txtSegment_21.Text = "0"
        _txtSegment_21.TextAlign = HorizontalAlignment.Center
        ' 
        ' _txtSegment_23
        ' 
        _txtSegment_23.AcceptsReturn = True
        _txtSegment_23.AllowDrop = True
        _txtSegment_23.BackColor = SystemColors.Window
        _txtSegment_23.Cursor = Cursors.IBeam
        _txtSegment_23.Font = New Font("Microsoft Sans Serif", 9.75F)
        _txtSegment_23.ForeColor = SystemColors.WindowText
        _txtSegment_23.Location = New Point(272, 271)
        _txtSegment_23.MaxLength = 0
        _txtSegment_23.Name = "_txtSegment_23"
        _txtSegment_23.RightToLeft = RightToLeft.No
        _txtSegment_23.Size = New Size(81, 22)
        _txtSegment_23.TabIndex = 108
        _txtSegment_23.Text = "0"
        _txtSegment_23.TextAlign = HorizontalAlignment.Center
        ' 
        ' _txtSegment_25
        ' 
        _txtSegment_25.AcceptsReturn = True
        _txtSegment_25.AllowDrop = True
        _txtSegment_25.BackColor = SystemColors.Window
        _txtSegment_25.Cursor = Cursors.IBeam
        _txtSegment_25.Font = New Font("Microsoft Sans Serif", 9.75F)
        _txtSegment_25.ForeColor = SystemColors.WindowText
        _txtSegment_25.Location = New Point(272, 302)
        _txtSegment_25.MaxLength = 0
        _txtSegment_25.Name = "_txtSegment_25"
        _txtSegment_25.RightToLeft = RightToLeft.No
        _txtSegment_25.Size = New Size(81, 22)
        _txtSegment_25.TabIndex = 109
        _txtSegment_25.Text = "0"
        _txtSegment_25.TextAlign = HorizontalAlignment.Center
        ' 
        ' _txtSegment_27
        ' 
        _txtSegment_27.AcceptsReturn = True
        _txtSegment_27.AllowDrop = True
        _txtSegment_27.BackColor = SystemColors.Window
        _txtSegment_27.Cursor = Cursors.IBeam
        _txtSegment_27.Font = New Font("Microsoft Sans Serif", 9.75F)
        _txtSegment_27.ForeColor = SystemColors.WindowText
        _txtSegment_27.Location = New Point(272, 333)
        _txtSegment_27.MaxLength = 0
        _txtSegment_27.Name = "_txtSegment_27"
        _txtSegment_27.RightToLeft = RightToLeft.No
        _txtSegment_27.Size = New Size(81, 22)
        _txtSegment_27.TabIndex = 110
        _txtSegment_27.Text = "0"
        _txtSegment_27.TextAlign = HorizontalAlignment.Center
        ' 
        ' _txtSegment_15
        ' 
        _txtSegment_15.AcceptsReturn = True
        _txtSegment_15.AllowDrop = True
        _txtSegment_15.BackColor = SystemColors.Window
        _txtSegment_15.Cursor = Cursors.IBeam
        _txtSegment_15.Font = New Font("Microsoft Sans Serif", 9.75F)
        _txtSegment_15.ForeColor = SystemColors.WindowText
        _txtSegment_15.Location = New Point(272, 147)
        _txtSegment_15.MaxLength = 0
        _txtSegment_15.Name = "_txtSegment_15"
        _txtSegment_15.RightToLeft = RightToLeft.No
        _txtSegment_15.Size = New Size(81, 22)
        _txtSegment_15.TabIndex = 111
        _txtSegment_15.Text = "0"
        _txtSegment_15.TextAlign = HorizontalAlignment.Center
        ' 
        ' _SSTab1_TabPage2
        ' 
        _SSTab1_TabPage2.Controls.Add(_Label3_1)
        _SSTab1_TabPage2.Controls.Add(_lblSegments_17)
        _SSTab1_TabPage2.Controls.Add(_lblSegments_16)
        _SSTab1_TabPage2.Controls.Add(_lblSegments_15)
        _SSTab1_TabPage2.Controls.Add(_lblSegments_14)
        _SSTab1_TabPage2.Controls.Add(_lblSegments_13)
        _SSTab1_TabPage2.Controls.Add(_lblSegments_2)
        _SSTab1_TabPage2.Controls.Add(_Label3_0)
        _SSTab1_TabPage2.Controls.Add(_lblSegments_21)
        _SSTab1_TabPage2.Controls.Add(_lblSegments_25)
        _SSTab1_TabPage2.Controls.Add(_lblSegments_26)
        _SSTab1_TabPage2.Controls.Add(_lblSegments_27)
        _SSTab1_TabPage2.Controls.Add(_lblSegments_29)
        _SSTab1_TabPage2.Controls.Add(_lblSegments_28)
        _SSTab1_TabPage2.Controls.Add(_txtSegment_33)
        _SSTab1_TabPage2.Controls.Add(_txtSegment_32)
        _SSTab1_TabPage2.Controls.Add(_txtSegment_31)
        _SSTab1_TabPage2.Controls.Add(_txtSegment_34)
        _SSTab1_TabPage2.Controls.Add(_txtSegment_35)
        _SSTab1_TabPage2.Controls.Add(_txtSegment_36)
        _SSTab1_TabPage2.Controls.Add(_txtSegment_37)
        _SSTab1_TabPage2.Controls.Add(_txtSegment_38)
        _SSTab1_TabPage2.Controls.Add(_txtSegment_39)
        _SSTab1_TabPage2.Controls.Add(_txtSegment_40)
        _SSTab1_TabPage2.Controls.Add(_txtSegment_41)
        _SSTab1_TabPage2.Controls.Add(_txtSegment_42)
        _SSTab1_TabPage2.Controls.Add(_txtSegment_44)
        _SSTab1_TabPage2.Controls.Add(_txtSegment_43)
        _SSTab1_TabPage2.Controls.Add(_txtSegment_46)
        _SSTab1_TabPage2.Controls.Add(_txtSegment_45)
        _SSTab1_TabPage2.Controls.Add(_txtSegment_48)
        _SSTab1_TabPage2.Controls.Add(_txtSegment_47)
        _SSTab1_TabPage2.Font = New Font("Microsoft Sans Serif", 8.25F)
        _SSTab1_TabPage2.Location = New Point(4, 22)
        _SSTab1_TabPage2.Name = "_SSTab1_TabPage2"
        _SSTab1_TabPage2.Size = New Size(517, 403)
        _SSTab1_TabPage2.TabIndex = 2
        _SSTab1_TabPage2.Text = "Calibration Factors"
        ' 
        ' _Label3_1
        ' 
        _Label3_1.AllowDrop = True
        _Label3_1.BackColor = SystemColors.Control
        _Label3_1.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Underline)
        _Label3_1.ForeColor = SystemColors.ControlText
        _Label3_1.Location = New Point(256, 36)
        _Label3_1.MinimumSize = New Size(57, 25)
        _Label3_1.Name = "_Label3_1"
        _Label3_1.RightToLeft = RightToLeft.No
        _Label3_1.Size = New Size(57, 25)
        _Label3_1.TabIndex = 53
        _Label3_1.Text = "Mean"
        _Label3_1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' _lblSegments_17
        ' 
        _lblSegments_17.AllowDrop = True
        _lblSegments_17.BackColor = SystemColors.Control
        _lblSegments_17.Font = New Font("Microsoft Sans Serif", 9.75F)
        _lblSegments_17.ForeColor = SystemColors.ControlText
        _lblSegments_17.Location = New Point(48, 68)
        _lblSegments_17.MinimumSize = New Size(193, 25)
        _lblSegments_17.Name = "_lblSegments_17"
        _lblSegments_17.RightToLeft = RightToLeft.No
        _lblSegments_17.Size = New Size(193, 25)
        _lblSegments_17.TabIndex = 54
        _lblSegments_17.Text = "Dispersion Rate:"
        _lblSegments_17.TextAlign = ContentAlignment.TopRight
        ' 
        ' _lblSegments_16
        ' 
        _lblSegments_16.AllowDrop = True
        _lblSegments_16.BackColor = SystemColors.Control
        _lblSegments_16.Font = New Font("Microsoft Sans Serif", 9.75F)
        _lblSegments_16.ForeColor = SystemColors.ControlText
        _lblSegments_16.Location = New Point(48, 228)
        _lblSegments_16.MinimumSize = New Size(193, 25)
        _lblSegments_16.Name = "_lblSegments_16"
        _lblSegments_16.RightToLeft = RightToLeft.No
        _lblSegments_16.Size = New Size(193, 25)
        _lblSegments_16.TabIndex = 55
        _lblSegments_16.Text = "Organic Nitrogen:"
        _lblSegments_16.TextAlign = ContentAlignment.TopRight
        ' 
        ' _lblSegments_15
        ' 
        _lblSegments_15.AllowDrop = True
        _lblSegments_15.BackColor = SystemColors.Control
        _lblSegments_15.Font = New Font("Microsoft Sans Serif", 9.75F)
        _lblSegments_15.ForeColor = SystemColors.ControlText
        _lblSegments_15.Location = New Point(48, 196)
        _lblSegments_15.MinimumSize = New Size(193, 25)
        _lblSegments_15.Name = "_lblSegments_15"
        _lblSegments_15.RightToLeft = RightToLeft.No
        _lblSegments_15.Size = New Size(193, 25)
        _lblSegments_15.TabIndex = 56
        _lblSegments_15.Text = "Secchi Depth:"
        _lblSegments_15.TextAlign = ContentAlignment.TopRight
        ' 
        ' _lblSegments_14
        ' 
        _lblSegments_14.AllowDrop = True
        _lblSegments_14.BackColor = SystemColors.Control
        _lblSegments_14.Font = New Font("Microsoft Sans Serif", 9.75F)
        _lblSegments_14.ForeColor = SystemColors.ControlText
        _lblSegments_14.Location = New Point(48, 164)
        _lblSegments_14.MinimumSize = New Size(193, 25)
        _lblSegments_14.Name = "_lblSegments_14"
        _lblSegments_14.RightToLeft = RightToLeft.No
        _lblSegments_14.Size = New Size(193, 25)
        _lblSegments_14.TabIndex = 57
        _lblSegments_14.Text = "Chlorophyll-a:"
        _lblSegments_14.TextAlign = ContentAlignment.TopRight
        ' 
        ' _lblSegments_13
        ' 
        _lblSegments_13.AllowDrop = True
        _lblSegments_13.BackColor = SystemColors.Control
        _lblSegments_13.Font = New Font("Microsoft Sans Serif", 9.75F)
        _lblSegments_13.ForeColor = SystemColors.ControlText
        _lblSegments_13.Location = New Point(48, 132)
        _lblSegments_13.MinimumSize = New Size(193, 25)
        _lblSegments_13.Name = "_lblSegments_13"
        _lblSegments_13.RightToLeft = RightToLeft.No
        _lblSegments_13.Size = New Size(193, 25)
        _lblSegments_13.TabIndex = 58
        _lblSegments_13.Text = "Total Nitrogen:"
        _lblSegments_13.TextAlign = ContentAlignment.TopRight
        ' 
        ' _lblSegments_2
        ' 
        _lblSegments_2.AllowDrop = True
        _lblSegments_2.BackColor = SystemColors.Control
        _lblSegments_2.Font = New Font("Microsoft Sans Serif", 9.75F)
        _lblSegments_2.ForeColor = SystemColors.ControlText
        _lblSegments_2.Location = New Point(48, 100)
        _lblSegments_2.MinimumSize = New Size(193, 25)
        _lblSegments_2.Name = "_lblSegments_2"
        _lblSegments_2.RightToLeft = RightToLeft.No
        _lblSegments_2.Size = New Size(193, 25)
        _lblSegments_2.TabIndex = 59
        _lblSegments_2.Text = "Total Phosphorus:"
        _lblSegments_2.TextAlign = ContentAlignment.TopRight
        ' 
        ' _Label3_0
        ' 
        _Label3_0.AllowDrop = True
        _Label3_0.BackColor = SystemColors.Control
        _Label3_0.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Underline)
        _Label3_0.ForeColor = SystemColors.ControlText
        _Label3_0.Location = New Point(344, 36)
        _Label3_0.MinimumSize = New Size(57, 25)
        _Label3_0.Name = "_Label3_0"
        _Label3_0.RightToLeft = RightToLeft.No
        _Label3_0.Size = New Size(57, 25)
        _Label3_0.TabIndex = 60
        _Label3_0.Text = "CV"
        _Label3_0.TextAlign = ContentAlignment.TopCenter
        ' 
        ' _lblSegments_21
        ' 
        _lblSegments_21.AllowDrop = True
        _lblSegments_21.BackColor = SystemColors.Control
        _lblSegments_21.Font = New Font("Microsoft Sans Serif", 9.75F)
        _lblSegments_21.ForeColor = SystemColors.ControlText
        _lblSegments_21.Location = New Point(48, 260)
        _lblSegments_21.MinimumSize = New Size(193, 25)
        _lblSegments_21.Name = "_lblSegments_21"
        _lblSegments_21.RightToLeft = RightToLeft.No
        _lblSegments_21.Size = New Size(193, 25)
        _lblSegments_21.TabIndex = 81
        _lblSegments_21.Text = "Particulate (Total P - Ortho P):"
        _lblSegments_21.TextAlign = ContentAlignment.TopRight
        ' 
        ' _lblSegments_25
        ' 
        _lblSegments_25.AllowDrop = True
        _lblSegments_25.BackColor = SystemColors.Control
        _lblSegments_25.Font = New Font("Microsoft Sans Serif", 9.75F)
        _lblSegments_25.ForeColor = SystemColors.ControlText
        _lblSegments_25.Location = New Point(48, 292)
        _lblSegments_25.MinimumSize = New Size(193, 25)
        _lblSegments_25.Name = "_lblSegments_25"
        _lblSegments_25.RightToLeft = RightToLeft.No
        _lblSegments_25.Size = New Size(193, 25)
        _lblSegments_25.TabIndex = 83
        _lblSegments_25.Text = "Hypolimnetic O2 Depletion:"
        _lblSegments_25.TextAlign = ContentAlignment.TopRight
        ' 
        ' _lblSegments_26
        ' 
        _lblSegments_26.AllowDrop = True
        _lblSegments_26.BackColor = SystemColors.Control
        _lblSegments_26.Font = New Font("Microsoft Sans Serif", 9.75F)
        _lblSegments_26.ForeColor = SystemColors.ControlText
        _lblSegments_26.Location = New Point(48, 324)
        _lblSegments_26.MinimumSize = New Size(193, 25)
        _lblSegments_26.Name = "_lblSegments_26"
        _lblSegments_26.RightToLeft = RightToLeft.No
        _lblSegments_26.Size = New Size(193, 25)
        _lblSegments_26.TabIndex = 84
        _lblSegments_26.Text = "Metalimnetic O2 Depletion:"
        _lblSegments_26.TextAlign = ContentAlignment.TopRight
        ' 
        ' _lblSegments_27
        ' 
        _lblSegments_27.AllowDrop = True
        _lblSegments_27.BackColor = SystemColors.Control
        _lblSegments_27.Font = New Font("Microsoft Sans Serif", 9.75F)
        _lblSegments_27.ForeColor = SystemColors.ControlText
        _lblSegments_27.Location = New Point(48, 356)
        _lblSegments_27.MinimumSize = New Size(193, 25)
        _lblSegments_27.Name = "_lblSegments_27"
        _lblSegments_27.RightToLeft = RightToLeft.No
        _lblSegments_27.Size = New Size(193, 25)
        _lblSegments_27.TabIndex = 89
        _lblSegments_27.Text = "Defaults:"
        _lblSegments_27.TextAlign = ContentAlignment.TopRight
        ' 
        ' _lblSegments_29
        ' 
        _lblSegments_29.AllowDrop = True
        _lblSegments_29.BackColor = SystemColors.Control
        _lblSegments_29.Font = New Font("Microsoft Sans Serif", 9.75F)
        _lblSegments_29.ForeColor = SystemColors.ControlText
        _lblSegments_29.Location = New Point(344, 356)
        _lblSegments_29.MinimumSize = New Size(57, 25)
        _lblSegments_29.Name = "_lblSegments_29"
        _lblSegments_29.RightToLeft = RightToLeft.No
        _lblSegments_29.Size = New Size(57, 25)
        _lblSegments_29.TabIndex = 90
        _lblSegments_29.Text = "0"
        _lblSegments_29.TextAlign = ContentAlignment.TopCenter
        ' 
        ' _lblSegments_28
        ' 
        _lblSegments_28.AllowDrop = True
        _lblSegments_28.BackColor = SystemColors.Control
        _lblSegments_28.Font = New Font("Microsoft Sans Serif", 9.75F)
        _lblSegments_28.ForeColor = SystemColors.ControlText
        _lblSegments_28.Location = New Point(248, 356)
        _lblSegments_28.MinimumSize = New Size(81, 25)
        _lblSegments_28.Name = "_lblSegments_28"
        _lblSegments_28.RightToLeft = RightToLeft.No
        _lblSegments_28.Size = New Size(81, 25)
        _lblSegments_28.TabIndex = 91
        _lblSegments_28.Text = "1"
        _lblSegments_28.TextAlign = ContentAlignment.TopCenter
        ' 
        ' _txtSegment_33
        ' 
        _txtSegment_33.AcceptsReturn = True
        _txtSegment_33.AllowDrop = True
        _txtSegment_33.BackColor = SystemColors.Window
        _txtSegment_33.Cursor = Cursors.IBeam
        _txtSegment_33.Font = New Font("Microsoft Sans Serif", 9.75F)
        _txtSegment_33.ForeColor = SystemColors.WindowText
        _txtSegment_33.Location = New Point(248, 100)
        _txtSegment_33.MaxLength = 0
        _txtSegment_33.Name = "_txtSegment_33"
        _txtSegment_33.RightToLeft = RightToLeft.No
        _txtSegment_33.Size = New Size(81, 22)
        _txtSegment_33.TabIndex = 41
        _txtSegment_33.Text = "0"
        _txtSegment_33.TextAlign = HorizontalAlignment.Center
        ' 
        ' _txtSegment_32
        ' 
        _txtSegment_32.AcceptsReturn = True
        _txtSegment_32.AllowDrop = True
        _txtSegment_32.BackColor = SystemColors.Window
        _txtSegment_32.Cursor = Cursors.IBeam
        _txtSegment_32.Font = New Font("Microsoft Sans Serif", 9.75F)
        _txtSegment_32.ForeColor = SystemColors.WindowText
        _txtSegment_32.Location = New Point(344, 68)
        _txtSegment_32.MaxLength = 0
        _txtSegment_32.Name = "_txtSegment_32"
        _txtSegment_32.RightToLeft = RightToLeft.No
        _txtSegment_32.Size = New Size(57, 22)
        _txtSegment_32.TabIndex = 42
        _txtSegment_32.Text = "0"
        _txtSegment_32.TextAlign = HorizontalAlignment.Center
        ' 
        ' _txtSegment_31
        ' 
        _txtSegment_31.AcceptsReturn = True
        _txtSegment_31.AllowDrop = True
        _txtSegment_31.BackColor = SystemColors.Window
        _txtSegment_31.Cursor = Cursors.IBeam
        _txtSegment_31.Font = New Font("Microsoft Sans Serif", 9.75F)
        _txtSegment_31.ForeColor = SystemColors.WindowText
        _txtSegment_31.Location = New Point(248, 68)
        _txtSegment_31.MaxLength = 0
        _txtSegment_31.Name = "_txtSegment_31"
        _txtSegment_31.RightToLeft = RightToLeft.No
        _txtSegment_31.Size = New Size(81, 22)
        _txtSegment_31.TabIndex = 43
        _txtSegment_31.Text = "0"
        _txtSegment_31.TextAlign = HorizontalAlignment.Center
        ' 
        ' _txtSegment_34
        ' 
        _txtSegment_34.AcceptsReturn = True
        _txtSegment_34.AllowDrop = True
        _txtSegment_34.BackColor = SystemColors.Window
        _txtSegment_34.Cursor = Cursors.IBeam
        _txtSegment_34.Font = New Font("Microsoft Sans Serif", 9.75F)
        _txtSegment_34.ForeColor = SystemColors.WindowText
        _txtSegment_34.Location = New Point(344, 100)
        _txtSegment_34.MaxLength = 0
        _txtSegment_34.Name = "_txtSegment_34"
        _txtSegment_34.RightToLeft = RightToLeft.No
        _txtSegment_34.Size = New Size(57, 22)
        _txtSegment_34.TabIndex = 44
        _txtSegment_34.Text = "0"
        _txtSegment_34.TextAlign = HorizontalAlignment.Center
        ' 
        ' _txtSegment_35
        ' 
        _txtSegment_35.AcceptsReturn = True
        _txtSegment_35.AllowDrop = True
        _txtSegment_35.BackColor = SystemColors.Window
        _txtSegment_35.Cursor = Cursors.IBeam
        _txtSegment_35.Font = New Font("Microsoft Sans Serif", 9.75F)
        _txtSegment_35.ForeColor = SystemColors.WindowText
        _txtSegment_35.Location = New Point(248, 132)
        _txtSegment_35.MaxLength = 0
        _txtSegment_35.Name = "_txtSegment_35"
        _txtSegment_35.RightToLeft = RightToLeft.No
        _txtSegment_35.Size = New Size(81, 22)
        _txtSegment_35.TabIndex = 45
        _txtSegment_35.Text = "0"
        _txtSegment_35.TextAlign = HorizontalAlignment.Center
        ' 
        ' _txtSegment_36
        ' 
        _txtSegment_36.AcceptsReturn = True
        _txtSegment_36.AllowDrop = True
        _txtSegment_36.BackColor = SystemColors.Window
        _txtSegment_36.Cursor = Cursors.IBeam
        _txtSegment_36.Font = New Font("Microsoft Sans Serif", 9.75F)
        _txtSegment_36.ForeColor = SystemColors.WindowText
        _txtSegment_36.Location = New Point(344, 132)
        _txtSegment_36.MaxLength = 0
        _txtSegment_36.Name = "_txtSegment_36"
        _txtSegment_36.RightToLeft = RightToLeft.No
        _txtSegment_36.Size = New Size(57, 22)
        _txtSegment_36.TabIndex = 46
        _txtSegment_36.Text = "0"
        _txtSegment_36.TextAlign = HorizontalAlignment.Center
        ' 
        ' _txtSegment_37
        ' 
        _txtSegment_37.AcceptsReturn = True
        _txtSegment_37.AllowDrop = True
        _txtSegment_37.BackColor = SystemColors.Window
        _txtSegment_37.Cursor = Cursors.IBeam
        _txtSegment_37.Font = New Font("Microsoft Sans Serif", 9.75F)
        _txtSegment_37.ForeColor = SystemColors.WindowText
        _txtSegment_37.Location = New Point(248, 164)
        _txtSegment_37.MaxLength = 0
        _txtSegment_37.Name = "_txtSegment_37"
        _txtSegment_37.RightToLeft = RightToLeft.No
        _txtSegment_37.Size = New Size(81, 22)
        _txtSegment_37.TabIndex = 47
        _txtSegment_37.Text = "0"
        _txtSegment_37.TextAlign = HorizontalAlignment.Center
        ' 
        ' _txtSegment_38
        ' 
        _txtSegment_38.AcceptsReturn = True
        _txtSegment_38.AllowDrop = True
        _txtSegment_38.BackColor = SystemColors.Window
        _txtSegment_38.Cursor = Cursors.IBeam
        _txtSegment_38.Font = New Font("Microsoft Sans Serif", 9.75F)
        _txtSegment_38.ForeColor = SystemColors.WindowText
        _txtSegment_38.Location = New Point(344, 164)
        _txtSegment_38.MaxLength = 0
        _txtSegment_38.Name = "_txtSegment_38"
        _txtSegment_38.RightToLeft = RightToLeft.No
        _txtSegment_38.Size = New Size(57, 22)
        _txtSegment_38.TabIndex = 48
        _txtSegment_38.Text = "0"
        _txtSegment_38.TextAlign = HorizontalAlignment.Center
        ' 
        ' _txtSegment_39
        ' 
        _txtSegment_39.AcceptsReturn = True
        _txtSegment_39.AllowDrop = True
        _txtSegment_39.BackColor = SystemColors.Window
        _txtSegment_39.Cursor = Cursors.IBeam
        _txtSegment_39.Font = New Font("Microsoft Sans Serif", 9.75F)
        _txtSegment_39.ForeColor = SystemColors.WindowText
        _txtSegment_39.Location = New Point(248, 196)
        _txtSegment_39.MaxLength = 0
        _txtSegment_39.Name = "_txtSegment_39"
        _txtSegment_39.RightToLeft = RightToLeft.No
        _txtSegment_39.Size = New Size(81, 22)
        _txtSegment_39.TabIndex = 49
        _txtSegment_39.Text = "0"
        _txtSegment_39.TextAlign = HorizontalAlignment.Center
        ' 
        ' _txtSegment_40
        ' 
        _txtSegment_40.AcceptsReturn = True
        _txtSegment_40.AllowDrop = True
        _txtSegment_40.BackColor = SystemColors.Window
        _txtSegment_40.Cursor = Cursors.IBeam
        _txtSegment_40.Font = New Font("Microsoft Sans Serif", 9.75F)
        _txtSegment_40.ForeColor = SystemColors.WindowText
        _txtSegment_40.Location = New Point(344, 196)
        _txtSegment_40.MaxLength = 0
        _txtSegment_40.Name = "_txtSegment_40"
        _txtSegment_40.RightToLeft = RightToLeft.No
        _txtSegment_40.Size = New Size(57, 22)
        _txtSegment_40.TabIndex = 50
        _txtSegment_40.Text = "0"
        _txtSegment_40.TextAlign = HorizontalAlignment.Center
        ' 
        ' _txtSegment_41
        ' 
        _txtSegment_41.AcceptsReturn = True
        _txtSegment_41.AllowDrop = True
        _txtSegment_41.BackColor = SystemColors.Window
        _txtSegment_41.Cursor = Cursors.IBeam
        _txtSegment_41.Font = New Font("Microsoft Sans Serif", 9.75F)
        _txtSegment_41.ForeColor = SystemColors.WindowText
        _txtSegment_41.Location = New Point(248, 228)
        _txtSegment_41.MaxLength = 0
        _txtSegment_41.Name = "_txtSegment_41"
        _txtSegment_41.RightToLeft = RightToLeft.No
        _txtSegment_41.Size = New Size(81, 22)
        _txtSegment_41.TabIndex = 51
        _txtSegment_41.Text = "0"
        _txtSegment_41.TextAlign = HorizontalAlignment.Center
        ' 
        ' _txtSegment_42
        ' 
        _txtSegment_42.AcceptsReturn = True
        _txtSegment_42.AllowDrop = True
        _txtSegment_42.BackColor = SystemColors.Window
        _txtSegment_42.Cursor = Cursors.IBeam
        _txtSegment_42.Font = New Font("Microsoft Sans Serif", 9.75F)
        _txtSegment_42.ForeColor = SystemColors.WindowText
        _txtSegment_42.Location = New Point(344, 228)
        _txtSegment_42.MaxLength = 0
        _txtSegment_42.Name = "_txtSegment_42"
        _txtSegment_42.RightToLeft = RightToLeft.No
        _txtSegment_42.Size = New Size(57, 22)
        _txtSegment_42.TabIndex = 52
        _txtSegment_42.Text = "0"
        _txtSegment_42.TextAlign = HorizontalAlignment.Center
        ' 
        ' _txtSegment_44
        ' 
        _txtSegment_44.AcceptsReturn = True
        _txtSegment_44.AllowDrop = True
        _txtSegment_44.BackColor = SystemColors.Window
        _txtSegment_44.Cursor = Cursors.IBeam
        _txtSegment_44.Font = New Font("Microsoft Sans Serif", 9.75F)
        _txtSegment_44.ForeColor = SystemColors.WindowText
        _txtSegment_44.Location = New Point(344, 260)
        _txtSegment_44.MaxLength = 0
        _txtSegment_44.Name = "_txtSegment_44"
        _txtSegment_44.RightToLeft = RightToLeft.No
        _txtSegment_44.Size = New Size(57, 22)
        _txtSegment_44.TabIndex = 79
        _txtSegment_44.Text = "0"
        _txtSegment_44.TextAlign = HorizontalAlignment.Center
        ' 
        ' _txtSegment_43
        ' 
        _txtSegment_43.AcceptsReturn = True
        _txtSegment_43.AllowDrop = True
        _txtSegment_43.BackColor = SystemColors.Window
        _txtSegment_43.Cursor = Cursors.IBeam
        _txtSegment_43.Font = New Font("Microsoft Sans Serif", 9.75F)
        _txtSegment_43.ForeColor = SystemColors.WindowText
        _txtSegment_43.Location = New Point(248, 260)
        _txtSegment_43.MaxLength = 0
        _txtSegment_43.Name = "_txtSegment_43"
        _txtSegment_43.RightToLeft = RightToLeft.No
        _txtSegment_43.Size = New Size(81, 22)
        _txtSegment_43.TabIndex = 80
        _txtSegment_43.Text = "0"
        _txtSegment_43.TextAlign = HorizontalAlignment.Center
        ' 
        ' _txtSegment_46
        ' 
        _txtSegment_46.AcceptsReturn = True
        _txtSegment_46.AllowDrop = True
        _txtSegment_46.BackColor = SystemColors.Window
        _txtSegment_46.Cursor = Cursors.IBeam
        _txtSegment_46.Font = New Font("Microsoft Sans Serif", 9.75F)
        _txtSegment_46.ForeColor = SystemColors.WindowText
        _txtSegment_46.Location = New Point(344, 292)
        _txtSegment_46.MaxLength = 0
        _txtSegment_46.Name = "_txtSegment_46"
        _txtSegment_46.RightToLeft = RightToLeft.No
        _txtSegment_46.Size = New Size(57, 22)
        _txtSegment_46.TabIndex = 85
        _txtSegment_46.Text = "0"
        _txtSegment_46.TextAlign = HorizontalAlignment.Center
        ' 
        ' _txtSegment_45
        ' 
        _txtSegment_45.AcceptsReturn = True
        _txtSegment_45.AllowDrop = True
        _txtSegment_45.BackColor = SystemColors.Window
        _txtSegment_45.Cursor = Cursors.IBeam
        _txtSegment_45.Font = New Font("Microsoft Sans Serif", 9.75F)
        _txtSegment_45.ForeColor = SystemColors.WindowText
        _txtSegment_45.Location = New Point(248, 292)
        _txtSegment_45.MaxLength = 0
        _txtSegment_45.Name = "_txtSegment_45"
        _txtSegment_45.RightToLeft = RightToLeft.No
        _txtSegment_45.Size = New Size(81, 22)
        _txtSegment_45.TabIndex = 86
        _txtSegment_45.Text = "0"
        _txtSegment_45.TextAlign = HorizontalAlignment.Center
        ' 
        ' _txtSegment_48
        ' 
        _txtSegment_48.AcceptsReturn = True
        _txtSegment_48.AllowDrop = True
        _txtSegment_48.BackColor = SystemColors.Window
        _txtSegment_48.Cursor = Cursors.IBeam
        _txtSegment_48.Font = New Font("Microsoft Sans Serif", 9.75F)
        _txtSegment_48.ForeColor = SystemColors.WindowText
        _txtSegment_48.Location = New Point(344, 324)
        _txtSegment_48.MaxLength = 0
        _txtSegment_48.Name = "_txtSegment_48"
        _txtSegment_48.RightToLeft = RightToLeft.No
        _txtSegment_48.Size = New Size(57, 22)
        _txtSegment_48.TabIndex = 87
        _txtSegment_48.Text = "0"
        _txtSegment_48.TextAlign = HorizontalAlignment.Center
        ' 
        ' _txtSegment_47
        ' 
        _txtSegment_47.AcceptsReturn = True
        _txtSegment_47.AllowDrop = True
        _txtSegment_47.BackColor = SystemColors.Window
        _txtSegment_47.Cursor = Cursors.IBeam
        _txtSegment_47.Font = New Font("Microsoft Sans Serif", 9.75F)
        _txtSegment_47.ForeColor = SystemColors.WindowText
        _txtSegment_47.Location = New Point(248, 324)
        _txtSegment_47.MaxLength = 0
        _txtSegment_47.Name = "_txtSegment_47"
        _txtSegment_47.RightToLeft = RightToLeft.No
        _txtSegment_47.Size = New Size(81, 22)
        _txtSegment_47.TabIndex = 88
        _txtSegment_47.Text = "0"
        _txtSegment_47.TextAlign = HorizontalAlignment.Center
        ' 
        ' _SSTab1_TabPage3
        ' 
        _SSTab1_TabPage3.Controls.Add(_txtSegment_49)
        _SSTab1_TabPage3.Controls.Add(_txtSegment_50)
        _SSTab1_TabPage3.Controls.Add(_txtSegment_51)
        _SSTab1_TabPage3.Controls.Add(_txtSegment_52)
        _SSTab1_TabPage3.Controls.Add(_txtSegment_53)
        _SSTab1_TabPage3.Controls.Add(_txtSegment_54)
        _SSTab1_TabPage3.Controls.Add(_lblSegments_32)
        _SSTab1_TabPage3.Controls.Add(_lblSegments_31)
        _SSTab1_TabPage3.Controls.Add(_lblSegments_30)
        _SSTab1_TabPage3.Controls.Add(_lblSegments_18)
        _SSTab1_TabPage3.Controls.Add(_lblSegments_19)
        _SSTab1_TabPage3.Controls.Add(_lblSegments_23)
        _SSTab1_TabPage3.Controls.Add(_Label3_6)
        _SSTab1_TabPage3.Controls.Add(_Label3_7)
        _SSTab1_TabPage3.Controls.Add(_Label3_8)
        _SSTab1_TabPage3.Font = New Font("Microsoft Sans Serif", 8.25F)
        _SSTab1_TabPage3.Location = New Point(4, 22)
        _SSTab1_TabPage3.Name = "_SSTab1_TabPage3"
        _SSTab1_TabPage3.Size = New Size(517, 403)
        _SSTab1_TabPage3.TabIndex = 3
        _SSTab1_TabPage3.Text = "Internal Load"
        ' 
        ' _txtSegment_49
        ' 
        _txtSegment_49.AcceptsReturn = True
        _txtSegment_49.AllowDrop = True
        _txtSegment_49.BackColor = SystemColors.Window
        _txtSegment_49.Cursor = Cursors.IBeam
        _txtSegment_49.Font = New Font("Microsoft Sans Serif", 9.75F)
        _txtSegment_49.ForeColor = SystemColors.WindowText
        _txtSegment_49.Location = New Point(232, 124)
        _txtSegment_49.MaxLength = 0
        _txtSegment_49.Name = "_txtSegment_49"
        _txtSegment_49.RightToLeft = RightToLeft.No
        _txtSegment_49.Size = New Size(57, 22)
        _txtSegment_49.TabIndex = 66
        _txtSegment_49.Text = "0"
        _txtSegment_49.TextAlign = HorizontalAlignment.Center
        ' 
        ' _txtSegment_50
        ' 
        _txtSegment_50.AcceptsReturn = True
        _txtSegment_50.AllowDrop = True
        _txtSegment_50.BackColor = SystemColors.Window
        _txtSegment_50.Cursor = Cursors.IBeam
        _txtSegment_50.Font = New Font("Microsoft Sans Serif", 9.75F)
        _txtSegment_50.ForeColor = SystemColors.WindowText
        _txtSegment_50.Location = New Point(312, 124)
        _txtSegment_50.MaxLength = 0
        _txtSegment_50.Name = "_txtSegment_50"
        _txtSegment_50.RightToLeft = RightToLeft.No
        _txtSegment_50.Size = New Size(57, 22)
        _txtSegment_50.TabIndex = 65
        _txtSegment_50.Text = "0"
        _txtSegment_50.TextAlign = HorizontalAlignment.Center
        ' 
        ' _txtSegment_51
        ' 
        _txtSegment_51.AcceptsReturn = True
        _txtSegment_51.AllowDrop = True
        _txtSegment_51.BackColor = SystemColors.Window
        _txtSegment_51.Cursor = Cursors.IBeam
        _txtSegment_51.Font = New Font("Microsoft Sans Serif", 9.75F)
        _txtSegment_51.ForeColor = SystemColors.WindowText
        _txtSegment_51.Location = New Point(232, 162)
        _txtSegment_51.MaxLength = 0
        _txtSegment_51.Name = "_txtSegment_51"
        _txtSegment_51.RightToLeft = RightToLeft.No
        _txtSegment_51.Size = New Size(57, 22)
        _txtSegment_51.TabIndex = 64
        _txtSegment_51.Text = "0"
        _txtSegment_51.TextAlign = HorizontalAlignment.Center
        ' 
        ' _txtSegment_52
        ' 
        _txtSegment_52.AcceptsReturn = True
        _txtSegment_52.AllowDrop = True
        _txtSegment_52.BackColor = SystemColors.Window
        _txtSegment_52.Cursor = Cursors.IBeam
        _txtSegment_52.Font = New Font("Microsoft Sans Serif", 9.75F)
        _txtSegment_52.ForeColor = SystemColors.WindowText
        _txtSegment_52.Location = New Point(312, 162)
        _txtSegment_52.MaxLength = 0
        _txtSegment_52.Name = "_txtSegment_52"
        _txtSegment_52.RightToLeft = RightToLeft.No
        _txtSegment_52.Size = New Size(57, 22)
        _txtSegment_52.TabIndex = 63
        _txtSegment_52.Text = "0"
        _txtSegment_52.TextAlign = HorizontalAlignment.Center
        ' 
        ' _txtSegment_53
        ' 
        _txtSegment_53.AcceptsReturn = True
        _txtSegment_53.AllowDrop = True
        _txtSegment_53.BackColor = SystemColors.Window
        _txtSegment_53.Cursor = Cursors.IBeam
        _txtSegment_53.Font = New Font("Microsoft Sans Serif", 9.75F)
        _txtSegment_53.ForeColor = SystemColors.WindowText
        _txtSegment_53.Location = New Point(232, 200)
        _txtSegment_53.MaxLength = 0
        _txtSegment_53.Name = "_txtSegment_53"
        _txtSegment_53.RightToLeft = RightToLeft.No
        _txtSegment_53.Size = New Size(57, 22)
        _txtSegment_53.TabIndex = 62
        _txtSegment_53.Text = "0"
        _txtSegment_53.TextAlign = HorizontalAlignment.Center
        ' 
        ' _txtSegment_54
        ' 
        _txtSegment_54.AcceptsReturn = True
        _txtSegment_54.AllowDrop = True
        _txtSegment_54.BackColor = SystemColors.Window
        _txtSegment_54.Cursor = Cursors.IBeam
        _txtSegment_54.Font = New Font("Microsoft Sans Serif", 9.75F)
        _txtSegment_54.ForeColor = SystemColors.WindowText
        _txtSegment_54.Location = New Point(312, 200)
        _txtSegment_54.MaxLength = 0
        _txtSegment_54.Name = "_txtSegment_54"
        _txtSegment_54.RightToLeft = RightToLeft.No
        _txtSegment_54.Size = New Size(57, 22)
        _txtSegment_54.TabIndex = 61
        _txtSegment_54.Text = "0"
        _txtSegment_54.TextAlign = HorizontalAlignment.Center
        ' 
        ' _lblSegments_32
        ' 
        _lblSegments_32.AllowDrop = True
        _lblSegments_32.BackColor = SystemColors.Control
        _lblSegments_32.Font = New Font("Microsoft Sans Serif", 9.75F)
        _lblSegments_32.ForeColor = SystemColors.ControlText
        _lblSegments_32.Location = New Point(232, 236)
        _lblSegments_32.MinimumSize = New Size(57, 25)
        _lblSegments_32.Name = "_lblSegments_32"
        _lblSegments_32.RightToLeft = RightToLeft.No
        _lblSegments_32.Size = New Size(57, 25)
        _lblSegments_32.TabIndex = 94
        _lblSegments_32.Text = "0"
        _lblSegments_32.TextAlign = ContentAlignment.TopCenter
        ' 
        ' _lblSegments_31
        ' 
        _lblSegments_31.AllowDrop = True
        _lblSegments_31.BackColor = SystemColors.Control
        _lblSegments_31.Font = New Font("Microsoft Sans Serif", 9.75F)
        _lblSegments_31.ForeColor = SystemColors.ControlText
        _lblSegments_31.Location = New Point(312, 236)
        _lblSegments_31.MinimumSize = New Size(57, 25)
        _lblSegments_31.Name = "_lblSegments_31"
        _lblSegments_31.RightToLeft = RightToLeft.No
        _lblSegments_31.Size = New Size(57, 25)
        _lblSegments_31.TabIndex = 93
        _lblSegments_31.Text = "0"
        _lblSegments_31.TextAlign = ContentAlignment.TopCenter
        ' 
        ' _lblSegments_30
        ' 
        _lblSegments_30.AllowDrop = True
        _lblSegments_30.BackColor = SystemColors.Control
        _lblSegments_30.Font = New Font("Microsoft Sans Serif", 9.75F)
        _lblSegments_30.ForeColor = SystemColors.ControlText
        _lblSegments_30.Location = New Point(32, 236)
        _lblSegments_30.MinimumSize = New Size(193, 25)
        _lblSegments_30.Name = "_lblSegments_30"
        _lblSegments_30.RightToLeft = RightToLeft.No
        _lblSegments_30.Size = New Size(193, 25)
        _lblSegments_30.TabIndex = 92
        _lblSegments_30.Text = "Defaults:"
        _lblSegments_30.TextAlign = ContentAlignment.TopRight
        ' 
        ' _lblSegments_18
        ' 
        _lblSegments_18.AllowDrop = True
        _lblSegments_18.BackColor = SystemColors.Control
        _lblSegments_18.Font = New Font("Microsoft Sans Serif", 9.75F)
        _lblSegments_18.ForeColor = SystemColors.ControlText
        _lblSegments_18.Location = New Point(64, 164)
        _lblSegments_18.MinimumSize = New Size(161, 25)
        _lblSegments_18.Name = "_lblSegments_18"
        _lblSegments_18.RightToLeft = RightToLeft.No
        _lblSegments_18.Size = New Size(161, 25)
        _lblSegments_18.TabIndex = 72
        _lblSegments_18.Text = "Total Phosphorus:"
        _lblSegments_18.TextAlign = ContentAlignment.TopRight
        ' 
        ' _lblSegments_19
        ' 
        _lblSegments_19.AllowDrop = True
        _lblSegments_19.BackColor = SystemColors.Control
        _lblSegments_19.Font = New Font("Microsoft Sans Serif", 9.75F)
        _lblSegments_19.ForeColor = SystemColors.ControlText
        _lblSegments_19.Location = New Point(72, 202)
        _lblSegments_19.MinimumSize = New Size(153, 25)
        _lblSegments_19.Name = "_lblSegments_19"
        _lblSegments_19.RightToLeft = RightToLeft.No
        _lblSegments_19.Size = New Size(153, 25)
        _lblSegments_19.TabIndex = 71
        _lblSegments_19.Text = "Total Nitrogen:"
        _lblSegments_19.TextAlign = ContentAlignment.TopRight
        ' 
        ' _lblSegments_23
        ' 
        _lblSegments_23.AllowDrop = True
        _lblSegments_23.BackColor = SystemColors.Control
        _lblSegments_23.Font = New Font("Microsoft Sans Serif", 9.75F)
        _lblSegments_23.ForeColor = SystemColors.ControlText
        _lblSegments_23.Location = New Point(64, 124)
        _lblSegments_23.MinimumSize = New Size(161, 25)
        _lblSegments_23.Name = "_lblSegments_23"
        _lblSegments_23.RightToLeft = RightToLeft.No
        _lblSegments_23.Size = New Size(161, 25)
        _lblSegments_23.TabIndex = 70
        _lblSegments_23.Text = "Conservative Substance:"
        _lblSegments_23.TextAlign = ContentAlignment.TopRight
        ' 
        ' _Label3_6
        ' 
        _Label3_6.AllowDrop = True
        _Label3_6.BackColor = SystemColors.Control
        _Label3_6.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Underline)
        _Label3_6.ForeColor = SystemColors.ControlText
        _Label3_6.Location = New Point(232, 92)
        _Label3_6.MinimumSize = New Size(57, 25)
        _Label3_6.Name = "_Label3_6"
        _Label3_6.RightToLeft = RightToLeft.No
        _Label3_6.Size = New Size(57, 25)
        _Label3_6.TabIndex = 69
        _Label3_6.Text = "Mean"
        _Label3_6.TextAlign = ContentAlignment.TopCenter
        ' 
        ' _Label3_7
        ' 
        _Label3_7.AllowDrop = True
        _Label3_7.BackColor = SystemColors.Control
        _Label3_7.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Underline)
        _Label3_7.ForeColor = SystemColors.ControlText
        _Label3_7.Location = New Point(312, 92)
        _Label3_7.MinimumSize = New Size(57, 25)
        _Label3_7.Name = "_Label3_7"
        _Label3_7.RightToLeft = RightToLeft.No
        _Label3_7.Size = New Size(57, 25)
        _Label3_7.TabIndex = 68
        _Label3_7.Text = "CV"
        _Label3_7.TextAlign = ContentAlignment.TopCenter
        ' 
        ' _Label3_8
        ' 
        _Label3_8.AllowDrop = True
        _Label3_8.BackColor = SystemColors.Control
        _Label3_8.Font = New Font("Microsoft Sans Serif", 9.75F)
        _Label3_8.ForeColor = SystemColors.ControlText
        _Label3_8.Location = New Point(184, 52)
        _Label3_8.MinimumSize = New Size(169, 25)
        _Label3_8.Name = "_Label3_8"
        _Label3_8.RightToLeft = RightToLeft.No
        _Label3_8.Size = New Size(169, 25)
        _Label3_8.TabIndex = 67
        _Label3_8.Text = "Units:  mg/m2-day"
        _Label3_8.TextAlign = ContentAlignment.TopCenter
        ' 
        ' _txtSegment_0
        ' 
        _txtSegment_0.AcceptsReturn = True
        _txtSegment_0.AllowDrop = True
        _txtSegment_0.BackColor = SystemColors.Window
        _txtSegment_0.Cursor = Cursors.IBeam
        _txtSegment_0.Font = New Font("Microsoft Sans Serif", 9.75F)
        _txtSegment_0.ForeColor = SystemColors.WindowText
        _txtSegment_0.Location = New Point(96, 56)
        _txtSegment_0.MaxLength = 0
        _txtSegment_0.Name = "_txtSegment_0"
        _txtSegment_0.RightToLeft = RightToLeft.No
        _txtSegment_0.Size = New Size(49, 22)
        _txtSegment_0.TabIndex = 76
        _txtSegment_0.Text = "0"
        _txtSegment_0.TextAlign = HorizontalAlignment.Center
        ' 
        ' Toolbar1
        ' 
        Toolbar1.AllowDrop = True
        Toolbar1.Font = New Font("Microsoft Sans Serif", 8.25F)
        Toolbar1.Items.AddRange(New ToolStripItem() {Toolbar1_Buttons_Button1, Toolbar1_Buttons_Button2, Toolbar1_Buttons_Button3, Toolbar1_Buttons_Button4, Toolbar1_Buttons_Button5, Toolbar1_Buttons_Button6, Toolbar1_Buttons_Button7, Toolbar1_Buttons_Button8, Toolbar1_Buttons_Button9})
        Toolbar1.Location = New Point(0, 0)
        Toolbar1.Name = "Toolbar1"
        Toolbar1.Size = New Size(571, 25)
        Toolbar1.TabIndex = 77
        ' 
        ' Toolbar1_Buttons_Button1
        ' 
        Toolbar1_Buttons_Button1.ImageScaling = ToolStripItemImageScaling.None
        Toolbar1_Buttons_Button1.Name = "Toolbar1_Buttons_Button1"
        Toolbar1_Buttons_Button1.Size = New Size(27, 22)
        Toolbar1_Buttons_Button1.Text = "List"
        Toolbar1_Buttons_Button1.TextImageRelation = TextImageRelation.ImageAboveText
        Toolbar1_Buttons_Button1.ToolTipText = "List segment & tributary network"
        ' 
        ' Toolbar1_Buttons_Button2
        ' 
        Toolbar1_Buttons_Button2.ImageScaling = ToolStripItemImageScaling.None
        Toolbar1_Buttons_Button2.Name = "Toolbar1_Buttons_Button2"
        Toolbar1_Buttons_Button2.Size = New Size(30, 22)
        Toolbar1_Buttons_Button2.Text = "Add"
        Toolbar1_Buttons_Button2.TextImageRelation = TextImageRelation.ImageAboveText
        Toolbar1_Buttons_Button2.ToolTipText = "Add a new segment at end of the segment list"
        ' 
        ' Toolbar1_Buttons_Button3
        ' 
        Toolbar1_Buttons_Button3.ImageScaling = ToolStripItemImageScaling.None
        Toolbar1_Buttons_Button3.Name = "Toolbar1_Buttons_Button3"
        Toolbar1_Buttons_Button3.Size = New Size(37, 22)
        Toolbar1_Buttons_Button3.Text = "Insert"
        Toolbar1_Buttons_Button3.TextImageRelation = TextImageRelation.ImageAboveText
        Toolbar1_Buttons_Button3.ToolTipText = "Insert a new segment after the selected one"
        ' 
        ' Toolbar1_Buttons_Button4
        ' 
        Toolbar1_Buttons_Button4.ImageScaling = ToolStripItemImageScaling.None
        Toolbar1_Buttons_Button4.Name = "Toolbar1_Buttons_Button4"
        Toolbar1_Buttons_Button4.Size = New Size(42, 22)
        Toolbar1_Buttons_Button4.Text = "Delete"
        Toolbar1_Buttons_Button4.TextImageRelation = TextImageRelation.ImageAboveText
        Toolbar1_Buttons_Button4.ToolTipText = "Delete selected segment"
        ' 
        ' Toolbar1_Buttons_Button5
        ' 
        Toolbar1_Buttons_Button5.ImageScaling = ToolStripItemImageScaling.None
        Toolbar1_Buttons_Button5.Name = "Toolbar1_Buttons_Button5"
        Toolbar1_Buttons_Button5.Size = New Size(35, 22)
        Toolbar1_Buttons_Button5.Text = "Clear"
        Toolbar1_Buttons_Button5.TextImageRelation = TextImageRelation.ImageAboveText
        Toolbar1_Buttons_Button5.ToolTipText = "Assign default values to all input values for selected segment"
        ' 
        ' Toolbar1_Buttons_Button6
        ' 
        Toolbar1_Buttons_Button6.ImageScaling = ToolStripItemImageScaling.None
        Toolbar1_Buttons_Button6.Name = "Toolbar1_Buttons_Button6"
        Toolbar1_Buttons_Button6.Size = New Size(37, 22)
        Toolbar1_Buttons_Button6.Text = "Undo"
        Toolbar1_Buttons_Button6.TextImageRelation = TextImageRelation.ImageAboveText
        Toolbar1_Buttons_Button6.ToolTipText = "Restore initial values for all segments"
        ' 
        ' Toolbar1_Buttons_Button7
        ' 
        Toolbar1_Buttons_Button7.ImageScaling = ToolStripItemImageScaling.None
        Toolbar1_Buttons_Button7.Name = "Toolbar1_Buttons_Button7"
        Toolbar1_Buttons_Button7.Size = New Size(33, 22)
        Toolbar1_Buttons_Button7.Text = "Help"
        Toolbar1_Buttons_Button7.TextImageRelation = TextImageRelation.ImageAboveText
        Toolbar1_Buttons_Button7.ToolTipText = "Get Help"
        ' 
        ' Toolbar1_Buttons_Button8
        ' 
        Toolbar1_Buttons_Button8.ImageScaling = ToolStripItemImageScaling.None
        Toolbar1_Buttons_Button8.Name = "Toolbar1_Buttons_Button8"
        Toolbar1_Buttons_Button8.Size = New Size(44, 22)
        Toolbar1_Buttons_Button8.Text = "Cancel"
        Toolbar1_Buttons_Button8.TextImageRelation = TextImageRelation.ImageAboveText
        Toolbar1_Buttons_Button8.ToolTipText = "Ignore edits & return to menu"
        ' 
        ' Toolbar1_Buttons_Button9
        ' 
        Toolbar1_Buttons_Button9.ImageScaling = ToolStripItemImageScaling.None
        Toolbar1_Buttons_Button9.Name = "Toolbar1_Buttons_Button9"
        Toolbar1_Buttons_Button9.Size = New Size(26, 22)
        Toolbar1_Buttons_Button9.Text = "OK"
        Toolbar1_Buttons_Button9.TextImageRelation = TextImageRelation.ImageAboveText
        Toolbar1_Buttons_Button9.ToolTipText = "Keep edits & return to program menu"
        ' 
        ' _lblSegments_24
        ' 
        _lblSegments_24.AllowDrop = True
        _lblSegments_24.BackColor = SystemColors.Control
        _lblSegments_24.Font = New Font("Microsoft Sans Serif", 9.75F)
        _lblSegments_24.ForeColor = SystemColors.ControlText
        _lblSegments_24.Location = New Point(56, 440)
        _lblSegments_24.MinimumSize = New Size(193, 25)
        _lblSegments_24.Name = "_lblSegments_24"
        _lblSegments_24.RightToLeft = RightToLeft.No
        _lblSegments_24.Size = New Size(193, 25)
        _lblSegments_24.TabIndex = 82
        _lblSegments_24.Text = "Hypol. O2 Depletion (ppb/day):"
        _lblSegments_24.TextAlign = ContentAlignment.TopRight
        ' 
        ' lblCount
        ' 
        lblCount.AllowDrop = True
        lblCount.BackColor = SystemColors.Control
        lblCount.Font = New Font("Microsoft Sans Serif", 9.75F)
        lblCount.ForeColor = SystemColors.ControlText
        lblCount.Location = New Point(264, 56)
        lblCount.MinimumSize = New Size(193, 25)
        lblCount.Name = "lblCount"
        lblCount.RightToLeft = RightToLeft.No
        lblCount.Size = New Size(193, 25)
        lblCount.TabIndex = 78
        lblCount.Text = "Label1"
        ' 
        ' lblDefinitions
        ' 
        lblDefinitions.AllowDrop = True
        lblDefinitions.BackColor = SystemColors.Control
        lblDefinitions.Font = New Font("Microsoft Sans Serif", 9.75F)
        lblDefinitions.ForeColor = SystemColors.Highlight
        lblDefinitions.Location = New Point(64, 104)
        lblDefinitions.MinimumSize = New Size(401, 17)
        lblDefinitions.Name = "lblDefinitions"
        lblDefinitions.RightToLeft = RightToLeft.No
        lblDefinitions.Size = New Size(401, 17)
        lblDefinitions.TabIndex = 73
        lblDefinitions.Text = "Label1"
        lblDefinitions.TextAlign = ContentAlignment.TopCenter
        ' 
        ' frmSegments
        ' 
        AllowDrop = True
        AutoScaleDimensions = New SizeF(6F, 13F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(571, 573)
        Controls.Add(Combo1)
        Controls.Add(SSTab1)
        Controls.Add(_txtSegment_0)
        Controls.Add(Toolbar1)
        Controls.Add(_lblSegments_24)
        Controls.Add(lblCount)
        Controls.Add(lblDefinitions)
        Font = New Font("Microsoft Sans Serif", 8.25F)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Location = New Point(10, 29)
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmSegments"
        RightToLeft = RightToLeft.No
        ShowInTaskbar = False
        Text = "Edit Segment Data"
        SSTab1.ResumeLayout(False)
        _SSTab1_TabPage0.ResumeLayout(False)
        _SSTab1_TabPage0.PerformLayout()
        _SSTab1_TabPage1.ResumeLayout(False)
        _SSTab1_TabPage1.PerformLayout()
        _SSTab1_TabPage2.ResumeLayout(False)
        _SSTab1_TabPage2.PerformLayout()
        _SSTab1_TabPage3.ResumeLayout(False)
        _SSTab1_TabPage3.PerformLayout()
        Toolbar1.ResumeLayout(False)
        Toolbar1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Sub ReLoadForm(ByVal addEvents As Boolean)
		InitializetxtSegment()
		InitializelblSegments()
		InitializelblSegment()
		InitializeLabel3()
		If addEvents Then
			AddHandler MyBase.MouseMove, AddressOf Form_MouseMove
			AddHandler MyBase.Closed, AddressOf Form_Closed
			AddHandler Activated, AddressOf frmSegments_Activated
		End If
	End Sub
	Sub InitializetxtSegment()
		ReDim txtSegment(54)
		txtSegment(15) = _txtSegment_15
		txtSegment(27) = _txtSegment_27
		txtSegment(25) = _txtSegment_25
		txtSegment(23) = _txtSegment_23
		txtSegment(21) = _txtSegment_21
		txtSegment(19) = _txtSegment_19
		txtSegment(17) = _txtSegment_17
		txtSegment(29) = _txtSegment_29
		txtSegment(12) = _txtSegment_12
		txtSegment(11) = _txtSegment_11
		txtSegment(13) = _txtSegment_13
		txtSegment(47) = _txtSegment_47
		txtSegment(48) = _txtSegment_48
		txtSegment(45) = _txtSegment_45
		txtSegment(46) = _txtSegment_46
		txtSegment(43) = _txtSegment_43
		txtSegment(44) = _txtSegment_44
		txtSegment(49) = _txtSegment_49
		txtSegment(50) = _txtSegment_50
		txtSegment(51) = _txtSegment_51
		txtSegment(52) = _txtSegment_52
		txtSegment(53) = _txtSegment_53
		txtSegment(54) = _txtSegment_54
		txtSegment(42) = _txtSegment_42
		txtSegment(41) = _txtSegment_41
		txtSegment(40) = _txtSegment_40
		txtSegment(39) = _txtSegment_39
		txtSegment(38) = _txtSegment_38
		txtSegment(37) = _txtSegment_37
		txtSegment(36) = _txtSegment_36
		txtSegment(35) = _txtSegment_35
		txtSegment(34) = _txtSegment_34
		txtSegment(31) = _txtSegment_31
		txtSegment(32) = _txtSegment_32
		txtSegment(33) = _txtSegment_33
		txtSegment(14) = _txtSegment_14
		txtSegment(16) = _txtSegment_16
		txtSegment(18) = _txtSegment_18
		txtSegment(20) = _txtSegment_20
		txtSegment(22) = _txtSegment_22
		txtSegment(24) = _txtSegment_24
		txtSegment(26) = _txtSegment_26
		txtSegment(28) = _txtSegment_28
		txtSegment(30) = _txtSegment_30
		txtSegment(1) = _txtSegment_1
		txtSegment(3) = _txtSegment_3
		txtSegment(4) = _txtSegment_4
		txtSegment(5) = _txtSegment_5
		txtSegment(6) = _txtSegment_6
		txtSegment(7) = _txtSegment_7
		txtSegment(8) = _txtSegment_8
		txtSegment(9) = _txtSegment_9
		txtSegment(10) = _txtSegment_10
		txtSegment(2) = _txtSegment_2
		txtSegment(0) = _txtSegment_0
	End Sub
	Sub InitializelblSegments()
		ReDim lblSegments(36)
		lblSegments(3) = _lblSegments_3
		lblSegments(35) = _lblSegments_35
		lblSegments(36) = _lblSegments_36
		lblSegments(34) = _lblSegments_34
		lblSegments(33) = _lblSegments_33
		lblSegments(22) = _lblSegments_22
		lblSegments(20) = _lblSegments_20
		lblSegments(32) = _lblSegments_32
		lblSegments(31) = _lblSegments_31
		lblSegments(30) = _lblSegments_30
		lblSegments(28) = _lblSegments_28
		lblSegments(29) = _lblSegments_29
		lblSegments(27) = _lblSegments_27
		lblSegments(26) = _lblSegments_26
		lblSegments(25) = _lblSegments_25
		lblSegments(21) = _lblSegments_21
		lblSegments(18) = _lblSegments_18
		lblSegments(19) = _lblSegments_19
		lblSegments(23) = _lblSegments_23
		lblSegments(2) = _lblSegments_2
		lblSegments(13) = _lblSegments_13
		lblSegments(14) = _lblSegments_14
		lblSegments(15) = _lblSegments_15
		lblSegments(16) = _lblSegments_16
		lblSegments(17) = _lblSegments_17
		lblSegments(5) = _lblSegments_5
		lblSegments(6) = _lblSegments_6
		lblSegments(7) = _lblSegments_7
		lblSegments(8) = _lblSegments_8
		lblSegments(9) = _lblSegments_9
		lblSegments(10) = _lblSegments_10
		lblSegments(11) = _lblSegments_11
		lblSegments(12) = _lblSegments_12
		lblSegments(4) = _lblSegments_4
		lblSegments(0) = _lblSegments_0
		lblSegments(1) = _lblSegments_1
		lblSegments(24) = _lblSegments_24
	End Sub
	Sub InitializelblSegment()
		ReDim lblSegment(7)
		lblSegment(0) = _lblSegment_0
		lblSegment(7) = _lblSegment_7
		lblSegment(3) = _lblSegment_3
		lblSegment(4) = _lblSegment_4
		lblSegment(5) = _lblSegment_5
		lblSegment(6) = _lblSegment_6
	End Sub
	Sub InitializeLabel3()
		ReDim Label3(8)
		Label3(6) = _Label3_6
		Label3(7) = _Label3_7
		Label3(8) = _Label3_8
		Label3(0) = _Label3_0
		Label3(1) = _Label3_1
		Label3(2) = _Label3_2
		Label3(3) = _Label3_3
		Label3(4) = _Label3_4
		Label3(5) = _Label3_5
	End Sub
#End Region
End Class