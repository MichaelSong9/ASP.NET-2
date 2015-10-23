<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Teste.aspx.cs" Inherits="Teste" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="Button1" runat="server" Style="z-index: 100; left: 254px; position: absolute;
            top: 39px" Text="Button" Width="110px" />
        <asp:TextBox ID="TextBox1" runat="server" Style="z-index: 101; left: 51px; position: absolute;
            top: 127px" Width="212px"></asp:TextBox>
        <asp:Panel ID="Panel1" runat="server" Height="110px" Style="z-index: 102; left: 438px;
            position: absolute; top: 103px" Width="205px">
            &nbsp;&nbsp; Teste do painel<br />
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" /></asp:Panel>
        <asp:Panel ID="Panel2" runat="server" Height="92px" Style="z-index: 104; left: 178px;
            position: absolute; top: 201px" Width="201px">
            <br />
            &nbsp; Testando posicao</asp:Panel>
    
    </div>
    </form>
</body>
</html>
