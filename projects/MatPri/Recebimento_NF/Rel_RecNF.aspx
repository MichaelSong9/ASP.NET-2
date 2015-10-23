<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Rel_RecNF.aspx.vb" Inherits="Recebimento_NF_Rel_RecNF" title="Untitled Page" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="DIV_PAGES">
        &nbsp;
        <table id="td_Botoes" class="TD_BOTOES_BODY_RECNF">
            <tr>
                <td style="height: 34px;">
                    &nbsp; &nbsp;&nbsp;
                    <asp:ImageButton ID="imb_Imprimir" runat="server" ImageUrl="~/App_Themes/CCL/Imagens/Bt_Imprimir.gif"
                        Style="left: 73px; position: relative; top: 1px" TabIndex="12" />
                </td>
                <td style="height: 34px;">
                    <asp:ImageButton ID="imb_Sair" runat="server" ImageUrl="~/App_Themes/CCL/Imagens/Bt_Sair.gif"
                        PostBackUrl="~/Pagina_Principal.aspx" Style="left: 0px; position: relative;
                        top: 1px" TabIndex="13" />
                </td>
            </tr>
        </table>
        <div style="z-index: 102; left: 500px; width: 184px; position: absolute; top: 262px;
            height: 140px">
            
            <cc1:DropShadowExtender 
                 ID="DropShadowExtender1"
                 runat="server"
                 Opacity="0.5"
                 TargetControlID="pnl_Form"
                 TrackPosition="true"
                 Width="3">
            </cc1:DropShadowExtender>
            
            <cc1:MaskedEditExtender 
                ID="MaskedEditExtender1"
                runat="server"
                AcceptNegative="Left"
                CultureName="pt-BR"
                DisplayMoney="Left"
                ErrorTooltipEnabled="True"
                Mask="99/99/9999"
                MaskType="Date"
                MessageValidatorTip="true"
                OnFocusCssClass="MaskedEditFocus"
                OnInvalidCssClass="MaskedEditError"
                TargetControlID="txt_DataRecI"> 
            </cc1:MaskedEditExtender>
            <cc1:MaskedEditExtender ID="MaskedEditExtender2" runat="server" AcceptNegative="Left"
                CultureName="pt-BR" DisplayMoney="Left" ErrorTooltipEnabled="True" Mask="99/99/9999"
                MaskType="Date" MessageValidatorTip="true" OnFocusCssClass="MaskedEditFocus"
                OnInvalidCssClass="MaskedEditError" TargetControlID="txt_DataRecF">
            </cc1:MaskedEditExtender>
            
            <cc1:CalendarExtender ID="CalendarExtender1" runat="server" CssClass="MyCalendar_recnf_de"
                Format="dd/MM/yyyy" PopupButtonID="imbCalendarDe" TargetControlID="txt_DataRecI">
            </cc1:CalendarExtender>
            <cc1:CalendarExtender ID="CalendarExtender2" runat="server" CssClass="MyCalendar_recnf_ate"
                Format="dd/MM/yyyy" PopupButtonID="imbCalendarAte" TargetControlID="txt_DataRecF">
            </cc1:CalendarExtender>
            
            <cc1:FilteredTextBoxExtender
                 ID="BoletimInicial" 
                 runat="server"
                 FilterType = "Custom, Numbers"
                 TargetControlID="txt_BoletimInicial">
            </cc1:FilteredTextBoxExtender>
            
            <cc1:FilteredTextBoxExtender
                 ID="BoletimFinal" 
                 runat="server"
                 FilterType = "Custom, Numbers" 
                 TargetControlID="txt_BoletimFinal">
            </cc1:FilteredTextBoxExtender>
          
        <asp:ScriptManager id="ScriptManager1" runat="server" EnableScriptGlobalization="True"
            EnableScriptLocalization="True">
        </asp:ScriptManager>&nbsp; &nbsp;&nbsp;
            
        </div>
        <asp:Panel ID="pnl_Form" runat="server" CssClass="PANEL_FORM_RECNF">
            <table id="td_form" class="TD_FORM">
                <tbody>
                    <tr>
                        <td align="right" style="width: 100%; height: 31px">
                            <asp:Label ID="lbl_CodLoc" runat="server" CssClass="LABEL_PAGES" Style="text-align: right"
                                Text="Localização:" Width="162px"></asp:Label></td>
                        <td align="left" colspan="2" style="height: 31px">
                            <asp:DropDownList ID="ddl_Localizacao" runat="server" CssClass="DROPDOWN_PAGES" TabIndex="1"
                                Width="245px">
                                <asp:ListItem Selected="True" Value="0">TODOS</asp:ListItem>
                                <asp:ListItem Value="01">01-CENTRAL</asp:ListItem>
                                <asp:ListItem Value="02">02-F.B.V.B</asp:ListItem>
                                <asp:ListItem Value="07">07-J.R.A</asp:ListItem>
                            </asp:DropDownList></td>
                    </tr>
                    <tr>
                        <td align="right" style="width: 100%; height: 31px">
                            <asp:Label ID="Label2" runat="server" CssClass="LABEL_PAGES" Style="text-align: right"
                                Text="Tipo do Remetente:" Width="162px"></asp:Label></td>
                        <td align="left" colspan="2" style="height: 31px">
                            <asp:DropDownList ID="ddl_TipoRemetente" runat="server" CssClass="DROPDOWN_PAGES"
                                TabIndex="2" Width="245px">
                                <asp:ListItem Value="0">TODOS</asp:ListItem>
                                <asp:ListItem Value="1">ASSOCIADA</asp:ListItem>
                                <asp:ListItem Value="2">TERCEIRO</asp:ListItem>
                                <asp:ListItem Value="3">UNIDADE</asp:ListItem>
                                <asp:ListItem Value="4">EM FORMA&#199;&#195;O</asp:ListItem>
                            </asp:DropDownList></td>
                    </tr>
                    <tr>
                        <td align="right" style="width: 100%; height: 21px">
                            <asp:Label ID="Label5" runat="server" CssClass="LABEL_PAGES" Style="text-align: right"
                                Text="Código Remetente:" Width="162px"></asp:Label></td>
                        <td align="left" colspan="2" style="height: 21px">
                            <asp:UpdatePanel id="CodRemUpdatePanel" runat="server" UpdateMode="Conditional"><contenttemplate>
