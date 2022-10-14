Public Class frmSubMenu
    Public id As String = "0"
    Public delete_record As Boolean = False
    Public tipo_Permiso As Integer = 0
    Private cxn As New cxnData
    Private newrow As Object
    Public parentMenu As String = ""
    Private Sub frmSubMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_Permiso()
    End Sub
    Private Sub load_Permiso()
        Me.btnGuardar.Visible = False
        Me.txtDesc.Enabled = False
        Me.chkStatus.Enabled = False
        Me.Text = "Detalle del SUB Menú: " & id.ToString
        If tipo_Permiso = 0 And Not delete_record Then 'Solo Lectura
            Me.txtDesc.Enabled = False
            Me.chkStatus.Enabled = False
            Me.lblCve.Text = "Clave del SUB Menú: " & id.ToString
            load_datos()
        ElseIf tipo_Permiso = 1 And id <> "0" Then  'Actualizar Registro
            Me.txtDesc.Enabled = True
            Me.btnGuardar.Visible = True
            chkStatus.Visible = True
            Me.chkStatus.Enabled = True
            Me.lblCve.Text = "Clave del SUB Menú: " & id.ToString
            load_datos()
        ElseIf tipo_Permiso = 1 And id = "0" Then 'Agregar Registro
            Me.Text = "Nuevo SUB Menú"
            Me.txtDesc.Enabled = True
            Me.lblCve.Text = "Clave del SUB Menú: "
            Me.btnGuardar.Visible = True
            Me.chkStatus.Visible = False
        End If
    End Sub
    Private Sub load_datos()
        Dim cxn2 As New cxnData
        cxn2.Select_SQL("select * from tbMainSubMenus where SubMenu='" & id & "'")
        Me.lblCve.Text = "Clave del SUB Menú: " & id.ToUpperInvariant
        Me.txtDesc.Text = cxn2.arrayValores(1).ToUpperInvariant
        Me.chkStatus.Checked = IIf(cxn2.arrayValores(4) = "0", True, False)
        If cxn2.arrayValores(0) IsNot Nothing Then
            Me.chkRead.Checked = IIf(cxn2.arrayValores(5) = "True", True, False)
            Me.chkAdd.Checked = IIf(cxn2.arrayValores(6) = "True", True, False)
            Me.chkDelete.Checked = IIf(cxn2.arrayValores(7) = "True", True, False)
            Me.chkAdd.Checked = IIf(cxn2.arrayValores(8) = "True", True, False)
            Me.chkModal.Checked = IIf(cxn2.arrayValores(9) = "True", True, False)
        End If
        Me.cxn.Select_SQL("Select * from tbMainMenu where menuNam='" & parentMenu & "'")
        Me.lblRoot.Text = "Menú Padre: " & cxn.arrayValores(0) & " - " & cxn.arrayValores(1)
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
    Private Sub txtDesc_TextChanged(sender As Object, e As EventArgs) Handles txtDesc.TextChanged
        Try
            If cxn.Select_SQL("Select LEFT('000' + convert(varchar(3), COUNT(*)), 3)  from tbMainSubMenus  where SubMenu like '" & Me.txtDesc.Text.Trim.Substring(1, 3) & "%'") Then
                Me.lblCve.Text = "Clave del SUB Menú: " & Me.txtDesc.Text.Trim.Substring(0, 3).ToUpperInvariant & cxn.arrayValores(0)
                Me.id = Me.txtDesc.Text.Trim.Substring(0, 3) & cxn.arrayValores(0)
                valida_datos()
            Else
                valida_datos()
            End If
        Catch ex As Exception
            valida_datos()
        End Try
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If valida_datos() Then
                cxn.Select_SQL("select * from tbMainSubMenus where SubMenu='" & id & "'")
                If cxn.arrayValores(0) IsNot Nothing Then
                    Me.Validate()
                    If Me.cxn.Select_SQL("update tbMainSubMenus set 
                                                Description='" & Me.txtDesc.Text.Trim & "'," &
                                                "Status=" & IIf(Me.chkStatus.Checked, "0", "1") & "," &
                                                "ReadOpt=" & IIf(Me.chkRead.Checked, "0", "1") & "," &
                                                "AddOpt=" & IIf(Me.chkAdd.Checked, "0", "1") & "," &
                                                "DelOpt=" & IIf(Me.chkDelete.Checked, "0", "1") & "," &
                                                "UpdOpt=" & IIf(Me.chkEdit.Checked, "0", "1") & "," &
                                                "IsModal=" & IIf(Me.chkModal.Checked, "0", "1") &
                                         "where SubMenu='" & id & "'") Then
                        SystemMessages1.SysMsg("Datos actualizados ")
                    Else
                        SystemMessages1.SysMsg("Ocurrió un error al actualizar los datos:" & cxn.arrayValores(0))
                    End If
                Else
                    If Me.cxn.Select_SQL("insert into tbMainSubMenus (SubMenu,Parent,Description, Status,ReadOpt,AddOpt,DelOpt,UpdOpt,IsModal) values ('" &
                                         id & "','" & parentMenu & "'," &
                                         "'" & Me.txtDesc.Text.Trim & "'," &
                                         IIf(Me.chkStatus.Checked, 0, 1) & "," &
                                         IIf(Me.chkRead.Checked, 0, 1) & "," &
                                         IIf(Me.chkAdd.Checked, 0, 1) & "," &
                                         IIf(Me.chkDelete.Checked, 0, 1) & "," &
                                         IIf(Me.chkEdit.Checked, 0, 1) & "," &
                                         IIf(Me.chkModal.Checked, 0, 1) & ")"
                                         ) Then
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
End Class