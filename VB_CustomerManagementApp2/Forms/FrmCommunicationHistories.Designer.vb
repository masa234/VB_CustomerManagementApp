<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCommunicationHistories
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
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.DgvCommunicationHistories = New System.Windows.Forms.DataGridView()
        Me.TxtID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtTitle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtDetail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnDeleteCommunicationHistory = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.DgvCommunicationHistories, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnBack
        '
        Me.BtnBack.Location = New System.Drawing.Point(547, 361)
        Me.BtnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(179, 52)
        Me.BtnBack.TabIndex = 59
        Me.BtnBack.Text = "戻る"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'DgvCommunicationHistories
        '
        Me.DgvCommunicationHistories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCommunicationHistories.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TxtID, Me.TxtTitle, Me.TxtDetail, Me.BtnDeleteCommunicationHistory})
        Me.DgvCommunicationHistories.Location = New System.Drawing.Point(75, 37)
        Me.DgvCommunicationHistories.Name = "DgvCommunicationHistories"
        Me.DgvCommunicationHistories.RowHeadersWidth = 62
        Me.DgvCommunicationHistories.RowTemplate.Height = 27
        Me.DgvCommunicationHistories.Size = New System.Drawing.Size(651, 292)
        Me.DgvCommunicationHistories.TabIndex = 58
        '
        'TxtID
        '
        Me.TxtID.DataPropertyName = "Id"
        Me.TxtID.HeaderText = "ID"
        Me.TxtID.MinimumWidth = 8
        Me.TxtID.Name = "TxtID"
        Me.TxtID.Visible = False
        Me.TxtID.Width = 150
        '
        'TxtTitle
        '
        Me.TxtTitle.DataPropertyName = "Title"
        Me.TxtTitle.HeaderText = "タイトル"
        Me.TxtTitle.MinimumWidth = 8
        Me.TxtTitle.Name = "TxtTitle"
        Me.TxtTitle.Width = 150
        '
        'TxtDetail
        '
        Me.TxtDetail.DataPropertyName = "Detail"
        Me.TxtDetail.HeaderText = "詳細"
        Me.TxtDetail.MinimumWidth = 8
        Me.TxtDetail.Name = "TxtDetail"
        Me.TxtDetail.Width = 150
        '
        'BtnDeleteCommunicationHistory
        '
        Me.BtnDeleteCommunicationHistory.HeaderText = "削除"
        Me.BtnDeleteCommunicationHistory.MinimumWidth = 8
        Me.BtnDeleteCommunicationHistory.Name = "BtnDeleteCommunicationHistory"
        Me.BtnDeleteCommunicationHistory.Width = 150
        '
        'FrmCommunicationHistories
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.DgvCommunicationHistories)
        Me.Name = "FrmCommunicationHistories"
        Me.Text = "FrmCommunicationHistories"
        CType(Me.DgvCommunicationHistories, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnBack As Button
    Friend WithEvents DgvCommunicationHistories As DataGridView
    Friend WithEvents TxtID As DataGridViewTextBoxColumn
    Friend WithEvents TxtTitle As DataGridViewTextBoxColumn
    Friend WithEvents TxtDetail As DataGridViewTextBoxColumn
    Friend WithEvents BtnDeleteCommunicationHistory As DataGridViewButtonColumn
End Class
