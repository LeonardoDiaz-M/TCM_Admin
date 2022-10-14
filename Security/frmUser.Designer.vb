<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUser))
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New Infragistics.Win.Misc.UltraLabel()
        Me.lblUser = New Infragistics.Win.Misc.UltraLabel()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.btnUndo = New System.Windows.Forms.ToolStripButton()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.btnElimina = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.grpDatosUsr = New Infragistics.Win.Misc.UltraGroupBox()
        Me.txtPswConfirm = New System.Windows.Forms.TextBox()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.cmbRol = New System.Windows.Forms.ComboBox()
        Me.lblRol = New Infragistics.Win.Misc.UltraLabel()
        Me.chkActive = New System.Windows.Forms.CheckBox()
        Me.txtUserId = New System.Windows.Forms.TextBox()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsAgua = New TCMAdmin.dsAgua()
        Me.Tbl_UserTableAdapter = New TCMAdmin.dsAguaTableAdapters.tbl_UserTableAdapter()
        Me.SystemMessages1 = New TCMAdmin.SystemMessages()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpDatosUsr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDatosUsr.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAgua, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Name", True))
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(114, 59)
        Me.txtNombre.MaxLength = 50
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(444, 22)
        Me.txtNombre.TabIndex = 5
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(50, 62)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(58, 17)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre:"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(55, 34)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(53, 17)
        Me.lblUser.TabIndex = 4
        Me.lblUser.Text = "User Id:"
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BackColor = System.Drawing.Color.Transparent
        Me.BindingNavigator1.BindingSource = Me.BindingSource1
        Me.BindingNavigator1.CountItem = Nothing
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnUndo, Me.btnGuardar, Me.btnElimina, Me.ToolStripSeparator1})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Nothing
        Me.BindingNavigator1.MoveLastItem = Nothing
        Me.BindingNavigator1.MoveNextItem = Nothing
        Me.BindingNavigator1.MovePreviousItem = Nothing
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Nothing
        Me.BindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.BindingNavigator1.Size = New System.Drawing.Size(743, 25)
        Me.BindingNavigator1.TabIndex = 4
        Me.BindingNavigator1.Text = "BindingNavigator1"
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
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'grpDatosUsr
        '
        Me.grpDatosUsr.Controls.Add(Me.txtPswConfirm)
        Me.grpDatosUsr.Controls.Add(Me.UltraLabel2)
        Me.grpDatosUsr.Controls.Add(Me.txtPassword)
        Me.grpDatosUsr.Controls.Add(Me.UltraLabel1)
        Me.grpDatosUsr.Controls.Add(Me.cmbRol)
        Me.grpDatosUsr.Controls.Add(Me.lblRol)
        Me.grpDatosUsr.Controls.Add(Me.chkActive)
        Me.grpDatosUsr.Controls.Add(Me.txtUserId)
        Me.grpDatosUsr.Controls.Add(Me.lblUser)
        Me.grpDatosUsr.Controls.Add(Me.txtNombre)
        Me.grpDatosUsr.Controls.Add(Me.lblNombre)
        Me.grpDatosUsr.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpDatosUsr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.grpDatosUsr.HeaderBorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grpDatosUsr.Location = New System.Drawing.Point(0, 25)
        Me.grpDatosUsr.Name = "grpDatosUsr"
        Me.grpDatosUsr.Size = New System.Drawing.Size(743, 200)
        Me.grpDatosUsr.TabIndex = 13
        Me.grpDatosUsr.Text = "Datos"
        Me.grpDatosUsr.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'txtPswConfirm
        '
        Me.txtPswConfirm.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "UserId", True))
        Me.txtPswConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPswConfirm.Location = New System.Drawing.Point(179, 156)
        Me.txtPswConfirm.MaxLength = 10
        Me.txtPswConfirm.Name = "txtPswConfirm"
        Me.txtPswConfirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtPswConfirm.Size = New System.Drawing.Size(227, 22)
        Me.txtPswConfirm.TabIndex = 55
        '
        'UltraLabel2
        '
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(38, 159)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(135, 17)
        Me.UltraLabel2.TabIndex = 54
        Me.UltraLabel2.Text = "Confirmar Password:"
        '
        'txtPassword
        '
        Me.txtPassword.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "UserId", True))
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(179, 123)
        Me.txtPassword.MaxLength = 10
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtPassword.Size = New System.Drawing.Size(227, 22)
        Me.txtPassword.TabIndex = 53
        '
        'UltraLabel1
        '
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(103, 126)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(70, 17)
        Me.UltraLabel1.TabIndex = 52
        Me.UltraLabel1.Text = "Password:"
        '
        'cmbRol
        '
        Me.cmbRol.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BindingSource1, "idRol", True))
        Me.cmbRol.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRol.FormattingEnabled = True
        Me.cmbRol.Location = New System.Drawing.Point(114, 87)
        Me.cmbRol.Name = "cmbRol"
        Me.cmbRol.Size = New System.Drawing.Size(370, 21)
        Me.cmbRol.TabIndex = 51
        '
        'lblRol
        '
        Me.lblRol.AutoSize = True
        Me.lblRol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRol.Location = New System.Drawing.Point(78, 91)
        Me.lblRol.Name = "lblRol"
        Me.lblRol.Size = New System.Drawing.Size(30, 17)
        Me.lblRol.TabIndex = 8
        Me.lblRol.Text = "Rol:"
        '
        'chkActive
        '
        Me.chkActive.AutoSize = True
        Me.chkActive.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.BindingSource1, "Status", True))
        Me.chkActive.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.BindingSource1, "Status", True))
        Me.chkActive.Location = New System.Drawing.Point(454, 31)
        Me.chkActive.Name = "chkActive"
        Me.chkActive.Size = New System.Drawing.Size(70, 20)
        Me.chkActive.TabIndex = 7
        Me.chkActive.Text = "Activo"
        Me.chkActive.UseVisualStyleBackColor = True
        '
        'txtUserId
        '
        Me.txtUserId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUserId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "UserId", True))
        Me.txtUserId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserId.Location = New System.Drawing.Point(114, 31)
        Me.txtUserId.MaxLength = 10
        Me.txtUserId.Name = "txtUserId"
        Me.txtUserId.Size = New System.Drawing.Size(180, 22)
        Me.txtUserId.TabIndex = 6
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "tbl_User"
        Me.BindingSource1.DataSource = Me.DsAgua
        '
        'DsAgua
        '
        Me.DsAgua.DataSetName = "dsAgua"
        Me.DsAgua.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_UserTableAdapter
        '
        Me.Tbl_UserTableAdapter.ClearBeforeFill = True
        '
        'SystemMessages1
        '
        Me.SystemMessages1.AutoScroll = True
        Me.SystemMessages1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.SystemMessages1.Dock = System.Windows.Forms.DockStyle.Top
        Me.SystemMessages1.Location = New System.Drawing.Point(0, 29)
        Me.SystemMessages1.Name = "SystemMessages1"
        Me.SystemMessages1.Size = New System.Drawing.Size(759, 26)
        Me.SystemMessages1.TabIndex = 7
        '
        'frmUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(743, 279)
        Me.ControlBox = False
        Me.Controls.Add(Me.grpDatosUsr)
        Me.Controls.Add(Me.SystemMessages1)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmUser"
        Me.Text = "Usuario"
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpDatosUsr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDatosUsr.ResumeLayout(False)
        Me.grpDatosUsr.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAgua, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DsAgua As TCMAdmin.dsAgua
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblUser As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnUndo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnElimina As System.Windows.Forms.ToolStripButton
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents SystemMessages1 As SystemMessages
    Friend WithEvents grpDatosUsr As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents txtUserId As TextBox
    Friend WithEvents chkActive As CheckBox
    Friend WithEvents lblRol As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cmbRol As ComboBox
    Friend WithEvents Tbl_UserTableAdapter As dsAguaTableAdapters.tbl_UserTableAdapter
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtPswConfirm As TextBox
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
End Class
