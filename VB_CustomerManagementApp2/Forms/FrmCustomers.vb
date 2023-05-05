Public Class FrmCustomers

    'ログインユーザID設定
    Private ReadOnly loginUserID As Long

    Public Sub New(ByVal loginUserID As Long)

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

        'ログインユーザID設定
        Me.loginUserID = loginUserID

    End Sub

    Private Sub DgvCustomers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvCustomers.CellContentClick

        Dim customerID As Long

        Try
            '顧客ID
            Long.TryParse(DgvCustomers.Rows(e.RowIndex).Cells(2).Value.ToString(), customerID)

            '削除ボタンが押されている場合
            If DgvCustomers.Columns(e.ColumnIndex).Name = "BtnDeleteCustomer" Then
                '削除
                If Not Customer.DeleteCustomer(customerID) Then
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

            '更新ボタンが押されている場合
            If DgvCustomers.Columns(e.ColumnIndex).Name = "BtnUpdateCustomer" Then
                '顧客更新画面に遷移
                CommonProc.HideAndOpen(Me, New FrmUpdateCustomer(Me.loginUserID, customerID))
            End If

        Catch ex As Exception
            'メッセージボックス
            MessageBox.Show(ex.Message,
                        Constant.WARNING,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub FrmCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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


    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click

        Try
            '顧客氏名
            Dim searchCustomerName As String = Me.TxtSearchCustomerName.Text

            '検索結果(件数)を取得
            Dim customerCount As Long = Customer.GetSearchCount(searchCustomerName)

            '画面に設定
            Me.LbllCustomerName.Text = customerCount.ToString() + "件"

            '検索用データソースの設定
            SetSearchDataSource(searchCustomerName)

        Catch ex As Exception
            'メッセージボックス
            MessageBox.Show(ex.Message,
                        Constant.WARNING,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub BtnOutputCSV_Click(sender As Object, e As EventArgs) Handles BtnOutputCSV.Click

        Try
            '顧客リストを取得
            Dim customerList As List(Of CustomerData) = Customer.GetAllCustomersList()

            'CSV出力
            If Not Customer.OutputCSV(customerList, Constant.OUTPUT_CSV_PATH) Then
                'メッセージボックス
                MessageBox.Show(String.Format(Constant.FAILED,
                                              Constant.OUTPUT_CSV),
                            Constant.CONFIRM,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
                Return
            End If

            '成功メッセージ
            MessageBox.Show(String.Format(Constant.SUCCESS,
                                          Constant.OUTPUT_CSV),
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



    Private Sub BtnSortAge_Click(sender As Object, e As EventArgs) Handles BtnSortAge.Click

        Try
            'ソート済みデータソースの設定
            SetSortedDataSource()

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
        Me.DgvCustomers.DataSource = Customer.GetAllCustomersList()

    End Sub


    ''' <summary>
    ''' 検索用データソースの設定
    ''' </summary>
    ''' 2023/05/04
    Private Sub SetSearchDataSource(ByVal searchCustomerName As String)

        'データソースの設定
        Me.DgvCustomers.DataSource = Customer.FilterCustomerList(searchCustomerName)

    End Sub


    ''' <summary>
    ''' ソート済みデータソースの設定
    ''' </summary>
    ''' 2023/05/05
    Private Sub SetSortedDataSource()

        'データソースの設定
        Me.DgvCustomers.DataSource = Customer.GetSortedCustomerList()

    End Sub
End Class