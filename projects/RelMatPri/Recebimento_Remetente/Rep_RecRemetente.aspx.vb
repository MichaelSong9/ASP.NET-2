Imports System
Imports System.Web
Imports System.Data
Imports System.Data.OracleClient
Imports OrcaleServer20.ConexaoSQL20
Imports CrystalDecisions.CrystalReports
Imports System.Drawing.Printing

Partial Class Recebimento_Remetente_Rep_RecRemetente
    Inherits System.Web.UI.Page
    Private sConnectString As String = ConfigurationManager.ConnectionStrings("ConnectionString").ToString()
    Private dtReader As DataTable
    Private dtTable As DataTable

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Page.Title = "Relatorio de Recebimento por Remetente"
        Dim ConectaRelatorio As New clCrystal
        Dim Crpt As New CrystalDecisions.Web.CrystalReportSource()
        Dim BuscaDados As New clRecRemetente

        BuscaDados.PCodLoc = Session("ddlLocalizacao")
        BuscaDados.PCODREM = Session("ddlRemetente")
        BuscaDados.PTIPDOC = Session("ddlTipoDocumento")
        BuscaDados.PDatRecI = Session("txtDataRecI")
        BuscaDados.PDatRecF = Session("txtDataRecF")
        dtTable = BuscaDados.Imprimir(sConnectString)

        If dtTable.Rows.Count() <> 0 Then
            CrystalReportViewer1.LogOnInfo = ConectaRelatorio.ConectaCrystal()
            CrystalReportViewer1.PrintMode = CrystalDecisions.Web.PrintMode.ActiveX
            Crpt.Report.FileName = "..\Recebimento_Remetente\crRelRecRemetente.rpt"
            Crpt.ReportDocument.SetDataSource(dtTable)
            CrystalReportViewer1.ReportSource = Crpt
            CrystalReportViewer1.DataBind()
        Else
            Me.Page.ClientScript.RegisterStartupScript(GetType(String), "", "<script language='JavaScript'>alert('N�o existem dados a serem impressos');</script>")
        End If
    End Sub
End Class
