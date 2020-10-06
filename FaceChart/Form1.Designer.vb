<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFaceChart
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtUnderValue = New System.Windows.Forms.TextBox()
        Me.txtHealth = New System.Windows.Forms.TextBox()
        Me.txtGrowth = New System.Windows.Forms.TextBox()
        Me.picCanvas = New System.Windows.Forms.PictureBox()
        Me.btnDraw = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picCanvas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "成長性（&G）："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "割安性（&M）："
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "財務健全性（&H）："
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "イメージ："
        '
        'txtUnderValue
        '
        Me.txtUnderValue.Location = New System.Drawing.Point(231, 75)
        Me.txtUnderValue.Name = "txtUnderValue"
        Me.txtUnderValue.Size = New System.Drawing.Size(100, 25)
        Me.txtUnderValue.TabIndex = 4
        '
        'txtHealth
        '
        Me.txtHealth.Location = New System.Drawing.Point(231, 121)
        Me.txtHealth.Name = "txtHealth"
        Me.txtHealth.Size = New System.Drawing.Size(100, 25)
        Me.txtHealth.TabIndex = 5
        '
        'txtGrowth
        '
        Me.txtGrowth.Location = New System.Drawing.Point(231, 30)
        Me.txtGrowth.Name = "txtGrowth"
        Me.txtGrowth.Size = New System.Drawing.Size(100, 25)
        Me.txtGrowth.TabIndex = 6
        '
        'picCanvas
        '
        Me.picCanvas.Location = New System.Drawing.Point(181, 181)
        Me.picCanvas.Name = "picCanvas"
        Me.picCanvas.Size = New System.Drawing.Size(117, 123)
        Me.picCanvas.TabIndex = 7
        Me.picCanvas.TabStop = False
        '
        'btnDraw
        '
        Me.btnDraw.Location = New System.Drawing.Point(380, 121)
        Me.btnDraw.Name = "btnDraw"
        Me.btnDraw.Size = New System.Drawing.Size(183, 43)
        Me.btnDraw.TabIndex = 8
        Me.btnDraw.Text = "イメージ表示（&D）"
        Me.btnDraw.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(380, 267)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(183, 37)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "終了（&X）"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmFaceChart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 363)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDraw)
        Me.Controls.Add(Me.picCanvas)
        Me.Controls.Add(Me.txtGrowth)
        Me.Controls.Add(Me.txtHealth)
        Me.Controls.Add(Me.txtUnderValue)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmFaceChart"
        Me.Text = "Form1"
        CType(Me.picCanvas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtUnderValue As TextBox
    Friend WithEvents txtHealth As TextBox
    Friend WithEvents txtGrowth As TextBox
    Friend WithEvents picCanvas As PictureBox
    Friend WithEvents btnDraw As Button
    Friend WithEvents btnExit As Button
End Class
