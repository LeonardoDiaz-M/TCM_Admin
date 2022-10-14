<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExportedFiles
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
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraListViewItem1 As Infragistics.Win.UltraWinListView.UltraListViewItem = New Infragistics.Win.UltraWinListView.UltraListViewItem("lll", New Infragistics.Win.UltraWinListView.UltraListViewSubItem() {New Infragistics.Win.UltraWinListView.UltraListViewSubItem("pppp", Nothing), New Infragistics.Win.UltraWinListView.UltraListViewSubItem("000", Nothing)}, Nothing)
        Dim UltraListViewItem2 As Infragistics.Win.UltraWinListView.UltraListViewItem = New Infragistics.Win.UltraWinListView.UltraListViewItem("gggg", New Infragistics.Win.UltraWinListView.UltraListViewSubItem() {New Infragistics.Win.UltraWinListView.UltraListViewSubItem(Nothing, Nothing), New Infragistics.Win.UltraWinListView.UltraListViewSubItem(Nothing, Nothing)}, Nothing)
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraListViewSubItemColumn1 As Infragistics.Win.UltraWinListView.UltraListViewSubItemColumn = New Infragistics.Win.UltraWinListView.UltraListViewSubItemColumn("Type")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraListViewSubItemColumn2 As Infragistics.Win.UltraWinListView.UltraListViewSubItemColumn = New Infragistics.Win.UltraWinListView.UltraListViewSubItemColumn("DateTime")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraListView1 = New Infragistics.Win.UltraWinListView.UltraListView()
        CType(Me.UltraListView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraListView1
        '
        Appearance1.ForeColor = System.Drawing.Color.White
        Me.UltraListView1.Appearance = Appearance1
        Me.UltraListView1.BorderStyle = Infragistics.Win.UIElementBorderStyle.Rounded1
        Me.UltraListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraListView1.GroupHeadersVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.UltraListView1.Items.AddRange(New Infragistics.Win.UltraWinListView.UltraListViewItem() {UltraListViewItem1, UltraListViewItem2})
        Me.UltraListView1.ItemSettings.AllowEdit = Infragistics.Win.DefaultableBoolean.[False]
        Appearance2.FontData.BoldAsString = "False"
        Appearance2.FontData.SizeInPoints = 8.0!
        Appearance2.ForeColor = System.Drawing.Color.Black
        Me.UltraListView1.ItemSettings.Appearance = Appearance2
        Me.UltraListView1.Location = New System.Drawing.Point(0, 0)
        Appearance3.ForeColor = System.Drawing.Color.White
        Me.UltraListView1.MainColumn.HeaderAppearance = Appearance3
        Me.UltraListView1.MainColumn.Key = "FileName"
        Me.UltraListView1.MainColumn.Text = "Archivo"
        Me.UltraListView1.MainColumn.VisiblePositionInDetailsView = 0
        Me.UltraListView1.Name = "UltraListView1"
        Me.UltraListView1.ShowGroups = False
        Me.UltraListView1.Size = New System.Drawing.Size(860, 675)
        Appearance4.ForeColor = System.Drawing.Color.White
        UltraListViewSubItemColumn1.HeaderAppearance = Appearance4
        UltraListViewSubItemColumn1.Key = "Type"
        UltraListViewSubItemColumn1.Text = "Tipo de archivo"
        UltraListViewSubItemColumn1.VisiblePositionInDetailsView = 2
        Appearance5.ForeColor = System.Drawing.Color.White
        UltraListViewSubItemColumn2.HeaderAppearance = Appearance5
        UltraListViewSubItemColumn2.Key = "DateTime"
        UltraListViewSubItemColumn2.Text = "Fecha de Creación"
        UltraListViewSubItemColumn2.VisiblePositionInDetailsView = 1
        Me.UltraListView1.SubItemColumns.AddRange(New Infragistics.Win.UltraWinListView.UltraListViewSubItemColumn() {UltraListViewSubItemColumn1, UltraListViewSubItemColumn2})
        Me.UltraListView1.TabIndex = 0
        Me.UltraListView1.Text = "UltraListView1"
        Me.UltraListView1.View = Infragistics.Win.UltraWinListView.UltraListViewStyle.Details
        Me.UltraListView1.ViewSettingsDetails.AllowColumnMoving = False
        Me.UltraListView1.ViewSettingsDetails.AllowColumnSizing = False
        Me.UltraListView1.ViewSettingsDetails.AutoFitColumns = Infragistics.Win.UltraWinListView.AutoFitColumns.ResizeAllColumns
        Me.UltraListView1.ViewSettingsDetails.ColumnAutoSizeMode = Infragistics.Win.UltraWinListView.ColumnAutoSizeMode.AllItems
        Appearance6.BackColor = System.Drawing.Color.Gray
        Appearance6.BackColor2 = System.Drawing.Color.Gray
        Appearance6.FontData.BoldAsString = "True"
        Me.UltraListView1.ViewSettingsDetails.ColumnHeaderAppearance = Appearance6
        Me.UltraListView1.ViewSettingsDetails.ColumnHeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Me.UltraListView1.ViewSettingsDetails.FullRowSelect = True
        Me.UltraListView1.ViewSettingsDetails.ImageSize = New System.Drawing.Size(0, 0)
        Me.UltraListView1.ViewSettingsDetails.SubItemTipStyle = Infragistics.Win.UltraWinListView.SubItemTipStyle.Hide
        '
        'frmExportedFiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 675)
        Me.Controls.Add(Me.UltraListView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmExportedFiles"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Archivos Generados"
        Me.TopMost = True
        CType(Me.UltraListView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UltraListView1 As Infragistics.Win.UltraWinListView.UltraListView
End Class
