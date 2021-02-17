Public Class Form2
    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim STA121 As Integer
        TextBox1.Text = STA121
        If TextBox1.Text >= 80 Then
            TextBox1.Text = "A"
        ElseIf TextBox1.Text >= 70 Then
            TextBox1.Text = "AB"
        ElseIf TextBox1.Text >= 70 Then
            TextBox1.Text = "B"
        ElseIf TextBox1.Text >= 60 Then
            TextBox1.Text = "BC"
        ElseIf TextBox1.Text >= 50 Then
            TextBox1.Text = "C"
        Else
            MsgBox("you fail")
        End If
        Form1.Show()
        Me.Hide()
    End Sub
End Class
