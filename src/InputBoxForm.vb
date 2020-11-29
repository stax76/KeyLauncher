
Imports System.Runtime.InteropServices

Public Class InputBoxForm
    Inherits Form

#Region " Designer "

    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

    ' Die Form �berschreibt den L�schvorgang der Basisklasse, um Komponenten zu bereinigen.
    Protected Overloads Overrides Sub Dispose(disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    ' F�r Windows Form-Designer erforderlich
    Private components As System.ComponentModel.IContainer

    'HINWEIS: Die folgende Prozedur ist f�r den Windows Form-Designer erforderlich
    'Sie kann mit dem Windows Form-Designer modifiziert werden.
    'Verwenden Sie nicht den Code-Editor zur Bearbeitung.
    Friend WithEvents bnCancel As System.Windows.Forms.Button
    Public WithEvents tbInput As System.Windows.Forms.TextBox
    Public WithEvents lPrompt As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Public WithEvents bOK As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lPrompt = New System.Windows.Forms.Label()
        Me.tbInput = New System.Windows.Forms.TextBox()
        Me.bnCancel = New System.Windows.Forms.Button()
        Me.bOK = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lPrompt
        '
        Me.lPrompt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.SetColumnSpan(Me.lPrompt, 2)
        Me.lPrompt.Location = New System.Drawing.Point(12, 4)
        Me.lPrompt.Margin = New System.Windows.Forms.Padding(12, 4, 12, 4)
        Me.lPrompt.Name = "lPrompt"
        Me.lPrompt.Size = New System.Drawing.Size(487, 58)
        Me.lPrompt.TabIndex = 0
        Me.lPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbInput
        '
        Me.tbInput.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.SetColumnSpan(Me.tbInput, 2)
        Me.tbInput.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbInput.Location = New System.Drawing.Point(12, 66)
        Me.tbInput.Margin = New System.Windows.Forms.Padding(12, 0, 12, 0)
        Me.tbInput.Name = "tbInput"
        Me.tbInput.Size = New System.Drawing.Size(487, 31)
        Me.tbInput.TabIndex = 1
        '
        'bCancel
        '
        Me.bnCancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.bnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bnCancel.Location = New System.Drawing.Point(399, 113)
        Me.bnCancel.Margin = New System.Windows.Forms.Padding(0, 0, 12, 0)
        Me.bnCancel.Name = "bCancel"
        Me.bnCancel.Size = New System.Drawing.Size(100, 34)
        Me.bnCancel.TabIndex = 2
        Me.bnCancel.Text = "Cancel"
        '
        'bOK
        '
        Me.bOK.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.bOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.bOK.Enabled = False
        Me.bOK.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bOK.Location = New System.Drawing.Point(291, 113)
        Me.bOK.Margin = New System.Windows.Forms.Padding(0, 0, 8, 0)
        Me.bOK.Name = "bOK"
        Me.bOK.Size = New System.Drawing.Size(100, 34)
        Me.bOK.TabIndex = 3
        Me.bOK.Text = "OK"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.bnCancel, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.bOK, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lPrompt, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.tbInput, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(10)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(511, 164)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'InputBoxForm
        '
        Me.AcceptButton = Me.bOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.CancelButton = Me.bnCancel
        Me.ClientSize = New System.Drawing.Size(511, 164)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "InputBoxForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Sub tbInput_TextChanged() Handles tbInput.TextChanged
        bOK.Enabled = (tbInput.Text <> "")
    End Sub

    Sub bnCancel_Click() Handles bnCancel.Click
        tbInput.Text = ""
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

    Sub InputBoxForm_Shown() Handles Me.Shown
        SetForegroundWindow(Handle)
    End Sub

    <DllImport("user32.dll")>
    Shared Function SetForegroundWindow(handle As IntPtr) As Boolean
    End Function
End Class
