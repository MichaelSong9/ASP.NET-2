<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="ControlarListaPreco.aspx.cs" Inherits="ControlarListaPreco" Title="Pgto Produtores - Controlar Lista de Preço" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Assembly="System.Web.Extensions, Version=1.0.61025.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"
    Namespace="System.Web.UI" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div style="z-index: 101; left: 508px; width: 136px; position: absolute; top: 287px;
        height: 170px">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <cc1:ModalPopupExtender ID="ModalPopupExtenderListaPreco" runat="server" BackgroundCssClass="MODALBACKGROUND"
            PopupControlID="pnlGridView" TargetControlID="btnAtivarModalPopup">
        </cc1:ModalPopupExtender>
        <cc1:ModalPopupExtender ID="ModalPopupExtenderPesquisar" runat="server" BackgroundCssClass="MODALBACKGROUND"
            PopupControlID="pnlPesquisar" TargetControlID="btnChamarModalPesquisar">
        </cc1:ModalPopupExtender>
        <cc1:MaskedEditExtender ID="MaskedEditExtender1" runat="server" CultureAMPMPlaceholder=""
            CultureCurrencySymbolPlaceholder="R$ " CultureDateFormat="DMY" CultureDatePlaceholder="/"
            CultureDecimalPlaceholder="," CultureName="pt-BR" CultureThousandsPlaceholder="."
            CultureTimePlaceholder=":" Enabled="True" ErrorTooltipEnabled="True" Mask="99/99/9999"
            MaskType="Date" TargetControlID="txtDataInicial">
        </cc1:MaskedEditExtender>
        <cc1:MaskedEditExtender ID="MaskedEditExtender2" runat="server" CultureAMPMPlaceholder=""
            CultureCurrencySymbolPlaceholder="R$ " CultureDateFormat="DMY" CultureDatePlaceholder="/"
            CultureDecimalPlaceholder="," CultureName="pt-BR" CultureThousandsPlaceholder="."
            CultureTimePlaceholder=":" Enabled="True" ErrorTooltipEnabled="True" Mask="99/99/9999"
            MaskType="Date" TargetControlID="txtDataFinal">
        </cc1:MaskedEditExtender>
        <cc1:MaskedEditExtender ID="MaskedEditExtender3" runat="server" CultureAMPMPlaceholder=""
            CultureCurrencySymbolPlaceholder="R$ " CultureDateFormat="DMY" CultureDatePlaceholder="/"
            CultureDecimalPlaceholder="," CultureName="pt-BR" CultureThousandsPlaceholder="."
            CultureTimePlaceholder=":" Enabled="True" ErrorTooltipEnabled="True" Mask="99/99/9999"
            MaskType="Date" TargetControlID="txtDataInicialPesq">
        </cc1:MaskedEditExtender>
        <cc1:MaskedEditExtender ID="MaskedEditExtender4" runat="server" CultureAMPMPlaceholder=""
            CultureCurrencySymbolPlaceholder="R$ " CultureDateFormat="DMY" CultureDatePlaceholder="/"
            CultureDecimalPlaceholder="," CultureName="pt-BR" CultureThousandsPlaceholder="."
            CultureTimePlaceholder=":" Enabled="True" ErrorTooltipEnabled="True" Mask="99/99/9999"
            MaskType="Date" TargetControlID="txtDataFinalPesq">
        </cc1:MaskedEditExtender>
    </div>
    <table>
        <tr>
            <td style="width: 78px; background-color: #f7f7f7">
                <asp:Label ID="Label5" runat="server" Text="Período"></asp:Label></td>
            <td style="width: 154px; background-color: #f7f7f7">
                <asp:DropDownList ID="ddlPeriodo" runat="server" Width="350px" AutoPostBack="True" OnSelectedIndexChanged="ddlPeriodo_SelectedIndexChanged">
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td style="width: 78px; background-color: #f7f7f7;">
                <asp:Label ID="lblRegiao" runat="server" Text="Região"></asp:Label></td>
            <td style="width: 154px; background-color: #f7f7f7;">
                <asp:DropDownList ID="ddlRegiao" runat="server" Width="350px" AutoPostBack="True" OnSelectedIndexChanged="ddlRegiao_SelectedIndexChanged">
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td style="width: 78px; background-color: #f7f7f7">
                <asp:Label ID="Label1" runat="server" Text="Cooperativa"></asp:Label></td>
            <td style="width: 154px; background-color: #f7f7f7">
                <asp:DropDownList ID="ddlCooperativa" runat="server" Width="350px" AutoPostBack="True" OnSelectedIndexChanged="ddlCooperativa_SelectedIndexChanged">
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td style="width: 78px; background-color: #f7f7f7">
                <asp:Label ID="lblPropriedade" runat="server" Text="Propriedade"></asp:Label></td>
            <td style="width: 154px; background-color: #f7f7f7">
                <asp:DropDownList ID="ddlPropriedade" runat="server" Width="350px" AutoPostBack="True" OnSelectedIndexChanged="ddlPropriedade_SelectedIndexChanged">
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td style="width: 78px; background-color: #f7f7f7">
                <asp:Label ID="Label2" runat="server" Text="Produtor"></asp:Label></td>
            <td style="width: 154px; background-color: #f7f7f7">
                <asp:DropDownList ID="ddlProdutor" runat="server" Width="350px" AutoPostBack="True" OnSelectedIndexChanged="ddlProdutor_SelectedIndexChanged">
                </asp:DropDownList></td>
        </tr>
    </table>
    <table style="border-bottom-style: none">
        <tr>
            <td style="width: 78px; height: 7px; background-color: #f7f7f7">
                <asp:Label ID="lblDt_Inicio" runat="server" Text="Data Inicial"></asp:Label></td>
            <td colspan="2" style="width: 103px; height: 7px; background-color: #f7f7f7">
                <asp:TextBox ID="txtDataInicial" runat="server" Width="80px"></asp:TextBox><cc1:MaskedEditValidator ID="MaskedEditValidator1" runat="server" ControlExtender="MaskedEditExtender1"
                    ControlToValidate="txtDataInicial" ErrorMessage="*" InvalidValueBlurredMessage="*"
                    InvalidValueMessage="Data Inválida" SetFocusOnError="True"></cc1:MaskedEditValidator></td>
            <td style="width: 75px; height: 7px; background-color: #f7f7f7">
                <asp:Label ID="lblDt_Final" runat="server" Text="Data Final"></asp:Label></td>
            <td colspan="2" style="width: 165px; height: 7px; background-color: #f7f7f7">
                <asp:TextBox ID="txtDataFinal" runat="server" Width="80px"></asp:TextBox><cc1:MaskedEditValidator ID="MaskedEditValidator2" runat="server" ControlExtender="MaskedEditExtender1"
                    ControlToValidate="txtDataFinal" ErrorMessage="*" InvalidValueBlurredMessage="*"
                    InvalidValueMessage="Data Inválida" SetFocusOnError="True"></cc1:MaskedEditValidator></td>
        </tr>
        <tr>
            <td style="width: 78px; height: 12px; background-color: #f7f7f7">
                <asp:Label ID="lblVolIni" runat="server" Text="Volume Inicial"></asp:Label></td>
            <td colspan="2" style="width: 103px; height: 12px; background-color: #f7f7f7">
                <asp:TextBox ID="txtVolInicial" runat="server" onkeyup="formataValor(this,event);"
                    Style="text-align: left" Width="80px"></asp:TextBox></td>
            <td style="width: 75px; height: 12px; background-color: #f7f7f7">
                <asp:Label ID="lblVolFinal" runat="server" Text="Volume Final"></asp:Label></td>
            <td colspan="2" style="width: 165px; height: 12px; background-color: #f7f7f7">
                <asp:TextBox ID="txtVolFinal" runat="server" onkeyup="formataValor(this,event);"
                    Style="text-align: left" Width="80px"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 78px; height: 17px; background-color: #f7f7f7">
                <asp:Label ID="lblTpLeite" runat="server" Text="Tipo do Leite"></asp:Label></td>
            <td style="width: 88px; height: 17px; background-color: #f7f7f7">
                <asp:DropDownList ID="ddlTipoLeite" runat="server" Width="87px">
                </asp:DropDownList></td>
            <td colspan="4" style="height: 17px; background-color: #f7f7f7">
            </td>
        </tr>
        <tr>
            <td style="width: 78px; height: 11px; background-color: #f7f7f7">
                <asp:Label ID="lblValorUnitario" runat="server" Text="Valor Unitário"></asp:Label></td>
            <td style="width: 88px; height: 11px; background-color: #f7f7f7">
                <asp:TextBox ID="txtValUnitario" runat="server" onkeyup="formataValor(this,event);"
                    Style="text-align: left" Width="80px"></asp:TextBox></td>
            <td colspan="4" style="height: 11px; background-color: #f7f7f7">
            </td>
        </tr>
    </table>
    <br />
    <asp:Button ID="btnInserir" runat="server" Text="Inserir" OnClick="btnInserir_Click"
        Width="100px" />
    <asp:Button ID="btnAtualizar" runat="server" OnClick="btnAtualizar_Click" Text="Atualizar"
        Width="100px" Enabled="False" />
    <asp:Button ID="btnPesquisar" runat="server" Text="Pesquisar" Width="100px" OnClick="btnPesquisar_Click"
        CausesValidation="False" />
    <asp:Button ID="btnLimpar" runat="server" OnClick="btnLimpar_Click" Text="Limpar"
        Width="100px" /><br />
    <asp:Button ID="btnChamarModalPesquisar" runat="server" BackColor="Transparent" BorderColor="Transparent"
        BorderStyle="None" ForeColor="Transparent" Width="1px" /><br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <asp:Panel ID="pnlPesquisar" runat="server" Height="350px" ScrollBars="Auto" Width="340px"
        BackColor="White" ForeColor="White" BorderStyle="Outset">
        <table>
            <tr>
                <td style="width: 302px; background-color: white; text-align: center; height: 1px;">
                    <asp:Label ID="lblPesquisar" runat="server" Text="Pesquisar" ForeColor="Black"></asp:Label></td>
                <td style="width: 24px; background-color: white; height: 1px;">
                    &nbsp;<asp:ImageButton ID="imbSairPesq" runat="server" ImageUrl="~/App_Themes/images/fechar.jpg"
                        OnClick="imbSairPesq_Click" /></td>
            </tr>
        </table>
        <br />
        <table>
            <tr>
                <td style="width: 74px; background-color: #f7f7f7;">
                    <asp:Label ID="lblRegiaoPesq" runat="server" Text="Região" ForeColor="Black"></asp:Label></td>
                <td style="width: 193px; background-color: #f7f7f7;">
                    <asp:DropDownList ID="ddlRegiaoPesq" runat="server" Width="200px" AutoPostBack="True" CausesValidation="True" OnSelectedIndexChanged="ddlRegiaoPesq_SelectedIndexChanged">
                    </asp:DropDownList></td>
                <td style="width: 46px; background-color: #f7f7f7">
                </td>
            </tr>
            <tr>
                <td style="width: 74px; background-color: #f7f7f7">
                    <asp:Label ID="Label3" runat="server" ForeColor="Black" Text="Cooperativa"></asp:Label></td>
                <td style="width: 193px; background-color: #f7f7f7">
                    <asp:DropDownList ID="ddlCooperativaPesq" runat="server" Width="200px" AutoPostBack="True" CausesValidation="True" OnSelectedIndexChanged="ddlCooperativaPesq_SelectedIndexChanged">
                    </asp:DropDownList></td>
                <td style="width: 46px; background-color: #f7f7f7">
                </td>
            </tr>
            <tr>
                <td style="width: 74px; background-color: #f7f7f7">
                    <asp:Label ID="lblPropriedPesq" runat="server" ForeColor="Black" Text="Propriedade"></asp:Label></td>
                <td style="width: 193px; background-color: #f7f7f7">
                    <asp:DropDownList ID="ddlPropriedPesq" runat="server" Width="200px" AutoPostBack="True" CausesValidation="True" OnSelectedIndexChanged="ddlPropriedPesq_SelectedIndexChanged">
                    </asp:DropDownList></td>
                <td style="width: 46px; background-color: #f7f7f7">
                </td>
            </tr>
            <tr>
                <td style="width: 74px; background-color: #f7f7f7">
                    <asp:Label ID="Label4" runat="server" ForeColor="Black" Text="Produtor"></asp:Label></td>
                <td style="width: 193px; background-color: #f7f7f7">
                    <asp:DropDownList ID="ddlProdutorPesq" runat="server" Width="200px">
                    </asp:DropDownList></td>
                <td style="width: 46px; background-color: #f7f7f7">
                </td>
            </tr>
            <tr>
                <td style="width: 74px; background-color: #f7f7f7; height: 26px;">
                    <asp:Label ID="lblDataInicialPesq" runat="server" Text="Data Inicial" ForeColor="Black"></asp:Label></td>
                <td style="width: 193px; background-color: #f7f7f7; height: 26px;">
                    <asp:TextBox ID="txtDataInicialPesq" runat="server" Width="195px"></asp:TextBox></td>
                <td style="width: 46px; background-color: #f7f7f7; height: 26px;">
                    <cc1:MaskedEditValidator ID="MaskedEditValidator3" runat="server" ControlExtender="MaskedEditExtender1"
                        ControlToValidate="txtDataInicialPesq" ErrorMessage="*" InvalidValueBlurredMessage="*"
                        InvalidValueMessage="Data Inválida" SetFocusOnError="True"></cc1:MaskedEditValidator></td>
            </tr>
            <tr>
                <td style="width: 74px; background-color: #f7f7f7;">
                    <asp:Label ID="lblDataFinalPesq" runat="server" Text="Data Final" ForeColor="Black"></asp:Label></td>
                <td style="width: 193px; background-color: #f7f7f7;">
                    <asp:TextBox ID="txtDataFinalPesq" runat="server" Width="195px"></asp:TextBox></td>
                <td style="width: 46px; background-color: #f7f7f7">
                    <cc1:MaskedEditValidator ID="MaskedEditValidator4" runat="server" ControlExtender="MaskedEditExtender1"
                        ControlToValidate="txtDataFinalPesq" ErrorMessage="*" InvalidValueBlurredMessage="*"
                        InvalidValueMessage="Data Inválida" SetFocusOnError="True"></cc1:MaskedEditValidator></td>
            </tr>
            <tr>
                <td style="width: 74px; background-color: #f7f7f7; height: 24px;">
                    <asp:Label ID="lblTipoLeitePesq" runat="server" Text="Tipo do Leite" ForeColor="Black"></asp:Label></td>
                <td style="width: 193px; background-color: #f7f7f7; height: 24px;">
                    <asp:DropDownList ID="ddlTipoLeitePesq" runat="server" Width="200px">
                        <asp:ListItem Value="T">TODOS</asp:ListItem>
                        <asp:ListItem>B</asp:ListItem>
                        <asp:ListItem>C</asp:ListItem>
                    </asp:DropDownList></td>
                <td style="width: 46px; background-color: #f7f7f7; height: 24px;">
                </td>
            </tr>
            <tr>
                <td style="width: 74px; background-color: #f7f7f7; height: 26px;">
                    <asp:Button ID="btnAtivarModalPopup" runat="server" BackColor="#F7F7F7" BorderColor="#F7F7F7"
                        BorderStyle="None" ForeColor="#F7F7F7" Width="1px" /></td>
                <td colspan="2" style="background-color: #f7f7f7; text-align: right; height: 26px;">
                    <asp:Button ID="btnPesquisar2" runat="server" Text="Pesquisar" OnClick="btnPesquisar2_Click"
                        Width="105px" /></td>
            </tr>
        </table>
        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
            <ContentTemplate>
                <asp:Label ID="lblMensagem" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="btnPesquisar2" EventName="Click" />
            </Triggers>
        </asp:UpdatePanel>
        &nbsp;&nbsp;&nbsp;&nbsp;
    </asp:Panel>
    <br />
    <asp:Panel ID="pnlGridView" runat="server" ScrollBars="Auto" Width="1031px" Height="350px"
        BackColor="White" BorderStyle="Outset">
        <table>
            <tr>
                <td style="width: 960px; background-color: white; text-align: center; height: 22px;">
                    &nbsp; &nbsp;&nbsp;
                    <asp:Label ID="lblPnlListaPreco" runat="server" Text="Lista de Preços"></asp:Label></td>
                <td style="width: 45px; background-color: white; height: 22px;">
                    &nbsp;<asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/App_Themes/images/voltar.jpg"
                        OnClick="ImageButton1_Click" />
                    <asp:ImageButton ID="btnSair" runat="server" ImageUrl="~/App_Themes/images/fechar.jpg"
                        OnClick="btnSair_Click" /></td>
            </tr>
        </table>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:GridView ID="gvListaPreco" runat="server" CellPadding="4" ForeColor="#333333"
                    GridLines="None" DataKeyNames="ID_REGIAO,DT_INICIO,DT_FIM,ID_COOPERAT,DS_COOPERAT,ID_PROPRIED,DS_PROPRIED,ID_PRODUTOR,DS_PRODUTOR,ID_TIPO_LEITE,ID_VOL_INI,ID_VOL_FIM,ID_VALOR_UNIT"
                    AutoGenerateColumns="False" AllowPaging="True" OnPageIndexChanging="gvListaPreco_PageIndexChanging"
                    OnRowCommand="gvListaPreco_RowCommand" OnRowDataBound="gvListaPreco_RowDataBound"
                    OnRowDeleting="gvListaPreco_RowDeleting" OnSorting="gvListaPreco_Sorting" AllowSorting="True">
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <EditRowStyle BackColor="#999999" />
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:TemplateField ShowHeader="False">
                            <ItemTemplate>
                                <asp:LinkButton ID="lnkSelecionar" runat="server" CommandName="Select" Text="Selecionar"
                                    Width="74px" OnClick="lnkSelecionar_Click"></asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Regi&#227;o" SortExpression="Id_regiao">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <div style="left: 0px; overflow: hidden; width: 47px; top: 0px; height: 16px">
                                    <asp:Label ID="lblGridRegiao" runat="server" Text='<%# Bind("ID_REGIAO") %>' ToolTip='<%# Bind("ID_REGIAO") %>'></asp:Label></div>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Cooperativa" SortExpression="Ds_cooperat">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <div style="left: 0px; overflow: hidden; width: 61px; top: 0px; height: 16px; direction: ltr;">
                                    <asp:Label ID="lblCooperativaPesq" runat="server" Text='<%# BIND("DS_COOPERAT") %>'
                                        ToolTip='<%# BIND("DS_COOPERAT") %>'></asp:Label></div>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Propriedade" SortExpression="Ds_propried">
                            <ItemTemplate>
                                <div style="left: 0px; overflow: hidden; width: 146px; top: 0px; height: 16px; direction: ltr;">
                                    <asp:Label ID="lblGridPropried" runat="server" Text='<%# Bind("DS_PROPRIED") %>'
                                        ToolTip='<%# Bind("DS_PROPRIED") %>'></asp:Label></div>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Produtor" SortExpression="Ds_produtor">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <div style="left: 0px; overflow: hidden; width: 164px; top: 0px; height: 16px; direction: ltr;">
                                    <asp:Label ID="lblProdutorPesq" runat="server" Text='<%# BIND("DS_PRODUTOR") %>'
                                        ToolTip='<%# BIND("DS_PRODUTOR") %>'></asp:Label></div>
                            </ItemTemplate>
                            <FooterStyle HorizontalAlign="Left" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Data In&#237;cio" SortExpression="Dt_inicio">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <div style="left: 0px; overflow: hidden; width: 70px; top: 0px; height: 16px">
                                    <asp:Label ID="lblGridDtInicio" runat="server" Text='<%# Bind("DT_INICIO") %>' ToolTip='<%# Bind("DT_INICIO") %>'></asp:Label></div>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Data Fim" SortExpression="Dt_fim">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <div style="left: 0px; overflow: hidden; width: 70px; top: 0px; height: 16px">
                                    &nbsp;<asp:Label ID="lblGridDtFim" runat="server" Text='<%# Bind("DT_FIM") %>' ToolTip='<%# Bind("DT_FIM") %>'></asp:Label></div>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Leite" SortExpression="Id_tipo_leite">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <div style="left: 0px; overflow: hidden; width: 18px; top: 0px; height: 16px">
                                    &nbsp;<asp:Label ID="lblGridLeite" runat="server" Text='<%# Bind("ID_TIPO_LEITE") %>'
                                        ToolTip='<%# Bind("ID_TIPO_LEITE") %>'></asp:Label></div>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Vol. Inicial" SortExpression="Id_vol_ini">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <div style="left: 0px; overflow: hidden; width: 70px; top: 0px; height: 16px">
                                    &nbsp;<asp:Label ID="lblGridVolIni" runat="server" Text='<%# BIND("ID_VOL_INI","{0:f}") %>'
                                        ToolTip='<%# BIND("ID_VOL_INI", "{0:f}") %>'></asp:Label></div>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Vol. Final" SortExpression="Id_vol_fim">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <div style="left: 0px; overflow: hidden; width: 70px; top: 0px; height: 16px">
                                    <asp:Label ID="lblGridVolFin" runat="server" Text='<%# BIND("ID_VOL_FIM", "{0:f}") %>'
                                        ToolTip='<%# BIND("ID_VOL_FIM", "{0:c}") %>'></asp:Label>
                                </div>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Valor Unit&#225;rio" SortExpression="Id_valor_unit">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <div style="left: 0px; overflow: hidden; width: 70px; top: 0px; height: 16px">
                                    <asp:Label ID="lblGridValUni" runat="server" Text='<%# BIND("ID_VALOR_UNIT","{0:c}") %>'
                                        ToolTip='<%# BIND("ID_VALOR_UNIT", "{0:c}") %>' Style="direction: rtl">
                                    </asp:Label>
                                </div>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField ShowHeader="False">
                            <ItemTemplate>
                                <asp:LinkButton ID="lnkExcluir" CommandArgument='<%# Eval("ID_REGIAO") %>' CommandName="Delete"
                                    runat="server" CausesValidation="False" Text="Excluir">
                                </asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <PagerSettings FirstPageText="Primeiro" LastPageText="&#218;ltimo" Mode="NextPreviousFirstLast"
                        NextPageText="Pr&#243;ximo" PreviousPageText="Anterior" />
                </asp:GridView>
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="btnPesquisar2" EventName="Click" />
                <asp:AsyncPostBackTrigger ControlID="gvListaPreco" EventName="SelectedIndexChanged" />
            </Triggers>
        </asp:UpdatePanel>
        <asp:UpdateProgress ID="UpdateProgress1" runat="server">
            <ProgressTemplate>
                <asp:Panel ID="pnlProcessando" runat="server" BackColor="#B5C7DE" BorderColor="LightGray"
                    BorderStyle="Double" Height="1px" Width="358px">
                    <img src="App_Themes/images/carregando.gif" alt="" style="width: 15px" />
                    Aguarde enquanto as informações estão sendo carregadas...</asp:Panel>
            </ProgressTemplate>
        </asp:UpdateProgress>
    </asp:Panel>
</asp:Content>
