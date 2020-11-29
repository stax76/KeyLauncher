
Option Strict Off

Imports Microsoft.VisualBasic

Public Class Shortcut
    Shared Function GetTargetPath(path As String) As String
        Return CreateObject("WScript.Shell").CreateShortcut(path).TargetPath
    End Function
End Class
