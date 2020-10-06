<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGetMax
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lstScore = New System.Windows.Forms.ListBox()
        Me.btnMaxValue = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstScore
        '
        Me.lstScore.FormattingEnabled = True
        Me.lstScore.ItemHeight = 18
        Me.lstScore.Location = New System.Drawing.Point(112, 60)
        Me.lstScore.Name = "lstScore"
        Me.lstScore.Size = New System.Drawing.Size(402, 220)
        Me.lstScore.TabIndex = 0
        '
        'btnMaxValue
        '
        Me.btnMaxValue.Location = New System.Drawing.Point(126, 336)
        Me.btnMaxValue.Name = "btnMaxValue"
        Me.btnMaxValue.Size = New System.Drawing.Size(138, 33)
        Me.btnMaxValue.TabIndex = 1
        Me.btnMaxValue.Text = "最高点（&M）"
        Me.btnMaxValue.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(301, 336)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(138, 35)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "終了（&X）"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmGetMax
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(642, 406)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnMaxValue)
        Me.Controls.Add(Me.lstScore)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmGetMax"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstScore As ListBox
    Friend WithEvents btnMaxValue As Button
    Friend WithEvents btnExit As Button
End Class
