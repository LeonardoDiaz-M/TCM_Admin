﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCatDiasInhabiles
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCatDiasInhabiles))
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.TbldiasinhabilesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsParametros = New TCMAdmin.dsParametros()
        Me.btnNTotal = New System.Windows.Forms.ToolStripLabel()
        Me.btnBack = New System.Windows.Forms.ToolStripButton()
        Me.btnUndo = New System.Windows.Forms.ToolStripButton()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.btnEditar = New System.Windows.Forms.ToolStripButton()
        Me.btnElimina = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.lblCurrentMenu = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.btnNPrimero = New System.Windows.Forms.ToolStripButton()
        Me.btnNPrevio = New System.Windows.Forms.ToolStripButton()
        Me.btnNCurrent = New System.Windows.Forms.ToolStripTextBox()
        Me.btnNSiguiente = New System.Windows.Forms.ToolStripButton()
        Me.btnNUltimo = New System.Windows.Forms.ToolStripButton()
        Me.grpOficinas = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.grParImpPred = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.dtpFecha = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.txtObservacion = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.Tbl_dias_inhabilesTableAdapter = New TCMAdmin.dsParametrosTableAdapters.tbl_dias_inhabilesTableAdapter()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.TbldiasinhabilesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsParametros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpOficinas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpOficinas.SuspendLayout()
        Me.grParImpPred.SuspendLayout()
        CType(Me.dtpFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtObservacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BackColor = System.Drawing.Color.White
        Me.BindingNavigator1.BindingSource = Me.TbldiasinhabilesBindingSource
        Me.BindingNavigator1.CountItem = Me.btnNTotal
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBack, Me.btnUndo, Me.btnGuardar, Me.btnEditar, Me.btnElimina, Me.ToolStripSeparator1, Me.ToolStripLabel1, Me.lblCurrentMenu, Me.ToolStripLabel2, Me.btnNPrimero, Me.btnNPrevio, Me.btnNCurrent, Me.btnNTotal, Me.btnNSiguiente, Me.btnNUltimo})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.btnNPrimero
        Me.BindingNavigator1.MoveLastItem = Me.btnNUltimo
        Me.BindingNavigator1.MoveNextItem = Me.btnNSiguiente
        Me.BindingNavigator1.MovePreviousItem = Me.btnNPrevio
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.btnNCurrent
        Me.BindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.BindingNavigator1.Size = New System.Drawing.Size(852, 37)
        Me.BindingNavigator1.TabIndex = 30
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'TbldiasinhabilesBindingSource
        '
        Me.TbldiasinhabilesBindingSource.DataMember = "tbl_dias_inhabiles"
        Me.TbldiasinhabilesBindingSource.DataSource = Me.DsParametros
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
        Me.btnNTotal.Size = New System.Drawing.Size(35, 34)
        Me.btnNTotal.Text = "of {0}"
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
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 37)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(40, 34)
        Me.ToolStripLabel1.Text = "           "
        '
        'lblCurrentMenu
        '
        Me.lblCurrentMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentMenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCurrentMenu.Name = "lblCurrentMenu"
        Me.lblCurrentMenu.Size = New System.Drawing.Size(119, 34)
        Me.lblCurrentMenu.Text = "ToolStripLabel2"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(40, 34)
        Me.ToolStripLabel2.Text = "           "
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
        Me.grpOficinas.ExpandedSize = New System.Drawing.Size(852, 185)
        Me.grpOficinas.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.None
        Me.grpOficinas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpOficinas.Location = New System.Drawing.Point(0, 37)
        Me.grpOficinas.Name = "grpOficinas"
        Me.grpOficinas.Size = New System.Drawing.Size(852, 185)
        Me.grpOficinas.TabIndex = 0
        Me.grpOficinas.Text = "Días Inhábiles detalle"
        Me.grpOficinas.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'grParImpPred
        '
        Me.grParImpPred.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.grParImpPred.Controls.Add(Me.dtpFecha)
        Me.grParImpPred.Controls.Add(Me.txtObservacion)
        Me.grParImpPred.Controls.Add(Me.UltraLabel3)
        Me.grParImpPred.Controls.Add(Me.UltraLabel1)
        Me.grParImpPred.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grParImpPred.Location = New System.Drawing.Point(2, 21)
        Me.grParImpPred.Name = "grParImpPred"
        Me.grParImpPred.Size = New System.Drawing.Size(848, 162)
        Me.grParImpPred.TabIndex = 0
        '
        'dtpFecha
        '
        Me.dtpFecha.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbldiasinhabilesBindingSource, "fecha", True))
        Me.dtpFecha.Location = New System.Drawing.Point(282, 59)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(144, 24)
        Me.dtpFecha.TabIndex = 0
        '
        'txtObservacion
        '
        Me.txtObservacion.AlwaysInEditMode = True
        Appearance1.BackColor = System.Drawing.Color.White
        Appearance1.BackColor2 = System.Drawing.Color.White
        Me.txtObservacion.Appearance = Appearance1
        Me.txtObservacion.BackColor = System.Drawing.Color.White
        Me.txtObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbldiasinhabilesBindingSource, "observacion", True))
        Me.txtObservacion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtObservacion.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservacion.Location = New System.Drawing.Point(282, 89)
        Me.txtObservacion.MaxLength = 60
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtObservacion.Size = New System.Drawing.Size(368, 23)
        Me.txtObservacion.TabIndex = 1
        '
        'UltraLabel3
        '
        Appearance2.TextHAlignAsString = "Right"
        Me.UltraLabel3.Appearance = Appearance2
        Me.UltraLabel3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(90, 92)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(180, 16)
        Me.UltraLabel3.TabIndex = 138
        Me.UltraLabel3.Text = "Observación:"
        Me.UltraLabel3.UseAppStyling = False
        '
        'UltraLabel1
        '
        Appearance3.TextHAlignAsString = "Right"
        Me.UltraLabel1.Appearance = Appearance3
        Me.UltraLabel1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(90, 64)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(180, 16)
        Me.UltraLabel1.TabIndex = 137
        Me.UltraLabel1.Text = "Fecha:"
        Me.UltraLabel1.UseAppStyling = False
        '
        'Tbl_dias_inhabilesTableAdapter
        '
        Me.Tbl_dias_inhabilesTableAdapter.ClearBeforeFill = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmCatDiasInhabiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(852, 222)
        Me.ControlBox = False
        Me.Controls.Add(Me.grpOficinas)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.KeyPreview = True
        Me.Name = "frmCatDiasInhabiles"
        Me.Text = "Catálogo: Días Inhabiles"
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.TbldiasinhabilesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsParametros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpOficinas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpOficinas.ResumeLayout(False)
        Me.grParImpPred.ResumeLayout(False)
        Me.grParImpPred.PerformLayout()
        CType(Me.dtpFecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtObservacion, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnElimina As ToolStripButton
    Friend WithEvents btnNPrimero As ToolStripButton
    Friend WithEvents btnNPrevio As ToolStripButton
    Friend WithEvents btnNCurrent As ToolStripTextBox
    Friend WithEvents btnNSiguiente As ToolStripButton
    Friend WithEvents btnNUltimo As ToolStripButton
    Friend WithEvents grpOficinas As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents grParImpPred As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents dtpFecha As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents txtObservacion As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents DsParametros As dsParametros
    Friend WithEvents TbldiasinhabilesBindingSource As BindingSource
    Friend WithEvents Tbl_dias_inhabilesTableAdapter As dsParametrosTableAdapters.tbl_dias_inhabilesTableAdapter
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents lblCurrentMenu As ToolStripLabel
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
End Class
