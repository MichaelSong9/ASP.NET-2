using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Security.Principal;


public partial class Autenticacao : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
            ViewState["LoginErrors"] = 0;
    }

    protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
    {
        UsuarioDAO obj = new UsuarioDAO();
        Usuario usuario = new Usuario();

        usuario.Login = Login1.UserName;
        usuario.Senha = Login1.Password;
        try
        {

            if (obj.EfetuarLogin(usuario))
            {
                Login1.Visible = false;
                Session["LOGIN"] = usuario.Login;
                e.Authenticated = true;

                FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(
                     1,                             // versão
                     this.Login1.UserName.Trim(),   // login
                     DateTime.Now,                  // hora atual
                     DateTime.Now.AddMinutes(10),   // tempo para expirar
                     false,                         // cookie is not persistent
                     "PGTO"                         // role - se houver
                     );
                HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, FormsAuthentication.Encrypt(ticket));
                Response.Cookies.Add(cookie);

                String returnUrl1;

                if (Request.QueryString["ReturnUrl"] == null)
                {
                    returnUrl1 = "Paginas/Home.aspx";
                }
                else
                {
                    returnUrl1 = Request.QueryString["ReturnUrl"];
                }

                Response.Redirect(returnUrl1);
            }
            else
            {
                e.Authenticated = false;
            }
        }
        catch (Exception ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "<script>alert('" + ex.Message.ToString() + "');</script>");
        }
    }

    protected void Login1_LoginError(object sender, EventArgs e)
    {
        if (ViewState["LoginErrors"] == null)
            ViewState["LoginErrors"] = 0;

        int ErrorCount = (int)ViewState["LoginErrors"] + 1;
        ViewState["LoginErrors"] = ErrorCount;
    }
}