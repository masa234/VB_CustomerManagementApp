Public Class FrmOrders

    'ログインユーザID
    Private ReadOnly loginUserID As Long

    Public Sub New(ByVal loginUserID As Long)

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

        'ログインユーザID設定
        Me.loginUserID = loginUserID

    End Sub

    Private Sub DgvOrders_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvOrders.CellContentClick

        Dim orderID As Long

        Try
            '注文ID
            Long.TryParse(DgvOrders.Rows(e.RowIndex).Cells(1).Value.ToString(), orderID)

            '削除ボタンが押されている場合
            If DgvOrders.Columns(e.ColumnIndex).Name = "DeleteOrder" Then
                '削除
                If Not Order.DeleteOrder(orderID) Then
                    'メッセージボックス
                    MessageBox.Show(String.Format(Constant.FAILED,
                                                  Constant.DELETE_ORDER),
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

    Private Sub FrmOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
        Me.DgvOrders.DataSource = Order.GetAllOrderList()

    End Sub
End Class