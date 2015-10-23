<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Rel_RecCreme.aspx.vb" Inherits="Rel_RecCreme" title="Untitled Page" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div class="DIV_PAGES">
        &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp;&nbsp;
        <asp:Panel ID="pnl_Creme" runat="server" CssClass="PANEL_FORM_CREME">
                        <TABLE id="td_form" class="TD_FORM"><TBODY><TR><TD style="WIDTH: 100%; HEIGHT: 31px" align="right"><asp:Label style="TEXT-ALIGN: right" id="lbl_CodLoc" runat="server" Width="162px" CssClass="LABEL_PAGES" Text="Localização:"></asp:Label></TD><TD style="HEIGHT: 31px" align="left" colspan="2">
                                <asp:DropDownList id="ddl_Localizacao" runat="server" Width="140px" CssClass="DROPDOWN_PAGES" TabIndex="1">
                                <asp:ListItem Selected="True" Value="0">TODOS</asp:ListItem>
                                <asp:ListItem Value="01">01-CENTRAL</asp:ListItem>
                                <asp:ListItem Value="02">02-F.B.V.B</asp:ListItem>
                                <asp:ListItem Value="07">07-J.R.A</asp:ListItem>
                                </asp:DropDownList>
                            &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
                        </td>
                        </TR><TR><TD style="HEIGHT: 29px" align="right"><asp:Label style="TEXT-ALIGN: right" id="lbl_TipoRem" runat="server" Width="162px" CssClass="LABEL_PAGES" Text="Remetente:"></asp:Label></TD>
                            <td align="left" colspan="2" style="height: 29px">
                            <asp:DropDownList id="ddl_Remetente" runat="server" CssClass="DROPDOWN_PAGES" TabIndex="2" Width="140px">
                                <asp:ListItem Selected="True" Value="0">TODOS</asp:ListItem>
                                <asp:ListItem Value="01">01-ASSOCIADA</asp:ListItem>
                                <asp:ListItem Value="02">02-TERCEIRO</asp:ListItem>
                                <asp:ListItem Value="03">03-UNIDADE</asp:ListItem>
                                <asp:ListItem Value="04">04-EM FORMA&#199;&#195;O</asp:ListItem>
                        </asp:DropDownList>
                                &nbsp; &nbsp; &nbsp; &nbsp;
                            </td>
                            </TR>
                            <tr>
                                <td align="right" style="height: 29px">
                                    <asp:Label ID="lbl_TipoDOC" runat="server" CssClass="LABEL_PAGES" Style="text-align: right"
                                        Text="Tipo do Documento:" Width="162px"></asp:Label></td>
                                <td align="left" colspan="2" style="height: 29px">
                                    <asp:RadioButton ID="rdlSelecione" runat="server" AutoPostBack="True" GroupName="TipDoc"
                                        Text="Selecione" ToolTip="Selecione o tipo de documento" /><asp:RadioButton ID="rdlTodos" runat="server" AutoPostBack="True"
                                            GroupName="TipDoc" Text="Todos" ToolTip="Seleciona todos tipos de documento" /></td>
                            </tr>
                            <TR><TD style="HEIGHT: 29px" align="right"><asp:Label style="TEXT-ALIGN: right" id="lbl_TipoMp" runat="server" Width="162px" CssClass="LABEL_PAGES" Text="Matéria Prima:"></asp:Label></TD>
                                <td align="left" colspan="2" style="height: 29px">
                                <asp:DropDownList id="ddl_MatPrima" runat="server" Width="140px" CssClass="DROPDOWN_PAGES" TabIndex="3">
                                <asp:ListItem Selected="True" Value="0">TODOS</asp:ListItem>
                                <asp:ListItem Value="C1">C1</asp:ListItem>
                                <asp:ListItem Value="C2">C2</asp:ListItem>
                                <asp:ListItem Value="C3">C3</asp:ListItem>
                        </asp:DropDownList>
                                    &nbsp; &nbsp; &nbsp;&nbsp;</td>
                            </TR><TR>
                            <TD style="HEIGHT: 28px" align="right">
                                <asp:Label id="lbl_DataRecI" runat="server" Width="162px" CssClass="LABEL_PAGES" Text="Data Recebimento De:"></asp:Label>
                            </TD>
                                <td align="left" colspan="2" style="height: 28px">
                                                          
                                <asp:TextBox id="txt_DataRecI" runat="server"
                                             Width="88px" 
                                             CssClass="TEXT_PAGES" 
                                             CausesValidation="True" TabIndex="4"></asp:TextBox>
                                    <asp:ImageButton ID="imbCalendarDe" runat="server" ImageUrl="~/App_Themes/CCL/Imagens/Calendar_scheduleHS.png" style="left: 94px; top: 2px" ToolTip="Calendário" />&nbsp;
                                                 <cc1:MaskedEditValidator ID="MaskedEditValidator1" runat="server" ControlExtender="MaskedEditExtender1"
                                     ControlToValidate="txt_DataRecI" ErrorMessage="*" InvalidValueMessage="Data Inválida"
                                     SetFocusOnError="True" InvalidValueBlurredMessage="*"></cc1:MaskedEditValidator></td>
                        </TR><TR>
                        <TD style="HEIGHT: 37px" align="right">
                            <asp:Label style="TEXT-ALIGN: right" id="Label1" runat="server" Width="162px" CssClass="LABEL_PAGES" Text="Até:"></asp:Label>
                        </TD>
                            <td align="left" colspan="2" style="height: 37px">
                            <asp:TextBox id="txt_DataRecF" runat="server" Width="88px" CssClass="TEXT_PAGES" CausesValidation="True" TabIndex="5"></asp:TextBox>
                                <asp:ImageButton ID="imbCalendarAte" runat="server" ImageUrl="~/App_Themes/CCL/Imagens/Calendar_scheduleHS.png" style="left: 93px; top: 0px" ToolTip="Calendário" />&nbsp;
                                <cc1:MaskedEditValidator ID="MaskedEditValidator2" runat="server" ControlExtender="MaskedEditExtender2"
                                 ControlToValidate="txt_DataRecF" ErrorMessage="*" InvalidValueMessage="Data Inválida"
                                 SetFocusOnError="True" InvalidValueBlurredMessage="*"></cc1:MaskedEditValidator></td>
                        </TR>
                        </TBODY></TABLE>
                </asp:Panel>
        &nbsp; &nbsp;&nbsp;
         <table id="td_Botoes" class="TD_BOTOES_BODY">
            <tr>
                <td style="width: 100px">
                    <asp:ImageButton ID="imb_Imprimir" runat="server" ImageUrl="~/App_Themes/CCL/Imagens/Bt_Imprimir.gif"
                        Style="left: 84px; position: relative; top: 1px" TabIndex="5" />
                </td>
                <td style="width: 100px">
                    <asp:ImageButton ID="imb_Sair" runat="server" ImageUrl="~/App_Themes/CCL/Imagens/Bt_Sair.gif"
                        PostBackUrl="~/Pagina_Principal.aspx" Style="left: 5px; position: relative;
                        top: 1px" TabIndex="6" />
                </td>
            </tr>
        </table>
        <div style="z-index: 102; left: 369px; width: 229px; position: absolute; top: 222px;
            height: 135px">
            
            <cc1:DropShadowExtender ID="DropShadowExtender1" 
                runat="server" 
                TargetControlID="pnl_Creme" 
                TrackPosition="True" 
                Opacity="0.5" Radius="10">
                
            </cc1:DropShadowExtender>
            <cc1:MaskedEditExtender ID="MaskedEditExtender1" 
                runat="server" 
                TargetControlID="txt_DataRecI"
                Mask="99/99/9999"
                MessageValidatorTip="true"
                CultureName="pt-BR"
                OnFocusCssClass="MaskedEditFocus"
                OnInvalidCssClass="MaskedEditError"
                MaskType="Date"
                DisplayMoney="Left"
                AcceptNegative="Left"
                ErrorTooltipEnabled="True" 
                >
            </cc1:MaskedEditExtender>
            <cc1:CalendarExtender ID="CalendarExtender1" runat="server"
                Format="dd/MM/yyyy"
                PopupButtonID="imbCalendarDe"
                TargetControlID="txt_DataRecI" CssClass="MyCalendar_creme_de">
            </cc1:CalendarExtender>
            
            <cc1:MaskedEditExtender ID="MaskedEditExtender2" 
                runat="server" 
                TargetControlID="txt_DataRecF"
                Mask="99/99/9999"
                MessageValidatorTip="true"
                CultureName="pt-BR"
                OnFocusCssClass="MaskedEditFocus"
                OnInvalidCssClass="MaskedEditError"
                MaskType="Date"
                DisplayMoney="Left"
                AcceptNegative="Left"
                ErrorTooltipEnabled="True" 
                >
            </cc1:MaskedEditExtender>
            <cc1:CalendarExtender ID="CalendarExtender2" runat="server"
                Format="dd/MM/yyyy"
                PopupButtonID="imbCalendarAte"
                TargetControlID="txt_DataRecF" CssClass="MyCalendar_creme_ate">
            </cc1:CalendarExtender>
        <asp:ScriptManager id="ScriptManager1" runat="server" EnableScriptGlobalization="True" EnableScriptLocalization="True">
        </asp:ScriptManager>

           </div>
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
    </div>
</asp:Content>

