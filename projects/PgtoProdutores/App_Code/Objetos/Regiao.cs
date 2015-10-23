using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public class Regiao
{
    private int id_regiao;
    private String ds_regiao;
    private DateTime dt_inicio;
    private DateTime dt_fim;

    public int Id_regiao
    {
        get { return id_regiao; }
        set { id_regiao = value; }
    }

    public String Ds_regiao
    {
        get { return ds_regiao; }
        set { ds_regiao = value; }
    }

    public DateTime Dt_inicio
    {
        get { return dt_inicio; }
        set { dt_inicio = value; }
    }

    public DateTime Dt_fim
    {
        get { return dt_fim; }
        set { dt_fim = value; }
    }
}
