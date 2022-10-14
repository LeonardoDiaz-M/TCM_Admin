Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win
Imports Infragistics.Documents.Reports.Report
Imports Infragistics.Win.UltraWinGrid.DocumentExport
Imports Infragistics.Documents.Reports.Report.Section
Imports Infragistics.Documents.Reports.Report.Text
Imports Infragistics.Documents.Reports
Imports System.Runtime.InteropServices
Imports System.Reflection
Imports System.Runtime.InteropServices.ComTypes
Imports System.Drawing.Printing
Imports System.IO
Imports System.ComponentModel
Imports Infragistics.Documents.Reports.Report.Projection

Public Class frmReport
    Public ugrpd As New UltraGridPrintDocument
    Private cxn As New cxnData
    Public query As String = ""
    Public grd As UltraGrid
    Dim fileexported As String = ""
    Dim myBackgroundWorker As New System.ComponentModel.BackgroundWorker()
    Private pages As IProjectionPageCollection
    Private currentPrintPageNumber As Integer
    Private error_msg As String = ""
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cxn.Get_SQL_DataGrid(query, Me.UltraGrid1)
        Me.UltraGrid1.DisplayLayout.AutoFitStyle = AutoFitStyle.ResizeAllColumns

        myBackgroundWorker.WorkerReportsProgress = True
        myBackgroundWorker.WorkerSupportsCancellation = True
        AddHandler myBackgroundWorker.DoWork, AddressOf myBackgroundWorker1_DoWork
        AddHandler myBackgroundWorker.RunWorkerCompleted, AddressOf myBackgroundWorker1_RunWorkerCompleted
    End Sub



    Private Sub UltraGrid1_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles UltraGrid1.InitializeLayout
        Try
            e.Layout.Override.AllowRowSummaries = AllowRowSummaries.True

            Dim columnToSummarize As UltraGridColumn = e.Layout.Bands(0).Columns(0)
            Dim summary As SummarySettings = e.Layout.Bands(0).Summaries.Add("Gran Total", SummaryType.Count, columnToSummarize)
            summary.DisplayFormat = "Registros encontrados {0:#####}"
            summary.Appearance.TextHAlign = HAlign.Right
            e.Layout.Override.SummaryDisplayArea = SummaryDisplayAreas.TopFixed
            e.Layout.Override.SummaryDisplayArea = e.Layout.Override.SummaryDisplayArea Or SummaryDisplayAreas.GroupByRowsFooter
            e.Layout.Override.SummaryDisplayArea = e.Layout.Override.SummaryDisplayArea Or SummaryDisplayAreas.InGroupByRows
            summary.SummaryDisplayArea = SummaryDisplayAreas.BottomFixed _
                                            Or SummaryDisplayAreas.GroupByRowsFooter

            e.Layout.Override.GroupBySummaryDisplayStyle = GroupBySummaryDisplayStyle.SummaryCells
            e.Layout.Override.SummaryFooterAppearance.BackColor = Drawing.Color.Silver

            e.Layout.Override.SummaryValueAppearance.BackColor = SystemColors.Window
            e.Layout.Override.SummaryValueAppearance.FontData.Bold = DefaultableBoolean.True

            e.Layout.Override.GroupBySummaryValueAppearance.BackColor = Drawing.Color.Gray
            e.Layout.Override.GroupBySummaryValueAppearance.TextHAlign = HAlign.Right

            e.Layout.Bands(0).SummaryFooterCaption = "Total:"

            e.Layout.Override.SummaryFooterCaptionAppearance.FontData.Bold = DefaultableBoolean.True

            e.Layout.Override.SummaryFooterSpacingAfter = 5
            e.Layout.Override.SummaryFooterSpacingBefore = 5
            Dim report As Report = New Report()
            Dim section As ISection = report.AddSection()
            Dim sec_header As ISectionHeader = section.AddHeader
            sec_header.Height = 100
            sec_header.Repeat = True
            Dim headerTitle As IText = sec_header.AddText(30, 30)
            'headerTitle.Style = style1
            headerTitle.AddContent("reporte sssssssssssssssssssssssssssssssssssssss")
            headerTitle.Alignment = TextAlignment.Center


        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub



    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles btnpdf.Click
        If Not myBackgroundWorker.IsBusy Then
            myBackgroundWorker.RunWorkerAsync()
            Me.UltraGrid1.Enabled = False
            Me.btnpdf.Enabled = False
            Me.RadWaitingBar1.Visible = True
            Me.RadWaitingBar1.BringToFront()
            Me.RadWaitingBar1.StartWaiting()
            Me.lblStatus.Text = "Generando archivo espere..."
        End If

    End Sub
    Private Function export_pdf_file(ByVal n As Integer, ByVal worker As BackgroundWorker, ByVal e As DoWorkEventArgs) As Long
        Dim result As Long = 0
        fileexported = pathStoredFiles & CurrentUsrName.Replace("\", "_") & "_" & Now.Millisecond.ToString & Now.Second.ToString & ".pdf"
        Try
            Me.UltraGridDocumentExporter1.Export(
                      Me.UltraGrid1,
                      fileexported,
                      Infragistics.Win.UltraWinGrid.DocumentExport.GridExportFileFormat.PDF)
            result = 1
            error_msg = ""
        Catch ex As Exception
            result = 0
            Me.error_msg = ex.Message
        End Try
        Return result
    End Function

    Private Sub myBackgroundWorker1_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)
        Dim worker As BackgroundWorker = TryCast(sender, BackgroundWorker)
        Dim n As Integer = Convert.ToInt32(e.Argument)
        e.Result = export_pdf_file(n, worker, e)
    End Sub
    Private Sub myBackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs)
        Me.RadWaitingBar1.StopWaiting()
        Me.RadWaitingBar1.ResetWaiting()
        Me.RadWaitingBar1.Visible = False
        Me.RadWaitingBar1.SendToBack()
        If (e.Cancelled = True) Then
            Me.lblStatus.Text = "El reporte se cancelo por el usuario!"
        ElseIf Not (e.Error Is Nothing) Or e.Result = 0 Then
            If Not (e.Error Is Nothing) Then
                error_msg = error_msg & "-" & e.Error.Message.ToString
            End If
            Me.lblStatus.Text = ("Error: " & error_msg)
            error_msg = ""
        Else
            Me.lblStatus.Text = "Archivo Generado " & fileexported
            Me.UltraGrid1.Enabled = True
            Me.btnpdf.Enabled = True
        End If
    End Sub


End Class
