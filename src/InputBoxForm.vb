
Public Class InputBoxForm
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

    Private components As System.ComponentModel.IContainer
    Public WithEvents tbInput As System.Windows.Forms.TextBox
    Public WithEvents lPrompt As System.Windows.Forms.Label
    Friend WithEvents tlpMain As System.Windows.Forms.TableLayoutPanel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lPrompt = New System.Windows.Forms.Label()
        Me.tbInput = New System.Windows.Forms.TextBox()
        Me.tlpMain = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'lPrompt
        '
        Me.lPrompt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lPrompt.Location = New System.Drawing.Point(30, 30)
        Me.lPrompt.Margin = New System.Windows.Forms.Padding(30, 30, 30, 8)
        Me.lPrompt.Name = "lPrompt"
        Me.lPrompt.Size = New System.Drawing.Size(962, 95)
        Me.lPrompt.TabIndex = 0
        Me.lPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbInput
        '
        Me.tbInput.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbInput.Location = New System.Drawing.Point(24, 133)
        Me.tbInput.Margin = New System.Windows.Forms.Padding(24, 0, 24, 24)
        Me.tbInput.Name = "tbInput"
        Me.tbInput.Size = New System.Drawing.Size(974, 54)
        Me.tbInput.TabIndex = 1
        '
        'tlpMain
        '
        Me.tlpMain.ColumnCount = 1
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMain.Controls.Add(Me.lPrompt, 0, 0)
        Me.tlpMain.Controls.Add(Me.tbInput, 0, 1)
        Me.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMain.Location = New System.Drawing.Point(0, 0)
        Me.tlpMain.Name = "tlpMain"
        Me.tlpMain.RowCount = 2
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMain.Size = New System.Drawing.Size(1022, 211)
        Me.tlpMain.TabIndex = 4
        '
        'InputBoxForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(288.0!, 288.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1022, 211)
        Me.Controls.Add(Me.tlpMain)
        Me.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "InputBoxForm"
        Me.ShowInTaskbar = False
        Me.tlpMain.ResumeLayout(False)
        Me.tlpMain.PerformLayout()
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
        lPrompt.ForeColor = Color.FromArgb(&HFFB0B3B5)
        tbInput.ForeColor = Color.FromArgb(&HFFB0B3B5)
        tbInput.BackColor = Color.FromArgb(&HFF1E1E1E)
    End Sub

    Sub InputBoxForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyData
            Case Keys.Escape
                Close()
            Case Keys.Enter
                DialogResult = DialogResult.OK
        End Select
    End Sub
End Class
