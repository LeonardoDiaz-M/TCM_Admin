<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Administracion_Forms_Rol
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("aspnet_Roles", -1)
        Dim UltraGridColumn90 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ApplicationId")
        Dim UltraGridColumn91 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RoleId")
        Dim UltraGridColumn92 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RoleName")
        Dim UltraGridColumn93 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LoweredRoleName")
        Dim UltraGridColumn94 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion_Menu")
        Dim UltraGridColumn95 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("aspnet_Roles_tbMainSubMenus")
        Dim UltraGridColumn96 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("aspnet_Roles_tbMainSubMenus1")
        Dim UltraGridColumn97 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("aspnet_Roles_tbMainSubMenus2")
        Dim UltraGridColumn98 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("aspnet_Roles_tbMainSubMenus3")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("aspnet_Roles_tbMainSubMenus", 0)
        Dim UltraGridColumn99 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubMenu")
        Dim UltraGridColumn100 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Description")
        Dim UltraGridColumn101 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Parent")
        Dim UltraGridColumn102 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IconName")
        Dim UltraGridColumn103 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Status")
        Dim UltraGridColumn104 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ReadOpt")
        Dim UltraGridColumn105 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AddOpt")
        Dim UltraGridColumn106 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DelOpt")
        Dim UltraGridColumn107 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UpdOpt")
        Dim UltraGridColumn108 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IsModal")
        Dim UltraGridColumn109 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PosMnu")
        Dim UltraGridColumn110 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("tbMainSubMenus_tbMainMenu")
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("tbMainSubMenus_tbMainMenu", 1)
        Dim UltraGridColumn111 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MenuNam")
        Dim UltraGridColumn112 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Description")
        Dim UltraGridColumn113 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IconName")
        Dim UltraGridColumn114 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Status")
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("aspnet_Roles_tbMainSubMenus1", 0)
        Dim UltraGridColumn115 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubMenu")
        Dim UltraGridColumn116 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Description")
        Dim UltraGridColumn117 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Parent")
        Dim UltraGridColumn118 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IconName")
        Dim UltraGridColumn119 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Status")
        Dim UltraGridColumn120 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ReadOpt")
        Dim UltraGridColumn121 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AddOpt")
        Dim UltraGridColumn122 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DelOpt")
        Dim UltraGridColumn123 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UpdOpt")
        Dim UltraGridColumn124 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IsModal")
        Dim UltraGridColumn125 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PosMnu")
        Dim UltraGridColumn126 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("tbMainSubMenus_tbMainMenu")
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("tbMainSubMenus_tbMainMenu", 3)
        Dim UltraGridColumn127 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MenuNam")
        Dim UltraGridColumn128 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Description")
        Dim UltraGridColumn129 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IconName")
        Dim UltraGridColumn130 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Status")
        Dim UltraGridBand6 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("aspnet_Roles_tbMainSubMenus2", 0)
        Dim UltraGridColumn131 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubMenu")
        Dim UltraGridColumn132 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Description")
        Dim UltraGridColumn133 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Parent")
        Dim UltraGridColumn134 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IconName")
        Dim UltraGridColumn135 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Status")
        Dim UltraGridColumn136 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ReadOpt")
        Dim UltraGridColumn137 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AddOpt")
        Dim UltraGridColumn138 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DelOpt")
        Dim UltraGridColumn139 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UpdOpt")
        Dim UltraGridColumn140 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IsModal")
        Dim UltraGridColumn141 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PosMnu")
        Dim UltraGridColumn142 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("tbMainSubMenus_tbMainMenu")
        Dim UltraGridBand7 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("tbMainSubMenus_tbMainMenu", 5)
        Dim UltraGridColumn143 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MenuNam")
        Dim UltraGridColumn144 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Description")
        Dim UltraGridColumn145 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IconName")
        Dim UltraGridColumn146 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Status")
        Dim UltraGridBand8 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("aspnet_Roles_tbMainSubMenus3", 0)
        Dim UltraGridColumn147 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubMenu")
        Dim UltraGridColumn148 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Description")
        Dim UltraGridColumn149 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Parent")
        Dim UltraGridColumn150 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IconName")
        Dim UltraGridColumn151 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Status")
        Dim UltraGridColumn152 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ReadOpt")
        Dim UltraGridColumn153 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AddOpt")
        Dim UltraGridColumn154 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DelOpt")
        Dim UltraGridColumn155 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UpdOpt")
        Dim UltraGridColumn156 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IsModal")
        Dim UltraGridColumn157 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PosMnu")
        Dim UltraGridColumn158 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("tbMainSubMenus_tbMainMenu")
        Dim UltraGridBand9 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("tbMainSubMenus_tbMainMenu", 7)
        Dim UltraGridColumn159 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MenuNam")
        Dim UltraGridColumn160 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Description")
        Dim UltraGridColumn161 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IconName")
        Dim UltraGridColumn162 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Status")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand10 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("tbMainSubMenus", -1)
        Dim UltraGridColumn163 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubMenu")
        Dim UltraGridColumn164 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Description")
        Dim UltraGridColumn165 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Parent")
        Dim UltraGridColumn166 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IconName")
        Dim UltraGridColumn167 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Status")
        Dim UltraGridColumn168 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ReadOpt", -1, "droRoles")
        Dim UltraGridColumn169 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AddOpt", -1, "droRoles", 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn170 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DelOpt", -1, "droRoles")
        Dim UltraGridColumn171 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UpdOpt", -1, "droRoles")
        Dim UltraGridColumn172 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IsModal")
        Dim UltraGridColumn173 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PosMnu")
        Dim UltraGridColumn174 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("tbMainSubMenus_tbMainMenu")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand11 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("tbMainSubMenus_tbMainMenu", 0)
        Dim UltraGridColumn175 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MenuNam")
        Dim UltraGridColumn176 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Description")
        Dim UltraGridColumn177 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IconName")
        Dim UltraGridColumn178 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Status")
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnSalir = New System.Windows.Forms.ToolStripButton()
        Me.tsbGuardaUsuario = New System.Windows.Forms.ToolStripButton()
        Me.tsbModificarUsuario = New System.Windows.Forms.ToolStripButton()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.droRoles = New Infragistics.Win.UltraWinGrid.UltraDropDown()
        Me.AspnetRolesBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsSeguridadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsSeguridad = New TCMAdmin.dsSeguridad()
        Me.griMenus = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.TbMainSubMenusBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbMainSubMenusTableAdapter = New TCMAdmin.dsSeguridadTableAdapters.tbMainSubMenusTableAdapter()
        Me.AspnetRolesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Aspnet_RolesTableAdapter = New TCMAdmin.dsSeguridadTableAdapters.aspnet_RolesTableAdapter()
        Me.AspnetRolesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AspnetRolesBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AspnetRolesBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbMainSubMenusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStrip1.SuspendLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.droRoles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AspnetRolesBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSeguridadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSeguridad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.griMenus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbMainSubMenusBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AspnetRolesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AspnetRolesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AspnetRolesBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AspnetRolesBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbMainSubMenusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSalir, Me.tsbGuardaUsuario, Me.tsbModificarUsuario})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1115, 47)
        Me.ToolStrip1.TabIndex = 579
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnSalir
        '
        Me.btnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSalir.Image = Global.TCMAdmin.My.Resources.Resources.IconBack
        Me.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(44, 44)
        Me.btnSalir.Text = "Cerrar"
        Me.btnSalir.ToolTipText = "Salir"
        '
        'tsbGuardaUsuario
        '
        Me.tsbGuardaUsuario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbGuardaUsuario.Image = Global.TCMAdmin.My.Resources.Resources.IconSave
        Me.tsbGuardaUsuario.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGuardaUsuario.Name = "tsbGuardaUsuario"
        Me.tsbGuardaUsuario.Size = New System.Drawing.Size(44, 44)
        Me.tsbGuardaUsuario.Text = "Guardar"
        '
        'tsbModificarUsuario
        '
        Me.tsbModificarUsuario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbModificarUsuario.Image = Global.TCMAdmin.My.Resources.Resources.IconEdit
        Me.tsbModificarUsuario.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbModificarUsuario.Name = "tsbModificarUsuario"
        Me.tsbModificarUsuario.Size = New System.Drawing.Size(44, 44)
        Me.tsbModificarUsuario.Text = "ToolStripButton1"
        Me.tsbModificarUsuario.ToolTipText = "Modificar"
        Me.tsbModificarUsuario.Visible = False
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.droRoles)
        Me.UltraGroupBox1.Controls.Add(Me.griMenus)
        Me.UltraGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox1.Location = New System.Drawing.Point(0, 47)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(1115, 568)
        Me.UltraGroupBox1.TabIndex = 580
        Me.UltraGroupBox1.Text = "Forms Menu"
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'droRoles
        '
        Me.droRoles.DataSource = Me.AspnetRolesBindingSource4
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.droRoles.DisplayLayout.Appearance = Appearance1
        UltraGridColumn90.Header.VisiblePosition = 0
        UltraGridColumn90.Hidden = True
        UltraGridColumn91.Header.VisiblePosition = 1
        UltraGridColumn91.Hidden = True
        UltraGridColumn92.Header.VisiblePosition = 2
        UltraGridColumn92.Width = 269
        UltraGridColumn93.Header.VisiblePosition = 3
        UltraGridColumn93.Hidden = True
        UltraGridColumn94.Header.VisiblePosition = 4
        UltraGridColumn95.Header.VisiblePosition = 5
        UltraGridColumn96.Header.VisiblePosition = 6
        UltraGridColumn97.Header.VisiblePosition = 7
        UltraGridColumn98.Header.VisiblePosition = 8
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn90, UltraGridColumn91, UltraGridColumn92, UltraGridColumn93, UltraGridColumn94, UltraGridColumn95, UltraGridColumn96, UltraGridColumn97, UltraGridColumn98})
        UltraGridColumn99.Header.VisiblePosition = 0
        UltraGridColumn100.Header.VisiblePosition = 1
        UltraGridColumn101.Header.VisiblePosition = 2
        UltraGridColumn102.Header.VisiblePosition = 3
        UltraGridColumn103.Header.VisiblePosition = 4
        UltraGridColumn104.Header.VisiblePosition = 5
        UltraGridColumn105.Header.VisiblePosition = 6
        UltraGridColumn106.Header.VisiblePosition = 7
        UltraGridColumn107.Header.VisiblePosition = 8
        UltraGridColumn108.Header.VisiblePosition = 9
        UltraGridColumn109.Header.VisiblePosition = 10
        UltraGridColumn110.Header.VisiblePosition = 11
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn99, UltraGridColumn100, UltraGridColumn101, UltraGridColumn102, UltraGridColumn103, UltraGridColumn104, UltraGridColumn105, UltraGridColumn106, UltraGridColumn107, UltraGridColumn108, UltraGridColumn109, UltraGridColumn110})
        UltraGridColumn111.Header.VisiblePosition = 0
        UltraGridColumn112.Header.VisiblePosition = 1
        UltraGridColumn113.Header.VisiblePosition = 2
        UltraGridColumn114.Header.VisiblePosition = 3
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn111, UltraGridColumn112, UltraGridColumn113, UltraGridColumn114})
        UltraGridColumn115.Header.VisiblePosition = 0
        UltraGridColumn116.Header.VisiblePosition = 1
        UltraGridColumn117.Header.VisiblePosition = 2
        UltraGridColumn118.Header.VisiblePosition = 3
        UltraGridColumn119.Header.VisiblePosition = 4
        UltraGridColumn120.Header.VisiblePosition = 5
        UltraGridColumn121.Header.VisiblePosition = 6
        UltraGridColumn122.Header.VisiblePosition = 7
        UltraGridColumn123.Header.VisiblePosition = 8
        UltraGridColumn124.Header.VisiblePosition = 9
        UltraGridColumn125.Header.VisiblePosition = 10
        UltraGridColumn126.Header.VisiblePosition = 11
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn115, UltraGridColumn116, UltraGridColumn117, UltraGridColumn118, UltraGridColumn119, UltraGridColumn120, UltraGridColumn121, UltraGridColumn122, UltraGridColumn123, UltraGridColumn124, UltraGridColumn125, UltraGridColumn126})
        UltraGridColumn127.Header.VisiblePosition = 0
        UltraGridColumn128.Header.VisiblePosition = 1
        UltraGridColumn129.Header.VisiblePosition = 2
        UltraGridColumn130.Header.VisiblePosition = 3
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn127, UltraGridColumn128, UltraGridColumn129, UltraGridColumn130})
        UltraGridColumn131.Header.VisiblePosition = 0
        UltraGridColumn132.Header.VisiblePosition = 1
        UltraGridColumn133.Header.VisiblePosition = 2
        UltraGridColumn134.Header.VisiblePosition = 3
        UltraGridColumn135.Header.VisiblePosition = 4
        UltraGridColumn136.Header.VisiblePosition = 5
        UltraGridColumn137.Header.VisiblePosition = 6
        UltraGridColumn138.Header.VisiblePosition = 7
        UltraGridColumn139.Header.VisiblePosition = 8
        UltraGridColumn140.Header.VisiblePosition = 9
        UltraGridColumn141.Header.VisiblePosition = 10
        UltraGridColumn142.Header.VisiblePosition = 11
        UltraGridBand6.Columns.AddRange(New Object() {UltraGridColumn131, UltraGridColumn132, UltraGridColumn133, UltraGridColumn134, UltraGridColumn135, UltraGridColumn136, UltraGridColumn137, UltraGridColumn138, UltraGridColumn139, UltraGridColumn140, UltraGridColumn141, UltraGridColumn142})
        UltraGridColumn143.Header.VisiblePosition = 0
        UltraGridColumn144.Header.VisiblePosition = 1
        UltraGridColumn145.Header.VisiblePosition = 2
        UltraGridColumn146.Header.VisiblePosition = 3
        UltraGridBand7.Columns.AddRange(New Object() {UltraGridColumn143, UltraGridColumn144, UltraGridColumn145, UltraGridColumn146})
        UltraGridColumn147.Header.VisiblePosition = 0
        UltraGridColumn148.Header.VisiblePosition = 1
        UltraGridColumn149.Header.VisiblePosition = 2
        UltraGridColumn150.Header.VisiblePosition = 3
        UltraGridColumn151.Header.VisiblePosition = 4
        UltraGridColumn152.Header.VisiblePosition = 5
        UltraGridColumn153.Header.VisiblePosition = 6
        UltraGridColumn154.Header.VisiblePosition = 7
        UltraGridColumn155.Header.VisiblePosition = 8
        UltraGridColumn156.Header.VisiblePosition = 9
        UltraGridColumn157.Header.VisiblePosition = 10
        UltraGridColumn158.Header.VisiblePosition = 11
        UltraGridBand8.Columns.AddRange(New Object() {UltraGridColumn147, UltraGridColumn148, UltraGridColumn149, UltraGridColumn150, UltraGridColumn151, UltraGridColumn152, UltraGridColumn153, UltraGridColumn154, UltraGridColumn155, UltraGridColumn156, UltraGridColumn157, UltraGridColumn158})
        UltraGridColumn159.Header.VisiblePosition = 0
        UltraGridColumn160.Header.VisiblePosition = 1
        UltraGridColumn161.Header.VisiblePosition = 2
        UltraGridColumn162.Header.VisiblePosition = 3
        UltraGridBand9.Columns.AddRange(New Object() {UltraGridColumn159, UltraGridColumn160, UltraGridColumn161, UltraGridColumn162})
        Me.droRoles.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.droRoles.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.droRoles.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.droRoles.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.droRoles.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Me.droRoles.DisplayLayout.BandsSerializer.Add(UltraGridBand6)
        Me.droRoles.DisplayLayout.BandsSerializer.Add(UltraGridBand7)
        Me.droRoles.DisplayLayout.BandsSerializer.Add(UltraGridBand8)
        Me.droRoles.DisplayLayout.BandsSerializer.Add(UltraGridBand9)
        Me.droRoles.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.droRoles.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance2.BorderColor = System.Drawing.SystemColors.Window
        Me.droRoles.DisplayLayout.GroupByBox.Appearance = Appearance2
        Appearance3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.droRoles.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance3
        Me.droRoles.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance4.BackColor2 = System.Drawing.SystemColors.Control
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.droRoles.DisplayLayout.GroupByBox.PromptAppearance = Appearance4
        Me.droRoles.DisplayLayout.MaxColScrollRegions = 1
        Me.droRoles.DisplayLayout.MaxRowScrollRegions = 1
        Appearance5.BackColor = System.Drawing.SystemColors.Window
        Appearance5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.droRoles.DisplayLayout.Override.ActiveCellAppearance = Appearance5
        Appearance6.BackColor = System.Drawing.SystemColors.Highlight
        Appearance6.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.droRoles.DisplayLayout.Override.ActiveRowAppearance = Appearance6
        Me.droRoles.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.droRoles.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance7.BackColor = System.Drawing.SystemColors.Window
        Me.droRoles.DisplayLayout.Override.CardAreaAppearance = Appearance7
        Appearance8.BorderColor = System.Drawing.Color.Silver
        Appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.droRoles.DisplayLayout.Override.CellAppearance = Appearance8
        Me.droRoles.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.droRoles.DisplayLayout.Override.CellPadding = 0
        Appearance9.BackColor = System.Drawing.SystemColors.Control
        Appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance9.BorderColor = System.Drawing.SystemColors.Window
        Me.droRoles.DisplayLayout.Override.GroupByRowAppearance = Appearance9
        Appearance10.TextHAlignAsString = "Left"
        Me.droRoles.DisplayLayout.Override.HeaderAppearance = Appearance10
        Me.droRoles.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.droRoles.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance11.BackColor = System.Drawing.SystemColors.Window
        Appearance11.BorderColor = System.Drawing.Color.Silver
        Me.droRoles.DisplayLayout.Override.RowAppearance = Appearance11
        Me.droRoles.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance12.BackColor = System.Drawing.SystemColors.ControlLight
        Me.droRoles.DisplayLayout.Override.TemplateAddRowAppearance = Appearance12
        Me.droRoles.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.droRoles.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.droRoles.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.droRoles.DisplayMember = "RoleName"
        Me.droRoles.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.droRoles.Location = New System.Drawing.Point(12, 266)
        Me.droRoles.Name = "droRoles"
        Me.droRoles.Size = New System.Drawing.Size(424, 80)
        Me.droRoles.TabIndex = 583
        Me.droRoles.Text = "UltraDropDown1"
        Me.droRoles.ValueMember = "RoleId"
        Me.droRoles.Visible = False
        '
        'AspnetRolesBindingSource4
        '
        Me.AspnetRolesBindingSource4.DataMember = "aspnet_Roles"
        Me.AspnetRolesBindingSource4.DataSource = Me.DsSeguridadBindingSource
        '
        'DsSeguridadBindingSource
        '
        Me.DsSeguridadBindingSource.DataSource = Me.DsSeguridad
        Me.DsSeguridadBindingSource.Position = 0
        '
        'DsSeguridad
        '
        Me.DsSeguridad.DataSetName = "dsSeguridad"
        Me.DsSeguridad.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'griMenus
        '
        Me.griMenus.DataSource = Me.TbMainSubMenusBindingSource1
        Appearance13.BackColor = System.Drawing.SystemColors.Window
        Appearance13.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Appearance13.FontData.BoldAsString = "False"
        Me.griMenus.DisplayLayout.Appearance = Appearance13
        UltraGridColumn163.Header.VisiblePosition = 0
        UltraGridColumn163.Hidden = True
        UltraGridColumn164.Header.Caption = "Descripción"
        UltraGridColumn164.Header.VisiblePosition = 2
        UltraGridColumn164.Width = 250
        UltraGridColumn165.Header.VisiblePosition = 1
        UltraGridColumn166.Header.VisiblePosition = 3
        UltraGridColumn166.Hidden = True
        UltraGridColumn167.Header.VisiblePosition = 4
        UltraGridColumn167.Hidden = True
        UltraGridColumn168.Header.Caption = "Consultar"
        UltraGridColumn168.Header.VisiblePosition = 5
        UltraGridColumn168.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate
        UltraGridColumn168.Width = 200
        UltraGridColumn169.Header.Caption = "Insertar"
        UltraGridColumn169.Header.VisiblePosition = 6
        UltraGridColumn169.Width = 200
        UltraGridColumn170.Header.Caption = "Borrar"
        UltraGridColumn170.Header.VisiblePosition = 7
        UltraGridColumn170.Width = 200
        UltraGridColumn171.Header.Caption = "Editar"
        UltraGridColumn171.Header.VisiblePosition = 8
        UltraGridColumn171.Width = 200
        UltraGridColumn172.Header.VisiblePosition = 9
        UltraGridColumn172.Hidden = True
        UltraGridColumn173.Header.VisiblePosition = 10
        UltraGridColumn173.Hidden = True
        UltraGridColumn174.Header.VisiblePosition = 11
        UltraGridBand10.Columns.AddRange(New Object() {UltraGridColumn163, UltraGridColumn164, UltraGridColumn165, UltraGridColumn166, UltraGridColumn167, UltraGridColumn168, UltraGridColumn169, UltraGridColumn170, UltraGridColumn171, UltraGridColumn172, UltraGridColumn173, UltraGridColumn174})
        Appearance14.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        UltraGridBand10.Override.RowAlternateAppearance = Appearance14
        UltraGridColumn175.Header.VisiblePosition = 0
        UltraGridColumn176.Header.VisiblePosition = 1
        UltraGridColumn177.Header.VisiblePosition = 2
        UltraGridColumn178.Header.VisiblePosition = 3
        UltraGridBand11.Columns.AddRange(New Object() {UltraGridColumn175, UltraGridColumn176, UltraGridColumn177, UltraGridColumn178})
        Me.griMenus.DisplayLayout.BandsSerializer.Add(UltraGridBand10)
        Me.griMenus.DisplayLayout.BandsSerializer.Add(UltraGridBand11)
        Me.griMenus.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griMenus.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance15.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance15.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance15.BorderColor = System.Drawing.SystemColors.Window
        Me.griMenus.DisplayLayout.GroupByBox.Appearance = Appearance15
        Appearance16.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griMenus.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance16
        Me.griMenus.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance17.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance17.BackColor2 = System.Drawing.SystemColors.Control
        Appearance17.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance17.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griMenus.DisplayLayout.GroupByBox.PromptAppearance = Appearance17
        Me.griMenus.DisplayLayout.MaxColScrollRegions = 1
        Me.griMenus.DisplayLayout.MaxRowScrollRegions = 1
        Appearance18.BackColor = System.Drawing.SystemColors.Window
        Appearance18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.griMenus.DisplayLayout.Override.ActiveCellAppearance = Appearance18
        Appearance19.BackColor = System.Drawing.SystemColors.Highlight
        Appearance19.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.griMenus.DisplayLayout.Override.ActiveRowAppearance = Appearance19
        Me.griMenus.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griMenus.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance20.BackColor = System.Drawing.SystemColors.Window
        Me.griMenus.DisplayLayout.Override.CardAreaAppearance = Appearance20
        Appearance21.BorderColor = System.Drawing.Color.Silver
        Appearance21.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.griMenus.DisplayLayout.Override.CellAppearance = Appearance21
        Me.griMenus.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.griMenus.DisplayLayout.Override.CellPadding = 0
        Me.griMenus.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griMenus.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance22.BackColor = System.Drawing.SystemColors.Control
        Appearance22.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance22.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance22.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance22.BorderColor = System.Drawing.SystemColors.Window
        Me.griMenus.DisplayLayout.Override.GroupByRowAppearance = Appearance22
        Appearance23.TextHAlignAsString = "Center"
        Me.griMenus.DisplayLayout.Override.HeaderAppearance = Appearance23
        Me.griMenus.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griMenus.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance24.BackColor = System.Drawing.SystemColors.Window
        Appearance24.BorderColor = System.Drawing.Color.Silver
        Me.griMenus.DisplayLayout.Override.RowAppearance = Appearance24
        Me.griMenus.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance25.BackColor = System.Drawing.SystemColors.ControlLight
        Me.griMenus.DisplayLayout.Override.TemplateAddRowAppearance = Appearance25
        Me.griMenus.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griMenus.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griMenus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griMenus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griMenus.Location = New System.Drawing.Point(2, 18)
        Me.griMenus.Name = "griMenus"
        Me.griMenus.Size = New System.Drawing.Size(1111, 548)
        Me.griMenus.TabIndex = 582
        Me.griMenus.Text = "griForms"
        '
        'TbMainSubMenusBindingSource1
        '
        Me.TbMainSubMenusBindingSource1.DataMember = "tbMainSubMenus"
        Me.TbMainSubMenusBindingSource1.DataSource = Me.DsSeguridadBindingSource
        '
        'TbMainSubMenusTableAdapter
        '
        Me.TbMainSubMenusTableAdapter.ClearBeforeFill = True
        '
        'AspnetRolesBindingSource
        '
        Me.AspnetRolesBindingSource.DataMember = "aspnet_Roles"
        Me.AspnetRolesBindingSource.DataSource = Me.DsSeguridadBindingSource
        '
        'Aspnet_RolesTableAdapter
        '
        Me.Aspnet_RolesTableAdapter.ClearBeforeFill = True
        '
        'AspnetRolesBindingSource1
        '
        Me.AspnetRolesBindingSource1.DataMember = "aspnet_Roles"
        Me.AspnetRolesBindingSource1.DataSource = Me.DsSeguridadBindingSource
        '
        'AspnetRolesBindingSource3
        '
        Me.AspnetRolesBindingSource3.DataMember = "aspnet_Roles"
        Me.AspnetRolesBindingSource3.DataSource = Me.DsSeguridadBindingSource
        '
        'AspnetRolesBindingSource2
        '
        Me.AspnetRolesBindingSource2.DataMember = "aspnet_Roles"
        Me.AspnetRolesBindingSource2.DataSource = Me.DsSeguridadBindingSource
        '
        'TbMainSubMenusBindingSource
        '
        Me.TbMainSubMenusBindingSource.DataMember = "tbMainSubMenus"
        Me.TbMainSubMenusBindingSource.DataSource = Me.DsSeguridadBindingSource
        '
        'Administracion_Forms_Rol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1115, 615)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "Administracion_Forms_Rol"
        Me.Text = "Administracion_Forms_Rol"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        CType(Me.droRoles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AspnetRolesBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSeguridadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSeguridad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.griMenus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbMainSubMenusBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AspnetRolesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AspnetRolesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AspnetRolesBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AspnetRolesBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbMainSubMenusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsbGuardaUsuario As ToolStripButton
    Friend WithEvents tsbModificarUsuario As ToolStripButton
    Friend WithEvents btnSalir As ToolStripButton
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents DsSeguridadBindingSource As BindingSource
    Friend WithEvents DsSeguridad As dsSeguridad
    Friend WithEvents TbMainSubMenusTableAdapter As dsSeguridadTableAdapters.tbMainSubMenusTableAdapter
    Friend WithEvents AspnetRolesBindingSource As BindingSource
    Friend WithEvents Aspnet_RolesTableAdapter As dsSeguridadTableAdapters.aspnet_RolesTableAdapter
    Friend WithEvents AspnetRolesBindingSource1 As BindingSource
    Friend WithEvents AspnetRolesBindingSource3 As BindingSource
    Friend WithEvents griMenus As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents TbMainSubMenusBindingSource1 As BindingSource
    Friend WithEvents droRoles As Infragistics.Win.UltraWinGrid.UltraDropDown
    Friend WithEvents AspnetRolesBindingSource4 As BindingSource
    Friend WithEvents AspnetRolesBindingSource2 As BindingSource
    Friend WithEvents TbMainSubMenusBindingSource As BindingSource
End Class
