Public Class clsNegocioMembership
    Dim cxn As New cxnData
    Public Function fun_Aspnet_Roles_Get_AllRoles(ByVal Aplication As String) As DataTable
        Dim sQuery As String = "aspnet_Roles_Get_AllRoles '" & Aplication & "'"
        Dim dt As DataTable = cxn.dtDataTable(sQuery)
        Return dt
    End Function
    Public Function fun_Aspnet_GetUsers_InRoles(ByVal Aplication As String, ByVal Rol_Name As String) As DataTable
        Dim sQuery As String = "aspnet_UsersInRoles_GetUsers_InRoles '" & Aplication & "','" & Rol_Name & "'"
        Dim dt As DataTable = cxn.dtDataTable(sQuery)
        Return dt
    End Function
    Public Function fun_Aspnet_GetAll_Users() As DataTable
        Dim sQuery As String = "aspnet_Membership_GetAll_Users"
        Dim dt As DataTable = cxn.dtDataTable(sQuery)
        Return dt
    End Function
    Public Function fun_Aspnet_GetByUserNameGenerals(ByVal UserName As String) As DataTable
        Dim sQuery As String = "aspnet_Membership_GetUserByUserName " & "'" & UserName & "'"
        Dim dt As DataTable = cxn.dtDataTable(sQuery)
        Return dt
    End Function
    'Public Function fun_Aspnet_Roles_Create_Role(ByVal Aplicacion As String, ByVal RolName As String, ByVal Nivel As Integer _
    '                                        , ByVal ParentRoleName As String, ByVal Type As String, ByVal Form As String) As Integer

    '    Dim sQuery As String = "aspnet_Roles_Create_Role '" & Aplicacion & "','" & RolName & "'," & Nivel & ",'" & ParentRoleName & "','" & Type & "','" & Form & "'"

    '    Dim iError As Integer
    '    iError = DbSecurity.fExecuteScalarInt(sQuery).ToString
    '    Return iError
    'End Function
End Class
