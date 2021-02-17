Public Class Form1

    Private Sub cmdBigger_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        picBMP.Height = picBMP.Height + 10
        picBMP.Width = picBMP.Width + 10
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        picBMP.Height = picBMP.Height - 10
        picBMP.Width = picBMP.Width - 10
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Hide()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Show()
    End Sub
End Class
