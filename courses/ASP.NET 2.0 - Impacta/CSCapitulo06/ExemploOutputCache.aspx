<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ExemploOutputCache.aspx.cs" Inherits="ExemploOutputCache" %>
<%@ OutputCache Duration="60" VaryByParam="*" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <br />
        Pagina em Cache por 60 segundos....<br />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Codigo"
            DataSourceID="SqlDataSource1" EmptyDataText="There are no data records to display.">
            <Columns>
                <asp:BoundField DataField="Codigo" HeaderText="Codigo" ReadOnly="True" SortExpression="Codigo" />
                <asp:BoundField DataField="Nome" HeaderText="Nome" SortExpression="Nome" />
                <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:cursoConnectionString1 %>"
            DeleteCommand="DELETE FROM [Clientes] WHERE [Codigo] = @Codigo" InsertCommand="INSERT INTO [Clientes] ([Nome], [Email]) VALUES (@Nome, @Email)"
            ProviderName="<%$ ConnectionStrings:cursoConnectionString1.ProviderName %>" SelectCommand="SELECT [Codigo], [Nome], [Email] FROM [Clientes]"
            UpdateCommand="UPDATE [Clientes] SET [Nome] = @Nome, [Email] = @Email WHERE [Codigo] = @Codigo">
            <InsertParameters>
                <asp:Parameter Name="Nome" Type="String" />
                <asp:Parameter Name="Email" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Nome" Type="String" />
                <asp:Parameter Name="Email" Type="String" />
                <asp:Parameter Name="Codigo" Type="Int32" />
            </UpdateParameters>
            <DeleteParameters>
                <asp:Parameter Name="Codigo" Type="Int32" />
            </DeleteParameters>
        </asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
