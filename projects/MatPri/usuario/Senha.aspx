<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Senha.aspx.vb" Inherits="Usuario_Senha" title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="DIV_PAGES" style="text-align: center">
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <table style="border-right: thin double; border-top: thin double; border-left: thin double; border-bottom: thin double; background-color: #dae5f9; width: 305px; height: 96px;">
            <tr>
                <td colspan="2" style="color: white; height: 14px; background-color: #507cd1">
                    <span style="font-size: 0.9em">Alteração de Senha</span></td>
            </tr>
            <tr>
                <td style="width: 137px; text-align: right;">
                    <asp:Label ID="Label1" runat="server" Text="Senha Atual:"></asp:Label></td>
                <td style="width: 110px; text-align: left;">
                    <asp:TextBox ID="txt_SenhaAtual" runat="server" TextMode="Password" MaxLength="12" TabIndex="1" Width="122px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 137px; text-align: right;">
                    <asp:Label ID="Label2" runat="server" Text="Nova Senha:"></asp:Label></td>
                <td style="width: 110px; text-align: left;">
                    <asp:TextBox ID="txt_NovaSenha" runat="server" TextMode="Password" MaxLength="12" TabIndex="2" Width="122px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 137px; height: 3px; text-align: right;">
                    <asp:Label ID="Label3" runat="server" Text="Confirmar Nova Senha:"></asp:Label></td>
                <td style="width: 110px; height: 3px; text-align: left;">
                    <asp:TextBox ID="txt_ConfirmarNovaSenha" runat="server" TextMode="Password" MaxLength="12" TabIndex="3" Width="122px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 137px; text-align: right; height: 20px;">
                    &nbsp;<asp:Button ID="Button1" runat="server" BackColor="White" BorderColor="#507CD1"
            BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em"
            ForeColor="#284E98" Text="Cancelar"
            ValidationGroup="ChangePassword1" PostBackUrl="~/Pagina_Principal.aspx" TabIndex="5" /></td>
                <td style="width: 110px; text-align: left; height: 20px;">
                    <asp:Button ID="btn_MudarSenha" runat="server" BackColor="White" BorderColor="#507CD1"
            BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em"
            ForeColor="#284E98" Text="Mudar a Senha"
            ValidationGroup="ChangePassword1" TabIndex="4" Width="131px" /></td>
            </tr>
        </table>
        </div>
</asp:Content>

