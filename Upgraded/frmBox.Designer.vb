<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBox
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As frmBox
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As frmBox
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = CreateInstance()
				m_InitializingDefInstance = False
			End If
			Return m_vb6FormDefInstance
		End Get
		Set(ByVal Value As frmBox)
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region
#Region "Windows Form Designer generated code "
	Public Shared Function CreateInstance() As frmBox
		Dim theInstance As New frmBox()
		Return theInstance
	End Function
	Private visualControls() As String = New String() {"components", "ToolTipMain", "CommonDialog1Save", "CommonDialog1", "txtBox", "Toolbar1_Buttons_Button1", "Toolbar1_Buttons_Button2", "Toolbar1_Buttons_Button3", "Toolbar1_Buttons_Button4", "Toolbar1"}
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTipMain As System.Windows.Forms.ToolTip
	Public CommonDialog1Save As System.Windows.Forms.SaveFileDialog
	Public CommonDialog1 As BT2Support.UpgradeStubs.AxMSComDlg_AxCommonDialog
	Public WithEvents txtBox As System.Windows.Forms.TextBox
	Public WithEvents Toolbar1_Buttons_Button1 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Buttons_Button2 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Buttons_Button3 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1_Buttons_Button4 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1 As System.Windows.Forms.ToolStrip
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	 Private Sub InitializeComponent()
		components = New System.ComponentModel.Container()
		Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(frmBox))
		ToolTipMain = New System.Windows.Forms.ToolTip(components)
		CommonDialog1Save = New System.Windows.Forms.SaveFileDialog()
		CommonDialog1 = New BT2Support.UpgradeStubs.AxMSComDlg_AxCommonDialog()
		txtBox = New System.Windows.Forms.TextBox()
		Toolbar1 = New System.Windows.Forms.ToolStrip()
		Toolbar1_Buttons_Button1 = New System.Windows.Forms.ToolStripButton()
		Toolbar1_Buttons_Button2 = New System.Windows.Forms.ToolStripButton()
		Toolbar1_Buttons_Button3 = New System.Windows.Forms.ToolStripButton()
		Toolbar1_Buttons_Button4 = New System.Windows.Forms.ToolStripButton()
		Toolbar1.SuspendLayout()
		SuspendLayout()
		' 
		'txtBox
		' 
		txtBox.AcceptsReturn = True
		txtBox.AllowDrop = True
		txtBox.BackColor = System.Drawing.SystemColors.Window
		txtBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		txtBox.Cursor = System.Windows.Forms.Cursors.IBeam
		txtBox.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		txtBox.ForeColor = System.Drawing.SystemColors.WindowText
		txtBox.Location = New System.Drawing.Point(8, 48)
		txtBox.MaxLength = 0
		txtBox.Multiline = True
		txtBox.Name = "txtBox"
		txtBox.RightToLeft = System.Windows.Forms.RightToLeft.No
		txtBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
		txtBox.Size = New System.Drawing.Size(689, 505)
		txtBox.TabIndex = 0
		txtBox.Text = "Text1"
		txtBox.WordWrap = False
		' 
		'Toolbar1
		' 
		Toolbar1.AllowDrop = True
		Toolbar1.Dock = System.Windows.Forms.DockStyle.Top
		Toolbar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		Toolbar1.Location = New System.Drawing.Point(0, 0)
		Toolbar1.Name = "Toolbar1"
		Toolbar1.ShowItemToolTips = True
		Toolbar1.Size = New System.Drawing.Size(701, 42)
		Toolbar1.TabIndex = 1
		Toolbar1.Items.Add(Toolbar1_Buttons_Button1)
		Toolbar1.Items.Add(Toolbar1_Buttons_Button2)
		Toolbar1.Items.Add(Toolbar1_Buttons_Button3)
		Toolbar1.Items.Add(Toolbar1_Buttons_Button4)
		' 
		'Toolbar1_Buttons_Button1
		' 
		Toolbar1_Buttons_Button1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Toolbar1_Buttons_Button1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Toolbar1_Buttons_Button1.Name = "btnSave"
		Toolbar1_Buttons_Button1.Size = New System.Drawing.Size(62, 37)
		Toolbar1_Buttons_Button1.Text = "Save"
		Toolbar1_Buttons_Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Toolbar1_Buttons_Button1.ToolTipText = "Save input values "
		' 
		'Toolbar1_Buttons_Button2
		' 
		Toolbar1_Buttons_Button2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Toolbar1_Buttons_Button2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Toolbar1_Buttons_Button2.Size = New System.Drawing.Size(62, 37)
		Toolbar1_Buttons_Button2.Text = "Copy Table"
		Toolbar1_Buttons_Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Toolbar1_Buttons_Button2.ToolTipText = "Copy table to windows clipboard"
		' 
		'Toolbar1_Buttons_Button3
		' 
		Toolbar1_Buttons_Button3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Toolbar1_Buttons_Button3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Toolbar1_Buttons_Button3.Size = New System.Drawing.Size(62, 37)
		Toolbar1_Buttons_Button3.Text = "Help"
		Toolbar1_Buttons_Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Toolbar1_Buttons_Button3.ToolTipText = "Get Help"
		' 
		'Toolbar1_Buttons_Button4
		' 
		Toolbar1_Buttons_Button4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Toolbar1_Buttons_Button4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Toolbar1_Buttons_Button4.Name = "btnClose"
		Toolbar1_Buttons_Button4.Size = New System.Drawing.Size(62, 37)
		Toolbar1_Buttons_Button4.Text = "Close"
		Toolbar1_Buttons_Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Toolbar1_Buttons_Button4.ToolTipText = "Stop editing & return to program menu"
		' 
		'frmBox
		' 
		AllowDrop = True
		AutoScaleDimensions = New System.Drawing.SizeF(7, 15)
		AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		BackColor = System.Drawing.SystemColors.Control
		ClientSize = New System.Drawing.Size(701, 566)
		Controls.Add(txtBox)
		Controls.Add(Toolbar1)
		Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Icon = CType(resources.GetObject("frmBox.Icon"), System.Drawing.Icon)
		Location = New System.Drawing.Point(3, 22)
		MaximizeBox = False
		MinimizeBox = False
		Name = "frmBox"
		RightToLeft = System.Windows.Forms.RightToLeft.No
		ShowInTaskbar = False
		Text = "Form1"
		Toolbar1.ResumeLayout(False)
		Toolbar1.PerformLayout()
		ResumeLayout(False)
		PerformLayout()
	End Sub
	Sub ReLoadForm(ByVal addEvents As Boolean)
		If addEvents Then
			AddHandler MyBase.Closed, AddressOf Form_Closed
			AddHandler Activated, AddressOf frmBox_Activated
		End If
	End Sub
#End Region
End Class