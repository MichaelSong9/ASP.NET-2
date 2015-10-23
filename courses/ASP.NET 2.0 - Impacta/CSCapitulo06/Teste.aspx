<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Teste.aspx.cs" Inherits="Teste" %>

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
                Uso do Cache no Servidor</h2>
            <p>
                <asp:Button ID="clientesButton" runat="server" OnClick="clientesButton_Click" Text="Clientes"
                    Width="115px" />
                <asp:Button ID="RemoverButton" runat="server" OnClick="RemoverButton_Click" Text="Apagar Cache" /><br />
                <br />
                <asp:Label ID="mensagemLabel" runat="server"></asp:Label><br />
                <br />
                <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#E7E7FF"
                    BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal">
                    <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                    <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                    <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                    <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                    <AlternatingRowStyle BackColor="#F7F7F7" />
                </asp:GridView>
            </p>
        </div>
    </form>
</body>
</html>
