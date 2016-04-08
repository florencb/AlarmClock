Public Class frmMain

    Private Sub btnSetAlarm_Click(sender As Object, e As EventArgs) Handles btnSetAlarm.Click
        'sets alarm
        tmrAlarm.Start()
    End Sub

    Private Sub tmrDisplayTIme_Tick(sender As Object, e As EventArgs) Handles tmrDisplayTIme.Tick
        'retirives curretn time of operating system.
        'formats it to string, and adds " : " in between and " AM/PM " at the end.
        lblTimeDisplay.Text = TimeOfDay.ToLongTimeString
    End Sub

    Private Sub tmrBeep_Tick(sender As Object, e As EventArgs) Handles tmrBeep.Tick
        'pre written class referring to current computer.
        'makes console beep repetitively.
        Console.Beep()
    End Sub

    Private Sub tmrAlarm_Tick(sender As Object, e As EventArgs) Handles tmrAlarm.Tick
        'retrives alarm time from user input
        'keeps checking if current time is same as alarm time
        'converts input letters to upper case
        'if alarm time is enabled, timer beeps continuously
        If txtAlarmTime.Text.ToUpper = TimeOfDay.ToLongTimeString Then
            tmrBeep.Start()
        End If
    End Sub

    Private Sub btnStopAlarm_Click(sender As Object, e As EventArgs) Handles btnStopAlarm.Click
        'by clicking stop buttton beeping stops, and alarm stops
        tmrBeep.Stop()
        tmrAlarm.Stop()
    End Sub
End Class
