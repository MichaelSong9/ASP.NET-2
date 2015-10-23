<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" 
            Height="380px" Width="493px" AllowPaging="True" BackColor="#DEBA84" 
            BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
            CellSpacing="2" DataKeyNames="FotoID">
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
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
                            ImageUrl='<%# Eval("FotoID","~/exibeFoto.aspx?fotoid={0}") %>' 
                            Width="201px" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:CommandField ButtonType="Button" ShowDeleteButton="True" 
                    ShowEditButton="True" ShowInsertButton="True" CancelText="Cancela" 
                    DeleteText="Deleta" EditText="Edita" InsertText="Inserir" NewText="Novo" 
                    SelectText="Seleciona" UpdateText="Atualiza" />
            </Fields>
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <EditRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
        </asp:DetailsView>
    
    </div>
    </form>
</body>
</html>
