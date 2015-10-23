using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Data;
using System.Data.SqlClient;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
public class Service : System.Web.Services.WebService
{
    public Service () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld() {
        return "Hello World";
    }

    [WebMethod]
    public string Mensagem()
    {
        return "Isto está vindo de um Web Service.Hora:" 
              + DateTime.Now.ToString();
    }

    [WebMethod]
    public decimal Cotacao()
    {
        return Convert.ToDecimal(3.8);
    }

    [WebMethod]
    public DataSet Produtos()
    { 
        SqlDataAdapter da=new SqlDataAdapter(
            "Select ProductName, UnitPrice From Products",
            "server=localhost\\sqlexpress;database=northwind;integrated security=true;"
            );
        DataSet ds = new DataSet("loja");
        da.Fill(ds, "produto");
        return ds;
    }



    
}
