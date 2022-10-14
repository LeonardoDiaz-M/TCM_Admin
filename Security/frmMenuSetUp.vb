Imports Infragistics.Win.UltraWinTabControl
Imports System.ComponentModel
Imports Infragistics.Win.UltraWinExplorerBar

Public Class frmMenuSetUp
    Public id As String = "0"
    Public delete_record As Boolean = False
    Public tipo_Permiso As Integer = 0
    Public idUsuario As String = My.User.Name
    Private mnu1 As New clsMainMenu
    Private tabs1 As New clsMenuLoadQuery
    Private cxn As New cxnData
    Private current_menu As String = ""
    Private idTab As Integer = -1
    Public myparent As Form = Nothing
    Private Sub frmMenuSetUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mnu1.MainBar = Me.UltraExplorerBar1

        Dim loaded As Boolean
        loaded = mnu1.load_MainMenu(True)
        Get_Forms(Me.ddlform)
        If Not loaded Then
            SystemMessages1.SysMsg("Error al cargar el menú - " & mnu1.errmsg, True)
        End If
    End Sub
    Private Sub UltraExplorerBar1_ItemDoubleClick(sender As Object, e As ItemEventArgs) Handles UltraExplorerBar1.ItemDoubleClick
        current_menu = e.Item.Key
        If cxn.Select_SQL("select * from [tbMainSubMenus] where submenu='" & e.Item.Key & "'") Then
            If cxn.arrayValores(0) IsNot Nothing Then
                Me.txtIdMenu.Text = cxn.arrayValores(0)
                Me.txtNombre.Text = cxn.arrayValores(1)
                Me.chkMnuActivo.Checked = IIf(cxn.arrayValores(4) = 0, True, False)
                cxn.Get_SQL_DataGrid("select distinct idTab as Id,TabOrder as [Orden],TabName as [Pestaña] " &
                                     "from [tbMainMenuTabs] where Menu='" & cxn.arrayValores(0) &
                                     "' order by taborder asc", Me.grdDataMainTabs)
                Dim i As Integer = Me.UltraTabControl1.Tabs.Count
                While i > 1
                    Me.UltraTabControl1.Tabs.Item(i - 1).Selected = True
                    Dim selectedtab = Me.UltraTabControl1.SelectedTab
                    If i > 0 Then

                        Me.UltraTabControl1.Tabs.Remove(selectedtab)
                    End If
                    i = i - 1
                End While
                UltraTabControl1.Tabs(0).Text = "Datos"
                cxn.Get_SQL_DataGrid("select 'Elija un menú o Pestaña (Tab)' as Información", grdQuery)
            Else
                SystemMessages1.SysMsg("No se encuentra la información", True)
            End If
        Else
            SystemMessages1.SysMsg(cxn.err, True)
        End If
    End Sub

    Private Sub grdDataMainTabs_DoubleClick(sender As Object, e As EventArgs) Handles grdDataMainTabs.DoubleClick
        Try
            idTab = Me.grdDataMainTabs.ActiveRow.Cells(0).Text
            If cxn.Select_SQL("select * from [tbMainMenuTabs] where idTab='" & Me.grdDataMainTabs.ActiveRow.Cells(0).Text & "'") Then
                If cxn.arrayValores(0) IsNot Nothing Then
                    Me.txtTabName.Text = cxn.arrayValores(2)
                    Me.txtQuery.Text = cxn.arrayValores(3)
                    If cxn.arrayValores(4) IsNot Nothing AndAlso cxn.arrayValores(4).Trim.Length > 0 Then
                        Me.ddlform.SelectedValue = cxn.arrayValores(4)
                    End If
                    Me.mskOrder.Text = cxn.arrayValores(5)
                    Me.chkActivo.Checked = IIf(cxn.arrayValores(6) = 0, True, False)
                Else
                    SystemMessages1.SysMsg("No se encuentra la información", True)
                End If
            Else
                SystemMessages1.SysMsg(cxn.err, True)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnVer_Click(sender As Object, e As EventArgs) Handles btnVer.Click
        Try
            For i As Integer = 0 To Me.UltraTabControl1.Tabs.Count - 1
                If i > 0 Then
                    Me.UltraTabControl1.Tabs.Remove(UltraTabControl1.Tabs(i))
                End If
            Next
            cxn.Get_SQL_DataGrid(Me.txtQuery.Text, Me.grdQuery)
            If Not tabs1.add_tabs(current_menu, Me.UltraTabControl1, Me.grdQuery) Then
                SystemMessages1.SysMsg(tabs1.errmsg, True)
            End If
        Catch ex As Exception
            SystemMessages1.SysMsg(ex.Message, True)
        End Try
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Dim resp As DialogResult = ShowContinueMessage("Confirmar Acción", " ",
                                                            "Se eliminará el Menu y los Tabs asociados." & vbCrLf &
                                                            "¿Esta seguro de eliminar los datos?", Me.UltraMessageBoxManager1,
                                                            MessageBoxButtons.YesNo)
        If resp = DialogResult.Yes Then
            If cxn.Select_SQL("delete from tbMainSubMenus where subMenu='" & current_menu.ToString & "'") Then
                SystemMessages1.SysMsg("El SubMenu se ha eliminado...")

                If cxn.Select_SQL("delete from tbMainMenuTabs where Menu='" & current_menu.ToString & "'") Then
                    SystemMessages1.SysMsg("Las pestañas (tabs) se han eliminado...")
                Else
                    SystemMessages1.SysMsg("Error: " & cxn.arrayValores(0))
                End If
            Else
                SystemMessages1.SysMsg("Error: " & cxn.arrayValores(0))
            End If
        End If
        mnu1.MainBar = Me.UltraExplorerBar1
        mnu1.load_MainMenu(True)
        Me.txtTabName.Text = ""
        Me.txtQuery.Text = ""
        Me.ddlform.SelectedIndex = -1
        Me.chkActivo.Checked = False
        Me.grdQuery.DataSource = Nothing
    End Sub

    Private Sub NewToolStripButton_Click(sender As Object, e As EventArgs) Handles btnNewMenu.Click
        mnu1.MainBar = Me.UltraExplorerBar1
        mnu1.load_MainMenu(True)
        Me.ddlform.SelectedIndex = -1
        Me.grdDataMainTabs.DataSource = Nothing
        Me.txtIdMenu.Text = ""
        Me.txtNombre.Text = ""
        Me.chkMnuActivo.Checked = False
        Me.txtIdMenu.Focus()
    End Sub

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles btnSaveMenu.Click
        SystemMessages1.Visible = True
        If Me.txtIdMenu.Text.Trim.Length > 0 Then
            SystemMessages1.Visible = False
            If Me.txtNombre.Text.Trim.Length > 0 Then
                '        Me.UltraExplorerBar1.SelectedGroup.Key 
                If cxn.Select_SQL("select * from [tbMainSubMenus] where submenu='" & current_menu & "'") Then
                    If cxn.arrayValores(0) Is Nothing Then
                        Dim resp As DialogResult = ShowContinueMessage("Confirmar Acción", " ",
                                                                       "Se agregará un nuevo menú" & vbCrLf &
                                                                       "¿Desea Continuar?", Me.UltraMessageBoxManager1,
                                                                       MessageBoxButtons.YesNo)
                        If resp = vbYes Then
                            If cxn.Select_SQL(" insert into tbMainSubMenus (SubMenu,Description,Parent,IconName,Status)" &
                                              " values ('" & Me.txtIdMenu.Text.Trim.ToUpperInvariant & "'," &
                                                       "'" & Me.txtNombre.Text.ToUpperInvariant & "'," &
                                                       "'" & Me.UltraExplorerBar1.ActiveGroup.Key & "'," &
                                                       "NULL," &
                                                       IIf(Me.chkMnuActivo.Checked = True, 0, 1) & ")") Then
                                SystemMessages1.SysMsg("Se han guardado los cambios")
                                frmMenuSetUp_Load(Nothing, Nothing)
                                cxn.Select_SQL("select * from [tbMainSubMenus] where submenu='" & Me.txtIdMenu.Text.Trim.ToUpperInvariant & "'")
                                Me.UltraExplorerBar1.Groups.Item(cxn.arrayValores(2)).Selected = True
                                Me.UltraExplorerBar1.SelectedGroup.Items.Item(cxn.arrayValores(0)).Active = True
                            Else
                                SystemMessages1.SysMsg("Ocurrío un error: " & cxn.arrayValores(0).Replace(vbCrLf, "/"), True)
                            End If
                        Else
                            SystemMessages1.SysMsg("El menú se ha agregado")
                        End If
                    Else
                        If cxn.Select_SQL("update tbMainSubMenus set  Description='" & Me.txtNombre.Text.ToUpperInvariant &
                                       "', Status=" & IIf(Me.chkMnuActivo.Checked = True, 0, 1) &
                                       "where SubMenu='" & current_menu & "'") Then
                            SystemMessages1.SysMsg("Se han guardado los cambios")
                            frmMenuSetUp_Load(Nothing, Nothing)
                            cxn.Select_SQL("select * from [tbMainSubMenus] where submenu='" & current_menu & "'")
                            Me.UltraExplorerBar1.Groups.Item(cxn.arrayValores(2)).Selected = True
                            Me.UltraExplorerBar1.SelectedGroup.Items.Item(cxn.arrayValores(0)).Active = True
                        Else
                            SystemMessages1.SysMsg("Ocurrío un error: " & cxn.arrayValores(0).Replace(vbCrLf, "/"), True)
                        End If
                    End If
                Else
                    SystemMessages1.SysMsg("Ocurrío un error: " & cxn.arrayValores(0), True)
                End If
            Else
                SystemMessages1.SysMsg("El campo Nombre es requerido...", True)
                Me.txtNombre.Focus()
            End If
        Else
            SystemMessages1.SysMsg("El campo Código del Menú está vacío, verifique...", True)
            Me.txtIdMenu.Focus()
        End If
    End Sub

    Private Sub UltraTabControl1_SelectedTabChanged(sender As Object, e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs) Handles UltraTabControl1.SelectedTabChanged
        Try
            If Not Me.tabs1.Load_Tab_data(Me.UltraTabControl1, Me.grdQuery.ActiveRow.Cells(0).Text) Then
                ' SystemMessages1.SysMsg(tabs1.errmsg, True)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnSaveDet_Click(sender As Object, e As EventArgs) Handles btnSaveDet.Click
        If Me.txtTabName.Text.Trim <> "" Then
            If Me.mskOrder.Text.Trim.Length > 0 Then
                If Me.txtQuery.Text.Trim <> "" Then
                    Dim filtro As String = ""
                    Dim query_test As String = ""
                    If (Me.txtQuery.Text.ToLowerInvariant.Contains("<$filtro1$>")) Then
                        filtro = InputBox("Valor para el filtro:", "Filtro del query")
                        query_test = Me.txtQuery.Text.ToLowerInvariant.Replace("<$filtro1$>", filtro)
                    Else
                        query_test = Me.txtQuery.Text
                    End If

                    If cxn.Get_SQL_DataGrid(query_test, Me.grdQuery) Then
                        Dim resp As DialogResult = DialogResult.Yes
                        If Me.grdQuery.Rows.Count = 0 Then
                            SystemMessages1.SysMsg("El query no produjo resultados...", True)
                            resp = ShowContinueMessage("Confirmar Acción", " ",
                                                                     "No se encontrarón datos con el query" & vbCrLf &
                                                                     "¿Desea Guardar los cambios?", Me.UltraMessageBoxManager1,
                                                                     MessageBoxButtons.YesNo)
                        End If
                        If resp = DialogResult.Yes Then
                            If cxn.Select_SQL("select * from [tbMainMenuTabs] where idTab='" & idTab & "'") Then
                                If cxn.arrayValores(0) Is Nothing Then
                                    Dim resp2 As DialogResult = ShowContinueMessage("Confirmar Acción", " ",
                                                                     "Se agregará un nueva Pestaña (Tab)" & vbCrLf &
                                                                     "¿Desea Continuar?", Me.UltraMessageBoxManager1,
                                                                     MessageBoxButtons.YesNo)
                                    If resp2 = vbYes Then
                                        If cxn.Select_SQL(" insert into tbMainMenuTabs (Menu,TabName,Query,FormName,TabOrder,Status)" &
                                                          " values ('" & current_menu & "'," &
                                                                   "'" & Me.txtTabName.Text.ToUpperInvariant & "'," &
                                                                   "'" & Me.txtQuery.Text.Replace("'", "''") & "'," &
                                                                    Me.mskOrder.Text & "," &
                                                                   IIf(Me.ddlform.SelectedValue = "-1", "NULL", "'" & Me.ddlform.SelectedValue & "'") &
                                                                   "," & IIf(Me.chkActivo.Checked = True, 0, 1) & ")") Then
                                            SystemMessages1.SysMsg("Se han guardado los cambios")
                                            cxn.Get_SQL_DataGrid("select distinct idTab as Id,TabOrder as [Orden],TabName as [Pestaña] " &
                                                                "from [tbMainMenuTabs] where Menu='" & current_menu &
                                                                "' order by taborder asc", Me.grdDataMainTabs)
                                            btnTabNew_Click(Nothing, Nothing)
                                        Else
                                            SystemMessages1.SysMsg("Ocurrío un error: " & cxn.arrayValores(0).Replace(vbCrLf, "/"), True)
                                        End If
                                    End If
                                Else
                                    If cxn.Select_SQL("update tbMainMenuTabs set  TabName='" & Me.txtTabName.Text.ToUpperInvariant & "'" &
                                                      ", Status=" & IIf(Me.chkActivo.Checked = True, 0, 1) &
                                                      ", Query='" & Me.txtQuery.Text.Replace("'", "''") & "'" &
                                                      ", TabOrder='" & Me.mskOrder.Text & "'" &
                                                      ", FormName=" & IIf(Me.ddlform.SelectedValue = "-1", "Null", "'" & Me.ddlform.SelectedValue & "'") &
                                                       "where idTab='" & idTab & "'") Then
                                        SystemMessages1.SysMsg("Se han guardado los cambios")
                                        cxn.Get_SQL_DataGrid("select distinct idTab as Id,TabOrder as [Orden],TabName as [Pestaña] " &
                                                           "from [tbMainMenuTabs] where Menu='" & current_menu &
                                                           "' order by taborder asc", Me.grdDataMainTabs)
                                    Else
                                        SystemMessages1.SysMsg("Ocurrío un error: " & cxn.arrayValores(0).Replace(vbCrLf, "/"), True)
                                    End If
                                End If
                            Else
                                SystemMessages1.SysMsg("Ocurrío un error: " & cxn.arrayValores(0).Replace(vbCrLf, "/"), True)
                            End If
                        End If
                    Else
                        SystemMessages1.SysMsg("Error al generar la sentencia sql, verifique..." & cxn.arrayValores(0), True)
                    End If
                Else
                    SystemMessages1.SysMsg("El campo Query es requerido...", True)
                    Me.txtQuery.Focus()
                End If
            Else
                SystemMessages1.SysMsg("El campo Orden es requerido...", True)
                Me.mskOrder.Focus()
            End If
        Else
            SystemMessages1.SysMsg("El campo Tab Nombre es requerido...", True)
            Me.txtTabName.Focus()
        End If
    End Sub

    Private Sub btnTabNew_Click(sender As Object, e As EventArgs) Handles btnTabNew.Click
        idTab = -1
        Me.txtTabName.Text = ""
        Me.txtQuery.Text = ""
        Me.chkMnuActivo.Checked = False
        Me.ddlform.SelectedValue = -1
        Me.mskOrder.Clear()
        cxn.Select_SQL("select max(TabOrder)+1 " &
                            " from [tbMainMenuTabs] where Menu='" & current_menu & "'")
        Me.mskOrder.Text = cxn.arrayValores(0)
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles btnEditmenu.Click
        Dim frm As New frmMenuRoot
        frm.id = Me.UltraExplorerBar1.SelectedGroup.Key.ToString
        frm.tipo_Permiso = 1
        frm.ShowDialog(Me)
    End Sub

    Private Sub btnAddMnu_Click(sender As Object, e As EventArgs) Handles btnAddMnu.Click
        Dim frm As New frmMenuRoot
        frm.id = 0
        frm.tipo_Permiso = 1
        frm.ShowDialog(Me)
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Dim resp As DialogResult = ShowContinueMessage("Confirmar Acción", " ",
                                                            "Se eliminarán los datos." & vbCrLf &
                                                            "¿Esta seguro de eliminar los datos?", Me.UltraMessageBoxManager1,
                                                            MessageBoxButtons.YesNo)
        If resp = DialogResult.Yes Then
            If cxn.Select_SQL("delete from tbMainMenuTabs where idtab=" & idTab.ToString) Then
                SystemMessages1.SysMsg("La pestaña (Tab) se ha eliminado...")
            Else
                SystemMessages1.SysMsg("Error: " & cxn.arrayValores(0))
            End If
        End If
    End Sub

    Private Sub frmFormaPago_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim Maintab As UltraTabControl = TryCast(myparent.Controls.Find("UltraTabControl1", True).FirstOrDefault(), UltraTabControl)
        Maintab.Visible = False
        Maintab.Visible = True
    End Sub
End Class