Imports System
Imports Microsoft.Reporting.WebForms
Imports System.Data
Imports System.Data.OracleClient
Imports OrcaleServer20.ConexaoSQL20

Imports System.IO
Imports System.Text
Imports System.Drawing.Imaging
Imports System.Drawing.Printing
Imports System.Collections.Generic


Partial Class Default1
    Inherits System.Web.UI.Page
    Implements IDisposable
    Private sConnectString As String = ConfigurationManager.ConnectionStrings("ConnectionString").ToString()

    Private m_currentPageIndex As Integer
    Private m_streams As IList(Of Stream)
    Private Function CreateStream(ByVal name As String, _
    ByVal fileNameExtension As String, _
    ByVal encoding As Encoding, ByVal mimeType As String, _
    ByVal willSeek As Boolean) As Stream
        Dim stream As Stream = New FileStream(name + "." + fileNameExtension, FileMode.Create)
        m_streams.Add(stream)
        Return stream
    End Function


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            'Dim sPathRpt = HttpContext.Current.Server.MapPath("").ToString
            'Dim FilePath = sPathRpt + "\Report1.rdlc"

            rptComigo.ProcessingMode = ProcessingMode.Local
            Dim report As LocalReport = rptComigo.LocalReport
            rptComigo.ShowPrintButton = True
            report.ReportPath = "Report1.rdlc"
            Dim rptDatasource As ReportDataSource = New ReportDataSource
            rptDatasource.Name = "RelAdi_PR_ADI_SEL_COMIGO1"
            rptDatasource.Value = getReports()
            report.DataSources.Add(rptDatasource)

            'Me.rptComigo.ServerReport.ReportServerUrl = New System.Uri(ConfigurationManager.AppSettings("http://localhost/ReportServer$sqlexpress"))
            'Me.rptComigo.ServerReport.ReportPath = ConfigurationManager.AppSettings(sPathRpt) & Request.QueryString("Report1.rdlc") & "&rctylesheet=HtmlViewer"
            'Me.rptComigo.ServerReport.Refresh()


            ' Run()
        Catch ex As Exception
            Dim erro As String = "Erro 2"
        End Try
    End Sub
    Protected Function getReports() As DataTable
        



        Dim dtperiodoI As String = "01072007"
        Dim dtperiodoF As String = "10072007"
        Dim Fields As String() = {"P_PERIODOI", "P_PERIODOF"}
        Dim Param As String() = {dtperiodoI, dtperiodoF}
        Dim OConexao As clsOracleServer20 = New clsOracleServer20()
        Dim dt As DataTable = New DataTable()
        If IsNothing(Session("dsComigo")) Then
            dt = OConexao.AbrirDataTable(sConnectString, "PR_ADI_SEL_COMIGO", Fields, Param)
            Session("dsComigo") = dt
        End If
        Try
            dt = CType(Session("dsComigo"), DataTable)
            Return (dt)
        Catch ex As Exception
        End Try
        Return Nothing
    End Function
    Private Sub Run()
        Dim report As LocalReport = New LocalReport()
        rptComigo.ProcessingMode = ProcessingMode.Remote
        report.ReportPath = "Report.rdlc"
        report.DataSources.Add(New ReportDataSource("RelAdi_PR_ADI_SEL_COMIGO", getReports()))
        Export(report)

        m_currentPageIndex = 0
        Print()
    End Sub
    Private Sub Export(ByVal report As LocalReport)
        Dim deviceInfo As String = _
          "<DeviceInfo>" + _
          "  <OutputFormat>EMF</OutputFormat>" + _
          "  <PageWidth>8.5in</PageWidth>" + _
          "  <PageHeight>11in</PageHeight>" + _
          "  <MarginTop>0.25in</MarginTop>" + _
          "  <MarginLeft>0.25in</MarginLeft>" + _
          "  <MarginRight>0.25in</MarginRight>" + _
          "  <MarginBottom>0.25in</MarginBottom>" + _
          "</DeviceInfo>"
        Dim warnings() As Warning = Nothing
        m_streams = New List(Of Stream)()
        report.Render("Image", deviceInfo, _
              AddressOf CreateStream, warnings)


        Dim stream As Stream
        For Each stream In m_streams
            stream.Position = 0
        Next
    End Sub
    Private Sub Print()
        Const printerName As String = "\\cclmail\qu_dfi"

        If m_streams Is Nothing Or m_streams.Count = 0 Then
            Return
        End If

        Dim printDoc As New PrintDocument()
        
        printDoc.PrinterSettings.PrinterName = printDoc.DocumentName()
        'printerName
        If Not printDoc.PrinterSettings.IsValid Then
            Dim msg As String = String.Format("Can't find printer ""{0}"".", printerName)
            'Debug.WriteLine(msg)
            Return
        End If
        AddHandler printDoc.PrintPage, AddressOf PrintPage
        printDoc.Print()

        'Dim dialog As New PrintDialog()
        'dialog.Document = pdoc
        'If dialog.ShowDialog = DialogResult.OK Then
        '    pdoc.Print()
        'End If

    End Sub


    Private Sub PrintPage(ByVal sender As Object, ByVal ev As PrintPageEventArgs)
        Dim pageImage As New Metafile(m_streams(m_currentPageIndex))
        ev.Graphics.DrawImage(pageImage, ev.PageBounds)

        m_currentPageIndex += 1
        ev.HasMorePages = (m_currentPageIndex < m_streams.Count)
        Return
    End Sub
    Public Overloads Sub Dispose() Implements IDisposable.Dispose
        If Not (m_streams Is Nothing) Then
            Dim stream As Stream
            For Each stream In m_streams
                stream.Close()
            Next
            m_streams = Nothing
        End If
    End Sub

    Public Shared Sub Main(ByVal args As String())
        Using demo As Default1 = New Default1()
            demo.Run()
        End Using
    End Sub
End Class
