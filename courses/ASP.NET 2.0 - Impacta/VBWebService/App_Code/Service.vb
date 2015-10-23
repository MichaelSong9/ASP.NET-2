Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Data.SqlClient
Imports System.Data


<WebService(Namespace:="http://tempuri.org/")> _
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Class Service
     Inherits System.Web.Services.WebService

    <WebMethod()> _
    Public Function HelloWorld() As String
        Return "Hello World"
    End Function

    <WebMethod()> Public Function Mensagem() As String
        Return "Isto está vindo de um Web Service. Hora no servidor:" _
                                      & DateTime.Now.ToString()
    End Function

    <WebMethod()> Public Function Cotacao() As Decimal
        Return Convert.ToDecimal(2.8)
    End Function

    <WebMethod()> Public Function Produtos() As DataSet
        Dim da As New SqlDataAdapter( _
          "Select ProductName, UnitPrice From Products", _
          "server=localhost\sqlexpress;database=northwind;" & _
          "integrated security=true;")
        Dim ds As New DataSet("loja")
        da.Fill(ds, "produto")
        Return ds
    End Function





End Class
