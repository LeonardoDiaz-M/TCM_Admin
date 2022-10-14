<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Seguridad_Permisos_Usuario
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
        Me.tosUsuariosEnRoles = New System.Windows.Forms.ToolStrip()
        Me.tsb_Salir = New System.Windows.Forms.ToolStripButton()
        Me.tsbQuitarUsuario = New System.Windows.Forms.ToolStripButton()
        Me.tsbOtorgaPermisos = New System.Windows.Forms.ToolStripButton()
        Me.treeMenu = New Infragistics.Win.UltraWinTree.UltraTree()
        Me.tosUsuariosEnRoles.SuspendLayout()
        CType(Me.treeMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tosUsuariosEnRoles
        '
        Me.tosUsuariosEnRoles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tosUsuariosEnRoles.ImageScalingSize = New System.Drawing.Size(36, 36)
        Me.tosUsuariosEnRoles.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsb_Salir, Me.tsbQuitarUsuario, Me.tsbOtorgaPermisos})
        Me.tosUsuariosEnRoles.Location = New System.Drawing.Point(0, 0)
        Me.tosUsuariosEnRoles.Name = "tosUsuariosEnRoles"
        Me.tosUsuariosEnRoles.Size = New System.Drawing.Size(947, 43)
        Me.tosUsuariosEnRoles.TabIndex = 185
        Me.tosUsuariosEnRoles.Text = "ToolStrip3"
        '
        'tsb_Salir
        '
        Me.tsb_Salir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsb_Salir.Image = Global.TCMAdmin.My.Resources.Resources.IconBack
        Me.tsb_Salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_Salir.Name = "tsb_Salir"
        Me.tsb_Salir.Size = New System.Drawing.Size(40, 40)
        Me.tsb_Salir.Text = "Cerrar"
        Me.tsb_Salir.ToolTipText = "Salir"
        '
        'tsbQuitarUsuario
        '
        Me.tsbQuitarUsuario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbQuitarUsuario.Image = Global.TCMAdmin.My.Resources.Resources.Quitar1
        Me.tsbQuitarUsuario.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbQuitarUsuario.Name = "tsbQuitarUsuario"
        Me.tsbQuitarUsuario.Size = New System.Drawing.Size(40, 40)
        Me.tsbQuitarUsuario.Text = "ToolStripButton1"
        Me.tsbQuitarUsuario.ToolTipText = "Quitar Permiso"
        '
        'tsbOtorgaPermisos
        '
        Me.tsbOtorgaPermisos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbOtorgaPermisos.Image = Global.TCMAdmin.My.Resources.Resources.Agrega
        Me.tsbOtorgaPermisos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbOtorgaPermisos.Name = "tsbOtorgaPermisos"
        Me.tsbOtorgaPermisos.Size = New System.Drawing.Size(40, 40)
        Me.tsbOtorgaPermisos.Text = "ToolStripButton2"
        Me.tsbOtorgaPermisos.ToolTipText = "Agregar Permiso"
        '
        'treeMenu
        '
        Me.treeMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.treeMenu.Location = New System.Drawing.Point(0, 43)
        Me.treeMenu.Name = "treeMenu"
        Me.treeMenu.Size = New System.Drawing.Size(369, 464)
        Me.treeMenu.TabIndex = 186
        '
        'Seguridad_Permisos_Usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(947, 507)
        Me.Controls.Add(Me.treeMenu)
        Me.Controls.Add(Me.tosUsuariosEnRoles)
        Me.Name = "Seguridad_Permisos_Usuario"
        Me.Text = "Seguridad_Permisos_Usuario"
        Me.tosUsuariosEnRoles.ResumeLayout(False)
        Me.tosUsuariosEnRoles.PerformLayout()
        CType(Me.treeMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tosUsuariosEnRoles As ToolStrip
    Friend WithEvents tsb_Salir As ToolStripButton
    Friend WithEvents tsbQuitarUsuario As ToolStripButton
    Friend WithEvents tsbOtorgaPermisos As ToolStripButton
    Friend WithEvents treeMenu As Infragistics.Win.UltraWinTree.UltraTree
End Class
