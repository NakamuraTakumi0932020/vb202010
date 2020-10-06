Public Class Form1
    Public MaxSeatCount As Integer = 200
    Dim x As String = "外側のx"
    Private Sub ShowString1_Click(sender As Object, e As EventArgs) Handles ShowString1.Click
        Dim x As String = "内側のx"
        Dim y As String = "内側のy"

        Debug.WriteLine(x)
    End Sub
    Private Sub ShowString2_Click(sender As Object, e As EventArgs) Handles ShowString2.Click
        Debug.WriteLine(x)
        'Debug.WriteLine(y)
    End Sub
    Private Sub btnToForm2_Click(sender As Object, e As EventArgs) Handles btnToForm2.Click
        Form2.Show()
    End Sub

End Class
