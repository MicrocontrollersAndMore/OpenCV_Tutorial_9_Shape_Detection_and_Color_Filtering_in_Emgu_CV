Option Strict

Imports Emgu.CV
Imports Emgu.CV.CvEnum
Imports Emgu.CV.Structure
Imports Emgu.CV.UI

'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Public Class frmForm

' member variables ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Dim blnFirstTimeInResizeEvent As Boolean = True
Dim intOrigFormWidth As Integer
Dim intOrigFormHeight As Integer
Dim intOrigTableLayoutPanelWidth As Integer
Dim intOrigTableLayoutPanelHeight As Integer

Dim capWebcam As Capture
Dim blnWebcamCapturingInProcess As Boolean = False

Dim imgOriginal As Image(Of Bgr, Byte)
Dim imgSmoothed As Image(Of Bgr, Byte)
Dim imgGrayColorFiltered As Image(Of Gray, Byte)
Dim imgCanny As Image(Of Gray, Byte)
Dim imgCircles As Image(Of Bgr, Byte)
Dim imgLines As Image(Of Bgr, Byte)
Dim imgTrisRectsPolys As Image(Of Bgr, Byte)

Dim dblMinBlue As Double = 0.0
Dim dblMinGreen As Double = 0.0
Dim dblMinRed As Double = 0.0
Dim dblMaxBlue As Double = 0.0
Dim dblMaxGreen As Double = 0.0
Dim dblMaxRed As Double = 0.0

' constructor '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Sub New()
	InitializeComponent()										' This call is required by the designer.
	
	intOrigFormWidth = Me.Width
	intOrigFormHeight = Me.Height
	intOrigTableLayoutPanelWidth = tlpLabelsAndImageBoxes.Width
	intOrigTableLayoutPanelHeight = tlpLabelsAndImageBoxes.Height
End Sub

'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Private Sub frmForm_Load( sender As System.Object,  e As System.EventArgs) Handles MyBase.Load
	For i As Integer = 0 To 255
		cboMinBlue.Items.Add(i)
		cboMinGreen.Items.Add(i)
		cboMinRed.Items.Add(i)
		cboMaxBlue.Items.Add(i+1)
		cboMaxGreen.Items.Add(i+1)
		cboMaxRed.Items.Add(i+1)
	Next
	cboMinBlue.Text = "0"
	cboMinGreen.Text = "0"
	cboMinRed.Text = "0"
	cboMaxBlue.Text = "1"
	cboMaxGreen.Text = "1"
	cboMaxRed.Text = "1"
End Sub

'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Private Sub frmForm_Resize( sender As System.Object,  e As System.EventArgs) Handles MyBase.Resize
	'This If Else statement is necessary to throw out the first time the Form1_Resize event is called.
	'For some reason, in VB.NET the Resize event is called once before the constructor, then the constructor is called,
	'then the Resize event is called each time the form is resized.  The first time the Resize event is called
	'(i.e. before the constructor is called) the coordinates of the components on the form all read zero,
	'therefore we have to throw out this first call, then the constructor will run and get the correct initial
	'component location data, then every time after that we can let the Resize event run as expected
	If(blnFirstTimeInResizeEvent = True) Then
		blnFirstTimeInResizeEvent = False
	Else
		tlpLabelsAndImageBoxes.Width = Me.Width - (intOrigFormWidth - intOrigTableLayoutPanelWidth)
		tlpLabelsAndImageBoxes.Height = Me.Height - (intOrigFormHeight - intOrigTableLayoutPanelHeight)
	End If
End Sub

'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Private Sub rdoImageFile_CheckedChanged( sender As System.Object,  e As System.EventArgs) Handles rdoImageFile.CheckedChanged
	If(rdoImageFile.Checked = True)
		If(blnWebcamCapturingInProcess = True) Then
			RemoveHandler Application.Idle, New EventHandler(AddressOf Me.ProcessImageAndUpdateGUI)
			blnWebcamCapturingInProcess = False
		End If
		
		ibOriginal.Image = Nothing
		ibGrayColorFiltered.Image = Nothing
		ibCanny.Image = Nothing
		ibCircles.Image = Nothing
		ibLines.Image = Nothing
		ibTrisRectsPolys.Image = Nothing

		lblFile.Visible = True
		txtFile.Visible = True
		btnFile.Visible = True
	End If
