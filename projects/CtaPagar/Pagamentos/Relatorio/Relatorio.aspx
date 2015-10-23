<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false"
    CodeFile="Relatorio.aspx.vb" Inherits="Pagamentos_Relatorio_Relatorio" Title="Untitled Page" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="DIV_PAGES" style="text-align: center">
        <div style="z-index: 101; left: 20px; width: 120px; position: absolute; top: 215px;
            height: 374px">
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <cc1:DropShadowExtender ID="Opcoes" runat="server" Enabled="True" Opacity="0.5" TargetControlID="pnl_Opcoes"
                TrackPosition="True" Width="3">
            </cc1:DropShadowExtender>
            <cc1:MaskedEditExtender ID="FornecedorDe" runat="server" TargetControlID="txt_FornecedorDe"
                Mask="99999999" MaskType="Number" AutoComplete="False">
            </cc1:MaskedEditExtender>
            <cc1:MaskedEditExtender ID="FornecedorAte" runat="server" TargetControlID="txt_FornecedorAte"
                Mask="99999999" MaskType="Number" AutoComplete="False">
            </cc1:MaskedEditExtender>
            <cc1:MaskedEditExtender ID="CNPJDe" runat="server" CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder=""
                CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" CultureThousandsPlaceholder=""
                CultureTimePlaceholder="" Enabled="True" Mask="99999999" MaskType="Number" TargetControlID="txt_CNPJDe">
            </cc1:MaskedEditExtender>
            <cc1:MaskedEditExtender ID="CNPJAte" runat="server" CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder=""
                CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" CultureThousandsPlaceholder=""
                CultureTimePlaceholder="" Enabled="True" Mask="99999999" MaskType="Number" TargetControlID="txt_CNPJAte">
            </cc1:MaskedEditExtender>
            <cc1:MaskedEditExtender ID="TituloDe" runat="server" Mask="????????" TargetControlID="txt_TituloDe">
            </cc1:MaskedEditExtender>
            <cc1:MaskedEditExtender ID="TituloAte" runat="server" Mask="????????" TargetControlID="txt_TituloAte">
            </cc1:MaskedEditExtender>
            <cc1:MaskedEditExtender ID="EmissaoDe" runat="server" TargetControlID="txt_EmissaoDe"
                Mask="99/99/9999" MaskType="Date" CultureName="pt-BR">
            </cc1:MaskedEditExtender>
            <cc1:MaskedEditExtender ID="EmissaoAte" runat="server" TargetControlID="txt_EmissaoAte"
                Mask="99/99/9999" MaskType="Date" CultureName="pt-BR">
            </cc1:MaskedEditExtender>
            <cc1:MaskedEditExtender ID="VencimentoDe" runat="server" TargetControlID="txt_VencimentoDe"
                Mask="99/99/9999" MaskType="Date" CultureName="pt-BR">
            </cc1:MaskedEditExtender>
            <cc1:MaskedEditExtender ID="VencimentoAte" runat="server" TargetControlID="txt_VencimentoAte"
                Mask="99/99/9999" MaskType="Date" CultureName="pt-BR">
            </cc1:MaskedEditExtender>
            <cc1:MaskedEditExtender ID="LiquidacaoDe" runat="server" TargetControlID="txt_LiquidacaoDe"
                Mask="99/99/9999" MaskType="Date" CultureName="pt-BR" UserDateFormat="DayMonthYear">
            </cc1:MaskedEditExtender>
            <cc1:MaskedEditExtender ID="LiquidacaoAte" runat="server" TargetControlID="txt_LiquidacaoAte"
                Mask="99/99/9999" MaskType="Date" CultureName="pt-BR" UserDateFormat="DayMonthYear">
            </cc1:MaskedEditExtender>
            <cc1:CalendarExtender ID="CalendarExtender1" runat="server" Format="dd/MM/yyyy" PopupButtonID="imbEmissaoDe"
                TargetControlID="txt_EmissaoDe">
            </cc1:CalendarExtender>
            <cc1:CalendarExtender ID="CalendarExtender2" runat="server" Format="dd/MM/yyyy" PopupButtonID="imbEmissaoAte"
                TargetControlID="txt_EmissaoAte">
            </cc1:CalendarExtender>
            <cc1:CalendarExtender ID="CalendarExtender3" runat="server" Format="dd/MM/yyyy" PopupButtonID="imbVencimentoDe"
                TargetControlID="txt_VencimentoDe">
            </cc1:CalendarExtender>
            <cc1:CalendarExtender ID="CalendarExtender4" runat="server" Format="dd/MM/yyyy" PopupButtonID="imbVencimentoAte"
                TargetControlID="txt_VencimentoAte">
            </cc1:CalendarExtender>
            <cc1:CalendarExtender ID="CalendarExtender5" runat="server" Format="dd/MM/yyyy" PopupButtonID="imbLiquidacaoDe"
                TargetControlID="txt_LiquidacaoDe">
            </cc1:CalendarExtender>
            <cc1:CalendarExtender ID="CalendarExtender6" runat="server" Format="dd/MM/yyyy" PopupButtonID="imbLiquidacaoAte"
                TargetControlID="txt_LiquidacaoAte">
            </cc1:CalendarExtender>
        </div>
        <div style="z-index: 102; left: 329px; width: 186px; position: absolute; top: 485px;
            height: 100px">
            <asp:UpdateProgress ID="UpdateProgress1" runat="server" DisplayAfter="300" AssociatedUpdatePanelID="UpdatePanel1">
                <ProgressTemplate>
                    <asp:Panel ID="pnlProcessando" runat="server" Width="334px" Height="1px" BorderColor="LightGray"
                        BackColor="#B5C7DE" BorderStyle="Double">
                        <img style="width: 15px" src="../../App_Themes/CCL/Imagens/loading.gif" />
                        Aguarde enquanto o relatório é gerado...</asp:Panel>
                </ProgressTemplate>
            </asp:UpdateProgress>
        </div>
        &nbsp;&nbsp;&nbsp;<br />
        <div style="width: 580px; height: 120px" id="divCamposObrigatorios">
            <asp:Panel ID="pnl_Opcoes" runat="server" Height="10px" Width="587px">
                <table id="tdOpcoes" class="TD_FORM">
                    <tr>
                        <td style="width: 174px; height: 18px; text-align: right">
                            <asp:Label ID="Label15" runat="server" Text="Fornecedor de:"></asp:Label>
                        </td>
                        <td style="width: 178px; height: 18px; text-align: left">
                            <asp:TextBox ID="txt_FornecedorDe" runat="server" CssClass="TEXT_PAGES" TabIndex="1"
                                Width="100px" MaxLength="8"></asp:TextBox>
                        </td>
                        <td style="width: 36px; height: 18px; text-align: right">
                            <asp:Label ID="Label16" runat="server" Text="Até:"></asp:Label>&nbsp;
                        </td>
                        <td style="width: 178px; height: 18px; text-align: left">
                            <asp:TextBox ID="txt_FornecedorAte" runat="server" CssClass="TEXT_PAGES" TabIndex="2"
                                Width="100px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 174px; text-align: right">
                            <asp:Label ID="lbl_CNPJDe" runat="server" Text="CNPJ de:"></asp:Label>
                        </td>
                        <td style="width: 178px; text-align: left">
                            <asp:TextBox ID="txt_CNPJDe" runat="server" CssClass="TEXT_PAGES" TabIndex="3" Width="100px"></asp:TextBox>
                        </td>
                        <td style="width: 36px; text-align: right">
                            <asp:Label ID="lbl_CNPJAte" runat="server" Text="Até:"></asp:Label>
                        </td>
                        <td style="width: 178px; text-align: left">
                            <asp:TextBox ID="txt_CNPJAte" runat="server" CssClass="TEXT_PAGES" TabIndex="4" Width="100px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 174px; height: 23px; text-align: right">
                            <asp:Label ID="lblTituloDe" runat="server" Text="Título de:"></asp:Label>
                        </td>
                        <td style="width: 178px; height: 23px; text-align: left">
                            <asp:TextBox ID="txt_TituloDe" runat="server" CssClass="TEXT_PAGES" TabIndex="5"
                                Width="100px"></asp:TextBox>
                        </td>
                        <td style="width: 36px; height: 23px; text-align: right">
                            <asp:Label ID="lblTituloAte" runat="server" Text="Até:"></asp:Label>
                        </td>
                        <td style="width: 178px; height: 23px; text-align: left">
                            <asp:TextBox ID="txt_TituloAte" runat="server" CssClass="TEXT_PAGES" TabIndex="6"
                                Width="100px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 174px; height: 23px; text-align: right">
                            <asp:Label ID="Label3" runat="server" Text="Emissão de:"></asp:Label>
                        </td>
                        <td style="width: 178px; height: 23px; text-align: left">
                            <asp:TextBox ID="txt_EmissaoDe" runat="server" CausesValidation="True" CssClass="TEXT_PAGES"
                                TabIndex="7" Width="100px"></asp:TextBox>
                            <asp:ImageButton ID="imbEmissaoDe" runat="server" ImageUrl="~/App_Themes/CCL/Imagens/Calendar_scheduleHS.png"
                                Style="left: 94px; top: 2px" TabIndex="16" ToolTip="Calendário" />
                            <cc1:MaskedEditValidator ID="MaskedEditValidator1" runat="server" ControlExtender="EmissaoDe"
                                ControlToValidate="txt_EmissaoDe" ErrorMessage="*" InvalidValueBlurredMessage="*"
                                InvalidValueMessage="Data Inválida" SetFocusOnError="True"></cc1:MaskedEditValidator>
                        </td>
                        <td style="width: 36px; height: 23px; text-align: right">
                            <asp:Label ID="Label10" runat="server" Text="Até:"></asp:Label>
                        </td>
                        <td style="width: 178px; height: 23px; text-align: left">
                            <asp:TextBox ID="txt_EmissaoAte" runat="server" CausesValidation="True" CssClass="TEXT_PAGES"
                                TabIndex="8" Width="100px"></asp:TextBox>
                            <asp:ImageButton ID="imbEmissaoAte" runat="server" ImageUrl="~/App_Themes/CCL/Imagens/Calendar_scheduleHS.png"
                                Style="left: 94px; top: 2px" TabIndex="17" ToolTip="Calendário" />
                            <cc1:MaskedEditValidator ID="MaskedEditValidator2" runat="server" ControlExtender="EmissaoAte"
                                ControlToValidate="txt_EmissaoAte" ErrorMessage="*" InvalidValueBlurredMessage="*"
                                InvalidValueMessage="Data Inválida" SetFocusOnError="True"></cc1:MaskedEditValidator>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 174px; height: 23px; text-align: right">
                            <asp:Label ID="Label4" runat="server" Text="Vencimento de:"></asp:Label>
                        </td>
                        <td style="width: 178px; height: 23px; text-align: left">
                            <asp:TextBox ID="txt_VencimentoDe" runat="server" CausesValidation="True" CssClass="TEXT_PAGES"
                                TabIndex="9" Width="100px"></asp:TextBox>
                            <asp:ImageButton ID="imbVencimentoDe" runat="server" ImageUrl="~/App_Themes/CCL/Imagens/Calendar_scheduleHS.png"
                                Style="left: 94px; top: 2px" TabIndex="18" ToolTip="Calendário" />
                            <cc1:MaskedEditValidator ID="MaskedEditValidator3" runat="server" ControlExtender="VencimentoDe"
                                ControlToValidate="txt_VencimentoDe" ErrorMessage="*" InvalidValueBlurredMessage="*"
                                InvalidValueMessage="Data Inválida" SetFocusOnError="True"></cc1:MaskedEditValidator>
                        </td>
                        <td style="width: 36px; height: 23px; text-align: right">
                            <asp:Label ID="Label11" runat="server" Text="Até:"></asp:Label>
                        </td>
                        <td style="width: 178px; height: 23px; text-align: left">
                            <asp:TextBox ID="txt_VencimentoAte" runat="server" CausesValidation="True" CssClass="TEXT_PAGES"
                                TabIndex="10" Width="100px"></asp:TextBox>
                            <asp:ImageButton ID="imbVencimentoAte" runat="server" ImageUrl="~/App_Themes/CCL/Imagens/Calendar_scheduleHS.png"
                                Style="left: 94px; top: 2px" TabIndex="19" ToolTip="Calendário" />
                            <cc1:MaskedEditValidator ID="MaskedEditValidator4" runat="server" ControlExtender="VencimentoAte"
                                ControlToValidate="txt_VencimentoAte" ErrorMessage="*" InvalidValueBlurredMessage="*"
                                InvalidValueMessage="Data Inválida" SetFocusOnError="True"></cc1:MaskedEditValidator>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 174px; height: 23px; text-align: right">
                            <asp:Label ID="Label5" runat="server" Text="Liquidação de:"></asp:Label>
                        </td>
                        <td style="width: 178px; height: 23px; text-align: left">
                            <asp:TextBox ID="txt_LiquidacaoDe" runat="server" CausesValidation="True" CssClass="TEXT_PAGES"
                                TabIndex="11" Width="100px"></asp:TextBox>
                            <asp:ImageButton ID="imbLiquidacaoDe" runat="server" ImageUrl="~/App_Themes/CCL/Imagens/Calendar_scheduleHS.png"
                                Style="left: 94px; top: 2px" TabIndex="20" ToolTip="Calendário" />
                            <cc1:MaskedEditValidator ID="MaskedEditValidator5" runat="server" ControlExtender="VencimentoDe"
                                ControlToValidate="txt_LiquidacaoDe" ErrorMessage="*" InvalidValueBlurredMessage="*"
                                InvalidValueMessage="Data Inválida" SetFocusOnError="True"></cc1:MaskedEditValidator>
                        </td>
                        <td style="width: 36px; height: 23px; text-align: right">
                            <asp:Label ID="Label12" runat="server" Text="Até:"></asp:Label>
                        </td>
                        <td style="width: 178px; height: 23px; text-align: left">
                            <asp:TextBox ID="txt_LiquidacaoAte" runat="server" CausesValidation="True" CssClass="TEXT_PAGES"
                                TabIndex="12" Width="100px"></asp:TextBox>
                            <asp:ImageButton ID="imbLiquidacaoAte" runat="server" ImageUrl="~/App_Themes/CCL/Imagens/Calendar_scheduleHS.png"
                                Style="left: 94px; top: 2px" TabIndex="21" ToolTip="Calendário" />
                            <cc1:MaskedEditValidator ID="MaskedEditValidator6" runat="server" ControlExtender="VencimentoDe"
                                ControlToValidate="txt_LiquidacaoAte" ErrorMessage="*" InvalidValueBlurredMessage="*"
                                InvalidValueMessage="Data Inválida" SetFocusOnError="True"></cc1:MaskedEditValidator>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="4" style="height: 23px; text-align: left">
                        </td>
                    </tr>
                    <tr>
                        <td colspan="4" style="height: 23px; text-align: center">
                            <asp:RadioButtonList ID="rbStatus" runat="server" RepeatDirection="Horizontal" Width="392px"
                                TabIndex="13">
                                <asp:ListItem Value="L">Liquidados</asp:ListItem>
                                <asp:ListItem Value="A">N&#227;o Liquidados</asp:ListItem>
                                <asp:ListItem Value="V">Ambos</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                    </tr>
                </table>
            </asp:Panel>
            &nbsp;</div>
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
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <table style="width: 615px" id="Table1">
                    <tbody>
                        <tr>
                            <td style="width: 615px; height: 12px; background-color: #b5c7de; text-align: center">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                                <asp:ImageButton ID="imbImprimir" TabIndex="14" OnClick="imbImprimir_Click" runat="server"
                                    ImageUrl="~/App_Themes/CCL/Imagens/Bt_Imprimir.gif"></asp:ImageButton>
                                <asp:ImageButton ID="imbSair" TabIndex="15" runat="server" PostBackUrl="~/Pagina_Principal.aspx"
                                    ImageUrl="~/App_Themes/CCL/Imagens/Bt_Sair.gif" Height="36px"></asp:ImageButton>
                                &nbsp; &nbsp; &nbsp;
                            </td>
                        </tr>
                    </tbody>
                </table>
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="imbImprimir" EventName="Click"></asp:AsyncPostBackTrigger>
            </Triggers>
        </asp:UpdatePanel>
    </div>
</asp:Content>
