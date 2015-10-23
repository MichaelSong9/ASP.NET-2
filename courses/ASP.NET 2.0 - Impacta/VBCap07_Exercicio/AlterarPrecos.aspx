<%@ Page Language="VB" AutoEventWireup="false" CodeFile="AlterarPrecos.aspx.vb" Inherits="AlterarPrecos" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    
    <h1>Curso ASP.NET</h1>
    <h2>Alteração de Preços</h2>
    
    <asp:GridView ID="produtosGridView" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyNames="Codigo" DataSourceID="produtosSqlDataSource" Width="351px">
        <FooterStyle BackColor="White" ForeColor="#000066" />
        <Columns>
            <asp:CommandField CancelText="Voltar" DeleteText="Excluir" EditText="Alterar" InsertText="Inserir"
                NewText="Novo" SelectText="Selecionar" ShowEditButton="True" UpdateText="Gravar">
                <HeaderStyle Width="60px" />
            </asp:CommandField>
            <asp:BoundField DataField="Nome" HeaderText="Nome" ReadOnly="True" SortExpression="Nome">
                <HeaderStyle Width="200px" />
            </asp:BoundField>
            <asp:BoundField DataField="Preco" DataFormatString="{0:C}" HeaderText="Preco" HtmlEncode="False"
                SortExpression="Preco">
                <ItemStyle HorizontalAlign="Right" />
                <HeaderStyle HorizontalAlign="Right" Width="200px" />
            </asp:BoundField>
        </Columns>
        <RowStyle ForeColor="#000066" />
        <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
        <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
    </asp:GridView>
    
    <asp:SqlDataSource ID="produtosSqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" DeleteCommand="DELETE FROM [Produtos] WHERE [Codigo] = @Codigo" InsertCommand="INSERT INTO [Produtos] ([Nome], [Preco]) VALUES (@Nome, @Preco)" SelectCommand="SELECT [Codigo], [Nome], [Preco] FROM [Produtos]" UpdateCommand="UPDATE [Produtos] SET [Preco] = @Preco WHERE [Codigo] = @Codigo">
        <DeleteParameters>
            <asp:Parameter Name="Codigo" Type="Int32" />
        </DeleteParameters>
        <UpdateParameters>
            <asp:Parameter Name="Preco" Type="Decimal" />
            <asp:Parameter Name="Codigo" Type="Int32" />
        </UpdateParameters>
        <InsertParameters>
            <asp:Parameter Name="Nome" Type="String" />
            <asp:Parameter Name="Preco" Type="Decimal" />
        </InsertParameters>
    </asp:SqlDataSource>
        <br />
    
    <asp:HyperLink ID="voltarHyperLink" runat="server" Text="Voltar" NavigateUrl="~/Default.aspx"></asp:HyperLink>
    
    <hr />Desenvolvido por Aluno(c) 2007
    
    
    
    
    </form>
</body>
</html>
