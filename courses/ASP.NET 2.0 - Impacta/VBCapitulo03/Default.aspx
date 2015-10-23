<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<%@ Register Src="Agenda.ascx" TagName="Agenda" TagPrefix="uc1" %>
<%@ Register Src="Favoritos.ascx" TagName="Favoritos" TagPrefix="uc2" %>
<%@ Register Src="Noticias.ascx" TagName="Noticias" TagPrefix="uc3" %>

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
            Capitulo 03 - Web Parts e aparência do Site</h2>
        <p>
            <asp:WebPartManager ID="WebPartManager1" runat="server">
            </asp:WebPartManager>
            &nbsp;</p>
        <p>
            <asp:LinkButton ID="LinkButton1" runat="server">Clique aqui para adicionar itens na sua página</asp:LinkButton>
        </p>
        <p>
            <asp:CatalogZone ID="CatalogZone1" runat="server" BackColor="#E3EAEB"
                BorderColor="#CCCCCC" BorderWidth="1px" Font-Names="Verdana" Height="182px" Padding="6"
                Width="634px">
                <HeaderVerbStyle Font-Bold="False" Font-Size="0.8em" Font-Underline="False" ForeColor="#333333" />
                <PartTitleStyle BackColor="#1C5E55" Font-Bold="True" Font-Size="0.8em" ForeColor="White" />
                <PartChromeStyle BorderColor="#C5BBAF" BorderStyle="Solid" BorderWidth="1px" />
                <InstructionTextStyle Font-Size="0.8em" ForeColor="#333333" />
                <PartLinkStyle Font-Size="0.8em" />
                <EmptyZoneTextStyle Font-Size="0.8em" ForeColor="#333333" />
                <LabelStyle Font-Size="0.8em" ForeColor="#333333" />
                <VerbStyle Font-Names="Verdana" Font-Size="0.8em" ForeColor="#333333" />
                <ZoneTemplate>
                    <asp:DeclarativeCatalogPart ID="DeclarativeCatalogPart1" runat="server">
                        <WebPartsTemplate>
                            <uc1:Agenda Title="Agenda" ID="Agenda2" runat="server" />
                            <uc3:Noticias Title="Noticias"   ID="Noticias2" runat="server" />
                            <uc2:Favoritos Title="Favoritos"  ID="Favoritos2" runat="server" />
                        </WebPartsTemplate>
                    </asp:DeclarativeCatalogPart>
                </ZoneTemplate>
                <PartStyle BorderColor="#E3EAEB" BorderWidth="5px" />
                <SelectedPartLinkStyle Font-Size="0.8em" />
                <FooterStyle BackColor="#C5BBAF" HorizontalAlign="Right" />
                <HeaderStyle BackColor="#C5BBAF" Font-Bold="True" Font-Size="0.8em" ForeColor="#333333" />
                <EditUIStyle Font-Names="Verdana" Font-Size="0.8em" ForeColor="#333333" />
            </asp:CatalogZone>
        </p>
        <p>
            <asp:WebPartZone ID="WebPartZone1" runat="server" BorderColor="#CCCCCC" Font-Names="Verdana"
                Height="230px" LayoutOrientation="Horizontal" Padding="6" Width="619px">
                <PartChromeStyle BackColor="#F7F6F3" BorderColor="#E2DED6" Font-Names="Verdana" ForeColor="White" />
                <MenuLabelHoverStyle ForeColor="#E2DED6" />
                <EmptyZoneTextStyle Font-Size="0.8em" />
                <MenuLabelStyle ForeColor="White" />
                <MenuVerbHoverStyle BackColor="#F7F6F3" BorderColor="#CCCCCC" BorderStyle="Solid"
                    BorderWidth="1px" ForeColor="#333333" />
                <HeaderStyle Font-Size="0.7em" ForeColor="#CCCCCC" HorizontalAlign="Center" />
                <ZoneTemplate>
                    <uc1:Agenda   Title="Agenda Semanal"  ID="Agenda1" runat="server" />
                    <uc2:Favoritos Title="Favoritos"   ID="Favoritos1" runat="server" />
                    <uc3:Noticias  Title="Notícias"  ID="Noticias1" runat="server" />
                </ZoneTemplate>
                <MenuVerbStyle BorderColor="#5D7B9D" BorderStyle="Solid" BorderWidth="1px" ForeColor="White" />
                <PartStyle Font-Size="0.8em" ForeColor="#333333" />
                <TitleBarVerbStyle Font-Size="0.6em" Font-Underline="False" ForeColor="White" />
                <MenuPopupStyle BackColor="#5D7B9D" BorderColor="#CCCCCC" BorderWidth="1px" Font-Names="Verdana"
                    Font-Size="0.6em" />
                <PartTitleStyle BackColor="#5D7B9D" Font-Bold="True" Font-Size="0.8em" ForeColor="White" />
            </asp:WebPartZone>
            &nbsp;</p>
    
    </div>
    </form>
</body>
</html>
