<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UsandoMultiView.aspx.cs" Inherits="UsandoMultiView" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>
            Usando MultiView</h2>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Ficha" Width="82px" />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Calendário"
            Width="92px" />
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Finalizar"
            Width="87px" /><br />
        <asp:MultiView ID="MultiView1" runat="server">
            <asp:View ID="View1" runat="server">
                <br />
                &nbsp; Nome &nbsp;&nbsp;
                <asp:TextBox ID="TextBox1" runat="server" Width="223px"></asp:TextBox><br />
            </asp:View>
            <asp:View ID="View2" runat="server">
                <br />
                <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="Black"
                    BorderStyle="Solid" CellSpacing="1" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black"
                    Height="250px" NextPrevFormat="ShortMonth" Width="330px">
                    <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                    <TodayDayStyle BackColor="#999999" ForeColor="White" />
                    <DayStyle BackColor="#CCCCCC" />
                    <OtherMonthDayStyle ForeColor="#999999" />
                    <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="White" />
                    <DayHeaderStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" Height="8pt" />
                    <TitleStyle BackColor="#333399" BorderStyle="Solid" Font-Bold="True" Font-Size="12pt"
                        ForeColor="White" Height="12pt" />
                </asp:Calendar>
                <br />
            </asp:View>
            <asp:View ID="View3" runat="server">
                <br />
                &nbsp; Este é o terceiro View!<br />
                &nbsp;<br />
                <asp:Button ID="Button1" runat="server" Text="Teste" /><br />
                &nbsp;&nbsp;
            </asp:View>
        </asp:MultiView></div>
    </form>
</body>
</html>
