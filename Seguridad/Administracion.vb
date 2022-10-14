Imports System.Web
Imports System.Web.Security
Imports System.Web.Services
Imports System.Globalization
Imports System.Text.RegularExpressions
Imports System.Web.Configuration


Public Class Administracion

#Region "Usuarios"
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


    Dim invalid As Boolean = False
    Dim ValidaUbicacion As Boolean = False
    Private clsNegocioUser_Profiles As New clsNegocioUser_Profiles
    Private Sub User_Profiles_Load(sender As Object, e As EventArgs) Handles Me.Load
        griAllUsers.DataSource = clsNegocioUser_Profiles.funGetAllUserProfiles
        Me.griAllUsers.Text = "Total registros encontrados: " & griAllUsers.Rows.FilteredInRowCount
        sLlenaComboPuestos()
        sLlenaComboSucursales()
    End Sub

    Private Sub griAllUsers_AfterRowFilterChanged(sender As Object, e As Infragistics.Win.UltraWinGrid.AfterRowFilterChangedEventArgs) Handles griAllUsers.AfterRowFilterChanged
        Me.griAllUsers.Text = "Total registros encontrados: " & griAllUsers.Rows.FilteredInRowCount
    End Sub


    Private Sub tsbGuardaUsuario_Click(sender As Object, e As EventArgs) Handles tsbGuardaUsuario.Click
        Try
            Dim IdOficina As String = ""

            If chkValidaUbicacion.CheckState = CheckState.Checked Then
                ValidaUbicacion = True
            Else
                ValidaUbicacion = False
            End If

            If ucoOficina.IsItemInList = False Then
                IdOficina = ""
            Else
                IdOficina = ucoOficina.Value
            End If

            If txtOperacion.Text = "ALTA" Then

                ' Create new user.
                If fValidaCampos() = False Then Exit Sub

                If Roles.IsUserInRole(Usuario, "Seguridad: Consulta") = False Then
                    cMensajes.DisplayMessage(Me, "Acceso no autorizado!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    Exit Sub
                End If

                Me.Cursor = Cursors.WaitCursor

                Dim createStatus As MembershipCreateStatus
                Dim newUser As MembershipUser = Membership.CreateUser(txtUser.Text, txtContraseña.Text, txtEmail.Text, txtPreguntaSecreta.Text, txtRespuestaAPregunta.Text, True, createStatus)

                Select Case (createStatus)
                    Case MembershipCreateStatus.Success
                        clsNegocioUser_Profiles.funSetUserProfiles("i", txtUser.Text, txtNombres.Text, txtPaterno.Text, txtMaterno.Text, ucoPuesto.Value, IdOficina, txtTelefono.Text, txtNumeroCaja.Text, NombreUsuario, ValidaUbicacion)
                        cMensajes.DisplayMessage(Me, "Cuenta creada correctamente!!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    Case MembershipCreateStatus.DuplicateUserName
                        cMensajes.DisplayMessage(Me, "Actualmente existe un registro con ese nombre de Usuario!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                        Exit Sub
                    Case MembershipCreateStatus.InvalidQuestion
                        cMensajes.DisplayMessage(Me, "la pregunta secreta suministrada es invalida!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                        Exit Sub
                    Case MembershipCreateStatus.InvalidAnswer
                        cMensajes.DisplayMessage(Me, "La respuesta a la pregunta de seguridad es invalida!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                        Exit Sub
                    Case MembershipCreateStatus.InvalidPassword
                        cMensajes.DisplayMessage(Me, "La contraseña suministrada es invalida!,  deberá tener 7 caracteres mínimo y ser alfanumérica!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                        Exit Sub
                    Case Else
                        cMensajes.DisplayMessage(Me, "Existe un error desconocido; El Usuario no fué creado!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                        Exit Sub
                End Select

            Else
                If fValidaModificacionCampos() = False Then Exit Sub

                If Roles.IsUserInRole(Usuario, "SEGURIDAD: CONSULTA") = False Then
                    cMensajes.DisplayMessage(Me, "Acceso no autorizado!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    Exit Sub
                End If

                Me.Cursor = Cursors.WaitCursor
                clsNegocioUser_Profiles.funSetUserProfiles("U", txtUser.Text, txtNombres.Text, txtPaterno.Text, txtMaterno.Text, ucoPuesto.Value, IdOficina, txtTelefono.Text, txtNumeroCaja.Text, NombreUsuario, ValidaUbicacion)
                Me.Cursor = Cursors.Default
                cMensajes.DisplayMessage(Me, "Cuenta Modificada correctamente!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

            End If
            griAllUsers.DataSource = clsNegocioUser_Profiles.funGetAllUserProfiles
            tsbGuardaUsuario.Visible = False
            tsbModificarUsuario.Visible = True
            panDatosUsuario.Enabled = False
        Catch eX As Exception
            MessageBox.Show(eX.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub griAllUsers_DoubleClickRow(sender As Object, e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles griAllUsers.DoubleClickRow
        Activa_Formulario(False)

        txtOperacion.Text = "Editar"
        Me.txtUser.Text = e.Row.Cells("proUserId").Value
        Me.txtNombres.Text = e.Row.Cells("proNombres").Value
        Me.txtPaterno.Text = e.Row.Cells("proApellidoPaterno").Value
        Me.txtMaterno.Text = e.Row.Cells("proApellidoMaterno").Value
        Me.ucoOficina.Value = e.Row.Cells("proIdOficina").Value
        Me.ucoPuesto.Value = e.Row.Cells("proIdPuesto").Value
        Me.txtTelefono.Text = e.Row.Cells("proTelefono").Value
        Me.chkValidaUbicacion.Checked = e.Row.Cells("proValidaUbicacion").Value
        Me.txtNumeroCaja.Text = e.Row.Cells("proNumeroCaja").Value

        Me.txtEmail.Text = e.Row.Cells("Email").Value
        Me.chkStatus.Checked = e.Row.Cells("IsApproved").Value
        Me.chkBloqueado.Checked = e.Row.Cells("IsLockedOut").Value
        Me.txtEmail.Text = e.Row.Cells("Email").Value


        Me.txtFechaCreacion.Text = e.Row.Cells("CreateDate").Value
        Me.txtUltimoAcceso.Text = e.Row.Cells("LastLoginDate").Value
        Me.txtUltimoCambioClave.Text = e.Row.Cells("LastPasswordChangedDate").Value
        Me.txtUltimoBloqueo.Text = e.Row.Cells("LastLockoutDate").Value
        Me.txtIntentosErroneos.Text = e.Row.Cells("FailedPasswordAttemptCount").Value
        Me.txtUltimaActividad.Text = e.Row.Cells("LastActivityDate").Value

        tabSecurity.Tabs("tabALtaUsuario").Selected = True
        Me.tsbModificarUsuario.Visible = True
        Me.tsbGuardaUsuario.Visible = False

        Me.tsbDesbloquear.Visible = True
        Me.tsbEliminaUsuario.Visible = True
        Me.tsbBloquear.Visible = True

        panDatosUsuario.Enabled = False

        erpError.Clear()

    End Sub

    Public Function fValidaCampos() As Boolean
        erpError.Clear()
        fValidaCampos = False
        If Me.txtUser.Text.Trim = vbNullString Then
            erpError.SetError(txtUser, "Es necesario capturar el usuario")
            txtUser.Focus()
            Exit Function
        End If

        If Me.txtContraseña.Text.Trim = vbNullString Then
            erpError.SetError(txtContraseña, "Es necesario capturar la contraseña")
            txtContraseña.Focus()
            Exit Function
        End If

        'If Me.txtEmail.Text.Trim = vbNullString Then
        '    erpError.SetError(txtEmail, "Es necesario capturar el correo electrónico")
        '    txtEmail.Focus()
        '    Exit Function
        'End If

        'If IsValidEmail(txtEmail.Text) = False Then
        '    erpError.SetError(txtEmail, "Es necesario capturar el correo electrónico en un formato válido")
        '    txtEmail.Focus()
        '    Exit Function
        'End If

        If Me.txtPreguntaSecreta.Text.Trim = vbNullString Then
            erpError.SetError(txtPreguntaSecreta, "Es necesario capturar la pregunta secreta")
            txtPreguntaSecreta.Focus()
            Exit Function
        End If

        If Me.txtRespuestaAPregunta.Text.Trim = vbNullString Then
            erpError.SetError(txtRespuestaAPregunta, "Es necesario capturar la respuesta a la pregunta secreta")
            txtRespuestaAPregunta.Focus()
            Exit Function
        End If

        If Me.txtNombres.Text.Trim = vbNullString Then
            erpError.SetError(txtNombres, "Es necesario capturar el nombre")
            txtNombres.Focus()
            Exit Function
        End If

        If Me.txtPaterno.Text.Trim = vbNullString Then
            erpError.SetError(txtPaterno, "Es necesario capturar el apellido paterno")
            txtPaterno.Focus()
            Exit Function
        End If


        If Me.ucoPuesto.IsItemInList = False Then
            erpError.SetError(ucoPuesto, "Es necesario seleccionar el puesto")
            ucoPuesto.Focus()
            Exit Function
        End If

        If Me.ucoOficina.IsItemInList = False Then
            erpError.SetError(ucoOficina, "Es necesario seleccionar la oficina")
            ucoOficina.Focus()
            Exit Function
        End If

        fValidaCampos = True
    End Function

    Public Function fValidaModificacionCampos() As Boolean
        erpError.Clear()
        fValidaModificacionCampos = False
        If Me.txtUser.Text.Trim = vbNullString Then
            erpError.SetError(txtUser, "Es necesario capturar el usuario")
            txtUser.Focus()
            Exit Function
        End If


        If Me.txtNombres.Text.Trim = vbNullString Then
            erpError.SetError(txtNombres, "Es necesario capturar el nombre")
            txtNombres.Focus()
            Exit Function
        End If

        If Me.txtPaterno.Text.Trim = vbNullString Then
            erpError.SetError(txtPaterno, "Es necesario capturar el apellido paterno")
            txtPaterno.Focus()
            Exit Function
        End If

        If Me.ucoPuesto.IsItemInList = False Then
            erpError.SetError(ucoPuesto, "Es necesario seleccionar el puesto")
            ucoPuesto.Focus()
            Exit Function
        End If

        If Me.ucoOficina.IsItemInList = False Then
            erpError.SetError(ucoOficina, "Es necesario seleccionar la oficina")
            ucoOficina.Focus()
            Exit Function
        End If

        fValidaModificacionCampos = True
    End Function

    Private Function DomainMapper(match As Match) As String
        ' IdnMapping class with default property values. 
        Dim idn As New IdnMapping()

        Dim domainName As String = match.Groups(2).Value
        Try
            domainName = idn.GetAscii(domainName)
        Catch e As ArgumentException
            invalid = True
        End Try
        Return match.Groups(1).Value + domainName
    End Function
#End Region


    Private Sub tsbDesbloquear_Click(sender As Object, e As EventArgs) Handles tsbDesbloquear.Click
        If Roles.IsUserInRole(Usuario, "SEGURIDAD: CONSULTA") = False Then
            cMensajes.DisplayMessage(Me, "Acceso no autorizado!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If

        If txtUser.Text = "" Then
            MessageBox.Show("Seleccione o Ingrese un nombre de Usuario Válido")
            Exit Sub
        End If
        Usuario = txtUser.Text
        Dim Userinfo As MembershipUser = Membership.GetUser(Usuario)
        Userinfo.UnlockUser()
        'griAllUsers.DataSource = clsNegocioUser_Profiles.funGetAllUserProfiles.Tables(0)
        txtIntentosErroneos.Text = "0"
        chkBloqueado.Checked = False
        MessageBox.Show("Usuario desbloqueado correctamente!")
    End Sub

    Private Sub tsb_Agregar_Click(sender As Object, e As EventArgs) Handles tsb_Agregar.Click
        Alta_Usuario()
    End Sub

    Private Sub tsb_Modificar_Click(sender As Object, e As EventArgs)
        txtOperacion.Text = "Editar"
        'Activa_Formulario(False)

        If griAllUsers.Selected.Rows.Count > 0 Then
            For Each DataRow In griAllUsers.Selected.Rows
                Me.txtUser.Text = DataRow.Cells("proUserId").Value
                Me.txtNombres.Text = DataRow.Cells("proNombres").Value
                Me.txtPaterno.Text = DataRow.Cells("proApellidoPaterno").Value
                Me.txtMaterno.Text = DataRow.Cells("proApellidoMaterno").Value
                Me.ucoOficina.Value = DataRow.Cells("proIdSucursal").Value
                Me.ucoPuesto.Value = DataRow.Cells("proIdPuesto").Value
                Me.txtTelefono.Text = DataRow.Cells("proTelefono").Value

                Me.txtEmail.Text = DataRow.Cells("Email").Value
                Me.chkStatus.Checked = DataRow.Cells("IsApproved").Value
                Me.chkBloqueado.Checked = DataRow.Cells("IsLockedOut").Value
                Me.txtEmail.Text = DataRow.Cells("Email").Value

                Me.txtFechaCreacion.Text = DataRow.Cells("CreateDate").Value
                Me.txtUltimoAcceso.Text = DataRow.Cells("LastLoginDate").Value
                Me.txtUltimoCambioClave.Text = DataRow.Cells("LastPasswordChangedDate").Value
                Me.txtUltimoBloqueo.Text = DataRow.Cells("LastLockoutDate").Value
                Me.txtIntentosErroneos.Text = DataRow.Cells("FailedPasswordAttemptCount").Value
                Me.txtUltimaActividad.Text = DataRow.Cells("LastActivityDate").Value

                tsbDesbloquear.Visible = True
                tsbEliminaUsuario.Visible = True
                tsbBloquear.Visible = True

            Next

            griAllUsers.Selected.Rows.Clear()
            tabSecurity.Tabs("tabALtaUsuario").Selected = True
            txtUser.Focus()
            txtUser.SelectAll()

        End If
    End Sub

    Private Sub tsb_Salir_Click(sender As Object, e As EventArgs) Handles tsb_Salir.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub tsb_Exportar_Click(sender As Object, e As EventArgs) Handles tsb_Exportar.Click
        Dim sfd As New SaveFileDialog

        If griAllUsers.Rows.Count > 0 Then
            With sfd
                .Title = "Ingresa el nombre del archivo a exportar"
                .Filter = "Excel files (*.xls)|*.xls|All files (*.*)|*.*"
                .ShowDialog()
                If .FileName <> "" Then
                    Me.Cursor = Cursors.WaitCursor
                    ugeExporter.Export(griAllUsers, .FileName)
                    Me.Cursor = Cursors.Default
                    MsgBox("Datos exportados correctamente!", MsgBoxStyle.Information, "Consulta")
                End If
            End With
        Else
            MessageBox.Show("No existen registros a exportar", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub tsbAgregaUsuario_Click(sender As Object, e As EventArgs) Handles tsbAgregaUsuario.Click
        Alta_Usuario()
    End Sub
    Private Sub Alta_Usuario()
        txtOperacion.Text = "Alta"
        tabSecurity.Tabs("tabALtaUsuario").Selected = True
        Activa_Formulario(False)
        Me.tsbGuardaUsuario.Visible = True
        Me.tsbModificarUsuario.Visible = False
        Me.tsbDesbloquear.Visible = False
        Me.tsbEliminaUsuario.Visible = False
        Me.tsbBloquear.Visible = False
        txtUser.ReadOnly = False
        panDatosUsuario.Enabled = True
        erpError.Clear()
        txtUser.Focus()
        txtUser.SelectAll()
    End Sub

    Private Sub Activa_Formulario(ByRef Activo As Boolean)
        Me.txtNombres.Text = ""
        Me.txtPaterno.Text = ""
        Me.txtMaterno.Text = ""
        Me.ucoPuesto.Value = ""
        Me.ucoOficina.Value = ""
        Me.txtTelefono.Text = ""
        Me.txtUser.Text = ""
        Me.txtContraseña.Text = ""
        Me.txtEmail.Text = ""
        Me.txtPreguntaSecreta.Text = ""
        Me.txtRespuestaAPregunta.Text = ""

        Me.txtNombres.ReadOnly = Activo
        Me.txtPaterno.ReadOnly = Activo
        Me.txtMaterno.ReadOnly = Activo
        Me.ucoPuesto.ReadOnly = Activo
        Me.ucoOficina.ReadOnly = Activo
        Me.txtTelefono.ReadOnly = Activo
        Me.txtNumeroCaja.ReadOnly = Activo
        'Me.txtUser.ReadOnly = Activo
        Me.txtContraseña.ReadOnly = Activo
        Me.txtEmail.ReadOnly = Activo
        Me.txtPreguntaSecreta.ReadOnly = Activo
        Me.txtRespuestaAPregunta.ReadOnly = Activo

        Me.chkStatus.Checked = True
        Me.chkBloqueado.Checked = False
        Me.txtFechaCreacion.Text = ""
        Me.txtUltimoAcceso.Text = ""
        Me.txtUltimoCambioClave.Text = ""
        Me.txtUltimoBloqueo.Text = ""
        Me.txtIntentosErroneos.Text = ""
        Me.txtUltimaActividad.Text = ""
        'Me.tsbGuardaUsuario.Visible = False
        'Me.tsbModificarUsuario.Visible = False
    End Sub




    Private Sub tsbModificarUsuario_Click(sender As Object, e As EventArgs) Handles tsbModificarUsuario.Click
        ' edit user.
        tsbModificarUsuario.Visible = False
        panDatosUsuario.Enabled = True
        tsbGuardaUsuario.Visible = True
    End Sub

    Private Sub tsbEliminaUsuario_Click(sender As Object, e As EventArgs) Handles tsbEliminaUsuario.Click
        If Roles.IsUserInRole(Usuario, "SEGURIDAD: CONSULTA") = False Then
            cMensajes.DisplayMessage(Me, "Acceso no autorizado!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If

        If txtUser.Text = "" Then
            MessageBox.Show("Seleccione o Ingrese un nombre de Usuario Válido")
            Exit Sub
        End If

        Dim result As DialogResult = MessageBox.Show("Esta seguro de borrar el usuario", Application.ProductName, MessageBoxButtons.YesNo)
        'If result = Windows.Forms.DialogResult.No Then

        'Else

        If chkValidaUbicacion.CheckState = CheckState.Checked Then
            ValidaUbicacion = True
        Else
            ValidaUbicacion = False
        End If
        Membership.DeleteUser(txtUser.Text.Trim, True)
        'Membership.DeleteUser(txtUser.Text)
        'clsNegocioUser_Profiles.funSetUserProfiles("D", txtUser.Text, txtNombres.Text, txtPaterno.Text, txtMaterno.Text, ucoSucursal.Value, ucoPuesto.Value, txtTelefono.Text, ValidaUbicacion, NombreUsuario)
        'griAllUsers.DataSource = clsNegocioUser_Profiles.funGetAllUserProfiles.Tables(0)
        Activa_Formulario(True)
        cMensajes.DisplayMessage(Me, "Usuario Eliminado!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

        'End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles tsbBloquear.Click
        If txtUser.Text = "" Then
            MessageBox.Show("Seleccione o Ingrese un nombre de Usuario Válido")
            Exit Sub
        End If


        If 0 < Membership.MaxInvalidPasswordAttempts AndAlso Membership.MaxInvalidPasswordAttempts < 100 Then
            For i As Integer = 0 To Membership.MaxInvalidPasswordAttempts
                Membership.ValidateUser(txtUser.Text, "jfdlsjflksjlkfjsdlkfjsdl")
            Next
        End If
        txtIntentosErroneos.Text = "3"
        chkBloqueado.Checked = True
        MessageBox.Show("El usuario fué  bloqueado!")
    End Sub

    Private Sub Administracion_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Dim nextControl As Control

        If e.KeyCode = Keys.Enter Then
            nextControl = GetNextControl(ActiveControl, Not e.Shift)
            If nextControl Is Nothing Then
                nextControl = GetNextControl(Nothing, True)
            End If
            nextControl.Focus()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub sLlenaComboSucursales()
        Try
            cxn.fLlenaDropDownUltra(ucoOficina, "Select comun, nombre from Oficinas")
        Catch ex As Exception
            MessageBox.Show("Error al llenar el combo Categoría", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    Private Sub sLlenaComboPuestos()
        Try
            cxn.fLlenaDropDownUltra(Me.ucoPuesto, "Select pueId,pueDescripcion from puestos")
        Catch ex As Exception
            MessageBox.Show("Error al llenar el combo Categoría", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub tsbRegresar_Click(sender As Object, e As EventArgs) Handles tsbRegresar.Click
        tabSecurity.Tabs("tabUsuarios").Selected = True
    End Sub
End Class