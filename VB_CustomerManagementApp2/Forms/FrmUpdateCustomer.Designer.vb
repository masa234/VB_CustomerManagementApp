<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUpdateCustomer
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
        Me.TxtRemarks = New System.Windows.Forms.TextBox()
        Me.LblRemarks = New System.Windows.Forms.Label()
        Me.TxtMailAddress = New System.Windows.Forms.TextBox()
        Me.LblMailAddress = New System.Windows.Forms.Label()
        Me.TxtDeptName = New System.Windows.Forms.TextBox()
        Me.LblDeptName = New System.Windows.Forms.Label()
        Me.TxtCompanyName = New System.Windows.Forms.TextBox()
        Me.LblCompanyName = New System.Windows.Forms.Label()
        Me.CmbGender = New System.Windows.Forms.ComboBox()
        Me.LblGender = New System.Windows.Forms.Label()
        Me.TxtAge = New System.Windows.Forms.TextBox()
        Me.LblAge = New System.Windows.Forms.Label()
        Me.TxtCustomerName = New System.Windows.Forms.TextBox()
        Me.LblCustomerName = New System.Windows.Forms.Label()
        Me.BtnUpdateCustomer = New System.Windows.Forms.Button()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtRemarks
        '
        Me.TxtRemarks.Location = New System.Drawing.Point(56, 698)
        Me.TxtRemarks.Multiline = True
        Me.TxtRemarks.Name = "TxtRemarks"
        Me.TxtRemarks.Size = New System.Drawing.Size(636, 184)
        Me.TxtRemarks.TabIndex = 90
        '
        'LblRemarks
        '
        Me.LblRemarks.AutoSize = True
        Me.LblRemarks.Location = New System.Drawing.Point(62, 661)
        Me.LblRemarks.Name = "LblRemarks"
        Me.LblRemarks.Size = New System.Drawing.Size(44, 18)
        Me.LblRemarks.TabIndex = 89
        Me.LblRemarks.Text = "備考"
        '
        'TxtMailAddress
        '
        Me.TxtMailAddress.Location = New System.Drawing.Point(56, 604)
        Me.TxtMailAddress.Name = "TxtMailAddress"
        Me.TxtMailAddress.Size = New System.Drawing.Size(636, 25)
        Me.TxtMailAddress.TabIndex = 88
        '
        'LblMailAddress
        '
        Me.LblMailAddress.AutoSize = True
        Me.LblMailAddress.Location = New System.Drawing.Point(62, 560)
        Me.LblMailAddress.Name = "LblMailAddress"
        Me.LblMailAddress.Size = New System.Drawing.Size(105, 18)
        Me.LblMailAddress.TabIndex = 87
        Me.LblMailAddress.Text = "メールアドレス"
        '
        'TxtDeptName
        '
        Me.TxtDeptName.Location = New System.Drawing.Point(56, 513)
        Me.TxtDeptName.Name = "TxtDeptName"
        Me.TxtDeptName.Size = New System.Drawing.Size(636, 25)
        Me.TxtDeptName.TabIndex = 86
        '
        'LblDeptName
        '
        Me.LblDeptName.AutoSize = True
        Me.LblDeptName.Location = New System.Drawing.Point(62, 465)
        Me.LblDeptName.Name = "LblDeptName"
        Me.LblDeptName.Size = New System.Drawing.Size(62, 18)
        Me.LblDeptName.TabIndex = 85
        Me.LblDeptName.Text = "部署名"
        '
        'TxtCompanyName
        '
        Me.TxtCompanyName.Location = New System.Drawing.Point(56, 411)
        Me.TxtCompanyName.Name = "TxtCompanyName"
        Me.TxtCompanyName.Size = New System.Drawing.Size(636, 25)
        Me.TxtCompanyName.TabIndex = 84
        '
        'LblCompanyName
        '
        Me.LblCompanyName.AutoSize = True
        Me.LblCompanyName.Location = New System.Drawing.Point(62, 363)
        Me.LblCompanyName.Name = "LblCompanyName"
        Me.LblCompanyName.Size = New System.Drawing.Size(62, 18)
        Me.LblCompanyName.TabIndex = 83
        Me.LblCompanyName.Text = "会社名"
        '
        'CmbGender
        '
        Me.CmbGender.FormattingEnabled = True
        Me.CmbGender.Location = New System.Drawing.Point(56, 294)
        Me.CmbGender.Name = "CmbGender"
        Me.CmbGender.Size = New System.Drawing.Size(121, 26)
        Me.CmbGender.TabIndex = 82
        '
        'LblGender
        '
        Me.LblGender.AutoSize = True
        Me.LblGender.Location = New System.Drawing.Point(62, 240)
        Me.LblGender.Name = "LblGender"
        Me.LblGender.Size = New System.Drawing.Size(44, 18)
        Me.LblGender.TabIndex = 81
        Me.LblGender.Text = "性別"
        '
        'TxtAge
        '
        Me.TxtAge.Location = New System.Drawing.Point(56, 176)
        Me.TxtAge.Name = "TxtAge"
        Me.TxtAge.Size = New System.Drawing.Size(636, 25)
        Me.TxtAge.TabIndex = 80
        '
        'LblAge
        '
        Me.LblAge.AutoSize = True
        Me.LblAge.Location = New System.Drawing.Point(62, 132)
        Me.LblAge.Name = "LblAge"
        Me.LblAge.Size = New System.Drawing.Size(44, 18)
        Me.LblAge.TabIndex = 79
        Me.LblAge.Text = "年齢"
        '
        'TxtCustomerName
        '
        Me.TxtCustomerName.Location = New System.Drawing.Point(56, 79)
        Me.TxtCustomerName.Name = "TxtCustomerName"
        Me.TxtCustomerName.Size = New System.Drawing.Size(636, 25)
        Me.TxtCustomerName.TabIndex = 78
        '
        'LblCustomerName
        '
        Me.LblCustomerName.AutoSize = True
        Me.LblCustomerName.Location = New System.Drawing.Point(62, 32)
        Me.LblCustomerName.Name = "LblCustomerName"
        Me.LblCustomerName.Size = New System.Drawing.Size(80, 18)
        Me.LblCustomerName.TabIndex = 77
        Me.LblCustomerName.Text = "顧客氏名"
        '
        'BtnUpdateCustomer
        '
        Me.BtnUpdateCustomer.Location = New System.Drawing.Point(513, 918)
        Me.BtnUpdateCustomer.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnUpdateCustomer.Name = "BtnUpdateCustomer"
        Me.BtnUpdateCustomer.Size = New System.Drawing.Size(179, 52)
        Me.BtnUpdateCustomer.TabIndex = 92
        Me.BtnUpdateCustomer.Text = "更新"
        Me.BtnUpdateCustomer.UseVisualStyleBackColor = True
        '
        'BtnBack
        '
        Me.BtnBack.Location = New System.Drawing.Point(299, 918)
        Me.BtnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(179, 52)
        Me.BtnBack.TabIndex = 91
        Me.BtnBack.Text = "戻る"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'FrmUpdateCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 1044)
        Me.Controls.Add(Me.BtnUpdateCustomer)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.TxtRemarks)
        Me.Controls.Add(Me.LblRemarks)
        Me.Controls.Add(Me.TxtMailAddress)
        Me.Controls.Add(Me.LblMailAddress)
        Me.Controls.Add(Me.TxtDeptName)
        Me.Controls.Add(Me.LblDeptName)
        Me.Controls.Add(Me.TxtCompanyName)
        Me.Controls.Add(Me.LblCompanyName)
        Me.Controls.Add(Me.CmbGender)
        Me.Controls.Add(Me.LblGender)
        Me.Controls.Add(Me.TxtAge)
        Me.Controls.Add(Me.LblAge)
        Me.Controls.Add(Me.TxtCustomerName)
        Me.Controls.Add(Me.LblCustomerName)
        Me.Name = "FrmUpdateCustomer"
        Me.Text = "FrmUpdateCustomer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtRemarks As TextBox
    Friend WithEvents LblRemarks As Label
    Friend WithEvents TxtMailAddress As TextBox
    Friend WithEvents LblMailAddress As Label
    Friend WithEvents TxtDeptName As TextBox
    Friend WithEvents LblDeptName As Label
    Friend WithEvents TxtCompanyName As TextBox
    Friend WithEvents LblCompanyName As Label
    Friend WithEvents CmbGender As ComboBox
    Friend WithEvents LblGender As Label
    Friend WithEvents TxtAge As TextBox
    Friend WithEvents LblAge As Label
    Friend WithEvents TxtCustomerName As TextBox
    Friend WithEvents LblCustomerName As Label
    Friend WithEvents BtnUpdateCustomer As Button
    Friend WithEvents BtnBack As Button
End Class
