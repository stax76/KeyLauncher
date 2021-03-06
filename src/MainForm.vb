
Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports System.Text.RegularExpressions
Imports System.Threading

Imports Microsoft.VisualBasic

Public Class MainForm
    Inherits Form

#Region "Designer"

    Private WithEvents lbItems As ListBoxEx
    Private WithEvents tbName As System.Windows.Forms.TextBox
    Friend WithEvents rtb As RichTextBox
    Friend WithEvents tlpMain As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmsRTB As ContextMenuStripEx
    Friend WithEvents cmsLB As ContextMenuStripEx
    Friend WithEvents miCut As MenuItem
    Friend WithEvents miCopy As MenuItem
    Friend WithEvents miPaste As MenuItem
    Friend WithEvents miRename As MenuItem
    Friend WithEvents miDelete As MenuItem
    Friend WithEvents tlpName As TableLayoutPanel
    Friend WithEvents tlpItems As TableLayoutPanel
    Friend WithEvents tlpRTB As TableLayoutPanel
    Friend WithEvents miPriority As MenuItem
    Friend WithEvents miPriorityLow As MenuItem
    Friend WithEvents miPriorityMedium As MenuItem
    Friend WithEvents miPriorityHigh As MenuItem
    Friend WithEvents miNew As MenuItem
    Friend WithEvents miAdvanced As MenuItem
    Friend WithEvents miSearchAndReplace As MenuItem
    Friend WithEvents miShowAll As MenuItem
    Friend WithEvents miEdit As MenuItem
    Friend WithEvents miSearch As MenuItem
    Friend WithEvents miClearHide As MenuItem
    Friend WithEvents miExit As MenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents miMoveWindowLeft As MenuItem
    Friend WithEvents miMoveWindowRight As MenuItem
    Friend WithEvents miMoveWindowTop As MenuItem
    Friend WithEvents miMoveWindowBottom As MenuItem
    Friend WithEvents miAbout As MenuItem
    Friend WithEvents miAction As MenuItem
    Friend WithEvents miCommandLineAction As MenuItem
    Friend WithEvents miPasteAction As MenuItem
    Friend WithEvents miNoneAction As MenuItem
    Friend WithEvents miPrioritySuperHigh As MenuItem
    Friend WithEvents miPriorityVeryHigh As MenuItem
    Friend WithEvents miPriorityHigher As MenuItem
    Friend WithEvents miPriorityLower As MenuItem
    Friend WithEvents miPriorityVeryLow As MenuItem
    Friend WithEvents miPrioritySuperLow As MenuItem
    Friend WithEvents miHelp As MenuItem
    Private components As IContainer

    Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.tlpMain = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpName = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpItems = New System.Windows.Forms.TableLayoutPanel()
        Me.lbItems = New ListBoxEx()
        Me.cmsLB = New ContextMenuStripEx(Me.components)
        Me.miNew = New MenuItem()
        Me.miRename = New MenuItem()
        Me.miEdit = New MenuItem()
        Me.miSearch = New MenuItem()
        Me.miDelete = New MenuItem()
        Me.miPriority = New MenuItem()
        Me.miPrioritySuperHigh = New MenuItem()
        Me.miPriorityVeryHigh = New MenuItem()
        Me.miPriorityHigher = New MenuItem()
        Me.miPriorityHigh = New MenuItem()
        Me.miPriorityMedium = New MenuItem()
        Me.miPriorityLow = New MenuItem()
        Me.miPriorityLower = New MenuItem()
        Me.miPriorityVeryLow = New MenuItem()
        Me.miPrioritySuperLow = New MenuItem()
        Me.miAction = New MenuItem()
        Me.miCommandLineAction = New MenuItem()
        Me.miPasteAction = New MenuItem()
        Me.miNoneAction = New MenuItem()
        Me.miAdvanced = New MenuItem()
        Me.miSearchAndReplace = New MenuItem()
        Me.miShowAll = New MenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.miMoveWindowLeft = New MenuItem()
        Me.miMoveWindowRight = New MenuItem()
        Me.miMoveWindowTop = New MenuItem()
        Me.miMoveWindowBottom = New MenuItem()
        Me.miClearHide = New MenuItem()
        Me.miAbout = New MenuItem()
        Me.miExit = New MenuItem()
        Me.miHelp = New MenuItem()
        Me.tlpRTB = New System.Windows.Forms.TableLayoutPanel()
        Me.rtb = New System.Windows.Forms.RichTextBox()
        Me.cmsRTB = New ContextMenuStripEx(Me.components)
        Me.miCut = New MenuItem()
        Me.miCopy = New MenuItem()
        Me.miPaste = New MenuItem()
        Me.tlpMain.SuspendLayout()
        Me.tlpName.SuspendLayout()
        Me.tlpItems.SuspendLayout()
        Me.cmsLB.SuspendLayout()
        Me.tlpRTB.SuspendLayout()
        Me.cmsRTB.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbName
        '
        Me.tbName.AcceptsTab = True
        Me.tbName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbName.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbName.Location = New System.Drawing.Point(0, 0)
        Me.tbName.Margin = New System.Windows.Forms.Padding(0)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(711, 57)
        Me.tbName.TabIndex = 0
        '
        'tlpMain
        '
        Me.tlpMain.ColumnCount = 2
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.01606!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.98394!))
        Me.tlpMain.Controls.Add(Me.tlpName, 0, 0)
        Me.tlpMain.Controls.Add(Me.tlpItems, 0, 1)
        Me.tlpMain.Controls.Add(Me.tlpRTB, 1, 1)
        Me.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMain.Location = New System.Drawing.Point(0, 0)
        Me.tlpMain.Margin = New System.Windows.Forms.Padding(5)
        Me.tlpMain.Name = "tlpMain"
        Me.tlpMain.RowCount = 2
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpMain.Size = New System.Drawing.Size(721, 305)
        Me.tlpMain.TabIndex = 3
        '
        'tlpName
        '
        Me.tlpName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpName.AutoSize = True
        Me.tlpName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpName.ColumnCount = 1
        Me.tlpMain.SetColumnSpan(Me.tlpName, 2)
        Me.tlpName.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpName.Controls.Add(Me.tbName, 0, 0)
        Me.tlpName.Location = New System.Drawing.Point(5, 5)
        Me.tlpName.Margin = New System.Windows.Forms.Padding(5)
        Me.tlpName.Name = "tlpName"
        Me.tlpName.RowCount = 1
        Me.tlpName.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpName.Size = New System.Drawing.Size(711, 57)
        Me.tlpName.TabIndex = 3
        '
        'tlpItems
        '
        Me.tlpItems.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpItems.ColumnCount = 1
        Me.tlpItems.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpItems.Controls.Add(Me.lbItems, 0, 0)
        Me.tlpItems.Location = New System.Drawing.Point(5, 72)
        Me.tlpItems.Margin = New System.Windows.Forms.Padding(5)
        Me.tlpItems.Name = "tlpItems"
        Me.tlpItems.RowCount = 1
        Me.tlpItems.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpItems.Size = New System.Drawing.Size(235, 228)
        Me.tlpItems.TabIndex = 4
        '
        'lbItems
        '
        Me.lbItems.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbItems.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbItems.ContextMenuStrip = Me.cmsLB
        Me.lbItems.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.lbItems.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbItems.FormattingEnabled = True
        Me.lbItems.IntegralHeight = False
        Me.lbItems.ItemHeight = 76
        Me.lbItems.Location = New System.Drawing.Point(0, 0)
        Me.lbItems.Margin = New System.Windows.Forms.Padding(0)
        Me.lbItems.Name = "lbItems"
        Me.lbItems.SelectionColor = System.Drawing.Color.Empty
        Me.lbItems.Size = New System.Drawing.Size(235, 228)
        Me.lbItems.TabIndex = 1
        Me.lbItems.TabStop = False
        '
        'cmsLB
        '
        Me.cmsLB.ImageScalingSize = New System.Drawing.Size(48, 48)
        Me.cmsLB.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miNew, Me.miRename, Me.miEdit, Me.miSearch, Me.miDelete, Me.miPriority, Me.miAction, Me.miAdvanced, Me.miClearHide, Me.miAbout, Me.miExit, Me.miHelp})
        Me.cmsLB.Name = "cmsLB"
        Me.cmsLB.Size = New System.Drawing.Size(289, 808)
        '
        'miNew
        '
        Me.miNew.Action = Nothing
        Me.miNew.Name = "miNew"
        Me.miNew.ShortcutKeyDisplayString = ""
        Me.miNew.Size = New System.Drawing.Size(288, 67)
        Me.miNew.Text = "New"
        '
        'miRename
        '
        Me.miRename.Action = Nothing
        Me.miRename.Name = "miRename"
        Me.miRename.ShortcutKeyDisplayString = ""
        Me.miRename.Size = New System.Drawing.Size(288, 67)
        Me.miRename.Text = "Rename      "
        '
        'miEdit
        '
        Me.miEdit.Action = Nothing
        Me.miEdit.Name = "miEdit"
        Me.miEdit.Size = New System.Drawing.Size(288, 67)
        Me.miEdit.Text = "Edit"
        '
        'miSearch
        '
        Me.miSearch.Action = Nothing
        Me.miSearch.Name = "miSearch"
        Me.miSearch.Size = New System.Drawing.Size(288, 67)
        Me.miSearch.Text = "Search"
        '
        'miDelete
        '
        Me.miDelete.Action = Nothing
        Me.miDelete.Name = "miDelete"
        Me.miDelete.ShortcutKeyDisplayString = ""
        Me.miDelete.Size = New System.Drawing.Size(288, 67)
        Me.miDelete.Text = "Delete"
        '
        'miPriority
        '
        Me.miPriority.Action = Nothing
        Me.miPriority.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miPrioritySuperHigh, Me.miPriorityVeryHigh, Me.miPriorityHigher, Me.miPriorityHigh, Me.miPriorityMedium, Me.miPriorityLow, Me.miPriorityLower, Me.miPriorityVeryLow, Me.miPrioritySuperLow})
        Me.miPriority.Name = "miPriority"
        Me.miPriority.Size = New System.Drawing.Size(288, 67)
        Me.miPriority.Text = "Priority"
        '
        'miPrioritySuperHigh
        '
        Me.miPrioritySuperHigh.Action = Nothing
        Me.miPrioritySuperHigh.Name = "miPrioritySuperHigh"
        Me.miPrioritySuperHigh.Size = New System.Drawing.Size(396, 67)
        Me.miPrioritySuperHigh.Text = "Super High"
        '
        'miPriorityVeryHigh
        '
        Me.miPriorityVeryHigh.Action = Nothing
        Me.miPriorityVeryHigh.Name = "miPriorityVeryHigh"
        Me.miPriorityVeryHigh.Size = New System.Drawing.Size(396, 67)
        Me.miPriorityVeryHigh.Text = "Very High"
        '
        'miPriorityHigher
        '
        Me.miPriorityHigher.Action = Nothing
        Me.miPriorityHigher.Name = "miPriorityHigher"
        Me.miPriorityHigher.Size = New System.Drawing.Size(396, 67)
        Me.miPriorityHigher.Text = "Higher"
        '
        'miPriorityHigh
        '
        Me.miPriorityHigh.Action = Nothing
        Me.miPriorityHigh.Name = "miPriorityHigh"
        Me.miPriorityHigh.Size = New System.Drawing.Size(396, 67)
        Me.miPriorityHigh.Text = "High"
        '
        'miPriorityMedium
        '
        Me.miPriorityMedium.Action = Nothing
        Me.miPriorityMedium.Name = "miPriorityMedium"
        Me.miPriorityMedium.Size = New System.Drawing.Size(396, 67)
        Me.miPriorityMedium.Text = "Medium"
        '
        'miPriorityLow
        '
        Me.miPriorityLow.Action = Nothing
        Me.miPriorityLow.Name = "miPriorityLow"
        Me.miPriorityLow.Size = New System.Drawing.Size(396, 67)
        Me.miPriorityLow.Text = "Low"
        '
        'miPriorityLower
        '
        Me.miPriorityLower.Action = Nothing
        Me.miPriorityLower.Name = "miPriorityLower"
        Me.miPriorityLower.Size = New System.Drawing.Size(396, 67)
        Me.miPriorityLower.Text = "Lower"
        '
        'miPriorityVeryLow
        '
        Me.miPriorityVeryLow.Action = Nothing
        Me.miPriorityVeryLow.Name = "miPriorityVeryLow"
        Me.miPriorityVeryLow.Size = New System.Drawing.Size(396, 67)
        Me.miPriorityVeryLow.Text = "Very Low"
        '
        'miPrioritySuperLow
        '
        Me.miPrioritySuperLow.Action = Nothing
        Me.miPrioritySuperLow.Name = "miPrioritySuperLow"
        Me.miPrioritySuperLow.Size = New System.Drawing.Size(396, 67)
        Me.miPrioritySuperLow.Text = "Super Low"
        '
        'miAction
        '
        Me.miAction.Action = Nothing
        Me.miAction.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miCommandLineAction, Me.miPasteAction, Me.miNoneAction})
        Me.miAction.Name = "miAction"
        Me.miAction.Size = New System.Drawing.Size(288, 67)
        Me.miAction.Text = "Action"
        '
        'miCommandLineAction
        '
        Me.miCommandLineAction.Action = Nothing
        Me.miCommandLineAction.Name = "miCommandLineAction"
        Me.miCommandLineAction.Size = New System.Drawing.Size(447, 67)
        Me.miCommandLineAction.Text = "CommandLine"
        '
        'miPasteAction
        '
        Me.miPasteAction.Action = Nothing
        Me.miPasteAction.Name = "miPasteAction"
        Me.miPasteAction.Size = New System.Drawing.Size(447, 67)
        Me.miPasteAction.Text = "Paste"
        '
        'miNoneAction
        '
        Me.miNoneAction.Action = Nothing
        Me.miNoneAction.Name = "miNoneAction"
        Me.miNoneAction.Size = New System.Drawing.Size(447, 67)
        Me.miNoneAction.Text = "None"
        '
        'miAdvanced
        '
        Me.miAdvanced.Action = Nothing
        Me.miAdvanced.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miSearchAndReplace, Me.miShowAll, Me.ToolStripMenuItem1, Me.miMoveWindowLeft, Me.miMoveWindowRight, Me.miMoveWindowTop, Me.miMoveWindowBottom})
        Me.miAdvanced.Name = "miAdvanced"
        Me.miAdvanced.Size = New System.Drawing.Size(288, 67)
        Me.miAdvanced.Text = "Advanced"
        '
        'miSearchAndReplace
        '
        Me.miSearchAndReplace.Action = Nothing
        Me.miSearchAndReplace.Name = "miSearchAndReplace"
        Me.miSearchAndReplace.ShortcutKeyDisplayString = ""
        Me.miSearchAndReplace.Size = New System.Drawing.Size(576, 67)
        Me.miSearchAndReplace.Text = "Search and Replace"
        '
        'miShowAll
        '
        Me.miShowAll.Action = Nothing
        Me.miShowAll.Name = "miShowAll"
        Me.miShowAll.Size = New System.Drawing.Size(576, 67)
        Me.miShowAll.Text = "Show All"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(573, 6)
        '
        'miMoveWindowLeft
        '
        Me.miMoveWindowLeft.Action = Nothing
        Me.miMoveWindowLeft.Name = "miMoveWindowLeft"
        Me.miMoveWindowLeft.Size = New System.Drawing.Size(576, 67)
        Me.miMoveWindowLeft.Text = "Move Window Left"
        '
        'miMoveWindowRight
        '
        Me.miMoveWindowRight.Action = Nothing
        Me.miMoveWindowRight.Name = "miMoveWindowRight"
        Me.miMoveWindowRight.Size = New System.Drawing.Size(576, 67)
        Me.miMoveWindowRight.Text = "Move Window Right"
        '
        'miMoveWindowTop
        '
        Me.miMoveWindowTop.Action = Nothing
        Me.miMoveWindowTop.Name = "miMoveWindowTop"
        Me.miMoveWindowTop.Size = New System.Drawing.Size(576, 67)
        Me.miMoveWindowTop.Text = "Move Window Top"
        '
        'miMoveWindowBottom
        '
        Me.miMoveWindowBottom.Action = Nothing
        Me.miMoveWindowBottom.Name = "miMoveWindowBottom"
        Me.miMoveWindowBottom.Size = New System.Drawing.Size(576, 67)
        Me.miMoveWindowBottom.Text = "Move Window Bottom"
        '
        'miClearHide
        '
        Me.miClearHide.Action = Nothing
        Me.miClearHide.Name = "miClearHide"
        Me.miClearHide.Size = New System.Drawing.Size(288, 67)
        Me.miClearHide.Text = "Clear/Hide"
        '
        'miAbout
        '
        Me.miAbout.Action = Nothing
        Me.miAbout.Name = "miAbout"
        Me.miAbout.Size = New System.Drawing.Size(288, 67)
        Me.miAbout.Text = "About"
        '
        'miExit
        '
        Me.miExit.Action = Nothing
        Me.miExit.Name = "miExit"
        Me.miExit.Size = New System.Drawing.Size(288, 67)
        Me.miExit.Text = "Exit"
        '
        'miHelp
        '
        Me.miHelp.Action = Nothing
        Me.miHelp.Name = "miHelp"
        Me.miHelp.Size = New System.Drawing.Size(288, 67)
        Me.miHelp.Text = "Help"
        '
        'tlpRTB
        '
        Me.tlpRTB.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpRTB.ColumnCount = 1
        Me.tlpRTB.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpRTB.Controls.Add(Me.rtb, 0, 0)
        Me.tlpRTB.Location = New System.Drawing.Point(250, 72)
        Me.tlpRTB.Margin = New System.Windows.Forms.Padding(5)
        Me.tlpRTB.Name = "tlpRTB"
        Me.tlpRTB.RowCount = 1
        Me.tlpRTB.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpRTB.Size = New System.Drawing.Size(466, 228)
        Me.tlpRTB.TabIndex = 5
        '
        'rtb
        '
        Me.rtb.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtb.ContextMenuStrip = Me.cmsRTB
        Me.rtb.EnableAutoDragDrop = True
        Me.rtb.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.rtb.Location = New System.Drawing.Point(0, 0)
        Me.rtb.Margin = New System.Windows.Forms.Padding(0)
        Me.rtb.Name = "rtb"
        Me.rtb.ReadOnly = True
        Me.rtb.Size = New System.Drawing.Size(466, 228)
        Me.rtb.TabIndex = 2
        Me.rtb.Text = ""
        '
        'cmsRTB
        '
        Me.cmsRTB.ImageScalingSize = New System.Drawing.Size(48, 48)
        Me.cmsRTB.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miCut, Me.miCopy, Me.miPaste})
        Me.cmsRTB.Name = "cmsRTB"
        Me.cmsRTB.Size = New System.Drawing.Size(282, 205)
        '
        'miCut
        '
        Me.miCut.Action = Nothing
        Me.miCut.Name = "miCut"
        Me.miCut.Size = New System.Drawing.Size(281, 67)
        Me.miCut.Text = "Cut"
        '
        'miCopy
        '
        Me.miCopy.Action = Nothing
        Me.miCopy.Name = "miCopy"
        Me.miCopy.Size = New System.Drawing.Size(281, 67)
        Me.miCopy.Text = "Copy          "
        '
        'miPaste
        '
        Me.miPaste.Action = Nothing
        Me.miPaste.Name = "miPaste"
        Me.miPaste.Size = New System.Drawing.Size(281, 67)
        Me.miPaste.Text = "Paste"
        '
        'MainForm
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(288.0!, 288.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(721, 305)
        Me.Controls.Add(Me.tlpMain)
        Me.Font = New System.Drawing.Font("Consolas", 9.857143!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "MainForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KeyLauncher"
        Me.TopMost = True
        Me.tlpMain.ResumeLayout(False)
        Me.tlpMain.PerformLayout()
        Me.tlpName.ResumeLayout(False)
        Me.tlpName.PerformLayout()
        Me.tlpItems.ResumeLayout(False)
        Me.cmsLB.ResumeLayout(False)
        Me.tlpRTB.ResumeLayout(False)
        Me.cmsRTB.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
#End Region

    Private BlockTextChanged As Boolean
    Private Items As List(Of Item)
    Private SettingsFileName As String = "Settings.xml"
    Private TextBackColor As Color
    Private TextForeColor As Color
    Private DPI As Integer
    Private LastSearch As String

    Public Sub New()
        Try
            InitializeComponent()

            AddHandler Application.ThreadException, AddressOf ApplicationThreadException
            tlpName.Height = FontHeight * 2
            lbItems.ItemHeight = CInt(FontHeight * 1.4)
            Width = FontHeight * 40
            Height = FontHeight * 18

            Const MOD_ALT = &H1

            If Not RegisterHotKey(Handle, 0, MOD_ALT, CUInt(Keys.Space)) Then
                Msg("Error registering hotkey.", MessageBoxIcon.Error)
            End If

            LoadItems()
            ActiveControl = tbName
            ToolStripRendererEx.InitColors(Color.Blue, False, False)
            cmsLB.Renderer = New ToolStripRendererEx()
            cmsRTB.Renderer = New ToolStripRendererEx()

            Dim gx = Graphics.FromHwnd(IntPtr.Zero)
            Dim LOGPIXELSX = 88
            DPI = GetDeviceCaps(gx.GetHdc(), LOGPIXELSX)

            If Debugger.IsAttached Then
                Invoke(Sub() ShowWindow())
            End If
        Catch ex As Exception
            Msg(ex.ToString, MessageBoxIcon.Error)
        End Try
    End Sub

    <STAThread()>
    Shared Sub Main()
        If Process.GetProcessesByName(Process.GetCurrentProcess.ProcessName).Length > 1 Then
            MessageBox.Show("Launcher is already running.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Dim TempMainForm = New MainForm()
            Application.Run()
        End If
    End Sub

    Sub ApplicationThreadException(sender As Object, e As ThreadExceptionEventArgs)
        Msg(e.Exception.ToString(), MessageBoxIcon.Error)
    End Sub

    Protected Overloads Overrides Sub Dispose(disposing As Boolean)
        If disposing Then
            If components IsNot Nothing Then
                components.Dispose()
            End If
        End If

        MyBase.Dispose(disposing)
    End Sub

    Private _SettingsFolder As String

    ReadOnly Property SettingsFolder As String
        Get
            If _SettingsFolder Is Nothing Then
                _SettingsFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\KeyLauncher\"

                If Not Directory.Exists(_SettingsFolder) Then
                    Dim linkFile = StartupFolder + "settings-directory.txt"

                    If File.Exists(linkFile) Then
                        Dim linkTarget = File.ReadAllText(linkFile).Trim()

                        If linkTarget.StartsWith(".") Then
                            linkTarget = StartupFolder + linkTarget
                        End If

                        If Directory.Exists(linkTarget) Then
                            _SettingsFolder = FixFolder(linkTarget)
                        End If
                    End If
                End If
            End If

            Return _SettingsFolder
        End Get
    End Property

    Shared StartupValue As String

    Shared ReadOnly Property StartupFolder As String
        Get
            If StartupValue Is Nothing Then
                StartupValue = FixFolder(Application.StartupPath)
            End If

            Return StartupValue
        End Get
    End Property

    Shared Function FixFolder(folderPath As String) As String
        If folderPath = "" Then
            Return ""
        End If

        While folderPath.EndsWith("\\")
            folderPath = folderPath.Substring(0, folderPath.Length - 1)
        End While

        If folderPath.EndsWith("\") Then
            Return folderPath
        End If

        Return folderPath + "\"
    End Function

    Sub LoadItems()
        If File.Exists(SettingsFolder + SettingsFileName) Then
            Items = XmlSerializerHelp.LoadXML(Of List(Of Item))(SettingsFolder + SettingsFileName)
        Else
            Items = New List(Of Item)()
        End If
    End Sub

    Sub SaveItems()
        If g.HasChanged Then
            If Not Directory.Exists(SettingsFolder) Then
                Directory.CreateDirectory(SettingsFolder)
            End If

            XmlSerializerHelp.SaveXML(SettingsFolder + SettingsFileName, Items)
            g.HasChanged = False
        End If
    End Sub

    Shared Function FixBreak(value As String) As String
        value = value.Replace(ChrW(13) + ChrW(10), ChrW(10))
        value = value.Replace(ChrW(13), ChrW(10))
        Return value.Replace(ChrW(10), ChrW(13) + ChrW(10))
    End Function

    Sub Launch(asAdmin As Boolean, asFolder As Boolean)
        If lbItems.SelectedIndex > -1 Then
            Dim item = DirectCast(lbItems.SelectedItem, Item)
            Dim value = item.Value.Trim

            If item.ActionMode = ActionMode.Paste Then
                HideForm()
                Dim clipCurrent = Clipboard.GetText
                Clipboard.SetText(value)
                SendKeys.SendWait("^v")
                Thread.Sleep(1000)

                If clipCurrent <> "" Then
                    Clipboard.SetText(clipCurrent)
                End If
            ElseIf item.ActionMode = ActionMode.CommandLine Then
                Try
                    HideForm()

                    value = FixBreak(value)
                    Dim workingDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                    Dim startMinimized As Boolean
                    Dim startMaximized As Boolean
                    Dim startHidden As Boolean

                    If value.Contains(vbCrLf) Then
                        For Each line In value.Split(vbCrLf)
                            Dim trimmedLine = line.Trim

                            If trimmedLine <> "" AndAlso Not trimmedLine.StartsWith("#") Then
                                If trimmedLine.StartsWith("working directory:") Then
                                    workingDirectory = trimmedLine.Substring(18).Trim
                                ElseIf trimmedLine = "minimized" Then
                                    startMinimized = True
                                ElseIf trimmedLine = "maximized" Then
                                    startMaximized = True
                                ElseIf trimmedLine = "hidden" Then
                                    startHidden = True
                                Else
                                    value = line
                                End If
                            End If
                        Next
                    End If

                    If value.Length > 3 AndAlso value.Substring(1).StartsWith(":\") AndAlso
                        value.Contains(" ") AndAlso (File.Exists(value) OrElse Directory.Exists(value)) Then

                        value = """" + value + """"
                    End If

                    Dim match = Regex.Match(value, "((?<file>[^\s""]+)|""(?<file>.+?)"") *(?<args>[^\f\r]*)")

                    Using proc As New Process
                        If asFolder Then
                            proc.StartInfo.FileName = Path.GetDirectoryName(match.Groups("file").Value)
                        Else
                            proc.StartInfo.FileName = match.Groups("file").Value
                            proc.StartInfo.Arguments = match.Groups("args").Value
                        End If

                        proc.StartInfo.UseShellExecute = True
                        proc.StartInfo.WorkingDirectory = workingDirectory

                        If startMinimized Then
                            proc.StartInfo.WindowStyle = ProcessWindowStyle.Minimized
                        ElseIf startMaximized Then
                            proc.StartInfo.WindowStyle = ProcessWindowStyle.Maximized
                        ElseIf startHidden Then
                            proc.StartInfo.UseShellExecute = False
                            proc.StartInfo.CreateNoWindow = True
                        End If

                        If asAdmin Then
                            proc.StartInfo.Verb = "runas"
                        End If

                        proc.Start()
                    End Using
                Catch ex As Exception
                    Msg(ex.Message, MessageBoxIcon.Error)
                    Show()
                    tbName.Text = item.Name
                    tbName.SelectAll()
                End Try
            End If
        End If
    End Sub

    Function InputBox(text As String, Optional value As String = "") As String
        Using form As New InputBoxForm()
            form.lPrompt.Text = text
            form.tbInput.Text = value

            If form.ShowDialog() = DialogResult.OK Then
                Return form.tbInput.Text
            End If
        End Using
    End Function

    Sub MainForm_DragEnter(sender As Object, e As DragEventArgs) Handles MyBase.DragEnter
        e.Effect = DragDropEffects.Copy
    End Sub

    Sub MainForm_DragDrop(sender As Object, e As DragEventArgs) Handles MyBase.DragDrop
        If Not e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Exit Sub
        End If

        Dim files = DirectCast(e.Data.GetData(DataFormats.FileDrop), String())
        Dim filePath = files(0)

        If filePath.ToLower.EndsWith(".lnk") Then
            Dim testPath = Shortcut.GetTargetPath(filePath)

            If File.Exists(testPath) Then
                filePath = testPath
            End If
        End If

        Dim name = Path.GetFileNameWithoutExtension(files(0))

        If Directory.Exists(filePath) Then
            name += " Folder"
        End If

        name = InputBox("Enter a name.", name)

        If name <> "" Then
            Dim item = New Item(name, filePath)
            Items.Add(item)
            tbName.Text = name
            tbName.SelectAll()
            lbItems.SelectedItem = item
            ActiveControl = tbName
        End If
    End Sub

    Sub lbItems_DoubleClick(sender As Object, e As System.EventArgs) Handles lbItems.DoubleClick
        Launch(False, False)
    End Sub

    Sub lbItems_KeyDown(sender As Object, e As KeyEventArgs) Handles lbItems.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                Launch(False, False)
            Case Keys.Control Or Keys.Enter
                Launch(False, True)
            Case Keys.Shift Or Keys.Enter
                Launch(True, False)
            Case Keys.Delete
                DeleteSelectedItem()
        End Select
    End Sub

    Sub lbItems_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbItems.SelectedIndexChanged
        If lbItems.SelectedIndex > -1 Then
            Dim item = CType(lbItems.SelectedItem, Item)
            BlockTextChanged = True
            rtb.Text = item.Value
            BlockTextChanged = False
            DisableEditMode()
        Else
            rtb.Text = ""
        End If
    End Sub

    Sub RenameSelectedItem()
        Dim item = TryCast(lbItems.SelectedItem, Item)

        If Not item Is Nothing Then
            Dim name = InputBox("Enter a name.", item.Name)

            If name <> "" Then
                item.Name = name
                Items.Sort()
                tbName_TextChanged()

                If lbItems.Items.Contains(item) Then
                    lbItems.SelectedItem = item
                End If
            End If
        End If
    End Sub

    Sub SearchAndReplace()
        Using form As New ReplaceForm
            If form.ShowDialog(Me) = DialogResult.OK Then
                If form.tbSearch.Text <> "" Then
                    For Each i In Items
                        If i.Value.Contains(form.tbSearch.Text) Then
                            If Msg(i.Name + BR2 + i.Value, MessageBoxIcon.Question, MessageBoxButtons.OKCancel) = DialogResult.OK Then
                                i.Value = i.Value.Replace(form.tbSearch.Text, form.tbReplace.Text)
                            Else
                                If Msg("Cancel all?",
                                       MessageBoxIcon.Question,
                                       MessageBoxButtons.YesNo) = DialogResult.Yes Then

                                    Exit For
                                End If
                            End If
                        End If
                    Next
                End If

                tbName_TextChanged()
                ActiveControl = tbName
                tbName.SelectAll()
            End If
        End Using
    End Sub

    Sub HideForm()
        ActiveControl = tbName
        tbName.Text = ""
        Application.DoEvents()
        Hide()
        SaveItems()
    End Sub

    Protected Overrides Sub WndProc(ByRef m As Message)
        Select Case m.Msg
            Case &H312 'WM_HOTKEY
                If m.WParam.ToInt64() = 0 Then
                    ShowWindow()
                End If
        End Select

        MyBase.WndProc(m)
    End Sub

    Sub ShowWindow()
        Dim wa = Screen.FromControl(Me).WorkingArea
        Left = (wa.Width - Width) \ 2
        Top = (wa.Height - Height) \ 2
        Show()
        Activate()
    End Sub

    Sub MainForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Dim workingArea = Screen.FromControl(Me).WorkingArea

        Select Case e.KeyData
            Case Keys.F1
                miHelp.PerformClick()
            Case Keys.F2
                RenameSelectedItem()
            Case Keys.F4
                If rtb.ReadOnly AndAlso lbItems.SelectedIndex > -1 Then
                    EnableEditMode()
                    ActiveControl = rtb
                Else
                    DisableEditMode()
                End If
            Case Keys.F6, Keys.F3
                ActiveControl = tbName
            Case Keys.Escape
                LastSearch = tbName.Text
                SupressAnnoyingSound = True
                HideForm()
            Case Keys.Alt Or Keys.Enter
                e.Handled = True
                SupressAnnoyingSound = True
                Clipboard.SetText(rtb.Text)
                HideForm()
            Case Keys.Control Or Keys.Shift Or Keys.A
                miAbout.PerformClick()
            Case Keys.Control Or Keys.N
                SupressAnnoyingSound = True
                AddNew()
            Case Keys.Control Or Keys.Delete
                DeleteSelectedItem()
            Case Keys.Control Or Keys.H, Keys.Control Or Keys.R
                SearchAndReplace()
            Case Keys.Control Or Keys.Shift Or Keys.Left
                Left = 0
            Case Keys.Control Or Keys.Shift Or Keys.Right
                Left = workingArea.Width - Width
            Case Keys.Control Or Keys.Shift Or Keys.Up
                Top = 0
            Case Keys.Control Or Keys.Shift Or Keys.Down
                Top = workingArea.Height - Height
            Case Keys.Control Or Keys.Shift Or Keys.A
                miShowAll.PerformClick()
            Case Keys.Control Or Keys.D1, Keys.Control Or Keys.NumPad1
                miPriorityHigh.PerformClick()
            Case Keys.Control Or Keys.D2, Keys.Control Or Keys.NumPad2
                miPriorityMedium.PerformClick()
            Case Keys.Control Or Keys.D3, Keys.Control Or Keys.NumPad3
                miPriorityLow.PerformClick()
        End Select
    End Sub

    Sub tbName_Enter(sender As Object, e As EventArgs) Handles tbName.Enter
        tbName.SelectAll()
    End Sub

    Sub tbName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbName.KeyPress
        If SupressAnnoyingSound Then
            e.Handled = True
            SupressAnnoyingSound = False
        End If
    End Sub

    Private SupressAnnoyingSound As Boolean

    Sub tbName_KeyDown(sender As Object, e As KeyEventArgs) Handles tbName.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                e.Handled = True
                SupressAnnoyingSound = True
                Launch(False, False)
            Case Keys.Control Or Keys.Enter
                e.Handled = True
                SupressAnnoyingSound = True
                Launch(False, True)
            Case Keys.Shift Or Keys.Enter
                e.Handled = True
                Launch(True, False)
            Case Keys.Up
                If tbName.Text = "" Then
                    tbName.Text = LastSearch
                Else
                    e.Handled = True

                    If lbItems.SelectedIndex > 0 Then
                        lbItems.SelectedIndex -= 1
                    End If
                End If
            Case Keys.Down
                e.Handled = True

                If lbItems.SelectedIndex < lbItems.Items.Count - 1 Then
                    lbItems.SelectedIndex += 1
                End If
            Case Keys.PageUp
                If lbItems.Items.Count > 0 Then
                    lbItems.SelectedIndex = 0
                End If
            Case Keys.PageDown
                If lbItems.Items.Count > 0 Then
                    lbItems.SelectedIndex = lbItems.Items.Count - 1
                End If
        End Select
    End Sub

    Function GetArgs(value As String) As String
        If value = "" OrElse value.Length <= 2 Then
            Return Nothing
        End If

        Return value.Substring(2)
    End Function

    Sub tbName_MouseDown(sender As Object, e As MouseEventArgs) Handles tbName.MouseDown
        tbName.SelectAll()
    End Sub

    Sub tbName_TextChanged() Handles tbName.TextChanged
        lbItems.Items.Clear()

        DisableEditMode()

        Dim input = tbName.Text
        Dim inputLower = input.ToLower

        If input = "" Then
            rtb.Text = ""
            Exit Sub
        End If

        Dim priorities = {
            Priority.SuperHigh,
            Priority.VeryHigh,
            Priority.Higher,
            Priority.High,
            Priority.Medium,
            Priority.Low,
            Priority.Lower,
            Priority.VeryLow,
            Priority.SuperLow
        }

        For Each prio In priorities
            For Each item In Items
                If item.Priority = prio Then
                    If input = "all:" OrElse item.Name.ToLower().StartsWith(inputLower) Then
                        Add(item)
                    End If
                End If
            Next
        Next

        Dim tokens = input.Split(" "c)

        'search all tokens in name

        If tokens.Length > 1 Then
            For Each prio In priorities
                For Each item In Items
                    If item.Priority = prio Then
                        Dim notFound = False

                        For Each token In tokens
                            If Not item.Name.ToLower.Contains(token.ToLower) Then
                                notFound = True
                                Exit For
                            End If
                        Next

                        If notFound Then
                            Continue For
                        Else
                            Add(item)
                        End If
                    End If
                Next
            Next
        End If

        'search all tokens in value
        If tokens.Length > 1 Then
            For Each prio In priorities
                For Each item In Items
                    If item.Priority = prio Then
                        Dim notFound = False

                        For Each token In tokens
                            If Not item.Value.ToLower.Contains(token.ToLower) Then
                                notFound = True
                                Exit For
                            End If
                        Next

                        If notFound Then
                            Continue For
                        Else
                            Add(item)
                        End If
                    End If
                Next
            Next
        End If

        'upper chars
        For Each prio In priorities
            For Each item In Items
                If item.Priority = prio Then
                    If lbItems.Items.Contains(item) Then
                        Continue For
                    End If

                    Dim upperChars = ""

                    For Each ch In item.Name
                        If Char.IsUpper(ch) Then
                            upperChars += ch
                        End If
                    Next

                    If upperChars.ToLower.StartsWith(inputLower) Then
                        Add(item)
                    End If
                End If
            Next
        Next

        'name starts
        For Each prio In priorities
            For Each item In Items
                If item.Priority = prio Then
                    If lbItems.Items.Contains(item) Then
                        Continue For
                    End If

                    If item.Name.ToLower().StartsWith(inputLower) Then
                        Add(item)
                    End If
                End If
            Next
        Next

        'name contains
        For Each prio In priorities
            For Each item In Items
                If item.Priority = prio Then
                    If lbItems.Items.Contains(item) Then
                        Continue For
                    End If

                    If item.Name.ToLower().Contains(inputLower) Then
                        Add(item)
                    End If
                End If
            Next
        Next

        'value contains
        For Each prio In priorities
            For Each item In Items
                If item.Priority = prio Then
                    If lbItems.Items.Contains(item) Then
                        Continue For
                    End If

                    If item.Value.ToLower().Contains(inputLower) Then
                        Add(item)
                    End If
                End If
            Next
        Next

        If lbItems.Items.Count > 0 Then
            lbItems.SelectedIndex = 0
        Else
            rtb.Text = ""
        End If
    End Sub

    Sub Add(item As Item)
        If Not lbItems.Items.Contains(item) Then
            lbItems.Items.Add(item)
        End If
    End Sub

    Function Match(item As Item, value As String) As Boolean
        Return item.Value <> "" AndAlso item.Value.ToUpper().Contains(
            value.ToUpper()) OrElse item.Name.ToUpper().Contains(value.ToUpper())
    End Function

    Sub MainForm_DoubleClick(sender As Object, e As EventArgs) Handles MyBase.DoubleClick
        If WindowState = FormWindowState.Maximized Then
            WindowState = FormWindowState.Normal
        Else
            WindowState = FormWindowState.Maximized
        End If
    End Sub

    Sub MainForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        UnregisterHotKey(Handle, 0)
        SaveItems()
        Application.Exit()
    End Sub

    Sub rtb_TextChanged(sender As Object, e As EventArgs) Handles rtb.TextChanged
        If Not BlockTextChanged Then
            Dim i = TryCast(lbItems.SelectedItem, Item)

            If i IsNot Nothing AndAlso i.Value <> rtb.Text Then
                i.Value = rtb.Text
            End If
        End If
    End Sub

    Sub DeleteSelectedItem()
        Dim item = TryCast(lbItems.SelectedItem, Item)

        If Not item Is Nothing AndAlso
            MsgBox.Show("Delete " & item.Name & "?") = DialogResult.OK Then

            Items.Remove(item)
            lbItems.Items.Remove(item)
            g.HasChanged = True
            tbName_TextChanged()
        End If
    End Sub

    Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles miCut.Click
        rtb.Cut()
    End Sub

    Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles miCopy.Click
        Clipboard.SetText(rtb.SelectedText)
    End Sub

    Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles miPaste.Click
        rtb.SelectedText = Clipboard.GetText
    End Sub

    Sub RenameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles miRename.Click
        RenameSelectedItem()
    End Sub

    Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles miDelete.Click
        DeleteSelectedItem()
    End Sub

    Sub cmsRTB_Opening(sender As Object, e As CancelEventArgs) Handles cmsRTB.Opening
        miCut.Enabled = Not rtb.ReadOnly
        miCopy.Enabled = rtb.Text <> ""
        miPaste.Enabled = Not rtb.ReadOnly AndAlso Clipboard.GetText <> ""
    End Sub

    Sub cmsLB_Opening(sender As Object, e As CancelEventArgs) Handles cmsLB.Opening
        miRename.Enabled = lbItems.SelectedItem IsNot Nothing
        miDelete.Enabled = lbItems.SelectedItem IsNot Nothing
        miEdit.Enabled = lbItems.SelectedItem IsNot Nothing
        miPriority.Enabled = lbItems.SelectedItem IsNot Nothing

        Dim item = TryCast(lbItems.SelectedItem, Item)

        If Not item Is Nothing Then
            miPrioritySuperLow.Checked = item.Priority = Priority.SuperLow
            miPriorityVeryLow.Checked = item.Priority = Priority.VeryLow
            miPriorityLower.Checked = item.Priority = Priority.Lower
            miPriorityLow.Checked = item.Priority = Priority.Low
            miPriorityMedium.Checked = item.Priority = Priority.Medium
            miPriorityHigh.Checked = item.Priority = Priority.High
            miPriorityHigher.Checked = item.Priority = Priority.Higher
            miPriorityVeryHigh.Checked = item.Priority = Priority.VeryHigh
            miPrioritySuperHigh.Checked = item.Priority = Priority.SuperHigh

            miNoneAction.Checked = item.ActionMode = ActionMode.None
            miCommandLineAction.Checked = item.ActionMode = ActionMode.CommandLine
            miPasteAction.Checked = item.ActionMode = ActionMode.Paste
        End If

        SetShortcutKeyDisplayString(miAbout, "Ctrl+Shift+A")
        SetShortcutKeyDisplayString(miClearHide, "ESC")
        SetShortcutKeyDisplayString(miCommandLineAction, "Ctrl+Shift+C")
        SetShortcutKeyDisplayString(miDelete, "Ctrl+Del")
        SetShortcutKeyDisplayString(miEdit, "F4")
        SetShortcutKeyDisplayString(miExit, "Alt+F4")
        SetShortcutKeyDisplayString(miHelp, "F1")
        SetShortcutKeyDisplayString(miMoveWindowBottom, "Ctrl+Shift+Bottom")
        SetShortcutKeyDisplayString(miMoveWindowLeft, "Ctrl+Shift+Left")
        SetShortcutKeyDisplayString(miMoveWindowRight, "Ctrl+Shift+Right")
        SetShortcutKeyDisplayString(miMoveWindowTop, "Ctrl+Shift+Top")
        SetShortcutKeyDisplayString(miNew, "Ctrl+N")
        SetShortcutKeyDisplayString(miNoneAction, "Ctrl+Shift+N")
        SetShortcutKeyDisplayString(miPasteAction, "Ctrl+Shift+P")
        SetShortcutKeyDisplayString(miPriorityHigh, "Ctrl+1")
        SetShortcutKeyDisplayString(miPriorityLow, "Ctrl+3")
        SetShortcutKeyDisplayString(miPriorityMedium, "Ctrl+2")
        SetShortcutKeyDisplayString(miRename, "F2")
        SetShortcutKeyDisplayString(miSearch, "F6")
        SetShortcutKeyDisplayString(miSearchAndReplace, "Ctrl+H")
    End Sub

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)

        TextBackColor = Color.FromArgb(&H30, &H30, &H30)
        TextForeColor = Color.White
        BackColor = Color.FromArgb(&H50, &H50, &H50)

        rtb.BackColor = TextBackColor
        rtb.ForeColor = TextForeColor

        tbName.BackColor = TextBackColor
        tbName.ForeColor = TextForeColor
        tlpName.BackColor = TextBackColor

        lbItems.BackColor = TextBackColor
        lbItems.ForeColor = TextForeColor
        lbItems.SelectionColor = BackColor

        Dim borderWidth = CInt(FontHeight / 3)
        Dim smallBorderWidth = CInt(FontHeight / 4)
        tbName.Margin = New Padding(0, smallBorderWidth, 0, smallBorderWidth)
        tlpName.Margin = New Padding(borderWidth)
        tlpItems.Margin = New Padding(borderWidth)
        tlpRTB.Margin = New Padding(0, borderWidth, borderWidth, borderWidth)
        tlpName.Margin = New Padding(borderWidth, borderWidth, borderWidth, 0)
    End Sub

    Sub EnableEditMode()
        rtb.ReadOnly = False
        rtb.BackColor = BackColor
        rtb.EnableAutoDragDrop = True
    End Sub

    Sub DisableEditMode()
        rtb.ReadOnly = True
        rtb.BackColor = TextBackColor
        rtb.EnableAutoDragDrop = False
    End Sub

    Sub miNew_Click(sender As Object, e As EventArgs) Handles miNew.Click
        AddNew()
    End Sub

    Sub AddNew()
        Dim name = InputBox("Enter a name.")

        If name = "" Then
            Exit Sub
        End If

        For Each item In Items
            If item.Name = name Then
                MessageBox.Show(Me, "There is already a item called " & name & ".",
                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
        Next

        Items.Add(New Item(name, ""))
        Items.Sort()
        tbName.Text = name
        tbName_TextChanged()
        ActiveControl = rtb
        EnableEditMode()
    End Sub

    Sub miSearchAndReplace_Click(sender As Object, e As EventArgs) Handles miSearchAndReplace.Click
        SearchAndReplace()
    End Sub

    Sub miShowAll_Click(sender As Object, e As EventArgs) Handles miShowAll.Click
        tbName.Text = "all:"
        tbName.SelectAll()
    End Sub

    Sub SetShortcutKeyDisplayString(mi As MenuItem, value As String)
        mi.ShortcutKeyDisplayString = value + " ".Multiply(CInt(DPI / 96))
    End Sub

    Sub miSearch_Click(sender As Object, e As EventArgs) Handles miSearch.Click
        ActiveControl = tbName
        tbName.SelectAll()
    End Sub

    Sub miAbout_Click(sender As Object, e As EventArgs) Handles miAbout.Click
        Msg(Application.ProductName + " " + Application.ProductVersion.ToString + BR2 +
            "Copyright (C) 2005-2020 Frank Skare (stax76)" + BR2 + "MIT License")
    End Sub

    <DllImport("gdi32.dll")>
    Shared Function GetDeviceCaps(hdc As IntPtr, nIndex As Integer) As Integer

    End Function
    <DllImport("user32.dll")>
    Shared Function RegisterHotKey(hWnd As IntPtr, id As Integer, fsModifiers As UInteger, vk As UInteger) As Boolean
    End Function

    <DllImport("user32.dll")>
    Shared Function UnregisterHotKey(hWnd As IntPtr, id As Integer) As Boolean
    End Function

    Sub miCommandLineAction_Click(sender As Object, e As EventArgs) Handles miCommandLineAction.Click
        DirectCast(lbItems.SelectedItem, Item).ActionMode = ActionMode.CommandLine
    End Sub

    Sub miPasteAction_Click(sender As Object, e As EventArgs) Handles miPasteAction.Click
        DirectCast(lbItems.SelectedItem, Item).ActionMode = ActionMode.Paste
    End Sub

    Sub miNoneAction_Click(sender As Object, e As EventArgs) Handles miNoneAction.Click
        DirectCast(lbItems.SelectedItem, Item).ActionMode = ActionMode.None
    End Sub

    Sub miPrioritySuperHigh_Click(sender As Object, e As EventArgs) Handles miPrioritySuperHigh.Click
        DirectCast(lbItems.SelectedItem, Item).Priority = Priority.SuperHigh
    End Sub

    Sub miPriorityVeryHigh_Click(sender As Object, e As EventArgs) Handles miPriorityVeryHigh.Click
        DirectCast(lbItems.SelectedItem, Item).Priority = Priority.VeryHigh
    End Sub

    Sub miPriorityHigher_Click(sender As Object, e As EventArgs) Handles miPriorityHigher.Click
        DirectCast(lbItems.SelectedItem, Item).Priority = Priority.Higher
    End Sub

    Sub miPriorityHigh_Click(sender As Object, e As EventArgs) Handles miPriorityHigh.Click
        DirectCast(lbItems.SelectedItem, Item).Priority = Priority.High
    End Sub

    Sub miPriorityMedium_Click(sender As Object, e As EventArgs) Handles miPriorityMedium.Click
        DirectCast(lbItems.SelectedItem, Item).Priority = Priority.Medium
    End Sub

    Sub miPriorityLow_Click(sender As Object, e As EventArgs) Handles miPriorityLow.Click
        DirectCast(lbItems.SelectedItem, Item).Priority = Priority.Low
    End Sub

    Sub miPriorityLower_Click(sender As Object, e As EventArgs) Handles miPriorityLower.Click
        DirectCast(lbItems.SelectedItem, Item).Priority = Priority.Lower
    End Sub

    Sub miPriorityVeryLow_Click(sender As Object, e As EventArgs) Handles miPriorityVeryLow.Click
        DirectCast(lbItems.SelectedItem, Item).Priority = Priority.VeryLow
    End Sub

    Sub miPrioritySuperLow_Click(sender As Object, e As EventArgs) Handles miPrioritySuperLow.Click
        DirectCast(lbItems.SelectedItem, Item).Priority = Priority.SuperLow
    End Sub

    Sub miExit_Click(sender As Object, e As EventArgs) Handles miExit.Click
        Close()
    End Sub

    Sub miHelp_Click(sender As Object, e As EventArgs) Handles miHelp.Click
        HideForm()
        Process.Start("https://github.com/stax76/KeyLauncher")
    End Sub

    Sub rtb_KeyDown(sender As Object, e As KeyEventArgs) Handles rtb.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.V Then
            rtb.Paste(DataFormats.GetFormat("Text"))
            e.Handled = True
        End If
    End Sub
End Class
