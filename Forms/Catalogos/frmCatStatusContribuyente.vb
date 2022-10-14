Imports System.ComponentModel
Imports Infragistics.Win.UltraWinTabControl
Imports System.Web.Security
Public Class frmCatStatusContribuyente
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
    Private Sub frmCatStatusContribuyente_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: esta línea de código carga datos en la tabla 'DsCatalogos.tbl_status_contribuyente' Puede moverla o quitarla según sea necesario.

        If id <> "0" Then
            Me.Tbl_status_contribuyenteTableAdapter.Fill(Me.DsCatalogos.tbl_status_contribuyente)
            Me.TblstatuscontribuyenteBindingSource.Position = Me.TblstatuscontribuyenteBindingSource.Find("cve_status", id)
        Else
            uexDatos.Enabled = True
            btnEditar.Visible = False
            btnGuardar.Visible = True
            txtDescripcion.SelectAll()
        End If
        'LoadRol()
    End Sub
    Private Sub LoadRol()
        btnEditar.Enabled = Roles.IsUserInRole(Usuario, Editar)
        btnElimina.Enabled = Roles.IsUserInRole(Usuario, Borrar)
        btnGuardar.Enabled = Roles.IsUserInRole(Usuario, Insertar)
    End Sub
    Private Function valida_datos() As Boolean
        Dim ban As Boolean = False
        Try
            If Me.txtId.Text.Trim = "" Then
                ErrorProvider1.SetError(txtId, "Error")
                cMensajes.DisplayMessage(Me, "El campo id es requerido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                ban = True
                Me.txtId.Focus()
            End If

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

    Private Sub btnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        TblstatuscontribuyenteBindingSource.CancelEdit()
        Me.Close()
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If valida_datos() = False Then
                If id <> "0" Then
                    Me.Validate()
                    Me.TblstatuscontribuyenteBindingSource.EndEdit()
                    Me.Tbl_status_contribuyenteTableAdapter.Update(DsCatalogos.tbl_status_contribuyente)
                    cMensajes.DisplayMessage(Me, "Datos actualizados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Else
                    Tbl_status_contribuyenteTableAdapter.Insert(txtDescripcion.Text.Trim, chkDetenerCobro.Checked)
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



    Private Sub btnElimina_Click(sender As Object, e As EventArgs) Handles btnElimina.Click
        Try
            If MsgBox("¿Seguro de Eliminar el Registro?", vbYesNo, "Confirmación") = vbYes Then
                Me.Validate()
                Me.TblstatuscontribuyenteBindingSource.RemoveCurrent()
                Me.Tbl_status_contribuyenteTableAdapter.Update(Me.DsCatalogos.tbl_status_contribuyente)
                cMensajes.DisplayMessage(Me, "Datos eliminados", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Me.Close()
            End If

        Catch ex As Exception
            cMensajes.DisplayMessage(Me, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Private Sub frmCatStatusContribuyente_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim Maintab As UltraTabControl = TryCast(parent.Controls.Find("tabPrincipal", True).FirstOrDefault(), UltraTabControl)
        Maintab.Visible = True
        Dim Mainbar As ToolStrip = TryCast(parent.Controls.Find("CommandBar", True).FirstOrDefault(), ToolStrip)
        Mainbar.Visible = True
    End Sub



End Class