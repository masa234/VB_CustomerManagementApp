﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmContracts
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
        Me.DgvContracts = New System.Windows.Forms.DataGridView()
        Me.TxtID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtTitle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtDetail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtContractStartDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtContractEndDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtContractMoney = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtNotification = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeleteContract = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.DgvContracts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnBack
        '
        Me.BtnBack.Location = New System.Drawing.Point(547, 355)
        Me.BtnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(179, 52)
        Me.BtnBack.TabIndex = 61
        Me.BtnBack.Text = "戻る"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'DgvContracts
        '
        Me.DgvContracts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvContracts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TxtID, Me.TxtTitle, Me.TxtDetail, Me.TxtContractStartDate, Me.TxtContractEndDate, Me.TxtContractMoney, Me.TxtNotification, Me.DeleteContract})
        Me.DgvContracts.Location = New System.Drawing.Point(75, 44)
        Me.DgvContracts.Name = "DgvContracts"
        Me.DgvContracts.RowHeadersWidth = 62
        Me.DgvContracts.RowTemplate.Height = 27
        Me.DgvContracts.Size = New System.Drawing.Size(651, 292)
        Me.DgvContracts.TabIndex = 60
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
        'TxtContractStartDate
        '
        Me.TxtContractStartDate.DataPropertyName = "ContractStartDate"
        Me.TxtContractStartDate.HeaderText = "契約開始日"
        Me.TxtContractStartDate.MinimumWidth = 8
        Me.TxtContractStartDate.Name = "TxtContractStartDate"
        Me.TxtContractStartDate.Width = 150
        '
        'TxtContractEndDate
        '
        Me.TxtContractEndDate.DataPropertyName = "ContractEndDate"
        Me.TxtContractEndDate.HeaderText = "契約終了日"
        Me.TxtContractEndDate.MinimumWidth = 8
        Me.TxtContractEndDate.Name = "TxtContractEndDate"
        Me.TxtContractEndDate.Width = 150
        '
        'TxtContractMoney
        '
        Me.TxtContractMoney.DataPropertyName = "ContractMoney"
        Me.TxtContractMoney.HeaderText = "契約金"
        Me.TxtContractMoney.MinimumWidth = 8
        Me.TxtContractMoney.Name = "TxtContractMoney"
        Me.TxtContractMoney.Width = 150
        '
        'TxtNotification
        '
        Me.TxtNotification.DataPropertyName = "Notification"
        Me.TxtNotification.HeaderText = "通知ON,OFF"
        Me.TxtNotification.MinimumWidth = 8
        Me.TxtNotification.Name = "TxtNotification"
        Me.TxtNotification.Width = 150
        '
        'DeleteContract
        '
        Me.DeleteContract.HeaderText = "削除"
        Me.DeleteContract.MinimumWidth = 8
        Me.DeleteContract.Name = "DeleteContract"
        Me.DeleteContract.Width = 150
        '
        'FrmContracts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.DgvContracts)
        Me.Name = "FrmContracts"
        Me.Text = "FrmContracts"
        CType(Me.DgvContracts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnBack As Button
    Friend WithEvents DgvContracts As DataGridView
    Friend WithEvents TxtID As DataGridViewTextBoxColumn
    Friend WithEvents TxtTitle As DataGridViewTextBoxColumn
    Friend WithEvents TxtDetail As DataGridViewTextBoxColumn
    Friend WithEvents TxtContractStartDate As DataGridViewTextBoxColumn
    Friend WithEvents TxtContractEndDate As DataGridViewTextBoxColumn
    Friend WithEvents TxtContractMoney As DataGridViewTextBoxColumn
    Friend WithEvents TxtNotification As DataGridViewTextBoxColumn
    Friend WithEvents DeleteContract As DataGridViewButtonColumn
End Class
