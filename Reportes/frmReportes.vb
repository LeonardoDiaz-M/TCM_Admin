Imports CrystalDecisions.Shared
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.CrystalReports.Engine
Imports Infragistics.Win.Touch

Public Class frmReportes
    Private cxn As New cxnData
    Public id As String = "0"
    Public Lectura As String = "0"
    Public Insertar As String = "0"
    Public Borrar As String = "0"
    Public Editar As String = "0"

    Public delete_record As Boolean = False
    Public tipo_Permiso As Integer = 0
    Public idUsuario As String = My.User.Name
    Private newrow As Object
    Public parent As Form = Nothing
    Private Sub frmReportes_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: esta línea de código carga datos en la tabla 'DsReportes.datos_mpio' Puede moverla o quitarla según sea necesario.
        Me.Datos_mpioTableAdapter.Fill(Me.DsReportes.datos_mpio)
        cxn.Select_SQL("SELECT nombre FROM datos_mpio")
        load_Combos()

        If cxn.arrayValores(0) IsNot Nothing Then
            Nombre_Municipio = cxn.arrayValores(0)
        End If

    End Sub
    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Seleccion_Reporte()
        'Imprimir()
    End Sub

    Private Sub Seleccion_Reporte()
        Dim Formulario As New frmGenerarReporte
        Me.Cursor = Cursors.WaitCursor

        If optTipoReporte.Value = 0 Then
            cMensajes.DisplayMessage(Me, "Seleccione un tipo de reporte", vbYes, vbExclamation, vbYes)
            Exit Sub
        End If


        Select Case optTipoReporte.Text
            Case Is = "Diario de Recaudación"
                Dim Rpt As New DiarioDeRecaudacion
                Me.OficinasTableAdapter.FillByOficina(Me.DsReportes.oficinas, "0101")
                Me.View_arc_ingTableAdapter.FillDiarioRecaudacion(Me.DsReportes.view_arc_ing, dtpFechaInicial.Value.ToString("yyyy-MM-dd"), dtpFechaFinal.Value.ToString("yyyy-MM-dd"))
                Rpt.SetDataSource(DsReportes)
                Formulario.CrystalReportViewer1.ReportSource = Rpt
                Rpt.SetParameterValue("Diainicial", dtpFechaInicial.Value.ToString)
                Rpt.SetParameterValue("DiaFinal", dtpFechaFinal.Value.ToString)
                Rpt.SetParameterValue("Oficina", "0101")
                Rpt.SetParameterValue("Municipio", Nombre_Municipio)




            Case Is = "Corte de Caja"
                Dim Rpt As New CorteDeCaja
                Me.OficinasTableAdapter.Fill(Me.DsReportes.oficinas)
                Me.View_arc_tranTableAdapter.FillByRepCorteCaja(Me.DsReportes.view_arc_tran, "0101", dtpFechaInicial.Value.ToString("yyyy-MM-dd"), dtpFechaFinal.Value.ToString("yyyy-MM-dd"))
                Rpt.SetDataSource(DsReportes)
                Formulario.CrystalReportViewer1.ReportSource = Rpt
                Rpt.SetParameterValue("Diainicial", dtpFechaInicial.Value.ToString)
                Rpt.SetParameterValue("DiaFinal", dtpFechaFinal.Value.ToString)
                Rpt.SetParameterValue("Oficina", "0101")
                Rpt.SetParameterValue("Municipio", Nombre_Municipio)

            Case Is = "Listado de Transacciones"
                Dim Rpt As New ListadoDeTransacciones
                Me.OficinasTableAdapter.Fill(Me.DsReportes.oficinas)
                Me.View_arc_tranTableAdapter.FillByRepCorteCaja(Me.DsReportes.view_arc_tran, "0101", dtpFechaInicial.Value.ToString("yyyy-MM-dd"), dtpFechaFinal.Value.ToString("yyyy-MM-dd"))
                Rpt.SetDataSource(DsReportes)
                Formulario.CrystalReportViewer1.ReportSource = Rpt
                Rpt.SetParameterValue("Diainicial", dtpFechaInicial.Value.ToString)
                Rpt.SetParameterValue("DiaFinal", dtpFechaFinal.Value.ToString)
                Rpt.SetParameterValue("Oficina", "0101")
                Rpt.SetParameterValue("Municipio", Nombre_Municipio)

            Case Is = "Recibos Cancelados"
                Dim Rpt As New RecibosCancelados
                Me.OficinasTableAdapter.Fill(Me.DsReportes.oficinas)
                Me.View_arc_tranTableAdapter.FillByRepRecibosCancelados(Me.DsReportes.view_arc_tran, "0101", dtpFechaInicial.Value.ToString("yyyy-MM-dd"), dtpFechaFinal.Value.ToString("yyyy-MM-dd"))
                Rpt.SetDataSource(DsReportes)
                Formulario.CrystalReportViewer1.ReportSource = Rpt
                Rpt.SetParameterValue("Diainicial", dtpFechaInicial.Value.ToString)
                Rpt.SetParameterValue("DiaFinal", dtpFechaFinal.Value.ToString)
                Rpt.SetParameterValue("Oficina", "0101")

            Case Is = "Pagos con Subsidio"
                Dim Rpt As New PagosConSubsidios
                Me.OficinasTableAdapter.Fill(Me.DsReportes.oficinas)
                Me.View_arc_tranTableAdapter.FillByRepPagosConSubsidio(Me.DsReportes.view_arc_tran, dtpFechaInicial.Value.ToString("yyyy-MM-dd"), dtpFechaFinal.Value.ToString("yyyy-MM-dd"))
                Rpt.SetDataSource(DsReportes)
                Formulario.CrystalReportViewer1.ReportSource = Rpt
                Rpt.SetParameterValue("Diainicial", dtpFechaInicial.Value.ToString)
                Rpt.SetParameterValue("DiaFinal", dtpFechaFinal.Value.ToString)
                Rpt.SetParameterValue("Oficina", "0101")
                Rpt.SetParameterValue("Municipio", Nombre_Municipio)

            Case Is = "Recibo / Ingreso"
                If optReciboIngreso.Value = 0 Then
                    cMensajes.DisplayMessage(Me, "Seleccione una opción para el reporte!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    Exit Sub
                End If
                Dim Rpt As New ReciboIngreso
                Me.OficinasTableAdapter.Fill(Me.DsReportes.oficinas)
                Me.View_arc_tranTableAdapter.FillByRepReciboIngreso(Me.DsReportes.view_arc_tran, dtpFechaInicial.Value.ToString("yyyy-MM-dd"), dtpFechaFinal.Value.ToString("yyyy-MM-dd"))
                Rpt.SetDataSource(DsReportes)
                Formulario.CrystalReportViewer1.ReportSource = Rpt
                Rpt.SetParameterValue("Diainicial", dtpFechaInicial.Value.ToString)
                Rpt.SetParameterValue("DiaFinal", dtpFechaFinal.Value.ToString)
                Rpt.SetParameterValue("Municipio", Nombre_Municipio)

            Case Is = "Póliza de Ingreso"

            Case Is = "Arqueo de Caja"
                If ucoCajero.IsItemInList = True Then
                    Dim Rpt As New ArqueoCaja
                    Me.OficinasTableAdapter.Fill(Me.DsReportes.oficinas)
                    Me.View_arc_tranTableAdapter.FillRepArqueoCaja(Me.DsReportes.view_arc_tran, "0101", ucoCajero.Value.ToString, dtpFechaInicial.Value.ToString("yyyy-MM-dd"), dtpFechaFinal.Value.ToString("yyyy-MM-dd"))
                    Rpt.SetDataSource(DsReportes)
                    Formulario.CrystalReportViewer1.ReportSource = Rpt
                    Rpt.SetParameterValue("Diainicial", dtpFechaInicial.Value.ToString)
                    Rpt.SetParameterValue("DiaFinal", dtpFechaFinal.Value.ToString)
                    Rpt.SetParameterValue("Oficina", "0101")
                    Rpt.SetParameterValue("Municipio", Nombre_Municipio)
                Else
                    cMensajes.DisplayMessage(Me, "Seleccione un cajero!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    ucoCajero.Focus()
                End If
            Case Is = "Ingreso por Concepto"
                If ucoConcepto.IsItemInList = True Then
                    Dim Rpt As New IngresoPorConcepto
                    Me.OficinasTableAdapter.Fill(Me.DsReportes.oficinas)
                    Me.View_arc_tranTableAdapter.FillByRepConcepto(Me.DsReportes.view_arc_tran, ucoConcepto.Value, dtpFechaInicial.Value.ToString("yyyy-MM-dd"), dtpFechaFinal.Value.ToString("yyyy-MM-dd"))
                    Rpt.SetDataSource(DsReportes)
                    Formulario.CrystalReportViewer1.ReportSource = Rpt
                    Rpt.SetParameterValue("Diainicial", dtpFechaInicial.Value.ToString)
                    Rpt.SetParameterValue("DiaFinal", dtpFechaFinal.Value.ToString)
                    Rpt.SetParameterValue("Concepto", ucoConcepto.Value)
                    Rpt.SetParameterValue("Municipio", Nombre_Municipio)
                Else
                    cMensajes.DisplayMessage(Me, "Seleccione un concepto!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    ucoConcepto.Focus()
                End If



            Case Is = "Depósito en Bancos"


            Case Is = "Auxiliar de ingreso por folios"
                Dim Rpt As New AuxiliarDeIngresos
                Me.OficinasTableAdapter.Fill(Me.DsReportes.oficinas)
                Me.View_arc_tranTableAdapter.FillByRepIngresosPorPeriodo(Me.DsReportes.view_arc_tran, dtpFechaInicial.Value.ToString("yyyy-MM-dd"), dtpFechaFinal.Value.ToString("yyyy-MM-dd"))
                Rpt.SetDataSource(DsReportes)
                Formulario.CrystalReportViewer1.ReportSource = Rpt
                Rpt.SetParameterValue("Diainicial", dtpFechaInicial.Value.ToString)
                Rpt.SetParameterValue("DiaFinal", dtpFechaFinal.Value.ToString)
                Rpt.SetParameterValue("Municipio", Nombre_Municipio)
                Rpt.SetParameterValue("Municipio", Nombre_Municipio)

            Case Is = "Auxiliar de ingreso por periodo"
                Dim Rpt As New AuxiliarDeIngresosPeriodo
                Me.OficinasTableAdapter.Fill(Me.DsReportes.oficinas)
                Me.View_arc_tranTableAdapter.FillByRepIngresosPorPeriodo(Me.DsReportes.view_arc_tran, dtpFechaInicial.Value.ToString("yyyy-MM-dd"), dtpFechaFinal.Value.ToString("yyyy-MM-dd"))
                Rpt.SetDataSource(DsReportes)
                Formulario.CrystalReportViewer1.ReportSource = Rpt
                Rpt.SetParameterValue("Diainicial", dtpFechaInicial.Value.ToString)
                Rpt.SetParameterValue("DiaFinal", dtpFechaFinal.Value.ToString)
                Rpt.SetParameterValue("Municipio", Nombre_Municipio)
            Case Is = "Agua potable y drenaje"

            Case Is = "Folio por caja"
                Dim Rpt As New FoliosUtilizadosPorCaja
                Me.OficinasTableAdapter.Fill(Me.DsReportes.oficinas)
                Me.View_arc_tranTableAdapter.FillByRepIngresosPorPeriodo(Me.DsReportes.view_arc_tran, dtpFechaInicial.Value.ToString("yyyy-MM-dd"), dtpFechaFinal.Value.ToString("yyyy-MM-dd"))
                Rpt.SetDataSource(DsReportes)
                Formulario.CrystalReportViewer1.ReportSource = Rpt
                Rpt.SetParameterValue("Diainicial", dtpFechaInicial.Value.ToString)
                Rpt.SetParameterValue("DiaFinal", dtpFechaFinal.Value.ToString)
                Rpt.SetParameterValue("Municipio", Nombre_Municipio)
            Case Is = "Concentrado por oficina"
                Dim Rpt As New DiarioDeRecaudacion
                Me.OficinasTableAdapter.FillByOficina(Me.DsReportes.oficinas, "0101")
                Me.View_arc_ingTableAdapter.FillDiarioRecaudacion(Me.DsReportes.view_arc_ing, dtpFechaInicial.Value.ToString("yyyy-MM-dd"), dtpFechaFinal.Value.ToString("yyyy-MM-dd"))
                Rpt.SetDataSource(DsReportes)
                Formulario.CrystalReportViewer1.ReportSource = Rpt
                Rpt.SetParameterValue("Diainicial", dtpFechaInicial.Value.ToString)
                Rpt.SetParameterValue("DiaFinal", dtpFechaFinal.Value.ToString)
                Rpt.SetParameterValue("Oficina", "0101")
                Rpt.SetParameterValue("Municipio", Nombre_Municipio)
            Case Is = "Eficiencia por caja"
            Case Is = "Selección especial de transacciones"
            Case Is = "Ingreso por dependencia"
                Dim Rpt As New IngresoPorDependencia
                Me.View_arc_tranTableAdapter.FillByRepIngresosPorDependencia(Me.DsReportes.view_arc_tran, 1, dtpFechaInicial.Value.ToString("yyyy-MM-dd"), dtpFechaFinal.Value.ToString("yyyy-MM-dd"))
                Rpt.SetDataSource(DsReportes)
                Formulario.CrystalReportViewer1.ReportSource = Rpt
                'Rpt.SetParameterValue("Diainicial", dtpFechaInicial.Value.ToString)
                'Rpt.SetParameterValue("DiaFinal", dtpFechaFinal.Value.ToString)
                'Rpt.SetParameterValue("Municipio", Nombre_Municipio)

            Case Is = "Concentrado por dependencia"
                Dim Rpt As New ConcentradoServiciosPorDependencia
                Dim cxn1 As New cxnData
                Dim dt As DataTable
                dt = cxn1.Get_SQL_Datatable("REPORTE_CONCENTRADO_POR_DEPENDENCIA'" & dtpFechaInicial.Value.ToString("yyyy-MM-dd") & "','" & dtpFechaFinal.Value.ToString("yyyy-MM-dd") & "'")
                Rpt.SetDataSource(dt)
                Formulario.CrystalReportViewer1.ReportSource = Rpt
                Rpt.SetParameterValue("Diainicial", dtpFechaInicial.Value.ToString)
                Rpt.SetParameterValue("DiaFinal", dtpFechaFinal.Value.ToString)
                Rpt.SetParameterValue("Municipio", Nombre_Municipio)

            Case Is = "Movimientos por usuario"
            Case Is = "Informe mensual de caja"

            Case Is = "Facturas mensuales generadas"
                Dim Rpt As New FacturasEmitidas
                Me.FacturasTableAdapter.Fill(Me.DsReportes.facturas, dtpFechaInicial.Value.ToString("yyyy-MM-dd"), dtpFechaFinal.Value.ToString("yyyy-MM-dd"))
                Rpt.SetDataSource(DsReportes)
                Formulario.CrystalReportViewer1.ReportSource = Rpt
                Rpt.SetParameterValue("Diainicial", dtpFechaInicial.Value.ToString)
                Rpt.SetParameterValue("DiaFinal", dtpFechaFinal.Value.ToString)
                Rpt.SetParameterValue("Municipio", Nombre_Municipio)
            Case Is = "Reporte de ingresos de gestión"
            Case Is = "Informe predial OSFEM"
            Case Is = "Informe traslado OSFEM"
                Dim Rpt As New TrasladoDeDominio
                Me.Datos_mpioTableAdapter.Fill(DsReportes.datos_mpio)
                Me.OficinasTableAdapter.Fill(Me.DsReportes.oficinas)
                Me.Arc_tranTableAdapter.FillTrasladoDominio(Me.DsReportes.arc_tran, dtpFechaInicial.Value.ToString("yyyy-MM-dd"), dtpFechaFinal.Value.ToString("yyyy-MM-dd"))
                Rpt.SetDataSource(DsReportes)
                Formulario.CrystalReportViewer1.ReportSource = Rpt
                Rpt.SetParameterValue("Diainicial", dtpFechaInicial.Value.ToString)
                Rpt.SetParameterValue("DiaFinal", dtpFechaFinal.Value.ToString)
                Rpt.SetParameterValue("Municipio", Nombre_Municipio)
        End Select

        Dim frmReporte As New Form
        With frmReporte
            .Controls.Add(Formulario.CrystalReportViewer1)
            .Text = "Reporte"
            .Show()
        End With
        Me.Cursor = Cursors.Default

    End Sub


    Private Sub Imprimir()
        Me.Cursor = Cursors.WaitCursor
        Dim Rpt As New CorteDeCaja
        Dim Formulario As New frmGenerarReporte

        'TODO: esta línea de código carga datos en la tabla 'DsReportes.oficinas' Puede moverla o quitarla según sea necesario.
        Me.OficinasTableAdapter.Fill(Me.DsReportes.oficinas)
        'TODO: esta línea de código carga datos en la tabla 'DsReportes.view_arc_tran' Puede moverla o quitarla según sea necesario.
        'Me.View_arc_tranTableAdapter.FillByRepCorteCaja(Me.DsReportes.view_arc_tran, "0201", "0", dtpFechaInicial.Value.ToString("yyyy-MM-dd"), dtpFechaFinal.Value.ToString("yyyy-MM-dd"))
        Me.View_arc_tranTableAdapter.FillByRepCorteCaja(Me.DsReportes.view_arc_tran, "0201", dtpFechaInicial.Value.ToString("yyyy-MM-dd"), dtpFechaFinal.Value.ToString("yyyy-MM-dd"))
        Rpt.SetDataSource(DsReportes)
        Formulario.CrystalReportViewer1.ReportSource = Rpt
        Rpt.SetParameterValue("Diainicial", dtpFechaInicial.Value.ToString)
        Rpt.SetParameterValue("DiaFinal", dtpFechaFinal.Value.ToString)
        Rpt.SetParameterValue("Oficina", "0201")
        'Rpt.SetParameterValue("Cajero", "0")

        Dim frmReporte As New Form
        With frmReporte
            .Controls.Add(Formulario.CrystalReportViewer1)
            .Text = "Reporte"
            .Show()
        End With
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub load_Combos()
        cxn.fLlenaDropDownUltra(ucoConcepto, "SELECT cve_cuenta,nombre FROM cat_cuentas")
        cxn.fLlenaDropDownUltra(ucoCajero, "select proNumeroCaja,proNombres +' '+ proApellidoPaterno +' '+ proApellidoMaterno as Cajero   from Users_Profiles where proIdPuesto=2")
    End Sub

    Private Sub optTipoReporte_ValueChanged(sender As Object, e As EventArgs) Handles optTipoReporte.ValueChanged
        gruConcepto.Visible = False
        gruCajero.Visible = False
        gruReciboIngreso.Visible = False

        Select Case optTipoReporte.Text
            Case Is = "Arqueo de Caja"
                gruCajero.Visible = True
            Case Is = "Ingreso por Concepto"
                gruConcepto.Visible = True
            Case Is = "Recibo / Ingreso"
                gruReciboIngreso.Visible = True
        End Select
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        Me.Dispose()
    End Sub


End Class
