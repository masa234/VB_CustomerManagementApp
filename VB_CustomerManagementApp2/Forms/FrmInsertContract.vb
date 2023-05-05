Public Class FrmInsertContract

    'ログインユーザID
    Private ReadOnly loginUserID As Long

    Public Sub New(ByVal loginUserID As Long)

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

        'ログインユーザID設定
        Me.loginUserID = loginUserID

    End Sub

    Private Sub FrmInsertContract_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    Private Sub InsertContract_Click(sender As Object, e As EventArgs) Handles InsertContract.Click

        Dim result As Integer

        Try
            'タイトル
            Dim title As String = Me.TxtTitle.Text
            '詳細
            Dim detail As String = Me.TxtDetail.Text
            '契約開始日
            Dim contractStartDate As Date = Me.DateContractStartDate.Value
            '契約終了日
            Dim contractEndDate As Date = Me.DateContractEndDate.Value
            '契約金
            Integer.TryParse(Me.TxtContractMoney.Text, result)
            Dim contractMoney As Integer = result
            '通知ON,OFF
            Dim notification As String = Me.CmbIsNotification.Text

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

            '入力チェック(契約開始日)
            If String.IsNullOrEmpty(contractStartDate) Then
                'メッセージボックス
                MessageBox.Show(String.Format(Constant.MUST_INPUT,
                                              Constant.ITEM_CONTRACT_STARTDATE),
                                Constant.CONFIRM,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
                Return
            End If

            '入力チェック(契約終了日)
            If String.IsNullOrEmpty(contractEndDate) Then
                'メッセージボックス
                MessageBox.Show(String.Format(Constant.MUST_INPUT,
                                              Constant.ITEM_CONTRACT_ENDDATE),
                                Constant.CONFIRM,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
                Return
            End If

            '入力チェック(通知ON、OFF)
            If String.IsNullOrEmpty(notification) Then
                'メッセージボックス
                MessageBox.Show(String.Format(Constant.MUST_INPUT,
                                              Constant.ITEM_NOTIFICATION),
                                Constant.CONFIRM,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
                Return
            End If

            'コンボボックスの選択肢内かどうか?(通知ON、OFF)
            If Not CommonProc.IsTextInCmb(Me.CmbIsNotification, notification) Then
                'メッセージボックス
                MessageBox.Show(String.Format(Constant.MUST_IN_CMB,
                                              Constant.ITEM_NOTIFICATION),
                                Constant.CONFIRM,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
                Return
            End If

            '登録
            If Not Contract.InsertContract(title,
                                        detail,
                                        contractStartDate,
                                        contractEndDate,
                                        contractMoney,
                                        notification) Then
                'メッセージボックス
                MessageBox.Show(String.Format(Constant.FAILED,
                                              Constant.INSERT_CONTRACT),
                                Constant.CONFIRM,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
                Return
            End If

            '成功メッセージ
            MessageBox.Show(String.Format(Constant.SUCCESS,
                                          Constant.INSERT_CONTRACT),
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


    ''' <summary>
    ''' フォーム初期化
    ''' </summary>
    ''' 2023/05/04
    Private Sub InitForm()

        'コンボボックスの設定
        SetCmb()

        '契約開始日
        Me.DateContractStartDate.Value = DateTime.Today

        '契約終了日
        Me.DateContractEndDate.Value = DateTime.Today

    End Sub


    ''' <summary>
    ''' コンボボックスの設定
    ''' </summary>
    ''' 2023/05/04
    Private Sub SetCmb()

        '通知ON、OFFのリストを取得
        Dim notificationList As List(Of String) = OtherProc.GetNotificationList()

        'コンボボックスに設定
        CommonProc.SetCmb(Me.CmbIsNotification, notificationList)

    End Sub
End Class