<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCatTipoPredio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCatTipoPredio))
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.btnNTotal = New System.Windows.Forms.ToolStripLabel()
        Me.btnBack = New System.Windows.Forms.ToolStripButton()
        Me.btnUndo = New System.Windows.Forms.ToolStripButton()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.btnEditar = New System.Windows.Forms.ToolStripButton()
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.lblBusca = New System.Windows.Forms.ToolStripLabel()
        Me.txtBusca = New System.Windows.Forms.ToolStripTextBox()
        Me.btnBuscar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnNPrimero = New System.Windows.Forms.ToolStripButton()
        Me.btnNPrevio = New System.Windows.Forms.ToolStripButton()
        Me.btnNCurrent = New System.Windows.Forms.ToolStripTextBox()
        Me.btnNSiguiente = New System.Windows.Forms.ToolStripButton()
        Me.btnNUltimo = New System.Windows.Forms.ToolStripButton()
        Me.uexDatos = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel1 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.lblClave = New Infragistics.Win.Misc.UltraLabel()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCatalogos = New TCMAdmin.dsCatalogos()
        Me.txtClave = New System.Windows.Forms.MaskedTextBox()
        Me.lblNombre = New Infragistics.Win.Misc.UltraLabel()
        Me.Tip_predioTableAdapter = New TCMAdmin.dsCatalogosTableAdapters.tip_predioTableAdapter()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.uexDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.uexDatos.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel1.SuspendLayout()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCatalogos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.CountItem = Me.btnNTotal
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBack, Me.btnUndo, Me.btnGuardar, Me.btnEditar, Me.btnEliminar, Me.ToolStripLabel3, Me.ToolStripLabel2, Me.lblBusca, Me.txtBusca, Me.btnBuscar, Me.ToolStripLabel1, Me.ToolStripSeparator1, Me.btnNPrimero, Me.btnNPrevio, Me.btnNCurrent, Me.btnNTotal, Me.btnNSiguiente, Me.btnNUltimo})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.btnNPrimero
        Me.BindingNavigator1.MoveLastItem = Me.btnNUltimo
        Me.BindingNavigator1.MoveNextItem = Me.btnNSiguiente
        Me.BindingNavigator1.MovePreviousItem = Me.btnNPrevio
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.btnNCurrent
        Me.BindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.BindingNavigator1.Size = New System.Drawing.Size(834, 37)
        Me.BindingNavigator1.TabIndex = 19
        Me.BindingNavigator1.Text = "BindingNavigator1"
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
        'btnGuardar
        '
        Me.btnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnGuardar.Image = Global.TCMAdmin.My.Resources.Resources.IconSave
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(34, 34)
        Me.btnGuardar.Text = "ToolStripButton1"
        Me.btnGuardar.ToolTipText = "Guardar Datos"
        Me.btnGuardar.Visible = False
        '
        'btnEditar
        '
        Me.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnEditar.Image = Global.TCMAdmin.My.Resources.Resources.IconEdit
        Me.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(34, 34)
        Me.btnEditar.Text = "ToolStripButton1"
        Me.btnEditar.ToolTipText = "Editar"
        '
        'btnEliminar
        '
        Me.btnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnEliminar.Image = Global.TCMAdmin.My.Resources.Resources.IconDelete
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.RightToLeftAutoMirrorImage = True
        Me.btnEliminar.Size = New System.Drawing.Size(34, 34)
        Me.btnEliminar.Text = "Eliminar"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(76, 34)
        Me.ToolStripLabel3.Text = "                       "
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(76, 34)
        Me.ToolStripLabel2.Text = "                       "
        '
        'lblBusca
        '
        Me.lblBusca.BackColor = System.Drawing.Color.Transparent
        Me.lblBusca.Name = "lblBusca"
        Me.lblBusca.Size = New System.Drawing.Size(42, 34)
        Me.lblBusca.Text = "Buscar"
        '
        'txtBusca
        '
        Me.txtBusca.Name = "txtBusca"
        Me.txtBusca.Size = New System.Drawing.Size(100, 37)
        '
        'btnBuscar
        '
        Me.btnBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnBuscar.Image = Global.TCMAdmin.My.Resources.Resources.search
        Me.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(34, 34)
        Me.btnBuscar.Text = "Buscar Cuenta"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(76, 34)
        Me.ToolStripLabel1.Text = "                       "
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 37)
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
        'btnNCurrent
        '
        Me.btnNCurrent.AccessibleName = "Posición"
        Me.btnNCurrent.AutoSize = False
        Me.btnNCurrent.Name = "btnNCurrent"
        Me.btnNCurrent.Size = New System.Drawing.Size(50, 23)
        Me.btnNCurrent.Text = "0"
        Me.btnNCurrent.ToolTipText = "Posición actual"
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
        'uexDatos
        '
        Appearance1.BackColor = System.Drawing.Color.White
        Me.uexDatos.Appearance = Appearance1
        Me.uexDatos.Controls.Add(Me.UltraExpandableGroupBoxPanel1)
        Me.uexDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.uexDatos.Enabled = False
        Me.uexDatos.ExpandedSize = New System.Drawing.Size(834, 174)
        Me.uexDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Appearance2.BackColor = System.Drawing.Color.AliceBlue
        Appearance2.BackColor2 = System.Drawing.Color.White
        Appearance2.BackGradientAlignment = Infragistics.Win.GradientAlignment.Client
        Me.uexDatos.HeaderAppearance = Appearance2
        Me.uexDatos.Location = New System.Drawing.Point(0, 37)
        Me.uexDatos.Name = "uexDatos"
        Me.uexDatos.Size = New System.Drawing.Size(834, 174)
        Me.uexDatos.TabIndex = 20
        Me.uexDatos.TabStop = False
        Me.uexDatos.Text = "Datos"
        Me.uexDatos.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2000
        '
        'UltraExpandableGroupBoxPanel1
        '
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.lblClave)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.txtDescripcion)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.txtClave)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.lblNombre)
        Me.UltraExpandableGroupBoxPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel1.Location = New System.Drawing.Point(3, 19)
        Me.UltraExpandableGroupBoxPanel1.Name = "UltraExpandableGroupBoxPanel1"
        Me.UltraExpandableGroupBoxPanel1.Size = New System.Drawing.Size(828, 152)
        Me.UltraExpandableGroupBoxPanel1.TabIndex = 0
        '
        'lblClave
        '
        Me.lblClave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClave.Location = New System.Drawing.Point(138, 55)
        Me.lblClave.Name = "lblClave"
        Me.lblClave.Size = New System.Drawing.Size(28, 23)
        Me.lblClave.TabIndex = 4
        Me.lblClave.Text = "Id"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource, "descripcion", True))
        Me.txtDescripcion.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(172, 83)
        Me.txtDescripcion.MaxLength = 50
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(550, 22)
        Me.txtDescripcion.TabIndex = 5
        '
        'BindingSource
        '
        Me.BindingSource.DataMember = "tip_predio"
        Me.BindingSource.DataSource = Me.DsCatalogos
        '
        'DsCatalogos
        '
        Me.DsCatalogos.DataSetName = "dsCatalogos"
        Me.DsCatalogos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtClave
        '
        Me.txtClave.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource, "tipo_predio", True))
        Me.txtClave.Enabled = False
        Me.txtClave.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClave.Location = New System.Drawing.Point(172, 55)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.ReadOnly = True
        Me.txtClave.Size = New System.Drawing.Size(74, 22)
        Me.txtClave.TabIndex = 1
        '
        'lblNombre
        '
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(61, 84)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(105, 26)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Tipo de Predio:"
        '
        'Tip_predioTableAdapter
        '
        Me.Tip_predioTableAdapter.ClearBeforeFill = True
        '
        'frmCatTipoPredio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 211)
        Me.ControlBox = False
        Me.Controls.Add(Me.uexDatos)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Name = "frmCatTipoPredio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catálogos: TipoPredio"
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.uexDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.uexDatos.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.PerformLayout()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCatalogos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DsCatalogos As dsCatalogos
    Friend WithEvents Tip_predioTableAdapter As dsCatalogosTableAdapters.tip_predioTableAdapter
    Friend WithEvents BindingSource As BindingSource
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents btnNTotal As ToolStripLabel
    Friend WithEvents btnBack As ToolStripButton
    Friend WithEvents btnUndo As ToolStripButton
    Friend WithEvents btnGuardar As ToolStripButton
    Friend WithEvents btnEditar As ToolStripButton
    Friend WithEvents btnEliminar As ToolStripButton
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents lblBusca As ToolStripLabel
    Friend WithEvents txtBusca As ToolStripTextBox
    Friend WithEvents btnBuscar As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents btnNPrimero As ToolStripButton
    Friend WithEvents btnNPrevio As ToolStripButton
    Friend WithEvents btnNCurrent As ToolStripTextBox
    Friend WithEvents btnNSiguiente As ToolStripButton
    Friend WithEvents btnNUltimo As ToolStripButton
    Friend WithEvents uexDatos As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel1 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents lblClave As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtClave As MaskedTextBox
    Friend WithEvents lblNombre As Infragistics.Win.Misc.UltraLabel
End Class
