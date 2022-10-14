Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinTabControl
Imports System.ComponentModel
Imports Infragistics.Win.UltraWinExplorerBar
Imports Infragistics.Win.UltraMessageBox
Imports System.Web.Security
Public Class frmFactLegal

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
    Private ejfiscal As String = "0"
    Private Sub frmFactLegal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsParametros1.recargos' Puede moverla o quitarla según sea necesario.
        load_Permiso()
        If id <> "0" Then
            Me.RecargosTableAdapter.Fill(Me.DsParametros.recargos)
            Me.ParametrBindingSource.Position = Me.ParametrBindingSource.Find("id_rec", id)
            btnEliminar.Visible = True
        Else
            cMensajes.DisplayMessage(Me, "Edite los registros correspondientes para el ejercicio fiscal!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Sub load_Permiso()
        Dim ban_enabled As Boolean = False
        Dim ejfiscal As String = ""
        Me.btnGuardar.Visible = False
        btnEliminar.Visible = False
        btnBack.Visible = False

        If id <> "0" Then
            'determina el año corriente
            cxn.Select_SQL("select year(getdate())")
            ejfiscal = cxn.arrayValores(0).ToString
            cxn.Select_SQL("select count(*) from recargos where ej_fiscal='" & ejfiscal & "'")

            If cxn.arrayValores(0) = "0" Then
                If ShowContinueMessage("Configuración", "Parametros Basicos",
                                "EL EJERCICIO FISCAL NO TIENE REGISTROS CREADOS" & vbCrLf & "¿DESEA CREARLOS AHORA?",
                                  Me.UltraMessageBoxManager1) = vbYes Then
                    Dim i As Int16 = 0
                    For i = 1 To 12
                        cxn.Select_SQL("INSERT INTO [dbo].[recargos]([ej_fiscal],[num_mes],[mora_edo] ,[pror_edo],[fact_edo],[mora_fed],[pror_fed],[inp]) 
                                        values (" & ejfiscal & "," & i & ",0,0,0,0,0,0)")
                        If cxn.err <> "" Then
                            ShowContinueMessage("Error", "Parametros Basicos",
                                "El proceso produjo el error:" & vbCrLf & Me.cxn.arrayValores(0), Me.UltraMessageBoxManager1,
                                New MessageBoxButtons = MessageBoxButtons.OK, New MessageBoxIcon = MessageBoxIcon.Error)
                            Me.Close()
                        End If
                    Next
                    cxn.Select_SQL("select count(*) from recargos where ej_fiscal=" & ejfiscal)
                    If cxn.arrayValores(0) = "12" Then
                        ShowContinueMessage("Configuración", "Parametros Basicos",
                                "El proceso se generó satisfactoriamente", Me.UltraMessageBoxManager1,
                                New MessageBoxButtons = MessageBoxButtons.OK, New MessageBoxIcon = MessageBoxIcon.Information)
                        Me.Close()
                    Else
                        ShowContinueMessage("Error", "Parametros Basicos",
                                "Existió un Error en el proceso...", Me.UltraMessageBoxManager1,
                                New MessageBoxButtons = MessageBoxButtons.OK, New MessageBoxIcon = MessageBoxIcon.Error)
                    End If

                Else
                    ShowContinueMessage("Configuración", "Parametros Basicos",
                                "Proceso Cancelado por el usuario", Me.UltraMessageBoxManager1,
                                New MessageBoxButtons = MessageBoxButtons.OK, New MessageBoxIcon = MessageBoxIcon.Information)
                    Me.Close()
                End If

            End If
        End If

        'LoadRol()
        btnBack.Visible = True
    End Sub

    Private Sub LoadRol()
        btnEditar.Enabled = Roles.IsUserInRole(Usuario, Editar)
        btnEliminar.Enabled = Roles.IsUserInRole(Usuario, Borrar)
        btnGuardar.Enabled = Roles.IsUserInRole(Usuario, Insertar)
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim Mainbar As ToolStrip = TryCast(parent.Controls.Find("CommandBar", True).FirstOrDefault(), ToolStrip)
        Mainbar.Enabled = True
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If valida_datos() = False Then
                If id <> "0" Then
                    Me.Validate()
                    Me.ParametrBindingSource.EndEdit()
                    Me.RecargosTableAdapter.Update(Me.DsParametros.recargos)
                    Me.grpParBasico.Enabled = False
                    Me.btnGuardar.Visible = False
                    Me.btnEditar.Visible = True
                    cMensajes.DisplayMessage(Me, "Datos actualizados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Else
                    'no existe insert
                End If
            End If
        Catch ex As Exception
            cMensajes.DisplayMessage(Me, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
    End Sub
    Private Function valida_datos() As Boolean
        Dim ban As Boolean = False
        Dim ocurriounError As Integer = 0
        Dim mensaje As String = ""
        Try
            ErrorProvider1.Clear()
            'cuenta

            If Me.uneAnio.Value < 2000 Or uneAnio.Value >= 2050 Then
                ErrorProvider1.SetError(uneAnio, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo año no es correcto.." & "<br />"
                Me.uneAnio.SelectAll()
            End If

            If Me.uneMes.Value <= 0 Or uneMes.Value >= 13 Then
                ErrorProvider1.SetError(uneMes, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo mes no es correcto" & "<br />"
                Me.uneMes.SelectAll()
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
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        btnGuardar.Visible = True
        btnEditar.Visible = False
        grpParBasico.Enabled = True
    End Sub
    Private Sub btnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        ErrorProvider1.Clear()
        Me.ParametrBindingSource.CancelEdit()
        btnGuardar.Visible = False
        btnEditar.Visible = True
        grpParBasico.Enabled = False

    End Sub
    Private Sub frmFactLegal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim Maintab As UltraTabControl = TryCast(parent.Controls.Find("tabPrincipal", True).FirstOrDefault(), UltraTabControl)
        Maintab.Visible = True
    End Sub

    Private Sub frmFactLegal_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Dim nextControl As Control

        If e.KeyCode = Keys.Enter Then
            nextControl = GetNextControl(ActiveControl, Not e.Shift)
            If nextControl Is Nothing Then
                nextControl = GetNextControl(Nothing, True)
            End If
            SendKeys.Send("{TAB}")
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If MsgBox("¿Seguro de Eliminar el Registro?", vbYesNo, "Confirmación") = vbYes Then
                Me.Validate()
                Me.BindingNavigator2.BindingSource.RemoveCurrent()
                Me.RecargosTableAdapter.Update(Me.DsParametros.recargos)
                cMensajes.DisplayMessage(Me, "Datos eliminados", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Me.Close()
            End If

        Catch ex As Exception
            cMensajes.DisplayMessage(Me, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
    End Sub


End Class