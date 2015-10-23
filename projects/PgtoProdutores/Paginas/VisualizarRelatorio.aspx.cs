using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class VisualizarRelatorio : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Page.Title = "Pgto de Produtores - Relatório de Pagamentos de Produtor";

        try
        {
            Pagamento pgto = new Pagamento();
            PagamentoBLL obj = new PagamentoBLL();
            String strPathreport = String.Empty;

            pgto.Id_regiao = Convert.ToInt32(Session["ID_REGIAO"]);
            pgto.Id_cooperativa = Convert.ToInt32(Session["ID_COOPERATIVA"]);
            pgto.Id_propriedade = Convert.ToInt32(Session["ID_PROPRIEDADE"]);
            pgto.Dt_inicio = Convert.ToString(Session["DT_INICIO"]);
            pgto.Dt_fim = Convert.ToString(Session["DT_FIM"]);
            pgto.Tp_relatorio = Convert.ToChar(Session["TP_RELATORIO"]);

            strPathreport = Server.MapPath("Relatorio.rpt");

            CrystalReportViewer1.LogOnInfo = Crystal.ConectaCrystal();
            CrystalReportViewer1.ReportSource = obj.GerarRelatorioPgtoProdutores(pgto, strPathreport);
            CrystalReportViewer1.DataBind();
        }
        catch (Exception ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "<script>alert('" + ex.Message.ToString() + "');</script>");
        }
    }
}