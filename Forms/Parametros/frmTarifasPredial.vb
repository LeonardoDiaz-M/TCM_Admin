Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinTabControl
Imports System.ComponentModel

Public Class frmTarifasPredial
    Public id As String = "0"
    Public Lectura As Boolean = False
    Public Insertar As Boolean = False
    Public Borrar As Boolean = False
    Public Editar As Boolean = False
    Public idUsuario As String = CurrentUsrName
    Public myparent As Form = Nothing
    Private cxn As New cxnData

    Private Sub frmTarifasPredial_Load(sender As Object, e As EventArgs) Handles Me.Load
        TabOrderSequence(Me, SMcMaster.TabOrderManager.TabScheme.AcrossFirst)
        If id <> "0" Then
            Me.Tbl_predialTableAdapter.Fill(Me.DsParametros.tbl_predial)
            Me.BindingSource.Position = Me.BindingSource.Find("id_tarifa_predial", id)
        End If
        load_Permiso()
    End Sub
    Private Sub load_Permiso()
        Me.btnElimina.Visible = False
        Me.btnNuevo.Visible = Insertar
        Me.btnGuardar.Visible = IIf(id = "0", Insertar, False)
        Me.btnEditar.Visible = IIf(id = "0", False, Editar)

        If id <> "0" Then
            lblOperacion.Text = "Modifica Tarifa"
            Me.Tbl_predialTableAdapter.Fill(Me.DsParametros.tbl_predial)
            Me.BindingSource.Position = Me.BindingSource.Find("id_tarifa_predial", id)
            uneAnio.ReadOnly = True
            Me.grpdata.Visible = True
            btnNuevo.Visible = Insertar
        Else
            uneAnio.Value = Nothing
            lblOperacion.Text = "Alta Concepto Tarifa"
            txtFraccion.Text = ""
            uneAnio.Value = Nothing
            grpdata.Enabled = True
            Me.grpdata.Visible = True
            btnEditar.Visible = False
            btnGuardar.Visible = Editar
            btnNuevo.Visible = False
            uneAnio.ReadOnly = False
            uneAnio.Focus()
        End If
    End Sub

    Private Sub btnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        ErrorProvider1.Clear()
        BindingSource.CancelEdit()
        lblOperacion.Text = ""

        If id <> "0" Then
            btnElimina.Visible = True
            btnGuardar.Visible = False
            btnEditar.Visible = True
            grpdata.Enabled = True
        Else
            btnElimina.Visible = False
            btnGuardar.Visible = True
            btnEditar.Visible = False
            grpdata.Enabled = True
            uneAnio.Value = Nothing
            txtFraccion.Text = ""
            optTipoTributo.Value = 0
            uneAnio.SelectAll()
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        GenericCloseChlildForm(Me)
    End Sub

    Private Sub frmTarifasPredial_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        GenericCloseChlildForm(Me)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If id <> "0" Then
                If lblOperacion.Text = "Modifica Rango Tarifa" Then
                    If valida_datos_Alta_Rango_Tarifa() = False Then
                        Me.Validate()
                        Me.BindingSource.EndEdit()
                        Me.Tbl_predialTableAdapter.Update(Me.DsParametros.tbl_predial)
                        Me.grpdata.Enabled = False
                        Me.btnGuardar.Visible = False
                        Me.btnEditar.Visible = True
                        Me.btnElimina.Visible = True
                        cMensajes.DisplayMessage(Me, "Datos actualizados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    End If
                End If

                If lblOperacion.Text = "Alta Rango Tarifa" Then
                    If valida_datos_Alta_Rango_Tarifa() = False Then
                        Me.Tbl_predialTableAdapter.Insert(CDec(uneAnio.Value), CDec(uneLimiteInferior.Value), CDec(uneLimiteSuperior.Value), CDec(uneCuotaMinima.Value), CDec(uneFactor.Value), "", "")

                        'Me.Tbl_predialTableAdapter.FillByKey(Me.DsParametros.tbl_predial, id)
                        Me.grpdata.Enabled = False
                        Me.btnGuardar.Visible = False
                        Me.btnEditar.Visible = True
                        Me.btnElimina.Visible = True
                        cMensajes.DisplayMessage(Me, "Datos Registrados ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    End If
                End If
            Else
                If valida_datos_Alta_Concepto_Tarifa() = False Then
                    'ya validados los campos se verifica no se duplique las tarifas
                    Dim Registros As Integer = cxn.arrayValores(0)

                    If Registros > 0 Then
                        ErrorProvider1.SetError(uneAnio, "Error")
                        cMensajes.DisplayMessage(Me, "Ya existe una tarifa registrada, con los parámetros ingresados!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                        Me.uneAnio.SelectAll()
                        Exit Sub
                    End If


                    'Me.Tbl_predialTableAdapter.Insert(uneAnio.Value, optTipoTributo.Value, txtFraccion.Text, txtGrupoMunicipio.Text)
                    Me.btnGuardar.Visible = False
                    Me.btnEditar.Visible = True
                    Me.btnElimina.Visible = False
                    cMensajes.DisplayMessage(Me, "Datos Registrados ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)

                    Dim Mainbar As ToolStrip = TryCast(myparent.Controls.Find("CommandBar", True).FirstOrDefault(), ToolStrip)
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

            If uneAnio.Value < 2015 Or uneAnio.Value > 2050 Then
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
        btnEditar.Visible = False
        btnGuardar.Visible = True
        btnElimina.Visible = False
        grpdata.Enabled = True
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        lblOperacion.Text = "Alta Rango Tarifa"
        Me.btnGuardar.Visible = True
        Me.btnEditar.Visible = False
        Me.btnElimina.Visible = False
        grpdata.Enabled = False
        uneLimiteInferior.Value = 0
        uneLimiteSuperior.Value = 0
        uneCuotaMinima.Value = 0
        uneFactor.Value = 0
        uneLimiteInferior.SelectAll()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnElimina.Click
        Try
            If MsgBox("¿Seguro de Eliminar el Registro?", vbYesNo, "Confirmación") = vbYes Then
                Me.Validate()
                Me.BindingNavigator.BindingSource.RemoveCurrent()
                Me.Tbl_predialTableAdapter.Update(Me.DsParametros.tbl_predial)
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