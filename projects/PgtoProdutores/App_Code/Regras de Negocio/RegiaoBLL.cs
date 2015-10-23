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

public class RegiaoBLL
{
    public List<Regiao> Selecionar()
    {
        RegiaoDAO obj = new RegiaoDAO();
        return obj.Selecionar();
    }

    public List<Regiao> SelecionarRegioesComProdutores()
    {
        RegiaoDAO obj = new RegiaoDAO();
        return obj.SelecionarRegioesComProdutores();
    }

    public List<Regiao> SelecionarRegioesComColeta(Regiao reg)
    {
        RegiaoDAO obj = new RegiaoDAO();
        return obj.SelecionarRegioesComColeta(reg);
    }
}