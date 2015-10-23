<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Devolucoes.aspx.cs" Inherits="Correspondencias_Devolucoes" Title="Untitled Page" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajax" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="DIV_PAGES">
        &nbsp;<asp:Panel ID="pnlPesquisar" runat="server" Height="19%" Width="56%">
            <table>
                <tr>
                    <td style="width: 116px; background-color: #f7f6f3">
                        <asp:Label ID="Label4" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy">Data de devolução:</asp:Label></td>
                    <td style="width: 47px; background-color: #f7f6f3">
                        <asp:TextBox ID="txtDataDevolucao" runat="server" Enabled="False" TabIndex="1" Width="100px"></asp:TextBox></td>
                    <td style="width: 119px; background-color: #f7f6f3">
                        <asp:Label ID="Label8" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy">Remetente:</asp:Label></td>
                    <td style="width: 104px; background-color: #f7f6f3">
                        <asp:TextBox ID="txtRemetente" runat="server" TabIndex="3" Width="150px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 116px; background-color: #ffffff">
                        <asp:Label ID="Label7" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy"
                            Text="Tipo:"></asp:Label></td>
                    <td style="width: 47px; background-color: #ffffff">
                        <asp:TextBox ID="txtTipo" runat="server" TabIndex="3" Width="100px"></asp:TextBox></td>
                    <td style="width: 119px; background-color: #ffffff">
                        <asp:Label ID="Label9" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy">Endereço:</asp:Label></td>
                    <td style="width: 104px; background-color: #ffffff">
                        <asp:TextBox ID="txtEndereco" runat="server" TabIndex="3" Width="150px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 116px; background-color: #f7f6f3">
                        <asp:Label ID="Label5" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy">Registro - Sedex:</asp:Label></td>
                    <td style="width: 47px; background-color: #f7f6f3">
                        <asp:TextBox ID="txtRegistroSedex" runat="server" TabIndex="3" Width="100px"></asp:TextBox></td>
                    <td style="width: 119px; background-color: #f7f6f3">
                        <asp:Label ID="Label10" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy">CEP:</asp:Label></td>
                    <td style="width: 104px; background-color: #f7f6f3">
                        <asp:TextBox ID="txtCEP" runat="server" TabIndex="3" Width="150px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 116px; background-color: #ffffff">
                        <asp:Label ID="Label1" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy"
                            Text="Carteiro:"></asp:Label></td>
                    <td style="width: 47px; background-color: #ffffff">
                        <asp:TextBox ID="txtCarteiro" runat="server" TabIndex="3" Width="100px"></asp:TextBox></td>
                    <td style="width: 119px; background-color: #ffffff">
                        <asp:Label ID="Label11" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy">Bairro:</asp:Label></td>
                    <td style="width: 104px; background-color: #ffffff">
                        <asp:TextBox ID="txtBairro" runat="server" TabIndex="3" Width="150px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 116px; background-color: #f7f6f3">
                        <asp:Label ID="Label15" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy"
                            Text="Registro - Carteiro:"></asp:Label></td>
                    <td style="width: 47px; background-color: #f7f6f3">
                        <asp:TextBox ID="txtRegistroCarteiro" runat="server" TabIndex="3" Width="100px"></asp:TextBox></td>
                    <td style="width: 119px; background-color: #f7f6f3">
                        <asp:Label ID="Label12" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy">Cidade:</asp:Label></td>
                    <td style="width: 104px; background-color: #f7f6f3">
                        <asp:TextBox ID="txtCidade" runat="server" TabIndex="3" Width="150px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 116px; background-color: #ffffff">
                        <asp:Label ID="Label3" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy"
                            Text="Registro Nacional:"></asp:Label></td>
                    <td style="width: 47px; background-color: #ffffff">
                        <asp:TextBox ID="txtRegistroNacional" runat="server" TabIndex="3" Width="100px"></asp:TextBox></td>
                    <td style="width: 119px; background-color: #ffffff">
                        <asp:Label ID="Label13" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy">Estado:</asp:Label></td>
                    <td style="width: 104px; background-color: #ffffff">
                        <asp:TextBox ID="txtEstado" runat="server" TabIndex="3" Width="150px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 116px; background-color: #f7f6f3">
                        <asp:Label ID="Label6" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy"
                            Text="Nome:"></asp:Label></td>
                    <td style="width: 47px; background-color: #f7f6f3">
                        <asp:TextBox ID="txtNome" runat="server" TabIndex="3" Width="100px"></asp:TextBox></td>
                    <td style="width: 119px; background-color: #f7f6f3">
                        <asp:Label ID="Label14" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy">Data de recebimento:</asp:Label></td>
                    <td style="width: 104px; background-color: #f7f6f3">
                        <asp:TextBox ID="txtDataRecebimento" runat="server" TabIndex="3" Width="150px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 116px; background-color: #f7f6f3">
                        <asp:Button ID="btnSalvar" runat="server" BackColor="White" BorderColor="#507CD1"
                            BorderStyle="Solid" BorderWidth="1px" CausesValidation="False" CommandName="Novo"
                            Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284E98" TabIndex="5" Text="Salvar"
                            Width="80px" /></td>
                    <td style="width: 47px; background-color: #f7f6f3">
                        <asp:Button ID="btnPesquisar" runat="server" BackColor="White" BorderColor="#507CD1"
                            BorderStyle="Solid" BorderWidth="1px" CausesValidation="False" CommandName="Pesquisar"
                            Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284E98" TabIndex="4" Text="Pesquisar"
                            Width="104px" /></td>
                    <td style="width: 119px; background-color: #f7f6f3">
                    </td>
                    <td style="width: 104px; background-color: #f7f6f3">
                    </td>
                </tr>
            </table>
        </asp:Panel>
        &nbsp; &nbsp;<br />
        &nbsp;
        <div style="z-index: 101; left: 545px; width: 165px; position: absolute; top: 225px;
            height: 234px">
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
        </div>
    </div>
</asp:Content>

