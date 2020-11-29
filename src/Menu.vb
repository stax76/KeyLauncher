
Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports System.Drawing.Text

Public Class ContextMenuStripEx
    Inherits ContextMenuStrip

    Public Sub New()
    End Sub

    Sub New(container As IContainer)
        MyBase.New(container)
    End Sub

    Function Add(path As String) As MenuItem
        Return Add(path, Nothing)
    End Function

    Function Add(path As String, action As Action, Optional enabled As Boolean = True) As MenuItem
        Dim ret = MenuItem.Add(Items, path, action)

        If ret Is Nothing Then
            Return Nothing
        End If

        ret.Enabled = enabled
        Return ret
    End Function
End Class

Public Class MenuItem
    Inherits ToolStripMenuItem

    Property Action As Action

    Sub New()
    End Sub

    Sub New(text As String)
        MyBase.New(text)
    End Sub

    Sub New(text As String, action As Action)
        MyBase.New(text)
        Me.Action = action
    End Sub

    Protected Overrides Sub OnClick(e As EventArgs)
        Application.DoEvents()
        Action?.Invoke()
        MyBase.OnClick(e)
    End Sub

    Shared Function Add(items As ToolStripItemCollection, path As String, action As Action) As MenuItem
        Dim a = path.Split({" > ", " | "}, StringSplitOptions.RemoveEmptyEntries)
        Dim itemsCollection = items

        For x = 0 To a.Length - 1
            Dim found = False

            For Each i In itemsCollection.OfType(Of ToolStripMenuItem)()
                If x < a.Length - 1 Then
                    If i.Text = a(x) & "    " Then
                        found = True
                        itemsCollection = i.DropDownItems
                    End If
                End If
            Next

            If Not found Then
                If x = a.Length - 1 Then
                    If a(x) = "-" Then
                        itemsCollection.Add(New ToolStripSeparator())
                    Else
                        Dim item As MenuItem = New MenuItem(a(x) & "    ", action)
                        itemsCollection.Add(item)
                        itemsCollection = item.DropDownItems
                        Return item
                    End If
                Else
                    Dim item As MenuItem = New MenuItem()
                    item.Text = a(x) & "    "
                    itemsCollection.Add(item)
                    itemsCollection = item.DropDownItems
                End If
            End If
        Next

        Return Nothing
    End Function

    Overrides Function GetPreferredSize(constrainingSize As Size) As Size
        Dim size = MyBase.GetPreferredSize(constrainingSize)
        size.Height = Convert.ToInt32(Font.Height * 1.4)
        Return size
    End Function

    Sub CloseAll(item As Object)
        If TypeOf item Is ToolStripItem Then
            CloseAll((CType(item, ToolStripItem)).Owner)
        End If

        If TypeOf item Is ToolStripDropDown Then
            Dim d = CType(item, ToolStripDropDown)
            d.Close()
            CloseAll(d.OwnerItem)
        End If
    End Sub
End Class

