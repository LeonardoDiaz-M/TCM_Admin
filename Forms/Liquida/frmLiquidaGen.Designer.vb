<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLiquidaGen
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
        Dim ValueListItem5 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem6 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("tip_predio", -1)
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("tipo_predio")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("descripcion")
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
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.lblCurrentMenu = New System.Windows.Forms.ToolStripLabel()
        Me.grpInfoREq = New Infragistics.Win.Misc.UltraGroupBox()
        Me.lblFolioRec = New System.Windows.Forms.Label()
        Me.txtObservacion = New System.Windows.Forms.TextBox()
        Me.lblObs = New System.Windows.Forms.Label()
        Me.lblFolREc = New System.Windows.Forms.Label()
        Me.optTipo = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        Me.lblNumCuenta = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtcveCatastral = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.grdDataMain = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.tblButtons = New System.Windows.Forms.TableLayoutPanel()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnPago = New System.Windows.Forms.Button()
        Me.btnImprimeRpt = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.UltraMessageBoxManager1 = New Infragistics.Win.UltraMessageBox.UltraMessageBoxManager(Me.components)
        Me.UltraMessageBoxManager2 = New Infragistics.Win.UltraMessageBox.UltraMessageBoxManager(Me.components)
        Me.UltraGridDocumentExporter1 = New Infragistics.Win.UltraWinGrid.DocumentExport.UltraGridDocumentExporter(Me.components)
        Me.SystemMessages1 = New TCM2017.SystemMessages()
        Me.RadThemeManager1 = New Telerik.WinControls.RadThemeManager()
        Me.DsPredial = New TCM2017.dsPredial()
        Me.ArcpredialBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Arc_predialTableAdapter = New TCM2017.dsPredialTableAdapters.arc_predialTableAdapter()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.grpInfoREq, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpInfoREq.SuspendLayout()
        CType(Me.optTipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.grdDataMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tblButtons.SuspendLayout()
        CType(Me.DsPredial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcpredialBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.BindingNavigator1.Size = New System.Drawing.Size(1045, 25)
        Me.BindingNavigator1.TabIndex = 16
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
        Appearance1.BorderColor = System.Drawing.Color.Gray
        Appearance1.TextHAlignAsString = "Center"
        Me.grpInfoREq.Appearance = Appearance1
        Me.grpInfoREq.Controls.Add(Me.lblFolioRec)
        Me.grpInfoREq.Controls.Add(Me.txtObservacion)
        Me.grpInfoREq.Controls.Add(Me.lblObs)
        Me.grpInfoREq.Controls.Add(Me.lblFolREc)
        Me.grpInfoREq.Controls.Add(Me.optTipo)
        Me.grpInfoREq.Controls.Add(Me.lblNumCuenta)
        Me.grpInfoREq.Controls.Add(Me.btnBuscar)
        Me.grpInfoREq.Controls.Add(Me.txtcveCatastral)
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
        Me.grpInfoREq.Size = New System.Drawing.Size(1045, 126)
        Me.grpInfoREq.TabIndex = 18
        Me.grpInfoREq.Text = "Información Requerida"
        Me.grpInfoREq.VerticalTextOrientation = Infragistics.Win.Misc.GroupBoxVerticalTextOrientation.BottomToTop
        Me.grpInfoREq.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2000
        '
        'lblFolioRec
        '
        Me.lblFolioRec.AutoSize = True
        Me.lblFolioRec.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblFolioRec.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblFolioRec.Location = New System.Drawing.Point(731, 45)
        Me.lblFolioRec.Name = "lblFolioRec"
        Me.lblFolioRec.Size = New System.Drawing.Size(26, 21)
        Me.lblFolioRec.TabIndex = 47
        Me.lblFolioRec.Text = "#:"
        Me.lblFolioRec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtObservacion
        '
        Me.txtObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservacion.Enabled = False
        Me.txtObservacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservacion.Location = New System.Drawing.Point(167, 80)
        Me.txtObservacion.MaxLength = 150
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(558, 34)
        Me.txtObservacion.TabIndex = 46
        '
        'lblObs
        '
        Me.lblObs.AutoSize = True
        Me.lblObs.Enabled = False
        Me.lblObs.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblObs.Location = New System.Drawing.Point(23, 84)
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
        Me.lblFolREc.Location = New System.Drawing.Point(590, 45)
        Me.lblFolREc.Name = "lblFolREc"
        Me.lblFolREc.Size = New System.Drawing.Size(135, 21)
        Me.lblFolREc.TabIndex = 44
        Me.lblFolREc.Text = "Folio de Recibo:"
        Me.lblFolREc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'optTipo
        '
        Me.optTipo.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Appearance2.FontData.BoldAsString = "False"
        Appearance2.FontData.SizeInPoints = 8.0!
        Appearance2.TextHAlignAsString = "Center"
        Appearance2.TextVAlignAsString = "Middle"
        Me.optTipo.ItemAppearance = Appearance2
        Appearance3.TextHAlignAsString = "Center"
        Appearance3.TextVAlignAsString = "Middle"
        ValueListItem5.Appearance = Appearance3
        ValueListItem5.DataValue = "1"
        ValueListItem5.DisplayText = "Por Período"
        Appearance4.TextHAlignAsString = "Center"
        Appearance4.TextVAlignAsString = "Middle"
        ValueListItem6.Appearance = Appearance4
        ValueListItem6.DataValue = "2"
        ValueListItem6.DisplayText = "Anual"
        Me.optTipo.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem5, ValueListItem6})
        Me.optTipo.ItemSpacingHorizontal = 10
        Me.optTipo.Location = New System.Drawing.Point(286, 51)
        Me.optTipo.Name = "optTipo"
        Me.optTipo.Size = New System.Drawing.Size(175, 19)
        Me.optTipo.TabIndex = 37
        Me.optTipo.TextRenderingMode = Infragistics.Win.TextRenderingMode.GDIPlus
        Me.optTipo.UseFlatMode = Infragistics.Win.DefaultableBoolean.[True]
        Me.optTipo.UseOsThemes = Infragistics.Win.DefaultableBoolean.[True]
        '
        'lblNumCuenta
        '
        Me.lblNumCuenta.AutoSize = True
        Me.lblNumCuenta.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumCuenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblNumCuenta.Location = New System.Drawing.Point(23, 48)
        Me.lblNumCuenta.Name = "lblNumCuenta"
        Me.lblNumCuenta.Size = New System.Drawing.Size(128, 17)
        Me.lblNumCuenta.TabIndex = 0
        Me.lblNumCuenta.Text = "Número de Cuenta:"
        Me.lblNumCuenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(467, 38)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 36)
        Me.btnBuscar.TabIndex = 38
        Me.btnBuscar.Text = "&Consultar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtcveCatastral
        '
        Appearance5.FontData.SizeInPoints = 8.0!
        Me.txtcveCatastral.Appearance = Appearance5
        Me.txtcveCatastral.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.txtcveCatastral.InputMask = "################"
        Me.txtcveCatastral.Location = New System.Drawing.Point(167, 47)
        Me.txtcveCatastral.Name = "txtcveCatastral"
        Me.txtcveCatastral.NonAutoSizeHeight = 26
        Me.txtcveCatastral.Size = New System.Drawing.Size(95, 22)
        Me.txtcveCatastral.TabIndex = 36
        '
        'UltraGroupBox2
        '
        Appearance7.BorderColor = System.Drawing.Color.Gray
        Appearance7.TextHAlignAsString = "Center"
        Me.UltraGroupBox2.Appearance = Appearance7
        Me.UltraGroupBox2.BorderStyle = Infragistics.Win.Misc.GroupBoxBorderStyle.Header3D
        Me.UltraGroupBox2.Controls.Add(Me.WebBrowser1)
        Me.UltraGroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance8.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance8.BorderColor = System.Drawing.Color.Gray
        Appearance8.ForeColor = System.Drawing.Color.Navy
        Appearance8.TextHAlignAsString = "Center"
        Appearance8.TextTrimming = Infragistics.Win.TextTrimming.None
        Appearance8.TextVAlignAsString = "Middle"
        Me.UltraGroupBox2.HeaderAppearance = Appearance8
        Me.UltraGroupBox2.HeaderBorderStyle = Infragistics.Win.UIElementBorderStyle.Rounded1
        Me.UltraGroupBox2.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOnBorder
        Me.UltraGroupBox2.Location = New System.Drawing.Point(0, 151)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(1045, 335)
        Me.UltraGroupBox2.TabIndex = 21
        Me.UltraGroupBox2.Text = "Datos de la Cuenta"
        Me.UltraGroupBox2.VerticalTextOrientation = Infragistics.Win.Misc.GroupBoxVerticalTextOrientation.BottomToTop
        Me.UltraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2000
        '
        'WebBrowser1
        '
        Me.WebBrowser1.AllowNavigation = False
        Me.WebBrowser1.AllowWebBrowserDrop = False
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(1, 34)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(1043, 300)
        Me.WebBrowser1.TabIndex = 0
        '
        'UltraGroupBox1
        '
        Appearance9.TextHAlignAsString = "Center"
        Me.UltraGroupBox1.Appearance = Appearance9
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
        Me.UltraGroupBox1.Location = New System.Drawing.Point(0, 486)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(1045, 174)
        Me.UltraGroupBox1.TabIndex = 22
        Me.UltraGroupBox1.Text = "Detalles del adeudo correspondiente"
        Me.UltraGroupBox1.VerticalTextOrientation = Infragistics.Win.Misc.GroupBoxVerticalTextOrientation.BottomToTop
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2000
        '
        'grdDataMain
        '
        Appearance10.BackColor = System.Drawing.SystemColors.Window
        Appearance10.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.grdDataMain.DisplayLayout.Appearance = Appearance10
        Me.grdDataMain.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn3.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn3.Header.VisiblePosition = 0
        UltraGridColumn3.Width = 470
        UltraGridColumn4.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn4.Header.VisiblePosition = 1
        UltraGridColumn4.Width = 540
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn3, UltraGridColumn4})
        Me.grdDataMain.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.grdDataMain.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grdDataMain.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.grdDataMain.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
        Me.grdDataMain.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.AlignWithDataRows
        Appearance11.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance11.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance11.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance11.BorderColor = System.Drawing.SystemColors.Window
        Me.grdDataMain.DisplayLayout.GroupByBox.Appearance = Appearance11
        Appearance12.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grdDataMain.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance12
        Me.grdDataMain.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance13.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance13.BackColor2 = System.Drawing.SystemColors.Control
        Appearance13.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance13.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grdDataMain.DisplayLayout.GroupByBox.PromptAppearance = Appearance13
        Appearance14.BackColor = System.Drawing.SystemColors.Window
        Appearance14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grdDataMain.DisplayLayout.Override.ActiveCellAppearance = Appearance14
        Appearance15.BackColor = System.Drawing.SystemColors.Highlight
        Appearance15.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.grdDataMain.DisplayLayout.Override.ActiveRowAppearance = Appearance15
        Me.grdDataMain.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        Me.grdDataMain.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.grdDataMain.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Me.grdDataMain.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.grdDataMain.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
        Me.grdDataMain.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.grdDataMain.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.grdDataMain.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance16.BackColor = System.Drawing.SystemColors.Window
        Me.grdDataMain.DisplayLayout.Override.CardAreaAppearance = Appearance16
        Appearance17.BorderColor = System.Drawing.Color.Silver
        Appearance17.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.grdDataMain.DisplayLayout.Override.CellAppearance = Appearance17
        Me.grdDataMain.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.grdDataMain.DisplayLayout.Override.CellPadding = 0
        Me.grdDataMain.DisplayLayout.Override.FilterClearButtonLocation = Infragistics.Win.UltraWinGrid.FilterClearButtonLocation.Cell
        Me.grdDataMain.DisplayLayout.Override.FilterEvaluationTrigger = Infragistics.Win.UltraWinGrid.FilterEvaluationTrigger.OnCellValueChange
        Me.grdDataMain.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.[Like]
        Me.grdDataMain.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance18.BackColor = System.Drawing.SystemColors.Control
        Appearance18.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance18.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance18.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance18.BorderColor = System.Drawing.SystemColors.Window
        Me.grdDataMain.DisplayLayout.Override.GroupByRowAppearance = Appearance18
        Me.grdDataMain.DisplayLayout.Override.GroupBySummaryDisplayStyle = Infragistics.Win.UltraWinGrid.GroupBySummaryDisplayStyle.SummaryCells
        Appearance19.BackColor = System.Drawing.Color.Gray
        Appearance19.BackColor2 = System.Drawing.Color.Gray
        Appearance19.FontData.BoldAsString = "True"
        Appearance19.ForeColor = System.Drawing.Color.White
        Appearance19.TextHAlignAsString = "Left"
        Me.grdDataMain.DisplayLayout.Override.HeaderAppearance = Appearance19
        Me.grdDataMain.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle
        Me.grdDataMain.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance20.BackColor = System.Drawing.Color.Gainsboro
        Appearance20.BackColor2 = System.Drawing.Color.Gainsboro
        Me.grdDataMain.DisplayLayout.Override.RowAlternateAppearance = Appearance20
        Appearance21.BackColor = System.Drawing.SystemColors.Window
        Appearance21.BorderColor = System.Drawing.Color.Silver
        Me.grdDataMain.DisplayLayout.Override.RowAppearance = Appearance21
        Me.grdDataMain.DisplayLayout.Override.RowFilterMode = Infragistics.Win.UltraWinGrid.RowFilterMode.AllRowsInBand
        Me.grdDataMain.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grdDataMain.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.grdDataMain.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.grdDataMain.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.grdDataMain.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.grdDataMain.DisplayLayout.Override.SupportDataErrorInfo = Infragistics.Win.UltraWinGrid.SupportDataErrorInfo.RowsOnly
        Appearance22.BackColor = System.Drawing.SystemColors.ControlLight
        Me.grdDataMain.DisplayLayout.Override.TemplateAddRowAppearance = Appearance22
        Me.grdDataMain.DisplayLayout.Override.TipStyleScroll = Infragistics.Win.UltraWinGrid.TipStyle.Hide
        Me.grdDataMain.DisplayLayout.Override.WrapHeaderText = Infragistics.Win.DefaultableBoolean.[True]
        Me.grdDataMain.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grdDataMain.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grdDataMain.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.grdDataMain.Dock = System.Windows.Forms.DockStyle.Top
        Me.grdDataMain.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdDataMain.Location = New System.Drawing.Point(1, 34)
        Me.grdDataMain.Name = "grdDataMain"
        Me.grdDataMain.Size = New System.Drawing.Size(1043, 134)
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
        Me.tblButtons.Controls.Add(Me.txtTotal, 6, 0)
        Me.tblButtons.Controls.Add(Me.lblTotal, 5, 0)
        Me.tblButtons.Controls.Add(Me.btnPago, 0, 0)
        Me.tblButtons.Controls.Add(Me.btnImprimeRpt, 1, 0)
        Me.tblButtons.Controls.Add(Me.btnCerrar, 2, 0)
        Me.tblButtons.Dock = System.Windows.Forms.DockStyle.Top
        Me.tblButtons.Location = New System.Drawing.Point(0, 660)
        Me.tblButtons.Name = "tblButtons"
        Me.tblButtons.RowCount = 1
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.tblButtons.Size = New System.Drawing.Size(1045, 29)
        Me.tblButtons.TabIndex = 23
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTotal.Enabled = False
        Me.txtTotal.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(887, 3)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(155, 25)
        Me.txtTotal.TabIndex = 53
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTotal.Location = New System.Drawing.Point(731, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(150, 29)
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
        Me.btnPago.Location = New System.Drawing.Point(3, 3)
        Me.btnPago.Name = "btnPago"
        Me.btnPago.Size = New System.Drawing.Size(254, 23)
        Me.btnPago.TabIndex = 41
        Me.btnPago.Text = "&Realizar Pago"
        Me.btnPago.UseVisualStyleBackColor = True
        '
        'btnImprimeRpt
        '
        Me.btnImprimeRpt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnImprimeRpt.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimeRpt.ForeColor = System.Drawing.Color.Navy
        Me.btnImprimeRpt.Location = New System.Drawing.Point(263, 3)
        Me.btnImprimeRpt.Name = "btnImprimeRpt"
        Me.btnImprimeRpt.Size = New System.Drawing.Size(150, 23)
        Me.btnImprimeRpt.TabIndex = 40
        Me.btnImprimeRpt.Text = "&Imprimir"
        Me.btnImprimeRpt.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCerrar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ForeColor = System.Drawing.Color.Navy
        Me.btnCerrar.Location = New System.Drawing.Point(419, 3)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(150, 23)
        Me.btnCerrar.TabIndex = 39
        Me.btnCerrar.Text = "&Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'UltraMessageBoxManager1
        '
        Me.UltraMessageBoxManager1.ContainingControl = Me
        '
        'UltraMessageBoxManager2
        '
        Me.UltraMessageBoxManager2.ContainingControl = Me
        '
        'SystemMessages1
        '
        Me.SystemMessages1.AutoScroll = True
        Me.SystemMessages1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.SystemMessages1.Dock = System.Windows.Forms.DockStyle.Top
        Me.SystemMessages1.Location = New System.Drawing.Point(2, 29)
        Me.SystemMessages1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SystemMessages1.Name = "SystemMessages1"
        Me.SystemMessages1.Size = New System.Drawing.Size(1061, 26)
        Me.SystemMessages1.TabIndex = 17
        '
        'DsPredial
        '
        Me.DsPredial.DataSetName = "dsPredial"
        Me.DsPredial.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ArcpredialBindingSource
        '
        Me.ArcpredialBindingSource.DataMember = "arc_predial"
        Me.ArcpredialBindingSource.DataSource = Me.DsPredial
        '
        'Arc_predialTableAdapter
        '
        Me.Arc_predialTableAdapter.ClearBeforeFill = True
        '
        'frmLiquidaGen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1045, 712)
        Me.Controls.Add(Me.tblButtons)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Controls.Add(Me.UltraGroupBox2)
        Me.Controls.Add(Me.grpInfoREq)
        Me.Controls.Add(Me.SystemMessages1)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Name = "frmLiquidaGen"
        Me.Text = "Liquidación Generica"
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.grpInfoREq, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpInfoREq.ResumeLayout(False)
        Me.grpInfoREq.PerformLayout()
        CType(Me.optTipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        CType(Me.grdDataMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tblButtons.ResumeLayout(False)
        Me.tblButtons.PerformLayout()
        CType(Me.DsPredial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcpredialBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents lblCurrentMenu As ToolStripLabel
    Friend WithEvents SystemMessages1 As SystemMessages
    Friend WithEvents grpInfoREq As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents lblFolREc As Label
    Friend WithEvents optTipo As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents lblNumCuenta As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtcveCatastral As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents tblButtons As TableLayoutPanel
    Friend WithEvents btnPago As Button
    Friend WithEvents btnImprimeRpt As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents UltraMessageBoxManager1 As Infragistics.Win.UltraMessageBox.UltraMessageBoxManager
    Friend WithEvents UltraMessageBoxManager2 As Infragistics.Win.UltraMessageBox.UltraMessageBoxManager
    Friend WithEvents grdDataMain As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents lblObs As Label
    Friend WithEvents txtObservacion As TextBox
    Friend WithEvents UltraGridDocumentExporter1 As Infragistics.Win.UltraWinGrid.DocumentExport.UltraGridDocumentExporter
    Friend WithEvents DsPredial As dsPredial
    Friend WithEvents ArcpredialBindingSource As BindingSource
    Friend WithEvents Arc_predialTableAdapter As dsPredialTableAdapters.arc_predialTableAdapter
    Friend WithEvents lblFolioRec As Label
End Class
