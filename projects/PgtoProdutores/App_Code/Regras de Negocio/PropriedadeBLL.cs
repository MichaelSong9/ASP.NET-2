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

public class PropriedadeBLL
{
    public List<Propriedade> Selecionar(Regiao r, Cooperativa c)
    {
        PropriedadeDAO obj = new PropriedadeDAO();
        return obj.Selecionar(r, c);
    }

    public List<Propriedade> SelecionarPropriedadesComColeta(Regiao r, Cooperativa c)
    {
        PropriedadeDAO obj = new PropriedadeDAO();
        return obj.SelecionarPropriedadesComColeta(r, c);
    }
}