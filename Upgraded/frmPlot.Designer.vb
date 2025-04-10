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
		components = New System.ComponentModel.Container()
		Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(frmPlot))
		ToolTipMain = New System.Windows.Forms.ToolTip(components)
		chkLogScale = New System.Windows.Forms.CheckBox()
		txtBarWidth = New System.Windows.Forms.TextBox()
		chkObserved = New System.Windows.Forms.CheckBox()
		Toolbar1 = New System.Windows.Forms.ToolStrip()
		Toolbar1_Buttons_Button1 = New System.Windows.Forms.ToolStripButton()
		Toolbar1_Buttons_Button2 = New System.Windows.Forms.ToolStripButton()
		Toolbar1_Buttons_Button3 = New System.Windows.Forms.ToolStripButton()
		Toolbar1_Buttons_Button4 = New System.Windows.Forms.ToolStripButton()
		Toolbar1_Buttons_Button5 = New System.Windows.Forms.ToolStripButton()
		btnListVar = New System.Windows.Forms.Button()
		Combo1 = New System.Windows.Forms.ComboBox()
		Label1 = New System.Windows.Forms.Label()
		Image1 = New System.Windows.Forms.PictureBox()
		Toolbar1.SuspendLayout()
		SuspendLayout()
		commandButtonHelper1 = New UpgradeHelpers.Gui.Controls.CommandButtonHelper(components)
		' 
		'chkLogScale
		' 
		chkLogScale.AllowDrop = True
		chkLogScale.Appearance = System.Windows.Forms.Appearance.Normal
		chkLogScale.BackColor = System.Drawing.SystemColors.Control
		chkLogScale.CausesValidation = True
		chkLogScale.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		chkLogScale.CheckState = System.Windows.Forms.CheckState.Unchecked
		chkLogScale.Enabled = True
		chkLogScale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.6!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		chkLogScale.ForeColor = System.Drawing.SystemColors.ControlText
		chkLogScale.Location = New System.Drawing.Point(520, 88)
		chkLogScale.Name = "chkLogScale"
		chkLogScale.RightToLeft = System.Windows.Forms.RightToLeft.No
		chkLogScale.Size = New System.Drawing.Size(121, 25)
		chkLogScale.TabIndex = 6
		chkLogScale.TabStop = True
		chkLogScale.Text = "Log Scale"
		chkLogScale.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		chkLogScale.Visible = True
		' 
		'txtBarWidth
		' 
		txtBarWidth.AcceptsReturn = True
		txtBarWidth.AllowDrop = True
		txtBarWidth.BackColor = System.Drawing.SystemColors.Window
		txtBarWidth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		txtBarWidth.Cursor = System.Windows.Forms.Cursors.IBeam
		txtBarWidth.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.6!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		txtBarWidth.ForeColor = System.Drawing.SystemColors.WindowText
		txtBarWidth.Location = New System.Drawing.Point(464, 72)
		txtBarWidth.MaxLength = 0
		txtBarWidth.Name = "txtBarWidth"
		txtBarWidth.RightToLeft = System.Windows.Forms.RightToLeft.No
		txtBarWidth.Size = New System.Drawing.Size(33, 25)
		txtBarWidth.TabIndex = 4
		txtBarWidth.Text = "1"
		txtBarWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		' 
		'chkObserved
		' 
		chkObserved.AllowDrop = True
		chkObserved.Appearance = System.Windows.Forms.Appearance.Normal
		chkObserved.BackColor = System.Drawing.SystemColors.Control
		chkObserved.CausesValidation = True
		chkObserved.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		chkObserved.CheckState = System.Windows.Forms.CheckState.Checked
		chkObserved.Enabled = True
		chkObserved.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.6!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		chkObserved.ForeColor = System.Drawing.SystemColors.ControlText
		chkObserved.Location = New System.Drawing.Point(520, 56)
		chkObserved.Name = "chkObserved"
		chkObserved.RightToLeft = System.Windows.Forms.RightToLeft.No
		chkObserved.Size = New System.Drawing.Size(121, 25)
		chkObserved.TabIndex = 3
		chkObserved.TabStop = True
		chkObserved.Text = "Plot Observed"
		chkObserved.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		chkObserved.Visible = True
		' 
		'Toolbar1
		' 
		Toolbar1.AllowDrop = True
		Toolbar1.Dock = System.Windows.Forms.DockStyle.Top
		Toolbar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.6!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		Toolbar1.Location = New System.Drawing.Point(0, 0)
		Toolbar1.Name = "Toolbar1"
		Toolbar1.ShowItemToolTips = True
		Toolbar1.Size = New System.Drawing.Size(664, 41)
		Toolbar1.TabIndex = 2
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
		Toolbar1_Buttons_Button1.Size = New System.Drawing.Size(63, 37)
		Toolbar1_Buttons_Button1.Text = "Plot"
		Toolbar1_Buttons_Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Toolbar1_Buttons_Button1.ToolTipText = "View plot for selected variable"
		' 
		'Toolbar1_Buttons_Button2
		' 
		Toolbar1_Buttons_Button2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Toolbar1_Buttons_Button2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Toolbar1_Buttons_Button2.Size = New System.Drawing.Size(63, 37)
		Toolbar1_Buttons_Button2.Text = "List Data"
		Toolbar1_Buttons_Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Toolbar1_Buttons_Button2.ToolTipText = "List plotted data"
		' 
		'Toolbar1_Buttons_Button3
		' 
		Toolbar1_Buttons_Button3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Toolbar1_Buttons_Button3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Toolbar1_Buttons_Button3.Size = New System.Drawing.Size(63, 37)
		Toolbar1_Buttons_Button3.Text = "Help"
		Toolbar1_Buttons_Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Toolbar1_Buttons_Button3.ToolTipText = "Get help"
		' 
		'Toolbar1_Buttons_Button4
		' 
		Toolbar1_Buttons_Button4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
		Toolbar1_Buttons_Button4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
		Toolbar1_Buttons_Button4.Size = New System.Drawing.Size(63, 37)
		Toolbar1_Buttons_Button4.Text = "Copy Chart"
		Toolbar1_Buttons_Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Toolbar1_Buttons_Button4.ToolTipText = "Copy chart to windows clipboard"
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
		'btnListVar
		' 
		btnListVar.AllowDrop = True
		btnListVar.BackColor = System.Drawing.SystemColors.Control
		btnListVar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.6!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		btnListVar.ForeColor = System.Drawing.SystemColors.ControlText
		btnListVar.Location = New System.Drawing.Point(248, 64)
		btnListVar.Name = "btnListVar"
		btnListVar.RightToLeft = System.Windows.Forms.RightToLeft.No
		btnListVar.Size = New System.Drawing.Size(97, 41)
		btnListVar.TabIndex = 1
		btnListVar.Text = "Variable Descriptions"
		btnListVar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		btnListVar.UseVisualStyleBackColor = False
		' 
		'Combo1
		' 
		Combo1.AllowDrop = True
		Combo1.BackColor = System.Drawing.SystemColors.Window
		Combo1.CausesValidation = True
		Combo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Combo1.Enabled = True
		Combo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.6!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		Combo1.ForeColor = System.Drawing.SystemColors.WindowText
		Combo1.IntegralHeight = True
		Combo1.Location = New System.Drawing.Point(8, 72)
		Combo1.Name = "Combo1"
		Combo1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Combo1.Size = New System.Drawing.Size(217, 24)
		Combo1.Sorted = False
		Combo1.TabIndex = 0
		Combo1.TabStop = True
		Combo1.Visible = True
		' 
		'Label1
		' 
		Label1.AllowDrop = True
		Label1.BackColor = System.Drawing.SystemColors.Control
		Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.6!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		Label1.ForeColor = System.Drawing.SystemColors.ControlText
		Label1.Location = New System.Drawing.Point(352, 72)
		Label1.MinimumSize = New System.Drawing.Size(105, 17)
		Label1.Name = "Label1"
		Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Label1.Size = New System.Drawing.Size(105, 17)
		Label1.TabIndex = 5
		Label1.Text = "Error Bar Width:"
		Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
		' 
		'Image1
		' 
		Image1.AllowDrop = True
		Image1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Image1.Enabled = True
		Image1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.6!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		Image1.Location = New System.Drawing.Point(8, 120)
		Image1.Name = "Image1"
		Image1.Size = New System.Drawing.Size(649, 417)
		Image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Image1.Visible = True
		' 
		'frmPlot
		' 
		AllowDrop = True
		AutoScaleDimensions = New System.Drawing.SizeF(7, 15)
		AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		BackColor = System.Drawing.SystemColors.Control
		ClientSize = New System.Drawing.Size(664, 545)
		Controls.Add(chkLogScale)
		Controls.Add(txtBarWidth)
		Controls.Add(chkObserved)
		Controls.Add(Toolbar1)
		Controls.Add(btnListVar)
		Controls.Add(Combo1)
		Controls.Add(Label1)
		Controls.Add(Image1)
		Font = New System.Drawing.Font("Microsoft Sans Serif", 9.6!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		Icon = CType(resources.GetObject("frmPlot.Icon"), System.Drawing.Icon)
		Location = New System.Drawing.Point(4, 24)
		MaximizeBox = True
		MinimizeBox = True
		Name = "frmPlot"
		RightToLeft = System.Windows.Forms.RightToLeft.No
		Text = "Bathtub Output Plot"
		commandButtonHelper1.SetStyle(btnListVar, 0)
		ToolTipMain.SetToolTip(chkLogScale, "Plot observed values")
		ToolTipMain.SetToolTip(txtBarWidth, "Width of error bars (number of standard errors)")
		ToolTipMain.SetToolTip(chkObserved, "Plot observed values")
		ToolTipMain.SetToolTip(btnListVar, "List discriptions of model output variables that can be plotted")
		Toolbar1.ResumeLayout(False)
		Toolbar1.PerformLayout()
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