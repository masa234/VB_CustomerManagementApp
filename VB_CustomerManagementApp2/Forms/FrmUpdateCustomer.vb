Public Class FrmUpdateCustomer

    'ログインユーザID
    Private ReadOnly loginUserID As Long
    '更新対象顧客ID
    Private ReadOnly updateCustomerID As Long

    Public Sub New(ByVal loginUserID As Long,
                   ByVal updateCustomerID As Long)

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

        '設定
        'ログインユーザID
        Me.loginUserID = loginUserID
        '更新対象顧客ID
        Me.updateCustomerID = updateCustomerID

    End Sub

    Private Sub FrmUpdateCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    Private Sub BtnUpdateCustomer_Click(sender As Object, e As EventArgs) Handles BtnUpdateCustomer.Click

        Dim result As Integer

        Try
            '顧客氏名
            Dim customerName As String = Me.TxtCustomerName.Text
            '年齢
            Integer.TryParse(Me.TxtAge.Text, result)
            Dim age As Integer = result
            '性別
            Dim gender As String = Me.CmbGender.Text
            '会社名
            Dim companyName As String = Me.TxtCompanyName.Text
            '部署名
            Dim deptName As String = Me.TxtDeptName.Text
            'メールアドレス
            Dim mailAddress As String = Me.TxtMailAddress.Text
            '備考
            Dim remarks As String = Me.TxtRemarks.Text

            '文字数チェック(顧客氏名)
            If Not CommonProc.IsFitInText(customerName, Constant.CUSTOMERNAME_MAX_LENGTH) Then
                'メッセージボックス
                MessageBox.Show(String.Format(Constant.INVALID_LENGTH,
                                              Constant.ITEM_CUSTOMERNAME,
                                              Constant.CUSTOMERNAME_MAX_LENGTH),
                                Constant.CONFIRM,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
                Return
            End If

            '入力チェック(性別)
            If String.IsNullOrEmpty(gender) Then
                'メッセージボックス
                MessageBox.Show(String.Format(Constant.MUST_INPUT,
                                              Constant.ITEM_GENDER),
                                Constant.CONFIRM,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
                Return
            End If

            'コンボボックスの選択肢内かどうか?(性別)
            If Not CommonProc.IsTextInCmb(Me.CmbGender, gender) Then
                'メッセージボックス
                MessageBox.Show(String.Format(Constant.MUST_IN_CMB,
                                              Constant.ITEM_GENDER),
                                Constant.CONFIRM,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
                Return
            End If

            '文字数チェック(会社名)
            If Not CommonProc.IsFitInText(companyName, Constant.COMPANYNAME_MAX_LENGTH) Then
                'メッセージボックス
                MessageBox.Show(String.Format(Constant.INVALID_LENGTH,
                                              Constant.ITEM_COMPANYNAME,
                                              Constant.COMPANYNAME_MAX_LENGTH),
                                Constant.CONFIRM,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
                Return
            End If

            '文字数チェック(部署名)
            If Not CommonProc.IsFitInText(deptName, Constant.DEPTNAME_MAX_LENGTH) Then
                'メッセージボックス
                MessageBox.Show(String.Format(Constant.INVALID_LENGTH,
                                              Constant.ITEM_DEPTNAME,
                                              Constant.DEPTNAME_MAX_LENGTH),
                                Constant.CONFIRM,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
                Return
            End If

            '文字数チェック(メールアドレス)
            If Not CommonProc.IsFitInText(mailAddress, Constant.MAILADDRESS_MAX_LENGTH) Then
                'メッセージボックス
                MessageBox.Show(String.Format(Constant.INVALID_LENGTH,
                                              Constant.ITEM_MAILADDRESS,
                                              Constant.MAILADDRESS_MAX_LENGTH),
                                Constant.CONFIRM,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
                Return
            End If

            '文字数チェック(備考)
            If Not CommonProc.IsFitInText(remarks, Constant.REMARKS_MAX_LENGTH) Then
                'メッセージボックス
                MessageBox.Show(String.Format(Constant.INVALID_LENGTH,
                                              Constant.ITEM_REMARKS,
                                              Constant.REMARKS_MAX_LENGTH),
                                Constant.CONFIRM,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
                Return
            End If

            '更新
            If Not Customer.UpdateCustomer(customerName,
                                            age,
                                            gender,
                                            companyName,
                                            deptName,
                                            mailAddress,
                                            remarks,
                                            Me.updateCustomerID) Then
                'メッセージボックス
                MessageBox.Show(String.Format(Constant.FAILED,
                                              Constant.UPDATE_CUSTOMER),
                                Constant.CONFIRM,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
                Return
            End If

            '成功メッセージ
            MessageBox.Show(String.Format(Constant.SUCCESS,
                                          Constant.UPDATE_CUSTOMER),
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


    ''' <summary>
    ''' フォーム初期化
    ''' </summary>
    ''' 2023/05/03
    Private Sub InitForm()

        'コンボボックスの設定
        SetCmb()

        '顧客情報を画面に設定
        SetCustomer()

    End Sub


    ''' <summary>
    ''' コンボボックスの設定
    ''' </summary>
    ''' 2023/05/03
    Private Sub SetCmb()

        '性別のリストを取得
        Dim genderList As List(Of String) = OtherProc.GetGenderList()

        'コンボボックスに設定
        CommonProc.SetCmb(Me.CmbGender, genderList)

    End Sub


    ''' <summary>
    ''' 顧客情報を画面に設定
    ''' </summary>
    ''' 2023/05/03
    Private Sub SetCustomer()

        '顧客情報を取得
        Dim customerData As CustomerData = Customer.GetCustomer(Me.updateCustomerID)

        '画面に設定
        '顧客氏名
        Me.TxtCustomerName.Text = customerData.CustomerName
        '年齢
        Me.TxtAge.Text = customerData.Age
        '性別
        Me.CmbGender.Text = customerData.Gender
        '会社名
        Me.TxtCompanyName.Text = customerData.CompanyName
        '部署名
        Me.TxtDeptName.Text = customerData.DeptName
        'メールアドレス
        Me.TxtMailAddress.Text = customerData.MailAddress
        '備考
        Me.TxtRemarks.Text = customerData.Remarks

    End Sub
End Class