Imports System.Text

Public Class Form1


#Region "Variables"

    Private TimeHours As Integer = 0
    Private TimeMinutes As Integer = 0
    Private TimeSeconds2 As Integer = 0

    Private mouseOffset As Point
    Private isMouseDown As Boolean = False
#End Region

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Create passwords - " & My.Application.Info.Version.ToString
    End Sub
    Private Sub TimerCreatePass_Tick(sender As System.Object, e As System.EventArgs) Handles TimerCreatePass.Tick
        Dim numUpperV, numLowerV, numNumbersV, numSpecialV As Integer

        numUpperV = 3
        numLowerV = 2
        numNumbersV = 2
        numSpecialV = 1

        'Dim s As String = "!@#$%abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
        'Dim s As String = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz01!2@3#4$5%6&7*89"
        Dim s As String = txtCharacters.Text
        Dim r As New Random
        Dim sb As New StringBuilder
        Dim NumberOfCharacters As Integer = Len(txtCharacters.Text)
        For i As Integer = 1 To txtNumbers.Text
            Dim idx As Integer = r.Next(0, NumberOfCharacters)
            sb.Append(s.Substring(idx, 1))
        Next
        txtShowPassword.Text = sb.ToString()


        If ValidatePassword(txtShowPassword.Text, txtNumbers.Text, numUpperV, numLowerV, numNumbersV, numSpecialV) = True Then
            txtValidatePass.Text = "The password is acceptable."
            txtTime.Text = "Time Required for Password Generation: " & TimeHours & " h, " & TimeMinutes & " m, " & TimeSeconds2 & " s"
            TimerCreatePass.Enabled = False
            TimerTime.Enabled = False
            TimerColor.Enabled = False
        Else
            txtValidatePass.Text = "Unacceptable password. New effort is taking place ..."
        End If
    End Sub
    Private Sub btnGenerate_Click(sender As System.Object, e As System.EventArgs) Handles btnGenerate.Click
        If txtNumbers.Text < 8 Then
            MsgBox("The code must consist of at least 8 alphanumeric characters.")
            txtNumbers.Text = 8
            Exit Sub
        Else
        End If

        TimeHours = 0
        TimeMinutes = 0
        TimeSeconds2 = 0
        txtTime.Text = "Time needed for password creation: " & TimeHours & " h, " & TimeMinutes & " m, " & TimeSeconds2 & " s"

        TimerCreatePass.Enabled = True
        TimerTime.Enabled = True
        TimerColor.Enabled = True
    End Sub
    Function ValidatePassword(ByVal pwd As String, ByVal minLength As Integer, ByVal numUpper As Integer, ByVal numLower As Integer, ByVal numNumbers As Integer, ByVal numSpecial As Integer) As Boolean
        ' Replace [A-Z] with \p{Lu}, to allow for Unicode uppercase letters. 
        Dim upper As New System.Text.RegularExpressions.Regex("[A-Z]")
        Dim lower As New System.Text.RegularExpressions.Regex("[a-z]")
        Dim number As New System.Text.RegularExpressions.Regex("[0-9]")
        ' Special is "none of the above". 
        Dim special As New System.Text.RegularExpressions.Regex("[^a-zA-Z0-9]")

        ' Check the length. 
        If Len(pwd) < minLength Then Return False
        ' Check for minimum number of occurrences. 
        If upper.Matches(pwd).Count < numUpper Then Return False
        If lower.Matches(pwd).Count < numLower Then Return False
        If number.Matches(pwd).Count < numNumbers Then Return False
        If special.Matches(pwd).Count < numSpecial Then Return False

        ' Passed all checks. 
        Return True
    End Function
    Private Sub txtNumbers_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNumbers.TextChanged
        If txtNumbers.Text = "" Then
            txtNumbers.Text = 8
        End If

        'If txtNumbers.Text < 8 Then
        '    MsgBox("The code must consist of at least 8 alphanumeric characters.")
        '    txtNumbers.Text = 8
        '    Exit Sub
        'ElseIf txtNumbers.Text = "" Then
        '    txtNumbers.Text = 8
        'End If
    End Sub
    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        txtTime.Text = "Time Required for Password Generation: " & TimeHours & " ώ, " & TimeMinutes & " λ, " & TimeSeconds2 & " δ"
        TimerCreatePass.Enabled = False
        TimerTime.Enabled = False
        TimerColor.Enabled = False
    End Sub
    Private Sub TimerTime_Tick(sender As System.Object, e As System.EventArgs) Handles TimerTime.Tick
        txtValidatePass.ForeColor = Color.OrangeRed
        txtTime.Text = "Time needed for password creation: " & TimeHours & " ώ, " & TimeMinutes & " λ, " & TimeSeconds2 & " δ"
        If TimeSeconds2 = 60 Then
            TimeMinutes = TimeMinutes + 1
            If TimeMinutes = 60 Then
                TimeHours = TimeHours + 1
                TimeMinutes = 0
            End If
            TimeSeconds2 = 0
        End If
        TimeSeconds2 += 1
    End Sub
    Private Sub TimerColor_Tick(sender As System.Object, e As System.EventArgs) Handles TimerColor.Tick
        txtValidatePass.ForeColor = Color.Aqua
    End Sub
    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

#Region "Code to move the form"
    Private Sub lblTitle_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles lblTitle.MouseDown
        Dim xOffset As Integer
        Dim yOffset As Integer
        If e.Button = Windows.Forms.MouseButtons.Left Then
            xOffset = -e.X - SystemInformation.FrameBorderSize.Width
            yOffset = -e.Y - SystemInformation.FrameBorderSize.Height
            mouseOffset = New Point(xOffset, yOffset)
            isMouseDown = True
        End If
    End Sub
    Private Sub lblTitle_MouseUp(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles lblTitle.MouseUp
        isMouseDown = False
    End Sub
    Private Sub lblTitle_MouseMove(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles lblTitle.MouseMove
        If isMouseDown Then
            Dim mousePos As Point = Control.MousePosition
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Location = mousePos
        End If
    End Sub
#End Region
End Class
