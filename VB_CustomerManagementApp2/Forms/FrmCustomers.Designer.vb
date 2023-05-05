<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCustomers
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
        Me.DgvCustomers = New System.Windows.Forms.DataGridView()
        Me.TxtID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtCustomerName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtAge = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtGender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtCompanyName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtDeptName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtMailAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtRemarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnDeleteCustomer = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.BtnUpdateCustomer = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.LbllCustomerName = New System.Windows.Forms.Label()
        Me.TxtSearchCustomerName = New System.Windows.Forms.TextBox()
        Me.BtnOutputCSV = New System.Windows.Forms.Button()
        Me.BtnSortAge = New System.Windows.Forms.Button()
        CType(Me.DgvCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvCustomers
        '
        Me.DgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCustomers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TxtID, Me.TxtCustomerName, Me.TxtAge, Me.TxtGender, Me.TxtCompanyName, Me.TxtDeptName, Me.TxtMailAddress, Me.TxtRemarks, Me.BtnDeleteCustomer, Me.BtnUpdateCustomer})
        Me.DgvCustomers.Location = New System.Drawing.Point(86, 169)
        Me.DgvCustomers.Name = "DgvCustomers"
        Me.DgvCustomers.RowHeadersWidth = 62
        Me.DgvCustomers.RowTemplate.Height = 27
        Me.DgvCustomers.Size = New System.Drawing.Size(768, 372)
        Me.DgvCustomers.TabIndex = 59
        '
        'TxtID
        '
        Me.TxtID.DataPropertyName = "ID"
        Me.TxtID.HeaderText = "ID"
        Me.TxtID.MinimumWidth = 8
        Me.TxtID.Name = "TxtID"
        Me.TxtID.Visible = False
        Me.TxtID.Width = 150
        '
        'TxtCustomerName
        '
        Me.TxtCustomerName.DataPropertyName = "CustomerName"
        Me.TxtCustomerName.HeaderText = "顧客氏名"
        Me.TxtCustomerName.MinimumWidth = 8
        Me.TxtCustomerName.Name = "TxtCustomerName"
        Me.TxtCustomerName.Width = 150
        '
        'TxtAge
        '
        Me.TxtAge.DataPropertyName = "Age"
        Me.TxtAge.HeaderText = "年齢"
        Me.TxtAge.MinimumWidth = 8
        Me.TxtAge.Name = "TxtAge"
        Me.TxtAge.Width = 150
        '
        'TxtGender
        '
        Me.TxtGender.DataPropertyName = "Gender"
        Me.TxtGender.HeaderText = "性別"
        Me.TxtGender.MinimumWidth = 8
        Me.TxtGender.Name = "TxtGender"
        Me.TxtGender.Width = 150
        '
        'TxtCompanyName
        '
        Me.TxtCompanyName.DataPropertyName = "CompanyName"
        Me.TxtCompanyName.HeaderText = "会社名"
        Me.TxtCompanyName.MinimumWidth = 8
        Me.TxtCompanyName.Name = "TxtCompanyName"
        Me.TxtCompanyName.Width = 150
        '
        'TxtDeptName
        '
        Me.TxtDeptName.DataPropertyName = "DeptName"
        Me.TxtDeptName.HeaderText = "部署名"
        Me.TxtDeptName.MinimumWidth = 8
        Me.TxtDeptName.Name = "TxtDeptName"
        Me.TxtDeptName.Width = 150
        '
        'TxtMailAddress
        '
        Me.TxtMailAddress.DataPropertyName = "MailAddress"
        Me.TxtMailAddress.HeaderText = "メールアドレス"
        Me.TxtMailAddress.MinimumWidth = 8
        Me.TxtMailAddress.Name = "TxtMailAddress"
        Me.TxtMailAddress.Width = 150
        '
        'TxtRemarks
        '
        Me.TxtRemarks.DataPropertyName = "Remarks"
        Me.TxtRemarks.HeaderText = "備考"
        Me.TxtRemarks.MinimumWidth = 8
        Me.TxtRemarks.Name = "TxtRemarks"
        Me.TxtRemarks.Width = 150
        '
        'BtnDeleteCustomer
        '
        Me.BtnDeleteCustomer.HeaderText = "削除"
        Me.BtnDeleteCustomer.MinimumWidth = 8
        Me.BtnDeleteCustomer.Name = "BtnDeleteCustomer"
        Me.BtnDeleteCustomer.Width = 150
        '
        'BtnUpdateCustomer
        '
        Me.BtnUpdateCustomer.HeaderText = "更新"
        Me.BtnUpdateCustomer.MinimumWidth = 8
        Me.BtnUpdateCustomer.Name = "BtnUpdateCustomer"
        Me.BtnUpdateCustomer.Width = 150
        '
        'BtnBack
        '
        Me.BtnBack.Location = New System.Drawing.Point(675, 572)
        Me.BtnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(179, 52)
        Me.BtnBack.TabIndex = 58
        Me.BtnBack.Text = "戻る"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'BtnSearch
        '
        Me.BtnSearch.Location = New System.Drawing.Point(676, 88)
        Me.BtnSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(181, 52)
        Me.BtnSearch.TabIndex = 67
        Me.BtnSearch.Text = "検索"
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'LbllCustomerName
        '
        Me.LbllCustomerName.AutoSize = True
        Me.LbllCustomerName.Location = New System.Drawing.Point(86, 21)
        Me.LbllCustomerName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LbllCustomerName.Name = "LbllCustomerName"
        Me.LbllCustomerName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LbllCustomerName.Size = New System.Drawing.Size(80, 18)
        Me.LbllCustomerName.TabIndex = 66
        Me.LbllCustomerName.Text = "顧客氏名"
        '
        'TxtSearchCustomerName
        '
        Me.TxtSearchCustomerName.Location = New System.Drawing.Point(85, 43)
        Me.TxtSearchCustomerName.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtSearchCustomerName.Name = "TxtSearchCustomerName"
        Me.TxtSearchCustomerName.Size = New System.Drawing.Size(769, 25)
        Me.TxtSearchCustomerName.TabIndex = 65
        '
        'BtnOutputCSV
        '
        Me.BtnOutputCSV.Location = New System.Drawing.Point(470, 572)
        Me.BtnOutputCSV.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnOutputCSV.Name = "BtnOutputCSV"
        Me.BtnOutputCSV.Size = New System.Drawing.Size(179, 52)
        Me.BtnOutputCSV.TabIndex = 68
        Me.BtnOutputCSV.Text = "CSV出力"
        Me.BtnOutputCSV.UseVisualStyleBackColor = True
        '
        'BtnSortAge
        '
        Me.BtnSortAge.Location = New System.Drawing.Point(470, 88)
        Me.BtnSortAge.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSortAge.Name = "BtnSortAge"
        Me.BtnSortAge.Size = New System.Drawing.Size(179, 52)
        Me.BtnSortAge.TabIndex = 69
        Me.BtnSortAge.Text = "年齢でソート"
        Me.BtnSortAge.UseVisualStyleBackColor = True
        '
        'FrmCustomers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 664)
        Me.Controls.Add(Me.BtnSortAge)
        Me.Controls.Add(Me.BtnOutputCSV)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.LbllCustomerName)
        Me.Controls.Add(Me.TxtSearchCustomerName)
        Me.Controls.Add(Me.DgvCustomers)
        Me.Controls.Add(Me.BtnBack)
        Me.Name = "FrmCustomers"
        Me.Text = "FrmCustomers"
        CType(Me.DgvCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DgvCustomers As DataGridView
    Friend WithEvents TxtID As DataGridViewTextBoxColumn
    Friend WithEvents TxtCustomerName As DataGridViewTextBoxColumn
    Friend WithEvents TxtAge As DataGridViewTextBoxColumn
    Friend WithEvents TxtGender As DataGridViewTextBoxColumn
    Friend WithEvents TxtCompanyName As DataGridViewTextBoxColumn
    Friend WithEvents TxtDeptName As DataGridViewTextBoxColumn
    Friend WithEvents TxtMailAddress As DataGridViewTextBoxColumn
    Friend WithEvents TxtRemarks As DataGridViewTextBoxColumn
    Friend WithEvents BtnDeleteCustomer As DataGridViewButtonColumn
    Friend WithEvents BtnUpdateCustomer As DataGridViewButtonColumn
    Friend WithEvents BtnBack As Button
    Friend WithEvents BtnSearch As Button
    Friend WithEvents LbllCustomerName As Label
    Friend WithEvents TxtSearchCustomerName As TextBox
    Friend WithEvents BtnOutputCSV As Button
    Friend WithEvents BtnSortAge As Button
End Class
