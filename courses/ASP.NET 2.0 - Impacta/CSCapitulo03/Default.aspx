<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Src="Favoritos.ascx" TagName="Favoritos" TagPrefix="uc1" %>
<%@ Register Src="Noticias.ascx" TagName="Noticias" TagPrefix="uc2" %>
<%@ Register Src="Agenda.ascx" TagName="Agenda" TagPrefix="uc3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Curso ASP.NET</h1>
        <h2>Capitulo 03 - Web Parts e Aparência do Site</h2>
        <p>
            <asp:WebPartManager ID="WebPartManager1" runat="server">
            </asp:WebPartManager>
            &nbsp;</p>
        <p>
            <br />
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Clique aqui para adicionar itens na sua página</asp:LinkButton>
            &nbsp;</p>
        <p>
            <asp:EditorZone ID="EditorZone1" runat="server" BackColor="#E3EAEB" BorderColor="#CCCCCC"
                BorderWidth="1px" Font-Names="Verdana" Height="130px" Padding="6" Width="433px">
                <HeaderStyle BackColor="#C5BBAF" Font-Bold="True" Font-Size="0.8em" ForeColor="#333333" />
                <LabelStyle Font-Size="0.8em" ForeColor="#333333" />
                <HeaderVerbStyle Font-Bold="False" Font-Size="0.8em" Font-Underline="False" ForeColor="#333333" />
                <PartChromeStyle BorderColor="#C5BBAF" BorderStyle="Solid" BorderWidth="1px" />
                <ZoneTemplate>
                    <asp:AppearanceEditorPart ID="AppearanceEditorPart1" runat="server" />
                </ZoneTemplate>
                <PartStyle BorderColor="#E3EAEB" BorderWidth="5px" />
                <FooterStyle BackColor="#C5BBAF" HorizontalAlign="Right" />
                <EditUIStyle Font-Names="Verdana" Font-Size="0.8em" ForeColor="#333333" />
                <InstructionTextStyle Font-Size="0.8em" ForeColor="#333333" />
                <ErrorStyle Font-Size="0.8em" />
                <VerbStyle Font-Names="Verdana" Font-Size="0.8em" ForeColor="#333333" />
                <EmptyZoneTextStyle Font-Size="0.8em" ForeColor="#333333" />
                <PartTitleStyle Font-Bold="True" Font-Size="0.8em" ForeColor="#333333" />
            </asp:EditorZone>
            <asp:CatalogZone ID="CatalogZone1" runat="server" BackColor="#EFF3FB" BorderColor="#CCCCCC" BorderWidth="1px" Font-Names="Verdana" Padding="6" Width="701px">
                <ZoneTemplate>
                    <asp:DeclarativeCatalogPart ID="DeclarativeCatalogPart1" runat="server">
                        <WebPartsTemplate>
                            <uc3:Agenda Title="Agenda" ID="Agenda2" runat="server" />
                            <uc2:Noticias Title="Noticias" ID="Noticias2" runat="server" />
                            <uc1:Favoritos Title="Favoritos" ID="Favoritos2" runat="server" />
                        </WebPartsTemplate>
                    </asp:DeclarativeCatalogPart>
                </ZoneTemplate>
                <HeaderVerbStyle Font-Bold="False" Font-Size="0.8em" Font-Underline="False" ForeColor="#333333" />
                <PartTitleStyle BackColor="#507CD1" Font-Bold="True" Font-Size="0.8em" ForeColor="White" />
                <PartChromeStyle BorderColor="#D1DDF1" BorderStyle="Solid" BorderWidth="1px" />
                <InstructionTextStyle Font-Size="0.8em" ForeColor="#333333" />
                <PartLinkStyle Font-Size="0.8em" />
                <EmptyZoneTextStyle Font-Size="0.8em" ForeColor="#333333" />
                <LabelStyle Font-Size="0.8em" ForeColor="#333333" />
                <VerbStyle Font-Names="Verdana" Font-Size="0.8em" ForeColor="#333333" />
                <PartStyle BorderColor="#EFF3FB" BorderWidth="5px" />
                <SelectedPartLinkStyle Font-Size="0.8em" />
                <FooterStyle BackColor="#D1DDF1" HorizontalAlign="Right" />
                <HeaderStyle BackColor="#D1DDF1" Font-Bold="True" Font-Size="0.8em" ForeColor="#333333" />
                <EditUIStyle Font-Names="Verdana" Font-Size="0.8em" ForeColor="#333333" />
            </asp:CatalogZone>
            <asp:WebPartZone ID="WebPartZone1" runat="server" BorderColor="#CCCCCC" Font-Names="Verdana"
                Height="172px" LayoutOrientation="Horizontal" Padding="6" Width="677px">
                <PartChromeStyle BackColor="#FFFBD6" BorderColor="#FFCC66" Font-Names="Verdana" ForeColor="#333333" />
                <MenuLabelHoverStyle ForeColor="#FFCC66" />
                <EmptyZoneTextStyle Font-Size="0.8em" />
                <MenuLabelStyle ForeColor="White" />
                <MenuVerbHoverStyle BackColor="#FFFBD6" BorderColor="#CCCCCC" BorderStyle="Solid"
                    BorderWidth="1px" ForeColor="#333333" />
                <HeaderStyle Font-Size="0.7em" ForeColor="#CCCCCC" HorizontalAlign="Center" />
                <ZoneTemplate>
                    <uc1:Favoritos Title="Favoritos"  ID="Favoritos1" runat="server" />
                    <uc2:Noticias  Title="Notícias da Semana"  ID="Noticias1" runat="server" />
                    <uc3:Agenda  Title="Agenda"  ID="Agenda1" runat="server" />
                </ZoneTemplate>
                <MenuVerbStyle BorderColor="#990000" BorderStyle="Solid" BorderWidth="1px" ForeColor="White" />
                <PartStyle Font-Size="0.8em" ForeColor="#333333" />
                <TitleBarVerbStyle Font-Size="0.6em" Font-Underline="False" ForeColor="White" />
                <MenuPopupStyle BackColor="#990000" BorderColor="#CCCCCC" BorderWidth="1px" Font-Names="Verdana"
                    Font-Size="0.6em" />
                <PartTitleStyle BackColor="#990000" Font-Bold="True" Font-Size="0.8em" ForeColor="White" />
            </asp:WebPartZone>
            &nbsp;</p>
        
        
    
    </div>
    </form>
</body>
</html>
