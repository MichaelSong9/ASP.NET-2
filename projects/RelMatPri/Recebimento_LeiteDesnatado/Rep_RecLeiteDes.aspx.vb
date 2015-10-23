Imports System
Imports System.Web
Imports System.Data
Imports System.Data.OracleClient
Imports OrcaleServer20.ConexaoSQL20
Imports CrystalDecisions.CrystalReports
Imports System.Drawing.Printing

Partial Class Recebimento_LeiteDesnatado_Rep_RecLeiteDes
    Inherits System.Web.UI.Page
    Private sConnectString As String = ConfigurationManager.ConnectionStrings("ConnectionString").ToString()
    Private dtReader As DataTable
    Private dtTable As DataTable

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Page.Title = "Relatorio de Recebimento de Leite Desnatado"
        Dim ConectaRelatorio As New clCrystal
        Dim Crpt As New CrystalDecisions.Web.CrystalReportSource()
        Dim BuscaDados As New clRecLeiteDes

        Dim ps As New PageSettings
        ps.Landscape = True

        BuscaDados.PCODLOC = Session("ddlLocalizacao")
        BuscaDados.PTIPREM = Session("ddlTipoRemetente")
        BuscaDados.PTIPOMP = Session("ddlTipoMP")
        BuscaDados.PTipDoc = Session("ddlTipoDocumento")
        BuscaDados.PCODREM = Session("ddlCodRemetente")
        BuscaDados.PTEORMGI = Session("txtTeorMGI")
        BuscaDados.PTEORMGF = Session("txtTeorMGF")
        BuscaDados.PDATRECI = Session("txtDataRecI")
        BuscaDados.PDATRECF = Session("txtDataRecF")

        dtTable = BuscaDados.Imprimir(sConnectString)

        If dtTable.Rows.Count() <> 0 Then
            CrystalReportViewer1.LogOnInfo = ConectaRelatorio.ConectaCrystal()

            'orientação do papel durante a impressão
            Crpt.ReportDocument.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Landscape

            CrystalReportViewer1.PrintMode = CrystalDecisions.Web.PrintMode.ActiveX
            Crpt.Report.FileName = "..\Recebimento_LeiteDesnatado\crRelRecLeiteDes.rpt"
            Crpt.ReportDocument.SetDataSource(dtTable)
            CrystalReportViewer1.ReportSource = Crpt
            CrystalReportViewer1.DataBind()
        Else
            Me.Page.ClientScript.RegisterStartupScript(GetType(String), "", "<script language='JavaScript'>alert('Não existem dados a serem impressos');</script>")
        End If
    End Sub
End Class