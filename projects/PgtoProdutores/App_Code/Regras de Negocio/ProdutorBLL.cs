using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections.Generic;

public class ProdutorBLL
{
    public List<Produtor> CarregarProdutores(Regiao regiao, Cooperativa cooperativa, Propriedade propriedade)
    {
        ProdutorDAO obj = new ProdutorDAO();
        return obj.CarregarProdutores(regiao, cooperativa, propriedade);
    }

    public List<Produtor> SelecionarProdutoresComColeta(Regiao regiao, Cooperativa cooperativa, Propriedade propriedade)
    {
        ProdutorDAO obj = new ProdutorDAO();
        return obj.SelecionarProdutoresComColeta(regiao, cooperativa, propriedade);
    }

    public List<Produtor> SelecionarTipoLeiteColetado(Regiao regiao, Cooperativa cooperativa, Propriedade propriedade, Produtor produtor)
    {
        ProdutorDAO obj = new ProdutorDAO();
        return obj.SelecionarTipoLeiteColetado(regiao, cooperativa, propriedade, produtor);
    }
}