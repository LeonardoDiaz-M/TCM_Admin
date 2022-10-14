Imports Infragistics.Win.UltraWinTabControl
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraMessageBox
Imports Infragistics.Win

Public Class clsMenuLoadQuery
    Private cxn As New cxnData
    Public errmsg As String = ""
    Private form As String
    Public Function Load_Tab_data(tab As UltraTabControl, filterValue As String) As Boolean
        Dim ban As Boolean = False
        Dim grdtab As New UltraGrid

        Try
            If tab.SelectedTab.Index > 0 Then

                Dim currenttab As UltraTab = tab.SelectedTab
                currenttab.TabPage.Controls.RemoveByKey("grd" & tab.SelectedTab.Key)
                If cxn.Select_SQL("select * from tbMainMenuTabs where idTab=" & currenttab.Key.ToString) Then
                    If cxn.arrayValores(0) IsNot Nothing Then
                        If cxn.Get_SQL_DataGrid(cxn.arrayValores(3).Replace("<$Filtro1$>", filterValue), grdtab) Then
                            grdtab.Name = "grd" & currenttab.Key.ToString
                            grdtab.Dock = DockStyle.Fill
                            grdtab.Refresh()
                            currenttab.TabPage.Controls.Add(grdtab)
                            tab.SelectedTab = currenttab
                            ban = True
                        Else
                            Me.errmsg = "Error al ejectuar la consulta: " & cxn.arrayValores(0)
                        End If
                    Else
                        Me.errmsg = "No se encontro el registro del Tab " & currenttab.Key
                    End If
                Else
                    Me.errmsg = "Error al ejectuar la consulta: " & cxn.arrayValores(0)
                End If
            End If
        Catch ex As Exception
            Me.errmsg = ex.Message
        End Try
        Return ban
    End Function
    Public Function get_query_tab(currenttabKey As String, filtro As String) As String
        Dim qry As String = ""
        If cxn.Select_SQL("select * from tbMainMenuTabs where idTab=" & currenttabKey) Then
            qry = cxn.arrayValores(3).ToString.Trim.ToLower.Replace("<$filtro1$>", filtro)
        End If
        Return qry
    End Function
    Public Function add_tabs(mnucode As String, tab As UltraTabControl, grid As UltraGrid, Optional filtro As String = "") As Boolean
        Dim ban As Boolean = False
        Try
            Dim total_tabs As Integer = 0
            Dim readersql As System.Data.IDataReader = Nothing
            Dim counter As Integer = 1
            Dim exec_qry As Boolean = False
            Dim tabAdded As UltraTab
            Dim tabs As UltraTabsCollection = tab.Tabs
            Dim cxn2 As New cxnData
            If cxn.Select_SQL("select count(*) from tbMainMenuTabs  where Menu= '" & mnucode & "' ") Then
                If cxn.arrayValores(0) IsNot Nothing Then
                    total_tabs = cxn.arrayValores(0)
                End If
                If total_tabs > 0 Then
                    tab.BeginUpdate()
                    If tab.Tabs.Count > 0 Then
                        For Each tb As UltraTab In tab.Tabs
                            If tb.Index > 1 Then
                                Dim removetab As UltraTab
                                removetab = tb
                                tab.Tabs.Remove(removetab)
                            End If
                        Next
                    End If

                    readersql = cxn2.Select_SQL("select * from tbMainMenuTabs " &
                                       " where Menu= '" & mnucode & "' and status=1  order by TabOrder asc", readersql)
                    counter = 1

                    If readersql.IsClosed = False Then
                        While readersql.Read()
                            Dim grid2 As New UltraGrid
                            If counter = 1 Then
                                tab.Tabs(0).Text = "&" & readersql.Item(2).ToString.Trim
                                tab.Tabs(0).Key = readersql.Item(0).ToString.Trim
                                cxn2.Get_SQL_DataGrid(readersql.Item(3).ToString.Trim.ToLower.Replace("<$filtro1$>", filtro), grid)
                            Else
                                cxn.Get_SQL_DataGrid("select 'Seleccione un registro... [Información]'", grid2)
                                'agrega tab de forma dinamica en base al datareader con las propiedades: key and text
                                tabAdded = tabs.Add(readersql.Item(0).ToString.Trim, "&" & readersql.Item(2).ToString.Trim)
                                tabAdded.Active = True
                                'establece propiedades del grid para agregarlo al tab
                                grid2.Name = "grd" & readersql.Item(0).ToString.Trim
                                NameGrid = grid2.Name.ToString
                                grid2.DisplayLayout.Scrollbars = Scrollbars.Automatic
                                grid2.Refresh()
                                'agrega el grid al tab agregado dinamicamente en el ciclo.
                                tabAdded.TabPage.Controls.Add(grid2)
                            End If
                            counter = counter + 1
                        End While
                    Else
                        cMensajes.DisplayMessage(Me, "Error de comunicación intente nuevamente", vbExclamation, vbYes, vbYes)
                    End If


                    tab.EndUpdate()
                    ban = True
                End If
            Else
                Me.errmsg = "No se encontrarón registros de Tabs del Menú: " & mnucode
            End If
        Catch ex As Exception
            Me.errmsg = ex.Message
        End Try
        Return ban
    End Function



    Public Function LoadForms(idKey As String, mnuCode As String, Lectura As String, Insertar As String, Borrar As String, Editar As String, Optional deleterecord As Boolean = False,
                              Optional mdiMainParent As Form = Nothing) As Boolean
        Dim ban As Boolean = False
        Dim mnucod As String = ""
        Dim Dock As Boolean = False
        Try
            Dim Sql_Select As String = ""
            Sql_Select = "select FormName,Menu,dockform from tbMainMenuTabs where idTab= " & mnuCode
            'Sql_Select = "select FormName,Menu,dockform from tbMainMenuTabs where idTab= " & mnuCode & " and Status=1"

            If cxn.Select_SQL(Sql_Select) Then
                form = cxn.arrayValores(0)
                mnucod = cxn.arrayValores(1)
                Dock = cxn.arrayValores(2)

                If form.Trim.Length > 0 Then
                    Dim formDB As Object = Activator.CreateInstance(Type.GetType(My.Application.Info.AssemblyName & "." & form))
                    formDB.id = idKey
                    formDB.Lectura = Lectura
                    formDB.Insertar = Insertar
                    formDB.Borrar = Borrar
                    formDB.Editar = Editar

                    formDB.delete_record = deleterecord
                    'formDB.Tipo_Permiso = Permiso
                    Dim ismodal As Boolean = False
                    If cxn.Select_SQL("select isModal from tbMainsubMenus where SubMenu= '" & mnucod & "'") Then
                        If cxn.arrayValores(0) IsNot Nothing AndAlso cxn.arrayValores(0).ToLowerInvariant = "true" Then
                            ismodal = True
                        End If
                    End If

                    If Not ismodal Then
                        formDB.FormBorderStyle = FormBorderStyle.None
                        TryCast(formDB, Form).MdiParent = mdiMainParent
                        TryCast(formDB, Form).TopLevel = False
                        TryCast(formDB, Form).FormBorderStyle = FormBorderStyle.None
                        If Dock = True Then
                            TryCast(formDB, Form).Dock = DockStyle.Fill
                        End If
                        formDB.Parent = mdiMainParent
                        cxn.Select_SQL("select description from tbMainSubMenus where submenu='" & mnucod & "'")
                        formDB.Text = cxn.arrayValores(0).ToUpperInvariant
                        formDB.Show()
                    Else
                        ' TryCast(formDB, Form).MdiParent = mdiMainParent
                        formDB.Parent = mdiMainParent
                        Plexiglass(formDB, mdiMainParent)
                    End If
                    ban = True
                End If
            Else
                errmsg = "Error, no se encontró una forma asociada al menú"
            End If

        Catch ex As Exception
            errmsg = ex.Message
        End Try
        Return ban
    End Function
    Public Shared Function Plexiglass(dialog As Form, parent As Form) As DialogResult
        Try
            Using plexi = New Form()
                plexi.FormBorderStyle = FormBorderStyle.None
                plexi.Bounds = Screen.FromPoint(dialog.Location).Bounds
                plexi.StartPosition = FormStartPosition.Manual
                plexi.AutoScaleMode = AutoScaleMode.None
                plexi.ShowInTaskbar = False
                plexi.BackColor = Color.Black
                plexi.Opacity = 0.45
                'plexi.MdiParent = parent
                plexi.Show()
                dialog.StartPosition = FormStartPosition.CenterParent
                Return dialog.ShowDialog(plexi)

            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return 0
    End Function
End Class
