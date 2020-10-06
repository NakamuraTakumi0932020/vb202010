Public Class frmGetMax
    Private Sub InitProc(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim r As Random = New Random()
        lstScore.Items.Clear()
        For i As Integer = 0 To 9
            lstScore.Items.Add(r.Next(101))
        Next
    End Sub

    Private Sub SearchMaxValue(sender As Object, e As EventArgs) Handles btnMaxValue.Click
        Dim MaxScore As Integer
        MaxScore = Integer.MinValue
        For Each Score As Integer In lstScore.Items
            If Score > MaxScore Then
                MaxScore = Score
            End If
        Next
        MessageBox.Show("最高点は" & MaxScore & "です")
    End Sub

    Private Sub ProcExit(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub





End Class
