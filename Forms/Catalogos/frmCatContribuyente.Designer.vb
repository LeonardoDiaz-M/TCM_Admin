<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCatContribuyente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCatContribuyente))
        Me.btnElimina = New System.Windows.Forms.ToolStripButton()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.btnUndo = New System.Windows.Forms.ToolStripButton()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsAgua = New TCMAdmin.dsAgua()
        Me.lblContribuyente = New Infragistics.Win.Misc.UltraLabel()
        Me.lblClave = New Infragistics.Win.Misc.UltraLabel()
        Me.txtClave = New System.Windows.Forms.MaskedTextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Tip_contribuyenteTableAdapter = New TCMAdmin.dsAguaTableAdapters.tip_contribuyenteTableAdapter()
        Me.SystemMessages1 = New TCMAdmin.SystemMessages()
        Me.grpDatosCuenta = New Infragistics.Win.Misc.UltraGroupBox()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAgua, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpDatosCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDatosCuenta.SuspendLayout()
        Me.SuspendLayout()
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
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
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
        Me.BindingSource1.DataMember = "tip_contribuyente"
        Me.BindingSource1.DataSource = Me.DsAgua
        '
        'DsAgua
        '
        Me.DsAgua.DataSetName = "dsAgua"
        Me.DsAgua.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblContribuyente
        '
        Me.lblContribuyente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContribuyente.Location = New System.Drawing.Point(166, 34)
        Me.lblContribuyente.Name = "lblContribuyente"
        Me.lblContribuyente.Size = New System.Drawing.Size(101, 22)
        Me.lblContribuyente.TabIndex = 0
        Me.lblContribuyente.Text = "Contribuyente:"
        '
        'lblClave
        '
        Me.lblClave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClave.Location = New System.Drawing.Point(45, 37)
        Me.lblClave.Name = "lblClave"
        Me.lblClave.Size = New System.Drawing.Size(26, 23)
        Me.lblClave.TabIndex = 4
        Me.lblClave.Text = "Id"
        '
        'txtClave
        '
        Me.txtClave.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "cve_tip_con", True))
        Me.txtClave.Enabled = False
        Me.txtClave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClave.Location = New System.Drawing.Point(77, 34)
        Me.txtClave.Mask = "########"
        Me.txtClave.Name = "txtClave"
        Me.txtClave.Size = New System.Drawing.Size(74, 22)
        Me.txtClave.TabIndex = 1
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Descripcion", True))
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(273, 34)
        Me.txtNombre.MaxLength = 50
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(294, 22)
        Me.txtNombre.TabIndex = 5
        '
        'Tip_contribuyenteTableAdapter
        '
        Me.Tip_contribuyenteTableAdapter.ClearBeforeFill = True
        '
        'SystemMessages1
        '
        Me.SystemMessages1.AutoScroll = True
        Me.SystemMessages1.Dock = System.Windows.Forms.DockStyle.Top
        Me.SystemMessages1.Location = New System.Drawing.Point(0, 29)
        Me.SystemMessages1.Name = "SystemMessages1"
        Me.SystemMessages1.Size = New System.Drawing.Size(614, 26)
        Me.SystemMessages1.TabIndex = 6
        '
        'grpDatosCuenta
        '
        Me.grpDatosCuenta.Controls.Add(Me.lblClave)
        Me.grpDatosCuenta.Controls.Add(Me.txtClave)
        Me.grpDatosCuenta.Controls.Add(Me.lblContribuyente)
        Me.grpDatosCuenta.Controls.Add(Me.txtNombre)
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
        'frmCatContribuyente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(634, 133)
        Me.ControlBox = False
        Me.Controls.Add(Me.grpDatosCuenta)
        Me.Controls.Add(Me.SystemMessages1)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Name = "frmCatContribuyente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catalogo Contribuyentes"
        Me.TopMost = True
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAgua, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpDatosCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDatosCuenta.ResumeLayout(False)
        Me.grpDatosCuenta.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DsAgua As TCMAdmin.dsAgua
    Friend WithEvents btnUndo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnElimina As System.Windows.Forms.ToolStripButton
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents lblContribuyente As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblClave As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtClave As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Tip_contribuyenteTableAdapter As TCMAdmin.dsAguaTableAdapters.tip_contribuyenteTableAdapter
    Friend WithEvents SystemMessages1 As SystemMessages
    Friend WithEvents grpDatosCuenta As Infragistics.Win.Misc.UltraGroupBox
End Class