End Sub

'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Private Sub rdoWebcam_CheckedChanged( sender As System.Object,  e As System.EventArgs) Handles rdoWebcam.CheckedChanged
	If(rdoWebcam.Checked = True) Then
		Try
			capWebcam = New Capture()
		Catch ex As Exception
			Me.Text = ex.Message
			Return
		End Try
		
		AddHandler Application.Idle, New EventHandler(AddressOf Me.ProcessImageAndUpdateGUI)
		blnWebcamCapturingInProcess = True
		
		lblFile.Visible = False
		txtFile.Visible = False
		btnFile.Visible = False
	End If
End Sub

'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Private Sub frmForm_FormClosed( sender As System.Object,  e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
	If(Not capWebcam Is Nothing)
		capWebcam.Dispose()
	End If
End Sub

'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Private Sub btnFile_Click( sender As System.Object,  e As System.EventArgs) Handles btnFile.Click
	Dim drDialogResult As DialogResult = ofdFile.ShowDialog()

	If(drDialogResult = Windows.Forms.DialogResult.OK Or drDialogResult = Windows.Forms.DialogResult.Yes) Then
		txtFile.Text = ofdFile.FileName
		If(txtFile.Text <> String.Empty) Then
			ProcessImageAndUpdateGUI(New Object(), New EventArgs())
		End If
	End If
End Sub

'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Private Sub ckDrawCirclesOnOriginalImage_CheckedChanged( sender As System.Object,  e As System.EventArgs) Handles ckDrawCirclesOnOriginalImage.CheckedChanged
	If(blnWebcamCapturingInProcess = False) Then
		ProcessImageAndUpdateGUI(New Object(), New EventArgs())
	End If
End Sub

'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Private Sub ckDrawLinesOnOriginalImage_CheckedChanged( sender As System.Object,  e As System.EventArgs) Handles ckDrawLinesOnOriginalImage.CheckedChanged
	If(blnWebcamCapturingInProcess = False) Then
		ProcessImageAndUpdateGUI(New Object(), New EventArgs())
	End If
End Sub

'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Private Sub ckDrawTrisRectsAndPolysOnOriginalImage_CheckedChanged( sender As System.Object,  e As System.EventArgs) Handles ckDrawTrisRectsAndPolysOnOriginalImage.CheckedChanged
	If(blnWebcamCapturingInProcess = False) Then
		ProcessImageAndUpdateGUI(New Object(), New EventArgs())
	End If
End Sub

'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Private Sub ckFilterOnColor_CheckedChanged( sender As System.Object,  e As System.EventArgs) Handles ckFilterOnColor.CheckedChanged
	If(ckFilterOnColor.Checked = True) Then
		lblBlue.Visible = True
		lblGreen.Visible = True
		lblRed.Visible = True
		lblMin.Visible = True
		lblMax.Visible = True
		cboMinBlue.Visible = True
		cboMaxBlue.Visible = True
		cboMinGreen.Visible = True
		cboMaxGreen.Visible = True
		cboMinRed.Visible = True
		cboMaxRed.Visible = True
		lblGrayColorFiltered.Text = "gray (color filtered):"
		ProcessImageAndUpdateGUI(New Object(), New EventArgs())
	ElseIf(ckFilterOnColor.Checked = False) Then
		lblBlue.Visible = False
		lblGreen.Visible = False
		lblRed.Visible = False
		lblMin.Visible = False
		lblMax.Visible = False
		cboMinBlue.Visible = False
		cboMaxBlue.Visible = False
		cboMinGreen.Visible = False
		cboMaxGreen.Visible = False
		cboMinRed.Visible = False
		cboMaxRed.Visible = False
		lblGrayColorFiltered.Text = "gray:"
		ProcessImageAndUpdateGUI(New Object(), New EventArgs())
	End If
End Sub

'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Private Sub txtFile_TextChanged( sender As System.Object,  e As System.EventArgs) Handles txtFile.TextChanged
	txtFile.SelectionStart = txtFile.Text.Length								'move caret to end of text box so file name is visible rather than file extension
