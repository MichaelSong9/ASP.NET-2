<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="admin_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div>
            <h1>
                CURSO ASP.NET</h1>
            <p>
                BEM VINDO A ÁREA ADMINISTRATIVA DO SITE</p>
            <p>
                &nbsp;</p>
            <p>
                Nome Completo:<br />
                <asp:TextBox ID="nomeTextBox" runat="server"></asp:TextBox></p>
            <p>
                Idade:<br />
                <asp:TextBox ID="idadeTextBox" runat="server"></asp:TextBox></p>
            <p>
                <asp:Button ID="confirmarButton" runat="server" OnClick="confirmarButton_Click" Text="Confirmar" />&nbsp;</p>
            <p>
                &nbsp;</p>
            <p>
                Você está logado como&nbsp;
                <asp:LoginName ID="LoginName1" runat="server" />
            </p>
            <p>
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default.aspx">Voltar </asp:HyperLink>&nbsp;</p>
        </div>
    
    </div>
    </form>
</body>
</html>
