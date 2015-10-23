<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Frota.aspx.cs" Inherits="Veiculos_Frota" Title="Untitled Page" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajax" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="DIV_PAGES" style="text-align: center">
        <br />
        <br />
        <br />
        <br />
        <asp:Panel ID="pnlPesquisar" runat="server" Height="19%" Width="67%">
            <table style="border-right: thin solid; border-top: thin solid; border-left: thin solid; border-bottom: thin solid; background-color: #f7f6f3;">
                <tr>
                    <td style="width: 38px; background-color: #f7f6f3">
                        <asp:Label ID="Label4" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy">Veículo:</asp:Label></td>
                    <td style="width: 47px; background-color: #f7f6f3">
                        <asp:TextBox ID="txtCodVeiculo" runat="server" TabIndex="1" Width="100px"></asp:TextBox></td>
                    <td style="width: 28px; background-color: #f7f6f3">
                        <asp:Label ID="Label2" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy">Ano:</asp:Label></td>
                    <td style="width: 104px; background-color: #f7f6f3">
                        <asp:TextBox ID="txtAno" runat="server" TabIndex="2" Width="100px"></asp:TextBox></td>
                    <td style="width: 34px; background-color: #f7f6f3">
                        <asp:Label ID="Label7" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy"
                            Text="Placa:"></asp:Label></td>
                    <td style="width: 104px; background-color: #f7f6f3">
                        <asp:TextBox ID="txtPlaca" runat="server" TabIndex="3" Width="100px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 38px; background-color: #f7f6f3; text-align: left;">
                        <asp:Label ID="Label5" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy">Marca:</asp:Label></td>
                    <td style="width: 47px; background-color: #f7f6f3">
                        <asp:TextBox ID="txtMarca" runat="server" TabIndex="4" Width="100px"></asp:TextBox></td>
                    <td style="width: 28px; background-color: #f7f6f3; text-align: left;">
                        <asp:Label ID="Label10" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy">Modelo:</asp:Label></td>
                    <td style="width: 104px; background-color: #f7f6f3">
                        <asp:TextBox ID="txtModelo" runat="server" TabIndex="5" Width="100px"></asp:TextBox></td>
                    <td style="width: 34px; background-color: #f7f6f3">
                        <asp:Label ID="Label1" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy"
                            Text="Combustível:"></asp:Label></td>
                    <td style="width: 104px; background-color: #f7f6f3">
                        <asp:TextBox ID="txtCombustivel" runat="server" TabIndex="6" Width="100px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 38px; background-color: #f7f6f3">
                        <asp:Label ID="Label15" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy"
                            Text="Carroceria:"></asp:Label></td>
                    <td style="width: 47px; background-color: #f7f6f3">
                        <asp:TextBox ID="txtCarroceria" runat="server" TabIndex="7" Width="100px"></asp:TextBox></td>
                    <td style="width: 28px; background-color: #f7f6f3">
                        <asp:Label ID="Label12" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy">Refrigeração:</asp:Label></td>
                    <td style="width: 104px; background-color: #f7f6f3">
                        <asp:TextBox ID="txtRefrigeracao" runat="server" TabIndex="8" Width="100px"></asp:TextBox></td>
                    <td style="width: 34px; background-color: #f7f6f3">
                        <asp:Label ID="Label3" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy"
                            Text="Chassis:"></asp:Label></td>
                    <td style="width: 104px; background-color: #f7f6f3">
                        <asp:TextBox ID="txtChassis" runat="server" TabIndex="9" Width="100px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 38px; background-color: #f7f6f3; text-align: left;">
                        <asp:Label ID="Label6" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy"
                            Text="Tacógrafo:"></asp:Label></td>
                    <td style="width: 47px; background-color: #f7f6f3">
                        <asp:TextBox ID="txtTacografo" runat="server" TabIndex="10" Width="100px"></asp:TextBox></td>
                    <td style="width: 28px; background-color: #f7f6f3; text-align: left;">
                        <asp:Label ID="Label14" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy">Tipo:</asp:Label></td>
                    <td style="width: 104px; background-color: #f7f6f3">
                        <asp:TextBox ID="txtTipo" runat="server" TabIndex="11" Width="100px"></asp:TextBox></td>
                    <td style="width: 34px; background-color: #f7f6f3; text-align: left;">
                        <asp:Label ID="Label8" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy"
                            Text="Unidade:"></asp:Label></td>
                    <td style="width: 104px; background-color: #f7f6f3">
                        <asp:TextBox ID="txtUnidade" runat="server" TabIndex="12" Width="100px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 38px; height: 1px; background-color: #f7f6f3">
                        <asp:Label ID="Label11" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy"
                            Text="Capacidade:"></asp:Label></td>
                    <td style="width: 47px; height: 1px; background-color: #f7f6f3">
                        <asp:TextBox ID="txtCapacidade" runat="server" TabIndex="13" Width="100px"></asp:TextBox></td>
                    <td style="width: 28px; height: 1px; background-color: #f7f6f3">
                        <asp:Label ID="Label13" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy"
                            Text="Tonelada/Litros"></asp:Label></td>
                    <td style="width: 104px; height: 1px; background-color: #f7f6f3">
                    </td>
                    <td style="width: 34px; height: 1px; background-color: #f7f6f3">
                        <asp:Label ID="Label9" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy">Local:</asp:Label></td>
                    <td style="width: 104px; height: 1px; background-color: #f7f6f3">
                        <asp:TextBox ID="txtLocal" runat="server" TabIndex="14" Width="100px"></asp:TextBox></td>
                </tr>
            </table>
            <br />
            <table id="Table3" style="border-right: thin solid; border-top: thin solid; border-left: thin solid;
                width: 571px; border-bottom: thin solid">
                <tr>
                    <td style="width: 253px; height: 13px; background-color: #f7f6f3">
                    </td>
                    <td style="width: 53px; height: 13px; background-color: #f7f6f3">
                        <asp:Button ID="btnSalvar" runat="server" BackColor="White" BorderColor="#507CD1"
                            BorderStyle="Solid" BorderWidth="1px" CausesValidation="False" CommandName="Novo"
                            Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284E98" TabIndex="15" Text="Salvar"
                            Width="150px" /></td>
                    <td colspan="10" style="width: 82px; height: 13px; background-color: #f7f6f3">
                        <asp:Button ID="btnPesquisar" runat="server" BackColor="White" BorderColor="#507CD1"
                            BorderStyle="Solid" BorderWidth="1px" CausesValidation="False" CommandName="Pesquisar"
                            Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284E98" TabIndex="16" Text="Pesquisar"
                            Width="150px" /></td>
                    <td colspan="1" style="width: 328px; height: 13px; background-color: #f7f6f3">
                    </td>
                </tr>
            </table>
        </asp:Panel>
    </div>
</asp:Content>

