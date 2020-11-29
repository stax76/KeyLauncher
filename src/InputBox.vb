
Public Class InputBox
    Property Text As String
    Property Title As String = Application.ProductName
    Property Value As String
    Property Owner As IWin32Window

    Shared Function Show(text As String) As String
        Return Show(text, Application.ProductName)
    End Function

    Shared Function Show(text As String, title As String) As String
        Return Show(text, title, "")
    End Function

    Shared Function Show(text As String, title As String, value As String) As String
        Dim b As New InputBox
        b.Text = text
        b.Title = title
        b.Value = value

        If b.Show = DialogResult.OK Then
            Return b.Value
        Else
            Return Nothing
        End If
    End Function

    Function Show() As DialogResult
        Using form As New InputBoxForm
            form.lPrompt.Text = Text
            form.tbInput.Text = Value
            form.Text = Title

            If Process.GetCurrentProcess.MainWindowHandle = IntPtr.Zero Then
                form.StartPosition = FormStartPosition.CenterScreen
            End If

            Dim ret As DialogResult

            If Not Owner Is Nothing Then
                ret = form.ShowDialog(Owner)
            Else
                ret = form.ShowDialog()
            End If

            Value = form.tbInput.Text

            Return ret
        End Using
    End Function
End Class