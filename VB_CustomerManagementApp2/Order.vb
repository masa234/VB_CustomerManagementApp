Imports System.Data.SqlClient

Public Class Order

    ''' <summary>
    ''' 注文情報登録
    ''' </summary>
    ''' 2023/05/04
    Public Shared Function InsertOrder(ByVal title As String,
                                           ByVal detail As String,
                                           ByVal contractStartDate As Date,
                                           ByVal contractEndDate As Date,
                                           ByVal contractMoney As Integer,
                                           ByVal strNotification As String) As Boolean

        '通知をInt型にする
        Dim intNotification As Integer = OtherProc.NotificationToInt(strNotification)

        'パラム設定
        Dim paramList As New List(Of SqlParameter)(New SqlParameter() {
            New SqlParameter("Title", title),
            New SqlParameter("Detail", detail),
            New SqlParameter("Contract_StartDate", contractStartDate),
            New SqlParameter("Contract_EndDate", contractEndDate),
            New SqlParameter("Contract＿Money", contractMoney),
            New SqlParameter("Is_Notification", intNotification)
        })

        'SQL取得
        Dim sql As String = Constant.INSERT_ORDER_SQL

        'インスタンス化
        Dim db As New DB()

        'SQL実行
        db.ExecuteNonQuery(sql, paramList)

        Return True

    End Function


    ''' <summary>
    ''' 注文情報一覧取得
    ''' </summary>
    ''' 2023/05/04
    Public Shared Function GetAllOrderList() As List(Of OrderData)

        'SQL取得
        Dim sql As String = Constant.GET_ORDER_SQL

        'インスタンス化
        Dim db As New DB()

        '実行結果(データ)を取得
        Using dt = db.GetDt(sql)
            '注文リストに変換
            Dim orderList As List(Of OrderData) = DtToOrderList(dt)

            Return orderList
        End Using

    End Function


    ''' <summary>
    ''' データテーブルを注文リストに変換
    ''' </summary>
    ''' 2023/05/04
    Public Shared Function DtToOrderList(ByVal dt As DataTable) As List(Of OrderData)

        Dim id As Integer
        Dim contractStartDate As Date
        Dim contractEndDate As Date
        Dim contractMoney As Integer
        Dim notification As Integer

        'リスト作成
        Dim orderList As New List(Of OrderData)

        'データテーブルの行数分繰り返す
        For Each row In dt.Rows
            'インスタンス化
            Dim orderData As OrderData = New OrderData()

            '設定
            'ID
            Integer.TryParse(row("Id").ToString(), id)
            orderData.Id = id
            'タイトル
            orderData.Title = row("Title").ToString()
            '詳細
            orderData.Detail = row("Detail").ToString()
            '契約開始日
            DateTime.TryParse(row("Contract_StartDate").ToString(), contractStartDate)
            orderData.ContractStartDate = contractStartDate
            '契約終了日
            DateTime.TryParse(row("Contract_EndDate").ToString(), contractEndDate)
            orderData.ContractEndDate = contractEndDate
            '契約金
            Integer.TryParse(row("Contract_Money").ToString(), contractMoney)
            orderData.ContractMoney = contractMoney
            '通知
            Integer.TryParse(row("Is_Notification").ToString(), notification)
            orderData.Notification = OtherProc.NotificationToString(notification)

            'リストに追加
            orderList.Add(orderData)
        Next row

        Return orderList

    End Function


    ''' <summary>
    ''' 注文情報削除
    ''' </summary>
    ''' 2023/05/04
    Public Shared Function DeleteOrder(ByVal deleteOrderID As Long) As Boolean

        'パラム設定
        Dim paramList As New List(Of SqlParameter)(New SqlParameter() {
            New SqlParameter("Id", deleteOrderID)
        })

        'SQL取得
        Dim sql As String = Constant.DELETE_ORDER_SQL

        'インスタンス化
        Dim db As New DB()

        'SQL実行
        db.ExecuteNonQuery(sql, paramList)

        Return True

    End Function

End Class
