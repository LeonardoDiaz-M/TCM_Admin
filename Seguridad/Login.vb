Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing.Drawing2D
Imports System.Web
Imports System.Web.Security
Imports System.Web.Services
Imports System.Net.NetworkInformation

Public Class Login
    Dim clsNegocioUser_Profiles As New clsNegocioUser_Profiles
    Private Sub Login_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Opacity = 100
        Timer1.Enabled = True
        Infragistics.Win.AppStyling.StyleManager.Load("Metro.isl")

        Me.Opacity = 100
        Timer1.Enabled = True
    End Sub

    Public Function ValidaUsuario() As Boolean
        Try
            Dim userinfo As MembershipUser = Membership.GetUser(txtUsuario.Text)
            Dim MacAdress As String = ""
            Dim ValidaUbicacionUsuario As Boolean = False

            If Membership.FindUsersByName(txtUsuario.Text).Count = 0 Then
                MsgBox("La combinación de nombre de usuario/contraseña indicada, no corresponde con ningún usuario registrado. Inténtelo de nuevo", MsgBoxStyle.Critical, Application.ProductName)
            Else
                If Membership.ValidateUser(txtUsuario.Text, txtClaveAcceso.Text) Then
                    User_Valid = True
                    Usuario = txtUsuario.Text
                    Get_Profile_User(Usuario)
                    Contraseña = txtClaveAcceso.Text
                    Me.DialogResult = DialogResult.OK
                    Me.Hide()
                    Me.Close()
                Else
                    If userinfo.IsLockedOut = True Then
                        User_Valid = False
                        MsgBox("Tu cuenta ha sido bloqueada, has superado el numero máximo de intentos, contacte al Administrador del sistema", MsgBoxStyle.Critical, Application.ProductName)
                        Me.Close()
                        Me.Dispose()
                        End
                    Else
                        User_Valid = False
                        'UltraPictureBox2.Image = Image.FromFile(Application.StartupPath & "\Images\Alto.png")
                        MsgBox("La combinación de nombre de usuario/contraseña indicada no corresponde con ningún usuario registrado. Inténtelo de nuevo", MsgBoxStyle.Critical, Application.ProductName)
                    End If
                End If

            End If
        Catch ex As Exception
            MsgBox("Existe un problema con la conexión al servidor central, consulta al administrador del sistema!", MsgBoxStyle.Critical, Application.ProductName)
            Me.Close()
            Me.Dispose()
            End
        End Try
    End Function

    Private Function getMacAddress() As String
        Try
            Dim adapters As NetworkInterface() = NetworkInterface.GetAllNetworkInterfaces()
            Dim adapter As NetworkInterface
            Dim myMac As String = String.Empty

            For Each adapter In adapters
                Select Case adapter.NetworkInterfaceType
                    'Exclude Tunnels, Loopbacks and PPP
                    Case NetworkInterfaceType.Tunnel, NetworkInterfaceType.Loopback, NetworkInterfaceType.Ppp
                    Case Else
                        If Not adapter.GetPhysicalAddress.ToString = String.Empty And Not adapter.GetPhysicalAddress.ToString = "00000000000000E0" Then
                            myMac = adapter.GetPhysicalAddress.ToString
                            Exit For ' Got a mac so exit for
                        End If

                End Select
            Next adapter

            Return myMac
        Catch ex As Exception
            Return String.Empty
        End Try
    End Function


    Private Sub Get_Profile_User(ByVal User As String)
        Dim dtProfileUser As DataTable
        dtProfileUser = clsNegocioUser_Profiles.funGetUserProfiles(User)

        If dtProfileUser.Rows.Count = 0 Then
            MessageBox.Show("Existe un error en la configuración del Usuario, contacte al administrador del sistema", Application.ProductName, MessageBoxButtons.OK)
            Exit Sub
        Else
            With dtProfileUser.Rows(0)
                NombreUsuario = .Item("proNombres")
                txtNombreUsuario.Text = NombreUsuario
                DescripcionPuesto = .Item("pueDescripcion")
                NombreOficina = .Item("Oficina")
            End With
        End If
    End Sub



    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Opacity += 1

        If (Me.Opacity >= 0.99) Then
            Me.Opacity = 1
            Timer1.Enabled = False
            txtUsuario.Focus()
        End If
    End Sub

    Private Sub butIngresar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butIngresar.Click
        User_Valid = False
        If txtUsuario.Text = "" Then
            ErrorProvider1.SetError(txtUsuario, "Capture el usuario")
            txtUsuario.Focus()
        ElseIf txtClaveAcceso.Text = "" Then
            ErrorProvider1.SetError(txtClaveAcceso, "Capture la clave de acceso")
            txtClaveAcceso.Focus()
        Else
            ErrorProvider1.Clear()
            Me.Cursor = Cursors.WaitCursor
            ValidaUsuario()
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub butSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butSalir.Click
        User_Valid = False
        Me.DialogResult = DialogResult.Cancel
        End
        Hide()
    End Sub

    Private Sub txtClaveAcceso_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtClaveAcceso.KeyDown
        If e.KeyValue = Keys.Enter Then
            butIngresar.Focus()
        End If
    End Sub

    Private Sub txtUsuario_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtUsuario.KeyDown
        If e.KeyValue = Keys.Enter Then
            txtClaveAcceso.Focus()
        End If
    End Sub


End Class