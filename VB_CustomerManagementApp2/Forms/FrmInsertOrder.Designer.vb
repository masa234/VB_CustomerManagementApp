<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInsertOrder
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
        Me.CmbIsNotification = New System.Windows.Forms.ComboBox()
        Me.LblIsNotification = New System.Windows.Forms.Label()
        Me.TxtContractMoney = New System.Windows.Forms.TextBox()
        Me.LblContractMoney = New System.Windows.Forms.Label()
        Me.DateContractEndDate = New System.Windows.Forms.DateTimePicker()
        Me.LblContractEndDate = New System.Windows.Forms.Label()
        Me.DateContractStartDate = New System.Windows.Forms.DateTimePicker()
        Me.LblContractStartDate = New System.Windows.Forms.Label()
        Me.TxtTitle = New System.Windows.Forms.TextBox()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.LblDetail = New System.Windows.Forms.Label()
        Me.TxtDetail = New System.Windows.Forms.TextBox()
        Me.InsertOrder = New System.Windows.Forms.Button()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CmbIsNotification
        '
        Me.CmbIsNotification.FormattingEnabled = True
        Me.CmbIsNotification.Location = New System.Drawing.Point(34, 807)
        Me.CmbIsNotification.Name = "CmbIsNotification"
        Me.CmbIsNotification.Size = New System.Drawing.Size(121, 26)
        Me.CmbIsNotification.TabIndex = 112
        '
        'LblIsNotification
        '
        Me.LblIsNotification.AutoSize = True
        Me.LblIsNotification.Location = New System.Drawing.Point(31, 765)
        Me.LblIsNotification.Name = "LblIsNotification"
        Me.LblIsNotification.Size = New System.Drawing.Size(106, 18)
        Me.LblIsNotification.TabIndex = 111
        Me.LblIsNotification.Text = "通知ON,OFF"
        '
        'TxtContractMoney
        '
        Me.TxtContractMoney.Location = New System.Drawing.Point(34, 711)
        Me.TxtContractMoney.Name = "TxtContractMoney"
        Me.TxtContractMoney.Size = New System.Drawing.Size(636, 25)
        Me.TxtContractMoney.TabIndex = 110
        '
        'LblContractMoney
        '
        Me.LblContractMoney.AutoSize = True
        Me.LblContractMoney.Location = New System.Drawing.Point(31, 671)
        Me.LblContractMoney.Name = "LblContractMoney"
        Me.LblContractMoney.Size = New System.Drawing.Size(62, 18)
        Me.LblContractMoney.TabIndex = 109
        Me.LblContractMoney.Text = "契約金"
        '
        'DateContractEndDate
        '
        Me.DateContractEndDate.Location = New System.Drawing.Point(34, 619)
        Me.DateContractEndDate.Name = "DateContractEndDate"
        Me.DateContractEndDate.Size = New System.Drawing.Size(200, 25)
        Me.DateContractEndDate.TabIndex = 108
        '
        'LblContractEndDate
        '
        Me.LblContractEndDate.AutoSize = True
        Me.LblContractEndDate.Location = New System.Drawing.Point(31, 575)
        Me.LblContractEndDate.Name = "LblContractEndDate"
        Me.LblContractEndDate.Size = New System.Drawing.Size(98, 18)
        Me.LblContractEndDate.TabIndex = 107
        Me.LblContractEndDate.Text = "契約終了日"
        '
        'DateContractStartDate
        '
        Me.DateContractStartDate.Location = New System.Drawing.Point(34, 529)
        Me.DateContractStartDate.Name = "DateContractStartDate"
        Me.DateContractStartDate.Size = New System.Drawing.Size(200, 25)
        Me.DateContractStartDate.TabIndex = 106
        '
        'LblContractStartDate
        '
        Me.LblContractStartDate.AutoSize = True
        Me.LblContractStartDate.Location = New System.Drawing.Point(31, 489)
        Me.LblContractStartDate.Name = "LblContractStartDate"
        Me.LblContractStartDate.Size = New System.Drawing.Size(98, 18)
        Me.LblContractStartDate.TabIndex = 105
        Me.LblContractStartDate.Text = "契約開始日"
        '
        'TxtTitle
        '
        Me.TxtTitle.Location = New System.Drawing.Point(34, 78)
        Me.TxtTitle.Name = "TxtTitle"
        Me.TxtTitle.Size = New System.Drawing.Size(636, 25)
        Me.TxtTitle.TabIndex = 104
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Location = New System.Drawing.Point(31, 27)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(61, 18)
        Me.LblTitle.TabIndex = 103
        Me.LblTitle.Text = "タイトル"
        '
        'LblDetail
        '
        Me.LblDetail.AutoSize = True
        Me.LblDetail.Location = New System.Drawing.Point(31, 129)
        Me.LblDetail.Name = "LblDetail"
        Me.LblDetail.Size = New System.Drawing.Size(44, 18)
        Me.LblDetail.TabIndex = 101
        Me.LblDetail.Text = "詳細"
        '
        'TxtDetail
        '
        Me.TxtDetail.Location = New System.Drawing.Point(34, 167)
        Me.TxtDetail.Multiline = True
        Me.TxtDetail.Name = "TxtDetail"
        Me.TxtDetail.Size = New System.Drawing.Size(636, 299)
        Me.TxtDetail.TabIndex = 102
        '
        'InsertOrder
        '
        Me.InsertOrder.Location = New System.Drawing.Point(491, 871)
        Me.InsertOrder.Margin = New System.Windows.Forms.Padding(2)
        Me.InsertOrder.Name = "InsertOrder"
        Me.InsertOrder.Size = New System.Drawing.Size(179, 52)
        Me.InsertOrder.TabIndex = 114
        Me.InsertOrder.Text = "登録"
        Me.InsertOrder.UseVisualStyleBackColor = True
        '
        'BtnBack
        '
        Me.BtnBack.Location = New System.Drawing.Point(275, 871)
        Me.BtnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(179, 52)
        Me.BtnBack.TabIndex = 113
        Me.BtnBack.Text = "戻る"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'FrmInsertOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 1044)
        Me.Controls.Add(Me.InsertOrder)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.CmbIsNotification)
        Me.Controls.Add(Me.LblIsNotification)
        Me.Controls.Add(Me.TxtContractMoney)
        Me.Controls.Add(Me.LblContractMoney)
        Me.Controls.Add(Me.DateContractEndDate)
        Me.Controls.Add(Me.LblContractEndDate)
        Me.Controls.Add(Me.DateContractStartDate)
        Me.Controls.Add(Me.LblContractStartDate)
        Me.Controls.Add(Me.TxtTitle)
        Me.Controls.Add(Me.LblTitle)
        Me.Controls.Add(Me.LblDetail)
        Me.Controls.Add(Me.TxtDetail)
        Me.Name = "FrmInsertOrder"
        Me.Text = "FrmInsertOrder"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CmbIsNotification As ComboBox
    Friend WithEvents LblIsNotification As Label
    Friend WithEvents TxtContractMoney As TextBox
    Friend WithEvents LblContractMoney As Label
    Friend WithEvents DateContractEndDate As DateTimePicker
    Friend WithEvents LblContractEndDate As Label
    Friend WithEvents DateContractStartDate As DateTimePicker
    Friend WithEvents LblContractStartDate As Label
    Friend WithEvents TxtTitle As TextBox
    Friend WithEvents LblTitle As Label
    Friend WithEvents LblDetail As Label
    Friend WithEvents TxtDetail As TextBox
    Friend WithEvents InsertOrder As Button
    Friend WithEvents BtnBack As Button
End Class
