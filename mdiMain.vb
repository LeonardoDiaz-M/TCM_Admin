Imports System.ComponentModel
Imports System.Windows.Forms
Imports Infragistics.Win.UltraWinExplorerBar
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinTabControl
Imports System.Web.Security
Public Class mdiMain
    Private childmodal As Boolean = False
    Private mnu1 As New clsMainMenu
    Private tabs1 As New clsMenuLoadQuery
    Private current_menu As String = ""
    Private cxn As New cxnData
    Public RegAguaPorCuenta As Boolean = False
    Public RegAguaPorRuta As Boolean = False
    Public RegSeguridad As Boolean = False
    Public RegPae As Boolean = False
    Dim RolLectura As String = ""
    Dim RolInsertar As String = ""
    Dim RolBorrar As String = ""
    Dim RolEditar As String = ""
    'Private sysmsg1 As Object

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lgn As New Login
        lgn.ShowDialog(Me)
        Me.Cursor = Cursors.WaitCursor
        If CurrentUsrName <> "" Then
            txtUsuario.Text = "USUARIO: " & NombreUsuario
            txtPuesto.Text = "PUESTO: " & DescripcionPuesto
            txtNombreOficina.Text = "OFICINA: " & NombreOficina
            mnu1.MainBar = Me.expPrincipal
            Infragistics.Win.AppStyling.StyleManager.Load("Metro.isl")
            Dim loaded As Boolean
            loaded = mnu1.load_MainMenu(True)
            'ValidaSeguridad()
            Me.Timer1.Enabled = True
            If Not loaded Then
                sysmsg1.SysMsg("Error al cargar el menú - " & mnu1.errmsg, True)
            End If
        Else
            End
        End If
        Me.Cursor = Cursors.Default


    End Sub
    Private Sub ValidaSeguridad()
        expPrincipal.Groups("gruCatastro").Visible = Roles.IsUserInRole(Usuario, "Padrón Catastro Predio: Consultar")
        expPrincipal.Groups("gruCatastro").Items("itmCatConsulta").Visible = Roles.IsUserInRole(Usuario, "Padrón Catastro Predio: Consultar") ''VALIDA ALTAS PREDIO
        expPrincipal.Groups("gruCatastro").Items("itmAltaPadron").Visible = Roles.IsUserInRole(Usuario, "Padrón Catastro Predio: Insertar") ''VALIDA ALTAS PREDIO
        expPrincipal.Groups("gruCatastro").Items("itmReportesPadron").Visible = Roles.IsUserInRole(Usuario, "Padrón Catastro Reportes: Consultar") ''VALIDA REPORTES CATASTRO
        expPrincipal.Groups("gruCatastro").Items("itmValuacion").Visible = Roles.IsUserInRole(Usuario, "Padrón Catastro Predio: Valuación") ''VALIDA PREDIO VALUACIÓN

        expPrincipal.Groups("itmCatalogos").Visible = Roles.IsUserInRole(Usuario, "Catálogos Catastro: Consultar")
        'SE COMENTA SECCION EN CASO DE QUERER PERSONALIZAR PERMISOS POR SUBMENU
        '    expPrincipal.Groups("itmCatalogos").Items("itmCatalogosGenerales").Visible = Roles.IsUserInRole(Usuario_actual, "Catálogos Catastro: Consultar") ''VALIDA CATASTRO CATALOGOS
        '    expPrincipal.Groups("itmCatalogos").Items("itmCatalogosOperativos").Visible = Roles.IsUserInRole(Usuario_actual, "Catálogos Catastro: Consultar") ''VALIDA CATASTRO CATALOGOS
        '    expPrincipal.Groups("itmCatalogos").Items("itmCatalogosMunicipales").Visible = Roles.IsUserInRole(Usuario_actual, "Catálogos Catastro: Consultar") ''VALIDA CATASTRO CATALOGOS

        expPrincipal.Groups("itmSeguridad").Visible = Roles.IsUserInRole(Usuario, "Seguridad: Consulta")
        expPrincipal.Groups("itmSeguridad").Items("itmUsuarios").Visible = Roles.IsUserInRole(Usuario, "Seguridad: Usuarios") 'VALIDA USUARIOS
        expPrincipal.Groups("itmSeguridad").Items("itmPermisos").Visible = Roles.IsUserInRole(Usuario, "Seguridad: Permisos") 'VALIDA PERMISOS
        expPrincipal.Groups("itmSeguridad").Items("itmCambioContraseña").Visible = Roles.IsUserInRole(Usuario, "Seguridad: Contraseña") 'CAMBIO CONTRASEÑA


    End Sub
    Private Sub expPrincipal_ItemDoubleClick(sender As Object, e As ItemEventArgs) Handles expPrincipal.ItemDoubleClick
        Try
            RegAguaPorCuenta = False
            RegAguaPorRuta = False
            RegSeguridad = False
            RegPae = False
            Dim Key As String = ""
            'validamos la apertura de forms de MENU Seguridad, ya que no tienen grid para consulta
            If e.Item.Key = "SEG001" Or e.Item.Key = "SEG002" Or e.Item.Key = "SEG003" Or e.Item.Key = "SEG004" Or e.Item.Key = "REP001" Or e.Item.Key = "PAE011" Or e.Item.Key = "PAE012" Or e.Item.Key = "PAE013" Then
                If e.Item.Key = "SEG001" Then
                    Key = "81"
                    RegSeguridad = True
                ElseIf e.Item.Key = "SEG002" Then
                    Key = "83"
                    RegSeguridad = True
                ElseIf e.Item.Key = "SEG003" Then
                    Key = "82"
                    RegSeguridad = True
                ElseIf e.Item.Key = "SEG004" Then
                    Key = "84"
                ElseIf e.Item.Key = "REP001" Then
                    Key = "110"
                    RegSeguridad = True
                ElseIf e.Item.Key = "PAE011" Then
                    Key = "115"
                    RegPae = True
                ElseIf e.Item.Key = "PAE012" Then
                    Key = "116"
                    RegPae = True
                ElseIf e.Item.Key = "PAE013" Then
                    Key = "117"
                    RegPae = True
                End If
                Me.CommandBar.Enabled = False
                RegAguaPorCuenta = False
                RegAguaPorRuta = False
                RegSeguridad = True

                CloseActiveForms()
                'tabPrincipal.Visible = False

                Me.current_menu = e.Item.Key
                Me.lblMenu.Text = vbTab & e.Item.Key & "-" & e.Item.Text

                Display_Form(Key, RolLectura, RolInsertar, RolBorrar, RolEditar, False)

                Exit Sub
            End If

            If e.Item.Key <> current_menu Then
                tabPrincipal.Visible = True
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

        'carga roles aplicados al formulario
        cxn.Select_SQL("SELECT dbo.tbMainSubMenus.Description, ISNULL(aspnet_Roles_0.RoleName,'No Asignado') AS Lectura, 
ISNULL(aspnet_Roles_1.RoleName,'No Asignado') AS Insertar,
ISNULL(aspnet_Roles_2.RoleName,'No Asignado') AS Borrar, 
ISNULL(aspnet_Roles_3.RoleName,'No Asignado') AS Editar
FROM  dbo.tbMainSubMenus 
left JOIN 
BASE_MPIO_SEC.dbo.aspnet_Roles AS aspnet_Roles_0 ON dbo.tbMainSubMenus.ReadOpt = aspnet_Roles_0.RoleId 
left JOIN BASE_MPIO_SEC.dbo.aspnet_Roles AS aspnet_Roles_1 ON dbo.tbMainSubMenus.AddOpt = aspnet_Roles_1.RoleId 
left JOIN BASE_MPIO_SEC.dbo.aspnet_Roles AS aspnet_Roles_2 ON dbo.tbMainSubMenus.DelOpt = aspnet_Roles_2.RoleId
left JOIN BASE_MPIO_SEC.dbo.aspnet_Roles AS aspnet_Roles_3 ON dbo.tbMainSubMenus.UpdOpt = aspnet_Roles_3.RoleId
where tbMainSubMenus.SubMenu='" & menu & "'")


        If cxn.arrayValores(0) IsNot Nothing Then
            RolLectura = cxn.arrayValores(1)
            RolInsertar = cxn.arrayValores(2)
            RolBorrar = cxn.arrayValores(3)
            RolEditar = cxn.arrayValores(4)
        End If

        Me.current_menu = menu
        Me.lblMenu.Text = vbTab & menu & "-" & cxn.arrayValores(0)

        'Si es agua habilito botones lecturas
        If menu = "USU058" Then
            btnRegistroConsumo.Visible = True
            btnRegistroPorCuenta.Visible = True
        Else
            btnRegistroConsumo.Visible = False
            btnRegistroPorCuenta.Visible = False

        End If
        btnGoogle.Visible = True

        Try
            'remueve tabs activas
            Dim i As Integer = Me.tabPrincipal.Tabs.Count - 1
            While Me.tabPrincipal.Tabs.Count > 1
                If i > 0 Then
                    Me.tabPrincipal.Tabs.Remove(tabPrincipal.Tabs(i))
                End If
                i = i - 1
            End While


            'borra datos del grid
            Me.grdDataMain.DataSource = Nothing

            If Not tabs1.add_tabs(current_menu, Me.tabPrincipal, Me.grdDataMain, Me.txtFilter.Text) Then
                sysmsg1.SysMsg(tabs1.errmsg, True)
            End If

            If Me.grdDataMain.Rows.Count = 0 Then
                cxn.Select_SQL("select FormName from tbMainMenuTabs where Menu='" & menu & "' and status=1  and (query='' or query is null)")

                If cxn.arrayValores(0) IsNot Nothing And cxn.err = "" Then
                    childmodal = False
                    Display_Form("0", RolLectura, RolInsertar, RolBorrar, RolEditar, False)
                ElseIf cxn.err <> "" Then
                    Me.sysmsg1.SysMsg(cxn.err, True)
                Else
                    tabPrincipal.Tabs(0).Text = "&Búsqueda"
                    cxn.Get_SQL_DataGrid("select 'No se encontró información' as Mensaje", Me.grdDataMain)
                End If

            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub CloseActiveForms()
        Try
            Me.tabPrincipal.Visible = True
            Me.CommandBar.Visible = True
            For Each f As Form In My.Application.OpenForms
                If f.Name.ToLower <> "mdimain" Then
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


    Private Sub Display_Form(key As String, Lectura As String, Insertar As String, Borrar As String, Editar As String, deleterecord As Boolean)
        Try

            If Not childmodal Then
                Me.tabPrincipal.Visible = False
            End If
            Me.Cursor = Cursors.WaitCursor

            If RegAguaPorRuta = True Then
                tabs1.LoadForms(94, "94", Lectura, Insertar, Borrar, Editar, deleterecord, Me)
            End If

            If RegAguaPorCuenta = True Then
                tabs1.LoadForms(key, "114", Lectura, Insertar, Borrar, Editar, deleterecord, Me)
            End If

            If RegSeguridad = True Then
                tabs1.LoadForms(key, key, Lectura, Insertar, Borrar, Editar, deleterecord, Me)
            End If
            If RegAguaPorRuta = False And RegAguaPorCuenta = False And RegSeguridad = False Then
                tabs1.LoadForms(key, Me.tabPrincipal.SelectedTab.Key.ToString, Lectura, Insertar, Borrar, Editar, deleterecord, Me)
            End If
            Me.Cursor = Cursors.Default

        Catch ex As Exception
            sysmsg1.SysMsg("Seleccione un registro", True)
        End Try
    End Sub
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Try

            Dim Id As String = ""
            Me.CommandBar.Enabled = False
            RegAguaPorRuta = False
            RegAguaPorCuenta = False
            RegSeguridad = False
            Display_Form("0", RolLectura, RolInsertar, RolBorrar, RolEditar, False)
        Catch ex As Exception
            sysmsg1.SysMsg("Seleccione un registro", True)
        End Try
    End Sub
    Private Sub btnAbrir_Click(sender As Object, e As EventArgs) Handles btnAbrir.Click
        Try
            RegAguaPorRuta = False
            RegAguaPorCuenta = False
            RegSeguridad = False
            Display_Form(Me.grdDataMain.ActiveRow.Cells(0).Text, RolLectura, RolInsertar, RolBorrar, RolEditar, False)
        Catch ex As Exception
            sysmsg1.SysMsg("Seleccione un registro", True)
        End Try
    End Sub
    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim expfiles As New frmExportedFiles
        expfiles.Show()
    End Sub
    Private Sub btnBuscaFiltro_Click(sender As Object, e As EventArgs) Handles btnBuscaFiltro.Click
        Try
            Dim i As Integer = Me.tabPrincipal.Tabs.Count - 1
            While Me.tabPrincipal.Tabs.Count > 1
                If i > 0 Then
                    Me.tabPrincipal.Tabs.Remove(tabPrincipal.Tabs(i))
                End If
                i = i - 1
            End While
            If Not tabs1.add_tabs(current_menu, Me.tabPrincipal, Me.grdDataMain, Me.txtFilter.Text) Then
                sysmsg1.SysMsg(tabs1.errmsg, True)
            End If
            If Me.grdDataMain.Rows.Count = 0 Then
                tabPrincipal.Tabs(0).Text = "&Búsqueda"
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

    Private Sub txtFilter_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFilter.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnBuscaFiltro_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub UltraExplorerBar1_ActiveItemChanged(sender As Object, e As ItemEventArgs) Handles expPrincipal.ActiveItemChanged
        lblParent.Text = Me.expPrincipal.SelectedGroup.Text
        Me.expPrincipal_ItemDoubleClick(sender, e)
    End Sub

    Private Sub UltraTabControl1_VisibleChanged(sender As Object, e As EventArgs) Handles tabPrincipal.VisibleChanged
        If RegSeguridad = False Then
            If Me.tabPrincipal.Visible Then
                load_menu_grid(current_menu)
                Me.CommandBar.Visible = True
                Me.Activate()
            End If
        Else
            tabPrincipal.Visible = False
        End If

    End Sub

    Private Sub UltraTabControl1_SelectedTabChanged(sender As Object, e As SelectedTabChangedEventArgs) Handles tabPrincipal.SelectedTabChanged
        Try
            If Not Me.tabs1.Load_Tab_data(Me.tabPrincipal, Me.grdDataMain.ActiveRow.Cells(0).Text) Then
                'System.Messages1.SysMsg(tabs1.errmsg, True)
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Excel_Click(sender As Object, e As EventArgs) Handles Excel.Click
        Try
            Dim sfd As New SaveFileDialog
            Dim gridexcel As UltraGrid = Nothing
            Dim tabselected As UltraTab = Me.tabPrincipal.SelectedTab
            If tabselected.Index > 0 Then
                gridexcel = DirectCast(tabselected.TabControl.Controls.Item(2).Controls.Item(0), UltraGrid)
            Else
                gridexcel = Me.grdDataMain
            End If


            If gridexcel IsNot Nothing Then
                If gridexcel.Rows.Count > 0 Then
                    With sfd
                        .Title = "Ingresa el nombre del archivo a exportar"
                        .Filter = "Excel files (*.xls)|*.xls|All files (*.*)|*.*"
                        .ShowDialog()
                        If .FileName <> "" Then
                            Me.Cursor = Cursors.WaitCursor
                            ugeExporter.Export(gridexcel, .FileName)
                            Me.Cursor = Cursors.Default
                            MsgBox("Datos exportados correctamente!", MsgBoxStyle.Information, "Consulta")
                        End If
                    End With
                Else
                    MessageBox.Show("No existen registros a exportar", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else
                MessageBox.Show("No existen registros a exportar", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub btnPDF_Click(sender As Object, e As EventArgs) Handles btnPDF.Click
        Try
            Dim gridexcel As UltraGrid = Nothing
            Dim tabselected As UltraTab = Me.tabPrincipal.SelectedTab
            If tabselected.Index > 0 Then
                gridexcel = DirectCast(tabselected.TabControl.Controls.Item(2).Controls.Item(0), UltraGrid)

            Else
                gridexcel = Me.grdDataMain
            End If
            If gridexcel IsNot Nothing Then
                If gridexcel.Rows.Count > 0 Then
                    Dim fileexported As String = pathStoredFiles & My.User.Name.Replace("\", "_") & "_" & Me.expPrincipal.SelectedGroup.Key.ToString.Trim & Now.Millisecond.ToString & Now.Second.ToString & ".pdf"
                    Me.ugdDocumentexporter.Export(gridexcel, fileexported, DocumentExport.GridExportFileFormat.PDF)
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
    Private Sub grdDataMain_ClickCell(sender As Object, e As ClickCellEventArgs) Handles grdDataMain.ClickCell
        'si el padron actual es agua potable, establecemos rutina para mostrar u ocultar boton consumo agua por cuenta
        If current_menu = "USU058" Then
            Dim Servicio As String
            Servicio = grdDataMain.ActiveRow.Cells("Servicio").Value
            If Servicio = "MEDIDO" Then
                btnRegistroPorCuenta.Visible = True
            ElseIf Servicio = "CUOTA FIJA" Then
                btnRegistroPorCuenta.Visible = False
            End If
        End If
    End Sub
    Private Sub grdDataMain_DoubleClickRow(sender As Object, e As DoubleClickRowEventArgs) Handles grdDataMain.DoubleClickRow
        Try
            Dim Id As String = ""
            RegAguaPorRuta = False
            RegAguaPorCuenta = False
            RegSeguridad = False
            Me.CommandBar.Enabled = False
            Display_Form(Me.grdDataMain.ActiveRow.Cells(0).Text, RolLectura, RolInsertar, RolBorrar, RolEditar, False)
        Catch ex As Exception
            sysmsg1.SysMsg("Seleccione un registro", True)
        End Try
    End Sub
    Private Sub Show_Form_Dialog(mnuCode As String, IdKey As String)
        Dim Sql_Select As String = ""
        Dim Form As String = ""
        Dim mnuCod As String = ""
        Sql_Select = "select FormName,Menu,dockform from tbMainMenuTabs where menu= '" & mnuCode & "'"
        If cxn.Select_SQL(Sql_Select & " and Status=0") Then
            Form = cxn.arrayValores(0)
            mnuCod = cxn.arrayValores(1)

            If Form.Trim.Length > 0 Then
                Dim formDB As Object = Activator.CreateInstance(Type.GetType(My.Application.Info.AssemblyName & "." & Form))
                formDB.id = IdKey
                formDB.Showdialog
                load_menu_grid(current_menu)

            End If
        End If
    End Sub


    Private Sub tsbMenuPrincipal_Click(sender As Object, e As EventArgs) Handles tsbMenuPrincipal.Click
        udmPrincipal.ShowAll()
    End Sub

    Private Sub mdiMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If (MsgBox("¿Esta seguro de salir?", vbCritical + vbYesNo) = vbYes) Then
            End
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub tsbSalir_Click(sender As Object, e As EventArgs)
        If (MsgBox("¿Esta seguro de salir?", vbCritical + vbYesNo) = vbYes) Then
            End
        End If
    End Sub

    Private Sub grdDataMain_GotFocus(sender As Object, e As EventArgs) Handles grdDataMain.GotFocus
        CommandBar.Enabled = True
    End Sub

    Private Sub btnRegistroConsumo_Click(sender As Object, e As EventArgs) Handles btnRegistroConsumo.Click
        Try
            CloseActiveForms()
            tabPrincipal.Visible = True
            Me.CommandBar.Enabled = False
            RegAguaPorCuenta = False
            RegAguaPorRuta = True
            RegSeguridad = False
            Display_Form(94, RolLectura, RolInsertar, RolBorrar, RolEditar, False)
        Catch ex As Exception
            sysmsg1.SysMsg("Seleccione un registro", True)
        End Try
    End Sub

    Private Sub btnRegistroPorCuenta_Click(sender As Object, e As EventArgs) Handles btnRegistroPorCuenta.Click
        Try
            tabPrincipal.Visible = True
            Me.CommandBar.Enabled = False
            RegAguaPorCuenta = True
            RegAguaPorRuta = False
            RegSeguridad = False
            Display_Form(Me.grdDataMain.ActiveRow.Cells(0).Text, RolLectura, RolInsertar, RolBorrar, RolEditar, False)
        Catch ex As Exception
            sysmsg1.SysMsg("Seleccione un registro", True)
        End Try
    End Sub

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

    Private Sub btnGoogle_Click(sender As Object, e As EventArgs) Handles btnGoogle.Click
        Dim frm As New frmGoogleMaps
        Dim Latitud As String = ""
        Dim Longitud As String = ""

        Latitud = Me.grdDataMain.ActiveRow.Cells("Latitud").Text
        Longitud = Me.grdDataMain.ActiveRow.Cells("Longitud").Text

        If Val(Latitud) = 0 Or Val(Longitud) = 0 Then
            cMensajes.DisplayMessage(Me, "No se han registrado las coordenadas geográficas del inmueble en el padrón, actualice el registro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End If

        frm.txtLatitud.Text = Latitud
        frm.txtLongitud.Text = Longitud

        If current_menu = "IMP056" Then
            frm.lblTipoPadron.Text = "arc_predial"
            frm.lblClavePadron.Text = Me.grdDataMain.ActiveRow.Cells("Clave catastral").Text
            frm.lblCampo.Text = "cve_catastral"
            frm.lblNombreContribuyente.Text = Me.grdDataMain.ActiveRow.Cells("Propietario").Text
        ElseIf current_menu = "USU058" Then
            frm.lblTipoPadron.Text = "arc_Agua"
            frm.lblClavePadron.Text = Me.grdDataMain.ActiveRow.Cells("Num_cuenta").Text
            frm.lblCampo.Text = "num_cuenta"
            frm.lblNombreContribuyente.Text = Me.grdDataMain.ActiveRow.Cells("Nombre").Text
        Else
            frm.lblTipoPadron.Text = "tbl_lic_municipales"
            frm.lblClavePadron.Text = Me.grdDataMain.ActiveRow.Cells("Clave").Text
            frm.lblCampo.Text = "cve_licencia"
            frm.lblNombreContribuyente.Text = Me.grdDataMain.ActiveRow.Cells("Propietario").Text
        End If
        frm.ShowDialog()
        load_menu_grid(current_menu)
    End Sub

End Class