End Sub

'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Private Sub cboMinBlue_SelectedIndexChanged( sender As System.Object,  e As System.EventArgs) Handles cboMinBlue.SelectedIndexChanged
	If(ckFilterOnColor.Checked = True And txtFile.Text <> String.Empty) Then
		dblMinBlue = CDbl(cboMinBlue.Text)
		ProcessImageAndUpdateGUI(New Object(), New EventArgs())
	End If
End Sub

'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Private Sub cboMinGreen_SelectedIndexChanged( sender As System.Object,  e As System.EventArgs) Handles cboMinGreen.SelectedIndexChanged
	If(ckFilterOnColor.Checked = True And txtFile.Text <> String.Empty) Then
		dblMinGreen = CDbl(cboMinGreen.Text)
		ProcessImageAndUpdateGUI(New Object(), New EventArgs())
	End If
End Sub

'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Private Sub cboMinRed_SelectedIndexChanged( sender As System.Object,  e As System.EventArgs) Handles cboMinRed.SelectedIndexChanged
	If(ckFilterOnColor.Checked = True And txtFile.Text <> String.Empty) Then
		dblMinRed = CDbl(cboMinRed.Text)
		ProcessImageAndUpdateGUI(New Object(), New EventArgs())
	End If
End Sub

'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Private Sub cboMaxBlue_SelectedIndexChanged( sender As System.Object,  e As System.EventArgs) Handles cboMaxBlue.SelectedIndexChanged
	If(ckFilterOnColor.Checked = True And txtFile.Text <> String.Empty) Then
		dblMaxBlue = CDbl(cboMaxBlue.Text)
		ProcessImageAndUpdateGUI(New Object(), New EventArgs())
	End If
End Sub

'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Private Sub cboMaxGreen_SelectedIndexChanged( sender As System.Object,  e As System.EventArgs) Handles cboMaxGreen.SelectedIndexChanged
	If(ckFilterOnColor.Checked = True And txtFile.Text <> String.Empty) Then
		dblMaxGreen = CDbl(cboMaxGreen.Text)
		ProcessImageAndUpdateGUI(New Object(), New EventArgs())
	End If
End Sub

'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Private Sub cboMaxRed_SelectedIndexChanged( sender As System.Object,  e As System.EventArgs) Handles cboMaxRed.SelectedIndexChanged
	If(ckFilterOnColor.Checked = True And txtFile.Text <> String.Empty) Then
		dblMaxRed = CDbl(cboMaxRed.Text)
		ProcessImageAndUpdateGUI(New Object(), New EventArgs())
	End If
End Sub

'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Private Sub cboMinBlue_Leave( sender As System.Object,  e As System.EventArgs) Handles cboMinBlue.Leave
	If(CInt(cboMinBlue.Text) < 0 Or CInt(cboMinBlue.Text) > 255) Then
		cboMinBlue.Text = "0"
	End If
	cboMinBlue_SelectedIndexChanged(New Object(), New EventArgs())			'call SelectedIndexChanged, that will update member variable for input and call ProcessImageAndUpdateGUI()
End Sub

'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Private Sub cboMinGreen_Leave( sender As System.Object,  e As System.EventArgs) Handles cboMinGreen.Leave
	If(CInt(cboMinGreen.Text) < 0 Or CInt(cboMinGreen.Text) > 255) Then
		cboMinGreen.Text = "0"
	End If
	cboMinGreen_SelectedIndexChanged(New Object(), New EventArgs())
End Sub

'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Private Sub cboMinRed_Leave( sender As System.Object,  e As System.EventArgs) Handles cboMinRed.Leave
	If(CInt(cboMinRed.Text) < 0 Or CInt(cboMinRed.Text) > 255) Then
		cboMinRed.Text = "0"
	End If
	cboMinRed_SelectedIndexChanged(New Object(), New EventArgs())
End Sub

'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Private Sub cboMaxBlue_Leave( sender As System.Object,  e As System.EventArgs) Handles cboMaxBlue.Leave
	If(CInt(cboMaxBlue.Text) < 1 Or CInt(cboMaxBlue.Text) > 256) Then
		cboMaxBlue.Text = "1"
	End If
	cboMaxBlue_SelectedIndexChanged(New Object(), New EventArgs())
