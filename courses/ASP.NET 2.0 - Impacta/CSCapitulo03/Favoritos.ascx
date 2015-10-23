<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Favoritos.ascx.cs" Inherits="Favoritos" %>
<asp:Panel id="Panel1" Width="205px" Height="270px" runat="server">
    <br  />
    <span style="color: #2f4f4f"><strong>Meus Favoritos</strong><br  />
    </span>
    <br  />
    <br  />
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="http://www.microsoft.com.br">Microsoft</asp:HyperLink><br  />
    <br  />
    <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="http://www.yahoo.com.br">Yahoo</asp:HyperLink><br  />
    <br  />
    <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="http://www.asp.net">ASP.NET</asp:HyperLink><br  />
    <br  />
    <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="http://www.impacta.com.br">Site da Impacta</asp:HyperLink><br  />
</asp:Panel>
