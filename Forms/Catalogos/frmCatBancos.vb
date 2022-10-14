Imports System.ComponentModel
Imports Infragistics.Win.UltraWinTabControl
Imports System.Web.Security
Public Class frmCatBancos
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

    Private Sub frmCatBancos_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: esta línea de código carga datos en la tabla 'DsCatalogos.bancos' Puede moverla o quitarla según sea necesario.

        If id <> "0" Then
            'TODO: esta línea de código carga datos en la tabla 'DsCatalogos.oficinas' Puede moverla o quitarla según sea necesario.
            Me.BancosTableAdapter.Fill(Me.DsCatalogos.bancos)
            Me.BancosBindingSource.Position = Me.BancosBindingSource.Find("BancoId", id)
            btnEliminar.Visible = True
            txtId.ReadOnly = True
        Else
            grpOficinas.Enabled = True
            txtId.ReadOnly = False
            btnEditar.Visible = False
            btnGuardar.Visible = True
            txtNombre.SelectAll()
        End If
        LoadRol()
    End Sub
    Private Sub LoadRol()
        btnEditar.Enabled = Roles.IsUserInRole(Usuario, Editar)
        btnEliminar.Enabled = Roles.IsUserInRole(Usuario, Borrar)
        btnGuardar.Enabled = Roles.IsUserInRole(Usuario, Insertar)
    End Sub
    Private Function valida_datos() As Boolean
        Dim ban As Boolean = False
        Dim ocurriounError As Integer = 0
        Dim mensaje As String = ""
        Try
            ErrorProvider1.Clear()

            If txtId.Text = "" Then
                ErrorProvider1.SetError(txtId, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo id es requerido." & "<br />"
                Me.txtId.Focus()
            End If

            If txtNombre.Text = "" Then
                ErrorProvider1.SetError(txtNombre, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo nombre es requerido." & "<br />"
                Me.txtNombre.Focus()
            End If

            If txtNumeroCliente.Text = "" Then
                ErrorProvider1.SetError(txtNumeroCliente, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo número cliente es requerido." & "<br />"
                Me.txtNumeroCliente.Focus()
            End If

            If txtContacto.Text = "" Then
                ErrorProvider1.SetError(txtContacto, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo contacto es requerido." & "<br />"
                Me.txtContacto.Focus()
            End If


            If txtTelefono.Text = "" Then
                ErrorProvider1.SetError(txtTelefono, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo teléfono es requerido." & "<br />"
                Me.txtTelefono.Focus()
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


    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If valida_datos() = False Then
                If id <> "0" Then
                    Me.Validate()
                    Me.BancosBindingSource.EndEdit()
                    Me.BancosTableAdapter.Update(Me.DsCatalogos.bancos)
                    cMensajes.DisplayMessage(Me, "Datos actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Else
                    BancosTableAdapter.Insert(txtId.Text.Trim, txtNombre.Text.Trim, txtNumeroCliente.Text, chkActivo.Checked, txtContacto.Text, txtTelefono.Text)
                    cMensajes.DisplayMessage(Me, "Datos Registrados", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            cMensajes.DisplayMessage(Me, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End Try
    End Sub
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        txtId.ReadOnly = True
        grpOficinas.Enabled = True
        btnEditar.Visible = False
        btnGuardar.Visible = True
    End Sub
    Private Sub btnElimina_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If MsgBox("¿Seguro de Eliminar el Registro?", vbYesNo, "Confirmación") = vbYes Then
                Me.Validate()
                Me.BindingNavigator1.BindingSource.RemoveCurrent()
                Me.BancosTableAdapter.Update(DsCatalogos.bancos)
                cMensajes.DisplayMessage(Me, "Datos eliminados", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Me.Close()
            End If

        Catch ex As Exception
            cMensajes.DisplayMessage(Me, "Error al registrar los movimientos ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End Try
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim Mainbar As ToolStrip = TryCast(parent.Controls.Find("CommandBar", True).FirstOrDefault(), ToolStrip)
        Mainbar.Enabled = True
        Me.Close()
        Me.Dispose()
    End Sub
    Private Sub btnUndo_Click_1(sender As Object, e As EventArgs) Handles btnUndo.Click
        ErrorProvider1.Clear()
        BancosBindingSource.CancelEdit()
    End Sub

    Private Sub frmCatOficinas_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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
    Private Sub frmCatBancos_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim Maintab As UltraTabControl = TryCast(parent.Controls.Find("tabPrincipal", True).FirstOrDefault(), UltraTabControl)
        Maintab.Visible = True
        Dim Mainbar As ToolStrip = TryCast(parent.Controls.Find("CommandBar", True).FirstOrDefault(), ToolStrip)
        Mainbar.Visible = True
    End Sub


End Class