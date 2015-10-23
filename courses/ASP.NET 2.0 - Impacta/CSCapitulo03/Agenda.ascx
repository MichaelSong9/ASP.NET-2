<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Agenda.ascx.cs" Inherits="Agenda" %>
<asp:Panel id="Panel1" Width="179px" Height="263px" runat="server">
    <br  />
    <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#999999"
        CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt"
        ForeColor="Black" Height="180px" Width="200px">
        <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White"  />
        <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black"  />
        <SelectorStyle BackColor="#CCCCCC"  />
        <WeekendDayStyle BackColor="#FFFFCC"  />
        <OtherMonthDayStyle ForeColor="#808080"  />
        <NextPrevStyle VerticalAlign="Bottom"  />
        <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt"  />
        <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True"  />
    </asp:Calendar>
</asp:Panel>
