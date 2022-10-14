Public Class frmLogin
    Private cxn As New cxnData
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If cxn.Select_SQL("select password from tbl_user where UserId='" & Me.UsernameTextBox.Text & "' and status=0") Then
            If StrComp(Me.PasswordTextBox.Text, cxn.arrayValores(0), CompareMethod.Binary) = 0 Then
                CurrentUsrName = Me.UsernameTextBox.Text.Trim
                Usuario = "ADMINISTRADOR"
                Me.Close()
            Else
                Me.lblError.Visible = True
                Me.lblError.Text = "Usuario y/o Password incorrecto..."
                CurrentUsrName = ""
            End If
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        CurrentUsrName = ""
        Me.Close()
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lblError.Visible = False
        CurrentUsrName = ""
    End Sub
End Class
