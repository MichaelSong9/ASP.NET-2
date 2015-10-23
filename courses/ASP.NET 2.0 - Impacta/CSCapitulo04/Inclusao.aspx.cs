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


public partial class Inclusao : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void gravarButton_Click(object sender, EventArgs e)
    {
        //Conexao
        SqlConnection cn = new SqlConnection();
        cn.ConnectionString = @"server=localhost\sqlexpress; 
                                              database=curso; 
                                             integrated security=true";
        //Comando
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = cn;
        cmd.CommandText = "insert into clientes(nome, email) values(@nome,@email)";
        cmd.Parameters.AddWithValue("@nome", nomeTextBox.Text);
        cmd.Parameters.AddWithValue("@email", emailTextBox.Text);

        //Executar
        cn.Open();
        cmd.ExecuteNonQuery();
        cn.Close();

        mensagemLabel.Text = "O cliente foi incluído com sucesso";

    }
}
