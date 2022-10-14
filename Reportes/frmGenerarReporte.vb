Imports CrystalDecisions.Shared
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.CrystalReports.Engine
Public Class frmGenerarReporte
    Private Sub frmGenerarReporte_Load(sender As Object, e As EventArgs) Handles Me.Load
        configureCrystalReports()
    End Sub
    Private Sub configureCrystalReports()
        Try
            Dim myConnectionInfo As ConnectionInfo = New ConnectionInfo()
            myConnectionInfo.ServerName = "DESKTOP-FORE0PK\SQLDBSERVER"
            myConnectionInfo.DatabaseName = "BASE_MPIO207"
            myConnectionInfo.UserID = "sa"
            myConnectionInfo.Password = "@sa@"
            myConnectionInfo.Type = ConnectionInfoType.Query 'Importante agregar este Type 
            myConnectionInfo.IntegratedSecurity = False
            setDBLOGONforREPORT(myConnectionInfo)
        Catch ex As Exception

        End Try
    End Sub



    Private Sub setDBLOGONforREPORT(ByVal myconnectioninfo As ConnectionInfo)
        Dim mytableloginfos As New TableLogOnInfos()
        mytableloginfos = CrystalReportViewer1.LogOnInfo
        For Each myTableLogOnInfo As TableLogOnInfo In mytableloginfos
            myTableLogOnInfo.ConnectionInfo = myconnectioninfo
        Next
    End Sub
End Class