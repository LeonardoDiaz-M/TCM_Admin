Imports Infragistics.Win.UltraMessageBox

Module modConst
    Public pathStoredFiles As String = My.Application.Info.DirectoryPath & "\ExportedFiles\"
    Public numCaja As Integer = 0
    Public CurrentUsrName As String = "0"
    Public NameGrid As String = ""


    'Public Sub MsgStatus(lblError As Label, texto As String, color As System.Drawing.Color, errorPrv As ErrorProvider)
    '    errorPrv.SetIconAlignment(lblError, ErrorIconAlignment.MiddleLeft)
    '    lblError.BackColor = color
    '    lblError.Text = texto
    '    lblError.Visible = True
    '    lblError.ForeColor = Color.Red
    '    errorPrv.SetError(lblError, texto)
    'End Sub

    Public Function ShowContinueMessage(ByVal message_header As String, ByVal message_footer As String,
                                        message As String, UltraMessageBoxManager1 As UltraMessageBoxManager,
                                        Optional type1 As MessageBoxButtons = MessageBoxButtons.YesNo,
                                        Optional msgtype As MessageBoxIcon = MessageBoxIcon.Question) As DialogResult
        Using ultraMessageBoxInfo As New UltraMessageBoxInfo()
            ' Set the general display style 
            ultraMessageBoxInfo.Style = MessageBoxStyle.Vista

            ' Set the text for the Text, Caption, Header and Footer 
            ultraMessageBoxInfo.Text = message
            ultraMessageBoxInfo.Caption = ""
            ultraMessageBoxInfo.Header = message_header
            ultraMessageBoxInfo.Footer = message_footer

            ' Specify which buttons should be used and which is the default button 
            ultraMessageBoxInfo.Buttons = type1
            'ultraMessageBoxInfo.DefaultButton = MessageBoxDefaultButton.Button1
            ultraMessageBoxInfo.ShowHelpButton = Infragistics.Win.DefaultableBoolean.[False]

            ' Display the OS Error Icon 
            ultraMessageBoxInfo.Icon = msgtype

            ' Disable the default sounds 
            ultraMessageBoxInfo.EnableSounds = Infragistics.Win.DefaultableBoolean.[False]

            ' Show the UltraMessageBox 
            Dim resp As DialogResult = UltraMessageBoxManager1.ShowMessageBox(ultraMessageBoxInfo)
            Return resp
        End Using
    End Function

    Public Function Get_Forms(cmb As ComboBox)
        Dim forms(200) As String
        Dim myAssembly As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
        cmb.DataSource = Nothing
        cmb.Items.Clear()
        Dim types As Type() = myAssembly.GetTypes()
        Dim comboBoxItems As New DataTable()
        comboBoxItems.Columns.Add("Display")
        comboBoxItems.Columns.Add("Value")
        Dim itemRow2 As DataRow = comboBoxItems.NewRow()
        itemRow2("Display") = "-Seleccione-"
        itemRow2("Value") = "-1"
        comboBoxItems.Rows.Add(itemRow2)
        Dim i As Integer = 0
        For Each t As Type In types
            If UCase(t.BaseType.ToString) = "SYSTEM.WINDOWS.FORMS.FORM" Then
                Dim formDB As Object = Activator.CreateInstance(Type.GetType(My.Application.Info.AssemblyName & "." & t.Name))
                Dim itemRow As DataRow = comboBoxItems.NewRow()
                itemRow("Display") = t.Name & "-" & formDB.Text
                itemRow("Value") = t.Name
                comboBoxItems.Rows.Add(itemRow)
            End If
        Next
        cmb.DisplayMember = "Display"
        cmb.ValueMember = "Value"
        cmb.DataSource = comboBoxItems
        cmb.DropDownStyle = ComboBoxStyle.DropDownList
        Return forms
    End Function

End Module
