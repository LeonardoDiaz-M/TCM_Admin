<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSQLConnection
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtDBPwd = New System.Windows.Forms.TextBox()
        Me.txtDBUserID = New System.Windows.Forms.TextBox()
        Me.txtDBName = New System.Windows.Forms.TextBox()
        Me.txtServerName = New System.Windows.Forms.TextBox()
        Me.btnChange = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.llbTitle = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.txtDBPwd, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txtDBUserID, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtDBName, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtServerName, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnChange, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.llbTitle, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(374, 270)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'txtDBPwd
        '
        Me.txtDBPwd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDBPwd.Location = New System.Drawing.Point(189, 177)
        Me.txtDBPwd.Name = "txtDBPwd"
        Me.txtDBPwd.Size = New System.Drawing.Size(143, 20)
        Me.txtDBPwd.TabIndex = 20
        '
        'txtDBUserID
        '
        Me.txtDBUserID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDBUserID.Location = New System.Drawing.Point(189, 137)
        Me.txtDBUserID.Name = "txtDBUserID"
        Me.txtDBUserID.Size = New System.Drawing.Size(143, 20)
        Me.txtDBUserID.TabIndex = 19
        '
        'txtDBName
        '
        Me.txtDBName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDBName.Location = New System.Drawing.Point(189, 97)
        Me.txtDBName.Name = "txtDBName"
        Me.txtDBName.Size = New System.Drawing.Size(143, 20)
        Me.txtDBName.TabIndex = 18
        '
        'txtServerName
        '
        Me.txtServerName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtServerName.Location = New System.Drawing.Point(189, 57)
        Me.txtServerName.Name = "txtServerName"
        Me.txtServerName.Size = New System.Drawing.Size(143, 20)
        Me.txtServerName.TabIndex = 17
        '
        'btnChange
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.btnChange, 2)
        Me.btnChange.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnChange.Location = New System.Drawing.Point(40, 217)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(292, 23)
        Me.btnChange.TabIndex = 16
        Me.btnChange.Text = "&Guardar Cambios"
        Me.btnChange.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(40, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 40)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Password:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 40)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Usuario:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 40)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Base de Datos:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 40)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Servidor SQL:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'llbTitle
        '
        Me.llbTitle.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.llbTitle, 2)
        Me.llbTitle.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.llbTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llbTitle.Location = New System.Drawing.Point(40, 34)
        Me.llbTitle.Name = "llbTitle"
        Me.llbTitle.Size = New System.Drawing.Size(292, 20)
        Me.llbTitle.TabIndex = 11
        Me.llbTitle.Text = "Conexión SQL"
        Me.llbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmSQLConnection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(374, 270)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSQLConnection"
        Me.Text = "Establecer Conexion SQL"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnChange As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents llbTitle As System.Windows.Forms.Label
    Friend WithEvents txtDBPwd As System.Windows.Forms.TextBox
    Friend WithEvents txtDBUserID As System.Windows.Forms.TextBox
    Friend WithEvents txtDBName As System.Windows.Forms.TextBox
    Friend WithEvents txtServerName As System.Windows.Forms.TextBox
End Class
