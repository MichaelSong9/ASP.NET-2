<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Rel_InspFed.aspx.vb" Inherits="Inspecao_Federal_Rel_InspFed" title="Untitled Page" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="DIV_PAGES">
        <br />
        <table id="td_Botoes" class="TD_BOTOES_BODY" style="z-index: 101">
            <tr>
                <td style="width: 100px">
                    <asp:ImageButton ID="imb_Imprimir" runat="server" ImageUrl="~/App_Themes/CCL/Imagens/Bt_Imprimir.gif"
                        Style="left: 83px; position: relative; top: 1px" TabIndex="7" />
                </td>
                <td style="width: 100px">
                    <asp:ImageButton ID="imb_Sair" runat="server" ImageUrl="~/App_Themes/CCL/Imagens/Bt_Sair.gif"
                        PostBackUrl="~/Pagina_Principal.aspx" Style="left: 7px; position: relative;
                        top: 1px" TabIndex="8" />
                </td>
            </tr>
        </table>
        <div style="z-index: 102; left: 15px; width: 229px; position: absolute; top: 204px;
            height: 135px">
            <cc1:dropshadowextender id="DropShadowExtender1" runat="server" opacity="0.5" targetcontrolid="pnl_Form"
                trackposition="true" width="3"></cc1:dropshadowextender>
            <cc1:maskededitextender id="MaskedEditExtender1" runat="server" acceptnegative="Left"
                culturename="pt-BR" displaymoney="Left" errortooltipenabled="True" mask="99/99/9999"
                masktype="Date" messagevalidatortip="true" onfocuscssclass="MaskedEditFocus"
                oninvalidcssclass="MaskedEditError" targetcontrolid="txt_DataRecI"></cc1:maskededitextender>
            <cc1:calendarextender id="CalendarExtender1" runat="server" cssclass="MyCalendar_inspfed_de"
                format="dd/MM/yyyy" popupbuttonid="imbCalendarDe" targetcontrolid="txt_DataRecI"></cc1:calendarextender>
            <cc1:maskededitextender id="MaskedEditExtender2" runat="server" acceptnegative="Left"
                culturename="pt-BR" displaymoney="Left" errortooltipenabled="True" mask="99/99/9999"
                masktype="Date" messagevalidatortip="true" onfocuscssclass="MaskedEditFocus"
                oninvalidcssclass="MaskedEditError" targetcontrolid="txt_DataRecF"></cc1:maskededitextender>
            <cc1:calendarextender id="CalendarExtender2" runat="server" cssclass="MyCalendar_inspfed_ate"
                format="dd/MM/yyyy" popupbuttonid="imbCalendarAte" targetcontrolid="txt_DataRecF"></cc1:calendarextender>
        <asp:ScriptManager id="ScriptManager1" runat="server" EnableScriptGlobalization="True"
            EnableScriptLocalization="True">
        </asp:ScriptManager><asp:SqlDataSource ID="RemetenteDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:RemetenteConnectionString %>"
            ProviderName="<%$ ConnectionStrings:RemetenteConnectionString.ProviderName %>"
            SelectCommand="SELECT DISTINCT &quot;NOMREM&quot;, &quot;CODREM&quot;&#13;&#10;FROM &quot;REMETENTE&quot;&#13;&#10;union all&#13;&#10;Select distinct 'TODOS' as &quot;NOMREM&quot;,&#13;&#10;       0 as &quot;CODREM&quot;&#13;&#10;FROM &quot;REMETENTE&quot;&#13;&#10;ORDER BY &quot;CODREM&quot;">
        </asp:SqlDataSource>
            &nbsp;</div>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Panel ID="pnl_Form" runat="server" CssClass="PANEL_FORM_INSP_FED">
            <table id="td_form" class="TD_FORM">
                <tbody>
                    <tr>
                        <td align="right" style="width: 100%; height: 31px">
                            <asp:Label ID="lbl_CodLoc" runat="server" CssClass="LABEL_PAGES" Style="text-align: right"
                                Text="Localização:" Width="162px"></asp:Label></td>
                        <td align="left" colspan="2" style="height: 31px">
                            <asp:DropDownList ID="ddl_Localizacao" runat="server" CssClass="DROPDOWN_PAGES" Width="247px" TabIndex="1">
                                <asp:ListItem Selected="True" Value="0">TODOS</asp:ListItem>
                                <asp:ListItem Value="01">01-CENTRAL</asp:ListItem>
                                <asp:ListItem Value="02">02-F.B.V.B</asp:ListItem>
                                <asp:ListItem Value="07">07-J.R.A</asp:ListItem>
                            </asp:DropDownList></td>
                    </tr>
                    <tr>
                        <td align="right" style="height: 29px">
                            <asp:Label ID="lbl_TipoRem" runat="server" CssClass="LABEL_PAGES" Style="text-align: right"
                                Text="Remetente:" Width="162px"></asp:Label></td>
                        <td align="left" colspan="2" style="height: 29px">
                            <asp:DropDownList ID="ddl_Remetente" runat="server" CssClass="DROPDOWN_PAGES" DataSourceID="RemetenteDataSource" DataTextField="NOMREM" DataValueField="CODREM" Width="247px" TabIndex="2">
                            </asp:DropDownList></td>
                    </tr>
                    <tr>
                        <td align="right" style="height: 29px">
                            <asp:Label ID="lbl_TipoMp" runat="server" CssClass="LABEL_PAGES" Style="text-align: right"
                                Text="Tipo do Documento:" Width="162px"></asp:Label></td>
                        <td align="left" colspan="2" style="height: 29px">
                            &nbsp;<asp:RadioButton ID="rdlSelecione" runat="server" AutoPostBack="True" GroupName="TipDoc"
                                TabIndex="3" Text="Selecione" />
                            <asp:RadioButton ID="rdlTodos" runat="server" AutoPostBack="True" GroupName="TipDoc"
                                TabIndex="4" Text="Todos" />
                        </td>

                    </tr>
                    <tr>
                        <td align="right" style="height: 15px">
                            <asp:Label ID="lbl_DataRecI" runat="server" CssClass="LABEL_PAGES" Text="Data Recebimento De:"
                                Width="162px"></asp:Label>
                        </td>
                        <td align="left" style="height: 15px" colspan="2">
                            <asp:TextBox ID="txt_DataRecI" runat="server" CausesValidation="True" CssClass="TEXT_PAGES"
                                Width="98px" TabIndex="5"></asp:TextBox>
                            <asp:ImageButton ID="imbCalendarDe" runat="server"
                                    ImageUrl="~/App_Themes/CCL/Imagens/Calendar_scheduleHS.png" Style="left: 94px;
                                    top: 2px" ToolTip="Calendário" />&nbsp;
                            <cc1:MaskedEditValidator ID="MaskedEditValidator1" runat="server" ControlExtender="MaskedEditExtender1"
                                ControlToValidate="txt_DataRecI" ErrorMessage="*" InvalidValueBlurredMessage="*"
                                InvalidValueMessage="Data Inválida" SetFocusOnError="True"></cc1:MaskedEditValidator></td>
                    </tr>
                    <tr>
                        <td align="right" style="height: 15px">
                            <asp:Label ID="Label1" runat="server" CssClass="LABEL_PAGES" Style="text-align: right"
                                Text="Até:" Width="162px"></asp:Label>
                        </td>
                        <td align="left" style="height: 15px" colspan="2">
                            <asp:TextBox ID="txt_DataRecF" runat="server" CausesValidation="True" CssClass="TEXT_PAGES"
                                Width="98px" TabIndex="6"></asp:TextBox>
                            <asp:ImageButton ID="imbCalendarAte" runat="server"
                                    ImageUrl="~/App_Themes/CCL/Imagens/Calendar_scheduleHS.png" Style="left: 93px;
                                    top: 0px" ToolTip="Calendário" />&nbsp;
                            <cc1:MaskedEditValidator ID="MaskedEditValidator2" runat="server" ControlExtender="MaskedEditExtender2"
                                ControlToValidate="txt_DataRecF" ErrorMessage="*" InvalidValueBlurredMessage="*"
                                InvalidValueMessage="Data Inválida" SetFocusOnError="True"></cc1:MaskedEditValidator></td>
                 
                    </tr>
                </tbody>
            </table>
        </asp:Panel>
        &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
    </div>
</asp:Content>

