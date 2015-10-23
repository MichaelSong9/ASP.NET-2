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

public class CooperativaBLL
{
    public List<Cooperativa> CarregarCooperativas(Cooperativa c)
    {
        CooperativaDAO obj = new CooperativaDAO();
        return obj.CarregarCooperativas(c);
    }

    public List<Cooperativa> SelecionarCooperativasComColeta(Cooperativa c)
    {
        CooperativaDAO obj = new CooperativaDAO();
        return obj.SelecionarCooperativasComColeta(c);
    }
}