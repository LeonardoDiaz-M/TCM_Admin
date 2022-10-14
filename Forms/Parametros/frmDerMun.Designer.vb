<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDerMun
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDerMun))
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem4 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem5 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cve_tip_con")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("descricion")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cve_cuenta")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("texto")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraMessageBoxManager1 = New Infragistics.Win.UltraMessageBox.UltraMessageBoxManager(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BindingNavigator2 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsParametros = New TCMAdmin.dsParametros()
        Me.btnNTotal = New System.Windows.Forms.ToolStripLabel()
        Me.btnBack = New System.Windows.Forms.ToolStripButton()
        Me.btnUndo = New System.Windows.Forms.ToolStripButton()
        Me.btnEditar = New System.Windows.Forms.ToolStripButton()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.btnNCurrent = New System.Windows.Forms.ToolStripTextBox()
        Me.btnNPrimero = New System.Windows.Forms.ToolStripButton()
        Me.btnNPrevio = New System.Windows.Forms.ToolStripButton()
        Me.btnNSiguiente = New System.Windows.Forms.ToolStripButton()
        Me.btnNUltimo = New System.Windows.Forms.ToolStripButton()
        Me.grpCuotas = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel1 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.UnoTipoCuota = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.txtformula = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtMensaje2 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtMensaje1 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.uneCuotaTres = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.uneCuotaDos = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.uneCuotaUno = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.UltraLabel15 = New Infragistics.Win.Misc.UltraLabel()
        Me.chkDatos2 = New System.Windows.Forms.CheckBox()
        Me.chkDatos1 = New System.Windows.Forms.CheckBox()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.optCuota = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.lblEjFiscal = New System.Windows.Forms.Label()
        Me.grpdata = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.grParImpPred = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.txtArtSiguiente = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtFraccSiguiente = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtParrSiguiente = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtSubcuenta = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtFraccion = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtArticulo = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtParrafo = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.ucoDependencia = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.ucoCuenta = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.txtDescripcion = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel14 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel12 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel13 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.lblPae = New Infragistics.Win.Misc.UltraLabel()
        Me.uneAnio = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.Tbl_derechosTableAdapter = New TCMAdmin.dsParametrosTableAdapters.tbl_derechosTableAdapter()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator2.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsParametros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpCuotas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCuotas.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel1.SuspendLayout()
        CType(Me.UnoTipoCuota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtformula, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMensaje2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMensaje1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uneCuotaTres, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uneCuotaDos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uneCuotaUno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.optCuota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpdata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpdata.SuspendLayout()
        Me.grParImpPred.SuspendLayout()
        CType(Me.txtArtSiguiente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFraccSiguiente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtParrSiguiente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSubcuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFraccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtArticulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtParrafo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ucoDependencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ucoCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uneAnio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraMessageBoxManager1
        '
        Me.UltraMessageBoxManager1.ContainingControl = Me
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'BindingNavigator2
        '
        Me.BindingNavigator2.AddNewItem = Nothing
        Me.BindingNavigator2.BindingSource = Me.BindingSource1
        Me.BindingNavigator2.CountItem = Me.btnNTotal
        Me.BindingNavigator2.DeleteItem = Nothing
        Me.BindingNavigator2.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.BindingNavigator2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBack, Me.btnUndo, Me.btnEditar, Me.btnGuardar, Me.ToolStripLabel2, Me.btnEliminar, Me.btnNCurrent, Me.btnNPrimero, Me.btnNPrevio, Me.btnNTotal, Me.btnNSiguiente, Me.btnNUltimo})
        Me.BindingNavigator2.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator2.MoveFirstItem = Me.btnNPrimero
        Me.BindingNavigator2.MoveLastItem = Me.btnNUltimo
        Me.BindingNavigator2.MoveNextItem = Me.btnNSiguiente
        Me.BindingNavigator2.MovePreviousItem = Me.btnNPrevio
        Me.BindingNavigator2.Name = "BindingNavigator2"
        Me.BindingNavigator2.PositionItem = Me.btnNCurrent
        Me.BindingNavigator2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.BindingNavigator2.Size = New System.Drawing.Size(934, 37)
        Me.BindingNavigator2.TabIndex = 3
        Me.BindingNavigator2.Text = "BindingNavigator2"
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "tbl_derechos"
        Me.BindingSource1.DataSource = Me.DsParametros
        '
        'DsParametros
        '
        Me.DsParametros.DataSetName = "dsParametros"
        Me.DsParametros.EnforceConstraints = False
        Me.DsParametros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnNTotal
        '
        Me.btnNTotal.Name = "btnNTotal"
        Me.btnNTotal.Size = New System.Drawing.Size(37, 34)
        Me.btnNTotal.Text = "de {0}"
        Me.btnNTotal.ToolTipText = "Número total de elementos"
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
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.AutoSize = False
        Me.ToolStripLabel2.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(500, 34)
        Me.ToolStripLabel2.Text = "                       "
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
        'btnNCurrent
        '
        Me.btnNCurrent.AccessibleName = "Posición"
        Me.btnNCurrent.AutoSize = False
        Me.btnNCurrent.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnNCurrent.Name = "btnNCurrent"
        Me.btnNCurrent.Size = New System.Drawing.Size(50, 23)
        Me.btnNCurrent.Text = "0"
        Me.btnNCurrent.ToolTipText = "Posición actual"
        '
        'btnNPrimero
        '
        Me.btnNPrimero.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnNPrimero.Image = CType(resources.GetObject("btnNPrimero.Image"), System.Drawing.Image)
        Me.btnNPrimero.Name = "btnNPrimero"
        Me.btnNPrimero.RightToLeftAutoMirrorImage = True
        Me.btnNPrimero.Size = New System.Drawing.Size(34, 34)
        Me.btnNPrimero.Text = "Mover primero"
        '
        'btnNPrevio
        '
        Me.btnNPrevio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnNPrevio.Image = CType(resources.GetObject("btnNPrevio.Image"), System.Drawing.Image)
        Me.btnNPrevio.Name = "btnNPrevio"
        Me.btnNPrevio.RightToLeftAutoMirrorImage = True
        Me.btnNPrevio.Size = New System.Drawing.Size(34, 34)
        Me.btnNPrevio.Text = "Mover anterior"
        '
        'btnNSiguiente
        '
        Me.btnNSiguiente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnNSiguiente.Image = CType(resources.GetObject("btnNSiguiente.Image"), System.Drawing.Image)
        Me.btnNSiguiente.Name = "btnNSiguiente"
        Me.btnNSiguiente.RightToLeftAutoMirrorImage = True
        Me.btnNSiguiente.Size = New System.Drawing.Size(34, 34)
        Me.btnNSiguiente.Text = "Mover siguiente"
        '
        'btnNUltimo
        '
        Me.btnNUltimo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnNUltimo.Image = CType(resources.GetObject("btnNUltimo.Image"), System.Drawing.Image)
        Me.btnNUltimo.Name = "btnNUltimo"
        Me.btnNUltimo.RightToLeftAutoMirrorImage = True
        Me.btnNUltimo.Size = New System.Drawing.Size(34, 34)
        Me.btnNUltimo.Text = "Mover último"
        '
        'grpCuotas
        '
        Me.grpCuotas.Controls.Add(Me.UltraExpandableGroupBoxPanel1)
        Me.grpCuotas.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grpCuotas.Enabled = False
        Me.grpCuotas.ExpandedSize = New System.Drawing.Size(934, 230)
        Me.grpCuotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCuotas.Location = New System.Drawing.Point(0, 300)
        Me.grpCuotas.Name = "grpCuotas"
        Me.grpCuotas.Size = New System.Drawing.Size(934, 230)
        Me.grpCuotas.TabIndex = 2
        Me.grpCuotas.Text = "Cuotas y Cálculos"
        Me.grpCuotas.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.VisualStudio2005
        '
        'UltraExpandableGroupBoxPanel1
        '
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UnoTipoCuota)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.txtformula)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.txtMensaje2)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.txtMensaje1)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.uneCuotaTres)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.uneCuotaDos)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.uneCuotaUno)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel15)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.chkDatos2)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.chkDatos1)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel5)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.optCuota)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel4)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel3)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel2)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel1)
        Me.UltraExpandableGroupBoxPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel1.Location = New System.Drawing.Point(2, 20)
        Me.UltraExpandableGroupBoxPanel1.Name = "UltraExpandableGroupBoxPanel1"
        Me.UltraExpandableGroupBoxPanel1.Size = New System.Drawing.Size(930, 208)
        Me.UltraExpandableGroupBoxPanel1.TabIndex = 0
        '
        'UnoTipoCuota
        '
        Appearance11.TextHAlignAsString = "Center"
        Me.UnoTipoCuota.Appearance = Appearance11
        Me.UnoTipoCuota.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BindingSource1, "tipo_cuota", True))
        Me.UnoTipoCuota.Location = New System.Drawing.Point(633, 30)
        Me.UnoTipoCuota.MaskInput = "nnnnnnnnn"
        Me.UnoTipoCuota.MaxValue = 9
        Me.UnoTipoCuota.MinValue = 0
        Me.UnoTipoCuota.Name = "UnoTipoCuota"
        Me.UnoTipoCuota.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.UnoTipoCuota.Size = New System.Drawing.Size(80, 21)
        Me.UnoTipoCuota.TabIndex = 66
        Me.UnoTipoCuota.UseAppStyling = False
        '
        'txtformula
        '
        Me.txtformula.AlwaysInEditMode = True
        Appearance12.BackColor = System.Drawing.Color.White
        Appearance12.BackColor2 = System.Drawing.Color.White
        Me.txtformula.Appearance = Appearance12
        Me.txtformula.BackColor = System.Drawing.Color.White
        Me.txtformula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtformula.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "exp_calculo", True))
        Me.txtformula.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtformula.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtformula.Location = New System.Drawing.Point(212, 56)
        Me.txtformula.MaxLength = 100
        Me.txtformula.Multiline = True
        Me.txtformula.Name = "txtformula"
        Me.txtformula.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtformula.Size = New System.Drawing.Size(501, 47)
        Me.txtformula.TabIndex = 1
        '
        'txtMensaje2
        '
        Me.txtMensaje2.AlwaysInEditMode = True
        Appearance13.BackColor = System.Drawing.Color.White
        Appearance13.BackColor2 = System.Drawing.Color.White
        Me.txtMensaje2.Appearance = Appearance13
        Me.txtMensaje2.BackColor = System.Drawing.Color.White
        Me.txtMensaje2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMensaje2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "msj_dos", True))
        Me.txtMensaje2.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtMensaje2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMensaje2.Location = New System.Drawing.Point(480, 135)
        Me.txtMensaje2.MaxLength = 20
        Me.txtMensaje2.Name = "txtMensaje2"
        Me.txtMensaje2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMensaje2.Size = New System.Drawing.Size(222, 23)
        Me.txtMensaje2.TabIndex = 3
        '
        'txtMensaje1
        '
        Me.txtMensaje1.AlwaysInEditMode = True
        Appearance14.BackColor = System.Drawing.Color.White
        Appearance14.BackColor2 = System.Drawing.Color.White
        Me.txtMensaje1.Appearance = Appearance14
        Me.txtMensaje1.BackColor = System.Drawing.Color.White
        Me.txtMensaje1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMensaje1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "msj_uno", True))
        Me.txtMensaje1.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtMensaje1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMensaje1.Location = New System.Drawing.Point(212, 135)
        Me.txtMensaje1.MaxLength = 20
        Me.txtMensaje1.Name = "txtMensaje1"
        Me.txtMensaje1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMensaje1.Size = New System.Drawing.Size(222, 23)
        Me.txtMensaje1.TabIndex = 5
        '
        'uneCuotaTres
        '
        Appearance15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.uneCuotaTres.Appearance = Appearance15
        Me.uneCuotaTres.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "cuota_tres", True))
        Me.uneCuotaTres.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uneCuotaTres.Location = New System.Drawing.Point(771, 151)
        Me.uneCuotaTres.MaskInput = "nnnn.nnnn"
        Me.uneCuotaTres.MinValue = 0
        Me.uneCuotaTres.Name = "uneCuotaTres"
        Me.uneCuotaTres.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.uneCuotaTres.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.uneCuotaTres.Size = New System.Drawing.Size(120, 23)
        Me.uneCuotaTres.TabIndex = 9
        '
        'uneCuotaDos
        '
        Appearance16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.uneCuotaDos.Appearance = Appearance16
        Me.uneCuotaDos.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "cuota_dos", True))
        Me.uneCuotaDos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uneCuotaDos.Location = New System.Drawing.Point(771, 101)
        Me.uneCuotaDos.MaskInput = "nnnn.nnnn"
        Me.uneCuotaDos.MinValue = 0
        Me.uneCuotaDos.Name = "uneCuotaDos"
        Me.uneCuotaDos.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.uneCuotaDos.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.uneCuotaDos.Size = New System.Drawing.Size(120, 23)
        Me.uneCuotaDos.TabIndex = 8
        '
        'uneCuotaUno
        '
        Appearance17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.uneCuotaUno.Appearance = Appearance17
        Me.uneCuotaUno.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "cuota_uno", True))
        Me.uneCuotaUno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uneCuotaUno.Location = New System.Drawing.Point(771, 53)
        Me.uneCuotaUno.MaskInput = "nnnn.nnnn"
        Me.uneCuotaUno.MinValue = 0
        Me.uneCuotaUno.Name = "uneCuotaUno"
        Me.uneCuotaUno.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.uneCuotaUno.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.uneCuotaUno.Size = New System.Drawing.Size(120, 23)
        Me.uneCuotaUno.TabIndex = 7
        '
        'UltraLabel15
        '
        Me.UltraLabel15.AutoSize = True
        Me.UltraLabel15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel15.Location = New System.Drawing.Point(212, 31)
        Me.UltraLabel15.Name = "UltraLabel15"
        Me.UltraLabel15.Size = New System.Drawing.Size(119, 16)
        Me.UltraLabel15.TabIndex = 65
        Me.UltraLabel15.Text = "Fórmula de Cálculo:"
        '
        'chkDatos2
        '
        Me.chkDatos2.AutoSize = True
        Me.chkDatos2.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.BindingSource1, "dato_dos", True))
        Me.chkDatos2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDatos2.Location = New System.Drawing.Point(480, 109)
        Me.chkDatos2.Name = "chkDatos2"
        Me.chkDatos2.Size = New System.Drawing.Size(150, 19)
        Me.chkDatos2.TabIndex = 2
        Me.chkDatos2.Text = "Dato Adicional dos:"
        Me.chkDatos2.UseVisualStyleBackColor = True
        '
        'chkDatos1
        '
        Me.chkDatos1.AutoSize = True
        Me.chkDatos1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.BindingSource1, "dato_uno", True))
        Me.chkDatos1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDatos1.Location = New System.Drawing.Point(212, 109)
        Me.chkDatos1.Name = "chkDatos1"
        Me.chkDatos1.Size = New System.Drawing.Size(151, 19)
        Me.chkDatos1.TabIndex = 4
        Me.chkDatos1.Text = "Dato Adicional uno:"
        Me.chkDatos1.UseVisualStyleBackColor = True
        '
        'UltraLabel5
        '
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel5.Location = New System.Drawing.Point(76, 30)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(88, 16)
        Me.UltraLabel5.TabIndex = 18
        Me.UltraLabel5.Text = "Tipo de Cuota:"
        '
        'optCuota
        '
        Me.optCuota.BorderStyle = Infragistics.Win.UIElementBorderStyle.InsetSoft
        Me.optCuota.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BindingSource1, "tipo_calculo", True))
        Appearance18.FontData.BoldAsString = "False"
        ValueListItem1.Appearance = Appearance18
        ValueListItem1.CheckState = System.Windows.Forms.CheckState.Checked
        ValueListItem1.DataValue = "S"
        ValueListItem1.DisplayText = "UMA"
        Appearance19.FontData.BoldAsString = "False"
        ValueListItem2.Appearance = Appearance19
        ValueListItem2.DataValue = "C"
        ValueListItem2.DisplayText = "Cuota"
        Appearance20.FontData.BoldAsString = "False"
        ValueListItem3.Appearance = Appearance20
        ValueListItem3.DataValue = "F"
        ValueListItem3.DisplayText = "Fórmula"
        Appearance21.FontData.BoldAsString = "False"
        ValueListItem4.Appearance = Appearance21
        ValueListItem4.DataValue = "V"
        ValueListItem4.DisplayText = "Variable"
        Appearance22.FontData.BoldAsString = "False"
        ValueListItem5.Appearance = Appearance22
        ValueListItem5.DataValue = "O"
        ValueListItem5.DisplayText = "Otro"
        Me.optCuota.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2, ValueListItem3, ValueListItem4, ValueListItem5})
        Me.optCuota.Location = New System.Drawing.Point(76, 56)
        Me.optCuota.Name = "optCuota"
        Me.optCuota.Size = New System.Drawing.Size(104, 90)
        Me.optCuota.TabIndex = 0
        '
        'UltraLabel4
        '
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(771, 130)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(71, 16)
        Me.UltraLabel4.TabIndex = 16
        Me.UltraLabel4.Text = "Cuota Tres:"
        '
        'UltraLabel3
        '
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(771, 81)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(68, 16)
        Me.UltraLabel3.TabIndex = 15
        Me.UltraLabel3.Text = "Cuota Dos:"
        '
        'UltraLabel2
        '
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(771, 34)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(69, 16)
        Me.UltraLabel2.TabIndex = 14
        Me.UltraLabel2.Text = "Cuota Uno:"
        '
        'UltraLabel1
        '
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(594, 31)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(33, 16)
        Me.UltraLabel1.TabIndex = 13
        Me.UltraLabel1.Text = "Tipo:"
        '
        'lblEjFiscal
        '
        Me.lblEjFiscal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblEjFiscal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEjFiscal.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblEjFiscal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEjFiscal.Location = New System.Drawing.Point(0, 37)
        Me.lblEjFiscal.Name = "lblEjFiscal"
        Me.lblEjFiscal.Size = New System.Drawing.Size(934, 43)
        Me.lblEjFiscal.TabIndex = 0
        Me.lblEjFiscal.Text = "Ejercicio Fiscal:     "
        Me.lblEjFiscal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpdata
        '
        Me.grpdata.Controls.Add(Me.grParImpPred)
        Me.grpdata.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpdata.Enabled = False
        Me.grpdata.ExpandedSize = New System.Drawing.Size(934, 220)
        Me.grpdata.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpdata.Location = New System.Drawing.Point(0, 80)
        Me.grpdata.Name = "grpdata"
        Me.grpdata.Size = New System.Drawing.Size(934, 220)
        Me.grpdata.TabIndex = 1
        Me.grpdata.Text = "Datos Generales"
        Me.grpdata.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.VisualStudio2005
        '
        'grParImpPred
        '
        Me.grParImpPred.Controls.Add(Me.txtArtSiguiente)
        Me.grParImpPred.Controls.Add(Me.txtFraccSiguiente)
        Me.grParImpPred.Controls.Add(Me.txtParrSiguiente)
        Me.grParImpPred.Controls.Add(Me.txtSubcuenta)
        Me.grParImpPred.Controls.Add(Me.txtFraccion)
        Me.grParImpPred.Controls.Add(Me.txtArticulo)
        Me.grParImpPred.Controls.Add(Me.txtParrafo)
        Me.grParImpPred.Controls.Add(Me.ucoDependencia)
        Me.grParImpPred.Controls.Add(Me.ucoCuenta)
        Me.grParImpPred.Controls.Add(Me.txtDescripcion)
        Me.grParImpPred.Controls.Add(Me.UltraLabel14)
        Me.grParImpPred.Controls.Add(Me.UltraLabel11)
        Me.grParImpPred.Controls.Add(Me.UltraLabel12)
        Me.grParImpPred.Controls.Add(Me.UltraLabel13)
        Me.grParImpPred.Controls.Add(Me.UltraLabel10)
        Me.grParImpPred.Controls.Add(Me.UltraLabel9)
        Me.grParImpPred.Controls.Add(Me.UltraLabel8)
        Me.grParImpPred.Controls.Add(Me.UltraLabel7)
        Me.grParImpPred.Controls.Add(Me.UltraLabel6)
        Me.grParImpPred.Controls.Add(Me.lblPae)
        Me.grParImpPred.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grParImpPred.Location = New System.Drawing.Point(2, 20)
        Me.grParImpPred.Name = "grParImpPred"
        Me.grParImpPred.Size = New System.Drawing.Size(930, 198)
        Me.grParImpPred.TabIndex = 0
        '
        'txtArtSiguiente
        '
        Me.txtArtSiguiente.AlwaysInEditMode = True
        Appearance2.BackColor = System.Drawing.Color.White
        Appearance2.BackColor2 = System.Drawing.Color.White
        Me.txtArtSiguiente.Appearance = Appearance2
        Me.txtArtSiguiente.BackColor = System.Drawing.Color.White
        Me.txtArtSiguiente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtArtSiguiente.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "articulo_sgte", True))
        Me.txtArtSiguiente.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtArtSiguiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArtSiguiente.Location = New System.Drawing.Point(804, 105)
        Me.txtArtSiguiente.MaxLength = 10
        Me.txtArtSiguiente.Name = "txtArtSiguiente"
        Me.txtArtSiguiente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtArtSiguiente.Size = New System.Drawing.Size(90, 23)
        Me.txtArtSiguiente.TabIndex = 7
        '
        'txtFraccSiguiente
        '
        Me.txtFraccSiguiente.AlwaysInEditMode = True
        Appearance3.BackColor = System.Drawing.Color.White
        Appearance3.BackColor2 = System.Drawing.Color.White
        Me.txtFraccSiguiente.Appearance = Appearance3
        Me.txtFraccSiguiente.BackColor = System.Drawing.Color.White
        Me.txtFraccSiguiente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFraccSiguiente.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "fraccion_sgte", True))
        Me.txtFraccSiguiente.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtFraccSiguiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFraccSiguiente.Location = New System.Drawing.Point(804, 132)
        Me.txtFraccSiguiente.MaxLength = 10
        Me.txtFraccSiguiente.Name = "txtFraccSiguiente"
        Me.txtFraccSiguiente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFraccSiguiente.Size = New System.Drawing.Size(90, 23)
        Me.txtFraccSiguiente.TabIndex = 8
        '
        'txtParrSiguiente
        '
        Me.txtParrSiguiente.AlwaysInEditMode = True
        Appearance4.BackColor = System.Drawing.Color.White
        Appearance4.BackColor2 = System.Drawing.Color.White
        Me.txtParrSiguiente.Appearance = Appearance4
        Me.txtParrSiguiente.BackColor = System.Drawing.Color.White
        Me.txtParrSiguiente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtParrSiguiente.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "parrafo_sgte", True))
        Me.txtParrSiguiente.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtParrSiguiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtParrSiguiente.Location = New System.Drawing.Point(804, 159)
        Me.txtParrSiguiente.MaxLength = 10
        Me.txtParrSiguiente.Name = "txtParrSiguiente"
        Me.txtParrSiguiente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtParrSiguiente.Size = New System.Drawing.Size(90, 23)
        Me.txtParrSiguiente.TabIndex = 9
        '
        'txtSubcuenta
        '
        Me.txtSubcuenta.AlwaysInEditMode = True
        Appearance5.BackColor = System.Drawing.Color.White
        Appearance5.BackColor2 = System.Drawing.Color.White
        Me.txtSubcuenta.Appearance = Appearance5
        Me.txtSubcuenta.BackColor = System.Drawing.Color.White
        Me.txtSubcuenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSubcuenta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "sub_cuenta", True))
        Me.txtSubcuenta.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtSubcuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubcuenta.Location = New System.Drawing.Point(144, 103)
        Me.txtSubcuenta.MaxLength = 3
        Me.txtSubcuenta.Name = "txtSubcuenta"
        Me.txtSubcuenta.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSubcuenta.Size = New System.Drawing.Size(61, 23)
        Me.txtSubcuenta.TabIndex = 2
        '
        'txtFraccion
        '
        Me.txtFraccion.AlwaysInEditMode = True
        Appearance6.BackColor = System.Drawing.Color.White
        Appearance6.BackColor2 = System.Drawing.Color.White
        Me.txtFraccion.Appearance = Appearance6
        Me.txtFraccion.BackColor = System.Drawing.Color.White
        Me.txtFraccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFraccion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "fraccion", True))
        Me.txtFraccion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtFraccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFraccion.Location = New System.Drawing.Point(585, 133)
        Me.txtFraccion.MaxLength = 5
        Me.txtFraccion.Name = "txtFraccion"
        Me.txtFraccion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFraccion.Size = New System.Drawing.Size(61, 23)
        Me.txtFraccion.TabIndex = 5
        '
        'txtArticulo
        '
        Me.txtArticulo.AlwaysInEditMode = True
        Appearance7.BackColor = System.Drawing.Color.White
        Appearance7.BackColor2 = System.Drawing.Color.White
        Me.txtArticulo.Appearance = Appearance7
        Me.txtArticulo.BackColor = System.Drawing.Color.White
        Me.txtArticulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtArticulo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "articulo", True))
        Me.txtArticulo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtArticulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArticulo.Location = New System.Drawing.Point(585, 106)
        Me.txtArticulo.MaxLength = 5
        Me.txtArticulo.Name = "txtArticulo"
        Me.txtArticulo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtArticulo.Size = New System.Drawing.Size(61, 23)
        Me.txtArticulo.TabIndex = 4
        '
        'txtParrafo
        '
        Me.txtParrafo.AlwaysInEditMode = True
        Appearance8.BackColor = System.Drawing.Color.White
        Appearance8.BackColor2 = System.Drawing.Color.White
        Me.txtParrafo.Appearance = Appearance8
        Me.txtParrafo.BackColor = System.Drawing.Color.White
        Me.txtParrafo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtParrafo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "parrafo", True))
        Me.txtParrafo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtParrafo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtParrafo.Location = New System.Drawing.Point(585, 160)
        Me.txtParrafo.MaxLength = 3
        Me.txtParrafo.Name = "txtParrafo"
        Me.txtParrafo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtParrafo.Size = New System.Drawing.Size(61, 23)
        Me.txtParrafo.TabIndex = 6
        '
        'ucoDependencia
        '
        Appearance9.FontData.BoldAsString = "True"
        Appearance9.FontData.Name = "Tahoma"
        Appearance9.FontData.SizeInPoints = 9.0!
        Me.ucoDependencia.Appearance = Appearance9
        Me.ucoDependencia.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.ucoDependencia.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains
        Me.ucoDependencia.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BindingSource1, "id_dep", True))
        UltraGridBand1.ColHeadersVisible = False
        UltraGridColumn3.Header.VisiblePosition = 0
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.Header.VisiblePosition = 1
        UltraGridColumn4.Width = 330
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn3, UltraGridColumn4})
        Me.ucoDependencia.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ucoDependencia.DisplayMember = "Descricion"
        Me.ucoDependencia.DropDownResizeHandleStyle = Infragistics.Win.DropDownResizeHandleStyle.VerticalResize
        Me.ucoDependencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ucoDependencia.Location = New System.Drawing.Point(144, 132)
        Me.ucoDependencia.MaxDropDownItems = 30
        Me.ucoDependencia.Name = "ucoDependencia"
        Me.ucoDependencia.NullText = "Seleccione..."
        Me.ucoDependencia.Size = New System.Drawing.Size(337, 24)
        Me.ucoDependencia.TabIndex = 3
        Me.ucoDependencia.ValueMember = "cve_tip_con"
        '
        'ucoCuenta
        '
        Appearance10.FontData.BoldAsString = "True"
        Appearance10.FontData.Name = "Tahoma"
        Appearance10.FontData.SizeInPoints = 9.0!
        Me.ucoCuenta.Appearance = Appearance10
        Me.ucoCuenta.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.ucoCuenta.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains
        Me.ucoCuenta.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BindingSource1, "cve_cuenta", True))
        UltraGridBand2.ColHeadersVisible = False
        UltraGridColumn5.Header.VisiblePosition = 0
        UltraGridColumn5.Hidden = True
        UltraGridColumn6.Header.VisiblePosition = 1
        UltraGridColumn6.Width = 800
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn5, UltraGridColumn6})
        Me.ucoCuenta.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.ucoCuenta.DisplayMember = "Descricion"
        Me.ucoCuenta.DropDownResizeHandleStyle = Infragistics.Win.DropDownResizeHandleStyle.VerticalResize
        Me.ucoCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ucoCuenta.Location = New System.Drawing.Point(144, 73)
        Me.ucoCuenta.MaxDropDownItems = 30
        Me.ucoCuenta.Name = "ucoCuenta"
        Me.ucoCuenta.NullText = "Seleccione..."
        Me.ucoCuenta.Size = New System.Drawing.Size(750, 24)
        Me.ucoCuenta.TabIndex = 1
        Me.ucoCuenta.ValueMember = "cve_tip_con"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "descripcion", True))
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(144, 18)
        Me.txtDescripcion.MaxLength = 148
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(750, 47)
        Me.txtDescripcion.TabIndex = 0
        '
        'UltraLabel14
        '
        Me.UltraLabel14.AutoSize = True
        Me.UltraLabel14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel14.Location = New System.Drawing.Point(41, 135)
        Me.UltraLabel14.Name = "UltraLabel14"
        Me.UltraLabel14.Size = New System.Drawing.Size(84, 16)
        Me.UltraLabel14.TabIndex = 19
        Me.UltraLabel14.Text = "Dependencia:"
        '
        'UltraLabel11
        '
        Me.UltraLabel11.AutoSize = True
        Me.UltraLabel11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel11.Location = New System.Drawing.Point(672, 162)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(106, 16)
        Me.UltraLabel11.TabIndex = 18
        Me.UltraLabel11.Text = "Párrafo siguiente:"
        '
        'UltraLabel12
        '
        Me.UltraLabel12.AutoSize = True
        Me.UltraLabel12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel12.Location = New System.Drawing.Point(666, 135)
        Me.UltraLabel12.Name = "UltraLabel12"
        Me.UltraLabel12.Size = New System.Drawing.Size(113, 16)
        Me.UltraLabel12.TabIndex = 17
        Me.UltraLabel12.Text = "Fracción siguiente:"
        '
        'UltraLabel13
        '
        Me.UltraLabel13.AutoSize = True
        Me.UltraLabel13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel13.Location = New System.Drawing.Point(670, 108)
        Me.UltraLabel13.Name = "UltraLabel13"
        Me.UltraLabel13.Size = New System.Drawing.Size(107, 16)
        Me.UltraLabel13.TabIndex = 16
        Me.UltraLabel13.Text = "Artículo siguiente:"
        '
        'UltraLabel10
        '
        Me.UltraLabel10.AutoSize = True
        Me.UltraLabel10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel10.Location = New System.Drawing.Point(519, 163)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(50, 16)
        Me.UltraLabel10.TabIndex = 15
        Me.UltraLabel10.Text = "Párrafo:"
        '
        'UltraLabel9
        '
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel9.Location = New System.Drawing.Point(513, 136)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(58, 16)
        Me.UltraLabel9.TabIndex = 14
        Me.UltraLabel9.Text = "Fracción:"
        '
        'UltraLabel8
        '
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel8.Location = New System.Drawing.Point(517, 109)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(52, 16)
        Me.UltraLabel8.TabIndex = 13
        Me.UltraLabel8.Text = "Artículo:"
        '
        'UltraLabel7
        '
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel7.Location = New System.Drawing.Point(55, 105)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(72, 16)
        Me.UltraLabel7.TabIndex = 12
        Me.UltraLabel7.Text = "SubCuenta:"
        '
        'UltraLabel6
        '
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel6.Location = New System.Drawing.Point(40, 76)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(86, 16)
        Me.UltraLabel6.TabIndex = 11
        Me.UltraLabel6.Text = "Clave Cuenta:"
        '
        'lblPae
        '
        Me.lblPae.AutoSize = True
        Me.lblPae.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPae.Location = New System.Drawing.Point(50, 21)
        Me.lblPae.Name = "lblPae"
        Me.lblPae.Size = New System.Drawing.Size(76, 16)
        Me.lblPae.TabIndex = 9
        Me.lblPae.Text = "Descripción:"
        '
        'uneAnio
        '
        Appearance1.BackColor = System.Drawing.Color.White
        Appearance1.TextHAlignAsString = "Center"
        Me.uneAnio.Appearance = Appearance1
        Me.uneAnio.BackColor = System.Drawing.Color.White
        Me.uneAnio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "ejfiscal", True))
        Me.uneAnio.Font = New System.Drawing.Font("Tahoma", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uneAnio.Location = New System.Drawing.Point(539, 43)
        Me.uneAnio.MaxValue = 9999
        Me.uneAnio.MinValue = 0
        Me.uneAnio.Name = "uneAnio"
        Me.uneAnio.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.uneAnio.ReadOnly = True
        Me.uneAnio.Size = New System.Drawing.Size(94, 31)
        Me.uneAnio.TabIndex = 0
        Me.uneAnio.UseAppStyling = False
        '
        'Tbl_derechosTableAdapter
        '
        Me.Tbl_derechosTableAdapter.ClearBeforeFill = True
        '
        'frmDerMun
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(934, 530)
        Me.ControlBox = False
        Me.Controls.Add(Me.uneAnio)
        Me.Controls.Add(Me.grpdata)
        Me.Controls.Add(Me.lblEjFiscal)
        Me.Controls.Add(Me.grpCuotas)
        Me.Controls.Add(Me.BindingNavigator2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Name = "frmDerMun"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cátalogo de Derechos Municipales"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator2.ResumeLayout(False)
        Me.BindingNavigator2.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsParametros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpCuotas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCuotas.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.PerformLayout()
        CType(Me.UnoTipoCuota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtformula, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMensaje2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMensaje1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uneCuotaTres, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uneCuotaDos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uneCuotaUno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.optCuota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpdata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpdata.ResumeLayout(False)
        Me.grParImpPred.ResumeLayout(False)
        Me.grParImpPred.PerformLayout()
        CType(Me.txtArtSiguiente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFraccSiguiente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtParrSiguiente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSubcuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFraccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtArticulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtParrafo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ucoDependencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ucoCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uneAnio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UltraMessageBoxManager1 As Infragistics.Win.UltraMessageBox.UltraMessageBoxManager
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents DsParametros As dsParametros
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents Tbl_derechosTableAdapter As dsParametrosTableAdapters.tbl_derechosTableAdapter
    Friend WithEvents grpdata As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents grParImpPred As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents txtArtSiguiente As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtFraccSiguiente As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtParrSiguiente As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtSubcuenta As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtFraccion As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtArticulo As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtParrafo As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents ucoDependencia As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents ucoCuenta As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents txtDescripcion As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel14 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel12 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblPae As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblEjFiscal As Label
    Friend WithEvents grpCuotas As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel1 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents txtformula As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtMensaje2 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtMensaje1 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents uneCuotaTres As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents uneCuotaDos As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents uneCuotaUno As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraLabel15 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents chkDatos2 As CheckBox
    Friend WithEvents chkDatos1 As CheckBox
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents optCuota As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents BindingNavigator2 As BindingNavigator
    Friend WithEvents btnNTotal As ToolStripLabel
    Friend WithEvents btnBack As ToolStripButton
    Friend WithEvents btnUndo As ToolStripButton
    Friend WithEvents btnGuardar As ToolStripButton
    Friend WithEvents btnEditar As ToolStripButton
    Friend WithEvents btnEliminar As ToolStripButton
    Friend WithEvents btnNPrimero As ToolStripButton
    Friend WithEvents btnNPrevio As ToolStripButton
    Friend WithEvents btnNCurrent As ToolStripTextBox
    Friend WithEvents btnNSiguiente As ToolStripButton
    Friend WithEvents btnNUltimo As ToolStripButton
    Friend WithEvents uneAnio As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents UnoTipoCuota As Infragistics.Win.UltraWinEditors.UltraNumericEditor
End Class
