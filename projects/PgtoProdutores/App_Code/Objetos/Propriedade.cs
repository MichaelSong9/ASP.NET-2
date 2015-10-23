using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public class Propriedade
{
    private String nome;
    private String codigo;
    private DateTime dt_inicio;
    private DateTime dt_fim;

    public String Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public String Codigo
    {
        get { return codigo; }
        set { codigo = value; }
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