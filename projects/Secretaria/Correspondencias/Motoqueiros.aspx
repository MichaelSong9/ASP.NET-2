<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Motoqueiros.aspx.cs" Inherits="Correspondencias_Motoqueiros" Title="Untitled Page" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajax" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="DIV_PAGES">
        <asp:Panel ID="pnlPesquisar" runat="server" Height="21%" Width="37%">
            <table>
                <tr>
                    <td style="width: 82px; height: 26px; background-color: #f7f6f3">
                        <asp:Label ID="Label4" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy">Data:</asp:Label></td>
                    <td style="width: 165px; height: 26px; background-color: #f7f6f3">
                        <asp:TextBox ID="txtData" runat="server" Enabled="False" TabIndex="1" Width="215px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 82px; height: 26px; background-color: #ffffff">
                        <asp:Label ID="Label5" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy"
                            Text="Remetente:"></asp:Label></td>
                    <td style="width: 165px; height: 26px; background-color: #ffffff">
                        <asp:TextBox ID="txtRemetente" runat="server" TabIndex="1" Width="215px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 82px; height: 26px; background-color: #f7f6f3">
                        <asp:Label ID="Label1" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy"
                            Text="Tipo:"></asp:Label></td>
                    <td style="width: 165px; height: 26px; background-color: #f7f6f3">
                        <asp:TextBox ID="txtDestinatario" runat="server" TabIndex="3" Width="215px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 82px; height: 26px; background-color: #ffffff">
                        <asp:Label ID="Label3" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy"
                            Text="Responsável:"></asp:Label></td>
                    <td style="width: 165px; height: 26px; background-color: #ffffff">
                        <asp:TextBox ID="txtResponsavel" runat="server" TabIndex="3" Width="215px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 82px; height: 24px; background-color: #f7f6f3">
                        <asp:Label ID="Label2" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy"
                            Text="Departamento:"></asp:Label></td>
                    <td style="width: 165px; height: 24px; background-color: #f7f6f3">
                        <asp:DropDownList ID="ddlDepto" runat="server" Width="222px">
                            <asp:ListItem></asp:ListItem>
                            <asp:ListItem>ADC</asp:ListItem>
                            <asp:ListItem Value="ADI">Administra&#231;&#227;o Industrial</asp:ListItem>
                            <asp:ListItem Value="AUD">Auditoria Interna</asp:ListItem>
                            <asp:ListItem Value="BB">Revista Balde Branco</asp:ListItem>
                            <asp:ListItem Value="DCF">Cont&#225;bil e Financeiro</asp:ListItem>
                            <asp:ListItem Value="DCO">Comercial</asp:ListItem>
                            <asp:ListItem Value="DEM">Engenharia e Manuten&#231;&#227;o</asp:ListItem>
                            <asp:ListItem Value="DGE">Diretoria</asp:ListItem>
                            <asp:ListItem Value="DGQ">Garantia da Qualidade</asp:ListItem>
                            <asp:ListItem Value="DIF">Inform&#225;tica</asp:ListItem>
                            <asp:ListItem Value="DJU">Jur&#237;dico</asp:ListItem>
                            <asp:ListItem Value="DPR">Desenvolvimento de Produtos</asp:ListItem>
                            <asp:ListItem Value="DRH">Recursos Humanos</asp:ListItem>
                            <asp:ListItem Value="DVE">Vendas Empreiteiros</asp:ListItem>
                            <asp:ListItem Value="FAT">Faturamento</asp:ListItem>
                            <asp:ListItem Value="DVE">Planej. e Adm. Vendas</asp:ListItem>
                            <asp:ListItem Value="PRE">Presid&#234;ncia</asp:ListItem>
                            <asp:ListItem Value="REP">Representantes</asp:ListItem>
                            <asp:ListItem Value="SAC">Servi&#231;o de Atend. Consumidor</asp:ListItem>
                            <asp:ListItem Value="SAG">Arquivo Geral</asp:ListItem>
                            <asp:ListItem Value="SAI">Interior e Associadas</asp:ListItem>
                            <asp:ListItem Value="SAL">Almoxarifado</asp:ListItem>
                            <asp:ListItem Value="SFS">Food Service</asp:ListItem>
                            <asp:ListItem Value="SGC">Grandes Contas</asp:ListItem>
                            <asp:ListItem Value="SMK">Marketing</asp:ListItem>
                            <asp:ListItem Value="SPV">Pr&#233;-Vendas</asp:ListItem>
                            <asp:ListItem Value="STR">Transportes</asp:ListItem>
                            <asp:ListItem Value="STV">Televendas</asp:ListItem>
                            <asp:ListItem Value="SUP">Suprimentos</asp:ListItem>
                            <asp:ListItem Value="SVD">Vendas Diretas</asp:ListItem>
                            <asp:ListItem Value="TUT">Telefones &#218;teis</asp:ListItem>
                            <asp:ListItem Value="UC">Unidade Central</asp:ListItem>
                        </asp:DropDownList></td>
                </tr>
                <tr>
                    <td style="width: 82px; height: 26px; background-color: #ffffff">
                        <asp:Label ID="Label6" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy"
                            Text="Nome:"></asp:Label></td>
                    <td style="width: 165px; height: 26px; background-color: #ffffff">
                        <asp:TextBox ID="txtNome" runat="server" TabIndex="3" Width="215px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 82px; height: 20px; background-color: #f7f6f3">
                        <asp:Button ID="btnSalvar" runat="server" BackColor="White" BorderColor="#507CD1"
                            BorderStyle="Solid" BorderWidth="1px" CausesValidation="False" CommandName="Novo"
                            Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284E98" TabIndex="5" Text="Salvar"
                            Width="80px" /></td>
                    <td style="width: 165px; height: 20px; background-color: #f7f6f3">
                        <asp:Button ID="btnPesquisar" runat="server" BackColor="White" BorderColor="#507CD1"
                            BorderStyle="Solid" BorderWidth="1px" CausesValidation="False" CommandName="Pesquisar"
                            Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284E98" TabIndex="4" Text="Pesquisar"
                            Width="222px" /></td>
                </tr>
            </table>
        </asp:Panel>
    </div>
</asp:Content>

