Public Class frmConvertTime
    Private Sub DoConvert(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim WorkingTime As Double '少数で表された時間
        Dim WorkingHour, WorkingMinute As Integer

        WorkingHour = CInt(txtHour.Text)
        WorkingMinute = CInt(txtMinute.Text)
        '時間の計算
        WorkingTime = WorkingHour + WorkingMinute / 60
        '時間の表示
        lblTime.Text = WorkingTime.ToString()
    End Sub

    Private Sub ExitProc(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
