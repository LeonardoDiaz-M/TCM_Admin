Public Class clsNegocioUser_Profiles
    '===========================================================================================================================
    'USER PROFILES
    '===========================================================================================================================
    Dim cxn As New cxnData
    Public Function funGetUserProfiles() As DataTable
        Dim sQuery As String = "USER_PROFILES_GET"
        Dim dt As DataTable = cxn.dtDataTable(sQuery)
        Return dt
    End Function

    Public Function funGetUserProfiles(User As String) As DataTable
        Dim sQuery As String = "USER_PROFILES_GET '" & User & "'"
        Dim dt As DataTable = cxn.dtDataTable(sQuery)
        Return dt
    End Function

    Public Function funGetAllUserProfiles() As DataTable
        Dim sQuery As String = "aspnet_Membership_GetUsers"
        Dim dt As DataTable = cxn.dtDataTable(sQuery)
        Return dt
    End Function

    Public Function funGetAllUserSeguridad() As DataTable
        Dim sQuery As String = "Seguridad_GetUsers"
        Dim dt As DataTable = cxn.dtDataTable(sQuery)

        Return dt
    End Function

    Public Function funSetUserProfiles(ByVal iVariable As String, ByVal User As String, ByVal Nombres As String _
                                              , ByVal Paterno As String, ByVal Materno As String, ByVal IdPuesto As Integer, ByVal IdOficina As String _
                                              , ByVal Telefono As String, ByVal NumeroCaja As String, ByVal Usuario As String, ByVal ValidaUbicacion As Boolean) As Integer

        Dim sQuery As String = "USER_PROFILES_SET '" & iVariable & "','" & User & "','" & Nombres & "','" & Paterno & "','" & Materno & "'," & IdPuesto & ",'" & IdOficina & "','" & Telefono & "','" & NumeroCaja & "','" & Usuario & "','" & ValidaUbicacion & "'"

        Dim iError As Integer = cxn.Gen_SQL(sQuery)
        Return iError
    End Function

    'Public Function funSetDirecciones_Fisicas(ByVal iVariable As String, ByVal Id As Integer, ByVal IdSucursal As Integer _
    '                                         , ByVal Referencia As String, ByVal MacAdress As String, ByVal Estatus As Boolean) As Integer

    '    Dim sQuery As String = "DIRECCIONES_FISICAS_SET '" & iVariable & "'," & Id & "," & IdSucursal & ",'" & Referencia & "','" & MacAdress & "'," & Estatus

    '    Dim iError As Integer
    '    iError = DB.fExecuteScalarInt(sQuery).ToString
    '    Return iError
    'End Function

    Public Function funGetDirecciones_Fisicas() As DataTable
        Dim sQuery As String = "DIRECCIONES_FISICAS_GET"
        Dim dt As DataTable = cxn.dtDataTable(sQuery)
        Return dt
    End Function

    Public Function funGetDirecciones_Fisicas_Sucursal(ByVal Id_Sucursal As Integer) As DataTable
        Dim sQuery As String = "DIRECCIONES_FISICAS_SUCURSAL_GET " & Id_Sucursal
        Dim dt As DataTable = cxn.dtDataTable(sQuery)
        Return dt
    End Function


    'Public Function funSetUser_Direcciones_Fisicas(ByVal iVariable As String, ByVal Id As Integer, ByVal Usuario As String _
    '                                         , ByVal IdDireccionFisica As Integer) As Integer

    '    Dim sQuery As String = "USER_DIRECCIONES_FISICAS_SET '" & iVariable & "'," & Id & ",'" & Usuario & "'," & IdDireccionFisica

    '    Dim iError As Integer
    '    iError = DB.fExecuteScalarInt(sQuery).ToString
    '    Return iError
    'End Function

    Public Function funGetUser_Direcciones_Fisicas(ByVal Usuario As String) As DataTable
        Dim sQuery As String = "USER_DIRECCIONES_FISICAS_GET '" & Usuario & "'"
        Dim dt As DataTable = cxn.dtDataTable(sQuery)
        Return dt
    End Function

    'Public Function funGetValidaUbicacionUsuario(ByVal IdSucursal As Integer, ByVal MacAdress As String)
    '    Dim sQuery As String = "select (DBO.VALIDA_MACADRESS (" & IdSucursal & ",'" & MacAdress & "'))"

    '    Dim Valor As Integer
    '    Valor = DB.fExecuteScalarInt(sQuery)
    '    Return Valor
    'End Function

    'Public Function funGetIdSucursalPorMacAdress(ByVal MacAdress As String) As Integer
    '    Dim sQuery As String = "select (DBO.DIRECCIONES_FISICAS_IDSUCURSAL_GET ('" & MacAdress & "'))"
    '    Dim Valor As Integer
    '    Valor = DB.fExecuteScalarStr(sQuery)
    '    Return Valor
    'End Function
End Class
