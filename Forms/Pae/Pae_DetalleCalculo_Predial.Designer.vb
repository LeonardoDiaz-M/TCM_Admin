<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pae_DetalleCalculo_Predial
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
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("viePaeDetalleCalculoPredial", -1)
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClaveCatastral")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("propietario")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ubicacion")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Año")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Mesini")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Mes")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BaseGrav")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Impuesto")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Recargos")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Multas")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gastos")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Sub_Imp")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Sub_Rec")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Sub_Multa")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Sub_Gastos")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Paga")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Acum_Ant")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Imp_Total")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Me.DsPae = New TCMAdmin.dsPae()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.btnBack = New System.Windows.Forms.ToolStripButton()
        Me.btnExportaExcel = New System.Windows.Forms.ToolStripButton()
        Me.griDetalle = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.ugeExporter = New Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter(Me.components)
        Me.ViePaeDetalleCalculoPredialBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ViePaeDetalleCalculoPredialTableAdapter = New TCMAdmin.dsPaeTableAdapters.viePaeDetalleCalculoPredialTableAdapter()
        CType(Me.DsPae, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.griDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViePaeDetalleCalculoPredialBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DsPae
        '
        Me.DsPae.DataSetName = "dsPae"
        Me.DsPae.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BackColor = System.Drawing.Color.Transparent
        Me.BindingNavigator1.CountItem = Nothing
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.ImageScalingSize = New System.Drawing.Size(36, 36)
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBack, Me.btnExportaExcel})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Nothing
        Me.BindingNavigator1.MoveLastItem = Nothing
        Me.BindingNavigator1.MoveNextItem = Nothing
        Me.BindingNavigator1.MovePreviousItem = Nothing
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.BindingNavigator1.PositionItem = Nothing
        Me.BindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.BindingNavigator1.Size = New System.Drawing.Size(1234, 43)
        Me.BindingNavigator1.TabIndex = 9
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
        'btnExportaExcel
        '
        Me.btnExportaExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnExportaExcel.Image = Global.TCMAdmin.My.Resources.Resources.Icon_File_Excel
        Me.btnExportaExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExportaExcel.Name = "btnExportaExcel"
        Me.btnExportaExcel.Size = New System.Drawing.Size(40, 40)
        Me.btnExportaExcel.Text = "ToolStripButton1"
        Me.btnExportaExcel.ToolTipText = "Exportar a excel"
        '
        'griDetalle
        '
        Me.griDetalle.DataSource = Me.ViePaeDetalleCalculoPredialBindingSource
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griDetalle.DisplayLayout.Appearance = Appearance1
        Appearance2.TextHAlignAsString = "Left"
        UltraGridColumn18.CellAppearance = Appearance2
        UltraGridColumn18.Header.VisiblePosition = 0
        UltraGridColumn18.Width = 120
        Appearance3.TextHAlignAsString = "Left"
        UltraGridColumn19.CellAppearance = Appearance3
        UltraGridColumn19.Header.VisiblePosition = 1
        UltraGridColumn19.Width = 153
        Appearance4.TextHAlignAsString = "Left"
        UltraGridColumn20.CellAppearance = Appearance4
        UltraGridColumn20.Header.VisiblePosition = 2
        UltraGridColumn20.Width = 199
        Appearance5.TextHAlignAsString = "Center"
        UltraGridColumn21.CellAppearance = Appearance5
        UltraGridColumn21.Header.VisiblePosition = 3
        Appearance6.TextHAlignAsString = "Center"
        UltraGridColumn24.CellAppearance = Appearance6
        UltraGridColumn24.Header.Caption = "Per Inicial"
        UltraGridColumn24.Header.VisiblePosition = 4
        Appearance7.TextHAlignAsString = "Center"
        UltraGridColumn25.CellAppearance = Appearance7
        UltraGridColumn25.Header.Caption = "Per Final"
        UltraGridColumn25.Header.VisiblePosition = 5
        UltraGridColumn26.Format = "$#,##0.00"
        UltraGridColumn26.Header.VisiblePosition = 6
        UltraGridColumn27.Format = "$#,##0.00"
        UltraGridColumn27.Header.VisiblePosition = 7
        UltraGridColumn28.Format = "$#,##0.00"
        UltraGridColumn28.Header.VisiblePosition = 8
        UltraGridColumn29.Format = "$#,##0.00"
        UltraGridColumn29.Header.VisiblePosition = 9
        UltraGridColumn30.Format = "$#,##0.00"
        UltraGridColumn30.Header.VisiblePosition = 10
        UltraGridColumn31.Format = "$#,##0.00"
        UltraGridColumn31.Header.VisiblePosition = 11
        UltraGridColumn32.Format = "$#,##0.00"
        UltraGridColumn32.Header.VisiblePosition = 12
        UltraGridColumn33.Format = "$#,##0.00"
        UltraGridColumn33.Header.VisiblePosition = 13
        UltraGridColumn34.Format = "$#,##0.00"
        UltraGridColumn34.Header.VisiblePosition = 14
        UltraGridColumn35.Format = "$#,##0.00"
        UltraGridColumn35.Header.VisiblePosition = 15
        UltraGridColumn36.Format = "$#,##0.00"
        UltraGridColumn36.Header.VisiblePosition = 16
        UltraGridColumn37.Format = "$#,##0.00"
        UltraGridColumn37.Header.VisiblePosition = 17
        UltraGridColumn38.Format = "$#,##0.00"
        UltraGridColumn38.Header.VisiblePosition = 18
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38})
        Appearance8.TextHAlignAsString = "Center"
        UltraGridBand1.Header.Appearance = Appearance8
        Me.griDetalle.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griDetalle.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griDetalle.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance9.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance9.BorderColor = System.Drawing.SystemColors.Window
        Me.griDetalle.DisplayLayout.GroupByBox.Appearance = Appearance9
        Appearance10.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griDetalle.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance10
        Me.griDetalle.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance11.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance11.BackColor2 = System.Drawing.SystemColors.Control
        Appearance11.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance11.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griDetalle.DisplayLayout.GroupByBox.PromptAppearance = Appearance11
        Me.griDetalle.DisplayLayout.MaxColScrollRegions = 1
        Me.griDetalle.DisplayLayout.MaxRowScrollRegions = 1
        Appearance12.BackColor = System.Drawing.SystemColors.Window
        Appearance12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.griDetalle.DisplayLayout.Override.ActiveCellAppearance = Appearance12
        Appearance13.BackColor = System.Drawing.SystemColors.Highlight
        Appearance13.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.griDetalle.DisplayLayout.Override.ActiveRowAppearance = Appearance13
        Me.griDetalle.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griDetalle.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance14.BackColor = System.Drawing.SystemColors.Window
        Me.griDetalle.DisplayLayout.Override.CardAreaAppearance = Appearance14
        Appearance15.BorderColor = System.Drawing.Color.Silver
        Appearance15.TextHAlignAsString = "Right"
        Appearance15.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.griDetalle.DisplayLayout.Override.CellAppearance = Appearance15
        Me.griDetalle.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.griDetalle.DisplayLayout.Override.CellPadding = 0
        Appearance16.BackColor = System.Drawing.SystemColors.Control
        Appearance16.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance16.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance16.BorderColor = System.Drawing.SystemColors.Window
        Me.griDetalle.DisplayLayout.Override.GroupByRowAppearance = Appearance16
        Appearance17.TextHAlignAsString = "Center"
        Me.griDetalle.DisplayLayout.Override.HeaderAppearance = Appearance17
        Me.griDetalle.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griDetalle.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance18.BackColor = System.Drawing.SystemColors.Window
        Appearance18.BorderColor = System.Drawing.Color.Silver
        Me.griDetalle.DisplayLayout.Override.RowAppearance = Appearance18
        Me.griDetalle.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance19.BackColor = System.Drawing.SystemColors.ControlLight
        Me.griDetalle.DisplayLayout.Override.TemplateAddRowAppearance = Appearance19
        Me.griDetalle.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griDetalle.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griDetalle.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griDetalle.Location = New System.Drawing.Point(0, 43)
        Me.griDetalle.Name = "griDetalle"
        Me.griDetalle.Size = New System.Drawing.Size(1234, 518)
        Me.griDetalle.TabIndex = 10
        Me.griDetalle.Text = "UltraGrid1"
        '
        'ViePaeDetalleCalculoPredialBindingSource
        '
        Me.ViePaeDetalleCalculoPredialBindingSource.DataMember = "viePaeDetalleCalculoPredial"
        Me.ViePaeDetalleCalculoPredialBindingSource.DataSource = Me.DsPae
        '
        'ViePaeDetalleCalculoPredialTableAdapter
        '
        Me.ViePaeDetalleCalculoPredialTableAdapter.ClearBeforeFill = True
        '
        'Pae_DetalleCalculo_Predial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1234, 561)
        Me.Controls.Add(Me.griDetalle)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Name = "Pae_DetalleCalculo_Predial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pae detalle cálculo"
        CType(Me.DsPae, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.griDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViePaeDetalleCalculoPredialBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DsPae As dsPae
    Friend WithEvents ViePaeDetalleCalculoPredialBindingSource As BindingSource
    Friend WithEvents ViePaeDetalleCalculoPredialTableAdapter As dsPaeTableAdapters.viePaeDetalleCalculoPredialTableAdapter
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents btnBack As ToolStripButton
    Friend WithEvents btnExportaExcel As ToolStripButton
    Friend WithEvents griDetalle As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ugeExporter As Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter
End Class
