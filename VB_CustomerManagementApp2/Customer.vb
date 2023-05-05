Imports System.Data.SqlClient
Imports System.IO

Public Class Customer

    ''' <summary>
    ''' 顧客登録
    ''' </summary>
    ''' 2023/05/02
    Public Shared Function InsertCustomer(ByVal customerName As String,
                                           ByVal age As Integer,
                                           ByVal strGender As String,
                                           ByVal companyName As String,
                                           ByVal deptName As String,
                                           ByVal mailAddress As String,
                                           ByVal remarks As String) As Boolean

        '性別をInt型にする
        Dim intGender As Integer = OtherProc.GenderToInt(strGender)

        'パラム設定
        Dim paramList As New List(Of SqlParameter)(New SqlParameter() {
            New SqlParameter("CustomerName", customerName),
            New SqlParameter("Age", age),
            New SqlParameter("Gender", intGender),
            New SqlParameter("CompanyName", companyName),
            New SqlParameter("DeptName", deptName),
            New SqlParameter("MailAddress", mailAddress),
            New SqlParameter("Remarks", remarks)
        })

        'SQL取得
        Dim sql As String = Constant.INSERT_CUSTOMER_SQL

        'インスタンス化
        Dim db As New DB()

        'SQL実行
        db.ExecuteNonQuery(sql, paramList)

        Return True

    End Function


    ''' <summary>
    ''' 顧客一覧取得
    ''' </summary>
    ''' 2023/05/03
    Public Shared Function GetAllCustomersList() As List(Of CustomerData)

        'SQL取得
        Dim sql As String = Constant.GET_CUSTOMERS_SQL

        'インスタンス化
        Dim db As New DB()

        '実行結果(データ)を取得
        Using dt = db.GetDt(sql)
            '顧客リストに変換
            Dim customerList As List(Of CustomerData) = DtToCustomerList(dt)

            Return customerList
        End Using

    End Function


    ''' <summary>
    ''' データテーブルを顧客リストに変換
    ''' </summary>
    ''' 2023/05/03
    Private Shared Function DtToCustomerList(ByVal dt As DataTable) As List(Of CustomerData)

        Dim id As Integer
        Dim age As Integer
        Dim gender As Integer

        'リスト作成
        Dim customerList As New List(Of CustomerData)

        'インスタンス化
        Dim otherProc As New OtherProc

        'データテーブルの行数分繰り返す
        For Each row In dt.Rows
            'インスタンス化
            Dim customerData As CustomerData = New CustomerData()

            '設定
            'ID
            Integer.TryParse(row("Id").ToString(), id)
            customerData.Id = id
            '顧客氏名
            customerData.CustomerName = row("CustomerName").ToString()
            '年齢
            Integer.TryParse(row("Age").ToString(), age)
            customerData.Age = age
            '性別
            Integer.TryParse(row("Gender").ToString, gender)
            customerData.Gender = OtherProc.GenderToString(gender)
            '会社名
            customerData.CompanyName = row("CompanyName").ToString()
            '部署名
            customerData.DeptName = row("DeptName").ToString()
            'メールアドレス
            customerData.MailAddress = row("MailAddress").ToString()
            '備考
            customerData.Remarks = row("Remarks").ToString()

            'リストに追加
            customerList.Add(customerData)
        Next row

        Return customerList

    End Function


    ''' <summary>
    ''' 顧客情報削除
    ''' </summary>
    ''' 2023/05/03
    Public Shared Function DeleteCustomer(ByVal deleteCustomerID As Long) As Boolean

        'パラム設定
        Dim paramList As New List(Of SqlParameter)(New SqlParameter() {
            New SqlParameter("Id", deleteCustomerID)
        })

        'SQL取得
        Dim sql As String = Constant.DELETE_CUSTOMER_SQL

        'インスタンス化
        Dim db As New DB()

        'SQL実行
        db.ExecuteNonQuery(sql, paramList)

        Return True

    End Function


    ''' <summary>
    ''' 顧客情報取得
    ''' </summary>
    ''' 2023/05/03
    Public Shared Function GetCustomer(ByVal customerID As Long) As CustomerData

        Dim id As Integer
        Dim age As Integer
        Dim gender As Integer

        'パラム設定
        Dim paramList As New List(Of SqlParameter)(New SqlParameter() {
            New SqlParameter("Id", customerID)
        })

        'SQL取得
        Dim sql As String = Constant.GET_CUSTOMER_SQL

        'インスタンス化
        Dim customerData As New CustomerData

        'インスタンス化
        Dim db As New DB()

        '実行結果(リーダー)を取得
        Using reader = db.ExecuteReader(sql, paramList)
            '読み込める間、繰り返す
            While reader.Read()
                '設定
                'ID
                Integer.TryParse(reader(0).ToString(), id)
                customerData.Id = id
                '顧客氏名
                customerData.CustomerName = reader(1).ToString()
                '年齢
                Integer.TryParse(reader(2).ToString(), age)
                customerData.Age = age
                '性別
                Integer.TryParse(reader(3).ToString(), gender)
                customerData.Gender = OtherProc.GenderToString(gender)
                '会社名
                customerData.CompanyName = reader(4).ToString()
                '部署名
                customerData.DeptName = reader(5).ToString()
                'メールアドレス
                customerData.MailAddress = reader(6).ToString()
                '備考
                customerData.Remarks = reader(7).ToString()
            End While

            Return customerData
        End Using

    End Function


    ''' <summary>
    ''' 顧客情報更新
    ''' </summary>
    ''' 2023/05/03
    Public Shared Function UpdateCustomer(ByVal customerName As String,
                                           ByVal age As Integer,
                                           ByVal strGender As String,
                                           ByVal companyName As String,
                                           ByVal deptName As String,
                                           ByVal mailAddress As String,
                                           ByVal remarks As String,
                                           ByVal updateCustomerID As Long) As Boolean
        '性別をInt型にする
        Dim intGender As Integer = OtherProc.GenderToInt(strGender)

        'パラム設定
        Dim paramList As New List(Of SqlParameter)(New SqlParameter() {
            New SqlParameter("CustomerName", customerName),
            New SqlParameter("Age", age),
            New SqlParameter("Gender", intGender),
            New SqlParameter("CompanyName", companyName),
            New SqlParameter("DeptName", deptName),
            New SqlParameter("MailAddress", mailAddress),
            New SqlParameter("Remarks", remarks),
            New SqlParameter("Id", updateCustomerID)
        })

        'SQL取得
        Dim sql As String = Constant.UPDATE_CUSTOMER_SQL

        'インスタンス化
        Dim db As New DB()

        'SQL実行
        db.ExecuteNonQuery(sql, paramList)

        Return True

    End Function


    ''' <summary>
    ''' 検索結果(件数)を取得
    ''' </summary>
    ''' 2023/05/04
    Public Shared Function GetSearchCount(ByVal searchCustomerName As String) As Long

        'パラム設定
        Dim paramList As New List(Of SqlParameter)(New SqlParameter() {
            New SqlParameter("CustomerName", searchCustomerName)
        })

        'SQL取得
        Dim sql As String = Constant.GET_CUSTOMER_SEARCH_COUNT_SQL

        'インスタンス化
        Dim db As New DB()

        '実行結果(件数)を取得
        Return db.ExecuteScalar(sql, paramList)

    End Function


    ''' <summary>
    ''' 検索結果を取得
    ''' </summary>
    ''' 2023/05/04
    Public Shared Function FilterCustomerList(ByVal searchCustomerName As String) As List(Of CustomerData)

        'パラム設定
        Dim paramList As New List(Of SqlParameter)(New SqlParameter() {
            New SqlParameter("CustomerName", searchCustomerName)
        })

        'SQL取得
        Dim sql As String = Constant.GET_SEARCH_CUSTOMER_SQL

        'インスタンス化
        Dim db As New DB()

        '実行結果(データ)を取得
        Using dt = db.GetDt(sql, paramList)
            '顧客リストに変換
            Dim customerList As List(Of CustomerData) = DtToCustomerList(dt)

            Return customerList
        End Using

    End Function


    ''' <summary>
    ''' CSV出力
    ''' </summary>
    ''' 2023/05/05
    Public Shared Function OutputCSV(ByVal outputCustomerList As List(Of CustomerData),
                                     ByVal outputCSVPath As String) As Boolean

        '文字列のリストに変換
        Dim outputList As List(Of String) = CustomerListToStringList(outputCustomerList)

        '区切り文字で区切る
        String.Join(",", outputList)

        '出力
        File.WriteAllLines(outputCSVPath, outputList)

        Return True

    End Function


    ''' <summary>
    ''' タスクリストを文字列のリストに変換する
    ''' </summary>
    ''' 2023/05/05
    Private Shared Function CustomerListToStringList(ByVal customerList As List(Of CustomerData)) As List(Of String)

        'リスト作成
        Dim retList As New List(Of String)

        'リストの要素数だけ繰り返す
        For Each customer In customerList
            'リストに追加
            retList.Add(customer.CustomerName)
        Next customer

        Return retList

    End Function


    ''' <summary>
    ''' ソート済み顧客リストを取得
    ''' </summary>
    ''' 2023/05/05
    Public Shared Function GetSortedCustomerList() As List(Of CustomerData)

        'SQL取得
        Dim sql As String = Constant.GET_SORTEDCUSTOMERS_SQL

        'インスタンス化
        Dim db As New DB()

        '実行結果(データ)を取得
        Using dt = db.GetDt(sql)
            '顧客リストに変換
            Dim customerList As List(Of CustomerData) = DtToCustomerList(dt)

            Return customerList
        End Using

    End Function

End Class
