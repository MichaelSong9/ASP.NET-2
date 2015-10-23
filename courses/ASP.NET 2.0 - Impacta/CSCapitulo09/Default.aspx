<%@ Page Trace="true" Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>
            Curso ASP.NET</h1>
        <h2>
        </h2>
        <h2>
            Aplicações e Manipuladores personalizados</h2>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="visitantesLabel" runat="server"></asp:Label>&nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/documento.ashx">Clique aqui para abrir o documento</asp:HyperLink>&nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
