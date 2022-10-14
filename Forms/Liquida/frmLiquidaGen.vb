Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinTabControl
Imports System.ComponentModel
Imports Infragistics.Win.UltraWinExplorerBar
Imports Telerik.Data
Imports Telerik.WinControls.UI.Export
Imports Telerik.WinControls.UI

Public Class frmLiquidaGen
    Public id As String = ""
    Public CuentaFormat As String = ""
    Public delete_record As Boolean = False
    Public allow_add As Boolean = False
    Public tipo_Permiso As Integer = 0
    Public idUsuario As String = My.User.Name
    Private cxn As New cxnData
    Private idColonia As Integer = -1
    Private newrow As Object
    Public parent As Form = Nothing
    Private currentmenu As String = ""
    Private cell_errors As Integer = -1
    Private prefix_folio As String = ""
    Private cve_cuenta As String = ""
    Private sub_cuenta As String = ""
    Private comun As String = ""
    Private folio_rec As String = ""

    Private Sub frmLiquidaGen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsPredial.arc_predial' table. You can move, or remove it, as needed.
        Me.Arc_predialTableAdapter.Fill(Me.DsPredial.arc_predial)
        Try
            Dim ultrexplor As UltraExplorerBar = TryCast(parent.Controls.Find("UltraExplorerBar1", True).FirstOrDefault(), UltraExplorerBar)
            currentmenu = ultrexplor.ActiveItem.Key
            Me.optTipo.Value = 1
            cxn.Select_SQL("select descripcion,TipoLiq,AllowAdd,CuentaFormat,FolioPrefix,
                            cve_cuenta,sub_cuenta,substring(cve_cuenta,3,4) as Comun 
                            FROM tbl_Liquida_Menus 
                            where parentmenu ='" & currentmenu & "'")
            Me.lblCurrentMenu.Text = cxn.arrayValores(0)
            allow_add = cxn.arrayValores(2)
            prefix_folio = cxn.arrayValores(4)
            cve_cuenta = cxn.arrayValores(5)
            sub_cuenta = cxn.arrayValores(6)
            comun = cxn.arrayValores(7)
            Me.lblFolioRec.Text = "--------"
            Me.txtcveCatastral.InputMask = cxn.arrayValores(3)
            Me.txtcveCatastral.Text = Me.id
            If allow_add Then
                Me.optTipo.Visible = False
                Me.optTipo.Value = 1
            End If
            WebBrowser1.IsWebBrowserContextMenuEnabled = False
            If Me.txtcveCatastral.Text.Trim <> "" Then
                btnBuscar_Click(Nothing, Nothing)
            End If

        Catch ex As Exception
            Me.SystemMessages1.SysMsg(ex.Message, True)
        End Try

    End Sub
    Private Sub txtcveCatastral_MaskChanged(sender As Object, e As Infragistics.Win.UltraWinMaskedEdit.MaskChangedEventArgs) Handles txtcveCatastral.MaskChanged
        If Me.txtcveCatastral.Text.Trim.Length >= 8 Then
            Dim reader As System.Data.IDataReader = Nothing
            reader = cxn.Select_SQL(" exec sp_LoadDataLiquida '" & currentmenu & "','" & Me.txtcveCatastral.Text.Trim & "','',''", reader)
            If reader IsNot Nothing AndAlso reader.RecordsAffected > 1 Then
                Dim txt_data As String = ""
                While reader.Read()
                    txt_data = txt_data & reader(0).ToString.Trim
                End While
                If txt_data.Trim <> "" Then
                    add_text_browser(txt_data)
                End If
                If txt_data <> "" Then

                    If Me.optTipo.Value IsNot Nothing Then
                        cxn.Get_SQL_DataGrid("exec [sp_exec_liquida] '" & currentmenu & "','" & Me.txtcveCatastral.Text.Trim & "','" & Me.optTipo.Value.ToString & "','" & idUsuario & "'", Me.grdDataMain)
                        If Not allow_add Then
                            If Me.grdDataMain.Rows.Count = 0 Then
                                SystemMessages1.SysMsg("La cuenta no tiene adeudos", True)
                            Else
                                Dim total As Integer = 0
                                For i As Integer = 0 To Me.grdDataMain.Rows.Count - 1
                                    total = total + CDbl(Me.grdDataMain.Rows(i).Cells("Total").Value)
                                Next
                                Me.txtTotal.Text = total
                            End If
                        Else

                            Me.grdDataMain.DisplayLayout.Override.SelectTypeRow = SelectType.Extended
                            For i As Integer = 1 To Me.grdDataMain.Rows.Count - 1
                                grdDataMain.Selected.Rows.Add(Me.grdDataMain.Rows(i))
                            Next
                            Me.grdDataMain.DeleteSelectedRows()
                            Me.grdDataMain.DisplayLayout.Override.SelectTypeRow = SelectType.Single

                            Me.grdDataMain.DisplayLayout.Bands(0).Columns("Año").MaskInput = "9999"
                            Me.grdDataMain.DisplayLayout.Bands(0).Columns("Per_Ini").MaskInput = "99"
                            Me.grdDataMain.DisplayLayout.Bands(0).Columns("Per_Fin").MaskInput = "99"
                            Me.grdDataMain.DisplayLayout.Bands(0).Columns("BaseGrav").MaskInput = "99999999"
                            Me.grdDataMain.DisplayLayout.Bands(0).Columns("Impuesto").MaskInput = "{LOC}{double:9.2:c}"
                            Me.grdDataMain.DisplayLayout.Bands(0).Columns("Recargos").MaskInput = "{LOC}{double:9.2:c}"
                            Me.grdDataMain.DisplayLayout.Bands(0).Columns("Multas").MaskInput = "{LOC}{double:9.2:c}"
                            Me.grdDataMain.DisplayLayout.Bands(0).Columns("Gastos").MaskInput = "{LOC}{double:9.2:c}"
                            Me.grdDataMain.DisplayLayout.Bands(0).Columns("Sub_Imp").MaskInput = "{LOC}{double:9.2:c}"
                            Me.grdDataMain.DisplayLayout.Bands(0).Columns("Sub_Rec").MaskInput = "{LOC}{double:9.2:c}"
                            Me.grdDataMain.DisplayLayout.Bands(0).Columns("Sub_Multa").MaskInput = "{LOC}{double:9.2:c}"
                            Me.txtObservacion.Enabled = True
                        End If
                        If cxn.Select_SQL("exec sp_recibo_CreaFolio '','" & Me.txtcveCatastral.Text.Trim & "','" & prefix_folio & "','" &
                                        cve_cuenta & "','" & numCaja & "',''") Then
                            If cxn.err = "" Then
                                Me.lblFolioRec.Text = cxn.arrayValores(0)
                                folio_rec = cxn.arrayValores(0)
                            Else
                                Me.SystemMessages1.SysMsg("Error: " & cxn.err, True)
                            End If
                        Else
                            Me.lblFolioRec.Text = "--------"
                        End If
                    Else
                        SystemMessages1.SysMsg("Seleccione la forma de Pago", True)
                        Me.lblFolioRec.Text = "--------"
                        Me.optTipo.Focus()
                    End If
                Else
                    SystemMessages1.SysMsg("La cuenta no existe, verifique", True)
                    Me.lblFolioRec.Text = "--------"
                    add_text_browser("<div style=""color: Red; background-color:#F8e0e0 ; font-size: 15px;text-align: center;""><h1>La cuenta no existe, verifique</h1></div>")
                End If
            Else
                SystemMessages1.SysMsg("La cuenta no existe, verifique", True)
                Me.lblFolioRec.Text = "--------"
            End If
        Else
            'SystemMessages1.SysMsg("Proporcione una cuenta valida", True)
            Me.lblFolioRec.Text = "--------"
            add_text_browser("<div style=""color: Red; background-color:#F8e0e0 ; font-size: 15px;text-align: center;"">Proporcione la Clave</div>")
        End If
    End Sub
    Private Sub btnPago_Click(sender As Object, e As EventArgs) Handles btnPago.Click
        Dim pago_finalizado As Boolean = False
        If allow_add Then
            If Me.txtObservacion.Text.Trim = "" Then
                Me.SystemMessages1.SysMsg("Debe proporcionar un comentario...", True)
                Me.txtObservacion.Focus()
                Exit Sub
            End If
        End If
        Dim total As Double = 0
        For i As Integer = 0 To Me.grdDataMain.Rows.Count - 1
            If Me.grdDataMain.Rows(i).Cells("checkColumnKey").Value = True Then
                total = total + CDbl(Me.grdDataMain.Rows(i).Cells("Total").Value)
            End If
        Next

        If total > 0 Then
            If ShowContinueMessage("RECIBIENDO PAGO" & vbCrLf & "¿Se recibió el pago?", "Una vez recibida la cantidad, acepte la transacción",
                                   "Total a pagar: $ " & total.ToString, Me.UltraMessageBoxManager1) = DialogResult.Yes Then
                Dim cxndata As New cxnData
                cxndata.Select_SQL(" exec [sp_exec_liquida] '" & currentmenu & "-Data','" & Me.txtcveCatastral.Text.Trim & "','',''")
                For i As Integer = 0 To Me.grdDataMain.Rows.Count - 1
                    If Me.grdDataMain.Rows(i).Cells("checkColumnKey").Value = True Then
                        total = total + CDbl(Me.grdDataMain.Rows(i).Cells("Total").Value)
                        cxn.Select_SQL("select getdate()")
                        If Not cxn.Select_SQL("declare @RC as bit 
                                    DECLARE @Tran_id int
                                    EXEC @RC = [dbo].[App_InsertaTransaccion] 
                                   '" & comun & "'
                                  ,'" & numCaja & "' 
                                  ,'" & cve_cuenta & "'
                                  ,'" & sub_cuenta & "'
                                  ,'" & cxndata.arrayValores(0) & "'
                                  ,'" & Me.txtcveCatastral.Text.Trim & "'
                                  ,'" & cxndata.arrayValores(2) & "'
                                  ,'" & cxndata.arrayValores(3) & "'
                                  ,'" & cxn.arrayValores(0) & "'
                                  ,'" & folio_rec & "'
                                  ," & Me.grdDataMain.Rows(i).Cells("BaseGrav").Value & "
                                  ," & Me.grdDataMain.Rows(i).Cells("Impuesto").Value & "
                                  ,0
                                  ," & Me.grdDataMain.Rows(i).Cells("Recargos").Value & "
                                  ," & Me.grdDataMain.Rows(i).Cells("Multas").Value & "
                                  ," & Me.grdDataMain.Rows(i).Cells("gastos").Value & "
                                  ," & Me.grdDataMain.Rows(i).Cells("sub_imp").Value & "
                                  ," & Me.grdDataMain.Rows(i).Cells("sub_rec").Value & "
                                  ," & Me.grdDataMain.Rows(i).Cells("sub_Multa").Value & "
                                  ,0
                                  ,'P'
                                  ,'C'  
                                  ,'" & Me.grdDataMain.Rows(i).Cells("Per_Ini").Value.ToString.Trim & "-" & Me.grdDataMain.Rows(i).Cells("Año").Value.ToString.Trim & "'
                                  ,'" & Me.grdDataMain.Rows(i).Cells("Per_Fin").Value.ToString.Trim & "-" & Me.grdDataMain.Rows(i).Cells("Año").Value.ToString.Trim & "'
                                  ,''
                                  ,''
                                  ,'E'
                                  ,0
                                  ,''
                                  ,0
                                  ,''
                                  ,''
                                  ," & CurrentUsrName & "
                                  ,@Tran_id OUTPUT") Then
                            If cxn.err <> "" Then
                                Me.SystemMessages1.SysMsg("Error: " & cxn.err, True)
                                pago_finalizado = False
                                Exit For
                            Else
                                pago_finalizado = True
                            End If
                        End If
                    End If
                Next
                If pago_finalizado Then
                    Dim ub As New MessageBoxButtons
                    ShowContinueMessage("PAGO GENERADO", "El pago se recibio correctamente", "", Me.UltraMessageBoxManager1, ub.OK)
                End If
            End If
        Else
            SystemMessages1.SysMsg("Seleccione al menos un periodo o año a pagar", True)
        End If
    End Sub
    Private Sub optTipo_TextChanged(sender As Object, e As EventArgs) Handles optTipo.TextChanged
        SystemMessages1.SysMsg("")
    End Sub
    Private Sub grdDataMain_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs) Handles grdDataMain.InitializeLayout
        Dim checkColumn As UltraGridColumn = e.Layout.Bands(0).Columns.Add("checkColumnKey", "")
        checkColumn.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        checkColumn.CellActivation = Activation.AllowEdit
        checkColumn.Header.VisiblePosition = 0
        e.Layout.Bands(0).Columns.Item("id_Liq").Hidden = True
        e.Layout.Bands(0).Columns.Item("num_rec").Hidden = True
        For i As Integer = 0 To e.Layout.Bands(0).Columns.Count - 1
            If e.Layout.Bands(0).Columns.Item(i).Key <> "checkColumnKey" And Not allow_add Then
                e.Layout.Bands(0).Columns.Item(i).CellActivation = Activation.NoEdit
            End If
            If allow_add Then
                e.Layout.Bands(0).Columns.Item(i).CellActivation = Activation.AllowEdit
            End If
        Next
        e.Layout.Bands(0).Columns.Item("Total").CellActivation = Activation.NoEdit
        For i As Integer = 0 To Me.grdDataMain.Rows.Count - 1
            Me.grdDataMain.Rows(i).Cells("checkColumnKey").Value = True
        Next

    End Sub
    Private Sub grdDataMain_CellChange(sender As Object, e As CellEventArgs) Handles grdDataMain.CellChange
        Dim total As Double = 0
        Dim current_row As Integer = e.Cell.Row.Index

        If Not allow_add Then
            For i As Integer = 0 To Me.grdDataMain.Rows.Count - 1
                If i <= current_row Then
                    Me.grdDataMain.Rows(i).Cells("checkColumnKey").Value = True
                    total = total + CDbl(Me.grdDataMain.Rows(i).Cells("Total").Value)
                Else
                    Me.grdDataMain.Rows(i).Cells("checkColumnKey").Value = False
                End If
            Next
        Else
            total = Me.grdDataMain.Rows(0).Cells("Impuesto").Value +
            Me.grdDataMain.Rows(0).Cells("Recargos").Value +
            Me.grdDataMain.Rows(0).Cells("Multas").Value +
            Me.grdDataMain.Rows(0).Cells("Gastos").Value -
            Me.grdDataMain.Rows(0).Cells("Sub_Imp").Value -
            Me.grdDataMain.Rows(0).Cells("Sub_Rec").Value -
            Me.grdDataMain.Rows(0).Cells("Sub_Multa").Value
            Me.grdDataMain.Rows(0).Cells("Total").Value = total
        End If
        Me.txtTotal.Text = total.ToString

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        add_text_browser("")
        txtcveCatastral_MaskChanged(Nothing, Nothing)
    End Sub
    Private Sub frmLiquidaAgua_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Try
            Dim Maintab As UltraTabControl = TryCast(parent.Controls.Find("UltraTabControl1", True).FirstOrDefault(), UltraTabControl)
            Maintab.Visible = False
            Maintab.Visible = True
            Dim Mainbar As ToolStrip = TryCast(parent.Controls.Find("CommandBar", True).FirstOrDefault(), ToolStrip)
            Mainbar.Visible = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub add_text_browser(txt_data As String)
        WebBrowser1.Navigate("about:blank")
        Me.WebBrowser1.Document.OpenNew(False)
        Me.WebBrowser1.Document.Write(txt_data)
        Me.WebBrowser1.DocumentText = txt_data
        Me.WebBrowser1.Refresh()
    End Sub

    Private Sub txtObservacion_EnabledChanged(sender As Object, e As EventArgs) Handles txtObservacion.EnabledChanged
        Me.lblObs.Enabled = Me.txtObservacion.Enabled
    End Sub


    Private Sub grdDataMain_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles grdDataMain.BeforeRowsDeleted
        e.DisplayPromptMsg = False
    End Sub

    Private Sub grdDataMain_BeforeExitEditMode(sender As Object, e As BeforeExitEditModeEventArgs) Handles grdDataMain.BeforeExitEditMode
        cxn.Select_SQL("select year(getdate()),month(getdate())")
        Dim total As Double = 0
        If allow_add Then
            Select Case Me.grdDataMain.ActiveCell.Column.Key
                Case "Año"
                    If Len(Trim(Me.grdDataMain.Rows(0).Cells("Año").Value)) <> 4 Or
                    Me.grdDataMain.Rows(0).Cells("Año").Value > cxn.arrayValores(0) Or
                    Me.grdDataMain.Rows(0).Cells("Año").Value < cxn.arrayValores(0) - 6 Then
                        Me.SystemMessages1.SysMsg("El Año proporcionado es incorrecto, verifique....", True)
                        cell_errors = 1
                    Else
                        cell_errors = -1
                    End If
                Case "Per_Ini"
                    If CInt(Me.grdDataMain.ActiveRow.Cells("Per_Ini").Value) < 1 Or
                  CInt(Me.grdDataMain.ActiveRow.Cells("Per_Ini").Value) > 12 Or
                    CInt(Me.grdDataMain.Rows(0).Cells("Per_Ini").Value) > CInt(Me.grdDataMain.Rows(0).Cells("Per_Fin").Value) Then
                        Me.SystemMessages1.SysMsg("El Periodo inicial proporcionado es incorrecto, verifique....", True)
                        cell_errors = 2
                    Else
                        cell_errors = -1
                    End If
                Case "Per_Fin"
                    If CInt(Me.grdDataMain.ActiveRow.Cells("Per_Fin").Value) < 1 Or CInt(Me.grdDataMain.ActiveRow.Cells("Per_Fin").Value) > 12 Or
                    CInt(Me.grdDataMain.Rows(0).Cells("Per_Fin").Value) < CInt(Me.grdDataMain.Rows(0).Cells("Per_Ini").Value) Then
                        Me.SystemMessages1.SysMsg("El Periodo Final proporcionado es incorrecto, verifique....", True)
                        cell_errors = 3
                    Else
                        cell_errors = -1
                    End If
                Case Else
                    cell_errors = -1
            End Select
            If cell_errors > -1 Then
                e.Cancel = True
                '// We force the end user to add valid value right now And don't validate the user input in BeforeRowUpdate.
                grdDataMain.ActiveCell.SelectAll()
                grdDataMain.PerformAction(UltraGridAction.EnterEditMode, False, False)
            End If
            Me.SystemMessages1.Visible = False
            total = Me.grdDataMain.Rows(0).Cells("Impuesto").Value +
            Me.grdDataMain.Rows(0).Cells("Recargos").Value +
            Me.grdDataMain.Rows(0).Cells("Multas").Value +
            Me.grdDataMain.Rows(0).Cells("Gastos").Value -
            Me.grdDataMain.Rows(0).Cells("Sub_Imp").Value -
            Me.grdDataMain.Rows(0).Cells("Sub_Rec").Value -
            Me.grdDataMain.Rows(0).Cells("Sub_Multa").Value
            Me.grdDataMain.Rows(0).Cells("Total").Value = total
            Me.txtTotal.Text = total.ToString
        End If

    End Sub

    Private Sub grdDataMain_BeforeCellActivate(sender As Object, e As CancelableCellEventArgs) Handles grdDataMain.BeforeCellActivate
        Dim total As Double = 0
        If allow_add Then
            Me.SystemMessages1.Visible = False
            total = Me.grdDataMain.Rows(0).Cells("Impuesto").Value +
            Me.grdDataMain.Rows(0).Cells("Recargos").Value +
            Me.grdDataMain.Rows(0).Cells("Multas").Value +
            Me.grdDataMain.Rows(0).Cells("Gastos").Value -
            Me.grdDataMain.Rows(0).Cells("Sub_Imp").Value -
            Me.grdDataMain.Rows(0).Cells("Sub_Rec").Value -
            Me.grdDataMain.Rows(0).Cells("Sub_Multa").Value
            Me.grdDataMain.Rows(0).Cells("Total").Value = total
            Me.txtTotal.Text = total.ToString
        End If
    End Sub

    Private Sub btnImprimeRpt_Click(sender As Object, e As EventArgs) Handles btnImprimeRpt.Click
        Dim RadGridView1 As New RadGridView
        RadGridView1.Dock = DockStyle.Top
        RadGridView1.EnableAlternatingRowColor = True
        CType(RadGridView1.TableElement, GridTableElement).AlternatingRowColor = Color.LightGray
        RadGridView1.Rows.Clear()

        For j As Int32 = 1 To grdDataMain.DisplayLayout.Bands(0).Columns.Count - 1
            If Not grdDataMain.DisplayLayout.Bands(0).Columns(j).Hidden And grdDataMain.DisplayLayout.Bands(0).Columns(j).Header.Caption <> "" Then
                Dim ID As New GridViewTextBoxColumn()
                ID.Name = grdDataMain.DisplayLayout.Bands(0).Columns(j).Key
                ID.HeaderText = grdDataMain.DisplayLayout.Bands(0).Columns(j).Key
                RadGridView1.MasterTemplate.Columns.Add(ID)
            End If

        Next
        For i As Int32 = 0 To Me.grdDataMain.Rows.Count - 1
            RadGridView1.Rows.Add(Me.grdDataMain.Rows(i).Cells("Año").Value,
                                  Me.grdDataMain.Rows(i).Cells("Per_Ini").Value,
                                  Me.grdDataMain.Rows(i).Cells("Per_Fin").Value,
                                  Me.grdDataMain.Rows(i).Cells("Impuesto").Value,
                                  Me.grdDataMain.Rows(i).Cells("Recargos").Value,
                                  Me.grdDataMain.Rows(i).Cells("Multas").Value,
                                  Me.grdDataMain.Rows(i).Cells("Gastos").Value,
                                  Me.grdDataMain.Rows(i).Cells("Sub_Imp").Value,
                                  Me.grdDataMain.Rows(i).Cells("Sub_Rec").Value,
                                  Me.grdDataMain.Rows(i).Cells("Sub_Multa").Value,
                                  Me.grdDataMain.Rows(i).Cells("Total").Value)
        Next

        Dim summaryItem As New GridViewSummaryItem("Total", "Total: {0:C2}", GridAggregateFunction.Sum)
        Dim summaryRowItem As New GridViewSummaryRowItem()
        summaryRowItem.Add(summaryItem)
        RadGridView1.SummaryRowsBottom.Add(summaryRowItem)

        Dim fileexported As String = pathStoredFiles & CurrentUsrName.Replace("\", "_") & "_" & Now.Millisecond.ToString & Now.Second.ToString & ".html"
        Dim expgridhtml As New ExportToHTML(RadGridView1)
        expgridhtml.AutoSizeColumns = True
        expgridhtml.ExportVisualSettings = True
        expgridhtml.RunExport(fileexported)

    End Sub
End Class