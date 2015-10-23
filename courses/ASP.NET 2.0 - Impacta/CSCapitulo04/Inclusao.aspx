<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Inclusao.aspx.cs" Inherits="Inclusao" %>

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
        <h2>
            Inclusão de Dados no SQL Server</h2>
        <p>
            Nome<br />
            <asp:TextBox ID="nomeTextBox" runat="server"></asp:TextBox></p>
        <p>
            Email<br />
            <asp:TextBox ID="emailTextBox" runat="server"></asp:TextBox></p>
        <p>
            <asp:Button ID="gravarButton" runat="server" OnClick="gravarButton_Click" Text="Gravar"
                Width="89px" />&nbsp;</p>
        <p>
            <asp:Label ID="mensagemLabel" runat="server"></asp:Label>
            <br />
        </p>
        <p>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default.aspx">Clique aqui para ver a lista completa de clientes</asp:HyperLink>&nbsp;</p>
    
    </div>
    </form>
</body>
</html>
