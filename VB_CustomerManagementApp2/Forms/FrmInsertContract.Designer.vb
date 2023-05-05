<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInsertContract
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
        Me.TxtDetail = New System.Windows.Forms.TextBox()
        Me.LblDetail = New System.Windows.Forms.Label()
        Me.InsertContract = New System.Windows.Forms.Button()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CmbIsNotification
        '
        Me.CmbIsNotification.FormattingEnabled = True
        Me.CmbIsNotification.Location = New System.Drawing.Point(53, 812)
        Me.CmbIsNotification.Name = "CmbIsNotification"
        Me.CmbIsNotification.Size = New System.Drawing.Size(121, 26)
        Me.CmbIsNotification.TabIndex = 100
        '
        'LblIsNotification
        '
        Me.LblIsNotification.AutoSize = True
        Me.LblIsNotification.Location = New System.Drawing.Point(50, 770)
        Me.LblIsNotification.Name = "LblIsNotification"
        Me.LblIsNotification.Size = New System.Drawing.Size(106, 18)
        Me.LblIsNotification.TabIndex = 99
        Me.LblIsNotification.Text = "通知ON,OFF"
        '
        'TxtContractMoney
        '
        Me.TxtContractMoney.Location = New System.Drawing.Point(53, 716)
        Me.TxtContractMoney.Name = "TxtContractMoney"
        Me.TxtContractMoney.Size = New System.Drawing.Size(636, 25)
        Me.TxtContractMoney.TabIndex = 98
        '
        'LblContractMoney
        '
        Me.LblContractMoney.AutoSize = True
        Me.LblContractMoney.Location = New System.Drawing.Point(50, 676)
        Me.LblContractMoney.Name = "LblContractMoney"
        Me.LblContractMoney.Size = New System.Drawing.Size(62, 18)
        Me.LblContractMoney.TabIndex = 97
        Me.LblContractMoney.Text = "契約金"
        '
        'DateContractEndDate
        '
        Me.DateContractEndDate.Location = New System.Drawing.Point(53, 624)
        Me.DateContractEndDate.Name = "DateContractEndDate"
        Me.DateContractEndDate.Size = New System.Drawing.Size(200, 25)
        Me.DateContractEndDate.TabIndex = 96
        '
        'LblContractEndDate
        '
        Me.LblContractEndDate.AutoSize = True
        Me.LblContractEndDate.Location = New System.Drawing.Point(50, 580)
        Me.LblContractEndDate.Name = "LblContractEndDate"
        Me.LblContractEndDate.Size = New System.Drawing.Size(98, 18)
        Me.LblContractEndDate.TabIndex = 95
        Me.LblContractEndDate.Text = "契約終了日"
        '
        'DateContractStartDate
        '
        Me.DateContractStartDate.Location = New System.Drawing.Point(53, 534)
        Me.DateContractStartDate.Name = "DateContractStartDate"
        Me.DateContractStartDate.Size = New System.Drawing.Size(200, 25)
        Me.DateContractStartDate.TabIndex = 94
        '
        'LblContractStartDate
        '
        Me.LblContractStartDate.AutoSize = True
        Me.LblContractStartDate.Location = New System.Drawing.Point(50, 494)
        Me.LblContractStartDate.Name = "LblContractStartDate"
        Me.LblContractStartDate.Size = New System.Drawing.Size(98, 18)
        Me.LblContractStartDate.TabIndex = 93
        Me.LblContractStartDate.Text = "契約開始日"
        '
        'TxtTitle
        '
        Me.TxtTitle.Location = New System.Drawing.Point(53, 83)
        Me.TxtTitle.Name = "TxtTitle"
        Me.TxtTitle.Size = New System.Drawing.Size(636, 25)
        Me.TxtTitle.TabIndex = 92
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Location = New System.Drawing.Point(50, 32)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(61, 18)
        Me.LblTitle.TabIndex = 91
        Me.LblTitle.Text = "タイトル"
        '
        'TxtDetail
        '
        Me.TxtDetail.Location = New System.Drawing.Point(53, 170)
        Me.TxtDetail.Multiline = True
        Me.TxtDetail.Name = "TxtDetail"
        Me.TxtDetail.Size = New System.Drawing.Size(636, 299)
        Me.TxtDetail.TabIndex = 90
        '
        'LblDetail
        '
        Me.LblDetail.AutoSize = True
        Me.LblDetail.Location = New System.Drawing.Point(50, 129)
        Me.LblDetail.Name = "LblDetail"
        Me.LblDetail.Size = New System.Drawing.Size(44, 18)
        Me.LblDetail.TabIndex = 89
        Me.LblDetail.Text = "詳細"
        '
        'InsertContract
        '
        Me.InsertContract.Location = New System.Drawing.Point(510, 867)
        Me.InsertContract.Margin = New System.Windows.Forms.Padding(2)
        Me.InsertContract.Name = "InsertContract"
        Me.InsertContract.Size = New System.Drawing.Size(179, 52)
        Me.InsertContract.TabIndex = 102
        Me.InsertContract.Text = "登録"
        Me.InsertContract.UseVisualStyleBackColor = True
        '
        'BtnBack
        '
        Me.BtnBack.Location = New System.Drawing.Point(298, 867)
        Me.BtnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(179, 52)
        Me.BtnBack.TabIndex = 101
        Me.BtnBack.Text = "戻る"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'FrmInsertContract
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 1044)
        Me.Controls.Add(Me.InsertContract)
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
        Me.Controls.Add(Me.TxtDetail)
        Me.Controls.Add(Me.LblDetail)
        Me.Name = "FrmInsertContract"
        Me.Text = "FrmInsertContract"
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
    Friend WithEvents TxtDetail As TextBox
    Friend WithEvents LblDetail As Label
    Friend WithEvents InsertContract As Button
    Friend WithEvents BtnBack As Button
End Class
