﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Administracion_CambioContrasena
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Administracion_CambioContrasena))
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.lblReviso = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtContraseñaNueva = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtConfirmaContraseñaNueva = New System.Windows.Forms.TextBox()
        Me.UltraPictureBox1 = New Infragistics.Win.UltraWinEditors.UltraPictureBox()
        Me.tsb_BarraMenu = New System.Windows.Forms.ToolStrip()
        Me.tsb_Guardar = New System.Windows.Forms.ToolStripButton()
        Me.tsb_Salir = New System.Windows.Forms.ToolStripButton()
        Me.erpError = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.tsb_BarraMenu.SuspendLayout()
        CType(Me.erpError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUser
        '
        Me.txtUser.BackColor = System.Drawing.Color.White
        Me.txtUser.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.ForeColor = System.Drawing.Color.Red
        Me.txtUser.Location = New System.Drawing.Point(354, 97)
        Me.txtUser.MaxLength = 40
        Me.txtUser.Name = "txtUser"
        Me.txtUser.ReadOnly = True
        Me.txtUser.Size = New System.Drawing.Size(152, 22)
        Me.txtUser.TabIndex = 572
        '
        'lblReviso
        '
        Me.lblReviso.AutoSize = True
        Me.lblReviso.BackColor = System.Drawing.Color.Transparent
        Me.lblReviso.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReviso.Location = New System.Drawing.Point(284, 100)
        Me.lblReviso.Name = "lblReviso"
        Me.lblReviso.Size = New System.Drawing.Size(47, 14)
        Me.lblReviso.TabIndex = 571
        Me.lblReviso.Text = "User ID"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(267, 128)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 14)
        Me.Label7.TabIndex = 574
        Me.Label7.Text = "Contraseña"
        '
        'txtContraseña
        '
        Me.txtContraseña.BackColor = System.Drawing.Color.White
        Me.txtContraseña.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContraseña.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtContraseña.Location = New System.Drawing.Point(354, 125)
        Me.txtContraseña.MaxLength = 40
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseña.Size = New System.Drawing.Size(152, 22)
        Me.txtContraseña.TabIndex = 573
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(233, 176)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 14)
        Me.Label1.TabIndex = 576
        Me.Label1.Text = "Contraseña Nueva"
        '
        'txtContraseñaNueva
        '
        Me.txtContraseñaNueva.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContraseñaNueva.Location = New System.Drawing.Point(354, 173)
        Me.txtContraseñaNueva.MaxLength = 40
        Me.txtContraseñaNueva.Name = "txtContraseñaNueva"
        Me.txtContraseñaNueva.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseñaNueva.Size = New System.Drawing.Size(152, 22)
        Me.txtContraseñaNueva.TabIndex = 575
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(219, 204)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 14)
        Me.Label2.TabIndex = 578
        Me.Label2.Text = "Confirma Contraseña"
        '
        'txtConfirmaContraseñaNueva
        '
        Me.txtConfirmaContraseñaNueva.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmaContraseñaNueva.Location = New System.Drawing.Point(354, 201)
        Me.txtConfirmaContraseñaNueva.MaxLength = 40
        Me.txtConfirmaContraseñaNueva.Name = "txtConfirmaContraseñaNueva"
        Me.txtConfirmaContraseñaNueva.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmaContraseñaNueva.Size = New System.Drawing.Size(152, 22)
        Me.txtConfirmaContraseñaNueva.TabIndex = 577
        '
        'UltraPictureBox1
        '
        Appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance1.BorderColor = System.Drawing.Color.White
        Appearance1.BorderColor2 = System.Drawing.Color.White
        Appearance1.BorderColor3DBase = System.Drawing.Color.White
        Me.UltraPictureBox1.Appearance = Appearance1
        Me.UltraPictureBox1.BorderShadowColor = System.Drawing.Color.White
        Me.UltraPictureBox1.BorderStyle = Infragistics.Win.UIElementBorderStyle.Rounded1
        Me.UltraPictureBox1.Image = CType(resources.GetObject("UltraPictureBox1.Image"), Object)
        Me.UltraPictureBox1.Location = New System.Drawing.Point(574, 96)
        Me.UltraPictureBox1.Name = "UltraPictureBox1"
        Me.UltraPictureBox1.Size = New System.Drawing.Size(142, 134)
        Me.UltraPictureBox1.TabIndex = 579
        '
        'tsb_BarraMenu
        '
        Me.tsb_BarraMenu.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.tsb_BarraMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsb_Salir, Me.tsb_Guardar})
        Me.tsb_BarraMenu.Location = New System.Drawing.Point(0, 0)
        Me.tsb_BarraMenu.Name = "tsb_BarraMenu"
        Me.tsb_BarraMenu.Size = New System.Drawing.Size(994, 47)
        Me.tsb_BarraMenu.TabIndex = 580
        Me.tsb_BarraMenu.Text = "ToolStrip1"
        '
        'tsb_Guardar
        '
        Me.tsb_Guardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsb_Guardar.Image = Global.TCMAdmin.My.Resources.Resources.IconSave
        Me.tsb_Guardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_Guardar.Name = "tsb_Guardar"
        Me.tsb_Guardar.Size = New System.Drawing.Size(44, 44)
        Me.tsb_Guardar.Text = "Guardar"
        '
        'tsb_Salir
        '
        Me.tsb_Salir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsb_Salir.Image = Global.TCMAdmin.My.Resources.Resources.IconBack
        Me.tsb_Salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_Salir.Name = "tsb_Salir"
        Me.tsb_Salir.Size = New System.Drawing.Size(44, 44)
        Me.tsb_Salir.Text = "Cerrar"
        Me.tsb_Salir.ToolTipText = "Salir"
        '
        'erpError
        '
        Me.erpError.ContainerControl = Me
        '
        'Administracion_CambioContrasena
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(994, 328)
        Me.ControlBox = False
        Me.Controls.Add(Me.tsb_BarraMenu)
        Me.Controls.Add(Me.UltraPictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtConfirmaContraseñaNueva)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtContraseñaNueva)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.lblReviso)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtContraseña)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Administracion_CambioContrasena"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cambio Contraseña"
        Me.tsb_BarraMenu.ResumeLayout(False)
        Me.tsb_BarraMenu.PerformLayout()
        CType(Me.erpError, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents lblReviso As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtContraseña As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtContraseñaNueva As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtConfirmaContraseñaNueva As System.Windows.Forms.TextBox
    Friend WithEvents UltraPictureBox1 As Infragistics.Win.UltraWinEditors.UltraPictureBox
    Friend WithEvents tsb_BarraMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents tsb_Guardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsb_Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents erpError As System.Windows.Forms.ErrorProvider
End Class
