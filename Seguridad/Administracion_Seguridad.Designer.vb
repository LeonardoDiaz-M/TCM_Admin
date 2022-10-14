<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Administracion_Seguridad
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Check")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("proUserId")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("proNombres")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("nombre")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("pueDescripcion")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab39 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab40 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraTabPageControl34 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griAllUsers = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraGridFilterUIProvider1 = New Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider(Me.components)
        Me.lstUsuariosEnRol = New System.Windows.Forms.ListBox()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.lstTodosRoles = New System.Windows.Forms.ListBox()
        Me.UltraPanel1 = New Infragistics.Win.Misc.UltraPanel()
        Me.chkMarcaTodos = New System.Windows.Forms.CheckBox()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.tsbAgregaRol = New System.Windows.Forms.Button()
        Me.txtRol = New System.Windows.Forms.TextBox()
        Me.tosUsuariosEnRoles = New System.Windows.Forms.ToolStrip()
        Me.tsb_Salir = New System.Windows.Forms.ToolStripButton()
        Me.tsbQuitarUsuario = New System.Windows.Forms.ToolStripButton()
        Me.tsbOtorgaPermisos = New System.Windows.Forms.ToolStripButton()
        Me.utcAdministraSeguridad = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.txtNombreUsuario = New Infragistics.Win.Misc.UltraGroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.butRolesUsuario = New System.Windows.Forms.Button()
        Me.txtRolesUsuario = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tosPermisosRoles = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.tsbQuitarRol = New System.Windows.Forms.ToolStripButton()
        Me.tsbAgregarRol = New System.Windows.Forms.ToolStripButton()
        Me.chkTodosRolesSeleccionados = New System.Windows.Forms.CheckBox()
        Me.chkTodosRoles = New System.Windows.Forms.CheckBox()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.lstRoles = New System.Windows.Forms.ListBox()
        Me.lstRolesPorUsuario = New System.Windows.Forms.ListBox()
        Me.AdministraSeguridad_Fill_Panel = New System.Windows.Forms.Panel()
        Me.tabSecurity = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.erpError = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.UltraTabPageControl34.SuspendLayout()
        CType(Me.griAllUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraPanel1.ClientArea.SuspendLayout()
        Me.UltraPanel1.SuspendLayout()
        Me.tosUsuariosEnRoles.SuspendLayout()
        Me.utcAdministraSeguridad.SuspendLayout()
        CType(Me.txtNombreUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.txtNombreUsuario.SuspendLayout()
        Me.tosPermisosRoles.SuspendLayout()
        Me.AdministraSeguridad_Fill_Panel.SuspendLayout()
        CType(Me.tabSecurity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabSecurity.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erpError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraTabPageControl34
        '
        Me.UltraTabPageControl34.Controls.Add(Me.griAllUsers)
        Me.UltraTabPageControl34.Controls.Add(Me.lstUsuariosEnRol)
        Me.UltraTabPageControl34.Controls.Add(Me.UltraLabel3)
        Me.UltraTabPageControl34.Controls.Add(Me.lstTodosRoles)
        Me.UltraTabPageControl34.Controls.Add(Me.UltraPanel1)
        Me.UltraTabPageControl34.Location = New System.Drawing.Point(1, 36)
        Me.UltraTabPageControl34.Name = "UltraTabPageControl34"
        Me.UltraTabPageControl34.Size = New System.Drawing.Size(1081, 518)
        '
        'griAllUsers
        '
        UltraGridColumn4.Header.VisiblePosition = 0
        UltraGridColumn4.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn4.Width = 83
        UltraGridColumn7.Header.Caption = "Usuario"
        UltraGridColumn7.Header.VisiblePosition = 1
        UltraGridColumn7.Width = 164
        UltraGridColumn8.Header.Caption = "Nombre"
        UltraGridColumn8.Header.VisiblePosition = 2
        UltraGridColumn8.Width = 198
        UltraGridColumn9.Header.Caption = "Oficina"
        UltraGridColumn9.Header.VisiblePosition = 3
        UltraGridColumn9.Width = 174
        UltraGridColumn10.Header.Caption = "Puesto"
        UltraGridColumn10.Header.VisiblePosition = 4
        UltraGridColumn10.Width = 177
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn4, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10})
        Me.griAllUsers.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Appearance1.TextHAlignAsString = "Center"
        Me.griAllUsers.DisplayLayout.CaptionAppearance = Appearance1
        Me.griAllUsers.DisplayLayout.GroupByBox.Hidden = True
        Me.griAllUsers.DisplayLayout.GroupByBox.Prompt = "Arraste aquí una columna para agrupar..."
        Me.griAllUsers.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        Me.griAllUsers.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.griAllUsers.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griAllUsers.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griAllUsers.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griAllUsers.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griAllUsers.DisplayLayout.Override.FilterUIProvider = Me.UltraGridFilterUIProvider1
        Me.griAllUsers.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griAllUsers.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griAllUsers.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.InGroupByRows
        Me.griAllUsers.DisplayLayout.UseFixedHeaders = True
        Me.griAllUsers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griAllUsers.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griAllUsers.Location = New System.Drawing.Point(340, 74)
        Me.griAllUsers.Name = "griAllUsers"
        Me.griAllUsers.Size = New System.Drawing.Size(741, 444)
        Me.griAllUsers.TabIndex = 195
        '
        'lstUsuariosEnRol
        '
        Me.lstUsuariosEnRol.BackColor = System.Drawing.Color.White
        Me.lstUsuariosEnRol.Dock = System.Windows.Forms.DockStyle.Left
        Me.lstUsuariosEnRol.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstUsuariosEnRol.ForeColor = System.Drawing.Color.Black
        Me.lstUsuariosEnRol.FormattingEnabled = True
        Me.lstUsuariosEnRol.Location = New System.Drawing.Point(339, 74)
        Me.lstUsuariosEnRol.Name = "lstUsuariosEnRol"
        Me.lstUsuariosEnRol.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstUsuariosEnRol.Size = New System.Drawing.Size(1, 444)
        Me.lstUsuariosEnRol.TabIndex = 192
        '
        'UltraLabel3
        '
        Appearance2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Appearance2.BackColor2 = System.Drawing.SystemColors.ControlLightLight
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance2.TextHAlignAsString = "Center"
        Me.UltraLabel3.Appearance = Appearance2
        Me.UltraLabel3.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Rounded1
        Me.UltraLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(3, 49)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(337, 23)
        Me.UltraLabel3.TabIndex = 191
        Me.UltraLabel3.Text = "Roles "
        '
        'lstTodosRoles
        '
        Me.lstTodosRoles.BackColor = System.Drawing.Color.White
        Me.lstTodosRoles.Dock = System.Windows.Forms.DockStyle.Left
        Me.lstTodosRoles.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstTodosRoles.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lstTodosRoles.FormattingEnabled = True
        Me.lstTodosRoles.ItemHeight = 14
        Me.lstTodosRoles.Location = New System.Drawing.Point(0, 74)
        Me.lstTodosRoles.Name = "lstTodosRoles"
        Me.lstTodosRoles.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstTodosRoles.Size = New System.Drawing.Size(339, 444)
        Me.lstTodosRoles.TabIndex = 190
        '
        'UltraPanel1
        '
        '
        'UltraPanel1.ClientArea
        '
        Me.UltraPanel1.ClientArea.Controls.Add(Me.chkMarcaTodos)
        Me.UltraPanel1.ClientArea.Controls.Add(Me.UltraLabel5)
        Me.UltraPanel1.ClientArea.Controls.Add(Me.tsbAgregaRol)
        Me.UltraPanel1.ClientArea.Controls.Add(Me.txtRol)
        Me.UltraPanel1.ClientArea.Controls.Add(Me.tosUsuariosEnRoles)
        Me.UltraPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraPanel1.Location = New System.Drawing.Point(0, 0)
        Me.UltraPanel1.Name = "UltraPanel1"
        Me.UltraPanel1.Size = New System.Drawing.Size(1081, 74)
        Me.UltraPanel1.TabIndex = 189
        '
        'chkMarcaTodos
        '
        Me.chkMarcaTodos.AutoSize = True
        Me.chkMarcaTodos.BackColor = System.Drawing.Color.Transparent
        Me.chkMarcaTodos.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkMarcaTodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMarcaTodos.ForeColor = System.Drawing.Color.Red
        Me.chkMarcaTodos.Location = New System.Drawing.Point(348, 52)
        Me.chkMarcaTodos.Name = "chkMarcaTodos"
        Me.chkMarcaTodos.Size = New System.Drawing.Size(56, 17)
        Me.chkMarcaTodos.TabIndex = 547
        Me.chkMarcaTodos.Text = "Todos"
        Me.chkMarcaTodos.UseVisualStyleBackColor = False
        '
        'UltraLabel5
        '
        Appearance3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Appearance3.BackColor2 = System.Drawing.SystemColors.ControlLightLight
        Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance3.TextHAlignAsString = "Center"
        Me.UltraLabel5.Appearance = Appearance3
        Me.UltraLabel5.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Rounded1
        Me.UltraLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel5.Location = New System.Drawing.Point(340, 49)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(741, 23)
        Me.UltraLabel5.TabIndex = 194
        Me.UltraLabel5.Text = "Usuarios en Rol"
        '
        'tsbAgregaRol
        '
        Me.tsbAgregaRol.Location = New System.Drawing.Point(909, 9)
        Me.tsbAgregaRol.Name = "tsbAgregaRol"
        Me.tsbAgregaRol.Size = New System.Drawing.Size(75, 23)
        Me.tsbAgregaRol.TabIndex = 187
        Me.tsbAgregaRol.Text = "Agrega Rol"
        Me.tsbAgregaRol.UseVisualStyleBackColor = True
        '
        'txtRol
        '
        Me.txtRol.Location = New System.Drawing.Point(693, 11)
        Me.txtRol.Name = "txtRol"
        Me.txtRol.Size = New System.Drawing.Size(198, 20)
        Me.txtRol.TabIndex = 188
        '
        'tosUsuariosEnRoles
        '
        Me.tosUsuariosEnRoles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tosUsuariosEnRoles.ImageScalingSize = New System.Drawing.Size(36, 36)
        Me.tosUsuariosEnRoles.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsb_Salir, Me.tsbQuitarUsuario, Me.tsbOtorgaPermisos})
        Me.tosUsuariosEnRoles.Location = New System.Drawing.Point(0, 0)
        Me.tosUsuariosEnRoles.Name = "tosUsuariosEnRoles"
        Me.tosUsuariosEnRoles.Size = New System.Drawing.Size(1081, 43)
        Me.tosUsuariosEnRoles.TabIndex = 184
        Me.tosUsuariosEnRoles.Text = "ToolStrip3"
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
        'tsbQuitarUsuario
        '
        Me.tsbQuitarUsuario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbQuitarUsuario.Image = Global.TCMAdmin.My.Resources.Resources.Quitar1
        Me.tsbQuitarUsuario.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbQuitarUsuario.Name = "tsbQuitarUsuario"
        Me.tsbQuitarUsuario.Size = New System.Drawing.Size(40, 40)
        Me.tsbQuitarUsuario.Text = "ToolStripButton1"
        Me.tsbQuitarUsuario.ToolTipText = "Quitar Permiso"
        '
        'tsbOtorgaPermisos
        '
        Me.tsbOtorgaPermisos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbOtorgaPermisos.Image = Global.TCMAdmin.My.Resources.Resources.Agrega
        Me.tsbOtorgaPermisos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbOtorgaPermisos.Name = "tsbOtorgaPermisos"
        Me.tsbOtorgaPermisos.Size = New System.Drawing.Size(40, 40)
        Me.tsbOtorgaPermisos.Text = "ToolStripButton2"
        Me.tsbOtorgaPermisos.ToolTipText = "Agregar Permiso"
        '
        'utcAdministraSeguridad
        '
        Me.utcAdministraSeguridad.Controls.Add(Me.txtNombreUsuario)
        Me.utcAdministraSeguridad.Controls.Add(Me.butRolesUsuario)
        Me.utcAdministraSeguridad.Controls.Add(Me.txtRolesUsuario)
        Me.utcAdministraSeguridad.Controls.Add(Me.Label11)
        Me.utcAdministraSeguridad.Controls.Add(Me.tosPermisosRoles)
        Me.utcAdministraSeguridad.Controls.Add(Me.chkTodosRolesSeleccionados)
        Me.utcAdministraSeguridad.Controls.Add(Me.chkTodosRoles)
        Me.utcAdministraSeguridad.Controls.Add(Me.UltraLabel2)
        Me.utcAdministraSeguridad.Controls.Add(Me.UltraLabel1)
        Me.utcAdministraSeguridad.Controls.Add(Me.lstRoles)
        Me.utcAdministraSeguridad.Controls.Add(Me.lstRolesPorUsuario)
        Me.utcAdministraSeguridad.Location = New System.Drawing.Point(-10000, -10000)
        Me.utcAdministraSeguridad.Name = "utcAdministraSeguridad"
        Me.utcAdministraSeguridad.Size = New System.Drawing.Size(1081, 518)
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.Controls.Add(Me.Label1)
        Me.txtNombreUsuario.Controls.Add(Me.txtNombres)
        Me.txtNombreUsuario.Location = New System.Drawing.Point(77, 44)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.Size = New System.Drawing.Size(957, 56)
        Me.txtNombreUsuario.TabIndex = 184
        Me.txtNombreUsuario.Text = "Usuario"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(95, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 14)
        Me.Label1.TabIndex = 559
        Me.Label1.Text = "Nombres (s)"
        '
        'txtNombres
        '
        Me.txtNombres.BackColor = System.Drawing.Color.White
        Me.txtNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombres.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombres.Location = New System.Drawing.Point(177, 18)
        Me.txtNombres.MaxLength = 50
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.ReadOnly = True
        Me.txtNombres.Size = New System.Drawing.Size(366, 22)
        Me.txtNombres.TabIndex = 558
        '
        'butRolesUsuario
        '
        Me.butRolesUsuario.Location = New System.Drawing.Point(407, 15)
        Me.butRolesUsuario.Name = "butRolesUsuario"
        Me.butRolesUsuario.Size = New System.Drawing.Size(80, 23)
        Me.butRolesUsuario.TabIndex = 179
        Me.butRolesUsuario.Text = "Buscar"
        Me.butRolesUsuario.UseVisualStyleBackColor = True
        '
        'txtRolesUsuario
        '
        Me.txtRolesUsuario.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRolesUsuario.Location = New System.Drawing.Point(255, 15)
        Me.txtRolesUsuario.Name = "txtRolesUsuario"
        Me.txtRolesUsuario.Size = New System.Drawing.Size(151, 23)
        Me.txtRolesUsuario.TabIndex = 175
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(199, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 14)
        Me.Label11.TabIndex = 174
        Me.Label11.Text = "Usuario"
        '
        'tosPermisosRoles
        '
        Me.tosPermisosRoles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tosPermisosRoles.Enabled = False
        Me.tosPermisosRoles.ImageScalingSize = New System.Drawing.Size(36, 36)
        Me.tosPermisosRoles.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.tsbQuitarRol, Me.tsbAgregarRol})
        Me.tosPermisosRoles.Location = New System.Drawing.Point(0, 0)
        Me.tosPermisosRoles.Name = "tosPermisosRoles"
        Me.tosPermisosRoles.Size = New System.Drawing.Size(1081, 43)
        Me.tosPermisosRoles.TabIndex = 177
        Me.tosPermisosRoles.Text = "ToolStrip3"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.TCMAdmin.My.Resources.Resources.IconBack
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(40, 40)
        Me.ToolStripButton1.Text = "Cerrar"
        Me.ToolStripButton1.ToolTipText = "Salir"
        '
        'tsbQuitarRol
        '
        Me.tsbQuitarRol.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbQuitarRol.Image = Global.TCMAdmin.My.Resources.Resources.Quitar
        Me.tsbQuitarRol.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbQuitarRol.Name = "tsbQuitarRol"
        Me.tsbQuitarRol.Size = New System.Drawing.Size(40, 40)
        Me.tsbQuitarRol.Text = "ToolStripButton1"
        Me.tsbQuitarRol.ToolTipText = "Quitar Permiso"
        '
        'tsbAgregarRol
        '
        Me.tsbAgregarRol.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbAgregarRol.Image = Global.TCMAdmin.My.Resources.Resources.Agrega
        Me.tsbAgregarRol.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAgregarRol.Name = "tsbAgregarRol"
        Me.tsbAgregarRol.Size = New System.Drawing.Size(40, 40)
        Me.tsbAgregarRol.Text = "ToolStripButton2"
        Me.tsbAgregarRol.ToolTipText = "Agregar Permiso"
        '
        'chkTodosRolesSeleccionados
        '
        Me.chkTodosRolesSeleccionados.AutoSize = True
        Me.chkTodosRolesSeleccionados.BackColor = System.Drawing.Color.Transparent
        Me.chkTodosRolesSeleccionados.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTodosRolesSeleccionados.Location = New System.Drawing.Point(254, 109)
        Me.chkTodosRolesSeleccionados.Name = "chkTodosRolesSeleccionados"
        Me.chkTodosRolesSeleccionados.Size = New System.Drawing.Size(54, 17)
        Me.chkTodosRolesSeleccionados.TabIndex = 183
        Me.chkTodosRolesSeleccionados.Text = "Todos"
        Me.chkTodosRolesSeleccionados.UseVisualStyleBackColor = False
        '
        'chkTodosRoles
        '
        Me.chkTodosRoles.AutoSize = True
        Me.chkTodosRoles.BackColor = System.Drawing.Color.Transparent
        Me.chkTodosRoles.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTodosRoles.Location = New System.Drawing.Point(731, 110)
        Me.chkTodosRoles.Name = "chkTodosRoles"
        Me.chkTodosRoles.Size = New System.Drawing.Size(54, 17)
        Me.chkTodosRoles.TabIndex = 182
        Me.chkTodosRoles.Text = "Todos"
        Me.chkTodosRoles.UseVisualStyleBackColor = False
        '
        'UltraLabel2
        '
        Appearance4.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Appearance4.BackColor2 = System.Drawing.SystemColors.ControlLightLight
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance4.TextHAlignAsString = "Left"
        Me.UltraLabel2.Appearance = Appearance4
        Me.UltraLabel2.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Rounded1
        Me.UltraLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(77, 106)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(402, 23)
        Me.UltraLabel2.TabIndex = 181
        Me.UltraLabel2.Text = "Roles Asignados al Usuario"
        '
        'UltraLabel1
        '
        Appearance5.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Appearance5.BackColor2 = System.Drawing.SystemColors.ControlLightLight
        Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance5.TextHAlignAsString = "Left"
        Me.UltraLabel1.Appearance = Appearance5
        Me.UltraLabel1.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Rounded1
        Me.UltraLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(632, 107)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(402, 23)
        Me.UltraLabel1.TabIndex = 180
        Me.UltraLabel1.Text = "Roles Actuales"
        '
        'lstRoles
        '
        Me.lstRoles.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstRoles.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lstRoles.FormattingEnabled = True
        Me.lstRoles.ItemHeight = 14
        Me.lstRoles.Location = New System.Drawing.Point(632, 131)
        Me.lstRoles.Name = "lstRoles"
        Me.lstRoles.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstRoles.Size = New System.Drawing.Size(402, 382)
        Me.lstRoles.TabIndex = 178
        '
        'lstRolesPorUsuario
        '
        Me.lstRolesPorUsuario.BackColor = System.Drawing.Color.White
        Me.lstRolesPorUsuario.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstRolesPorUsuario.ForeColor = System.Drawing.Color.DarkGreen
        Me.lstRolesPorUsuario.FormattingEnabled = True
        Me.lstRolesPorUsuario.ItemHeight = 14
        Me.lstRolesPorUsuario.Location = New System.Drawing.Point(77, 130)
        Me.lstRolesPorUsuario.Name = "lstRolesPorUsuario"
        Me.lstRolesPorUsuario.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstRolesPorUsuario.Size = New System.Drawing.Size(402, 382)
        Me.lstRolesPorUsuario.TabIndex = 176
        '
        'AdministraSeguridad_Fill_Panel
        '
        Me.AdministraSeguridad_Fill_Panel.Controls.Add(Me.tabSecurity)
        Me.AdministraSeguridad_Fill_Panel.Cursor = System.Windows.Forms.Cursors.Default
        Me.AdministraSeguridad_Fill_Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AdministraSeguridad_Fill_Panel.Location = New System.Drawing.Point(0, 0)
        Me.AdministraSeguridad_Fill_Panel.Name = "AdministraSeguridad_Fill_Panel"
        Me.AdministraSeguridad_Fill_Panel.Size = New System.Drawing.Size(1083, 555)
        Me.AdministraSeguridad_Fill_Panel.TabIndex = 1
        '
        'tabSecurity
        '
        Appearance6.TextHAlignAsString = "Left"
        Appearance6.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.tabSecurity.ActiveTabAppearance = Appearance6
        Appearance7.FontData.StrikeoutAsString = "False"
        Appearance7.ImageVAlign = Infragistics.Win.VAlign.Middle
        Appearance7.TextHAlignAsString = "Left"
        Me.tabSecurity.Appearance = Appearance7
        Me.tabSecurity.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.tabSecurity.Controls.Add(Me.UltraTabPageControl34)
        Me.tabSecurity.Controls.Add(Me.utcAdministraSeguridad)
        Me.tabSecurity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabSecurity.ImageSize = New System.Drawing.Size(32, 32)
        Me.tabSecurity.ImageTransparentColor = System.Drawing.Color.White
        Me.tabSecurity.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.tabSecurity.Location = New System.Drawing.Point(0, 0)
        Me.tabSecurity.Name = "tabSecurity"
        Me.tabSecurity.ScaleImages = Infragistics.Win.ScaleImage.Never
        Me.tabSecurity.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.tabSecurity.Size = New System.Drawing.Size(1083, 555)
        Me.tabSecurity.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.Office2007Ribbon
        Me.tabSecurity.TabIndex = 101
        Me.tabSecurity.TabPadding = New System.Drawing.Size(35, 0)
        Appearance8.Image = "createMeeting48x48.png"
        UltraTab39.Appearance = Appearance8
        UltraTab39.Key = "tabPermisosRol"
        UltraTab39.TabPage = Me.UltraTabPageControl34
        UltraTab39.Text = "Permisos Rol"
        Appearance9.Image = "user.png"
        UltraTab40.Appearance = Appearance9
        UltraTab40.Key = "tabPermisosUsuario"
        UltraTab40.TabPage = Me.utcAdministraSeguridad
        UltraTab40.Text = "Permisos Usuario"
        Me.tabSecurity.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab39, UltraTab40})
        Me.tabSecurity.TabSize = New System.Drawing.Size(0, 35)
        Me.tabSecurity.TabsPerRow = 5
        Me.tabSecurity.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(1081, 518)
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'erpError
        '
        Me.erpError.ContainerControl = Me
        '
        'Administracion_Seguridad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1083, 555)
        Me.Controls.Add(Me.AdministraSeguridad_Fill_Panel)
        Me.Name = "Administracion_Seguridad"
        Me.Text = "Administración Seguridad"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.UltraTabPageControl34.ResumeLayout(False)
        CType(Me.griAllUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraPanel1.ClientArea.ResumeLayout(False)
        Me.UltraPanel1.ClientArea.PerformLayout()
        Me.UltraPanel1.ResumeLayout(False)
        Me.tosUsuariosEnRoles.ResumeLayout(False)
        Me.tosUsuariosEnRoles.PerformLayout()
        Me.utcAdministraSeguridad.ResumeLayout(False)
        Me.utcAdministraSeguridad.PerformLayout()
        CType(Me.txtNombreUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.txtNombreUsuario.ResumeLayout(False)
        Me.txtNombreUsuario.PerformLayout()
        Me.tosPermisosRoles.ResumeLayout(False)
        Me.tosPermisosRoles.PerformLayout()
        Me.AdministraSeguridad_Fill_Panel.ResumeLayout(False)
        CType(Me.tabSecurity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabSecurity.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erpError, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AdministraSeguridad_Fill_Panel As System.Windows.Forms.Panel
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents erpError As System.Windows.Forms.ErrorProvider
    Friend WithEvents UltraGridFilterUIProvider1 As Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider
    Friend WithEvents tabSecurity As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl34 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griAllUsers As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents lstUsuariosEnRol As System.Windows.Forms.ListBox
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lstTodosRoles As System.Windows.Forms.ListBox
    Friend WithEvents UltraPanel1 As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents chkMarcaTodos As System.Windows.Forms.CheckBox
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents tsbAgregaRol As System.Windows.Forms.Button
    Friend WithEvents txtRol As System.Windows.Forms.TextBox
    Friend WithEvents tosUsuariosEnRoles As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbQuitarUsuario As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbOtorgaPermisos As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsb_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents utcAdministraSeguridad As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents butRolesUsuario As System.Windows.Forms.Button
    Friend WithEvents txtRolesUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tosPermisosRoles As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbQuitarRol As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbAgregarRol As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents chkTodosRolesSeleccionados As System.Windows.Forms.CheckBox
    Friend WithEvents chkTodosRoles As System.Windows.Forms.CheckBox
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lstRoles As System.Windows.Forms.ListBox
    Friend WithEvents lstRolesPorUsuario As System.Windows.Forms.ListBox
    Friend WithEvents txtNombreUsuario As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNombres As TextBox
End Class
