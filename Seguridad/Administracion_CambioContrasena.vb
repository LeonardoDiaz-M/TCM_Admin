Imports System.Web
Imports System.Web.Security
Public Class Administracion_CambioContrasena
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
    Private Sub Administracion_CambioContrasena_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtUser.Text = Usuario

    End Sub
    Private Sub tsb_Salir_Click(sender As Object, e As EventArgs) Handles tsb_Salir.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub tsb_Guardar_Click(sender As Object, e As EventArgs) Handles tsb_Guardar.Click
        Dim Usuario_Validado As Boolean = False
        If valida_datos() = False Then

            If Membership.ValidateUser(txtUser.Text, txtContraseña.Text) Then
                Usuario_Validado = True
            End If

            If Usuario_Validado = True Then
                Dim User As MembershipUser
                User = Membership.GetUser(Usuario, True)
                User.ChangePassword(txtContraseña.Text, txtContraseñaNueva.Text)
                cMensajes.DisplayMessage(Me, "Contraseña cambiada correctamente!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Me.Close()
                Me.Dispose()
            Else
                cMensajes.DisplayMessage(Me, "Contraseña Inválida, Intente Nuevamente!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                txtContraseña.Focus()
                txtContraseña.SelectAll()
            End If
        End If
    End Sub

    Public Function fValidaCampos() As Boolean
        erpError.Clear()
        fValidaCampos = False

        If Me.txtContraseña.Text.Trim = vbNullString Then
            erpError.SetError(txtContraseña, "Es necesario capturar la contraseña actual")
            txtContraseña.Focus()
            Exit Function
        End If

        If Me.txtContraseñaNueva.Text.Trim = vbNullString Then
            erpError.SetError(txtContraseñaNueva, "Es necesario capturar la contraseña nueva")
            txtContraseñaNueva.Focus()
            Exit Function
        End If

        If Me.txtConfirmaContraseñaNueva.Text.Trim = vbNullString Then
            erpError.SetError(txtConfirmaContraseñaNueva, "Es necesario capturar la confirmacion de la contraseña")
            txtConfirmaContraseñaNueva.Focus()
            Exit Function
        End If

        If Me.txtContraseñaNueva.Text.Trim <> txtConfirmaContraseñaNueva.Text.Trim Then
            erpError.SetError(txtContraseñaNueva, "No coinciden las contraseñas proporcionadas")
            erpError.SetError(txtConfirmaContraseñaNueva, "No coinciden las contraseñas proporcionadas")
            cMensajes.DisplayMessage(Me, "No coinciden las contraseñas proporcionadas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            txtConfirmaContraseñaNueva.Focus()
            Exit Function
        End If
        fValidaCampos = True
    End Function

    Private Function valida_datos() As Boolean
        Dim ban As Boolean = False
        Dim ocurriounError As Integer = 0
        Dim mensaje As String = ""
        Try
            erpError.Clear()
            'cuenta

            If Me.txtContraseña.Text.Trim = vbNullString Then
                erpError.SetError(txtContraseña, "Error")
                ocurriounError += 1
                mensaje += "- " & "Es necesario capturar la contraseña actual.." & "<br />"
                txtContraseña.SelectAll()
            End If

            If Me.txtContraseñaNueva.Text.Trim = vbNullString Then
                erpError.SetError(txtContraseñaNueva, "Error")
                ocurriounError += 1
                mensaje += "- " & "Es necesario capturar la contraseña nueva.." & "<br />"
                txtContraseñaNueva.SelectAll()
            End If

            If Me.txtConfirmaContraseñaNueva.Text.Trim = vbNullString Then
                erpError.SetError(txtConfirmaContraseñaNueva, "Error")
                ocurriounError += 1
                mensaje += "- " & "Es necesario capturar la confirmacion de la contraseña.." & "<br />"
                txtConfirmaContraseñaNueva.SelectAll()

            End If

            If Me.txtContraseñaNueva.Text.Trim <> txtConfirmaContraseñaNueva.Text.Trim Then
                erpError.SetError(txtContraseñaNueva, "Error")
                erpError.SetError(txtConfirmaContraseñaNueva, "Error")
                ocurriounError += 1
                mensaje += "- " & "La confirmación de contraseña ingresada no coincide.." & "<br />"
                txtConfirmaContraseñaNueva.SelectAll()
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

End Class