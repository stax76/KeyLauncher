
Imports System.Drawing.Text

Public Class ListBoxEx
    Inherits ListBox

    Property SelectionColor As Color

    Public Sub New()
        DrawMode = DrawMode.OwnerDrawFixed
        ItemHeight = CInt(FontHeight * 1.3)
    End Sub

    Protected Overrides Sub OnDrawItem(e As DrawItemEventArgs)
        e.Graphics.TextRenderingHint = TextRenderingHint.AntiAlias

        If Items.Count = 0 OrElse e.Index < 0 Then
            Exit Sub
        End If

        Dim rect = e.Bounds

        If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then
            Dim offset = CInt(FontHeight / 16)
            rect.X += offset
            rect.Y += offset
            rect.Width -= offset * 2
            rect.Height -= offset * 2

            Using brush As New SolidBrush(SelectionColor)
                e.Graphics.FillRectangle(brush, rect)
            End Using
        Else
            Using brush As New SolidBrush(BackColor)
                e.Graphics.FillRectangle(brush, rect)
            End Using
        End If

        Dim format As New StringFormat
        format.FormatFlags = StringFormatFlags.NoWrap
        format.LineAlignment = StringAlignment.Center

        rect = e.Bounds
        rect.X = 2
        rect.Width = e.Bounds.Width

        Using brush = New SolidBrush(ForeColor)
            e.Graphics.DrawString(Items(e.Index).ToString(), Font, brush, rect, format)
        End Using
    End Sub
End Class