Public Class frmAguaRegistroConsumo_Alta
    Private cxn As New cxnData
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim OpcionCalculo As Integer = 0
        OpcionCalculo = optLectura.Value
        If valida_datos() = False Then
            Tbl_consumo_aguaTableAdapter.Insert(txtNumeroCuenta.Text, CType(txtanio.Value, Decimal), unePeriodo.Value, CType(uneConsumo.Value, Decimal), CType(uneLecturaActual.Value, Decimal), CType(uneLecturaAnterior.Value, Decimal), Date.Now, OpcionCalculo, NombreUsuario, CType(txtRuta.Text, Integer))
            cMensajes.DisplayMessage(Me, "Registro guardado!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Me.Close()
        End If
    End Sub
    Private Sub optLectura_ValueChanged(sender As Object, e As EventArgs) Handles optLectura.ValueChanged
        Ingresa_Lectura()
    End Sub
    Private Sub Ingresa_Lectura()

        Dim FormaCalculoConsumo As Integer = 0
        FormaCalculoConsumo = optLectura.Value
        If FormaCalculoConsumo = 1 Then
            uneLecturaActual.SelectAll()
        End If
        If FormaCalculoConsumo = 2 Then
            Dim ConsumoPromedio As Integer = 0
            cxn.Select_SQL("Consumo_agua_forma_calculo '" & txtNumeroCuenta.Text.Trim & "'," & "2")
            ConsumoPromedio = cxn.arrayValores(0)
            uneConsumo.Value = ConsumoPromedio
            uneLecturaActual.Value = uneLecturaAnterior.Value
        End If
        If FormaCalculoConsumo = 3 Then
            Dim ConsumoMinimo As Integer = 0
            cxn.Select_SQL("Consumo_agua_forma_calculo '" & txtNumeroCuenta.Text.Trim & "'," & "3")
            ConsumoMinimo = cxn.arrayValores(0)
            uneConsumo.Value = ConsumoMinimo
            uneLecturaActual.Value = uneLecturaAnterior.Value
        End If

    End Sub

    Private Function valida_datos() As Boolean
        Dim ban As Boolean = False
        Dim ocurriounError As Integer = 0
        Dim mensaje As String = ""
        Try
            ErrorProvider1.Clear()
            'cuenta
            If Me.txtanio.Value Is Nothing Then
                ErrorProvider1.SetError(txtanio, "Error")
                ocurriounError += 1
                mensaje += "- " & "Ingrese el año." & "<br />"
                txtanio.SelectAll()
            End If

            If unePeriodo.Value = 0 Then
                ErrorProvider1.SetError(unePeriodo, "Error")
                ocurriounError += 1
                mensaje += "- " & "Seleccione el periodo de lectura." & "<br />"
                unePeriodo.Focus()
            End If

            If optLectura.Value > 0 Then
                If optLectura.Value = 1 Then
                    If uneLecturaActual.Value <= uneLecturaAnterior.Value Then
                        ErrorProvider1.SetError(uneLecturaActual, "Error")
                        ocurriounError += 1
                        mensaje += "- " & "La lectura actual no puede ser menor o igual a la lectura Anterior." & "<br />"
                        uneLecturaActual.SelectAll()
                    End If
                End If

                If optLectura.Value = 3 Then
                    If uneConsumo.Value = 0 Then
                        ErrorProvider1.SetError(uneConsumo, "Error")
                        ocurriounError += 1
                        mensaje += "- " & "Ingrese el consumo." & "<br />"
                        uneConsumo.SelectAll()
                    End If

                End If
            Else
                ErrorProvider1.SetError(optLectura, "Error")
                ocurriounError += 1
                mensaje += "- " & "Seleccione la forma de cálculo." & "<br />"
                optLectura.Focus()
            End If

            'valida no se dupliquen las lecturas
            Dim Existe As Boolean = False
            cxn.Select_SQL("Consumo_agua_Valida_Lecturas '" & txtNumeroCuenta.Text.Trim & "'," & txtanio.Value & "," & unePeriodo.Value)
            Existe = cxn.arrayValores(0)
            If Existe = True Then
                ErrorProvider1.SetError(uneConsumo, "Error")
                ocurriounError += 1
                mensaje += "- " & "Lectura Existente!" & "<br />"
                uneConsumo.SelectAll()
            End If


            If ocurriounError > 0 Then
                ban = True
                cMensajes.DisplayMessage(Me, mensaje, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Else
                ban = False
            End If


        Catch ex As Exception
            cMensajes.DisplayMessage(Me, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
        Return ban
    End Function
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub uneLecturaActual_ValueChanged(sender As Object, e As EventArgs) Handles uneLecturaActual.ValueChanged, uneLecturaAnterior.ValueChanged
        If uneLecturaActual.Value >= uneLecturaAnterior.Value And optLectura.Value = 1 Then
            uneConsumo.Value = uneLecturaActual.Value - uneLecturaAnterior.Value
        End If

    End Sub


End Class