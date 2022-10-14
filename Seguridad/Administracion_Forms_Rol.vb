Imports Infragistics.Win.UltraWinGrid
Public Class Administracion_Forms_Rol
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
    Private Sub Administracion_Forms_Rol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsSeguridad.aspnet_Roles' Puede moverla o quitarla según sea necesario.
        Me.Aspnet_RolesTableAdapter.Fill(Me.DsSeguridad.aspnet_Roles)
        'TODO: esta línea de código carga datos en la tabla 'DsSeguridad.tbMainSubMenus' Puede moverla o quitarla según sea necesario.
        Me.TbMainSubMenusTableAdapter.Fill(Me.DsSeguridad.tbMainSubMenus)
    End Sub
    Private Sub tsbGuardaUsuario_Click(sender As Object, e As EventArgs) Handles tsbGuardaUsuario.Click
        TbMainSubMenusBindingSource1.EndEdit()
        TbMainSubMenusTableAdapter.Update(DsSeguridad.tbMainSubMenus)
        'TODO: esta línea de código carga datos en la tabla 'DsSeguridad.tbMainSubMenus' Puede moverla o quitarla según sea necesario.
        Me.TbMainSubMenusTableAdapter.Fill(Me.DsSeguridad.tbMainSubMenus)
        cMensajes.DisplayMessage(Me, "registros actualizados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
        Me.Dispose()
    End Sub
    Private Sub griMenus_CellDataError(sender As Object, e As CellDataErrorEventArgs) Handles griMenus.CellDataError
        e.RaiseErrorEvent = False
        e.RestoreOriginalValue = True
        e.StayInEditMode = True
        cMensajes.DisplayMessage(Me, "El valor ingresado no corresponde a un registro de la lista!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    End Sub
End Class