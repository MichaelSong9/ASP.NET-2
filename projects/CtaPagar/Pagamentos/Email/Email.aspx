<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false"
    CodeFile="Email.aspx.vb" ValidateRequest="false" Inherits="Pagamentos_Email_Email"
    Title="Untitled Page" %>

<%--<%@ OutputCache Duration="1" Location="Any" VaryByParam="*" %>
--%>
<%@ Register Assembly="FreeTextBox" Namespace="FreeTextBoxControls" TagPrefix="FTB" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="DIV_PAGES">
        <div id="DIV_Principal" class="DIV_PAGES" style="text-align: center">
            &nbsp;
            <div style="z-index: 101; left: 146px; width: 126px; position: absolute; top: 1237px;
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
                <cc1:ModalPopupExtender ID="ModalPopupExtender1" runat="server" BackgroundCssClass="MODALBACKGROUND"
                    CancelControlID="imbSairFtb" DynamicServicePath="" Enabled="True" PopupControlID="pnlEmail"
                    TargetControlID="lbNovoEmail">
                </cc1:ModalPopupExtender>
                <cc1:ModalPopupExtender ID="ModalPopupExtender2" runat="server" BackgroundCssClass="MODALBACKGROUND"
                    DynamicServicePath="" Enabled="True" PopupControlID="pnlAnexar" TargetControlID="lbAnexar">
                </cc1:ModalPopupExtender>
                <cc1:ModalPopupExtender ID="VisualizarGridModalPopupExtender" runat="server" BackgroundCssClass="MODALBACKGROUND"
                    CancelControlID="imb_Fechar" PopupControlID="pnlGridVisualizar" TargetControlID="lbGridVisualizar">
                </cc1:ModalPopupExtender>
            </div>
            <div style="z-index: 103; left: 899px; width: 100px; position: absolute; top: 774px;
                height: 16px">
                <asp:LinkButton ID="lbGridVisualizar" runat="server" ForeColor="White" Width="1px"
                    Height="2px">_____</asp:LinkButton>
                <asp:LinkButton ID="lbNovoEmail" runat="server" ForeColor="White" Width="1px" Height="1px">_____</asp:LinkButton>
                <asp:TextBox ID="txtProcessa" runat="server" Visible="False" Width="1px" Height="11px"></asp:TextBox>
            </div>
            <br />
            <div id="divCamposObrigatorios" style="width: 654px; height: 116px">
                <asp:Panel ID="pnl_Opcoes" runat="server" Height="20px" Width="633px">
                    <table id="tdOpcoes" class="TD_FORM">
                        <tr>
                            <td style="width: 174px; text-align: right">
                                <asp:Label ID="lbl_PagamentoDe" runat="server" Text="Data de Pagamento de:" Width="171px"></asp:Label>
                            </td>
                            <td style="width: 178px; text-align: left">
                                <asp:TextBox ID="txt_DataInicial" runat="server" CausesValidation="True" CssClass="TEXT_PAGES"
                                    Width="100px"></asp:TextBox>
                                <asp:ImageButton ID="imbCalendarDe" runat="server" ImageUrl="~/App_Themes/CCL/Imagens/Calendar_scheduleHS.png"
                                    Style="left: 94px; top: 2px" ToolTip="Calendário" TabIndex="8" />
                                &nbsp;
                                <cc1:MaskedEditValidator ID="MaskedEditValidator1" runat="server" ControlExtender="MaskedEditExtender1"
                                    ControlToValidate="txt_DataInicial" ErrorMessage="*" InvalidValueBlurredMessage="*"
                                    InvalidValueMessage="Data Inválida" SetFocusOnError="True"></cc1:MaskedEditValidator>
                            </td>
                            <td style="width: 36px; text-align: right">
                                <asp:Label ID="lblPagamentoAte" runat="server" Text="Até:"></asp:Label>
                            </td>
                            <td style="width: 218px; text-align: left">
                                <asp:TextBox ID="txt_DataFinal" runat="server" CausesValidation="True" CssClass="TEXT_PAGES"
                                    TabIndex="1" Width="100px"></asp:TextBox>
                                &nbsp;
                                <asp:ImageButton ID="imbCalendarAte" runat="server" ImageUrl="~/App_Themes/CCL/Imagens/Calendar_scheduleHS.png"
                                    Style="left: 93px; top: 0px" ToolTip="Calendário" TabIndex="9" />
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
                                <asp:TextBox ID="txt_CGCInicial" runat="server" CssClass="TEXT_PAGES" TabIndex="2"
                                    Width="100px"></asp:TextBox>
                                &nbsp;&nbsp; &nbsp; &nbsp;&nbsp;
                            </td>
                            <td style="width: 36px; text-align: right">
                                <asp:Label ID="lbl_CNPJAte" runat="server" Text="Até:"></asp:Label>
                            </td>
                            <td style="width: 218px; text-align: left">
                                <asp:TextBox ID="txt_CGCFinal" runat="server" CssClass="TEXT_PAGES" TabIndex="3"
                                    Width="100px"></asp:TextBox>
                                &nbsp; &nbsp; &nbsp;&nbsp;
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
            </div>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server" ChildrenAsTriggers="False" UpdateMode="Conditional">
                <ContentTemplate>
                    <asp:Panel ID="pnlGridEmail" runat="server" Width="980px" Height="350px">
                        <asp:GridView ID="gridEmail" runat="server" Width="850px" Height="125px" BorderColor="#999999"
                            BackColor="White" AllowSorting="True" AllowPaging="True" AutoGenerateColumns="False"
                            CellPadding="3" GridLines="Vertical" BorderWidth="1px" ShowFooter="True" DataKeyNames="CGC"
                            BorderStyle="None">
                            <FooterStyle BackColor="#CCCCCC" BorderStyle="None" ForeColor="Black"></FooterStyle>
                            <Columns>
                                <asp:BoundField DataField="cgc" HeaderText="CNPJ"></asp:BoundField>
                                <asp:TemplateField HeaderText="Raz&#227;o Social" ShowHeader="False">
                                    <ItemTemplate>
                                        <div style="left: 0px; overflow: hidden; width: 232px; top: 0px; height: 16px">
                                            <asp:Label ID="lblRazaoSocial" runat="server" ToolTip='<%# Bind("RAZAO_SOC") %>'
                                                Text='<%# Bind("RAZAO_SOC") %>'></asp:Label></div>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Nome Fantasia" ShowHeader="False">
                                    <ItemTemplate>
                                        <div style="left: 0px; overflow: hidden; width: 164px; top: 0px; height: 16px">
                                            <asp:Label ID="lblFantasia" runat="server" ToolTip='<%# Bind("FANTASIA") %>' Text='<%# Bind("FANTASIA") %>'></asp:Label></div>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Selecionar E-mail">
                                    <HeaderTemplate>
                                        <asp:Label ID="lblSelecionarEmail" runat="server" Text="Enviar E-mail"></asp:Label>
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <div style="left: 0px; overflow: hidden; width: 36px; top: 0px; height: 16px">
                                            <asp:CheckBox ID="ItemEmailCheckBox" runat="server" ToolTip="Seleciona o e-mail a ser enviado"
                                                Width="1px" Height="10px"></asp:CheckBox></div>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="E-mail" ShowHeader="False">
                                    <ItemTemplate>
                                        <div style="left: 0px; overflow: hidden; width: 222px; top: 0px; height: 16px">
                                            <asp:Label ID="lblEmail" runat="server" ToolTip='<%# Bind("E_MAIL") %>' Text='<%# Bind("E_MAIL") %>'></asp:Label></div>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Anexar">
                                    <HeaderTemplate>
                                        <asp:Label ID="lblAnexar" runat="server" ToolTip="Anexar arquivos de pagamentos"
                                            Text="Anexar Arq."></asp:Label>
                                        <br />
                                        <input id="chkHeaderAnexar" onclick="javascript:SelecionaTodosChecks(this);" type="checkbox"
                                            runat="server" visible="false" />
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <div style="left: 0px; overflow: hidden; width: 35px; top: 0px; height: 16px">
                                            <asp:CheckBox ID="ItemAnexarCheckBox" runat="server" ToolTip="Seleciona o arquivo a ser gerado"
                                                Width="18px" Height="18px"></asp:CheckBox></div>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Visualizar Arquivo">
                                    <ItemTemplate>
                                        <div style="left: 0px; overflow: hidden; width: 35px; top: 0px; height: 19px">
                                            <asp:ImageButton ID="imbVisualizar" runat="server" ToolTip="Visualizar o arquivo PDF"
                                                ImageUrl="~/App_Themes/CCL/Imagens/Bt_Visualizar_Arquivo.gif" ForeColor="Transparent">
                                            </asp:ImageButton></div>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:CommandField EditImageUrl="~/App_Themes/CCL/Imagens/visualizar.gif" ShowCancelButton="False"
                                    EditText="Visualizar Titulos" ButtonType="Image" HeaderText="Visualizar Titulos"
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
                    <asp:AsyncPostBackTrigger ControlID="imbProcessar" EventName="Click"></asp:AsyncPostBackTrigger>
                    <asp:AsyncPostBackTrigger ControlID="gridEmail" EventName="RowEditing"></asp:AsyncPostBackTrigger>
                    <asp:AsyncPostBackTrigger ControlID="gridVisTit" EventName="DataBinding"></asp:AsyncPostBackTrigger>
                    <asp:AsyncPostBackTrigger ControlID="gridEmail" EventName="PageIndexChanging"></asp:AsyncPostBackTrigger>
                </Triggers>
            </asp:UpdatePanel>
            <div style="z-index: 102; left: 364px; width: 186px; position: absolute; top: 403px;
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
            <table id="Table1">
                <tr>
                    <td style="width: 615px; height: 12px; background-color: #b5c7de; text-align: center">
                        <asp:ImageButton ID="imbPesquisar" runat="server" ImageUrl="~/App_Themes/CCL/Imagens/Bt_Pesquisar_.gif"
                            TabIndex="4" />&nbsp;
                        <asp:ImageButton ID="imbProcessar" runat="server" ImageUrl="~/App_Themes/CCL/Imagens/Bt_Processar.jpg"
                            TabIndex="5" />
                        &nbsp;&nbsp;<asp:ImageButton ID="imbNovoEmail" runat="server" ImageUrl="~/App_Themes/CCL/Imagens/Bt_NovoEmail.jpg"
                            TabIndex="6" />
                        &nbsp;<asp:ImageButton ID="imbSair" runat="server" Height="36px" ImageUrl="~/App_Themes/CCL/Imagens/Bt_Sair.gif"
                            PostBackUrl="~/Pagina_Principal.aspx" TabIndex="7" />
                    </td>
                </tr>
            </table>
            <asp:UpdatePanel ID="UpdatePanel2" runat="server" ChildrenAsTriggers="False" UpdateMode="Conditional">
                <ContentTemplate>
                    <asp:Panel Style="display: none; z-index: 102; border-top-style: outset; border-right-style: outset;
                        border-left-style: outset; background-color: #dae5f9; border-bottom-style: outset"
                        ID="pnlGridVisualizar" runat="server" Width="842px" Height="221px" ScrollBars="Auto">
                        <div style="width: 818px; height: 2px; text-align: right">
                            <asp:ImageButton ID="imb_Fechar" runat="server" ImageUrl="~/App_Themes/CCL/Imagens/fechar.jpg">
                            </asp:ImageButton></div>
                        <asp:GridView ID="gridVisTit" runat="server" Width="630px" Height="125px" BorderColor="#999999"
                            ForeColor="#333333" BackColor="White" BorderStyle="None" BorderWidth="1px" GridLines="Vertical"
                            CellPadding="3" AutoGenerateColumns="False" PageSize="5">
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
                                        <asp:TextBox runat="server" Text='<%# Bind("VALOR_T") %>' ID="TextBox11"></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <div style="left: 0px; overflow: hidden; width: 68px; top: 0px; height: 16px">
                                            <asp:Label ID="Label11" runat="server" ToolTip='<%# Bind("VALOR_T") %>' Text='<%# Bind("VALOR_T") %>'></asp:Label></div>
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
            <asp:Panel ID="pnlEmail" runat="server" Height="50px" Style="display: none; border-top-style: outset;
                border-right-style: outset; border-left-style: outset; background-color: #dae5f9;
                border-bottom-style: outset" Width="125px">
                &nbsp;<table>
                    <tr>
                        <td style="width: 100px">
                            <asp:Label ID="lblAssunto" runat="server" Text="De:"></asp:Label>
                        </td>
                        <td style="width: 100px">
                            <asp:TextBox ID="txtDe" runat="server" Width="750px" Style="border-top-style: groove;
                                border-right-style: groove; border-left-style: groove; border-bottom-style: groove"
                                Enabled="False">ctapagar@ccl.com.br</asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 100px">
                            <asp:Label ID="Label14" runat="server" Text="Para:"></asp:Label>
                        </td>
                        <td style="width: 100px">
                            <asp:TextBox ID="txtPara" runat="server" Style="border-top-style: groove; border-right-style: groove;
                                border-left-style: groove; border-bottom-style: groove" TextMode="MultiLine"
                                Width="750px" Enabled="False"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 100px">
                            <asp:Label ID="Label13" runat="server" Text="Assunto:"></asp:Label>
                        </td>
                        <td style="width: 100px">
                            <asp:TextBox ID="txtAssunto" runat="server" Width="750px">Pagamentos Efetuados pela CCL</asp:TextBox>
                        </td>
                    </tr>
                </table>
                &nbsp;
                <FTB:FreeTextBox ID="FreeTextBox1" runat="server" AllowHtmlMode="False" AssemblyResourceHandlerPath=""
                    AutoConfigure="" AutoGenerateToolbarsFromString="True" AutoHideToolbar="True"
                    AutoParseStyles="True" BackColor="158, 190, 245" BaseUrl="" BreakMode="Paragraph"
                    ButtonDownImage="False" ButtonFileExtention="gif" ButtonFolder="Images" ButtonHeight="20"
                    ButtonImagesLocation="InternalResource" ButtonOverImage="False" ButtonPath=""
                    ButtonSet="Office2003" ButtonWidth="21" ClientSideTextChanged="" ConvertHtmlSymbolsToHtmlCodes="False"
                    DesignModeBodyTagCssClass="" DesignModeCss="" DisableIEBackButton="False" DownLevelCols="50"
                    DownLevelMessage="" DownLevelMode="TextArea" DownLevelRows="10" EditorBorderColorDark="Gray"
                    EditorBorderColorLight="Gray" EnableHtmlMode="True" EnableSsl="False" EnableToolbars="True"
                    Focus="False" FormatHtmlTagsToXhtml="True" GutterBackColor="129, 169, 226" GutterBorderColorDark="Gray"
                    GutterBorderColorLight="White" Height="300px" HelperFilesParameters="" HelperFilesPath=""
                    HtmlModeCss="" HtmlModeDefaultsToMonoSpaceFont="True" ImageGalleryPath="/imagens/"
                    ImageGalleryUrl="ftb.imagegallery.aspx?rif={0}&cif={0}" InstallationErrorMessage="InlineMessage"
                    JavaScriptLocation="InternalResource" Language="en-US" PasteMode="Default" ReadOnly="False"
                    RemoveScriptNameFromBookmarks="True" RemoveServerNameFromUrls="False" RenderMode="NotSet"
                    ScriptMode="External" SslUrl="/." StartMode="DesignMode" StripAllScripting="False"
                    SupportFolder="/aspnet_client/FreeTextBox/" TabIndex="-1" TabMode="InsertSpaces"
                    Text="" TextDirection="LeftToRight" ToolbarBackColor="Transparent" ToolbarBackgroundImage="True"
                    ToolbarImagesLocation="InternalResource" ToolbarLayout="ParagraphMenu,FontFacesMenu,FontSizesMenu,FontForeColorsMenu|Bold,Italic,Underline,Strikethrough;Superscript,Subscript,RemoveFormat|JustifyLeft,JustifyRight,JustifyCenter,JustifyFull;BulletedList,NumberedList,Indent,Outdent;CreateLink,Unlink,InsertImage,InsertRule|Cut,Copy,Paste;Undo,Redo,Print"
                    ToolbarStyleConfiguration="Office2003" UpdateToolbar="True" UseToolbarBackGroundImage="True"
                    Width="800px">
                </FTB:FreeTextBox>
                <asp:LinkButton ID="lbAnexar" runat="server" CausesValidation="False" Width="312px"
                    Style="text-align: left">Deseja anexar outro arquivo?</asp:LinkButton>
                <br />
                <asp:Panel ID="pnlAnexar" runat="server" Height="84px" Style="border-top-style: outset;
                    border-right-style: outset; border-left-style: outset; background-color: #dae5f9;
                    border-bottom-style: outset" Width="325px">
                    <br />
                    <table>
                        <tr>
                            <td colspan="2" style="width: 410px; text-align: left">
                                <asp:FileUpload ID="FileUpload1" runat="server" Width="309px" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2" style="width: 410px; text-align: left">
                                <asp:Button ID="cmdAnexarArquivo" runat="server" Text="Anexar arquivo" UseSubmitBehavior="False"
                                    Width="155px" />
                                <asp:Button ID="cmdExcluir" runat="server" Text="Excluir arquivo" Width="152px" />
                                &nbsp;
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2" style="width: 410px">
                                <asp:ListBox ID="ListBoxAnexos" runat="server" Width="311px"></asp:ListBox>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2" style="width: 410px; text-align: right">
                                <asp:Button ID="cmdSairAnexo" runat="server" Text="Sair" Width="155px" />
                                &nbsp;
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
                <asp:Label ID="lblMensagem" runat="server" Width="354px" Style="text-align: left"
                    Font-Strikeout="False"></asp:Label>
                <table style="text-align: left">
                    <tr>
                        <td style="width: 100px">
                            <asp:ImageButton ID="imbEnviarEmail" runat="server" ImageUrl="~/App_Themes/CCL/Imagens/Bt_EnviarEmail.jpg" />
                        </td>
                        <td style="width: 153px">
                            <asp:ImageButton ID="imbSairFtb" runat="server" ImageUrl="~/App_Themes/CCL/Imagens/Bt_Sair.gif" />
                        </td>
                    </tr>
                </table>
            </asp:Panel>
        </div>
    </div>

    <script language="javascript">
 function SelecionaTodosChecks(spanChk){
   var oItem = spanChk.children;
   var theBox= (spanChk.type=="checkbox") ?
        spanChk : spanChk.children.item[0];
   xState=theBox.checked;
   elm=theBox.form.elements;
   for(i=0;i<elm.length;i++)
     if(elm[i].type=="checkbox" &&
              elm[i].id!=theBox.id)
     {
       if(elm[i].checked!=xState)
         elm[i].click();
     }
 }
    </script>

</asp:Content>
