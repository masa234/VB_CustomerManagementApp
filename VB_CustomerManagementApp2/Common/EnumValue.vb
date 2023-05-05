Public Class EnumValue

    ''' <summary>
    ''' ユーザ種類
    ''' </summary>
    Public Enum UserType
        Admin = 1
        Normal = 2
    End Enum


    ''' <summary>
    ''' ロックタイプ
    ''' </summary>
    Public Enum IsLock
        NotLock = 0
        Locked = 1
    End Enum


    ''' <summary>
    ''' 性別
    ''' </summary>
    Public Enum Gender
        Man = 1
        Woman = 2
    End Enum


    ''' <summary>
    ''' 通知
    ''' </summary>
    Public Enum IsNotification
        'TODO: ONだとエラーになるため、ONNにする
        ONN = 1
        OFF = 2
    End Enum

End Class
