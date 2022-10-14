Imports Infragistics.Win.UltraWinTabControl
Imports System.ComponentModel
Imports System.Web.Security
Public Class frmCatRutas
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
    Private Sub frmCatTipoinmueble_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsAgua.tipo_inmueble' Puede moverla o quitarla según sea necesario.

        If id <> "0" Then
            Me.RutasTableAdapter.Fill(Me.DsAgua.rutas)
            Me.BindingSource1.Position = Me.BindingSource1.Find("id_ruta", id)
        Else
            uexDatos.Enabled = True
            btnEditar.Visible = False
            btnGuardar.Visible = True
            txtDescripcion.SelectAll()
        End If
        LoadRol()
    End Sub
    Private Sub LoadRol()
        btnEditar.Enabled = Roles.IsUserInRole(Usuario, Editar)
        btnElimina.Enabled = Roles.IsUserInRole(Usuario, Borrar)
        btnGuardar.Enabled = Roles.IsUserInRole(Usuario, Insertar)
    End Sub
    Private Function valida_datos() As Boolean
        Dim ban As Boolean = False
        Try
            If Me.txtDescripcion.Text.Trim = "" Then
                ErrorProvider1.SetError(txtDescripcion, "Error")
                cMensajes.DisplayMessage(Me, "El campo descripcion es requerido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                ban = True
                Me.txtDescripcion.Focus()
            End If
        Catch ex As Exception
            cMensajes.DisplayMessage(Me, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
        Return ban
    End Function
    'Private Sub btnElimina_Click(sender As Object, e As EventArgs)
    '    Try
    '        If MsgBox("¿Seguro de Eliminar el Registro?", vbYesNo, "Confirmación") = vbYes Then
    '            Me.Validate()
    '            Me.BindingNavigator1.BindingSource.RemoveCurrent()
    '            Me.RutasTableAdapter.Update(Me.DsAgua.rutas)
    '            SystemMessages1.SysMsg("Datos eliminados ")
    '            MsgBox("Registro eliminado", MsgBoxStyle.Information, "Rutas")
    '            Me.Close()
    '        End If
    '    Catch ex As Exception
    '        SystemMessages1.SysMsg("Error al registrar los movimientos ", True)
    '    End Try
    'End Sub
    Private Sub btnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        BindingSource1.CancelEdit()
        Me.Close()
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If valida_datos() = False Then
                If id <> "0" Then
                    Me.Validate()
                    Me.BindingSource1.EndEdit()
                    Me.RutasTableAdapter.Update(Me.DsAgua.rutas)
                    cMensajes.DisplayMessage(Me, "Datos actualizados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Else
                    RutasTableAdapter.Insert(txtDescripcion.Text.Trim)
                    btnGuardar.Visible = False
                    btnEditar.Visible = False
                    uexDatos.Enabled = False

                    cMensajes.DisplayMessage(Me, "Datos Registrados ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                End If
            End If
        Catch ex As Exception
            cMensajes.DisplayMessage(Me, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
    End Sub
    Private Sub frmMovtosPadron_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        Dim Maintab As UltraTabControl = TryCast(parent.Controls.Find("tabPrincipal", True).FirstOrDefault(), UltraTabControl)
        Maintab.Visible = True
        Dim Mainbar As ToolStrip = TryCast(parent.Controls.Find("CommandBar", True).FirstOrDefault(), ToolStrip)
        Mainbar.Visible = True
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim Mainbar As ToolStrip = TryCast(parent.Controls.Find("CommandBar", True).FirstOrDefault(), ToolStrip)
        Mainbar.Enabled = True
        Me.Close()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        uexDatos.Enabled = True
        btnGuardar.Visible = True
        btnEditar.Visible = False
    End Sub
End Class