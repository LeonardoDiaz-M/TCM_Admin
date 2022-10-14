<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRol
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRol))
        Dim UltraTreeColumnSet1 As Infragistics.Win.UltraWinTree.UltraTreeColumnSet = New Infragistics.Win.UltraWinTree.UltraTreeColumnSet()
        Dim UltraTreeNodeColumn1 As Infragistics.Win.UltraWinTree.UltraTreeNodeColumn = New Infragistics.Win.UltraWinTree.UltraTreeNodeColumn()
        Dim UltraTreeNodeColumn2 As Infragistics.Win.UltraWinTree.UltraTreeNodeColumn = New Infragistics.Win.UltraWinTree.UltraTreeNodeColumn()
        Dim UltraTreeNodeColumn3 As Infragistics.Win.UltraWinTree.UltraTreeNodeColumn = New Infragistics.Win.UltraWinTree.UltraTreeNodeColumn()
        Dim UltraTreeNodeColumn4 As Infragistics.Win.UltraWinTree.UltraTreeNodeColumn = New Infragistics.Win.UltraWinTree.UltraTreeNodeColumn()
        Dim UltraTreeNodeColumn5 As Infragistics.Win.UltraWinTree.UltraTreeNodeColumn = New Infragistics.Win.UltraWinTree.UltraTreeNodeColumn()
        Dim UltraTreeColumnSet2 As Infragistics.Win.UltraWinTree.UltraTreeColumnSet = New Infragistics.Win.UltraWinTree.UltraTreeColumnSet()
        Dim UltraTreeNodeColumn6 As Infragistics.Win.UltraWinTree.UltraTreeNodeColumn = New Infragistics.Win.UltraWinTree.UltraTreeNodeColumn()
        Dim UltraTreeNodeColumn7 As Infragistics.Win.UltraWinTree.UltraTreeNodeColumn = New Infragistics.Win.UltraWinTree.UltraTreeNodeColumn()
        Dim UltraTreeNodeColumn8 As Infragistics.Win.UltraWinTree.UltraTreeNodeColumn = New Infragistics.Win.UltraWinTree.UltraTreeNodeColumn()
        Dim UltraTreeNodeColumn9 As Infragistics.Win.UltraWinTree.UltraTreeNodeColumn = New Infragistics.Win.UltraWinTree.UltraTreeNodeColumn()
        Dim UltraTreeNodeColumn10 As Infragistics.Win.UltraWinTree.UltraTreeNodeColumn = New Infragistics.Win.UltraWinTree.UltraTreeNodeColumn()
        Me.txtRolDesc = New System.Windows.Forms.TextBox()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsAgua = New TCMAdmin.dsAgua()
        Me.lblNombre = New Infragistics.Win.Misc.UltraLabel()
        Me.lblClave = New Infragistics.Win.Misc.UltraLabel()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.btnUndo = New System.Windows.Forms.ToolStripButton()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.btnElimina = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.grpDatosRol = New Infragistics.Win.Misc.UltraGroupBox()
        Me.chkActive = New System.Windows.Forms.CheckBox()
        Me.txtRol = New System.Windows.Forms.TextBox()
        Me.grpTree = New Infragistics.Win.Misc.UltraGroupBox()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.UltraTree1 = New Infragistics.Win.UltraWinTree.UltraTree()
        Me.BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FKtblUsertblRolBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_RolTableAdapter = New TCMAdmin.dsAguaTableAdapters.tbl_RolTableAdapter()
        Me.Tbl_UserTableAdapter = New TCMAdmin.dsAguaTableAdapters.tbl_UserTableAdapter()
        Me.Tbl_ProfileTableAdapter = New TCMAdmin.dsAguaTableAdapters.tbl_ProfileTableAdapter()
        Me.QryMenuActiveBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QryMenuActiveTableAdapter = New TCMAdmin.dsAguaTableAdapters.QryMenuActiveTableAdapter()
        Me.SystemMessages1 = New TCMAdmin.SystemMessages()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAgua, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpDatosRol, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDatosRol.SuspendLayout()
        CType(Me.grpTree, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTree.SuspendLayout()
        CType(Me.UltraTree1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKtblUsertblRolBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QryMenuActiveBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtRolDesc
        '
        Me.txtRolDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRolDesc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Description", True))
        Me.txtRolDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRolDesc.Location = New System.Drawing.Point(114, 59)
        Me.txtRolDesc.MaxLength = 50
        Me.txtRolDesc.Name = "txtRolDesc"
        Me.txtRolDesc.Size = New System.Drawing.Size(444, 22)
        Me.txtRolDesc.TabIndex = 5
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "tbl_Rol"
        Me.BindingSource1.DataSource = Me.DsAgua
        '
        'DsAgua
        '
        Me.DsAgua.DataSetName = "dsAgua"
        Me.DsAgua.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(26, 62)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(82, 17)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Descripción:"
        '
        'lblClave
        '
        Me.lblClave.AutoSize = True
        Me.lblClave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClave.Location = New System.Drawing.Point(78, 34)
        Me.lblClave.Name = "lblClave"
        Me.lblClave.Size = New System.Drawing.Size(30, 17)
        Me.lblClave.TabIndex = 4
        Me.lblClave.Text = "Rol:"
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
        Me.BindingNavigator1.Size = New System.Drawing.Size(634, 25)
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
        'grpDatosRol
        '
        Me.grpDatosRol.Controls.Add(Me.chkActive)
        Me.grpDatosRol.Controls.Add(Me.txtRol)
        Me.grpDatosRol.Controls.Add(Me.lblClave)
        Me.grpDatosRol.Controls.Add(Me.txtRolDesc)
        Me.grpDatosRol.Controls.Add(Me.lblNombre)
        Me.grpDatosRol.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpDatosRol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.grpDatosRol.HeaderBorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grpDatosRol.Location = New System.Drawing.Point(0, 25)
        Me.grpDatosRol.Name = "grpDatosRol"
        Me.grpDatosRol.Size = New System.Drawing.Size(634, 100)
        Me.grpDatosRol.TabIndex = 13
        Me.grpDatosRol.Text = "Datos"
        Me.grpDatosRol.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'chkActive
        '
        Me.chkActive.AutoSize = True
        Me.chkActive.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.BindingSource1, "Status", True))
        Me.chkActive.Location = New System.Drawing.Point(454, 31)
        Me.chkActive.Name = "chkActive"
        Me.chkActive.Size = New System.Drawing.Size(70, 20)
        Me.chkActive.TabIndex = 7
        Me.chkActive.Text = "Activo"
        Me.chkActive.UseVisualStyleBackColor = True
        '
        'txtRol
        '
        Me.txtRol.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRol.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "RolName", True))
        Me.txtRol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRol.Location = New System.Drawing.Point(114, 31)
        Me.txtRol.MaxLength = 10
        Me.txtRol.Name = "txtRol"
        Me.txtRol.Size = New System.Drawing.Size(180, 22)
        Me.txtRol.TabIndex = 6
        '
        'grpTree
        '
        Me.grpTree.Controls.Add(Me.TreeView1)
        Me.grpTree.Controls.Add(Me.UltraTree1)
        Me.grpTree.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpTree.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.grpTree.HeaderBorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grpTree.Location = New System.Drawing.Point(0, 125)
        Me.grpTree.Name = "grpTree"
        Me.grpTree.Size = New System.Drawing.Size(634, 385)
        Me.grpTree.TabIndex = 14
        Me.grpTree.Text = "Seleccione los menus"
        Me.grpTree.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'TreeView1
        '
        Me.TreeView1.BackColor = System.Drawing.Color.White
        Me.TreeView1.CheckBoxes = True
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.Location = New System.Drawing.Point(2, 21)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(630, 362)
        Me.TreeView1.TabIndex = 1
        '
        'UltraTree1
        '
        UltraTreeNodeColumn1.ButtonDisplayStyle = Infragistics.Win.UltraWinTree.ButtonDisplayStyle.Always
        UltraTreeNodeColumn1.DataType = GetType(Integer)
        UltraTreeNodeColumn1.Key = "idRol"
        UltraTreeNodeColumn2.ButtonDisplayStyle = Infragistics.Win.UltraWinTree.ButtonDisplayStyle.Always
        UltraTreeNodeColumn2.DataType = GetType(String)
        UltraTreeNodeColumn2.Key = "RolName"
        UltraTreeNodeColumn3.ButtonDisplayStyle = Infragistics.Win.UltraWinTree.ButtonDisplayStyle.Always
        UltraTreeNodeColumn3.DataType = GetType(String)
        UltraTreeNodeColumn3.Key = "Description"
        UltraTreeNodeColumn4.ButtonDisplayStyle = Infragistics.Win.UltraWinTree.ButtonDisplayStyle.Always
        UltraTreeNodeColumn4.DataType = GetType(Integer)
        UltraTreeNodeColumn4.Key = "Status"
        UltraTreeNodeColumn5.ButtonDisplayStyle = Infragistics.Win.UltraWinTree.ButtonDisplayStyle.Always
        UltraTreeNodeColumn5.DataType = GetType(System.ComponentModel.IBindingList)
        UltraTreeNodeColumn5.IsChaptered = True
        UltraTreeNodeColumn5.Key = "FK_tbl_User_tbl_Rol"
        UltraTreeColumnSet1.Columns.Add(UltraTreeNodeColumn1)
        UltraTreeColumnSet1.Columns.Add(UltraTreeNodeColumn2)
        UltraTreeColumnSet1.Columns.Add(UltraTreeNodeColumn3)
        UltraTreeColumnSet1.Columns.Add(UltraTreeNodeColumn4)
        UltraTreeColumnSet1.Columns.Add(UltraTreeNodeColumn5)
        UltraTreeColumnSet1.IsAutoGenerated = True
        UltraTreeNodeColumn6.ButtonDisplayStyle = Infragistics.Win.UltraWinTree.ButtonDisplayStyle.Always
        UltraTreeNodeColumn6.DataType = GetType(String)
        UltraTreeNodeColumn6.Key = "UserId"
        UltraTreeNodeColumn7.ButtonDisplayStyle = Infragistics.Win.UltraWinTree.ButtonDisplayStyle.Always
        UltraTreeNodeColumn7.DataType = GetType(String)
        UltraTreeNodeColumn7.Key = "Name"
        UltraTreeNodeColumn8.ButtonDisplayStyle = Infragistics.Win.UltraWinTree.ButtonDisplayStyle.Always
        UltraTreeNodeColumn8.DataType = GetType(Integer)
        UltraTreeNodeColumn8.Key = "idRol"
        UltraTreeNodeColumn9.ButtonDisplayStyle = Infragistics.Win.UltraWinTree.ButtonDisplayStyle.Always
        UltraTreeNodeColumn9.DataType = GetType(Integer)
        UltraTreeNodeColumn9.Key = "Nomina"
        UltraTreeNodeColumn10.ButtonDisplayStyle = Infragistics.Win.UltraWinTree.ButtonDisplayStyle.Always
        UltraTreeNodeColumn10.DataType = GetType(Integer)
        UltraTreeNodeColumn10.Key = "Status"
        UltraTreeColumnSet2.Columns.Add(UltraTreeNodeColumn6)
        UltraTreeColumnSet2.Columns.Add(UltraTreeNodeColumn7)
        UltraTreeColumnSet2.Columns.Add(UltraTreeNodeColumn8)
        UltraTreeColumnSet2.Columns.Add(UltraTreeNodeColumn9)
        UltraTreeColumnSet2.Columns.Add(UltraTreeNodeColumn10)
        UltraTreeColumnSet2.IsAutoGenerated = True
        UltraTreeColumnSet2.Key = "FK_tbl_User_tbl_Rol"
        Me.UltraTree1.ColumnSettings.ColumnSets.Add(UltraTreeColumnSet1)
        Me.UltraTree1.ColumnSettings.ColumnSets.Add(UltraTreeColumnSet2)
        Me.UltraTree1.DataSource = Me.BindingSource2
        Me.UltraTree1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTree1.Location = New System.Drawing.Point(2, 21)
        Me.UltraTree1.Name = "UltraTree1"
        Me.UltraTree1.Size = New System.Drawing.Size(630, 362)
        Me.UltraTree1.TabIndex = 0
        '
        'BindingSource2
        '
        Me.BindingSource2.DataMember = "tbl_Profile"
        Me.BindingSource2.DataSource = Me.DsAgua
        '
        'FKtblUsertblRolBindingSource
        '
        Me.FKtblUsertblRolBindingSource.DataMember = "FK_tbl_User_tbl_Rol"
        Me.FKtblUsertblRolBindingSource.DataSource = Me.BindingSource1
        '
        'Tbl_RolTableAdapter
        '
        Me.Tbl_RolTableAdapter.ClearBeforeFill = True
        '
        'Tbl_UserTableAdapter
        '
        Me.Tbl_UserTableAdapter.ClearBeforeFill = True
        '
        'Tbl_ProfileTableAdapter
        '
        Me.Tbl_ProfileTableAdapter.ClearBeforeFill = True
        '
        'QryMenuActiveBindingSource
        '
        Me.QryMenuActiveBindingSource.DataMember = "QryMenuActive"
        Me.QryMenuActiveBindingSource.DataSource = Me.DsAgua
        '
        'QryMenuActiveTableAdapter
        '
        Me.QryMenuActiveTableAdapter.ClearBeforeFill = True
        '
        'SystemMessages1
        '
        Me.SystemMessages1.AutoScroll = True
        Me.SystemMessages1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.SystemMessages1.Dock = System.Windows.Forms.DockStyle.Top
        Me.SystemMessages1.Location = New System.Drawing.Point(0, 29)
        Me.SystemMessages1.Name = "SystemMessages1"
        Me.SystemMessages1.Size = New System.Drawing.Size(650, 26)
        Me.SystemMessages1.TabIndex = 7
        '
        'frmRol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(634, 510)
        Me.ControlBox = False
        Me.Controls.Add(Me.grpTree)
        Me.Controls.Add(Me.grpDatosRol)
        Me.Controls.Add(Me.SystemMessages1)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmRol"
        Me.Text = "Rol"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAgua, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpDatosRol, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDatosRol.ResumeLayout(False)
        Me.grpDatosRol.PerformLayout()
        CType(Me.grpTree, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTree.ResumeLayout(False)
        CType(Me.UltraTree1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKtblUsertblRolBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QryMenuActiveBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DsAgua As TCMAdmin.dsAgua
    Friend WithEvents txtRolDesc As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblClave As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnUndo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnElimina As System.Windows.Forms.ToolStripButton
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents SystemMessages1 As SystemMessages
    Friend WithEvents grpDatosRol As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents txtRol As TextBox
    Friend WithEvents Tbl_RolTableAdapter As dsAguaTableAdapters.tbl_RolTableAdapter
    Friend WithEvents chkActive As CheckBox
    Friend WithEvents grpTree As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraTree1 As Infragistics.Win.UltraWinTree.UltraTree
    Friend WithEvents FKtblUsertblRolBindingSource As BindingSource
    Friend WithEvents Tbl_UserTableAdapter As dsAguaTableAdapters.tbl_UserTableAdapter
    Friend WithEvents BindingSource2 As BindingSource
    Friend WithEvents Tbl_ProfileTableAdapter As dsAguaTableAdapters.tbl_ProfileTableAdapter
    Friend WithEvents QryMenuActiveBindingSource As BindingSource
    Friend WithEvents QryMenuActiveTableAdapter As dsAguaTableAdapters.QryMenuActiveTableAdapter
    Friend WithEvents TreeView1 As TreeView
End Class
