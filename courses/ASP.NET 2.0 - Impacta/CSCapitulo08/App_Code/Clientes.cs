using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;

/// <summary>
/// Summary description for Clientes
/// </summary>
public class Clientes
{

    private string conexao =@"server=localhost\sqlexpress;
                            database=northwind;
                            integrated security=true; ";

    public DataSet ListaDePaises()
    {
        SqlDataAdapter da = new SqlDataAdapter("ListaDePaises", conexao);
        DataSet ds=new DataSet();
        da.Fill(ds);
        return ds;
    }

    public DataSet ListaDeCidades(string pais)
    {
        
        HttpContext.Current.Trace.Warn("ListaDeCidades", pais);

        SqlDataAdapter da = new SqlDataAdapter("ListaDeCidades", conexao);
        da.SelectCommand.Parameters.AddWithValue("@pais", pais);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }

    public DataSet ListaDeClientes(string pais, string cidade)
    {
        SqlDataAdapter da = new SqlDataAdapter("ListaDeClientes", conexao);
        da.SelectCommand.Parameters.AddWithValue("@pais", pais);
        da.SelectCommand.Parameters.AddWithValue("@cidade", cidade);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }

}
