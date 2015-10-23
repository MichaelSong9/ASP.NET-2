<%@ Page  Trace="true" Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Capitulo 06</h1>
        <h2>Mantendo o Estado</h2>
        <p>
            &nbsp;</p>
        <p>
            Digite o seu nome
            <asp:TextBox ID="nomeTextBox" runat="server"></asp:TextBox>
            <asp:Button ID="confirmarButton" runat="server" OnClick="confirmarButton_Click" Text="Confirmar" />
            <br />
            <br />
            <asp:Label ID="mensagemLabel" runat="server"></asp:Label></p>
        <p>
            &nbsp;</p>
        <p>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Pagina2.aspx">Pagina 2</asp:HyperLink>&nbsp;</p>
    
    </div>
    </form>
</body>
</html>
