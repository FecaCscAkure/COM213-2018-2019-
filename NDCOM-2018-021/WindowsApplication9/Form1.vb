Public Class Form1
    Dim a As Integer
    Dim b As Integer
    Dim c As Integer
    Dim Det As Double
    Dim Root1 As Double
    Dim Root2 As Double

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        c = Val(TextBox3.Text)

        'To compute the value of the determinant
        Det = (b ^ 2) + (4 * a * c)
        Root1 = (-b + Math.Sqrt(Det)) / (2 * a)
        Root2 = (-b - Math.Sqrt(Det)) / (2 * a)
        MsgBox(Root1)
        MsgBox(Root2)

    End Sub
End Class
