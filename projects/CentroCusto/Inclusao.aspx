<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Inclusao.aspx.vb" Inherits="Inclusao" title="Untitled Page" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="DIV_PAGES">
        <table>
            <tr>
                <td style="width: 110px">
                    <asp:Label ID="lblConta" runat="server" Text="Centro de Custos:"></asp:Label></td>
                <td colspan="2">
                    <asp:TextBox ID="txtCentroCusto" runat="server" CssClass="TEXT_PAGES" Width="110px" MaxLength="11" BackColor="White"></asp:TextBox></td>
            </tr>
        </table>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <cc1:FilteredTextBoxExtender ID="ftbCentroCustos" runat="server" TargetControlID="txtCentroCusto" FilterType = "Custom, Numbers">
        </cc1:FilteredTextBoxExtender>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True"
                    AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="None"
                    BorderWidth="1px" CellPadding="3" DataSourceID="SqlDataSource1" GridLines="Vertical"
                    PageSize="9" Width="959px">
                    <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <Columns>
                        <asp:BoundField DataField="CENTRO" HeaderText="Centro de Custos" SortExpression="CENTRO" />
                        <asp:TemplateField HeaderText="Nome" SortExpression="NOMECENTRO">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("NOMECENTRO") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="lblNome" runat="server" Text='<%# Bind("NOMECENTRO") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Centro Para">
                            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            <ItemTemplate>
                                <asp:TextBox ID="txtCentroPara" runat="server" CssClass="TEXT_PAGES" MaxLength="4" Width="46px"></asp:TextBox>
                                <cc1:FilteredTextBoxExtender ID="ftbCentroPara" runat="server" TargetControlID="txtCentroPara" FilterType = "Custom, Numbers">
                                </cc1:FilteredTextBoxExtender>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                    <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                    <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                    <AlternatingRowStyle BackColor="Gainsboro" />
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString1 %>"
                    ProviderName="<%$ ConnectionStrings:ConnectionString1.ProviderName %>" SelectCommand='SELECT CENTRO, NOMECENTRO FROM INTQCUST.CENTROS1 A WHERE (NOT EXISTS (SELECT CENTRO_DE, NOMECENTRO_DE, CENTRO_PARA FROM DEPARA_CENTROCUSTO C WHERE (CENTRO_DE = A.CENTRO) AND (A.NOMECENTRO = A.NOMECENTRO))) ORDER BY CENTRO'>
                </asp:SqlDataSource>
                &nbsp;
                <div style="z-index: 103; left: 291px; width: 324px; position: absolute; top: 335px;
                    height: 100px">
                    <asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="UpdatePanel1"
                        DisplayAfter="300">
                        <ProgressTemplate>
                            <asp:Panel ID="pnlProcessando" runat="server" BackColor="#B5C7DE" BorderColor="Teal"
                                BorderStyle="Solid" BorderWidth="1px" Height="1px" Width="345px">
                                <img src="imagens/loading.gif" style="width: 15px" />
                                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; <font color="#284e98" face="Verdana"
                                    size="2">Processando sua solicitação...</font>
                            </asp:Panel>
                        </ProgressTemplate>
                    </asp:UpdateProgress>
                </div>
                <br />
                <table id="tblBotoes" style="width: 714px">
                    <tr>
                        <td style="width: 100px">
                        </td>
                        <td style="width: 100px">
                        </td>
                        <td colspan="5" style="background-color: #b5c7de">
                            &nbsp; &nbsp;
                            <asp:ImageButton ID="imbIncluir" runat="server" ImageUrl="~/imagens/Botao_Incluir.gif"
                                OnClick="imbIncluir_Click1" Style="padding-left: 10px; margin-left: 60px" />&nbsp;<asp:ImageButton
                                    ID="imbPesquisar" runat="server" ImageUrl="~/imagens/Botao_Pesquisar.gif" OnClick="imbPesquisar_Click" />&nbsp;<asp:ImageButton
                                        ID="imgSair" runat="server" ImageUrl="~/imagens/Botao_Sair.gif" PostBackUrl="~/Pagina_Principal.aspx" /></td>
                    </tr>
                </table>
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="imbPesquisar" EventName="Click" />
                <asp:AsyncPostBackTrigger ControlID="imbIncluir" EventName="Click" />
                <asp:AsyncPostBackTrigger ControlID="imbPesquisar" EventName="Command" />
            </Triggers>
        </asp:UpdatePanel>
    </div>
</asp:Content>

