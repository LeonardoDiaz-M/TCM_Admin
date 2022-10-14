Imports System.ComponentModel
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinTabControl
Public Class frmTarifaAgua

    Public id As String = "0"
    Public Lectura As String = "0"
    Public Insertar As String = "0"
    Public Borrar As String = "0"
    Public Editar As String = "0"

    Public delete_record As Boolean = False
    Public tipo_Permiso As Integer = 0
    Public idUsuario As String = My.User.Name
    Private cxn As New cxnData
    Private newrow As Object
    Public parent As Form = Nothing
    Private currentmenu As String = ""
    Private Sub frmTarifaAgua_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'TODO: esta línea de código carga datos en la tabla 'DsParametros1.tbl_predial' Puede moverla o quitarla según sea necesario.
            If id <> "0" Then
                lblOperacion.Text = "Modifica Tarifa"
                'TODO: esta línea de código carga datos en la tabla 'DsParametros.tbl1_tarifas_agua' Puede moverla o quitarla según sea necesario.
                Me.Tbl1_tarifas_aguaTableAdapter.Fill(Me.DsParametros1.tbl1_tarifas_agua)
                Me.Tbl1tarifasaguaBindingSource2.Position = Me.Tbl1tarifasaguaBindingSource2.Find("id_grupo_agua", id)
                'TODO: esta línea de código carga datos en la tabla 'DsParametros.tbl_tarifas_agua' Puede moverla o quitarla según sea necesario.
                Me.Tbl_tarifas_aguaTableAdapter.FillByKey(Me.DsParametros1.tbl_tarifas_agua, id)
                Valida_Usuario_Servicio()
                uneAnio.ReadOnly = True
                Me.grpdata.Visible = True
                If griDatatable.RowCount > 0 Then
                    btnEditar.Visible = True
                    btnEliminar.Visible = True
                Else
                    btnEditar.Visible = False
                    btnEliminar.Visible = False
                End If
                btnNuevo.Visible = True
            Else
                uneAnio.Value = Nothing
                lblOperacion.Text = "Alta Concepto Tarifa"
                txtFraccion.Text = ""
                txtGrupoMunicipio.Text = ""
                uneAnio.Value = Nothing
                grpdata.Enabled = True
                Me.grpdata.Visible = True
                Me.grpRangos.Visible = False
                Me.griDatatable.Visible = False
                btnEditar.Visible = False
                btnGuardar.Visible = True
                btnNuevo.Visible = False
                uneAnio.ReadOnly = False
                uneAnio.Focus()
            End If
        Catch ex As Exception
            cMensajes.DisplayMessage(Me, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try

    End Sub

    Private Sub btnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        ErrorProvider1.Clear()
        TbltarifasaguaBindingSource1.CancelEdit()
        If id <> "0" Then
            btnEliminar.Visible = True
            btnGuardar.Visible = False
            btnEditar.Visible = True
            grpdata.Enabled = False
        Else
            btnEliminar.Visible = False
            btnGuardar.Visible = True
            btnEditar.Visible = False
            grpdata.Enabled = True
            uneAnio.Value = Nothing
            txtDescripcionTarifa.Text = ""
            txtFraccion.Text = ""
            txtGrupoMunicipio.Text = ""
            optTipoServicio.Value = 0
            optUsuario.Value = 0
            uneAnio.SelectAll()
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim Mainbar As ToolStrip = TryCast(parent.Controls.Find("CommandBar", True).FirstOrDefault(), ToolStrip)
        Mainbar.Enabled = True
        Me.Close()
        Me.Dispose()
    End Sub
    Private Sub frmTarifaAgua_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim Maintab As UltraTabControl = TryCast(parent.Controls.Find("tabPrincipal", True).FirstOrDefault(), UltraTabControl)
        Maintab.Visible = True
        Dim Mainbar As ToolStrip = TryCast(parent.Controls.Find("CommandBar", True).FirstOrDefault(), ToolStrip)
        Mainbar.Visible = True
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If id <> "0" Then
                If lblOperacion.Text = "Modifica Rango Tarifa" Then
                    If valida_datos_Alta_Rango_Tarifa() = False Then
                        Me.Validate()
                        Me.TbltarifasaguaBindingSource1.EndEdit()
                        Me.Tbl_tarifas_aguaTableAdapter.Update(Me.DsParametros1.tbl_tarifas_agua)
                        Me.grpdata.Enabled = False
                        Me.griDatatable.Enabled = True
                        Me.grpRangos.Enabled = False
                        Me.btnGuardar.Visible = False
                        Me.btnEditar.Visible = True
                        Me.btnEliminar.Visible = True
                        cMensajes.DisplayMessage(Me, "Datos actualizados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    End If
                End If

                If lblOperacion.Text = "Alta Rango Tarifa" Then
                    If valida_datos_Alta_Rango_Tarifa() = False Then
                        Dim diametrotoma As Integer = 0
                        Dim TipoInmueble As Integer = 0

                        If Me.optUsuario.Value = 1 And Me.optTipoServicio.Value = 2 Then
                            diametrotoma = vbNull
                            TipoInmueble = ucoTipoInmueble.Value
                        End If
                        'Tipo de usuario comercial = 2 & tipo de servicio cuota fija = 2
                        If Me.optUsuario.Value = 2 And optTipoServicio.Value = 2 Then
                            diametrotoma = ucoDiametroToma.Value
                            TipoInmueble = vbNull
                        End If

                        If optTipoServicio.Value = 1 Then
                            diametrotoma = vbNull
                            TipoInmueble = vbNull
                        End If


                        Me.Tbl_tarifas_aguaTableAdapter.Insert(id, TipoInmueble, diametrotoma, CDec(uneLimiteInferior.Value), CDec(uneLimiteSuperior.Value), CDec(uneCuotaMinima.Value), CDec(uneFactor.Value))
                        Me.Tbl_tarifas_aguaTableAdapter.FillByKey(Me.DsParametros1.tbl_tarifas_agua, id)
                        Me.grpdata.Enabled = False
                        Me.grpRangos.Enabled = False
                        Me.griDatatable.Enabled = True
                        Me.btnGuardar.Visible = False
                        Me.btnEditar.Visible = True
                        Me.btnEliminar.Visible = True
                        cMensajes.DisplayMessage(Me, "Datos Registrados ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    End If
                End If
            Else
                If valida_datos_Alta_Concepto_Tarifa() = False Then
                    Me.Tbl1_tarifas_aguaTableAdapter.Insert(uneAnio.Value, optUsuario.Value, optTipoServicio.Value, txtFraccion.Text, txtGrupoMunicipio.Text, txtDescripcionTarifa.Text, optFormaPago.Value)
                    Me.btnGuardar.Visible = False
                    Me.btnEditar.Visible = True
                    Me.btnEliminar.Visible = False
                    Me.grpRangos.Enabled = False
                    cMensajes.DisplayMessage(Me, "Datos Registrados ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)

                    Dim Mainbar As ToolStrip = TryCast(parent.Controls.Find("CommandBar", True).FirstOrDefault(), ToolStrip)
                    Mainbar.Enabled = True
                    Me.Close()
                    Me.Dispose()
                End If
            End If

        Catch ex As Exception
            cMensajes.DisplayMessage(Me, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
    End Sub
    Private Function valida_datos_Alta_Rango_Tarifa() As Boolean
        Dim ban As Boolean = False
        Dim ocurriounError As Integer = 0
        Dim mensaje As String = ""
        Try
            ErrorProvider1.Clear()

            If uneLimiteSuperior.Value <= uneLimiteInferior.Value Then
                ErrorProvider1.SetError(uneLimiteSuperior, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo limites superior no puede ser menor al limite inferior." & "<br />"
                Me.uneLimiteSuperior.Focus()
            End If

            If uneCuotaMinima.Value <= 0 Then
                ErrorProvider1.SetError(uneCuotaMinima, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo cuota mínima no puede ser igual a cero." & "<br />"
                Me.uneCuotaMinima.Focus()
            End If

            If uneFactor.Value <= 0 Then
                ErrorProvider1.SetError(uneFactor, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo factor no puede ser igual a cero." & "<br />"
                Me.uneFactor.Focus()
            End If

            If Me.optUsuario.Value = 1 And Me.optTipoServicio.Value = 2 Then
                If ucoTipoInmueble.IsItemInList = False Then
                    ErrorProvider1.SetError(ucoTipoInmueble, "Error")
                    ocurriounError += 1
                    mensaje += "- " & "El campo tipo de inmueble es requerido" & "<br />"
                    Me.ucoTipoInmueble.Focus()
                End If
            End If
            'Tipo de usuario comercial = 2 & tipo de servicio cuota fija = 2
            If Me.optUsuario.Value = 2 And optTipoServicio.Value = 2 Then
                If ucoDiametroToma.IsItemInList = False Then
                    ErrorProvider1.SetError(ucoDiametroToma, "Error")
                    ocurriounError += 1
                    mensaje += "- " & "El campo diametro toma es requerido" & "<br />"
                    Me.ucoDiametroToma.Focus()
                End If
            End If

            If ocurriounError > 0 Then
                ban = True
                cMensajes.DisplayMessage(Me, mensaje, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Else
                ban = False
            End If


        Catch ex As Exception
            cMensajes.DisplayMessage(Me, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
        Return ban
    End Function
    Private Function valida_datos_Alta_Concepto_Tarifa() As Boolean
        Dim ban As Boolean = False
        Dim ocurriounError As Integer = 0
        Dim mensaje As String = ""
        Try
            ErrorProvider1.Clear()

            If uneAnio.Value < 2000 Or uneAnio.Value > 2050 Then
                ErrorProvider1.SetError(uneAnio, "Error")
                ocurriounError += 1
                mensaje += "- " & "El año es requerido" & "<br />"
                Me.uneAnio.Focus()
            End If

            If txtFraccion.Text.Trim = "" Then
                ErrorProvider1.SetError(txtFraccion, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo fracción es necesario!" & "<br />"
                Me.txtFraccion.Focus()
            End If

            If txtGrupoMunicipio.Text.Trim = "" Then
                ErrorProvider1.SetError(txtGrupoMunicipio, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo grupo municipio es requerido" & "<br />"
                Me.txtGrupoMunicipio.Focus()
            End If

            If optTipoServicio.Value = "" Then
                ErrorProvider1.SetError(grpServicio, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo tipo de servicio es requerido." & "<br />"
                Me.optTipoServicio.Focus()
            End If

            If optUsuario.Value = "" Then
                ErrorProvider1.SetError(grpTipoUsuario, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo tipo de usuario es requerido." & "<br />"
                Me.optUsuario.Focus()
            End If

            If optFormaPago.Value = "" Then
                ErrorProvider1.SetError(grpFormaPago, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo forma de pago es requerido." & "<br />"
                Me.optFormaPago.Focus()
            End If

            If txtDescripcionTarifa.Text.Trim = "" Then
                ErrorProvider1.SetError(txtDescripcionTarifa, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo descripción es necesario!" & "<br />"
                Me.txtDescripcionTarifa.Focus()
            End If

            If ocurriounError > 0 Then
                ban = True
                cMensajes.DisplayMessage(Me, mensaje, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Else
                ban = False
            End If


        Catch ex As Exception
            cMensajes.DisplayMessage(Me, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
        Return ban
    End Function
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        lblOperacion.Text = "Modifica Rango Tarifa"
        grpRangos.Enabled = True
        griDatatable.Enabled = True
        btnEditar.Visible = False
        btnGuardar.Visible = True
        btnEliminar.Visible = False
        uneLimiteInferior.SelectAll()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        grpRangos.Visible = True
        lblOperacion.Text = "Alta Rango Tarifa"
        Me.btnGuardar.Visible = True
        Me.btnEditar.Visible = False
        Me.btnEliminar.Visible = False
        grpdata.Enabled = False
        grpRangos.Enabled = True
        uneLimiteInferior.Value = 0
        uneLimiteSuperior.Value = 0
        uneCuotaMinima.Value = 0
        uneFactor.Value = 0
        uneLimiteInferior.SelectAll()
    End Sub
    Private Sub optUsuario_ValueChanged(sender As Object, e As EventArgs) Handles optUsuario.ValueChanged
        Valida_Usuario_Servicio()
    End Sub

    Private Sub optTipoServicio_ValueChanged(sender As Object, e As EventArgs) Handles optTipoServicio.ValueChanged
        Valida_Usuario_Servicio()
    End Sub
    Private Sub Valida_Usuario_Servicio()
        'tipo de usuario domestico = 1 & tipo de servicio cuota fija = 2
        If Me.optUsuario.Value = 1 And Me.optTipoServicio.Value = 2 Then
            cxn.fLlenaDropDownUltra(ucoTipoInmueble, "SELECT clave,nombre from tipo_inmueble")
            'TODO: esta línea de código carga datos en la tabla 'DsParametros1.tipo_inmueble' Puede moverla o quitarla según sea necesario.
            Me.Tipo_inmuebleTableAdapter.Fill(Me.DsParametros1.tipo_inmueble)
            ucoDiametroToma.Visible = False
            ucoTipoInmueble.Visible = True
            lblDiametroToma.Visible = False
            lblTipoInmueble.Visible = True
            griDatatable.Columns(1).Visible = True
            griDatatable.Columns(2).Visible = False
        End If
        'Tipo de usuario comercial = 2 & tipo de servicio cuota fija = 2
        If Me.optUsuario.Value = 2 And optTipoServicio.Value = 2 Then
            cxn.fLlenaDropDownUltra(ucoDiametroToma, "SELECT idToma,Diametro from tbl_DiametroToma")
            'TODO: esta línea de código carga datos en la tabla 'DsParametros1.tbl_DiametroToma' Puede moverla o quitarla según sea necesario.
            Me.Tbl_DiametroTomaTableAdapter.Fill(Me.DsParametros1.tbl_DiametroToma)
            ucoDiametroToma.Visible = True
            ucoTipoInmueble.Visible = False
            lblDiametroToma.Visible = True
            lblTipoInmueble.Visible = False
            griDatatable.Columns(1).Visible = False
            griDatatable.Columns(2).Visible = True
        End If

        If optTipoServicio.Value = 1 Then
            ucoDiametroToma.Visible = False
            ucoTipoInmueble.Visible = False
            lblDiametroToma.Visible = False
            lblTipoInmueble.Visible = False
            griDatatable.Columns(1).Visible = False
            griDatatable.Columns(2).Visible = False
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If MsgBox("¿Seguro de Eliminar el Registro?", vbYesNo, "Confirmación") = vbYes Then
                Me.Validate()
                Me.BindingNavigator2.BindingSource.RemoveCurrent()
                Me.Tbl_tarifas_aguaTableAdapter.Update(Me.DsParametros1.tbl_tarifas_agua)
                cMensajes.DisplayMessage(Me, "Datos eliminados", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            End If

        Catch ex As Exception
            cMensajes.DisplayMessage(Me, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Private Sub frmTarifaAgua_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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

    Private Sub frmTarifaAgua_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        uneAnio.SelectAll()
    End Sub
End Class