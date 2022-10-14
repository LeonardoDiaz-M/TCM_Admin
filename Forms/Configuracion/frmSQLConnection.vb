Imports System.Xml
Imports System.Configuration
Imports System.Data.SqlClient

Public Class frmSQLConnection

    Private current_cxn As String = My.Settings.base_mpioConnectionString
    Private generic_cxn As String = My.Settings.GenericConection
    Private cxn As New cxnData
    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        generic_cxn = generic_cxn.Replace("{ServerName}", Me.txtServerName.Text.Trim.ToUpper)
        generic_cxn = generic_cxn.Replace("{Databasename}", Me.txtDBName.Text.Trim.ToUpper)
        generic_cxn = generic_cxn.Replace("{UserName}", Me.txtDBUserID.Text.Trim)
        generic_cxn = generic_cxn.Replace("{Password}", Me.txtDBPwd.Text.Trim)
        Dim cn As New SqlConnection(generic_cxn)
        Dim Ban As Boolean = False
        Try
            If Cn.State = System.Data.ConnectionState.Closed Then
                Cn.Open()
            Else
                Cn.Close()
                Cn.Open()
            End If
            ban = True
        Catch ex As System.Exception          
            MsgBox("Error: No se pudo establecer conexión con el servidor", MsgBoxStyle.OkOnly, "Error")
        End Try

        If Ban Then

            Dim applicationName As String = Environment.GetCommandLineArgs()(0)

            'Dim appName1 As String = Environment.GetCommandLineArgs()(0) '+ ".exe"
            Dim exePath As String = System.IO.Path.Combine(Environment.CurrentDirectory, applicationName)

            ' Get the configuration file. The file name has
            ' this format appname.exe.config.
            Dim config As System.Configuration.Configuration = ConfigurationManager.OpenExeConfiguration(exePath)

            Dim section As ConnectionStringsSection = TryCast(config.GetSection("connectionStrings"), ConnectionStringsSection)
            If section IsNot Nothing Then
                section.ConnectionStrings(1).ConnectionString = generic_cxn                
            End If
            Dim appsection As AppSettingsSection = TryCast(config.GetSection("appSettings"), AppSettingsSection)
            appsection.Settings("DBServerName").Value = Me.txtServerName.Text.Trim.ToUpper
            appsection.Settings("DatabaseName").Value = Me.txtDBName.Text.Trim.ToUpper
            appsection.Settings("DatabaseUserID").Value = Me.txtDBUserID.Text.Trim
            appsection.Settings("DatabasePwd").Value = Me.txtDBPwd.Text.Trim
            config.Save()
            MsgBox("Conexión Realizada!!")
            ' My.Settings.base_mpioConnectionString = generic_cxn
        End If

    End Sub
    Private Sub LoadConfigValueToControls()
        txtServerName.Text = System.Configuration.ConfigurationSettings.AppSettings.Get("DBServerName")
        txtDBName.Text = System.Configuration.ConfigurationSettings.AppSettings.Get("DatabaseName")
        txtDBUserID.Text = System.Configuration.ConfigurationSettings.AppSettings.Get("DatabaseUserID")
        txtDBPwd.Text = System.Configuration.ConfigurationSettings.AppSettings.Get("DatabasePwd")
    End Sub

    Private Sub frmSQLConnection_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadConfigValueToControls()
    End Sub
End Class