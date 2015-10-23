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
using System.Data.SqlClient;


public partial class Teste : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void clientesButton_Click(object sender, EventArgs e)
    {
        if (Cache["clientes"] == null)
        {
            string sql = "Select * from Clientes";
            string conexao = @"server=localhost\sqlexpress;
                                   database=curso;
                                   integrated security=true;";
            SqlDataAdapter da = new SqlDataAdapter(sql, conexao);
            DataSet ds = new DataSet();
            da.Fill(ds);

            GridView1.DataSource = ds;
            GridView1.DataBind();
            mensagemLabel.Text = "Dados lidos do sql server";
            
            // Gravar um Cache Permanente
            //Cache["clientes"] = ds;

            //Gravar um Cache Temporário
            // Neste exemplo, 10 segundos
            Cache.Insert("clientes", ds, null,
                  System.Web.Caching.Cache.NoAbsoluteExpiration,
                  TimeSpan.FromSeconds(10));

        }
        else
        {
            GridView1.DataSource = Cache["clientes"];
            GridView1.DataBind();
            mensagemLabel.Text = "Dados lidos do cache";
        }


    }
    protected void RemoverButton_Click(object sender, EventArgs e)
    {
        Cache.Remove("clientes");
        mensagemLabel.Text = "Os dados foram removidos do cache";
    }
}
