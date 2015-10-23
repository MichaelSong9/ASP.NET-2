using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public class Usuario
{
    private String _nome;
    private String _id_usuario;
    private String _login;
    private String _tipo_usuario;
    private String _senha;

    public String Nome
    {
        get { return _nome; }
        set { _nome = value; }
    }

    public String Id_usuario
    {
        get { return _id_usuario; }
        set { _id_usuario = value; }
    }

    public String Login
    {
        get { return _login; }
        set { _login = value; }
    }

    public String Tipo_usuario
    {
        get { return _tipo_usuario; }
        set { _tipo_usuario = value; }
    }

    public String Senha
    {
        get { return _senha; }
        set { _senha = value; }
    }
}