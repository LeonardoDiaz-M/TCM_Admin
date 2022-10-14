Imports System.ComponentModel

Public Class PaeImpuestoPredial
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
            txtClavecatastral.Visible = False
            panZonaManzanas.Visible = False
            panZonaManCond.Visible = False
            Select Case Editor.Value.ToString
                Case Is = 1 'clave catastral
                    txtClavecatastral.Visible = True
                    txtClavecatastral.Focus()
                Case Is = 2 'zona manzana
                    panZonaManzanas.Visible = True
                    txtZona.Focus()
                Case Is = 3 'Padrón general
                Case Is = 4 'Condominio
                    panZonaManCond.Visible = True
                    txtzmcZona.Focus()
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
                Case Is = 3
                    panDiagMontAdeudo.Visible = True
                    uneDiagMontoAdeudoDel.SelectAll()
                Case Is = 4
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
                BackgroundWorker1.RunWorkerAsync()
                MuestraProgreso()
            End If
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al efectuar el proceso.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)
        If worker.CancellationPending = True Then
            e.Cancel = True
        Else
            System.Threading.Thread.Sleep(10)
            Dim iError As Integer
            Dim Squery As String
            Dim TipoDocumento As String
            If optDocumentospae.Value > 0 Then
                TipoDocumento = IIf(optDocumentospae.Value = 1, "N", IIf(optDocumentospae.Value = 2, "M", "A")) 'Notificación, Mandamiento, Acta de embargo
            Else
                TipoDocumento = IIf(optDocAuxCobranza.Value = 1, "I", IIf(optDocumentospae.Value = 2, "R", "C")) 'Invitación, Requerimeinto, Citatorio
            End If

            'MsgBox(TipoDocumento)
            Squery = "EXEC PAE_Proceso_Predial '" & optSelDatos.Value & "','" & Me.txtClavecatastral.Text & "','" & Me.txtZona.Text & "','" & txtManzanaDe.Text & "','" & Me.txtManzanaAl.Text & "','" & ClavePredio & "','" & TipoDocumento & "','" & txtNombreNotificador.Text & "','" & uneFolioInicial.Value & "','" & txtNumeroCredencial.Text & "'"
            iError = DB.fExecuteScalarIntTimeOut(Squery, 0)
            MessageBox.Show(iError.ToString, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            MessageBox.Show("Proceso Generado Satisfactoriamente.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Sub MuestraProgreso()
        TotalRegistrosACalcular = ClavesACalcular()
        barCalculo.Maximum = TotalRegistrosACalcular
        BackgroundWorker2.RunWorkerAsync()
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
                valor = DB.fExecuteScalarInt("select count(Cve_Catastral) from C_REQ_PRED")
                worker.ReportProgress(valor)
            End While
        End If
    End Sub
    Private Sub backgroundWorker2_ProgressChanged(ByVal sender As System.Object, ByVal e As ProgressChangedEventArgs) Handles BackgroundWorker2.ProgressChanged
        Me.btnProcesar.Enabled = False
        lblMessage.Text = "Total registros calculados: " & e.ProgressPercentage.ToString() & " De:" & TotalRegistrosACalcular
        barCalculo.Value = e.ProgressPercentage
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Dim Formulario As New frmGenerarReporte
        Dim frmReporte As New Form

        If optReporte.Value = 1 Then 'Diagnóstico por contribuyente
            Me.Cursor = Cursors.WaitCursor
            Dim Rpt As New rptDiagnosticoPorContribuyente
            Me.Arc_predialTableAdapter.Fill(Me.DsPae.arc_predial)
            'Me.C_LIQ_PREDTableAdapter.Fill(Me.DsPae.C_LIQ_PRED)
            Rpt.SetDataSource(DsPae)
            Formulario.CrystalReportViewer1.ReportSource = Rpt
            'Rpt.SetParameterValue("Logo1", My.Application.Info.DirectoryPath.ToString & "\Images\Logo1.jpg")
            'Rpt.SetParameterValue("Logo2", My.Application.Info.DirectoryPath.ToString & "\Images\Logo2.jpg")
        End If

        If optReporte.Value = 2 Then
            Me.Cursor = Cursors.WaitCursor
            Dim Rpt As New rptDiagnosticoAdeudoImpuestoPredial
            Me.Arc_predialTableAdapter.Fill(Me.DsPae.arc_predial)
            'Me.C_LIQ_PREDTableAdapter.Fill(Me.DsPae.C_LIQ_PRED)
            Rpt.SetDataSource(DsPae)
            Formulario.CrystalReportViewer1.ReportSource = Rpt
            'Rpt.SetParameterValue("Logo1", My.Application.Info.DirectoryPath.ToString & "\Images\Logo1.jpg")
            'Rpt.SetParameterValue("Logo2", My.Application.Info.DirectoryPath.ToString & "\Images\Logo2.jpg")
        End If

        If optReporte.Value = 4 Then  'Documentos para campo
            If optDocAuxCobranza.Value = 1 Then  'carta invitacion sin liquidacion de adeudo
                Me.Cursor = Cursors.WaitCursor
                Dim Rpt As New rptCartaInvitacionSinLiquidacionPredial
                'Me.Pae_EncabezadoTableAdapter.Fill(DsPae.Pae_Encabezado)
                Rpt.SetDataSource(DsPae)
                Formulario.CrystalReportViewer1.ReportSource = Rpt
                Rpt.SetParameterValue("Logo1", My.Application.Info.DirectoryPath.ToString & "\Images\Logo1.jpg")
                Rpt.SetParameterValue("Logo2", My.Application.Info.DirectoryPath.ToString & "\Images\Logo2.jpg")
            End If
            If optDocAuxCobranza.Value = 2 Then  'carta invitacion con liquidacion de adeudo
                Me.Cursor = Cursors.WaitCursor
                Dim Rpt As New rptCartaInvitacionConLiquidacionPredial
                'Me.Pae_EncabezadoTableAdapter.Fill(DsPae.Pae_Encabezado)
                Rpt.SetDataSource(DsPae)
                Formulario.CrystalReportViewer1.ReportSource = Rpt
                Rpt.SetParameterValue("Logo1", My.Application.Info.DirectoryPath.ToString & "\Images\Logo1.jpg")
                Rpt.SetParameterValue("Logo2", My.Application.Info.DirectoryPath.ToString & "\Images\Logo2.jpg")
            End If
            If optDocAuxCobranza.Value = 3 Then  'Citatorio
                Me.Cursor = Cursors.WaitCursor
                Dim Rpt As New rptCitatorioPredial
                'Me.Pae_EncabezadoTableAdapter.Fill(DsPae.Pae_Encabezado)
                Rpt.SetDataSource(DsPae)
                Formulario.CrystalReportViewer1.ReportSource = Rpt
                Rpt.SetParameterValue("Logo1", My.Application.Info.DirectoryPath.ToString & "\Images\Logo1.jpg")
                Rpt.SetParameterValue("Logo2", My.Application.Info.DirectoryPath.ToString & "\Images\Logo2.jpg")
            End If
            If optDocumentospae.Value = 1 Then 'Notificacion de adeudo
                Me.Cursor = Cursors.WaitCursor
                Dim Rpt As New rptNotificacionAdeudoImpuestoPredial
                'Me.Pae_EncabezadoTableAdapter.Fill(DsPae.Pae_Encabezado)
                'Me.C_LIQ_PREDTableAdapter.Fill(Me.DsPae.C_LIQ_PRED)
                Rpt.SetDataSource(DsPae)
                Formulario.CrystalReportViewer1.ReportSource = Rpt
                Rpt.SetParameterValue("Logo1", My.Application.Info.DirectoryPath.ToString & "\Images\Logo1.jpg")
                Rpt.SetParameterValue("Logo2", My.Application.Info.DirectoryPath.ToString & "\Images\Logo2.jpg")
            End If
            If optDocumentospae.Value = 2 Then 'mandamiento ejecucion
                Me.Cursor = Cursors.WaitCursor
                Dim Rpt As New rptMandamientoEjecucionPredial
                'Me.Pae_EncabezadoTableAdapter.Fill(DsPae.Pae_Encabezado)
                'Me.C_LIQ_PREDTableAdapter.Fill(Me.DsPae.C_LIQ_PRED)
                Rpt.SetDataSource(DsPae)
                Formulario.CrystalReportViewer1.ReportSource = Rpt
                Rpt.SetParameterValue("Logo1", My.Application.Info.DirectoryPath.ToString & "\Images\Logo1.jpg")
                Rpt.SetParameterValue("Logo2", My.Application.Info.DirectoryPath.ToString & "\Images\Logo2.jpg")
            End If
            If optDocumentospae.Value = 3 Then 'acta de embargo
                Me.Cursor = Cursors.WaitCursor
                Dim Rpt As New rptActaEmbargoPredial
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
        Dim Zona As String
        Dim ManzanaDel As String
        Dim ManzanaAl As String

        If optSelDatos.Value = 1 Then
            TotalRegistrosACalcular = 1
        End If
        If optSelDatos.Value = 2 Then
            Zona = txtZona.Text
            ManzanaDel = txtManzanaDe.Text
            ManzanaAl = txtManzanaAl.Text
            TotalRegistrosACalcular = DB.fExecuteScalarInt("select COUNT(cve_catastral) from arc_predial where substring(cve_catastral,4,5) BETWEEN '" & Zona + ManzanaDel & "' AND '" & Zona + ManzanaAl & "' AND ult_año_pag<YEAR(GETDATE())")
        End If
        If optSelDatos.Value = 3 Then
            TotalRegistrosACalcular = DB.fExecuteScalarInt("select COUNT(cve_catastral) from arc_predial where ult_año_pag<YEAR(GETDATE()) ")
        End If
        If optSelDatos.Value = 4 Then
            ClavePredio = txtzmcZona.Text + txtzmcManzana.Text + txtzmcPredio.Text
            TotalRegistrosACalcular = DB.fExecuteScalarInt("select COUNT(cve_catastral) from arc_predial where substring(cve_catastral,4,7) = '" & ClavePredio & "' AND ult_año_pag<YEAR(GETDATE())'")
        End If
        Return TotalRegistrosACalcular
    End Function
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        btnProcesar.Enabled = True
    End Sub

    Private Sub btnVisualizaCalculo_Click(sender As Object, e As EventArgs) Handles btnVisualizaCalculo.Click
        Dim frm As New Pae_DetalleCalculo_Predial
        frm.ShowDialog()
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

            'Seleccion clave catastral
            If optSelDatos.Value = 1 Then
                If Me.txtClavecatastral.Text.Trim.Length > 0 Then
                    If Me.txtClavecatastral.Text.Length = 16 Then
                        cxn.Select_SQL("select cve_catastral from arc_predial where cve_catastral='" & Me.txtClavecatastral.Text.Trim & "'")
                        If cxn.arrayValores(0) Is Nothing Then
                            ErrorProvider1.SetError(txtClavecatastral, "Error")
                            mensaje += "- " & "La clave catastral no existe, verifique." & "<br />"
                            ocurriounError += 1
                            Me.txtClavecatastral.SelectAll()
                        End If
                    Else
                        ErrorProvider1.SetError(txtClavecatastral, "Error")
                        ocurriounError += 1
                        mensaje += "- " & "Clave catastral erronéa, verifique." & "<br />"
                        txtClavecatastral.Focus()
                    End If
                Else
                    ErrorProvider1.SetError(txtClavecatastral, "Error")
                    ocurriounError += 1
                    mensaje += "- " & "Ingrese la clave catastral." & "<br />"
                    txtClavecatastral.Focus()
                End If
            End If
            'Seleccion Zona Manzana
            If optSelDatos.Value = 2 Then
                If Me.txtZona.Text.Trim = "" Then
                    ErrorProvider1.SetError(txtZona, "Error")
                    ocurriounError += 1
                    mensaje += "- " & "El campo zona es requerido." & "<br />"
                    Me.txtZona.Focus()
                End If
                If Me.txtZona.Text.Length <> 2 Or Not IsNumeric(txtZona.Text) Then
                    ErrorProvider1.SetError(txtZona, "Error")
                    ocurriounError += 1
                    mensaje += "- " & "Ingrese la zona en un formato correcto." & "<br />"
                    Me.txtZona.Focus()
                End If
                If Me.txtManzanaDe.Text.Trim = "" Then
                    ErrorProvider1.SetError(txtManzanaDe, "Error")
                    ocurriounError += 1
                    mensaje += "- " & "El campo manzana de requerido." & "<br />"
                    Me.txtManzanaDe.Focus()
                End If
                If Me.txtManzanaDe.Text.Length <> 3 Or Not IsNumeric(txtManzanaDe.Text) Then
                    ErrorProvider1.SetError(txtManzanaDe, "Error")
                    ocurriounError += 1
                    mensaje += "- " & "Ingrese la manzana inicial en un formato correcto." & "<br />"
                    Me.txtManzanaDe.Focus()
                End If
                If Me.txtManzanaAl.Text.Trim = "" Then
                    ErrorProvider1.SetError(txtManzanaAl, "Error")
                    ocurriounError += 1
                    mensaje += "- " & "El campo manzana al es requerido." & "<br />"
                    Me.txtManzanaAl.Focus()
                End If
                If Me.txtManzanaAl.Text.Length <> 3 Or Not IsNumeric(txtManzanaAl.Text) Then
                    ErrorProvider1.SetError(txtManzanaAl, "Error")
                    ocurriounError += 1
                    mensaje += "- " & "Ingrese la manzana final en un formato correcto." & "<br />"
                    Me.txtManzanaAl.Focus()
                End If
            End If

            'Seleccion padron general
            If optSelDatos.Value = 3 Then

            End If
            'Seleccion condominio
            If optSelDatos.Value = 4 Then
                If Me.txtzmcZona.Text.Trim = "" Then
                    ErrorProvider1.SetError(txtzmcZona, "Error")
                    ocurriounError += 1
                    mensaje += "- " & "El campo zona es requerido." & "<br />"
                    Me.txtzmcZona.Focus()
                End If
                If Me.txtzmcZona.Text.Length <> 2 Or Not IsNumeric(txtzmcZona.Text) Then
                    ErrorProvider1.SetError(txtzmcZona, "Error")
                    ocurriounError += 1
                    mensaje += "- " & "Ingrese la zona en un formato correcto." & "<br />"
                    Me.txtzmcZona.Focus()
                End If
                If Me.txtzmcManzana.Text.Trim = "" Then
                    ErrorProvider1.SetError(txtzmcManzana, "Error")
                    ocurriounError += 1
                    mensaje += "- " & "El campo manzana de requerido." & "<br />"
                    Me.txtzmcManzana.Focus()
                End If
                If Me.txtzmcManzana.Text.Length <> 3 Or Not IsNumeric(txtzmcManzana.Text) Then
                    ErrorProvider1.SetError(txtzmcManzana, "Error")
                    ocurriounError += 1
                    mensaje += "- " & "Ingrese la manzana  en un formato correcto." & "<br />"
                    Me.txtzmcManzana.Focus()
                End If
                If Me.txtzmcPredio.Text.Trim = "" Then
                    ErrorProvider1.SetError(txtzmcPredio, "Error")
                    ocurriounError += 1
                    mensaje += "- " & "El campo predio  es requerido." & "<br />"
                    Me.txtzmcPredio.Focus()
                End If
                If Me.txtzmcPredio.Text.Length <> 2 Or Not IsNumeric(txtzmcPredio.Text) Then
                    ErrorProvider1.SetError(txtzmcPredio, "Error")
                    ocurriounError += 1
                    mensaje += "- " & "Ingrese el predio  en un formato correcto." & "<br />"
                    Me.txtzmcPredio.Focus()
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
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        GenericCloseChlildForm(Me)
    End Sub

    Private Sub PaeImpuestoPredial_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Dim nextControl As Control

        If e.KeyCode = Keys.Enter Then

            nextControl = GetNextControl(ActiveControl, Not e.Shift)
            If nextControl Is Nothing Then
                nextControl = GetNextControl(Nothing, True)
            End If
            SendKeys.Send("{TAB}")
            e.SuppressKeyPress = True
        End If
    End Sub
End Class