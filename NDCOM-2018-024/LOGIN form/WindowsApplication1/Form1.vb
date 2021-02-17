Public Class Form1

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text >= 80 Then
            TextBox1.Text = "A"
        End If






        If TextBox1.Text >= 90 Then TextBox5.Text = "A"
    End Sub
End Class
