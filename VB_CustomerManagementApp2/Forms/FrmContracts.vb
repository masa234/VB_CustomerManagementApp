Public Class FrmContracts

    'ログインユーザID
    Private ReadOnly loginUserID As Long

    Public Sub New(ByVal loginUserID As Long)

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

        'ログインユーザID設定
        Me.loginUserID = loginUserID

    End Sub

    Private Sub DgvContracts_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvContracts.CellContentClick

        Dim contractID As Long

        Try
            '契約ID
            Long.TryParse(DgvContracts.Rows(e.RowIndex).Cells(1).Value.ToString(), contractID)

            '削除ボタンが押されている場合
            If DgvContracts.Columns(e.ColumnIndex).Name = "DeleteContract" Then
                '削除
                If Not Contract.DeleteContract(contractID) Then
                    'メッセージボックス
                    MessageBox.Show(String.Format(Constant.FAILED,
                                                  Constant.DELETE_CUSTOMER),
                                Constant.CONFIRM,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
                    Return
                End If

                'データソースの再設定
                SetDataSource()
            End If

        Catch ex As Exception
            'メッセージボックス
            MessageBox.Show(ex.Message,
                        Constant.WARNING,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click

        Try
            'メイン画面に遷移
            CommonProc.HideAndOpen(Me, New FrmMain(Me.loginUserID))

        Catch ex As Exception
            'メッセージボックス
            MessageBox.Show(ex.Message,
                        Constant.WARNING,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub FrmContracts_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            'フォーム初期化
            InitForm()

        Catch ex As Exception
            'メッセージボックス
            MessageBox.Show(ex.Message,
                        Constant.WARNING,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
        End Try

    End Sub


    ''' <summary>
    ''' フォーム初期化
    ''' </summary>
    ''' 2023/05/04
    Private Sub InitForm()

        'データソースの設定
        SetDataSource()

    End Sub


    ''' <summary>
    ''' データソースの設定
    ''' </summary>
    ''' 2023/05/04
    Private Sub SetDataSource()

        'データソースの設定
        Me.DgvContracts.DataSource = Contract.GetAllContractList()

    End Sub
End Class