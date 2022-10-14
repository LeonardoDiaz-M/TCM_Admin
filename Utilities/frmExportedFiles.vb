Imports System.IO
Imports Infragistics.Win.UltraWinListView

Public Class frmExportedFiles
    Private Sub frmExportedFiles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.UltraListView1.Items.Clear()
        For Each Dir As String In Directory.GetFiles(pathStoredFiles)
            Dim orderItem As UltraListViewItem = Me.UltraListView1.Items.Add(Dir.Replace(pathStoredFiles, ""), Dir.Replace(pathStoredFiles, ""))
            Dim subItemColumn As UltraListViewSubItemColumn
            For Each subItemColumn In Me.UltraListView1.SubItemColumns

                ' DataColumn = CType(subItemColumn.Tag, DataColumn)
                Dim subItem As UltraListViewSubItem = orderItem.SubItems(subItemColumn)
                If subItem.Key.ToLower.ToLower = "datetime" Then
                    subItem.Value = File.GetCreationTime(Dir)
                Else
                    subItem.Value = Path.GetExtension(Dir)
                End If

            Next
        Next
    End Sub

    Private Sub UltraListView1_ItemActivated(sender As Object, e As ItemActivatedEventArgs) Handles UltraListView1.ItemActivated

    End Sub

    Private Sub UltraListView1_ItemDoubleClick(sender As Object, e As ItemDoubleClickEventArgs) Handles UltraListView1.ItemDoubleClick
        Try
            System.Diagnostics.Process.Start(pathStoredFiles & UltraListView1.ActiveItem.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class