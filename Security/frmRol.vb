Imports Infragistics.Win.UltraWinTabControl
Imports System.ComponentModel
Public Class frmRol
    Public id As String = "0"
    Public delete_record As Boolean = False
    Public tipo_Permiso As Integer = 0
    Private cxn As New cxnData
    Private newrow As Object
    Public myparent As Form = Nothing
    Private treeloading As Boolean = True
    Private Sub frmCatTipoinmueble_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsAgua.tipo_inmueble' Puede moverla o quitarla según sea necesario.
        Me.Tbl_RolTableAdapter.Fill(Me.DsAgua.tbl_Rol)
        Me.BindingSource1.Position = Me.BindingSource1.Find("idRol", id)
        Me.cxn.load_parents(Me.TreeView1, "select MenuNam,Description from tbMainMenu where status=0")
        Me.cxn.load_childs(Me.TreeView1, "select submenu,submenu + ' - '+Description, readopt,addopt,delopt,updopt from tbMainSubMenus where status=0 and parent='<%PARENT%>'")
        load_Permiso()
        treeloading = False
    End Sub
    Private Sub load_Permiso()
        Me.btnGuardar.Visible = False
        btnElimina.Visible = False
        Me.Text = "Detalle del Rol "
        If tipo_Permiso = 0 And Not delete_record Then 'Solo Lectura
            Me.grpDatosRol.Enabled = False
            Me.txtRol.Enabled = False
            Me.cxn.load_selected(Me.TreeView1, "select idMenu,readopt,addopt,delopt,updopt from tbl_Profile where idRol=" & id)
        ElseIf tipo_Permiso = 1 And delete_record Then 'Eliminar Registro
            Me.grpDatosRol.Enabled = False
            btnElimina.Visible = True
            btnUndo.Visible = True
            Me.txtRol.Enabled = False
            Me.cxn.load_selected(Me.TreeView1, "select idMenu,readopt,addopt,delopt,updopt from tbl_Profile where idRol=" & id)
        ElseIf tipo_Permiso = 1 And id <> "0" Then  'Actualizar Registro
            Me.grpDatosRol.Enabled = True
            Me.btnGuardar.Visible = True
            btnUndo.Visible = True
            Me.txtRol.Enabled = False
            Me.cxn.load_selected(Me.TreeView1, "select idMenu,readopt,addopt,delopt,updopt from tbl_Profile where idRol=" & id)
        ElseIf tipo_Permiso = 1 And id = "0" Then 'Agregar Registro
            Me.Text = "Nuevo ROL"
            Me.grpDatosRol.Enabled = True
            Me.btnGuardar.Visible = True
            Me.BindingNavigator1.BindingSource.AddNew()
            Me.txtRol.Enabled = True
        End If
    End Sub
    Private Function valida_datos() As Boolean
        Dim ban As Boolean = False
        Try
            If tipo_Permiso = 1 And id = "0" Then
                cxn.Select_SQL("select count(*) from tbl_rol where RolName='" & Me.txtRol.Text.Trim & "'")
                If cxn.arrayValores(0) <> 0 Then
                    SystemMessages1.SysMsg("El Rol ya existe....", True)
                    Me.txtRol.SelectAll()
                    Me.txtRol.Focus()
                    Return 0
                End If
            End If


            If Me.txtRol.Text.Trim.Length > 0 Then
                If Me.txtRolDesc.Text.Trim.Trim.Length > 0 Then
                    Dim countnodes As Int16 = Me.TreeviewCountCheckedNodes(Me.TreeView1.Nodes, False)
                    If countnodes > 0 Then
                        ban = True
                    Else
                        SystemMessages1.SysMsg("Debe Seleccionar al menos un menu!!.", True)
                        Me.TreeView1.Focus()
                    End If

                Else
                    SystemMessages1.SysMsg("El campo Descripción es requerido.", True)
                    Me.txtRolDesc.Focus()
                End If
            Else
                SystemMessages1.SysMsg("El campo Rol es requerido.", True)
                Me.txtRol.Focus()
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
                Me.Tbl_RolTableAdapter.Update(Me.DsAgua.tbl_Rol)
                SystemMessages1.SysMsg("Datos eliminados ", )
                MsgBox("Registro eliminado", MsgBoxStyle.Information, "PAE")
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
                    Me.BindingSource1.EndEdit()
                    Me.Tbl_RolTableAdapter.Update(Me.DsAgua.tbl_Rol)
                    SystemMessages1.SysMsg("Datos actualizados ")
                Else
                    Tbl_RolTableAdapter.Insert(Me.txtRol.Text.Trim.ToUpperInvariant, Me.txtRolDesc.Text.Trim.ToUpperInvariant, IIf(Me.chkActive.Checked, 0, 1))
                    Me.Tbl_RolTableAdapter.Update(Me.DsAgua.tbl_Rol)
                    SystemMessages1.SysMsg("Datos Registrados ")
                    Me.Close()
                End If
                Dim idrol As String = ""
                cxn.Select_SQL("select idRol from tbl_Rol where RolName='" & Me.txtRol.Text.Trim & "'")
                If cxn.arrayValores(0) IsNot Nothing Then
                    idrol = cxn.arrayValores(0)
                Else
                    SystemMessages1.SysMsg("No existe el Rol...", True)
                    Exit Sub
                End If
                If Me.cxn.Select_SQL("delete from tbl_Profile where idRol='" & idrol & "'") Then
                    TreeviewCountCheckedNodes(Me.TreeView1.Nodes, True)
                Else
                    SystemMessages1.SysMsg("Error al guardar los menus: " & cxn.err, True)
                End If
            End If
        Catch ex As Exception
            SystemMessages1.SysMsg(ex.Message, True)
        End Try
    End Sub
    Private Sub frmRol_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim Maintab As UltraTabControl = TryCast(myparent.Controls.Find("UltraTabControl1", True).FirstOrDefault(), UltraTabControl)
        Maintab.Visible = True
        Dim Mainbar As ToolStrip = TryCast(myparent.Controls.Find("CommandBar", True).FirstOrDefault(), ToolStrip)
        Mainbar.Visible = True
    End Sub

    Private Sub TreeView1_AfterCheck(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterCheck
        Try
            If e.Node.Nodes.Count > 0 Then
                CheckAllChildNodes(e.Node, IIf(e.Node.Checked, True, False))
            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub CheckAllChildNodes(treeNode As TreeNode, nodeChecked As Boolean)
        Dim node As TreeNode
        For Each node In treeNode.Nodes
            If node.Name.Replace(node.Parent.Name, "").ToLowerInvariant <> "nvo" And node.Name.Replace(node.Parent.Name, "").ToLowerInvariant <> "ver" And
                               node.Name.Replace(node.Parent.Name, "").ToLowerInvariant <> "edt" And node.Name.Replace(node.Parent.Name, "").ToLowerInvariant <> "elr" Then
                node.Checked = nodeChecked
            Else
                Dim cxn3 As New cxnData
                cxn3.Select_SQL("select readopt,addopt,delopt,updopt from tbl_Profile where idMenu='" & node.Parent.Name & "' and idRol='" & id & "'")
                Dim node1 As TreeNode() = Me.TreeView1.Nodes.Find(node.Parent.Name & "ver", True)
                node1(0).Checked = IIf(cxn3.arrayValores(0) = "True", True, False)
                Dim node2 As TreeNode() = Me.TreeView1.Nodes.Find(node.Parent.Name & "nvo", True)
                node2(0).Checked = IIf(cxn3.arrayValores(1) = "True", True, False)
                Dim node3 As TreeNode() = Me.TreeView1.Nodes.Find(node.Parent.Name & "edt", True)
                node3(0).Checked = IIf(cxn3.arrayValores(3) = "True", True, False)
                Dim node4 As TreeNode() = Me.TreeView1.Nodes.Find(node.Parent.Name & "elr", True)
                node4(0).Checked = IIf(cxn3.arrayValores(2) = "True", True, False)
            End If
            If node.Nodes.Count > 0 Then
                ' If the current node has child nodes, call the CheckAllChildsNodes method recursively.  
                Me.CheckAllChildNodes(node, nodeChecked)
            End If
        Next node
    End Sub
    Private Function TreeviewCountCheckedNodes(ByVal treeNodeCollection As TreeNodeCollection, updatedban As Boolean) As Integer
        Dim countchecked As Integer = 0

        If treeNodeCollection IsNot Nothing Then

            For Each node As TreeNode In treeNodeCollection

                If node.Nodes.Count = 0 AndAlso node.Checked Then
                    countchecked += 1
                    If updatedban Then
                        cxn.Select_SQL("select idRol from tbl_Rol where RolName='" & Me.txtRol.Text.Trim & "'")
                        If cxn.arrayValores(0) IsNot Nothing Then
                            Dim idrol As String = cxn.arrayValores(0)
                            If node.Name.Replace(node.Parent.Name, "").ToLowerInvariant <> "nvo" And node.Name.Replace(node.Parent.Name, "").ToLowerInvariant <> "ver" And
                               node.Name.Replace(node.Parent.Name, "").ToLowerInvariant <> "edt" And node.Name.Replace(node.Parent.Name, "").ToLowerInvariant <> "elr" Then
                                cxn.Select_SQL("insert into tbl_Profile (idRol,idMenu) values (" & idrol & ",'" & node.Name & "')")
                            Else
                                cxn.Select_SQL("SELECT COUNT(*) from tbl_Profile where idMenu='" & node.Parent.Name & "' and idRol='" & idrol & "'")
                                If cxn.arrayValores(0) = 0 Then
                                    cxn.Select_SQL("insert into tbl_Profile (idRol,idMenu) values (" & idrol & ",'" & node.Parent.Name & "')")
                                End If
                                Dim fld As String = ""
                                Select Case node.Name.Replace(node.Parent.Name, "").ToLowerInvariant
                                    Case "ver"
                                        fld = "readopt"
                                    Case "nvo"
                                        fld = "addopt"
                                    Case "edt"
                                        fld = "updopt"
                                    Case "elr"
                                        fld = "delopt"
                                End Select
                                cxn.Select_SQL("update tbl_Profile set " & fld & "=" & IIf(node.Checked, 1, 0) & " where idMenu='" & node.Parent.Name & "' and idRol='" & idrol & "'")
                            End If

                        Else
                                SystemMessages1.SysMsg("No existe el Rol...", True)
                            Return 0
                        End If
                    End If
                ElseIf node.Nodes.Count > 0 Then
                    countchecked += TreeviewCountCheckedNodes(node.Nodes, updatedban)
                End If
            Next
        End If

        Return countchecked
    End Function
End Class