﻿Imports System.ComponentModel
Imports Infragistics.Win.UltraWinTabControl
Imports System.Text.RegularExpressions
Imports System.Web.Security
Public Class frmDiversion1
    Public id As String = "0"
    Public Lectura As String = "0"
    Public Insertar As String = "0"
    Public Borrar As String = "0"
    Public Editar As String = "0"

    Public delete_record As Boolean = False
    Public tipo_Permiso As Integer = 0
    Private cxn As New cxnData
    Private newrow As Object
    Public parent As Form = Nothing
    Private Sub frmDiversion1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.lblCurrentMenu.Text = Me.Text
            load_Combos()
            If id <> "0" Then
                btnEditar.Visible = True
                btnGuardar.Visible = False
                btnElimina.Visible = True
            Else
                ActivaFormulario(True)
                btnGuardar.Visible = True
                btnEditar.Visible = False
                btnElimina.Visible = False
            End If
            If id <> "0" Then
                Me.Tbl_lic_municipalesTableAdapter.FillByPM(Me.DsLicencias1.tbl_lic_municipales, id)
                'Me.BindingSource1.Position = Me.BindingSource1.Find("cve_licencia", id)
            End If
            LoadRol()
        Catch ex As Exception
            cMensajes.DisplayMessage(Me, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
    End Sub
    Private Sub LoadRol()
        btnEditar.Enabled = Roles.IsUserInRole(Usuario, Editar)
        btnElimina.Enabled = Roles.IsUserInRole(Usuario, Borrar)
        btnGuardar.Enabled = Roles.IsUserInRole(Usuario, Insertar)
    End Sub
    Private Sub load_Permiso()
        Me.btnGuardar.Visible = False
        btnElimina.Visible = False
        Me.txtNoLic.Enabled = False
        Dim cxn_load As New cxnData
        Me.Text = "Detalle de la Licencia  " & id.ToString
        If id <> "0" Then
            cxn_load.Select_SQL("SELECT cve_col,cve_loc,cve_catastral from tbl_lic_municipales where cve_licencia='" & id.ToString & "'")
            Me.txtClavecatastral.Text = cxn_load.arrayValores(2)
            Me.ucoLocalidad.Value = cxn_load.arrayValores(1)
            If cxn_load.arrayValores(1) <> "-1" And cxn_load.arrayValores(1) IsNot Nothing Then
                Me.ucoColonia.Value = cxn.arrayValores(0)
            End If
        End If
        If tipo_Permiso = 0 And Not delete_record Then 'Solo Lectura
            Me.grpDatosCuenta.Enabled = False
            Me.grpPropietario.Enabled = False
            Me.grpPAE.Enabled = False
        ElseIf tipo_Permiso = 1 And delete_record Then 'Eliminar Registro
            Me.grpDatosCuenta.Enabled = False
            Me.grpPropietario.Enabled = False
            Me.grpPAE.Enabled = False
            btnElimina.Visible = True
        ElseIf tipo_Permiso = 1 And id <> "0" Then  'Actualizar Registro
            Me.grpDatosCuenta.Enabled = True
            Me.btnGuardar.Visible = True
        ElseIf tipo_Permiso = 1 And id = "0" Then 'Agregar Registro
            Me.Text = "Nueva Licencia"
            Me.grpDatosCuenta.Enabled = True
            Me.btnGuardar.Visible = True
            Me.BindingNavigator1.BindingSource.AddNew()
            cxn_load.Select_SQL("exec sp_DDL_Derechos 'PM',''")
            Me.BindingSource1.Current("cve_licencia") = cxn_load.arrayValores(0)
            cxn_load.Select_SQL("select getdate(), month(getdate()),year(getdate()) ")
            Me.BindingSource1.Current("ult_año_pago") = cxn_load.arrayValores(2)
            Me.BindingSource1.Current("ult_mes_pago") = cxn_load.arrayValores(1)
            Me.BindingSource1.Current("fecha_ini_oper") = cxn_load.arrayValores(0)
            Me.txtNoLic.Text = cxn.arrayValores(0)
            ucoTipoContribuyente.Value = -1
            ucoStatus.Value = -1
            ucoLocalidad.Value = -1
            ucoPae.Value = -1
            cmbTipoLicencia.SelectedValue = -1
        End If
    End Sub
    Private Sub load_Combos()
        cxn.Get_SQL_Combobox("exec sp_DDL_Derechos 'Diversiones',''", Me.cmbTipoLicencia, "Descripcion", "clave")
        cxn.fLlenaDropDownUltra(ucoStatus, "SELECT cve_status,descripcion from tbl_Status_Contribuyente")
        cxn.fLlenaDropDownUltra(ucoTipoContribuyente, "SELECT cve_tip_con,descricion from tip_contribuyente")
        cxn.fLlenaDropDownUltra(ucoLocalidad, "Select clave, nombre from localidades")
        cxn.fLlenaDropDownUltra(ucoPae, "Select clave, nombre from Pae")
    End Sub
    Private Function valida_datos() As Boolean
        Dim ban As Boolean = False
        Dim ocurriounError As Integer = 0
        Dim mensaje As String = ""
        Try
            ErrorProvider1.Clear()
            'cuenta
            If Me.txtNoLic.Text.Trim.Trim.Length > 0 Then
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
                    mensaje += "- " & "El campo clave catastral es requerido." & "<br />"
                    txtClavecatastral.Focus()
                End If
            Else
                ErrorProvider1.SetError(txtNoLic, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo No. licencia es requerido." & "<br />"
                Me.txtNoLic.Focus()
            End If


            If Me.ucoTipoContribuyente.IsItemInList = False Then
                ErrorProvider1.SetError(ucoTipoContribuyente, "Error")
                ocurriounError += 1
                mensaje += "- " & "Seleccione el tipo de contribuyente." & "<br />"
                Me.ucoTipoContribuyente.Focus()
            End If

            If Me.ucoStatus.IsItemInList = False Then
                ErrorProvider1.SetError(ucoStatus, "Error")
                ocurriounError += 1
                mensaje += "- " & "Seleccione el status del contribuyente." & "<br />"
                ucoStatus.Focus()
            End If

            If Me.cmbTipoLicencia.SelectedValue <= -1 Or cmbTipoLicencia.SelectedValue = Nothing Then
                ErrorProvider1.SetError(cmbTipoLicencia, "Error")
                ocurriounError += 1
                mensaje += "- " & "Seleccione el tipo de licencia." & "<br />"
                Me.cmbTipoLicencia.Focus()
            End If

            If Not IsDate(txtFechaIniOp.Value) Then
                ErrorProvider1.SetError(txtFechaIniOp, "Error")
                ocurriounError += 1
                mensaje += "- " & "Ingrese una fecha válida para el inicio de operaciones." & "<br />"
                Me.txtFechaIniOp.Focus()
            End If

            If uneNumeroMaquinas.Value <= 0 Then
                ErrorProvider1.SetError(uneNumeroMaquinas, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo numero de máquinas es requerido." & "<br />"
                Me.uneNumeroMaquinas.Focus()
            End If

            'datos del propietario
            If Me.txtNombre.Text.Trim = "" Then
                ErrorProvider1.SetError(txtNombre, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo nombre o razón social es requerido." & "<br />"
                Me.txtNombre.Focus()
            End If
            If Me.txtDomicilio.Text.Trim.Trim = "" Then
                ErrorProvider1.SetError(txtDomicilio, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo domicilio fiscal es requerido." & "<br />"
                Me.txtDomicilio.Focus()
            End If

            If Me.ucoLocalidad.IsItemInList = False Then
                ErrorProvider1.SetError(ucoLocalidad, "Error")
                ocurriounError += 1
                mensaje += "- " & "Seleccione la localidad." & "<br />"
                Me.ucoLocalidad.Focus()
            End If

            If Me.ucoColonia.IsItemInList = False Then
                ErrorProvider1.SetError(ucoColonia, "Error")
                ocurriounError += 1
                mensaje += "- " & "Seleccione la colonia." & "<br />"
                Me.ucoColonia.Focus()
            End If

            If txtRfc.Text <> String.Empty Then
                If Regex.IsMatch(txtRfc.Text.Trim, "^([A-ZÑ\x26]{3,4}([0-9]{2})(0[1-9]|1[0-2])(0[1-9]|1[0-9]|2[0-9]|3[0-1])([A-Z]|[0-9]){2}([A]|[0-9]){1})?$") = False Then
                    ErrorProvider1.SetError(txtRfc, "Error")
                    ocurriounError += 1
                    mensaje += "- " & "Ingrese el RFC en un formato válido." & "<br />"
                    txtRfc.Focus()
                End If
            End If

            If txtCurp.Text <> String.Empty Then
                If Regex.IsMatch(txtCurp.Text.Trim, "[A-Z][A,E,I,O,U,X][A-Z]{2}[0-9]{2}[0-1][0-9][0-3][0-9][M|H](AS|BC|BS|CC|CL|CM|CS|CH|DF|DG|GT|GR|HG|JC|MC|MN|MS|NT|NL|OC|PL|QT|QR|SP|SL|SR|TC|TS|TL|VZ|YN|ZS|NE)[B,C,D,F,G,H,J,K,L,M,N,Ñ,P,Q,R,S,T,V,W,X,Y,Z]{3}[0-9,A-Z][0-9]$") = False Then
                    ErrorProvider1.SetError(txtCurp, "Error")
                    ocurriounError += 1
                    mensaje += "- " & "Ingrese la curp en un formato válido." & "<br />"
                    txtCurp.Focus()
                End If
            End If

            If Me.txtResponsable.Text.Trim = "" Then
                ErrorProvider1.SetError(txtResponsable, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo responsable es requerido." & "<br />"
                Me.txtResponsable.Focus()
            End If

            If txtemail.Text <> String.Empty Then
                If IsValidEmail(txtemail.Text) = False Then
                    ErrorProvider1.SetError(txtemail, "Error")
                    ocurriounError += 1
                    mensaje += "- " & "Es necesario capturar el correo electrónico en un formato válido." & "<br />"
                    txtemail.SelectAll()
                    txtemail.Focus()
                End If
            End If

            If Me.txtNoExt.Text.Trim = "" Then
                ErrorProvider1.SetError(txtNoExt, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo número exterior es requerido." & "<br />"
                Me.txtNoExt.Focus()
            End If

            If Len(Me.uneUltAnio.Text.Trim) = 4 Then
                If Year(Now()) < Me.uneUltAnio.Value Then
                    ErrorProvider1.SetError(uneUltAnio, "Error")
                    ocurriounError += 1
                    mensaje += "- " & "El año de pago no puede ser mayor al año actual, verifique." & "<br />"
                    Me.uneUltAnio.SelectAll()
                    Me.uneUltAnio.Focus()
                End If
            Else
                ErrorProvider1.SetError(uneUltAnio, "Error")
                ocurriounError += 1
                mensaje += "- " & "El año de pago es incorrecto, verifique." & "<br />"
                Me.uneUltAnio.SelectAll()
                Me.uneUltAnio.Focus()
            End If


            If Me.mskUltMes.Text.Trim.Length > 0 Then
                If Me.mskUltMes.Text <= 0 Or mskUltMes.Text >= 13 Then
                    ErrorProvider1.SetError(mskUltMes, "Error")
                    ocurriounError += 1
                    mensaje += "- " & "El mes de último pago es incorrecto." & "<br />"
                    Me.mskUltMes.SelectAll()
                    Me.mskUltMes.Focus()
                End If
            Else
                ErrorProvider1.SetError(mskUltMes, "Error")
                ocurriounError += 1
                mensaje += "- " & "El mes de último pago es incorrecto." & "<br />"
                Me.mskUltMes.SelectAll()
                Me.mskUltMes.Focus()
            End If

            'valida el PAE
            If chkNotificado.Checked = True Then
                If ucoPae.IsItemInList = False Then
                    ErrorProvider1.SetError(ucoPae, "Error")
                    ocurriounError += 1
                    mensaje += "- " & "El campo etapa es requerido." & "<br />"
                    Me.ucoPae.Focus()
                End If

                If txtNoOficioPae.Text.Trim = "" Then
                    ErrorProvider1.SetError(txtNoOficioPae, "Error")
                    ocurriounError += 1
                    mensaje += "- " & "El campo oficio número es requerido." & "<br />"
                    Me.txtNoOficioPae.Focus()
                End If

                If Not IsDate(txtFecPAE.Value) Then
                    ErrorProvider1.SetError(txtFecPAE, "Error")
                    ocurriounError += 1
                    mensaje += "- " & "El campo fecha actos es requerido." & "<br />"
                    Me.txtFecPAE.Focus()
                End If

                If IsDBNull(txtNoActos.Value) Then
                    ErrorProvider1.SetError(txtNoActos, "Error")
                    ocurriounError += 1
                    mensaje += "- " & "El campo número de acto es requerido." & "<br />"
                    Me.txtNoActos.Focus()
                End If

                If Not IsDBNull(txtNoActos.Value) Then
                    If txtNoActos.Value = 0 Then
                        ErrorProvider1.SetError(txtNoActos, "Error")
                        ocurriounError += 1
                        mensaje += "- " & "El campo número de actos es requerido." & "<br />"
                        Me.txtNoActos.Focus()
                    End If
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
    Private Sub btnElimina_Click(sender As Object, e As EventArgs) Handles btnElimina.Click
        Try
            If MsgBox("¿Seguro de Eliminar el Registro?", vbYesNo, "Confirmación") = vbYes Then
                Me.Validate()
                Me.BindingNavigator1.BindingSource.RemoveCurrent()
                Me.Tbl_lic_municipalesTableAdapter.Update(Me.DsLicencias1.tbl_lic_municipales)
                cMensajes.DisplayMessage(Me, "Datos eliminados correctamente!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                MsgBox("Registro eliminado", MsgBoxStyle.Information, "Licencias")
                Me.Close()
            End If

        Catch ex As Exception
            cMensajes.DisplayMessage(Me, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
    End Sub
    Private Sub btnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        BindingSource1.CancelEdit()
        ActivaFormulario(False)
        btnEditar.Visible = True
        btnGuardar.Visible = False
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If valida_datos() Then

                If id <> "0" Then
                    Me.Validate()
                    Me.BindingSource1.Current("ult_mes_pago") = CDec(Me.mskUltMes.Text)
                    Me.BindingSource1.EndEdit()
                    Me.Tbl_lic_municipalesTableAdapter.Update(Me.DsLicencias1.tbl_lic_municipales)
                    ActivaFormulario(False)
                    cMensajes.DisplayMessage(Me, "Datos modificados correctamente!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Else
                    Dim fec_alta As DateTime
                    cxn.Select_SQL("select getdate(),DATEADD(YEAR,-100,GETDATE())")
                    fec_alta = cxn.arrayValores(0)
                    cxn.Select_SQL("exec sp_DDL_Derechos 'PM',''")
                    Me.txtNoLic.Text = cxn.arrayValores(0)
                    Tbl_lic_municipalesTableAdapter.Insert(Me.txtNoLic.Text,
                                                           Me.cmbTipoLicencia.SelectedValue, 'tip_der
                                                           Me.txtRfc.Text.Trim.ToUpperInvariant,
                                                           Me.txtNombre.Text.Trim.ToUpperInvariant,
                                                           Me.txtResponsable.Text.Trim.ToUpperInvariant,
                                                           Me.txtDomicilio.Text.Trim.ToUpperInvariant,
                                                           Me.txtNoInt.Text.ToUpperInvariant.Trim,
                                                           Me.txtNoExt.Text.ToUpperInvariant.Trim,
                                                           Me.ucoColonia.Value,
                                                           Me.ucoLocalidad.Value,
                                                           Me.txtCP.Text.Trim.ToUpperInvariant,
                                                           "", 'telefono
                                                           Me.txtDomicilio.Text.Trim.ToUpperInvariant,
                                                           Me.txtClavecatastral.Text.ToUpperInvariant.Trim,
                                                           "0",
                                                           CDec(Me.ucoTipoContribuyente.Value),
                                                           "0",'Horario Inicia Lunes a Vierne
                                                           "0",'Horario Termina Lunes a Vierne
                                                           "0",'Horario Inicia Sabado
                                                           "0",'Horario Termina Sábado
                                                           "0",'Horario Inicia Domingo
                                                           "0",'Horario Termina Domingo
                                                           CDec(Me.uneUltAnio.Value),'Ultimo Pago
                                                           CDec(Me.mskUltMes.Text), ' ultimo mes pago
                                                           Nothing,'Tipo Anuncio
                                                           CDec(Me.uneNumeroMaquinas.Value),
                                                           0,'largo
                                                           0,'ancho                                                           
                                                            Me.chkNotificado.Checked,
                                                            IIf(Me.chkNotificado.Checked = True, Me.txtNoOficioPae.Text, Nothing),'numero oficio pae,
                                                            IIf(Me.chkNotificado.Checked = True, Me.txtFecPAE.Value, Nothing),'fec notif
                                                           "",'folio rec 
                                                           CDec(Me.ucoStatus.Value),'status
                                                           fec_alta,'fec alta
                                                           Nothing,'fec pago ,
                                                           CDate(Me.txtFechaIniOp.Value),'fec ini operfec_alta,
                                                           Me.txtObservaciones.Text.Trim,
                                                           CDate(Me.txtFechaIniOp.Value).ToShortDateString,'Fecha_ini _operacion
                                                            IIf(Me.chkNotificado.Checked = True, Me.ucoPae.Value, Nothing),
                                                            IIf(Me.chkNotificado.Checked = True, Me.txtNoActos.Value, Nothing),
                                                            Me.txtCurp.Text,
                                                           Me.txtemail.Text,
                                                            My.User.Name, "", ""
                                                           )
                    Me.Tbl_lic_municipalesTableAdapter.Update(Me.DsLicencias1.tbl_lic_municipales)
                    cMensajes.DisplayMessage(Me, "Datos registrados correctamente!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    id = Me.txtNoLic.Text
                    tipo_Permiso = 1
                    Me.frmDiversion1_Load(Nothing, Nothing)
                End If
            End If
        Catch ex As Exception
            cMensajes.DisplayMessage(Me, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
    End Sub
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            'valida permiso de edicion
            ActivaFormulario(True)
            btnGuardar.Visible = True
            btnEditar.Visible = False
            txtClavecatastral.Focus()
        Catch ex As Exception
            cMensajes.DisplayMessage(Me, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
    End Sub
    Private Sub ucoLocalidad_ValueChanged(sender As Object, e As EventArgs) Handles ucoLocalidad.ValueChanged
        Try
            If Me.ucoLocalidad.Value IsNot Nothing Then
                cxn.fLlenaDropDownUltra(ucoColonia, "SELECT id_colonia,nom_colonia from colonias where cve_loc='" & Me.ucoLocalidad.Value.ToString & "'")
                ucoColonia.Value = Nothing
            End If
        Catch ex As Exception
            cMensajes.DisplayMessage(Me, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim Mainbar As ToolStrip = TryCast(parent.Controls.Find("CommandBar", True).FirstOrDefault(), ToolStrip)
        Mainbar.Enabled = True
        Me.Close()
    End Sub

    Private Sub frmDiversion1_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        Dim Maintab As UltraTabControl = TryCast(parent.Controls.Find("tabPrincipal", True).FirstOrDefault(), UltraTabControl)
        Maintab.Visible = True
        Dim Mainbar As ToolStrip = TryCast(parent.Controls.Find("CommandBar", True).FirstOrDefault(), ToolStrip)
        Mainbar.Visible = True
    End Sub

    Private Sub txtClavecatastral_TextChanged(sender As Object, e As EventArgs) Handles txtClavecatastral.TextChanged
        If Me.txtClavecatastral.Text.Length = 16 Then
            cxn.Select_SQL("select cve_catastral from arc_predial where cve_catastral='" & Me.txtClavecatastral.Text.Trim & "'")
            If cxn.arrayValores(0) Is Nothing Then
                cMensajes.DisplayMessage(Me, "La clave catastral no existe, verifique...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            End If
        End If
    End Sub
    Private Sub frmDiversion1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        txtClavecatastral.Focus()
    End Sub
    Private Sub frmDiversion1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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
    Private Sub chkNotificado_CheckedChanged(sender As Object, e As EventArgs) Handles chkNotificado.CheckedChanged
        If chkNotificado.Checked = True Then
            panNotificado.Enabled = True
        Else
            panNotificado.Enabled = False
            ucoPae.Value = Nothing
            txtNoActos.Value = Nothing
            txtFecPAE.Value = Nothing
            txtNoOficioPae.Text = ""
        End If
    End Sub
    Private Sub txtRfc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRfc.KeyPress
#Region "validarfc"
        If Char.IsLetterOrDigit(e.KeyChar) Then
            Dim Posicion As Integer = txtRfc.SelectionStart + 1
            If Posicion >= 1 Or Posicion <= 3 Then
                If Char.IsLetter(e.KeyChar) Then
                    e.Handled = False
                Else
                    e.Handled = True
                End If
            End If
            If Posicion = 4 Then
                If Char.IsLetterOrDigit(e.KeyChar) Then
                    e.Handled = False
                Else
                    e.Handled = True
                End If
            End If
            'si es numero es persona moral
            If Posicion >= 5 Then
                Dim pm As Boolean = False
                Dim pf As Boolean = False
                If Char.IsDigit(txtRfc.Text.Substring(3, 1)) Then
                    'Es persona moral
                    pm = True
                End If

                If Char.IsLetter(txtRfc.Text.Substring(3, 1)) Then
                    'Es persona fisica
                    pf = True
                End If
                If Char.IsDigit(e.KeyChar) = True Then
                    If pf = True Then
                        If Posicion >= 5 And Posicion <= 10 Then
                            If Char.IsDigit(e.KeyChar) Then
                                e.Handled = False
                            Else
                                e.Handled = True
                            End If
                        End If
                    End If
                    If pm = True Then
                        If Posicion >= 5 And Posicion <= 9 Then
                            If Char.IsDigit(e.KeyChar) Then
                                e.Handled = False
                            Else
                                e.Handled = True
                            End If
                        End If
                    End If

                Else
                    e.Handled = True
                End If
                'valida resto de la cadena
                If Posicion > 9 And Posicion <= 12 And pm = True Then
                    If Char.IsLetterOrDigit(e.KeyChar) Then
                        e.Handled = False
                    Else
                        e.Handled = True
                    End If
                End If
                If Posicion > 10 And Posicion <= 13 And pf = True Then
                    If Char.IsLetterOrDigit(e.KeyChar) Then
                        e.Handled = False
                    Else
                        e.Handled = True
                    End If
                End If
            End If
        Else
            e.Handled = True
        End If

        If e.KeyChar = vbBack Then
            e.Handled = False
        End If
#End Region
    End Sub
    Private Sub ActivaFormulario(enable As Boolean)
        grpDatosCuenta.Enabled = enable
        grpPropietario.Enabled = enable
        grpPAE.Enabled = enable
        grpUltimoPago.Enabled = enable
        btnGuardar.Visible = enable
        btnEditar.Visible = True
    End Sub

    Private Sub btnImage_Click(sender As Object, e As EventArgs) Handles btnImage.Click
        Dim frm As New Padron_Imagenes
        frm.Show(txtNoLic.Text.Trim, "DIVERSION", Me)
    End Sub
End Class