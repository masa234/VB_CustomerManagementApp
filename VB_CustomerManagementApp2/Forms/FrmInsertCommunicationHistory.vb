Public Class FrmInsertCommunicationHistory

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

    Private Sub InsertCommunicationHistory_Click(sender As Object, e As EventArgs) Handles InsertCommunicationHistory.Click

        Try
            'タイトル
            Dim title As String = Me.TxtTitle.Text
            '詳細
            Dim detail As String = Me.TxtDetail.Text

            '文字数チェック(タイトル)
            If Not CommonProc.IsFitInText(title, Constant.TITLE_MAX_LENGTH) Then
                'メッセージボックス
                MessageBox.Show(String.Format(Constant.INVALID_LENGTH,
                                              Constant.ITEM_TITLE,
                                              Constant.TITLE_MAX_LENGTH),
                                Constant.CONFIRM,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
                Return
            End If

            '文字数チェック(詳細)
            If Not CommonProc.IsFitInText(detail, Constant.DETAIL_MAX_LENGTH) Then
                'メッセージボックス
                MessageBox.Show(String.Format(Constant.INVALID_LENGTH,
                                              Constant.ITEM_DETAIL,
                                              Constant.DETAIL_MAX_LENGTH),
                                Constant.CONFIRM,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
                Return
            End If

            '登録
            If Not CommunicationHistory.InsertCommunicationHistory(title, detail) Then
                'メッセージボックス
                MessageBox.Show(String.Format(Constant.FAILED,
                                              Constant.INSERT_COMMUNICATIONHISTORY),
                                Constant.CONFIRM,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
                Return
            End If

            '成功メッセージ
            MessageBox.Show(String.Format(Constant.SUCCESS,
                            Constant.INSERT_COMMUNICATIONHISTORY),
                            Constant.CONFIRM,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)

        Catch ex As Exception
            'メッセージボックス
            MessageBox.Show(ex.Message,
                        Constant.WARNING,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
        End Try

    End Sub
End Class