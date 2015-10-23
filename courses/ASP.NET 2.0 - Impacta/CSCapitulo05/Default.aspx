<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

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
            &nbsp;</p>
        <p>
            Bem vindo ao site,
            <asp:Label ID="usuarioLabel" runat="server"></asp:Label></p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="mensagemLabel" runat="server"></asp:Label>&nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/admin/Default.aspx">Clique aqui para acesso a área administrativa</asp:HyperLink>&nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    
    </div>
    </form>
</body>
</html>
