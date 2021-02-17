Public Class Form1

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If TimeOfDay = DateTimePicker1.Text Then
            'This will instantinize a new "voice" for this app to speak through
            Dim voice = CreateObject("SAPI.spvoice")
            'what the content of lblmsg will be passed to  voice.speak

            voice.speak(TextBox1.Text)
            lblstatus.Text = "Status:Alarm is not set!"
        End If

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        lblcurtime.Text = TimeOfDay
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer2.Enabled = True

    End Sub

    Private Sub btnsetalarm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsetalarm.Click
        Timer1.Enabled = True
        lblstatus.Text = "Status:Alarm is set!"
    End Sub
End Class
