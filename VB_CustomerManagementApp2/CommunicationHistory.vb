Imports System.Data.SqlClient

Public Class CommunicationHistory

    ''' <summary>
    ''' コミュニケーション履歴登録
    ''' </summary>
    ''' 2023/05/03
    Public Shared Function InsertCommunicationHistory(ByVal title As String,
                                                        ByVal detail As String) As Boolean

        'パラム設定
        Dim paramList As New List(Of SqlParameter)(New SqlParameter() {
            New SqlParameter("Title", title),
            New SqlParameter("Detail", detail)
        })

        'SQL取得
        Dim sql As String = Constant.INSERT_COMMUNICATIONHISTORY_SQL

        'インスタンス化
        Dim db As New DB()

        'SQL実行
        db.ExecuteNonQuery(sql, paramList)

        Return True

    End Function


    ''' <summary>
    ''' コミュニケーション履歴一覧取得
    ''' </summary>
    ''' 2023/05/03
    Public Shared Function GetCommunicationHistories() As DataTable

        'SQL取得
        Dim sql As String = Constant.GET_COMMUNICATIONHISTORIES_SQL

        'インスタンス化
        Dim db As New DB()

        '実行結果(データ)を取得
        Return db.GetDt(sql)

    End Function


    ''' <summary>
    ''' コミュニケーション履歴削除
    ''' </summary>
    ''' 2023/05/03
    Public Shared Function DeleteCommunicationHistory(ByVal deleteCommunicationHistoriesID As Long) As Boolean

        'パラム設定
        Dim paramList As New List(Of SqlParameter)(New SqlParameter() {
            New SqlParameter("Id", deleteCommunicationHistoriesID)
        })

        'SQL取得
        Dim sql As String = Constant.DELETE_COMMUNICATIONHISTORY_SQL

        'インスタンス化
        Dim db As New DB()

        'SQL実行
        db.ExecuteNonQuery(sql, paramList)

        Return True

    End Function

End Class
