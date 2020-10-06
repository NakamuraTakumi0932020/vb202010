Public Class Form2
    Private Sub btnShowValue_Click(sender As Object, e As EventArgs) Handles btnShowValue.Click
        Debug.WriteLine(Form1.MaxSeatCount)
    End Sub
End Class