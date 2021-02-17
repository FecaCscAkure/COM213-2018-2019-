Public Class Form1
    Dim a As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        a = Val(TextBox1.Text)
        If a > 18 Then
            MsgBox("You're eligible to vote")
        ElseIf a < 18 Then
            MsgBox("You're too young to vote.")
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
