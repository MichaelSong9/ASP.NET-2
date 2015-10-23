<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Rel_RecLeiteDes.aspx.vb" Inherits="Recebimento_LeiteDesnatado_Rel_RecLeiteDes" title="Untitled Page" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="DIV_PAGES">
        &nbsp;<table id="td_Botoes" class="TD_BOTOES_BODY">
            <tr>
                <td style="width: 100px; height: 34px;">
                    <asp:ImageButton ID="imb_Imprimir" runat="server" ImageUrl="~/App_Themes/CCL/Imagens/Bt_Imprimir.gif"
                        Style="left: 83px; position: relative; top: 1px" TabIndex="11" />
                </td>
                <td style="width: 100px; height: 34px;">
                    <asp:ImageButton ID="imb_Sair" runat="server" ImageUrl="~/App_Themes/CCL/Imagens/Bt_Sair.gif"
                        PostBackUrl="~/Pagina_Principal.aspx" Style="left: 9px; position: relative;
                        top: 1px" TabIndex="12" />
                </td>
            </tr>
        </table>
        <div style="z-index: 102; left: 648px; width: 220px; position: absolute; top: 264px;
            height: 135px">
            <cc1:DropShadowExtender ID="DropShadowExtender1" runat="server" Opacity="0.5" TargetControlID="pnl_Form"
                TrackPosition="true" Width="3">
            </cc1:DropShadowExtender>
            <cc1:MaskedEditExtender ID="MaskedEditExtender1" runat="server" AcceptNegative="Left"
                CultureName="pt-BR" DisplayMoney="Left" ErrorTooltipEnabled="True" Mask="99/99/9999"
                MaskType="Date" MessageValidatorTip="true" OnFocusCssClass="MaskedEditFocus"
                OnInvalidCssClass="MaskedEditError" TargetControlID="txt_DataRecI">
            </cc1:MaskedEditExtender>
            <cc1:CalendarExtender ID="CalendarExtender1" runat="server" CssClass="MyCalendar_leides_de"
                Format="dd/MM/yyyy" PopupButtonID="imbCalendarDe" TargetControlID="txt_DataRecI">
            </cc1:CalendarExtender>
            <cc1:MaskedEditExtender ID="MaskedEditExtender2" runat="server" AcceptNegative="Left"
                CultureName="pt-BR" DisplayMoney="Left" ErrorTooltipEnabled="True" Mask="99/99/9999"
                MaskType="Date" MessageValidatorTip="true" OnFocusCssClass="MaskedEditFocus"
                OnInvalidCssClass="MaskedEditError" TargetControlID="txt_DataRecF">
            </cc1:MaskedEditExtender>
            <cc1:CalendarExtender ID="CalendarExtender2" runat="server" CssClass="MyCalendar_leides_ate"
                Format="dd/MM/yyyy" PopupButtonID="imbCalendarAte" TargetControlID="txt_DataRecF">
            </cc1:CalendarExtender>
            
            <cc1:FilteredTextBoxExtender 
                 ID="TeorDe" 
                 runat="server" 
                 FilterType = "Custom, Numbers"
                 ValidChars="."
                 TargetControlID="txt_TeorMGI">
            </cc1:FilteredTextBoxExtender>
            
            <cc1:FilteredTextBoxExtender 
                 ID="TeorATE" 
                 runat="server"
                 FilterType = "Custom, Numbers"
                 ValidChars="."
                 TargetControlID="txt_TeorMGF">
            </cc1:FilteredTextBoxExtender>
        <asp:ScriptManager id="ScriptManager1" runat="server" EnableScriptGlobalization="True"
            EnableScriptLocalization="True">
        </asp:ScriptManager>&nbsp;</div>
        <asp:Panel ID="pnl_Form" runat="server" CssClass="PANEL_FORM_LEIDES">
            <table id="td_form" class="TD_FORM">
                <tbody>
                    <tr>
                        <td align="right" style="width: 358px; height: 31px">
                            <asp:Label ID="lbl_CodLoc" runat="server" CssClass="LABEL_PAGES" Style="text-align: right"
                                Text="Localização:" Width="162px"></asp:Label></td>
                        <td align="left" colspan="2" style="height: 31px">
                                <asp:DropDownList ID="ddl_Localizacao" runat="server" CssClass="DROPDOWN_PAGES" TabIndex="1"
                                    Width="247px" style="z-index: 1">
                                    <asp:ListItem Selected="True" Value="0">TODOS</asp:ListItem>
                                    <asp:ListItem Value="01">01-CENTRAL</asp:ListItem>
                                    <asp:ListItem Value="02">02-F.B.V.B</asp:ListItem>
                                    <asp:ListItem Value="07">07-J.R.A</asp:ListItem>
                                </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" style="width: 358px; height: 31px">
                            <asp:Label ID="Label2" runat="server" CssClass="LABEL_PAGES" Style="text-align: right"
                                Text="Tipo do Remetente:" Width="162px"></asp:Label></td>
                        <td align="left" colspan="2" style="height: 31px">
                            <asp:DropDownList ID="ddl_TipoRemetente" runat="server" CssClass="DROPDOWN_PAGES"
                                TabIndex="2" Width="247px">
                                <asp:ListItem Value="0">TODOS</asp:ListItem>
                                <asp:ListItem Value="1">ASSOCIADA</asp:ListItem>
                                <asp:ListItem Value="2">TERCEIRO</asp:ListItem>
                                <asp:ListItem Value="3">UNIDADE</asp:ListItem>
                                <asp:ListItem Value="4">EM FORMA&#199;&#195;O</asp:ListItem>
                            </asp:DropDownList></td>
                    </tr>
                    <tr>
                        <td align="right" style="width: 358px; height: 21px">
                            <asp:Label ID="lbl_TipoMP" runat="server" CssClass="LABEL_PAGES" Style="text-align: right"
                                Text="Tipo de Matéria-Prima:" Width="165px"></asp:Label></td>
                        <td align="left" colspan="2" style="height: 21px">
                            <asp:DropDownList ID="ddl_MP" runat="server" CssClass="DROPDOWN_PAGES" TabIndex="3"
                                Width="247px">
                                <asp:ListItem Selected="True" Value="0">TODOS</asp:ListItem>
                                <asp:ListItem Value="01">B</asp:ListItem>
                                <asp:ListItem Value="02">C</asp:ListItem>
                                <asp:ListItem Value="07">D</asp:ListItem>
                                <asp:ListItem>H</asp:ListItem>
                            </asp:DropDownList></td>
                    </tr>
                    <tr>
                        <td align="right" style="width: 358px; height: 29px">
                            <asp:Label ID="lbl_TipoDOC" runat="server" CssClass="LABEL_PAGES" Style="text-align: right"
                                Text="Tipo do Documento:" Width="162px"></asp:Label></td>
                        <td align="left" colspan="2" style="height: 29px">
                            <asp:RadioButton ID="rdlSelecione" runat="server" AutoPostBack="True" GroupName="TipDoc"
                                TabIndex="4" Text="Selecione" ToolTip="Selecione o tipo de documento" />
                            <asp:RadioButton ID="rdlTodos" runat="server" AutoPostBack="True" GroupName="TipDoc"
                                TabIndex="5" Text="Todos" ToolTip="Seleciona todos tipos de documento" />
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td align="right" style="width: 358px; height: 29px">
                            <asp:Label ID="Label3" runat="server" CssClass="LABEL_PAGES" Style="text-align: right"
                                Text="Codigo do Remetente:" Width="168px"></asp:Label></td>
                        <td align="left" colspan="2" style="height: 29px">
                            <asp:UpdatePanel id="UpdatePanel1" runat="server">
                                <contenttemplate>