Public Class ToolStripRendererEx
    Inherits ToolStripSystemRenderer

    Shared Property ColorForeground As Color = Color.Black
    Shared Property ColorTheme As Color
    Shared Property ColorChecked As Color
    Shared Property ColorBorder As Color
    Shared Property ColorTop As Color
    Shared Property ColorSelection As Color
    Shared Property ColorBackground As Color

    Private TextOffset As Integer

    Public Shared Sub InitColors(themeColor As Color, darkMode As Boolean, themed As Boolean)
        If darkMode Then
            ColorBorder = Color.White
            ColorBackground = Color.FromArgb(50, 50, 50)
            ColorSelection = Color.FromArgb(80, 80, 80)

            If themed Then
                ColorForeground = themeColor
            Else
                ColorForeground = Color.White
            End If

            ColorChecked = Color.FromArgb(90, 90, 90)
        Else
            If Not themed Then
                themeColor = Color.FromArgb(238, 238, 238)
            End If

            ColorBorder = HSLColor.Convert(themeColor).ToColorSetLuminosity(180)
            ColorChecked = HSLColor.Convert(themeColor).ToColorSetLuminosity(160)
            ColorSelection = HSLColor.Convert(themeColor).ToColorSetLuminosity(180)
            ColorBackground = HSLColor.Convert(themeColor).ToColorSetLuminosity(230)
            ColorTop = HSLColor.Convert(themeColor).ToColorSetLuminosity(240)
        End If
    End Sub

    Protected Overrides Sub OnRenderToolStripBorder(e As ToolStripRenderEventArgs)
        Dim r = e.AffectedBounds
        r.Inflate(-1, -1)
        ControlPaint.DrawBorder(e.Graphics, r, ColorBackground, ButtonBorderStyle.Solid)
        ControlPaint.DrawBorder(e.Graphics, e.AffectedBounds, ColorBorder, ButtonBorderStyle.Solid)
    End Sub

    Protected Overrides Sub OnRenderItemText(e As ToolStripItemTextRenderEventArgs)
        e.Graphics.TextRenderingHint = TextRenderingHint.AntiAlias

        If TypeOf e.Item Is ToolStripMenuItem AndAlso Not (TypeOf e.Item.Owner Is MenuStrip) Then
            Dim rect = e.TextRectangle
            Dim dropDown = TryCast(e.ToolStrip, ToolStripDropDownMenu)

            If dropDown Is Nothing OrElse dropDown.ShowImageMargin OrElse dropDown.ShowCheckMargin Then
                TextOffset = Convert.ToInt32(e.Item.Height * 1.1)
            Else
                TextOffset = Convert.ToInt32(e.Item.Height * 0.2)
            End If

            e.TextColor = ColorForeground
            e.TextRectangle = New Rectangle(TextOffset, Convert.ToInt32((e.Item.Height - rect.Height) / 2.0), rect.Width, rect.Height)
        End If

        MyBase.OnRenderItemText(e)
    End Sub

    Protected Overrides Sub OnRenderMenuItemBackground(e As ToolStripItemRenderEventArgs)
        Dim rect = New Rectangle(Point.Empty, e.Item.Size)

        If Not (TypeOf e.Item.Owner Is MenuStrip) Then
            e.Graphics.Clear(ColorBackground)
        End If

        If e.Item.Selected AndAlso e.Item.Enabled Then
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
            rect = New Rectangle(rect.X + 2, rect.Y, rect.Width - 4, rect.Height - 1)
            rect.Inflate(-1, -1)

            Using brush = New SolidBrush(ColorSelection)
                e.Graphics.FillRectangle(brush, rect)
            End Using
        End If
    End Sub

    Protected Overrides Sub OnRenderArrow(e As ToolStripArrowRenderEventArgs)
        If e.Direction = ArrowDirection.Down Then
            Throw New NotImplementedException()
        End If

        If Not e.Item.Enabled Then
            Exit Sub
        End If

        Dim x1 = e.Item.Width - e.Item.Height * 0.6F
        Dim y1 = e.Item.Height * 0.25F
        Dim x2 = x1 + e.Item.Height * 0.25F
        Dim y2 = e.Item.Height / 2.0F
        Dim x3 = x1
        Dim y3 = e.Item.Height * 0.75F

        e.Graphics.SmoothingMode = SmoothingMode.HighQuality

        Using brush = New SolidBrush(ColorForeground)
            Using pen = New Pen(brush, Control.DefaultFont.Height / 20.0F)
                e.Graphics.DrawLine(pen, x1, y1, x2, y2)
                e.Graphics.DrawLine(pen, x2, y2, x3, y3)
            End Using
        End Using
    End Sub

    Protected Overrides Sub OnRenderItemCheck(e As ToolStripItemImageRenderEventArgs)
        If e.Item.GetType() <> GetType(MenuItem) Then
            Return
        End If

        Dim item = TryCast(e.Item, MenuItem)
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias

        If Not item.Checked Then
            Return
        End If

        Dim rect = New Rectangle(Point.Empty, e.Item.Size)
        rect = New Rectangle(rect.X + 2, rect.Y, rect.Height - 1, rect.Height - 1)
        rect.Inflate(-1, -1)

        Using brush As Brush = New SolidBrush(ColorChecked)
            e.Graphics.FillRectangle(brush, rect)
        End Using

        Dim ellipseWidth As Single = rect.Height / 3.0F
        Dim rectF As RectangleF = New RectangleF(rect.X + rect.Height / 2.0F - ellipseWidth / 2.0F, rect.Y + rect.Height / 2.0F - ellipseWidth / 2.0F, ellipseWidth, ellipseWidth)

        Using brush As Brush = New SolidBrush(ColorForeground)
            e.Graphics.FillEllipse(brush, rectF)
        End Using
    End Sub

    Protected Overrides Sub OnRenderSeparator(e As ToolStripSeparatorRenderEventArgs)
        e.Graphics.Clear(ColorBackground)
        Dim top = e.Item.Height / 2
        top -= 1
        Dim offset = Convert.ToInt32(e.Item.Font.Height * 0.7)

        Using p As Pen = New Pen(ColorBorder)
            e.Graphics.DrawLine(p, New Point(offset, CInt(top)), New Point(e.Item.Width - offset, CInt(top)))
        End Using
    End Sub
