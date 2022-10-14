Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinTabControl
Imports System.ComponentModel

Public Class frmTarifasPredial
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

    Private Sub frmTarifasPredial_Load(sender As Object, e As EventArgs) Handles Me.Load

        'TODO: esta línea de código carga datos en la tabla 'DsParametros1.tbl_predial' Puede moverla o quitarla según sea necesario.
        If id <> "0" Then
            lblOperacion.Text = "Modifica Tarifa"
            'TODO: esta línea de código carga datos en la tabla 'DsParametros1.tbl1_predial' Puede moverla o quitarla según sea necesario.
            Me.Tbl1_predialTableAdapter.Fill(Me.DsParametros1.tbl1_predial)
            Me.Tbl1predialBindingSource.Position = Me.Tbl1predialBindingSource.Find("id_grupo_imp", id)
            Me.Tbl_predialTableAdapter.FillByKey(Me.DsParametros1.tbl_predial, id)
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
    End Sub

    Private Sub btnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        ErrorProvider1.Clear()
        BindingSource1.CancelEdit()
        lblOperacion.Text = ""

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
            txtFraccion.Text = ""
            txtGrupoMunicipio.Text = ""
            optTipoTributo.Value = 0
            uneAnio.SelectAll()
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim Mainbar As ToolStrip = TryCast(parent.Controls.Find("CommandBar", True).FirstOrDefault(), ToolStrip)
        Mainbar.Enabled = True
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub frmTarifasPredial_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
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
                        Me.BindingSource1.EndEdit()
                        Me.Tbl_predialTableAdapter.Update(Me.DsParametros1.tbl_predial)
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
                        Me.Tbl_predialTableAdapter.Insert(CInt(id), CDec(uneAnio.Value), CDec(uneLimiteInferior.Value), CDec(uneLimiteSuperior.Value) _
                                                      , CDec(0), CDec(0), CDec(0), CDec(0), CDec(uneCuotaMinima.Value), CDec(uneFactor.Value), CDec(0) _
                                                      , CDec(0), "", CDec("0"), "")

                        Me.Tbl_predialTableAdapter.FillByKey(Me.DsParametros1.tbl_predial, id)
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
                    'ya validados los campos se verifica no se duplique las tarifas
                    cxn.Select_SQL("select count(*) from tbl1_predial where año_fiscal= '" & uneAnio.Value.ToString & "' and tip_impuesto='" & optTipoTributo.Value.ToString & "' and fracc_articulo='" & txtFraccion.Text.Trim & "' and gpo_mun='" & txtGrupoMunicipio.Text.Trim & "'")
                    Dim Registros As Integer = cxn.arrayValores(0)

                    If Registros > 0 Then
                        ErrorProvider1.SetError(uneAnio, "Error")
                        cMensajes.DisplayMessage(Me, "Ya existe una tarifa registrada, con los parámetros ingresados!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                        Me.uneAnio.SelectAll()
                        Exit Sub
                    End If


                    Me.Tbl1_predialTableAdapter.Insert(uneAnio.Value, optTipoTributo.Value, txtFraccion.Text, txtGrupoMunicipio.Text)
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

            If uneAnio.Value = Nothing Then
                ErrorProvider1.SetError(uneAnio, "Error")
                ocurriounError += 1
                mensaje += "- " & "El año ingresado es necesario!" & "<br />"
                Me.uneAnio.Focus()
            End If

            If uneAnio.Value < 2000 Or uneAnio.Value > 2050 Then
                ErrorProvider1.SetError(uneAnio, "Error")
                ocurriounError += 1
                mensaje += "- " & "El año ingresado no corresponde al rango permitido" & "<br />"
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

            If optTipoTributo.Value = "" Then
                ErrorProvider1.SetError(optTipoTributo, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo tipo de tributo es requerido." & "<br />"
                Me.optTipoTributo.Focus()
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
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
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

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If MsgBox("¿Seguro de Eliminar el Registro?", vbYesNo, "Confirmación") = vbYes Then
                Me.Validate()
                Me.BindingNavigator2.BindingSource.RemoveCurrent()
                Me.Tbl_predialTableAdapter.Update(Me.DsParametros1.tbl_predial)
                cMensajes.DisplayMessage(Me, "Datos eliminados", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            End If

        Catch ex As Exception
            cMensajes.DisplayMessage(Me, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Private Sub frmTarifasPredial_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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