<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Motorista.aspx.cs" Inherits="Veiculos_Motorista" Title="Untitled Page" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajax" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="DIV_PAGES" style="text-align: center">
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Panel ID="pnlPesquisar" runat="server" Height="21%" Width="37%">
            <table style="border-right: thin solid; border-top: thin solid; border-left: thin solid; border-bottom: thin solid">
                <tr>
                    <td style="width: 141px; background-color: #f7f6f3; text-align: left;">
                        <asp:Label ID="Label4" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy">Motorista:</asp:Label></td>
                    <td style="width: 162px; background-color: #f7f6f3">
                        <asp:TextBox ID="txtMotorista" runat="server" TabIndex="1" Width="180px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 141px; background-color: #f7f6f3; text-align: left;">
                        <asp:Label ID="Label5" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy"
                            Text="Classificação:"></asp:Label></td>
                    <td style="width: 162px; background-color: #f7f6f3">
                        <asp:DropDownList ID="ddlClassificacao" runat="server" TabIndex="2" Width="185px">
                            <asp:ListItem>Fixo</asp:ListItem>
                            <asp:ListItem>Extra</asp:ListItem>
                        </asp:DropDownList></td>
                </tr>
                <tr>
                    <td style="width: 141px; background-color: #f7f6f3; text-align: left;">
                        <asp:Label ID="Label6" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy"
                            Text="Tipo:"></asp:Label></td>
                    <td style="width: 162px; background-color: #f7f6f3">
                        <asp:DropDownList ID="ddlTipo" runat="server" TabIndex="3" Width="185px">
                            <asp:ListItem>CCL</asp:ListItem>
                            <asp:ListItem>Free-Lance</asp:ListItem>
                        </asp:DropDownList></td>
                </tr>
            </table>
            <br />
            <table id="Table3" style="border-right: thin solid; border-top: thin solid; border-left: thin solid;
                width: 343px; border-bottom: thin solid">
                <tr>
                    <td style="width: 253px; height: 13px; background-color: #f7f6f3">
                    </td>
                    <td style="width: 53px; height: 13px; background-color: #f7f6f3">
                        <asp:Button ID="btnSalvar" runat="server" BackColor="White" BorderColor="#507CD1"
                            BorderStyle="Solid" BorderWidth="1px" CausesValidation="False" CommandName="Novo"
                            Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284E98" TabIndex="4" Text="Salvar"
                            Width="150px" /></td>
                    <td colspan="10" style="width: 82px; height: 13px; background-color: #f7f6f3">
                        <asp:Button ID="btnPesquisar" runat="server" BackColor="White" BorderColor="#507CD1"
                            BorderStyle="Solid" BorderWidth="1px" CausesValidation="False" CommandName="Pesquisar"
                            Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284E98" TabIndex="5" Text="Pesquisar"
                            Width="150px" /></td>
                    <td colspan="1" style="width: 328px; height: 13px; background-color: #f7f6f3">
                    </td>
                </tr>
            </table>
        </asp:Panel>
    </div>
</asp:Content>

