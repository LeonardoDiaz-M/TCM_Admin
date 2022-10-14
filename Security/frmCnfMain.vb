Imports Infragistics.Win.UltraWinTabControl
Imports System.ComponentModel
Imports Infragistics.Win.UltraWinExplorerBar
Imports Infragistics.Win.UltraWinGrid

Public Class frmCnfMain
    Public id As String = "0"
    Public delete_record As Boolean = False
    Public tipo_Permiso As Integer = 0
    Public idUsuario As String = My.User.Name
    Private mnu1 As New clsMainMenu
    Private tabs1 As New clsMenuLoadQuery
    Private cxn As New cxnData
    Private submnu As String = ""
    Private idTab As Integer = -1
    Public myparent As Form = Nothing

    Private Sub frmCnfMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cxn.Get_SQL_DataGrid("Select MenuNam,Description,Status from tbMainMenu", Me.grdMenus)
        Get_Forms(Me.ddlform)
    End Sub

    Private Sub grdSubMenus_DoubleClick(sender As Object, e As EventArgs) Handles grdSubMenus.DoubleClick
        Try
            Dim ismodal As Boolean = False
            submnu = Me.grdSubMenus.ActiveRow.Cells(0).Text
            If cxn.Select_SQL("select * from [tbMainSubMenus] where submenu='" & Me.grdMenus.ActiveRow.Cells(0).Text & "'") Then
                cxn.Get_SQL_DataGrid("select distinct idTab as Id,TabOrder as [Orden],TabName as [Pestaña] " &
                                         "from [tbMainMenuTabs] where Menu='" & submnu &
                                         "' order by taborder asc", Me.grdTabs)
                cxn.Select_SQL("select readOpt,AddOpt,DelOpt,UpdOpt,IsModal,description from tbMainSubMenus where SubMenu='" & submnu & "'")
                If cxn.arrayValores(0) IsNot Nothing Then
                    Me.btnView.Enabled = IIf(cxn.arrayValores(0) = "True", True, False)
                    Me.btnNuevo.Enabled = IIf(cxn.arrayValores(1) = "True", True, False)
                    Me.btnEliminar.Enabled = IIf(cxn.arrayValores(2) = "True", True, False)
                    Me.btnAbrir.Enabled = IIf(cxn.arrayValores(3) = "True", True, False)
                    ismodal = IIf(cxn.arrayValores(4) = "True", True, False)
                End If
                Dim i As Integer = Me.UltraTabControl1.Tabs.Count - 1
                While Me.UltraTabControl1.Tabs.Count > 1
                    If i > 0 Then
                        Me.UltraTabControl1.Tabs.Remove(UltraTabControl1.Tabs(i))
                    End If
                    i = i - 1
                End While
                Me.grdQuery.DataSource = Nothing
                If Not tabs1.add_tabs(submnu, Me.UltraTabControl1, Me.grdQuery, Me.txtFilter.Text) Then
                    Me.SystemMessages1.SysMsg(tabs1.errmsg, True)
                End If
                If Me.grdQuery.Rows.Count = 0 Then
                    cxn.Select_SQL("select FormName from tbMainMenuTabs where Menu='" & Me.grdMenus.ActiveRow.Cells(0).Text & "' and (query='' or query is null)")
                    If cxn.arrayValores(0) IsNot Nothing And cxn.err = "" Then
                        'Display_Form("0", 1, False, ismodal)
                    ElseIf cxn.err <> "" Then
                        Me.SystemMessages1.SysMsg(cxn.err, True)
                    Else
                        UltraTabControl1.Tabs(0).Text = "&Búsqueda"
                        cxn.Get_SQL_DataGrid("select 'No se encontró información' as Mensaje", Me.grdQuery)
                    End If

                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub grdMenus_DoubleClick(sender As Object, e As EventArgs) Handles grdMenus.DoubleClick
        cxn.Get_SQL_DataGrid("Select SubMenu,Description,Status from tbMainSubMenus where Parent='" & Me.grdMenus.ActiveRow.Cells(0).Text & "'", Me.grdSubMenus)
    End Sub
    Private Sub frmCnfMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim Maintab As UltraTabControl = TryCast(myparent.Controls.Find("UltraTabControl1", True).FirstOrDefault(), UltraTabControl)
        Maintab.Visible = True
        Dim Mainbar As ToolStrip = TryCast(myparent.Controls.Find("CommandBar", True).FirstOrDefault(), ToolStrip)
        Mainbar.Visible = True
    End Sub
    'Private Sub Display_Form(key As String, Permiso As Integer, deleterecord As Boolean, childmodal As Boolean)
    '    Try
    '        If Not childmodal Then
    '            Me.UltraTabControl1.Visible = False
    '            Me.CommandBar.Visible = False
    '        End If
    '        tabs1.LoadForms(key, Me.UltraTabControl1.SelectedTab.Key.ToString, Permiso, "", deleterecord, Me)
    '    Catch ex As Exception
    '        Me.SystemMessages1.SysMsg("Seleccione un registro", True)
    '    End Try
    'End Sub

    Private Sub grdTabs_DoubleClick(sender As Object, e As EventArgs) Handles grdTabs.DoubleClick
        Try
            idTab = Me.grdTabs.ActiveRow.Cells(0).Text
            If cxn.Select_SQL("select * from [tbMainMenuTabs] where idTab='" & Me.grdTabs.ActiveRow.Cells(0).Text & "'") Then
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

    Private Sub btnTabSave_Click(sender As Object, e As EventArgs) Handles btnTabSave.Click
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
                                        If cxn.Select_SQL(" insert into tbMainMenuTabs (Menu,TabName,Query,TabOrder,FormName,Status)" &
                                                          " values ('" & submnu & "'," &
                                                                   "'" & Me.txtTabName.Text.ToUpperInvariant & "'," &
                                                                   "'" & Me.txtQuery.Text.Replace("'", "''") & "'," &
                                                                    "'" & Me.mskOrder.Text & "'," &
                                                                   IIf(Me.ddlform.SelectedValue = "-1", "NULL", "'" & Me.ddlform.SelectedValue & "'") &
                                                                   "," & IIf(Me.chkActivo.Checked = True, 0, 1) & ")") Then
                                            SystemMessages1.SysMsg("Se han guardado los cambios")
                                            cxn.Get_SQL_DataGrid("select distinct idTab as Id,TabOrder as [Orden],TabName as [Pestaña] " &
                                                                "from [tbMainMenuTabs] where Menu='" & submnu &
                                                                "' order by taborder asc", Me.grdTabs)
                                            btnAddTab_Click(Nothing, Nothing)
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
                                                           "from [tbMainMenuTabs] where Menu='" & submnu &
                                                           "' order by taborder asc", Me.grdTabs)
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
    Private Sub btnAddTab_Click(sender As Object, e As EventArgs) Handles btnAddTab.Click
        idTab = -1
        Me.txtTabName.Text = ""
        Me.txtQuery.Text = ""
        Me.chkActivo.Checked = False
        Me.ddlform.SelectedValue = -1
        Me.mskOrder.Clear()
        cxn.Select_SQL("select max(TabOrder)+1 " &
                            " from [tbMainMenuTabs] where Menu='" & submnu & "'")
        Me.mskOrder.Text = cxn.arrayValores(0)
    End Sub

    Private Sub btnMnEdit_Click(sender As Object, e As EventArgs) Handles btnMnEdit.Click
        Dim frm As New frmMenuRoot
        frm.id = Me.grdMenus.ActiveRow.Cells(0).Text
        frm.tipo_Permiso = 1
        frm.ShowDialog(Me)
        frmCnfMain_Load(Nothing, Nothing)
    End Sub

    Private Sub btnMnuAdd_Click(sender As Object, e As EventArgs) Handles btnMnuAdd.Click
        Dim frm As New frmMenuRoot
        frm.id = 0
        frm.tipo_Permiso = 1
        frm.ShowDialog(Me)
        frmCnfMain_Load(Nothing, Nothing)
    End Sub

    Private Sub btnSubEdit_Click(sender As Object, e As EventArgs) Handles btnSubEdit.Click
        Dim frm As New frmSubMenu
        frm.id = submnu
        frm.tipo_Permiso = 1
        frm.parentMenu = Me.grdMenus.ActiveRow.Cells(0).Text
        frm.ShowDialog(Me)
        grdMenus_DoubleClick(Nothing, Nothing)
    End Sub
    Private Sub btnSubAdd_Click(sender As Object, e As EventArgs) Handles btnSubAdd.Click
        Dim frm As New frmSubMenu
        frm.id = 0
        frm.tipo_Permiso = 1
        frm.parentMenu = Me.grdMenus.ActiveRow.Cells(0).Text
        frm.ShowDialog(Me)
        grdMenus_DoubleClick(Nothing, Nothing)
    End Sub
End Class