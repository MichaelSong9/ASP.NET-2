<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Rel_RecCreme.aspx.vb" Inherits="Rel_RecCreme" title="Untitled Page" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<script language="javascript" type="text/javascript" src="../ValidarData.js"></script>

    <div class="DIV_PAGES">
        <asp:ScriptManager id="ScriptManager1" runat="server" EnableScriptGlobalization="True" EnableScriptLocalization="True">
        </asp:ScriptManager>
        &nbsp; &nbsp; &nbsp;&nbsp;
        <asp:Panel ID="pnl_Form" runat="server" Height="201px" Style="left: 343px; position: absolute;
            top: 233px" Width="281px">
                        <TABLE id="td_form" class="TD_FORM"><TBODY><TR><TD style="WIDTH: 100%; HEIGHT: 31px" align="right"><asp:Label style="TEXT-ALIGN: right" id="lbl_CodLoc" runat="server" Width="162px" CssClass="LABEL_PAGES" Text="Localização:"></asp:Label></TD><TD style="WIDTH: 100px; HEIGHT: 31px" align="left">
                                <asp:DropDownList id="ddl_Localizacao" runat="server" Width="157px" CssClass="DROPDOWN_PAGES" TabIndex="1">
                                <asp:ListItem Selected="True" Value="0">TODOS</asp:ListItem>
                                <asp:ListItem Value="01">01-CENTRAL</asp:ListItem>
                                <asp:ListItem Value="02">02-F.B.V.B</asp:ListItem>
                                <asp:ListItem Value="07">07-J.R.A</asp:ListItem>
                                </asp:DropDownList></td>
                        </TR><TR><TD style="HEIGHT: 29px" align="right"><asp:Label style="TEXT-ALIGN: right" id="lbl_TipoRem" runat="server" Width="162px" CssClass="LABEL_PAGES" Text="Remetente:"></asp:Label></TD><TD style="WIDTH: 100px; HEIGHT: 29px" align="left">
                            <asp:DropDownList id="ddl_Remetente" runat="server" CssClass="DROPDOWN_PAGES" TabIndex="2">
                                <asp:ListItem Selected="True" Value="0">TODOS</asp:ListItem>
                                <asp:ListItem Value="01">01-ASSOCIADA</asp:ListItem>
                                <asp:ListItem Value="02">02-TERCEIRO</asp:ListItem>
                                <asp:ListItem Value="03">03-UNIDADE</asp:ListItem>
                                <asp:ListItem Value="04">04-EM FORMA&#199;&#195;O</asp:ListItem>
                        </asp:DropDownList></td>
                            </TR><TR><TD style="HEIGHT: 29px" align="right"><asp:Label style="TEXT-ALIGN: right" id="lbl_TipoMp" runat="server" Width="162px" CssClass="LABEL_PAGES" Text="Matéria Prima:"></asp:Label></TD><TD style="WIDTH: 100px; HEIGHT: 29px" align="left">
                                <asp:DropDownList id="ddl_MatPrima" runat="server" Width="158px" CssClass="DROPDOWN_PAGES" TabIndex="3">
                                <asp:ListItem Selected="True" Value="0">TODOS</asp:ListItem>
                                <asp:ListItem Value="C1">C1</asp:ListItem>
                                <asp:ListItem Value="C2">C2</asp:ListItem>
                                <asp:ListItem Value="C3">C3</asp:ListItem>
                        </asp:DropDownList></TD>
                            </TR><TR>
                            <TD style="HEIGHT: 28px" align="right">
                                <asp:Label id="lbl_DataRecI" runat="server" Width="162px" CssClass="LABEL_PAGES" Text="Data Recebimento De:"></asp:Label>
                            </TD>
                            <TD style="WIDTH: 100px; HEIGHT: 28px" align="left">
                                                          
                                <asp:TextBox id="txt_DataRecI" runat="server"
                                             Width="96px" 
                                             CssClass="TEXT_PAGES" 
                                             CausesValidation="True" TabIndex="4"></asp:TextBox>

                                <asp:ImageButton ID="imbCalendarDe" runat="server" ImageUrl="~/imagens/Calendar_scheduleHS.png" style="left: 314px; position: absolute; top: 135px; z-index: 1;" />
                                <cc1:MaskedEditValidator ID="MaskedEditValidator1" runat="server" ControlExtender="MaskedEditExtender1"
                                     ControlToValidate="txt_DataRecI" ErrorMessage="*" InvalidValueMessage="Data Inválida"
                                     SetFocusOnError="True" style="left: 335px; position: absolute; top: 135px" Width="11px" InvalidValueBlurredMessage="*" IsValidEmpty="False"></cc1:MaskedEditValidator>
                        </TR><TR>
                        <TD style="HEIGHT: 38px" align="right">
                            <asp:Label style="TEXT-ALIGN: right" id="Label1" runat="server" Width="162px" CssClass="LABEL_PAGES" Text="Até:"></asp:Label>
                        </TD>
                        <TD style="WIDTH: 100px; HEIGHT: 38px" align="left">
                            <asp:TextBox id="txt_DataRecF" runat="server" Width="96px" CssClass="TEXT_PAGES" CausesValidation="True" TabIndex="5"></asp:TextBox>
                            <asp:ImageButton ID="imbCalendarAte" runat="server" ImageUrl="~/imagens/Calendar_scheduleHS.png" style="left: 314px; position: absolute; top: 175px; z-index: 3;" />
                            <cc1:MaskedEditValidator ID="MaskedEditValidator2" runat="server" ControlExtender="MaskedEditExtender2"
                                 ControlToValidate="txt_DataRecF" ErrorMessage="*" InvalidValueMessage="Data Inválida"
                                 SetFocusOnError="True" style="left: 335px; position: absolute; top: 175px" Width="11px" InvalidValueBlurredMessage="*" IsValidEmpty="False"></cc1:MaskedEditValidator>
                        </TD>
                        </TR>
                        </TBODY></TABLE>
                </asp:Panel>
        &nbsp; &nbsp;&nbsp;
        <table id="td_Botoes" class="TD_BOTOES_BODY" style="z-index: 101; left: 48px; top: 415px;">
                <tr>
                    <td style="width: 100px">
                        <asp:ImageButton ID="imb_Imprimir" runat="server" ImageUrl="~/imagens/Botao_Imprimir.gif" style="left: 127px; position: relative; top: 1px" TabIndex="6" />
                    </td>
                    <td style="width: 100px">
                        <asp:ImageButton ID="imb_Sair" runat="server" ImageUrl="~/imagens/Botao_Sair.gif" style="left: -1px; position: relative; top: 1px" PostBackUrl="~/Pagina_Principal.aspx" TabIndex="7" />
                    </td>
                </tr>
        </table>
        <div style="z-index: 102; left: 17px; width: 275px; position: absolute; top: 231px;
            height: 135px">
            &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
            <cc1:DropShadowExtender ID="DropShadowExtender1" 
                runat="server" 
                TargetControlID="pnl_Form" 
                TrackPosition="true" 
                Opacity="0.5"
                width="3">
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
                TargetControlID="txt_DataRecI" CssClass="MyCalendar">
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
                TargetControlID="txt_DataRecF" CssClass="MyCalendar">
            </cc1:CalendarExtender>

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

