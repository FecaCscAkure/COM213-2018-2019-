Public Class Form1
    Dim a, b, c, d, det As Integer
    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        c = Val(TextBox3.Text)
        d = Val(TextBox4.Text)

        'To compute the value of the determinant
        det = (a + b + c + d)
        If det > 250 Then
            MsgBox("Congratulations!, You've beeen Selected for the 2020 Post-UTME. Good-Luck")
        ElseIf det < 250 Then
            MsgBox("Sorry!, You're below the cut-off Mark. You are not eligible to write the Exam")
        End If
    End Sub


End Class
