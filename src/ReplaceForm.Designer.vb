<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReplaceForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.buOK = New System.Windows.Forms.Button()
        Me.buCancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbSearch = New System.Windows.Forms.TextBox()
        Me.tbReplace = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.40154!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.buOK, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.buCancel, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.tbSearch, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.tbReplace, 1, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(14, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(486, 169)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'buOK
        '
        Me.buOK.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.buOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.buOK.Location = New System.Drawing.Point(278, 117)
        Me.buOK.Margin = New System.Windows.Forms.Padding(0, 0, 8, 0)
        Me.buOK.Name = "buOK"
        Me.buOK.Size = New System.Drawing.Size(100, 34)
        Me.buOK.TabIndex = 1
        Me.buOK.Text = "OK"
        Me.buOK.UseVisualStyleBackColor = True
        '
        'buCancel
        '
        Me.buCancel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.buCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.buCancel.Location = New System.Drawing.Point(386, 117)
        Me.buCancel.Margin = New System.Windows.Forms.Padding(0)
        Me.buCancel.Name = "buCancel"
        Me.buCancel.Size = New System.Drawing.Size(100, 34)
        Me.buCancel.TabIndex = 2
        Me.buCancel.Text = "Cancel"
        Me.buCancel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Search: "
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(0, 72)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Replace:"
        '
        'tbSearch
        '
        Me.tbSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.SetColumnSpan(Me.tbSearch, 2)
        Me.tbSearch.Location = New System.Drawing.Point(77, 19)
        Me.tbSearch.Margin = New System.Windows.Forms.Padding(0)
        Me.tbSearch.Name = "tbSearch"
        Me.tbSearch.Size = New System.Drawing.Size(409, 31)
        Me.tbSearch.TabIndex = 2
        '
        'tbReplace
        '
        Me.tbReplace.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.SetColumnSpan(Me.tbReplace, 2)
        Me.tbReplace.Location = New System.Drawing.Point(77, 69)
        Me.tbReplace.Margin = New System.Windows.Forms.Padding(0)
        Me.tbReplace.Name = "tbReplace"
        Me.tbReplace.Size = New System.Drawing.Size(409, 31)
        Me.tbReplace.TabIndex = 3
        '
        'ReplaceForm
        '
        Me.AcceptButton = Me.buOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.CancelButton = Me.buCancel
        Me.ClientSize = New System.Drawing.Size(514, 167)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ReplaceForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Replace"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbSearch As System.Windows.Forms.TextBox
    Friend WithEvents tbReplace As System.Windows.Forms.TextBox
    Friend WithEvents buOK As System.Windows.Forms.Button
    Friend WithEvents buCancel As System.Windows.Forms.Button
End Class
