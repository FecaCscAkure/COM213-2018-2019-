Public Class Form1
    Private stopwatch As New Stopwatch
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Dim elapsed As TimeSpan = stopwatch.Elapsed
        Label1.Text = String.Format("{0:00}:{1:00}:{2:00}:{3:00}",
                                    Math.Floor(elapsed.TotalHours),
                                    elapsed.Minutes, elapsed.Seconds, elapsed.Milliseconds)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If Button1.Text = "Start" Then
            Timer1.Start()
            stopwatch.Start()
            Button1.Text = "Stop"
            Button3.Enabled = False
        Else
            Timer1.Stop()
            stopwatch.Stop()
            Button1.Text = "Start"
            Button3.Enabled = True
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        officialseed.Items.Add(officialseed.Items.Count + 1 & ". " & Label1.Text)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        stopwatch.Reset()
        Label1.Text = "00:00:00:00"
        officialseed.Items.Clear()

    End Sub
End Class
