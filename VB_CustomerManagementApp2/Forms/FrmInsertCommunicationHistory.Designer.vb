<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInsertCommunicationHistory
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
        Me.TxtTitle = New System.Windows.Forms.TextBox()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.InsertCommunicationHistory = New System.Windows.Forms.Button()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.TxtDetail = New System.Windows.Forms.TextBox()
        Me.LblDetail = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtTitle
        '
        Me.TxtTitle.Location = New System.Drawing.Point(41, 84)
        Me.TxtTitle.Name = "TxtTitle"
        Me.TxtTitle.Size = New System.Drawing.Size(636, 25)
        Me.TxtTitle.TabIndex = 82
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Location = New System.Drawing.Point(38, 33)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(61, 18)
        Me.LblTitle.TabIndex = 81
        Me.LblTitle.Text = "タイトル"
        '
        'InsertCommunicationHistory
        '
        Me.InsertCommunicationHistory.Location = New System.Drawing.Point(498, 533)
        Me.InsertCommunicationHistory.Margin = New System.Windows.Forms.Padding(2)
        Me.InsertCommunicationHistory.Name = "InsertCommunicationHistory"
        Me.InsertCommunicationHistory.Size = New System.Drawing.Size(179, 52)
        Me.InsertCommunicationHistory.TabIndex = 80
        Me.InsertCommunicationHistory.Text = "登録"
        Me.InsertCommunicationHistory.UseVisualStyleBackColor = True
        '
        'BtnBack
        '
        Me.BtnBack.Location = New System.Drawing.Point(282, 533)
        Me.BtnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(179, 52)
        Me.BtnBack.TabIndex = 79
        Me.BtnBack.Text = "戻る"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'TxtDetail
        '
        Me.TxtDetail.Location = New System.Drawing.Point(41, 171)
        Me.TxtDetail.Multiline = True
        Me.TxtDetail.Name = "TxtDetail"
        Me.TxtDetail.Size = New System.Drawing.Size(636, 299)
        Me.TxtDetail.TabIndex = 78
        '
        'LblDetail
        '
        Me.LblDetail.AutoSize = True
        Me.LblDetail.Location = New System.Drawing.Point(38, 130)
        Me.LblDetail.Name = "LblDetail"
        Me.LblDetail.Size = New System.Drawing.Size(44, 18)
        Me.LblDetail.TabIndex = 77
        Me.LblDetail.Text = "詳細"
        '
        'FrmInsertCommunicationHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 644)
        Me.Controls.Add(Me.TxtTitle)
        Me.Controls.Add(Me.LblTitle)
        Me.Controls.Add(Me.InsertCommunicationHistory)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.TxtDetail)
        Me.Controls.Add(Me.LblDetail)
        Me.Name = "FrmInsertCommunicationHistory"
        Me.Text = "FrmInsertCommunicationHistory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtTitle As TextBox
    Friend WithEvents LblTitle As Label
    Friend WithEvents InsertCommunicationHistory As Button
    Friend WithEvents BtnBack As Button
    Friend WithEvents TxtDetail As TextBox
    Friend WithEvents LblDetail As Label
End Class
