Imports System.ComponentModel
Imports Infragistics.Win.UltraWinTabControl
Imports System.Web.Security
Public Class frmCatDiasInhabiles
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
    Private Sub frmCatDiasInhabiles_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        If id <> "0" Then
            'TODO: esta línea de código carga datos en la tabla 'DsParametros.tbl_dias_inhabiles' Puede moverla o quitarla según sea necesario.
            Me.Tbl_dias_inhabilesTableAdapter.Fill(Me.DsParametros.tbl_dias_inhabiles)
            Me.TbldiasinhabilesBindingSource.Position = Me.TbldiasinhabilesBindingSource.Find("id", id)
            btnEliminar.Visible = True
        Else
            grpOficinas.Enabled = True
            btnEditar.Visible = False
            btnGuardar.Visible = True
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

            If Not IsDate(dtpFecha.Value) Then
                ErrorProvider1.SetError(dtpFecha, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo fecha es requerido." & "<br />"
                Me.dtpFecha.Focus()
            End If

            If txtObservacion.Text = "" Then
                ErrorProvider1.SetError(txtObservacion, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo observación es requerido." & "<br />"
                Me.txtObservacion.Focus()
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
                    Me.TbldiasinhabilesBindingSource.EndEdit()
                    Me.Tbl_dias_inhabilesTableAdapter.Update(Me.DsParametros.tbl_dias_inhabiles)
                    cMensajes.DisplayMessage(Me, "Datos actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Else
                    Tbl_dias_inhabilesTableAdapter.Insert(dtpFecha.Value, txtObservacion.Text)
                    Me.Tbl_dias_inhabilesTableAdapter.Update(Me.DsParametros.tbl_dias_inhabiles)
                    cMensajes.DisplayMessage(Me, "Datos Registrados", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            cMensajes.DisplayMessage(Me, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End Try
    End Sub
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        grpOficinas.Enabled = True
        btnEditar.Visible = False
        btnGuardar.Visible = True
    End Sub
    Private Sub btnElimina_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If MsgBox("¿Seguro de Eliminar el Registro?", vbYesNo, "Confirmación") = vbYes Then
                Me.Validate()
                Me.BindingNavigator1.BindingSource.RemoveCurrent()
                Me.Tbl_dias_inhabilesTableAdapter.Update(DsParametros.tbl_dias_inhabiles)
                cMensajes.DisplayMessage(Me, "Datos eliminados", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Me.Close()
            End If

        Catch ex As Exception
            cMensajes.DisplayMessage(Me, "Error al registrar los movimientos ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End Try
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim Mainbar As ToolStrip = TryCast(Parent.Controls.Find("CommandBar", True).FirstOrDefault(), ToolStrip)
        Mainbar.Enabled = True
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub frmCatDiasInhabiles_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim Maintab As UltraTabControl = TryCast(Parent.Controls.Find("tabPrincipal", True).FirstOrDefault(), UltraTabControl)
        Maintab.Visible = True
        Dim Mainbar As ToolStrip = TryCast(Parent.Controls.Find("CommandBar", True).FirstOrDefault(), ToolStrip)
        Mainbar.Visible = True
    End Sub


    'Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
    '    Me.OficinasBindingSource.Position = Me.OficinasBindingSource.Find("nom_colonia", txtBusca.Text)
    'End Sub

    Private Sub btnUndo_Click_1(sender As Object, e As EventArgs) Handles btnUndo.Click
        ErrorProvider1.Clear()
        TbldiasinhabilesBindingSource.CancelEdit()
    End Sub

    Private Sub frmCatDiasInhabiles_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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