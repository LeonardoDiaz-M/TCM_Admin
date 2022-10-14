Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Text
Imports System.Data.OleDb
Public Class DbSecurity
    Dim cnx As New SqlConnection
    Public Shared Function lobConnection() As SqlConnection
            Dim lobConn As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("Localsqlserver").ToString())
            lobConnection = lobConn
        End Function
        Public Shared Function dtDataTable(ByVal pstSql As String) As DataTable
            Dim lobConn As SqlConnection = lobConnection()
            Dim lobDataAdapter As SqlDataAdapter
            Dim lobSqlCommand As SqlCommand
            Dim dtable As DataTable = New DataTable

            Try
                lobDataAdapter = New SqlDataAdapter
                lobSqlCommand = New SqlCommand(pstSql, lobConn)
                lobSqlCommand.CommandType = CommandType.Text

                lobDataAdapter.SelectCommand = lobSqlCommand
                lobDataAdapter.Fill(dtable)

                dtDataTable = dtable

            Catch ex As Exception
                dtDataTable = Nothing
            Finally
                lobConnection.Close()
            End Try
        End Function

        Public Shared Function fExecuteScalarInt(ByVal sQuery As String) As Integer
            Dim lobConn As SqlConnection = lobConnection()

            Try
                Dim lobCommand As SqlCommand = New SqlCommand(sQuery, lobConn)

                lobCommand.CommandTimeout = 0
                lobConn.Open()

                fExecuteScalarInt = lobCommand.ExecuteScalar
            Catch ex As Exception
                Throw ex
            Finally
                If Not lobConn Is Nothing Then
                    lobConn.Close()
                End If
            End Try
        End Function
    End Class