<asp:DropDownList id="ddl_CodRemetente" tabIndex=3 runat="server" Width="245px" CssClass="DROPDOWN_PAGES" __designer:wfdid="w7">
                            </asp:DropDownList>&nbsp;<asp:ImageButton id="imbCodRem" runat="server" Width="20px" Height="18px" ToolTip="Carrega a lista de códigos de remetente" ImageUrl="~/App_Themes/CCL/Imagens/Botao_Carregar.gif" __designer:wfdid="w8"></asp:ImageButton> 
</contenttemplate>
                                <triggers>
<asp:AsyncPostBackTrigger ControlID="imbCodRem" EventName="Click"></asp:AsyncPostBackTrigger>
</triggers>
                            </asp:UpdatePanel><asp:UpdateProgress id="UpdateProgress1" runat="server" DisplayAfter="300"><progresstemplate>
<asp:Panel id="pnlProcessando" runat="server" Width="252px" Height="1px" BorderColor="Transparent" BackColor="#B5C7DE"><IMG style="WIDTH: 15px" src="../App_Themes/CCL/Imagens/loading.gif" /> Informações sendo carregadas...</asp:Panel> 
</progresstemplate>
                            </asp:UpdateProgress></td>
                    </tr>
                    <tr>
                        <td align="right" style="height: 29px">
                            <asp:Label ID="lbl_TipoDOC" runat="server" CssClass="LABEL_PAGES" Style="text-align: right"
                                Text="Tipo do Documento:" Width="162px"></asp:Label></td>
                        <td align="left" colspan="2" style="height: 29px">
                            &nbsp;<asp:RadioButton ID="rdlSelecione" runat="server" AutoPostBack="True" GroupName="TipDoc"
                                Text="Selecione" TabIndex="4" ToolTip="Selecione o tipo de documento" /><asp:RadioButton ID="rdlTodos" runat="server" AutoPostBack="True"
                                    GroupName="TipDoc" Text="Todos" TabIndex="5" ToolTip="Seleciona todos tipos de documento" /></td>
                    </tr>
                    <tr>
                        <td align="right" style="height: 29px">
                            <asp:Label ID="Label3" runat="server" CssClass="LABEL_PAGES" Style="text-align: right"
                                Text="Nota Fiscal:" Width="162px"></asp:Label></td>
                        <td align="left" colspan="2" style="height: 29px">
                            &nbsp;<asp:UpdatePanel id="NotaFiscalUpdatePanel" runat="server" UpdateMode="Conditional"><contenttemplate>
<asp:DropDownList id="ddl_NotaFiscal" tabIndex=6 runat="server" Width="245px" CssClass="DROPDOWN_PAGES" __designer:wfdid="w9">
                        </asp:DropDownList>&nbsp;<asp:ImageButton id="imbNotaFiscal" runat="server" Width="20px" Height="18px" ToolTip="Carrega a lista de Nota Fiscal" ImageUrl="~/App_Themes/CCL/Imagens/Botao_Carregar.gif" __designer:wfdid="w10"></asp:ImageButton> 
</contenttemplate>
                                <triggers>
