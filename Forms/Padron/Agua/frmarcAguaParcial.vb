Imports Infragistics.Win.UltraWinGrid
Public Class frmarcAguaParcial
    Public id As String = "0"
    Public Lectura As String = "0"
    Public Insertar As String = "0"
    Public Borrar As String = "0"
    Public Editar As String = "0"

    Public delete_record As Boolean = False
    Public tipo_Permiso As Integer = 0
    Public idUsuario As String = My.User.Name
    Private cxn As New cxnData
    Private idColonia As Integer = -1
    Private newrow As Object
    Private Sub frmarcAguaParcial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsAgua.ced_fiscal' table. You can move, or remove it, as needed.
        Me.Ced_fiscalTableAdapter.Fill(Me.DsAgua.ced_fiscal)
        If id <> "0" Then
            Me.txtcveCatastral.Text = id
            cxn.Get_SQL_Combobox("select * from [tipo_inmueble]", Me.cmbInmueble, "nombre", "clave")
            txtcveCatastral_MaskChanged(Nothing, Nothing)
        End If
    End Sub

    Private Sub txtcveCatastral_MaskChanged(sender As Object, e As Infragistics.Win.UltraWinMaskedEdit.MaskChangedEventArgs) Handles txtcveCatastral.MaskChanged
        If Me.txtcveCatastral.Text.Trim.Length = 8 Then
            If cxn.Select_SQL("select Nombre,Domicilio,ult_año_pago,ult_mes_pago,tipo_servicio,
                                      tipo_inmueble,tip_usuario,ult_lectura,notificado
                                from arc_agua 
                                where num_cuenta='" & Me.txtcveCatastral.Text.Trim & "'") Then
                If cxn.arrayValores(0) IsNot Nothing Then
                    Me.txtPropietario.Text = cxn.arrayValores(0)
                    Me.txtUbicacion.Text = cxn.arrayValores(1)
                    Me.txtAñoPago.Text = cxn.arrayValores(2)
                    Me.txtMesPago.Text = cxn.arrayValores(3)
                    Me.optTipoServicio.Value = cxn.arrayValores(4)
                    Me.cmbInmueble.SelectedValue = cxn.arrayValores(5)
                    Me.optUsuario.Value = cxn.arrayValores(6)
                    Me.txtUltLect.Text = cxn.arrayValores(7)
                    Me.chkNotif.Checked = IIf(cxn.arrayValores(8) = 0, False, True)
                    If CType(Me.txtAñoPago.Text, Integer) = Now.Year And CType(Me.txtMesPago.Text, Integer) = 12 And CType(cxn.arrayValores(4), Integer) = 2 Then
                        SystemMessages1.SysMsg("El usuario no tiene adeudos fiscales registrados", True)
                    Else
                        If Me.optTipo.Value IsNot Nothing Then
                            'cxn.Get_SQL_DataGrid("exec [Calcula_Agua] '" & Me.txtcveCatastral.Text.Trim & "','" & Me.optTipo.Value.ToString & "'", Me.grdDataMain)
                            'If Me.grdDataMain.Rows.Count = 0 Then
                            '   SystemMessages1.SysMsg( "La cuenta no tiene adeudos",true)
                            'Else
                            '    Dim total As Integer = 0
                            '    'For i As Integer = 0 To Me.grdDataMain.Rows.Count - 1
                            '    '    total = total + CDbl(Me.grdDataMain.Rows(i).Cells(17).Value)
                            '    'Next
                            '    Me.txtTotal.Text = total.ToString
                            'End If
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
        'For i As Integer = 0 To Me.grdDataMain.Rows.Count - 1
        '    If Me.grdDataMain.Rows(i).Cells(18).Value = True Then
        '        total = total + CDbl(Me.grdDataMain.Rows(i).Cells(17).Value)
        '    End If
        'Next
        If total > 0 Then

            If ShowContinueMessage("RECIBIENDO PAGO" & vbCrLf & "¿Se recibió el pago?", "Una vez recibida la cantidad, acepte la transacción",
                                   "Total a pagar: $ " & total.ToString, Me.UltraMessageBoxManager1) = DialogResult.Yes Then
                Me.txtcveCatastral.Text = ""
                id = ""
                txtcveCatastral_MaskChanged(Nothing, Nothing)
            End If
        Else
            'SystemMessages1.SysMsg( "Seleccione al menos un periodo o año a pagar", Color.MistyRose, True, Me.ErrorProvider1, Me.grdDataMain)
        End If
    End Sub

    Private Sub grdDataMain_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs)
        Dim checkColumn As UltraGridColumn = e.Layout.Bands(0).Columns.Add("checkColumnKey", "")
        checkColumn.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        checkColumn.CellActivation = Activation.AllowEdit
        checkColumn.Header.VisiblePosition = 0
        e.Layout.Bands(0).Columns.Item(0).Hidden = True
        e.Layout.Bands(0).Columns.Item(1).Hidden = True
        'For i As Integer = 3 To Me.grdDataMain.Rows.Count - 1
        '    e.Layout.Bands(0).Columns.Item(i).CellActivation = Activation.NoEdit
        'Next
        'For i As Integer = 0 To Me.grdDataMain.Rows.Count - 1
        '    Me.grdDataMain.Rows(i).Cells(18).Value = False
        'Next

    End Sub
    Private Sub grdDataMain_CellChange(sender As Object, e As CellEventArgs)
        Dim total As Double = 0
        Dim current_row As Integer = e.Cell.Row.Index
        'For i As Integer = 0 To Me.grdDataMain.Rows.Count - 1
        '    If i <= current_row Then
        '        Me.grdDataMain.Rows(i).Cells(18).Value = True
        '        total = total + CDbl(Me.grdDataMain.Rows(i).Cells(17).Value)
        '    Else
        '        Me.grdDataMain.Rows(i).Cells(18).Value = False
        '    End If
        'Next
        Me.txtTotal.Text = total.ToString
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        txtcveCatastral_MaskChanged(Nothing, Nothing)
    End Sub
End Class