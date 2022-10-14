<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Padron_Imagenes
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
        Dim DockAreaPane1 As Infragistics.Win.UltraWinDock.DockAreaPane = New Infragistics.Win.UltraWinDock.DockAreaPane(Infragistics.Win.UltraWinDock.DockedLocation.DockedLeft, New System.Guid("b77e1739-72f6-442b-911d-77460f2ae5d3"))
        Dim DockableControlPane1 As Infragistics.Win.UltraWinDock.DockableControlPane = New Infragistics.Win.UltraWinDock.DockableControlPane(New System.Guid("1bbf8688-ee69-41c7-af7d-2efaf0f4abe6"), New System.Guid("00000000-0000-0000-0000-000000000000"), -1, New System.Guid("b77e1739-72f6-442b-911d-77460f2ae5d3"), -1)
        Me.griImagenes = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoPadron = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClavePadron = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.imageFile = New System.Windows.Forms.DataGridViewImageColumn()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.btnBack = New System.Windows.Forms.ToolStripButton()
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.btnElimina = New System.Windows.Forms.ToolStripButton()
        Me.txtexaminar = New System.Windows.Forms.ToolStripTextBox()
        Me.lblTipoPadron = New System.Windows.Forms.ToolStripLabel()
        Me.lblClavePadron = New System.Windows.Forms.ToolStripLabel()
        Me.ofdArchivos = New System.Windows.Forms.OpenFileDialog()
        Me.dokImagenes = New Infragistics.Win.UltraWinDock.UltraDockManager(Me.components)
        Me._Padron_ImagenesUnpinnedTabAreaLeft = New Infragistics.Win.UltraWinDock.UnpinnedTabArea()
        Me._Padron_ImagenesUnpinnedTabAreaRight = New Infragistics.Win.UltraWinDock.UnpinnedTabArea()
        Me._Padron_ImagenesUnpinnedTabAreaTop = New Infragistics.Win.UltraWinDock.UnpinnedTabArea()
        Me._Padron_ImagenesUnpinnedTabAreaBottom = New Infragistics.Win.UltraWinDock.UnpinnedTabArea()
        Me._Padron_ImagenesAutoHideControl = New Infragistics.Win.UltraWinDock.AutoHideControl()
        Me.WindowDockingArea1 = New Infragistics.Win.UltraWinDock.WindowDockingArea()
        Me.DockableWindow1 = New Infragistics.Win.UltraWinDock.DockableWindow()
        Me.picImagen = New System.Windows.Forms.PictureBox()
        CType(Me.griImagenes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.dokImagenes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WindowDockingArea1.SuspendLayout()
        Me.DockableWindow1.SuspendLayout()
        CType(Me.picImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'griImagenes
        '
        Me.griImagenes.AllowUserToAddRows = False
        Me.griImagenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.griImagenes.ColumnHeadersVisible = False
        Me.griImagenes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.TipoPadron, Me.ClavePadron, Me.imageFile})
        Me.griImagenes.Dock = System.Windows.Forms.DockStyle.Left
        Me.griImagenes.Location = New System.Drawing.Point(0, 18)
        Me.griImagenes.Name = "griImagenes"
        Me.griImagenes.RowHeadersVisible = False
        Me.griImagenes.RowTemplate.Height = 200
        Me.griImagenes.Size = New System.Drawing.Size(206, 600)
        Me.griImagenes.TabIndex = 9
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.Visible = False
        '
        'TipoPadron
        '
        Me.TipoPadron.DataPropertyName = "TipoPadron"
        Me.TipoPadron.HeaderText = "TipoPadron"
        Me.TipoPadron.Name = "TipoPadron"
        Me.TipoPadron.Visible = False
        '
        'ClavePadron
        '
        Me.ClavePadron.DataPropertyName = "ClavePadron"
        Me.ClavePadron.HeaderText = "ClavePadron"
        Me.ClavePadron.Name = "ClavePadron"
        Me.ClavePadron.Visible = False
        '
        'imageFile
        '
        Me.imageFile.DataPropertyName = "imageFile"
        Me.imageFile.HeaderText = "Imagen"
        Me.imageFile.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.imageFile.MinimumWidth = 200
        Me.imageFile.Name = "imageFile"
        Me.imageFile.Width = 200
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BackColor = System.Drawing.Color.Transparent
        Me.BindingNavigator1.CountItem = Nothing
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.ImageScalingSize = New System.Drawing.Size(36, 36)
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBack, Me.btnNuevo, Me.btnGuardar, Me.btnElimina, Me.txtexaminar, Me.lblTipoPadron, Me.lblClavePadron})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Nothing
        Me.BindingNavigator1.MoveLastItem = Nothing
        Me.BindingNavigator1.MoveNextItem = Nothing
        Me.BindingNavigator1.MovePreviousItem = Nothing
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.BindingNavigator1.PositionItem = Nothing
        Me.BindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.BindingNavigator1.Size = New System.Drawing.Size(1021, 43)
        Me.BindingNavigator1.TabIndex = 5
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'btnBack
        '
        Me.btnBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnBack.Image = Global.TCMAdmin.My.Resources.Resources.IconBack
        Me.btnBack.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnBack.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(28, 40)
        Me.btnBack.Text = "ToolStripButton1"
        Me.btnBack.ToolTipText = "Regresar"
        '
        'btnNuevo
        '
        Me.btnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnNuevo.Image = Global.TCMAdmin.My.Resources.Resources.IconNew
        Me.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(40, 40)
        Me.btnNuevo.Text = "ToolStripButton1"
        Me.btnNuevo.ToolTipText = "Agregar Imagen"
        '
        'btnGuardar
        '
        Me.btnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnGuardar.Image = Global.TCMAdmin.My.Resources.Resources.IconSave
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(40, 40)
        Me.btnGuardar.Text = "ToolStripButton1"
        Me.btnGuardar.ToolTipText = "Guardar Imagen"
        Me.btnGuardar.Visible = False
        '
        'btnElimina
        '
        Me.btnElimina.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnElimina.Image = Global.TCMAdmin.My.Resources.Resources.IconDelete
        Me.btnElimina.Name = "btnElimina"
        Me.btnElimina.RightToLeftAutoMirrorImage = True
        Me.btnElimina.Size = New System.Drawing.Size(40, 40)
        Me.btnElimina.Text = "Eliminar"
        Me.btnElimina.ToolTipText = "Borrar Imagen"
        Me.btnElimina.Visible = False
        '
        'txtexaminar
        '
        Me.txtexaminar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtexaminar.Name = "txtexaminar"
        Me.txtexaminar.Size = New System.Drawing.Size(100, 43)
        Me.txtexaminar.Visible = False
        '
        'lblTipoPadron
        '
        Me.lblTipoPadron.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoPadron.Name = "lblTipoPadron"
        Me.lblTipoPadron.Size = New System.Drawing.Size(0, 40)
        '
        'lblClavePadron
        '
        Me.lblClavePadron.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClavePadron.Name = "lblClavePadron"
        Me.lblClavePadron.Size = New System.Drawing.Size(0, 40)
        '
        'ofdArchivos
        '
        Me.ofdArchivos.FileName = "OpenFileDialog1"
        '
        'dokImagenes
        '
        Me.dokImagenes.CompressUnpinnedTabs = False
        DockableControlPane1.Control = Me.griImagenes
        DockableControlPane1.OriginalControlBounds = New System.Drawing.Rectangle(0, 43, 305, 429)
        DockableControlPane1.Size = New System.Drawing.Size(100, 100)
        DockableControlPane1.Text = "Imágenes "
        DockAreaPane1.Panes.AddRange(New Infragistics.Win.UltraWinDock.DockablePaneBase() {DockableControlPane1})
        DockAreaPane1.Size = New System.Drawing.Size(206, 618)
        Me.dokImagenes.DockAreas.AddRange(New Infragistics.Win.UltraWinDock.DockAreaPane() {DockAreaPane1})
        Me.dokImagenes.HostControl = Me
        '
        '_Padron_ImagenesUnpinnedTabAreaLeft
        '
        Me._Padron_ImagenesUnpinnedTabAreaLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me._Padron_ImagenesUnpinnedTabAreaLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Padron_ImagenesUnpinnedTabAreaLeft.Location = New System.Drawing.Point(0, 43)
        Me._Padron_ImagenesUnpinnedTabAreaLeft.Name = "_Padron_ImagenesUnpinnedTabAreaLeft"
        Me._Padron_ImagenesUnpinnedTabAreaLeft.Owner = Me.dokImagenes
        Me._Padron_ImagenesUnpinnedTabAreaLeft.Size = New System.Drawing.Size(0, 618)
        Me._Padron_ImagenesUnpinnedTabAreaLeft.TabIndex = 11
        '
        '_Padron_ImagenesUnpinnedTabAreaRight
        '
        Me._Padron_ImagenesUnpinnedTabAreaRight.Dock = System.Windows.Forms.DockStyle.Right
        Me._Padron_ImagenesUnpinnedTabAreaRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Padron_ImagenesUnpinnedTabAreaRight.Location = New System.Drawing.Point(1021, 43)
        Me._Padron_ImagenesUnpinnedTabAreaRight.Name = "_Padron_ImagenesUnpinnedTabAreaRight"
        Me._Padron_ImagenesUnpinnedTabAreaRight.Owner = Me.dokImagenes
        Me._Padron_ImagenesUnpinnedTabAreaRight.Size = New System.Drawing.Size(0, 618)
        Me._Padron_ImagenesUnpinnedTabAreaRight.TabIndex = 12
        '
        '_Padron_ImagenesUnpinnedTabAreaTop
        '
        Me._Padron_ImagenesUnpinnedTabAreaTop.Dock = System.Windows.Forms.DockStyle.Top
        Me._Padron_ImagenesUnpinnedTabAreaTop.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Padron_ImagenesUnpinnedTabAreaTop.Location = New System.Drawing.Point(0, 43)
        Me._Padron_ImagenesUnpinnedTabAreaTop.Name = "_Padron_ImagenesUnpinnedTabAreaTop"
        Me._Padron_ImagenesUnpinnedTabAreaTop.Owner = Me.dokImagenes
        Me._Padron_ImagenesUnpinnedTabAreaTop.Size = New System.Drawing.Size(1021, 0)
        Me._Padron_ImagenesUnpinnedTabAreaTop.TabIndex = 13
        '
        '_Padron_ImagenesUnpinnedTabAreaBottom
        '
        Me._Padron_ImagenesUnpinnedTabAreaBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me._Padron_ImagenesUnpinnedTabAreaBottom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Padron_ImagenesUnpinnedTabAreaBottom.Location = New System.Drawing.Point(0, 661)
        Me._Padron_ImagenesUnpinnedTabAreaBottom.Name = "_Padron_ImagenesUnpinnedTabAreaBottom"
        Me._Padron_ImagenesUnpinnedTabAreaBottom.Owner = Me.dokImagenes
        Me._Padron_ImagenesUnpinnedTabAreaBottom.Size = New System.Drawing.Size(1021, 0)
        Me._Padron_ImagenesUnpinnedTabAreaBottom.TabIndex = 14
        '
        '_Padron_ImagenesAutoHideControl
        '
        Me._Padron_ImagenesAutoHideControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Padron_ImagenesAutoHideControl.Location = New System.Drawing.Point(0, 0)
        Me._Padron_ImagenesAutoHideControl.Name = "_Padron_ImagenesAutoHideControl"
        Me._Padron_ImagenesAutoHideControl.Owner = Me.dokImagenes
        Me._Padron_ImagenesAutoHideControl.Size = New System.Drawing.Size(0, 0)
        Me._Padron_ImagenesAutoHideControl.TabIndex = 15
        '
        'WindowDockingArea1
        '
        Me.WindowDockingArea1.Controls.Add(Me.DockableWindow1)
        Me.WindowDockingArea1.Dock = System.Windows.Forms.DockStyle.Left
        Me.WindowDockingArea1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WindowDockingArea1.Location = New System.Drawing.Point(0, 43)
        Me.WindowDockingArea1.Name = "WindowDockingArea1"
        Me.WindowDockingArea1.Owner = Me.dokImagenes
        Me.WindowDockingArea1.Size = New System.Drawing.Size(211, 618)
        Me.WindowDockingArea1.TabIndex = 16
        '
        'DockableWindow1
        '
        Me.DockableWindow1.Controls.Add(Me.griImagenes)
        Me.DockableWindow1.Location = New System.Drawing.Point(0, 0)
        Me.DockableWindow1.Name = "DockableWindow1"
        Me.DockableWindow1.Owner = Me.dokImagenes
        Me.DockableWindow1.Size = New System.Drawing.Size(206, 618)
        Me.DockableWindow1.TabIndex = 18
        '
        'picImagen
        '
        Me.picImagen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picImagen.Location = New System.Drawing.Point(211, 43)
        Me.picImagen.Name = "picImagen"
        Me.picImagen.Size = New System.Drawing.Size(810, 618)
        Me.picImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picImagen.TabIndex = 17
        Me.picImagen.TabStop = False
        '
        'Padron_Imagenes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1021, 661)
        Me.Controls.Add(Me._Padron_ImagenesAutoHideControl)
        Me.Controls.Add(Me.picImagen)
        Me.Controls.Add(Me.WindowDockingArea1)
        Me.Controls.Add(Me._Padron_ImagenesUnpinnedTabAreaBottom)
        Me.Controls.Add(Me._Padron_ImagenesUnpinnedTabAreaTop)
        Me.Controls.Add(Me._Padron_ImagenesUnpinnedTabAreaRight)
        Me.Controls.Add(Me._Padron_ImagenesUnpinnedTabAreaLeft)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Name = "Padron_Imagenes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Imágenes asociadas "
        CType(Me.griImagenes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.dokImagenes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WindowDockingArea1.ResumeLayout(False)
        Me.DockableWindow1.ResumeLayout(False)
        CType(Me.picImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents btnBack As ToolStripButton
    Friend WithEvents btnGuardar As ToolStripButton
    Friend WithEvents btnElimina As ToolStripButton
    Friend WithEvents ofdArchivos As OpenFileDialog
    Friend WithEvents btnNuevo As ToolStripButton
    Friend WithEvents txtexaminar As ToolStripTextBox
    Friend WithEvents griImagenes As DataGridView
    Friend WithEvents dokImagenes As Infragistics.Win.UltraWinDock.UltraDockManager
    Friend WithEvents _Padron_ImagenesAutoHideControl As Infragistics.Win.UltraWinDock.AutoHideControl
    Friend WithEvents WindowDockingArea1 As Infragistics.Win.UltraWinDock.WindowDockingArea
    Friend WithEvents DockableWindow1 As Infragistics.Win.UltraWinDock.DockableWindow
    Friend WithEvents _Padron_ImagenesUnpinnedTabAreaBottom As Infragistics.Win.UltraWinDock.UnpinnedTabArea
    Friend WithEvents _Padron_ImagenesUnpinnedTabAreaTop As Infragistics.Win.UltraWinDock.UnpinnedTabArea
    Friend WithEvents _Padron_ImagenesUnpinnedTabAreaRight As Infragistics.Win.UltraWinDock.UnpinnedTabArea
    Friend WithEvents _Padron_ImagenesUnpinnedTabAreaLeft As Infragistics.Win.UltraWinDock.UnpinnedTabArea
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents TipoPadron As DataGridViewTextBoxColumn
    Friend WithEvents ClavePadron As DataGridViewTextBoxColumn
    Friend WithEvents imageFile As DataGridViewImageColumn
    Friend WithEvents picImagen As PictureBox
    Friend WithEvents lblTipoPadron As ToolStripLabel
    Friend WithEvents lblClavePadron As ToolStripLabel
End Class
