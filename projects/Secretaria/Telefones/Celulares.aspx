<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Celulares.aspx.cs" Inherits="Celulares" Title="Untitled Page" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajax" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <!--<div id="DIV_PAGES">-->
    <span style="display : block; float : left; position: absolute; z-index: 100;">
         </span>
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
                <td colspan="2">
                    <asp:Button ID="btnPesquisar" runat="server" OnClick="btnPesquisar_Click" Text="Pesquisar"
                        Width="212px" BackColor="White" BorderColor="#507CD1" BorderStyle="Solid" BorderWidth="1px" CausesValidation="False" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284E98" /></td>
            </tr>
        </table>
        <div style="z-index: 101; left: 241px; width: 248px; position: absolute; top: 229px;
            height: 37px">
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
        </div>
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
        <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" CellPadding="4"
            DataKeyNames="codid" DataSourceID="CelularesSqlDataSource" ForeColor="#333333"
            GridLines="None" Height="27px" Width="700px" Font-Size="Small">
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <CommandRowStyle BackColor="#E2DED6" Font-Bold="True" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <FieldHeaderStyle BackColor="#E9ECF1" Font-Bold="True" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <Fields>
                <asp:TemplateField HeaderText="C&#243;digo" InsertVisible="False" SortExpression="codid">
                    <EditItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("codid") %>'></asp:Label>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("codid") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="C&#243;digo do Celular" SortExpression="cod_cel">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("cod_cel") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <InsertItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("cod_cel") %>'></asp:TextBox>
                    </InsertItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("cod_cel") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="nome" HeaderText="Nome" SortExpression="nome" />
                <asp:TemplateField HeaderText="Departamento" SortExpression="depto">
                    <EditItemTemplate>
                        <asp:DropDownList ID="DropDownList1" runat="server" SelectedValue='<%# Bind("DEPTO", "{0}") %>'
                            Width="155px">
                            <asp:ListItem>ADC</asp:ListItem>
                            <asp:ListItem>ADI</asp:ListItem>
                            <asp:ListItem>AUD</asp:ListItem>
                            <asp:ListItem>AVP</asp:ListItem>
                            <asp:ListItem>BB</asp:ListItem>
                            <asp:ListItem>DCF</asp:ListItem>
                            <asp:ListItem>DCO</asp:ListItem>
                            <asp:ListItem>DEM</asp:ListItem>
                            <asp:ListItem>DGE</asp:ListItem>
                            <asp:ListItem>DGQ</asp:ListItem>
                            <asp:ListItem>DIF</asp:ListItem>
                            <asp:ListItem>DJU</asp:ListItem>
                            <asp:ListItem>DLS</asp:ListItem>
                            <asp:ListItem>DOM</asp:ListItem>
                            <asp:ListItem>DPR</asp:ListItem>
                            <asp:ListItem>DRH</asp:ListItem>
                            <asp:ListItem>DVE</asp:ListItem>
                            <asp:ListItem>FAT</asp:ListItem>
                            <asp:ListItem>JRA</asp:ListItem>
                            <asp:ListItem>PAV</asp:ListItem>
                            <asp:ListItem>POL</asp:ListItem>
                            <asp:ListItem>REP</asp:ListItem>
                            <asp:ListItem>SAC</asp:ListItem>
                            <asp:ListItem>SAG</asp:ListItem>
                            <asp:ListItem>SAI</asp:ListItem>
                            <asp:ListItem>SAL</asp:ListItem>
                            <asp:ListItem>SEP</asp:ListItem>
                            <asp:ListItem>SFS</asp:ListItem>
                            <asp:ListItem>SGC</asp:ListItem>
                            <asp:ListItem>SMK</asp:ListItem>
                            <asp:ListItem>SPT</asp:ListItem>
                            <asp:ListItem>SPV</asp:ListItem>
                            <asp:ListItem>SSG</asp:ListItem>
                            <asp:ListItem>STR</asp:ListItem>
                            <asp:ListItem>STV</asp:ListItem>
                            <asp:ListItem>SUP</asp:ListItem>
                            <asp:ListItem>SVD</asp:ListItem>
                            <asp:ListItem>TUT</asp:ListItem>
                            <asp:ListItem>UC</asp:ListItem>
                        </asp:DropDownList>
                    </EditItemTemplate>
                    <InsertItemTemplate>
                        <asp:DropDownList ID="DropDownList1" runat="server" SelectedValue='<%# Bind("DEPTO", "{0}") %>'
                            Width="155px">
                            <asp:ListItem>ADC</asp:ListItem>
                            <asp:ListItem>ADI</asp:ListItem>
                            <asp:ListItem>AUD</asp:ListItem>
                            <asp:ListItem>AVP</asp:ListItem>
                            <asp:ListItem>BB</asp:ListItem>
                            <asp:ListItem>DCF</asp:ListItem>
                            <asp:ListItem>DCO</asp:ListItem>
                            <asp:ListItem>DEM</asp:ListItem>
                            <asp:ListItem>DGE</asp:ListItem>
                            <asp:ListItem>DGQ</asp:ListItem>
                            <asp:ListItem>DIF</asp:ListItem>
                            <asp:ListItem>DJU</asp:ListItem>
                            <asp:ListItem>DLS</asp:ListItem>
                            <asp:ListItem>DOM</asp:ListItem>
                            <asp:ListItem>DPR</asp:ListItem>
                            <asp:ListItem>DRH</asp:ListItem>
                            <asp:ListItem>DVE</asp:ListItem>
                            <asp:ListItem>FAT</asp:ListItem>
                            <asp:ListItem>JRA</asp:ListItem>
                            <asp:ListItem>PAV</asp:ListItem>
                            <asp:ListItem>POL</asp:ListItem>
                            <asp:ListItem>REP</asp:ListItem>
                            <asp:ListItem>SAC</asp:ListItem>
                            <asp:ListItem>SAG</asp:ListItem>
                            <asp:ListItem>SAI</asp:ListItem>
                            <asp:ListItem>SAL</asp:ListItem>
                            <asp:ListItem>SEP</asp:ListItem>
                            <asp:ListItem>SFS</asp:ListItem>
                            <asp:ListItem>SGC</asp:ListItem>
                            <asp:ListItem>SMK</asp:ListItem>
                            <asp:ListItem>SPT</asp:ListItem>
                            <asp:ListItem>SPV</asp:ListItem>
                            <asp:ListItem>SSG</asp:ListItem>
                            <asp:ListItem>STR</asp:ListItem>
                            <asp:ListItem>STV</asp:ListItem>
                            <asp:ListItem>SUP</asp:ListItem>
                            <asp:ListItem>SVD</asp:ListItem>
                            <asp:ListItem>TUT</asp:ListItem>
                            <asp:ListItem>UC</asp:ListItem>
                        </asp:DropDownList>
                    </InsertItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("depto") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="cargo" HeaderText="Cargo" SortExpression="cargo" />
                <asp:BoundField DataField="regiao" HeaderText="Regi&#227;o" SortExpression="regiao" />
                <asp:BoundField DataField="telefone" HeaderText="Telefone" SortExpression="telefone" />
                <asp:BoundField DataField="celular" HeaderText="Celular" SortExpression="celular" />
                <asp:BoundField DataField="palm" HeaderText="Palm" SortExpression="palm" />
                <asp:BoundField DataField="recado" HeaderText="Recado" SortExpression="recado" />
                <asp:TemplateField ShowHeader="False">
                    <EditItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="True" CommandName="Update"
                            Text="Atualizar"></asp:LinkButton>
                        <asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Cancel"
                            Text="Cancelar"></asp:LinkButton>
                    </EditItemTemplate>
                    <InsertItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="True" CommandName="Insert"
                            Text="Inserir"></asp:LinkButton>
                        <asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Cancel"
                            Text="Cancelar"></asp:LinkButton>
                    </InsertItemTemplate>
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Edit"
                            Text="Editar"></asp:LinkButton>
                        <asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="New"
                            Text="Novo"></asp:LinkButton>&nbsp;
                    </ItemTemplate>
                </asp:TemplateField>
            </Fields>
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <EditRowStyle BackColor="#999999" />
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        </asp:DetailsView>
        <asp:SqlDataSource ID="CelularesSqlDataSource" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:intranetConnectionString %>" DeleteCommand="DELETE FROM [CELULARES] WHERE [codid] = @original_codid AND (([cod_cel] = @original_cod_cel) OR ([cod_cel] IS NULL AND @original_cod_cel IS NULL)) AND [nome] = @original_nome AND (([depto] = @original_depto) OR ([depto] IS NULL AND @original_depto IS NULL)) AND (([cargo] = @original_cargo) OR ([cargo] IS NULL AND @original_cargo IS NULL)) AND (([regiao] = @original_regiao) OR ([regiao] IS NULL AND @original_regiao IS NULL)) AND (([telefone] = @original_telefone) OR ([telefone] IS NULL AND @original_telefone IS NULL)) AND (([celular] = @original_celular) OR ([celular] IS NULL AND @original_celular IS NULL)) AND (([palm] = @original_palm) OR ([palm] IS NULL AND @original_palm IS NULL)) AND (([recado] = @original_recado) OR ([recado] IS NULL AND @original_recado IS NULL))" InsertCommand="INSERT INTO [CELULARES] ([cod_cel], [nome], [depto], [cargo], [regiao], [telefone], [celular], [palm], [recado]) VALUES (@cod_cel, @nome, @depto, @cargo, @regiao, @telefone, @celular, @palm, @recado)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT [codid], [cod_cel], [nome], [depto], [cargo], [regiao], [telefone], [celular], [palm], [recado] FROM [CELULARES] WHERE ([codid] = @codid)" UpdateCommand="UPDATE [CELULARES] SET [cod_cel] = @cod_cel, [nome] = @nome, [depto] = @depto, [cargo] = @cargo, [regiao] = @regiao, [telefone] = @telefone, [celular] = @celular, [palm] = @palm, [recado] = @recado WHERE [codid] = @original_codid AND (([cod_cel] = @original_cod_cel) OR ([cod_cel] IS NULL AND @original_cod_cel IS NULL)) AND [nome] = @original_nome AND (([depto] = @original_depto) OR ([depto] IS NULL AND @original_depto IS NULL)) AND (([cargo] = @original_cargo) OR ([cargo] IS NULL AND @original_cargo IS NULL)) AND (([regiao] = @original_regiao) OR ([regiao] IS NULL AND @original_regiao IS NULL)) AND (([telefone] = @original_telefone) OR ([telefone] IS NULL AND @original_telefone IS NULL)) AND (([celular] = @original_celular) OR ([celular] IS NULL AND @original_celular IS NULL)) AND (([palm] = @original_palm) OR ([palm] IS NULL AND @original_palm IS NULL)) AND (([recado] = @original_recado) OR ([recado] IS NULL AND @original_recado IS NULL))">
            <SelectParameters>
                <asp:ControlParameter ControlID="GridView1" Name="codid" PropertyName="SelectedValue"
                    Type="Int32" />
            </SelectParameters>
            <DeleteParameters>
                <asp:Parameter Name="original_codid" Type="Int32" />
                <asp:Parameter Name="original_cod_cel" Type="Int32" />
                <asp:Parameter Name="original_nome" Type="String" />
                <asp:Parameter Name="original_depto" Type="String" />
                <asp:Parameter Name="original_cargo" Type="String" />
                <asp:Parameter Name="original_regiao" Type="String" />
                <asp:Parameter Name="original_telefone" Type="String" />
                <asp:Parameter Name="original_celular" Type="String" />
                <asp:Parameter Name="original_palm" Type="String" />
                <asp:Parameter Name="original_recado" Type="String" />
            </DeleteParameters>
            <UpdateParameters>
                <asp:Parameter Name="cod_cel" Type="Int32" />
                <asp:Parameter Name="nome" Type="String" />
                <asp:Parameter Name="depto" Type="String" />
                <asp:Parameter Name="cargo" Type="String" />
                <asp:Parameter Name="regiao" Type="String" />
                <asp:Parameter Name="telefone" Type="String" />
                <asp:Parameter Name="celular" Type="String" />
                <asp:Parameter Name="palm" Type="String" />
                <asp:Parameter Name="recado" Type="String" />
                <asp:Parameter Name="original_codid" Type="Int32" />
                <asp:Parameter Name="original_cod_cel" Type="Int32" />
                <asp:Parameter Name="original_nome" Type="String" />
                <asp:Parameter Name="original_depto" Type="String" />
                <asp:Parameter Name="original_cargo" Type="String" />
                <asp:Parameter Name="original_regiao" Type="String" />
                <asp:Parameter Name="original_telefone" Type="String" />
                <asp:Parameter Name="original_celular" Type="String" />
                <asp:Parameter Name="original_palm" Type="String" />
                <asp:Parameter Name="original_recado" Type="String" />
            </UpdateParameters>
            <InsertParameters>
                <asp:Parameter Name="cod_cel" Type="Int32" />
                <asp:Parameter Name="nome" Type="String" />
                <asp:Parameter Name="depto" Type="String" />
                <asp:Parameter Name="cargo" Type="String" />
                <asp:Parameter Name="regiao" Type="String" />
                <asp:Parameter Name="telefone" Type="String" />
                <asp:Parameter Name="celular" Type="String" />
                <asp:Parameter Name="palm" Type="String" />
                <asp:Parameter Name="recado" Type="String" />
            </InsertParameters>
        </asp:SqlDataSource>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="CODID" CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="True" style="top: 0px; left: 1px;" Font-Size="Small" OnPageIndexChanging="GridView1_PageIndexChanging" OnRowCommand="GridView1_RowCommand" OnRowDataBound="GridView1_RowDataBound" OnRowDeleting="GridView1_RowDeleting" Width="700px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <Columns>
                <asp:TemplateField ShowHeader="False">
                    <ItemTemplate>
                        <asp:LinkButton ID="lnkSelecionar" runat="server" CausesValidation="False" CommandName="Select"
                            OnClick="lnkSelecionar_Click" Text="Selecionar"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Nome" SortExpression="nome">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("nome") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <div style="left: 0px; overflow: hidden; width: 153px; top: 0px; height: 16px; text-align: left;">
                            <asp:Label ID="lblNome" runat="server" Text='<%# Bind("NOME") %>' ToolTip='<%# Bind("NOME") %>'></asp:Label></div>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Cargo" SortExpression="cargo">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("cargo") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <div style="left: 0px; overflow: hidden; width: 135px; top: 0px; height: 16px; text-align: left;">
                            <asp:Label ID="lblCargo" runat="server" Text='<%# Bind("CARGO") %>' ToolTip='<%# Bind("CARGO") %>'></asp:Label></div>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Depto" SortExpression="depto">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("depto") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblDepto" runat="server" Height="16px" Text='<%# Bind("DEPTO") %>'
                            ToolTip='<%# Bind("DEPTO") %>' Width="56px"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Regi&#227;o" SortExpression="regiao" Visible="False">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox5" runat="server" Text='<%# Bind("regiao") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <div style="left: 0px; overflow: hidden; width: 69px; top: 0px; height: 16px">
                            <asp:Label ID="lblRegiao" runat="server" Text='<%# Bind("regiao") %>' ToolTip='<%# Bind("regiao") %>'></asp:Label></div>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Telefone" SortExpression="telefone">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox6" runat="server" Text='<%# Bind("telefone") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <div style="left: 0px; overflow: hidden; width: 75px; top: 0px; height: 16px; text-align: left;">
                            <asp:Label ID="lblTelefone" runat="server" Text='<%# Bind("telefone") %>' ToolTip='<%# Bind("telefone") %>' Width="97px"></asp:Label></div>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Celular" SortExpression="celular">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox7" runat="server" Text='<%# Bind("celular") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <div style="left: 0px; overflow: hidden; width: 90px; top: 0px; height: 16px; text-align: left;">
                            <asp:Label ID="lblCelular" runat="server" Text='<%# Bind("celular") %>' ToolTip='<%# Bind("celular") %>'></asp:Label></div>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Palm" SortExpression="palm" Visible="False">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox8" runat="server" Text='<%# Bind("palm") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <div style="left: 0px; overflow: hidden; width: 75px; top: 0px; height: 16px">
                            <asp:Label ID="lblPalm" runat="server" Text='<%# Bind("palm") %>' ToolTip='<%# Bind("palm") %>'></asp:Label></div>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Recado" SortExpression="recado" Visible="False">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox9" runat="server" Text='<%# Bind("recado") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <div style="left: 0px; overflow: hidden; width: 75px; top: 0px; height: 16px">
                            <asp:Label ID="lblRecado" runat="server" Text='<%# Bind("recado") %>' ToolTip='<%# Bind("recado") %>'></asp:Label></div>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="codid" SortExpression="codid" Visible="False">
                    <ItemTemplate>
                        <asp:Label ID="lblCodId" runat="server" Text='<%# Bind("CODID") %>' ToolTip='<%# Bind("NOME") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="cod_cel" SortExpression="cod_cel" Visible="False">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("cod_cel") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblCodCel" runat="server" Text='<%# Bind("cod_cel") %>'></asp:Label>
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
    <!--</div>-->
</asp:Content>

