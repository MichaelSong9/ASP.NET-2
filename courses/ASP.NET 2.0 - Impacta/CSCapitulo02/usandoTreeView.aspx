<%@ Page Language="C#" AutoEventWireup="true" CodeFile="usandoTreeView.aspx.cs" Inherits="usandoTreeView" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h3>
            Usando o TreeView</h3>
        <p>
            <asp:Label ID="mensagemLabel" runat="server"></asp:Label>
            <br />
            <br />
            <asp:TreeView ID="TreeView1" runat="server" ExpandDepth="0" ImageSet="Inbox" OnSelectedNodeChanged="TreeView1_SelectedNodeChanged">
                <ParentNodeStyle Font-Bold="False" />
                <HoverNodeStyle Font-Underline="True" />
                <SelectedNodeStyle Font-Underline="True" HorizontalPadding="0px" VerticalPadding="0px" />
                <Nodes>
                    <asp:TreeNode SelectAction="None" Text="Arquivos" Value="Arquivos">
                        <asp:TreeNode Text="Clientes" Value="Clientes"></asp:TreeNode>
                        <asp:TreeNode Text="Produtos" Value="Produtos"></asp:TreeNode>
                        <asp:TreeNode Text="Fornecedores" Value="Fornecedores"></asp:TreeNode>
                        <asp:TreeNode Text="Vendas" Value="Vendas"></asp:TreeNode>
                    </asp:TreeNode>
                    <asp:TreeNode SelectAction="None" Text="Relat&#243;rios" Value="Relat&#243;rios">
                        <asp:TreeNode Text="Listagem de Filiais" Value="Listagem de Filiais"></asp:TreeNode>
                        <asp:TreeNode Text="Vendas do mes" Value="Vendas do mes"></asp:TreeNode>
                    </asp:TreeNode>
                    <asp:TreeNode SelectAction="None" Text="Ferramentas" Value="Ferramentas">
                        <asp:TreeNode Text="Backup" Value="Backup"></asp:TreeNode>
                        <asp:TreeNode Text="Restaurar" Value="Restaurar"></asp:TreeNode>
                    </asp:TreeNode>
                    <asp:TreeNode SelectAction="None" Text="Noticias" Value="Noticias">
                        <asp:TreeNode NavigateUrl="http://www.uol.com.br" Text="Uol" Value="Uol"></asp:TreeNode>
                        <asp:TreeNode NavigateUrl="http://www.yahoo.com.br" Text="yahoo" Value="yahoo"></asp:TreeNode>
                    </asp:TreeNode>
                </Nodes>
                <NodeStyle Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" HorizontalPadding="5px"
                    NodeSpacing="0px" VerticalPadding="0px" />
            </asp:TreeView>
        </p>
        <p>
            &nbsp;</p>
    
    </div>
    </form>
</body>
</html>
