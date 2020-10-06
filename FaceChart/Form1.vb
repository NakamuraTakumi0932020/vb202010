Public Class frmFaceChart
    Private Sub MakeFaceChart(sender As Object, e As EventArgs) Handles btnDraw.Click
        Dim aFace As Face = New Face()
        aFace.Picture = picCanvas
        aFace.Growth = CInt(txtGrowth.Text)
        aFace.UnderValue = CInt(txtUnderValue.Text)
        aFace.Health = CInt(txtHealth.Text)
        aFace.Refresh()
    End Sub

    Private Sub ExitProc(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class

Public Class Face
    Private mGrowth As Integer      '成長性
    Private mUnderValue As Integer  '割安性
    Private mHealth As Integer      '財務健全性
    Private WithEvents picFace As PictureBox    '顔

    Public Property Growth() As Integer
        Get
            Return mGrowth
        End Get
        Set(value As Integer)
            mGrowth = Math.Min(10, Math.Max(1, value))
        End Set
    End Property

    Public Property UnderValue() As Integer
        Get
            Return mUnderValue
        End Get
        Set(value As Integer)
            mUnderValue = Math.Min(10, Math.Max(1, value))
        End Set
    End Property

    Public Property Health() As Integer
        Get
            Return mHealth
        End Get
        Set(value As Integer)
            mHealth = Math.Min(10, Math.Max(1, value))
        End Set
    End Property

    Public Property Picture() As PictureBox
        Get
            Return picFace
        End Get
        Set(value As PictureBox)
            picFace = value
        End Set
    End Property

    Private Sub DrawFace(sender As Object, e As PaintEventArgs) Handles picFace.Paint
        e.Graphics.Clear(picFace.BackColor)
        '輪郭
        e.Graphics.DrawEllipse(Pens.Black, 0, 0, 45, 45)
        '眉
        e.Graphics.DrawLine(Pens.Black, 10, 10, 20, mGrowth + 5)
        e.Graphics.DrawLine(Pens.Black, 25, mGrowth + 5, 35, 10)
        '目
        e.Graphics.DrawEllipse(Pens.Black, 15 - mUnderValue \ 2, 20 - mUnderValue \ 2, mUnderValue, mUnderValue)
        e.Graphics.DrawEllipse(Pens.Black, 30 - mUnderValue \ 2, 20 - mUnderValue \ 2, mUnderValue, mUnderValue)
        '口
        If (mHealth < 6) Then
            e.Graphics.DrawArc(Pens.Black, 15, 30, 15, 6 - mHealth, 0, 180)
        Else
            e.Graphics.DrawArc(Pens.Black, 15, 30, 15, mHealth, 180, 180)
        End If
    End Sub

    Public Sub Refresh()
        picFace.Refresh()
    End Sub

End Class
