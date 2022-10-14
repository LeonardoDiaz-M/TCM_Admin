Imports System.Data
Imports System.Data.SqlClient
Imports System.Web.Security
Imports System.Security.Principal
Public Class Administracion_Seguridad
    Dim dtUsuarios As New DataTable
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
    Dim clsNegocioUser_Profiles As New clsNegocioUser_Profiles
    Private Sub BitacoraEscenarios_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'LlenaDatos()
        Usuario = "Administrador"
        CreaTablaUsuarios()
        Llena_Todos_LosUsuarios()
        Llena_Roles_Actuales()
        griAllUsers.DataSource = clsNegocioUser_Profiles.funGetAllUserSeguridad
    End Sub

    Private Sub Load_Permisos()
        tsbAgregaRol.Visible = Roles.IsUserInRole(Usuario, "SEGURIDAD: ALTA ROLES")
        txtRol.Visible = Roles.IsUserInRole(Usuario, "SEGURIDAD: ALTA ROLES")
        tabSecurity.Tabs.Item("tabPermisosRol").Visible = Roles.IsUserInRole(Usuario, "SEGURIDAD: ASIGNA ROLES A USUARIOS")
        tabSecurity.Tabs.Item("tabPermisosUsuario").Visible = Roles.IsUserInRole(Usuario, "SEGURIDAD: ASIGNA ROLES A USUARIOS")
    End Sub

    Private Sub Llena_Roles_Actuales()
        lstTodosRoles.DataSource = Roles.GetAllRoles
    End Sub


    Private Sub Llena_Todos_LosUsuarios()
        'dtUsuarios.Clear()
        'Dim usuarios As MembershipUserCollection
        'usuarios = Membership.GetAllUsers
        'dgvAllUsuarios.DataSource = usuarios
        'For Each mu As MembershipUser In usuarios
        '    Dim dr As DataRow
        '    dr = dtUsuarios.NewRow
        '    dr("UserName") = mu.UserName
        '    dr("Nombre") = mu.Email
        '    dr("Status") = mu.IsLockedOut
        '    dr("FechaCreacion") = mu.CreationDate

        '    dtUsuarios.Rows.Add(dr)
        '    dtUsuarios.AcceptChanges()
        'Next
        'dgvAllUsuarios.DataSource = dtUsuarios
        'dgvTodosLosUsuarios.DataSource = dtUsuarios

    End Sub

    Private Sub CreaTablaUsuarios()
        Dim column As DataColumn = New DataColumn
        With column
            .DataType = System.Type.GetType("System.String")
            .Caption = "UserName"
            .ColumnName = "UserName"
            .DefaultValue = 0
            dtUsuarios.Columns.Add(column)
        End With

        Dim column1 As DataColumn = New DataColumn
        With column1
            .DataType = System.Type.GetType("System.String")
            .Caption = "Nombre"
            .ColumnName = "Nombre"
            dtUsuarios.Columns.Add(column1)
        End With

        Dim column2 As DataColumn = New DataColumn
        With column2
            .DataType = System.Type.GetType("System.Byte")
            .Caption = "Status"
            .ColumnName = "Status"
            dtUsuarios.Columns.Add(column2)
        End With

        Dim column3 As DataColumn = New DataColumn
        With column3
            .DataType = System.Type.GetType("System.DateTime")
            .Caption = "FechaCreacion"
            .ColumnName = "FechaCreacion"
            dtUsuarios.Columns.Add(column3)
        End With
    End Sub
    Private Sub tsbQuitarRol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbQuitarRol.Click
        If Roles.IsUserInRole(Usuario, "SEGURIDAD: CONSULTA") = False Then
            cMensajes.DisplayMessage(Me, "Acceso no autorizado!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If

        Dim Buttons As Integer = MessageBoxButtons.YesNo

        Dim Result As DialogResult
        Result = MessageBox.Show(Me, "Desea eliminar los permisos seleccionados", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

        If Result = System.Windows.Forms.DialogResult.Yes Then
            Me.Cursor = Cursors.WaitCursor
            Dim i As Object
            Dim rol As String
            For Each i In lstRolesPorUsuario.SelectedItems
                rol = i.ToString
                Roles.RemoveUserFromRole(txtRolesUsuario.Text, rol)
            Next
        End If
        LlenaRolesPorUsuario()
        Llena_Usuarios_EnRol()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub tsbAgregarRol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAgregarRol.Click

        If Roles.IsUserInRole(Usuario, "SEGURIDAD: CONSULTA") = False Then
            cMensajes.DisplayMessage(Me, "Acceso no autorizado!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If

        Dim i As Object

        Me.Cursor = Cursors.WaitCursor

        For Each i In lstRoles.SelectedItems
            Dim rol As String = i.ToString
            If Not Roles.IsUserInRole(txtRolesUsuario.Text, rol) Then
                Roles.AddUserToRole(txtRolesUsuario.Text, rol)
            Else
                MsgBox("El usuario ya pertenece al Rol", MsgBoxStyle.Exclamation, Application.ProductName)
            End If
        Next
        LlenaRolesPorUsuario()
        Llena_Usuarios_EnRol()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub LlenaRolesPorUsuario()
        lstRolesPorUsuario.DataSource = Roles.GetRolesForUser(txtRolesUsuario.Text)
        lstRoles.DataSource = Roles.GetAllRoles
        lstRoles.ClearSelected()
        lstRolesPorUsuario.ClearSelected()
    End Sub

    Private Sub chkTodosRoles_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTodosRoles.CheckedChanged
        If chkTodosRoles.Checked = True Then
            Dim i As Integer
            For i = 0 To Me.lstRoles.Items.Count - 1
                lstRoles.SelectedIndex = i
            Next
        Else
            lstRoles.ClearSelected()
        End If
    End Sub


    Private Sub chkTodosRolesSeleccionados_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTodosRolesSeleccionados.CheckedChanged
        If chkTodosRolesSeleccionados.Checked = True Then
            Dim i As Integer
            For i = 0 To Me.lstRolesPorUsuario.Items.Count - 1
                lstRolesPorUsuario.SelectedIndex = i
            Next
        Else
            lstRolesPorUsuario.ClearSelected()
        End If
    End Sub

    Private Sub butRolesUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butRolesUsuario.Click
        If Roles.IsUserInRole(Usuario, "Seguridad: Consulta") = False Then
            cMensajes.DisplayMessage(Me, "Acceso no autorizado!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If

        Try

            If txtRolesUsuario.Text = Nothing Then
                erpError.SetError(txtRolesUsuario, "Ingrese el Usuario")
                tosPermisosRoles.Enabled = False
            Else
                If ValidaUsuario(txtRolesUsuario.Text) = False Then
                    LimpiaRolesUsuario()
                    tosPermisosRoles.Enabled = False
                    txtRolesUsuario.SelectAll()
                    erpError.SetError(txtRolesUsuario, "El usuario no existe")
                    MsgBox("El usuario no existe", MsgBoxStyle.Exclamation, Application.ProductName)
                Else
                    erpError.Clear()
                    Me.Cursor = Cursors.WaitCursor

                    cxn.Select_SQL("select proNombres + ' ' + proApellidoPaterno + ' ' + proApellidoMaterno from Users_Profiles where proUserId='" & txtRolesUsuario.Text.Trim & "'")
                    If cxn.arrayValores(0) IsNot Nothing Then
                        txtNombres.Text = cxn.arrayValores(0)
                    End If

                    LlenaRolesPorUsuario()
                    Me.Cursor = Cursors.Default
                    tosPermisosRoles.Enabled = True
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function ValidaUsuario(ByVal Usuario As String) As Boolean
        If Membership.FindUsersByName(Usuario).Count = 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub LimpiaRolesUsuario()
        lstRolesPorUsuario.DataSource = Nothing
    End Sub

    Private Sub lstTodosRoles_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstTodosRoles.SelectedIndexChanged
        Llena_Usuarios_EnRol()
    End Sub

    Private Sub Llena_Usuarios_EnRol()
        Dim rol As String
        rol = lstTodosRoles.SelectedItem
        lstUsuariosEnRol.DataSource = Roles.GetUsersInRole(rol)
        Muestra_Usuarios_En_Rol()
    End Sub
    Private Sub tsbQuitarUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbQuitarUsuario.Click
        If Roles.IsUserInRole(Usuario, "SEGURIDAD: CONSULTA") = False Then
            cMensajes.DisplayMessage(Me, "Acceso no autorizado!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If
        Dim Buttons As Integer = MessageBoxButtons.YesNo

        Dim Result As DialogResult
        Result = MessageBox.Show(Me, "Desea eliminar del rol los usuarios seleccionados?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

        If Result = System.Windows.Forms.DialogResult.Yes Then
            Me.Cursor = Cursors.WaitCursor
            Dim i As Object
            Dim Rol As String
            Dim User As String = ""
            For Each i In lstUsuariosEnRol.SelectedItems
                User = i.ToString
                Rol = lstTodosRoles.SelectedItem
                Roles.RemoveUserFromRole(User, Rol)
                Llena_Usuarios_EnRol()
            Next
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub tsbOtorgaPermisos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbOtorgaPermisos.Click
        If Roles.IsUserInRole(Usuario, "Seguridad: Consulta") = False Then
            cMensajes.DisplayMessage(Me, "Acceso no autorizado!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If
        Me.Cursor = Cursors.WaitCursor
        Dim User As String = ""
        For Each Rol As String In lstTodosRoles.SelectedItems
            For Each DataRow In griAllUsers.Rows
                If DataRow.Cells("Check").Value = 1 Then
                    User = DataRow.Cells("proUserId").Value
                    If Not Roles.IsUserInRole(User, Rol) Then
                        Roles.AddUserToRole(User, Rol)
                    Else
                        'MsgBox("El usuario ya pertenece al Rol", MsgBoxStyle.Exclamation, Application.ProductName)
                    End If
                End If
            Next
        Next

        LlenaRolesPorUsuario()
        Llena_Usuarios_EnRol()
        MsgBox("Permisos Actualizados!", MsgBoxStyle.Exclamation, Application.ProductName)
        Me.Cursor = Cursors.Default
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAgregaRol.Click
        If Roles.IsUserInRole(Usuario, "Seguridad: Consulta") = False Then
            cMensajes.DisplayMessage(Me, "Acceso no autorizado!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If
        Roles.CreateRole(txtRol.Text)
        MsgBox("Rol ingresado!")
        txtRol.Text = ""
        txtRol.Focus()
    End Sub

    Private Sub griAllUsers_ClickCell(sender As Object, e As Infragistics.Win.UltraWinGrid.ClickCellEventArgs) Handles griAllUsers.ClickCell
        If griAllUsers.Selected.Rows.Count > 0 Then
            If Not IsDBNull(e.Cell.Row.Cells("Check").Value) Then
                Dim valor As Integer = e.Cell.Row.Cells("Check").Value
                If valor = -1 Then
                    e.Cell.Row.Cells("Check").Value = 0
                ElseIf valor = 1 Then
                    e.Cell.Row.Cells("Check").Value = 0

                Else
                    e.Cell.Row.Cells("Check").Value = 1
                End If
            End If
        End If
    End Sub

    Private Sub chkMarcaTodos_CheckedChanged(sender As Object, e As EventArgs) Handles chkMarcaTodos.CheckedChanged
        If chkMarcaTodos.Checked = True Then
            For Each DataRow In griAllUsers.Rows.GetFilteredInNonGroupByRows
                DataRow.Cells("Check").Value = 1
            Next
        Else
            For Each DataRow In griAllUsers.Rows
                DataRow.Cells("Check").Value = 0
            Next
        End If

    End Sub

    Private Sub tsb_Salir_Click(sender As Object, e As EventArgs) Handles tsb_Salir.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
        Me.Dispose()
    End Sub


    'Private Sub lstUsuariosEnRol_SelectedValueChanged(sender As Object, e As EventArgs) Handles lstUsuariosEnRol.SelectedValueChanged
    '    Dim Usuario As String
    '    griAllUsers.DisplayLayout.Bands(0).ColumnFilters.ClearAllFilters()

    '    For Each listUsuarios As String In lstUsuariosEnRol.Items
    '        Usuario = listUsuarios.ToString
    '        For Each DataRow In griAllUsers.Rows
    '            If DataRow.Cells("proUserId").Value = Usuario Then
    '                Me.griAllUsers.ActiveRow = DataRow
    '                DataRow.Cells("Check").Value = True
    '                'griAllUsers.ActiveRowScrollRegion.ScrollRowIntoView(DataRow)
    '            Else

    '            End If
    '        Next
    '    Next
    '    griAllUsers.DisplayLayout.Bands(0).ColumnFilters("Check").FilterConditions.Add(Infragistics.Win.UltraWinGrid.FilterComparisionOperator.Equals, 1)

    'End Sub
    Private Sub lstTodosRoles_SelectedValueChanged(sender As Object, e As EventArgs) Handles lstTodosRoles.SelectedValueChanged
        Muestra_Usuarios_En_Rol()
        'Dim Usuario As String
        ''griAllUsers.DisplayLayout.Bands(0).ColumnFilters.ClearAllFilters()
        'For Each DataRow In griAllUsers.Rows
        '    DataRow.Cells("Check").Value = False
        'Next
        'For Each listUsuarios As String In lstUsuariosEnRol.Items
        '    Usuario = listUsuarios.ToString
        '    For Each DataRow In griAllUsers.Rows
        '        If DataRow.Cells("proUserId").Value = Usuario Then
        '            Me.griAllUsers.ActiveRow = DataRow
        '            DataRow.Cells("Check").Value = True
        '            'griAllUsers.ActiveRowScrollRegion.ScrollRowIntoView(DataRow)
        '        End If
        '    Next
        'Next
        'griAllUsers.DisplayLayout.Bands(0).ColumnFilters("Check").FilterConditions.Add(Infragistics.Win.UltraWinGrid.FilterComparisionOperator.Equals, 1)

    End Sub

    Private Sub Muestra_Usuarios_En_Rol()
        Dim Usuario As String
        'griAllUsers.DisplayLayout.Bands(0).ColumnFilters.ClearAllFilters()
        For Each DataRow In griAllUsers.Rows
            DataRow.Cells("Check").Value = False
        Next
        For Each listUsuarios As String In lstUsuariosEnRol.Items
            Usuario = listUsuarios.ToString
            For Each DataRow In griAllUsers.Rows
                If DataRow.Cells("proUserId").Value = Usuario Then
                    Me.griAllUsers.ActiveRow = DataRow
                    DataRow.Cells("Check").Value = True
                    'griAllUsers.ActiveRowScrollRegion.ScrollRowIntoView(DataRow)
                End If
            Next
        Next
        griAllUsers.DisplayLayout.Bands(0).ColumnFilters("Check").FilterConditions.Add(Infragistics.Win.UltraWinGrid.FilterComparisionOperator.Equals, 1)

    End Sub

End Class