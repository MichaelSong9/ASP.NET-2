<%@ Page  Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
    <script>
       function teste()
       {
          debugger
          alert('ok');
       }
       
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>
                Curso ASP.NET</h1>
            <h2>
                Exemplo de Debug e Trace</h2>
            <p>
                &nbsp;</p>
            <p>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />&nbsp;</p>
            <p>
                <input id="Button2" onclick="teste()"  type="button" value="button" />&nbsp;</p>
            <p>
                Pais<br />
                <asp:DropDownList ID="paisDropDownList" runat="server" AutoPostBack="True" DataSourceID="paisObjectDataSource"
                    DataTextField="Pais" Width="143px">
                </asp:DropDownList><asp:ObjectDataSource ID="paisObjectDataSource" runat="server"
                    SelectMethod="ListaDePaises" TypeName="Clientes"></asp:ObjectDataSource>
            </p>
            <p>
                Cidade<br />
                <asp:DropDownList ID="cidadeDropDownList" runat="server" AutoPostBack="True" DataSourceID="cidadesObjectDataSource"
                    DataTextField="Cidade" Width="142px">
                </asp:DropDownList><asp:ObjectDataSource ID="cidadesObjectDataSource" runat="server"
                    SelectMethod="ListaDeCidades" TypeName="Clientes">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="paisDropDownList" Name="pais" PropertyName="SelectedValue"
                            Type="String" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </p>
            <p>
                Cliente<br />
                <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#CC9966"
                    BorderStyle="None" BorderWidth="1px" CellPadding="4" DataSourceID="clientesObjectDataSource">
                    <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                    <RowStyle BackColor="White" ForeColor="#330099" />
                    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                    <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                </asp:GridView>
                <asp:ObjectDataSource ID="clientesObjectDataSource" runat="server" SelectMethod="ListaDeClientes"
                    TypeName="Clientes">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="paisDropDownList" Name="pais" PropertyName="SelectedValue"
                            Type="String" />
                        <asp:ControlParameter ControlID="cidadeDropDownList" Name="cidade" PropertyName="SelectedValue"
                            Type="String" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </p>
        </div>
    </form>
</body>
</html>
