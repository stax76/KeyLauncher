
Public Class MsgBox
    Inherits Form

#Region " Designer "

    Protected Overloads Overrides Sub Dispose(disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    Friend WithEvents laMain As Label
    Private components As System.ComponentModel.IContainer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.laMain = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'laMain
        '
        Me.laMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.laMain.Location = New System.Drawing.Point(0, 0)
        Me.laMain.Name = "laMain"
        Me.laMain.Padding = New System.Windows.Forms.Padding(18)
        Me.laMain.Size = New System.Drawing.Size(1022, 156)
        Me.laMain.TabIndex = 2
        Me.laMain.Text = "laMain"
        Me.laMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MsgBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(288.0!, 288.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1022, 156)
        Me.Controls.Add(Me.laMain)
        Me.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MsgBox"
        Me.ShowInTaskbar = False
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Sub New()
        MyBase.New()
        InitializeComponent()
        KeyPreview = True
        TopMost = True
        StartPosition = FormStartPosition.CenterParent
        BackColor = Color.FromArgb(&H50, &H50, &H50)
        laMain.ForeColor = Color.FromArgb(&HFFB0B3B5)
    End Sub

    Sub MsgBox_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyData
            Case Keys.Escape
                DialogResult = DialogResult.Cancel
            Case Keys.Enter
                DialogResult = DialogResult.OK
        End Select
    End Sub

    Shared Shadows Function Show(message As String) As DialogResult
        Using form As New MsgBox
            form.Text = Application.ProductName
            form.laMain.Text = message
            Return form.ShowDialog()
        End Using
    End Function
End Class
