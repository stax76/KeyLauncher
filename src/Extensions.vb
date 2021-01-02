
Imports System.Runtime.CompilerServices
Imports System.Text

Module StringExtensions
    <Extension()>
    Function Split(value As String, ParamArray delimiters As String()) As String()
        Dim strings = value.Split(delimiters, StringSplitOptions.RemoveEmptyEntries)
        Dim emptyFound As Boolean

        For Each str In strings
            If str = "" Then
                emptyFound = True
            End If
        Next

        If emptyFound Then
            Dim strings2 As New List(Of String)

            For Each str In strings
                If str <> "" Then
                    strings2.Add(str)
                End If
            Next

            strings = strings2.ToArray
        End If

        Return strings
    End Function

    <Extension()>
    Function SplitKeepEmpty(value As String, ParamArray delimiters As String()) As String()
        Return value.Split(delimiters, StringSplitOptions.None)
    End Function

    <Extension>
    Function Multiply(instance As String, multiplier As Integer) As String
        If multiplier < 1 Then
            multiplier = 1
        End If

        Dim sb As New StringBuilder(multiplier * instance.Length)

        For i = 0 To multiplier - 1
            sb.Append(instance)
        Next

        Return sb.ToString()
    End Function
End Module

Module MiscExtensions
    <Extension()>
    Function Join(value As IEnumerable(Of String), delimiter As String) As String
        Return String.Join(delimiter, value.ToArray)
    End Function
End Module
