Imports Infragistics.Win.UltraMessageBox
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinTabControl
Imports System.ComponentModel

Public Class frmLiquidaPredial
    Public id As String = "0"
    Public delete_record As Boolean = False
    Public tipo_Permiso As Integer = 0
    Public idUsuario As String = CurrentUsrName
    Private cxn As New cxnData
    Private idColonia As Integer = -1
    Private newrow As Object
    Dim loaded As Boolean = False
    Public myparent As Form = Nothing
    Private Sub frmLiquidaAgua_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
        If id <> "0" Then
            Me.optTipo.Value = 1
            Me.txtcveCatastral.Text = id
            txtcveCatastral_MaskChanged(Nothing, Nothing)
            Me.lblTotal.Text = ""
        End If
    End Sub

    Private Sub txtcveCatastral_MaskChanged(sender As Object, e As Infragistics.Win.UltraWinMaskedEdit.MaskChangedEventArgs) Handles txtcveCatastral.MaskChanged
        If Me.txtcveCatastral.Text.Trim.Length = 16 Then
            If cxn.Select_SQL("select Propietario, Ubicacion,ult_año_pag,ult_mes_pag,forma_pago from arc_predial where cve_Catastral='" & Me.txtcveCatastral.Text.Trim.ToUpper & "'") Then
                If cxn.arrayValores(0) IsNot Nothing Then
                    SystemMessages1.SysMsg("")

                    Me.txtPropietario.Text = cxn.arrayValores(0)
                    Me.txtUbicacion.Text = cxn.arrayValores(1)
                    Me.txtAñoPago.Text = cxn.arrayValores(2)
                    Me.txtMesPago.Text = cxn.arrayValores(3)
                    If CType(Me.txtAñoPago.Text, Integer) = Now.Year And CType(Me.txtMesPago.Text, Integer) = 12 And CType(cxn.arrayValores(4), Integer) = 2 Then
                        SystemMessages1.SysMsg("El usuario no tiene adeudos fiscales registrados", True)
                    Else
                        'Select a la tabla de liquidaciones
                        'cxn.Get_SQL_DataGrid("Select Nombre,Domicilio,ult_año_pago,ult_mes_pago,tipo_servicio from arc_agua where num_cuenta='" & Me.txtcveCatastral.Text.Trim.Trim & "'", Me.grdDataMain)
                        If Me.optTipo.Value IsNot Nothing Then
                            cxn.Get_SQL_DataGrid("exec [Calcula_Predial] '" & Me.txtcveCatastral.Text.Trim & "','" & Me.optTipo.Value.ToString & "','" & Me.idUsuario & "'", Me.grdDataMain)
                            If Me.grdDataMain.Rows.Count = 0 Then
                                SystemMessages1.SysMsg("La cuenta no tiene adeudos", True)
                            Else
                                Dim total As Integer = 0
                                For i As Integer = 0 To Me.grdDataMain.Rows.Count - 1
                                    total = total + CDbl(Me.grdDataMain.Rows(i).Cells(11).Value)
                                Next
                                Me.lblTotal.Text = "Total a pagar: $ " & total.ToString
                            End If
                        Else
                            SystemMessages1.SysMsg("Seleccione la forma de Pago", True)
                            Me.optTipo.Focus()
                        End If

                    End If
                Else
                    SystemMessages1.SysMsg("La cuenta no existe, verifique", True)
                End If
            End If
        Else
            Me.txtPropietario.Text = ""
            Me.txtUbicacion.Text = ""
            Me.txtAñoPago.Text = ""
            Me.txtMesPago.Text = ""
        End If
    End Sub

    Private Sub btnPago_Click(sender As Object, e As EventArgs) Handles btnPago.Click
        Dim total As Double = 0
        For i As Integer = 0 To Me.grdDataMain.Rows.Count - 1
            If Me.grdDataMain.Rows(i).Cells(14).Value = True Then
                total = total + CDbl(Me.grdDataMain.Rows(i).Cells(11).Value)
            End If
        Next
        If total > 0 Then

            If ShowContinueMessage("Total a pagar: $ " & total.ToString) = DialogResult.Yes Then


                txtcveCatastral_MaskChanged(Nothing, Nothing)
            End If
        Else
            SystemMessages1.SysMsg("Seleccione al menos un periodo o año a pagar", True)
        End If

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        txtcveCatastral_MaskChanged(Nothing, Nothing)
    End Sub

    Private Sub optTipo_TextChanged(sender As Object, e As EventArgs) Handles optTipo.TextChanged
        SystemMessages1.SysMsg("")
    End Sub

    Private Sub grdDataMain_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs) Handles grdDataMain.InitializeLayout
        Dim checkColumn As UltraGridColumn = e.Layout.Bands(0).Columns.Add("checkColumnKey", "")
        checkColumn.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        checkColumn.CellActivation = Activation.AllowEdit
        checkColumn.Header.VisiblePosition = 0
        'e.Layout.Bands(0).Columns.Item(0).Hidden = True
        'e.Layout.Bands(0).Columns.Item(1).Hidden = True
        For i As Integer = 3 To Me.grdDataMain.Rows.Count - 1
            e.Layout.Bands(0).Columns.Item(i).CellActivation = Activation.NoEdit
        Next
        For i As Integer = 0 To Me.grdDataMain.Rows.Count - 1
            Me.grdDataMain.Rows(i).Cells(14).Value = False
        Next

    End Sub


    Private Sub txtcveCatastral_TextChanged(sender As Object, e As EventArgs) Handles txtcveCatastral.TextChanged
        If Me.txtcveCatastral.Value.ToString.Trim.Length = 16 Then
            txtcveCatastral_MaskChanged(Nothing, Nothing)
        End If
    End Sub
    Private Function ShowContinueMessage(ByVal message As String) As DialogResult
        Using ultraMessageBoxInfo As New UltraMessageBoxInfo()
            ' Set the general display style 
            ultraMessageBoxInfo.Style = MessageBoxStyle.Vista

            ' Set the text for the Text, Caption, Header and Footer 
            ultraMessageBoxInfo.Text = message
            ultraMessageBoxInfo.Caption = ""
            ultraMessageBoxInfo.Header = "RECIBIENDO PAGO" & vbCrLf & "¿Se recibió el pago?"
            ultraMessageBoxInfo.Footer = "Una vez recibida la cantidad, acepte la transacción"

            ' Specify which buttons should be used and which is the default button 
            ultraMessageBoxInfo.Buttons = MessageBoxButtons.YesNo
            ultraMessageBoxInfo.DefaultButton = MessageBoxDefaultButton.Button2
            ultraMessageBoxInfo.ShowHelpButton = Infragistics.Win.DefaultableBoolean.[False]

            ' Display the OS Error Icon 
            ultraMessageBoxInfo.Icon = MessageBoxIcon.Question

            ' Disable the default sounds 
            ultraMessageBoxInfo.EnableSounds = Infragistics.Win.DefaultableBoolean.[False]

            ' Show the UltraMessageBox 
            Dim resp As DialogResult = Me.UltraMessageBoxManager1.ShowMessageBox(ultraMessageBoxInfo)
            Return resp
        End Using
    End Function

    Private Sub grdDataMain_CellChange(sender As Object, e As CellEventArgs) Handles grdDataMain.CellChange
        Dim total As Double = 0
        Dim current_row As Integer = e.Cell.Row.Index
        For i As Integer = 0 To Me.grdDataMain.Rows.Count - 1
            If i <= current_row Then
                Me.grdDataMain.Rows(i).Cells(14).Value = True
                total = total + CDbl(Me.grdDataMain.Rows(i).Cells(11).Value)
            Else
                Me.grdDataMain.Rows(i).Cells(14).Value = False
            End If
        Next
        Me.lblTotal.Text = "Total a pagar: $ " & total.ToString
    End Sub
    Private Sub frmLiquidaPredial_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim Maintab As UltraTabControl = TryCast(myparent.Controls.Find("UltraTabControl1", True).FirstOrDefault(), UltraTabControl)
        Maintab.Visible = False
        Maintab.Visible = True
        Dim Mainbar As ToolStrip = TryCast(myparent.Controls.Find("CommandBar", True).FirstOrDefault(), ToolStrip)
        Mainbar.Visible = True
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class