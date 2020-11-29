
Imports System.ComponentModel
Imports VB6 = Microsoft.VisualBasic

Public Class g
    Private Shared HasChangedValue As Boolean

    Shared Property HasChanged() As Boolean
        Get
            Return HasChangedValue
        End Get
        Set(value As Boolean)
            HasChangedValue = value
        End Set
    End Property

    Public Shared Sub HandleException(ex As Exception)
        Msg(ex.ToString(), MessageBoxIcon.Error)
    End Sub
End Class

Module MainModule
    Public Const BR As String = VB6.vbCrLf
    Public Const BR2 As String = VB6.vbCrLf + VB6.vbCrLf

    Sub Msg(text As Object)
        Msg(text.ToString, MessageBoxIcon.Information)
    End Sub

    Sub Msg(text As String, icon As MessageBoxIcon)
        Msg(text, Application.ProductName, icon)
    End Sub

    Function Msg(text As String,
                 icon As MessageBoxIcon,
                 buttons As MessageBoxButtons) As DialogResult

        Return Msg(text, Application.ProductName, icon, buttons)
    End Function

    Function Msg(text As String,
                 title As String,
                 icon As MessageBoxIcon) As DialogResult

        Return Msg(text, title, icon, MessageBoxButtons.OK)
    End Function

    Function Msg(text As String,
                 title As String,
                 icon As MessageBoxIcon,
                 buttons As MessageBoxButtons) As DialogResult

        Return MessageBox.Show(text, title, buttons, icon)
    End Function
End Module

<Serializable()>
Public Class Item
    Implements IComparable(Of Item)

    Sub New()
    End Sub

    Sub New(name As String, val As String)
        Me.Name = name
        Value = val
    End Sub

    Private NameValue As String

    Property Name() As String
        Get
            If NameValue Is Nothing Then
                NameValue = ""
            End If

            Return NameValue
        End Get
        Set(value As String)
            If value Is Nothing Then
                NameValue = ""
                g.HasChanged = True
            ElseIf value <> NameValue Then
                NameValue = value
                g.HasChanged = True
            End If
        End Set
    End Property

    Private ValueValue As String

    Property Value() As String
        Get
            If ValueValue Is Nothing Then
                ValueValue = ""
            End If

            Return ValueValue
        End Get
        Set(value As String)
            If value Is Nothing Then
                ValueValue = ""
                g.HasChanged = True
            ElseIf value <> ValueValue Then
                ValueValue = value
                g.HasChanged = True
            End If
        End Set
    End Property

    Private PriorityValue As Priority

    <DefaultValue(Priority.Medium)>
    Property Priority As Priority
        Get
            Return PriorityValue
        End Get
        Set(value As Priority)
            If value <> PriorityValue Then
                PriorityValue = value
                g.HasChanged = True
            End If
        End Set
    End Property

    Function CompareTo(item As Item) As Integer Implements IComparable(Of Item).CompareTo
        Return Name.CompareTo(item.Name)
    End Function

    Overrides Function ToString() As String
        Return Name
    End Function
End Class

Public Enum Priority
    Low = -1
    Medium = 0
    High = 1
End Enum
