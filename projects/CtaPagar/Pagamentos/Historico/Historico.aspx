<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false"
    CodeFile="Historico.aspx.vb" Inherits="Pagamentos_Historico_Historico" Title="Untitled Page" %>

<%@ Register Assembly="FreeTextBox" Namespace="FreeTextBoxControls" TagPrefix="FTB" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="DIV_PAGES" style="text-align: center">
        &nbsp;
        <div style="z-index: 101; left: 19px; width: 126px; position: absolute; top: 807px;
            height: 195px">
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <cc1:MaskedEditExtender ID="CGCDe" runat="server" CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder=""
                CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" CultureThousandsPlaceholder=""
                CultureTimePlaceholder="" Enabled="True" Mask="99999999" MaskType="Number" TargetControlID="txt_CGCInicial">
            </cc1:MaskedEditExtender>
            <cc1:MaskedEditExtender ID="CGCAte" runat="server" CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder=""
                CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" CultureThousandsPlaceholder=""
                CultureTimePlaceholder="" Enabled="True" Mask="99999999" MaskType="Number" TargetControlID="txt_CGCFinal">
            </cc1:MaskedEditExtender>
            <cc1:DropShadowExtender ID="Opcoes" runat="server" Enabled="True" Opacity="0.5" TargetControlID="pnl_Opcoes"
                TrackPosition="True" Width="3">
            </cc1:DropShadowExtender>
            <cc1:CalendarExtender ID="CalendarExtender1" runat="server" Enabled="True" Format="dd/MM/yyyy"
                PopupButtonID="imbCalendarDe" TargetControlID="txt_DataInicial">
            </cc1:CalendarExtender>
            <cc1:CalendarExtender ID="CalendarExtender2" runat="server" Enabled="True" Format="dd/MM/yyyy"
                PopupButtonID="imbCalendarAte" TargetControlID="txt_DataFinal">
            </cc1:CalendarExtender>
            <cc1:MaskedEditExtender ID="MaskedEditExtender1" runat="server" CultureAMPMPlaceholder=""
                CultureCurrencySymbolPlaceholder="R$ " CultureDateFormat="DMY" CultureDatePlaceholder="/"
                CultureDecimalPlaceholder="," CultureName="pt-BR" CultureThousandsPlaceholder="."
                CultureTimePlaceholder=":" Enabled="True" ErrorTooltipEnabled="True" Mask="99/99/9999"
                MaskType="Date" TargetControlID="txt_DataInicial">
            </cc1:MaskedEditExtender>
            <cc1:MaskedEditExtender ID="MaskedEditExtender2" runat="server" CultureAMPMPlaceholder=""
                CultureCurrencySymbolPlaceholder="R$ " CultureDateFormat="DMY" CultureDatePlaceholder="/"
                CultureDecimalPlaceholder="," CultureName="pt-BR" CultureThousandsPlaceholder="."
                CultureTimePlaceholder=":" Enabled="True" ErrorTooltipEnabled="True" Mask="99/99/9999"
                MaskType="Date" TargetControlID="txt_DataFinal">
            </cc1:MaskedEditExtender>
            <cc1:ModalPopupExtender ID="VisualizarGridModalPopupExtender" runat="server" BackgroundCssClass="MODALBACKGROUND"
                CancelControlID="imb_Fechar" PopupControlID="pnlGridVisualizar" TargetControlID="lbGridVisualizar">
            </cc1:ModalPopupExtender>
            <cc1:MaskedEditExtender ID="MaskedEditExtender3" runat="server" Mask="????????" TargetControlID="txt_TituloDe">
            </cc1:MaskedEditExtender>
            <cc1:MaskedEditExtender ID="MaskedEditExtender4" runat="server" Mask="????????" TargetControlID="txt_TituloAte">
            </cc1:MaskedEditExtender>
        </div>
        <div id="divCamposObrigatorios" style="width: 654px; height: 120px">
            <asp:Panel ID="pnl_Opcoes" runat="server" Height="20px" Width="633px">
                <table id="tdOpcoes" class="TD_FORM">
                    <tr>
                        <td style="width: 174px; text-align: right">
                            <asp:Label ID="lbl_EnvioDe" runat="server" Text="Data de Envio de:" Width="171px"></asp:Label>
                        </td>
                        <td style="width: 178px; text-align: left">
                            <asp:TextBox ID="txt_DataInicial" runat="server" CausesValidation="True" CssClass="TEXT_PAGES"
                                Width="100px" TabIndex="1"></asp:TextBox>
                            <asp:ImageButton ID="imbCalendarDe" runat="server" ImageUrl="~/App_Themes/CCL/Imagens/Calendar_scheduleHS.png"
                                Style="left: 94px; top: 2px" TabIndex="8" ToolTip="Calendário" />
                            &nbsp;
                            <cc1:MaskedEditValidator ID="MaskedEditValidator1" runat="server" ControlExtender="MaskedEditExtender1"
                                ControlToValidate="txt_DataInicial" ErrorMessage="*" InvalidValueBlurredMessage="*"
                                InvalidValueMessage="Data Inválida" SetFocusOnError="True"></cc1:MaskedEditValidator>
                        </td>
                        <td style="width: 36px; text-align: right">
                            <asp:Label ID="lblEnvioAte" runat="server" Text="Até:"></asp:Label>
                        </td>
                        <td style="width: 218px; text-align: left">
                            <asp:TextBox ID="txt_DataFinal" runat="server" CausesValidation="True" CssClass="TEXT_PAGES"
                                TabIndex="2" Width="100px"></asp:TextBox>
                            &nbsp;
                            <asp:ImageButton ID="imbCalendarAte" runat="server" ImageUrl="~/App_Themes/CCL/Imagens/Calendar_scheduleHS.png"
                                Style="left: 93px; top: 0px" TabIndex="9" ToolTip="Calendário" />
                            &nbsp;
                            <cc1:MaskedEditValidator ID="MaskedEditValidator2" runat="server" ControlExtender="MaskedEditExtender2"
                                ControlToValidate="txt_DataFinal" ErrorMessage="*" InvalidValueBlurredMessage="*"
                                InvalidValueMessage="Data Inválida" SetFocusOnError="True"></cc1:MaskedEditValidator>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 174px; text-align: right">
                            <asp:Label ID="lbl_CNPJDe" runat="server" Text="CNPJ de:"></asp:Label>
                        </td>
                        <td style="width: 178px; text-align: left">
                            <asp:TextBox ID="txt_CGCInicial" runat="server" CssClass="TEXT_PAGES" TabIndex="3"
                                Width="100px"></asp:TextBox>
                        </td>
                        <td style="width: 36px; text-align: right">
                            <asp:Label ID="lbl_CNPJAte" runat="server" Text="Até:"></asp:Label>
                        </td>
                        <td style="width: 218px; text-align: left">
                            <asp:TextBox ID="txt_CGCFinal" runat="server" CssClass="TEXT_PAGES" TabIndex="4"
                                Width="100px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 174px; height: 23px; text-align: right">
                            <asp:Label ID="lblTituloDe" runat="server" Text="Título de:"></asp:Label>
                        </td>
                        <td style="width: 178px; height: 23px; text-align: left">
                            <asp:TextBox ID="txt_TituloDe" runat="server" CssClass="TEXT_PAGES" TabIndex="5"
                                Width="100px" MaxLength="8"></asp:TextBox>
                        </td>
                        <td style="width: 36px; height: 23px; text-align: right">
                            <asp:Label ID="lblTituloAte" runat="server" Text="Até:"></asp:Label>
                        </td>
                        <td style="width: 218px; height: 23px; text-align: left">
                            <asp:TextBox ID="txt_TituloAte" runat="server" CssClass="TEXT_PAGES" TabIndex="6"
                                Width="100px" MaxLength="8"></asp:TextBox>
                        </td>
                    </tr>
                </table>
            </asp:Panel>
        </div>
        <div style="z-index: 102; left: 380px; width: 186px; position: absolute; top: 412px;
            height: 100px">
            <asp:UpdateProgress ID="UpdateProgress1" runat="server" DisplayAfter="300">
                <ProgressTemplate>
                    <asp:Panel ID="pnlProcessando" runat="server" Width="334px" Height="1px" BorderColor="LightGray"
                        BackColor="#B5C7DE" BorderStyle="Double">
                        <img style="width: 15px" src="../../App_Themes/CCL/Imagens/loading.gif" />
                        Aguarde, as informações estão sendo processadas...</asp:Panel>
                </ProgressTemplate>
            </asp:UpdateProgress>
        </div>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Panel ID="pnlGridEmail" runat="server" Width="980px" Height="350px">
                    <asp:GridView ID="gridEmail" TabIndex="10" runat="server" Width="950px" Height="125px"
                        BorderColor="#999999" BackColor="White" BorderStyle="None"
                        BorderWidth="1px" AutoGenerateColumns="False" CellPadding="3" GridLines="Vertical"
                        ShowFooter="True" DataKeyNames="CGC" AllowPaging="True" AllowSorting="True">
                        <FooterStyle BackColor="#CCCCCC" BorderStyle="None" ForeColor="Black"></FooterStyle>
                        <Columns>
                            <asp:BoundField DataField="CGC" HeaderText="CNPJ"></asp:BoundField>
                            <asp:TemplateField HeaderText="E-mail" ShowHeader="False">
                                <ItemTemplate>
                                    <div style="left: 0px; overflow: hidden; width: 182px; top: 0px; height: 16px">
                                        <asp:Label ID="lblEmail" runat="server" ToolTip='<%# Bind("EMAIL") %>' Text='<%# Bind("EMAIL") %>'></asp:Label></div>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Data/Hora de Envio" ShowHeader="False">
                                <ItemTemplate>
                                    <div style="left: 0px; overflow: hidden; width: 122px; top: 0px; height: 16px">
                                        <asp:Label ID="lblDataEnvio" runat="server" ToolTip='<%# Bind("DATA_ENVIO") %>' Width="116px"
                                            Text='<%# Bind("DATA_ENVIO") %>'></asp:Label></div>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Usu&#225;rio" ShowHeader="False">
                                <ItemTemplate>
                                    <div style="left: 0px; overflow: hidden; width: 112px; top: 0px; height: 16px">
                                        <asp:Label ID="lblUsuarioEnviou" runat="server" ToolTip='<%# Bind("USUARIO") %>'
                                            Text='<%# Bind("USUARIO") %>'></asp:Label></div>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Intervalo De" ShowHeader="False">
                                <ItemTemplate>
                                    <div style="left: 0px; overflow: hidden; width: 86px; top: 0px; height: 16px">
                                        <asp:Label ID="lblIntervaloDe" runat="server" ToolTip='<%# Bind("INTERVALO_DE") %>'
                                            Text='<%# Bind("INTERVALO_DE") %>'></asp:Label></div>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="At&#233;" ShowHeader="False">
                                <ItemTemplate>
                                    <div style="left: 0px; overflow: hidden; width: 86px; top: 0px; height: 16px">
                                        <asp:Label ID="lblIntervaloAte" runat="server" ToolTip='<%# Bind("INTERVALO_ATE") %>'
                                            Text='<%# Bind("INTERVALO_ATE") %>'></asp:Label></div>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="T&#237;tulo" ShowHeader="False">
                                <ItemTemplate>
                                    <div style="left: 0px; overflow: hidden; width: 106px; top: 0px; height: 16px">
                                        <asp:Label ID="lblTitulo" runat="server" ToolTip='<%# Bind("TITULO") %>' Text='<%# Bind("TITULO") %>'></asp:Label></div>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:CommandField EditImageUrl="~/App_Themes/CCL/Imagens/visualizar.gif" ShowCancelButton="False"
                                EditText="Visualizar T&#237;tulos Pagos" ButtonType="Image" HeaderText="Visualizar T&#237;tulos"
                                ShowEditButton="True"></asp:CommandField>
                        </Columns>
                        <RowStyle BackColor="#EEEEEE" ForeColor="Black"></RowStyle>
                        <SelectedRowStyle BackColor="#008A8C" ForeColor="White" Font-Bold="True"></SelectedRowStyle>
                        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center"></PagerStyle>
                        <HeaderStyle BackColor="#CAD7E7" ForeColor="#4C4CA5" Font-Overline="False" Font-Bold="True">
                        </HeaderStyle>
                        <AlternatingRowStyle BackColor="White"></AlternatingRowStyle>
                    </asp:GridView>
                </asp:Panel>
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="imbPesquisar" EventName="Click"></asp:AsyncPostBackTrigger>
                <asp:AsyncPostBackTrigger ControlID="gridEmail" EventName="RowEditing"></asp:AsyncPostBackTrigger>
                <asp:AsyncPostBackTrigger ControlID="gridEmail" EventName="PageIndexChanging"></asp:AsyncPostBackTrigger>
            </Triggers>
        </asp:UpdatePanel>
        <table id="Table1">
            <tr>
                <td style="width: 615px; height: 12px; background-color: #b5c7de; text-align: center">
                    <asp:ImageButton ID="imbPesquisar" runat="server" ImageUrl="~/App_Themes/CCL/Imagens/Bt_Pesquisar_.gif"
                        TabIndex="7" />&nbsp;
                    <asp:ImageButton ID="imbSair" runat="server" Height="36px" ImageUrl="~/App_Themes/CCL/Imagens/Bt_Sair.gif"
                        PostBackUrl="~/Pagina_Principal.aspx" TabIndex="8" />
                </td>
            </tr>
        </table>
        <div style="z-index: 103; left: 885px; width: 75px; position: absolute; top: 775px;
            height: 13px">
            <asp:LinkButton ID="lbGridVisualizar" runat="server" ForeColor="White" Width="49px"
                TabIndex="40">_____</asp:LinkButton><asp:TextBox ID="txtProcessa" runat="server"
                    Height="11px" Visible="False" Width="1px" TabIndex="41"></asp:TextBox>
        </div>
        <asp:UpdatePanel ID="UpdatePanel2" runat="server" ChildrenAsTriggers="False" UpdateMode="Conditional">
            <ContentTemplate>
                <asp:Panel Style="display: none; z-index: 102; border-top-style: outset; border-right-style: outset;
                    border-left-style: outset; background-color: #dae5f9; border-bottom-style: outset"
                    ID="pnlGridVisualizar" runat="server" Width="842px" Height="221px"
                    ScrollBars="Auto">
                    <div style="width: 818px; height: 2px; text-align: right">
                        <asp:ImageButton ID="imb_Fechar" runat="server" ImageUrl="~/App_Themes/CCL/Imagens/fechar.jpg"></asp:ImageButton></div>
                    <asp:GridView ID="gridVisTit" runat="server" Width="630px" Height="125px" BorderColor="#999999"
                        ForeColor="#333333" BackColor="White" BorderStyle="None"
                        GridLines="Vertical" CellPadding="3" AutoGenerateColumns="False" BorderWidth="1px"
                        PageSize="5">
                        <FooterStyle BackColor="#5D7B9D" ForeColor="White" Font-Bold="True"></FooterStyle>
                        <Columns>
                            <asp:TemplateField HeaderText="T&#237;tulo">
                                <EditItemTemplate>
                                    <asp:TextBox runat="server" Text='<%# Bind("Num_TIT") %>' ID="TextBox1"></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <div style="left: 0px; overflow: hidden; width: 70px; top: 0px; height: 16px">
                                        <asp:Label ID="Label1" runat="server" ToolTip='<%# Bind("Num_TIT") %>' Text='<%# Bind("Num_TIT") %>'></asp:Label></div>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Tipo">
                                <EditItemTemplate>
                                    <asp:TextBox runat="server" Text='<%# Bind("Descr_Tit") %>' ID="TextBox2"></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <div style="left: 0px; overflow: hidden; width: 78px; top: 0px; height: 16px">
                                        <asp:Label ID="Label2" runat="server" ToolTip='<%# Bind("Descr_Tit") %>' Text='<%# Bind("Descr_Tit") %>'></asp:Label></div>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Situa&#231;&#227;o">
                                <EditItemTemplate>
                                    <asp:TextBox runat="server" Text='<%# Bind("Desc_Situa") %>' ID="TextBox3"></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <div style="left: 0px; overflow: hidden; width: 86px; top: 0px; height: 16px">
                                        <asp:Label ID="Label3" runat="server" ToolTip='<%# Bind("Desc_Situa") %>' Text='<%# Bind("Desc_Situa") %>'></asp:Label></div>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="&#205;ndice">
                                <EditItemTemplate>
                                    <asp:TextBox runat="server" Text='<%# Bind("NomeIndice") %>' ID="TextBox4"></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <div style="left: 0px; overflow: hidden; width: 44px; top: 0px; height: 16px">
                                        <asp:Label ID="Label4" runat="server" ToolTip='<%# Bind("NomeIndice") %>' Text='<%# Bind("NomeIndice") %>'></asp:Label></div>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Vencimento">
                                <EditItemTemplate>
                                    <asp:TextBox runat="server" Text='<%# Bind("Data_Venc") %>' ID="TextBox5"></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <div style="left: 0px; overflow: hidden; width: 66px; top: 0px; height: 16px">
                                        <asp:Label ID="Label5" runat="server" ToolTip='<%# Bind("Data_Venc") %>' Text='<%# Bind("Data_Venc") %>'></asp:Label></div>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Pagamento">
                                <EditItemTemplate>
                                    <asp:TextBox runat="server" Text='<%# Bind("Data_Liq") %>' ID="TextBox6"></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <div style="left: 0px; overflow: hidden; width: 66px; top: 0px; height: 16px">
                                        <asp:Label ID="Label6" runat="server" ToolTip='<%# Bind("Data_Liq") %>' Text='<%# Bind("Data_Liq") %>'></asp:Label></div>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Banco">
                                <EditItemTemplate>
                                    <asp:TextBox runat="server" Text='<%# Bind("CodBanco") %>' ID="TextBox7"></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <div style="left: 0px; overflow: hidden; width: 32px; top: 0px; height: 16px">
                                        <asp:Label ID="Label7" runat="server" ToolTip='<%# Bind("CodBanco") %>' Width="13px"
                                            Text='<%# Bind("CodBanco") %>'></asp:Label></div>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Ag&#234;ncia">
                                <EditItemTemplate>
                                    <asp:TextBox runat="server" Text='<%# Bind("Agencia") %>' ID="TextBox8"></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <div style="left: 0px; overflow: hidden; width: 39px; top: 0px; height: 16px">
                                        <asp:Label ID="Label8" runat="server" ToolTip='<%# Bind("Agencia") %>' Text='<%# Bind("Agencia") %>'></asp:Label></div>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Conta">
                                <EditItemTemplate>
                                    <asp:TextBox runat="server" Text='<%# Bind("Conta") %>' ID="TextBox9"></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <div style="left: 0px; overflow: hidden; width: 53px; top: 0px; height: 16px">
                                        <asp:Label ID="Label9" runat="server" ToolTip='<%# Bind("Conta") %>' Text='<%# Bind("Conta") %>'></asp:Label></div>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Observa&#231;&#227;o">
                                <EditItemTemplate>
                                    <asp:TextBox runat="server" Text='<%# Bind("Observ_t") %>' ID="TextBox10"></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <div style="left: 0px; overflow: hidden; width: 130px; top: 0px; height: 16px">
                                        <asp:Label ID="Label10" runat="server" ToolTip='<%# Bind("Observ_t") %>' Text='<%# Bind("Observ_t") %>'></asp:Label></div>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Valor">
                                <EditItemTemplate>
                                    <asp:TextBox runat="server" Text='<%# Bind("Val_Rat") %>' ID="TextBox11"></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <div style="left: 0px; overflow: hidden; width: 68px; top: 0px; height: 16px">
                                        <asp:Label ID="Label11" runat="server" ToolTip='<%# Bind("Valor_T") %>' Text='<%# Bind("Valor_T") %>'></asp:Label></div>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333"></RowStyle>
                        <EditRowStyle BackColor="#999999"></EditRowStyle>
                        <SelectedRowStyle BackColor="#E2DED6" ForeColor="#333333" Font-Bold="True"></SelectedRowStyle>
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center"></PagerStyle>
                        <HeaderStyle BackColor="#CAD7E7" ForeColor="#4C4CA5" Font-Bold="True"></HeaderStyle>
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775"></AlternatingRowStyle>
                    </asp:GridView>
                    <div style="width: 816px; height: 2px">
                    </div>
                </asp:Panel>
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="gridEmail" EventName="RowEditing"></asp:AsyncPostBackTrigger>
            </Triggers>
        </asp:UpdatePanel>
    </div>
</asp:Content>
