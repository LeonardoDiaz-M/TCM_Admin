
Public Class SystemMessages
    Public IsError1 As Boolean = True
    Private startTime As DateTime
    Private messagetxt As String = ""
    Private Sub btnClose_Click(sender As Object, e As EventArgs)
        Me.Visible = False
    End Sub

    Private Sub SystemMessages_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.AutoScroll = True
        Me.Width = Me.Parent.Width
        Me.Dock = DockStyle.Top
        SysMsg("")
    End Sub

    Private Sub SystemMessages_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible Then
            '  Me.Height = 20
            Me.Width = Me.Parent.Width
            Me.Dock = DockStyle.Top
            Me.lblerror.BackColor = IIf(IsError1, Color.MistyRose, Color.LightGreen)
            If IsError1 Then
                Me.BackColor = Color.MistyRose
                Me.lblerror.ForeColor = Color.Red
            Else
                Me.BackColor = Color.LightGreen
                Me.lblerror.ForeColor = Color.DarkGreen
                Me.Timer1.Enabled = True
            End If
            Me.lblerror.Text = messagetxt
            Me.Timer1.Enabled = True
            startTime = Now()
            Me.Refresh()
        End If
    End Sub

    Private Sub lblError_Paint(sender As Object, e As PaintEventArgs) Handles lblerror.Paint
        ControlPaint.DrawBorder(e.Graphics, lblerror.DisplayRectangle, IIf(IsError1, Color.Red, Color.Green), ButtonBorderStyle.Solid)
    End Sub
    Private Sub UltraButton1_Click(sender As Object, e As EventArgs) Handles UltraButton1.Click
        Me.Visible = False
        Me.Height = 0
    End Sub
    Public Sub SysMsg(Message As String, Optional isError As Boolean = False)
        Me.Visible = False
        Me.IsError1 = isError
        Me.messagetxt = Message
        Me.lblerror.Text = messagetxt
        Me.ErrorProvider1.Clear()
        ErrorProvider1.SetIconAlignment(lblerror, ErrorIconAlignment.MiddleLeft)
        ErrorProvider1.SetError(lblerror, Message)
        Me.Visible = IIf(Message <> "", True, False)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If DateDiff(DateInterval.Second, startTime, Now) > 10 And Not Me.IsError1 Then
            Me.Timer1.Enabled = False
            UltraButton1_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub lblerror_TextChanged(sender As Object, e As EventArgs) Handles lblerror.TextChanged
        Me.Height = Me.lblerror.Height
        Me.TableLayoutPanel1.RowStyles(0).Height = Me.Height
    End Sub
End Class
