<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.BtnReleaseLock = New System.Windows.Forms.Button()
        Me.BtnInsertCustomer = New System.Windows.Forms.Button()
        Me.BtnCustomers = New System.Windows.Forms.Button()
        Me.InsertCommunicationHistory = New System.Windows.Forms.Button()
        Me.BtnCommunicationHistories = New System.Windows.Forms.Button()
        Me.BtnInsertContract = New System.Windows.Forms.Button()
        Me.BtnContracts = New System.Windows.Forms.Button()
        Me.BtnInsertOrder = New System.Windows.Forms.Button()
        Me.BtnOrders = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnLogout
        '
        Me.BtnLogout.Location = New System.Drawing.Point(788, 439)
        Me.BtnLogout.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(161, 66)
        Me.BtnLogout.TabIndex = 5
        Me.BtnLogout.Text = "ログアウト"
        Me.BtnLogout.UseVisualStyleBackColor = True
        '
        'BtnReleaseLock
        '
        Me.BtnReleaseLock.Location = New System.Drawing.Point(43, 35)
        Me.BtnReleaseLock.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnReleaseLock.Name = "BtnReleaseLock"
        Me.BtnReleaseLock.Size = New System.Drawing.Size(161, 66)
        Me.BtnReleaseLock.TabIndex = 6
        Me.BtnReleaseLock.Text = "アカウントロック解除"
        Me.BtnReleaseLock.UseVisualStyleBackColor = True
        '
        'BtnInsertCustomer
        '
        Me.BtnInsertCustomer.Location = New System.Drawing.Point(43, 145)
        Me.BtnInsertCustomer.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnInsertCustomer.Name = "BtnInsertCustomer"
        Me.BtnInsertCustomer.Size = New System.Drawing.Size(161, 66)
        Me.BtnInsertCustomer.TabIndex = 7
        Me.BtnInsertCustomer.Text = "顧客登録"
        Me.BtnInsertCustomer.UseVisualStyleBackColor = True
        '
        'BtnCustomers
        '
        Me.BtnCustomers.Location = New System.Drawing.Point(231, 145)
        Me.BtnCustomers.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCustomers.Name = "BtnCustomers"
        Me.BtnCustomers.Size = New System.Drawing.Size(161, 66)
        Me.BtnCustomers.TabIndex = 8
        Me.BtnCustomers.Text = "顧客一覧"
        Me.BtnCustomers.UseVisualStyleBackColor = True
        '
        'InsertCommunicationHistory
        '
        Me.InsertCommunicationHistory.Location = New System.Drawing.Point(43, 244)
        Me.InsertCommunicationHistory.Margin = New System.Windows.Forms.Padding(4)
        Me.InsertCommunicationHistory.Name = "InsertCommunicationHistory"
        Me.InsertCommunicationHistory.Size = New System.Drawing.Size(161, 66)
        Me.InsertCommunicationHistory.TabIndex = 9
        Me.InsertCommunicationHistory.Text = "コミュニケーション履歴登録"
        Me.InsertCommunicationHistory.UseVisualStyleBackColor = True
        '
        'BtnCommunicationHistories
        '
        Me.BtnCommunicationHistories.Location = New System.Drawing.Point(231, 244)
        Me.BtnCommunicationHistories.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCommunicationHistories.Name = "BtnCommunicationHistories"
        Me.BtnCommunicationHistories.Size = New System.Drawing.Size(161, 66)
        Me.BtnCommunicationHistories.TabIndex = 10
        Me.BtnCommunicationHistories.Text = "コミュニケーション履歴一覧"
        Me.BtnCommunicationHistories.UseVisualStyleBackColor = True
        '
        'BtnInsertContract
        '
        Me.BtnInsertContract.Location = New System.Drawing.Point(43, 340)
        Me.BtnInsertContract.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnInsertContract.Name = "BtnInsertContract"
        Me.BtnInsertContract.Size = New System.Drawing.Size(161, 66)
        Me.BtnInsertContract.TabIndex = 11
        Me.BtnInsertContract.Text = "契約情報登録"
        Me.BtnInsertContract.UseVisualStyleBackColor = True
        '
        'BtnContracts
        '
        Me.BtnContracts.Location = New System.Drawing.Point(231, 340)
        Me.BtnContracts.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnContracts.Name = "BtnContracts"
        Me.BtnContracts.Size = New System.Drawing.Size(161, 66)
        Me.BtnContracts.TabIndex = 12
        Me.BtnContracts.Text = "契約情報一覧"
        Me.BtnContracts.UseVisualStyleBackColor = True
        '
        'BtnInsertOrder
        '
        Me.BtnInsertOrder.Location = New System.Drawing.Point(43, 439)
        Me.BtnInsertOrder.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnInsertOrder.Name = "BtnInsertOrder"
        Me.BtnInsertOrder.Size = New System.Drawing.Size(161, 66)
        Me.BtnInsertOrder.TabIndex = 13
        Me.BtnInsertOrder.Text = "注文情報登録"
        Me.BtnInsertOrder.UseVisualStyleBackColor = True
        '
        'BtnOrders
        '
        Me.BtnOrders.Location = New System.Drawing.Point(231, 439)
        Me.BtnOrders.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnOrders.Name = "BtnOrders"
        Me.BtnOrders.Size = New System.Drawing.Size(161, 66)
        Me.BtnOrders.TabIndex = 14
        Me.BtnOrders.Text = "注文情報一覧"
        Me.BtnOrders.UseVisualStyleBackColor = True
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 540)
        Me.Controls.Add(Me.BtnOrders)
        Me.Controls.Add(Me.BtnInsertOrder)
        Me.Controls.Add(Me.BtnContracts)
        Me.Controls.Add(Me.BtnInsertContract)
        Me.Controls.Add(Me.BtnCommunicationHistories)
        Me.Controls.Add(Me.InsertCommunicationHistory)
        Me.Controls.Add(Me.BtnCustomers)
        Me.Controls.Add(Me.BtnInsertCustomer)
        Me.Controls.Add(Me.BtnReleaseLock)
        Me.Controls.Add(Me.BtnLogout)
        Me.Name = "FrmMain"
        Me.Text = "FrmMain"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnLogout As Button
    Friend WithEvents BtnReleaseLock As Button
    Friend WithEvents BtnInsertCustomer As Button
    Friend WithEvents BtnCustomers As Button
    Friend WithEvents InsertCommunicationHistory As Button
    Friend WithEvents BtnCommunicationHistories As Button
    Friend WithEvents BtnInsertContract As Button
    Friend WithEvents BtnContracts As Button
    Friend WithEvents BtnInsertOrder As Button
    Friend WithEvents BtnOrders As Button
End Class
