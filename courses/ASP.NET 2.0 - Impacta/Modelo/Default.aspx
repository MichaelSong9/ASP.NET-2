<%@ Page  Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

  Esta é uma página baseada em uma master page<br />
    <br />
    <asp:Label ID="Label1" runat="server" Text="Isto é um label normal"></asp:Label><br />
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" SkinID="mensagem" Text="Este é um label com o Skin aplicado"></asp:Label><br />
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" CssClass="alerta" Text="Este é um label com um estilo aplicado"></asp:Label><br />
    <br />
    <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="Black" DayNameFormat="Shortest" Font-Names="Times New Roman" Font-Size="10pt" ForeColor="Black" Height="220px" NextPrevFormat="FullMonth" TitleFormat="Month" Width="400px">
        <SelectedDayStyle BackColor="#CC3333" ForeColor="White" />
        <TodayDayStyle BackColor="#CCCC99" />
        <SelectorStyle BackColor="#CCCCCC" Font-Bold="True" Font-Names="Verdana" Font-Size="8pt"
            ForeColor="#333333" Width="1%" />
        <DayStyle Width="14%" />
        <OtherMonthDayStyle ForeColor="#999999" />
        <NextPrevStyle Font-Size="8pt" ForeColor="White" />
        <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" ForeColor="#333333"
            Height="10pt" />
        <TitleStyle BackColor="Black" Font-Bold="True" Font-Size="13pt" ForeColor="White"
            Height="14pt" />
    </asp:Calendar>
    <br />
    &nbsp;

</asp:Content>

