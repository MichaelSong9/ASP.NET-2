<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    
    
        <h1>Oficina</h1>
        <p>Exemplo de interface Web</p>
        <p>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" 
                CellPadding="4" DataSourceID="ObjectDataSource1">
                <RowStyle BackColor="White" ForeColor="#003399" />
                <Columns>
                    <asp:BoundField DataField="Placa" HeaderText="Placa" SortExpression="Placa" />
                    <asp:BoundField DataField="Ano" HeaderText="Ano" SortExpression="Ano" />
                    <asp:BoundField DataField="Modelo" HeaderText="Modelo" 
                        SortExpression="Modelo" />
                </Columns>
                <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
            </asp:GridView>
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
                SelectMethod="Listagem" TypeName="Oficina.BLL.VeiculoBLL">
            </asp:ObjectDataSource>
        </p>
        <p>
            <asp:GridView ID="GridView2" runat="server" AllowPaging="True" 
                BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" 
                CellPadding="4" DataSourceID="ObjectDataSource2" PageSize="3">
                <RowStyle BackColor="White" ForeColor="#330099" />
                <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
            </asp:GridView>
            <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" 
                SelectMethod="Lista" TypeName="Oficina.BLL.VeiculoBLL">
            </asp:ObjectDataSource>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" 
                CellPadding="4" DataKeyNames="Placa" DataSourceID="ObjectDataSource3" 
                ForeColor="#333333" GridLines="None">
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <Columns>
                    <asp:CommandField ShowEditButton="True" />
                    <asp:BoundField DataField="Placa" HeaderText="Placa" ReadOnly="True" 
                        SortExpression="Placa" />
                    <asp:BoundField DataField="Modelo" HeaderText="Modelo" 
                        SortExpression="Modelo" />
                    <asp:BoundField DataField="Cor" HeaderText="Cor" SortExpression="Cor" />
                    <asp:BoundField DataField="Ano" HeaderText="Ano" SortExpression="Ano" />
                </Columns>
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <EditRowStyle BackColor="#999999" />
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            </asp:GridView>
        </p>
        <asp:ObjectDataSource ID="ObjectDataSource3" runat="server" 
            DeleteMethod="Delete" InsertMethod="Insert" 
            OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" 
            TypeName="OficinaDataSetTableAdapters.VeiculoTableAdapter" 
            UpdateMethod="Update">
            <DeleteParameters>
                <asp:Parameter Name="Original_Placa" Type="String" />
            </DeleteParameters>
            <UpdateParameters>
                <asp:Parameter Name="Modelo" Type="String" />
                <asp:Parameter Name="Cor" Type="String" />
                <asp:Parameter Name="Ano" Type="Int16" />
                <asp:Parameter Name="Original_Placa" Type="String" />
            </UpdateParameters>
            <InsertParameters>
                <asp:Parameter Name="Placa" Type="String" />
                <asp:Parameter Name="Modelo" Type="String" />
                <asp:Parameter Name="Cor" Type="String" />
                <asp:Parameter Name="Ano" Type="Int16" />
            </InsertParameters>
        </asp:ObjectDataSource>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    
    
    
    </div>
    </form>
</body>
</html>
