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

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ConfirmarButton_Click(object sender, EventArgs e)
    {
                if(senhaTextBox.Text == "123")
                {
                        FormsAuthentication.RedirectFromLoginPage(nomeTextBox.Text, false);
                }
                else
                {
                    mensagemLabel.Text = "usuário ou senha inválida";
                }
    }
}

