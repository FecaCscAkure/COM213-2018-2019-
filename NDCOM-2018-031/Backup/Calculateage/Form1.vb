Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a As String
        Dim b As String
        Dim c As String
        a = TextBox3.Text
        b = TextBox1.Text
        c = TextBox2.Text
        Dim DOB As New DateTime(a, b, c)
        Dim Years As Integer = DateDiff(DateInterval.Year, DOB, Now) - 1
        Dim Months As Integer = DateDiff(DateInterval.Month, DOB, Now) Mod 12
        Dim days As Integer = DateDiff(DateInterval.Day, DOB, Now) Mod 30 - 10
        TextBox4.Text = Years & " Years, " & Months & " Months "
    End Sub

End Class
