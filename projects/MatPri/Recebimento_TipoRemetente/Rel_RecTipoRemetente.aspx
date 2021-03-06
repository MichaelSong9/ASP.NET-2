<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Rel_RecTipoRemetente.aspx.vb" Inherits="Recebimento_TipoRemetente_Rel_RecTipoRemetente" title="Untitled Page" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="DIV_PAGES">
        &nbsp;<table id="td_Botoes" class="TD_BOTOES_BODY">
            <tr>
                <td style="width: 100px">
                    <asp:ImageButton ID="imb_Imprimir" runat="server" ImageUrl="~/App_Themes/CCL/Imagens/Bt_Imprimir.gif"
                        Style="left: 83px; position: relative; top: 1px" TabIndex="8" />
                </td>
                <td style="width: 100px">
                    <asp:ImageButton ID="imb_Sair" runat="server" ImageUrl="~/App_Themes/CCL/Imagens/Bt_Sair.gif"
                        PostBackUrl="~/Pagina_Principal.aspx" Style="left: 5px; position: relative;
                        top: 1px" TabIndex="9" />
                </td>
            </tr>
        </table>
        <div style="z-index: 102; left: 481px; width: 208px; position: absolute; top: 264px;
            height: 135px">
            <cc1:DropShadowExtender ID="DropShadowExtender1" runat="server" Opacity="0.5" TargetControlID="pnl_Form"
                TrackPosition="true" Width="3">
            </cc1:DropShadowExtender>
            <cc1:MaskedEditExtender ID="MaskedEditExtender1" runat="server" AcceptNegative="Left"
                CultureName="pt-BR" DisplayMoney="Left" ErrorTooltipEnabled="True" Mask="99/99/9999"
                MaskType="Date" MessageValidatorTip="true" OnFocusCssClass="MaskedEditFocus"
                OnInvalidCssClass="MaskedEditError" TargetControlID="txt_DataRecI">
            </cc1:MaskedEditExtender>
            <cc1:CalendarExtender ID="CalendarExtender1" runat="server" CssClass="MyCalendar_tiporem_de"
                Format="dd/MM/yyyy" PopupButtonID="imbCalendarDe" TargetControlID="txt_DataRecI">
            </cc1:CalendarExtender>
            <cc1:MaskedEditExtender ID="MaskedEditExtender2" runat="server" AcceptNegative="Left"
                CultureName="pt-BR" DisplayMoney="Left" ErrorTooltipEnabled="True" Mask="99/99/9999"
                MaskType="Date" MessageValidatorTip="true" OnFocusCssClass="MaskedEditFocus"
                OnInvalidCssClass="MaskedEditError" TargetControlID="txt_DataRecF">
            </cc1:MaskedEditExtender>
            <cc1:CalendarExtender ID="CalendarExtender2" runat="server" CssClass="MyCalendar_tiporem_ate"
                Format="dd/MM/yyyy" PopupButtonID="imbCalendarAte" TargetControlID="txt_DataRecF">
            </cc1:CalendarExtender>
        <asp:ScriptManager id="ScriptManager1" runat="server" EnableScriptGlobalization="True"
            EnableScriptLocalization="True">
        </asp:ScriptManager>
            <asp:SqlDataSource ID="CodRemSqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:RemetenteConnectionString %>"
                ProviderName="<%$ ConnectionStrings:RemetenteConnectionString.ProviderName %>"
                SelectCommand="SELECT DISTINCT &quot;NOMREM&quot;, &quot;CODREM&quot; &#13;&#10;FROM &quot;REMETENTE&quot;&#13;&#10;union all&#13;&#10;Select distinct 'TODOS' as &quot;NOMREM&quot;,&#13;&#10;       0 as &quot;CODREM&quot;&#13;&#10;FROM &quot;REMETENTE&quot;&#13;&#10;ORDER BY &quot;CODREM&quot;">
            </asp:SqlDataSource>
        </div>
        <asp:Panel ID="pnl_Form" runat="server" CssClass="PANEL_FORM_TIPOREM">
            <table id="td_form" class="TD_FORM">
                <tbody>
                    <tr>
                        <td align="right" style="width: 100%; height: 31px">
                            <asp:Label ID="lbl_CodLoc" runat="server" CssClass="LABEL_PAGES" Style="text-align: right"
                                Text="Localiza��o:" Width="162px"></asp:Label></td>
                        <td align="left" style="width: 132px; height: 31px">
                            <asp:DropDownList ID="ddl_Localizacao" runat="server" CssClass="DROPDOWN_PAGES" Width="247px" TabIndex="1">
                                <asp:ListItem Selected="True" Value="0">TODOS</asp:ListItem>
                                <asp:ListItem Value="01">01-CENTRAL</asp:ListItem>
                                <asp:ListItem Value="02">02-F.B.V.B</asp:ListItem>
                                <asp:ListItem Value="07">07-J.R.A</asp:ListItem>
                            </asp:DropDownList></td>
                        <td align="left" style="width: 132px; height: 31px">
                        </td>
                    </tr>
                    <tr>
                        <td align="right" style="width: 100%; height: 30px">
                            <asp:Label ID="lbl_TipoRem" runat="server" CssClass="LABEL_PAGES" Style="text-align: right"
                                Text="Tipo do Remetente:" Width="162px"></asp:Label></td>
                        <td align="left" style="width: 132px; height: 30px">
                            <asp:DropDownList ID="ddl_TipoRemetente" runat="server" CssClass="DROPDOWN_PAGES" TabIndex="2"
                                Width="247px">
                                <asp:ListItem Value="0">TODOS</asp:ListItem>
                                <asp:ListItem Value="1">ASSOCIADA</asp:ListItem>
                                <asp:ListItem Value="2">TERCEIRO</asp:ListItem>
                                <asp:ListItem Value="3">UNIDADE</asp:ListItem>
                                <asp:ListItem Value="4">EM FORMA&#199;&#195;O</asp:ListItem>
                            </asp:DropDownList></td>
                        <td align="left" style="width: 132px; height: 30px">
                        </td>
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
                        <td align="left" style="width: 132px; height: 21px">
                        </td>
                    </tr>
                    <tr>
                        <td align="right" style="height: 29px">
                            <asp:Label ID="lbl_TipoDOC" runat="server" CssClass="LABEL_PAGES" Style="text-align: right"
                                Text="Tipo do Documento:" Width="162px"></asp:Label></td>
                        <td align="left" style="width: 132px; height: 29px">
                            <asp:RadioButton ID="rdlSelecione" runat="server" AutoPostBack="True" GroupName="TipDoc"
                                Text="Selecione" ToolTip="Selecione o tipo de documento" /><asp:RadioButton ID="rdlTodos" runat="server" AutoPostBack="True"
                                    GroupName="TipDoc" Text="Todos" ToolTip="Seleciona todos tipos de documento" /></td>
                        <td align="left" style="width: 132px; height: 29px">
                            &nbsp; &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td align="right" style="height: 19px">
                            <asp:Label ID="lbl_DataRecI" runat="server" CssClass="LABEL_PAGES" Text="Data Recebimento De:"
                                Width="162px"></asp:Label>
                        </td>
                        <td align="left" style="width: 132px; height: 19px">
                            <asp:TextBox ID="txt_DataRecI" runat="server" CausesValidation="True" CssClass="TEXT_PAGES"
                                TabIndex="6" Width="96px"></asp:TextBox>
                            <asp:ImageButton ID="imbCalendarDe" runat="server" ImageUrl="~/App_Themes/CCL/Imagens/Calendar_scheduleHS.png"
                                Style="z-index: 1;" ToolTip="Calend�rio" />
                            <cc1:MaskedEditValidator ID="MaskedEditValidator1" runat="server" ControlExtender="MaskedEditExtender1"
                                ControlToValidate="txt_DataRecI" ErrorMessage="*" InvalidValueBlurredMessage="*"
                                InvalidValueMessage="Data Inv�lida" SetFocusOnError="True" Width="11px"></cc1:MaskedEditValidator>
                        </td>
                        <td align="left" style="width: 132px; height: 19px">
                        </td>
                    </tr>
                    <tr>
                        <td align="right" style="height: 25px">
                            <asp:Label ID="Label1" runat="server" CssClass="LABEL_PAGES" Style="text-align: right"
                                Text="At�:" Width="162px"></asp:Label>
                        </td>
                        <td align="left" style="width: 132px; height: 25px">
                            <asp:TextBox ID="txt_DataRecF" runat="server" CausesValidation="True" CssClass="TEXT_PAGES"
                                TabIndex="7" Width="96px"></asp:TextBox>
                            <asp:ImageButton ID="imbCalendarAte" runat="server" ImageUrl="~/App_Themes/CCL/Imagens/Calendar_scheduleHS.png"
                                Style="z-index: 3;" ToolTip="Calend�rio" />
                            <cc1:MaskedEditValidator ID="MaskedEditValidator2" runat="server" ControlExtender="MaskedEditExtender2"
                                ControlToValidate="txt_DataRecF" ErrorMessage="*" InvalidValueBlurredMessage="*"
                                InvalidValueMessage="Data Inv�lida" SetFocusOnError="True" Width="11px"></cc1:MaskedEditValidator>
                        </td>
                        <td align="left" style="width: 132px; height: 25px">
                        </td>
                    </tr>
                </tbody>
            </table>
        </asp:Panel>
    </div>
</asp:Content>

