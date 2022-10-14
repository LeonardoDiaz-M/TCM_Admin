Imports Infragistics.Win.UltraWinTabControl
Imports System.ComponentModel
Imports System.Web.Security
Public Class frmCatTipoinmueble
    Public id As String = "0"
    Public Lectura As String = "0"
    Public Insertar As String = "0"
    Public Borrar As String = "0"
    Public Editar As String = "0"

    Public delete_record As Boolean = False
    Public tipo_Permiso As Integer = 0
    Private cxn As New cxnData
    Private newrow As Object
    Public myparent As Form = Nothing
    Private Sub frmCatTipoinmueble_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsAgua.tipo_inmueble' Puede moverla o quitarla según sea necesario.
        Me.Tipo_inmuebleTableAdapter.Fill(Me.DsAgua.tipo_inmueble)
        Me.BindingSource1.Position = Me.BindingSource1.Find("clave", id)
        load_Permiso()
    End Sub
    Private Sub load_Permiso()
        Me.btnGuardar.Visible = False
        btnElimina.Visible = False
        btnUndo.Visible = False
        Me.txtClave.Enabled = False
        Me.Text = "Detalle de Inmueble : " & id.ToString
        If tipo_Permiso = 0 And Not delete_record Then 'Solo Lectura
            Me.grpDatosCuenta.Enabled = False
        ElseIf tipo_Permiso = 1 And delete_record Then 'Eliminar Registro
            Me.grpDatosCuenta.Enabled = False
            btnElimina.Visible = True
            btnUndo.Visible = True
        ElseIf tipo_Permiso = 1 And id <> "0" Then  'Actualizar Registro
            Me.grpDatosCuenta.Enabled = True
            Me.btnGuardar.Visible = True
            btnUndo.Visible = True
        ElseIf tipo_Permiso = 1 And id = "0" Then 'Agregar Registro
            Me.Text = "Nuevo Tipo de Inmueble"
            Me.grpDatosCuenta.Enabled = True
            Me.btnGuardar.Visible = True
            Me.BindingNavigator1.BindingSource.AddNew()

        End If
        LoadRol()
    End Sub
    Private Sub LoadRol()

        btnElimina.Enabled = Roles.IsUserInRole(Usuario, Borrar)
        btnGuardar.Enabled = Roles.IsUserInRole(Usuario, Insertar)
    End Sub

    Private Function valida_datos() As Boolean
        Dim ban As Boolean = False
        Try
            If Me.txtNombre.Text.Trim.Length > 0 Then
                If Me.txtNomCorto.Text.Trim.Trim.Length > 0 Then
                    ban = True
                Else
                    SystemMessages1.SysMsg("El campo Nombre Corto es requerido.", True)
                    Me.txtNomCorto.Focus()
                End If
            Else
                SystemMessages1.SysMsg("El campo Nombre es requerido.", True)
                Me.txtNombre.Focus()
            End If
        Catch ex As Exception

        End Try
        Return ban
    End Function
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Private Sub btnElimina_Click(sender As Object, e As EventArgs) Handles btnElimina.Click
        Try
            If MsgBox("¿Seguro de Eliminar el Registro?", vbYesNo, "Confirmación") = vbYes Then
                Me.Validate()
                Me.BindingNavigator1.BindingSource.RemoveCurrent()
                Me.Tipo_inmuebleTableAdapter.Update(Me.DsAgua.tipo_inmueble)
                SystemMessages1.SysMsg("Datos eliminados ")
                MsgBox("Registro eliminado", MsgBoxStyle.Information, "Tipo inmueble")
                Me.Close()
            End If

        Catch ex As Exception
            SystemMessages1.SysMsg("Error al registrar los movimientos ", True)
        End Try
    End Sub
    Private Sub btnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        Me.Close()
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If valida_datos() Then
                If tipo_Permiso = 1 And id <> "0" Then
                    Me.Validate()

                    Me.BindingSource1.EndEdit()
                    Me.Tipo_inmuebleTableAdapter.Update(Me.DsAgua.tipo_inmueble)
                    SystemMessages1.SysMsg("Datos actualizados ")
                Else
                    Tipo_inmuebleTableAdapter.Insert(Me.txtNombre.Text.Trim.ToUpperInvariant, Me.txtNomCorto.Text.Trim.ToUpperInvariant)
                    Me.Tipo_inmuebleTableAdapter.Update(Me.DsAgua.tipo_inmueble)
                    SystemMessages1.SysMsg("Datos Registrados ")
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            SystemMessages1.SysMsg(ex.Message, True)
        End Try
    End Sub
    Private Sub frmMovtosPadron_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim Maintab As UltraTabControl = TryCast(myparent.Controls.Find("UltraTabControl1", True).FirstOrDefault(), UltraTabControl)
        Maintab.Visible = False
        Maintab.Visible = True
    End Sub
End Class