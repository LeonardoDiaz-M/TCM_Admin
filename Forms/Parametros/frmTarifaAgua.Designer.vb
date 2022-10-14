<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTarifaAgua
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
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem7 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem8 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem5 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem6 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("idToma", 0)
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Diametro", 1)
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("clave")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("nombre")
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BindingNavigator2 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.TbltarifasaguaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsParametros1 = New TCMAdmin.dsParametros()
        Me.btnBack = New System.Windows.Forms.ToolStripButton()
        Me.btnUndo = New System.Windows.Forms.ToolStripButton()
        Me.btnEditar = New System.Windows.Forms.ToolStripButton()
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.lblOperacion = New System.Windows.Forms.ToolStripLabel()
        Me.lblEjFiscal = New System.Windows.Forms.Label()
        Me.grpdata = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.grParImpPred = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.grpFormaPago = New Infragistics.Win.Misc.UltraGroupBox()
        Me.optFormaPago = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        Me.Tbl1tarifasaguaBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.grpServicio = New Infragistics.Win.Misc.UltraGroupBox()
        Me.optTipoServicio = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        Me.grpTipoUsuario = New Infragistics.Win.Misc.UltraGroupBox()
        Me.optUsuario = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        Me.lblDescripciontarifa = New Infragistics.Win.Misc.UltraLabel()
        Me.txtDescripcionTarifa = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.uneAnio = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtFraccion = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtGrupoMunicipio = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.lblGrupo = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.ucoDiametroToma = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.ucoTipoInmueble = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.lblTipoInmueble = New Infragistics.Win.Misc.UltraLabel()
        Me.lblDiametroToma = New Infragistics.Win.Misc.UltraLabel()
        Me.grpRangos = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel1 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.uneCuotaMinima = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.UltraLabel13 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel12 = New Infragistics.Win.Misc.UltraLabel()
        Me.uneFactor = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.uneLimiteSuperior = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.uneLimiteInferior = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Tbl1_tarifas_aguaTableAdapter = New TCMAdmin.dsParametrosTableAdapters.tbl1_tarifas_aguaTableAdapter()
        Me.Tbl_tarifas_aguaTableAdapter = New TCMAdmin.dsParametrosTableAdapters.tbl_tarifas_aguaTableAdapter()
        Me.UltraExpandableGroupBox1 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel2 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.griDatatable = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.TipoinmuebleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.TblDiametroTomaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tbl_DiametroTomaTableAdapter = New TCMAdmin.dsParametrosTableAdapters.tbl_DiametroTomaTableAdapter()
        Me.Tipo_inmuebleTableAdapter = New TCMAdmin.dsParametrosTableAdapters.tipo_inmuebleTableAdapter()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator2.SuspendLayout()
        CType(Me.TbltarifasaguaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsParametros1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpdata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpdata.SuspendLayout()
        Me.grParImpPred.SuspendLayout()
        CType(Me.grpFormaPago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFormaPago.SuspendLayout()
        CType(Me.optFormaPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl1tarifasaguaBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpServicio.SuspendLayout()
        CType(Me.optTipoServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpTipoUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTipoUsuario.SuspendLayout()
        CType(Me.optUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcionTarifa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uneAnio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFraccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGrupoMunicipio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ucoDiametroToma, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ucoTipoInmueble, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpRangos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpRangos.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel1.SuspendLayout()
        CType(Me.uneCuotaMinima, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uneFactor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uneLimiteSuperior, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uneLimiteInferior, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraExpandableGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox1.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel2.SuspendLayout()
        CType(Me.griDatatable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoinmuebleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblDiametroTomaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BindingNavigator2
        '
        Me.BindingNavigator2.AddNewItem = Nothing
        Me.BindingNavigator2.BindingSource = Me.TbltarifasaguaBindingSource1
        Me.BindingNavigator2.CountItem = Nothing
        Me.BindingNavigator2.DeleteItem = Nothing
        Me.BindingNavigator2.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.BindingNavigator2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBack, Me.btnUndo, Me.btnEditar, Me.btnNuevo, Me.btnGuardar, Me.btnEliminar, Me.ToolStripLabel2, Me.lblOperacion})
        Me.BindingNavigator2.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator2.MoveFirstItem = Nothing
        Me.BindingNavigator2.MoveLastItem = Nothing
        Me.BindingNavigator2.MoveNextItem = Nothing
        Me.BindingNavigator2.MovePreviousItem = Nothing
        Me.BindingNavigator2.Name = "BindingNavigator2"
        Me.BindingNavigator2.PositionItem = Nothing
        Me.BindingNavigator2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.BindingNavigator2.Size = New System.Drawing.Size(1025, 37)
        Me.BindingNavigator2.TabIndex = 10
        Me.BindingNavigator2.Text = "BindingNavigator2"
        '
        'TbltarifasaguaBindingSource1
        '
        Me.TbltarifasaguaBindingSource1.DataMember = "tbl_tarifas_agua"
        Me.TbltarifasaguaBindingSource1.DataSource = Me.DsParametros1
        '
        'DsParametros1
        '
        Me.DsParametros1.DataSetName = "dsParametros"
        Me.DsParametros1.EnforceConstraints = False
        Me.DsParametros1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnBack
        '
        Me.btnBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnBack.Image = Global.TCMAdmin.My.Resources.Resources.IconBack
        Me.btnBack.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(34, 34)
        Me.btnBack.Text = "ToolStripButton1"
        Me.btnBack.ToolTipText = "Regresar"
        '
        'btnUndo
        '
        Me.btnUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnUndo.Image = Global.TCMAdmin.My.Resources.Resources.Icon_Undo
        Me.btnUndo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(34, 34)
        Me.btnUndo.Text = "ToolStripButton1"
        Me.btnUndo.ToolTipText = "Deshacer cambios"
        '
        'btnEditar
        '
        Me.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnEditar.Image = Global.TCMAdmin.My.Resources.Resources.IconEdit
        Me.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(34, 34)
        Me.btnEditar.Text = "ToolStripButton1"
        Me.btnEditar.ToolTipText = "Editar registro"
        Me.btnEditar.Visible = False
        '
        'btnNuevo
        '
        Me.btnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnNuevo.Image = Global.TCMAdmin.My.Resources.Resources.IconNew
        Me.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(34, 34)
        Me.btnNuevo.Text = "ToolStripButton1"
        Me.btnNuevo.ToolTipText = "Agregar registro"
        Me.btnNuevo.Visible = False
        '
        'btnGuardar
        '
        Me.btnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnGuardar.Image = Global.TCMAdmin.My.Resources.Resources.IconSave
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(34, 34)
        Me.btnGuardar.Text = "ToolStripButton1"
        Me.btnGuardar.ToolTipText = "Guardar registro"
        Me.btnGuardar.Visible = False
        '
        'btnEliminar
        '
        Me.btnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnEliminar.Image = Global.TCMAdmin.My.Resources.Resources.IconDelete
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.RightToLeftAutoMirrorImage = True
        Me.btnEliminar.Size = New System.Drawing.Size(34, 34)
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.ToolTipText = "Eliminar registro"
        Me.btnEliminar.Visible = False
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.AutoSize = False
        Me.ToolStripLabel2.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(600, 34)
        Me.ToolStripLabel2.Text = "                       "
        '
        'lblOperacion
        '
        Me.lblOperacion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblOperacion.Name = "lblOperacion"
        Me.lblOperacion.Size = New System.Drawing.Size(0, 34)
        '
        'lblEjFiscal
        '
        Me.lblEjFiscal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblEjFiscal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEjFiscal.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblEjFiscal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEjFiscal.Location = New System.Drawing.Point(0, 37)
        Me.lblEjFiscal.Name = "lblEjFiscal"
        Me.lblEjFiscal.Size = New System.Drawing.Size(1025, 43)
        Me.lblEjFiscal.TabIndex = 11
        Me.lblEjFiscal.Text = "Tablas de Tarífas de Agua Potable"
        Me.lblEjFiscal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpdata
        '
        Me.grpdata.Controls.Add(Me.grParImpPred)
        Me.grpdata.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpdata.Enabled = False
        Me.grpdata.ExpandedSize = New System.Drawing.Size(1025, 153)
        Me.grpdata.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpdata.Location = New System.Drawing.Point(0, 80)
        Me.grpdata.Name = "grpdata"
        Me.grpdata.Size = New System.Drawing.Size(1025, 153)
        Me.grpdata.TabIndex = 12
        Me.grpdata.Text = "Datos Generales"
        Me.grpdata.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'grParImpPred
        '
        Me.grParImpPred.Controls.Add(Me.grpFormaPago)
        Me.grParImpPred.Controls.Add(Me.grpServicio)
        Me.grParImpPred.Controls.Add(Me.grpTipoUsuario)
        Me.grParImpPred.Controls.Add(Me.lblDescripciontarifa)
        Me.grParImpPred.Controls.Add(Me.txtDescripcionTarifa)
        Me.grParImpPred.Controls.Add(Me.uneAnio)
        Me.grParImpPred.Controls.Add(Me.UltraLabel1)
        Me.grParImpPred.Controls.Add(Me.txtFraccion)
        Me.grParImpPred.Controls.Add(Me.txtGrupoMunicipio)
        Me.grParImpPred.Controls.Add(Me.lblGrupo)
        Me.grParImpPred.Controls.Add(Me.UltraLabel9)
        Me.grParImpPred.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grParImpPred.Location = New System.Drawing.Point(2, 22)
        Me.grParImpPred.Name = "grParImpPred"
        Me.grParImpPred.Size = New System.Drawing.Size(1021, 129)
        Me.grParImpPred.TabIndex = 0
        '
        'grpFormaPago
        '
        Me.grpFormaPago.Controls.Add(Me.optFormaPago)
        Me.grpFormaPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpFormaPago.Location = New System.Drawing.Point(801, 17)
        Me.grpFormaPago.Name = "grpFormaPago"
        Me.grpFormaPago.Size = New System.Drawing.Size(159, 65)
        Me.grpFormaPago.TabIndex = 80
        Me.grpFormaPago.Text = "Forma Pago"
        Me.grpFormaPago.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'optFormaPago
        '
        Me.optFormaPago.BackColor = System.Drawing.Color.White
        Me.optFormaPago.BackColorInternal = System.Drawing.Color.White
        Me.optFormaPago.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.optFormaPago.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Tbl1tarifasaguaBindingSource2, "tipo_cuota", True))
        Me.optFormaPago.Dock = System.Windows.Forms.DockStyle.Fill
        Appearance24.FontData.BoldAsString = "False"
        Appearance24.FontData.SizeInPoints = 8.0!
        Appearance24.TextHAlignAsString = "Center"
        Appearance24.TextVAlignAsString = "Middle"
        Me.optFormaPago.ItemAppearance = Appearance24
        ValueListItem7.DataValue = "1"
        ValueListItem7.DisplayText = "Bimestral"
        ValueListItem8.DataValue = "2"
        ValueListItem8.DisplayText = "Mensual"
        Me.optFormaPago.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem7, ValueListItem8})
        Me.optFormaPago.ItemSpacingVertical = 5
        Me.optFormaPago.Location = New System.Drawing.Point(3, 19)
        Me.optFormaPago.Name = "optFormaPago"
        Me.optFormaPago.Size = New System.Drawing.Size(153, 43)
        Me.optFormaPago.TabIndex = 0
        Me.optFormaPago.UseFlatMode = Infragistics.Win.DefaultableBoolean.[True]
        Me.optFormaPago.UseOsThemes = Infragistics.Win.DefaultableBoolean.[True]
        '
        'Tbl1tarifasaguaBindingSource2
        '
        Me.Tbl1tarifasaguaBindingSource2.DataMember = "tbl1_tarifas_agua"
        Me.Tbl1tarifasaguaBindingSource2.DataSource = Me.DsParametros1
        '
        'grpServicio
        '
        Me.grpServicio.Controls.Add(Me.optTipoServicio)
        Me.grpServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpServicio.Location = New System.Drawing.Point(612, 17)
        Me.grpServicio.Name = "grpServicio"
        Me.grpServicio.Size = New System.Drawing.Size(159, 65)
        Me.grpServicio.TabIndex = 79
        Me.grpServicio.Text = "Tipo Servicio"
        Me.grpServicio.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'optTipoServicio
        '
        Me.optTipoServicio.BackColor = System.Drawing.Color.White
        Me.optTipoServicio.BackColorInternal = System.Drawing.Color.White
        Me.optTipoServicio.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.optTipoServicio.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Tbl1tarifasaguaBindingSource2, "tipo_servicio", True))
        Me.optTipoServicio.Dock = System.Windows.Forms.DockStyle.Fill
        Appearance25.FontData.BoldAsString = "False"
        Appearance25.FontData.SizeInPoints = 8.0!
        Appearance25.TextHAlignAsString = "Center"
        Appearance25.TextVAlignAsString = "Middle"
        Me.optTipoServicio.ItemAppearance = Appearance25
        ValueListItem1.DataValue = "1"
        ValueListItem1.DisplayText = "Medido"
        ValueListItem2.DataValue = "2"
        ValueListItem2.DisplayText = "Cuota Fija"
        Me.optTipoServicio.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2})
        Me.optTipoServicio.ItemSpacingVertical = 5
        Me.optTipoServicio.Location = New System.Drawing.Point(3, 19)
        Me.optTipoServicio.Name = "optTipoServicio"
        Me.optTipoServicio.Size = New System.Drawing.Size(153, 43)
        Me.optTipoServicio.TabIndex = 0
        Me.optTipoServicio.UseFlatMode = Infragistics.Win.DefaultableBoolean.[True]
        Me.optTipoServicio.UseOsThemes = Infragistics.Win.DefaultableBoolean.[True]
        '
        'grpTipoUsuario
        '
        Appearance26.BorderColor = System.Drawing.Color.Silver
        Appearance26.BorderColor2 = System.Drawing.Color.Silver
        Appearance26.BorderColor3DBase = System.Drawing.Color.Silver
        Me.grpTipoUsuario.Appearance = Appearance26
        Me.grpTipoUsuario.BorderStyle = Infragistics.Win.Misc.GroupBoxBorderStyle.Rounded
        Me.grpTipoUsuario.Controls.Add(Me.optUsuario)
        Me.grpTipoUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTipoUsuario.Location = New System.Drawing.Point(423, 17)
        Me.grpTipoUsuario.Name = "grpTipoUsuario"
        Me.grpTipoUsuario.Size = New System.Drawing.Size(159, 63)
        Me.grpTipoUsuario.TabIndex = 78
        Me.grpTipoUsuario.Text = "Tipo Usuario"
        Me.grpTipoUsuario.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'optUsuario
        '
        Me.optUsuario.BackColor = System.Drawing.Color.White
        Me.optUsuario.BackColorInternal = System.Drawing.Color.White
        Me.optUsuario.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.optUsuario.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Tbl1tarifasaguaBindingSource2, "tipo_Usuario", True))
        Me.optUsuario.Dock = System.Windows.Forms.DockStyle.Fill
        Appearance27.FontData.BoldAsString = "False"
        Appearance27.FontData.SizeInPoints = 8.0!
        Appearance27.TextHAlignAsString = "Center"
        Appearance27.TextVAlignAsString = "Middle"
        Me.optUsuario.ItemAppearance = Appearance27
        Appearance28.FontData.BoldAsString = "False"
        ValueListItem5.Appearance = Appearance28
        ValueListItem5.DataValue = "1"
        ValueListItem5.DisplayText = "Doméstico"
        Appearance29.FontData.BoldAsString = "False"
        ValueListItem6.Appearance = Appearance29
        ValueListItem6.DataValue = "2"
        ValueListItem6.DisplayText = "Comercial"
        Me.optUsuario.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem5, ValueListItem6})
        Me.optUsuario.ItemSpacingVertical = 5
        Me.optUsuario.Location = New System.Drawing.Point(3, 19)
        Me.optUsuario.Name = "optUsuario"
        Me.optUsuario.Size = New System.Drawing.Size(153, 41)
        Me.optUsuario.TabIndex = 0
        '
        'lblDescripciontarifa
        '
        Appearance30.BackColor = System.Drawing.Color.White
        Me.lblDescripciontarifa.Appearance = Appearance30
        Me.lblDescripciontarifa.AutoSize = True
        Me.lblDescripciontarifa.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripciontarifa.Location = New System.Drawing.Point(286, 92)
        Me.lblDescripciontarifa.Name = "lblDescripciontarifa"
        Me.lblDescripciontarifa.Size = New System.Drawing.Size(131, 18)
        Me.lblDescripciontarifa.TabIndex = 77
        Me.lblDescripciontarifa.Text = "Descripción Tarifa:"
        '
        'txtDescripcionTarifa
        '
        Me.txtDescripcionTarifa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcionTarifa.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl1tarifasaguaBindingSource2, "desc_tarifa", True))
        Me.txtDescripcionTarifa.Location = New System.Drawing.Point(423, 89)
        Me.txtDescripcionTarifa.MaxLength = 50
        Me.txtDescripcionTarifa.Name = "txtDescripcionTarifa"
        Me.txtDescripcionTarifa.Size = New System.Drawing.Size(537, 24)
        Me.txtDescripcionTarifa.TabIndex = 3
        '
        'uneAnio
        '
        Appearance31.BackColor = System.Drawing.Color.White
        Appearance31.TextHAlignAsString = "Left"
        Me.uneAnio.Appearance = Appearance31
        Me.uneAnio.BackColor = System.Drawing.Color.White
        Me.uneAnio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl1tarifasaguaBindingSource2, "año_fiscal", True))
        Me.uneAnio.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uneAnio.Location = New System.Drawing.Point(175, 29)
        Me.uneAnio.MaxValue = 3000
        Me.uneAnio.MinValue = 0
        Me.uneAnio.Name = "uneAnio"
        Me.uneAnio.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.uneAnio.ReadOnly = True
        Me.uneAnio.Size = New System.Drawing.Size(81, 25)
        Me.uneAnio.TabIndex = 0
        Me.uneAnio.UseAppStyling = False
        '
        'UltraLabel1
        '
        Appearance32.BackColor = System.Drawing.Color.White
        Me.UltraLabel1.Appearance = Appearance32
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(68, 33)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(101, 18)
        Me.UltraLabel1.TabIndex = 62
        Me.UltraLabel1.Text = "Ejercicio fiscal"
        '
        'txtFraccion
        '
        Me.txtFraccion.AlwaysInEditMode = True
        Appearance10.BackColor = System.Drawing.Color.White
        Appearance10.BackColor2 = System.Drawing.Color.White
        Me.txtFraccion.Appearance = Appearance10
        Me.txtFraccion.BackColor = System.Drawing.Color.White
        Me.txtFraccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFraccion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl1tarifasaguaBindingSource2, "fracc_articulo", True))
        Me.txtFraccion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtFraccion.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFraccion.Location = New System.Drawing.Point(175, 59)
        Me.txtFraccion.MaxLength = 5
        Me.txtFraccion.Name = "txtFraccion"
        Me.txtFraccion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFraccion.Size = New System.Drawing.Size(81, 23)
        Me.txtFraccion.TabIndex = 1
        '
        'txtGrupoMunicipio
        '
        Me.txtGrupoMunicipio.AlwaysInEditMode = True
        Appearance11.BackColor = System.Drawing.Color.White
        Appearance11.BackColor2 = System.Drawing.Color.White
        Me.txtGrupoMunicipio.Appearance = Appearance11
        Me.txtGrupoMunicipio.BackColor = System.Drawing.Color.White
        Me.txtGrupoMunicipio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGrupoMunicipio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl1tarifasaguaBindingSource2, "gpo_mun", True))
        Me.txtGrupoMunicipio.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtGrupoMunicipio.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrupoMunicipio.Location = New System.Drawing.Point(175, 88)
        Me.txtGrupoMunicipio.MaxLength = 3
        Me.txtGrupoMunicipio.Name = "txtGrupoMunicipio"
        Me.txtGrupoMunicipio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtGrupoMunicipio.Size = New System.Drawing.Size(81, 23)
        Me.txtGrupoMunicipio.TabIndex = 2
        '
        'lblGrupo
        '
        Appearance33.BackColor = System.Drawing.Color.White
        Me.lblGrupo.Appearance = Appearance33
        Me.lblGrupo.AutoSize = True
        Me.lblGrupo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrupo.Location = New System.Drawing.Point(49, 89)
        Me.lblGrupo.Name = "lblGrupo"
        Me.lblGrupo.Size = New System.Drawing.Size(120, 18)
        Me.lblGrupo.TabIndex = 15
        Me.lblGrupo.Text = "Grupo Municipio:"
        '
        'UltraLabel9
        '
        Appearance34.BackColor = System.Drawing.Color.White
        Me.UltraLabel9.Appearance = Appearance34
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel9.Location = New System.Drawing.Point(103, 62)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(66, 18)
        Me.UltraLabel9.TabIndex = 14
        Me.UltraLabel9.Text = "Fracción:"
        '
        'ucoDiametroToma
        '
        Appearance14.FontData.BoldAsString = "True"
        Appearance14.FontData.Name = "Tahoma"
        Appearance14.FontData.SizeInPoints = 9.0!
        Me.ucoDiametroToma.Appearance = Appearance14
        Me.ucoDiametroToma.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.ucoDiametroToma.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains
        Me.ucoDiametroToma.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TbltarifasaguaBindingSource1, "diametro_toma", True))
        UltraGridBand1.ColHeadersVisible = False
        UltraGridColumn3.Header.VisiblePosition = 0
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.Header.VisiblePosition = 1
        UltraGridColumn4.Width = 200
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn3, UltraGridColumn4})
        Me.ucoDiametroToma.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ucoDiametroToma.DropDownResizeHandleStyle = Infragistics.Win.DropDownResizeHandleStyle.VerticalResize
        Me.ucoDiametroToma.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ucoDiametroToma.Location = New System.Drawing.Point(760, 14)
        Me.ucoDiametroToma.MaxDropDownItems = 30
        Me.ucoDiametroToma.Name = "ucoDiametroToma"
        Me.ucoDiametroToma.NullText = "Seleccione..."
        Me.ucoDiametroToma.Size = New System.Drawing.Size(200, 24)
        Me.ucoDiametroToma.TabIndex = 4
        Me.ucoDiametroToma.Visible = False
        '
        'ucoTipoInmueble
        '
        Appearance15.FontData.BoldAsString = "True"
        Appearance15.FontData.Name = "Tahoma"
        Appearance15.FontData.SizeInPoints = 9.0!
        Me.ucoTipoInmueble.Appearance = Appearance15
        Me.ucoTipoInmueble.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.ucoTipoInmueble.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains
        Me.ucoTipoInmueble.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TbltarifasaguaBindingSource1, "tipo_inmueble", True))
        UltraGridBand2.ColHeadersVisible = False
        UltraGridColumn7.Header.VisiblePosition = 0
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.Header.VisiblePosition = 1
        UltraGridColumn8.Width = 200
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn7, UltraGridColumn8})
        Me.ucoTipoInmueble.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.ucoTipoInmueble.DropDownResizeHandleStyle = Infragistics.Win.DropDownResizeHandleStyle.VerticalResize
        Me.ucoTipoInmueble.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ucoTipoInmueble.Location = New System.Drawing.Point(760, 14)
        Me.ucoTipoInmueble.MaxDropDownItems = 30
        Me.ucoTipoInmueble.Name = "ucoTipoInmueble"
        Me.ucoTipoInmueble.NullText = "Seleccione..."
        Me.ucoTipoInmueble.Size = New System.Drawing.Size(200, 24)
        Me.ucoTipoInmueble.TabIndex = 74
        Me.ucoTipoInmueble.Visible = False
        '
        'lblTipoInmueble
        '
        Appearance35.BackColor = System.Drawing.Color.White
        Me.lblTipoInmueble.Appearance = Appearance35
        Me.lblTipoInmueble.AutoSize = True
        Me.lblTipoInmueble.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoInmueble.Location = New System.Drawing.Point(647, 18)
        Me.lblTipoInmueble.Name = "lblTipoInmueble"
        Me.lblTipoInmueble.Size = New System.Drawing.Size(107, 18)
        Me.lblTipoInmueble.TabIndex = 73
        Me.lblTipoInmueble.Text = "Tipo Inmueble:"
        Me.lblTipoInmueble.Visible = False
        '
        'lblDiametroToma
        '
        Me.lblDiametroToma.AutoSize = True
        Me.lblDiametroToma.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiametroToma.Location = New System.Drawing.Point(641, 18)
        Me.lblDiametroToma.Name = "lblDiametroToma"
        Me.lblDiametroToma.Size = New System.Drawing.Size(113, 18)
        Me.lblDiametroToma.TabIndex = 72
        Me.lblDiametroToma.Text = "Diámetro Toma:"
        Me.lblDiametroToma.Visible = False
        '
        'grpRangos
        '
        Me.grpRangos.Controls.Add(Me.UltraExpandableGroupBoxPanel1)
        Me.grpRangos.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpRangos.Enabled = False
        Me.grpRangos.ExpandedSize = New System.Drawing.Size(1025, 106)
        Me.grpRangos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpRangos.Location = New System.Drawing.Point(0, 233)
        Me.grpRangos.Name = "grpRangos"
        Me.grpRangos.Size = New System.Drawing.Size(1025, 106)
        Me.grpRangos.TabIndex = 13
        Me.grpRangos.Text = "Rangos"
        Me.grpRangos.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        Me.grpRangos.Visible = False
        '
        'UltraExpandableGroupBoxPanel1
        '
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.uneCuotaMinima)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel13)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel12)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.uneFactor)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.ucoDiametroToma)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.ucoTipoInmueble)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel6)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.lblTipoInmueble)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.uneLimiteSuperior)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.lblDiametroToma)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel7)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.uneLimiteInferior)
        Me.UltraExpandableGroupBoxPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel1.Location = New System.Drawing.Point(2, 22)
        Me.UltraExpandableGroupBoxPanel1.Name = "UltraExpandableGroupBoxPanel1"
        Me.UltraExpandableGroupBoxPanel1.Size = New System.Drawing.Size(1021, 82)
        Me.UltraExpandableGroupBoxPanel1.TabIndex = 0
        '
        'uneCuotaMinima
        '
        Appearance36.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.uneCuotaMinima.Appearance = Appearance36
        Me.uneCuotaMinima.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbltarifasaguaBindingSource1, "cuota_minima", True))
        Me.uneCuotaMinima.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uneCuotaMinima.Location = New System.Drawing.Point(461, 14)
        Me.uneCuotaMinima.MaskInput = "nnnn.nnnn"
        Me.uneCuotaMinima.MinValue = 0
        Me.uneCuotaMinima.Name = "uneCuotaMinima"
        Me.uneCuotaMinima.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.uneCuotaMinima.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.uneCuotaMinima.Size = New System.Drawing.Size(111, 25)
        Me.uneCuotaMinima.TabIndex = 2
        Me.uneCuotaMinima.UseAppStyling = False
        '
        'UltraLabel13
        '
        Me.UltraLabel13.AutoSize = True
        Me.UltraLabel13.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel13.Location = New System.Drawing.Point(353, 18)
        Me.UltraLabel13.Name = "UltraLabel13"
        Me.UltraLabel13.Size = New System.Drawing.Size(102, 18)
        Me.UltraLabel13.TabIndex = 69
        Me.UltraLabel13.Text = "Cuota Mínima:"
        '
        'UltraLabel12
        '
        Appearance37.BackColor = System.Drawing.Color.White
        Me.UltraLabel12.Appearance = Appearance37
        Me.UltraLabel12.AutoSize = True
        Me.UltraLabel12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel12.Location = New System.Drawing.Point(403, 45)
        Me.UltraLabel12.Name = "UltraLabel12"
        Me.UltraLabel12.Size = New System.Drawing.Size(52, 18)
        Me.UltraLabel12.TabIndex = 17
        Me.UltraLabel12.Text = "Factor:"
        '
        'uneFactor
        '
        Appearance38.ForeColor = System.Drawing.Color.Black
        Me.uneFactor.Appearance = Appearance38
        Me.uneFactor.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbltarifasaguaBindingSource1, "factor", True))
        Me.uneFactor.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uneFactor.Location = New System.Drawing.Point(461, 43)
        Me.uneFactor.MaskInput = "nnnn.nnnn"
        Me.uneFactor.MinValue = 0
        Me.uneFactor.Name = "uneFactor"
        Me.uneFactor.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.uneFactor.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.uneFactor.Size = New System.Drawing.Size(111, 25)
        Me.uneFactor.TabIndex = 3
        Me.uneFactor.UseAppStyling = False
        '
        'UltraLabel6
        '
        Appearance39.BackColor = System.Drawing.Color.White
        Me.UltraLabel6.Appearance = Appearance39
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel6.Location = New System.Drawing.Point(64, 18)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(108, 18)
        Me.UltraLabel6.TabIndex = 11
        Me.UltraLabel6.Text = "Límite Inferior:"
        '
        'uneLimiteSuperior
        '
        Appearance40.ForeColor = System.Drawing.Color.Black
        Me.uneLimiteSuperior.Appearance = Appearance40
        Me.uneLimiteSuperior.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbltarifasaguaBindingSource1, "lim_superior", True))
        Me.uneLimiteSuperior.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uneLimiteSuperior.Location = New System.Drawing.Point(175, 43)
        Me.uneLimiteSuperior.MinValue = 0
        Me.uneLimiteSuperior.Name = "uneLimiteSuperior"
        Me.uneLimiteSuperior.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.uneLimiteSuperior.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.uneLimiteSuperior.Size = New System.Drawing.Size(111, 25)
        Me.uneLimiteSuperior.TabIndex = 1
        Me.uneLimiteSuperior.UseAppStyling = False
        '
        'UltraLabel7
        '
        Appearance41.BackColor = System.Drawing.Color.White
        Me.UltraLabel7.Appearance = Appearance41
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel7.Location = New System.Drawing.Point(59, 45)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(113, 18)
        Me.UltraLabel7.TabIndex = 12
        Me.UltraLabel7.Text = "Límite Superior:"
        '
        'uneLimiteInferior
        '
        Appearance42.ForeColor = System.Drawing.Color.Black
        Me.uneLimiteInferior.Appearance = Appearance42
        Me.uneLimiteInferior.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbltarifasaguaBindingSource1, "lim_inferior", True))
        Me.uneLimiteInferior.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uneLimiteInferior.Location = New System.Drawing.Point(175, 14)
        Me.uneLimiteInferior.MinValue = 0
        Me.uneLimiteInferior.Name = "uneLimiteInferior"
        Me.uneLimiteInferior.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.uneLimiteInferior.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.uneLimiteInferior.Size = New System.Drawing.Size(111, 25)
        Me.uneLimiteInferior.TabIndex = 0
        Me.uneLimiteInferior.UseAppStyling = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Tbl1_tarifas_aguaTableAdapter
        '
        Me.Tbl1_tarifas_aguaTableAdapter.ClearBeforeFill = True
        '
        'Tbl_tarifas_aguaTableAdapter
        '
        Me.Tbl_tarifas_aguaTableAdapter.ClearBeforeFill = True
        '
        'UltraExpandableGroupBox1
        '
        Me.UltraExpandableGroupBox1.Controls.Add(Me.UltraExpandableGroupBoxPanel2)
        Me.UltraExpandableGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBox1.ExpandedSize = New System.Drawing.Size(1025, 175)
        Me.UltraExpandableGroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraExpandableGroupBox1.Location = New System.Drawing.Point(0, 339)
        Me.UltraExpandableGroupBox1.Name = "UltraExpandableGroupBox1"
        Me.UltraExpandableGroupBox1.Size = New System.Drawing.Size(1025, 175)
        Me.UltraExpandableGroupBox1.TabIndex = 14
        Me.UltraExpandableGroupBox1.Text = "Tarifa Detalle"
        Me.UltraExpandableGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'UltraExpandableGroupBoxPanel2
        '
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.griDatatable)
        Me.UltraExpandableGroupBoxPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel2.Location = New System.Drawing.Point(2, 22)
        Me.UltraExpandableGroupBoxPanel2.Name = "UltraExpandableGroupBoxPanel2"
        Me.UltraExpandableGroupBoxPanel2.Size = New System.Drawing.Size(1021, 151)
        Me.UltraExpandableGroupBoxPanel2.TabIndex = 0
        '
        'griDatatable
        '
        Me.griDatatable.AllowUserToAddRows = False
        Me.griDatatable.AllowUserToDeleteRows = False
        Me.griDatatable.AutoGenerateColumns = False
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.griDatatable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.griDatatable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.griDatatable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.griDatatable.DataSource = Me.TbltarifasaguaBindingSource1
        Me.griDatatable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griDatatable.Location = New System.Drawing.Point(0, 0)
        Me.griDatatable.Name = "griDatatable"
        Me.griDatatable.Size = New System.Drawing.Size(1021, 151)
        Me.griDatatable.TabIndex = 15
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_tarifa"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id_tarifa"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "tipo_inmueble"
        Me.DataGridViewTextBoxColumn6.DataSource = Me.TipoinmuebleBindingSource
        Me.DataGridViewTextBoxColumn6.DisplayMember = "nombre"
        Me.DataGridViewTextBoxColumn6.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.DataGridViewTextBoxColumn6.HeaderText = "Tipo Inmueble"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn6.ValueMember = "clave"
        Me.DataGridViewTextBoxColumn6.Width = 150
        '
        'TipoinmuebleBindingSource
        '
        Me.TipoinmuebleBindingSource.DataMember = "tipo_inmueble"
        Me.TipoinmuebleBindingSource.DataSource = Me.DsParametros1
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "diametro_toma"
        Me.DataGridViewTextBoxColumn7.DataSource = Me.TblDiametroTomaBindingSource
        Me.DataGridViewTextBoxColumn7.DisplayMember = "Diametro"
        Me.DataGridViewTextBoxColumn7.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.DataGridViewTextBoxColumn7.HeaderText = "Diametro Toma"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn7.ValueMember = "idToma"
        Me.DataGridViewTextBoxColumn7.Width = 150
        '
        'TblDiametroTomaBindingSource
        '
        Me.TblDiametroTomaBindingSource.DataMember = "tbl_DiametroToma"
        Me.TblDiametroTomaBindingSource.DataSource = Me.DsParametros1
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "lim_inferior"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn9.HeaderText = "Límite Inferior"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 175
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "lim_superior"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.DataGridViewTextBoxColumn10.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn10.HeaderText = "Límite Superior"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 175
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "cuota_minima"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "N2"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.DataGridViewTextBoxColumn11.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn11.HeaderText = "Cuota Mínima"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 175
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "factor"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "N2"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.DataGridViewTextBoxColumn12.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewTextBoxColumn12.HeaderText = "Factor"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 175
        '
        'Tbl_DiametroTomaTableAdapter
        '
        Me.Tbl_DiametroTomaTableAdapter.ClearBeforeFill = True
        '
        'Tipo_inmuebleTableAdapter
        '
        Me.Tipo_inmuebleTableAdapter.ClearBeforeFill = True
        '
        'frmTarifaAgua
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1025, 514)
        Me.Controls.Add(Me.UltraExpandableGroupBox1)
        Me.Controls.Add(Me.grpRangos)
        Me.Controls.Add(Me.grpdata)
        Me.Controls.Add(Me.lblEjFiscal)
        Me.Controls.Add(Me.BindingNavigator2)
        Me.KeyPreview = True
        Me.Name = "frmTarifaAgua"
        Me.Text = "Tarifas de Agua Potable"
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator2.ResumeLayout(False)
        Me.BindingNavigator2.PerformLayout()
        CType(Me.TbltarifasaguaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsParametros1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpdata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpdata.ResumeLayout(False)
        Me.grParImpPred.ResumeLayout(False)
        Me.grParImpPred.PerformLayout()
        CType(Me.grpFormaPago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFormaPago.ResumeLayout(False)
        CType(Me.optFormaPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl1tarifasaguaBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpServicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpServicio.ResumeLayout(False)
        CType(Me.optTipoServicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpTipoUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTipoUsuario.ResumeLayout(False)
        CType(Me.optUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcionTarifa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uneAnio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFraccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGrupoMunicipio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ucoDiametroToma, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ucoTipoInmueble, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpRangos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpRangos.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.PerformLayout()
        CType(Me.uneCuotaMinima, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uneFactor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uneLimiteSuperior, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uneLimiteInferior, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraExpandableGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox1.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel2.ResumeLayout(False)
        CType(Me.griDatatable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoinmuebleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblDiametroTomaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BindingNavigator2 As BindingNavigator
    Friend WithEvents btnBack As ToolStripButton
    Friend WithEvents btnUndo As ToolStripButton
    Friend WithEvents btnEditar As ToolStripButton
    Friend WithEvents btnNuevo As ToolStripButton
    Friend WithEvents btnGuardar As ToolStripButton
    Friend WithEvents btnEliminar As ToolStripButton
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents lblOperacion As ToolStripLabel
    Friend WithEvents lblEjFiscal As Label
    Friend WithEvents grpdata As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents grParImpPred As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents uneAnio As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtFraccion As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtGrupoMunicipio As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lblGrupo As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents grpRangos As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel1 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UltraLabel12 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uneFactor As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uneLimiteSuperior As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uneLimiteInferior As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents lblTipoInmueble As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblDiametroToma As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uneCuotaMinima As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents DsParametros As dsParametros
    Friend WithEvents Tbl1_tarifas_aguaTableAdapter As dsParametrosTableAdapters.tbl1_tarifas_aguaTableAdapter
    Friend WithEvents Tbl_tarifas_aguaTableAdapter As dsParametrosTableAdapters.tbl_tarifas_aguaTableAdapter
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ucoDiametroToma As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents lblDescripciontarifa As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtDescripcionTarifa As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents ucoTipoInmueble As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents grpTipoUsuario As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents optUsuario As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents grpServicio As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents optTipoServicio As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents IdtarifaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdgrupoaguaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AñofiscalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipusuarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TiposervicioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoinmuebleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiametrotomaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FraccarticuloDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LiminferiorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LimsuperiorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CuotaminimaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FactorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GpomunDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DesctarifaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ObservacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipocuotaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TbltarifasaguaBindingSource1 As BindingSource
    Friend WithEvents DsParametros1 As dsParametros
    Friend WithEvents Tbl1tarifasaguaBindingSource2 As BindingSource
    Friend WithEvents UltraExpandableGroupBox1 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel2 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents griDatatable As DataGridView
    Friend WithEvents grpFormaPago As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents optFormaPago As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents TblDiametroTomaBindingSource As BindingSource
    Friend WithEvents Tbl_DiametroTomaTableAdapter As dsParametrosTableAdapters.tbl_DiametroTomaTableAdapter
    Friend WithEvents TipoinmuebleBindingSource As BindingSource
    Friend WithEvents Tipo_inmuebleTableAdapter As dsParametrosTableAdapters.tipo_inmuebleTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
End Class
