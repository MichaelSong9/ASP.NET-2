Imports System
Imports System.Web
Imports System.Data
Imports System.Data.OracleClient
Imports CrystalDecisions.CrystalReports
Imports System.Drawing.Printing
Imports System.Configuration
Imports System.Web.Configuration

Partial Class Recebimento_TipoRemetente_Rep_RecTipoRemetente
    Inherits System.Web.UI.Page
    Private sConnectString As String = ConfigurationManager.ConnectionStrings("ConnectionString").ToString()
    Private dtReader As DataTable
    Private dtTable As DataTable
    Private TipDoc(9) As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Page.Title = "Relatorio de Recebimento por Tipo de Remetente"
        Dim ConectaRelatorio As New clCrystal
        Dim Crpt As New CrystalDecisions.Web.CrystalReportSource()
        Dim BuscaDados As New clRecTipoRemetente

        Dim Cripta As New clDescriptografa
        sConnectString = Cripta.Descrip(sConnectString, Session("BancodeDados"))

        TipDoc = Session("arrTipoDocumento")

        BuscaDados.PCODLOC = Session("ddlLocalizacao")
        BuscaDados.PTIPREM = Session("ddlTipoRemetente")
        BuscaDados.PTipDoc1 = TipDoc(0).ToString
        BuscaDados.PTipDoc2 = TipDoc(1).ToString
        BuscaDados.PTipDoc3 = TipDoc(2).ToString
        BuscaDados.PTipDoc4 = TipDoc(3).ToString
        BuscaDados.PTipDoc5 = TipDoc(4).ToString
        BuscaDados.PTipDoc6 = TipDoc(5).ToString
        BuscaDados.PTipDoc7 = TipDoc(6).ToString
        BuscaDados.PTipDoc8 = TipDoc(7).ToString
        BuscaDados.PTipDoc9 = TipDoc(8).ToString
        BuscaDados.PTipDoc10 = TipDoc(9).ToString
        BuscaDados.PCODREM = Session("ddlCodRemetente")
        BuscaDados.PDATRECI = Session("txtDataRecI")
        BuscaDados.PDATRECF = Session("txtDataRecF")

        dtTable = BuscaDados.Imprimir(sConnectString)

        If dtTable.Rows.Count() <> 0 Then
            CrystalReportViewer1.LogOnInfo = ConectaRelatorio.ConectaCrystal()
            CrystalReportViewer1.PrintMode = CrystalDecisions.Web.PrintMode.ActiveX
            Crpt.Report.FileName = "..\Recebimento_TipoRemetente\crRelRecTipoRemetente.rpt"
            Crpt.ReportDocument.SetDataSource(dtTable)
            CrystalReportViewer1.ReportSource = Crpt
            CrystalReportViewer1.DataBind()
        Else
            Me.Page.ClientScript.RegisterStartupScript(GetType(String), "", "<script language='JavaScript'>alert('N�o existem dados a serem impressos');</script>")
        End If
    End Sub
End Class