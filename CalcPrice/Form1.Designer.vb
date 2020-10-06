<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalcPrice
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
        Me.lblStandardPrice = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblSalesPrice = New System.Windows.Forms.Label()
        Me.rbNone = New System.Windows.Forms.RadioButton()
        Me.rbStudent = New System.Windows.Forms.RadioButton()
        Me.rbHolder = New System.Windows.Forms.RadioButton()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(109, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "標準価格（&S）:"
        '
        'lblStandardPrice
        '
        Me.lblStandardPrice.AutoSize = True
        Me.lblStandardPrice.Location = New System.Drawing.Point(253, 61)
        Me.lblStandardPrice.Name = "lblStandardPrice"
        Me.lblStandardPrice.Size = New System.Drawing.Size(0, 18)
        Me.lblStandardPrice.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(109, 242)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "販売価格（&P）:"
        '
        'lblSalesPrice
        '
        Me.lblSalesPrice.AutoSize = True
        Me.lblSalesPrice.Location = New System.Drawing.Point(253, 242)
        Me.lblSalesPrice.Name = "lblSalesPrice"
        Me.lblSalesPrice.Size = New System.Drawing.Size(0, 18)
        Me.lblSalesPrice.TabIndex = 3
        '
        'rbNone
        '
        Me.rbNone.AutoSize = True
        Me.rbNone.Checked = True
        Me.rbNone.Location = New System.Drawing.Point(147, 102)
        Me.rbNone.Name = "rbNone"
        Me.rbNone.Size = New System.Drawing.Size(127, 22)
        Me.rbNone.TabIndex = 4
        Me.rbNone.TabStop = True
        Me.rbNone.Text = "割引なし（&N）"
        Me.rbNone.UseVisualStyleBackColor = True
        '
        'rbStudent
        '
        Me.rbStudent.AutoSize = True
        Me.rbStudent.Location = New System.Drawing.Point(147, 151)
        Me.rbStudent.Name = "rbStudent"
        Me.rbStudent.Size = New System.Drawing.Size(134, 22)
        Me.rbStudent.TabIndex = 5
        Me.rbStudent.Text = "学生割引（&T）"
        Me.rbStudent.UseVisualStyleBackColor = True
        '
        'rbHolder
        '
        Me.rbHolder.AutoSize = True
        Me.rbHolder.Location = New System.Drawing.Point(147, 195)
        Me.rbHolder.Name = "rbHolder"
        Me.rbHolder.Size = New System.Drawing.Size(135, 22)
        Me.rbHolder.TabIndex = 6
        Me.rbHolder.Text = "株主優待（&H）"
        Me.rbHolder.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(315, 282)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(129, 35)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "終了（&X）"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmCalcPrice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 362)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.rbHolder)
        Me.Controls.Add(Me.rbStudent)
        Me.Controls.Add(Me.rbNone)
        Me.Controls.Add(Me.lblSalesPrice)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblStandardPrice)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmCalcPrice"
        Me.Text = "割引価格計算プログラム"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblStandardPrice As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblSalesPrice As Label
    Friend WithEvents rbNone As RadioButton
    Friend WithEvents rbStudent As RadioButton
    Friend WithEvents rbHolder As RadioButton
    Friend WithEvents btnExit As Button
End Class
