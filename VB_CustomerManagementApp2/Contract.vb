Imports System.Data.SqlClient

Public Class Contract

    ''' <summary>
    ''' 契約情報登録
    ''' </summary>
    ''' 2023/05/04
    Public Shared Function InsertContract(ByVal title As String,
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
        Dim sql As String = Constant.INSERT_CONTRACT_SQL

        'インスタンス化
        Dim db As New DB()

        'SQL実行
        db.ExecuteNonQuery(sql, paramList)

        Return True

    End Function


    ''' <summary>
    ''' 契約情報一覧取得
    ''' </summary>
    ''' 2023/05/04
    Public Shared Function GetAllContractList() As List(Of ContractData)

        'SQL取得
        Dim sql As String = Constant.GET_CONTRACTS__SQL

        'インスタンス化
        Dim db As New DB()

        '実行結果(データ)を取得
        Using dt = db.GetDt(sql)
            '契約リストに変換
            Dim contractList As List(Of ContractData) = DtToContractList(dt)

            Return contractList
        End Using

    End Function


    ''' <summary>
    ''' データテーブルを契約リストに変換
    ''' </summary>
    ''' 2023/05/04
    Public Shared Function DtToContractList(ByVal dt As DataTable) As List(Of ContractData)

        Dim id As Integer
        Dim contractStartDate As Date
        Dim contractEndDate As Date
        Dim contractMoney As Integer
        Dim notification As Integer

        'リスト作成
        Dim contractList As New List(Of ContractData)

        'データテーブルの行数分繰り返す
        For Each row In dt.Rows
            'インスタンス化
            Dim contractData = New ContractData()

            '設定
            'ID
            Integer.TryParse(row("Id").ToString(), id)
            contractData.Id = id
            'タイトル
            contractData.Title = row("Title").ToString()
            '詳細
            contractData.Detail = row("Detail").ToString()
            '契約開始日
            DateTime.TryParse(row("Contract_StartDate").ToString, contractStartDate)
            contractData.ContractStartDate = contractStartDate
            '契約終了日
            DateTime.TryParse(row("Contract_EndDate").ToString(), contractEndDate)
            contractData.ContractEndDate = contractEndDate
            '契約金
            Integer.TryParse(row("Contract_Money").ToString(), contractMoney)
            contractData.ContractMoney = contractMoney
            '通知
            Integer.TryParse(row("Is_Notification").ToString(), notification)
            contractData.Notification = OtherProc.NotificationToString(notification)

            'リストに追加
            contractList.Add(contractData)
        Next row

        Return contractList

    End Function


    ''' <summary>
    ''' 契約情報削除
    ''' </summary>
    ''' 2023/04/26
    Public Shared Function DeleteContract(ByVal deleteContractID As Long) As Boolean

        'パラム設定
        Dim paramList As New List(Of SqlParameter)(New SqlParameter() {
            New SqlParameter("Id", deleteContractID)
        })

        'SQL取得
        Dim sql As String = Constant.DELETE_CONTRACT_SQL

        'インスタンス化
        Dim db As New DB()

        'SQL実行
        db.ExecuteNonQuery(sql, paramList)

        Return True

    End Function

End Class
