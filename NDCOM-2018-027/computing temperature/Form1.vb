Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim t, h, f As Double
        t = Convert.ToDouble(txtt.Text)
        h = Convert.ToDouble(txth.Text)


        f = Convert.ToDouble(txtf.Text)

        temphumid(t, h)
        forcast(t, h, f)


    End Sub
    Private Sub temphumid(ByVal t As Double, ByVal h As Double)
        Dim th As Double
        th = t + h
        lbls.Text = th

    End Sub
    Private Sub forcast(ByVal t As Double, ByVal h As Double, ByVal f As Double)
        Dim ff, th As Double
        th = t + h
        ff = (th / f)

        If (ff < -19) And (ff < 2) Then
            lblw.Text = "snow is near"
        ElseIf (ff > 1) And (ff < 16) Then
            lblw.Text = "cold"
        ElseIf (ff > 15) And (ff < 22) Then
            lblw.Text = "normal"
        ElseIf (ff > 21) And (ff < 36) Then
            lblw.Text = "warm"
        ElseIf (ff > 35) And (ff < 49) Then
            lblw.Text = "mild"
        ElseIf (ff > 48) And (ff < 62) Then
            lblw.Text = "hot"
        ElseIf (ff > 61) And (ff < 84) Then
            lblw.Text = "very hot"
        ElseIf (ff > 83) And (ff < 101) Then
            lblw.Text = "too hot"
        Else
            lblw.Text = "pls enter range btw 1 to 100"


        End If

    End Sub
End Class
