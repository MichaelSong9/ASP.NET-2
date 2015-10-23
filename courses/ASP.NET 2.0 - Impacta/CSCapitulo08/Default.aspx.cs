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
        if (Trace.IsEnabled)
        {
            Trace.Warn("A pagina foi carregada");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Clientes obj = new Clientes();
        DataSet ds = obj.ListaDePaises();
        Response.Write(ds.Tables[0].Rows[0][0].ToString());
    }
}
