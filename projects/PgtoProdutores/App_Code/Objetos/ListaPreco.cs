using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

[Serializable]
public class ListaPreco
{
    private int id_regiao;
    private int id_cooperat;
    private String ds_cooperat;
    private int id_propried;
    private String ds_propried;
    private int id_produtor;
    private String ds_produtor;
    private DateTime dt_inicio;
    private DateTime dt_fim;
    private char id_tipo_leite;
    private Decimal id_vol_ini;
    private Decimal id_vol_fim;
    private Decimal id_valor_unit;
    private String login;

    public int Id_regiao
    {
        get { return id_regiao; }
        set { id_regiao = value; }
    }

    public int Id_cooperat
    {
        get { return id_cooperat; }
        set { id_cooperat = value; }
    }

    public String Ds_cooperat
    {
        get { return ds_cooperat; }
        set { ds_cooperat = value; }
    }

    public int Id_propried
    {
        get { return id_propried; }
        set { id_propried = value; }
    }

    public String Ds_propried
    {
        get { return ds_propried; }
        set { ds_propried = value; }
    }

    public int Id_produtor
    {
        get { return id_produtor; }
        set { id_produtor = value; }
    }

    public String Ds_produtor
    {
        get { return ds_produtor; }
        set { ds_produtor = value; }
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

    public char Id_tipo_leite
    {
        get { return id_tipo_leite; }
        set { id_tipo_leite = value; }
    }

    public Decimal Id_vol_ini
    {
        get { return id_vol_ini; }
        set { id_vol_ini = value; }
    }

    public Decimal Id_vol_fim
    {
        get { return id_vol_fim; }
        set { id_vol_fim = value; }
    }

    public Decimal Id_valor_unit
    {
        get { return id_valor_unit; }
        set { id_valor_unit = value; }
    }

    public String Login
    {
        get { return login; }
        set { login = value; }
    }
}