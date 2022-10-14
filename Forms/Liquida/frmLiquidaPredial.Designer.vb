<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLiquidaPredial
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
        Dim Appearance164 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance165 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("tip_predio", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("tipo_predio")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("descripcion")
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
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance166 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance167 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance168 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance169 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance170 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem4 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance171 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance172 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance173 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.grpDetails = New Infragistics.Win.Misc.UltraGroupBox()
        Me.grdDataMain = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.grpInfoREq = New Infragistics.Win.Misc.UltraGroupBox()
        Me.tblInfo = New System.Windows.Forms.TableLayoutPanel()
        Me.optTipo = New Infragistics.Win.UltraWinEditors.UltraOptionSet()
        Me.txtcveCatastral = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.lblNumCuenta = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.grpDatosProp = New Infragistics.Win.Misc.UltraGroupBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtMesPago = New System.Windows.Forms.TextBox()
        Me.txtAñoPago = New System.Windows.Forms.TextBox()
        Me.lblMesPago = New System.Windows.Forms.Label()
        Me.txtUbicacion = New System.Windows.Forms.TextBox()
        Me.lblAñoPago = New System.Windows.Forms.Label()
        Me.lblUbicacion = New System.Windows.Forms.Label()
        Me.lblPropietario = New System.Windows.Forms.Label()
        Me.txtPropietario = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.SystemMessages1 = New TCMAdmin.SystemMessages()
        Me.tblButtons = New System.Windows.Forms.TableLayoutPanel()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnPago = New System.Windows.Forms.Button()
        Me.btnImprimeRpt = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.UltraGridBagLayoutManager1 = New Infragistics.Win.Misc.UltraGridBagLayoutManager(Me.components)
        Me.UltraMessageBoxManager1 = New Infragistics.Win.UltraMessageBox.UltraMessageBoxManager(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.grpDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDetails.SuspendLayout()
        CType(Me.grdDataMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpInfoREq, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpInfoREq.SuspendLayout()
        Me.tblInfo.SuspendLayout()
        CType(Me.optTipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpDatosProp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDatosProp.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.tblButtons.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGridBagLayoutManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.grpDetails, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.grpInfoREq, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.grpDatosProp, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.tblButtons, 0, 4)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(853, 487)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'grpDetails
        '
        Appearance164.TextHAlignAsString = "Center"
        Me.grpDetails.Appearance = Appearance164
        Me.grpDetails.BorderStyle = Infragistics.Win.Misc.GroupBoxBorderStyle.HeaderDoubleSolid
        Me.grpDetails.Controls.Add(Me.grdDataMain)
        Me.grpDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpDetails.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDetails.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance165.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance165.BorderColor = System.Drawing.Color.Gray
        Appearance165.ForeColor = System.Drawing.Color.Navy
        Appearance165.TextHAlignAsString = "Center"
        Appearance165.TextTrimming = Infragistics.Win.TextTrimming.None
        Appearance165.TextVAlignAsString = "Middle"
        Me.grpDetails.HeaderAppearance = Appearance165
        Me.grpDetails.HeaderBorderStyle = Infragistics.Win.UIElementBorderStyle.Rounded1
        Me.grpDetails.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOnBorder
        Me.grpDetails.Location = New System.Drawing.Point(3, 221)
        Me.grpDetails.Name = "grpDetails"
        Me.grpDetails.Size = New System.Drawing.Size(847, 237)
        Me.grpDetails.TabIndex = 9
        Me.grpDetails.Text = "Detalles del Adeudo Correspondiente"
        Me.grpDetails.VerticalTextOrientation = Infragistics.Win.Misc.GroupBoxVerticalTextOrientation.BottomToTop
        Me.grpDetails.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2000
        '
        'grdDataMain
        '
        Appearance2.BackColor = System.Drawing.SystemColors.Window
        Appearance2.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.grdDataMain.DisplayLayout.Appearance = Appearance2
        Me.grdDataMain.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Width = 392
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 451
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2})
        Me.grdDataMain.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.grdDataMain.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grdDataMain.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.grdDataMain.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
        Me.grdDataMain.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.AlignWithDataRows
        Appearance3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance3.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance3.BorderColor = System.Drawing.SystemColors.Window
        Me.grdDataMain.DisplayLayout.GroupByBox.Appearance = Appearance3
        Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grdDataMain.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance4
        Me.grdDataMain.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance5.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance5.BackColor2 = System.Drawing.SystemColors.Control
        Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance5.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grdDataMain.DisplayLayout.GroupByBox.PromptAppearance = Appearance5
        Appearance6.BackColor = System.Drawing.SystemColors.Window
        Appearance6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grdDataMain.DisplayLayout.Override.ActiveCellAppearance = Appearance6
        Appearance7.BackColor = System.Drawing.SystemColors.Highlight
        Appearance7.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.grdDataMain.DisplayLayout.Override.ActiveRowAppearance = Appearance7
        Me.grdDataMain.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        Me.grdDataMain.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.grdDataMain.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Me.grdDataMain.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.grdDataMain.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
        Me.grdDataMain.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.grdDataMain.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.grdDataMain.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance8.BackColor = System.Drawing.SystemColors.Window
        Me.grdDataMain.DisplayLayout.Override.CardAreaAppearance = Appearance8
        Appearance9.BorderColor = System.Drawing.Color.Silver
        Appearance9.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.grdDataMain.DisplayLayout.Override.CellAppearance = Appearance9
        Me.grdDataMain.DisplayLayout.Override.CellPadding = 0
        Me.grdDataMain.DisplayLayout.Override.FilterClearButtonLocation = Infragistics.Win.UltraWinGrid.FilterClearButtonLocation.Cell
        Me.grdDataMain.DisplayLayout.Override.FilterEvaluationTrigger = Infragistics.Win.UltraWinGrid.FilterEvaluationTrigger.OnCellValueChange
        Me.grdDataMain.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.[Like]
        Me.grdDataMain.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance10.BackColor = System.Drawing.SystemColors.Control
        Appearance10.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance10.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance10.BorderColor = System.Drawing.SystemColors.Window
        Me.grdDataMain.DisplayLayout.Override.GroupByRowAppearance = Appearance10
        Me.grdDataMain.DisplayLayout.Override.GroupBySummaryDisplayStyle = Infragistics.Win.UltraWinGrid.GroupBySummaryDisplayStyle.SummaryCells
        Appearance11.BackColor = System.Drawing.Color.Gray
        Appearance11.BackColor2 = System.Drawing.Color.Gray
        Appearance11.FontData.BoldAsString = "True"
        Appearance11.ForeColor = System.Drawing.Color.White
        Appearance11.TextHAlignAsString = "Left"
        Me.grdDataMain.DisplayLayout.Override.HeaderAppearance = Appearance11
        Me.grdDataMain.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle
        Me.grdDataMain.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance12.BackColor = System.Drawing.Color.Gainsboro
        Appearance12.BackColor2 = System.Drawing.Color.Gainsboro
        Me.grdDataMain.DisplayLayout.Override.RowAlternateAppearance = Appearance12
        Appearance13.BackColor = System.Drawing.SystemColors.Window
        Appearance13.BorderColor = System.Drawing.Color.Silver
        Me.grdDataMain.DisplayLayout.Override.RowAppearance = Appearance13
        Me.grdDataMain.DisplayLayout.Override.RowFilterMode = Infragistics.Win.UltraWinGrid.RowFilterMode.AllRowsInBand
        Me.grdDataMain.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Me.grdDataMain.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.grdDataMain.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.grdDataMain.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.grdDataMain.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.grdDataMain.DisplayLayout.Override.SupportDataErrorInfo = Infragistics.Win.UltraWinGrid.SupportDataErrorInfo.RowsOnly
        Appearance14.BackColor = System.Drawing.SystemColors.ControlLight
        Me.grdDataMain.DisplayLayout.Override.TemplateAddRowAppearance = Appearance14
        Me.grdDataMain.DisplayLayout.Override.TipStyleScroll = Infragistics.Win.UltraWinGrid.TipStyle.Hide
        Me.grdDataMain.DisplayLayout.Override.WrapHeaderText = Infragistics.Win.DefaultableBoolean.[True]
        Me.grdDataMain.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grdDataMain.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grdDataMain.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.grdDataMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdDataMain.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdDataMain.Location = New System.Drawing.Point(1, 34)
        Me.grdDataMain.Name = "grdDataMain"
        Me.grdDataMain.Size = New System.Drawing.Size(845, 202)
        Me.grdDataMain.TabIndex = 10
        Me.grdDataMain.Text = "Datos"
        '
        'grpInfoREq
        '
        Appearance166.TextHAlignAsString = "Center"
        Me.grpInfoREq.Appearance = Appearance166
        Me.grpInfoREq.BorderStyle = Infragistics.Win.Misc.GroupBoxBorderStyle.HeaderDoubleSolid
        Me.grpInfoREq.Controls.Add(Me.tblInfo)
        Me.grpInfoREq.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpInfoREq.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpInfoREq.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance167.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance167.BorderColor = System.Drawing.Color.Gray
        Appearance167.ForeColor = System.Drawing.Color.Navy
        Appearance167.TextHAlignAsString = "Center"
        Appearance167.TextTrimming = Infragistics.Win.TextTrimming.None
        Appearance167.TextVAlignAsString = "Middle"
        Me.grpInfoREq.HeaderAppearance = Appearance167
        Me.grpInfoREq.HeaderBorderStyle = Infragistics.Win.UIElementBorderStyle.Rounded1
        Me.grpInfoREq.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOnBorder
        Me.grpInfoREq.Location = New System.Drawing.Point(3, 32)
        Me.grpInfoREq.Name = "grpInfoREq"
        Me.grpInfoREq.Size = New System.Drawing.Size(847, 57)
        Me.grpInfoREq.TabIndex = 8
        Me.grpInfoREq.Text = "Información Requerida"
        Me.grpInfoREq.VerticalTextOrientation = Infragistics.Win.Misc.GroupBoxVerticalTextOrientation.BottomToTop
        Me.grpInfoREq.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2000
        '
        'tblInfo
        '
        Me.tblInfo.ColumnCount = 6
        Me.tblInfo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tblInfo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.tblInfo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.0!))
        Me.tblInfo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tblInfo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.0!))
        Me.tblInfo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tblInfo.Controls.Add(Me.optTipo, 3, 0)
        Me.tblInfo.Controls.Add(Me.txtcveCatastral, 2, 0)
        Me.tblInfo.Controls.Add(Me.lblNumCuenta, 1, 0)
        Me.tblInfo.Controls.Add(Me.btnBuscar, 4, 0)
        Me.tblInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblInfo.Location = New System.Drawing.Point(1, 34)
        Me.tblInfo.Name = "tblInfo"
        Me.tblInfo.RowCount = 1
        Me.tblInfo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblInfo.Size = New System.Drawing.Size(845, 22)
        Me.tblInfo.TabIndex = 0
        '
        'optTipo
        '
        Appearance168.TextHAlignAsString = "Right"
        Me.optTipo.Appearance = Appearance168
        Me.optTipo.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.optTipo.Dock = System.Windows.Forms.DockStyle.Fill
        Appearance169.FontData.BoldAsString = "False"
        Appearance169.FontData.SizeInPoints = 8.0!
        Appearance169.TextHAlignAsString = "Right"
        Appearance169.TextVAlignAsString = "Middle"
        Me.optTipo.ItemAppearance = Appearance169
        Appearance170.TextHAlignAsString = "Center"
        Appearance170.TextVAlignAsString = "Middle"
        ValueListItem3.Appearance = Appearance170
        ValueListItem3.DataValue = "2"
        ValueListItem3.DisplayText = "Por Período"
        Appearance171.TextHAlignAsString = "Center"
        Appearance171.TextVAlignAsString = "Middle"
        ValueListItem4.Appearance = Appearance171
        ValueListItem4.DataValue = "1"
        ValueListItem4.DisplayText = "Anual"
        Me.optTipo.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem3, ValueListItem4})
        Me.optTipo.ItemSpacingHorizontal = 10
        Me.optTipo.ItemSpacingVertical = 10
        Me.optTipo.Location = New System.Drawing.Point(483, 3)
        Me.optTipo.Name = "optTipo"
        Me.optTipo.Size = New System.Drawing.Size(163, 16)
        Me.optTipo.TabIndex = 37
        Me.optTipo.TextIndentation = 5
        Me.optTipo.TextRenderingMode = Infragistics.Win.TextRenderingMode.GDIPlus
        Me.optTipo.UseFlatMode = Infragistics.Win.DefaultableBoolean.[True]
        Me.optTipo.UseOsThemes = Infragistics.Win.DefaultableBoolean.[True]
        '
        'txtcveCatastral
        '
        Me.txtcveCatastral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtcveCatastral.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.txtcveCatastral.InputMask = "################"
        Me.txtcveCatastral.Location = New System.Drawing.Point(298, 3)
        Me.txtcveCatastral.Name = "txtcveCatastral"
        Me.txtcveCatastral.NonAutoSizeHeight = 26
        Me.txtcveCatastral.Size = New System.Drawing.Size(179, 33)
        Me.txtcveCatastral.TabIndex = 36
        '
        'lblNumCuenta
        '
        Me.lblNumCuenta.AutoSize = True
        Me.lblNumCuenta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblNumCuenta.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumCuenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblNumCuenta.Location = New System.Drawing.Point(45, 0)
        Me.lblNumCuenta.Name = "lblNumCuenta"
        Me.lblNumCuenta.Size = New System.Drawing.Size(247, 22)
        Me.lblNumCuenta.TabIndex = 0
        Me.lblNumCuenta.Text = "Número de Cuenta o Contrato:"
        Me.lblNumCuenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnBuscar
        '
        Me.btnBuscar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnBuscar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(652, 3)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 16)
        Me.btnBuscar.TabIndex = 38
        Me.btnBuscar.Text = "&Consultar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'grpDatosProp
        '
        Appearance172.TextHAlignAsString = "Center"
        Me.grpDatosProp.Appearance = Appearance172
        Me.grpDatosProp.BorderStyle = Infragistics.Win.Misc.GroupBoxBorderStyle.HeaderDoubleSolid
        Me.grpDatosProp.Controls.Add(Me.TableLayoutPanel3)
        Me.grpDatosProp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpDatosProp.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDatosProp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance173.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance173.BorderColor = System.Drawing.Color.Gray
        Appearance173.ForeColor = System.Drawing.Color.Navy
        Appearance173.TextHAlignAsString = "Center"
        Appearance173.TextTrimming = Infragistics.Win.TextTrimming.None
        Appearance173.TextVAlignAsString = "Middle"
        Me.grpDatosProp.HeaderAppearance = Appearance173
        Me.grpDatosProp.HeaderBorderStyle = Infragistics.Win.UIElementBorderStyle.Rounded1
        Me.grpDatosProp.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOnBorder
        Me.grpDatosProp.Location = New System.Drawing.Point(3, 95)
        Me.grpDatosProp.Name = "grpDatosProp"
        Me.grpDatosProp.Size = New System.Drawing.Size(847, 120)
        Me.grpDatosProp.TabIndex = 7
        Me.grpDatosProp.Text = "Datos del Propietario"
        Me.grpDatosProp.VerticalTextOrientation = Infragistics.Win.Misc.GroupBoxVerticalTextOrientation.BottomToTop
        Me.grpDatosProp.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2000
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 7
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.txtMesPago, 4, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.txtAñoPago, 2, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.lblMesPago, 3, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.txtUbicacion, 2, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.lblAñoPago, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.lblUbicacion, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.lblPropietario, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.txtPropietario, 2, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(1, 34)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(845, 85)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'txtMesPago
        '
        Me.txtMesPago.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMesPago.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtMesPago.Location = New System.Drawing.Point(339, 59)
        Me.txtMesPago.Name = "txtMesPago"
        Me.txtMesPago.ReadOnly = True
        Me.txtMesPago.Size = New System.Drawing.Size(78, 33)
        Me.txtMesPago.TabIndex = 8
        '
        'txtAñoPago
        '
        Me.txtAñoPago.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAñoPago.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtAñoPago.Location = New System.Drawing.Point(171, 59)
        Me.txtAñoPago.Name = "txtAñoPago"
        Me.txtAñoPago.ReadOnly = True
        Me.txtAñoPago.Size = New System.Drawing.Size(78, 33)
        Me.txtAñoPago.TabIndex = 7
        '
        'lblMesPago
        '
        Me.lblMesPago.AutoSize = True
        Me.lblMesPago.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMesPago.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMesPago.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblMesPago.Location = New System.Drawing.Point(255, 56)
        Me.lblMesPago.Name = "lblMesPago"
        Me.lblMesPago.Size = New System.Drawing.Size(78, 29)
        Me.lblMesPago.TabIndex = 6
        Me.lblMesPago.Text = "Mes Pago:"
        Me.lblMesPago.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtUbicacion
        '
        Me.txtUbicacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TableLayoutPanel3.SetColumnSpan(Me.txtUbicacion, 4)
        Me.txtUbicacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtUbicacion.Location = New System.Drawing.Point(171, 31)
        Me.txtUbicacion.Name = "txtUbicacion"
        Me.txtUbicacion.ReadOnly = True
        Me.txtUbicacion.Size = New System.Drawing.Size(626, 33)
        Me.txtUbicacion.TabIndex = 5
        '
        'lblAñoPago
        '
        Me.lblAñoPago.AutoSize = True
        Me.lblAñoPago.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblAñoPago.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAñoPago.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblAñoPago.Location = New System.Drawing.Point(45, 56)
        Me.lblAñoPago.Name = "lblAñoPago"
        Me.lblAñoPago.Size = New System.Drawing.Size(120, 29)
        Me.lblAñoPago.TabIndex = 3
        Me.lblAñoPago.Text = "Año Pago:"
        Me.lblAñoPago.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUbicacion
        '
        Me.lblUbicacion.AutoSize = True
        Me.lblUbicacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblUbicacion.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUbicacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblUbicacion.Location = New System.Drawing.Point(45, 28)
        Me.lblUbicacion.Name = "lblUbicacion"
        Me.lblUbicacion.Size = New System.Drawing.Size(120, 28)
        Me.lblUbicacion.TabIndex = 2
        Me.lblUbicacion.Text = "Ubicación:"
        Me.lblUbicacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPropietario
        '
        Me.lblPropietario.AutoSize = True
        Me.lblPropietario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPropietario.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPropietario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblPropietario.Location = New System.Drawing.Point(45, 0)
        Me.lblPropietario.Name = "lblPropietario"
        Me.lblPropietario.Size = New System.Drawing.Size(120, 28)
        Me.lblPropietario.TabIndex = 1
        Me.lblPropietario.Text = "Propietario:"
        Me.lblPropietario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPropietario
        '
        Me.txtPropietario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TableLayoutPanel3.SetColumnSpan(Me.txtPropietario, 4)
        Me.txtPropietario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPropietario.Location = New System.Drawing.Point(171, 3)
        Me.txtPropietario.Name = "txtPropietario"
        Me.txtPropietario.ReadOnly = True
        Me.txtPropietario.Size = New System.Drawing.Size(626, 33)
        Me.txtPropietario.TabIndex = 4
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.SystemMessages1, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(847, 23)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'SystemMessages1
        '
        Me.SystemMessages1.AutoScroll = True
        Me.SystemMessages1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel2.SetColumnSpan(Me.SystemMessages1, 2)
        Me.SystemMessages1.Dock = System.Windows.Forms.DockStyle.Top
        Me.SystemMessages1.Location = New System.Drawing.Point(4, 5)
        Me.SystemMessages1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SystemMessages1.Name = "SystemMessages1"
        Me.SystemMessages1.Size = New System.Drawing.Size(847, 13)
        Me.SystemMessages1.TabIndex = 1
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
        Me.tblButtons.Controls.Add(Me.lblTotal, 5, 0)
        Me.tblButtons.Controls.Add(Me.btnPago, 0, 0)
        Me.tblButtons.Controls.Add(Me.btnImprimeRpt, 2, 0)
        Me.tblButtons.Controls.Add(Me.btnClose, 4, 0)
        Me.tblButtons.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblButtons.Location = New System.Drawing.Point(3, 464)
        Me.tblButtons.Name = "tblButtons"
        Me.tblButtons.RowCount = 1
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblButtons.Size = New System.Drawing.Size(847, 20)
        Me.tblButtons.TabIndex = 10
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.tblButtons.SetColumnSpan(Me.lblTotal, 2)
        Me.lblTotal.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTotal.Location = New System.Drawing.Point(595, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(249, 20)
        Me.lblTotal.TabIndex = 42
        Me.lblTotal.Text = "Número de Cuenta o Contrato:"
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
        Me.btnPago.Size = New System.Drawing.Size(205, 14)
        Me.btnPago.TabIndex = 41
        Me.btnPago.Text = "&Realizar Pago"
        Me.btnPago.UseVisualStyleBackColor = True
        '
        'btnImprimeRpt
        '
        Me.btnImprimeRpt.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimeRpt.ForeColor = System.Drawing.Color.Navy
        Me.btnImprimeRpt.Location = New System.Drawing.Point(214, 3)
        Me.btnImprimeRpt.Name = "btnImprimeRpt"
        Me.btnImprimeRpt.Size = New System.Drawing.Size(121, 14)
        Me.btnImprimeRpt.TabIndex = 40
        Me.btnImprimeRpt.Text = "&Imprimir"
        Me.btnImprimeRpt.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Navy
        Me.btnClose.Location = New System.Drawing.Point(468, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(121, 14)
        Me.btnClose.TabIndex = 43
        Me.btnClose.Text = "&Cerrar"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'UltraMessageBoxManager1
        '
        Me.UltraMessageBoxManager1.ContainingControl = Me
        '
        'frmLiquidaPredial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(853, 487)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmLiquidaPredial"
        Me.Text = "Pago de Agua"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.grpDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDetails.ResumeLayout(False)
        CType(Me.grdDataMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpInfoREq, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpInfoREq.ResumeLayout(False)
        Me.tblInfo.ResumeLayout(False)
        Me.tblInfo.PerformLayout()
        CType(Me.optTipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpDatosProp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDatosProp.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.tblButtons.ResumeLayout(False)
        Me.tblButtons.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGridBagLayoutManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents grpDetails As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents grpInfoREq As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents grpDatosProp As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents tblInfo As TableLayoutPanel
    Friend WithEvents lblNumCuenta As Label
    Friend WithEvents txtcveCatastral As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents optTipo As Infragistics.Win.UltraWinEditors.UltraOptionSet
    Friend WithEvents btnBuscar As Button
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents lblAñoPago As Label
    Friend WithEvents lblUbicacion As Label
    Friend WithEvents lblPropietario As Label
    Friend WithEvents txtPropietario As TextBox
    Friend WithEvents txtUbicacion As TextBox
    Friend WithEvents lblMesPago As Label
    Friend WithEvents txtMesPago As TextBox
    Friend WithEvents txtAñoPago As TextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents tblButtons As TableLayoutPanel
    Friend WithEvents btnImprimeRpt As Button
    Friend WithEvents btnPago As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents UltraGridBagLayoutManager1 As Infragistics.Win.Misc.UltraGridBagLayoutManager
    Friend WithEvents grdDataMain As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraMessageBoxManager1 As Infragistics.Win.UltraMessageBox.UltraMessageBoxManager
    Friend WithEvents SystemMessages1 As SystemMessages
    Friend WithEvents btnClose As Button
End Class
