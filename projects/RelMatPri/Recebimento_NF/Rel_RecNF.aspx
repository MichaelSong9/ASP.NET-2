<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Rel_RecNF.aspx.vb" Inherits="Recebimento_NF_Rel_RecNF" title="Untitled Page" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="DIV_PAGES">
        <asp:ScriptManager id="ScriptManager1" runat="server" EnableScriptGlobalization="True"
            EnableScriptLocalization="True">
        </asp:ScriptManager><table id="td_Botoes" class="TD_BOTOES_BODY" style="z-index: 101;
            left: 32px; top: 443px">
            <tr>
                <td style="width: 100px">
                    <asp:ImageButton ID="imb_Imprimir" runat="server" ImageUrl="~/imagens/Botao_Imprimir.gif"
                        Style="left: 127px; position: relative; top: 1px" TabIndex="11" />
                </td>
                <td style="width: 100px">
                    <asp:ImageButton ID="imb_Sair" runat="server" ImageUrl="~/imagens/Botao_Sair.gif"
                        PostBackUrl="~/Pagina_Principal.aspx" Style="left: -1px; position: relative;
                        top: 1px" TabIndex="12" />
                </td>
            </tr>
        </table>
        <div style="z-index: 102; left: 17px; width: 275px; position: absolute; top: 231px;
            height: 135px">
            &nbsp; &nbsp; &nbsp; &nbsp;<br />
            <cc1:DropShadowExtender ID="DropShadowExtender1" runat="server" Opacity="0.5" TargetControlID="pnl_Form"
                TrackPosition="true" Width="3">
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
            
        </div>
        <asp:Panel ID="pnl_Form" runat="server" Height="201px" Style="left: 299px; position: absolute;
            top: 184px" Width="347px">
            <table id="td_form" class="TD_FORM">
                <tbody>
                    <tr>
                        <td align="right" style="width: 100%; height: 31px">
                            <asp:Label ID="lbl_CodLoc" runat="server" CssClass="LABEL_PAGES" Style="text-align: right"
                                Text="Localização:" Width="162px"></asp:Label></td>
                        <td align="left" style="width: 132px; height: 31px">
                            <asp:DropDownList ID="ddl_Localizacao" runat="server" CssClass="DROPDOWN_PAGES" TabIndex="1"
                                Width="247px">
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
                        <td align="left" style="width: 132px; height: 31px">
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
                        <td align="right" style="width: 100%; height: 21px">
                            <asp:Label ID="Label5" runat="server" CssClass="LABEL_PAGES" Style="text-align: right"
                                Text="Código Remetente:" Width="162px"></asp:Label></td>
                        <td align="left" style="width: 132px; height: 21px">
                            <asp:DropDownList ID="ddl_CodRemetente" runat="server" CssClass="DROPDOWN_PAGES"
                                DataSourceID="CodRemSqlDataSource" DataTextField="NOMREM" DataValueField="CODREM"
                                Width="247px" TabIndex="3">
                            </asp:DropDownList></td>
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
                        <td align="right" style="height: 29px">
                            <asp:Label ID="Label3" runat="server" CssClass="LABEL_PAGES" Style="text-align: right"
                                Text="Nota Fiscal:" Width="162px"></asp:Label></td>
                        <td align="left" style="width: 132px; height: 29px"><asp:DropDownList ID="ddl_NotaFiscal" runat="server" CssClass="DROPDOWN_PAGES"
                                TabIndex="5" Width="247px" DataSourceID="NotaFiscalSqlDataSource" DataTextField="NUMNFR" DataValueField="NUMNFR">
                        </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" style="height: 28px">
                            <asp:Label ID="Label4" runat="server" CssClass="LABEL_PAGES" Style="text-align: right"
                                Text="Boletim Inicial:" Width="137px"></asp:Label></td>
                        <td align="left" style="width: 132px; height: 28px">
                            <asp:TextBox ID="txt_BoletimInicial" runat="server" CausesValidation="True" CssClass="TEXT_PAGES"
                                TabIndex="6" Width="53px" MaxLength="6"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txt_BoletimInicial"
                                ErrorMessage="*" ToolTip="Insira o Boletim"></asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td align="right" style="height: 28px">
                            <asp:Label ID="Label6" runat="server" CssClass="LABEL_PAGES" Style="text-align: right"
                                Text="Boletim Final:" Width="137px"></asp:Label></td>
                        <td align="left" style="width: 132px; height: 28px">
                            <asp:TextBox ID="txt_BoletimFinal" runat="server" CausesValidation="True" CssClass="TEXT_PAGES"
                                TabIndex="7" Width="53px" MaxLength="6"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txt_BoletimFinal"
                                ErrorMessage="*" ToolTip="Insira o Boletim"></asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td align="right" style="height: 28px">
                            <asp:Label ID="lbl_TeorMGF" runat="server" CssClass="LABEL_PAGES" Style="text-align: right"
                                Text="Código do Posto Fiscal:" Width="176px"></asp:Label></td>
                        <td align="left" style="width: 132px; height: 28px">
                            <asp:DropDownList ID="ddl_CodPos" runat="server" CssClass="DROPDOWN_PAGES" DataSourceID="CodPosSqlDataSource"
                                DataTextField="CODPOS" DataValueField="CODPOS" Width="247px" TabIndex="8">
                            </asp:DropDownList></td>
                    </tr>
                    <tr>
                        <td align="right" style="height: 28px">
                            <asp:Label ID="lbl_DataRecI" runat="server" CssClass="LABEL_PAGES" Text="Data Recebimento De:"
                                Width="162px"></asp:Label>
                        </td>
                        <td align="left" style="width: 132px; height: 28px">
                            <asp:TextBox ID="txt_DataRecI" runat="server" CausesValidation="True" CssClass="TEXT_PAGES"
                                TabIndex="9" Width="96px"></asp:TextBox>
                            <asp:ImageButton ID="imbCalendarDe" runat="server" ImageUrl="~/imagens/Calendar_scheduleHS.png"
                                Style="z-index: 1; left: 325px; position: absolute; top: 333px" />
                            <cc1:MaskedEditValidator ID="MaskedEditValidator1" runat="server" ControlExtender="MaskedEditExtender1"
                                ControlToValidate="txt_DataRecI" ErrorMessage="*" InvalidValueBlurredMessage="*"
                                InvalidValueMessage="Data Inválida" IsValidEmpty="False" SetFocusOnError="True"
                                Style="left: 350px; position: absolute; top: 335px" Width="11px"></cc1:MaskedEditValidator>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" style="height: 38px">
                            <asp:Label ID="Label1" runat="server" CssClass="LABEL_PAGES" Style="text-align: right"
                                Text="Até:" Width="162px"></asp:Label>
                        </td>
                        <td align="left" style="width: 132px; height: 38px">
                            <asp:TextBox ID="txt_DataRecF" runat="server" CausesValidation="True" CssClass="TEXT_PAGES"
                                TabIndex="10" Width="96px"></asp:TextBox>
                            <asp:ImageButton ID="imbCalendarAte" runat="server" ImageUrl="~/imagens/Calendar_scheduleHS.png"
                                Style="z-index: 3; left: 325px; position: absolute; top: 373px" />
                            <cc1:MaskedEditValidator ID="MaskedEditValidator2" runat="server" ControlExtender="MaskedEditExtender2"
                                ControlToValidate="txt_DataRecF" ErrorMessage="*" InvalidValueBlurredMessage="*"
                                InvalidValueMessage="Data Inválida" IsValidEmpty="False" SetFocusOnError="True"
                                Style="left: 352px; position: absolute; top: 373px" Width="11px"></cc1:MaskedEditValidator>
                        </td>
                    </tr>
                </tbody>
            </table>
            <asp:SqlDataSource ID="CodRemSqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:RemetenteConnectionString %>"
                ProviderName="<%$ ConnectionStrings:RemetenteConnectionString.ProviderName %>"
                SelectCommand="SELECT DISTINCT &quot;NOMREM&quot;, &quot;CODREM&quot; &#13;&#10;FROM &quot;REMETENTE&quot;&#13;&#10;union all&#13;&#10;Select distinct 'TODOS' as &quot;NOMREM&quot;,&#13;&#10;       0 as &quot;CODREM&quot;&#13;&#10;FROM &quot;REMETENTE&quot;&#13;&#10;ORDER BY &quot;CODREM&quot;">
            </asp:SqlDataSource>
            <asp:SqlDataSource ID="CodPosSqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:RemetenteConnectionString %>"
                ProviderName="<%$ ConnectionStrings:RemetenteConnectionString.ProviderName %>"
                SelectCommand="SELECT DISTINCT CODPOS FROM MPPCP&#13;&#10;UNION ALL&#13;&#10;SELECT DISTINCT 0 as CODPOS&#13;&#10;FROM MPPCP&#13;&#10;ORDER BY CODPOS">
            </asp:SqlDataSource>
            <asp:SqlDataSource ID="NotaFiscalSqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:RemetenteConnectionString %>"
                ProviderName="<%$ ConnectionStrings:RemetenteConnectionString.ProviderName %>"
                SelectCommand='SELECT DISTINCT "NUMNFR" FROM "MPPCP"'></asp:SqlDataSource>
        </asp:Panel>
        &nbsp;
    </div>
</asp:Content>

