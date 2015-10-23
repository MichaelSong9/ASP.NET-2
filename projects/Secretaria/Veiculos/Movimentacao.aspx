<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Movimentacao.aspx.cs" Inherits="Veiculos_Movimentacao" Title="Untitled Page" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajax" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="DIV_PAGES" style="text-align: center">
        <div style="width: 920px; height: 141px">
            <br />
            <div style="width: 894px; height: 198px">
                <div style="width: 878px; height: 18px; background-color: mediumblue; text-align: left;">
                    <asp:Label ID="Label7" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy"
                        Style="color: white" Text="Frota"></asp:Label></div>
                <table style="border-right: thin solid; border-top: thin solid; border-left: thin solid;
                    border-bottom: thin solid; width: 877px;" id="tableFrotas">
                    <tr>
                        <td style="width: 82px; height: 7px; background-color: #f7f6f3">
                            <asp:Label ID="Label4" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy">Frota:</asp:Label></td>
                        <td style="width: 52px; height: 7px; background-color: #f7f6f3">
                            <asp:TextBox ID="txtFrota" runat="server" TabIndex="1" Width="50px"></asp:TextBox></td>
                        <td style="width: 64px; height: 7px; background-color: #f7f6f3">
                            <asp:Label ID="Label1" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy">Identificação:</asp:Label></td>
                        <td style="width: 45px; height: 7px; background-color: #f7f6f3">
                            <asp:TextBox ID="txtIdentificacao1" runat="server" TabIndex="2" Width="50px"></asp:TextBox>
                        </td>
                        <td style="width: 73px; height: 7px; background-color: #f7f6f3">
                            <asp:TextBox ID="txtIdentificacao2" runat="server" TabIndex="3" Width="188px"></asp:TextBox></td>
                        <td colspan="3" style="height: 7px; background-color: #f7f6f3; text-align: left;">
                            <asp:TextBox ID="txtIdentificacao3" runat="server" TabIndex="3" Width="140px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td style="width: 82px; height: 1px; background-color: #f7f6f3">
                            <asp:Label ID="Label5" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy"
                                Text="Documento:"></asp:Label></td>
                        <td style="width: 52px; height: 1px; background-color: #f7f6f3">
                            <asp:TextBox ID="txtAssociada" runat="server" TabIndex="4" Width="50px"></asp:TextBox></td>
                        <td style="width: 64px; height: 1px; background-color: #f7f6f3">
                            <asp:Label ID="Label2" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy"
                                Text="Motorista:"></asp:Label></td>
                        <td style="width: 45px; height: 1px; background-color: #ffffff">
                            <asp:DropDownList ID="ddlMotorista" runat="server" Width="54px" style="background-color: #f7f6f3" TabIndex="5">
                            </asp:DropDownList></td>
                        <td colspan="2" style="height: 1px; background-color: #f7f6f3">
                            <asp:Label ID="Label3" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy"
                                Text="Nome:"></asp:Label>
                            &nbsp; &nbsp;
                            <asp:DropDownList ID="ddlNomeMotorista" runat="server" Width="147px" TabIndex="6">
                            </asp:DropDownList></td>
                        <td style="width: 79px; height: 1px; background-color: #f7f6f3">
                            <asp:Label ID="Label6" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy"
                                Text="Nº Ajudantes:"></asp:Label></td>
                        <td style="width: 308px; height: 1px; background-color: #f7f6f3; text-align: left;">
                            <asp:TextBox ID="txtNumeroAjudantes" runat="server" TabIndex="7" Width="50px"></asp:TextBox></td>
                    </tr>
                </table>
                <br />
                <div style="width: 878px; height: 18px; background-color: mediumblue; text-align: left;">
                    <asp:Label ID="Label8" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy"
                        Style="color: white" Text="Data"></asp:Label>
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                    <asp:Label ID="Label9" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy"
                        Style="color: white" Text="Km"></asp:Label>
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                    &nbsp;&nbsp;&nbsp; &nbsp;
                    <asp:Label ID="Label15" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy"
                        Style="color: white" Text="Horas"></asp:Label></div>
                <table style="border-right: thin solid; border-top: thin solid; border-left: thin solid;
                    border-bottom: thin solid" id="tableDataKMHOras">
                    <tr>
                        <td style="width: 37px; height: 13px; background-color: #f7f6f3">
                            <asp:Label ID="lblDataSaida" runat="server" BackColor="Transparent" Font-Bold="True"
                                ForeColor="Navy">Saída:</asp:Label></td>
                        <td style="width: 52px; height: 13px; background-color: #f7f6f3">
                            <asp:TextBox ID="txtDataSaida" runat="server" TabIndex="8" Width="50px"></asp:TextBox></td>
                        <td style="width: 49px; height: 13px; background-color: #f7f6f3">
                            <asp:Label ID="lblDataRetorno" runat="server" BackColor="Transparent" Font-Bold="True"
                                ForeColor="Navy">Retorno:</asp:Label></td>
                        <td style="border-right: thin solid; width: 45px; height: 13px; background-color: #f7f6f3">
                            <asp:TextBox ID="txtDataRetorno" runat="server" TabIndex="9" Width="50px"></asp:TextBox>
                        </td>
                        <td style="width: 36px; height: 13px; background-color: #f7f6f3">
                            <asp:Label ID="Label10" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy">Saída:</asp:Label></td>
                        <td colspan="3" style="height: 13px; background-color: #f7f6f3">
                            <asp:TextBox ID="txtKmSaida" runat="server" TabIndex="10" Width="50px"></asp:TextBox></td>
                        <td style="width: 36px; height: 13px; background-color: #f7f6f3">
                            <asp:Label ID="Label11" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy">Retorno:</asp:Label></td>
                        <td style="width: 36px; height: 13px; background-color: #f7f6f3">
                            <asp:TextBox ID="txtKmRetorno" runat="server" TabIndex="11" Width="50px"></asp:TextBox></td>
                        <td style="width: 36px; height: 13px; background-color: #f7f6f3">
                            <asp:Label ID="Label12" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy">Total:</asp:Label></td>
                        <td style="width: 36px; height: 13px; background-color: #f7f6f3; border-right: thin solid;">
                            <asp:TextBox ID="txtKmTotal" runat="server" TabIndex="12" Width="50px"></asp:TextBox></td>
                        <td style="width: 36px; height: 13px; background-color: #f7f6f3">
                            <asp:Label ID="Label13" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy">Saída:</asp:Label></td>
                        <td style="width: 36px; height: 13px; background-color: #f7f6f3">
                            <asp:TextBox ID="txtHorasSaida" runat="server" TabIndex="13" Width="50px"></asp:TextBox></td>
                        <td style="width: 36px; height: 13px; background-color: #f7f6f3">
                            <asp:Label ID="Label14" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy">Retorno:</asp:Label></td>
                        <td style="width: 36px; height: 13px; background-color: #f7f6f3">
                            <asp:TextBox ID="txtHorasRetorno" runat="server" TabIndex="14" Width="50px"></asp:TextBox></td>
                        <td style="width: 66px; height: 13px; background-color: #f7f6f3">
                            <asp:Label ID="Label16" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy">Total (min):</asp:Label></td>
                        <td style="width: 36px; height: 13px; background-color: #f7f6f3">
                            <asp:TextBox ID="txtTotalHoras" runat="server" TabIndex="15" Width="50px"></asp:TextBox></td>
                    </tr>
                </table><br />
                <div style="width: 878px; height: 18px; background-color: mediumblue; text-align: left;">
                    <asp:Label ID="lblApropriacao" runat="server" BackColor="Transparent" Font-Bold="True"
                        ForeColor="Navy" Style="color: white" Text="Apropriação"></asp:Label></div>
                <table style="border-right: thin solid; border-top: thin solid; border-left: thin solid;
                    border-bottom: thin solid; width: 877px;" id="Table1">
                    <tr>
                        <td style="width: 37px; height: 5px; background-color: #f7f6f3">
                            <asp:Label ID="Label20" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy">Tipo:</asp:Label></td>
                        <td style="height: 5px; background-color: #f7f6f3" colspan="3">
                            <asp:TextBox ID="txtTipoApropriacao" runat="server" TabIndex="15" Width="50px"></asp:TextBox>
                            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                            <asp:Label ID="Label21" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy">Solicitante:</asp:Label>
                            &nbsp;
                            <asp:DropDownList ID="ddlSolicitante" runat="server" Width="147px" TabIndex="16">
                            </asp:DropDownList></td>
                        <td style="width: 84px; height: 5px; background-color: #f7f6f3">
                            <asp:TextBox ID="txtTrafego" runat="server" TabIndex="17" Width="120px"></asp:TextBox></td>
                        <td colspan="3" style="height: 5px; background-color: #f7f6f3; width: 5px; text-align: left;">
                            <asp:Label ID="Label17" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy"
                                Width="117px">Debitar do C.Custos:</asp:Label></td>
                        <td style="width: 13px; height: 5px; background-color: #f7f6f3">
                            <asp:TextBox ID="txtDebitarCCustos" runat="server" TabIndex="18" Width="150px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td style="width: 37px; height: 4px; background-color: #f7f6f3">
                            <asp:Label ID="Label18" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy">Terceiro:</asp:Label></td>
                        <td style="width: 52px; height: 4px; background-color: #f7f6f3">
                            <asp:TextBox ID="txtTerceiros" runat="server" TabIndex="19" Width="188px"></asp:TextBox></td>
                        <td style="width: 49px; height: 4px; background-color: #f7f6f3">
                            <asp:Label ID="Label19" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy">Litros:</asp:Label></td>
                        <td style="border-right: thin solid; width: 45px; height: 4px; background-color: #f7f6f3">
                            <asp:TextBox ID="txtLitros" runat="server" TabIndex="20" Width="50px"></asp:TextBox></td>
                        <td style="width: 84px; height: 4px; background-color: #f7f6f3; text-align: left;">
                            <asp:Label ID="Label22" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy">Cobrar:</asp:Label><asp:DropDownList ID="ddlCobrar" runat="server" Width="70px" TabIndex="21">
                            </asp:DropDownList></td>
                        <td colspan="3" style="width: 5px; height: 4px; background-color: #f7f6f3; text-align: left;">
                            <asp:Label ID="Label23" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy"
                                Width="117px">O/S - O.C:</asp:Label></td>
                        <td style="width: 13px; height: 4px; background-color: #f7f6f3">
                            <asp:TextBox ID="txtOs_OC" runat="server" TabIndex="22" Width="150px"></asp:TextBox></td>
                    </tr>
                </table>
                <br />
                <div style="width: 878px; height: 18px; background-color: mediumblue">
                </div>
                <table style="border-right: thin solid; border-top: thin solid; border-left: thin solid;
                    border-bottom: thin solid" id="Table2">
                    <tr>
                        <td style="width: 37px; height: 12px; background-color: #f7f6f3">
                            <asp:Label ID="Label27" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy"
                                Width="132px">Descrição do Serviço:</asp:Label></td>
                        <td style="width: 53px; height: 12px; background-color: #f7f6f3">
                            <asp:TextBox ID="TextBox1" runat="server" Height="56px" TabIndex="23" TextMode="MultiLine"
                                Width="635px"></asp:TextBox></td>
                        <td style="width: 85px; height: 12px; background-color: #f7f6f3" colspan="10">
                        </td>
                    </tr>
                </table>
                <br />
                <table style="border-right: thin solid; border-top: thin solid; border-left: thin solid;
                    border-bottom: thin solid" id="Table3">
                    <tr>
                        <td style="width: 253px; height: 13px; background-color: #f7f6f3">
                        </td>
                        <td style="width: 53px; height: 13px; background-color: #f7f6f3">
            <asp:Button ID="btnSalvar" runat="server" BackColor="White" BorderColor="#507CD1"
                BorderStyle="Solid" BorderWidth="1px" CausesValidation="False" CommandName="Novo"
                Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284E98" TabIndex="24" Text="Salvar"
                Width="150px" /></td>
                        <td style="width: 82px; height: 13px; background-color: #f7f6f3" colspan="10">
            <asp:Button ID="btnPesquisar" runat="server" BackColor="White" BorderColor="#507CD1"
                BorderStyle="Solid" BorderWidth="1px" CausesValidation="False" CommandName="Pesquisar"
                Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284E98" TabIndex="25" Text="Pesquisar"
                Width="150px" /></td>
                        <td colspan="1" style="width: 306px; height: 13px; background-color: #f7f6f3">
                        </td>
                    </tr>
                </table>
            </div>
            &nbsp;</div>
    </div>
</asp:Content>

