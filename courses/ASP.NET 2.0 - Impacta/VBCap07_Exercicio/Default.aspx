<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>
<%@ OutputCache Duration="60"  VaryByParam="categoriaDropDownList" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
      
       <h1>Curso ASP.NET</h1> 
       
       <asp:Label ID="mensagemLabel" runat="server"></asp:Label>
       
       <br />
       <br />
       
       Categoria: <asp:DropDownList ID="categoriaDropDownList" runat="server" AutoPostBack="True" DataSourceID="categoriasSqlDataSource" DataTextField="Nome" DataValueField="Codigo"></asp:DropDownList>
       
       <br />
       <br />
       <asp:GridView ID="produtosGridView" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="produtosSqlDataSource" ForeColor="#333333" GridLines="None" Width="210px">
           <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
           <Columns>
               <asp:BoundField DataField="Nome" HeaderText="Nome" SortExpression="Nome" />
               <asp:BoundField DataField="Preco" DataFormatString="{0:C}" HeaderText="Preco" HtmlEncode="False"
                   SortExpression="Preco">
                   <ItemStyle HorizontalAlign="Right" />
                   <HeaderStyle HorizontalAlign="Right" />
               </asp:BoundField>
           </Columns>
           <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
           <EditRowStyle BackColor="#999999" />
           <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
           <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
           <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
           <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
       </asp:GridView>
       
       <br />
       <br />
       <asp:HyperLink ID="alterarPrecosHyperLink" runat="server" NavigateUrl="~/AlterarPrecos.aspx" Text="Alterar Preços"></asp:HyperLink>
       
       <br />
       <br />
       
       <asp:SqlDataSource ID="categoriasSqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [Codigo], [Nome] FROM [Categorias]"></asp:SqlDataSource>
       <asp:SqlDataSource ID="produtosSqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [Nome], [Preco] FROM [Produtos] WHERE ([CodigoCategoria] = @CodigoCategoria)">
           <SelectParameters>
               <asp:ControlParameter ControlID="categoriaDropDownList" Name="CodigoCategoria" PropertyName="SelectedValue"
                   Type="Int32" />
           </SelectParameters>
       </asp:SqlDataSource>
       <br />
       <br />
       <hr />Desenvolvido para o curso de ASP.NET (c) 2007
       
       



    </form>
</body>
</html>
