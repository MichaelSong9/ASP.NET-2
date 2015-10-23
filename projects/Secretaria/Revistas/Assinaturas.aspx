<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Assinaturas.aspx.cs" Inherits="Revistas_Assinaturas" Title="Untitled Page" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajax" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="DIV_PAGES">
        <asp:Panel ID="pnlPesquisar" runat="server" Height="31%" Width="56%">
            <table>
                <tr>
                    <td style="width: 82px; height: 26px; background-color: #f7f6f3">
                        <asp:Label ID="Label4" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy">Revista/Jornal:</asp:Label></td>
                    <td style="width: 82px; height: 26px; background-color: #f7f6f3">
                        <asp:TextBox ID="txtRevista" runat="server" Enabled="False" TabIndex="1" Width="150px"></asp:TextBox></td>
                    <td style="width: 51px; height: 26px; background-color: #f7f6f3">
                        <asp:Label ID="Label2" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy"
                            Text="Observações:"></asp:Label></td>
                    <td style="width: 165px; height: 26px; background-color: #f7f6f3">
                        <asp:DropDownList ID="DropDownList1" runat="server" Width="158px">
                            <asp:ListItem>Assinatura</asp:ListItem>
                            <asp:ListItem>Promocional</asp:ListItem>
                        </asp:DropDownList></td>
                </tr>
                <tr>
                    <td style="width: 82px; height: 26px; background-color: #ffffff">
                        <asp:Label ID="Label5" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy"
                            Text="Leitores:"></asp:Label></td>
                    <td style="width: 82px; height: 26px; background-color: #ffffff">
                        <asp:TextBox ID="txtLeitores" runat="server" TabIndex="1" Width="150px"></asp:TextBox></td>
                    <td style="width: 51px; height: 26px; background-color: #ffffff">
                        <asp:Label ID="Label6" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy"
                            Text="Renovação:"></asp:Label></td>
                    <td style="width: 165px; height: 26px; background-color: #ffffff">
                        <asp:TextBox ID="txtRenovacao" runat="server" TabIndex="3" Width="150px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 82px; height: 26px; background-color: #f7f6f3">
                        <asp:Label ID="Label1" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy"
                            Text="Tipo:"></asp:Label></td>
                    <td style="width: 82px; height: 26px; background-color: #f7f6f3">
                        <asp:TextBox ID="txtTipo" runat="server" TabIndex="3" Width="150px"></asp:TextBox></td>
                    <td style="width: 51px; height: 26px; background-color: #f7f6f3">
                        <asp:Label ID="Label7" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy"
                            Text="Vigência:"></asp:Label></td>
                    <td style="width: 165px; height: 26px; background-color: #f7f6f3">
                        <asp:TextBox ID="txtVigencia" runat="server" TabIndex="3" Width="150px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 82px; height: 26px; background-color: #ffffff">
                        <asp:Label ID="Label3" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy"
                            Text="Telefone:"></asp:Label></td>
                    <td style="width: 82px; height: 26px; background-color: #ffffff">
                        <asp:TextBox ID="txtTelefone" runat="server" TabIndex="3" Width="150px"></asp:TextBox></td>
                    <td style="width: 51px; height: 26px; background-color: #ffffff">
                        <asp:Label ID="Label8" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy"
                            Text="Tipo:"></asp:Label></td>
                    <td style="width: 165px; height: 26px; background-color: #ffffff">
                        <asp:DropDownList ID="ddlTipo" runat="server" Width="158px">
                            <asp:ListItem>Anual</asp:ListItem>
                            <asp:ListItem>Semestral</asp:ListItem>
                        </asp:DropDownList></td>
                </tr>
                <tr>
                    <td style="width: 82px; height: 24px; background-color: #f7f6f3">
                    </td>
                    <td style="width: 82px; height: 24px; background-color: #f7f6f3">
                    </td>
                    <td style="width: 51px; height: 24px; background-color: #f7f6f3">
                        <asp:Label ID="Label9" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy"
                            Text="Custo:"></asp:Label></td>
                    <td style="width: 165px; height: 24px; background-color: #f7f6f3">
                        <asp:TextBox ID="txtCusto" runat="server" TabIndex="3" Width="150px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 82px; height: 26px; background-color: #ffffff">
                    </td>
                    <td style="width: 82px; height: 26px; background-color: #ffffff; text-align: right">
                        <asp:Button ID="btnSalvar" runat="server" BackColor="White" BorderColor="#507CD1"
                            BorderStyle="Solid" BorderWidth="1px" CausesValidation="False" CommandName="Novo"
                            Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284E98" TabIndex="5" Text="Salvar"
                            Width="80px" /></td>
                    <td colspan="2" style="height: 26px; background-color: #ffffff">
                        <asp:Button ID="btnPesquisar" runat="server" BackColor="White" BorderColor="#507CD1"
                            BorderStyle="Solid" BorderWidth="1px" CausesValidation="False" CommandName="Pesquisar"
                            Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284E98" TabIndex="4" Text="Pesquisar"
                            Width="150px" /></td>
                </tr>
            </table>
        </asp:Panel>
    </div>
</asp:Content>

