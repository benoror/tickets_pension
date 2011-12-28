' Created on 28-4-2004 at 10:22 by Emdek
'
' Class PlainVanillaTextPrinter
'
' Description: Quick & Dirty Plain-Vanilla Textprinting in VB.NET
'
' Features: Automatic page-breaks, pagenumbering, pagebanner and -footer
'			and PrintPreview
'
' ToDo : implement wordwrap, lineprint
'
' Namespaces:
'	System
'	System.Drawing
'	Microsoft.VisualBasic
'
' Properties:
'	Name:			Type:		Description:
'
'	UseBanner		Boolean		Toggle's the use of page-banners
'	Banner		String		Text for banner
'	UseFooter		Boolean		Toggle's the use of page-footer
'	UseBorder		Boolean		Toggle's borderdrawing of banner and footer
'	BannerFont	Font		Fonttype to use to print the banner
'	FooterFont		Font		Fonttype to use to print the footer
'	DataFont		Font		Fonttype to use to print the text
'	LinesPerPage	Integer		Read-only: is calculated during printing
'	TotalPages		Integer		Read-only: is calculated during printing
'	MarginTop		Integer		Margin in points
'	MarginLeft		Integer		Margin in points
'	MarginRight	Integer		Margin in points
'	MarginBottom	Integer		Margin in points
'	TextOffset		Integer		Left margin-offset for text in points
'
' Methods:
'	New			Initiates a new PlainVanillaTextPrinter object
'  	New(ArrayOfStrings)		Initiates a new PlainVanillaTextPrinter object with data added to page for print
'	AddLine(String)		Add String to page to print
'	Preview			Show print-preview
'	Print			Send pages to printer
'	
'Imports System
'Imports Microsoft.VisualBasic
'Imports System.Drawing
'
'Namespace myTest
'
'Module Sample
'Public Sub Main()
'Dim myPrinter As New PlainVanillaTextPrinter
'
'   With myPrinter
'set properties
'        .UseBanner = True
'        .Banner = "Anytext you allways wanted to print from VB.NET"
'        .BannerFont = New Font("Courier New", 12, FontStyle.Regular, GraphicsUnit.Point)
'        .UseFooter = True
'        .MarginTop = 75
'        .MarginBottom = 50
'        .MarginLeft = 100
'        .MarginRight = 100
'        .TextOffset = 50
'Add data
'       .AddLine(" ")
'      .AddLine(" ")
'     .AddLine(" ")
'    .AddLine(" ")
'   .AddLine(" ")
'  .AddLine("You can print this")
'   .AddLine("or you can print that")
'  .AddLine(New String("or you can print this").PadLeft(50))
' .AddLine(New String("way to mimic").PadLeft(50))
'.AddLine(New String("data-columns").PadLeft(50))
'.AddLine(New String("in which case").PadLeft(50))
'.AddLine(New String("you'll have to use").PadLeft(50))
'.AddLine(New String("a non-proportional").PadLeft(50))
'.AddLine(New String("lettertype like Courier").PadLeft(50))
'.AddLine(New String("-").PadLeft(50, "-"))
'.AddLine(New String("Tha month is").PadRight(30, ".") & Now.ToString("y", System.Globalization.DateTimeFormatInfo.InvariantInfo))
'.AddLine(New String("Tha date is").PadRight(30, ".") & Now.ToString("M/dd/yyyy"))
'.AddLine(New String("Tha time is").PadRight(30, ".") & Now.ToString("hh:mm:ss"))
'.AddLine(New String("-").PadLeft(50, "-"))
'.AddLine("Document stats:")
'.AddLine("Top    : " & myPrinter.MarginTop.ToString())
'.AddLine("Bottom : " & myPrinter.MarginBottom.ToString())
'.AddLine("Left   : " & myPrinter.MarginLeft.ToString())
'.AddLine("Right  : " & myPrinter.MarginRight.ToString())
'.AddLine("Offset : " & myPrinter.TextOffset.ToString())
'.AddLine(New String("-").PadLeft(50, "-"))
'.AddLine(" ")
'.AddLine("Thank you for flying Nevercrash Airways")
'replace .Preview by .Print if you want a hard copy. Think green.
'.PreView()
'End With
'End Sub
'End Module

