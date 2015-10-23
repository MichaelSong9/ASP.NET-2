<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="BlobASPNet._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Teste BLOB ASP.NET - 14.05.2012</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    
        <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" 
            Height="380px" Width="493px" AllowPaging="True" CellPadding="4" 
            DataKeyNames="FotoID" ForeColor="#333333" GridLines="None" 
            oniteminserting="DetailsView1_ItemInserting" 
            onitemdeleting="DetailsView1_ItemDeleting" 
            onitemupdating="DetailsView1_ItemUpdating" 
            onmodechanging="DetailsView1_ModeChanging" 
            onpageindexchanging="DetailsView1_PageIndexChanging">
            <FooterStyle BackColor="#5D7B9D" ForeColor="White" Font-Bold="True" />
            <CommandRowStyle BackColor="#E2DED6" Font-Bold="True" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <FieldHeaderStyle BackColor="#E9ECF1" Font-Bold="True" />
            <PagerStyle ForeColor="White" HorizontalAlign="Center" BackColor="#284775" />
            <Fields>
                <asp:BoundField HeaderText="Titulo :" DataField="Titulo" />
                <asp:TemplateField HeaderText="Descrição :">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Height="38px" Width="428px"></asp:TextBox>
                    </EditItemTemplate>
                    <InsertItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Height="60px" 
                            Text='<%# Bind("Descricao") %>' TextMode="MultiLine" Width="429px"></asp:TextBox>
                    </InsertItemTemplate>
                    <ItemTemplate>
                        <asp:TextBox ID="TextBox3" runat="server" Height="49px" 
                            Text='<%# Bind("Descricao") %>' TextMode="MultiLine" Width="419px" 
                            ReadOnly="True"></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Foto :">
                    <EditItemTemplate>
                        <asp:FileUpload ID="FileUpload1" runat="server" />
                    </EditItemTemplate>
                    <InsertItemTemplate>
                        <asp:FileUpload ID="FileUpload2" runat="server" />
                    </InsertItemTemplate>
                    <ItemTemplate>
                        <asp:Image ID="Image1" runat="server" Height="218px" 
                            ImageUrl='<%# Eval("FotoID","~/ExibeFoto.aspx?fotoid={0}") %>' 
                            Width="201px" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:CommandField ButtonType="Button" ShowDeleteButton="True" 
                    ShowEditButton="True" ShowInsertButton="True" CancelText="Cancela" 
                    DeleteText="Deleta" EditText="Edita" InsertText="Inserir" NewText="Novo" 
                    SelectText="Seleciona" UpdateText="Atualiza" />
            </Fields>
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <EditRowStyle BackColor="#999999" />
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        </asp:DetailsView>
    
    
    </div>
    </form>
</body>
</html>
