Public Class frmCalcPrice
    Const StandrdPrice As Integer = 3600 '標準価格
    Private Sub frmCalcPrice_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblStandardPrice.Text = StandrdPrice.ToString("#,##0円")
    End Sub

    Private Sub Recalc(sender As Object, e As EventArgs) Handles rbNone.CheckedChanged, rbStudent.CheckedChanged, rbHolder.CheckedChanged
        Dim SalesPrice As Integer
        If rbNone.Checked Then
            SalesPrice = StandrdPrice
        ElseIf rbStudent.Checked Then
            SalesPrice = CInt(Int(StandrdPrice * 0.9))
        Else
            SalesPrice = CInt(Int(StandrdPrice * 0.85))
        End If
        lblSalesPrice.Text = SalesPrice.ToString()
    End Sub

    Private Sub ExitProc(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
