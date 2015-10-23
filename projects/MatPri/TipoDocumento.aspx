<%@ Page Language="VB" AutoEventWireup="false" CodeFile="TipoDocumento.aspx.vb" Inherits="Recebimento_LeiteDesnatado_TipoDocumento" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body style="background-color: #b5c7de">
    <form id="form1" runat="server">
    <div>
            <asp:CheckBoxList ID="chkTipoDocumento" runat="server" Height="210px" Width="155px" Font-Bold="False" Font-Italic="False" ForeColor="#000099">
                <asp:ListItem Value="1">Leite</asp:ListItem>
                <asp:ListItem Value="2">Creme</asp:ListItem>
                <asp:ListItem Value="3">Soro</asp:ListItem>
                <asp:ListItem Value="4">Granelizado</asp:ListItem>
                <asp:ListItem Value="92">Apoio-Tr&#226;nsito</asp:ListItem>
                <asp:ListItem Value="94">Emprestimo</asp:ListItem>
                <asp:ListItem Value="96">Remessa-Terceiro</asp:ListItem>
                <asp:ListItem Value="97">Retido na Associada</asp:ListItem>
                <asp:ListItem Value="98">Venda-Terceiro</asp:ListItem>
                <asp:ListItem Value="99">Insufic&#234;ncias</asp:ListItem>
            </asp:CheckBoxList><br />
        &nbsp;&nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp;&nbsp; 
        <asp:ImageButton ID="imbSalvar" runat="server" ImageUrl="~/App_Themes/CCL/Imagens/Bt_Salvar.gif" />
    </div>
    </form>
</body>
</html>