End Sub

'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Private Sub cboMaxGreen_Leave( sender As System.Object,  e As System.EventArgs) Handles cboMaxGreen.Leave
	If(CInt(cboMaxGreen.Text) < 1 Or CInt(cboMaxGreen.Text) > 256) Then
		cboMaxGreen.Text = "1"
	End If
	cboMaxGreen_SelectedIndexChanged(New Object(), New EventArgs())
End Sub

'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Private Sub cboMaxRed_Leave( sender As System.Object,  e As System.EventArgs) Handles cboMaxRed.Leave
	If(CInt(cboMaxRed.Text) < 1 Or CInt(cboMaxRed.Text) > 256) Then
		cboMaxRed.Text = "1"
	End If
	cboMaxRed_SelectedIndexChanged(New Object(), New EventArgs())
End Sub

'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Private Sub cboMinBlue_KeyDown( sender As System.Object,  e As System.Windows.Forms.KeyEventArgs) Handles cboMinBlue.KeyDown
	If(e.KeyCode.Equals(Keys.Enter) Or e.KeyCode.Equals(Keys.Return)) Then
		e.SuppressKeyPress = True								'this is necessary to prevent "ding" sound when enter key is pressed
		lblOriginal.Focus()											'move focus to label
	End If
End Sub

'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Private Sub cboMinGreen_KeyDown( sender As System.Object,  e As System.Windows.Forms.KeyEventArgs) Handles cboMinGreen.KeyDown
	If(e.KeyCode.Equals(Keys.Enter) Or e.KeyCode.Equals(Keys.Return)) Then
		e.SuppressKeyPress = True
		lblOriginal.Focus()
	End If
End Sub

'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Private Sub cboMinRed_KeyDown( sender As System.Object,  e As System.Windows.Forms.KeyEventArgs) Handles cboMinRed.KeyDown
	If(e.KeyCode.Equals(Keys.Enter) Or e.KeyCode.Equals(Keys.Return)) Then
		e.SuppressKeyPress = True
		lblOriginal.Focus()
	End If
End Sub

'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Private Sub cboMaxBlue_KeyDown( sender As System.Object,  e As System.Windows.Forms.KeyEventArgs) Handles cboMaxBlue.KeyDown
	If(e.KeyCode.Equals(Keys.Enter) Or e.KeyCode.Equals(Keys.Return)) Then
		e.SuppressKeyPress = True
		lblOriginal.Focus()
	End If
End Sub

'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Private Sub cboMaxGreen_KeyDown( sender As System.Object,  e As System.Windows.Forms.KeyEventArgs) Handles cboMaxGreen.KeyDown
	If(e.KeyCode.Equals(Keys.Enter) Or e.KeyCode.Equals(Keys.Return)) Then
		e.SuppressKeyPress = True
		lblOriginal.Focus()
	End If
End Sub

'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Private Sub cboMaxRed_KeyDown( sender As System.Object,  e As System.Windows.Forms.KeyEventArgs) Handles cboMaxRed.KeyDown
	If(e.KeyCode.Equals(Keys.Enter) Or e.KeyCode.Equals(Keys.Return)) Then
		e.SuppressKeyPress = True
		lblOriginal.Focus()
	End If
End Sub

