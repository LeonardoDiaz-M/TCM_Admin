Imports CrystalDecisions.Shared
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.CrystalReports.Engine
Imports Infragistics.Win.Touch
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinTabControl

Public Class RptPadronContribuyentes
    Public id As String = "0"
    Public Lectura As String = "0"
    Public Insertar As String = "0"
    Public Borrar As String = "0"
    Public Editar As String = "0"

    Public delete_record As Boolean = False
    Public tipo_Permiso As Integer = 0
    Public idUsuario As String = My.User.Name
    Private cxn As New cxnData
    Private newrow As Object
    Public parent As Form = Nothing
    Private currentmenu As String = ""
    Private Sub RptPadronContribuyentes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.PropiedadesTableAdapter.Fill(Me.DsPredial.Propiedades)
        'GridPredial.DataSource = Me.PropiedadesTableAdapter.GetData()
    End Sub

    Private Sub TsbExportarPredial_Click(sender As Object, e As EventArgs) Handles TsbExportarPredial.Click
        Try
            Dim sfd As New SaveFileDialog
            Dim gridexcel As UltraGrid = Nothing
            Dim tabselected As UltraTab = Me.TabReportesContribuyente.SelectedTab
            If tabselected.Index > 0 Then
                gridexcel = DirectCast(tabselected.TabControl.Controls.Item(2).Controls.Item(0), UltraGrid)
            Else
                gridexcel = Me.GridPredial
            End If
            If gridexcel IsNot Nothing Then
                If gridexcel.Rows.Count > 0 Then
                    With sfd
                        .Title = "Ingresa el nombre del archivo a exportar"
                        .Filter = "Excel files (*.xls)|*.xls|All files (*.*)|*.*"
                        .ShowDialog()
                        If .FileName <> "" Then
                            Me.Cursor = Cursors.WaitCursor
                            ugeExporter.Export(gridexcel, .FileName)
                            Me.Cursor = Cursors.Default
                            MsgBox("Datos exportados correctamente!", MsgBoxStyle.Information, "Consulta")
                        End If
                    End With
                Else
                    MessageBox.Show("No existen registros a exportar", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else
                MessageBox.Show("No existen registros a exportar", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub TsbExportarLicencias_Click(sender As Object, e As EventArgs) Handles TsbExportarLicencias.Click
        Try
            Dim sfd As New SaveFileDialog
            Dim gridexcel As UltraGrid = Nothing
            Dim tabselected As UltraTab = Me.TabReportesContribuyente.SelectedTab
            If tabselected.Index > 0 Then
                gridexcel = DirectCast(tabselected.TabControl.Controls.Item(2).Controls.Item(0), UltraGrid)
            Else
                gridexcel = Me.GridLicencias
            End If
            If gridexcel IsNot Nothing Then
                If gridexcel.Rows.Count > 0 Then
                    With sfd
                        .Title = "Ingresa el nombre del archivo a exportar"
                        .Filter = "Excel files (*.xls)|*.xls|All files (*.*)|*.*"
                        .ShowDialog()
                        If .FileName <> "" Then
                            Me.Cursor = Cursors.WaitCursor
                            ugeExporter.Export(gridexcel, .FileName)
                            Me.Cursor = Cursors.Default
                            MsgBox("Datos exportados correctamente!", MsgBoxStyle.Information, "Consulta")
                        End If
                    End With
                Else
                    MessageBox.Show("No existen registros a exportar", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else
                MessageBox.Show("No existen registros a exportar", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub TsbExportarAgua_Click(sender As Object, e As EventArgs) Handles TsbExportarAgua.Click
        Try
            Dim sfd As New SaveFileDialog
            Dim gridexcel As UltraGrid = Nothing
            Dim tabselected As UltraTab = Me.TabReportesContribuyente.SelectedTab
            If tabselected.Index > 0 Then
                gridexcel = DirectCast(tabselected.TabControl.Controls.Item(2).Controls.Item(0), UltraGrid)
            Else
                gridexcel = Me.GridAgua
            End If
            If gridexcel IsNot Nothing Then
                If gridexcel.Rows.Count > 0 Then
                    With sfd
                        .Title = "Ingresa el nombre del archivo a exportar"
                        .Filter = "Excel files (*.xls)|*.xls|All files (*.*)|*.*"
                        .ShowDialog()
                        If .FileName <> "" Then
                            Me.Cursor = Cursors.WaitCursor
                            ugeExporter.Export(gridexcel, .FileName)
                            Me.Cursor = Cursors.Default
                            MsgBox("Datos exportados correctamente!", MsgBoxStyle.Information, "Consulta")
                        End If
                    End With
                Else
                    MessageBox.Show("No existen registros a exportar", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else
                MessageBox.Show("No existen registros a exportar", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub TabReportesContribuyente_SelectedTabChanged(sender As Object, e As SelectedTabChangedEventArgs) Handles TabReportesContribuyente.SelectedTabChanged
        Try
            Select Case TabReportesContribuyente.SelectedTab.Key
                Case "TabPredial"
                    Me.PropiedadesTableAdapter.Fill(Me.DsPredial.Propiedades)
                    GridPredial.DataSource = Me.PropiedadesTableAdapter.GetData()
                'Case "TabLicencias"
                '    Me.LicenciasTableAdapter.Fill(Me.DsPredial.Licencias)
                '    GridLicencias.DataSource = Me.LicenciasTableAdapter.GetData()
                Case "TabAgua"
                    Me.AguaTableAdapter.Fill(Me.DsPredial.Agua)
                    GridAgua.DataSource = Me.AguaTableAdapter.GetData
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub CmbTipoLicencia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbTipoLicencia.SelectedIndexChanged

        Try
            Select Case Me.CmbTipoLicencia.SelectedIndex
                Case 0
                    Me.LicenciasTableAdapter.FillByTipoLicencia(Me.DsPredial.Licencias, "LA")
                    GridLicencias.DataSource = Me.LicenciasTableAdapter.GetDataByTipoLIcencia("LA")
                Case 1
                    Me.LicenciasTableAdapter.FillByTipoLicencia(Me.DsPredial.Licencias, "PC")
                    GridLicencias.DataSource = Me.LicenciasTableAdapter.GetDataByTipoLIcencia("PC")
                Case 2
                    Me.LicenciasTableAdapter.FillByTipoLicencia(Me.DsPredial.Licencias, "LC")
                    GridLicencias.DataSource = Me.LicenciasTableAdapter.GetDataByTipoLIcencia("LC")
                Case 3
                    Me.LicenciasTableAdapter.FillByTipoLicencia(Me.DsPredial.Licencias, "PM")
                    GridLicencias.DataSource = Me.LicenciasTableAdapter.GetDataByTipoLIcencia("PM")
                Case 4
                    Me.LicenciasTableAdapter.FillByTipoLicencia(Me.DsPredial.Licencias, "PE")
                    GridLicencias.DataSource = Me.LicenciasTableAdapter.GetDataByTipoLIcencia("PE")
                Case 5
                    Me.LicenciasTableAdapter.FillByAnuncios(Me.DsPredial.Licencias, "PA")
                    GridLicencias.DataSource = Me.LicenciasTableAdapter.GetDataByAnuncios("PA")
                Case 6
                    Me.LicenciasTableAdapter.FillByAnuncios(Me.DsPredial.Licencias, "PP")
                    GridLicencias.DataSource = Me.LicenciasTableAdapter.GetDataByAnuncios("PP")
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
End Class