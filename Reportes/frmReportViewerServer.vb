Imports Microsoft.Reporting.WinForms
Imports System.Net
Imports Infragistics.Win.UltraWinTabControl
Imports System.ComponentModel
Public Class frmReportViewerServer
    Public id As String = "0"
    Public delete_record As Boolean = False
    Public tipo_Permiso As Integer = 0
    Private cxn As New cxnData
    Private newrow As Object
    Public myparent As Form = Nothing

    Private Sub frmReportViewerServer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cxn.Select_SQL("select urlServer,rptNameServer,usrLogin,usrPassword from tbl_reports where idReport=" & id)
        ''Set the processing mode for the ReportViewer to Remote 
        ReportViewer1.ProcessingMode = ProcessingMode.Remote

        Dim serverReport As ServerReport
        serverReport = ReportViewer1.ServerReport

        Dim myCred As NetworkCredential = New NetworkCredential(cxn.arrayValores(2), cxn.arrayValores(3))

        ''Set the credentials for the server report 
        ReportViewer1.ServerReport.ReportServerCredentials.NetworkCredentials = myCred
        ''Set the report server URL and report path  
        serverReport.ReportServerUrl = New Uri(cxn.arrayValores(0))
        serverReport.ReportPath = "/" & cxn.arrayValores(1)

        ''Create the sales order number report parameter  
        'Dim salesOrderNumber As New ReportParameter()
        'salesOrderNumber.Name = "VIN_SR"
        'salesOrderNumber.Values.Add("VINDAta")

        '' ''Set the report parameters for the report 
        'Dim parameters() As ReportParameter = {salesOrderNumber}
        'serverReport.SetParameters(parameters)

        'Refresh the report 
        ReportViewer1.RefreshReport()

        Me.ReportViewer1.RefreshReport()
    End Sub
    Private Sub frmReportViewerServer_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim Maintab As UltraTabControl = TryCast(myparent.Controls.Find("UltraTabControl1", True).FirstOrDefault(), UltraTabControl)
        Maintab.Visible = True
        Dim Mainbar As ToolStrip = TryCast(myparent.Controls.Find("CommandBar", True).FirstOrDefault(), ToolStrip)
        Mainbar.Visible = True
    End Sub

    Private Sub btnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        Me.Close()
    End Sub
End Class