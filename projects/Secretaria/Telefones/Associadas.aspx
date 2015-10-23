<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Associadas.aspx.cs" Inherits="Associadas" Title="Untitled Page" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajax" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="DIV_PAGES">
    <br />
    <table style="width: 220px">
        <tr>
            <td style="width: 44px">
                <asp:Label ID="Label1" runat="server" Text="Nome:"></asp:Label></td>
            <td style="width: 100px">
                <asp:TextBox ID="txtNome" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 44px">
                <asp:Label ID="Label3" runat="server" Text="Telefone:"></asp:Label></td>
            <td style="width: 100px">
                <asp:TextBox ID="txtTelefone" runat="server" MaxLength="10"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="2" style="text-align: right">
                <asp:Button ID="btnPesquisar" runat="server" OnClick="btnPesquisar_Click" Text="Pesquisar"
                    Width="159px" BackColor="White" BorderColor="#507CD1" BorderStyle="Solid" BorderWidth="1px" CausesValidation="False" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284E98" /></td>
        </tr>
    </table>
        <div style="z-index: 101; left: 254px; width: 202px; position: absolute; top: 223px;
            height: 41px">
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
        </div>
        &nbsp;<asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
    <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" CellPadding="4"
        DataKeyNames="SEQUENCIA" DataSourceID="AssociadasSqlDataSource" Font-Size="Small"
        ForeColor="#333333" GridLines="None" Height="50px" Width="700px">
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <CommandRowStyle BackColor="#E2DED6" Font-Bold="True" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <FieldHeaderStyle BackColor="#E9ECF1" Font-Bold="True" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <Fields>
            <asp:BoundField DataField="SEQUENCIA" HeaderText="Sequ&#234;ncia" InsertVisible="False"
                ReadOnly="True" SortExpression="SEQUENCIA" />
            <asp:BoundField DataField="NOME" HeaderText="Nome" SortExpression="NOME" />
            <asp:BoundField DataField="LOCAL" HeaderText="Local" SortExpression="LOCAL" />
            <asp:BoundField DataField="DESTINO" HeaderText="Destino" SortExpression="DESTINO" />
            <asp:BoundField DataField="TELEFONE" HeaderText="Telefone" SortExpression="TELEFONE" />
            <asp:BoundField DataField="CARGO" HeaderText="Cargo" SortExpression="CARGO" Visible="False" />
            <asp:BoundField DataField="RAMAL" HeaderText="Ramal" SortExpression="RAMAL" Visible="False" />
            <asp:BoundField DataField="CODIGO" HeaderText="C&#243;digo" SortExpression="CODIGO" />
            <asp:CommandField ShowEditButton="True" ShowInsertButton="True" CancelText="Cancelar" DeleteText="Deletar" EditText="Editar" InsertText="Inserir" NewText="Novo" UpdateText="Atualizar" />
        </Fields>
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <EditRowStyle BackColor="#999999" />
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
    </asp:DetailsView>
    <asp:SqlDataSource ID="AssociadasSqlDataSource" runat="server" ConflictDetection="CompareAllValues"
        ConnectionString="<%$ ConnectionStrings:intranetConnectionString %>" DeleteCommand="DELETE FROM [COOP] WHERE [SEQUENCIA] = @original_SEQUENCIA AND (([DESTINO] = @original_DESTINO) OR ([DESTINO] IS NULL AND @original_DESTINO IS NULL)) AND (([LOCAL] = @original_LOCAL) OR ([LOCAL] IS NULL AND @original_LOCAL IS NULL)) AND (([TELEFONE] = @original_TELEFONE) OR ([TELEFONE] IS NULL AND @original_TELEFONE IS NULL)) AND (([NOME] = @original_NOME) OR ([NOME] IS NULL AND @original_NOME IS NULL)) AND (([CARGO] = @original_CARGO) OR ([CARGO] IS NULL AND @original_CARGO IS NULL)) AND (([RAMAL] = @original_RAMAL) OR ([RAMAL] IS NULL AND @original_RAMAL IS NULL)) AND (([CODIGO] = @original_CODIGO) OR ([CODIGO] IS NULL AND @original_CODIGO IS NULL))"
        InsertCommand="INSERT INTO [COOP] ([DESTINO], [LOCAL], [TELEFONE], [NOME], [CARGO], [RAMAL], [CODIGO]) VALUES (@DESTINO, @LOCAL, @TELEFONE, @NOME, @CARGO, @RAMAL, @CODIGO)"
        OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT [SEQUENCIA], [DESTINO], [LOCAL], [TELEFONE], [NOME], [CARGO], [RAMAL], [CODIGO] FROM [COOP] WHERE ([SEQUENCIA] = @SEQUENCIA)"
        UpdateCommand="UPDATE [COOP] SET [DESTINO] = @DESTINO, [LOCAL] = @LOCAL, [TELEFONE] = @TELEFONE, [NOME] = @NOME, [CARGO] = @CARGO, [RAMAL] = @RAMAL, [CODIGO] = @CODIGO WHERE [SEQUENCIA] = @original_SEQUENCIA AND (([DESTINO] = @original_DESTINO) OR ([DESTINO] IS NULL AND @original_DESTINO IS NULL)) AND (([LOCAL] = @original_LOCAL) OR ([LOCAL] IS NULL AND @original_LOCAL IS NULL)) AND (([TELEFONE] = @original_TELEFONE) OR ([TELEFONE] IS NULL AND @original_TELEFONE IS NULL)) AND (([NOME] = @original_NOME) OR ([NOME] IS NULL AND @original_NOME IS NULL)) AND (([CARGO] = @original_CARGO) OR ([CARGO] IS NULL AND @original_CARGO IS NULL)) AND (([RAMAL] = @original_RAMAL) OR ([RAMAL] IS NULL AND @original_RAMAL IS NULL)) AND (([CODIGO] = @original_CODIGO) OR ([CODIGO] IS NULL AND @original_CODIGO IS NULL))">
        <SelectParameters>
            <asp:ControlParameter ControlID="GridView1" Name="SEQUENCIA" PropertyName="SelectedValue"
                Type="Int32" />
        </SelectParameters>
        <DeleteParameters>
            <asp:Parameter Name="original_SEQUENCIA" Type="Int32" />
            <asp:Parameter Name="original_DESTINO" Type="String" />
            <asp:Parameter Name="original_LOCAL" Type="String" />
            <asp:Parameter Name="original_TELEFONE" Type="String" />
            <asp:Parameter Name="original_NOME" Type="String" />
            <asp:Parameter Name="original_CARGO" Type="String" />
            <asp:Parameter Name="original_RAMAL" Type="String" />
            <asp:Parameter Name="original_CODIGO" Type="String" />
        </DeleteParameters>
        <UpdateParameters>
            <asp:Parameter Name="DESTINO" Type="String" />
            <asp:Parameter Name="LOCAL" Type="String" />
            <asp:Parameter Name="TELEFONE" Type="String" />
            <asp:Parameter Name="NOME" Type="String" />
            <asp:Parameter Name="CARGO" Type="String" />
            <asp:Parameter Name="RAMAL" Type="String" />
            <asp:Parameter Name="CODIGO" Type="String" />
            <asp:Parameter Name="original_SEQUENCIA" Type="Int32" />
            <asp:Parameter Name="original_DESTINO" Type="String" />
            <asp:Parameter Name="original_LOCAL" Type="String" />
            <asp:Parameter Name="original_TELEFONE" Type="String" />
            <asp:Parameter Name="original_NOME" Type="String" />
            <asp:Parameter Name="original_CARGO" Type="String" />
            <asp:Parameter Name="original_RAMAL" Type="String" />
            <asp:Parameter Name="original_CODIGO" Type="String" />
        </UpdateParameters>
        <InsertParameters>
            <asp:Parameter Name="DESTINO" Type="String" />
            <asp:Parameter Name="LOCAL" Type="String" />
            <asp:Parameter Name="TELEFONE" Type="String" />
            <asp:Parameter Name="NOME" Type="String" />
            <asp:Parameter Name="CARGO" Type="String" />
            <asp:Parameter Name="RAMAL" Type="String" />
            <asp:Parameter Name="CODIGO" Type="String" />
        </InsertParameters>
    </asp:SqlDataSource>
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False"
        CellPadding="4" DataKeyNames="SEQUENCIA" Font-Size="Small" ForeColor="#333333"
        GridLines="None" OnPageIndexChanged="GridView1_PageIndexChanged" OnPageIndexChanging="GridView1_PageIndexChanging"
        OnRowCommand="GridView1_RowCommand" OnRowDataBound="GridView1_RowDataBound" OnRowDeleting="GridView1_RowDeleting"
        Style="left: 0px; top: 0px" PageSize="7" Width="700px">
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <Columns>
            <asp:CommandField ShowSelectButton="True" SelectText="Selecionar" />
            <asp:TemplateField HeaderText="Nome" SortExpression="NOME">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("NOME") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <div style="left: 0px; overflow: hidden; width: 227px; top: 0px; height: 16px; text-align: left">
                        <asp:Label ID="lblNome" runat="server" Text='<%# Bind("NOME") %>' ToolTip='<%# Bind("NOME") %>'></asp:Label></div>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Telefone" SortExpression="TELEFONE">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("RAMAL") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <div style="left: 0px; overflow: hidden; width: 142px; top: 0px; height: 16px; text-align: left">
                        <asp:Label ID="lblTelefone" runat="server" Text='<%# Bind("TELEFONE") %>' ToolTip='<%# Bind("TELEFONE") %>'></asp:Label></div>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="C&#243;digo" SortExpression="CODIGO">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("CARGO") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <div style="left: 0px; overflow: hidden; width: 62px; top: 0px; height: 16px; text-align: left;">
                        <asp:Label ID="lblCodigo" runat="server" Text='<%# Bind("CODIGO") %>' ToolTip='<%# Bind("CODIGO") %>'></asp:Label></div>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Sequencia" SortExpression="SEQUENCIA" Visible="False">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="lblSequencia" runat="server" Text='<%# BIND("SEQUENCIA") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField ShowHeader="False">
                <ItemTemplate>
                    <asp:LinkButton ID="lnkExcluir" runat="server" CausesValidation="False" CommandName="Delete"
                        Text="Excluir"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <EditRowStyle BackColor="#999999" />
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
    </asp:GridView>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
</asp:Content>

