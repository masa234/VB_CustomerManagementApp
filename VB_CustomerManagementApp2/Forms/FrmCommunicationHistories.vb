Public Class FrmCommunicationHistories

    'ログインユーザID
    Private ReadOnly loginUserID As Long

    Public Sub New(ByVal loginUserID As Long)

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

        'ログインユーザID設定
        Me.loginUserID = loginUserID

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

    Private Sub DgvCommunicationHistories_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvCommunicationHistories.CellContentClick

        Dim communicationHistoriesID As Long

        Try
            'コミュニケーション履歴ID
            Long.TryParse(DgvCommunicationHistories.Rows(e.RowIndex).Cells(1).Value.ToString(), communicationHistoriesID)

            '削除ボタンが押されている場合
            If DgvCommunicationHistories.Columns(e.ColumnIndex).Name = "BtnDeleteCommunicationHistory" Then
                '削除
                If Not CommunicationHistory.DeleteCommunicationHistory(communicationHistoriesID) Then
                    'メッセージボックス
                    MessageBox.Show(String.Format(Constant.FAILED,
                                                  Constant.DELETE_COMMUNICATIONHISTORY),
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

    Private Sub FrmCommunicationHistories_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
    ''' 2023/05/03
    Private Sub InitForm()

        'データソースの設定
        SetDataSource()

    End Sub


    ''' <summary>
    ''' データソースの設定
    ''' </summary>
    ''' 2023/05/03
    Private Sub SetDataSource()

        'データソースの設定
        Me.DgvCommunicationHistories.DataSource = CommunicationHistory.GetCommunicationHistories()

    End Sub
End Class