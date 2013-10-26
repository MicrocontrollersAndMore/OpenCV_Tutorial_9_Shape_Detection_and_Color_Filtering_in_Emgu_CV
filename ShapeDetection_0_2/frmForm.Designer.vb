<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
		Me.tlpLabelsAndImageBoxes = New System.Windows.Forms.TableLayoutPanel()
		Me.lblOriginal = New System.Windows.Forms.Label()
		Me.lblGrayColorFiltered = New System.Windows.Forms.Label()
		Me.lblCanny = New System.Windows.Forms.Label()
		Me.lblCircles = New System.Windows.Forms.Label()
		Me.lblLines = New System.Windows.Forms.Label()
		Me.lblTrisRectsPolys = New System.Windows.Forms.Label()
		Me.ibOriginal = New Emgu.CV.UI.ImageBox()
		Me.ibGrayColorFiltered = New Emgu.CV.UI.ImageBox()
		Me.ibCanny = New Emgu.CV.UI.ImageBox()
		Me.ibCircles = New Emgu.CV.UI.ImageBox()
		Me.ibLines = New Emgu.CV.UI.ImageBox()
		Me.ibTrisRectsPolys = New Emgu.CV.UI.ImageBox()
		Me.gbChooseImage = New System.Windows.Forms.GroupBox()
		Me.rdoWebcam = New System.Windows.Forms.RadioButton()
		Me.rdoImageFile = New System.Windows.Forms.RadioButton()
		Me.lblFile = New System.Windows.Forms.Label()
		Me.txtFile = New System.Windows.Forms.TextBox()
		Me.btnFile = New System.Windows.Forms.Button()
		Me.ckDrawCirclesOnOriginalImage = New System.Windows.Forms.CheckBox()
		Me.ckDrawLinesOnOriginalImage = New System.Windows.Forms.CheckBox()
		Me.ckDrawTrisRectsAndPolysOnOriginalImage = New System.Windows.Forms.CheckBox()
		Me.ckFilterOnColor = New System.Windows.Forms.CheckBox()
		Me.lblBlue = New System.Windows.Forms.Label()
		Me.lblGreen = New System.Windows.Forms.Label()
		Me.lblRed = New System.Windows.Forms.Label()
		Me.lblMin = New System.Windows.Forms.Label()
		Me.lblMax = New System.Windows.Forms.Label()
		Me.cboMinBlue = New System.Windows.Forms.ComboBox()
		Me.cboMaxBlue = New System.Windows.Forms.ComboBox()
		Me.cboMinGreen = New System.Windows.Forms.ComboBox()
		Me.cboMaxGreen = New System.Windows.Forms.ComboBox()
		Me.cboMinRed = New System.Windows.Forms.ComboBox()
		Me.cboMaxRed = New System.Windows.Forms.ComboBox()
		Me.ofdFile = New System.Windows.Forms.OpenFileDialog()
		Me.tlpLabelsAndImageBoxes.SuspendLayout
		CType(Me.ibOriginal,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.ibGrayColorFiltered,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.ibCanny,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.ibCircles,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.ibLines,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.ibTrisRectsPolys,System.ComponentModel.ISupportInitialize).BeginInit
		Me.gbChooseImage.SuspendLayout
		Me.SuspendLayout
		'
		'tlpLabelsAndImageBoxes
		'
		Me.tlpLabelsAndImageBoxes.ColumnCount = 3
		Me.tlpLabelsAndImageBoxes.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
		Me.tlpLabelsAndImageBoxes.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
		Me.tlpLabelsAndImageBoxes.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
		Me.tlpLabelsAndImageBoxes.Controls.Add(Me.lblOriginal, 0, 0)
		Me.tlpLabelsAndImageBoxes.Controls.Add(Me.lblGrayColorFiltered, 1, 0)
		Me.tlpLabelsAndImageBoxes.Controls.Add(Me.lblCanny, 2, 0)
		Me.tlpLabelsAndImageBoxes.Controls.Add(Me.lblCircles, 0, 2)
		Me.tlpLabelsAndImageBoxes.Controls.Add(Me.lblLines, 1, 2)
		Me.tlpLabelsAndImageBoxes.Controls.Add(Me.lblTrisRectsPolys, 2, 2)
		Me.tlpLabelsAndImageBoxes.Controls.Add(Me.ibOriginal, 0, 1)
		Me.tlpLabelsAndImageBoxes.Controls.Add(Me.ibGrayColorFiltered, 1, 1)
		Me.tlpLabelsAndImageBoxes.Controls.Add(Me.ibCanny, 2, 1)
		Me.tlpLabelsAndImageBoxes.Controls.Add(Me.ibCircles, 0, 3)
		Me.tlpLabelsAndImageBoxes.Controls.Add(Me.ibLines, 1, 3)
		Me.tlpLabelsAndImageBoxes.Controls.Add(Me.ibTrisRectsPolys, 2, 3)
		Me.tlpLabelsAndImageBoxes.Location = New System.Drawing.Point(2, 100)
		Me.tlpLabelsAndImageBoxes.Margin = New System.Windows.Forms.Padding(2)
		Me.tlpLabelsAndImageBoxes.Name = "tlpLabelsAndImageBoxes"
		Me.tlpLabelsAndImageBoxes.RowCount = 4
		Me.tlpLabelsAndImageBoxes.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.tlpLabelsAndImageBoxes.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50!))
		Me.tlpLabelsAndImageBoxes.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.tlpLabelsAndImageBoxes.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50!))
		Me.tlpLabelsAndImageBoxes.Size = New System.Drawing.Size(768, 392)
		Me.tlpLabelsAndImageBoxes.TabIndex = 0
		'
		'lblOriginal
		'
		Me.lblOriginal.AutoSize = true
		Me.lblOriginal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblOriginal.Location = New System.Drawing.Point(2, 0)
		Me.lblOriginal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.lblOriginal.Name = "lblOriginal"
		Me.lblOriginal.Size = New System.Drawing.Size(63, 20)
		Me.lblOriginal.TabIndex = 26
		Me.lblOriginal.Text = "original:"
		'
		'lblGrayColorFiltered
		'
		Me.lblGrayColorFiltered.AutoSize = true
		Me.lblGrayColorFiltered.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblGrayColorFiltered.Location = New System.Drawing.Point(258, 0)
		Me.lblGrayColorFiltered.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.lblGrayColorFiltered.Name = "lblGrayColorFiltered"
		Me.lblGrayColorFiltered.Size = New System.Drawing.Size(43, 20)
		Me.lblGrayColorFiltered.TabIndex = 1
		Me.lblGrayColorFiltered.Text = "gray:"
		'
		'lblCanny
		'
		Me.lblCanny.AutoSize = true
		Me.lblCanny.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblCanny.Location = New System.Drawing.Point(514, 0)
		Me.lblCanny.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.lblCanny.Name = "lblCanny"
		Me.lblCanny.Size = New System.Drawing.Size(54, 20)
		Me.lblCanny.TabIndex = 2
		Me.lblCanny.Text = "Canny"
		'
		'lblCircles
		'
		Me.lblCircles.AutoSize = true
		Me.lblCircles.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblCircles.Location = New System.Drawing.Point(2, 186)
		Me.lblCircles.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.lblCircles.Name = "lblCircles"
		Me.lblCircles.Size = New System.Drawing.Size(94, 20)
		Me.lblCircles.TabIndex = 3
		Me.lblCircles.Text = "circles (red):"
		'
		'lblLines
		'
		Me.lblLines.AutoSize = true
		Me.lblLines.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblLines.Location = New System.Drawing.Point(258, 186)
		Me.lblLines.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.lblLines.Name = "lblLines"
		Me.lblLines.Size = New System.Drawing.Size(100, 20)
		Me.lblLines.TabIndex = 4
		Me.lblLines.Text = "lines (green):"
		'
		'lblTrisRectsPolys
		'
		Me.lblTrisRectsPolys.AutoSize = true
		Me.lblTrisRectsPolys.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblTrisRectsPolys.Location = New System.Drawing.Point(514, 186)
		Me.lblTrisRectsPolys.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.lblTrisRectsPolys.Name = "lblTrisRectsPolys"
		Me.lblTrisRectsPolys.Size = New System.Drawing.Size(251, 40)
		Me.lblTrisRectsPolys.TabIndex = 5
		Me.lblTrisRectsPolys.Text = "triangles (yellow), rectangles(blue), and polygons (gray):"
		'
		'ibOriginal
		'
		Me.ibOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.ibOriginal.Dock = System.Windows.Forms.DockStyle.Fill
		Me.ibOriginal.Enabled = false
		Me.ibOriginal.Location = New System.Drawing.Point(2, 22)
		Me.ibOriginal.Margin = New System.Windows.Forms.Padding(2)
		Me.ibOriginal.Name = "ibOriginal"
		Me.ibOriginal.Size = New System.Drawing.Size(252, 162)
		Me.ibOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.ibOriginal.TabIndex = 2
		Me.ibOriginal.TabStop = false
		'
		'ibGrayColorFiltered
		'
		Me.ibGrayColorFiltered.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.ibGrayColorFiltered.Dock = System.Windows.Forms.DockStyle.Fill
		Me.ibGrayColorFiltered.Enabled = false
		Me.ibGrayColorFiltered.Location = New System.Drawing.Point(258, 22)
		Me.ibGrayColorFiltered.Margin = New System.Windows.Forms.Padding(2)
		Me.ibGrayColorFiltered.Name = "ibGrayColorFiltered"
		Me.ibGrayColorFiltered.Size = New System.Drawing.Size(252, 162)
		Me.ibGrayColorFiltered.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.ibGrayColorFiltered.TabIndex = 2
		Me.ibGrayColorFiltered.TabStop = false
		'
		'ibCanny
		'
		Me.ibCanny.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.ibCanny.Dock = System.Windows.Forms.DockStyle.Fill
		Me.ibCanny.Enabled = false
		Me.ibCanny.Location = New System.Drawing.Point(514, 22)
		Me.ibCanny.Margin = New System.Windows.Forms.Padding(2)
		Me.ibCanny.Name = "ibCanny"
		Me.ibCanny.Size = New System.Drawing.Size(252, 162)
		Me.ibCanny.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.ibCanny.TabIndex = 2
		Me.ibCanny.TabStop = false
		'
		'ibCircles
		'
		Me.ibCircles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.ibCircles.Dock = System.Windows.Forms.DockStyle.Fill
		Me.ibCircles.Enabled = false
		Me.ibCircles.Location = New System.Drawing.Point(2, 228)
		Me.ibCircles.Margin = New System.Windows.Forms.Padding(2)
		Me.ibCircles.Name = "ibCircles"
		Me.ibCircles.Size = New System.Drawing.Size(252, 162)
		Me.ibCircles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.ibCircles.TabIndex = 2
		Me.ibCircles.TabStop = false
		'
		'ibLines
		'
		Me.ibLines.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.ibLines.Dock = System.Windows.Forms.DockStyle.Fill
		Me.ibLines.Enabled = false
		Me.ibLines.Location = New System.Drawing.Point(258, 228)
		Me.ibLines.Margin = New System.Windows.Forms.Padding(2)
		Me.ibLines.Name = "ibLines"
		Me.ibLines.Size = New System.Drawing.Size(252, 162)
		Me.ibLines.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.ibLines.TabIndex = 2
		Me.ibLines.TabStop = false
		'
		'ibTrisRectsPolys
		'
		Me.ibTrisRectsPolys.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.ibTrisRectsPolys.Dock = System.Windows.Forms.DockStyle.Fill
		Me.ibTrisRectsPolys.Enabled = false
		Me.ibTrisRectsPolys.Location = New System.Drawing.Point(514, 228)
		Me.ibTrisRectsPolys.Margin = New System.Windows.Forms.Padding(2)
		Me.ibTrisRectsPolys.Name = "ibTrisRectsPolys"
		Me.ibTrisRectsPolys.Size = New System.Drawing.Size(252, 162)
		Me.ibTrisRectsPolys.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.ibTrisRectsPolys.TabIndex = 2
		Me.ibTrisRectsPolys.TabStop = false
		'
		'gbChooseImage
		'
		Me.gbChooseImage.Controls.Add(Me.rdoWebcam)
		Me.gbChooseImage.Controls.Add(Me.rdoImageFile)
		Me.gbChooseImage.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.gbChooseImage.Location = New System.Drawing.Point(3, 3)
		Me.gbChooseImage.Margin = New System.Windows.Forms.Padding(2)
		Me.gbChooseImage.Name = "gbChooseImage"
		Me.gbChooseImage.Padding = New System.Windows.Forms.Padding(2)
		Me.gbChooseImage.Size = New System.Drawing.Size(131, 77)
		Me.gbChooseImage.TabIndex = 1
		Me.gbChooseImage.TabStop = false
		Me.gbChooseImage.Text = "choose image:"
		'
		'rdoWebcam
		'
		Me.rdoWebcam.AutoSize = true
		Me.rdoWebcam.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.rdoWebcam.Location = New System.Drawing.Point(8, 49)
		Me.rdoWebcam.Margin = New System.Windows.Forms.Padding(2)
		Me.rdoWebcam.Name = "rdoWebcam"
		Me.rdoWebcam.Size = New System.Drawing.Size(91, 24)
		Me.rdoWebcam.TabIndex = 1
		Me.rdoWebcam.Text = "Webcam"
		Me.rdoWebcam.UseVisualStyleBackColor = true
		'
		'rdoImageFile
		'
		Me.rdoImageFile.AutoSize = true
		Me.rdoImageFile.Checked = true
		Me.rdoImageFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.rdoImageFile.Location = New System.Drawing.Point(8, 22)
		Me.rdoImageFile.Margin = New System.Windows.Forms.Padding(2)
		Me.rdoImageFile.Name = "rdoImageFile"
		Me.rdoImageFile.Size = New System.Drawing.Size(102, 24)
		Me.rdoImageFile.TabIndex = 0
		Me.rdoImageFile.TabStop = true
		Me.rdoImageFile.Text = "Image File"
		Me.rdoImageFile.UseVisualStyleBackColor = true
		'
		'lblFile
		'
		Me.lblFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblFile.Location = New System.Drawing.Point(138, 0)
		Me.lblFile.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.lblFile.Name = "lblFile"
		Me.lblFile.Size = New System.Drawing.Size(91, 20)
		Me.lblFile.TabIndex = 2
		Me.lblFile.Text = "choose file:"
		Me.lblFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'txtFile
		'
		Me.txtFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtFile.Location = New System.Drawing.Point(230, 0)
		Me.txtFile.Margin = New System.Windows.Forms.Padding(2)
		Me.txtFile.Name = "txtFile"
		Me.txtFile.Size = New System.Drawing.Size(175, 23)
		Me.txtFile.TabIndex = 3
		'
		'btnFile
		'
		Me.btnFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnFile.Location = New System.Drawing.Point(406, 0)
		Me.btnFile.Margin = New System.Windows.Forms.Padding(2)
		Me.btnFile.Name = "btnFile"
		Me.btnFile.Size = New System.Drawing.Size(28, 22)
		Me.btnFile.TabIndex = 4
		Me.btnFile.Text = "..."
		Me.btnFile.UseVisualStyleBackColor = true
		'
		'ckDrawCirclesOnOriginalImage
		'
		Me.ckDrawCirclesOnOriginalImage.AutoSize = true
		Me.ckDrawCirclesOnOriginalImage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.ckDrawCirclesOnOriginalImage.Location = New System.Drawing.Point(156, 26)
		Me.ckDrawCirclesOnOriginalImage.Margin = New System.Windows.Forms.Padding(2)
		Me.ckDrawCirclesOnOriginalImage.Name = "ckDrawCirclesOnOriginalImage"
		Me.ckDrawCirclesOnOriginalImage.Size = New System.Drawing.Size(214, 21)
		Me.ckDrawCirclesOnOriginalImage.TabIndex = 5
		Me.ckDrawCirclesOnOriginalImage.Text = "draw circles on original image"
		Me.ckDrawCirclesOnOriginalImage.UseVisualStyleBackColor = true
		'
		'ckDrawLinesOnOriginalImage
		'
		Me.ckDrawLinesOnOriginalImage.AutoSize = true
		Me.ckDrawLinesOnOriginalImage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.ckDrawLinesOnOriginalImage.Location = New System.Drawing.Point(156, 50)
		Me.ckDrawLinesOnOriginalImage.Margin = New System.Windows.Forms.Padding(2)
		Me.ckDrawLinesOnOriginalImage.Name = "ckDrawLinesOnOriginalImage"
		Me.ckDrawLinesOnOriginalImage.Size = New System.Drawing.Size(203, 21)
		Me.ckDrawLinesOnOriginalImage.TabIndex = 6
		Me.ckDrawLinesOnOriginalImage.Text = "draw lines on original image"
		Me.ckDrawLinesOnOriginalImage.UseVisualStyleBackColor = true
		'
		'ckDrawTrisRectsAndPolysOnOriginalImage
		'
		Me.ckDrawTrisRectsAndPolysOnOriginalImage.AutoSize = true
		Me.ckDrawTrisRectsAndPolysOnOriginalImage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.ckDrawTrisRectsAndPolysOnOriginalImage.Location = New System.Drawing.Point(156, 74)
		Me.ckDrawTrisRectsAndPolysOnOriginalImage.Margin = New System.Windows.Forms.Padding(2)
		Me.ckDrawTrisRectsAndPolysOnOriginalImage.Name = "ckDrawTrisRectsAndPolysOnOriginalImage"
		Me.ckDrawTrisRectsAndPolysOnOriginalImage.Size = New System.Drawing.Size(395, 21)
		Me.ckDrawTrisRectsAndPolysOnOriginalImage.TabIndex = 7
		Me.ckDrawTrisRectsAndPolysOnOriginalImage.Text = "draw triangles, rectangles, and polygons on original image"
		Me.ckDrawTrisRectsAndPolysOnOriginalImage.UseVisualStyleBackColor = true
		'
		'ckFilterOnColor
		'
		Me.ckFilterOnColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.ckFilterOnColor.Location = New System.Drawing.Point(446, 0)
		Me.ckFilterOnColor.Margin = New System.Windows.Forms.Padding(2)
		Me.ckFilterOnColor.Name = "ckFilterOnColor"
		Me.ckFilterOnColor.Size = New System.Drawing.Size(125, 24)
		Me.ckFilterOnColor.TabIndex = 8
		Me.ckFilterOnColor.Text = "filter on color"
		Me.ckFilterOnColor.UseVisualStyleBackColor = true
		'
		'lblBlue
		'
		Me.lblBlue.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblBlue.Location = New System.Drawing.Point(574, 0)
		Me.lblBlue.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.lblBlue.Name = "lblBlue"
		Me.lblBlue.Size = New System.Drawing.Size(63, 19)
		Me.lblBlue.TabIndex = 9
		Me.lblBlue.Text = "blue:"
		Me.lblBlue.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.lblBlue.Visible = false
		'
		'lblGreen
		'
		Me.lblGreen.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblGreen.Location = New System.Drawing.Point(640, 0)
		Me.lblGreen.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.lblGreen.Name = "lblGreen"
		Me.lblGreen.Size = New System.Drawing.Size(63, 19)
		Me.lblGreen.TabIndex = 10
		Me.lblGreen.Text = "green:"
		Me.lblGreen.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.lblGreen.Visible = false
		'
		'lblRed
		'
		Me.lblRed.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblRed.Location = New System.Drawing.Point(706, 0)
		Me.lblRed.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.lblRed.Name = "lblRed"
		Me.lblRed.Size = New System.Drawing.Size(63, 19)
		Me.lblRed.TabIndex = 11
		Me.lblRed.Text = "red:"
		Me.lblRed.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.lblRed.Visible = false
		'
		'lblMin
		'
		Me.lblMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblMin.Location = New System.Drawing.Point(472, 26)
		Me.lblMin.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.lblMin.Name = "lblMin"
		Me.lblMin.Size = New System.Drawing.Size(103, 19)
		Me.lblMin.TabIndex = 12
		Me.lblMin.Text = "min (0-255):"
		Me.lblMin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.lblMin.Visible = false
		'
		'lblMax
		'
		Me.lblMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblMax.Location = New System.Drawing.Point(468, 50)
		Me.lblMax.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.lblMax.Name = "lblMax"
		Me.lblMax.Size = New System.Drawing.Size(105, 19)
		Me.lblMax.TabIndex = 13
		Me.lblMax.Text = "max (1-256):"
		Me.lblMax.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.lblMax.Visible = false
		'
		'cboMinBlue
		'
		Me.cboMinBlue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.cboMinBlue.FormattingEnabled = true
		Me.cboMinBlue.Location = New System.Drawing.Point(574, 23)
		Me.cboMinBlue.Margin = New System.Windows.Forms.Padding(2)
		Me.cboMinBlue.Name = "cboMinBlue"
		Me.cboMinBlue.Size = New System.Drawing.Size(64, 25)
		Me.cboMinBlue.TabIndex = 20
		Me.cboMinBlue.Visible = false
		'
		'cboMaxBlue
		'
		Me.cboMaxBlue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.cboMaxBlue.FormattingEnabled = true
		Me.cboMaxBlue.Location = New System.Drawing.Point(574, 46)
		Me.cboMaxBlue.Margin = New System.Windows.Forms.Padding(2)
		Me.cboMaxBlue.Name = "cboMaxBlue"
		Me.cboMaxBlue.Size = New System.Drawing.Size(64, 25)
		Me.cboMaxBlue.TabIndex = 21
		Me.cboMaxBlue.Visible = false
		'
		'cboMinGreen
		'
		Me.cboMinGreen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.cboMinGreen.FormattingEnabled = true
		Me.cboMinGreen.Location = New System.Drawing.Point(640, 23)
		Me.cboMinGreen.Margin = New System.Windows.Forms.Padding(2)
		Me.cboMinGreen.Name = "cboMinGreen"
		Me.cboMinGreen.Size = New System.Drawing.Size(64, 25)
		Me.cboMinGreen.TabIndex = 22
		Me.cboMinGreen.Visible = false
		'
		'cboMaxGreen
		'
		Me.cboMaxGreen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.cboMaxGreen.FormattingEnabled = true
		Me.cboMaxGreen.Location = New System.Drawing.Point(640, 46)
		Me.cboMaxGreen.Margin = New System.Windows.Forms.Padding(2)
		Me.cboMaxGreen.Name = "cboMaxGreen"
		Me.cboMaxGreen.Size = New System.Drawing.Size(64, 25)
		Me.cboMaxGreen.TabIndex = 23
		Me.cboMaxGreen.Visible = false
		'
		'cboMinRed
		'
		Me.cboMinRed.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.cboMinRed.FormattingEnabled = true
		Me.cboMinRed.Location = New System.Drawing.Point(706, 23)
		Me.cboMinRed.Margin = New System.Windows.Forms.Padding(2)
		Me.cboMinRed.Name = "cboMinRed"
		Me.cboMinRed.Size = New System.Drawing.Size(64, 25)
		Me.cboMinRed.TabIndex = 24
		Me.cboMinRed.Visible = false
		'
		'cboMaxRed
		'
		Me.cboMaxRed.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.cboMaxRed.FormattingEnabled = true
		Me.cboMaxRed.Location = New System.Drawing.Point(706, 46)
		Me.cboMaxRed.Margin = New System.Windows.Forms.Padding(2)
		Me.cboMaxRed.Name = "cboMaxRed"
		Me.cboMaxRed.Size = New System.Drawing.Size(64, 25)
		Me.cboMaxRed.TabIndex = 25
		Me.cboMaxRed.Visible = false
		'
		'frmForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(773, 493)
		Me.Controls.Add(Me.cboMaxRed)
		Me.Controls.Add(Me.cboMinRed)
		Me.Controls.Add(Me.cboMaxGreen)
		Me.Controls.Add(Me.cboMinGreen)
		Me.Controls.Add(Me.cboMaxBlue)
		Me.Controls.Add(Me.cboMinBlue)
		Me.Controls.Add(Me.lblMax)
		Me.Controls.Add(Me.lblMin)
		Me.Controls.Add(Me.lblRed)
		Me.Controls.Add(Me.lblGreen)
		Me.Controls.Add(Me.lblBlue)
		Me.Controls.Add(Me.ckFilterOnColor)
		Me.Controls.Add(Me.ckDrawTrisRectsAndPolysOnOriginalImage)
		Me.Controls.Add(Me.ckDrawLinesOnOriginalImage)
		Me.Controls.Add(Me.ckDrawCirclesOnOriginalImage)
		Me.Controls.Add(Me.btnFile)
		Me.Controls.Add(Me.txtFile)
		Me.Controls.Add(Me.lblFile)
		Me.Controls.Add(Me.gbChooseImage)
		Me.Controls.Add(Me.tlpLabelsAndImageBoxes)
		Me.Margin = New System.Windows.Forms.Padding(2)
		Me.Name = "frmForm"
		Me.Text = "Shape Detection"
		Me.tlpLabelsAndImageBoxes.ResumeLayout(false)
		Me.tlpLabelsAndImageBoxes.PerformLayout
		CType(Me.ibOriginal,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.ibGrayColorFiltered,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.ibCanny,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.ibCircles,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.ibLines,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.ibTrisRectsPolys,System.ComponentModel.ISupportInitialize).EndInit
		Me.gbChooseImage.ResumeLayout(false)
		Me.gbChooseImage.PerformLayout
		Me.ResumeLayout(false)
		Me.PerformLayout

