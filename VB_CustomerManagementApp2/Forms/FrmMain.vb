Public Class FrmMain

    'ログインユーザID
    Private ReadOnly loginUserID As Long

    Public Sub New(ByVal loginUserID As Long)

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

        'ログインユーザID
        Me.loginUserID = loginUserID

    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click

        Try
            'ログイン画面に遷移
            CommonProc.HideAndOpen(Me, FrmLogin)

        Catch ex As Exception
            'メッセージボックス
            MessageBox.Show(ex.Message,
                        Constant.WARNING,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub BtnReleaseLock_Click(sender As Object, e As EventArgs) Handles BtnReleaseLock.Click

        Try
            'アカウントロック解除画面に遷移
            CommonProc.HideAndOpen(Me, New FrmReleaseLock(Me.loginUserID))

        Catch ex As Exception
            'メッセージボックス
            MessageBox.Show(ex.Message,
                        Constant.WARNING,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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


    Private Sub BtnInsertCustomer_Click(sender As Object, e As EventArgs) Handles BtnInsertCustomer.Click

        Try
            '顧客登録画面に遷移
            CommonProc.HideAndOpen(Me, New FrmInsertCustomer(Me.loginUserID))

        Catch ex As Exception
            'メッセージボックス
            MessageBox.Show(ex.Message,
                        Constant.WARNING,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub BtnCustomers_Click(sender As Object, e As EventArgs) Handles BtnCustomers.Click

        Try
            '顧客一覧画面に遷移
            CommonProc.HideAndOpen(Me, New FrmCustomers(Me.loginUserID))

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
            'コミュニケーション履歴登録画面に遷移
            CommonProc.HideAndOpen(Me, New FrmInsertCommunicationHistory(Me.loginUserID))

        Catch ex As Exception
            'メッセージボックス
            MessageBox.Show(ex.Message,
                        Constant.WARNING,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub BtnCommunicationHistories_Click(sender As Object, e As EventArgs) Handles BtnCommunicationHistories.Click

        Try
            'コミュニケーション履歴一覧画面に遷移
            CommonProc.HideAndOpen(Me, New FrmCommunicationHistories(Me.loginUserID))

        Catch ex As Exception
            'メッセージボックス
            MessageBox.Show(ex.Message,
                        Constant.WARNING,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub BtnInsertContract_Click(sender As Object, e As EventArgs) Handles BtnInsertContract.Click

        Try
            '契約情報登録画面に遷移
            CommonProc.HideAndOpen(Me, New FrmInsertContract(Me.loginUserID))

        Catch ex As Exception
            'メッセージボックス
            MessageBox.Show(ex.Message,
                        Constant.WARNING,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub BtnContracts_Click(sender As Object, e As EventArgs) Handles BtnContracts.Click

        Try
            '契約情報一覧画面に遷移
            CommonProc.HideAndOpen(Me, New FrmContracts(Me.loginUserID))

        Catch ex As Exception
            'メッセージボックス
            MessageBox.Show(ex.Message,
                        Constant.WARNING,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub BtnInsertOrder_Click(sender As Object, e As EventArgs) Handles BtnInsertOrder.Click

        Try
            '注文情報登録画面に遷移
            CommonProc.HideAndOpen(Me, New FrmInsertOrder(Me.loginUserID))

        Catch ex As Exception
            'メッセージボックス
            MessageBox.Show(ex.Message,
                        Constant.WARNING,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub BtnOrders_Click(sender As Object, e As EventArgs) Handles BtnOrders.Click

        Try
            '注文情報一覧画面に遷移
            CommonProc.HideAndOpen(Me, New FrmOrders(Me.loginUserID))

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
    ''' 2023/05/02
    Private Sub InitForm()

        'ボタンの表示非表示を設定
        SetBtnVisible()

    End Sub


    ''' <summary>
    ''' ボタンの表示非表示を設定
    ''' </summary>
    ''' 2023/05/02
    Private Sub SetBtnVisible()

        '管理者でない場合
        If Not User.IsAdmin(Me.loginUserID) Then
            'ボタンを非表示にする
            'アカウントロック解除ボタン
            Me.BtnReleaseLock.Visible = False
        End If

    End Sub
End Class