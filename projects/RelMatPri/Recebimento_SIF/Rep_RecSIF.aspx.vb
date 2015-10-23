Imports System
Imports System.Web
Imports System.Data
Imports System.Data.OracleClient
Imports OrcaleServer20.ConexaoSQL20
Imports CrystalDecisions.CrystalReports
Imports System.Drawing.Printing

Partial Class Recebimento_SIF_Rep_RecSIF
    Inherits System.Web.UI.Page

    Private sConnectString As String = ConfigurationManager.ConnectionStrings("ConnectionString").ToString()
    Private dtReader As DataTable
    Private dtTable As DataTable

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Page.Title = "Relatorio de Recebimento por SIF"
        Dim ConectaRelatorio As New clCrystal
        Dim Crpt As New CrystalDecisions.Web.CrystalReportSource()
        Dim BuscaDados As New clRecSIF

        Dim ps As New PageSettings
        ps.Landscape = True

        BuscaDados.PCodLoc = Session("ddlLocalizacao")
        BuscaDados.PTipoMP = Session("ddlTipoMP")
        BuscaDados.PCodPos = Session("ddlCodPos")
        BuscaDados.PCodRem = Session("ddlRemetente")
        BuscaDados.PTIPDOC = Session("ddlTipoDocumento")
        BuscaDados.PDatRecI = Session("txtDataRecI")
        BuscaDados.PDatRecF = Session("txtDataRecF")

        dtTable = BuscaDados.Imprimir(sConnectString)

        If dtTable.Rows.Count() <> 0 Then
            CrystalReportViewer1.LogOnInfo = ConectaRelatorio.ConectaCrystal()

            'orientação do papel durante a impressão
            Crpt.ReportDocument.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Landscape

            CrystalReportViewer1.PrintMode = CrystalDecisions.Web.PrintMode.ActiveX
            Crpt.Report.FileName = "..\Recebimento_SIF\crRelRecSIF.rpt"
            Crpt.ReportDocument.SetDataSource(dtTable)
            CrystalReportViewer1.ReportSource = Crpt
            CrystalReportViewer1.DataBind()
        Else
            Me.Page.ClientScript.RegisterStartupScript(GetType(String), "", "<script language='JavaScript'>alert('Não existem dados a serem impressos');</script>")
        End If
    End Sub
End Class
