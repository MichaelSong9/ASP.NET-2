<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Rel_RecTipoRemetente.aspx.vb" Inherits="Recebimento_TipoRemetente_Rel_RecTipoRemetente" title="Untitled Page" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="DIV_PAGES">
        <asp:ScriptManager id="ScriptManager1" runat="server" EnableScriptGlobalization="True"
            EnableScriptLocalization="True">
        </asp:ScriptManager><table id="td_Botoes" class="TD_BOTOES_BODY" style="z-index: 101;
            left: 48px; top: 415px">
            <tr>
                <td style="width: 100px">
                    <asp:ImageButton ID="imb_Imprimir" runat="server" ImageUrl="~/imagens/Botao_Imprimir.gif"
                        Style="left: 127px; position: relative; top: 1px" TabIndex="7" />
                </td>
                <td style="width: 100px">
                    <asp:ImageButton ID="imb_Sair" runat="server" ImageUrl="~/imagens/Botao_Sair.gif"
                        PostBackUrl="~/Pagina_Principal.aspx" Style="left: -1px; position: relative;
                        top: 1px" TabIndex="8" />
                </td>
            </tr>
        </table>
        <div style="z-index: 102; left: 17px; width: 275px; position: absolute; top: 231px;
            height: 135px">
            &nbsp; &nbsp; &nbsp; &nbsp;<br />
            <cc1:DropShadowExtender ID="DropShadowExtender1" runat="server" Opacity="0.5" TargetControlID="pnl_Form"
                TrackPosition="true" Width="3">
            </cc1:DropShadowExtender>
            <cc1:MaskedEditExtender ID="MaskedEditExtender1" runat="server" AcceptNegative="Left"
                CultureName="pt-BR" DisplayMoney="Left" ErrorTooltipEnabled="True" Mask="99/99/9999"
                MaskType="Date" MessageValidatorTip="true" OnFocusCssClass="MaskedEditFocus"
                OnInvalidCssClass="MaskedEditError" TargetControlID="txt_DataRecI">
            </cc1:MaskedEditExtender>
            <cc1:CalendarExtender ID="CalendarExtender1" runat="server" CssClass="MyCalendar"
                Format="dd/MM/yyyy" PopupButtonID="imbCalendarDe" TargetControlID="txt_DataRecI">
            </cc1:CalendarExtender>
            <cc1:MaskedEditExtender ID="MaskedEditExtender2" runat="server" AcceptNegative="Left"
                CultureName="pt-BR" DisplayMoney="Left" ErrorTooltipEnabled="True" Mask="99/99/9999"
                MaskType="Date" MessageValidatorTip="true" OnFocusCssClass="MaskedEditFocus"
                OnInvalidCssClass="MaskedEditError" TargetControlID="txt_DataRecF">
            </cc1:MaskedEditExtender>
            <cc1:CalendarExtender ID="CalendarExtender2" runat="server" CssClass="MyCalendar"
                Format="dd/MM/yyyy" PopupButtonID="imbCalendarAte" TargetControlID="txt_DataRecF">
            </cc1:CalendarExtender>
        </div>
        <asp:Panel ID="pnl_Form" runat="server" Height="180px" Style="left: 303px; position: absolute;
            top: 206px" Width="347px">
            <table id="td_form" class="TD_FORM">
                <tbody>
                    <tr>
                        <td align="right" style="width: 100%; height: 31px">
                            <asp:Label ID="lbl_CodLoc" runat="server" CssClass="LABEL_PAGES" Style="text-align: right"
                                Text="Localização:" Width="162px"></asp:Label></td>
                        <td align="left" style="width: 132px; height: 31px">
                            <asp:DropDownList ID="ddl_Localizacao" runat="server" CssClass="DROPDOWN_PAGES" Width="247px" TabIndex="1">
                                <asp:ListItem Selected="True" Value="0">TODOS</asp:ListItem>
                                <asp:ListItem Value="01">01-CENTRAL</asp:ListItem>
                                <asp:ListItem Value="02">02-F.B.V.B</asp:ListItem>
                                <asp:ListItem Value="07">07-J.R.A</asp:ListItem>
                            </asp:DropDownList></td>
                    </tr>
                    <tr>
                        <td align="right" style="width: 100%; height: 31px">
                            <asp:Label ID="lbl_TipoRem" runat="server" CssClass="LABEL_PAGES" Style="text-align: right"
                                Text="Tipo do Remetente:" Width="162px"></asp:Label></td>
                        <td align="left" style="width: 132px; height: 31px">
                            <asp:DropDownList ID="ddl_TipoRemetente" runat="server" CssClass="DROPDOWN_PAGES" TabIndex="2"
                                Width="247px">
                                <asp:ListItem Value="0">TODOS</asp:ListItem>
                                <asp:ListItem Value="1">ASSOCIADA</asp:ListItem>
                                <asp:ListItem Value="2">TERCEIRO</asp:ListItem>
                                <asp:ListItem Value="3">UNIDADE</asp:ListItem>
                                <asp:ListItem Value="4">EM FORMA&#199;&#195;O</asp:ListItem>
                            </asp:DropDownList></td>
                    </tr>
                    <tr>
                        <td align="right" style="width: 100%; height: 21px">
                            <asp:Label ID="lbl_CodPos" runat="server" CssClass="LABEL_PAGES" Style="text-align: right"
                                Text="Codigo do Remetente:" Width="168px"></asp:Label></td>
                        <td align="left" style="width: 132px; height: 21px">
                            <asp:DropDownList ID="ddl_CodRemetente" runat="server" CssClass="DROPDOWN_PAGES" DataSourceID="CodRemSqlDataSource"
                                DataTextField="NOMREM" DataValueField="CODREM" Width="247px" TabIndex="3">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" style="height: 29px">
                            <asp:Label ID="lbl_TipoDOC" runat="server" CssClass="LABEL_PAGES" Style="text-align: right"
                                Text="Tipo do Documento:" Width="162px"></asp:Label></td>
                        <td align="left" style="width: 132px; height: 29px">
                            <asp:DropDownList ID="ddl_TipoDocumento" runat="server" CssClass="DROPDOWN_PAGES"
                                TabIndex="4" Width="247px">
                                <asp:ListItem Value="0">TODOS</asp:ListItem>
                                <asp:ListItem>LEITE</asp:ListItem>
                                <asp:ListItem>CREME</asp:ListItem>
                                <asp:ListItem>GRANELIZADO</asp:ListItem>
                                <asp:ListItem>EMPRESTIMO</asp:ListItem>
                            </asp:DropDownList></td>
                    </tr>
                    <tr>
                        <td align="right" style="height: 28px">
                            <asp:Label ID="lbl_DataRecI" runat="server" CssClass="LABEL_PAGES" Text="Data Recebimento De:"
                                Width="162px"></asp:Label>
                        </td>
                        <td align="left" style="width: 132px; height: 28px">
                            <asp:TextBox ID="txt_DataRecI" runat="server" CausesValidation="True" CssClass="TEXT_PAGES"
                                TabIndex="5" Width="96px"></asp:TextBox>
                            <asp:ImageButton ID="imbCalendarDe" runat="server" ImageUrl="~/imagens/Calendar_scheduleHS.png"
                                Style="z-index: 1; left: 314px; position: absolute; top: 174px" />
                            <cc1:MaskedEditValidator ID="MaskedEditValidator1" runat="server" ControlExtender="MaskedEditExtender1"
                                ControlToValidate="txt_DataRecI" ErrorMessage="*" InvalidValueBlurredMessage="*"
                                InvalidValueMessage="Data Inválida" IsValidEmpty="False" SetFocusOnError="True"
                                Style="left: 339px; position: absolute; top: 176px" Width="11px"></cc1:MaskedEditValidator>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" style="height: 38px">
                            <asp:Label ID="Label1" runat="server" CssClass="LABEL_PAGES" Style="text-align: right"
                                Text="Até:" Width="162px"></asp:Label>
                        </td>
                        <td align="left" style="width: 132px; height: 38px">
                            <asp:TextBox ID="txt_DataRecF" runat="server" CausesValidation="True" CssClass="TEXT_PAGES"
                                TabIndex="6" Width="96px"></asp:TextBox>
                            <asp:ImageButton ID="imbCalendarAte" runat="server" ImageUrl="~/imagens/Calendar_scheduleHS.png"
                                Style="z-index: 3; left: 314px; position: absolute; top: 214px" />
                            <cc1:MaskedEditValidator ID="MaskedEditValidator2" runat="server" ControlExtender="MaskedEditExtender2"
                                ControlToValidate="txt_DataRecF" ErrorMessage="*" InvalidValueBlurredMessage="*"
                                InvalidValueMessage="Data Inválida" IsValidEmpty="False" SetFocusOnError="True"
                                Style="left: 341px; position: absolute; top: 214px" Width="11px"></cc1:MaskedEditValidator>
                        </td>
                    </tr>
                </tbody>
            </table>
            <asp:SqlDataSource ID="CodRemSqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:RemetenteConnectionString %>"
                ProviderName="<%$ ConnectionStrings:RemetenteConnectionString.ProviderName %>"
                SelectCommand="SELECT DISTINCT &quot;NOMREM&quot;, &quot;CODREM&quot; &#13;&#10;FROM &quot;REMETENTE&quot;&#13;&#10;union all&#13;&#10;Select distinct 'TODOS' as &quot;NOMREM&quot;,&#13;&#10;       0 as &quot;CODREM&quot;&#13;&#10;FROM &quot;REMETENTE&quot;&#13;&#10;ORDER BY &quot;CODREM&quot;">
            </asp:SqlDataSource>
        </asp:Panel>
    </div>
</asp:Content>

