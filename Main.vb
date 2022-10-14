Imports System.Windows.Forms
Imports Infragistics.Win.UltraWinExplorerBar
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinTabControl

Public Class Main
    Private childmodal As Boolean = False
    Private mnu1 As New clsMainMenu
    Private tabs1 As New clsMenuLoadQuery
    Private current_menu As String = ""
    Private cxn As New cxnData

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lgn As New frmLogin
        lgn.ShowDialog(Me)
        If CurrentUsrName <> "" Then
            mnu1.MainBar = Me.UltraExplorerBar1
            Infragistics.Win.AppStyling.StyleManager.Load("Aero.isl")
            Dim loaded As Boolean
            loaded = mnu1.load_MainMenu(True)
            Me.Timer1.Enabled = True
            If Not loaded Then
                sysmsg1.SysMsg("Error al cargar el menú - " & mnu1.errmsg, True)
            End If
        Else
            End
        End If
    End Sub

    Private Sub UltraExplorerBar1_ItemDoubleClick(sender As Object, e As ItemEventArgs) Handles UltraExplorerBar1.ItemDoubleClick
        Try
            If e.Item.Key <> current_menu Then
                'dependiendo de la opcion del barra explorer cargamos el grid con el CODIGO de la forma seleccionada ejem IMP056
                Me.Cursor = Cursors.WaitCursor
                load_menu_grid(e.Item.Key)
                Me.Cursor = Cursors.Default
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub load_menu_grid(menu As String)
        CloseActiveForms()
        'cxn.Select_SQL("select readOpt,AddOpt,DelOpt,UpdOpt,IsModal,description from tbMainSubMenus where SubMenu='" & menu & "'")
        'valida permisos lectura, insert, delete, update en base al rol
        cxn.Select_SQL("SELECT pf.readOpt,pf.AddOpt,pf.DelOpt,pf.UpdOpt,ms.IsModal,ms.description
                        from  tbl_Profile pf 
	                        inner join tbl_rol rl on rl.idRol = pf.idRol and rl.Status=0
                            inner join tbl_user tu on tu.idRol = rl.idRol  and tu.Status=0     
	                        inner join tbMainSubMenus ms on ms.SubMenu =pf.idMenu  and ms.Status=0 
                        where tu.UserId ='" & CurrentUsrName & "' and pf.idMenu='" & menu & "'")
        If cxn.arrayValores(0) IsNot Nothing Then
            Me.btnView.Enabled = IIf(cxn.arrayValores(0) = "True", True, False)
            Me.btnNuevo.Enabled = IIf(cxn.arrayValores(1) = "True", True, False)
            Me.btnEliminar.Enabled = IIf(cxn.arrayValores(2) = "True", True, False)
            Me.btnAbrir.Enabled = IIf(cxn.arrayValores(3) = "True", True, False)
            Me.childmodal = IIf(cxn.arrayValores(4) = "True", True, False)
        End If
        Me.current_menu = menu
        current_menu = menu
        Me.lblParent.Text = Me.UltraExplorerBar1.SelectedGroup.Text
        Me.lblMenu.Text = vbTab & menu & "-" & cxn.arrayValores(5)
        Try

            'remueve tabs activas
            Dim i As Integer = Me.UltraTabControl1.Tabs.Count - 1
            While Me.UltraTabControl1.Tabs.Count > 1
                If i > 0 Then
                    Me.UltraTabControl1.Tabs.Remove(UltraTabControl1.Tabs(i))
                End If
                i = i - 1
            End While
            'borra datos del grid
            Me.grdDataMain.DataSource = Nothing

            If Not tabs1.add_tabs(current_menu, Me.UltraTabControl1, Me.grdDataMain, Me.txtFilter.Text) Then
                sysmsg1.SysMsg(tabs1.errmsg, True)
            End If
            If Me.grdDataMain.Rows.Count = 0 Then
                cxn.Select_SQL("select FormName from tbMainMenuTabs where Menu='" & menu & "' and (query='' or query is null)")

                If cxn.arrayValores(0) IsNot Nothing And cxn.err = "" Then
                    childmodal = False
                    Display_Form("0", 1, False)
                ElseIf cxn.err <> "" Then
                    Me.sysmsg1.SysMsg(cxn.err, True)
                Else
                    UltraTabControl1.Tabs(0).Text = "&Búsqueda"
                    cxn.Get_SQL_DataGrid("select 'No se encontró información' as Mensaje", Me.grdDataMain)
                End If

            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub CloseActiveForms()
        Try
            Me.UltraTabControl1.Visible = True
            Me.CommandBar.Visible = True
            For Each f As Form In My.Application.OpenForms
                If f.Name.ToLower <> "main" Then
                    Try
                        'f.Close()
                        Me.BeginInvoke(New Action(Sub() f.Close()))
                    Catch ex As Exception

                    End Try

                End If
            Next
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Excel_Click(sender As Object, e As EventArgs) Handles Excel.Click
        Try
            Dim gridexcel As UltraGrid = Nothing
            Dim tabselected As UltraTab = Me.UltraTabControl1.SelectedTab
            If tabselected.Index > 0 Then
                gridexcel = DirectCast(tabselected.TabControl.Controls.Item(2).Controls.Item(0), UltraGrid)

            Else
                gridexcel = Me.grdDataMain
            End If
            If gridexcel IsNot Nothing Then
                If gridexcel.Rows.Count > 0 Then
                    Dim fileexported As String = pathStoredFiles & My.User.Name.Replace("\", "_") & "_" & Me.UltraExplorerBar1.SelectedGroup.Key.ToString.Trim & "_" & Now.Millisecond.ToString & Now.Second.ToString & ".xls"
                    sysmsg1.SysMsg("Archivo Generado: " & fileexported.Replace(pathStoredFiles, ""))
                    Me.UltraGridExcelExporter1.Export(gridexcel, fileexported)
                Else
                    sysmsg1.SysMsg("No se encontraron datos para exportar", True)
                End If
            Else
                sysmsg1.SysMsg("No se encontraron datos para exportar", True)
            End If
        Catch ex As Exception
            sysmsg1.SysMsg(ex.Message, True)
        End Try
    End Sub

    Private Sub Display_Form(key As String, Permiso As Integer, deleterecord As Boolean)
        Try
            If Not childmodal Then
                Me.UltraTabControl1.Visible = False
                Me.CommandBar.Visible = False
            End If
            Me.Cursor = Cursors.WaitCursor
            tabs1.LoadForms(key, Me.UltraTabControl1.SelectedTab.Key.ToString, Permiso, deleterecord, Me)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            sysmsg1.SysMsg("Seleccione un registro", True)
        End Try
    End Sub
    Private Sub NewToolStripButton_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Try
            Display_Form("0", 1, False)
            '        Me.UltraTabControl1.Visible = False
            '        Me.CommandBar.Visible = False
            '        tabs1.LoadForms("0", Me.UltraTabControl1.SelectedTab.Key.ToString, 1, False, Me)
        Catch ex As Exception
            sysmsg1.SysMsg("Seleccione un registro", True)
        End Try
    End Sub
    Private Sub OpenToolStripButton_Click(sender As Object, e As EventArgs) Handles btnAbrir.Click
        Try
            Display_Form(Me.grdDataMain.ActiveRow.Cells(0).Text, 1, False)
            '    If Not child_modal Then
            '        Me.UltraTabControl1.Visible = False
            '        Me.CommandBar.Visible = False
            '    End If
            '    tabs1.LoadForms(Me.grdDataMain.ActiveRow.Cells(0).Text, Me.UltraTabControl1.SelectedTab.Key.ToString, 1, False, Me)
        Catch ex As Exception
            sysmsg1.SysMsg("Seleccione un registro", True)
        End Try
    End Sub
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Display_Form(Me.grdDataMain.ActiveRow.Cells(0).Text, 1, True)
        Try
            Display_Form(Me.grdDataMain.ActiveRow.Cells(0).Text, 1, True)
            '    Me.UltraTabControl1.Visible = False
            '    Me.CommandBar.Visible = False
            '    tabs1.LoadForms(Me.grdDataMain.ActiveRow.Cells(0).Text, Me.UltraTabControl1.SelectedTab.Key.ToString, 1, True, Me)
        Catch ex As Exception
            sysmsg1.SysMsg("Seleccione un registro", True)
        End Try
    End Sub
    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click

        Try
            Display_Form(Me.grdDataMain.ActiveRow.Cells(0).Text, 0, False)
            'Me.UltraTabControl1.Visible = False
            'Me.CommandBar.Visible = False
            'tabs1.LoadForms(Me.grdDataMain.ActiveRow.Cells(0).Text, Me.UltraTabControl1.SelectedTab.Key.ToString, 0, False, Me)
        Catch ex As Exception
            sysmsg1.SysMsg("Seleccione un registro", True)
        End Try
    End Sub
    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        Dim expfiles As New frmExportedFiles
        expfiles.Show()
    End Sub
    Private Sub btnBuscaFiltro_Click(sender As Object, e As EventArgs) Handles btnBuscaFiltro.Click
        Try
            Dim i As Integer = Me.UltraTabControl1.Tabs.Count - 1
            While Me.UltraTabControl1.Tabs.Count > 1
                If i > 0 Then
                    Me.UltraTabControl1.Tabs.Remove(UltraTabControl1.Tabs(i))
                End If
                i = i - 1
            End While
            If Not tabs1.add_tabs(current_menu, Me.UltraTabControl1, Me.grdDataMain, Me.txtFilter.Text) Then
                sysmsg1.SysMsg(tabs1.errmsg, True)
            End If
            If Me.grdDataMain.Rows.Count = 0 Then
                UltraTabControl1.Tabs(0).Text = "&Búsqueda"
                cxn.Get_SQL_DataGrid("select 'No se encontró información' as Mensaje", Me.grdDataMain)
            End If
        Catch ex As Exception
            sysmsg1.SysMsg(ex.Message, True)
        End Try
    End Sub

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        'Dim rpt As New frmReport
        'rpt.query = tabs1.get_query_tab(Me.UltraTabControl1.SelectedTab.Key.ToString, Me.txtFilter.Text.Trim)
        'rpt.Show()
    End Sub

    'Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    '    Dim cnt As Decimal = 0
    '    Me.lblTime.Text = Now().ToString
    'End Sub

    Private Sub txtFilter_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFilter.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnBuscaFiltro_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub btnIrMenu_Click(sender As Object, e As EventArgs) Handles btnIrMenu.Click
        Try
            Dim response As String = InputBox("TECLEAR CÓDIGO DE MENÚ", "IR A MENÚ").ToUpperInvariant
            Dim foundit As Boolean = False
            If response <> "" Then
                Dim group1 As UltraExplorerBarGroup
                For Each group1 In Me.UltraExplorerBar1.Groups
                    For i = 0 To group1.Items.Count - 1
                        Dim item As UltraExplorerBarItem = group1.Items(i)
                        If item.Key = response.ToUpper Then
                            group1.Selected = True
                            group1.Expanded = True
                            Me.UltraExplorerBar1.ActiveGroup = group1
                            Me.UltraExplorerBar1.ActiveItem = Me.UltraExplorerBar1.ActiveGroup.Items(0)
                            item.Active = True
                            foundit = True
                        End If
                    Next
                Next
                If Not foundit Then
                    sysmsg1.SysMsg("No se encontró el menú, verifique...", True)
                End If
            End If
        Catch ex As Exception
            sysmsg1.SysMsg("No se encontró el menú, verifique...", True)
        End Try
    End Sub

    Private Sub UltraExplorerBar1_ActiveItemChanged(sender As Object, e As ItemEventArgs) Handles UltraExplorerBar1.ActiveItemChanged
        Me.UltraExplorerBar1_ItemDoubleClick(sender, e)
    End Sub

    Private Sub UltraTabControl1_VisibleChanged(sender As Object, e As EventArgs)
        If Me.UltraTabControl1.Visible Then
            load_menu_grid(current_menu)
            Me.CommandBar.Visible = True
            Me.Activate()
        End If
    End Sub

    Private Sub UltraTabControl1_SelectedTabChanged(sender As Object, e As SelectedTabChangedEventArgs) Handles UltraTabControl1.SelectedTabChanged
        Try
            If Not Me.tabs1.Load_Tab_data(Me.UltraTabControl1, Me.grdDataMain.ActiveRow.Cells(0).Text) Then
                ' SystemMessages1.SysMsg(tabs1.errmsg, True)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPDF_Click(sender As Object, e As EventArgs) Handles btnPDF.Click
        Try
            Dim gridexcel As UltraGrid = Nothing
            Dim tabselected As UltraTab = Me.UltraTabControl1.SelectedTab
            If tabselected.Index > 0 Then
                gridexcel = DirectCast(tabselected.TabControl.Controls.Item(2).Controls.Item(0), UltraGrid)

            Else
                gridexcel = Me.grdDataMain
            End If
            If gridexcel IsNot Nothing Then
                If gridexcel.Rows.Count > 0 Then
                    Dim fileexported As String = pathStoredFiles & My.User.Name.Replace("\", "_") & "_" & Me.UltraExplorerBar1.SelectedGroup.Key.ToString.Trim & Now.Millisecond.ToString & Now.Second.ToString & ".pdf"
                    Me.UltraGridDocumentExporter1.Export(gridexcel, fileexported, DocumentExport.GridExportFileFormat.PDF)
                    sysmsg1.SysMsg("Archivo Generado: " & fileexported.Replace(pathStoredFiles, ""))
                Else
                    sysmsg1.SysMsg("No se encontraron datos para exportar", True)
                End If
            Else
                sysmsg1.SysMsg("No se encontraron datos para exportar", True)
            End If
        Catch ex As Exception
            sysmsg1.SysMsg(ex.Message, True)
        End Try
    End Sub

    Private Sub ToolStripButton1_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Try
            mnu1.MainBar = Me.UltraExplorerBar1
            Dim loaded As Boolean
            loaded = mnu1.load_MainMenu(True)
            current_menu = ""
            CloseActiveForms()
            Me.UltraExplorerBar1.Groups.Item(0).Active = True
            Me.UltraExplorerBar1.ActiveItem = Me.UltraExplorerBar1.ActiveGroup.Items(0)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub grdDataMain_DoubleClickRow(sender As Object, e As DoubleClickRowEventArgs) Handles grdDataMain.DoubleClickRow
        Try
            Display_Form(Me.grdDataMain.ActiveRow.Cells(0).Text, 0, False)
        Catch ex As Exception
            sysmsg1.SysMsg("Seleccione un registro", True)
        End Try
    End Sub


End Class
