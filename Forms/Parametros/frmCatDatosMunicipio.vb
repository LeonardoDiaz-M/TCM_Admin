Imports System.ComponentModel
Imports Infragistics.Win.UltraWinTabControl
Imports System.Web.Security
Public Class frmCatDatosMunicipio
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

    Private Sub frmCatDatosMunicipio_Load(sender As Object, e As EventArgs) Handles Me.Load
        If id <> "0" Then
            'TODO: esta línea de código carga datos en la tabla 'DsCatalogos.oficinas' Puede moverla o quitarla según sea necesario.
            Me.Datos_mpioTableAdapter.Fill(Me.DsParametros.datos_mpio)
            Me.DatosmpioBindingSource.Position = Me.DatosmpioBindingSource.Find("num_mun", id)
            btnEliminar.Visible = True
            txtNumeroMunicipio.ReadOnly = True
        Else
            grpDatosMunicipio.Enabled = True
            txtNumeroMunicipio.ReadOnly = False
            btnEditar.Visible = False
            btnGuardar.Visible = True
            txtNumeroMunicipio.SelectAll()
        End If
        LoadRol()
    End Sub
    Private Sub LoadRol()
        btnEditar.Enabled = Roles.IsUserInRole(Usuario, Editar)
        btnEliminar.Enabled = Roles.IsUserInRole(Usuario, Borrar)
        btnGuardar.Enabled = Roles.IsUserInRole(Usuario, Insertar)
    End Sub

    Private Function valida_datos() As Boolean
        Dim ban As Boolean = False
        Dim ocurriounError As Integer = 0
        Dim mensaje As String = ""
        Try
            ErrorProvider1.Clear()

            If txtNumeroMunicipio.Text = "" Then
                ErrorProvider1.SetError(txtNumeroMunicipio, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo id es requerido." & "<br />"
                Me.txtNumeroMunicipio.Focus()
            End If

            If txtNombre.Text = "" Then
                ErrorProvider1.SetError(txtNombre, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo nombre es requerido." & "<br />"
                Me.txtNombre.Focus()
            End If

            If txtNombreMunicipio.Text = "" Then
                ErrorProvider1.SetError(txtNombreMunicipio, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo dirección es requerido." & "<br />"
                Me.txtNombreMunicipio.Focus()
            End If

            If txtDireccion.Text = "" Then
                ErrorProvider1.SetError(txtDireccion, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo responsable es requerido." & "<br />"
                Me.txtDireccion.Focus()
            End If

            If txtTelefono.Text = "" Then
                ErrorProvider1.SetError(txtTelefono, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo nombre area responsable es requerido." & "<br />"
                Me.txtTelefono.Focus()
            End If


            If txtNombreAreaIngresos.Text = "" Then
                ErrorProvider1.SetError(txtNombreAreaIngresos, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo nombre area ingresos es requerido." & "<br />"
                Me.txtNombreAreaIngresos.Focus()
            End If

            If txtNombrePresidente.Text = "" Then
                ErrorProvider1.SetError(txtNombrePresidente, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo Nombre Presidente es requerido." & "<br />"
                Me.txtNombrePresidente.Focus()
            End If

            If txtNombreTesorero.Text = "" Then
                ErrorProvider1.SetError(txtNombreTesorero, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo nombre Tesorero es requerido." & "<br />"
                Me.txtNombreTesorero.Focus()
            End If

            If txtNombreSindico.Text = "" Then
                ErrorProvider1.SetError(txtNombreSindico, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo nombre Sindico es requerido." & "<br />"
                Me.txtNombreSindico.Focus()
            End If

            If txtNombreDirectorGob.Text = "" Then
                ErrorProvider1.SetError(txtNombreDirectorGob, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo Nombre Director Gobierno es requerido." & "<br />"
                Me.txtNombreDirectorGob.Focus()
            End If

            If txtNombreDesarrolloUrbano.Text = "" Then
                ErrorProvider1.SetError(txtNombreDesarrolloUrbano, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo nombre Desarrollo Urbano es requerido." & "<br />"
                Me.txtNombreDesarrolloUrbano.Focus()
            End If

            If txtNombreDesarrolloEconomico.Text = "" Then
                ErrorProvider1.SetError(txtNombreDesarrolloEconomico, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo nombre Desarrollo Económico es requerido." & "<br />"
                Me.txtNombreDesarrolloEconomico.Focus()
            End If


            If Me.ucoGrupoMunicipio.SelectedIndex < 1 Then
                ErrorProvider1.SetError(ucoGrupoMunicipio, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo Grupo Municipio es requerido." & "<br />"
                Me.ucoGrupoMunicipio.Focus()
            End If

            If Me.ucoGrupoPredial.SelectedIndex < 1 Then
                ErrorProvider1.SetError(ucoGrupoPredial, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo Grupo Predial es requerido." & "<br />"
                Me.ucoGrupoPredial.Focus()
            End If

            If Me.ucoGrupoAgua.SelectedIndex < 1 Then
                ErrorProvider1.SetError(ucoGrupoAgua, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo Grupo Agua es requerido." & "<br />"
                Me.ucoGrupoAgua.Focus()
            End If

            If Me.ucoGrupoLicFunc.SelectedIndex < 1 Then
                ErrorProvider1.SetError(ucoGrupoLicFunc, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo Grupo Licencias Funcionamiento es requerido." & "<br />"
                Me.ucoGrupoLicFunc.Focus()
            End If

            If Me.ucoGrupoDesarrolloUrbLic.SelectedIndex < 1 Then
                ErrorProvider1.SetError(ucoGrupoDesarrolloUrbLic, "Error")
                ocurriounError += 1
                mensaje += "- " & "El campo Grupo Desarrollo Urbano Licencias es requerido." & "<br />"
                Me.ucoGrupoDesarrolloUrbLic.Focus()
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


    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If valida_datos() = False Then
                If id <> "0" Then
                    Me.Validate()
                    Me.DatosmpioBindingSource.EndEdit()
                    Me.Datos_mpioTableAdapter.Update(Me.DsParametros.datos_mpio)
                    cMensajes.DisplayMessage(Me, "Datos actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Else
                    Datos_mpioTableAdapter.Insert(txtNumeroMunicipio.Text, txtNombre.Text, txtNombreMunicipio.Text, txtDireccion.Text, txtTelefono.Text, txtNombreAreaIngresos.Text _
                                                  , txtNombrePresidente.Text, txtNombreTesorero.Text, txtNombreSindico.Text, txtNombreDirectorGob.Text, txtNombreDesarrolloUrbano.Text _
                                                  , txtNombreDesarrolloEconomico.Text, chkCobraDrenaje.Checked, ucoGrupoDesarrolloUrbLic.Text, ucoGrupoLicFunc.Text, ucoGrupoMunicipio.Text _
                                                  , ucoGrupoAgua.Text, ucoGrupoPredial.Text)

                    Me.Datos_mpioTableAdapter.Update(Me.DsParametros.datos_mpio)
                    cMensajes.DisplayMessage(Me, "Datos Registrados", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            cMensajes.DisplayMessage(Me, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End Try
    End Sub
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        txtNumeroMunicipio.ReadOnly = True
        grpDatosMunicipio.Enabled = True
        btnEditar.Visible = False
        btnGuardar.Visible = True
    End Sub
    Private Sub btnElimina_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If MsgBox("¿Seguro de Eliminar el Registro?", vbYesNo, "Confirmación") = vbYes Then
                Me.Validate()
                Me.BindingNavigator1.BindingSource.RemoveCurrent()
                Me.Datos_mpioTableAdapter.Update(Me.DsParametros.datos_mpio)
                cMensajes.DisplayMessage(Me, "Datos eliminados", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Me.Close()
            End If

        Catch ex As Exception
            cMensajes.DisplayMessage(Me, "Error al registrar los movimientos ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End Try
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim Mainbar As ToolStrip = TryCast(parent.Controls.Find("CommandBar", True).FirstOrDefault(), ToolStrip)
        Mainbar.Enabled = True
        Me.Close()
        Me.Dispose()
    End Sub



    'Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
    '    Me.OficinasBindingSource.Position = Me.OficinasBindingSource.Find("nom_colonia", txtBusca.Text)
    'End Sub

    Private Sub btnUndo_Click_1(sender As Object, e As EventArgs) Handles btnUndo.Click
        ErrorProvider1.Clear()
        DatosmpioBindingSource.CancelEdit()
    End Sub

    Private Sub frmCatDatosMunicipio_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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
    Private Sub frmCatDatosMunicipio_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim Maintab As UltraTabControl = TryCast(parent.Controls.Find("tabPrincipal", True).FirstOrDefault(), UltraTabControl)
        Maintab.Visible = True
        Dim Mainbar As ToolStrip = TryCast(parent.Controls.Find("CommandBar", True).FirstOrDefault(), ToolStrip)
        Mainbar.Visible = True
    End Sub

    Private Sub frmCatDatosMunicipio_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        txtNumeroMunicipio.Focus()
    End Sub
End Class