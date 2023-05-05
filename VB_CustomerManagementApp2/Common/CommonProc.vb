Imports System.ComponentModel

Public Class CommonProc

    ''' <summary>
    ''' 文字数がおさまっているかどうか?
    ''' </summary>
    ''' 2023/05/01
    Public Shared Function IsFitInText(ByVal str As String,
                                 ByVal maxLength As Long) As Boolean

        '空かどうか?
        If String.IsNullOrEmpty(str) Then
            Return False
        End If

        '制限文字列以内かどうか?
        If maxLength < str.Length Then
            Return False
        End If

        Return True

    End Function


    ''' <summary>
    ''' 画面遷移
    ''' </summary>
    ''' 2023/05/01
    Public Shared Sub HideAndOpen(ByVal openedForm As Form,
                                        ByVal openForm As Form)

        '既に開いている画面を非表示にする
        openedForm.Hide()

        '画面を表示
        openForm.Show()

    End Sub


    ''' <summary>
    ''' コンボボックスに設定
    ''' </summary>
    ''' 2023/05/02
    Public Shared Sub SetCmb(ByVal cmb As ComboBox,
                            ByVal cmbTxtList As List(Of String))

        'リストの要素数だけ繰り返す
        For Each cmbTxt In cmbTxtList
            'コンボボックスに設定
            cmb.Items.Add(cmbTxt)
        Next cmbTxt

    End Sub


    ''' <summary>
    ''' コンボボックスの選択肢内かどうか?
    ''' </summary>
    ''' 2023/05/02
    Public Shared Function IsTextInCmb(ByVal cmb As ComboBox,
                                        ByVal str As String) As Boolean

        'リスト作成
        Dim cmbTxtList As New List(Of String)

        'コンボボックスの要素数だけ繰り返す
        For Each cmbTxt In cmb.Items
            'リストに追加
            cmbTxtList.Add(cmbTxt)
        Next cmbTxt

        'リストに存在するかどうか?
        If cmbTxtList.Contains(str) Then
            Return True
        End If

        Return False

    End Function

End Class
