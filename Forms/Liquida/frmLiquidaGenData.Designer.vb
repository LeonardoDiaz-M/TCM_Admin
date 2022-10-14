<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLiquidaGenData
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("tip_predio", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("tipo_predio", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("descripcion")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.lblCurrentMenu = New System.Windows.Forms.ToolStripLabel()
        Me.grpInfoREq = New Infragistics.Win.Misc.UltraGroupBox()
        Me.txtOrdPAgo = New System.Windows.Forms.TextBox()
        Me.txtObservacion = New System.Windows.Forms.TextBox()
        Me.lblObs = New System.Windows.Forms.Label()
        Me.lblOrdPag = New Infragistics.Win.Misc.UltraLabel()
        Me.mskDimension = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.lblConcPago = New Infragistics.Win.Misc.UltraLabel()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.cmbPago = New System.Windows.Forms.ComboBox()
        Me.txtDomicilio = New System.Windows.Forms.TextBox()
        Me.mskRFC = New System.Windows.Forms.MaskedTextBox()
        Me.lblNombre = New Infragistics.Win.Misc.UltraLabel()
        Me.lblDomicilio = New Infragistics.Win.Misc.UltraLabel()
        Me.lblCantidad = New Infragistics.Win.Misc.UltraLabel()
        Me.lblRFC = New System.Windows.Forms.Label()
        Me.lblFolREc = New System.Windows.Forms.Label()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.grdDataMain = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.tblButtons = New System.Windows.Forms.TableLayoutPanel()
        Me.bntLiquida = New System.Windows.Forms.Button()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnPago = New System.Windows.Forms.Button()
        Me.btnImprimeRpt = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.grpInfoREq, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpInfoREq.SuspendLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.grdDataMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tblButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BackColor = System.Drawing.Color.Transparent
        Me.BindingNavigator1.CountItem = Nothing
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.lblCurrentMenu})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Nothing
        Me.BindingNavigator1.MoveLastItem = Nothing
        Me.BindingNavigator1.MoveNextItem = Nothing
        Me.BindingNavigator1.MovePreviousItem = Nothing
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Nothing
        Me.BindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.BindingNavigator1.Size = New System.Drawing.Size(825, 25)
        Me.BindingNavigator1.TabIndex = 17
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.AutoSize = False
        Me.ToolStripLabel1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(200, 22)
        Me.ToolStripLabel1.Text = "                       "
        '
        'lblCurrentMenu
        '
        Me.lblCurrentMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentMenu.ForeColor = System.Drawing.Color.Blue
        Me.lblCurrentMenu.Name = "lblCurrentMenu"
        Me.lblCurrentMenu.Size = New System.Drawing.Size(119, 22)
        Me.lblCurrentMenu.Text = "ToolStripLabel2"
        '
        'grpInfoREq
        '
        Appearance1.BackColor = System.Drawing.Color.White
        Appearance1.BorderColor = System.Drawing.Color.Gray
        Appearance1.TextHAlignAsString = "Center"
        Me.grpInfoREq.Appearance = Appearance1
        Me.grpInfoREq.Controls.Add(Me.txtOrdPAgo)
        Me.grpInfoREq.Controls.Add(Me.txtObservacion)
        Me.grpInfoREq.Controls.Add(Me.lblObs)
        Me.grpInfoREq.Controls.Add(Me.lblOrdPag)
        Me.grpInfoREq.Controls.Add(Me.mskDimension)
        Me.grpInfoREq.Controls.Add(Me.lblConcPago)
        Me.grpInfoREq.Controls.Add(Me.txtNombre)
        Me.grpInfoREq.Controls.Add(Me.cmbPago)
        Me.grpInfoREq.Controls.Add(Me.txtDomicilio)
        Me.grpInfoREq.Controls.Add(Me.mskRFC)
        Me.grpInfoREq.Controls.Add(Me.lblNombre)
        Me.grpInfoREq.Controls.Add(Me.lblDomicilio)
        Me.grpInfoREq.Controls.Add(Me.lblCantidad)
        Me.grpInfoREq.Controls.Add(Me.lblRFC)
        Me.grpInfoREq.Controls.Add(Me.lblFolREc)
        Me.grpInfoREq.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpInfoREq.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpInfoREq.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance6.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance6.BorderColor = System.Drawing.Color.Gray
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Appearance6.TextHAlignAsString = "Center"
        Appearance6.TextTrimming = Infragistics.Win.TextTrimming.None
        Appearance6.TextVAlignAsString = "Middle"
        Me.grpInfoREq.HeaderAppearance = Appearance6
        Me.grpInfoREq.HeaderBorderStyle = Infragistics.Win.UIElementBorderStyle.Rounded1
        Me.grpInfoREq.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOnBorder
        Me.grpInfoREq.Location = New System.Drawing.Point(0, 25)
        Me.grpInfoREq.Name = "grpInfoREq"
        Me.grpInfoREq.Size = New System.Drawing.Size(825, 321)
        Me.grpInfoREq.TabIndex = 19
        Me.grpInfoREq.Text = "Datos del Pago"
        Me.grpInfoREq.VerticalTextOrientation = Infragistics.Win.Misc.GroupBoxVerticalTextOrientation.BottomToTop
        Me.grpInfoREq.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2000
        '
        'txtOrdPAgo
        '
        Me.txtOrdPAgo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOrdPAgo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrdPAgo.Location = New System.Drawing.Point(346, 235)
        Me.txtOrdPAgo.Name = "txtOrdPAgo"
        Me.txtOrdPAgo.Size = New System.Drawing.Size(108, 20)
        Me.txtOrdPAgo.TabIndex = 76
        '
        'txtObservacion
        '
        Me.txtObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservacion.Location = New System.Drawing.Point(133, 269)
        Me.txtObservacion.MaxLength = 150
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(652, 34)
        Me.txtObservacion.TabIndex = 75
        Me.txtObservacion.Text = "123456789012345678901234567890123456789012345678901234567890123456789012345678901" &
    "234567890123456789012345678901234567890"
        '
        'lblObs
        '
        Me.lblObs.AutoSize = True
        Me.lblObs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObs.ForeColor = System.Drawing.Color.Black
        Me.lblObs.Location = New System.Drawing.Point(24, 270)
        Me.lblObs.Name = "lblObs"
        Me.lblObs.Size = New System.Drawing.Size(103, 16)
        Me.lblObs.TabIndex = 74
        Me.lblObs.Text = "Observaciones:"
        Me.lblObs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOrdPag
        '
        Appearance2.ForeColor = System.Drawing.Color.Black
        Me.lblOrdPag.Appearance = Appearance2
        Me.lblOrdPag.AutoSize = True
        Me.lblOrdPag.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrdPag.Location = New System.Drawing.Point(241, 238)
        Me.lblOrdPag.Name = "lblOrdPag"
        Me.lblOrdPag.Size = New System.Drawing.Size(99, 17)
        Me.lblOrdPag.TabIndex = 73
        Me.lblOrdPag.Text = "Orden de Pago:"
        '
        'mskDimension
        '
        Appearance3.FontData.SizeInPoints = 8.0!
        Me.mskDimension.Appearance = Appearance3
        Me.mskDimension.ClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeBoth
        Me.mskDimension.DataMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.Raw
        Me.mskDimension.DisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.Raw
        Me.mskDimension.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.mskDimension.InputMask = "{double:-9.4}"
        Me.mskDimension.Location = New System.Drawing.Point(133, 236)
        Me.mskDimension.Name = "mskDimension"
        Me.mskDimension.NonAutoSizeHeight = 26
        Appearance4.TextHAlignAsString = "Right"
        Appearance4.TextTrimming = Infragistics.Win.TextTrimming.Word
        Me.mskDimension.PromptCharacterAppearance = Appearance4
        Me.mskDimension.Size = New System.Drawing.Size(87, 22)
        Me.mskDimension.TabIndex = 72
        Me.mskDimension.TextRenderingMode = Infragistics.Win.TextRenderingMode.GDIPlus
        Me.mskDimension.UseAppStyling = False
        Me.mskDimension.UseFlatMode = Infragistics.Win.DefaultableBoolean.[True]
        '
        'lblConcPago
        '
        Me.lblConcPago.AutoSize = True
        Me.lblConcPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConcPago.Location = New System.Drawing.Point(8, 203)
        Me.lblConcPago.Name = "lblConcPago"
        Me.lblConcPago.Size = New System.Drawing.Size(119, 17)
        Me.lblConcPago.TabIndex = 55
        Me.lblConcPago.Text = "Concepto de Pago:"
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(136, 82)
        Me.txtNombre.MaxLength = 120
        Me.txtNombre.Multiline = True
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(649, 34)
        Me.txtNombre.TabIndex = 54
        Me.txtNombre.Text = "123456789012345678901234567890123456789012345678901234567890123456789012345678901" &
    "234567890123456789012345678901234567890"
        '
        'cmbPago
        '
        Me.cmbPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPago.FormattingEnabled = True
        Me.cmbPago.Location = New System.Drawing.Point(136, 202)
        Me.cmbPago.Name = "cmbPago"
        Me.cmbPago.Size = New System.Drawing.Size(649, 21)
        Me.cmbPago.TabIndex = 53
        '
        'txtDomicilio
        '
        Me.txtDomicilio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDomicilio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDomicilio.Location = New System.Drawing.Point(136, 156)
        Me.txtDomicilio.MaxLength = 120
        Me.txtDomicilio.Multiline = True
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.Size = New System.Drawing.Size(649, 35)
        Me.txtDomicilio.TabIndex = 51
        Me.txtDomicilio.Text = "123456789012345678901234567890123456789012345678901234567890123456789012345678901" &
    "234567890123456789012345678901234567890"
        '
        'mskRFC
        '
        Me.mskRFC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskRFC.Location = New System.Drawing.Point(136, 125)
        Me.mskRFC.Mask = "LLLL000000AAA"
        Me.mskRFC.Name = "mskRFC"
        Me.mskRFC.Size = New System.Drawing.Size(107, 20)
        Me.mskRFC.TabIndex = 52
        '
        'lblNombre
        '
        Appearance5.TextHAlignAsString = "Left"
        Me.lblNombre.Appearance = Appearance5
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(79, 83)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(63, 19)
        Me.lblNombre.TabIndex = 47
        Me.lblNombre.Text = "Nombre :"
        '
        'lblDomicilio
        '
        Me.lblDomicilio.AutoSize = True
        Me.lblDomicilio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDomicilio.Location = New System.Drawing.Point(28, 157)
        Me.lblDomicilio.Name = "lblDomicilio"
        Me.lblDomicilio.Size = New System.Drawing.Size(102, 17)
        Me.lblDomicilio.TabIndex = 48
        Me.lblDomicilio.Text = "Domicilio Fiscal:"
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad.Location = New System.Drawing.Point(65, 241)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(62, 17)
        Me.lblCantidad.TabIndex = 49
        Me.lblCantidad.Text = "Cantidad:"
        '
        'lblRFC
        '
        Me.lblRFC.AutoSize = True
        Me.lblRFC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRFC.Location = New System.Drawing.Point(83, 129)
        Me.lblRFC.Name = "lblRFC"
        Me.lblRFC.Size = New System.Drawing.Size(47, 16)
        Me.lblRFC.TabIndex = 50
        Me.lblRFC.Text = "R.F.C.:"
        '
        'lblFolREc
        '
        Me.lblFolREc.AutoSize = True
        Me.lblFolREc.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFolREc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblFolREc.Location = New System.Drawing.Point(22, 45)
        Me.lblFolREc.Name = "lblFolREc"
        Me.lblFolREc.Size = New System.Drawing.Size(120, 19)
        Me.lblFolREc.TabIndex = 44
        Me.lblFolREc.Text = "Folio de Recibo:"
        Me.lblFolREc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UltraGroupBox1
        '
        Appearance7.TextHAlignAsString = "Center"
        Me.UltraGroupBox1.Appearance = Appearance7
        Me.UltraGroupBox1.BorderStyle = Infragistics.Win.Misc.GroupBoxBorderStyle.HeaderSolid
        Me.UltraGroupBox1.Controls.Add(Me.grdDataMain)
        Me.UltraGroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance21.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance21.BorderColor = System.Drawing.Color.Gray
        Appearance21.ForeColor = System.Drawing.Color.Navy
        Appearance21.TextHAlignAsString = "Center"
        Appearance21.TextTrimming = Infragistics.Win.TextTrimming.None
        Appearance21.TextVAlignAsString = "Middle"
        Me.UltraGroupBox1.HeaderAppearance = Appearance21
        Me.UltraGroupBox1.HeaderBorderStyle = Infragistics.Win.UIElementBorderStyle.Rounded1
        Me.UltraGroupBox1.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOnBorder
        Me.UltraGroupBox1.Location = New System.Drawing.Point(0, 346)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(825, 194)
        Me.UltraGroupBox1.TabIndex = 23
        Me.UltraGroupBox1.Text = "Estado de Cuenta"
        Me.UltraGroupBox1.VerticalTextOrientation = Infragistics.Win.Misc.GroupBoxVerticalTextOrientation.BottomToTop
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2000
        '
        'grdDataMain
        '
        Appearance8.BackColor = System.Drawing.SystemColors.Window
        Appearance8.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.grdDataMain.DisplayLayout.Appearance = Appearance8
        Me.grdDataMain.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn1.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Width = 382
        UltraGridColumn2.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 439
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2})
        Me.grdDataMain.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.grdDataMain.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grdDataMain.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.grdDataMain.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
        Me.grdDataMain.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.AlignWithDataRows
        Appearance9.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance9.BorderColor = System.Drawing.SystemColors.Window
        Me.grdDataMain.DisplayLayout.GroupByBox.Appearance = Appearance9
        Appearance10.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grdDataMain.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance10
        Me.grdDataMain.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance11.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance11.BackColor2 = System.Drawing.SystemColors.Control
        Appearance11.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance11.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grdDataMain.DisplayLayout.GroupByBox.PromptAppearance = Appearance11
        Appearance12.BackColor = System.Drawing.SystemColors.Window
        Appearance12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grdDataMain.DisplayLayout.Override.ActiveCellAppearance = Appearance12
        Appearance13.BackColor = System.Drawing.SystemColors.Highlight
        Appearance13.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.grdDataMain.DisplayLayout.Override.ActiveRowAppearance = Appearance13
        Me.grdDataMain.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        Me.grdDataMain.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.grdDataMain.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Me.grdDataMain.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.grdDataMain.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
        Me.grdDataMain.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.grdDataMain.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.grdDataMain.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance14.BackColor = System.Drawing.SystemColors.Window
        Me.grdDataMain.DisplayLayout.Override.CardAreaAppearance = Appearance14
        Appearance15.BorderColor = System.Drawing.Color.Silver
        Appearance15.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.grdDataMain.DisplayLayout.Override.CellAppearance = Appearance15
        Me.grdDataMain.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.grdDataMain.DisplayLayout.Override.CellPadding = 0
        Me.grdDataMain.DisplayLayout.Override.FilterClearButtonLocation = Infragistics.Win.UltraWinGrid.FilterClearButtonLocation.Cell
        Me.grdDataMain.DisplayLayout.Override.FilterEvaluationTrigger = Infragistics.Win.UltraWinGrid.FilterEvaluationTrigger.OnCellValueChange
        Me.grdDataMain.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.[Like]
        Me.grdDataMain.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance16.BackColor = System.Drawing.SystemColors.Control
        Appearance16.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance16.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance16.BorderColor = System.Drawing.SystemColors.Window
        Me.grdDataMain.DisplayLayout.Override.GroupByRowAppearance = Appearance16
        Me.grdDataMain.DisplayLayout.Override.GroupBySummaryDisplayStyle = Infragistics.Win.UltraWinGrid.GroupBySummaryDisplayStyle.SummaryCells
        Appearance17.BackColor = System.Drawing.Color.Gray
        Appearance17.BackColor2 = System.Drawing.Color.Gray
        Appearance17.FontData.BoldAsString = "True"
        Appearance17.ForeColor = System.Drawing.Color.White
        Appearance17.TextHAlignAsString = "Left"
        Me.grdDataMain.DisplayLayout.Override.HeaderAppearance = Appearance17
        Me.grdDataMain.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle
        Me.grdDataMain.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance18.BackColor = System.Drawing.Color.Gainsboro
        Appearance18.BackColor2 = System.Drawing.Color.Gainsboro
        Me.grdDataMain.DisplayLayout.Override.RowAlternateAppearance = Appearance18
        Appearance19.BackColor = System.Drawing.SystemColors.Window
        Appearance19.BorderColor = System.Drawing.Color.Silver
        Me.grdDataMain.DisplayLayout.Override.RowAppearance = Appearance19
        Me.grdDataMain.DisplayLayout.Override.RowFilterMode = Infragistics.Win.UltraWinGrid.RowFilterMode.AllRowsInBand
        Me.grdDataMain.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Me.grdDataMain.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.grdDataMain.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.grdDataMain.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.grdDataMain.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.grdDataMain.DisplayLayout.Override.SupportDataErrorInfo = Infragistics.Win.UltraWinGrid.SupportDataErrorInfo.RowsOnly
        Appearance20.BackColor = System.Drawing.SystemColors.ControlLight
        Me.grdDataMain.DisplayLayout.Override.TemplateAddRowAppearance = Appearance20
        Me.grdDataMain.DisplayLayout.Override.TipStyleScroll = Infragistics.Win.UltraWinGrid.TipStyle.Hide
        Me.grdDataMain.DisplayLayout.Override.WrapHeaderText = Infragistics.Win.DefaultableBoolean.[True]
        Me.grdDataMain.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grdDataMain.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grdDataMain.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.grdDataMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdDataMain.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdDataMain.Location = New System.Drawing.Point(1, 34)
        Me.grdDataMain.Name = "grdDataMain"
        Me.grdDataMain.Size = New System.Drawing.Size(823, 159)
        Me.grdDataMain.TabIndex = 11
        Me.grdDataMain.Text = "Datos"
        '
        'tblButtons
        '
        Me.tblButtons.ColumnCount = 7
        Me.tblButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tblButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tblButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tblButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tblButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tblButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tblButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tblButtons.Controls.Add(Me.bntLiquida, 0, 0)
        Me.tblButtons.Controls.Add(Me.txtTotal, 6, 0)
        Me.tblButtons.Controls.Add(Me.lblTotal, 5, 0)
        Me.tblButtons.Controls.Add(Me.btnPago, 1, 0)
        Me.tblButtons.Controls.Add(Me.btnImprimeRpt, 2, 0)
        Me.tblButtons.Controls.Add(Me.btnCerrar, 3, 0)
        Me.tblButtons.Dock = System.Windows.Forms.DockStyle.Top
        Me.tblButtons.Location = New System.Drawing.Point(0, 540)
        Me.tblButtons.Name = "tblButtons"
        Me.tblButtons.RowCount = 1
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.tblButtons.Size = New System.Drawing.Size(825, 29)
        Me.tblButtons.TabIndex = 24
        '
        'bntLiquida
        '
        Me.bntLiquida.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bntLiquida.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntLiquida.ForeColor = System.Drawing.Color.Red
        Me.bntLiquida.Location = New System.Drawing.Point(3, 3)
        Me.bntLiquida.Name = "bntLiquida"
        Me.bntLiquida.Size = New System.Drawing.Size(76, 23)
        Me.bntLiquida.TabIndex = 77
        Me.bntLiquida.Text = "&Liquidar"
        Me.bntLiquida.UseVisualStyleBackColor = True
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTotal.Enabled = False
        Me.txtTotal.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(700, 3)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(122, 25)
        Me.txtTotal.TabIndex = 53
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTotal.Location = New System.Drawing.Point(577, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(117, 29)
        Me.lblTotal.TabIndex = 49
        Me.lblTotal.Text = "Total: $"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnPago
        '
        Me.btnPago.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnPago.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPago.ForeColor = System.Drawing.Color.Navy
        Me.btnPago.Location = New System.Drawing.Point(85, 3)
        Me.btnPago.Name = "btnPago"
        Me.btnPago.Size = New System.Drawing.Size(117, 23)
        Me.btnPago.TabIndex = 41
        Me.btnPago.Text = "&Imprimir Liquidación"
        Me.btnPago.UseVisualStyleBackColor = True
        '
        'btnImprimeRpt
        '
        Me.btnImprimeRpt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnImprimeRpt.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimeRpt.ForeColor = System.Drawing.Color.Navy
        Me.btnImprimeRpt.Location = New System.Drawing.Point(208, 3)
        Me.btnImprimeRpt.Name = "btnImprimeRpt"
        Me.btnImprimeRpt.Size = New System.Drawing.Size(117, 23)
        Me.btnImprimeRpt.TabIndex = 40
        Me.btnImprimeRpt.Text = "&Imprimir Recibo"
        Me.btnImprimeRpt.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCerrar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ForeColor = System.Drawing.Color.Navy
        Me.btnCerrar.Location = New System.Drawing.Point(331, 3)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(117, 23)
        Me.btnCerrar.TabIndex = 39
        Me.btnCerrar.Text = "&Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'frmLiquidaGenData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(825, 573)
        Me.Controls.Add(Me.tblButtons)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Controls.Add(Me.grpInfoREq)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Name = "frmLiquidaGenData"
        Me.Text = "frmLiquidaGenData"
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.grpInfoREq, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpInfoREq.ResumeLayout(False)
        Me.grpInfoREq.PerformLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        CType(Me.grdDataMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tblButtons.ResumeLayout(False)
        Me.tblButtons.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents lblCurrentMenu As ToolStripLabel
    Friend WithEvents grpInfoREq As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents lblFolREc As Label
    Friend WithEvents cmbPago As ComboBox
    Friend WithEvents txtDomicilio As TextBox
    Friend WithEvents mskRFC As MaskedTextBox
    Friend WithEvents lblNombre As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblDomicilio As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblCantidad As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblRFC As Label
    Friend WithEvents lblConcPago As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblOrdPag As Infragistics.Win.Misc.UltraLabel
    Private WithEvents mskDimension As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents txtObservacion As TextBox
    Friend WithEvents lblObs As Label
    Friend WithEvents txtOrdPAgo As TextBox
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents grdDataMain As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents tblButtons As TableLayoutPanel
    Friend WithEvents bntLiquida As Button
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnImprimeRpt As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnPago As Button
End Class
