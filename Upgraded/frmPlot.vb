Option Strict Off
Option Explicit On
Imports BT2Support.UpgradeStubs
Imports Excel = Microsoft.Office.Interop.Excel
Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Imports UpgradeHelpers.Gui.Controls
Imports UpgradeHelpers.Helpers
Partial Friend Class frmPlot
	Inherits System.Windows.Forms.Form
	Public Sub New()
		MyBase.New()
		Dim mustCallFormLoad As Boolean = False
		If m_vb6FormDefInstance Is Nothing Then
			If m_InitializingDefInstance Then
				m_vb6FormDefInstance = Me
			Else
				Try
					'For the start-up form, the first instance created is the default instance.
					If Not (System.Reflection.Assembly.GetExecutingAssembly().EntryPoint Is Nothing) AndAlso System.Reflection.Assembly.GetExecutingAssembly().EntryPoint.DeclaringType Is Me.GetType() Then
						m_vb6FormDefInstance = Me
					End If
				Finally 
					mustCallFormLoad = True
				End Try
			End If
		End If
		'This call is required by the Windows Form Designer.
		isInitializingComponent = True
		InitializeComponent()
		isInitializingComponent = False
		ReLoadForm(False)
		If mustCallFormLoad And Not (m_vb6FormDefInstance Is Nothing) Then
			m_vb6FormDefInstance.Form_Load()
		End If
	End Sub


	Private Sub frmPlot_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		If Not (UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm Is eventSender) Then
			UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm = eventSender
		End If
	End Sub
	Dim BarwidtH As Single
	Dim PlotObserved As Boolean

	Private isInitializingComponent As Boolean
	Private Sub chkLogScale_CheckStateChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles chkLogScale.CheckStateChanged
		If isInitializingComponent Then
			Exit Sub
		End If
		Combo1_SelectedIndexChanged(Combo1, New EventArgs())
	End Sub

	Private Sub chkObserved_CheckStateChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles chkObserved.CheckStateChanged
		If isInitializingComponent Then
			Exit Sub
		End If
		Combo1_SelectedIndexChanged(Combo1, New EventArgs())
	End Sub

	Private Sub Toolbar1_ButtonClick(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles Toolbar1_Buttons_Button1.Click, Toolbar1_Buttons_Button2.Click, Toolbar1_Buttons_Button3.Click, Toolbar1_Buttons_Button4.Click, Toolbar1_Buttons_Button5.Click
		Dim Button As ToolStripItem = CType(eventSender, ToolStripItem)


		Select Case Button.Text
			Case "Plot"
				Combo1_SelectedIndexChanged(Combo1, New EventArgs())

			Case "List Data"
				Combo1_SelectedIndexChanged(Combo1, New EventArgs())
				ViewSheet("Plot")

			Case "Help"
				'UPGRADE_ISSUE: (2064) Form property frmPlot.HelpContextID was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-2064
				'ShowHelp(Me.getHelpContextID())

			Case "Copy Chart"
				Clipboard.Clear()
				Clipboard.SetData(DataFormats.Bitmap, Image1.Image)

			Case "Quit"
				Me.Close()
				Status("Ready")

		End Select

	End Sub
	Private Sub btnlistvar_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles btnListVar.Click
		ShowHelp(331)
	End Sub
	Private Sub form_initialize()
		PlotObserved = True
		txtBarWidth.Text = CStr(1)
	End Sub
	'UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-2080
	Private Sub Form_Load()
		Combo1.Items.Clear()
		For i As Double = 1 To NDiagnostics
			Combo1.AddItem(DiagName(CInt(i)))
		Next i
		Combo1.SelectedIndex = 1
	End Sub

	Private Sub Combo1_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles Combo1.SelectedIndexChanged
		Dim realversion As Double = CDbl(Wka.Version)
		If (realversion < 15) Then Wka.WindowState = Excel.XlWindowState.xlMinimized
		Dim io As Integer = Combo1.SelectedIndex + 1
		ChartIt(io)
	End Sub


	Sub ChartIt(ByVal io As Integer)
		Dim DebugCount As Double
		Dim Fname As String = ""
		'view chart for variable io

		Dim fF As Single
		Dim XBAR, UpCI, LowCI As Double
		Dim Lpic As Integer

		Dim xloW As Single

		PlotObserved = Me.chkObserved.CheckState = CheckState.Checked

		If Me.txtBarWidth.Text = "" Then
			BarwidtH = 0
		Else
			BarwidtH = Conversion.Val(Me.txtBarWidth.Text)
		End If

		'plot_plot is where the chart is drawn, but PLOT is where the data reside
		'Including the Confidence Limits (j and k aka Offset columns 9 & 10 for OBS)
		' Get the Chart object from the ChartObjects collection
		CurrentWKChart = CType(Wkb.Sheets("plot_plot").ChartObjects(1).Chart, Excel.Chart)

		With CurrentWKChart.Axes(Excel.XlAxisType.xlValue)
			' log scale
			If Me.chkLogScale.CheckState = CheckState.Checked Then
				.Crosses = Excel.Constants.xlAutomatic
				.MinimumScaleIsAuto = True
				.ScaleType = Excel.XlScaleType.xlScaleLogarithmic
				.MinorTickMark = Excel.Constants.xlOutside
			Else
				' linear scale
				.Crosses = Excel.Constants.xlAutomatic
				.MinimumScaleIsAuto = True
				.ScaleType = Excel.XlScaleType.xlScaleLinear
				.MinorTickMark = Excel.Constants.xlNone
			End If
		End With

		StartSheet("Plot")

		Dim pLabelCell As Excel.Range = gLSht.Range("p_label").Offset(0, -1)
		With pLabelCell
			Hdr.Range("header_plot").Copy()
			gLSht.Paste(.Offset(0, 0))
			.Offset(0, 1).Value = DiagName(io)

			xloW = 10000000 ' minimum value to scale log plot
			For i As Double = 1 To Nseg + 1
				.Offset(i + 3, 0).Value = SegName(CInt(i))
				If Cest(CInt(i), io) > 0 Then
					.Offset(i + 3, 1).Value = Cest(CInt(i), io)
					.Offset(i + 3, 1).NumberFormat = "0.0"
					.Offset(i + 3, 2).Value = Math.Sqrt(CvCest(CInt(i), io)) / Cest(CInt(i), io)
					.Offset(i + 3, 2).NumberFormat = "0.00"
					xloW = MIn(xloW, Cest(CInt(i), io))
					If BarwidtH > 0 Then
						fF = Math.Exp(Math.Sqrt(CvCest(CInt(i), io)) / Cest(CInt(i), io) * BarwidtH)
						.Offset(i + 3, 7).Value = Cest(CInt(i), io) * (1 - 1 / fF)
						.Offset(i + 3, 8).Value = Cest(CInt(i), io) * (fF - 1)
						xloW = MIn(xloW, Cest(CInt(i), io) / fF)
					End If
				End If

				If Cobs(CInt(i), io) > 0 Then
					.Offset(i + 3, 3).Value = Cobs(CInt(i), io)
					.Offset(i + 3, 3).NumberFormat = "0.0"
					.Offset(i + 3, 4).Value = CvCobs(CInt(i), io)
					.Offset(i + 3, 4).NumberFormat = "0.00"
					xloW = MIn(xloW, Cobs(CInt(i), io))
					If PlotObserved And BarwidtH > 0 Then
						fF = Math.Exp(CvCobs(CInt(i), io) * BarwidtH)
						.Offset(i + 3, 9).Value = Cobs(CInt(i), io) * (1 - 1 / fF)
						.Offset(i + 3, 10).Value = Cobs(CInt(i), io) * (fF - 1)
						xloW = MIn(xloW, Cobs(CInt(i), io) / fF)
						If DebugCVMode Then
							XBAR = Cobs(CInt(i), io)
							LowCI = XBAR - Cobs(CInt(i), io) * (1 - 1 / fF)
							UpCI = XBAR + Cobs(CInt(i), io) * (fF - 1)
							MessageBox.Show("seg/Upper+ " & i & " / " & CStr(UpCI) & "/" & CStr(fF), My.Application.Info.Title)
							MessageBox.Show("seg/Lower " & i & " / " & CStr(LowCI) & "/" & CStr(fF), My.Application.Info.Title)
						End If
					End If
				End If
			Next i
		End With

		If xloW > 0 And Me.chkLogScale.CheckState = CheckState.Checked Then
			xloW = 10 ^ Math.Floor(Math.Log(xloW) / 2.303)
			With CurrentWKChart.Axes(Excel.XlAxisType.xlValue)
				.MinimumScale = xloW
				.CrossesAt = xloW
			End With
		End If

		With gLSht
			.Range(.Range("A7"), .Range("A7").Offset(Nseg, 0)).Name = "p_segs"
			.Range(.Range("b7"), .Range("b7").Offset(Nseg, 0)).Name = "p_pred"
			If PlotObserved Then
				.Range(.Range("d7"), .Range("d7").Offset(Nseg, 0)).Name = "p_obs"
			Else
				.Range("A40").Name = "p_obs"
			End If

			Wka.Calculate()

			' Delete all shapes
			Lpic = .Shapes.Count
			For i As Double = 1 To Lpic
				.Shapes.Item(1).Delete() ' Always delete the first shape, as the collection shrinks
			Next i

			If DebugMode Then MessageBox.Show("DEBUG 16: frmPlot: About to perform CurrentWKChart.copy picture " & Conversion.Str(DebugCount), My.Application.Info.Title)
			DebugCount += 1
			CurrentWKChart.CopyPicture()
			.Paste(.Range("A7").Offset(Nseg + 2, 0))

			Fname = Directory & "temp.gif"
			CurrentWKChart.Export(Fname, "GIF")
			Image1.Image = Image.FromFile(Fname)
			File.Delete(Fname)
			.Range("g7:z100").ClearContents()
			If Iop(12) = 2 Then .Range("j7").Offset(Nseg + 2 + 30, 0).Value = " "
		End With

	End Sub
	Private Sub txtBarWidth_TextChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles txtBarWidth.TextChanged
		If isInitializingComponent Then
			Exit Sub
		End If
		If Not VerifyPositive(txtBarWidth.Text) Then txtBarWidth.Text = ""
	End Sub

	Private Sub txtBarWidth_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles txtBarWidth.Leave
		Combo1_SelectedIndexChanged(Combo1, New EventArgs())
	End Sub
	Private Sub Form_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
	End Sub
End Class