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

public partial class Validacao : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
    {
        if (args.Value.ToLower() == "impacta")
        {
            args.IsValid = false;
        }
        else
        {
            args.IsValid = true;
        }
    }
    protected void confirmarButton_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            mensagemLabel.Text = "<h1>Formulário Processado</h1>";
        }
        else
        {
            mensagemLabel.Text = "<script>alert('Página inválida')</script>";
        }

    }
}
