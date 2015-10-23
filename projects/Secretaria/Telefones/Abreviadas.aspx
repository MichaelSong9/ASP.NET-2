<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Abreviadas.aspx.cs" Inherits="Cadastrar_Abreviadas" Title="Untitled Page" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajax" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="DIV_PAGES">
        <div>
            <asp:Panel ID="pnlPesquisar" runat="server" Height="20%" Width="59%">
                <table>
                    <tr>
                        <td style="width: 82px; background-color: #ffffff">
                            <asp:Label ID="Label5" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy"
                                Text="Nome:"></asp:Label></td>
                        <td style="width: 165px; background-color: #ffffff">
                            <asp:TextBox ID="txtPesqNome" runat="server" TabIndex="1" Width="215px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td style="width: 82px; background-color: #f7f6f3">
                            <asp:Label ID="Label6" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy"
                                Text="Telefone:"></asp:Label></td>
                        <td style="width: 165px; background-color: #f7f6f3">
                            <asp:TextBox ID="txtPesqTelefone" runat="server" TabIndex="2" Width="215px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td style="width: 82px; background-color: #ffffff">
                            <asp:Label ID="Label7" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy"
                                Text="Código:"></asp:Label></td>
                        <td style="width: 165px; background-color: #ffffff">
                            <asp:TextBox ID="txtPesqCodigo" runat="server" TabIndex="3" Width="215px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td style="width: 82px; background-color: #f7f6f3">
                            <asp:Button ID="btnNovo" runat="server" BackColor="White" BorderColor="#507CD1" BorderStyle="Solid"
                                BorderWidth="1px" CausesValidation="False" CommandName="Novo" Font-Names="Verdana"
                                Font-Size="0.8em" ForeColor="#284E98" OnClick="btnNovo_Click" TabIndex="5" Text="Novo"
                                Width="80px" /></td>
                        <td style="width: 165px; background-color: #f7f6f3">
                            <asp:Button ID="btnPesquisar" runat="server" BackColor="White" BorderColor="#507CD1"
                                BorderStyle="Solid" BorderWidth="1px" CausesValidation="False" CommandName="Pesquisar"
                                Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284E98" OnClick="btnPesquisar_Click"
                                TabIndex="4" Text="Pesquisar" Width="222px" /></td>
                    </tr>
                </table>
            </asp:Panel>
            <div style="z-index: 101; left: 582px; width: 184px; position: absolute; top: 211px;
                height: 27px">
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
            </div>
            &nbsp;<br />
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
            <asp:Panel ID="pnlVisualizar" runat="server" Height="20%" Visible="False" Width="59%">
                <table>
                    <tr>
                        <td style="width: 349px; background-color: #ffffff">
                            <asp:Label ID="lblN" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy"
                                Text="Nome:"></asp:Label></td>
                        <td style="width: 484px; background-color: #ffffff">
                            <asp:Label ID="lblNome" runat="server" BackColor="Transparent" Font-Bold="True" Font-Italic="True"
                                ForeColor="Black"></asp:Label>
                            <asp:TextBox ID="txtNome" runat="server" Visible="False"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td style="width: 349px; background-color: #f7f6f3">
                            <asp:Label ID="lblC" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy"
                                Text="Telefone:"></asp:Label></td>
                        <td style="width: 484px; background-color: #f7f6f3">
                            <asp:Label ID="lblTelefone" runat="server" BackColor="Transparent" Font-Bold="True"
                                Font-Italic="True" ForeColor="Black"></asp:Label>
                            <asp:TextBox ID="txtTelefone" runat="server" Visible="False"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td style="width: 349px; background-color: #ffffff">
                            <asp:Label ID="lblR" runat="server" BackColor="Transparent" Font-Bold="True" ForeColor="Navy"
                                Text="Código:"></asp:Label></td>
                        <td style="width: 484px; background-color: #ffffff">
                            <asp:Label ID="lblCodigo" runat="server" BackColor="Transparent" Font-Bold="True"
                                Font-Italic="True" ForeColor="Black"></asp:Label>
                            <asp:TextBox ID="txtCodigo" runat="server" Visible="False"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td style="width: 349px; background-color: #f7f6f3">
                            <asp:LinkButton ID="lnkEditar" runat="server" OnClick="lnkEditar_Click">Editar</asp:LinkButton>
                            <asp:LinkButton ID="lnkSalvar" runat="server" OnClick="lnkSalvar_Click" Visible="False">Salvar</asp:LinkButton>
                            <asp:LinkButton ID="lnkSalvarNovoUsuario" runat="server" OnClick="lnkSalvarNovoUsuario_Click"
                                Visible="False">Inserir Novo Usuário</asp:LinkButton></td>
                        <td style="width: 484px; background-color: #f7f6f3">
                            <asp:LinkButton ID="lnkCancelar" runat="server" OnClick="lnkCancelar_Click" Visible="False">Cancelar</asp:LinkButton></td>
                    </tr>
                </table>
            </asp:Panel>
                    <br />
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                CellPadding="4" DataKeyNames="NOME,TELEFONE,CODIGO" ForeColor="#333333" GridLines="None"
                OnPageIndexChanging="GridView1_PageIndexChanging" OnRowCommand="GridView1_RowCommand"
                OnRowDataBound="GridView1_RowDataBound" OnRowDeleting="GridView1_RowDeleting"
                OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <Columns>
                    <asp:TemplateField ShowHeader="False">
                        <ItemTemplate>
                            <asp:LinkButton ID="lnkSelecionar" runat="server" CausesValidation="False" CommandName="Select"
                                OnClick="lnkSelecionar_Click" Text="Selecionar"></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Nome" SortExpression="NOME">
                        <EditItemTemplate>
                            <asp:Label ID="Label2" runat="server" Text='<%# Eval("NOME") %>'></asp:Label>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblGridNome" runat="server" Text='<%# Bind("NOME") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Telefone" SortExpression="TELEFONE">
                        <EditItemTemplate>
                            <asp:Label ID="Label3" runat="server" Text='<%# Eval("TELEFONE") %>'></asp:Label>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblGridTelefone" runat="server" Text='<%# Bind("TELEFONE") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="C&#243;digo" SortExpression="CODIGO">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("CODIGO") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblGridCodigo" runat="server" Text='<%# Bind("CODIGO") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField ShowHeader="False">
                        <ItemTemplate>
                            <asp:LinkButton ID="lnkExcluir" runat="server" CausesValidation="False" CommandName="Delete"
                                Text="Excluir"></asp:LinkButton>
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
                </ContentTemplate>
            </asp:UpdatePanel>
            &nbsp;<br />
        </div>
    </div>
</asp:Content>

