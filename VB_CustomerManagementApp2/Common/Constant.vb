Public Class Constant

    ''' <summary>
    ''' バリデーションメッセージ
    ''' </summary>
    Public Const INVALID_LENGTH As String = "{0}は1～{1}文字で指定してください。"
    Public Const MUST_INPUT As String = "{0}は必須です。"
    Public Const MUST_IN_CMB As String = "{0}はコンボボックスから指定してください。"
    ''' <summary>
    ''' 失敗メッセージ
    ''' </summary>
    Public Const FAILED As String = "{0}に失敗しました。"
    ''' <summary>
    ''' 成功メッセージ
    ''' </summary>
    Public Const SUCCESS As String = "{0}に成功しました。"
    ''' <summary>
    ''' アイテム
    ''' </summary>
    Public Const ITEM_USERNAME As String = "ユーザ名"
    Public Const ITEM_PASSWORD As String = "パスワード"
    Public Const ITEM_CUSTOMERNAME As String = "顧客氏名"
    Public Const ITEM_GENDER As String = "性別"
    Public Const ITEM_COMPANYNAME As String = "会社名"
    Public Const ITEM_DEPTNAME As String = "部署名"
    Public Const ITEM_MAILADDRESS As String = "メールアドレス"
    Public Const ITEM_REMARKS As String = "備考"
    Public Const ITEM_TITLE As String = "タイトル"
    Public Const ITEM_DETAIL As String = "詳細"
    Public Const ITEM_CONTRACT_STARTDATE As String = "契約開始日"
    Public Const ITEM_CONTRACT_ENDDATE As String = "契約終了日"
    Public Const ITEM_NOTIFICATION As String = "通知ON,OFF"
    Public Const LOGIN As String = "ログイン"
    Public Const INSERT_CUSTOMER As String = "顧客登録"
    Public Const DELETE_CUSTOMER As String = "顧客削除"
    Public Const UPDATE_CUSTOMER As String = "顧客更新"
    Public Const INSERT_COMMUNICATIONHISTORY As String = "コミュニケーション履歴登録"
    Public Const DELETE_COMMUNICATIONHISTORY As String = "コミュニケーション履歴削除"
    Public Const INSERT_CONTRACT As String = "契約情報登録"
    Public Const INSERT_ORDER As String = "注文情報登録"
    Public Const DELETE_ORDER As String = "注文情報削除"
    Public Const OUTPUT_CSV As String = "CSV出力"
    ''' <summary>
    ''' メッセージタイトル
    ''' </summary>
    Public Const WARNING As String = "警告"
    Public Const CONFIRM As String = "確認"
    ''' <summary>
    ''' 接続文字列
    ''' </summary>
    Public Const CONNECTION_STRING As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=testDB5;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
    ''' <summary>
    ''' 最大文字数
    ''' </summary>
    Public Const USERNAME_MAX_LENGTH As Long = 255
    Public Const PASSWORD_MAX_LENGTH As Long = 255
    Public Const CUSTOMERNAME_MAX_LENGTH As Long = 255
    Public Const COMPANYNAME_MAX_LENGTH As Long = 255
    Public Const DEPTNAME_MAX_LENGTH As Long = 255
    Public Const MAILADDRESS_MAX_LENGTH As Long = 255
    Public Const REMARKS_MAX_LENGTH As Long = 255
    Public Const TITLE_MAX_LENGTH As Long = 255
    Public Const DETAIL_MAX_LENGTH As Long = 255
    ''' <summary>
    ''' その他
    ''' </summary>
    Public Const LOCK_COUNT As Long = 3
    Public Const USER_IS_LOCKED As String = "アカウントがロックされています。管理者に問い合わせてください。"
    Public Const USER_IS_LOCK As String = "アカウントがロックされました。管理者に問い合わせてください。"
    Public Const OUTPUT_CSV_PATH = "C:\Users\bfmt1\OneDrive\デスクトップ"
    ''' <summary>
    ''' ユーザ情報SQL
    ''' </summary>
    Public Const GET_USER_COUNT_SQL As String = "SELECT " +
                                                "  COUNT(*) " +
                                                "FROM " +
                                                "  Users " +
                                                "WHERE " +
                                                "  UserName = @UserName " +
                                                "AND " +
                                                "  Password = @Password "
    Public Const GET_USERID_SQL As String = "SELECT " +
                                            "  Id " +
                                            "FROM " +
                                            "  Users " +
                                            "WHERE " +
                                            "  UserName = @UserName " +
                                            "AND " +
                                            "  Password = @Password "
    Public Const GET_USERNAME_COUNT_SQL As String = "SELECT " +
                                                    "  COUNT(*) " +
                                                    "FROM " +
                                                    "  Users " +
                                                    "WHERE " +
                                                    "  UserName = @UserName "
    Public Const GET_LOCKFLAG_SQL As String = "SELECT " +
                                            "    LockFlag " +
                                            "  FROM " +
                                            "    Users " +
                                            "  WHERE " +
                                            "    UserName = @UserName "
    Public Const GET_ADMIN_SQL As String = " SELECT " +
                                            "  Admin " +
                                            "FROM " +
                                            "  Users " +
                                            "WHERE " +
                                            "  Id = @Id "
    Public Const GET_LOCKED_USERS_SQL As String = "SELECT " +
                                                "    Id, " +
                                                "    UserName, " +
                                                "    Password " +
                                                "  FROM " +
                                                "    Users " +
                                                "  WHERE " +
                                                "    LockFlag = @LockFlag " +
                                                "  ORDER BY " +
                                                "    Id ASC "
    Public Const UPDATE_LOCKFLAG_SQL As String = "UPDATE " +
                                                "   Users " +
                                                " SET " +
                                                "   LockFlag = @LockFlag " +
                                                " WHERE " +
                                                "   UserName = @UserName "
    ''' <summary>
    ''' 顧客情報SQL
    ''' </summary>
    Public Const GET_CUSTOMERS_SQL As String = " SELECT " +
                                            "      Id, " +
                                            "      CustomerName, " +
                                            "      Age, " +
                                            "      Gender, " +
                                            "      CompanyName, " +
                                            "      DeptName, " +
                                            "      MailAddress, " +
                                            "      Remarks " +
                                            "    FROM " +
                                            "      Customers "
    Public Const GET_CUSTOMER_SQL As String = " SELECT " +
                                            "     Id, " +
                                            "     CustomerName, " +
                                            "     Age, " +
                                            "     Gender, " +
                                            "     CompanyName, " +
                                            "     DeptName, " +
                                            "     MailAddress, " +
                                            "     Remarks " +
                                            "   FROM " +
                                            "     Customers " +
                                            "   WHERE " +
                                            "     Id = @Id "
    Public Const GET_CUSTOMER_SEARCH_COUNT_SQL = " SELECT " +
                                                "    COUNT(*) " +
                                                "  FROM " +
                                                "    Customers " +
                                                "  WHERE " +
                                                "    CustomerName Like @CustomerName "
    Public Const GET_SEARCH_CUSTOMER_SQL = "  SELECT " +
                                            "   Id, " +
                                            "   CustomerName, " +
                                            "   Age, " +
                                            "   Gender, " +
                                            "   CompanyName, " +
                                            "   DeptName, " +
                                            "   MailAddress, " +
                                            "   Remarks " +
                                            " FROM " +
                                            "   Customers " +
                                            " WHERE " +
                                            "   CustomerName Like @CustomerName "
    Public Const GET_SORTEDCUSTOMERS_SQL As String = " SELECT " +
                                                "        Id, " +
                                                "        CustomerName, " +
                                                "        Age, " +
                                                "        Gender, " +
                                                "        CompanyName, " +
                                                "        DeptName, " +
                                                "        MailAddress, " +
                                                "        Remarks " +
                                                "      FROM " +
                                                "        Customers " +
                                                "      ORDER BY Age ASC "
    Public Const INSERT_CUSTOMER_SQL As String = "INSERT " +
                                                "   INTO " +
                                                " Customers " +
                                                "   (CustomerName, " +
                                                "   Age, " +
                                                "   Gender, " +
                                                "   CompanyName, " +
                                                "   DeptName, " +
                                                "   MailAddress, " +
                                                "   Remarks) " +
                                                " VALUES" +
                                                "   (@CustomerName, " +
                                                "   @Age, " +
                                                "   @Gender, " +
                                                "   @CompanyName, " +
                                                "   @DeptName, " +
                                                "   @MailAddress, " +
                                                "   @Remarks) "
    Public Const DELETE_CUSTOMER_SQL As String = "DELETE " +
                                                "FROM " +
                                                "  Customers " +
                                                "WHERE " +
                                                "  Id = @Id "
    Public Const UPDATE_CUSTOMER_SQL As String = "UPDATE " +
                                                "  Customers " +
                                                "SET " +
                                                "  CustomerName = @CustomerName, " +
                                                "  Age = @Age, " +
                                                "  Gender = @Gender, " +
                                                "  CompanyName = @CompanyName, " +
                                                "  DeptName = @DeptName, " +
                                                "  MailAddress = @MailAddress, " +
                                                "  Remarks = @Remarks " +
                                                "WHERE " +
                                                "  Id = @Id "
    ''' <summary>
    ''' コミュニケーション履歴SQL
    ''' </summary>
    Public Const GET_COMMUNICATIONHISTORIES_SQL As String = " SELECT " +
                                                        "       Id, " +
                                                        "       Title, " +
                                                        "       Detail " +
                                                        "     FROM " +
                                                        "       CommunicationHistories "
    Public Const INSERT_COMMUNICATIONHISTORY_SQL As String = "INSERT " +
                                                            "   INTO " +
                                                            " CommunicationHistories " +
                                                            "   (Title, " +
                                                            "   Detail) " +
                                                            " VALUES" +
                                                            "   (@Title, " +
                                                            "   @Detail) "
    Public Const DELETE_COMMUNICATIONHISTORY_SQL As String = "DELETE " +
                                                            " FROM " +
                                                            "   CommunicationHistories " +
                                                            " WHERE " +
                                                            "   Id = @Id "
    ''' <summary>
    ''' 契約情報SQL
    ''' </summary>
    Public Const GET_CONTRACTS__SQL As String = " SELECT " +
                                            "      Id, " +
                                            "      Title, " +
                                            "      Detail, " +
                                            "      Contract_StartDate, " +
                                            "      Contract_EndDate, " +
                                            "      Contract＿Money, " +
                                            "      Is_Notification " +
                                            "    FROM " +
                                            "      Contract "
    Public Const INSERT_CONTRACT_SQL As String = "INSERT " +
                                                "   INTO " +
                                                " Contract " +
                                                "   (Title, " +
                                                "   Detail , " +
                                                "   Contract_StartDate, " +
                                                "   Contract_EndDate, " +
                                                "   Contract＿Money, " +
                                                "   Is_Notification) " +
                                                " VALUES" +
                                                "   (@Title, " +
                                                "   @Detail, " +
                                                "   @Contract_StartDate, " +
                                                "   @Contract_EndDate, " +
                                                "   @Contract＿Money, " +
                                                "   @Is_Notification) "
    Public Const DELETE_CONTRACT_SQL As String = "DELETE " +
                                                " FROM " +
                                                "   Contract " +
                                                " WHERE " +
                                                "   Id = @Id "
    ''' <summary>
    ''' 注文情報SQL
    ''' </summary>
    Public Const GET_ORDER_SQL As String = " SELECT " +
                                        "       Id, " +
                                        "       Title, " +
                                        "       Detail, " +
                                        "       Contract_StartDate, " +
                                        "       Contract_EndDate, " +
                                        "       Contract＿Money, " +
                                        "       Is_Notification " +
                                        "     FROM " +
                                        "       Orders "
    Public Const INSERT_ORDER_SQL As String = "INSERT " +
                                            "    INTO " +
                                            "  Orders " +
                                            "    (Title, " +
                                            "    Detail , " +
                                            "    Contract_StartDate, " +
                                            "    Contract_EndDate, " +
                                            "    Contract＿Money, " +
                                            "    Is_Notification) " +
                                            "   VALUES" +
                                            "    (@Title, " +
                                            "     @Detail, " +
                                            "     @Contract_StartDate, " +
                                            "     @Contract_EndDate, " +
                                            "     @Contract＿Money, " +
                                            "     @Is_Notification) "
    Public Const DELETE_ORDER_SQL As String = "DELETE " +
                                            "  FROM " +
                                            "    Orders " +
                                            "  WHERE " +
                                            "    Id = @Id "
End Class
