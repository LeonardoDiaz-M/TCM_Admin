<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPanteones
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("clave")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("nombre")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("id_colonia")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("nom_colonia")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("clave")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("nombre")
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem4 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem5 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cve_status")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("descripcion")
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cve_tip_con")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("descricion")
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsLicencias1 = New TCMAdmin.dsLicencias()
        Me.btnBack = New System.Windows.Forms.ToolStripButton()
        Me.btnUndo = New System.Windows.Forms.ToolStripButton()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.btnEditar = New System.Windows.Forms.ToolStripButton()
        Me.btnElimina = New System.Windows.Forms.ToolStripButton()
        Me.btnImage = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.lblCurrentMenu = New System.Windows.Forms.ToolStripLabel()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.grpUltimoPago = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel4 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.uneUltMes = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.uneUltAnio = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.dtpFechaPago = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtNoRecibo = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.lblNumRecibo = New Infragistics.Win.Misc.UltraLabel()
        Me.lblUltAño = New Infragistics.Win.Misc.UltraLabel()
        Me.lblUltMes = New Infragistics.Win.Misc.UltraLabel()
        Me.grpPAE = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel3 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.chkNotificado = New System.Windows.Forms.CheckBox()
        Me.panNotificado = New System.Windows.Forms.Panel()
        Me.txtNoActos = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.ucoPae = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.lblPae = New Infragistics.Win.Misc.UltraLabel()
        Me.lblFechaPae = New Infragistics.Win.Misc.UltraLabel()
        Me.txtNoOficioPae = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtFecPAE = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.lblNoPAe = New Infragistics.Win.Misc.UltraLabel()
        Me.lblNoActosPAe = New Infragistics.Win.Misc.UltraLabel()
        Me.grpPropietario = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel2 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.lblCorreo = New Infragistics.Win.Misc.UltraLabel()
        Me.txtemail = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtCurp = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.lblCurp = New Infragistics.Win.Misc.UltraLabel()
        Me.txtRfc = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtTel = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.lblTelefono = New Infragistics.Win.Misc.UltraLabel()
        Me.txtCalle = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtCP = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.ucoColonia = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.txtNoInt = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtNoExt = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.lblCP = New Infragistics.Win.Misc.UltraLabel()
        Me.lblObs = New Infragistics.Win.Misc.UltraLabel()
        Me.lblResponsable = New Infragistics.Win.Misc.UltraLabel()
        Me.lblRFC = New Infragistics.Win.Misc.UltraLabel()
        Me.ucoLocalidad = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.txtObservaciones = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtResponsable = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtDomicilio = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtNombre = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.lblNoInterior = New Infragistics.Win.Misc.UltraLabel()
        Me.lblNombre = New Infragistics.Win.Misc.UltraLabel()
        Me.lblDomicilio = New Infragistics.Win.Misc.UltraLabel()
        Me.lblLocalidad = New Infragistics.Win.Misc.UltraLabel()
        Me.lblColonia = New Infragistics.Win.Misc.UltraLabel()
        Me.lblNoExt = New Infragistics.Win.Misc.UltraLabel()
        Me.grpDatosCuenta = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel1 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.gruTipoDeposito = New Infragistics.Win.Misc.UltraGroupBox()
        Me.optTipoDeposito = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        Me.uneDimension = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.txtUbicacionDeposito = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtFechaIniOp = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.lblIniciRecargo = New Infragistics.Win.Misc.UltraLabel()
        Me.ucoStatus = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.ucoTipoContribuyente = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.lblDimension = New Infragistics.Win.Misc.UltraLabel()
        Me.lblContribuyente = New Infragistics.Win.Misc.UltraLabel()
        Me.lblStatus = New Infragistics.Win.Misc.UltraLabel()
        Me.lblCuenta = New Infragistics.Win.Misc.UltraLabel()
        Me.lblActividad = New Infragistics.Win.Misc.UltraLabel()
        Me.txtNoLic = New System.Windows.Forms.MaskedTextBox()
        Me.Tbl_lic_municipalesTableAdapter = New TCMAdmin.dsLicenciasTableAdapters.tbl_lic_municipalesTableAdapter()
        Me.DsLicencias1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanteonesTipoDepositoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panteones_Tipo_DepositoTableAdapter = New TCMAdmin.dsLicenciasTableAdapters.Panteones_Tipo_DepositoTableAdapter()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsLicencias1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpUltimoPago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpUltimoPago.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel4.SuspendLayout()
        CType(Me.uneUltMes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uneUltAnio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoRecibo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpPAE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPAE.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel3.SuspendLayout()
        Me.panNotificado.SuspendLayout()
        CType(Me.txtNoActos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ucoPae, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoOficioPae, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFecPAE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpPropietario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPropietario.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel2.SuspendLayout()
        CType(Me.txtemail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRfc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ucoColonia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoInt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoExt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ucoLocalidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtObservaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtResponsable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDomicilio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpDatosCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDatosCuenta.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel1.SuspendLayout()
        CType(Me.gruTipoDeposito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gruTipoDeposito.SuspendLayout()
        CType(Me.optTipoDeposito, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uneDimension, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUbicacionDeposito, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaIniOp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ucoStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ucoTipoContribuyente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsLicencias1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanteonesTipoDepositoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BackColor = System.Drawing.Color.Transparent
        Me.BindingNavigator1.BindingSource = Me.BindingSource1
        Me.BindingNavigator1.CountItem = Nothing
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.ImageScalingSize = New System.Drawing.Size(36, 36)
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBack, Me.btnUndo, Me.btnGuardar, Me.btnEditar, Me.btnElimina, Me.btnImage, Me.ToolStripSeparator1, Me.ToolStripLabel2, Me.lblCurrentMenu})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Nothing
        Me.BindingNavigator1.MoveLastItem = Nothing
        Me.BindingNavigator1.MoveNextItem = Nothing
        Me.BindingNavigator1.MovePreviousItem = Nothing
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Nothing
        Me.BindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.BindingNavigator1.Size = New System.Drawing.Size(1445, 43)
        Me.BindingNavigator1.TabIndex = 0
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "tbl_lic_municipales"
        Me.BindingSource1.DataSource = Me.DsLicencias1
        '
        'DsLicencias1
        '
        Me.DsLicencias1.DataSetName = "dsLicencias"
        Me.DsLicencias1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnBack
        '
        Me.btnBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnBack.Image = Global.TCMAdmin.My.Resources.Resources.IconBack
        Me.btnBack.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnBack.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(29, 40)
        Me.btnBack.Text = "ToolStripButton1"
        Me.btnBack.ToolTipText = "Regresar"
        '
        'btnUndo
        '
        Me.btnUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnUndo.Image = Global.TCMAdmin.My.Resources.Resources.IconoUndo
        Me.btnUndo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnUndo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(29, 40)
        Me.btnUndo.Text = "Deshacer cambios"
        Me.btnUndo.ToolTipText = "Deshacer cambios"
        '
        'btnGuardar
        '
        Me.btnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnGuardar.Image = Global.TCMAdmin.My.Resources.Resources.IconSave
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(40, 40)
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.ToolTipText = "Guardar"
        Me.btnGuardar.Visible = False
        '
        'btnEditar
        '
        Me.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnEditar.Image = Global.TCMAdmin.My.Resources.Resources.IconEdit
        Me.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(40, 40)
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.ToolTipText = "Editar"
        Me.btnEditar.Visible = False
        '
        'btnElimina
        '
        Me.btnElimina.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnElimina.Image = Global.TCMAdmin.My.Resources.Resources.IconDelete
        Me.btnElimina.Name = "btnElimina"
        Me.btnElimina.RightToLeftAutoMirrorImage = True
        Me.btnElimina.Size = New System.Drawing.Size(40, 40)
        Me.btnElimina.Text = "Eliminar"
        Me.btnElimina.Visible = False
        '
        'btnImage
        '
        Me.btnImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnImage.Image = Global.TCMAdmin.My.Resources.Resources.IconImage
        Me.btnImage.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImage.Name = "btnImage"
        Me.btnImage.Size = New System.Drawing.Size(40, 40)
        Me.btnImage.Text = "ToolStripButton1"
        Me.btnImage.ToolTipText = "Ver imágenes"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 43)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(53, 40)
        Me.ToolStripLabel2.Text = "           "
        '
        'lblCurrentMenu
        '
        Me.lblCurrentMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentMenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCurrentMenu.Name = "lblCurrentMenu"
        Me.lblCurrentMenu.Size = New System.Drawing.Size(141, 40)
        Me.lblCurrentMenu.Text = "ToolStripLabel2"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'grpUltimoPago
        '
        Me.grpUltimoPago.Controls.Add(Me.UltraExpandableGroupBoxPanel4)
        Me.grpUltimoPago.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpUltimoPago.Enabled = False
        Me.grpUltimoPago.ExpandedSize = New System.Drawing.Size(594, 187)
        Me.grpUltimoPago.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.None
        Me.grpUltimoPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpUltimoPago.Location = New System.Drawing.Point(851, 550)
        Me.grpUltimoPago.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpUltimoPago.Name = "grpUltimoPago"
        Me.grpUltimoPago.Size = New System.Drawing.Size(594, 187)
        Me.grpUltimoPago.TabIndex = 4
        Me.grpUltimoPago.TabStop = False
        Me.grpUltimoPago.Text = "Último Pago"
        Me.grpUltimoPago.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'UltraExpandableGroupBoxPanel4
        '
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.uneUltMes)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.uneUltAnio)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.dtpFechaPago)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.UltraLabel1)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.txtNoRecibo)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.lblNumRecibo)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.lblUltAño)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.lblUltMes)
        Me.UltraExpandableGroupBoxPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel4.Location = New System.Drawing.Point(2, 25)
        Me.UltraExpandableGroupBoxPanel4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.UltraExpandableGroupBoxPanel4.Name = "UltraExpandableGroupBoxPanel4"
        Me.UltraExpandableGroupBoxPanel4.Size = New System.Drawing.Size(590, 160)
        Me.UltraExpandableGroupBoxPanel4.TabIndex = 0
        '
        'uneUltMes
        '
        Me.uneUltMes.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "ult_mes_pago", True))
        Me.uneUltMes.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uneUltMes.Location = New System.Drawing.Point(380, 5)
        Me.uneUltMes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.uneUltMes.MaxValue = 12
        Me.uneUltMes.MinValue = 1
        Me.uneUltMes.Name = "uneUltMes"
        Me.uneUltMes.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.uneUltMes.ReadOnly = True
        Me.uneUltMes.Size = New System.Drawing.Size(133, 27)
        Me.uneUltMes.TabIndex = 2
        Me.uneUltMes.Value = 12
        '
        'uneUltAnio
        '
        Me.uneUltAnio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "ult_año_pago", True))
        Me.uneUltAnio.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uneUltAnio.Location = New System.Drawing.Point(380, 38)
        Me.uneUltAnio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.uneUltAnio.MaxValue = 2050
        Me.uneUltAnio.MinValue = 0
        Me.uneUltAnio.Name = "uneUltAnio"
        Me.uneUltAnio.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.uneUltAnio.Size = New System.Drawing.Size(133, 27)
        Me.uneUltAnio.TabIndex = 3
        '
        'dtpFechaPago
        '
        Me.dtpFechaPago.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BindingSource1, "fecha_pago", True))
        Me.dtpFechaPago.DateTime = New Date(2016, 10, 7, 0, 0, 0, 0)
        Me.dtpFechaPago.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaPago.Location = New System.Drawing.Point(120, 38)
        Me.dtpFechaPago.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpFechaPago.Name = "dtpFechaPago"
        Me.dtpFechaPago.Size = New System.Drawing.Size(147, 27)
        Me.dtpFechaPago.TabIndex = 1
        Me.dtpFechaPago.Value = New Date(2016, 10, 7, 0, 0, 0, 0)
        '
        'UltraLabel1
        '
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(57, 41)
        Me.UltraLabel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(68, 25)
        Me.UltraLabel1.TabIndex = 91
        Me.UltraLabel1.Text = "Fecha:"
        Me.UltraLabel1.UseAppStyling = False
        '
        'txtNoRecibo
        '
        Me.txtNoRecibo.AlwaysInEditMode = True
        Appearance1.BackColor = System.Drawing.Color.White
        Appearance1.BackColor2 = System.Drawing.Color.White
        Me.txtNoRecibo.Appearance = Appearance1
        Me.txtNoRecibo.BackColor = System.Drawing.Color.White
        Me.txtNoRecibo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNoRecibo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "folio_recibo", True))
        Me.txtNoRecibo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtNoRecibo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoRecibo.Location = New System.Drawing.Point(120, 5)
        Me.txtNoRecibo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNoRecibo.MaxLength = 8
        Me.txtNoRecibo.Multiline = True
        Me.txtNoRecibo.Name = "txtNoRecibo"
        Me.txtNoRecibo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNoRecibo.Size = New System.Drawing.Size(147, 28)
        Me.txtNoRecibo.TabIndex = 0
        '
        'lblNumRecibo
        '
        Me.lblNumRecibo.AutoSize = True
        Me.lblNumRecibo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumRecibo.Location = New System.Drawing.Point(21, 9)
        Me.lblNumRecibo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblNumRecibo.Name = "lblNumRecibo"
        Me.lblNumRecibo.Size = New System.Drawing.Size(112, 25)
        Me.lblNumRecibo.TabIndex = 89
        Me.lblNumRecibo.Text = "No. Recibo:"
        Me.lblNumRecibo.UseAppStyling = False
        '
        'lblUltAño
        '
        Me.lblUltAño.AutoSize = True
        Me.lblUltAño.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUltAño.Location = New System.Drawing.Point(301, 43)
        Me.lblUltAño.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblUltAño.Name = "lblUltAño"
        Me.lblUltAño.Size = New System.Drawing.Size(88, 25)
        Me.lblUltAño.TabIndex = 77
        Me.lblUltAño.Text = "Últ. Año:"
        Me.lblUltAño.UseAppStyling = False
        '
        'lblUltMes
        '
        Me.lblUltMes.AutoSize = True
        Me.lblUltMes.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUltMes.Location = New System.Drawing.Point(301, 10)
        Me.lblUltMes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblUltMes.Name = "lblUltMes"
        Me.lblUltMes.Size = New System.Drawing.Size(88, 25)
        Me.lblUltMes.TabIndex = 76
        Me.lblUltMes.Text = "Últ. Mes:"
        Me.lblUltMes.UseAppStyling = False
        '
        'grpPAE
        '
        Me.grpPAE.Controls.Add(Me.UltraExpandableGroupBoxPanel3)
        Me.grpPAE.Dock = System.Windows.Forms.DockStyle.Left
        Me.grpPAE.Enabled = False
        Me.grpPAE.ExpandedSize = New System.Drawing.Size(851, 187)
        Me.grpPAE.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.None
        Me.grpPAE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPAE.Location = New System.Drawing.Point(0, 550)
        Me.grpPAE.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpPAE.Name = "grpPAE"
        Me.grpPAE.Size = New System.Drawing.Size(851, 187)
        Me.grpPAE.TabIndex = 3
        Me.grpPAE.TabStop = False
        Me.grpPAE.Text = "PAE"
        Me.grpPAE.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'UltraExpandableGroupBoxPanel3
        '
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.chkNotificado)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.panNotificado)
        Me.UltraExpandableGroupBoxPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel3.Location = New System.Drawing.Point(2, 25)
        Me.UltraExpandableGroupBoxPanel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.UltraExpandableGroupBoxPanel3.Name = "UltraExpandableGroupBoxPanel3"
        Me.UltraExpandableGroupBoxPanel3.Size = New System.Drawing.Size(847, 160)
        Me.UltraExpandableGroupBoxPanel3.TabIndex = 0
        '
        'chkNotificado
        '
        Me.chkNotificado.AutoSize = True
        Me.chkNotificado.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkNotificado.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.BindingSource1, "notificado", True))
        Me.chkNotificado.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNotificado.Location = New System.Drawing.Point(73, 9)
        Me.chkNotificado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkNotificado.Name = "chkNotificado"
        Me.chkNotificado.Size = New System.Drawing.Size(103, 22)
        Me.chkNotificado.TabIndex = 2
        Me.chkNotificado.Text = "Notificado: "
        Me.chkNotificado.UseVisualStyleBackColor = True
        '
        'panNotificado
        '
        Me.panNotificado.Controls.Add(Me.txtNoActos)
        Me.panNotificado.Controls.Add(Me.ucoPae)
        Me.panNotificado.Controls.Add(Me.lblPae)
        Me.panNotificado.Controls.Add(Me.lblFechaPae)
        Me.panNotificado.Controls.Add(Me.txtNoOficioPae)
        Me.panNotificado.Controls.Add(Me.txtFecPAE)
        Me.panNotificado.Controls.Add(Me.lblNoPAe)
        Me.panNotificado.Controls.Add(Me.lblNoActosPAe)
        Me.panNotificado.Enabled = False
        Me.panNotificado.Location = New System.Drawing.Point(136, 4)
        Me.panNotificado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.panNotificado.Name = "panNotificado"
        Me.panNotificado.Size = New System.Drawing.Size(625, 70)
        Me.panNotificado.TabIndex = 3
        '
        'txtNoActos
        '
        Me.txtNoActos.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BindingSource1, "num_actos", True))
        Me.txtNoActos.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoActos.Location = New System.Drawing.Point(483, 37)
        Me.txtNoActos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNoActos.MaskInput = "999"
        Me.txtNoActos.Name = "txtNoActos"
        Me.txtNoActos.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtNoActos.Size = New System.Drawing.Size(68, 27)
        Me.txtNoActos.TabIndex = 3
        '
        'ucoPae
        '
        Appearance2.FontData.BoldAsString = "True"
        Appearance2.FontData.Name = "Tahoma"
        Appearance2.FontData.SizeInPoints = 9.0!
        Me.ucoPae.Appearance = Appearance2
        Me.ucoPae.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.ucoPae.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains
        Me.ucoPae.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BindingSource1, "pae", True))
        UltraGridBand1.ColHeadersVisible = False
        UltraGridColumn1.Header.Editor = Nothing
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.Editor = Nothing
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 161
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2})
        Me.ucoPae.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ucoPae.DisplayMember = "Descricion"
        Me.ucoPae.DropDownResizeHandleStyle = Infragistics.Win.DropDownResizeHandleStyle.VerticalResize
        Me.ucoPae.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ucoPae.Location = New System.Drawing.Point(133, 4)
        Me.ucoPae.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ucoPae.MaxDropDownItems = 30
        Me.ucoPae.Name = "ucoPae"
        Me.ucoPae.NullText = "Seleccione..."
        Me.ucoPae.Size = New System.Drawing.Size(215, 28)
        Me.ucoPae.TabIndex = 0
        Me.ucoPae.ValueMember = "cve_tip_con"
        '
        'lblPae
        '
        Me.lblPae.AutoSize = True
        Me.lblPae.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPae.Location = New System.Drawing.Point(67, 7)
        Me.lblPae.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblPae.Name = "lblPae"
        Me.lblPae.Size = New System.Drawing.Size(67, 25)
        Me.lblPae.TabIndex = 99
        Me.lblPae.Text = "Etapa:"
        Me.lblPae.UseAppStyling = False
        '
        'lblFechaPae
        '
        Me.lblFechaPae.AutoSize = True
        Me.lblFechaPae.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaPae.Location = New System.Drawing.Point(379, 9)
        Me.lblFechaPae.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblFechaPae.Name = "lblFechaPae"
        Me.lblFechaPae.Size = New System.Drawing.Size(113, 25)
        Me.lblFechaPae.TabIndex = 99
        Me.lblFechaPae.Text = "Fecha acto:"
        Me.lblFechaPae.UseAppStyling = False
        '
        'txtNoOficioPae
        '
        Me.txtNoOficioPae.AlwaysInEditMode = True
        Appearance3.BackColor = System.Drawing.Color.White
        Appearance3.BackColor2 = System.Drawing.Color.White
        Me.txtNoOficioPae.Appearance = Appearance3
        Me.txtNoOficioPae.BackColor = System.Drawing.Color.White
        Me.txtNoOficioPae.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNoOficioPae.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "num_noti", True))
        Me.txtNoOficioPae.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtNoOficioPae.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoOficioPae.Location = New System.Drawing.Point(133, 37)
        Me.txtNoOficioPae.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNoOficioPae.MaxLength = 30
        Me.txtNoOficioPae.Name = "txtNoOficioPae"
        Me.txtNoOficioPae.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNoOficioPae.Size = New System.Drawing.Size(215, 27)
        Me.txtNoOficioPae.TabIndex = 1
        '
        'txtFecPAE
        '
        Me.txtFecPAE.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BindingSource1, "fecha_noti", True))
        Me.txtFecPAE.DateTime = New Date(2016, 10, 7, 0, 0, 0, 0)
        Me.txtFecPAE.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecPAE.Location = New System.Drawing.Point(483, 5)
        Me.txtFecPAE.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFecPAE.Name = "txtFecPAE"
        Me.txtFecPAE.Size = New System.Drawing.Size(133, 27)
        Me.txtFecPAE.TabIndex = 2
        Me.txtFecPAE.Value = New Date(2016, 10, 7, 0, 0, 0, 0)
        '
        'lblNoPAe
        '
        Appearance4.TextHAlignAsString = "Right"
        Me.lblNoPAe.Appearance = Appearance4
        Me.lblNoPAe.AutoSize = True
        Me.lblNoPAe.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoPAe.Location = New System.Drawing.Point(4, 41)
        Me.lblNoPAe.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblNoPAe.Name = "lblNoPAe"
        Me.lblNoPAe.Size = New System.Drawing.Size(144, 25)
        Me.lblNoPAe.TabIndex = 47
        Me.lblNoPAe.Text = "Oficio Número:"
        Me.lblNoPAe.UseAppStyling = False
        '
        'lblNoActosPAe
        '
        Me.lblNoActosPAe.AutoSize = True
        Me.lblNoActosPAe.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoActosPAe.Location = New System.Drawing.Point(367, 42)
        Me.lblNoActosPAe.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblNoActosPAe.Name = "lblNoActosPAe"
        Me.lblNoActosPAe.Size = New System.Drawing.Size(128, 25)
        Me.lblNoActosPAe.TabIndex = 48
        Me.lblNoActosPAe.Text = "No. de actos:"
        Me.lblNoActosPAe.UseAppStyling = False
        '
        'grpPropietario
        '
        Me.grpPropietario.Controls.Add(Me.UltraExpandableGroupBoxPanel2)
        Me.grpPropietario.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpPropietario.Enabled = False
        Me.grpPropietario.ExpandedSize = New System.Drawing.Size(1445, 271)
        Me.grpPropietario.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.None
        Me.grpPropietario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPropietario.Location = New System.Drawing.Point(0, 279)
        Me.grpPropietario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpPropietario.Name = "grpPropietario"
        Me.grpPropietario.Size = New System.Drawing.Size(1445, 271)
        Me.grpPropietario.TabIndex = 2
        Me.grpPropietario.TabStop = False
        Me.grpPropietario.Text = "Datos del Responsable"
        Me.grpPropietario.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'UltraExpandableGroupBoxPanel2
        '
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.lblCorreo)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.txtemail)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.txtCurp)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.lblCurp)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.txtRfc)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.txtTel)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.lblTelefono)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.txtCalle)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.UltraLabel3)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.txtCP)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.ucoColonia)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.txtNoInt)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.txtNoExt)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.lblCP)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.lblObs)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.lblResponsable)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.lblRFC)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.ucoLocalidad)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.txtObservaciones)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.txtResponsable)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.txtDomicilio)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.txtNombre)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.lblNoInterior)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.lblNombre)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.lblDomicilio)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.lblLocalidad)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.lblColonia)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.lblNoExt)
        Me.UltraExpandableGroupBoxPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel2.Location = New System.Drawing.Point(2, 25)
        Me.UltraExpandableGroupBoxPanel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.UltraExpandableGroupBoxPanel2.Name = "UltraExpandableGroupBoxPanel2"
        Me.UltraExpandableGroupBoxPanel2.Size = New System.Drawing.Size(1441, 244)
        Me.UltraExpandableGroupBoxPanel2.TabIndex = 0
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorreo.Location = New System.Drawing.Point(903, 177)
        Me.lblCorreo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCorreo.Size = New System.Drawing.Size(75, 25)
        Me.lblCorreo.TabIndex = 189
        Me.lblCorreo.Text = "Correo:"
        Me.lblCorreo.UseAppStyling = False
        '
        'txtemail
        '
        Appearance5.BackColor = System.Drawing.Color.White
        Appearance5.BackColor2 = System.Drawing.Color.White
        Me.txtemail.Appearance = Appearance5
        Me.txtemail.BackColor = System.Drawing.Color.White
        Me.txtemail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtemail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "correoe", True))
        Me.txtemail.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtemail.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemail.Location = New System.Drawing.Point(971, 172)
        Me.txtemail.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtemail.MaxLength = 100
        Me.txtemail.Name = "txtemail"
        Me.txtemail.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtemail.Size = New System.Drawing.Size(393, 27)
        Me.txtemail.TabIndex = 174
        '
        'txtCurp
        '
        Appearance6.FontData.BoldAsString = "True"
        Appearance6.FontData.Name = "Tahoma"
        Appearance6.FontData.SizeInPoints = 9.0!
        Me.txtCurp.Appearance = Appearance6
        Me.txtCurp.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.txtCurp.InputMask = ">????######??????AA"
        Me.txtCurp.Location = New System.Drawing.Point(1171, 39)
        Me.txtCurp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCurp.Name = "txtCurp"
        Me.txtCurp.NonAutoSizeHeight = 22
        Me.txtCurp.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtCurp.Size = New System.Drawing.Size(193, 26)
        Me.txtCurp.TabIndex = 165
        Me.txtCurp.UseAppStyling = False
        '
        'lblCurp
        '
        Me.lblCurp.AutoSize = True
        Me.lblCurp.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurp.Location = New System.Drawing.Point(1107, 43)
        Me.lblCurp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblCurp.Name = "lblCurp"
        Me.lblCurp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCurp.Size = New System.Drawing.Size(64, 25)
        Me.lblCurp.TabIndex = 188
        Me.lblCurp.Text = "CURP:"
        '
        'txtRfc
        '
        Me.txtRfc.AlwaysInEditMode = True
        Appearance7.BackColor = System.Drawing.Color.White
        Appearance7.BackColor2 = System.Drawing.Color.White
        Me.txtRfc.Appearance = Appearance7
        Me.txtRfc.BackColor = System.Drawing.Color.White
        Me.txtRfc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRfc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "rfc", True))
        Me.txtRfc.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtRfc.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRfc.Location = New System.Drawing.Point(1171, 6)
        Me.txtRfc.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtRfc.MaxLength = 13
        Me.txtRfc.Name = "txtRfc"
        Me.txtRfc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtRfc.Size = New System.Drawing.Size(193, 27)
        Me.txtRfc.TabIndex = 163
        '
        'txtTel
        '
        Appearance8.FontData.BoldAsString = "True"
        Appearance8.FontData.Name = "Tahoma"
        Appearance8.FontData.SizeInPoints = 9.0!
        Me.txtTel.Appearance = Appearance8
        Me.txtTel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "telefono", True))
        Me.txtTel.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.txtTel.InputMask = ">########aa"
        Me.txtTel.Location = New System.Drawing.Point(1217, 137)
        Me.txtTel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.NonAutoSizeHeight = 22
        Me.txtTel.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtTel.Size = New System.Drawing.Size(147, 26)
        Me.txtTel.TabIndex = 172
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(1135, 142)
        Me.lblTelefono.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(93, 25)
        Me.lblTelefono.TabIndex = 187
        Me.lblTelefono.Text = "Teléfono:"
        Me.lblTelefono.UseAppStyling = False
        '
        'txtCalle
        '
        Me.txtCalle.AlwaysInEditMode = True
        Appearance9.BackColor = System.Drawing.Color.White
        Appearance9.BackColor2 = System.Drawing.Color.White
        Me.txtCalle.Appearance = Appearance9
        Me.txtCalle.BackColor = System.Drawing.Color.White
        Me.txtCalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCalle.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "calle", True))
        Me.txtCalle.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtCalle.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCalle.Location = New System.Drawing.Point(268, 73)
        Me.txtCalle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCalle.MaxLength = 25
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCalle.Size = New System.Drawing.Size(579, 27)
        Me.txtCalle.TabIndex = 166
        '
        'UltraLabel3
        '
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(208, 76)
        Me.UltraLabel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(59, 25)
        Me.UltraLabel3.TabIndex = 186
        Me.UltraLabel3.Text = "Calle:"
        Me.UltraLabel3.UseAppStyling = False
        '
        'txtCP
        '
        Appearance10.FontData.BoldAsString = "True"
        Appearance10.FontData.Name = "Tahoma"
        Appearance10.FontData.SizeInPoints = 9.0!
        Me.txtCP.Appearance = Appearance10
        Me.txtCP.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "cod_postal", True))
        Me.txtCP.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.txtCP.InputMask = "#####"
        Me.txtCP.Location = New System.Drawing.Point(971, 106)
        Me.txtCP.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCP.Name = "txtCP"
        Me.txtCP.NonAutoSizeHeight = 22
        Me.txtCP.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtCP.Size = New System.Drawing.Size(111, 26)
        Me.txtCP.TabIndex = 170
        '
        'ucoColonia
        '
        Appearance11.FontData.BoldAsString = "True"
        Appearance11.FontData.Name = "Tahoma"
        Appearance11.FontData.SizeInPoints = 9.0!
        Me.ucoColonia.Appearance = Appearance11
        Me.ucoColonia.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.ucoColonia.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains
        Me.ucoColonia.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BindingSource1, "cve_col", True))
        UltraGridBand2.ColHeadersVisible = False
        UltraGridColumn5.Header.Editor = Nothing
        UltraGridColumn5.Header.VisiblePosition = 0
        UltraGridColumn5.Hidden = True
        UltraGridColumn6.Header.Editor = Nothing
        UltraGridColumn6.Header.VisiblePosition = 1
        UltraGridColumn6.Width = 435
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn5, UltraGridColumn6})
        Me.ucoColonia.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.ucoColonia.DisplayMember = "nom_colonia"
        Me.ucoColonia.DropDownResizeHandleStyle = Infragistics.Win.DropDownResizeHandleStyle.VerticalResize
        Me.ucoColonia.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ucoColonia.Location = New System.Drawing.Point(268, 139)
        Me.ucoColonia.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ucoColonia.MaxDropDownItems = 30
        Me.ucoColonia.Name = "ucoColonia"
        Me.ucoColonia.NullText = "Seleccione..."
        Me.ucoColonia.Size = New System.Drawing.Size(579, 28)
        Me.ucoColonia.TabIndex = 171
        Me.ucoColonia.ValueMember = "id_colonia"
        '
        'txtNoInt
        '
        Me.txtNoInt.AlwaysInEditMode = True
        Appearance12.BackColor = System.Drawing.Color.White
        Appearance12.BackColor2 = System.Drawing.Color.White
        Me.txtNoInt.Appearance = Appearance12
        Me.txtNoInt.BackColor = System.Drawing.Color.White
        Me.txtNoInt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNoInt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "no_int", True))
        Me.txtNoInt.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtNoInt.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoInt.Location = New System.Drawing.Point(1217, 73)
        Me.txtNoInt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNoInt.MaxLength = 5
        Me.txtNoInt.Name = "txtNoInt"
        Me.txtNoInt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNoInt.Size = New System.Drawing.Size(147, 27)
        Me.txtNoInt.TabIndex = 168
        '
        'txtNoExt
        '
        Me.txtNoExt.AlwaysInEditMode = True
        Appearance13.BackColor = System.Drawing.Color.White
        Appearance13.BackColor2 = System.Drawing.Color.White
        Me.txtNoExt.Appearance = Appearance13
        Me.txtNoExt.BackColor = System.Drawing.Color.White
        Me.txtNoExt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNoExt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "no_ext", True))
        Me.txtNoExt.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtNoExt.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoExt.Location = New System.Drawing.Point(971, 73)
        Me.txtNoExt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNoExt.MaxLength = 5
        Me.txtNoExt.Name = "txtNoExt"
        Me.txtNoExt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNoExt.Size = New System.Drawing.Size(111, 27)
        Me.txtNoExt.TabIndex = 167
        '
        'lblCP
        '
        Me.lblCP.AutoSize = True
        Me.lblCP.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCP.Location = New System.Drawing.Point(921, 110)
        Me.lblCP.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblCP.Name = "lblCP"
        Me.lblCP.Size = New System.Drawing.Size(51, 25)
        Me.lblCP.TabIndex = 185
        Me.lblCP.Text = "C.P.:"
        Me.lblCP.UseAppStyling = False
        '
        'lblObs
        '
        Me.lblObs.AutoSize = True
        Me.lblObs.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObs.Location = New System.Drawing.Point(137, 209)
        Me.lblObs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblObs.Name = "lblObs"
        Me.lblObs.Size = New System.Drawing.Size(147, 25)
        Me.lblObs.TabIndex = 184
        Me.lblObs.Text = "Observaciones:"
        Me.lblObs.UseAppStyling = False
        '
        'lblResponsable
        '
        Me.lblResponsable.AutoSize = True
        Me.lblResponsable.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResponsable.Location = New System.Drawing.Point(152, 176)
        Me.lblResponsable.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblResponsable.Name = "lblResponsable"
        Me.lblResponsable.Size = New System.Drawing.Size(128, 25)
        Me.lblResponsable.TabIndex = 183
        Me.lblResponsable.Text = "Responsable:"
        Me.lblResponsable.UseAppStyling = False
        '
        'lblRFC
        '
        Me.lblRFC.AutoSize = True
        Me.lblRFC.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRFC.Location = New System.Drawing.Point(1103, 10)
        Me.lblRFC.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblRFC.Name = "lblRFC"
        Me.lblRFC.Size = New System.Drawing.Size(69, 25)
        Me.lblRFC.TabIndex = 182
        Me.lblRFC.Text = "R.F.C.:"
        Me.lblRFC.UseAppStyling = False
        '
        'ucoLocalidad
        '
        Appearance14.FontData.BoldAsString = "True"
        Appearance14.FontData.Name = "Tahoma"
        Appearance14.FontData.SizeInPoints = 9.0!
        Me.ucoLocalidad.Appearance = Appearance14
        Me.ucoLocalidad.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.ucoLocalidad.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains
        Me.ucoLocalidad.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BindingSource1, "cve_loc", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        UltraGridBand3.ColHeadersVisible = False
        UltraGridColumn7.Header.Editor = Nothing
        UltraGridColumn7.Header.VisiblePosition = 0
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.Header.Editor = Nothing
        UltraGridColumn8.Header.VisiblePosition = 1
        UltraGridColumn8.Width = 435
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn7, UltraGridColumn8})
        Me.ucoLocalidad.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.ucoLocalidad.DisplayLayout.Override.NullText = "Seleccione..."
        Me.ucoLocalidad.DisplayMember = "nombre"
        Me.ucoLocalidad.DropDownResizeHandleStyle = Infragistics.Win.DropDownResizeHandleStyle.VerticalResize
        Me.ucoLocalidad.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ucoLocalidad.Location = New System.Drawing.Point(268, 106)
        Me.ucoLocalidad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ucoLocalidad.MaxDropDownItems = 30
        Me.ucoLocalidad.Name = "ucoLocalidad"
        Me.ucoLocalidad.NullText = "Seleccione..."
        Me.ucoLocalidad.Size = New System.Drawing.Size(579, 28)
        Me.ucoLocalidad.TabIndex = 169
        Me.ucoLocalidad.ValueMember = "clave"
        '
        'txtObservaciones
        '
        Appearance15.BackColor = System.Drawing.Color.White
        Appearance15.BackColor2 = System.Drawing.Color.White
        Me.txtObservaciones.Appearance = Appearance15
        Me.txtObservaciones.BackColor = System.Drawing.Color.White
        Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservaciones.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "observacion", True))
        Me.txtObservaciones.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtObservaciones.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(268, 207)
        Me.txtObservaciones.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtObservaciones.MaxLength = 150
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtObservaciones.Size = New System.Drawing.Size(1096, 27)
        Me.txtObservaciones.TabIndex = 175
        '
        'txtResponsable
        '
        Me.txtResponsable.AlwaysInEditMode = True
        Appearance16.BackColor = System.Drawing.Color.White
        Appearance16.BackColor2 = System.Drawing.Color.White
        Me.txtResponsable.Appearance = Appearance16
        Me.txtResponsable.BackColor = System.Drawing.Color.White
        Me.txtResponsable.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtResponsable.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "responsable", True))
        Me.txtResponsable.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtResponsable.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResponsable.Location = New System.Drawing.Point(268, 172)
        Me.txtResponsable.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtResponsable.MaxLength = 120
        Me.txtResponsable.Multiline = True
        Me.txtResponsable.Name = "txtResponsable"
        Me.txtResponsable.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtResponsable.Size = New System.Drawing.Size(579, 28)
        Me.txtResponsable.TabIndex = 173
        '
        'txtDomicilio
        '
        Appearance17.BackColor = System.Drawing.Color.White
        Appearance17.BackColor2 = System.Drawing.Color.White
        Me.txtDomicilio.Appearance = Appearance17
        Me.txtDomicilio.BackColor = System.Drawing.Color.White
        Me.txtDomicilio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDomicilio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "domicilio_fiscal", True))
        Me.txtDomicilio.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtDomicilio.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDomicilio.Location = New System.Drawing.Point(268, 39)
        Me.txtDomicilio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDomicilio.MaxLength = 120
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDomicilio.Size = New System.Drawing.Size(813, 27)
        Me.txtDomicilio.TabIndex = 164
        '
        'txtNombre
        '
        Me.txtNombre.AlwaysInEditMode = True
        Appearance18.BackColor = System.Drawing.Color.White
        Appearance18.BackColor2 = System.Drawing.Color.White
        Me.txtNombre.Appearance = Appearance18
        Me.txtNombre.BackColor = System.Drawing.Color.White
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "nombre", True))
        Me.txtNombre.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtNombre.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(268, 6)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNombre.MaxLength = 120
        Me.txtNombre.Multiline = True
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNombre.Size = New System.Drawing.Size(813, 28)
        Me.txtNombre.TabIndex = 162
        '
        'lblNoInterior
        '
        Me.lblNoInterior.AutoSize = True
        Me.lblNoInterior.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoInterior.Location = New System.Drawing.Point(1108, 76)
        Me.lblNoInterior.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblNoInterior.Name = "lblNoInterior"
        Me.lblNoInterior.Size = New System.Drawing.Size(127, 25)
        Me.lblNoInterior.TabIndex = 181
        Me.lblNoInterior.Text = "No. Interior :"
        Me.lblNoInterior.UseAppStyling = False
        '
        'lblNombre
        '
        Appearance19.TextHAlignAsString = "Center"
        Me.lblNombre.Appearance = Appearance19
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(75, 10)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(225, 25)
        Me.lblNombre.TabIndex = 176
        Me.lblNombre.Text = "Nombre ó Razón Social:"
        Me.lblNombre.UseAppStyling = False
        '
        'lblDomicilio
        '
        Me.lblDomicilio.AutoSize = True
        Me.lblDomicilio.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDomicilio.Location = New System.Drawing.Point(132, 43)
        Me.lblDomicilio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblDomicilio.Name = "lblDomicilio"
        Me.lblDomicilio.Size = New System.Drawing.Size(153, 25)
        Me.lblDomicilio.TabIndex = 177
        Me.lblDomicilio.Text = "Domicilio Fiscal:"
        Me.lblDomicilio.UseAppStyling = False
        '
        'lblLocalidad
        '
        Me.lblLocalidad.AutoSize = True
        Me.lblLocalidad.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocalidad.Location = New System.Drawing.Point(175, 110)
        Me.lblLocalidad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblLocalidad.Name = "lblLocalidad"
        Me.lblLocalidad.Size = New System.Drawing.Size(100, 25)
        Me.lblLocalidad.TabIndex = 178
        Me.lblLocalidad.Text = "Localidad:"
        Me.lblLocalidad.UseAppStyling = False
        '
        'lblColonia
        '
        Me.lblColonia.AutoSize = True
        Me.lblColonia.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColonia.Location = New System.Drawing.Point(189, 144)
        Me.lblColonia.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblColonia.Name = "lblColonia"
        Me.lblColonia.Size = New System.Drawing.Size(81, 25)
        Me.lblColonia.TabIndex = 179
        Me.lblColonia.Text = "Colonia:"
        Me.lblColonia.UseAppStyling = False
        '
        'lblNoExt
        '
        Me.lblNoExt.AutoSize = True
        Me.lblNoExt.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoExt.Location = New System.Drawing.Point(864, 76)
        Me.lblNoExt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblNoExt.Name = "lblNoExt"
        Me.lblNoExt.Size = New System.Drawing.Size(123, 25)
        Me.lblNoExt.TabIndex = 180
        Me.lblNoExt.Text = "No. Exterior:"
        Me.lblNoExt.UseAppStyling = False
        '
        'grpDatosCuenta
        '
        Me.grpDatosCuenta.Controls.Add(Me.UltraExpandableGroupBoxPanel1)
        Me.grpDatosCuenta.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpDatosCuenta.Enabled = False
        Me.grpDatosCuenta.ExpandedSize = New System.Drawing.Size(1445, 236)
        Me.grpDatosCuenta.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.None
        Me.grpDatosCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDatosCuenta.Location = New System.Drawing.Point(0, 43)
        Me.grpDatosCuenta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpDatosCuenta.Name = "grpDatosCuenta"
        Me.grpDatosCuenta.Size = New System.Drawing.Size(1445, 236)
        Me.grpDatosCuenta.TabIndex = 1
        Me.grpDatosCuenta.TabStop = False
        Me.grpDatosCuenta.Text = "Cuenta"
        Me.grpDatosCuenta.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'UltraExpandableGroupBoxPanel1
        '
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.gruTipoDeposito)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.uneDimension)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.txtUbicacionDeposito)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.txtFechaIniOp)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.lblIniciRecargo)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.ucoStatus)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.ucoTipoContribuyente)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.lblDimension)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.lblContribuyente)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.lblStatus)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.lblCuenta)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.lblActividad)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.txtNoLic)
        Me.UltraExpandableGroupBoxPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel1.Location = New System.Drawing.Point(2, 25)
        Me.UltraExpandableGroupBoxPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.UltraExpandableGroupBoxPanel1.Name = "UltraExpandableGroupBoxPanel1"
        Me.UltraExpandableGroupBoxPanel1.Size = New System.Drawing.Size(1441, 209)
        Me.UltraExpandableGroupBoxPanel1.TabIndex = 0
        '
        'gruTipoDeposito
        '
        Me.gruTipoDeposito.Controls.Add(Me.optTipoDeposito)
        Me.gruTipoDeposito.Location = New System.Drawing.Point(940, 27)
        Me.gruTipoDeposito.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gruTipoDeposito.Name = "gruTipoDeposito"
        Me.gruTipoDeposito.Size = New System.Drawing.Size(424, 170)
        Me.gruTipoDeposito.TabIndex = 5
        Me.gruTipoDeposito.Text = "Tipo de depósito"
        '
        'optTipoDeposito
        '
        Me.optTipoDeposito.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BindingSource1, "largo", True))
        ValueListItem1.DataValue = "1"
        ValueListItem1.DisplayText = "Cripta"
        ValueListItem2.DataValue = "2"
        ValueListItem2.DisplayText = "Capilla"
        ValueListItem3.DataValue = "3"
        ValueListItem3.DisplayText = "Urna"
        ValueListItem4.DataValue = "4"
        ValueListItem4.DisplayText = "Fosa"
        ValueListItem5.DataValue = "5"
        ValueListItem5.DisplayText = "Mausoleo"
        Me.optTipoDeposito.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2, ValueListItem3, ValueListItem4, ValueListItem5})
        Me.optTipoDeposito.ItemSpacingHorizontal = 50
        Me.optTipoDeposito.ItemSpacingVertical = 10
        Me.optTipoDeposito.Location = New System.Drawing.Point(63, 36)
        Me.optTipoDeposito.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.optTipoDeposito.Name = "optTipoDeposito"
        Me.optTipoDeposito.Size = New System.Drawing.Size(285, 114)
        Me.optTipoDeposito.TabIndex = 103
        '
        'uneDimension
        '
        Me.uneDimension.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "dimension", True))
        Me.uneDimension.Font = New System.Drawing.Font("Tahoma", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uneDimension.Location = New System.Drawing.Point(268, 167)
        Me.uneDimension.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.uneDimension.MinValue = 0R
        Me.uneDimension.Name = "uneDimension"
        Me.uneDimension.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.uneDimension.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.uneDimension.Size = New System.Drawing.Size(177, 29)
        Me.uneDimension.TabIndex = 3
        '
        'txtUbicacionDeposito
        '
        Me.txtUbicacionDeposito.AlwaysInEditMode = True
        Appearance20.BackColor = System.Drawing.Color.White
        Appearance20.BackColor2 = System.Drawing.Color.White
        Me.txtUbicacionDeposito.Appearance = Appearance20
        Me.txtUbicacionDeposito.BackColor = System.Drawing.Color.White
        Me.txtUbicacionDeposito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUbicacionDeposito.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "giro", True))
        Me.txtUbicacionDeposito.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtUbicacionDeposito.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUbicacionDeposito.Location = New System.Drawing.Point(268, 62)
        Me.txtUbicacionDeposito.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtUbicacionDeposito.MaxLength = 90
        Me.txtUbicacionDeposito.Name = "txtUbicacionDeposito"
        Me.txtUbicacionDeposito.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtUbicacionDeposito.Size = New System.Drawing.Size(579, 27)
        Me.txtUbicacionDeposito.TabIndex = 0
        '
        'txtFechaIniOp
        '
        Me.txtFechaIniOp.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BindingSource1, "fecha_ini_oper", True))
        Me.txtFechaIniOp.DateTime = New Date(2016, 10, 7, 0, 0, 0, 0)
        Me.txtFechaIniOp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaIniOp.Location = New System.Drawing.Point(715, 169)
        Me.txtFechaIniOp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFechaIniOp.Name = "txtFechaIniOp"
        Me.txtFechaIniOp.Size = New System.Drawing.Size(132, 26)
        Me.txtFechaIniOp.TabIndex = 4
        Me.txtFechaIniOp.Value = New Date(2016, 10, 7, 0, 0, 0, 0)
        '
        'lblIniciRecargo
        '
        Me.lblIniciRecargo.AutoSize = True
        Me.lblIniciRecargo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIniciRecargo.Location = New System.Drawing.Point(608, 172)
        Me.lblIniciRecargo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblIniciRecargo.Name = "lblIniciRecargo"
        Me.lblIniciRecargo.Size = New System.Drawing.Size(124, 25)
        Me.lblIniciRecargo.TabIndex = 100
        Me.lblIniciRecargo.Text = "Fecha Inicio:"
        Me.lblIniciRecargo.UseAppStyling = False
        '
        'ucoStatus
        '
        Appearance21.FontData.BoldAsString = "True"
        Appearance21.FontData.Name = "Tahoma"
        Appearance21.FontData.SizeInPoints = 9.0!
        Me.ucoStatus.Appearance = Appearance21
        Me.ucoStatus.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.ucoStatus.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains
        Me.ucoStatus.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BindingSource1, "status", True))
        UltraGridBand4.ColHeadersVisible = False
        UltraGridColumn9.Header.Editor = Nothing
        UltraGridColumn9.Header.VisiblePosition = 0
        UltraGridColumn9.Hidden = True
        UltraGridColumn10.Header.Editor = Nothing
        UltraGridColumn10.Header.VisiblePosition = 1
        UltraGridColumn10.Width = 434
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn9, UltraGridColumn10})
        Me.ucoStatus.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.ucoStatus.DisplayMember = "descripcion"
        Me.ucoStatus.DropDownResizeHandleStyle = Infragistics.Win.DropDownResizeHandleStyle.VerticalResize
        Me.ucoStatus.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ucoStatus.Location = New System.Drawing.Point(268, 130)
        Me.ucoStatus.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ucoStatus.MaxDropDownItems = 30
        Me.ucoStatus.Name = "ucoStatus"
        Me.ucoStatus.NullText = "Seleccione..."
        Me.ucoStatus.Size = New System.Drawing.Size(579, 28)
        Me.ucoStatus.TabIndex = 2
        Me.ucoStatus.ValueMember = "cve_status"
        '
        'ucoTipoContribuyente
        '
        Appearance22.FontData.BoldAsString = "True"
        Appearance22.FontData.Name = "Tahoma"
        Appearance22.FontData.SizeInPoints = 9.0!
        Me.ucoTipoContribuyente.Appearance = Appearance22
        Me.ucoTipoContribuyente.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.ucoTipoContribuyente.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains
        Me.ucoTipoContribuyente.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BindingSource1, "cve_tip_con", True))
        UltraGridBand5.ColHeadersVisible = False
        UltraGridColumn11.Header.Editor = Nothing
        UltraGridColumn11.Header.VisiblePosition = 0
        UltraGridColumn11.Hidden = True
        UltraGridColumn12.Header.Editor = Nothing
        UltraGridColumn12.Header.VisiblePosition = 1
        UltraGridColumn12.Width = 434
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn11, UltraGridColumn12})
        Me.ucoTipoContribuyente.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Me.ucoTipoContribuyente.DisplayMember = "Descricion"
        Me.ucoTipoContribuyente.DropDownResizeHandleStyle = Infragistics.Win.DropDownResizeHandleStyle.VerticalResize
        Me.ucoTipoContribuyente.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ucoTipoContribuyente.Location = New System.Drawing.Point(268, 97)
        Me.ucoTipoContribuyente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ucoTipoContribuyente.MaxDropDownItems = 30
        Me.ucoTipoContribuyente.Name = "ucoTipoContribuyente"
        Me.ucoTipoContribuyente.NullText = "Seleccione..."
        Me.ucoTipoContribuyente.Size = New System.Drawing.Size(579, 28)
        Me.ucoTipoContribuyente.TabIndex = 1
        Me.ucoTipoContribuyente.ValueMember = "cve_tip_con"
        '
        'lblDimension
        '
        Me.lblDimension.AutoSize = True
        Me.lblDimension.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDimension.Location = New System.Drawing.Point(17, 170)
        Me.lblDimension.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblDimension.Name = "lblDimension"
        Me.lblDimension.Size = New System.Drawing.Size(296, 25)
        Me.lblDimension.TabIndex = 70
        Me.lblDimension.Text = "Dimensión Unidad del depósito:"
        Me.lblDimension.UseAppStyling = False
        '
        'lblContribuyente
        '
        Me.lblContribuyente.AutoSize = True
        Me.lblContribuyente.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContribuyente.Location = New System.Drawing.Point(141, 102)
        Me.lblContribuyente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblContribuyente.Name = "lblContribuyente"
        Me.lblContribuyente.Size = New System.Drawing.Size(141, 25)
        Me.lblContribuyente.TabIndex = 56
        Me.lblContribuyente.Text = "Contribuyente:"
        Me.lblContribuyente.UseAppStyling = False
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(197, 133)
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(72, 25)
        Me.lblStatus.TabIndex = 57
        Me.lblStatus.Text = "Status:"
        Me.lblStatus.UseAppStyling = False
        '
        'lblCuenta
        '
        Me.lblCuenta.AutoSize = True
        Me.lblCuenta.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuenta.Location = New System.Drawing.Point(204, 28)
        Me.lblCuenta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblCuenta.Name = "lblCuenta"
        Me.lblCuenta.Size = New System.Drawing.Size(64, 25)
        Me.lblCuenta.TabIndex = 59
        Me.lblCuenta.Text = "Clave:"
        Me.lblCuenta.UseAppStyling = False
        '
        'lblActividad
        '
        Me.lblActividad.AutoSize = True
        Me.lblActividad.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActividad.Location = New System.Drawing.Point(80, 69)
        Me.lblActividad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblActividad.Name = "lblActividad"
        Me.lblActividad.Size = New System.Drawing.Size(217, 25)
        Me.lblActividad.TabIndex = 61
        Me.lblActividad.Text = "Ubicación del depósito:"
        Me.lblActividad.UseAppStyling = False
        '
        'txtNoLic
        '
        Me.txtNoLic.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "cve_licencia", True))
        Me.txtNoLic.Enabled = False
        Me.txtNoLic.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoLic.Location = New System.Drawing.Point(268, 21)
        Me.txtNoLic.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNoLic.Mask = "LL-000000"
        Me.txtNoLic.Name = "txtNoLic"
        Me.txtNoLic.ReadOnly = True
        Me.txtNoLic.Size = New System.Drawing.Size(176, 30)
        Me.txtNoLic.TabIndex = 1
        '
        'Tbl_lic_municipalesTableAdapter
        '
        Me.Tbl_lic_municipalesTableAdapter.ClearBeforeFill = True
        '
        'DsLicencias1BindingSource
        '
        Me.DsLicencias1BindingSource.DataSource = Me.DsLicencias1
        Me.DsLicencias1BindingSource.Position = 0
        '
        'PanteonesTipoDepositoBindingSource
        '
        Me.PanteonesTipoDepositoBindingSource.DataMember = "Panteones_Tipo_Deposito"
        Me.PanteonesTipoDepositoBindingSource.DataSource = Me.DsLicencias1BindingSource
        '
        'Panteones_Tipo_DepositoTableAdapter
        '
        Me.Panteones_Tipo_DepositoTableAdapter.ClearBeforeFill = True
        '
        'frmPanteones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1445, 737)
        Me.ControlBox = False
        Me.Controls.Add(Me.grpUltimoPago)
        Me.Controls.Add(Me.grpPAE)
        Me.Controls.Add(Me.grpPropietario)
        Me.Controls.Add(Me.grpDatosCuenta)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmPanteones"
        Me.Text = "Padrón de Panteones"
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsLicencias1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpUltimoPago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpUltimoPago.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel4.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel4.PerformLayout()
        CType(Me.uneUltMes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uneUltAnio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoRecibo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpPAE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPAE.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel3.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel3.PerformLayout()
        Me.panNotificado.ResumeLayout(False)
        Me.panNotificado.PerformLayout()
        CType(Me.txtNoActos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ucoPae, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoOficioPae, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFecPAE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpPropietario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPropietario.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel2.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel2.PerformLayout()
        CType(Me.txtemail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRfc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ucoColonia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoInt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoExt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ucoLocalidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtObservaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtResponsable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDomicilio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpDatosCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDatosCuenta.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.PerformLayout()
        CType(Me.gruTipoDeposito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gruTipoDeposito.ResumeLayout(False)
        CType(Me.optTipoDeposito, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uneDimension, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUbicacionDeposito, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaIniOp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ucoStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ucoTipoContribuyente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsLicencias1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanteonesTipoDepositoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents DsLicencias1 As dsLicencias
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents btnBack As ToolStripButton
    Friend WithEvents btnUndo As ToolStripButton
    Friend WithEvents btnGuardar As ToolStripButton
    Friend WithEvents btnElimina As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents lblCurrentMenu As ToolStripLabel
    Friend WithEvents Tbl_lic_municipalesTableAdapter As dsLicenciasTableAdapters.tbl_lic_municipalesTableAdapter
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents grpUltimoPago As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel4 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents dtpFechaPago As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtNoRecibo As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lblNumRecibo As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblUltAño As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblUltMes As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents grpPAE As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel3 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents grpPropietario As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel2 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents grpDatosCuenta As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel1 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents gruTipoDeposito As Infragistics.Win.Misc.UltraGroupBox
    Private WithEvents txtFechaIniOp As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Private WithEvents lblIniciRecargo As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ucoStatus As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents ucoTipoContribuyente As Infragistics.Win.UltraWinGrid.UltraCombo
    Private WithEvents lblDimension As Infragistics.Win.Misc.UltraLabel
    Private WithEvents lblContribuyente As Infragistics.Win.Misc.UltraLabel
    Private WithEvents lblStatus As Infragistics.Win.Misc.UltraLabel
    Private WithEvents lblCuenta As Infragistics.Win.Misc.UltraLabel
    Private WithEvents lblActividad As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtNoLic As MaskedTextBox
    Friend WithEvents btnEditar As ToolStripButton
    Friend WithEvents txtUbicacionDeposito As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents uneUltMes As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents uneUltAnio As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents uneDimension As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents btnImage As ToolStripButton
    Friend WithEvents lblCorreo As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtemail As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtCurp As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents lblCurp As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtRfc As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtTel As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents lblTelefono As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtCalle As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtCP As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents ucoColonia As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents txtNoInt As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtNoExt As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lblCP As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblObs As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblResponsable As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblRFC As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ucoLocalidad As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents txtObservaciones As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtResponsable As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtDomicilio As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtNombre As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lblNoInterior As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblNombre As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblDomicilio As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblLocalidad As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblColonia As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblNoExt As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents chkNotificado As CheckBox
    Friend WithEvents panNotificado As Panel
    Friend WithEvents txtNoActos As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents ucoPae As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents lblPae As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblFechaPae As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtNoOficioPae As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtFecPAE As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents lblNoPAe As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblNoActosPAe As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents DsLicencias1BindingSource As BindingSource
    Friend WithEvents PanteonesTipoDepositoBindingSource As BindingSource
    Friend WithEvents Panteones_Tipo_DepositoTableAdapter As dsLicenciasTableAdapters.Panteones_Tipo_DepositoTableAdapter
    Friend WithEvents optTipoDeposito As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
End Class
