Imports System.ComponentModel
Public Class PaeOtrosPadrones
    Public id As String = "0"
    Public Lectura As Boolean = False
    Public Insertar As Boolean = False
    Public Borrar As Boolean = False
    Public Editar As Boolean = False
    Public idUsuario As String = CurrentUsrName
    Public myparent As Form = Nothing
    Private cxn As New cxnData
    Dim TotalRegistrosACalcular As Integer = 0
    Dim valor As Integer
    Dim ClavePredio As String = ""
    Private Sub optSelDatos_ValueChanged(sender As Object, e As EventArgs) Handles optSelDatos.ValueChanged
        Dim Editor = TryCast(sender, Infragistics.Win.UltraWinEditors.UltraOptionSet)
        If Editor IsNot Nothing Then
            ErrorProvider1.Clear()
            txtClaveLicencia.Visible = False

            Select Case Editor.Value.ToString
                Case Is = 1 'clave catastral
                    txtClaveLicencia.Visible = True
                    txtClaveLicencia.Focus()
                Case Is = 2 'zona manzana

            End Select
        End If
    End Sub
    Private Sub optReporte_ValueChanged(sender As Object, e As EventArgs) Handles optReporte.ValueChanged
        Dim Editor = TryCast(sender, Infragistics.Win.UltraWinEditors.UltraOptionSet)
        If Editor IsNot Nothing Then
            panDiagMontAdeudo.Visible = False
            gruDocAuxCobranza.Enabled = False
            gruDocumentospae.Enabled = False

            Select Case Editor.Value.ToString
                Case Is = 2
                    panDiagMontAdeudo.Visible = True
                    uneDiagMontoAdeudoDel.SelectAll()
                Case Is = 3
                    gruDocAuxCobranza.Enabled = True
                    gruDocumentospae.Enabled = True
                Case Else
                    gruDocAuxCobranza.Enabled = False
                    gruDocumentospae.Enabled = False
                    panDiagMontAdeudo.Visible = False
            End Select
        End If
    End Sub
    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
        Me.lblMessage.Text = "Generando cálculo, espere ..."
        Try
            If valida_datos() Then
                DB.fExecuteScalarInt("TRUNCATE TABLE PAE_ENCABEZADO_LICENCIAS")
                BackgroundWorker1.RunWorkerAsync()
                MuestraProgreso()
            End If
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al efectuar el proceso.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    Private Sub MuestraProgreso()
        TotalRegistrosACalcular = ClavesACalcular()
        barCalculo.Maximum = TotalRegistrosACalcular
        BackgroundWorker2.RunWorkerAsync()
    End Sub
    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)
        If worker.CancellationPending = True Then
            e.Cancel = True
        Else
            System.Threading.Thread.Sleep(10)
            Dim iError As Integer
            Dim Squery As String
            Dim ClaveIngreso As String
            Dim TipoDocumento As String
            ClaveIngreso = optPadronLicencias.Value
            TipoDocumento = "M"  'manejamos la constante M /Mandamiento ejecucion ya que es el Unico que lleva MOTIVACION

            'ejecuta proceso principal
            Squery = "exec PAE_PROCESO_LICENCIAS '" & optSelDatos.Value & "','" & Me.txtClaveLicencia.Text & "','" & ClaveIngreso & "','" & TipoDocumento & "','" & txtNombreNotificador.Text & "','" & uneFolioInicial.Value & "','" & txtNumeroCredencial.Text & "'"
            iError = DB.fExecuteScalarIntTimeOut(Squery, 0)
            MessageBox.Show("Proceso Generado Satisfactoriamente.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Sub BackgroundWorker2_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        valor = 1
        Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)

        If worker.CancellationPending = True Then
            e.Cancel = True
        Else
            'define un intervalo para consultar el progreso
            System.Threading.Thread.Sleep(10)
            'Mientras se ejecute el proceso principal, valido el avance calculado
            While BackgroundWorker1.IsBusy = True
                valor = DB.fExecuteScalarInt("select count(Clave_Licencia) from PAE_ENCABEZADO_LICENCIAS")
                worker.ReportProgress(valor)
            End While
        End If
    End Sub
    Private Sub backgroundWorker2_ProgressChanged(ByVal sender As System.Object, ByVal e As ProgressChangedEventArgs) Handles BackgroundWorker2.ProgressChanged
        Me.btnProcesar.Enabled = False
        lblMessage.Text = "Total registros calculados: " & e.ProgressPercentage.ToString() & " De:" & TotalRegistrosACalcular
        barCalculo.Value = e.ProgressPercentage
    End Sub
    Private Function valida_datos() As Boolean
        Dim ban As Boolean = False
        Dim ocurriounError As Integer = 0
        Dim mensaje As String = ""
        Try
            ErrorProvider1.Clear()
            If optSelDatos.Value = 0 Then
                ErrorProvider1.SetError(optSelDatos, "Error")
                ocurriounError += 1
                mensaje += "- " & "Seleccione una opción de cálculo." & "<br />"
                optSelDatos.Select()
            End If
            If optPadronLicencias.Value = 0 Then
                ErrorProvider1.SetError(optPadronLicencias, "Error")
                ocurriounError += 1
                mensaje += "- " & "Seleccione una opción del padrón de licencias." & "<br />"
                optPadronLicencias.Select()
            End If

            'Seleccion clave catastral
            If optSelDatos.Value = 1 Then
                If Me.txtClaveLicencia.Text.Trim.Length > 0 Then
                    If Me.txtClaveLicencia.Text.Length = 8 Then
                        cxn.Select_SQL("select cve_licencia from tbl_lic_municipales where cve_licencia='" & Me.txtClaveLicencia.Text & "'")
                        If cxn.arrayValores(0) Is Nothing Then
                            ErrorProvider1.SetError(txtClaveLicencia, "Error")
                            mensaje += "- " & "El número de licencia no existe, verifique." & "<br />"
                            ocurriounError += 1
                            Me.txtClaveLicencia.SelectAll()
                        End If
                    Else
                        ErrorProvider1.SetError(txtClaveLicencia, "Error")
                        ocurriounError += 1
                        mensaje += "- " & "Número de licencia  errónea, verifique." & "<br />"
                        txtClaveLicencia.Focus()
                    End If
                Else
                    ErrorProvider1.SetError(txtClaveLicencia, "Error")
                    ocurriounError += 1
                    mensaje += "- " & "Ingrese el número de licencia." & "<br />"
                    txtClaveLicencia.Focus()
                End If
            End If

            If ocurriounError > 0 Then
                ban = False
                cMensajes.DisplayMessage(Me, mensaje, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Else
                ban = True
            End If

        Catch ex As Exception
            cMensajes.DisplayMessage(Me, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
        Return ban
    End Function
    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        If e.Cancelled = True Then
            lblMessage.Text = "Proceso Canceledo!"
        ElseIf e.Error IsNot Nothing Then
            lblMessage.Text = "Error: " & e.Error.Message
        Else
            BackgroundWorker2.Dispose()
            lblMessage.Text = "Proceso Terminado!"
        End If
        btnProcesar.Enabled = True
    End Sub
    Private Function ClavesACalcular() As Integer
        Dim ClaveIngreso As String
        ClaveIngreso = optPadronLicencias.Value

        If optSelDatos.Value = 1 Then
            TotalRegistrosACalcular = 1
        End If

        If optSelDatos.Value = 2 Then
            TotalRegistrosACalcular = DB.fExecuteScalarInt("select COUNT(cve_licencia) from tbl_lic_municipales " & "where substring(tip_der,1,6)='" & ClaveIngreso & "'")
        End If
        Return TotalRegistrosACalcular
    End Function

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Dim Formulario As New frmGenerarReporte
        Dim frmReporte As New Form

        If optReporte.Value = 1 Then 'Diagnóstico por contribuyente
            Me.Cursor = Cursors.WaitCursor
            Dim Rpt As New rptDiagnosticoPorContribuyenteLicencias
            Me.Tbl_lic_municipalesTableAdapter.Fill(Me.DsPae.tbl_lic_municipales)
            Me.C_LIQ_LICENCIASTableAdapter.Fill(Me.DsPae.C_LIQ_LICENCIAS)
            Rpt.SetDataSource(DsPae)
            Formulario.CrystalReportViewer1.ReportSource = Rpt
            'Rpt.SetParameterValue("Logo1", My.Application.Info.DirectoryPath.ToString & "\Images\Logo1.jpg")
            'Rpt.SetParameterValue("Logo2", My.Application.Info.DirectoryPath.ToString & "\Images\Logo2.jpg")
        End If

        If optReporte.Value = 2 Then
            Me.Cursor = Cursors.WaitCursor
            Dim Rpt As New rptDiagnosticoAdeudoImpuestoPredial
            Me.Tbl_lic_municipalesTableAdapter.Fill(Me.DsPae.tbl_lic_municipales)
            Me.C_LIQ_LICENCIASTableAdapter.Fill(Me.DsPae.C_LIQ_LICENCIAS)
            Rpt.SetDataSource(DsPae)
            Formulario.CrystalReportViewer1.ReportSource = Rpt
            'Rpt.SetParameterValue("Logo1", My.Application.Info.DirectoryPath.ToString & "\Images\Logo1.jpg")
            'Rpt.SetParameterValue("Logo2", My.Application.Info.DirectoryPath.ToString & "\Images\Logo2.jpg")
        End If

        If optReporte.Value = 3 Then  'Documentos para campo
            If optDocAuxCobranza.Value = 1 Then  'carta invitacion sin liquidacion de adeudo
                Me.Cursor = Cursors.WaitCursor
                Dim Rpt As New rptCartaInvitacionSinLiquidacionLicencias
                Me.PAE_ENCABEZADO_LICENCIASTableAdapter.Fill(DsPae.PAE_ENCABEZADO_LICENCIAS)
                Rpt.SetDataSource(DsPae)
                Formulario.CrystalReportViewer1.ReportSource = Rpt
                Rpt.SetParameterValue("Logo1", My.Application.Info.DirectoryPath.ToString & "\Images\Logo1.jpg")
                Rpt.SetParameterValue("Logo2", My.Application.Info.DirectoryPath.ToString & "\Images\Logo2.jpg")
            End If
            If optDocAuxCobranza.Value = 2 Then  'carta invitacion con liquidacion de adeudo
                Me.Cursor = Cursors.WaitCursor
                Dim Rpt As New rptCartaInvitacionConLiquidacionLicencias
                Me.PAE_ENCABEZADO_LICENCIASTableAdapter.Fill(DsPae.PAE_ENCABEZADO_LICENCIAS)
                Rpt.SetDataSource(DsPae)
                Formulario.CrystalReportViewer1.ReportSource = Rpt
                Rpt.SetParameterValue("Logo1", My.Application.Info.DirectoryPath.ToString & "\Images\Logo1.jpg")
                Rpt.SetParameterValue("Logo2", My.Application.Info.DirectoryPath.ToString & "\Images\Logo2.jpg")
            End If

            If optDocAuxCobranza.Value = 3 Then  'Citatorio
                Me.Cursor = Cursors.WaitCursor
                Dim Rpt As New rptCitatorioLicencias
                Me.PAE_ENCABEZADO_LICENCIASTableAdapter.Fill(DsPae.PAE_ENCABEZADO_LICENCIAS)
                Rpt.SetDataSource(DsPae)
                Formulario.CrystalReportViewer1.ReportSource = Rpt
                Rpt.SetParameterValue("Logo1", My.Application.Info.DirectoryPath.ToString & "\Images\Logo1.jpg")
                Rpt.SetParameterValue("Logo2", My.Application.Info.DirectoryPath.ToString & "\Images\Logo2.jpg")
            End If

            If optDocumentospae.Value = 1 Then 'Notificacion de adeudo
                Me.Cursor = Cursors.WaitCursor
                Dim Rpt As New rptNotificacionAdeudoLicencias
                Me.PAE_ENCABEZADO_LICENCIASTableAdapter.Fill(DsPae.PAE_ENCABEZADO_LICENCIAS)
                Me.C_LIQ_LICENCIASTableAdapter.Fill(Me.DsPae.C_LIQ_LICENCIAS)
                Rpt.SetDataSource(DsPae)
                Formulario.CrystalReportViewer1.ReportSource = Rpt
                Rpt.SetParameterValue("Logo1", My.Application.Info.DirectoryPath.ToString & "\Images\Logo1.jpg")
                Rpt.SetParameterValue("Logo2", My.Application.Info.DirectoryPath.ToString & "\Images\Logo2.jpg")
            End If
            If optDocumentospae.Value = 2 Then 'mandamiento ejecucion
                Me.Cursor = Cursors.WaitCursor
                Dim Rpt As New rptMandamientoEjecucionLicencias
                Me.PAE_ENCABEZADO_LICENCIASTableAdapter.Fill(DsPae.PAE_ENCABEZADO_LICENCIAS)
                Me.C_LIQ_LICENCIASTableAdapter.Fill(Me.DsPae.C_LIQ_LICENCIAS)
                Rpt.SetDataSource(DsPae)
                Formulario.CrystalReportViewer1.ReportSource = Rpt
                Rpt.SetParameterValue("Logo1", My.Application.Info.DirectoryPath.ToString & "\Images\Logo1.jpg")
                Rpt.SetParameterValue("Logo2", My.Application.Info.DirectoryPath.ToString & "\Images\Logo2.jpg")
            End If
            If optDocumentospae.Value = 3 Then 'acta de embargo
                Me.Cursor = Cursors.WaitCursor
                Dim Rpt As New rptActaEmbargoLicencias
                Rpt.SetDataSource(DsPae)
                Formulario.CrystalReportViewer1.ReportSource = Rpt
                Rpt.SetParameterValue("Logo1", My.Application.Info.DirectoryPath.ToString & "\Images\Logo1.jpg")
                Rpt.SetParameterValue("Logo2", My.Application.Info.DirectoryPath.ToString & "\Images\Logo2.jpg")
            End If
        End If


        Me.Cursor = Cursors.Default
        With frmReporte
            .Controls.Add(Formulario.CrystalReportViewer1)
            .Text = "Reporte"
            .Show()
        End With
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub optDocAuxCobranza_ValueChanged(sender As Object, e As EventArgs) Handles optDocAuxCobranza.ValueChanged
        If optDocAuxCobranza.Value <> 0 Then
            optDocumentospae.Value = 0
            If optDocAuxCobranza.Value = 3 Then
                gruDatospae.Enabled = True
            Else
                gruDatospae.Enabled = False
            End If
        End If
    End Sub
    Private Sub optDocumentospae_ValueChanged(sender As Object, e As EventArgs) Handles optDocumentospae.ValueChanged
        If optDocumentospae.Value <> 0 Then
            optDocAuxCobranza.Value = 0
            gruDatospae.Enabled = True
        Else
            gruDatospae.Enabled = False
        End If
    End Sub
    Private Sub btnVisualizaCalculo_Click(sender As Object, e As EventArgs) Handles btnVisualizaCalculo.Click
        Dim frm As New Pae_DetalleCalculo_DerechosAgua
        frm.ShowDialog()
    End Sub
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        btnProcesar.Enabled = True
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        GenericCloseChlildForm(Me)
    End Sub
End Class