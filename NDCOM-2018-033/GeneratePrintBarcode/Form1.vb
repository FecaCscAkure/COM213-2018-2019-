Imports System.Drawing.Imaging
Imports IDAutomation.Windows.Forms.LinearBarCode
Imports System.Drawing.Printing
Imports System.Configuration
Imports GenCode128

Public Class Form1
    Private WithEvents pdPrint As PrintDocument
    Private PrintDocType As String = "Barcode"
    Private StrPrinterName As String = "Microsoft XPS Document Writer"
    Dim pbImage2 As New PictureBox

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub pdPrint_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles pdPrint.PrintPage

        Dim rect As New Rectangle(0, 10, 280, 85)
        Dim sf As New StringFormat
        sf.LineAlignment = StringAlignment.Center
        Dim printFont10_Normal As New Font("Calibri", 10, FontStyle.Regular, GraphicsUnit.Point)
        rect = New Rectangle(0, 10, 280, 15)

        e.Graphics.DrawString("----------IDAutomation---------------", printFont10_Normal, Brushes.Black, rect, sf)
        e.Graphics.DrawRectangle(Pens.White, rect)

        Dim h, w, h2, w2 As Integer
        Dim pbImage As New PictureBox
        pbImage.Image = Image.FromFile(Application.StartupPath & "\" & "SavedBarcode.Jpeg")
        w = Image.FromFile(Application.StartupPath & "\" & "SavedBarcode.Jpeg").Width
        h = Image.FromFile(Application.StartupPath & "\" & "SavedBarcode.Jpeg").Height
        Dim lPosition As Integer
        lPosition = (280 - w) / 2
        rect = New Rectangle(50, 25, w, h)
        e.Graphics.InterpolationMode = Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        e.Graphics.CompositingQuality = Drawing2D.CompositingQuality.HighQuality
        e.Graphics.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighQuality
        e.Graphics.DrawImage(pbImage.Image, rect)
        e.Graphics.DrawRectangle(Pens.White, rect)

        rect = New Rectangle(0, 95, 280, 15)
        e.Graphics.DrawString("------------------------------------------------", printFont10_Normal, Brushes.Black, rect, sf)
        e.Graphics.DrawRectangle(Pens.White, rect)


        rect = New Rectangle(0, 105, 280, 15)
        e.Graphics.DrawString("---------------GEN128Barcode----------------------", printFont10_Normal, Brushes.Black, rect, sf)
        e.Graphics.DrawRectangle(Pens.White, rect)

        w2 = pbImage2.Width
        h2 = pbImage2.Height
        rect = New Rectangle(50, 130, w2, h2)
        e.Graphics.InterpolationMode = Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        e.Graphics.CompositingQuality = Drawing2D.CompositingQuality.HighQuality
        e.Graphics.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighQuality
        e.Graphics.DrawImage(pbImage2.Image, rect)
        e.Graphics.DrawRectangle(Pens.White, rect)

        rect = New Rectangle(70, 185, 280, 15)
        e.Graphics.DrawString(txtBarcode.Text.ToString(), printFont10_Normal, Brushes.Black, rect, sf)
        e.Graphics.DrawRectangle(Pens.White, rect)

        rect = New Rectangle(0, 215, 280, 15)
        e.Graphics.DrawString("------------------------------------------------", printFont10_Normal, Brushes.Black, rect, sf)
        e.Graphics.DrawRectangle(Pens.White, rect)
    End Sub

    Private Sub btnGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.Click
        'ID Automation
        'Free only with the Code39 and Code39Ext
        Dim NewBarcode As IDAutomation.Windows.Forms.LinearBarCode.Barcode = New Barcode()
        NewBarcode.DataToEncode = txtBarcode.Text.ToString() 'Input of textbox to generate barcode 
        NewBarcode.SymbologyID = Symbologies.Code39
        NewBarcode.Code128Set = Code128CharacterSets.A
        NewBarcode.RotationAngle = RotationAngles.Zero_Degrees
        NewBarcode.RefreshImage()
        NewBarcode.Resolution = Resolutions.Screen
        NewBarcode.ResolutionCustomDPI = 96
        NewBarcode.RefreshImage()
        NewBarcode.SaveImageAs("SavedBarcode.Jpeg", System.Drawing.Imaging.ImageFormat.Jpeg)
        NewBarcode.Resolution = Resolutions.Printer
        imgIDAutomation.Image = Image.FromFile(Application.StartupPath & "\" & "SavedBarcode.Jpeg")

        'Barcode using the GenCode128
        Dim myimg As Image = Code128Rendering.MakeBarcodeImage(txtBarcode.Text.ToString(), Integer.Parse(txtWeight.Text.ToString()), False)
        imgGenCode.Image = myimg
        pbImage2.Image = myimg
        'Barcode using the GenCode128
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Try
            pdPrint = New PrintDocument
            pdPrint.PrinterSettings.PrinterName = StrPrinterName
            pdPrint.PrintController = New StandardPrintController
            If pdPrint.PrinterSettings.IsValid Then
                pdPrint.DocumentName = PrintDocType
                pdPrint.Print()
            End If
        Catch ex As Exception
        End Try
    End Sub

End Class
