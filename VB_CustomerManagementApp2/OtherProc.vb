Public Class OtherProc

    ''' <summary>
    ''' 性別のリストを取得
    ''' </summary>
    ''' 2023/05/02
    Public Shared Function GetGenderList() As List(Of String)

        '性別のリスト
        Return New List(Of String)(New String() {
            "男",
            "女"
        })

    End Function


    ''' <summary>
    ''' 性別をInt型に変換する
    ''' </summary>
    ''' 2023/05/02
    Public Shared Function GenderToInt(ByVal strGender As String) As Integer

        '値によって分岐させる
        Select Case strGender
            Case "男"
                Return EnumValue.Gender.Man
            Case "女"
                Return EnumValue.Gender.Woman
        End Select

        Return 0

    End Function


    ''' <summary>
    ''' 性別をString型に変換する
    ''' </summary>
    ''' 2023/05/03
    Public Shared Function GenderToString(ByVal intGender As String) As String

        '値によって分岐させる
        Select Case intGender
            Case EnumValue.Gender.Man
                Return "男"
            Case EnumValue.Gender.Woman
                Return "女"
        End Select

        Return String.Empty

    End Function


    ''' <summary>
    ''' 通知のリストを取得
    ''' </summary>
    ''' 2023/05/04
    Public Shared Function GetNotificationList() As List(Of String)

        '性別のリスト
        Return New List(Of String)(New String() {
            "ON",
            "OFF"
        })

    End Function


    ''' <summary>
    ''' 通知をInt型に変換する
    ''' </summary>
    ''' 2023/05/04
    Public Shared Function NotificationToInt(ByVal strNotification As String) As Integer

        '値によって分岐させる
        Select Case strNotification
            Case "ON"
                Return EnumValue.IsNotification.ONN
            Case "OFF"
                Return EnumValue.IsNotification.OFF
        End Select

        Return 0

    End Function


    ''' <summary>
    ''' 通知をString型に変換する
    ''' </summary>
    ''' 2023/05/04
    Public Shared Function NotificationToString(ByVal intNortification As String) As String

        '値によって分岐させる
        Select Case intNortification
            Case EnumValue.IsNotification.ONN
                Return "ON"
            Case EnumValue.IsNotification.OFF
                Return "OFF"
        End Select

        Return String.Empty

    End Function

End Class
