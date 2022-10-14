Imports System.ComponentModel
Imports Infragistics.Win.UltraWinTabControl
Imports System.Web.Security
Public Class frmCatTipoPredio
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

    Private Sub frmCatTipoPredio_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            If id <> "0" Then
                Tip_predioTableAdapter.FillById(DsCatalogos.tip_predio, id)
                btnEditar.Visible = True
                btnGuardar.Visible = False
                btnEliminar.Visible = True
            Else
                'ActivaFormulario(True)
                btnGuardar.Visible = True
                btnEditar.Visible = False
                btnEliminar.Visible = False
            End If

            LoadRol()

        Catch ex As Exception
            cMensajes.DisplayMessage(Me, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
    End Sub
    Private Sub LoadRol()
        btnEditar.Enabled = Roles.IsUserInRole(Usuario, Editar)
        btnEliminar.Enabled = Roles.IsUserInRole(Usuario, Borrar)
        btnGuardar.Enabled = Roles.IsUserInRole(Usuario, Insertar)
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        BindingSource.EndEdit()
        Tip_predioTableAdapter.Update(DsCatalogos.tip_predio)
        cMensajes.DisplayMessage(Me, "Datos actualizados ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        uexDatos.Enabled = True
        btnGuardar.Visible = True
        btnEditar.Visible = False
    End Sub

    Private Sub btnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        BindingSource.CancelEdit()
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim Mainbar As ToolStrip = TryCast(parent.Controls.Find("CommandBar", True).FirstOrDefault(), ToolStrip)
        Mainbar.Enabled = True
        Me.Close()
    End Sub

    Private Sub frmCatTipoPredio_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim Maintab As UltraTabControl = TryCast(parent.Controls.Find("tabPrincipal", True).FirstOrDefault(), UltraTabControl)
        Maintab.Visible = True
        Dim Mainbar As ToolStrip = TryCast(parent.Controls.Find("CommandBar", True).FirstOrDefault(), ToolStrip)
        Mainbar.Visible = True
    End Sub
End Class