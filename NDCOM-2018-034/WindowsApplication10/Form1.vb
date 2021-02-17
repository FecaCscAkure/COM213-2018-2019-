Public Class Form1
    Dim a As Integer
    Dim Det As Double

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        a = Val(TextBox1.Text)

        'To compute the value of the determinant
        Det = (22 / 7) * a ^ 2
        MsgBox(Det)
    End Sub
End Class
