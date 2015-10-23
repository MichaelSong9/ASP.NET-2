<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Rel_InspFed.aspx.vb" Inherits="Inspecao_Federal_Rel_InspFed" title="Untitled Page" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="DIV_PAGES">
        <asp:ScriptManager id="ScriptManager1" runat="server" EnableScriptGlobalization="True"
            EnableScriptLocalization="True">
        </asp:ScriptManager><br />
        <table id="td_Botoes" class="TD_BOTOES_BODY" style="z-index: 101; left: 48px; top: 415px">
            <tr>
                <td style="width: 100px">
                    <asp:ImageButton ID="imb_Imprimir" runat="server" ImageUrl="~/imagens/Botao_Imprimir.gif"
                        Style="left: 127px; position: relative; top: 1px" TabIndex="6" />
                </td>
                <td style="width: 100px">
                    <asp:ImageButton ID="imb_Sair" runat="server" ImageUrl="~/imagens/Botao_Sair.gif"
                        PostBackUrl="~/Pagina_Principal.aspx" Style="left: -1px; position: relative;
                        top: 1px" TabIndex="7" />
                </td>
            </tr>
        </table>
        <div style="z-index: 102; left: 17px; width: 275px; position: absolute; top: 231px;
            height: 135px">
            &nbsp; &nbsp; &nbsp; &nbsp;<br />
            <cc1:dropshadowextender id="DropShadowExtender1" runat="server" opacity="0.5" targetcontrolid="pnl_Form"
                trackposition="true" width="3"></cc1:dropshadowextender>
            <cc1:maskededitextender id="MaskedEditExtender1" runat="server" acceptnegative="Left"
                culturename="pt-BR" displaymoney="Left" errortooltipenabled="True" mask="99/99/9999"
                masktype="Date" messagevalidatortip="true" onfocuscssclass="MaskedEditFocus"
                oninvalidcssclass="MaskedEditError" targetcontrolid="txt_DataRecI"></cc1:maskededitextender>
            <cc1:calendarextender id="CalendarExtender1" runat="server" cssclass="MyCalendar"
                format="dd/MM/yyyy" popupbuttonid="imbCalendarDe" targetcontrolid="txt_DataRecI"></cc1:calendarextender>
            <cc1:maskededitextender id="MaskedEditExtender2" runat="server" acceptnegative="Left"
                culturename="pt-BR" displaymoney="Left" errortooltipenabled="True" mask="99/99/9999"
                masktype="Date" messagevalidatortip="true" onfocuscssclass="MaskedEditFocus"
                oninvalidcssclass="MaskedEditError" targetcontrolid="txt_DataRecF"></cc1:maskededitextender>
            <cc1:calendarextender id="CalendarExtender2" runat="server" cssclass="MyCalendar"
                format="dd/MM/yyyy" popupbuttonid="imbCalendarAte" targetcontrolid="txt_DataRecF"></cc1:calendarextender>
        </div>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Panel ID="pnl_Form" runat="server" Height="201px" Style="left: 300px; position: absolute;
            top: 232px" Width="347px">
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
                        <td align="right" style="height: 29px">
                            <asp:Label ID="lbl_TipoRem" runat="server" CssClass="LABEL_PAGES" Style="text-align: right"
                                Text="Remetente:" Width="162px"></asp:Label></td>
                        <td align="left" style="width: 132px; height: 29px">
                            <asp:DropDownList ID="ddl_Remetente" runat="server" CssClass="DROPDOWN_PAGES" DataSourceID="RemetenteDataSource" DataTextField="NOMREM" DataValueField="CODREM" Width="247px" TabIndex="2">
                            </asp:DropDownList></td>
                    </tr>
                    <tr>
                        <td align="right" style="height: 29px">
                            <asp:Label ID="lbl_TipoMp" runat="server" CssClass="LABEL_PAGES" Style="text-align: right"
                                Text="Tipo do Documento:" Width="162px"></asp:Label></td>
                        <td align="left" style="width: 132px; height: 29px">
                            <asp:DropDownList ID="ddl_TipoDocumento" runat="server" CssClass="DROPDOWN_PAGES"
                                Width="247px" TabIndex="3">
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
                                Width="96px" TabIndex="4"></asp:TextBox>
                            <asp:ImageButton ID="imbCalendarDe" runat="server" ImageUrl="~/imagens/Calendar_scheduleHS.png"
                                Style="z-index: 1; left: 314px; position: absolute; top: 135px" />
                            <cc1:MaskedEditValidator ID="MaskedEditValidator1" runat="server" ControlExtender="MaskedEditExtender1"
                                ControlToValidate="txt_DataRecI" ErrorMessage="*" InvalidValueBlurredMessage="*"
                                InvalidValueMessage="Data Inválida" IsValidEmpty="False" SetFocusOnError="True"
                                Style="left: 335px; position: absolute; top: 135px" Width="11px"></cc1:MaskedEditValidator>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" style="height: 38px">
                            <asp:Label ID="Label1" runat="server" CssClass="LABEL_PAGES" Style="text-align: right"
                                Text="Até:" Width="162px"></asp:Label>
                        </td>
                        <td align="left" style="width: 132px; height: 38px">
                            <asp:TextBox ID="txt_DataRecF" runat="server" CausesValidation="True" CssClass="TEXT_PAGES"
                                Width="96px" TabIndex="5"></asp:TextBox>
                            <asp:ImageButton ID="imbCalendarAte" runat="server" ImageUrl="~/imagens/Calendar_scheduleHS.png"
                                Style="z-index: 3; left: 314px; position: absolute; top: 175px" />
                            <cc1:MaskedEditValidator ID="MaskedEditValidator2" runat="server" ControlExtender="MaskedEditExtender2"
                                ControlToValidate="txt_DataRecF" ErrorMessage="*" InvalidValueBlurredMessage="*"
                                InvalidValueMessage="Data Inválida" IsValidEmpty="False" SetFocusOnError="True"
                                Style="left: 335px; position: absolute; top: 175px" Width="11px"></cc1:MaskedEditValidator>
                        </td>
                    </tr>
                </tbody>
            </table>
            <asp:SqlDataSource ID="RemetenteDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:RemetenteConnectionString %>"
                ProviderName="<%$ ConnectionStrings:RemetenteConnectionString.ProviderName %>" SelectCommand="SELECT DISTINCT &quot;NOMREM&quot;, &quot;CODREM&quot;&#13;&#10;FROM &quot;REMETENTE&quot;&#13;&#10;union all&#13;&#10;Select distinct 'TODOS' as &quot;NOMREM&quot;,&#13;&#10;       0 as &quot;CODREM&quot;&#13;&#10;FROM &quot;REMETENTE&quot;&#13;&#10;ORDER BY &quot;CODREM&quot;">
            </asp:SqlDataSource>
        </asp:Panel>
        <table id="Table1" class="TD_BOTOES_BODY" style="z-index: 101; left: 48px; top: 415px">
            <tr>
                <td style="width: 100px">
                    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/imagens/Botao_Imprimir.gif"
                        Style="left: 127px; position: relative; top: 1px" />
                </td>
                <td style="width: 100px">
                    <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/imagens/Botao_Sair.gif"
                        PostBackUrl="~/Pagina_Principal.aspx" Style="left: -1px; position: relative;
                        top: 1px" />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>

