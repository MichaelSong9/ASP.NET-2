<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ConectandoBanco.aspx.cs" Inherits="ConectandoBanco" %>

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
                Conectando um Banco de Dados</h1>
            <p>
                <asp:Button ID="clientesButton" runat="server" OnClick="clientesButton_Click" Text="Clientes (DataReader)" />
                <asp:Button ID="clientesDataSetButton" runat="server" OnClick="clientesDataSetButton_Click"
                    Text="Clientes (DataSet)" Width="172px" /><br />
                <br />
                <asp:GridView ID="gv" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <RowStyle BackColor="#E3EAEB" />
                    <EditRowStyle BackColor="#7C6F57" />
                    <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                    <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <AlternatingRowStyle BackColor="White" />
                </asp:GridView>
            </p>
        </div>
    
    </div>
    </form>
</body>
</html>
