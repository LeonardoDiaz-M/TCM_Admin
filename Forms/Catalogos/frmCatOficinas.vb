Imports System.ComponentModel
Imports Infragistics.Win.UltraWinTabControl
Imports System.Web.Security
Public Class frmCatOficinas
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

    Private Sub frmCatOficinas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If id <> "0" Then
            'TODO: esta línea de código carga datos en la tabla 'DsCatalogos.oficinas' Puede moverla o quitarla según sea necesario.
            Me.OficinasTableAdapter.Fill(Me.DsCatalogos.oficinas)
            Me.OficinasBindingSource.Position = Me.OficinasBindingSource.Find("comun", id)
            btnEliminar.Visible = True
            txtComun.ReadOnly = True
        Else
            grpOficinas.Enabled = True
            txtComun.ReadOnly = False
            btnEditar.Visible = False
            btnGuardar.Visible = True
            txtNombre.SelectAll()
        End If
        'LoadRol()
    End Sub
    Private Sub LoadRol()
        btnEditar.Enabled = Roles.IsUserInRole(Usuario, Editar)
        btnEliminar.Enabled = Roles.IsUserInRole(Usuario, Borrar)
        btnGuardar.Enabled = Roles.IsUserInRole(Usuario, Insertar)
    End Sub
    Private Sub load_Permiso()
        'Me.btnGuardar.Visible = False
        'btnElimina.Visible = False
        'btnUndo.Visible = False
        'Me.txtClave.Enabled = False
        'Me.Text = "Detalle de la Colonia: " & id.ToString
        'If tipo_Permiso = 0 And Not delete_record Then 'Solo Lectura
        '    Me.gruDatosCuenta.Enabled = False
        'ElseIf tipo_Permiso = 1 And delete_record Then 'Eliminar Registro
        '    Me.gruDatosCuenta.Enabled = False
        '    btnElimina.Visible = True
        '    btnUndo.Visible = True
        'ElseIf tipo_Permiso = 1 And id <> "0" Then  'Actualizar Registro
        '    Me.gruDatosCuenta.Enabled = True
        '    Me.btnGuardar.Visible = True
        '    btnUndo.Visible = True
        'ElseIf tipo_Permiso = 1 And id = "0" Then 'Agregar Registro
        '    Me.Text = "Nueva Colonia"
        '    Me.gruDatosCuenta.Enabled = True
        '    Me.btnGuardar.Visible = True
        '    Me.btnNPrimero.Visible = False
        '    Me.btnNPrevio.Visible = False
        '    Me.btnNTotal.Visible = False
        '    Me.btnNCurrent.Visible = False
        '    Me.btnNSiguiente.Visible = False
        '    Me.btnNUltimo.Visible = False
        '    Me.BindingNavigator1.BindingSource.AddNew()

        'End If
    End Sub
    Private Function valida_datos() As Boolean
        Dim ban As Boolean = False
        Dim ocurriounError As Integer = 0
        Dim mensaje As String = ""
        Try
            ErrorProvider1.Clear()

            If txtComun.Text = "" Then
                ErrorProvider1.SetError(txtComun, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo id es requerido." & "<br />"
                Me.txtComun.Focus()
            End If

            If txtNombre.Text = "" Then
                ErrorProvider1.SetError(txtNombre, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo nombre es requerido." & "<br />"
                Me.txtNombre.Focus()
            End If

            If txtDireccion.Text = "" Then
                ErrorProvider1.SetError(txtDireccion, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo dirección es requerido." & "<br />"
                Me.txtDireccion.Focus()
            End If

            If txtResponsable.Text = "" Then
                ErrorProvider1.SetError(txtResponsable, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo responsable es requerido." & "<br />"
                Me.txtResponsable.Focus()
            End If

            If txtNombreAreaResponsable.Text = "" Then
                ErrorProvider1.SetError(txtNombreAreaResponsable, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo nombre area responsable es requerido." & "<br />"
                Me.txtNombreAreaResponsable.Focus()
            End If

            If optTipoSalario.Value = 0 Then
                ErrorProvider1.SetError(optTipoSalario, "Error")
                ocurriounError += 1
                mensaje += "- " & "El tipo de salario es requerido." & "<br />"
                Me.optTipoSalario.Focus()
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
                    Me.OficinasBindingSource.EndEdit()
                    Me.OficinasTableAdapter.Update(Me.DsCatalogos.oficinas)
                    cMensajes.DisplayMessage(Me, "Datos actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Else
                    OficinasTableAdapter.Insert(txtComun.Text.Trim, txtNombre.Text.Trim, txtDireccion.Text.Trim, txtResponsable.Text.Trim, txtNombreAreaResponsable.Text.Trim, txtContador.Text.Trim, txtNombreAreaContador.Text.Trim, txtResponsableFormasValoradas.Text.Trim, optTipoSalario.Value)
                    Me.OficinasTableAdapter.Update(Me.DsCatalogos.oficinas)
                    cMensajes.DisplayMessage(Me, "Datos Registrados", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            cMensajes.DisplayMessage(Me, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End Try
    End Sub
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        txtComun.ReadOnly = True
        grpOficinas.Enabled = True
        btnEditar.Visible = False
        btnGuardar.Visible = True
    End Sub
    Private Sub btnElimina_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If MsgBox("¿Seguro de Eliminar el Registro?", vbYesNo, "Confirmación") = vbYes Then
                Me.Validate()
                Me.BindingNavigator1.BindingSource.RemoveCurrent()
                Me.OficinasTableAdapter.Update(DsCatalogos.oficinas)
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
    Private Sub frmCatOficinas_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim Maintab As UltraTabControl = TryCast(parent.Controls.Find("tabPrincipal", True).FirstOrDefault(), UltraTabControl)
        Maintab.Visible = True
        Dim Mainbar As ToolStrip = TryCast(parent.Controls.Find("CommandBar", True).FirstOrDefault(), ToolStrip)
        Mainbar.Visible = True
    End Sub


    'Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
    '    Me.OficinasBindingSource.Position = Me.OficinasBindingSource.Find("nom_colonia", txtBusca.Text)
    'End Sub

    Private Sub btnUndo_Click_1(sender As Object, e As EventArgs) Handles btnUndo.Click
        ErrorProvider1.Clear()
        OficinasBindingSource.CancelEdit()
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


End Class