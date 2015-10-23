Imports System
Imports System.Web
Imports System.Data
Imports System.Data.OracleClient
Imports CrystalDecisions.CrystalReports
Imports System.Drawing.Printing
Imports System.Configuration
Imports System.Web.Configuration

Partial Class Pagamentos_Relatorio_Rep_Relatorio
    Inherits System.Web.UI.Page
    Private sConnectString As String = ConfigurationManager.ConnectionStrings("ConnectionString").ToString()
    Private dtReader As DataTable
    Private dtTable As DataTable

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Page.Title = "Relatorios"
        Dim ConectaRelatorio As New clCrystal
        Dim Crpt As New CrystalDecisions.Web.CrystalReportSource()
        Dim BuscaDados As New clEmail

        Dim Cripta As New clDescriptografa
        sConnectString = Cripta.Descrip(sConnectString, Session("BancodeDados"))

        BuscaDados.PDATA_LIQ_INI = Session("DataLiqIni")
        BuscaDados.PDATA_LIQ_FIM = Session("DataLiqFim")
        BuscaDados.PCNPJ_DE = Session("CNPJDe")
        BuscaDados.PCNPJ_ATE = Session("CNPJAte")
        BuscaDados.PCODEMP_D_INI = Session("CODEmpIni")
        BuscaDados.PCODEMP_D_FIM = Session("CODEmpFim")
        BuscaDados.PEMISSAO_INI = Session("EmissaoIni")
        BuscaDados.PEMISSAO_FIM = Session("EmissaoAte")
        BuscaDados.PDATA_VENC_INI = Session("VencIni")
        BuscaDados.PDATA_VENC_FIM = Session("VencFim")
        BuscaDados.PNUM_TIT_INI = Session("NumTitIni")
        BuscaDados.PNUM_TIT_FIM = Session("NunTitFin")
        BuscaDados.PDET_CGC = Session("DetCGC")
        BuscaDados.PUSUARIO = Session("Usuario")
        BuscaDados.PCONDICAO = Session("Condicao")
        BuscaDados.PSTATUS = Session("Status")
        BuscaDados.PEMAIL = Session("Email")

        dtTable = BuscaDados.VisualizarRelatorio(sConnectString)

        If dtTable.Rows.Count() <> 0 Then
            CrystalReportViewer1.LogOnInfo = ConectaRelatorio.ConectaCrystal()
            Crpt.ReportDocument.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Landscape
            CrystalReportViewer1.PrintMode = CrystalDecisions.Web.PrintMode.ActiveX
            Crpt.Report.FileName = "crRelPagTit.rpt"
            Crpt.ReportDocument.SetDataSource(dtTable)
            CrystalReportViewer1.ReportSource = Crpt
            CrystalReportViewer1.DataBind()
        Else
            Me.Page.ClientScript.RegisterStartupScript(GetType(String), "", "<script language='JavaScript'>alert('Não existem dados a serem impressos');</script>")
        End If
    End Sub
End Class