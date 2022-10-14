<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAguaRegistroConsumo_Alta
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
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.lblPeriodo = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtanio = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.uneLecturaActual = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.uneLecturaAnterior = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.optLectura = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtNombre = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtNumeroCuenta = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.btnBack = New System.Windows.Forms.ToolStripButton()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.uneConsumo = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.unePeriodo = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.Tbl_consumo_aguaTableAdapter = New TCMAdmin.dsAguaTableAdapters.tbl_consumo_aguaTableAdapter()
        Me.txtRuta = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        CType(Me.txtanio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uneLecturaActual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uneLecturaAnterior, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.optLectura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumeroCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.uneConsumo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.unePeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRuta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPeriodo
        '
        Me.lblPeriodo.AutoSize = True
        Me.lblPeriodo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPeriodo.Location = New System.Drawing.Point(244, 142)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(83, 16)
        Me.lblPeriodo.TabIndex = 87
        Me.lblPeriodo.Text = "Bimestre/Mes:"
        Me.lblPeriodo.UseAppStyling = False
        '
        'UltraLabel1
        '
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(98, 140)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(30, 16)
        Me.UltraLabel1.TabIndex = 88
        Me.UltraLabel1.Text = "Año:"
        Me.UltraLabel1.UseAppStyling = False
        '
        'txtanio
        '
        Appearance1.BackColor = System.Drawing.Color.White
        Appearance1.TextHAlignAsString = "Center"
        Me.txtanio.Appearance = Appearance1
        Me.txtanio.BackColor = System.Drawing.Color.White
        Me.txtanio.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtanio.Location = New System.Drawing.Point(133, 136)
        Me.txtanio.Name = "txtanio"
        Me.txtanio.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtanio.ReadOnly = True
        Me.txtanio.Size = New System.Drawing.Size(69, 25)
        Me.txtanio.TabIndex = 85
        Me.txtanio.UseAppStyling = False
        '
        'UltraLabel7
        '
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel7.Location = New System.Drawing.Point(396, 262)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(59, 16)
        Me.UltraLabel7.TabIndex = 100
        Me.UltraLabel7.Text = "Consumo:"
        Me.UltraLabel7.UseAppStyling = False
        '
        'UltraLabel6
        '
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel6.Location = New System.Drawing.Point(366, 231)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(86, 16)
        Me.UltraLabel6.TabIndex = 99
        Me.UltraLabel6.Text = "Lectura actual:"
        Me.UltraLabel6.UseAppStyling = False
        '
        'uneLecturaActual
        '
        Me.uneLecturaActual.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uneLecturaActual.Location = New System.Drawing.Point(460, 227)
        Me.uneLecturaActual.MinValue = 0
        Me.uneLecturaActual.Name = "uneLecturaActual"
        Me.uneLecturaActual.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.uneLecturaActual.Size = New System.Drawing.Size(100, 25)
        Me.uneLecturaActual.TabIndex = 95
        Me.uneLecturaActual.UseAppStyling = False
        '
        'UltraLabel5
        '
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel5.Location = New System.Drawing.Point(356, 202)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(96, 16)
        Me.UltraLabel5.TabIndex = 98
        Me.UltraLabel5.Text = "Lectura anterior:"
        Me.UltraLabel5.UseAppStyling = False
        '
        'uneLecturaAnterior
        '
        Me.uneLecturaAnterior.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uneLecturaAnterior.Location = New System.Drawing.Point(460, 198)
        Me.uneLecturaAnterior.MinValue = 0
        Me.uneLecturaAnterior.Name = "uneLecturaAnterior"
        Me.uneLecturaAnterior.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.uneLecturaAnterior.Size = New System.Drawing.Size(100, 25)
        Me.uneLecturaAnterior.TabIndex = 94
        Me.uneLecturaAnterior.UseAppStyling = False
        '
        'optLectura
        '
        Me.optLectura.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Appearance2.FontData.SizeInPoints = 10.0!
        Me.optLectura.ItemAppearance = Appearance2
        ValueListItem3.CheckState = System.Windows.Forms.CheckState.Checked
        ValueListItem3.DataValue = "1"
        ValueListItem3.DisplayText = "Por Lectura"
        ValueListItem1.DataValue = "2"
        ValueListItem1.DisplayText = "Por promedio de tres últimas lecturas"
        ValueListItem2.DataValue = "3"
        ValueListItem2.DisplayText = "Por Consumo minimo"
        Me.optLectura.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem3, ValueListItem1, ValueListItem2})
        Me.optLectura.ItemSpacingVertical = 5
        Me.optLectura.Location = New System.Drawing.Point(69, 188)
        Me.optLectura.Name = "optLectura"
        Me.optLectura.Size = New System.Drawing.Size(249, 74)
        Me.optLectura.TabIndex = 101
        '
        'UltraLabel9
        '
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel9.Location = New System.Drawing.Point(81, 62)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(47, 16)
        Me.UltraLabel9.TabIndex = 104
        Me.UltraLabel9.Text = "Cuenta:"
        Me.UltraLabel9.UseAppStyling = False
        '
        'UltraLabel8
        '
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel8.Location = New System.Drawing.Point(76, 91)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(52, 16)
        Me.UltraLabel8.TabIndex = 103
        Me.UltraLabel8.Text = "Nombre:"
        Me.UltraLabel8.UseAppStyling = False
        '
        'txtNombre
        '
        Me.txtNombre.AlwaysInEditMode = True
        Appearance3.BackColor = System.Drawing.Color.White
        Appearance3.BackColor2 = System.Drawing.Color.White
        Appearance3.TextVAlignAsString = "Middle"
        Me.txtNombre.Appearance = Appearance3
        Me.txtNombre.BackColor = System.Drawing.Color.White
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtNombre.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(133, 89)
        Me.txtNombre.MaxLength = 120
        Me.txtNombre.Multiline = True
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNombre.Size = New System.Drawing.Size(330, 23)
        Me.txtNombre.TabIndex = 102
        '
        'txtNumeroCuenta
        '
        Me.txtNumeroCuenta.AlwaysInEditMode = True
        Appearance4.BackColor = System.Drawing.Color.White
        Appearance4.BackColor2 = System.Drawing.Color.White
        Appearance4.TextVAlignAsString = "Middle"
        Me.txtNumeroCuenta.Appearance = Appearance4
        Me.txtNumeroCuenta.BackColor = System.Drawing.Color.White
        Me.txtNumeroCuenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroCuenta.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtNumeroCuenta.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroCuenta.Location = New System.Drawing.Point(133, 60)
        Me.txtNumeroCuenta.MaxLength = 120
        Me.txtNumeroCuenta.Multiline = True
        Me.txtNumeroCuenta.Name = "txtNumeroCuenta"
        Me.txtNumeroCuenta.ReadOnly = True
        Me.txtNumeroCuenta.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNumeroCuenta.Size = New System.Drawing.Size(118, 23)
        Me.txtNumeroCuenta.TabIndex = 105
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BackColor = System.Drawing.Color.Transparent
        Me.BindingNavigator1.CountItem = Nothing
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.ImageScalingSize = New System.Drawing.Size(36, 36)
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBack, Me.btnGuardar, Me.ToolStripLabel1})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Nothing
        Me.BindingNavigator1.MoveLastItem = Nothing
        Me.BindingNavigator1.MoveNextItem = Nothing
        Me.BindingNavigator1.MovePreviousItem = Nothing
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Nothing
        Me.BindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.BindingNavigator1.Size = New System.Drawing.Size(612, 43)
        Me.BindingNavigator1.TabIndex = 106
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
        'btnGuardar
        '
        Me.btnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnGuardar.Image = Global.TCMAdmin.My.Resources.Resources.IconSave
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(40, 40)
        Me.btnGuardar.Text = "ToolStripButton1"
        Me.btnGuardar.ToolTipText = "Guardar "
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.AutoSize = False
        Me.ToolStripLabel1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(200, 22)
        Me.ToolStripLabel1.Text = "                       "
        '
        'uneConsumo
        '
        Me.uneConsumo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uneConsumo.Location = New System.Drawing.Point(460, 256)
        Me.uneConsumo.MinValue = 0
        Me.uneConsumo.Name = "uneConsumo"
        Me.uneConsumo.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.uneConsumo.Size = New System.Drawing.Size(100, 25)
        Me.uneConsumo.TabIndex = 107
        Me.uneConsumo.UseAppStyling = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'unePeriodo
        '
        Appearance6.BackColor = System.Drawing.Color.White
        Appearance6.TextHAlignAsString = "Center"
        Me.unePeriodo.Appearance = Appearance6
        Me.unePeriodo.BackColor = System.Drawing.Color.White
        Me.unePeriodo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.unePeriodo.Location = New System.Drawing.Point(336, 137)
        Me.unePeriodo.MaxValue = 12
        Me.unePeriodo.MinValue = 0
        Me.unePeriodo.Name = "unePeriodo"
        Me.unePeriodo.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.unePeriodo.ReadOnly = True
        Me.unePeriodo.Size = New System.Drawing.Size(61, 25)
        Me.unePeriodo.TabIndex = 108
        Me.unePeriodo.UseAppStyling = False
        '
        'Tbl_consumo_aguaTableAdapter
        '
        Me.Tbl_consumo_aguaTableAdapter.ClearBeforeFill = True
        '
        'txtRuta
        '
        Me.txtRuta.AlwaysInEditMode = True
        Appearance5.BackColor = System.Drawing.Color.White
        Appearance5.BackColor2 = System.Drawing.Color.White
        Appearance5.TextVAlignAsString = "Middle"
        Me.txtRuta.Appearance = Appearance5
        Me.txtRuta.BackColor = System.Drawing.Color.White
        Me.txtRuta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRuta.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtRuta.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRuta.Location = New System.Drawing.Point(396, 60)
        Me.txtRuta.MaxLength = 120
        Me.txtRuta.Multiline = True
        Me.txtRuta.Name = "txtRuta"
        Me.txtRuta.ReadOnly = True
        Me.txtRuta.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtRuta.Size = New System.Drawing.Size(67, 23)
        Me.txtRuta.TabIndex = 110
        '
        'UltraLabel2
        '
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(356, 62)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(34, 16)
        Me.UltraLabel2.TabIndex = 109
        Me.UltraLabel2.Text = "Ruta:"
        Me.UltraLabel2.UseAppStyling = False
        '
        'frmAguaRegistroConsumo_Alta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(612, 305)
        Me.Controls.Add(Me.txtRuta)
        Me.Controls.Add(Me.UltraLabel2)
        Me.Controls.Add(Me.unePeriodo)
        Me.Controls.Add(Me.uneConsumo)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.txtNumeroCuenta)
        Me.Controls.Add(Me.UltraLabel9)
        Me.Controls.Add(Me.UltraLabel8)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.optLectura)
        Me.Controls.Add(Me.UltraLabel7)
        Me.Controls.Add(Me.UltraLabel6)
        Me.Controls.Add(Me.uneLecturaActual)
        Me.Controls.Add(Me.UltraLabel5)
        Me.Controls.Add(Me.uneLecturaAnterior)
        Me.Controls.Add(Me.lblPeriodo)
        Me.Controls.Add(Me.UltraLabel1)
        Me.Controls.Add(Me.txtanio)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmAguaRegistroConsumo_Alta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro Consumo Alta"
        CType(Me.txtanio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uneLecturaActual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uneLecturaAnterior, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.optLectura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumeroCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.uneConsumo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.unePeriodo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRuta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPeriodo As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtanio As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uneLecturaActual As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uneLecturaAnterior As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents optLectura As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtNombre As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtNumeroCuenta As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents btnBack As ToolStripButton
    Friend WithEvents btnGuardar As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents Tbl_consumo_aguaTableAdapter As dsAguaTableAdapters.tbl_consumo_aguaTableAdapter
    Friend WithEvents uneConsumo As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents unePeriodo As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents txtRuta As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
End Class
