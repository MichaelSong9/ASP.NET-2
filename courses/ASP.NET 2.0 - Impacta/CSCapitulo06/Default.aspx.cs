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
        //Se existe um Cookie chamado Nome, Coloca no textBox
        //Se o textBox estiver vazio
        if (nomeTextBox.Text == "") 
        {
            if (Request.Cookies["nome"] != null)
            {
                nomeTextBox.Text = Request.Cookies["nome"].Value;
            }
        }



    }
    protected void confirmarButton_Click(object sender, EventArgs e)
    {
        //Gravar o nome do usuario na sessão
        Session["nome"] = nomeTextBox.Text;

        //Gravar o nome do usuario em Cookies
        Response.Cookies["nome"].Value = nomeTextBox.Text;
        Response.Cookies["nome"].Expires = DateTime.Now.AddDays(1);

        //Gravar no View State
        if (ViewState["contador"] == null)
        {
            ViewState["contador"] = 1;
        }
        else
        {
            ViewState["contador"] = 
                  Convert.ToInt32(ViewState["contador"]) + 1;
        }

        mensagemLabel.Text = "Os dados foram gravados com sucesso";
        mensagemLabel.Text += "<br>Total de gravações:";
        mensagemLabel.Text += ViewState["contador"].ToString();


    }
}
