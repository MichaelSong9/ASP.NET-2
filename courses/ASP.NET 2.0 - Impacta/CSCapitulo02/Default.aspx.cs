using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void okButton_Click(object sender, EventArgs e)
    {
        mensagemLabel.Text = "Boa noite, " + nomeTextBox.Text;
        mensagemLabel.ForeColor = System.Drawing.Color.Blue;

       
    }
    protected void ajudaLinkButton_Click(object sender, EventArgs e)
    {
        mensagemLabel.Text = "Não há ajuda por enquanto.";
    }
    protected void testeImageButton_Click(object sender, ImageClickEventArgs e)
    {
        mensagemLabel.Text = "Você clicou na imagem na coordenada " ;
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        mensagemLabel.Text = "Voce escoheu " + DropDownList1.SelectedValue;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Panel1.Visible = false;
        Panel2.Visible = true;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        Panel2.Visible = false;
    }
}
