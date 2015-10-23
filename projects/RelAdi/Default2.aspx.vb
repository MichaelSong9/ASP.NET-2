Imports System
Imports System.Data
Imports System.Data.OracleClient
Imports OrcaleServer20.ConexaoSQL20
Imports CrystalDecisions.CrystalReports

Partial Class Default2
    Inherits System.Web.UI.Page
    Private sConnectString As String = ConfigurationManager.ConnectionStrings("ConnectionString").ToString()
    Private dtReader As DataTable
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim ConectaRelatorio As clCrystal = New clCrystal
        Dim Crpt As New CrystalDecisions.Web.CrystalReportSource()
        If IsNothing(Session("dsComigo")) Then
            Dim ConsultaDados As clRelAdi = New clRelAdi
            ConsultaDados.dt_periodoI = "01072007"
            ConsultaDados.dt_periodoF = "10072007"
            dtReader = ConsultaDados.Consultar(sConnectString)
            Session("dsComigo") = dtReader
        Else
            Try
                dtReader = CType(Session("dsComigo"), DataTable)
            Catch ex As Exception
            End Try
        End If
        CrystalReportViewer1.LogOnInfo = ConectaRelatorio.ConectaCrystal()
        CrystalReportViewer1.PrintMode() = CrystalDecisions.Web.PrintMode.ActiveX

        Crpt.Report.FileName = "CrystalReport.rpt"
        Crpt.ReportDocument.SetDataSource(dtReader)
        CrystalReportViewer1.ReportSource = Crpt
        CrystalReportViewer1.DataBind()
    End Sub
End Class
