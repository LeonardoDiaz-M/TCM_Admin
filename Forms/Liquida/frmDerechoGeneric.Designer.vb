<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDerechoGeneric
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
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("tip_predio", -1)
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("tipo_predio")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("descripcion")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.lblCurrentMenu = New System.Windows.Forms.ToolStripLabel()
        Me.SystemMessages1 = New TCMAdmin.SystemMessages()
        Me.grdDataMain = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.txtOrdenPago = New System.Windows.Forms.TextBox()
        Me.cmbDerecho = New System.Windows.Forms.ComboBox()
        Me.mskRFC = New System.Windows.Forms.MaskedTextBox()
        Me.txtDir = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblCommon1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblFolioRec = New System.Windows.Forms.Label()
        Me.lblObs = New System.Windows.Forms.Label()
        Me.lblFolREc = New System.Windows.Forms.Label()
        Me.lblNumCuenta = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnPago = New System.Windows.Forms.Button()
        Me.btnImprimeRpt = New System.Windows.Forms.Button()
        Me.tblButtons = New System.Windows.Forms.TableLayoutPanel()
        Me.btnLiquidar = New System.Windows.Forms.Button()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.txtObservacion = New System.Windows.Forms.TextBox()
        Me.grpInfoREq = New Infragistics.Win.Misc.UltraGroupBox()
        Me.txtCommon1 = New System.Windows.Forms.TextBox()
        Me.UltraMessageBoxManager1 = New Infragistics.Win.UltraMessageBox.UltraMessageBoxManager(Me.components)
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.grdDataMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tblButtons.SuspendLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.grpInfoREq, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpInfoREq.SuspendLayout()
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
        Me.BindingNavigator1.Size = New System.Drawing.Size(967, 25)
        Me.BindingNavigator1.TabIndex = 19
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
        'SystemMessages1
        '
        Me.SystemMessages1.AutoScroll = True
        Me.SystemMessages1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.SystemMessages1.Dock = System.Windows.Forms.DockStyle.Top
        Me.SystemMessages1.Location = New System.Drawing.Point(0, 29)
        Me.SystemMessages1.Name = "SystemMessages1"
        Me.SystemMessages1.Size = New System.Drawing.Size(983, 48)
        Me.SystemMessages1.TabIndex = 20
        '
        'grdDataMain
        '
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.grdDataMain.DisplayLayout.Appearance = Appearance1
        Me.grdDataMain.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn3.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn3.Header.VisiblePosition = 0
        UltraGridColumn3.Width = 431
        UltraGridColumn4.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn4.Header.VisiblePosition = 1
        UltraGridColumn4.Width = 501
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn3, UltraGridColumn4})
        Me.grdDataMain.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.grdDataMain.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grdDataMain.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.grdDataMain.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
        Me.grdDataMain.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.AlignWithDataRows
        Appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance2.BorderColor = System.Drawing.SystemColors.Window
        Me.grdDataMain.DisplayLayout.GroupByBox.Appearance = Appearance2
        Appearance3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grdDataMain.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance3
        Me.grdDataMain.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance4.BackColor2 = System.Drawing.SystemColors.Control
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grdDataMain.DisplayLayout.GroupByBox.PromptAppearance = Appearance4
        Appearance5.BackColor = System.Drawing.SystemColors.Window
        Appearance5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grdDataMain.DisplayLayout.Override.ActiveCellAppearance = Appearance5
        Appearance6.BackColor = System.Drawing.SystemColors.Highlight
        Appearance6.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.grdDataMain.DisplayLayout.Override.ActiveRowAppearance = Appearance6
        Me.grdDataMain.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        Me.grdDataMain.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.grdDataMain.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Me.grdDataMain.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.grdDataMain.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
        Me.grdDataMain.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.grdDataMain.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.grdDataMain.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance7.BackColor = System.Drawing.SystemColors.Window
        Me.grdDataMain.DisplayLayout.Override.CardAreaAppearance = Appearance7
        Appearance8.BorderColor = System.Drawing.Color.Silver
        Appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.grdDataMain.DisplayLayout.Override.CellAppearance = Appearance8
        Me.grdDataMain.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.grdDataMain.DisplayLayout.Override.CellPadding = 0
        Me.grdDataMain.DisplayLayout.Override.FilterClearButtonLocation = Infragistics.Win.UltraWinGrid.FilterClearButtonLocation.Cell
        Me.grdDataMain.DisplayLayout.Override.FilterEvaluationTrigger = Infragistics.Win.UltraWinGrid.FilterEvaluationTrigger.OnCellValueChange
        Me.grdDataMain.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.[Like]
        Me.grdDataMain.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance9.BackColor = System.Drawing.SystemColors.Control
        Appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance9.BorderColor = System.Drawing.SystemColors.Window
        Me.grdDataMain.DisplayLayout.Override.GroupByRowAppearance = Appearance9
        Me.grdDataMain.DisplayLayout.Override.GroupBySummaryDisplayStyle = Infragistics.Win.UltraWinGrid.GroupBySummaryDisplayStyle.SummaryCells
        Appearance10.BackColor = System.Drawing.Color.Gray
        Appearance10.BackColor2 = System.Drawing.Color.Gray
        Appearance10.FontData.BoldAsString = "True"
        Appearance10.ForeColor = System.Drawing.Color.White
        Appearance10.TextHAlignAsString = "Left"
        Me.grdDataMain.DisplayLayout.Override.HeaderAppearance = Appearance10
        Me.grdDataMain.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle
        Me.grdDataMain.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance11.BackColor = System.Drawing.Color.Gainsboro
        Appearance11.BackColor2 = System.Drawing.Color.Gainsboro
        Me.grdDataMain.DisplayLayout.Override.RowAlternateAppearance = Appearance11
        Appearance12.BackColor = System.Drawing.SystemColors.Window
        Appearance12.BorderColor = System.Drawing.Color.Silver
        Me.grdDataMain.DisplayLayout.Override.RowAppearance = Appearance12
        Me.grdDataMain.DisplayLayout.Override.RowFilterMode = Infragistics.Win.UltraWinGrid.RowFilterMode.AllRowsInBand
        Me.grdDataMain.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grdDataMain.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.grdDataMain.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.grdDataMain.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.grdDataMain.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.grdDataMain.DisplayLayout.Override.SupportDataErrorInfo = Infragistics.Win.UltraWinGrid.SupportDataErrorInfo.RowsOnly
        Appearance13.BackColor = System.Drawing.SystemColors.ControlLight
        Me.grdDataMain.DisplayLayout.Override.TemplateAddRowAppearance = Appearance13
        Me.grdDataMain.DisplayLayout.Override.TipStyleScroll = Infragistics.Win.UltraWinGrid.TipStyle.Hide
        Me.grdDataMain.DisplayLayout.Override.WrapHeaderText = Infragistics.Win.DefaultableBoolean.[True]
        Me.grdDataMain.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grdDataMain.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grdDataMain.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.grdDataMain.Dock = System.Windows.Forms.DockStyle.Top
        Me.grdDataMain.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdDataMain.Location = New System.Drawing.Point(1, 34)
        Me.grdDataMain.Name = "grdDataMain"
        Me.grdDataMain.Size = New System.Drawing.Size(965, 134)
        Me.grdDataMain.TabIndex = 11
        Me.grdDataMain.Text = "Datos"
        '
        'txtOrdenPago
        '
        Me.txtOrdenPago.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOrdenPago.Enabled = False
        Me.txtOrdenPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrdenPago.Location = New System.Drawing.Point(167, 242)
        Me.txtOrdenPago.MaxLength = 8
        Me.txtOrdenPago.Name = "txtOrdenPago"
        Me.txtOrdenPago.Size = New System.Drawing.Size(213, 20)
        Me.txtOrdenPago.TabIndex = 58
        Me.txtOrdenPago.WordWrap = False
        '
        'cmbDerecho
        '
        Me.cmbDerecho.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDerecho.FormattingEnabled = True
        Me.cmbDerecho.Location = New System.Drawing.Point(167, 201)
        Me.cmbDerecho.Name = "cmbDerecho"
        Me.cmbDerecho.Size = New System.Drawing.Size(715, 21)
        Me.cmbDerecho.TabIndex = 56
        '
        'mskRFC
        '
        Me.mskRFC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskRFC.Location = New System.Drawing.Point(167, 162)
        Me.mskRFC.Mask = "LLLL000000AAA"
        Me.mskRFC.Name = "mskRFC"
        Me.mskRFC.Size = New System.Drawing.Size(101, 20)
        Me.mskRFC.TabIndex = 55
        '
        'txtDir
        '
        Me.txtDir.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDir.Location = New System.Drawing.Point(167, 128)
        Me.txtDir.MaxLength = 150
        Me.txtDir.Name = "txtDir"
        Me.txtDir.Size = New System.Drawing.Size(715, 20)
        Me.txtDir.TabIndex = 54
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(167, 93)
        Me.txtNombre.MaxLength = 150
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(715, 20)
        Me.txtNombre.TabIndex = 53
        '
        'lblCommon1
        '
        Me.lblCommon1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCommon1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCommon1.Location = New System.Drawing.Point(386, 242)
        Me.lblCommon1.Name = "lblCommon1"
        Me.lblCommon1.Size = New System.Drawing.Size(266, 20)
        Me.lblCommon1.TabIndex = 52
        Me.lblCommon1.Text = "Núm. de Oficialia:AAAAAAAAAAAAAAA"
        Me.lblCommon1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(23, 242)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 17)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Orden de Pago:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(23, 201)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 17)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Concepto de Pago:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(23, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 17)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "R.F.C.:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(23, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 17)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Dirección:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFolioRec
        '
        Me.lblFolioRec.AutoSize = True
        Me.lblFolioRec.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblFolioRec.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblFolioRec.Location = New System.Drawing.Point(163, 45)
        Me.lblFolioRec.Name = "lblFolioRec"
        Me.lblFolioRec.Size = New System.Drawing.Size(26, 21)
        Me.lblFolioRec.TabIndex = 47
        Me.lblFolioRec.Text = "#:"
        Me.lblFolioRec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblObs
        '
        Me.lblObs.AutoSize = True
        Me.lblObs.Enabled = False
        Me.lblObs.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblObs.Location = New System.Drawing.Point(23, 285)
        Me.lblObs.Name = "lblObs"
        Me.lblObs.Size = New System.Drawing.Size(102, 17)
        Me.lblObs.TabIndex = 45
        Me.lblObs.Text = "Observaciones:"
        Me.lblObs.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFolREc
        '
        Me.lblFolREc.AutoSize = True
        Me.lblFolREc.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblFolREc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblFolREc.Location = New System.Drawing.Point(22, 45)
        Me.lblFolREc.Name = "lblFolREc"
        Me.lblFolREc.Size = New System.Drawing.Size(135, 21)
        Me.lblFolREc.TabIndex = 44
        Me.lblFolREc.Text = "Folio de Recibo:"
        Me.lblFolREc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNumCuenta
        '
        Me.lblNumCuenta.AutoSize = True
        Me.lblNumCuenta.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumCuenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblNumCuenta.Location = New System.Drawing.Point(23, 93)
        Me.lblNumCuenta.Name = "lblNumCuenta"
        Me.lblNumCuenta.Size = New System.Drawing.Size(62, 17)
        Me.lblNumCuenta.TabIndex = 0
        Me.lblNumCuenta.Text = "Nombre:"
        Me.lblNumCuenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTotal.Enabled = False
        Me.txtTotal.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(824, 3)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(140, 25)
        Me.txtTotal.TabIndex = 53
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTotal.Location = New System.Drawing.Point(679, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(139, 31)
        Me.lblTotal.TabIndex = 49
        Me.lblTotal.Text = "Total: $"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnPago
        '
        Me.tblButtons.SetColumnSpan(Me.btnPago, 2)
        Me.btnPago.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnPago.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPago.ForeColor = System.Drawing.Color.Navy
        Me.btnPago.Location = New System.Drawing.Point(244, 3)
        Me.btnPago.Name = "btnPago"
        Me.btnPago.Size = New System.Drawing.Size(284, 25)
        Me.btnPago.TabIndex = 41
        Me.btnPago.Text = "&Realizar Pago"
        Me.btnPago.UseVisualStyleBackColor = True
        '
        'btnImprimeRpt
        '
        Me.btnImprimeRpt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnImprimeRpt.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimeRpt.ForeColor = System.Drawing.Color.Navy
        Me.btnImprimeRpt.Location = New System.Drawing.Point(534, 3)
        Me.btnImprimeRpt.Name = "btnImprimeRpt"
        Me.btnImprimeRpt.Size = New System.Drawing.Size(139, 25)
        Me.btnImprimeRpt.TabIndex = 40
        Me.btnImprimeRpt.Text = "&Imprimir"
        Me.btnImprimeRpt.UseVisualStyleBackColor = True
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
        Me.tblButtons.Controls.Add(Me.txtTotal, 6, 0)
        Me.tblButtons.Controls.Add(Me.lblTotal, 5, 0)
        Me.tblButtons.Controls.Add(Me.btnPago, 2, 0)
        Me.tblButtons.Controls.Add(Me.btnImprimeRpt, 4, 0)
        Me.tblButtons.Controls.Add(Me.btnLiquidar, 0, 0)
        Me.tblButtons.Dock = System.Windows.Forms.DockStyle.Top
        Me.tblButtons.Location = New System.Drawing.Point(0, 545)
        Me.tblButtons.Name = "tblButtons"
        Me.tblButtons.RowCount = 1
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblButtons.Size = New System.Drawing.Size(967, 29)
        Me.tblButtons.TabIndex = 27
        '
        'btnLiquidar
        '
        Me.tblButtons.SetColumnSpan(Me.btnLiquidar, 2)
        Me.btnLiquidar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnLiquidar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLiquidar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLiquidar.ForeColor = System.Drawing.Color.Red
        Me.btnLiquidar.Location = New System.Drawing.Point(3, 3)
        Me.btnLiquidar.Name = "btnLiquidar"
        Me.btnLiquidar.Size = New System.Drawing.Size(235, 25)
        Me.btnLiquidar.TabIndex = 54
        Me.btnLiquidar.Text = "&Liquidar"
        Me.btnLiquidar.UseVisualStyleBackColor = True
        '
        'UltraGroupBox1
        '
        Appearance22.TextHAlignAsString = "Center"
        Me.UltraGroupBox1.Appearance = Appearance22
        Me.UltraGroupBox1.BorderStyle = Infragistics.Win.Misc.GroupBoxBorderStyle.HeaderSolid
        Me.UltraGroupBox1.Controls.Add(Me.grdDataMain)
        Me.UltraGroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance23.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance23.BorderColor = System.Drawing.Color.Gray
        Appearance23.ForeColor = System.Drawing.Color.Navy
        Appearance23.TextHAlignAsString = "Center"
        Appearance23.TextTrimming = Infragistics.Win.TextTrimming.None
        Appearance23.TextVAlignAsString = "Middle"
        Me.UltraGroupBox1.HeaderAppearance = Appearance23
        Me.UltraGroupBox1.HeaderBorderStyle = Infragistics.Win.UIElementBorderStyle.Rounded1
        Me.UltraGroupBox1.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOnBorder
        Me.UltraGroupBox1.Location = New System.Drawing.Point(0, 371)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(967, 174)
        Me.UltraGroupBox1.TabIndex = 26
        Me.UltraGroupBox1.Text = "Estado de Cuenta"
        Me.UltraGroupBox1.VerticalTextOrientation = Infragistics.Win.Misc.GroupBoxVerticalTextOrientation.BottomToTop
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2000
        '
        'txtObservacion
        '
        Me.txtObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservacion.Location = New System.Drawing.Point(167, 285)
        Me.txtObservacion.MaxLength = 150
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(715, 34)
        Me.txtObservacion.TabIndex = 46
        '
        'grpInfoREq
        '
        Appearance24.BorderColor = System.Drawing.Color.Gray
        Appearance24.TextHAlignAsString = "Center"
        Me.grpInfoREq.Appearance = Appearance24
        Me.grpInfoREq.Controls.Add(Me.txtCommon1)
        Me.grpInfoREq.Controls.Add(Me.txtOrdenPago)
        Me.grpInfoREq.Controls.Add(Me.cmbDerecho)
        Me.grpInfoREq.Controls.Add(Me.mskRFC)
        Me.grpInfoREq.Controls.Add(Me.txtDir)
        Me.grpInfoREq.Controls.Add(Me.txtNombre)
        Me.grpInfoREq.Controls.Add(Me.lblCommon1)
        Me.grpInfoREq.Controls.Add(Me.Label4)
        Me.grpInfoREq.Controls.Add(Me.Label3)
        Me.grpInfoREq.Controls.Add(Me.Label2)
        Me.grpInfoREq.Controls.Add(Me.Label1)
        Me.grpInfoREq.Controls.Add(Me.lblFolioRec)
        Me.grpInfoREq.Controls.Add(Me.txtObservacion)
        Me.grpInfoREq.Controls.Add(Me.lblObs)
        Me.grpInfoREq.Controls.Add(Me.lblFolREc)
        Me.grpInfoREq.Controls.Add(Me.lblNumCuenta)
        Me.grpInfoREq.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpInfoREq.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpInfoREq.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance25.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance25.BorderColor = System.Drawing.Color.Gray
        Appearance25.ForeColor = System.Drawing.Color.Navy
        Appearance25.TextHAlignAsString = "Center"
        Appearance25.TextTrimming = Infragistics.Win.TextTrimming.None
        Appearance25.TextVAlignAsString = "Middle"
        Me.grpInfoREq.HeaderAppearance = Appearance25
        Me.grpInfoREq.HeaderBorderStyle = Infragistics.Win.UIElementBorderStyle.Rounded1
        Me.grpInfoREq.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOnBorder
        Me.grpInfoREq.Location = New System.Drawing.Point(0, 25)
        Me.grpInfoREq.Name = "grpInfoREq"
        Me.grpInfoREq.Size = New System.Drawing.Size(967, 346)
        Me.grpInfoREq.TabIndex = 25
        Me.grpInfoREq.Text = "Datos del Pago"
        Me.grpInfoREq.VerticalTextOrientation = Infragistics.Win.Misc.GroupBoxVerticalTextOrientation.BottomToTop
        Me.grpInfoREq.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2000
        '
        'txtCommon1
        '
        Me.txtCommon1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCommon1.Enabled = False
        Me.txtCommon1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCommon1.Location = New System.Drawing.Point(658, 242)
        Me.txtCommon1.MaxLength = 8
        Me.txtCommon1.Name = "txtCommon1"
        Me.txtCommon1.Size = New System.Drawing.Size(213, 20)
        Me.txtCommon1.TabIndex = 59
        Me.txtCommon1.WordWrap = False
        '
        'UltraMessageBoxManager1
        '
        Me.UltraMessageBoxManager1.ContainingControl = Me
        '
        'frmDerechoGeneric
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(967, 660)
        Me.Controls.Add(Me.tblButtons)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Controls.Add(Me.grpInfoREq)
        Me.Controls.Add(Me.SystemMessages1)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Name = "frmDerechoGeneric"
        Me.Text = "frmDerechoGeneric"
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.grdDataMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tblButtons.ResumeLayout(False)
        Me.tblButtons.PerformLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        CType(Me.grpInfoREq, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpInfoREq.ResumeLayout(False)
        Me.grpInfoREq.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents lblCurrentMenu As ToolStripLabel
    Friend WithEvents SystemMessages1 As SystemMessages
    Friend WithEvents grdDataMain As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents txtOrdenPago As TextBox
    Friend WithEvents cmbDerecho As ComboBox
    Friend WithEvents mskRFC As MaskedTextBox
    Friend WithEvents txtDir As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblCommon1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblFolioRec As Label
    Friend WithEvents lblObs As Label
    Friend WithEvents lblFolREc As Label
    Friend WithEvents lblNumCuenta As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnPago As Button
    Friend WithEvents tblButtons As TableLayoutPanel
    Friend WithEvents btnImprimeRpt As Button
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents txtObservacion As TextBox
    Friend WithEvents grpInfoREq As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraMessageBoxManager1 As Infragistics.Win.UltraMessageBox.UltraMessageBoxManager
    Friend WithEvents txtCommon1 As TextBox
    Friend WithEvents btnLiquidar As Button
End Class