Public Class ticketPrinter
    Dim WithEvents _PrintDocument As New System.Drawing.Printing.PrintDocument
    Dim WithEvents _PrintPreview As New System.Windows.Forms.PrintPreviewDialog
    Dim _Text() As String
    Dim _Banner As String
    Dim _Footer As String
    Dim _LinesPerPage As Integer = 1
    Dim _BannerFont As Font = New Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point)
    Dim _DataFont As Font = New Font("Courier New", 12, FontStyle.Bold, GraphicsUnit.Point)
    Dim _FooterFont As Font = New Font("Arial", 9, FontStyle.Regular, GraphicsUnit.Point)
    Dim _UseBanner As Boolean = True
    Dim _UseFooter As Boolean = True
    Dim _UseBorder As Boolean = True
    Dim _MarginTop As Integer = _PrintDocument.DefaultPageSettings.Margins.Top
    Dim _MarginBottom As Integer = _PrintDocument.DefaultPageSettings.Margins.Bottom
    Dim _MarginLeft As Integer = _PrintDocument.DefaultPageSettings.Margins.Left
    Dim _MarginRight As Integer = _PrintDocument.DefaultPageSettings.Margins.Right
    Dim _TextOffset As Integer = 0
    Dim _PrinterMode As Integer = 0

    Public Enum PrinterMode As Integer
        TextPrinter = 0
        LinePrinter = 1
    End Enum
    Public Sub New()
        InitializeMe()
    End Sub

    Public Sub New(ByVal cText() As String)
        InitializeMe()
        Dim n As Integer
        For n = 0 To UBound(cText)
            AddLine(cText(n))
        Next
    End Sub

    Private Sub InitializeMe()
        _PrintPreview.Document = _PrintDocument
        _PrintPreview.Location = New System.Drawing.Point(13, 14)
        _PrintPreview.MinimumSize = New System.Drawing.Size(375, 250)
        _PrintPreview.Name = "PrintPreviewDialog1"
        _PrintPreview.TransparencyKey = System.Drawing.Color.Empty
        _PrintPreview.WindowState = System.Windows.Forms.FormWindowState.Maximized
        _PrintPreview.Enabled = True
        _PrintPreview.Visible = False
        ReDim _Text(1)
        _PrinterMode = PrinterMode.TextPrinter
    End Sub


    Public Sub AddLine(ByVal cText As String)
        If _Text(0) = Nothing Then
            _Text(0) = cText
        Else
            ReDim Preserve _Text(UBound(_Text) + 1)
            _Text(UBound(_Text) - 1) = cText
        End If
    End Sub

    Public Sub Print()
        _PrintDocument.Print()
    End Sub

    Public Sub PreView()
        _PrintPreview.ShowDialog()
    End Sub

    ' Aaaww...here it goes! (the Magic, I mean...)
    Private Sub PrintDocument_PrintPage(ByVal sender As Object, _
     ByVal e As System.Drawing.Printing.PrintPageEventArgs) _
      Handles _PrintDocument.PrintPage
        Static _CurLineNo As Integer = 0
        Static _CurPageNo As Integer = 1
        Dim _LineCounter As Integer = 0
        Dim _PageDone As Boolean = False

        Select Case _PrinterMode
            Case PrinterMode.LinePrinter
                'work in progress
            Case PrinterMode.TextPrinter
                ' set starting coordinates (for the 'printhead')
                Dim _TextSize As New SizeF
                _TextSize = e.Graphics.MeasureString(Trim$(_Banner), _BannerFont)
                Dim _CurrentX As Integer = e.MarginBounds.Left + _
                  ((e.MarginBounds.Right - e.MarginBounds.Left) / 2) - (_TextSize.Width / 2)
                Dim _CurrentY As Integer = e.MarginBounds.Top - _BannerFont.Height
                'page banner      
                If _UseBanner = True Then
                    ' Draw Banner text
                    e.Graphics.DrawString(_Banner, _BannerFont, Brushes.Black, _CurrentX, _CurrentY)
                    If _UseBorder = True Then
                        ' Draw box around Banner text
                        e.Graphics.DrawRectangle(Pens.Black, e.MarginBounds.Left - 1, _CurrentY - 1, _
                        (e.MarginBounds.Right - e.MarginBounds.Left) + 2, _BannerFont.Height + 4)
                    End If
                    ' Set coordinates to start printing data-lines
                    _CurrentY = _CurrentY + _BannerFont.Height + 4
                    _CurrentY = _CurrentY + _DataFont.Height
                End If
                'page text
                Do Until _PageDone
                    ' Check to see whether there's more space on the page
                    If _CurrentY <= e.MarginBounds.Bottom - _DataFont.Height Then
                        ' Are there strings left to be printed
                        If _CurLineNo < UBound(_Text) Then
                            e.Graphics.DrawString(_Text(_CurLineNo), _DataFont, Brushes.Black, e.MarginBounds.Left + _TextOffset, _CurrentY)
                            _CurrentY = _CurrentY + _DataFont.Height
                            _CurLineNo = _CurLineNo + 1
                            _LineCounter = _LineCounter + 1
                        Else
                            ' end of data reached
                            _PageDone = True
                            e.HasMorePages = False
                        End If
                    Else
                        ' We want to print more text, but there's no space
                        _PageDone = True
                        e.HasMorePages = True
                    End If
                Loop

                _LinesPerPage = Math.Max(_LinesPerPage, _LineCounter)
                'page footer
                If _UseFooter = True Then
                    _Footer = "Page " & _CurPageNo.ToString & " of " & Me.TotalPages.ToString
                    ' calculate coordinates for Footer text
                    _TextSize = e.Graphics.MeasureString(_Footer, _FooterFont)
                    _CurrentX = e.MarginBounds.Right - _TextSize.Width
                    _CurrentY = e.MarginBounds.Bottom
                    ' Draw Footer text	
                    e.Graphics.DrawString(_Footer, _FooterFont, Brushes.Black, _CurrentX, _CurrentY)
                    e.Graphics.DrawString("Printed on " & Now.ToString, _FooterFont, Brushes.Black, e.MarginBounds.Left, _CurrentY)
                    If _UseBorder = True Then ' Draw box around Footer text
                        e.Graphics.DrawRectangle(Pens.Black, e.MarginBounds.Left - 1, _CurrentY - 1, _
                            (e.MarginBounds.Right - e.MarginBounds.Left) + 1, _FooterFont.Height + 3)
                    End If
                End If
                _CurPageNo = _CurPageNo + 1
        End Select
    End Sub

    Public Property DataFont() As Font
        Get
            Return _DataFont
        End Get
        Set(ByVal value As Font)
            _DataFont = value
        End Set
    End Property

    Public Property BannerFont() As Font
        Get
            Return _BannerFont
        End Get
        Set(ByVal value As Font)
            _BannerFont = value
        End Set
    End Property

    Public Property FooterFont() As Font
        Get
            Return _FooterFont
        End Get
        Set(ByVal value As Font)
            _FooterFont = value
        End Set
    End Property

    Public Property Banner() As String
        Get
            Return _Banner
        End Get
        Set(ByVal value As String)
            _Banner = value
        End Set
    End Property

    Public Property Footer() As String
        Get
            Return _Footer
        End Get
        Set(ByVal value As String)
            _Footer = value
        End Set
    End Property

    Public ReadOnly Property LinesPerPage() As Integer
        Get
            Return _LinesPerPage
        End Get
    End Property

    Public ReadOnly Property TotalPages() As Integer
        Get
            ' Q&D check for fractional pages by rounding
            Dim _NmbrPages As Double = UBound(_Text) / _LinesPerPage
            If Convert.ToInt32(_NmbrPages) = Convert.ToInt32(UBound(_Text) / _LinesPerPage) Then
                Return Math.Max(_NmbrPages, 1)
            Else ' _NoPages + some textlines
                Return _NmbrPages + 1
            End If
        End Get
    End Property

    Public Property UseBanner() As Boolean
        Get
            Return _UseBanner
        End Get
        Set(ByVal value As Boolean)
            _UseBanner = value
        End Set
    End Property

    Public Property UseFooter() As Boolean
        Get
            Return _UseFooter
        End Get
        Set(ByVal value As Boolean)
            _UseFooter = value
        End Set
    End Property

    Public Property UseBorder() As Boolean
        Get
            Return _UseBorder
        End Get
        Set(ByVal value As Boolean)
            _UseBorder = value
        End Set
    End Property

    Public Property MarginTop() As Integer
        Get
            Return _PrintDocument.DefaultPageSettings.Margins.Top
        End Get
        Set(ByVal value As Integer)
            _PrintDocument.DefaultPageSettings.Margins.Top = value
        End Set
    End Property

    Public Property MarginBottom() As Integer
        Get
            Return _PrintDocument.DefaultPageSettings.Margins.Bottom
        End Get
        Set(ByVal value As Integer)
            _PrintDocument.DefaultPageSettings.Margins.Bottom = value
        End Set
    End Property

    Public Property MarginLeft() As Integer
        Get
            Return _PrintDocument.DefaultPageSettings.Margins.Left
        End Get
        Set(ByVal value As Integer)
            _PrintDocument.DefaultPageSettings.Margins.Left = value
        End Set
    End Property

    Public Property MarginRight() As Integer
        Get
            Return _PrintDocument.DefaultPageSettings.Margins.Right
        End Get
        Set(ByVal value As Integer)
            _PrintDocument.DefaultPageSettings.Margins.Right = value
        End Set
    End Property

    Public Property TextOffset() As Integer
        Get
            Return _TextOffset
        End Get
        Set(ByVal value As Integer)
            _TextOffset = value
        End Set
    End Property

End Class

'End Namespace

