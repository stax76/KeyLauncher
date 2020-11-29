
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

    <Extension()>
    Function FormatColumn(value As String, delimiter As String,
                          Optional padBehindDelimiter As Boolean = False) As String

        Dim positions As New List(Of Integer)
        Dim lines = value.SplitKeepEmpty(BR)
        Dim modeOffset = If(padBehindDelimiter, delimiter.Length, 0)

        For Each i In lines
            positions.Add(i.IndexOf(delimiter))
        Next

        If positions.Count > 0 Then
            Dim highest = Aggregate i In positions Into Max(i)

            For i = 0 To lines.Length - 1
                If positions(i) <> highest AndAlso positions(i) > -1 Then
                    lines(i) = lines(i).Insert(positions(i) + modeOffset, " ".PadRight(highest - positions(i)))
                End If
            Next
        End If

        Return lines.Join(BR)
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
