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


public partial class ConectandoBanco : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void clientesButton_Click(object sender, EventArgs e)
    {
        //Criar a conexao
        SqlConnection cn = new SqlConnection();
        cn.ConnectionString = "Data Source=localhost\\sqlexpress;Initial Catalog=curso;Integrated Security=True;";

        //Criar o comando
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "Select Nome,Email from Clientes";
        cmd.Connection = cn;

        //Declarar o DataReader (não instanciar)
        SqlDataReader dr;
        
        //Abrir a conexao
        cn.Open();

        //Obter uma instancia do Leitor de dados
        dr = cmd.ExecuteReader();

        //Vincular a Grid
        gv.DataSource = dr;
        gv.DataBind();

        //fechar
        dr.Close();
        cn.Close();
                
    }
    protected void clientesDataSetButton_Click(object sender, EventArgs e)
    {
        SqlDataAdapter da = new SqlDataAdapter("Select * from Clientes", "Data Source=localhost\\sqlexpress;Initial Catalog=curso;Integrated Security=True;");
        DataSet ds = new DataSet();

        da.Fill(ds);

        gv.DataSource = ds;
        gv.DataBind();

    }
}