End Class

Public Structure HSLColor
    Public Sub New(color As Color)
        Me.New()
        SetRGB(color.R, color.G, color.B)
    End Sub

    Public Sub New(h As Integer, s As Integer, l As Integer)
        Me.New()
        Hue = h
        Saturation = s
        Luminosity = l
    End Sub

    Private _Hue As Double

    Property Hue As Integer
        Get
            Return System.Convert.ToInt32(_Hue * 240)
        End Get
        Set(value As Integer)
            _Hue = CheckRange(value / 240.0)
        End Set
    End Property

    Private _Saturation As Double

    Property Saturation As Integer
        Get
            Return System.Convert.ToInt32(_Saturation * 240)
        End Get
        Set(value As Integer)
            _Saturation = CheckRange(value / 240.0)
        End Set
    End Property

    Private _Luminosity As Double

    Property Luminosity As Integer
        Get
            Return System.Convert.ToInt32(_Luminosity * 240)
        End Get
        Set(value As Integer)
            _Luminosity = CheckRange(value / 240.0)
        End Set
    End Property

    Function CheckRange(value As Double) As Double
        If value < 0 Then
            value = 0
        ElseIf value > 1 Then
            value = 1
        End If

        Return value
    End Function

    Function ToColorAddLuminosity(luminosity As Integer) As Color
        Me.Luminosity += luminosity
        Return ToColor()
    End Function

    Function ToColorSetLuminosity(luminosity As Integer) As Color
        Me.Luminosity = luminosity
        Return ToColor()
    End Function

    Function ToColor() As Color
        Dim r As Double
        Dim g As Double
        Dim b As Double

        If _Luminosity <> 0 Then
            If _Saturation = 0 Then
                b = _Luminosity
                g = _Luminosity
                r = _Luminosity
            Else
                Dim temp2 = GetTemp2(Me)
                Dim temp1 = 2.0 * _Luminosity - temp2
                r = GetColorComponent(temp1, temp2, _Hue + 1.0 / 3.0)
                g = GetColorComponent(temp1, temp2, _Hue)
                b = GetColorComponent(temp1, temp2, _Hue - 1.0 / 3.0)
            End If
        End If

        Return Color.FromArgb(System.Convert.ToInt32(255 * r), System.Convert.ToInt32(255 * g), System.Convert.ToInt32(255 * b))
    End Function

    Shared Function GetColorComponent(temp1 As Double, temp2 As Double, temp3 As Double) As Double
        temp3 = MoveIntoRange(temp3)

        If temp3 < 1 / 6.0 Then
            Return temp1 + (temp2 - temp1) * 6.0 * temp3
        ElseIf temp3 < 0.5 Then
            Return temp2
        ElseIf temp3 < 2 / 3.0 Then
            Return temp1 + ((temp2 - temp1) * (2 / 3.0 - temp3) * 6)
        Else
            Return temp1
        End If
    End Function

    Shared Function MoveIntoRange(temp3 As Double) As Double
        If temp3 < 0 Then
            temp3 += 1
        ElseIf temp3 > 1 Then
            temp3 -= 1
        End If

        Return temp3
    End Function

    Shared Function GetTemp2(hslColor As HSLColor) As Double
        Dim temp2 As Double

        If hslColor._Luminosity < 0.5 Then
            temp2 = hslColor._Luminosity * (1.0 + hslColor._Saturation)
        Else
            temp2 = hslColor._Luminosity + hslColor._Saturation - (hslColor._Luminosity * hslColor._Saturation)
        End If

        Return temp2
    End Function

    Shared Function Convert(c As Color) As HSLColor
        Dim ret = New HSLColor()
        ret._Hue = c.GetHue() / 360.0
        ret._Luminosity = c.GetBrightness()
        ret._Saturation = c.GetSaturation()
        Return ret
    End Function

    Public Sub SetRGB(red As Integer, green As Integer, blue As Integer)
        Dim hc = HSLColor.Convert(Color.FromArgb(red, green, blue))
        _Hue = hc._Hue
        _Saturation = hc._Saturation
        _Luminosity = hc._Luminosity
    End Sub
End Structure
