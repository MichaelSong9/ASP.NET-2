<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Default1.aspx.vb" Inherits="Default1" title="Untitled Page" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
    Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="DIV_PAGES">
        &nbsp; &nbsp;
        <div id="divBotoesBody" class="DIV_BOTOES_BODY">
            <asp:ImageButton ID="imbIncluir" runat="server" ImageUrl="~/imagens/Botao_Incluir.gif"
                Style="padding-left: 10px; margin-left: 60px" />
            <asp:ImageButton ID="imbMostrar" runat="server" ImageUrl="~/imagens/Botao_Mostrar.gif" />
            <asp:ImageButton ID="imgSair" runat="server" ImageUrl="~/imagens/Botao_Sair.gif" /></div>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <rsweb:ReportViewer ID="rptComigo" runat="server" Width="892px">
        </rsweb:ReportViewer>
    </div>
</asp:Content>

