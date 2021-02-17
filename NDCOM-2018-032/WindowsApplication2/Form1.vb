Public Class Form1
    Dim a, b, det As Integer
    Dim numroot As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)

        'To compute the value of the determinant
        det = ((1 / 2) * b) * a
        MsgBox(Det)
    End Sub
End Class
