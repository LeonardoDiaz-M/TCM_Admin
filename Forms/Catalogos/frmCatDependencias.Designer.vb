﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCatDependencias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCatDependencias))
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.DependenciasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCatalogos = New TCMAdmin.dsCatalogos()
        Me.btnNTotal = New System.Windows.Forms.ToolStripLabel()
        Me.btnBack = New System.Windows.Forms.ToolStripButton()
        Me.btnUndo = New System.Windows.Forms.ToolStripButton()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.btnEditar = New System.Windows.Forms.ToolStripButton()
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.btnNPrimero = New System.Windows.Forms.ToolStripButton()
        Me.btnNPrevio = New System.Windows.Forms.ToolStripButton()
        Me.btnNCurrent = New System.Windows.Forms.ToolStripTextBox()
        Me.btnNSiguiente = New System.Windows.Forms.ToolStripButton()
        Me.btnNUltimo = New System.Windows.Forms.ToolStripButton()
        Me.grpOficinas = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.grParImpPred = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.chkHabilitado = New System.Windows.Forms.CheckBox()
        Me.txtResponsable = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtNombre = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.DependenciasTableAdapter = New TCMAdmin.dsCatalogosTableAdapters.dependenciasTableAdapter()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.DependenciasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCatalogos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpOficinas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpOficinas.SuspendLayout()
        Me.grParImpPred.SuspendLayout()
        CType(Me.txtResponsable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BindingSource = Me.DependenciasBindingSource
        Me.BindingNavigator1.CountItem = Me.btnNTotal
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBack, Me.btnUndo, Me.btnGuardar, Me.btnEditar, Me.btnEliminar, Me.ToolStripLabel1, Me.btnNPrimero, Me.btnNPrevio, Me.btnNCurrent, Me.btnNTotal, Me.btnNSiguiente, Me.btnNUltimo})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.btnNPrimero
        Me.BindingNavigator1.MoveLastItem = Me.btnNUltimo
        Me.BindingNavigator1.MoveNextItem = Me.btnNSiguiente
        Me.BindingNavigator1.MovePreviousItem = Me.btnNPrevio
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.btnNCurrent
        Me.BindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.BindingNavigator1.Size = New System.Drawing.Size(836, 37)
        Me.BindingNavigator1.TabIndex = 30
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'DependenciasBindingSource
        '
        Me.DependenciasBindingSource.DataMember = "dependencias"
        Me.DependenciasBindingSource.DataSource = Me.DsCatalogos
        '
        'DsCatalogos
        '
        Me.DsCatalogos.DataSetName = "dsCatalogos"
        Me.DsCatalogos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.AutoSize = False
        Me.ToolStripLabel1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(500, 34)
        Me.ToolStripLabel1.Text = "                       "
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
        Me.btnNCurrent.Font = New System.Drawing.Font("Segoe UI", 9.0!)
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
        'grpOficinas
        '
        Me.grpOficinas.Controls.Add(Me.grParImpPred)
        Me.grpOficinas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpOficinas.Enabled = False
        Me.grpOficinas.ExpandedSize = New System.Drawing.Size(836, 242)
        Me.grpOficinas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpOficinas.Location = New System.Drawing.Point(0, 37)
        Me.grpOficinas.Name = "grpOficinas"
        Me.grpOficinas.Size = New System.Drawing.Size(836, 242)
        Me.grpOficinas.TabIndex = 32
        Me.grpOficinas.Text = "Dependencias Detalle"
        Me.grpOficinas.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2000
        '
        'grParImpPred
        '
        Me.grParImpPred.Controls.Add(Me.chkHabilitado)
        Me.grParImpPred.Controls.Add(Me.txtResponsable)
        Me.grParImpPred.Controls.Add(Me.UltraLabel2)
        Me.grParImpPred.Controls.Add(Me.UltraLabel1)
        Me.grParImpPred.Controls.Add(Me.txtNombre)
        Me.grParImpPred.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grParImpPred.Location = New System.Drawing.Point(3, 19)
        Me.grParImpPred.Name = "grParImpPred"
        Me.grParImpPred.Size = New System.Drawing.Size(830, 220)
        Me.grParImpPred.TabIndex = 0
        '
        'chkHabilitado
        '
        Me.chkHabilitado.AutoSize = True
        Me.chkHabilitado.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkHabilitado.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DependenciasBindingSource, "habilitado", True))
        Me.chkHabilitado.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkHabilitado.Location = New System.Drawing.Point(205, 105)
        Me.chkHabilitado.Name = "chkHabilitado"
        Me.chkHabilitado.Size = New System.Drawing.Size(90, 18)
        Me.chkHabilitado.TabIndex = 4
        Me.chkHabilitado.Text = "Habílitado : "
        Me.chkHabilitado.UseVisualStyleBackColor = True
        '
        'txtResponsable
        '
        Me.txtResponsable.AlwaysInEditMode = True
        Appearance1.BackColor = System.Drawing.Color.White
        Appearance1.BackColor2 = System.Drawing.Color.White
        Me.txtResponsable.Appearance = Appearance1
        Me.txtResponsable.BackColor = System.Drawing.Color.White
        Me.txtResponsable.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtResponsable.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DependenciasBindingSource, "responsabl", True))
        Me.txtResponsable.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtResponsable.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResponsable.Location = New System.Drawing.Point(282, 70)
        Me.txtResponsable.MaxLength = 50
        Me.txtResponsable.Multiline = True
        Me.txtResponsable.Name = "txtResponsable"
        Me.txtResponsable.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtResponsable.Size = New System.Drawing.Size(368, 23)
        Me.txtResponsable.TabIndex = 2
        '
        'UltraLabel2
        '
        Appearance2.TextHAlignAsString = "Right"
        Me.UltraLabel2.Appearance = Appearance2
        Me.UltraLabel2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(90, 73)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(180, 16)
        Me.UltraLabel2.TabIndex = 139
        Me.UltraLabel2.Text = "Responsable:"
        Me.UltraLabel2.UseAppStyling = False
        '
        'UltraLabel1
        '
        Appearance3.TextHAlignAsString = "Right"
        Me.UltraLabel1.Appearance = Appearance3
        Me.UltraLabel1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(90, 40)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(180, 16)
        Me.UltraLabel1.TabIndex = 137
        Me.UltraLabel1.Text = "Nombre:"
        Me.UltraLabel1.UseAppStyling = False
        '
        'txtNombre
        '
        Me.txtNombre.AlwaysInEditMode = True
        Appearance4.BackColor = System.Drawing.Color.White
        Appearance4.BackColor2 = System.Drawing.Color.White
        Me.txtNombre.Appearance = Appearance4
        Me.txtNombre.BackColor = System.Drawing.Color.White
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DependenciasBindingSource, "nombre", True))
        Me.txtNombre.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtNombre.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(282, 37)
        Me.txtNombre.MaxLength = 50
        Me.txtNombre.Multiline = True
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNombre.Size = New System.Drawing.Size(368, 23)
        Me.txtNombre.TabIndex = 1
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'DependenciasTableAdapter
        '
        Me.DependenciasTableAdapter.ClearBeforeFill = True
        '
        'frmCatDependencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(836, 279)
        Me.Controls.Add(Me.grpOficinas)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.KeyPreview = True
        Me.Name = "frmCatDependencias"
        Me.Text = "Catálogo: Dependencias"
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.DependenciasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCatalogos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpOficinas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpOficinas.ResumeLayout(False)
        Me.grParImpPred.ResumeLayout(False)
        Me.grParImpPred.PerformLayout()
        CType(Me.txtResponsable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents btnNTotal As ToolStripLabel
    Friend WithEvents btnBack As ToolStripButton
    Friend WithEvents btnUndo As ToolStripButton
    Friend WithEvents btnGuardar As ToolStripButton
    Friend WithEvents btnEditar As ToolStripButton
    Friend WithEvents btnEliminar As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents btnNPrimero As ToolStripButton
    Friend WithEvents btnNPrevio As ToolStripButton
    Friend WithEvents btnNCurrent As ToolStripTextBox
    Friend WithEvents btnNSiguiente As ToolStripButton
    Friend WithEvents btnNUltimo As ToolStripButton
    Friend WithEvents grpOficinas As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents grParImpPred As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents txtResponsable As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtNombre As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents chkHabilitado As CheckBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents DsCatalogos As dsCatalogos
    Friend WithEvents DependenciasBindingSource As BindingSource
    Friend WithEvents DependenciasTableAdapter As dsCatalogosTableAdapters.dependenciasTableAdapter
End Class