End Sub
    Friend WithEvents tlpLabelsAndImageBoxes As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblOriginal As System.Windows.Forms.Label
    Friend WithEvents lblGrayColorFiltered As System.Windows.Forms.Label
    Friend WithEvents lblCanny As System.Windows.Forms.Label
    Friend WithEvents lblCircles As System.Windows.Forms.Label
    Friend WithEvents lblLines As System.Windows.Forms.Label
    Friend WithEvents lblTrisRectsPolys As System.Windows.Forms.Label
    Friend WithEvents ibOriginal As Emgu.CV.UI.ImageBox
    Friend WithEvents ibGrayColorFiltered As Emgu.CV.UI.ImageBox
    Friend WithEvents ibCanny As Emgu.CV.UI.ImageBox
    Friend WithEvents ibCircles As Emgu.CV.UI.ImageBox
    Friend WithEvents ibLines As Emgu.CV.UI.ImageBox
    Friend WithEvents ibTrisRectsPolys As Emgu.CV.UI.ImageBox
    Friend WithEvents gbChooseImage As System.Windows.Forms.GroupBox
    Friend WithEvents rdoWebcam As System.Windows.Forms.RadioButton
    Friend WithEvents rdoImageFile As System.Windows.Forms.RadioButton
    Friend WithEvents lblFile As System.Windows.Forms.Label
    Friend WithEvents txtFile As System.Windows.Forms.TextBox
    Friend WithEvents btnFile As System.Windows.Forms.Button
    Friend WithEvents ckDrawCirclesOnOriginalImage As System.Windows.Forms.CheckBox
    Friend WithEvents ckDrawLinesOnOriginalImage As System.Windows.Forms.CheckBox
    Friend WithEvents ckDrawTrisRectsAndPolysOnOriginalImage As System.Windows.Forms.CheckBox
    Friend WithEvents ckFilterOnColor As System.Windows.Forms.CheckBox
    Friend WithEvents lblBlue As System.Windows.Forms.Label
    Friend WithEvents lblGreen As System.Windows.Forms.Label
    Friend WithEvents lblRed As System.Windows.Forms.Label
    Friend WithEvents lblMin As System.Windows.Forms.Label
    Friend WithEvents lblMax As System.Windows.Forms.Label
    Friend WithEvents cboMinBlue As System.Windows.Forms.ComboBox
    Friend WithEvents cboMaxBlue As System.Windows.Forms.ComboBox
    Friend WithEvents cboMinGreen As System.Windows.Forms.ComboBox
    Friend WithEvents cboMaxGreen As System.Windows.Forms.ComboBox
    Friend WithEvents cboMinRed As System.Windows.Forms.ComboBox
    Friend WithEvents cboMaxRed As System.Windows.Forms.ComboBox
    Friend WithEvents ofdFile As System.Windows.Forms.OpenFileDialog

End Class
