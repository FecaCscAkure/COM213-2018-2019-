Public Class Form1
    Dim a As Integer
    Dim b As Integer
    Dim c As Integer
    Dim Det As Double
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        c = Val(TextBox3.Text)

        'To compute the value of the determinant
        Det = ((a + b) / 2) * c
        MsgBox(Det)
    End Sub
End Class