'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Sub ProcessImageAndUpdateGUI(sender As Object, arg As EventArgs)
	If(rdoImageFile.Checked = True) Then																		'if the image file radio button is chosen . . .
		Try
			imgOriginal = New Image(Of Bgr, Byte)(txtFile.Text)										'get original image from file name in text box
		Catch ex As Exception
			Return
		End Try
	Else If(rdoWebcam.Checked = True) Then																	'else if the webcam radio button is chosen . . .
		Try
			imgOriginal = capWebcam.QueryFrame()																	'get next frame from webcam
		Catch ex As Exception
			Return
		End Try
	Else
		'should never get here
	End If
	
	If(imgOriginal Is Nothing) Then										'if imgOriginal is null
		Return																					'bail
	End If
																																'perform image smoothing
	imgSmoothed = imgOriginal.PyrDown().PyrUp()										'Gaussian pyramid decomposition
	imgSmoothed._SmoothGaussian(3)																'Gaussian smooth, argument is size of filter window
	
	If(ckFilterOnColor.Checked = True) Then																'if filter on color check box is checked, then filter on color
		imgGrayColorFiltered = imgSmoothed.InRange(New Bgr(dblMinBlue, dblMinGreen, dblMinRed), New Bgr(dblMaxBlue, dblMaxGreen, dblMaxRed))
		imgGrayColorFiltered = imgGrayColorFiltered.PyrDown().PyrUp()						'repeat smoothing process after InRange function call,
		imgGrayColorFiltered._SmoothGaussian(3)																	'seems to work out better this way
	ElseIf(ckFilterOnColor.Checked = False) Then													'if filter on color is not checked,
		imgGrayColorFiltered = imgSmoothed.Convert(Of Gray, Byte)()					'then convert to gray without filtering
	End If
	
	Dim grayCannyThreshold As Gray = New Gray(160)									'first Canny threshold, used for both circle detection, and line / triangle / rectangle detection
	Dim grayCircleAccumThreshold As Gray = New Gray(100)						'second Canny threshold for circle detection, higher number = more selective
	Dim grayThreshLinking As Gray = New Gray(80)										'second Canny threshold for line / triangle / rectangle detection
	
	imgCanny = imgGrayColorFiltered.Canny(grayCannyThreshold, grayThreshLinking)					'Canny image used for line, triangle, rectangle, and polygon detection	
	imgCircles = imgOriginal.CopyBlank()														'create blank image, use for circles later
	imgLines = imgOriginal.CopyBlank()															'create blank image, use for lines later
	imgTrisRectsPolys = imgOriginal.CopyBlank()							'create blank image, use for triangles and rectangles later
																																							'HoughCircles arguments
	Dim dblAccumRes As Double = 2.0																							'resulution of the accumulator used to detect centers of circles
	Dim dblMinDistBetweenCircles As Double = imgGrayColorFiltered.Height / 4		'min distance between centers of detected circles
	Dim intMinRadius As Integer = 10																						'min radius of circles to search for
	Dim intMaxRadius As Integer = 400																						'max radius of circles to search for
																																							'find circles
	Dim circles As CircleF() = imgGrayColorFiltered.HoughCircles(grayCannyThreshold, grayCircleAccumThreshold, dblAccumRes, dblMinDistBetweenCircles, intMinRadius, intMaxRadius)(0)
	
	For Each circle As CircleF In circles
		imgCircles.Draw(circle, New Bgr(Color.Red), 2)						'draw circles on circles image
		If(ckDrawCirclesOnOriginalImage.Checked = True) Then			'if check box is checked
			imgOriginal.Draw(circle, New Bgr(Color.Red), 2)					'then also draw circles on original image
		End If
	Next
																													'HoughLinesBinary arguments
	Dim dblRhoRes As Double = 1.0														'distance resolution in pixels
	Dim dblThetaRes As Double = 4.0 * (Math.PI / 180.0)			'angle resolution in radians (multiply by PI / 180 converts to radians)
	Dim intThreshold As Integer = 20												'a line is returned by the function if the corresponding accumulator value is greater than threshold
	Dim dblMinLineWidth As Double = 30.0										'minimum width of a line
	Dim dblMinGapBetweenLines As Double = 10.0							'minimum gap between lines
																													'find lines
	Dim lines() As LineSegment2D = imgCanny.HoughLinesBinary(dblRhoRes, dblThetaRes, intThreshold, dblMinLineWidth, dblMinGapBetweenLines)(0)
	
	For Each line As LineSegment2D In lines
		imgLines.Draw(line, New Bgr(Color.DarkGreen), 2)							'draw lines on lines image
		If(ckDrawLinesOnOriginalImage.Checked = True) Then								'if check box is checked
			imgOriginal.Draw(line, New Bgr(Color.DarkGreen), 2)					'then also draw lines on original image
		End If
	Next
	
	Dim contours As Contour(Of Point) = imgCanny.FindContours()													'find a sequence (similar to a linked list) of contours using the simple approximation method
	Dim lstTriangles As List(Of Triangle2DF) = New List(Of Triangle2DF)()								'declare list of triangles
	Dim lstRectangles As List(Of MCvBox2D) = New List(Of MCvBox2D)()										'declare list of "rectangles"
	Dim lstPolygons As List(Of Contour(Of Point)) = New List(Of Contour(Of Point))			'declare list of polygons
	
	While(Not contours Is Nothing)
		Dim contour As Contour(Of Point) = contours.ApproxPoly(10.0)											'approximates one or more curves and returns the approximation results
		If(contour.Area > 250.0) Then
			If(contour.Total = 3) Then																											'if 3 points, it's a triangle
				Dim ptPoints() As Point = contour.ToArray()																		'get contour points
				lstTriangles.Add(New Triangle2DF(ptPoints(0), ptPoints(1), ptPoints(2)))			'and add to triangle list
			ElseIf(contour.Total >= 4 And contour.Total <= 6) Then													'if 4, 5, or 6 points, could be a square or a polygon
				Dim ptPoints() As Point = contour.ToArray()																		'get contour points
				Dim blnIsRectangle As Boolean = True																					'to start with, lets suppose it's a rectangle
				
				If(contour.Total = 4) Then																												'if 4 points, could be a rectangle . . .
					Dim ls2dEdges As LineSegment2D() = PointCollection.PolyLine(ptPoints, True)			'get edges between points
					For i As Integer = 0 To ls2dEdges.Length - 1																		'step through edges
						Dim dblAngle As Double = Math.Abs(ls2dEdges((i + 1) Mod ls2dEdges.Length).GetExteriorAngleDegree(ls2dEdges(i)))
						If(dblAngle < 80.0 Or dblAngle > 100.0) Then																	'if not about a 90 degree angle between edges
							blnIsRectangle = False																											'then it's not a rectangle
							Exit For																																		'note that if execution never gets here, blnIsRectangle will stay True as initialized
						End If
					Next
				Else															'if more than 4 points,
					blnIsRectangle = False					'can't possibly be a rectangle
				End If
				
				If(blnIsRectangle) Then																'if a rectangle
					lstRectangles.Add(contour.GetMinAreaRect())					'add to list of rectangles
				Else																									'otherwise
					lstPolygons.Add(contour)														'add to list of polygons
				End If
			End If
		End If
		contours = contours.HNext							'go to next contour in countours sequence
	End While
	
	For Each triangle As Triangle2DF In lstTriangles
		imgTrisRectsPolys.Draw(triangle, New Bgr(Color.Yellow), 2)						'add the triangles to the image
		If(ckDrawTrisRectsAndPolysOnOriginalImage.Checked = True) Then				'if check box is checked
			imgOriginal.Draw(triangle, New Bgr(Color.Yellow), 2)								'then also draw triangles on original image
		End If
	Next
	
	For Each rect As MCvBox2D In lstRectangles
		imgTrisRectsPolys.Draw(rect, New Bgr(Color.Blue), 2)									'add the rectangles to the image
		If(ckDrawTrisRectsAndPolysOnOriginalImage.Checked = True) Then				'if check box is checked
			imgOriginal.Draw(rect, New Bgr(Color.Blue), 2)											'then also draw rectangles on original image
		End If
	Next
	
	For Each contPoly As Contour(Of Point) In lstPolygons
		imgTrisRectsPolys.Draw(contPoly, New Bgr(Color.Gray), 2)							'add the polygons to the image
		If(ckDrawTrisRectsAndPolysOnOriginalImage.Checked = True) Then				'if check box is checked
			imgOriginal.Draw(contPoly, New Bgr(Color.Gray), 2)									'then also draw polygons on original image
		End If
	Next
	
	ibOriginal.Image = imgOriginal																					'show all 6 images on form
	ibGrayColorFiltered.Image = imgGrayColorFiltered
	ibCanny.Image = imgCanny
	ibCircles.Image = imgCircles
	ibLines.Image = imgLines
	ibTrisRectsPolys.Image = imgTrisRectsPolys
	
End Sub

End Class
