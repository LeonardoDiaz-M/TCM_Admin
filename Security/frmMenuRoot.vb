Public Class frmMenuRoot
    Public id As String = "0"
    Public delete_record As Boolean = False
    Public tipo_Permiso As Integer = 0
    Private cxn As New cxnData
    Private newrow As Object
    Private Sub frmMenuRoot_Load(sender As Object, e As EventArgs) Handles Me.Load
        load_Permiso()
    End Sub
    Private Sub load_Permiso()
        Me.btnGuardar.Visible = False
        Me.txtDesc.Enabled = False
        Me.chkStatus.Enabled = False
        Me.Text = "Detalle del Menú: " & id.ToString
        If tipo_Permiso = 0 And Not delete_record Then 'Solo Lectura
            Me.txtDesc.Enabled = False
            Me.chkStatus.Enabled = False
            Me.lblCve.Text = "Clave del Menú: " & id.ToString
            load_datos()
        ElseIf tipo_Permiso = 1 And id <> "0" Then  'Actualizar Registro
            Me.txtDesc.Enabled = True
            Me.btnGuardar.Visible = True
            chkStatus.Visible = True
            Me.lblCve.Text = "Clave del Menú: " & id.ToString
            load_datos()
        ElseIf tipo_Permiso = 1 And id = "0" Then 'Agregar Registro
            Me.Text = "Nuevo Menú"
            Me.txtDesc.Enabled = True
            Me.lblCve.Text = "Clave del Menú: "
            Me.btnGuardar.Visible = True
            Me.chkStatus.Visible = False
        End If
    End Sub
    Private Sub load_datos()
        cxn.Select_SQL("select * from tbMainMenu where MenuNam='" & id & "'")
        Me.txtDesc.Text = cxn.arrayValores(1).ToUpperInvariant
        Me.lblCve.Text = "Clave del Menú: " & id.ToUpperInvariant
        Me.chkStatus.Checked = IIf(cxn.arrayValores(3) = "0", True, False)
    End Sub
    Private Function valida_datos() As Boolean
        Dim ban As Boolean = False
        Try
            If Me.txtDesc.Text.Trim.Length >= 3 Then
                ban = True
            Else
                SystemMessages1.SysMsg("El campo Título del menú es requerido y debe contener al menos 3 caracteres.", True)
                Me.txtDesc.Focus()
            End If
        Catch ex As Exception

        End Try
        Return ban
    End Function
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If valida_datos() Then
                cxn.Select_SQL("select * from tbMainMenu where MenuNam='" & id & "'")
                If cxn.arrayValores(0) IsNot Nothing Then
                    Me.Validate()
                    If Me.cxn.Select_SQL("update tbMainMenu set Description='" & Me.txtDesc.Text.Trim &
                                         "' where MenuNam='" & id & "'") Then
                        SystemMessages1.SysMsg("Datos actualizados ")
                    Else
                        SystemMessages1.SysMsg("Ocurrió un error al actualizar los datos:" & cxn.arrayValores(0))
                    End If
                Else
                    If Me.cxn.Select_SQL("insert into tbMainMenu (MenuNam, Description, Status) values ('" &
                                         id & "','" & Me.txtDesc.Text.Trim & "','" &
                                         IIf(Me.chkStatus.Checked, 0, 1) & "')") Then
                        SystemMessages1.SysMsg("Datos Registrados ")
                    Else
                        SystemMessages1.SysMsg("Ocurrió un error al actualizar los datos:" & cxn.arrayValores(0))
                    End If
                End If
            End If
        Catch ex As Exception
            SystemMessages1.SysMsg(ex.Message, True)
        End Try
    End Sub

    Private Sub txtDesc_TextChanged(sender As Object, e As EventArgs) Handles txtDesc.TextChanged
        Try
            If cxn.Select_SQL("Select LEFT('000' + convert(varchar(3), COUNT(*)), 3)  from tbMainMenu  where MenuNam like '" & Me.txtDesc.Text.Trim.Substring(1, 3) & "%'") Then
                Me.lblCve.Text = "Clave del Menú: " & Me.txtDesc.Text.Trim.Substring(0, 3).ToUpperInvariant & cxn.arrayValores(0)
                Me.id = Me.txtDesc.Text.Trim.Substring(0, 3) & cxn.arrayValores(0)
                valida_datos()
            Else
                valida_datos()
            End If
        Catch ex As Exception
            valida_datos()
        End Try
    End Sub

End Class