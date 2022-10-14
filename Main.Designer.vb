<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Dim UltraExplorerBarGroup1 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup()
        Dim UltraExplorerBarItem1 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraExplorerBarGroup2 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup()
        Dim UltraExplorerBarGroup3 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("tip_predio", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("tipo_predio", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, False)
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
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.CommandBar = New System.Windows.Forms.ToolStrip()
        Me.lblBusca = New System.Windows.Forms.ToolStripLabel()
        Me.txtFilter = New System.Windows.Forms.ToolStripTextBox()
        Me.btnBuscaFiltro = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnView = New System.Windows.Forms.ToolStripButton()
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.btnAbrir = New System.Windows.Forms.ToolStripButton()
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Excel = New System.Windows.Forms.ToolStripButton()
        Me.btnPDF = New System.Windows.Forms.ToolStripButton()
        Me.btnReporte = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblParent = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblMenu = New System.Windows.Forms.ToolStripLabel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.UltraExplorerBar1 = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.btnIrMenu = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.lblTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.UltraGridExcelExporter1 = New Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter(Me.components)
        Me.UltraGridDocumentExporter1 = New Infragistics.Win.UltraWinGrid.DocumentExport.UltraGridDocumentExporter(Me.components)
        Me.sysmsg1 = New TCM2017.SystemMessages()
        Me.UltraDockManager1 = New Infragistics.Win.UltraWinDock.UltraDockManager(Me.components)
        Me._MainUnpinnedTabAreaLeft = New Infragistics.Win.UltraWinDock.UnpinnedTabArea()
        Me._MainUnpinnedTabAreaRight = New Infragistics.Win.UltraWinDock.UnpinnedTabArea()
        Me._MainUnpinnedTabAreaTop = New Infragistics.Win.UltraWinDock.UnpinnedTabArea()
        Me._MainUnpinnedTabAreaBottom = New Infragistics.Win.UltraWinDock.UnpinnedTabArea()
        Me._MainAutoHideControl = New Infragistics.Win.UltraWinDock.AutoHideControl()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.grdDataMain = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.CommandBar.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.UltraExplorerBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        CType(Me.UltraDockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.grdDataMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CommandBar
        '
        Me.CommandBar.BackColor = System.Drawing.Color.White
        Me.CommandBar.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.CommandBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblBusca, Me.txtFilter, Me.btnBuscaFiltro, Me.ToolStripSeparator2, Me.btnView, Me.btnNuevo, Me.btnAbrir, Me.btnEliminar, Me.ToolStripSeparator1, Me.Excel, Me.btnPDF, Me.btnReporte, Me.ToolStripSeparator10, Me.lblParent, Me.ToolStripSeparator9, Me.lblMenu})
        Me.CommandBar.Location = New System.Drawing.Point(0, 0)
        Me.CommandBar.Name = "CommandBar"
        Me.CommandBar.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.CommandBar.Size = New System.Drawing.Size(682, 31)
        Me.CommandBar.TabIndex = 15
        Me.CommandBar.Text = "CommandBar"
        '
        'lblBusca
        '
        Me.lblBusca.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBusca.Name = "lblBusca"
        Me.lblBusca.Size = New System.Drawing.Size(47, 28)
        Me.lblBusca.Text = "Buscar:"
        '
        'txtFilter
        '
        Me.txtFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFilter.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(100, 31)
        '
        'btnBuscaFiltro
        '
        Me.btnBuscaFiltro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnBuscaFiltro.Image = Global.TCM2017.My.Resources.Resources.search
        Me.btnBuscaFiltro.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBuscaFiltro.Name = "btnBuscaFiltro"
        Me.btnBuscaFiltro.Size = New System.Drawing.Size(28, 28)
        Me.btnBuscaFiltro.Text = "ToolStripButton1"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'btnView
        '
        Me.btnView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnView.Image = Global.TCM2017.My.Resources.Resources.find
        Me.btnView.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(28, 28)
        Me.btnView.Text = "Ver Registro"
        '
        'btnNuevo
        '
        Me.btnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageTransparentColor = System.Drawing.Color.Black
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(28, 28)
        Me.btnNuevo.Text = "Agregar Registro"
        '
        'btnAbrir
        '
        Me.btnAbrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnAbrir.Image = CType(resources.GetObject("btnAbrir.Image"), System.Drawing.Image)
        Me.btnAbrir.ImageTransparentColor = System.Drawing.Color.Black
        Me.btnAbrir.Name = "btnAbrir"
        Me.btnAbrir.Size = New System.Drawing.Size(28, 28)
        Me.btnAbrir.Text = "&Abrir Registro"
        '
        'btnEliminar
        '
        Me.btnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnEliminar.Image = Global.TCM2017.My.Resources.Resources.delete1
        Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(28, 28)
        Me.btnEliminar.Text = "Eliminar Registro"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'Excel
        '
        Me.Excel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Excel.Image = Global.TCM2017.My.Resources.Resources.Excel1
        Me.Excel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Excel.Name = "Excel"
        Me.Excel.Size = New System.Drawing.Size(28, 28)
        Me.Excel.Text = "Exportar a Excel"
        '
        'btnPDF
        '
        Me.btnPDF.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPDF.Image = Global.TCM2017.My.Resources.Resources.pdf
        Me.btnPDF.ImageTransparentColor = System.Drawing.Color.Black
        Me.btnPDF.Name = "btnPDF"
        Me.btnPDF.Size = New System.Drawing.Size(28, 28)
        Me.btnPDF.Text = "Generar PDF"
        '
        'btnReporte
        '
        Me.btnReporte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnReporte.Image = Global.TCM2017.My.Resources.Resources.book_marks
        Me.btnReporte.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Size = New System.Drawing.Size(28, 28)
        Me.btnReporte.Text = "Reportes"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 31)
        '
        'lblParent
        '
        Me.lblParent.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParent.ForeColor = System.Drawing.Color.Black
        Me.lblParent.Name = "lblParent"
        Me.lblParent.Size = New System.Drawing.Size(181, 28)
        Me.lblParent.Text = "                                                          "
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 31)
        '
        'lblMenu
        '
        Me.lblMenu.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenu.ForeColor = System.Drawing.Color.Blue
        Me.lblMenu.Name = "lblMenu"
        Me.lblMenu.Size = New System.Drawing.Size(44, 28)
        Me.lblMenu.Text = " Menu:"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.White
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(2)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.UltraExplorerBar1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ToolStrip1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.UltraTabControl1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.CommandBar)
        Me.SplitContainer1.Size = New System.Drawing.Size(893, 562)
        Me.SplitContainer1.SplitterDistance = 206
        Me.SplitContainer1.SplitterWidth = 3
        Me.SplitContainer1.TabIndex = 20
        '
        'UltraExplorerBar1
        '
        Me.UltraExplorerBar1.AcceptsFocus = Infragistics.Win.DefaultableBoolean.[True]
        Me.UltraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill
        UltraExplorerBarItem1.Checked = True
        Appearance1.Image = Global.TCM2017.My.Resources.Resources.predial
        UltraExplorerBarItem1.Settings.AppearancesLarge.ActiveAppearance = Appearance1
        UltraExplorerBarItem1.Text = "New Item"
        UltraExplorerBarGroup1.Items.AddRange(New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarItem() {UltraExplorerBarItem1})
        UltraExplorerBarGroup1.Text = "New Group"
        UltraExplorerBarGroup2.Text = "New Group"
        UltraExplorerBarGroup3.Text = "New Group"
        Me.UltraExplorerBar1.Groups.AddRange(New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup() {UltraExplorerBarGroup1, UltraExplorerBarGroup2, UltraExplorerBarGroup3})
        Me.UltraExplorerBar1.GroupSettings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.SmallImagesWithText
        Me.UltraExplorerBar1.Location = New System.Drawing.Point(0, 0)
        Me.UltraExplorerBar1.Name = "UltraExplorerBar1"
        Me.UltraExplorerBar1.Size = New System.Drawing.Size(204, 529)
        Me.UltraExplorerBar1.Style = Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarStyle.Listbar
        Me.UltraExplorerBar1.TabIndex = 19
        Me.UltraExplorerBar1.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintToolStripMenuItem, Me.ToolStripButton1, Me.btnIrMenu, Me.ToolStripButton4, Me.ToolStripButton5})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 529)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ToolStrip1.Size = New System.Drawing.Size(204, 31)
        Me.ToolStrip1.TabIndex = 16
        Me.ToolStrip1.Text = "Barra de comandos"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PrintToolStripMenuItem.Image = Global.TCM2017.My.Resources.Resources.printer
        Me.PrintToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(28, 28)
        Me.PrintToolStripMenuItem.Text = "Archivos Generados"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.TCM2017.My.Resources.Resources.refresh
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(28, 28)
        Me.ToolStripButton1.Text = "Actualizar Menus"
        '
        'btnIrMenu
        '
        Me.btnIrMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnIrMenu.Image = Global.TCM2017.My.Resources.Resources.findMNU
        Me.btnIrMenu.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnIrMenu.Name = "btnIrMenu"
        Me.btnIrMenu.Size = New System.Drawing.Size(28, 28)
        Me.btnIrMenu.Text = "Buscar Menu"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = Global.TCM2017.My.Resources.Resources.help
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(28, 28)
        Me.ToolStripButton4.Text = "Ayuda"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = Global.TCM2017.My.Resources.Resources._exit
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(28, 28)
        Me.ToolStripButton5.Text = "Salir del Sistema"
        '
        'lblTime
        '
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(37, 17)
        Me.lblTime.Text = "Time:"
        '
        'StatusStrip
        '
        Me.StatusStrip.BackColor = System.Drawing.Color.White
        Me.StatusStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblTime})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 562)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Padding = New System.Windows.Forms.Padding(2, 0, 14, 0)
        Me.StatusStrip.Size = New System.Drawing.Size(893, 22)
        Me.StatusStrip.TabIndex = 19
        Me.StatusStrip.Text = "StatusStrip"
        '
        'sysmsg1
        '
        Me.sysmsg1.AutoScroll = True
        Me.sysmsg1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.sysmsg1.Dock = System.Windows.Forms.DockStyle.Top
        Me.sysmsg1.Location = New System.Drawing.Point(9, 8)
        Me.sysmsg1.Name = "sysmsg1"
        Me.sysmsg1.Size = New System.Drawing.Size(909, 26)
        Me.sysmsg1.TabIndex = 18
        Me.sysmsg1.Visible = False
        '
        'UltraDockManager1
        '
        Me.UltraDockManager1.CompressUnpinnedTabs = False
        Me.UltraDockManager1.HostControl = Me
        Me.UltraDockManager1.LayoutStyle = Infragistics.Win.UltraWinDock.DockAreaLayoutStyle.FillContainer
        '
        '_MainUnpinnedTabAreaLeft
        '
        Me._MainUnpinnedTabAreaLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me._MainUnpinnedTabAreaLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._MainUnpinnedTabAreaLeft.Location = New System.Drawing.Point(0, 0)
        Me._MainUnpinnedTabAreaLeft.Name = "_MainUnpinnedTabAreaLeft"
        Me._MainUnpinnedTabAreaLeft.Owner = Me.UltraDockManager1
        Me._MainUnpinnedTabAreaLeft.Size = New System.Drawing.Size(0, 562)
        Me._MainUnpinnedTabAreaLeft.TabIndex = 22
        '
        '_MainUnpinnedTabAreaRight
        '
        Me._MainUnpinnedTabAreaRight.Dock = System.Windows.Forms.DockStyle.Right
        Me._MainUnpinnedTabAreaRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._MainUnpinnedTabAreaRight.Location = New System.Drawing.Point(893, 0)
        Me._MainUnpinnedTabAreaRight.Name = "_MainUnpinnedTabAreaRight"
        Me._MainUnpinnedTabAreaRight.Owner = Me.UltraDockManager1
        Me._MainUnpinnedTabAreaRight.Size = New System.Drawing.Size(0, 562)
        Me._MainUnpinnedTabAreaRight.TabIndex = 23
        '
        '_MainUnpinnedTabAreaTop
        '
        Me._MainUnpinnedTabAreaTop.Dock = System.Windows.Forms.DockStyle.Top
        Me._MainUnpinnedTabAreaTop.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._MainUnpinnedTabAreaTop.Location = New System.Drawing.Point(0, 0)
        Me._MainUnpinnedTabAreaTop.Name = "_MainUnpinnedTabAreaTop"
        Me._MainUnpinnedTabAreaTop.Owner = Me.UltraDockManager1
        Me._MainUnpinnedTabAreaTop.Size = New System.Drawing.Size(893, 0)
        Me._MainUnpinnedTabAreaTop.TabIndex = 24
        '
        '_MainUnpinnedTabAreaBottom
        '
        Me._MainUnpinnedTabAreaBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me._MainUnpinnedTabAreaBottom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._MainUnpinnedTabAreaBottom.Location = New System.Drawing.Point(0, 562)
        Me._MainUnpinnedTabAreaBottom.Name = "_MainUnpinnedTabAreaBottom"
        Me._MainUnpinnedTabAreaBottom.Owner = Me.UltraDockManager1
        Me._MainUnpinnedTabAreaBottom.Size = New System.Drawing.Size(893, 0)
        Me._MainUnpinnedTabAreaBottom.TabIndex = 25
        '
        '_MainAutoHideControl
        '
        Me._MainAutoHideControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._MainAutoHideControl.Location = New System.Drawing.Point(0, 0)
        Me._MainAutoHideControl.Name = "_MainAutoHideControl"
        Me._MainAutoHideControl.Owner = Me.UltraDockManager1
        Me._MainAutoHideControl.Size = New System.Drawing.Size(0, 0)
        Me._MainAutoHideControl.TabIndex = 26
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.grdDataMain)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 24)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(680, 504)
        '
        'grdDataMain
        '
        Appearance2.BackColor = System.Drawing.SystemColors.Window
        Appearance2.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.grdDataMain.DisplayLayout.Appearance = Appearance2
        Me.grdDataMain.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Width = 295
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 352
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
        Me.grdDataMain.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Synchronized
        Me.grdDataMain.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed
        Me.grdDataMain.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.grdDataMain.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.grdDataMain.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        Me.grdDataMain.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.grdDataMain.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.grdDataMain.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance8.BackColor = System.Drawing.SystemColors.Window
        Me.grdDataMain.DisplayLayout.Override.CardAreaAppearance = Appearance8
        Appearance9.BorderColor = System.Drawing.Color.Silver
        Appearance9.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.grdDataMain.DisplayLayout.Override.CellAppearance = Appearance9
        Me.grdDataMain.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.grdDataMain.DisplayLayout.Override.CellPadding = 0
        Me.grdDataMain.DisplayLayout.Override.ColumnSizingArea = Infragistics.Win.UltraWinGrid.ColumnSizingArea.EntireColumn
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
        Me.grdDataMain.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grdDataMain.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.grdDataMain.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.grdDataMain.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.grdDataMain.DisplayLayout.Override.SummaryDisplayArea = CType((Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed Or Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.RootRowsFootersOnly), Infragistics.Win.UltraWinGrid.SummaryDisplayAreas)
        Me.grdDataMain.DisplayLayout.Override.SupportDataErrorInfo = Infragistics.Win.UltraWinGrid.SupportDataErrorInfo.RowsOnly
        Appearance14.BackColor = System.Drawing.SystemColors.ControlLight
        Me.grdDataMain.DisplayLayout.Override.TemplateAddRowAppearance = Appearance14
        Me.grdDataMain.DisplayLayout.Override.TipStyleScroll = Infragistics.Win.UltraWinGrid.TipStyle.Hide
        Me.grdDataMain.DisplayLayout.Override.WrapHeaderText = Infragistics.Win.DefaultableBoolean.[True]
        Me.grdDataMain.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grdDataMain.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grdDataMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdDataMain.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdDataMain.Location = New System.Drawing.Point(0, 0)
        Me.grdDataMain.Name = "grdDataMain"
        Me.grdDataMain.Size = New System.Drawing.Size(680, 504)
        Me.grdDataMain.TabIndex = 9
        Me.grdDataMain.Text = "Datos"
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(680, 504)
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.CloseButtonLocation = Infragistics.Win.UltraWinTabs.TabCloseButtonLocation.None
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 31)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Appearance15.BackColor = System.Drawing.Color.WhiteSmoke
        Appearance15.BackColor2 = System.Drawing.Color.LightCoral
        Appearance15.BackGradientAlignment = Infragistics.Win.GradientAlignment.Container
        Appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.GlassTop37
        Appearance15.BackHatchStyle = Infragistics.Win.BackHatchStyle.None
        Appearance15.BorderColor = System.Drawing.Color.Black
        Appearance15.FontData.BoldAsString = "True"
        Appearance15.FontData.SizeInPoints = 10.0!
        Me.UltraTabControl1.SelectedTabAppearance = Appearance15
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(682, 529)
        Me.UltraTabControl1.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.VisualStudio2005
        Me.UltraTabControl1.TabIndex = 16
        Me.UltraTabControl1.TabOrientation = Infragistics.Win.UltraWinTabs.TabOrientation.TopLeft
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Busqueda de Datos"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1})
        Me.UltraTabControl1.TextOrientation = Infragistics.Win.UltraWinTabs.TextOrientation.Horizontal
        Me.UltraTabControl1.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Standard
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(893, 584)
        Me.Controls.Add(Me._MainAutoHideControl)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.sysmsg1)
        Me.Controls.Add(Me._MainUnpinnedTabAreaBottom)
        Me.Controls.Add(Me._MainUnpinnedTabAreaTop)
        Me.Controls.Add(Me._MainUnpinnedTabAreaRight)
        Me.Controls.Add(Me._MainUnpinnedTabAreaLeft)
        Me.Controls.Add(Me.StatusStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema Tributario Catastral 2019"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.CommandBar.ResumeLayout(False)
        Me.CommandBar.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.UltraExplorerBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        CType(Me.UltraDockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.grdDataMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents sysmsg1 As SystemMessages
    Friend WithEvents Timer1 As Timer
    Friend WithEvents CommandBar As ToolStrip
    Friend WithEvents lblBusca As ToolStripLabel
    Friend WithEvents txtFilter As ToolStripTextBox
    Friend WithEvents btnBuscaFiltro As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents btnView As ToolStripButton
    Friend WithEvents btnNuevo As ToolStripButton
    Friend WithEvents btnAbrir As ToolStripButton
    Friend WithEvents btnEliminar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents Excel As ToolStripButton
    Friend WithEvents btnPDF As ToolStripButton
    Friend WithEvents btnReporte As ToolStripButton
    Friend WithEvents ToolStripSeparator10 As ToolStripSeparator
    Friend WithEvents lblParent As ToolStripLabel
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents lblMenu As ToolStripLabel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents UltraExplorerBar1 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar
    Friend WithEvents lblTime As ToolStripStatusLabel
    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents UltraGridExcelExporter1 As Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter
    Friend WithEvents UltraGridDocumentExporter1 As Infragistics.Win.UltraWinGrid.DocumentExport.UltraGridDocumentExporter
    Friend WithEvents UltraDockManager1 As Infragistics.Win.UltraWinDock.UltraDockManager
    Friend WithEvents _MainAutoHideControl As Infragistics.Win.UltraWinDock.AutoHideControl
    Friend WithEvents _MainUnpinnedTabAreaBottom As Infragistics.Win.UltraWinDock.UnpinnedTabArea
    Friend WithEvents _MainUnpinnedTabAreaTop As Infragistics.Win.UltraWinDock.UnpinnedTabArea
    Friend WithEvents _MainUnpinnedTabAreaRight As Infragistics.Win.UltraWinDock.UnpinnedTabArea
    Friend WithEvents _MainUnpinnedTabAreaLeft As Infragistics.Win.UltraWinDock.UnpinnedTabArea
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents PrintToolStripMenuItem As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents btnIrMenu As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Private WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Private WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Private WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Private WithEvents grdDataMain As Infragistics.Win.UltraWinGrid.UltraGrid
End Class