<asp:AsyncPostBackTrigger ControlID="imbNotaFiscal" EventName="Click"></asp:AsyncPostBackTrigger>
</triggers>
                            </asp:UpdatePanel>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" style="height: 28px">
                            <asp:Label ID="lbl_CodPos" runat="server" CssClass="LABEL_PAGES" Style="text-align: right"
                                Text="Código do Posto Fiscal:" Width="176px"></asp:Label></td>
                        <td align="left" style="height: 28px" colspan="2">
                            &nbsp;<asp:UpdatePanel id="PostoFiscalUpdatePanel" runat="server" UpdateMode="Conditional"><contenttemplate>
<asp:DropDownList id="ddl_CodPos" tabIndex=7 runat="server" Width="245px" CssClass="DROPDOWN_PAGES" __designer:wfdid="w11">
                            </asp:DropDownList>&nbsp;<asp:ImageButton id="imbPostoFiscal" runat="server" Width="20px" Height="18px" ToolTip="Carrega a lista do Código do Posto Fiscal" ImageUrl="~/App_Themes/CCL/Imagens/Botao_Carregar.gif" __designer:wfdid="w12"></asp:ImageButton> 
</contenttemplate>
                                <triggers>
<asp:AsyncPostBackTrigger ControlID="imbPostoFiscal" EventName="Click"></asp:AsyncPostBackTrigger>
</triggers>
                            </asp:UpdatePanel></td>
                    </tr>
                    <tr>
                        <td align="left" colspan="5" style="height: 5px; width: 575px;">
                            <hr style="height: 3px" />
                        </td>
                    </tr>
                    
                    <tr>
                        <td align="left" colspan="4" style="height: 28px">
                            <asp:Label ID="Label4" runat="server" CssClass="LABEL_PAGES" Style="text-align: right"
                                Text="Boletim De:" Width="123px"></asp:Label>
                            <asp:TextBox ID="txt_BoletimInicial" runat="server" CausesValidation="True" CssClass="TEXT_PAGES"
                                TabIndex="8" Width="96px" MaxLength="6">0</asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txt_BoletimInicial"
                                ErrorMessage="*" ToolTip="Insira o Boletim"></asp:RequiredFieldValidator>
                            &nbsp; &nbsp; &nbsp; &nbsp;
                            <asp:Label ID="Label6" runat="server" CssClass="LABEL_PAGES" Style="text-align: right"
                                Text="Ate:" Width="37px"></asp:Label>
                            <asp:TextBox ID="txt_BoletimFinal" runat="server" CausesValidation="True" CssClass="TEXT_PAGES"
                                TabIndex="9" Width="96px" MaxLength="6">999999</asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txt_BoletimFinal"
                                ErrorMessage="*" ToolTip="Insira o Boletim"></asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td align="right" colspan="4" style="height: 28px; text-align: left">
                            <asp:Label ID="lbl_DataRecI" runat="server" CssClass="LABEL_PAGES" Text="Recebimento De:"
                                Width="123px"></asp:Label>
                            <asp:TextBox ID="txt_DataRecI" runat="server" CausesValidation="True" CssClass="TEXT_PAGES"
                                TabIndex="10" Width="96px"></asp:TextBox>
                            <asp:ImageButton ID="imbCalendarDe" runat="server" ImageUrl="~/App_Themes/CCL/Imagens/Calendar_scheduleHS.png"
                                Style="z-index: 1;" ToolTip="Calendário" />
                            <cc1:MaskedEditValidator ID="MaskedEditValidator1" runat="server" ControlExtender="MaskedEditExtender1"
                                ControlToValidate="txt_DataRecI" ErrorMessage="*" InvalidValueBlurredMessage="*"
                                InvalidValueMessage="Data Inválida" SetFocusOnError="True" Width="11px"></cc1:MaskedEditValidator>
                            <asp:Label ID="Label1" runat="server" CssClass="LABEL_PAGES" Style="text-align: right"
                                Text="Até:" Width="37px"></asp:Label>
                            <asp:TextBox ID="txt_DataRecF" runat="server" CausesValidation="True" CssClass="TEXT_PAGES"
                                TabIndex="11" Width="96px"></asp:TextBox>
                            <asp:ImageButton ID="imbCalendarAte" runat="server" ImageUrl="~/App_Themes/CCL/Imagens/Calendar_scheduleHS.png"
                                Style="z-index: 3;" ToolTip="Calendário" />
                            <cc1:MaskedEditValidator ID="MaskedEditValidator2" runat="server" ControlExtender="MaskedEditExtender2"
                                ControlToValidate="txt_DataRecF" ErrorMessage="*" InvalidValueBlurredMessage="*"
                                InvalidValueMessage="Data Inválida" SetFocusOnError="True" Width="11px"></cc1:MaskedEditValidator></td>
                    </tr>
                    
                </tbody>
            </table>
        </asp:Panel>
    </div>
</asp:Content>

