<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Exclusao_De_Movimento.aspx.vb" Inherits="Exclusao_de_Movimento_Exclusao_De_Movimento" title="Untitled Page" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div id="pagina" class="DIV_PAGES" style="text-align: center">
        <div style="z-index: 102; left: 24px; width: 229px; position: absolute; top: 210px;
            height: 135px; text-align: left;">
            <cc1:DropShadowExtender ID="DropShadowExtender1" runat="server" Opacity="0.5" TargetControlID="pnl_Form"
                TrackPosition="true" Width="3">
            </cc1:DropShadowExtender>
            <cc1:MaskedEditExtender ID="MaskedEditExtender1" runat="server" AcceptNegative="Left"
                CultureName="pt-BR" DisplayMoney="Left" ErrorTooltipEnabled="True" Mask="99/99/9999"
                MaskType="Date" MessageValidatorTip="true" OnFocusCssClass="MaskedEditFocus"
                OnInvalidCssClass="MaskedEditError" TargetControlID="txt_DataRecI">
            </cc1:MaskedEditExtender>
            <cc1:CalendarExtender ID="CalendarExtender1" runat="server" CssClass="MyCalendar_creme_de"
                Format="dd/MM/yyyy" PopupButtonID="imbCalendarDe" TargetControlID="txt_DataRecI">
            </cc1:CalendarExtender>
            <cc1:MaskedEditExtender ID="MaskedEditExtender2" runat="server" AcceptNegative="Left"
                CultureName="pt-BR" DisplayMoney="Left" ErrorTooltipEnabled="True" Mask="99/99/9999"
                MaskType="Date" MessageValidatorTip="true" OnFocusCssClass="MaskedEditFocus"
                OnInvalidCssClass="MaskedEditError" TargetControlID="txt_DataRecF">
            </cc1:MaskedEditExtender>
            <cc1:CalendarExtender ID="CalendarExtender2" runat="server" CssClass="MyCalendar_creme_ate"
                Format="dd/MM/yyyy" PopupButtonID="imbCalendarAte" TargetControlID="txt_DataRecF">
            </cc1:CalendarExtender>
            <asp:ScriptManager id="ScriptManager1" runat="server" EnableScriptGlobalization="True"
                EnableScriptLocalization="True">
            </asp:ScriptManager>
        </div>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Panel ID="pnl_Form" runat="server" Width="376px">
            <table id="td_form" class="TD_FORM">
                <tbody>
                    <tr>
                        <td align="right" style="height: 28px">
                            <asp:Label ID="lbl_DataRecI" runat="server" CssClass="LABEL_PAGES" Text="Data De:"
                                Width="140px"></asp:Label>
                        </td>
                        <td align="left" colspan="2" style="height: 28px; width: 196px;">
                            <asp:TextBox ID="txt_DataRecI" runat="server" CausesValidation="True" CssClass="TEXT_PAGES"
                                TabIndex="1" Width="88px"></asp:TextBox>
                            <asp:ImageButton ID="imbCalendarDe" runat="server" ImageUrl="~/App_Themes/CCL/Imagens/Calendar_scheduleHS.png"
                                Style="left: 94px; top: 2px" ToolTip="Calendário" />&nbsp;
                            <cc1:MaskedEditValidator ID="MaskedEditValidator1" runat="server" ControlExtender="MaskedEditExtender1"
                                ControlToValidate="txt_DataRecI" ErrorMessage="*" InvalidValueBlurredMessage="*"
                                InvalidValueMessage="Data Inválida" SetFocusOnError="True"></cc1:MaskedEditValidator></td>
                    </tr>
                    <tr>
                        <td align="right" style="height: 37px">
                            <asp:Label ID="Label1" runat="server" CssClass="LABEL_PAGES" Style="text-align: right"
                                Text="Até:" Width="36px"></asp:Label>
                        </td>
                        <td align="left" colspan="2" style="height: 37px; width: 196px;">
                            <asp:TextBox ID="txt_DataRecF" runat="server" CausesValidation="True" CssClass="TEXT_PAGES"
                                TabIndex="2" Width="88px"></asp:TextBox>
                            <asp:ImageButton ID="imbCalendarAte" runat="server" ImageUrl="~/App_Themes/CCL/Imagens/Calendar_scheduleHS.png"
                                Style="left: 93px; top: 0px" ToolTip="Calendário" />&nbsp;
                            <cc1:MaskedEditValidator ID="MaskedEditValidator2" runat="server" ControlExtender="MaskedEditExtender2"
                                ControlToValidate="txt_DataRecF" ErrorMessage="*" InvalidValueBlurredMessage="*"
                                InvalidValueMessage="Data Inválida" SetFocusOnError="True"></cc1:MaskedEditValidator></td>
                    </tr>
                </tbody>
            </table>
        </asp:Panel>
        <asp:UpdateProgress id="UpdateProgress1" runat="server" DisplayAfter="300" AssociatedUpdatePanelID="UpdatePanel1">
            <progresstemplate>
<BR /><asp:Panel id="pnlProcessando" runat="server" Width="372px" Height="1px" BorderColor="Transparent" BackColor="#B5C7DE" __designer:wfdid="w17"><IMG style="WIDTH: 15px" src="../App_Themes/CCL/Imagens/loading.gif" />&nbsp;Aguarde, o arquivo está sendo excluído...</asp:Panel> 
</progresstemplate>
        </asp:UpdateProgress><br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:UpdatePanel id="UpdatePanel1" runat="server">
            <contenttemplate>
<asp:Panel style="BACKGROUND-COLOR: #b5c7de" id="Panel1" runat="server" Width="405px" Height="40px">&nbsp;&nbsp; <asp:ImageButton id="imb_Excluir" tabIndex=3 runat="server" ToolTip="Processar" ImageUrl="~/App_Themes/CCL/Imagens/Bt_Excluir.gif"></asp:ImageButton>&nbsp;&nbsp; <asp:ImageButton id="imb_Sair" tabIndex=4 runat="server" PostBackUrl="~/Pagina_Principal.aspx" ImageUrl="~/App_Themes/CCL/Imagens/Bt_Sair.gif"></asp:ImageButton> &nbsp; </asp:Panel> <cc1:ConfirmButtonExtender id="ConfirmButtonExtender1" runat="server" TargetControlID="imb_Excluir" ConfirmText="Deseja excluir o arquivo?">
        </cc1:ConfirmButtonExtender> 
</contenttemplate>
        </asp:UpdatePanel>&nbsp;&nbsp;</div>
</asp:Content>

