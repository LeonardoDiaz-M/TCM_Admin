Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinTabControl
Imports System.ComponentModel
Imports Infragistics.Win.UltraWinExplorerBar

Public Class frmDerechoGeneric
    Public id As String = ""
    Public CuentaFormat As String = ""
    Public delete_record As Boolean = False
    Public allow_add As Boolean = False
    Public tipo_Permiso As Integer = 0
    Public idUsuario As String = My.User.Name
    Private cxn As New cxnData
    Private idColonia As Integer = -1
    Private newrow As Object
    Public myparent As Form = Nothing
    Private currentmenu As String = ""
    Private cell_errors As Integer = -1
    Private prefix_folio As String = ""
    Private cve_cuenta As String = ""
    Private sub_cuenta As String = ""
    Private comun As String = ""
    Private folio_rec As String = ""
    Private Sub frmDerechoGeneric_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Dim ultrexplor As UltraExplorerBar = TryCast(parent.Controls.Find("UltraExplorerBar1", True).FirstOrDefault(), UltraExplorerBar)
            currentmenu = ultrexplor.ActiveItem.Key

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
            cxn.Select_SQL("select ")
            If cxn.Select_SQL("exec sp_recibo_CreaFolio '','DERECHOS','" & prefix_folio & "','" &
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

            cxn.Get_SQL_Combobox("select Derecho_Id,descripcion 
                                    from tbl_derechos 
                                 where cve_cuenta='" & cve_cuenta & "' 
                                       and ejfiscal=YEAR(GETDATE())-2 order by descripcion asc",
                                  Me.cmbDerecho, "descripcion", "derecho_id")
            Me.grdDataMain.DisplayLayout.Bands(0).Columns(0).AllowRowSummaries = AllowRowSummaries.True
        Catch ex As Exception
            Me.SystemMessages1.SysMsg(ex.Message, True)
        End Try

    End Sub
    Private Sub grdDataMain_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs) Handles grdDataMain.InitializeLayout

        For i As Integer = 0 To e.Layout.Bands(0).Columns.Count - 1
            e.Layout.Bands(0).Columns.Item(i).CellActivation = Activation.NoEdit
        Next
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
            total = total + CDbl(IIf(Len(Me.grdDataMain.Rows(i).Cells(12).Text) > 0, Me.grdDataMain.Rows(i).Cells(12).Value, 0))
        Next

        If total > 0 Then
            If ShowContinueMessage("RECIBIENDO PAGO" & vbCrLf & "¿Se recibió el pago?", "Una vez recibida la cantidad, acepte la transacción",
                                   "Total a pagar: $ " & total.ToString, Me.UltraMessageBoxManager1) = DialogResult.Yes Then

                For i As Integer = 0 To Me.grdDataMain.Rows.Count - 1

                    cxn.Select_SQL("select getdate()")
                    'row.Cells(0).Value = cxn.arrayValores(0) 'Año
                    'row.Cells(1).Value = cxn.arrayValores(1) 'MesIni
                    'row.Cells(2).Value = cxn.arrayValores(2) 'MesFin
                    'row.Cells(3).Value = cxn.arrayValores(3) 'Impuesto
                    'row.Cells(4).Value = cxn.arrayValores(4) 'Actualizacion
                    'row.Cells(5).Value = cxn.arrayValores(5) 'Recargos
                    'row.Cells(6).Value = cxn.arrayValores(6) 'Multas
                    'row.Cells(7).Value = cxn.arrayValores(7) 'Gastos
                    'row.Cells(8).Value = cxn.arrayValores(8) 'subImp
                    'row.Cells(9).Value = cxn.arrayValores(9) 'subrec
                    'row.Cells(10).Value = cxn.arrayValores(10) 'subMulta
                    'row.Cells(11).Value = cxn.arrayValores(11) 'Subgastos
                    'row.Cells(12).Value = cxn.arrayValores(12) 'Total
                    If Not cxn.Select_SQL("declare @RC as bit 
                                    DECLARE @Tran_id int
                                    EXEC @RC = [dbo].[App_InsertaTransaccion] 
                                   '" & comun & "'
                                  ,'" & numCaja & "' 
                                  ,'" & cve_cuenta & "'
                                  ,'" & sub_cuenta & "'
                                  ,''
                                  ,'DERECHOS'
                                  ,'" & Me.txtNombre.Text.Trim.ToUpperInvariant & "'
                                  ,'" & Me.txtDir.Text.Trim.ToUpperInvariant & "'
                                  ,'" & cxn.arrayValores(0) & "'
                                  ,'" & folio_rec & "'
                                  ,0
                                  ," & Me.grdDataMain.Rows(i).Cells(3).Value & "
                                  ," & Me.grdDataMain.Rows(i).Cells(4).Value & "
                                  ," & Me.grdDataMain.Rows(i).Cells(5).Value & "
                                  ," & Me.grdDataMain.Rows(i).Cells(6).Value & "
                                  ," & Me.grdDataMain.Rows(i).Cells(7).Value & "
                                  ," & Me.grdDataMain.Rows(i).Cells(8).Value & "
                                  ," & Me.grdDataMain.Rows(i).Cells(9).Value & "
                                  ," & Me.grdDataMain.Rows(i).Cells(10).Value & "
                                  ," & Me.grdDataMain.Rows(i).Cells(11).Value & "
                                  ,'P'
                                  ,'C'  
                                  ,'" & Me.grdDataMain.Rows(i).Cells(1).Value.ToString.Trim & "-" & Me.grdDataMain.Rows(i).Cells(0).Value.ToString.Trim & "'
                                  ,'" & Me.grdDataMain.Rows(i).Cells(2).Value.ToString.Trim & "-" & Me.grdDataMain.Rows(i).Cells(0).Value.ToString.Trim & "'
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
    Private Sub txtObservacion_EnabledChanged(sender As Object, e As EventArgs) Handles txtObservacion.EnabledChanged
        Me.lblObs.Enabled = Me.txtObservacion.Enabled
    End Sub
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Private Sub frmDerechoGeneric_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Try
            Dim Maintab As UltraTabControl = TryCast(parent.Controls.Find("UltraTabControl1", True).FirstOrDefault(), UltraTabControl)
            Maintab.Visible = False
            Maintab.Visible = True
            Dim Mainbar As ToolStrip = TryCast(parent.Controls.Find("CommandBar", True).FirstOrDefault(), ToolStrip)
            Mainbar.Visible = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnLiquidar_Click(sender As Object, e As EventArgs) Handles btnLiquidar.Click
        If Me.txtNombre.Text.Trim <> "" Then
            If Me.cmbDerecho.SelectedIndex > 0 Then
                If Me.grdDataMain.Rows.Count = 0 Then
                    cxn.Get_SQL_DataGrid("exec [CalculaDerechos] " & Me.cmbDerecho.SelectedValue & ",0,0", Me.grdDataMain)
                Else
                    Dim grdtmp As New UltraGrid
                    cxn.Select_SQL("exec [CalculaDerechos] " & Me.cmbDerecho.SelectedValue & ",0,0")

                    grdDataMain.DisplayLayout.Override.AllowAddNew = AllowAddNew.Yes

                    Dim row As UltraGridRow = Me.grdDataMain.DisplayLayout.Bands(0).AddNew()
                    row.Cells(0).Value = cxn.arrayValores(0) 'Año
                    row.Cells(1).Value = cxn.arrayValores(1) 'MesIni
                    row.Cells(2).Value = cxn.arrayValores(2) 'MesFin
                    row.Cells(3).Value = cxn.arrayValores(3) 'Impuesto
                    row.Cells(4).Value = cxn.arrayValores(4) 'Actualizacion
                    row.Cells(5).Value = cxn.arrayValores(5) 'Recargos
                    row.Cells(6).Value = cxn.arrayValores(6) 'Multas
                    row.Cells(7).Value = cxn.arrayValores(7) 'Gastos
                    row.Cells(8).Value = cxn.arrayValores(8) 'subImp
                    row.Cells(9).Value = cxn.arrayValores(9) 'subrec
                    row.Cells(10).Value = cxn.arrayValores(10) 'subMulta
                    row.Cells(11).Value = cxn.arrayValores(11) 'Subgastos
                    row.Cells(12).Value = cxn.arrayValores(12) 'Total
                    grdDataMain.DisplayLayout.Override.AllowAddNew = AllowAddNew.No
                End If

                If cxn.err <> "" Then
                    Me.SystemMessages1.SysMsg(cxn.err, True)
                End If
            Else
                Me.SystemMessages1.SysMsg("Seleccione el Concepto de Pago ...", True)
                Me.cmbDerecho.Focus()
            End If
        Else
            Me.SystemMessages1.SysMsg("El campo Nombre es requerido...", True)
            Me.txtNombre.Focus()
        End If
        Dim total As Double = 0
        For i As Integer = 0 To Me.grdDataMain.Rows.Count - 1
            total = total + CDbl(IIf(Len(Me.grdDataMain.Rows(i).Cells(12).Text) > 0, Me.grdDataMain.Rows(i).Cells(12).Value, 0))
        Next
        Me.txtTotal.Text = total.ToString

    End Sub

End Class