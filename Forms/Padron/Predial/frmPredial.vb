﻿Imports System.ComponentModel
Imports Infragistics.Win.UltraWinTabControl
Imports System.Math
Imports System.Text.RegularExpressions
Imports System.Web.Security
Public Class frmPredial
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
    Private Sub frmPredial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DasPredial.arc_predial' Puede moverla o quitarla según sea necesario.
        Try
            Me.lblCurrentMenu2.Text = Me.Text
            load_Combos()
            If id <> "0" Then
                Me.Arc_predialTableAdapter.FillBy(Me.DasPredial.arc_predial, id)
                'Me.BindingSource1.Position = Me.BindingSource1.Find("cve_catastral", id)
            End If
            LoadRol()
        Catch ex As Exception
            cMensajes.DisplayMessage(Me, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Private Sub load_Combos()
        cxn.fLlenaDropDownUltra(ucoStatus, "SELECT cve_status,descripcion from tbl_Status_Contribuyente")
        cxn.fLlenaDropDownUltra(ucoTipoContribuyente, "SELECT cve_tip_con,descricion from tip_contribuyente")
        cxn.fLlenaDropDownUltra(ucoTipoPredio, "SELECT tipo_predio,descripcion from tip_predio")
        cxn.fLlenaDropDownUltra(ucoPae, "Select clave, nombre from Pae")
    End Sub
    Private Sub LoadRol()
        btnEditar.Enabled = Roles.IsUserInRole(Usuario, Editar)
        'btnElimina.Enabled = Roles.IsUserInRole(Usuario, Borrar)
        btnGuardar.Enabled = Roles.IsUserInRole(Usuario, Insertar)
    End Sub


    Private Sub load_Permiso()
        Me.btnGuardar.Visible = False
        btnUndo.Visible = False
        Dim resp As DialogResult = DialogResult.Yes
        Me.Text = "Detalles del Predio: " & id.ToString
        If tipo_Permiso = 0 And Not delete_record Then 'Solo Lectura
            Me.grpDatosCuenta.Enabled = False
            Me.grpPropietario.Enabled = False
            Me.grpPAE.Enabled = False
            Me.grpUltimoPago.Enabled = False
        ElseIf tipo_Permiso = 1 And delete_record Then 'Eliminar Registro
            resp = ShowContinueMessage("Operación no Permitida", " ",
                                        "No se encontrarón datos con el query" & vbCrLf &
                                        "¿Desea Guardar los cambios?", Me.UltraMessageBoxManager1,
                                        MessageBoxButtons.YesNo)
            Me.Close()
        ElseIf tipo_Permiso = 1 And id <> "0" Then  'Actualizar Registro
            Me.grpDatosCuenta.Enabled = True
            Me.grpPropietario.Enabled = True
            Me.txtcveCatastral.ReadOnly = True
            Me.grpUltimoPago.Enabled = True
            Me.grpPAE.Enabled = True
            Me.btnGuardar.Visible = True
            btnUndo.Visible = True
        ElseIf tipo_Permiso = 1 And id = "0" Then 'Agregar Registro
            resp = ShowContinueMessage("Operación no Permitida", " ",
                                        "No se encontrarón datos con el query" & vbCrLf &
                                        "¿Desea Guardar los cambios?", Me.UltraMessageBoxManager1,
                                        MessageBoxButtons.YesNo)
            Me.Close()

        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If valida_datos() Then
                Me.Validate()
                Me.ArcpredialBindingSource.Current("usuario") = Usuario
                Me.ArcpredialBindingSource.EndEdit()
                Me.Arc_predialTableAdapter.Update(Me.DasPredial.arc_predial)
                ActivaFormulario(False)
                cMensajes.DisplayMessage(Me, "Datos actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            End If

        Catch ex As Exception
            cMensajes.DisplayMessage(Me, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)

        End Try
    End Sub

    Private Sub btnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        ArcpredialBindingSource.CancelEdit()
        ActivaFormulario(False)
        btnEditar.Visible = True
        btnGuardar.Visible = False
    End Sub
    Private Function valida_datos() As Boolean
        Dim ban As Boolean = False
        Dim ocurriounError As Integer = 0
        Dim mensaje As String = ""
        Try
            ErrorProvider1.Clear()
            If Me.txtcveCatastral.Text.Length <> 16 Then
                ErrorProvider1.SetError(txtcveCatastral, "Error")
                mensaje += "- " & "El campo clave catastral es requerido y debe tener una longitud de 16 digitos" & "<br />"
                ocurriounError += 1
                txtcveCatastral.Focus()
                Me.txtcveCatastral.SelectAll()
            End If
            If Me.ucoStatus.IsItemInList = False Then
                ErrorProvider1.SetError(ucoStatus, "Error")
                ocurriounError += 1
                mensaje += "- " & "Seleccione el status del contribuyente." & "<br />"
                ucoStatus.Focus()
            End If
            If Me.ucoTipoPredio.IsItemInList = False Then
                ErrorProvider1.SetError(ucoTipoPredio, "Error")
                mensaje += "- " & "El campo tipo de predio es requerido" & "<br />"
                ocurriounError += 1
                Me.ucoTipoPredio.Focus()
            End If

            If Me.txtPropietario.Text.Trim = "" Then
                ErrorProvider1.SetError(txtPropietario, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo propietario es requerido." & "<br />"
                Me.txtPropietario.Focus()
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
            If txtCurp.Text <> String.Empty Then
                If Regex.IsMatch(txtCurp.Text.Trim, "[A-Z][A,E,I,O,U,X][A-Z]{2}[0-9]{2}[0-1][0-9][0-3][0-9][M|H](AS|BC|BS|CC|CL|CM|CS|CH|DF|DG|GT|GR|HG|JC|MC|MN|MS|NT|NL|OC|PL|QT|QR|SP|SL|SR|TC|TS|TL|VZ|YN|ZS|NE)[B,C,D,F,G,H,J,K,L,M,N,Ñ,P,Q,R,S,T,V,W,X,Y,Z]{3}[0-9,A-Z][0-9]$") = False Then
                    ErrorProvider1.SetError(txtCurp, "Error")
                    ocurriounError += 1
                    mensaje += "- " & "Ingrese la curp en un formato válido." & "<br />"
                    txtCurp.Focus()
                End If
            End If
            If Me.ucoTipoContribuyente.IsItemInList = False Then
                ErrorProvider1.SetError(ucoTipoContribuyente, "Error")
                ocurriounError += 1
                mensaje += "- " & "Seleccione el tipo de contribuyente." & "<br />"
                Me.ucoTipoContribuyente.Focus()
            End If
            If txtRfc.Text <> String.Empty Then
                If Regex.IsMatch(txtRfc.Text.Trim, "^([A-ZÑ\x26]{3,4}([0-9]{2})(0[1-9]|1[0-2])(0[1-9]|1[0-9]|2[0-9]|3[0-1])([A-Z]|[0-9]){2}([A]|[0-9]){1})?$") = False Then
                    ErrorProvider1.SetError(txtRfc, "Error")
                    ocurriounError += 1
                    mensaje += "- " & "Ingrese el RFC en un formato válido." & "<br />"
                    txtRfc.Focus()
                End If
            End If
            If Me.txtUbicacion.Text.Trim.Trim = "" Then
                ErrorProvider1.SetError(txtUbicacion, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo domicilio es requerido." & "<br />"
                Me.txtUbicacion.Focus()
                txtUbicacion.SelectAll()
            End If

            If Me.txtDomicilio.Text.Trim.Trim = "" Then
                ErrorProvider1.SetError(txtDomicilio, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo domicilio fiscal es requerido." & "<br />"
                Me.txtDomicilio.Focus()
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

            If Me.ucoUltMes.Text.Trim.Length > 0 Then
                If Me.ucoUltMes.Text <= 0 Or ucoUltMes.Text >= 13 Then
                    ErrorProvider1.SetError(ucoUltMes, "Error")
                    ocurriounError += 1
                    mensaje += "- " & "El mes de último pago es incorrecto." & "<br />"
                    Me.ucoUltMes.SelectAll()
                    Me.ucoUltMes.Focus()
                End If
            Else
                ErrorProvider1.SetError(ucoUltMes, "Error")
                ocurriounError += 1
                mensaje += "- " & "El mes de último pago es incorrecto." & "<br />"
                Me.ucoUltMes.SelectAll()
                Me.ucoUltMes.Focus()
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

    'Private Sub btnCerrar_Click(sender As Object, e As EventArgs)
    '    Me.Close()
    'End Sub

    'Private Sub btnElimina_Click(sender As Object, e As EventArgs)

    '    If MsgBox("¿Seguro de Eliminar el Registro?", vbYesNo, "Confirmación") = vbYes Then
    '        Me.Validate()
    '        Me.BindingSource1.Current("status_cta") = "1"
    '        Me.BindingSource1.EndEdit()

    '        Me.Arc_predialTableAdapter.Update(Me.DsPredial.arc_predial)
    '        ' Me.cxn.Select_SQL("exec sp_arcagua_registramovtos '" & Me.txtCuenta.Text.Trim & "','E','" & My.User.Name.ToString & "'")
    '        If cxn.arrayValores(0).ToString = "1" Then
    '            cMensajes.DisplayMessage(Me, "Datos actualizados ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
    '            Me.Close()
    '        Else
    '            cMensajes.DisplayMessage(Me, "Error al registrar los movimientos ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '        End If
    '    End If
    'End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim Mainbar As ToolStrip = TryCast(parent.Controls.Find("CommandBar", True).FirstOrDefault(), ToolStrip)
        Mainbar.Enabled = True
        Me.Close()
    End Sub

    Private Sub frmPredial_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim Maintab As UltraTabControl = TryCast(parent.Controls.Find("tabPrincipal", True).FirstOrDefault(), UltraTabControl)
        Maintab.Visible = True
        Dim Mainbar As ToolStrip = TryCast(parent.Controls.Find("CommandBar", True).FirstOrDefault(), ToolStrip)
        Mainbar.Visible = True
    End Sub

    Private Sub frmPredial_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            'valida permiso de edicion
            ActivaFormulario(True)
            btnGuardar.Visible = True
            btnEditar.Visible = False
            txtcveCatastral.Focus()
        Catch ex As Exception
            cMensajes.DisplayMessage(Me, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Private Sub btnImage_Click(sender As Object, e As EventArgs) Handles btnImage.Click
        Dim frm As New Padron_Imagenes
        frm.Show(txtcveCatastral.Text.Trim, "PREDIAL", Me)
    End Sub

    Private Sub UltraExpandableGroupBoxPanel2_Paint(sender As Object, e As PaintEventArgs) Handles UltraExpandableGroupBoxPanel2.Paint

    End Sub
End Class
