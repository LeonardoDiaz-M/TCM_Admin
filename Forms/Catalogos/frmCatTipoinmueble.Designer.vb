<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCatTipoinmueble
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCatTipoinmueble))
        Me.DsAgua = New TCMAdmin.dsAgua()
        Me.lblNomCorto = New Infragistics.Win.Misc.UltraLabel()
        Me.lblClave = New Infragistics.Win.Misc.UltraLabel()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnUndo = New System.Windows.Forms.ToolStripButton()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.btnElimina = New System.Windows.Forms.ToolStripButton()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lblNombre = New Infragistics.Win.Misc.UltraLabel()
        Me.txtClave = New System.Windows.Forms.MaskedTextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtNomCorto = New System.Windows.Forms.TextBox()
        Me.Tipo_inmuebleTableAdapter = New TCMAdmin.dsAguaTableAdapters.tipo_inmuebleTableAdapter()
        Me.SystemMessages1 = New TCMAdmin.SystemMessages()
        Me.grpDatosCuenta = New Infragistics.Win.Misc.UltraGroupBox()
        CType(Me.DsAgua, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpDatosCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDatosCuenta.SuspendLayout()
        Me.SuspendLayout()
        '
        'DsAgua
        '
        Me.DsAgua.DataSetName = "dsAgua"
        Me.DsAgua.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblNomCorto
        '
        Me.lblNomCorto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomCorto.Location = New System.Drawing.Point(191, 31)
        Me.lblNomCorto.Name = "lblNomCorto"
        Me.lblNomCorto.Size = New System.Drawing.Size(106, 22)
        Me.lblNomCorto.TabIndex = 1
        Me.lblNomCorto.Text = "Nombre Corto:"
        '
        'lblClave
        '
        Me.lblClave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClave.Location = New System.Drawing.Point(36, 33)
        Me.lblClave.Name = "lblClave"
        Me.lblClave.Size = New System.Drawing.Size(56, 23)
        Me.lblClave.TabIndex = 4
        Me.lblClave.Text = "Clave:"
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BackColor = System.Drawing.Color.Transparent
        Me.BindingNavigator1.BindingSource = Me.BindingSource1
        Me.BindingNavigator1.CountItem = Nothing
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnUndo, Me.btnGuardar, Me.btnElimina})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Nothing
        Me.BindingNavigator1.MoveLastItem = Nothing
        Me.BindingNavigator1.MoveNextItem = Nothing
        Me.BindingNavigator1.MovePreviousItem = Nothing
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Nothing
        Me.BindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.BindingNavigator1.Size = New System.Drawing.Size(634, 25)
        Me.BindingNavigator1.TabIndex = 4
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "tipo_inmueble"
        Me.BindingSource1.DataSource = Me.DsAgua
        '
        'btnUndo
        '
        Me.btnUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnUndo.Image = Global.TCMAdmin.My.Resources.Resources.back
        Me.btnUndo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(23, 22)
        Me.btnUndo.Text = "ToolStripButton1"
        Me.btnUndo.ToolTipText = "Deshacer cambios"
        '
        'btnGuardar
        '
        Me.btnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnGuardar.Image = Global.TCMAdmin.My.Resources.Resources.save
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(23, 22)
        Me.btnGuardar.Text = "ToolStripButton1"
        Me.btnGuardar.ToolTipText = "Guardar Datos"
        '
        'btnElimina
        '
        Me.btnElimina.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnElimina.Image = CType(resources.GetObject("btnElimina.Image"), System.Drawing.Image)
        Me.btnElimina.Name = "btnElimina"
        Me.btnElimina.RightToLeftAutoMirrorImage = True
        Me.btnElimina.Size = New System.Drawing.Size(23, 22)
        Me.btnElimina.Text = "Eliminar"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'lblNombre
        '
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(24, 62)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(68, 22)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre:"
        '
        'txtClave
        '
        Me.txtClave.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "clave", True))
        Me.txtClave.Enabled = False
        Me.txtClave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClave.Location = New System.Drawing.Point(98, 30)
        Me.txtClave.Mask = "########"
        Me.txtClave.Name = "txtClave"
        Me.txtClave.Size = New System.Drawing.Size(75, 20)
        Me.txtClave.TabIndex = 1
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "nombre", True))
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(98, 59)
        Me.txtNombre.MaxLength = 50
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(444, 22)
        Me.txtNombre.TabIndex = 5
        '
        'txtNomCorto
        '
        Me.txtNomCorto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNomCorto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "nom_corto", True))
        Me.txtNomCorto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomCorto.Location = New System.Drawing.Point(303, 28)
        Me.txtNomCorto.MaxLength = 2
        Me.txtNomCorto.Name = "txtNomCorto"
        Me.txtNomCorto.Size = New System.Drawing.Size(100, 22)
        Me.txtNomCorto.TabIndex = 6
        '
        'Tipo_inmuebleTableAdapter
        '
        Me.Tipo_inmuebleTableAdapter.ClearBeforeFill = True
        '
        'SystemMessages1
        '
        Me.SystemMessages1.AutoScroll = True
        Me.SystemMessages1.Dock = System.Windows.Forms.DockStyle.Top
        Me.SystemMessages1.Location = New System.Drawing.Point(13, 29)
        Me.SystemMessages1.Name = "SystemMessages1"
        Me.SystemMessages1.Size = New System.Drawing.Size(614, 26)
        Me.SystemMessages1.TabIndex = 7
        '
        'grpDatosCuenta
        '
        Me.grpDatosCuenta.Controls.Add(Me.lblClave)
        Me.grpDatosCuenta.Controls.Add(Me.txtClave)
        Me.grpDatosCuenta.Controls.Add(Me.lblNombre)
        Me.grpDatosCuenta.Controls.Add(Me.txtNombre)
        Me.grpDatosCuenta.Controls.Add(Me.lblNomCorto)
        Me.grpDatosCuenta.Controls.Add(Me.txtNomCorto)
        Me.grpDatosCuenta.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpDatosCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.grpDatosCuenta.HeaderBorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grpDatosCuenta.Location = New System.Drawing.Point(0, 25)
        Me.grpDatosCuenta.Name = "grpDatosCuenta"
        Me.grpDatosCuenta.Size = New System.Drawing.Size(634, 89)
        Me.grpDatosCuenta.TabIndex = 13
        Me.grpDatosCuenta.Text = "Datos"
        Me.grpDatosCuenta.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'frmCatTipoinmueble
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(634, 124)
        Me.Controls.Add(Me.grpDatosCuenta)
        Me.Controls.Add(Me.SystemMessages1)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmCatTipoinmueble"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tipo de Inmueble"
        Me.TopMost = True
        CType(Me.DsAgua, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpDatosCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDatosCuenta.ResumeLayout(False)
        Me.grpDatosCuenta.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DsAgua As TCMAdmin.dsAgua
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents btnUndo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnElimina As System.Windows.Forms.ToolStripButton
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtClave As System.Windows.Forms.MaskedTextBox
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Tipo_inmuebleTableAdapter As TCMAdmin.dsAguaTableAdapters.tipo_inmuebleTableAdapter
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtNomCorto As System.Windows.Forms.TextBox
    Private WithEvents lblNomCorto As Infragistics.Win.Misc.UltraLabel
    Private WithEvents lblClave As Infragistics.Win.Misc.UltraLabel
    Private WithEvents lblNombre As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents SystemMessages1 As SystemMessages
    Friend WithEvents grpDatosCuenta As Infragistics.Win.Misc.UltraGroupBox
End Class
