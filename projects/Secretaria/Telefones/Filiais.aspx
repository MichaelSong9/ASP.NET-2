<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Filiais.aspx.cs" Inherits="Filiais" Title="Untitled Page" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajax" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="DIV_PAGES">
    <table style="width: 220px">
        <tr>
            <td style="width: 44px">
                <asp:Label ID="Label1" runat="server" Text="Nome:"></asp:Label></td>
            <td style="width: 94px">
                <asp:TextBox ID="txtNome" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 44px">
                <asp:Label ID="Label3" runat="server" Text="Ramal:"></asp:Label></td>
            <td style="width: 94px">
                <asp:TextBox ID="txtRamal" runat="server" MaxLength="10"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="2" style="text-align: right">
                <asp:Button ID="btnPesquisar" runat="server" BackColor="White" BorderColor="#507CD1"
                    BorderStyle="Solid" BorderWidth="1px" CausesValidation="False" Font-Names="Verdana"
                    Font-Size="0.8em" ForeColor="#284E98" OnClick="btnPesquisar_Click" Text="Pesquisar"
                    Width="160px" />
                &nbsp;
            </td>
        </tr>
    </table>
        <div style="z-index: 101; left: 237px; width: 206px; position: absolute; top: 209px;
            height: 32px">
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
        </div>
        <br />
        &nbsp; &nbsp;<br />
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
        <asp:DetailsView ID="dvFilial" runat="server" AutoGenerateRows="False" CellPadding="4"
            DataKeyNames="SEQUENCIA" DataSourceID="FiliaisSqlDataSource" Font-Size="Small"
            ForeColor="#333333" GridLines="None" Height="50px" Width="700px">
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <CommandRowStyle BackColor="#E2DED6" Font-Bold="True" />
            <EditRowStyle BackColor="#999999" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <Fields>
                <asp:BoundField DataField="SEQUENCIA" HeaderText="Sequ&#234;ncia" InsertVisible="False"
                    ReadOnly="True" SortExpression="SEQUENCIA" />
                <asp:BoundField DataField="DESTINO" HeaderText="Destino" SortExpression="DESTINO" />
                <asp:BoundField DataField="LOCAL" HeaderText="Local" SortExpression="LOCAL" />
                <asp:BoundField DataField="TELEFONE" HeaderText="Telefone" SortExpression="TELEFONE" />
                <asp:BoundField DataField="NOME" HeaderText="Nome" SortExpression="NOME" />
                <asp:BoundField DataField="CARGO" HeaderText="Cargo" SortExpression="CARGO" />
                <asp:BoundField DataField="RAMAL" HeaderText="Ramal" SortExpression="RAMAL" />
                <asp:BoundField DataField="CODIGO" HeaderText="C&#243;digo" SortExpression="CODIGO" />
                <asp:CommandField CancelText="Cancelar" DeleteText="Deletar" EditText="Editar" InsertText="Inserir"
                    NewText="Novo" SelectText="Selecionar" ShowEditButton="True" ShowInsertButton="True"
                    UpdateText="Atualizar" />
            </Fields>
            <FieldHeaderStyle BackColor="#E9ECF1" Font-Bold="True" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        </asp:DetailsView>
        <asp:SqlDataSource ID="FiliaisSqlDataSource" runat="server" ConflictDetection="CompareAllValues"
            ConnectionString="<%$ ConnectionStrings:intranetConnectionString %>" DeleteCommand="DELETE FROM [FILIAIS] WHERE [SEQUENCIA] = @original_SEQUENCIA AND [DESTINO] = @original_DESTINO AND [LOCAL] = @original_LOCAL AND [TELEFONE] = @original_TELEFONE AND [NOME] = @original_NOME AND [CARGO] = @original_CARGO AND [RAMAL] = @original_RAMAL AND [CODIGO] = @original_CODIGO"
            InsertCommand="INSERT INTO [FILIAIS] ([DESTINO], [LOCAL], [TELEFONE], [NOME], [CARGO], [RAMAL], [CODIGO]) VALUES (@DESTINO, @LOCAL, @TELEFONE, @NOME, @CARGO, @RAMAL, @CODIGO)"
            OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT [SEQUENCIA], [DESTINO], [LOCAL], [TELEFONE], [NOME], [CARGO], [RAMAL], [CODIGO] FROM [FILIAIS] WHERE (([NOME] = @NOME) AND ([DESTINO] = @DESTINO) AND ([RAMAL] = @RAMAL))"
            UpdateCommand="UPDATE [FILIAIS] SET [DESTINO] = @DESTINO, [LOCAL] = @LOCAL, [TELEFONE] = @TELEFONE, [NOME] = @NOME, [CARGO] = @CARGO, [RAMAL] = @RAMAL, [CODIGO] = @CODIGO WHERE [SEQUENCIA] = @original_SEQUENCIA AND [DESTINO] = @original_DESTINO AND [LOCAL] = @original_LOCAL AND [TELEFONE] = @original_TELEFONE AND [NOME] = @original_NOME AND [CARGO] = @original_CARGO AND [RAMAL] = @original_RAMAL AND [CODIGO] = @original_CODIGO">
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
            <SelectParameters>
                <asp:SessionParameter Name="NOME" SessionField="nome" Type="String" />
                <asp:SessionParameter Name="DESTINO" SessionField="destino" Type="String" />
                <asp:SessionParameter Name="RAMAL" SessionField="ramal" Type="String" />
            </SelectParameters>
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
        CellPadding="4" DataKeyNames="NOME,DESTINO,RAMAL" Font-Size="Small" ForeColor="#333333"
        GridLines="None" OnPageIndexChanging="GridView1_PageIndexChanging"
        OnRowCommand="GridView1_RowCommand" OnRowDataBound="GridView1_RowDataBound" OnRowDeleting="GridView1_RowDeleting"
        Style="left: 0px; top: 0px" Width="700px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <Columns>
            <asp:TemplateField ShowHeader="False">
                <ItemTemplate>
                    <asp:LinkButton ID="lnkSelecionar" runat="server" CausesValidation="False" CommandName="Select"
                        Text="Selecionar" OnClick="lnkSelecionar_Click"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Sequ&#234;ncia" SortExpression="SEQUENCIA" Visible="False"></asp:TemplateField>
            <asp:TemplateField HeaderText="Destino" SortExpression="DESTINO" Visible="False">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("CARGO") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <div style="left: 0px; overflow: hidden; width: 154px; top: 0px; height: 16px; text-align: left">
                        <asp:Label ID="lblDestino" runat="server" Text='<%# Bind("DESTINO") %>' ToolTip='<%# Bind("DESTINO") %>'></asp:Label></div>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Nome" SortExpression="NOME">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("NOME") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <div style="left: 0px; overflow: hidden; width: 153px; top: 0px; height: 16px; text-align: left">
                        <asp:Label ID="lblNome" runat="server" Text='<%# Bind("NOME") %>' ToolTip='<%# Bind("NOME") %>'></asp:Label></div>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Cargo" SortExpression="CARGO">
                <ItemTemplate>
                    <div style="left: 0px; overflow: hidden; width: 154px; top: 0px; height: 16px; text-align: left">
                        <asp:Label ID="lblCargo" runat="server" Text='<%# Bind("CARGO") %>' ToolTip='<%# Bind("CARGO") %>'></asp:Label></div>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Ramal" SortExpression="RAMAL">
                <ItemTemplate>
                    <div style="left: 0px; overflow: hidden; width: 59px; top: 0px; height: 16px; text-align: left">
                        <asp:Label ID="lblRamal" runat="server" Text='<%# Bind("RAMAL") %>' ToolTip='<%# Bind("RAMAL") %>'></asp:Label></div>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Local" SortExpression="LOCAL">
                <ItemTemplate>
                    <div style="left: 0px; overflow: hidden; width: 154px; top: 0px; height: 16px; text-align: left">
                        <asp:Label ID="lblLocal" runat="server" Text='<%# Bind("LOCAL") %>' ToolTip='<%# Bind("LOCAL") %>'></asp:Label></div>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Telefone" SortExpression="TELEFONE" Visible="False">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("RAMAL") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <div style="left: 0px; overflow: hidden; width: 180px; top: 0px; height: 16px; text-align: left">
                        <asp:Label ID="lblTelefone" runat="server" Text='<%# Bind("TELEFONE") %>' ToolTip='<%# Bind("TELEFONE") %>'></asp:Label></div>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="C&#243;digo" SortExpression="CODIGO" Visible="False"></asp:TemplateField>
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
        &nbsp;
    &nbsp;&nbsp;&nbsp;</div>
</asp:Content>

