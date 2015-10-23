using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

using CrystalDecisions.CrystalReports.Engine;

public class PagamentoBLL
{
    public bool LiberarPagamento(Pagamento pgto, String usuario)
    {
        PagamentoDAO obj = new PagamentoDAO();
        return obj.LiberarPagamento(pgto, usuario);
    }

    public ReportDocument GerarRelatorioPgtoProdutores(Pagamento pgto, String strPathreport)
    {
        PagamentoDAO obj = new PagamentoDAO();
        ReportDocument rpt = new ReportDocument();

        DateTime dtInicialDigitada = Convert.ToDateTime(pgto.Dt_inicio);
        DateTime dtFinalDigitada = Convert.ToDateTime(pgto.Dt_fim);

        String dataInicialDigitada = dtInicialDigitada.ToString("dd/MM/yyyy");
        String dataFinalDigitada = dtFinalDigitada.ToString("dd/MM/yyyy");

        if (pgto.Id_regiao == 0)
            throw new Exception("Selecione a região!");
        else if (pgto.Id_cooperativa == 0)
            throw new Exception("Selecione a cooperativa!");
        else if (Convert.ToDateTime(dataInicialDigitada) > Convert.ToDateTime(dataFinalDigitada))
            throw new Exception("A data final não pode ser inferior a data inicial");

        rpt = obj.GerarRelatorioPgtoProdutores(pgto, strPathreport);
        return rpt;
    }
}