
Imports MessagingToolkit.QRCode.Codec

Public Class Form1

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Try
            Call qrcodeGen()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    REM qr code generator
    Private Sub qrcodeGen()
        Try
            Dim qrCode As New QRCodeEncoder
            qrCode.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE
            qrCode.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.L
            Me.PictureBox1.Image = qrCode.Encode(Me.txtCode.Text, System.Text.Encoding.UTF8)


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    REM export qr to image
    REM exported QR images is saved directly in MY DOCUMENTS directory
    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Try
            If Me.PictureBox1.Image IsNot Nothing Then
                Me.PictureBox1.Image.Save(IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, Me.txtCode.Text & ".jpg"))
                MessageBox.Show("QR is successfully saved")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class
