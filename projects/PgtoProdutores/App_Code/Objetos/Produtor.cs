using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public class Produtor
{
    private String _cod_produtor;
    private String _cod_Regiao;
    private String _id_produtor_coop;
    private String _ds_produtor;
    private String _id_tipo_leite;

    public String Cod_produtor
    {
        get { return _cod_produtor; }
        set { _cod_produtor = value; }
    }

    public String Id_produtor_coop
    {
        get { return _id_produtor_coop; }
        set { _id_produtor_coop = value; }
    }

    public String Cod_Regiao
    {
        get { return _cod_Regiao; }
        set { _cod_Regiao = value; }
    }

    public String Ds_produtor
    {
        get { return _ds_produtor; }
        set { _ds_produtor = value; }
    }

    public String Id_tipo_leite
    {
        get { return _id_tipo_leite; }
        set { _id_tipo_leite = value; }
    }
}