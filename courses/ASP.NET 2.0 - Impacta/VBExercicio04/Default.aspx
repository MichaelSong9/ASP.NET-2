<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>
            Curso ASP.NET</h1>
        <p>
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" Width="218px">
                <asp:ListItem></asp:ListItem>
                <asp:ListItem>Clientes</asp:ListItem>
                <asp:ListItem>Produtos</asp:ListItem>
                <asp:ListItem>Fornecedores</asp:ListItem>
            </asp:DropDownList>&nbsp;</p>
        <hr />
    
    </div>
        <asp:MultiView ID="MultiView1" runat="server">
            <asp:View ID="View1" runat="server">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4"
                    DataKeyNames="Codigo" DataSourceID="clientesSqlDataSource" ForeColor="#333333"
                    GridLines="None">
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <Columns>
                        <asp:CommandField ShowEditButton="True" />
                        <asp:BoundField DataField="Codigo" HeaderText="Codigo" InsertVisible="False" ReadOnly="True"
                            SortExpression="Codigo" />
                        <asp:BoundField DataField="Nome" HeaderText="Nome" SortExpression="Nome" />
                        <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                    </Columns>
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <EditRowStyle BackColor="#999999" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                </asp:GridView>
                <asp:SqlDataSource ID="clientesSqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
                    SelectCommand="SELECT [Codigo], [Nome], [Email] FROM [Clientes]" DeleteCommand="DELETE FROM [Clientes] WHERE [Codigo] = @Codigo" InsertCommand="INSERT INTO [Clientes] ([Nome], [Email]) VALUES (@Nome, @Email)" UpdateCommand="UPDATE [Clientes] SET [Nome] = @Nome, [Email] = @Email WHERE [Codigo] = @Codigo">
                    <DeleteParameters>
                        <asp:Parameter Name="Codigo" Type="Int32" />
                    </DeleteParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="Nome" Type="String" />
                        <asp:Parameter Name="Email" Type="String" />
                        <asp:Parameter Name="Codigo" Type="Int32" />
                    </UpdateParameters>
                    <InsertParameters>
                        <asp:Parameter Name="Nome" Type="String" />
                        <asp:Parameter Name="Email" Type="String" />
                    </InsertParameters>
                </asp:SqlDataSource>
            </asp:View>
            <asp:View ID="View2" runat="server">
                <asp:DetailsView ID="DetailsView1" runat="server" AllowPaging="True" AutoGenerateRows="False"
                    BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px"
                    CellPadding="4" DataKeyNames="Codigo" DataSourceID="produtosSqlDataSource" Height="50px"
                    Width="348px">
                    <PagerSettings FirstPageText="Primeira" LastPageText="&#218;ltima" Mode="NextPrevious"
                        NextPageText="Avan&#231;ar" PreviousPageText="Voltar" />
                    <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                    <EditRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                    <RowStyle BackColor="White" ForeColor="#003399" />
                    <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                    <Fields>
                        <asp:BoundField DataField="Codigo" HeaderText="Codigo" InsertVisible="False" ReadOnly="True"
                            SortExpression="Codigo" />
                        <asp:BoundField DataField="Nome" HeaderText="Nome" SortExpression="Nome" />
                        <asp:BoundField DataField="Preco" DataFormatString="{0:C}" HeaderText="Preco" HtmlEncode="False"
                            SortExpression="Preco" />
                        <asp:BoundField DataField="Estoque" HeaderText="Estoque" SortExpression="Estoque" />
                        <asp:CommandField CancelText="Cancelar" DeleteText="Excluir" EditText="Alterar" InsertText="Gravar"
                            NewText="Novo" SelectText="Selecionar" ShowDeleteButton="True" ShowEditButton="True"
                            ShowInsertButton="True" UpdateText="Gravar" />
                    </Fields>
                    <FieldHeaderStyle Font-Bold="True" Width="1%" Wrap="False" />
                    <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                </asp:DetailsView>
                <asp:SqlDataSource ID="produtosSqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
                    DeleteCommand="DELETE FROM [Produtos] WHERE [Codigo] = @Codigo" InsertCommand="INSERT INTO [Produtos] ([Nome], [Preco], [Estoque]) VALUES (@Nome, @Preco, @Estoque)"
                    SelectCommand="SELECT [Codigo], [Nome], [Preco], [Estoque] FROM [Produtos]" UpdateCommand="UPDATE [Produtos] SET [Nome] = @Nome, [Preco] = @Preco, [Estoque] = @Estoque WHERE [Codigo] = @Codigo">
                    <DeleteParameters>
                        <asp:Parameter Name="Codigo" Type="Int32" />
                    </DeleteParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="Nome" Type="String" />
                        <asp:Parameter Name="Preco" Type="Decimal" />
                        <asp:Parameter Name="Estoque" Type="Int32" />
                        <asp:Parameter Name="Codigo" Type="Int32" />
                    </UpdateParameters>
                    <InsertParameters>
                        <asp:Parameter Name="Nome" Type="String" />
                        <asp:Parameter Name="Preco" Type="Decimal" />
                        <asp:Parameter Name="Estoque" Type="Int32" />
                    </InsertParameters>
                </asp:SqlDataSource>
            </asp:View>
            <asp:View ID="View3" runat="server">
                <asp:DataList ID="DataList1" runat="server" BackColor="White" BorderColor="#CC9966"
                    BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyField="Codigo" DataSourceID="fornecedoresSqlDataSource"
                    GridLines="Both" RepeatColumns="2" Width="484px">
                    <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                    <SelectedItemStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                    <ItemTemplate>
                        <asp:Label ID="NomeLabel" runat="server" Font-Bold="True" Text='<%# Eval("Nome") %>'></asp:Label><br />
                        Telefone:
                        <asp:Label ID="TelefoneLabel" runat="server" Text='<%# Eval("Telefone") %>'></asp:Label><br />
                        Email:
                        <asp:Label ID="EmailLabel" runat="server" Text='<%# Eval("Email") %>'></asp:Label><br />
                        <br />
                        Contato:
                        <asp:Label ID="ContatoLabel" runat="server" Text='<%# Eval("Contato") %>'></asp:Label><br />
                        <br />
                    </ItemTemplate>
                    <ItemStyle BackColor="White" ForeColor="#330099" />
                    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                </asp:DataList>
                <asp:SqlDataSource ID="fornecedoresSqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
                    SelectCommand="SELECT [Codigo], [Nome], [Telefone], [Email], [Contato] FROM [Fornecedores]">
                </asp:SqlDataSource>
            </asp:View>
        </asp:MultiView>
    </form>
</body>
</html>
