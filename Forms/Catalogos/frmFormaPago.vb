Imports Infragistics.Win.UltraWinTabControl
Imports System.ComponentModel
Imports System.Web.Security
Public Class frmFormaPago
    Public id As String = "0"
    Public Lectura As String = "0"
    Public Insertar As String = "0"
    Public Borrar As String = "0"
    Public Editar As String = "0"

    Public delete_record As Boolean = False
    Public tipo_Permiso As Integer = 0
    Private cxn As New cxnData
    Private newrow As Object
    Public myparent As Form = Nothing
    Private Sub frmFormaPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsAgua.tip_contribuyente' Puede moverla o quitarla según sea necesario.        

        Me.Fma_pagoTableAdapter.Fill(Me.DsAgua.fma_pago)
        'TODO: esta línea de código carga datos en la tabla 'DsAgua.tipo_inmueble' Puede moverla o quitarla según sea necesario.        
        Me.BindingSource1.Position = Me.BindingSource1.Find("forma_pago", id)
        load_Permiso()

    End Sub


    Private Sub load_Permiso()
        Me.btnGuardar.Visible = False
        btnElimina.Visible = False
        btnUndo.Visible = False
        Me.txtClave.Enabled = False
        Me.Text = "Detalle de Forma de Pago : " & id.ToString
        If tipo_Permiso = 0 And Not delete_record Then 'Solo Lectura
            Me.grpDatosCuenta.Enabled = False
        ElseIf tipo_Permiso = 1 And delete_record Then 'Eliminar Registro
            Me.grpDatosCuenta.Enabled = False
            btnElimina.Visible = True
            btnUndo.Visible = True
        ElseIf tipo_Permiso = 1 And id <> "0" Then  'Actualizar Registro
            Me.grpDatosCuenta.Enabled = True
            Me.btnGuardar.Visible = True
            btnUndo.Visible = True
        ElseIf tipo_Permiso = 1 And id = "0" Then 'Agregar Registro
            Me.Text = "Nueva Forma de Pago"
            Me.grpDatosCuenta.Enabled = True
            Me.btnGuardar.Visible = True
            Me.btnNPrimero.Visible = False
            Me.btnNPrevio.Visible = False
            Me.btnNTotal.Visible = False
            Me.btnNCurrent.Visible = False
            Me.btnNSiguiente.Visible = False
            Me.btnNUltimo.Visible = False
            Me.BindingNavigator1.BindingSource.AddNew()
        End If
        LoadRol()
    End Sub
    Private Sub LoadRol()
        btnElimina.Enabled = Roles.IsUserInRole(Usuario, Borrar)
        btnGuardar.Enabled = Roles.IsUserInRole(Usuario, Insertar)
    End Sub
    Private Function valida_datos() As Boolean
        Dim ban As Boolean = False
        Try
            If Me.txtPago.Text.Trim.Length > 0 Then
                ban = True
            Else
                SystemMessages1.SysMsg("El campo Forma de Pagp es requerido.", True)
                Me.txtPago.Focus()
            End If
        Catch ex As Exception

        End Try
        Return ban
    End Function



    Private Sub frmFormaPago_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim Maintab As UltraTabControl = TryCast(myparent.Controls.Find("UltraTabControl1", True).FirstOrDefault(), UltraTabControl)
        Maintab.Visible = False
        Maintab.Visible = True
    End Sub

    Private Sub btnGuardar_Click_1(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If valida_datos() Then
                If tipo_Permiso = 1 And id <> "0" Then
                    Me.Validate()

                    Me.BindingSource1.EndEdit()
                    Me.Fma_pagoTableAdapter.Update(Me.DsAgua.fma_pago)
                    SystemMessages1.SysMsg("Datos actualizados ")
                Else
                    Fma_pagoTableAdapter.Insert(Me.txtPago.Text.Trim.ToUpperInvariant)
                    Me.Fma_pagoTableAdapter.Update(Me.DsAgua.fma_pago)
                    SystemMessages1.SysMsg("Datos Registrados ")
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            SystemMessages1.SysMsg(ex.Message, True)
        End Try
    End Sub

    Private Sub btnElimina_Click_1(sender As Object, e As EventArgs) Handles btnElimina.Click
        Try
            If MsgBox("¿Seguro de Eliminar el Registro?", vbYesNo, "Confirmación") = vbYes Then
                Me.Validate()
                Me.BindingNavigator1.BindingSource.RemoveCurrent()
                Me.Fma_pagoTableAdapter.Update(Me.DsAgua.fma_pago)
                SystemMessages1.SysMsg("Datos eliminados ")
                MsgBox("Registro eliminado", MsgBoxStyle.Information, "Contribuyente")
                Me.Close()
            End If
        Catch ex As Exception
            SystemMessages1.SysMsg("Error al registrar los movimientos ", True)
        End Try
    End Sub

    Private Sub btnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        Me.Close()
    End Sub
End Class