<asp:DropDownList id="ddl_CodRemetente" tabIndex=6 runat="server" Width="238px" CssClass="DROPDOWN_PAGES"></asp:DropDownList>&nbsp;<asp:ImageButton id="imbCodRem" runat="server" Width="20px" Height="18px" ToolTip="Carrega a lista de códigos de remetente" ImageUrl="~/App_Themes/CCL/Imagens/Botao_Carregar.gif"></asp:ImageButton> 
</contenttemplate>
                                <triggers>
<asp:AsyncPostBackTrigger ControlID="imbCodRem" EventName="Click"></asp:AsyncPostBackTrigger>
</triggers>
                            </asp:UpdatePanel>
                                <asp:UpdateProgress id="UpdateProgress1" runat="server" AssociatedUpdatePanelID="UpdatePanel1"
                                    DisplayAfter="300">
                                    <progresstemplate>
<asp:Panel id="pnlProcessando" runat="server" Width="252px" Height="1px" BorderColor="Transparent" BackColor="#B5C7DE"><IMG style="WIDTH: 15px" src="../App_Themes/CCL/Imagens/loading.gif" />&nbsp;Informações sendo carregadas...</asp:Panel> 
</progresstemplate>
                                </asp:UpdateProgress>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" colspan="4" style="height: 5px; width: 480px;">
                            <hr style="height: 3px; width: 614px;" />
                        </td>
                    </tr>
                    <tr>
                        <td align="left" colspan="4" style="height: 28px; width: 480px;">
                            &nbsp; &nbsp; &nbsp;
                            <asp:Label ID="lbl_TeorMGI" runat="server" CssClass="LABEL_PAGES" Style="text-align: right"
                                Text="Teor De:" Width="108px"></asp:Label><asp:TextBox ID="txt_TeorMGI" runat="server"
                                    CausesValidation="True" CssClass="TEXT_PAGES" MaxLength="8" TabIndex="7" Width="94px">0.00</asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txt_TeorMGI"
                                ErrorMessage="*" ToolTip="Teor Inválido"></asp:RequiredFieldValidator><asp:Label ID="lbl_TeorMGF" runat="server" CssClass="LABEL_PAGES" Style="text-align: right"
                                Text="Até:" Width="61px"></asp:Label><asp:TextBox ID="txt_TeorMGF" runat="server"
                                    CausesValidation="True" CssClass="TEXT_PAGES" MaxLength="8" TabIndex="8" Width="94px">999.99</asp:TextBox><asp:RequiredFieldValidator
                                        ID="RequiredFieldValidator2" runat="server" ControlToValidate="txt_TeorMGF" ErrorMessage="*"
                                        ToolTip="Teor inválido"></asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td align="left" colspan="3" style="height: 28px">
                            &nbsp; &nbsp; &nbsp;&nbsp;
                            <asp:Label ID="lbl_DataRecI" runat="server" CssClass="LABEL_PAGES" Text="Recebimento De:"
                                Width="108px"></asp:Label><asp:TextBox ID="txt_DataRecI" runat="server" CausesValidation="True"
                                    CssClass="TEXT_PAGES" TabIndex="9" Width="94px"></asp:TextBox>&nbsp;
                                    <asp:ImageButton ID="imbCalendarDe" runat="server"  ImageUrl="~/App_Themes/CCL/Imagens/Calendar_scheduleHS.png" ToolTip="Calendário"/>
                            <cc1:MaskedEditValidator ID="MaskedEditValidator1"
                                            runat="server" ControlExtender="MaskedEditExtender1" ControlToValidate="txt_DataRecI"
                                            ErrorMessage="*" InvalidValueBlurredMessage="*" InvalidValueMessage="Data Inválida" SetFocusOnError="True"></cc1:MaskedEditValidator>&nbsp;<asp:Label
                                                ID="Label1" runat="server" CssClass="LABEL_PAGES" Style="text-align: right" Text="Até:"
                                                Width="36px"></asp:Label>
                            <asp:TextBox ID="txt_DataRecF" runat="server"
                                    CausesValidation="True" CssClass="TEXT_PAGES" TabIndex="10" Width="94px"></asp:TextBox><asp:ImageButton
                                        ID="imbCalendarAte" runat="server" ImageUrl="~/App_Themes/CCL/Imagens/Calendar_scheduleHS.png"
                                        Style="left: 93px; top: 0px" ToolTip="Calendário" />
                            <cc1:MaskedEditValidator ID="MaskedEditValidator2"
                                            runat="server" ControlExtender="MaskedEditExtender2" ControlToValidate="txt_DataRecF"
                                            ErrorMessage="*" InvalidValueBlurredMessage="*" InvalidValueMessage="Data Inválida" SetFocusOnError="True"></cc1:MaskedEditValidator></td>
                    </tr>
                </tbody>
            </table>
        </asp:Panel>
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp;
    </div>
</asp:Content>

