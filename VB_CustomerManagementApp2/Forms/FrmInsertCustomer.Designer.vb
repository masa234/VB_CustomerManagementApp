<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInsertCustomer
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
        Me.BtnInsertCustomer = New System.Windows.Forms.Button()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.TxtCompanyName = New System.Windows.Forms.TextBox()
        Me.LblCompanyName = New System.Windows.Forms.Label()
        Me.CmbGender = New System.Windows.Forms.ComboBox()
        Me.LblGender = New System.Windows.Forms.Label()
        Me.TxtAge = New System.Windows.Forms.TextBox()
        Me.LblAge = New System.Windows.Forms.Label()
        Me.TxtCustomerName = New System.Windows.Forms.TextBox()
        Me.LblCustomerName = New System.Windows.Forms.Label()
        Me.TxtRemarks = New System.Windows.Forms.TextBox()
        Me.LblRemarks = New System.Windows.Forms.Label()
        Me.TxtMailAddress = New System.Windows.Forms.TextBox()
        Me.LblMailAddress = New System.Windows.Forms.Label()
        Me.TxtDeptName = New System.Windows.Forms.TextBox()
        Me.LblDeptName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnInsertCustomer
        '
        Me.BtnInsertCustomer.Location = New System.Drawing.Point(507, 928)
        Me.BtnInsertCustomer.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnInsertCustomer.Name = "BtnInsertCustomer"
        Me.BtnInsertCustomer.Size = New System.Drawing.Size(179, 52)
        Me.BtnInsertCustomer.TabIndex = 72
        Me.BtnInsertCustomer.Text = "登録"
        Me.BtnInsertCustomer.UseVisualStyleBackColor = True
        '
        'BtnBack
        '
        Me.BtnBack.Location = New System.Drawing.Point(283, 928)
        Me.BtnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(179, 52)
        Me.BtnBack.TabIndex = 71
        Me.BtnBack.Text = "戻る"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'TxtCompanyName
        '
        Me.TxtCompanyName.Location = New System.Drawing.Point(67, 421)
        Me.TxtCompanyName.Name = "TxtCompanyName"
        Me.TxtCompanyName.Size = New System.Drawing.Size(636, 25)
        Me.TxtCompanyName.TabIndex = 80
        '
        'LblCompanyName
        '
        Me.LblCompanyName.AutoSize = True
        Me.LblCompanyName.Location = New System.Drawing.Point(73, 373)
        Me.LblCompanyName.Name = "LblCompanyName"
        Me.LblCompanyName.Size = New System.Drawing.Size(62, 18)
        Me.LblCompanyName.TabIndex = 79
        Me.LblCompanyName.Text = "会社名"
        '
        'CmbGender
        '
        Me.CmbGender.FormattingEnabled = True
        Me.CmbGender.Location = New System.Drawing.Point(67, 304)
        Me.CmbGender.Name = "CmbGender"
        Me.CmbGender.Size = New System.Drawing.Size(121, 26)
        Me.CmbGender.TabIndex = 78
        '
        'LblGender
        '
        Me.LblGender.AutoSize = True
        Me.LblGender.Location = New System.Drawing.Point(73, 251)
        Me.LblGender.Name = "LblGender"
        Me.LblGender.Size = New System.Drawing.Size(44, 18)
        Me.LblGender.TabIndex = 77
        Me.LblGender.Text = "性別"
        '
        'TxtAge
        '
        Me.TxtAge.Location = New System.Drawing.Point(67, 186)
        Me.TxtAge.Name = "TxtAge"
        Me.TxtAge.Size = New System.Drawing.Size(636, 25)
        Me.TxtAge.TabIndex = 76
        '
        'LblAge
        '
        Me.LblAge.AutoSize = True
        Me.LblAge.Location = New System.Drawing.Point(73, 142)
        Me.LblAge.Name = "LblAge"
        Me.LblAge.Size = New System.Drawing.Size(44, 18)
        Me.LblAge.TabIndex = 75
        Me.LblAge.Text = "年齢"
        '
        'TxtCustomerName
        '
        Me.TxtCustomerName.Location = New System.Drawing.Point(67, 89)
        Me.TxtCustomerName.Name = "TxtCustomerName"
        Me.TxtCustomerName.Size = New System.Drawing.Size(636, 25)
        Me.TxtCustomerName.TabIndex = 74
        '
        'LblCustomerName
        '
        Me.LblCustomerName.AutoSize = True
        Me.LblCustomerName.Location = New System.Drawing.Point(64, 47)
        Me.LblCustomerName.Name = "LblCustomerName"
        Me.LblCustomerName.Size = New System.Drawing.Size(80, 18)
        Me.LblCustomerName.TabIndex = 73
        Me.LblCustomerName.Text = "顧客氏名"
        '
        'TxtRemarks
        '
        Me.TxtRemarks.Location = New System.Drawing.Point(67, 717)
        Me.TxtRemarks.Multiline = True
        Me.TxtRemarks.Name = "TxtRemarks"
        Me.TxtRemarks.Size = New System.Drawing.Size(636, 184)
        Me.TxtRemarks.TabIndex = 86
        '
        'LblRemarks
        '
        Me.LblRemarks.AutoSize = True
        Me.LblRemarks.Location = New System.Drawing.Point(73, 671)
        Me.LblRemarks.Name = "LblRemarks"
        Me.LblRemarks.Size = New System.Drawing.Size(44, 18)
        Me.LblRemarks.TabIndex = 85
        Me.LblRemarks.Text = "備考"
        '
        'TxtMailAddress
        '
        Me.TxtMailAddress.Location = New System.Drawing.Point(67, 614)
        Me.TxtMailAddress.Name = "TxtMailAddress"
        Me.TxtMailAddress.Size = New System.Drawing.Size(636, 25)
        Me.TxtMailAddress.TabIndex = 84
        '
        'LblMailAddress
        '
        Me.LblMailAddress.AutoSize = True
        Me.LblMailAddress.Location = New System.Drawing.Point(73, 570)
        Me.LblMailAddress.Name = "LblMailAddress"
        Me.LblMailAddress.Size = New System.Drawing.Size(105, 18)
        Me.LblMailAddress.TabIndex = 83
        Me.LblMailAddress.Text = "メールアドレス"
        '
        'TxtDeptName
        '
        Me.TxtDeptName.Location = New System.Drawing.Point(67, 519)
        Me.TxtDeptName.Name = "TxtDeptName"
        Me.TxtDeptName.Size = New System.Drawing.Size(636, 25)
        Me.TxtDeptName.TabIndex = 82
        '
        'LblDeptName
        '
        Me.LblDeptName.AutoSize = True
        Me.LblDeptName.Location = New System.Drawing.Point(73, 475)
        Me.LblDeptName.Name = "LblDeptName"
        Me.LblDeptName.Size = New System.Drawing.Size(62, 18)
        Me.LblDeptName.TabIndex = 81
        Me.LblDeptName.Text = "部署名"
        '
        'FrmInsertCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 1044)
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
        Me.Controls.Add(Me.BtnInsertCustomer)
        Me.Controls.Add(Me.BtnBack)
        Me.Name = "FrmInsertCustomer"
        Me.Text = "FrmInsertCustomer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnInsertCustomer As Button
    Friend WithEvents BtnBack As Button
    Friend WithEvents TxtCompanyName As TextBox
    Friend WithEvents LblCompanyName As Label
    Friend WithEvents CmbGender As ComboBox
    Friend WithEvents LblGender As Label
    Friend WithEvents TxtAge As TextBox
    Friend WithEvents LblAge As Label
    Friend WithEvents TxtCustomerName As TextBox
    Friend WithEvents LblCustomerName As Label
    Friend WithEvents TxtRemarks As TextBox
    Friend WithEvents LblRemarks As Label
    Friend WithEvents TxtMailAddress As TextBox
    Friend WithEvents LblMailAddress As Label
    Friend WithEvents TxtDeptName As TextBox
    Friend WithEvents LblDeptName As Label
End Class
