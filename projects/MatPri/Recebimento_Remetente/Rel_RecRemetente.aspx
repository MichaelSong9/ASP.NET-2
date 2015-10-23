<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Rel_RecRemetente.aspx.vb" Inherits="Recebimento_Remetente_Rel_RecRemetente" title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
    <div class="DIV_PAGES">
        &nbsp;<table id="td_Botoes" class="TD_BOTOES_BODY">
            <tr>
                <td style="width: 99px">
                    <asp:ImageButton ID="imb_Imprimir" runat="server" ImageUrl="~/App_Themes/CCL/Imagens/Bt_Imprimir.gif"
                        Style="left: 85px; position: relative; top: 1px" TabIndex="6" />
                </td>
                <td style="width: 100px">
                    <asp:ImageButton ID="imb_Sair" runat="server" ImageUrl="~/App_Themes/CCL/Imagens/Bt_Sair.gif"
                        PostBackUrl="~/Pagina_Principal.aspx" Style="left: 11px; position: relative;
                        top: 1px" TabIndex="7" />
                </td>
            </tr>
        </table>
        <div style="z-index: 102; left: 605px; width: 233px; position: absolute; top: 280px;
            height: 135px">
            <cc1:DropShadowExtender ID="DropShadowExtender1" runat="server" Opacity="0.5" TargetControlID="pnl_Form"
                TrackPosition="true" Width="3">
            </cc1:DropShadowExtender>
            <cc1:MaskedEditExtender ID="MaskedEditExtender1" runat="server" AcceptNegative="Left"
                CultureName="pt-BR" DisplayMoney="Left" ErrorTooltipEnabled="True" Mask="99/99/9999"
                MaskType="Date" MessageValidatorTip="true" OnFocusCssClass="MaskedEditFocus"
                OnInvalidCssClass="MaskedEditError" TargetControlID="txt_DataRecI">
            </cc1:MaskedEditExtender>
            <cc1:CalendarExtender ID="CalendarExtender1" runat="server" CssClass="MyCalendar_remetente_de"
                Format="dd/MM/yyyy" PopupButtonID="imbCalendarDe" TargetControlID="txt_DataRecI">
            </cc1:CalendarExtender>
            <cc1:MaskedEditExtender ID="MaskedEditExtender2" runat="server" AcceptNegative="Left"
                CultureName="pt-BR" DisplayMoney="Left" ErrorTooltipEnabled="True" Mask="99/99/9999"
                MaskType="Date" MessageValidatorTip="true" OnFocusCssClass="MaskedEditFocus"
                OnInvalidCssClass="MaskedEditError" TargetControlID="txt_DataRecF">
            </cc1:MaskedEditExtender>
            <cc1:CalendarExtender ID="CalendarExtender2" runat="server" CssClass="MyCalendar_remetente_ate"
                Format="dd/MM/yyyy" PopupButtonID="imbCalendarAte" TargetControlID="txt_DataRecF">
            </cc1:CalendarExtender>
        <asp:ScriptManager id="ScriptManager1" runat="server" EnableScriptGlobalization="True"
            EnableScriptLocalization="True">
        </asp:ScriptManager>
            <asp:SqlDataSource ID="RemetenteDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:RemetenteConnectionString %>"
                ProviderName="<%$ ConnectionStrings:RemetenteConnectionString.ProviderName %>"
                SelectCommand="SELECT DISTINCT &quot;NOMREM&quot;, &quot;CODREM&quot;&#13;&#10;FROM &quot;REMETENTE&quot;&#13;&#10;union all&#13;&#10;Select distinct 'TODOS' as &quot;NOMREM&quot;,&#13;&#10;       0 as &quot;CODREM&quot;&#13;&#10;FROM &quot;REMETENTE&quot;&#13;&#10;ORDER BY &quot;CODREM&quot;">
            </asp:SqlDataSource>
        </div>
        <asp:Panel ID="pnl_Form" runat="server" CssClass="PANEL_FORM_REMETENTE">
            <table id="td_form" class="TD_FORM">
                <tbody>
                    <tr>
                        <td align="right" style="width: 190px; height: 31px">
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
                        <td align="right" style="height: 29px; width: 190px;">
                            <asp:Label ID="lbl_TipoRem" runat="server" CssClass="LABEL_PAGES" Style="text-align: right"
                                Text="Remetente:" Width="162px"></asp:Label></td>
                        <td align="left" style="width: 132px; height: 29px">
                            <asp:DropDownList ID="ddl_Remetente" runat="server" CssClass="DROPDOWN_PAGES"
                                DataSourceID="RemetenteDataSource" DataTextField="NOMREM" DataValueField="CODREM"
                                TabIndex="2" Width="247px">
                            </asp:DropDownList></td>
                    </tr>
                    <tr>
                        <td align="right" style="height: 29px; width: 190px;">
                            <asp:Label ID="lbl_TipoMp" runat="server" CssClass="LABEL_PAGES" Style="text-align: right"
                                Text="Tipo do Documento:" Width="162px"></asp:Label></td>
                        <td align="left" style="width: 132px; height: 29px">
                            <asp:RadioButton ID="rdlSelecione" runat="server" AutoPostBack="True" GroupName="TipDoc"
                                TabIndex="4" Text="Selecione" ToolTip="Selecione o tipo de documento" /><asp:RadioButton ID="rdlTodos" runat="server" AutoPostBack="True"
                                    GroupName="TipDoc" TabIndex="5" Text="Todos" ToolTip="Seleciona todos tipos de documento" /></td>
                    </tr>
                    <tr>
                        <td align="right" style="height: 18px; width: 190px;">
                            <asp:Label ID="lbl_DataRecI" runat="server" CssClass="LABEL_PAGES" Text="Data Recebimento De:"
                                Width="162px"></asp:Label>
                        </td>
                        <td align="left" style="width: 132px; height: 18px">
                            <asp:TextBox ID="txt_DataRecI" runat="server" CausesValidation="True" CssClass="TEXT_PAGES"
                                TabIndex="4" Width="96px"></asp:TextBox>
                            <asp:ImageButton ID="imbCalendarDe" runat="server" ImageUrl="~/App_Themes/CCL/Imagens/Calendar_scheduleHS.png"
                                Style="z-index: 1;" ToolTip="Calendário" />
                            <cc1:MaskedEditValidator ID="MaskedEditValidator1" runat="server" ControlExtender="MaskedEditExtender1"
                                ControlToValidate="txt_DataRecI" ErrorMessage="*" InvalidValueBlurredMessage="*"
                                InvalidValueMessage="Data Inválida" SetFocusOnError="True" Width="11px"></cc1:MaskedEditValidator>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" style="height: 32px; width: 190px;">
                            <asp:Label ID="Label1" runat="server" CssClass="LABEL_PAGES" Style="text-align: right"
                                Text="Até:" Width="162px"></asp:Label>
                        </td>
                        <td align="left" style="width: 132px; height: 32px">
                            <asp:TextBox ID="txt_DataRecF" runat="server" CausesValidation="True" CssClass="TEXT_PAGES"
                                TabIndex="5" Width="96px"></asp:TextBox>
                            <asp:ImageButton ID="imbCalendarAte" runat="server" ImageUrl="~/App_Themes/CCL/Imagens/Calendar_scheduleHS.png"
                                Style="z-index: 3;" ToolTip="Calendário" />
                            <cc1:MaskedEditValidator ID="MaskedEditValidator2" runat="server" ControlExtender="MaskedEditExtender2"
                                ControlToValidate="txt_DataRecF" ErrorMessage="*" InvalidValueBlurredMessage="*"
                                InvalidValueMessage="Data Inválida" SetFocusOnError="True" Width="11px"></cc1:MaskedEditValidator>
                        </td>
                    </tr>
                </tbody>
            </table>
        </asp:Panel>
    </div>
</asp:Content>

