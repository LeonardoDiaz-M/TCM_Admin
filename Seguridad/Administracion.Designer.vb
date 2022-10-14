<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Administracion
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("proUserId")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("proNombres")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("proApellidoPaterno")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("proApellidoMaterno")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("proIdOficina")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("nombre")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("proNumeroCaja")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("proIdPuesto")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("pueDescripcion", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("proTelefono")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Email")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IsApproved")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IsLockedOut")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CreateDate")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LastLoginDate")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LastPasswordChangedDate")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LastLockoutDate")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FailedPasswordAttemptCount")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LastActivityDate")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("proValidaUbicacion")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Alta")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Baja")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Usuario")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("", -1)
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("pueId", 0)
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("pueDescripcion", 1)
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("comun")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("nombre")
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab(True)
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griAllUsers = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.tsb_BarraMenu = New System.Windows.Forms.ToolStrip()
        Me.tsb_Salir = New System.Windows.Forms.ToolStripButton()
        Me.tsb_Agregar = New System.Windows.Forms.ToolStripButton()
        Me.tsb_Exportar = New System.Windows.Forms.ToolStripButton()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.panDatosUsuario = New Infragistics.Win.Misc.UltraPanel()
        Me.txtOperacion = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtNumeroCaja = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.chkValidaUbicacion = New System.Windows.Forms.CheckBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.chkStatus = New System.Windows.Forms.CheckBox()
        Me.chkBloqueado = New System.Windows.Forms.CheckBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtUltimaActividad = New System.Windows.Forms.TextBox()
        Me.lblReviso = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtRespuestaAPregunta = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtPreguntaSecreta = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtUltimoBloqueo = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.txtFechaCreacion = New System.Windows.Forms.TextBox()
        Me.txtPaterno = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtIntentosErroneos = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtMaterno = New System.Windows.Forms.TextBox()
        Me.txtUltimoAcceso = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtUltimoCambioClave = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ucoPuesto = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.ucoOficina = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbRegresar = New System.Windows.Forms.ToolStripButton()
        Me.tsbAgregaUsuario = New System.Windows.Forms.ToolStripButton()
        Me.tsbDesbloquear = New System.Windows.Forms.ToolStripButton()
        Me.tsbBloquear = New System.Windows.Forms.ToolStripButton()
        Me.tsbGuardaUsuario = New System.Windows.Forms.ToolStripButton()
        Me.tsbModificarUsuario = New System.Windows.Forms.ToolStripButton()
        Me.tsbEliminaUsuario = New System.Windows.Forms.ToolStripButton()
        Me.erpError = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ugeExporter = New Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.tabSecurity = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.griAllUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsb_BarraMenu.SuspendLayout()
        Me.UltraTabPageControl2.SuspendLayout()
        Me.panDatosUsuario.ClientArea.SuspendLayout()
        Me.panDatosUsuario.SuspendLayout()
        CType(Me.ucoPuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ucoOficina, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.erpError, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabSecurity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabSecurity.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.griAllUsers)
        Me.UltraTabPageControl1.Controls.Add(Me.tsb_BarraMenu)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 40)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1081, 536)
        '
        'griAllUsers
        '
        UltraGridColumn1.Header.Caption = "Usuario"
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn2.Header.Caption = "Nombres"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn4.Header.Caption = "Paterno"
        UltraGridColumn4.Header.VisiblePosition = 2
        UltraGridColumn9.Header.Caption = "Materno"
        UltraGridColumn9.Header.VisiblePosition = 3
        UltraGridColumn3.Header.VisiblePosition = 4
        UltraGridColumn3.Hidden = True
        UltraGridColumn6.Header.Caption = "Oficina"
        UltraGridColumn6.Header.VisiblePosition = 6
        UltraGridColumn6.Width = 141
        UltraGridColumn5.Header.Caption = "Caja"
        UltraGridColumn5.Header.VisiblePosition = 7
        UltraGridColumn12.Header.VisiblePosition = 8
        UltraGridColumn12.Hidden = True
        UltraGridColumn13.Header.Caption = "Puesto"
        UltraGridColumn13.Header.VisiblePosition = 5
        UltraGridColumn13.Width = 166
        UltraGridColumn15.Header.Caption = "Teléfono"
        UltraGridColumn15.Header.VisiblePosition = 9
        UltraGridColumn16.Header.VisiblePosition = 10
        UltraGridColumn16.Hidden = True
        UltraGridColumn18.Header.Caption = "Aprobado"
        UltraGridColumn18.Header.VisiblePosition = 11
        UltraGridColumn18.Hidden = True
        UltraGridColumn19.Header.Caption = "Bloqueado"
        UltraGridColumn19.Header.VisiblePosition = 12
        UltraGridColumn20.Header.Caption = "F Creación"
        UltraGridColumn20.Header.VisiblePosition = 13
        UltraGridColumn21.Header.Caption = "Ultimo Acceso"
        UltraGridColumn21.Header.VisiblePosition = 14
        UltraGridColumn21.Hidden = True
        UltraGridColumn22.Header.Caption = "Ultimo Cambio Clave"
        UltraGridColumn22.Header.VisiblePosition = 15
        UltraGridColumn22.Hidden = True
        UltraGridColumn23.Header.Caption = "Ultimo Bloqueo"
        UltraGridColumn23.Header.VisiblePosition = 16
        UltraGridColumn23.Hidden = True
        UltraGridColumn24.Header.Caption = "Intentos Error Clave"
        UltraGridColumn24.Header.VisiblePosition = 17
        UltraGridColumn25.Header.Caption = "Ultima Actividad"
        UltraGridColumn25.Header.VisiblePosition = 18
        UltraGridColumn25.Hidden = True
        UltraGridColumn26.Header.Caption = "Valida Ubicacion"
        UltraGridColumn26.Header.VisiblePosition = 19
        UltraGridColumn26.Hidden = True
        UltraGridColumn7.Header.VisiblePosition = 20
        UltraGridColumn8.Header.VisiblePosition = 21
        UltraGridColumn8.Hidden = True
        UltraGridColumn11.Header.VisiblePosition = 22
        UltraGridColumn11.Hidden = True
        UltraGridColumn14.Header.VisiblePosition = 23
        UltraGridColumn14.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn4, UltraGridColumn9, UltraGridColumn3, UltraGridColumn6, UltraGridColumn5, UltraGridColumn12, UltraGridColumn13, UltraGridColumn15, UltraGridColumn16, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn7, UltraGridColumn8, UltraGridColumn11, UltraGridColumn14})
        Me.griAllUsers.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griAllUsers.DisplayLayout.GroupByBox.Hidden = True
        Me.griAllUsers.DisplayLayout.GroupByBox.Prompt = "Arraste aquí una columna para agrupar..."
        Me.griAllUsers.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        Me.griAllUsers.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.griAllUsers.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griAllUsers.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griAllUsers.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griAllUsers.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griAllUsers.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griAllUsers.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griAllUsers.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.InGroupByRows
        Me.griAllUsers.DisplayLayout.UseFixedHeaders = True
        Me.griAllUsers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griAllUsers.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griAllUsers.Location = New System.Drawing.Point(0, 43)
        Me.griAllUsers.Name = "griAllUsers"
        Me.griAllUsers.Size = New System.Drawing.Size(1081, 493)
        Me.griAllUsers.TabIndex = 24
        Me.griAllUsers.Text = "Usuarios del Sistema"
        '
        'tsb_BarraMenu
        '
        Me.tsb_BarraMenu.ImageScalingSize = New System.Drawing.Size(36, 36)
        Me.tsb_BarraMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsb_Salir, Me.tsb_Agregar, Me.tsb_Exportar})
        Me.tsb_BarraMenu.Location = New System.Drawing.Point(0, 0)
        Me.tsb_BarraMenu.Name = "tsb_BarraMenu"
        Me.tsb_BarraMenu.Size = New System.Drawing.Size(1081, 43)
        Me.tsb_BarraMenu.TabIndex = 22
        Me.tsb_BarraMenu.Text = "ToolStrip1"
        '
        'tsb_Salir
        '
        Me.tsb_Salir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsb_Salir.Image = Global.TCMAdmin.My.Resources.Resources.IconBack
        Me.tsb_Salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_Salir.Name = "tsb_Salir"
        Me.tsb_Salir.Size = New System.Drawing.Size(40, 40)
        Me.tsb_Salir.Text = "Cerrar"
        Me.tsb_Salir.ToolTipText = "Salir"
        '
        'tsb_Agregar
        '
        Me.tsb_Agregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsb_Agregar.Image = Global.TCMAdmin.My.Resources.Resources.IconNew
        Me.tsb_Agregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_Agregar.Name = "tsb_Agregar"
        Me.tsb_Agregar.Size = New System.Drawing.Size(40, 40)
        Me.tsb_Agregar.Text = "Agregar"
        Me.tsb_Agregar.ToolTipText = "Agregar"
        '
        'tsb_Exportar
        '
        Me.tsb_Exportar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsb_Exportar.Image = Global.TCMAdmin.My.Resources.Resources.Icon_File_Excel
        Me.tsb_Exportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_Exportar.Name = "tsb_Exportar"
        Me.tsb_Exportar.Size = New System.Drawing.Size(40, 40)
        Me.tsb_Exportar.Text = "ToolStripButton1"
        Me.tsb_Exportar.ToolTipText = "Exporta Excel"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.panDatosUsuario)
        Me.UltraTabPageControl2.Controls.Add(Me.ToolStrip1)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1081, 536)
        '
        'panDatosUsuario
        '
        Appearance1.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance1.BackColor2 = System.Drawing.Color.White
        Appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance1.BorderColor = System.Drawing.Color.Silver
        Me.panDatosUsuario.Appearance = Appearance1
        Me.panDatosUsuario.BorderStyle = Infragistics.Win.UIElementBorderStyle.Rounded3
        '
        'panDatosUsuario.ClientArea
        '
        Me.panDatosUsuario.ClientArea.Controls.Add(Me.txtOperacion)
        Me.panDatosUsuario.ClientArea.Controls.Add(Me.Label21)
        Me.panDatosUsuario.ClientArea.Controls.Add(Me.txtNumeroCaja)
        Me.panDatosUsuario.ClientArea.Controls.Add(Me.Label18)
        Me.panDatosUsuario.ClientArea.Controls.Add(Me.chkValidaUbicacion)
        Me.panDatosUsuario.ClientArea.Controls.Add(Me.txtTelefono)
        Me.panDatosUsuario.ClientArea.Controls.Add(Me.chkStatus)
        Me.panDatosUsuario.ClientArea.Controls.Add(Me.chkBloqueado)
        Me.panDatosUsuario.ClientArea.Controls.Add(Me.Label17)
        Me.panDatosUsuario.ClientArea.Controls.Add(Me.Label6)
        Me.panDatosUsuario.ClientArea.Controls.Add(Me.txtUser)
        Me.panDatosUsuario.ClientArea.Controls.Add(Me.txtUltimaActividad)
        Me.panDatosUsuario.ClientArea.Controls.Add(Me.lblReviso)
        Me.panDatosUsuario.ClientArea.Controls.Add(Me.Label16)
        Me.panDatosUsuario.ClientArea.Controls.Add(Me.Label10)
        Me.panDatosUsuario.ClientArea.Controls.Add(Me.Label1)
        Me.panDatosUsuario.ClientArea.Controls.Add(Me.Label9)
        Me.panDatosUsuario.ClientArea.Controls.Add(Me.Label19)
        Me.panDatosUsuario.ClientArea.Controls.Add(Me.txtRespuestaAPregunta)
        Me.panDatosUsuario.ClientArea.Controls.Add(Me.Label20)
        Me.panDatosUsuario.ClientArea.Controls.Add(Me.txtPreguntaSecreta)
        Me.panDatosUsuario.ClientArea.Controls.Add(Me.Label2)
        Me.panDatosUsuario.ClientArea.Controls.Add(Me.Label8)
        Me.panDatosUsuario.ClientArea.Controls.Add(Me.txtUltimoBloqueo)
        Me.panDatosUsuario.ClientArea.Controls.Add(Me.txtEmail)
        Me.panDatosUsuario.ClientArea.Controls.Add(Me.Label3)
        Me.panDatosUsuario.ClientArea.Controls.Add(Me.Label11)
        Me.panDatosUsuario.ClientArea.Controls.Add(Me.Label7)
        Me.panDatosUsuario.ClientArea.Controls.Add(Me.txtNombres)
        Me.panDatosUsuario.ClientArea.Controls.Add(Me.txtContraseña)
        Me.panDatosUsuario.ClientArea.Controls.Add(Me.txtFechaCreacion)
        Me.panDatosUsuario.ClientArea.Controls.Add(Me.txtPaterno)
        Me.panDatosUsuario.ClientArea.Controls.Add(Me.Label12)
        Me.panDatosUsuario.ClientArea.Controls.Add(Me.txtIntentosErroneos)
        Me.panDatosUsuario.ClientArea.Controls.Add(Me.Label14)
        Me.panDatosUsuario.ClientArea.Controls.Add(Me.txtMaterno)
        Me.panDatosUsuario.ClientArea.Controls.Add(Me.txtUltimoAcceso)
        Me.panDatosUsuario.ClientArea.Controls.Add(Me.Label15)
        Me.panDatosUsuario.ClientArea.Controls.Add(Me.txtUltimoCambioClave)
        Me.panDatosUsuario.ClientArea.Controls.Add(Me.Label4)
        Me.panDatosUsuario.ClientArea.Controls.Add(Me.Label13)
        Me.panDatosUsuario.ClientArea.Controls.Add(Me.ucoPuesto)
        Me.panDatosUsuario.ClientArea.Controls.Add(Me.ucoOficina)
        Me.panDatosUsuario.ClientArea.Controls.Add(Me.Label5)
        Me.panDatosUsuario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panDatosUsuario.Enabled = False
        Me.panDatosUsuario.Location = New System.Drawing.Point(0, 43)
        Me.panDatosUsuario.Name = "panDatosUsuario"
        Me.panDatosUsuario.Size = New System.Drawing.Size(1081, 493)
        Me.panDatosUsuario.TabIndex = 579
        '
        'txtOperacion
        '
        Me.txtOperacion.BackColor = System.Drawing.Color.White
        Me.txtOperacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOperacion.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOperacion.ForeColor = System.Drawing.Color.Red
        Me.txtOperacion.Location = New System.Drawing.Point(773, 13)
        Me.txtOperacion.MaxLength = 50
        Me.txtOperacion.Name = "txtOperacion"
        Me.txtOperacion.ReadOnly = True
        Me.txtOperacion.Size = New System.Drawing.Size(187, 22)
        Me.txtOperacion.TabIndex = 13
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(701, 17)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(62, 14)
        Me.Label21.TabIndex = 597
        Me.Label21.Text = "Operación"
        '
        'txtNumeroCaja
        '
        Me.txtNumeroCaja.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroCaja.Location = New System.Drawing.Point(174, 390)
        Me.txtNumeroCaja.MaxLength = 12
        Me.txtNumeroCaja.Name = "txtNumeroCaja"
        Me.txtNumeroCaja.ReadOnly = True
        Me.txtNumeroCaja.Size = New System.Drawing.Size(69, 22)
        Me.txtNumeroCaja.TabIndex = 12
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(72, 392)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(94, 14)
        Me.Label18.TabIndex = 595
        Me.Label18.Text = "Número de Caja"
        '
        'chkValidaUbicacion
        '
        Me.chkValidaUbicacion.AutoSize = True
        Me.chkValidaUbicacion.Location = New System.Drawing.Point(174, 187)
        Me.chkValidaUbicacion.Name = "chkValidaUbicacion"
        Me.chkValidaUbicacion.Size = New System.Drawing.Size(15, 14)
        Me.chkValidaUbicacion.TabIndex = 5
        Me.chkValidaUbicacion.UseVisualStyleBackColor = True
        '
        'txtTelefono
        '
        Me.txtTelefono.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(174, 362)
        Me.txtTelefono.MaxLength = 12
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.ReadOnly = True
        Me.txtTelefono.Size = New System.Drawing.Size(151, 22)
        Me.txtTelefono.TabIndex = 11
        '
        'chkStatus
        '
        Me.chkStatus.AutoSize = True
        Me.chkStatus.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkStatus.Enabled = False
        Me.chkStatus.Location = New System.Drawing.Point(773, 76)
        Me.chkStatus.Name = "chkStatus"
        Me.chkStatus.Size = New System.Drawing.Size(15, 14)
        Me.chkStatus.TabIndex = 14
        Me.chkStatus.UseVisualStyleBackColor = True
        '
        'chkBloqueado
        '
        Me.chkBloqueado.AutoSize = True
        Me.chkBloqueado.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkBloqueado.Enabled = False
        Me.chkBloqueado.Location = New System.Drawing.Point(773, 255)
        Me.chkBloqueado.Name = "chkBloqueado"
        Me.chkBloqueado.Size = New System.Drawing.Size(15, 14)
        Me.chkBloqueado.TabIndex = 18
        Me.chkBloqueado.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(73, 187)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(93, 14)
        Me.Label17.TabIndex = 577
        Me.Label17.Text = "Valida Ubicación"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(110, 364)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 14)
        Me.Label6.TabIndex = 567
        Me.Label6.Text = "Teléfono"
        '
        'txtUser
        '
        Me.txtUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUser.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.ForeColor = System.Drawing.Color.Red
        Me.txtUser.Location = New System.Drawing.Point(174, 37)
        Me.txtUser.MaxLength = 50
        Me.txtUser.Name = "txtUser"
        Me.txtUser.ReadOnly = True
        Me.txtUser.Size = New System.Drawing.Size(187, 22)
        Me.txtUser.TabIndex = 0
        '
        'txtUltimaActividad
        '
        Me.txtUltimaActividad.BackColor = System.Drawing.Color.White
        Me.txtUltimaActividad.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUltimaActividad.Location = New System.Drawing.Point(773, 329)
        Me.txtUltimaActividad.MaxLength = 50
        Me.txtUltimaActividad.Name = "txtUltimaActividad"
        Me.txtUltimaActividad.ReadOnly = True
        Me.txtUltimaActividad.Size = New System.Drawing.Size(187, 22)
        Me.txtUltimaActividad.TabIndex = 21
        '
        'lblReviso
        '
        Me.lblReviso.AutoSize = True
        Me.lblReviso.BackColor = System.Drawing.Color.Transparent
        Me.lblReviso.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReviso.Location = New System.Drawing.Point(119, 40)
        Me.lblReviso.Name = "lblReviso"
        Me.lblReviso.Size = New System.Drawing.Size(47, 14)
        Me.lblReviso.TabIndex = 555
        Me.lblReviso.Text = "User ID"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(676, 281)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(89, 14)
        Me.Label16.TabIndex = 588
        Me.Label16.Text = "Último Bloqueo"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(103, 157)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 14)
        Me.Label10.TabIndex = 576
        Me.Label10.Text = "Respuesta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(92, 255)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 14)
        Me.Label1.TabIndex = 557
        Me.Label1.Text = "Nombres (s)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(63, 127)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(103, 14)
        Me.Label9.TabIndex = 575
        Me.Label9.Text = "Pregunta Secreta"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(602, 307)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(163, 14)
        Me.Label19.TabIndex = 589
        Me.Label19.Text = "Cant. Intentos errones clave"
        '
        'txtRespuestaAPregunta
        '
        Me.txtRespuestaAPregunta.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRespuestaAPregunta.Location = New System.Drawing.Point(174, 154)
        Me.txtRespuestaAPregunta.MaxLength = 50
        Me.txtRespuestaAPregunta.Name = "txtRespuestaAPregunta"
        Me.txtRespuestaAPregunta.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtRespuestaAPregunta.ReadOnly = True
        Me.txtRespuestaAPregunta.Size = New System.Drawing.Size(281, 22)
        Me.txtRespuestaAPregunta.TabIndex = 4
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(671, 333)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(94, 14)
        Me.Label20.TabIndex = 590
        Me.Label20.Text = "Ultimo Actividad"
        '
        'txtPreguntaSecreta
        '
        Me.txtPreguntaSecreta.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPreguntaSecreta.Location = New System.Drawing.Point(174, 123)
        Me.txtPreguntaSecreta.MaxLength = 50
        Me.txtPreguntaSecreta.Name = "txtPreguntaSecreta"
        Me.txtPreguntaSecreta.ReadOnly = True
        Me.txtPreguntaSecreta.Size = New System.Drawing.Size(281, 22)
        Me.txtPreguntaSecreta.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(116, 278)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 14)
        Me.Label2.TabIndex = 558
        Me.Label2.Text = "Paterno"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(132, 97)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 14)
        Me.Label8.TabIndex = 572
        Me.Label8.Text = "email"
        '
        'txtUltimoBloqueo
        '
        Me.txtUltimoBloqueo.BackColor = System.Drawing.Color.White
        Me.txtUltimoBloqueo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUltimoBloqueo.Location = New System.Drawing.Point(773, 276)
        Me.txtUltimoBloqueo.MaxLength = 50
        Me.txtUltimoBloqueo.Name = "txtUltimoBloqueo"
        Me.txtUltimoBloqueo.ReadOnly = True
        Me.txtUltimoBloqueo.Size = New System.Drawing.Size(187, 22)
        Me.txtUltimoBloqueo.TabIndex = 19
        '
        'txtEmail
        '
        Me.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtEmail.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(174, 92)
        Me.txtEmail.MaxLength = 50
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(187, 22)
        Me.txtEmail.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(347, 280)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 14)
        Me.Label3.TabIndex = 559
        Me.Label3.Text = "Materno"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(705, 76)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 14)
        Me.Label11.TabIndex = 578
        Me.Label11.Text = "Aprobado"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(98, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 14)
        Me.Label7.TabIndex = 570
        Me.Label7.Text = "Contraseña"
        '
        'txtNombres
        '
        Me.txtNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombres.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombres.Location = New System.Drawing.Point(174, 248)
        Me.txtNombres.MaxLength = 50
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.ReadOnly = True
        Me.txtNombres.Size = New System.Drawing.Size(151, 22)
        Me.txtNombres.TabIndex = 6
        '
        'txtContraseña
        '
        Me.txtContraseña.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContraseña.Location = New System.Drawing.Point(174, 65)
        Me.txtContraseña.MaxLength = 50
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseña.ReadOnly = True
        Me.txtContraseña.Size = New System.Drawing.Size(187, 22)
        Me.txtContraseña.TabIndex = 1
        '
        'txtFechaCreacion
        '
        Me.txtFechaCreacion.BackColor = System.Drawing.Color.White
        Me.txtFechaCreacion.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaCreacion.Location = New System.Drawing.Point(773, 97)
        Me.txtFechaCreacion.MaxLength = 50
        Me.txtFechaCreacion.Name = "txtFechaCreacion"
        Me.txtFechaCreacion.ReadOnly = True
        Me.txtFechaCreacion.Size = New System.Drawing.Size(187, 22)
        Me.txtFechaCreacion.TabIndex = 15
        '
        'txtPaterno
        '
        Me.txtPaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPaterno.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaterno.Location = New System.Drawing.Point(174, 276)
        Me.txtPaterno.MaxLength = 30
        Me.txtPaterno.Name = "txtPaterno"
        Me.txtPaterno.ReadOnly = True
        Me.txtPaterno.Size = New System.Drawing.Size(151, 22)
        Me.txtPaterno.TabIndex = 7
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(631, 154)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(134, 14)
        Me.Label12.TabIndex = 587
        Me.Label12.Text = "Ultimo Cambio de Clave"
        '
        'txtIntentosErroneos
        '
        Me.txtIntentosErroneos.BackColor = System.Drawing.Color.White
        Me.txtIntentosErroneos.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIntentosErroneos.Location = New System.Drawing.Point(773, 302)
        Me.txtIntentosErroneos.MaxLength = 50
        Me.txtIntentosErroneos.Name = "txtIntentosErroneos"
        Me.txtIntentosErroneos.ReadOnly = True
        Me.txtIntentosErroneos.Size = New System.Drawing.Size(187, 22)
        Me.txtIntentosErroneos.TabIndex = 20
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(676, 102)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(89, 14)
        Me.Label14.TabIndex = 583
        Me.Label14.Text = "Fecha Creación"
        '
        'txtMaterno
        '
        Me.txtMaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMaterno.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaterno.Location = New System.Drawing.Point(401, 276)
        Me.txtMaterno.MaxLength = 30
        Me.txtMaterno.Name = "txtMaterno"
        Me.txtMaterno.ReadOnly = True
        Me.txtMaterno.Size = New System.Drawing.Size(151, 22)
        Me.txtMaterno.TabIndex = 8
        '
        'txtUltimoAcceso
        '
        Me.txtUltimoAcceso.BackColor = System.Drawing.Color.White
        Me.txtUltimoAcceso.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUltimoAcceso.Location = New System.Drawing.Point(773, 123)
        Me.txtUltimoAcceso.MaxLength = 50
        Me.txtUltimoAcceso.Name = "txtUltimoAcceso"
        Me.txtUltimoAcceso.ReadOnly = True
        Me.txtUltimoAcceso.Size = New System.Drawing.Size(245, 22)
        Me.txtUltimoAcceso.TabIndex = 16
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(701, 255)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(64, 14)
        Me.Label15.TabIndex = 581
        Me.Label15.Text = "Bloqueado"
        '
        'txtUltimoCambioClave
        '
        Me.txtUltimoCambioClave.BackColor = System.Drawing.Color.White
        Me.txtUltimoCambioClave.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUltimoCambioClave.Location = New System.Drawing.Point(773, 150)
        Me.txtUltimoCambioClave.MaxLength = 50
        Me.txtUltimoCambioClave.Name = "txtUltimoCambioClave"
        Me.txtUltimoCambioClave.ReadOnly = True
        Me.txtUltimoCambioClave.Size = New System.Drawing.Size(245, 22)
        Me.txtUltimoCambioClave.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(121, 308)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 14)
        Me.Label4.TabIndex = 563
        Me.Label4.Text = "Puesto"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(681, 128)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 14)
        Me.Label13.TabIndex = 586
        Me.Label13.Text = "Último Acceso"
        '
        'ucoPuesto
        '
        Appearance2.FontData.BoldAsString = "True"
        Me.ucoPuesto.Appearance = Appearance2
        Me.ucoPuesto.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.ucoPuesto.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains
        UltraGridColumn27.Header.Caption = "ID"
        UltraGridColumn27.Header.VisiblePosition = 0
        UltraGridColumn27.Hidden = True
        UltraGridColumn28.Header.Caption = "Puesto"
        UltraGridColumn28.Header.VisiblePosition = 1
        UltraGridColumn28.Width = 378
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn27, UltraGridColumn28})
        Me.ucoPuesto.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.ucoPuesto.DropDownResizeHandleStyle = Infragistics.Win.DropDownResizeHandleStyle.VerticalResize
        Me.ucoPuesto.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ucoPuesto.Location = New System.Drawing.Point(174, 303)
        Me.ucoPuesto.MaxDropDownItems = 30
        Me.ucoPuesto.Name = "ucoPuesto"
        Me.ucoPuesto.NullText = "Seleccione..."
        Me.ucoPuesto.ReadOnly = True
        Me.ucoPuesto.Size = New System.Drawing.Size(378, 24)
        Me.ucoPuesto.TabIndex = 9
        '
        'ucoOficina
        '
        Appearance3.FontData.BoldAsString = "True"
        Me.ucoOficina.Appearance = Appearance3
        Me.ucoOficina.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.ucoOficina.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains
        UltraGridColumn29.Header.VisiblePosition = 0
        UltraGridColumn29.Hidden = True
        UltraGridColumn30.Header.VisiblePosition = 1
        UltraGridColumn30.Width = 378
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn29, UltraGridColumn30})
        Me.ucoOficina.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.ucoOficina.DisplayMember = "nombre"
        Me.ucoOficina.DropDownResizeHandleStyle = Infragistics.Win.DropDownResizeHandleStyle.VerticalResize
        Me.ucoOficina.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ucoOficina.Location = New System.Drawing.Point(174, 333)
        Me.ucoOficina.MaxDropDownItems = 30
        Me.ucoOficina.Name = "ucoOficina"
        Me.ucoOficina.NullText = "Seleccione..."
        Me.ucoOficina.ReadOnly = True
        Me.ucoOficina.Size = New System.Drawing.Size(378, 24)
        Me.ucoOficina.TabIndex = 10
        Me.ucoOficina.ValueMember = "comun"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(123, 337)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 14)
        Me.Label5.TabIndex = 565
        Me.Label5.Text = "Oficina"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(36, 36)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbRegresar, Me.tsbAgregaUsuario, Me.tsbDesbloquear, Me.tsbBloquear, Me.tsbGuardaUsuario, Me.tsbModificarUsuario, Me.tsbEliminaUsuario})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1081, 43)
        Me.ToolStrip1.TabIndex = 578
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbRegresar
        '
        Me.tsbRegresar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbRegresar.Image = Global.TCMAdmin.My.Resources.Resources.IconBack
        Me.tsbRegresar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRegresar.Name = "tsbRegresar"
        Me.tsbRegresar.Size = New System.Drawing.Size(40, 40)
        Me.tsbRegresar.Text = "Cerrar"
        Me.tsbRegresar.ToolTipText = "Salir"
        '
        'tsbAgregaUsuario
        '
        Me.tsbAgregaUsuario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbAgregaUsuario.Image = Global.TCMAdmin.My.Resources.Resources.IconNew
        Me.tsbAgregaUsuario.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAgregaUsuario.Name = "tsbAgregaUsuario"
        Me.tsbAgregaUsuario.Size = New System.Drawing.Size(40, 40)
        Me.tsbAgregaUsuario.Text = "Agregar"
        Me.tsbAgregaUsuario.ToolTipText = "Agregar"
        '
        'tsbDesbloquear
        '
        Me.tsbDesbloquear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbDesbloquear.Image = Global.TCMAdmin.My.Resources.Resources.Desbloquear
        Me.tsbDesbloquear.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbDesbloquear.Name = "tsbDesbloquear"
        Me.tsbDesbloquear.Size = New System.Drawing.Size(40, 40)
        Me.tsbDesbloquear.Text = "ToolStripButton2"
        Me.tsbDesbloquear.ToolTipText = "Desbloquear Usuario"
        Me.tsbDesbloquear.Visible = False
        '
        'tsbBloquear
        '
        Me.tsbBloquear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbBloquear.Image = Global.TCMAdmin.My.Resources.Resources.Bloquear
        Me.tsbBloquear.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbBloquear.Name = "tsbBloquear"
        Me.tsbBloquear.Size = New System.Drawing.Size(40, 40)
        Me.tsbBloquear.Text = "ToolStripButton1"
        Me.tsbBloquear.ToolTipText = "Bloquea Usuario"
        Me.tsbBloquear.Visible = False
        '
        'tsbGuardaUsuario
        '
        Me.tsbGuardaUsuario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbGuardaUsuario.Image = Global.TCMAdmin.My.Resources.Resources.IconSave
        Me.tsbGuardaUsuario.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGuardaUsuario.Name = "tsbGuardaUsuario"
        Me.tsbGuardaUsuario.Size = New System.Drawing.Size(40, 40)
        Me.tsbGuardaUsuario.Text = "Guardar"
        Me.tsbGuardaUsuario.Visible = False
        '
        'tsbModificarUsuario
        '
        Me.tsbModificarUsuario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbModificarUsuario.Image = Global.TCMAdmin.My.Resources.Resources.IconEdit
        Me.tsbModificarUsuario.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbModificarUsuario.Name = "tsbModificarUsuario"
        Me.tsbModificarUsuario.Size = New System.Drawing.Size(40, 40)
        Me.tsbModificarUsuario.Text = "ToolStripButton1"
        Me.tsbModificarUsuario.ToolTipText = "Modificar"
        Me.tsbModificarUsuario.Visible = False
        '
        'tsbEliminaUsuario
        '
        Me.tsbEliminaUsuario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbEliminaUsuario.Image = Global.TCMAdmin.My.Resources.Resources.Eliminar1
        Me.tsbEliminaUsuario.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEliminaUsuario.Name = "tsbEliminaUsuario"
        Me.tsbEliminaUsuario.Size = New System.Drawing.Size(40, 40)
        Me.tsbEliminaUsuario.Text = "ToolStripButton1"
        Me.tsbEliminaUsuario.ToolTipText = "Eliminar Usuario"
        Me.tsbEliminaUsuario.Visible = False
        '
        'erpError
        '
        Me.erpError.ContainerControl = Me
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1081, 536)
        '
        'tabSecurity
        '
        Me.tabSecurity.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.tabSecurity.Controls.Add(Me.UltraTabPageControl1)
        Me.tabSecurity.Controls.Add(Me.UltraTabPageControl2)
        Me.tabSecurity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabSecurity.Location = New System.Drawing.Point(0, 0)
        Me.tabSecurity.Name = "tabSecurity"
        Me.tabSecurity.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.tabSecurity.Size = New System.Drawing.Size(1083, 577)
        Me.tabSecurity.SpaceAfterTabs = New Infragistics.Win.DefaultableInteger(50)
        Me.tabSecurity.TabIndex = 0
        Me.tabSecurity.TabLayoutStyle = Infragistics.Win.UltraWinTabs.TabLayoutStyle.SingleRowSizeToFit
        Me.tabSecurity.TabPadding = New System.Drawing.Size(1, 10)
        UltraTab1.Key = "tabUsuarios"
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Usuarios"
        UltraTab2.Key = "tabALtaUsuario"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Alta Usuarios"
        Me.tabSecurity.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.tabSecurity.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'Administracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1083, 577)
        Me.Controls.Add(Me.tabSecurity)
        Me.KeyPreview = True
        Me.Name = "Administracion"
        Me.Text = "Administracion"
        Me.UltraTabPageControl1.ResumeLayout(False)
        Me.UltraTabPageControl1.PerformLayout()
        CType(Me.griAllUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsb_BarraMenu.ResumeLayout(False)
        Me.tsb_BarraMenu.PerformLayout()
        Me.UltraTabPageControl2.ResumeLayout(False)
        Me.UltraTabPageControl2.PerformLayout()
        Me.panDatosUsuario.ClientArea.ResumeLayout(False)
        Me.panDatosUsuario.ClientArea.PerformLayout()
        Me.panDatosUsuario.ResumeLayout(False)
        CType(Me.ucoPuesto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ucoOficina, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.erpError, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabSecurity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabSecurity.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents erpError As System.Windows.Forms.ErrorProvider
    Friend WithEvents ugeExporter As Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter
    Friend WithEvents tabSecurity As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griAllUsers As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents tsb_BarraMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents tsb_Agregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsb_Exportar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsb_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents chkBloqueado As System.Windows.Forms.CheckBox
    Friend WithEvents chkStatus As System.Windows.Forms.CheckBox
    Friend WithEvents txtUltimaActividad As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtUltimoBloqueo As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents panDatosUsuario As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents lblReviso As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtRespuestaAPregunta As System.Windows.Forms.TextBox
    Friend WithEvents txtNombres As System.Windows.Forms.TextBox
    Friend WithEvents txtPreguntaSecreta As System.Windows.Forms.TextBox
    Friend WithEvents txtPaterno As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtMaterno As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ucoPuesto As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents txtContraseña As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ucoOficina As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbAgregaUsuario As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbDesbloquear As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbBloquear As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbGuardaUsuario As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbModificarUsuario As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbEliminaUsuario As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbRegresar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtIntentosErroneos As System.Windows.Forms.TextBox
    Friend WithEvents txtUltimoCambioClave As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtUltimoAcceso As System.Windows.Forms.TextBox
    Friend WithEvents txtFechaCreacion As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents chkValidaUbicacion As System.Windows.Forms.CheckBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtNumeroCaja As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtOperacion As TextBox
    Friend WithEvents Label21 As Label
End Class
