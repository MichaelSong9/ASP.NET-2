using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public class Cooperativa
{
    private String _regiao;
    private String _id_cooperativa;
    private String _usuario;
    private String _ds_regiao;
    private String _ds_cooperat;
    private DateTime dt_inicio;
    private DateTime dt_fim;

    public String Regiao
    {
        get { return _regiao; }
        set { _regiao = value; }
    }

    public String Id_cooperativa
    {
        get { return _id_cooperativa; }
        set { _id_cooperativa = value; }
    }
   
    public String Usuario
    {
        get { return _usuario; }
        set { _usuario = value; }
    }

    public String Ds_regiao
    {
        get { return _ds_regiao; }
        set { _ds_regiao = value; }
    }

    public String Ds_cooperat
    {
        get { return _ds_cooperat; }
        set { _ds_cooperat = value; }
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