using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public class Pagamento
{
    private int id_regiao;
    private int id_cooperativa;
    private int id_propriedade;
    private int id_produtor;
    private String dt_inicio;
    private String dt_fim;
    private char tp_relatorio;

    public int Id_regiao
    {
        get { return id_regiao; }
        set { id_regiao = value; }
    }

    public int Id_cooperativa
    {
        get { return id_cooperativa; }
        set { id_cooperativa = value; }
    }

    public int Id_propriedade
    {
        get { return id_propriedade; }
        set { id_propriedade = value; }
    }

    public int Id_produtor
    {
        get { return id_produtor; }
        set { id_produtor = value; }
    }

    public String Dt_inicio
    {
        get { return dt_inicio; }
        set { dt_inicio = value; }
    }

    public String Dt_fim
    {
        get { return dt_fim; }
        set { dt_fim = value; }
    }

    public char Tp_relatorio
    {
        get { return tp_relatorio; }
        set { tp_relatorio = value; }
    }
}