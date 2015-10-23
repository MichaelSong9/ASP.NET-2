<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Manutencao.aspx.vb" Inherits="Manutencao" title="Untitled Page" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="DIV_PAGES">
        <table>
            <tr>
                <td style="width: 118px">
                    <asp:Label ID="lblConta" runat="server" Text="Centro de Custos:"></asp:Label></td>
                <td colspan="2">
                    <asp:TextBox ID="txtCentroCusto" runat="server" CssClass="TEXT_PAGES" Width="110px" MaxLength="11"></asp:TextBox></td>
            </tr>
        </table>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <cc1:FilteredTextBoxExtender ID="ftbCentroCustos" runat="server" FilterType="Custom, Numbers"
            TargetControlID="txtCentroCusto">
        </cc1:FilteredTextBoxExtender>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True"
                    AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="None"
                    BorderWidth="1px" CellPadding="3" DataSourceID="SqlDataSource1"
                    GridLines="Vertical"
                    Width="959px" DataKeyNames="CENTRO_DE">
                    <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <Columns>
                        <asp:TemplateField HeaderText="E" ShowHeader="False">
                            <ItemTemplate>
                                &nbsp;<asp:ImageButton ID="ImageButton1" runat="server" CausesValidation="False"
                                    CommandName="Delete" ImageUrl="~/imagens/Botao_Deletar.gif" OnClientClick="javascript:return ConfirmaExclusao();"
                                    Text="Excluir Registro" ToolTip="Excluir Registro" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:CommandField ButtonType="Image" HeaderText="M" SelectImageUrl="~/imagens/Botao_Marcar.gif"
                            SelectText="Marcar Linha" ShowSelectButton="True" />
                        <asp:ButtonField ButtonType="Image" HeaderText="D" ImageUrl="~/imagens/Botao_Desmarcar.gif"
                            Text="Desmarcar Linha" />
                        <asp:BoundField DataField="CENTRO_DE" HeaderText="Centro De" ReadOnly="True" SortExpression="CENTRO_DE">
                            <FooterStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                        </asp:BoundField>
                        <asp:BoundField DataField="NOMECENTRO_DE" HeaderText="Nome" SortExpression="NOMECENTRO_DE">
                            <FooterStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                        </asp:BoundField>
                        <asp:BoundField DataField="CENTRO_PARA" HeaderText="Centro Para" SortExpression="CENTRO_PARA">
                            <FooterStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                        </asp:BoundField>
                    </Columns>
                    <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                    <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                    <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                    <AlternatingRowStyle BackColor="Gainsboro" />
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString1 %>"
                    ProviderName="<%$ ConnectionStrings:ConnectionString1.ProviderName %>" SelectCommand='SELECT "CENTRO_DE", "NOMECENTRO_DE", "CENTRO_PARA" FROM "DEPARA_CENTROCUSTO"' ConflictDetection="CompareAllValues" DeleteCommand='DELETE FROM "DEPARA_CENTROCUSTO" WHERE "CENTRO_DE" = :original_CENTRO_DE AND "NOMECENTRO_DE" = :original_NOMECENTRO_DE AND "CENTRO_PARA" = :original_CENTRO_PARA' InsertCommand='INSERT INTO "DEPARA_CENTROCUSTO" ("CENTRO_DE", "NOMECENTRO_DE", "CENTRO_PARA") VALUES (:CENTRO_DE, :NOMECENTRO_DE, :CENTRO_PARA)' OldValuesParameterFormatString="original_{0}" UpdateCommand='UPDATE "DEPARA_CENTROCUSTO" SET "NOMECENTRO_DE" = :NOMECENTRO_DE, "CENTRO_PARA" = :CENTRO_PARA WHERE "CENTRO_DE" = :original_CENTRO_DE AND "NOMECENTRO_DE" = :original_NOMECENTRO_DE AND "CENTRO_PARA" = :original_CENTRO_PARA'>
                    <DeleteParameters>
                        <asp:Parameter Name="original_CENTRO_DE" Type="String" />
                        <asp:Parameter Name="original_NOMECENTRO_DE" Type="String" />
                        <asp:Parameter Name="original_CENTRO_PARA" Type="String" />
                    </DeleteParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="NOMECENTRO_DE" Type="String" />
                        <asp:Parameter Name="CENTRO_PARA" Type="String" />
                        <asp:Parameter Name="original_CENTRO_DE" Type="String" />
                        <asp:Parameter Name="original_NOMECENTRO_DE" Type="String" />
                        <asp:Parameter Name="original_CENTRO_PARA" Type="String" />
                    </UpdateParameters>
                    <InsertParameters>
                        <asp:Parameter Name="CENTRO_DE" Type="String" />
                        <asp:Parameter Name="NOMECENTRO_DE" Type="String" />
                        <asp:Parameter Name="CENTRO_PARA" Type="String" />
                    </InsertParameters>
                </asp:SqlDataSource>
                &nbsp;
                <div style="z-index: 103; left: 306px; width: 324px; position: absolute; top: 336px;
                    height: 100px">
                    <asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="UpdatePanel1" DisplayAfter="300">
                        <ProgressTemplate>
                            <asp:Panel ID="pnlProcessando" runat="server" BackColor="#B5C7DE" BorderColor="Teal"
                                BorderStyle="Solid" BorderWidth="1px" Height="1px" Width="345px">
                                <img src="imagens/loading.gif" style="width: 15px" />
                                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; <font color="#284e98" face="Verdana"
                                    size="2">Processando sua solicitação...</font>
                            </asp:Panel>
                        </ProgressTemplate>
                    </asp:UpdateProgress>
                </div>
                &nbsp;
                <table id="tblBotoes" style="width: 714px">
                    <tr>
                        <td style="width: 100px">
                        </td>
                        <td style="width: 100px">
                        </td>
                        <td colspan="5" style="background-color: #b5c7de">
                            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;<asp:ImageButton
                                ID="imbPesquisar" runat="server" ImageUrl="~/imagens/Botao_Pesquisar.gif" OnClick="imbPesquisar_Click" />&nbsp;<asp:ImageButton
                                    ID="imgSair" runat="server" ImageUrl="~/imagens/Botao_Sair.gif" PostBackUrl="~/Pagina_Principal.aspx" /></td>
                    </tr>
                </table>
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="imbPesquisar" EventName="Click" />
                <asp:AsyncPostBackTrigger ControlID="imbPesquisar" EventName="Command" />
            </Triggers>
        </asp:UpdatePanel>
        &nbsp;&nbsp;
    </div>
    <script language= "javascript" type = "text/javascript">
    function ConfirmaExclusao(){
        return confirm('Deseja realmente excluir este registro?');
    }
</script>
</asp:Content>

