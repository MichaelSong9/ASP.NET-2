<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Correio.aspx.cs" Inherits="Correspondencias_Correio" Title="Untitled Page" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajax" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div class="DIV_PAGES">
        &nbsp;<asp:Panel ID="pnlPesquisar" runat="server" Height="21%" Width="37%">
            <table>
                <tr>
                    <td style="width: 82px; background-color: #f7f6f3">
                        <asp:Label ID="Label4" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy">Data:</asp:Label></td>
                    <td style="width: 165px; background-color: #f7f6f3">
                        <asp:TextBox ID="txtData" runat="server" Enabled="False" TabIndex="1" Width="215px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 82px; background-color: #ffffff">
                        <asp:Label ID="Label5" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy"
                            Text="Remetente:"></asp:Label></td>
                    <td style="width: 165px; background-color: #ffffff">
                        <asp:TextBox ID="txtRemetente" runat="server" TabIndex="1" Width="215px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 82px; background-color: #f7f6f3">
                        <asp:Label ID="Label7" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy"
                            Text="Tipo:"></asp:Label></td>
                    <td style="width: 165px; background-color: #f7f6f3">
                        <asp:TextBox ID="txtTipo" runat="server" TabIndex="3" Width="215px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 82px; background-color: #ffffff">
                        <asp:Label ID="Label1" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy"
                            Text="Destinatário:"></asp:Label></td>
                    <td style="width: 165px; background-color: #ffffff">
                        <asp:TextBox ID="txtDestinatario" runat="server" TabIndex="3" Width="215px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 82px; background-color: #f7f6f3">
                        <asp:Label ID="Label2" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy"
                            Text="Departamento:"></asp:Label></td>
                    <td style="width: 165px; background-color: #f7f6f3">
                        <asp:DropDownList ID="ddlDepto" runat="server" Width="222px">
                            <asp:ListItem></asp:ListItem>
                            <asp:ListItem>ADC</asp:ListItem>
                            <asp:ListItem Value="ADI">Administra&#231;&#227;o Industrial</asp:ListItem>
                            <asp:ListItem Value="AUD">Auditoria Interna</asp:ListItem>
                            <asp:ListItem Value="BB">Revista Balde Branco</asp:ListItem>
                            <asp:ListItem Value="DCF">Cont&#225;bil e Financeiro</asp:ListItem>
                            <asp:ListItem Value="DCO">Comercial</asp:ListItem>
                            <asp:ListItem Value="DEM">Engenharia e Manuten&#231;&#227;o</asp:ListItem>
                            <asp:ListItem Value="DGE">Diretoria</asp:ListItem>
                            <asp:ListItem Value="DGQ">Garantia da Qualidade</asp:ListItem>
                            <asp:ListItem Value="DIF">Inform&#225;tica</asp:ListItem>
                            <asp:ListItem Value="DJU">Jur&#237;dico</asp:ListItem>
                            <asp:ListItem Value="DPR">Desenvolvimento de Produtos</asp:ListItem>
                            <asp:ListItem Value="DRH">Recursos Humanos</asp:ListItem>
                            <asp:ListItem Value="DVE">Vendas Empreiteiros</asp:ListItem>
                            <asp:ListItem Value="FAT">Faturamento</asp:ListItem>
                            <asp:ListItem Value="DVE">Planej. e Adm. Vendas</asp:ListItem>
                            <asp:ListItem Value="PRE">Presid&#234;ncia</asp:ListItem>
                            <asp:ListItem Value="REP">Representantes</asp:ListItem>
                            <asp:ListItem Value="SAC">Servi&#231;o de Atend. Consumidor</asp:ListItem>
                            <asp:ListItem Value="SAG">Arquivo Geral</asp:ListItem>
                            <asp:ListItem Value="SAI">Interior e Associadas</asp:ListItem>
                            <asp:ListItem Value="SAL">Almoxarifado</asp:ListItem>
                            <asp:ListItem Value="SFS">Food Service</asp:ListItem>
                            <asp:ListItem Value="SGC">Grandes Contas</asp:ListItem>
                            <asp:ListItem Value="SMK">Marketing</asp:ListItem>
                            <asp:ListItem Value="SPV">Pr&#233;-Vendas</asp:ListItem>
                            <asp:ListItem Value="STR">Transportes</asp:ListItem>
                            <asp:ListItem Value="STV">Televendas</asp:ListItem>
                            <asp:ListItem Value="SUP">Suprimentos</asp:ListItem>
                            <asp:ListItem Value="SVD">Vendas Diretas</asp:ListItem>
                            <asp:ListItem Value="TUT">Telefones &#218;teis</asp:ListItem>
                            <asp:ListItem Value="UC">Unidade Central</asp:ListItem>
                        </asp:DropDownList></td>
                </tr>
                <tr>
                    <td style="width: 82px; background-color: #ffffff">
                        <asp:Label ID="Label3" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy"
                            Text="Nome:"></asp:Label></td>
                    <td style="width: 165px; background-color: #ffffff">
                        <asp:TextBox ID="txtNome" runat="server" TabIndex="3" Width="215px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 82px; background-color: #f7f6f3">
                        <asp:Label ID="Label6" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy"
                            Text="Registro:"></asp:Label></td>
                    <td style="width: 165px; background-color: #f7f6f3">
                        <asp:TextBox ID="txRegistro" runat="server" TabIndex="3" Width="215px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 82px; background-color: #f7f6f3">
                        <asp:Button ID="btnSalvar" runat="server" BackColor="White" BorderColor="#507CD1"
                            BorderStyle="Solid" BorderWidth="1px" CausesValidation="False" CommandName="Novo"
                            Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284E98" TabIndex="5" Text="Salvar"
                            Width="80px" /></td>
                    <td style="width: 165px; background-color: #f7f6f3">
                        <asp:Button ID="btnPesquisar" runat="server" BackColor="White" BorderColor="#507CD1"
                            BorderStyle="Solid" BorderWidth="1px" CausesValidation="False" CommandName="Pesquisar"
                            Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284E98" TabIndex="4" Text="Pesquisar"
                            Width="222px" /></td>
                </tr>
            </table>
        </asp:Panel>
        <br />
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False"
            CellPadding="4" DataKeyNames="DATA,REMETENTE,TIPO,DESTINATARIO,DEPTO,NOME,REGISTRO" ForeColor="#333333" GridLines="None" PageSize="8">
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <Columns>
                <asp:TemplateField ShowHeader="False">
                    <ItemTemplate>
                        <asp:LinkButton ID="lnkSelecionar" runat="server" CausesValidation="False" CommandName="Select"
                            Text="Selecionar"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Data" SortExpression="DATA">
                    <EditItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("DEPTO") %>'></asp:Label>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblGridData" runat="server" Text='<%# Bind("DATA") %>' ToolTip='<%# Bind("DATA") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Remetente" SortExpression="REMETENTE">
                    <EditItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("NOME") %>'></asp:Label>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblGridRemetente" runat="server" Text='<%# Bind("REMETENTE") %>' ToolTip='<%# Bind("REMETENTE") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Tipo" SortExpression="TIPO">
                    <EditItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# Eval("RAMAL") %>'></asp:Label>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblGridTipo" runat="server" Text='<%# Bind("TIPO") %>' ToolTip='<%# Bind("TIPO") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Destinat&#225;rio" SortExpression="DESTINATARIO">
                    <ItemTemplate>
                        <asp:Label ID="lblGridDestinatario" runat="server" Text='<%# Bind("DESTINATARIO") %>' ToolTip='<%# Bind("DESTINATARIO") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Depto." SortExpression="DEPARTAMENTO">
                    <ItemTemplate>
                        <asp:Label ID="lblGridDepto" runat="server" Text='<%# Bind("DEPTO") %>' ToolTip='<%# Bind("DEPTO") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Nome" SortExpression="NOME">
                    <ItemTemplate>
                        <asp:Label ID="lblGridNome" runat="server" Text='<%# Bind("NOME") %>' ToolTip='<%# Bind("NOME") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Registro" SortExpression="REGISTRO">
                    <ItemTemplate>
                        <asp:Label ID="lblGridRegistro" runat="server" Text='<%# Bind("REGISTRO") %>' ToolTip='<%# Bind("REGISTRO") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField ShowHeader="False">
                    <ItemTemplate>
                        <asp:LinkButton ID="lnkExcluir" runat="server" CommandArgument='<%# Eval("RAMAL") %>'
                            CommandName="Delete">Excluir</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <EditRowStyle BackColor="#999999" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        </asp:GridView>
        &nbsp;
        <div style="z-index: 101; left: 372px; width: 165px; position: absolute; top: 223px;
            height: 234px">
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
        </div>
    </div>
</asp:Content>

