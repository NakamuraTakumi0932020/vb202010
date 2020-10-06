<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.ShowString1 = New System.Windows.Forms.Button()
        Me.ShowString2 = New System.Windows.Forms.Button()
        Me.btnToForm2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ShowString1
        '
        Me.ShowString1.Location = New System.Drawing.Point(113, 42)
        Me.ShowString1.Name = "ShowString1"
        Me.ShowString1.Size = New System.Drawing.Size(147, 56)
        Me.ShowString1.TabIndex = 0
        Me.ShowString1.Text = "ShowString1"
        Me.ShowString1.UseVisualStyleBackColor = True
        '
        'ShowString2
        '
        Me.ShowString2.Location = New System.Drawing.Point(279, 42)
        Me.ShowString2.Name = "ShowString2"
        Me.ShowString2.Size = New System.Drawing.Size(147, 56)
        Me.ShowString2.TabIndex = 1
        Me.ShowString2.Text = "ShowString2"
        Me.ShowString2.UseVisualStyleBackColor = True
        '
        'btnToForm2
        '
        Me.btnToForm2.Location = New System.Drawing.Point(279, 154)
        Me.btnToForm2.Name = "btnToForm2"
        Me.btnToForm2.Size = New System.Drawing.Size(147, 46)
        Me.btnToForm2.TabIndex = 2
        Me.btnToForm2.Text = "To Form2"
        Me.btnToForm2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 235)
        Me.Controls.Add(Me.btnToForm2)
        Me.Controls.Add(Me.ShowString2)
        Me.Controls.Add(Me.ShowString1)
        Me.Name = "Form1"
        Me.Text = "ShoeString"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ShowString1 As Button
    Friend WithEvents ShowString2 As Button
    Friend WithEvents btnToForm2 As Button
End Class
