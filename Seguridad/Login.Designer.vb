<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraPanel1 = New Infragistics.Win.Misc.UltraPanel()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.UltraActivityIndicator1 = New Infragistics.Win.UltraActivityIndicator.UltraActivityIndicator()
        Me.txtNombreUsuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtClaveAcceso = New System.Windows.Forms.TextBox()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblClaveAcceso = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.butIngresar = New Infragistics.Win.Misc.UltraButton()
        Me.butSalir = New Infragistics.Win.Misc.UltraButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.UltraPanel1.ClientArea.SuspendLayout()
        Me.UltraPanel1.SuspendLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraLabel4
        '
        Appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom20Bright
        Appearance1.FontData.BoldAsString = "True"
        Appearance1.FontData.SizeInPoints = 9.0!
        Appearance1.ForeColor = System.Drawing.Color.White
        Appearance1.TextVAlignAsString = "Middle"
        Me.UltraLabel4.Appearance = Appearance1
        Me.UltraLabel4.Location = New System.Drawing.Point(7, 260)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(692, 44)
        Me.UltraLabel4.TabIndex = 18
        '
        'UltraPanel1
        '
        Appearance2.BackColor = System.Drawing.Color.White
        Appearance2.BackColor2 = System.Drawing.Color.White
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.GlassRight50
        Me.UltraPanel1.Appearance = Appearance2
        '
        'UltraPanel1.ClientArea
        '
        Me.UltraPanel1.ClientArea.Controls.Add(Me.LogoPictureBox)
        Me.UltraPanel1.ClientArea.Controls.Add(Me.UltraActivityIndicator1)
        Me.UltraPanel1.ClientArea.Controls.Add(Me.txtNombreUsuario)
        Me.UltraPanel1.ClientArea.Controls.Add(Me.Label2)
        Me.UltraPanel1.ClientArea.Controls.Add(Me.UltraLabel5)
        Me.UltraPanel1.ClientArea.Controls.Add(Me.txtClaveAcceso)
        Me.UltraPanel1.ClientArea.Controls.Add(Me.lblUsuario)
        Me.UltraPanel1.ClientArea.Controls.Add(Me.lblClaveAcceso)
        Me.UltraPanel1.ClientArea.Controls.Add(Me.txtUsuario)
        Me.UltraPanel1.Location = New System.Drawing.Point(7, 25)
        Me.UltraPanel1.Name = "UltraPanel1"
        Me.UltraPanel1.Size = New System.Drawing.Size(692, 236)
        Me.UltraPanel1.TabIndex = 17
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = Global.TCMAdmin.My.Resources.Resources.LogoMpio
        Me.LogoPictureBox.Location = New System.Drawing.Point(28, 46)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(328, 135)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 26
        Me.LogoPictureBox.TabStop = False
        '
        'UltraActivityIndicator1
        '
        Me.UltraActivityIndicator1.AnimationEnabled = True
        Me.UltraActivityIndicator1.AnimationSpeed = 50
        Me.UltraActivityIndicator1.CausesValidation = True
        Me.UltraActivityIndicator1.Location = New System.Drawing.Point(-1, 228)
        Me.UltraActivityIndicator1.Name = "UltraActivityIndicator1"
        Me.UltraActivityIndicator1.Size = New System.Drawing.Size(790, 8)
        Me.UltraActivityIndicator1.TabIndex = 25
        Me.UltraActivityIndicator1.TabStop = True
        Me.UltraActivityIndicator1.ViewStyle = Infragistics.Win.UltraActivityIndicator.ActivityIndicatorViewStyle.Aero
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreUsuario.ForeColor = System.Drawing.Color.Green
        Me.txtNombreUsuario.Location = New System.Drawing.Point(535, 200)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNombreUsuario.Size = New System.Drawing.Size(120, 22)
        Me.txtNombreUsuario.TabIndex = 23
        Me.txtNombreUsuario.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(266, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(227, 22)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Sistema Tributario Catastral"
        '
        'UltraLabel5
        '
        Appearance3.BackColor = System.Drawing.Color.White
        Appearance3.BackColor2 = System.Drawing.Color.PowderBlue
        Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalWithGlassRight50
        Appearance3.FontData.Name = "Microsoft Sans Serif"
        Appearance3.FontData.SizeInPoints = 11.25!
        Appearance3.ForeColor = System.Drawing.Color.White
        Appearance3.TextHAlignAsString = "Center"
        Me.UltraLabel5.Appearance = Appearance3
        Me.UltraLabel5.Location = New System.Drawing.Point(406, 24)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(1, 198)
        Me.UltraLabel5.TabIndex = 13
        '
        'txtClaveAcceso
        '
        Me.txtClaveAcceso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClaveAcceso.ForeColor = System.Drawing.Color.Red
        Me.txtClaveAcceso.Location = New System.Drawing.Point(514, 159)
        Me.txtClaveAcceso.Name = "txtClaveAcceso"
        Me.txtClaveAcceso.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtClaveAcceso.Size = New System.Drawing.Size(145, 22)
        Me.txtClaveAcceso.TabIndex = 11
        Me.txtClaveAcceso.Text = "1"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.BackColor = System.Drawing.Color.Transparent
        Me.lblUsuario.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.ForeColor = System.Drawing.Color.Black
        Me.lblUsuario.Location = New System.Drawing.Point(455, 121)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(52, 14)
        Me.lblUsuario.TabIndex = 0
        Me.lblUsuario.Text = "Usuario"
        '
        'lblClaveAcceso
        '
        Me.lblClaveAcceso.AutoSize = True
        Me.lblClaveAcceso.BackColor = System.Drawing.Color.Transparent
        Me.lblClaveAcceso.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClaveAcceso.ForeColor = System.Drawing.Color.Black
        Me.lblClaveAcceso.Location = New System.Drawing.Point(422, 162)
        Me.lblClaveAcceso.Name = "lblClaveAcceso"
        Me.lblClaveAcceso.Size = New System.Drawing.Size(85, 14)
        Me.lblClaveAcceso.TabIndex = 1
        Me.lblClaveAcceso.Text = "Clave Acceso"
        '
        'txtUsuario
        '
        Me.txtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.ForeColor = System.Drawing.Color.Red
        Me.txtUsuario.Location = New System.Drawing.Point(514, 117)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(145, 22)
        Me.txtUsuario.TabIndex = 2
        Me.txtUsuario.Text = "Administrador"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(178, 280)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 17)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "PRODUCCIÓN"
        '
        'UltraLabel2
        '
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.GlassTop20Bright
        Appearance4.FontData.BoldAsString = "True"
        Appearance4.FontData.SizeInPoints = 9.0!
        Appearance4.ForeColor = System.Drawing.Color.Black
        Appearance4.TextVAlignAsString = "Middle"
        Me.UltraLabel2.Appearance = Appearance4
        Me.UltraLabel2.Location = New System.Drawing.Point(5, 2)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(650, 23)
        Me.UltraLabel2.TabIndex = 16
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(58, 284)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Ver. 2019.Abril.1"
        '
        'butIngresar
        '
        Appearance5.Image = CType(resources.GetObject("Appearance5.Image"), Object)
        Appearance5.ImageHAlign = Infragistics.Win.HAlign.Left
        Appearance5.ImageVAlign = Infragistics.Win.VAlign.Middle
        Me.butIngresar.Appearance = Appearance5
        Me.butIngresar.ImageSize = New System.Drawing.Size(32, 32)
        Me.butIngresar.Location = New System.Drawing.Point(424, 267)
        Me.butIngresar.Name = "butIngresar"
        Me.butIngresar.Size = New System.Drawing.Size(118, 37)
        Me.butIngresar.TabIndex = 19
        Me.butIngresar.Text = "Ingresar"
        '
        'butSalir
        '
        Me.butSalir.ImageSize = New System.Drawing.Size(32, 32)
        Me.butSalir.Location = New System.Drawing.Point(549, 267)
        Me.butSalir.Name = "butSalir"
        Me.butSalir.Size = New System.Drawing.Size(118, 37)
        Me.butSalir.TabIndex = 20
        Me.butSalir.Text = "Salir"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(710, 313)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.butIngresar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.butSalir)
        Me.Controls.Add(Me.UltraLabel4)
        Me.Controls.Add(Me.UltraPanel1)
        Me.Controls.Add(Me.UltraLabel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.UltraPanel1.ClientArea.ResumeLayout(False)
        Me.UltraPanel1.ClientArea.PerformLayout()
        Me.UltraPanel1.ResumeLayout(False)
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraPanel1 As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtClaveAcceso As System.Windows.Forms.TextBox
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents lblClaveAcceso As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents butIngresar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents butSalir As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNombreUsuario As System.Windows.Forms.TextBox
    Friend WithEvents UltraActivityIndicator1 As Infragistics.Win.UltraActivityIndicator.UltraActivityIndicator
    Friend WithEvents LogoPictureBox As PictureBox
End Class
