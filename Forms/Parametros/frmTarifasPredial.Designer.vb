<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTarifasPredial
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
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem4 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.grpdata = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.grParImpPred = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.uneFactor = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsParametros = New TCMAdmin.dsParametros()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.uneLimiteSuperior = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.uneLimiteInferior = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.uneCuotaMinima = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.gruTipTributo = New Infragistics.Win.Misc.UltraGroupBox()
        Me.optTipoTributo = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        Me.uneAnio = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtFraccion = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.lblEjFiscal = New System.Windows.Forms.Label()
        Me.BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.btnBack = New System.Windows.Forms.ToolStripButton()
        Me.btnUndo = New System.Windows.Forms.ToolStripButton()
        Me.btnEditar = New System.Windows.Forms.ToolStripButton()
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.btnElimina = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.lblOperacion = New System.Windows.Forms.ToolStripLabel()
        Me.Tbl_predialTableAdapter = New TCMAdmin.dsParametrosTableAdapters.tbl_predialTableAdapter()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.grpdata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpdata.SuspendLayout()
        Me.grParImpPred.SuspendLayout()
        CType(Me.uneFactor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsParametros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uneLimiteSuperior, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uneLimiteInferior, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uneCuotaMinima, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gruTipTributo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gruTipTributo.SuspendLayout()
        CType(Me.optTipoTributo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uneAnio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFraccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpdata
        '
        Me.grpdata.Controls.Add(Me.grParImpPred)
        Me.grpdata.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpdata.Enabled = False
        Me.grpdata.ExpandedSize = New System.Drawing.Size(1251, 601)
        Me.grpdata.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpdata.Location = New System.Drawing.Point(0, 90)
        Me.grpdata.Margin = New System.Windows.Forms.Padding(4)
        Me.grpdata.Name = "grpdata"
        Me.grpdata.Size = New System.Drawing.Size(1251, 601)
        Me.grpdata.TabIndex = 8
        Me.grpdata.Text = "Datos Generales"
        Me.grpdata.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'grParImpPred
        '
        Me.grParImpPred.Controls.Add(Me.UltraLabel2)
        Me.grParImpPred.Controls.Add(Me.uneFactor)
        Me.grParImpPred.Controls.Add(Me.UltraLabel3)
        Me.grParImpPred.Controls.Add(Me.uneLimiteSuperior)
        Me.grParImpPred.Controls.Add(Me.UltraLabel4)
        Me.grParImpPred.Controls.Add(Me.uneLimiteInferior)
        Me.grParImpPred.Controls.Add(Me.UltraLabel5)
        Me.grParImpPred.Controls.Add(Me.uneCuotaMinima)
        Me.grParImpPred.Controls.Add(Me.gruTipTributo)
        Me.grParImpPred.Controls.Add(Me.uneAnio)
        Me.grParImpPred.Controls.Add(Me.UltraLabel1)
        Me.grParImpPred.Controls.Add(Me.txtFraccion)
        Me.grParImpPred.Controls.Add(Me.UltraLabel9)
        Me.grParImpPred.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grParImpPred.Location = New System.Drawing.Point(2, 25)
        Me.grParImpPred.Margin = New System.Windows.Forms.Padding(4)
        Me.grParImpPred.Name = "grParImpPred"
        Me.grParImpPred.Size = New System.Drawing.Size(1247, 574)
        Me.grParImpPred.TabIndex = 0
        '
        'UltraLabel2
        '
        Appearance1.BackColor = System.Drawing.Color.White
        Me.UltraLabel2.Appearance = Appearance1
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(716, 300)
        Me.UltraLabel2.Margin = New System.Windows.Forms.Padding(4)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(65, 22)
        Me.UltraLabel2.TabIndex = 77
        Me.UltraLabel2.Text = "Factor:"
        '
        'uneFactor
        '
        Appearance2.ForeColor = System.Drawing.Color.Black
        Me.uneFactor.Appearance = Appearance2
        Me.uneFactor.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BindingSource, "factor_valor", True))
        Me.uneFactor.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uneFactor.Location = New System.Drawing.Point(794, 300)
        Me.uneFactor.Margin = New System.Windows.Forms.Padding(4)
        Me.uneFactor.MaskInput = "nnnn.nnnn"
        Me.uneFactor.MinValue = 0
        Me.uneFactor.Name = "uneFactor"
        Me.uneFactor.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.uneFactor.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.uneFactor.Size = New System.Drawing.Size(148, 29)
        Me.uneFactor.TabIndex = 73
        Me.uneFactor.UseAppStyling = False
        '
        'BindingSource
        '
        Me.BindingSource.DataMember = "tbl_predial"
        Me.BindingSource.DataSource = Me.DsParametros
        '
        'DsParametros
        '
        Me.DsParametros.DataSetName = "dsParametros"
        Me.DsParametros.EnforceConstraints = False
        Me.DsParametros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UltraLabel3
        '
        Appearance3.BackColor = System.Drawing.Color.White
        Me.UltraLabel3.Appearance = Appearance3
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(284, 225)
        Me.UltraLabel3.Margin = New System.Windows.Forms.Padding(4)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(134, 22)
        Me.UltraLabel3.TabIndex = 74
        Me.UltraLabel3.Text = "Límite Inferior:"
        '
        'uneLimiteSuperior
        '
        Appearance4.ForeColor = System.Drawing.Color.Black
        Me.uneLimiteSuperior.Appearance = Appearance4
        Me.uneLimiteSuperior.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BindingSource, "lim_superior", True))
        Me.uneLimiteSuperior.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uneLimiteSuperior.Location = New System.Drawing.Point(436, 300)
        Me.uneLimiteSuperior.Margin = New System.Windows.Forms.Padding(4)
        Me.uneLimiteSuperior.MinValue = 0
        Me.uneLimiteSuperior.Name = "uneLimiteSuperior"
        Me.uneLimiteSuperior.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.uneLimiteSuperior.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.uneLimiteSuperior.Size = New System.Drawing.Size(148, 29)
        Me.uneLimiteSuperior.TabIndex = 71
        Me.uneLimiteSuperior.UseAppStyling = False
        '
        'UltraLabel4
        '
        Appearance5.BackColor = System.Drawing.Color.White
        Me.UltraLabel4.Appearance = Appearance5
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(278, 300)
        Me.UltraLabel4.Margin = New System.Windows.Forms.Padding(4)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(141, 22)
        Me.UltraLabel4.TabIndex = 75
        Me.UltraLabel4.Text = "Límite Superior:"
        '
        'uneLimiteInferior
        '
        Appearance6.ForeColor = System.Drawing.Color.Black
        Me.uneLimiteInferior.Appearance = Appearance6
        Me.uneLimiteInferior.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BindingSource, "lim_inferior", True))
        Me.uneLimiteInferior.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uneLimiteInferior.Location = New System.Drawing.Point(436, 225)
        Me.uneLimiteInferior.Margin = New System.Windows.Forms.Padding(4)
        Me.uneLimiteInferior.MinValue = 0
        Me.uneLimiteInferior.Name = "uneLimiteInferior"
        Me.uneLimiteInferior.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.uneLimiteInferior.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.uneLimiteInferior.Size = New System.Drawing.Size(148, 29)
        Me.uneLimiteInferior.TabIndex = 70
        Me.uneLimiteInferior.UseAppStyling = False
        '
        'UltraLabel5
        '
        Appearance7.BackColor = System.Drawing.Color.White
        Me.UltraLabel5.Appearance = Appearance7
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel5.Location = New System.Drawing.Point(682, 225)
        Me.UltraLabel5.Margin = New System.Windows.Forms.Padding(4)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(97, 22)
        Me.UltraLabel5.TabIndex = 76
        Me.UltraLabel5.Text = "Cuota Fija:"
        '
        'uneCuotaMinima
        '
        Appearance8.ForeColor = System.Drawing.Color.Black
        Me.uneCuotaMinima.Appearance = Appearance8
        Me.uneCuotaMinima.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BindingSource, "cuota_fija", True))
        Me.uneCuotaMinima.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uneCuotaMinima.Location = New System.Drawing.Point(794, 225)
        Me.uneCuotaMinima.Margin = New System.Windows.Forms.Padding(4)
        Me.uneCuotaMinima.MaskInput = "nnnn.nnnn"
        Me.uneCuotaMinima.MinValue = 0
        Me.uneCuotaMinima.Name = "uneCuotaMinima"
        Me.uneCuotaMinima.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.uneCuotaMinima.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.uneCuotaMinima.Size = New System.Drawing.Size(148, 29)
        Me.uneCuotaMinima.TabIndex = 72
        Me.uneCuotaMinima.UseAppStyling = False
        '
        'gruTipTributo
        '
        Appearance9.BackColor = System.Drawing.Color.White
        Appearance9.BorderColor = System.Drawing.Color.Blue
        Me.gruTipTributo.Appearance = Appearance9
        Me.gruTipTributo.BorderStyle = Infragistics.Win.Misc.GroupBoxBorderStyle.Rounded
        Me.gruTipTributo.Controls.Add(Me.optTipoTributo)
        Me.gruTipTributo.Location = New System.Drawing.Point(437, 54)
        Me.gruTipTributo.Margin = New System.Windows.Forms.Padding(4)
        Me.gruTipTributo.Name = "gruTipTributo"
        Me.gruTipTributo.Size = New System.Drawing.Size(735, 127)
        Me.gruTipTributo.TabIndex = 69
        Me.gruTipTributo.Text = " Tipo de tributo:"
        Me.gruTipTributo.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2000
        '
        'optTipoTributo
        '
        Me.optTipoTributo.BorderStyle = Infragistics.Win.UIElementBorderStyle.Rounded4Thick
        Me.optTipoTributo.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BindingSource, "tip_impuesto", True))
        Appearance10.FontData.BoldAsString = "True"
        ValueListItem1.Appearance = Appearance10
        ValueListItem1.CheckState = System.Windows.Forms.CheckState.Checked
        ValueListItem1.DataValue = "P"
        ValueListItem1.DisplayText = "Predial"
        Appearance11.FontData.BoldAsString = "True"
        ValueListItem2.Appearance = Appearance11
        ValueListItem2.DataValue = "T"
        ValueListItem2.DisplayText = "Traslado de Dominio"
        Appearance12.FontData.BoldAsString = "True"
        ValueListItem3.Appearance = Appearance12
        ValueListItem3.DataValue = "L"
        ValueListItem3.DisplayText = "Levantamiento Topográfico"
        Appearance13.FontData.BoldAsString = "True"
        ValueListItem4.Appearance = Appearance13
        ValueListItem4.DataValue = "V"
        ValueListItem4.DisplayText = "Verificación de Linderos"
        Me.optTipoTributo.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2, ValueListItem3, ValueListItem4})
        Me.optTipoTributo.ItemSpacingHorizontal = 20
        Me.optTipoTributo.ItemSpacingVertical = 5
        Me.optTipoTributo.Location = New System.Drawing.Point(80, 34)
        Me.optTipoTributo.Margin = New System.Windows.Forms.Padding(4)
        Me.optTipoTributo.Name = "optTipoTributo"
        Me.optTipoTributo.Size = New System.Drawing.Size(633, 73)
        Me.optTipoTributo.TabIndex = 0
        '
        'uneAnio
        '
        Appearance14.BackColor = System.Drawing.Color.White
        Appearance14.TextHAlignAsString = "Left"
        Me.uneAnio.Appearance = Appearance14
        Me.uneAnio.BackColor = System.Drawing.Color.White
        Me.uneAnio.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BindingSource, "año_fiscal", True))
        Me.uneAnio.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uneAnio.Location = New System.Drawing.Point(237, 76)
        Me.uneAnio.Margin = New System.Windows.Forms.Padding(4)
        Me.uneAnio.MaxValue = 3000
        Me.uneAnio.MinValue = 0
        Me.uneAnio.Name = "uneAnio"
        Me.uneAnio.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.uneAnio.ReadOnly = True
        Me.uneAnio.Size = New System.Drawing.Size(108, 30)
        Me.uneAnio.TabIndex = 0
        Me.uneAnio.UseAppStyling = False
        '
        'UltraLabel1
        '
        Appearance15.BackColor = System.Drawing.Color.White
        Me.UltraLabel1.Appearance = Appearance15
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(95, 81)
        Me.UltraLabel1.Margin = New System.Windows.Forms.Padding(4)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(126, 22)
        Me.UltraLabel1.TabIndex = 62
        Me.UltraLabel1.Text = "Ejercicio fiscal"
        '
        'txtFraccion
        '
        Me.txtFraccion.AlwaysInEditMode = True
        Appearance16.BackColor = System.Drawing.Color.White
        Appearance16.BackColor2 = System.Drawing.Color.White
        Me.txtFraccion.Appearance = Appearance16
        Me.txtFraccion.BackColor = System.Drawing.Color.White
        Me.txtFraccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFraccion.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BindingSource, "fracc_articulo", True))
        Me.txtFraccion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtFraccion.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFraccion.Location = New System.Drawing.Point(237, 143)
        Me.txtFraccion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFraccion.MaxLength = 5
        Me.txtFraccion.Name = "txtFraccion"
        Me.txtFraccion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFraccion.Size = New System.Drawing.Size(108, 27)
        Me.txtFraccion.TabIndex = 1
        '
        'UltraLabel9
        '
        Appearance17.BackColor = System.Drawing.Color.White
        Me.UltraLabel9.Appearance = Appearance17
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel9.Location = New System.Drawing.Point(141, 147)
        Me.UltraLabel9.Margin = New System.Windows.Forms.Padding(4)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(83, 22)
        Me.UltraLabel9.TabIndex = 14
        Me.UltraLabel9.Text = "Fracción:"
        '
        'lblEjFiscal
        '
        Me.lblEjFiscal.BackColor = System.Drawing.Color.White
        Me.lblEjFiscal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEjFiscal.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblEjFiscal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEjFiscal.Location = New System.Drawing.Point(0, 37)
        Me.lblEjFiscal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEjFiscal.Name = "lblEjFiscal"
        Me.lblEjFiscal.Size = New System.Drawing.Size(1251, 53)
        Me.lblEjFiscal.TabIndex = 7
        Me.lblEjFiscal.Text = "Tablas de Valores de Predial  y Traslados de Dominio"
        Me.lblEjFiscal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BindingNavigator
        '
        Me.BindingNavigator.AddNewItem = Nothing
        Me.BindingNavigator.BackColor = System.Drawing.Color.White
        Me.BindingNavigator.BindingSource = Me.BindingSource
        Me.BindingNavigator.CountItem = Nothing
        Me.BindingNavigator.DeleteItem = Nothing
        Me.BindingNavigator.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBack, Me.btnUndo, Me.btnEditar, Me.btnNuevo, Me.btnGuardar, Me.btnElimina, Me.ToolStripLabel2, Me.lblOperacion})
        Me.BindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator.MoveFirstItem = Nothing
        Me.BindingNavigator.MoveLastItem = Nothing
        Me.BindingNavigator.MoveNextItem = Nothing
        Me.BindingNavigator.MovePreviousItem = Nothing
        Me.BindingNavigator.Name = "BindingNavigator"
        Me.BindingNavigator.PositionItem = Nothing
        Me.BindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.BindingNavigator.Size = New System.Drawing.Size(1251, 37)
        Me.BindingNavigator.TabIndex = 9
        Me.BindingNavigator.Text = "BindingNavigator"
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
        'btnElimina
        '
        Me.btnElimina.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnElimina.Image = Global.TCMAdmin.My.Resources.Resources.IconDelete
        Me.btnElimina.Name = "btnElimina"
        Me.btnElimina.RightToLeftAutoMirrorImage = True
        Me.btnElimina.Size = New System.Drawing.Size(34, 34)
        Me.btnElimina.Text = "Eliminar"
        Me.btnElimina.ToolTipText = "Eliminar registro"
        Me.btnElimina.Visible = False
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.AutoSize = False
        Me.ToolStripLabel2.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(500, 34)
        Me.ToolStripLabel2.Text = "                       "
        '
        'lblOperacion
        '
        Me.lblOperacion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblOperacion.Name = "lblOperacion"
        Me.lblOperacion.Size = New System.Drawing.Size(0, 34)
        '
        'Tbl_predialTableAdapter
        '
        Me.Tbl_predialTableAdapter.ClearBeforeFill = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmTarifasPredial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1251, 704)
        Me.ControlBox = False
        Me.Controls.Add(Me.grpdata)
        Me.Controls.Add(Me.lblEjFiscal)
        Me.Controls.Add(Me.BindingNavigator)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmTarifasPredial"
        Me.Text = "Tablas de Valores de Predial y Traslados de Dominio"
        CType(Me.grpdata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpdata.ResumeLayout(False)
        Me.grParImpPred.ResumeLayout(False)
        Me.grParImpPred.PerformLayout()
        CType(Me.uneFactor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsParametros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uneLimiteSuperior, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uneLimiteInferior, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uneCuotaMinima, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gruTipTributo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gruTipTributo.ResumeLayout(False)
        CType(Me.optTipoTributo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uneAnio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFraccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator.ResumeLayout(False)
        Me.BindingNavigator.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpdata As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents grParImpPred As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents optTipoTributo As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents uneAnio As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtFraccion As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblEjFiscal As Label
    Friend WithEvents BindingNavigator As BindingNavigator
    Friend WithEvents btnBack As ToolStripButton
    Friend WithEvents btnUndo As ToolStripButton
    Friend WithEvents btnEditar As ToolStripButton
    Friend WithEvents btnGuardar As ToolStripButton
    Friend WithEvents btnElimina As ToolStripButton
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents gruTipTributo As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents DsParametros As dsParametros
    Friend WithEvents BindingSource As BindingSource
    Friend WithEvents Tbl_predialTableAdapter As dsParametrosTableAdapters.tbl_predialTableAdapter
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents btnNuevo As ToolStripButton
    Friend WithEvents lblOperacion As ToolStripLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uneFactor As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uneLimiteSuperior As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uneLimiteInferior As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uneCuotaMinima As Infragistics.Win.UltraWinEditors.UltraNumericEditor
End Class
