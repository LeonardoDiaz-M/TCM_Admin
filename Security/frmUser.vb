Imports Infragistics.Win.UltraWinTabControl
Imports System.ComponentModel
Public Class frmUser
    Public id As String = "0"
    Public delete_record As Boolean = False
    Public tipo_Permiso As Integer = 0
    Private cxn As New cxnData
    Private newrow As Object
    Public myparent As Form = Nothing
    Private pswreq As Boolean = False
    Private Sub frmUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsAgua.tbl_User' table. You can move, or remove it, as needed.
        Me.Tbl_UserTableAdapter.Fill(Me.DsAgua.tbl_User)
        'TODO: This line of code loads data into the 'DsAgua.tbl_Rol' table. You can move, or remove it, as needed.                
        cxn.Get_SQL_Combobox("SELECT * from tbl_rol where status=0", Me.cmbRol, "RolName", "idRol")
        If id <> "0" Then
            Me.BindingSource1.Position = Me.BindingSource1.Find("UserId", id)
        End If
        load_Permiso()
    End Sub
    Private Sub load_Permiso()
        Me.btnGuardar.Visible = False
        btnElimina.Visible = False
        Me.Text = "Detalle del Usuario "
        Dim idrol As String = ""
        If id <> "0" Then
            cxn.Select_SQL("select idRol,status from tbl_User where UserId='" & Me.txtUserId.Text.Trim & "'")
            idrol = cxn.arrayValores(0)
            Me.cmbRol.SelectedValue = idrol
            Me.txtPassword.Text = ""
            Me.txtPswConfirm.Text = ""
            Me.chkActive.Checked = IIf(cxn.arrayValores(1) = 0, True, False)
        End If
        If tipo_Permiso = 0 And Not delete_record Then 'Solo Lectura
            Me.grpDatosUsr.Enabled = False
        ElseIf tipo_Permiso = 1 And delete_record Then 'Eliminar Registro
            Me.grpDatosUsr.Enabled = False
            btnElimina.Visible = True
            btnUndo.Visible = True
        ElseIf tipo_Permiso = 1 And id <> "0" Then  'Actualizar Registro
            Me.grpDatosUsr.Enabled = True
            Me.btnGuardar.Visible = True
            btnUndo.Visible = True
            Me.txtUserId.Enabled = False
        ElseIf tipo_Permiso = 1 And id = "0" Then 'Agregar Registro
            Me.Text = "Nuevo Usuario"
            Me.grpDatosUsr.Enabled = True
            Me.btnGuardar.Visible = True
            Me.BindingNavigator1.BindingSource.AddNew()
            pswreq = True
        End If
    End Sub
    Private Function valida_datos() As Boolean
        Dim ban As Boolean = False
        Try
            If Me.txtPassword.Text.Trim = "" And Me.txtPswConfirm.Text.Trim = "" And id <> "0" Then
                pswreq = False
            End If
            If Me.txtUserId.Text.Trim.Length > 0 Then
                If Me.txtNombre.Text.Trim.Trim.Length > 0 Then
                    If Me.cmbRol.SelectedIndex > 0 Then
                        ban = True
                    Else
                        SystemMessages1.SysMsg("El campo ROL es requerido.", True)
                        Me.cmbRol.Focus()
                    End If
                Else
                    SystemMessages1.SysMsg("El campo Descripción es requerido.", True)
                    Me.txtNombre.Focus()
                End If
            Else
                SystemMessages1.SysMsg("El campo Rol es requerido.", True)
                Me.txtUserId.Focus()
            End If
            If pswreq Then
                ban = False
                If Me.txtPassword.Text.Trim <> "" Then
                    If Me.txtPassword.Text.Trim.Length >= 7 Then
                        If Me.txtPassword.Text.Trim.Any(AddressOf Char.IsUpper) Then
                            If Me.txtPassword.Text.Trim.Any(AddressOf Char.IsPunctuation) Then
                                If StrComp(Me.txtPassword.Text.Trim, Me.txtPswConfirm.Text.Trim, vbTextCompare) = 0 Then
                                    ban = True
                                Else
                                    SystemMessages1.SysMsg("El Password y la confirmación deben ser iguales ", True)
                                    Me.txtPassword.Focus()
                                End If
                            Else
                                SystemMessages1.SysMsg("El Password debe tener 1 Símbolo", True)
                                Me.txtPassword.Focus()
                            End If
                        Else
                            SystemMessages1.SysMsg("El Password debe tener 1 Mayúscula", True)
                            Me.txtPassword.Focus()
                        End If
                    Else
                        SystemMessages1.SysMsg("El Password debe tener al menos 7 caracteres.", True)
                        Me.txtPassword.Focus()
                    End If
                Else
                    SystemMessages1.SysMsg("El Password es requerido.", True)
                    Me.txtPassword.Focus()
                End If
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
                Me.Tbl_UserTableAdapter.Update(Me.DsAgua.tbl_User)
                SystemMessages1.SysMsg("Datos eliminados ", )
                MsgBox("Registro eliminado", MsgBoxStyle.Information, "Usuarios")
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
                    Me.BindingSource1.Current("Password") = Me.txtPassword.Text
                    id = Me.txtUserId.Text
                    Me.BindingSource1.Current("UserId") = id
                    Me.BindingSource1.Current("Status") = IIf(Me.chkActive.Checked, 0, 1)
                    Me.BindingSource1.EndEdit()
                    Me.Tbl_UserTableAdapter.Update(Me.DsAgua.tbl_User)
                    SystemMessages1.SysMsg("Datos actualizados ")
                Else
                    Tbl_UserTableAdapter.Insert(Me.txtUserId.Text.Trim.ToUpperInvariant, Me.txtNombre.Text.Trim.ToUpperInvariant, Me.cmbRol.SelectedIndex, Nothing, IIf(Me.chkActive.Checked, 0, 1), Me.txtPassword.Text)
                    Me.Tbl_UserTableAdapter.Update(Me.DsAgua.tbl_User)
                    SystemMessages1.SysMsg("Datos Registrados ")
                End If
                tipo_Permiso = 1
                frmUser_Load(Nothing, Nothing)
            End If
        Catch ex As Exception
            SystemMessages1.SysMsg(ex.Message, True)
        End Try
    End Sub
    Private Sub frmMovtosPadron_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim Maintab As UltraTabControl = TryCast(myparent.Controls.Find("UltraTabControl1", True).FirstOrDefault(), UltraTabControl)
        Maintab.Visible = True
        Dim Mainbar As ToolStrip = TryCast(myparent.Controls.Find("CommandBar", True).FirstOrDefault(), ToolStrip)
        Mainbar.Visible = True
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        If Me.txtPassword.Text.Trim <> "" Or Me.txtPswConfirm.Text.Trim <> "" Then
            pswreq = True
        End If
    End Sub
End Class