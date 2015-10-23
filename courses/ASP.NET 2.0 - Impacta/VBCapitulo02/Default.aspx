<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>
<%@ Register Src="Rodape.ascx" TagName="Rodape" TagPrefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
<script language="javascript" type="text/javascript">
// <!CDATA[

function Submit1_onclick() {

}

// ]]>
</script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div>
            <h1>
                Curso ASP.NET
            </h1>
            <h2>
                Capitulo 02 - Controles de Servidor</h2>
            <p>
                <asp:ImageButton ID="testeImageButton" runat="server" CausesValidation="False" ImageUrl="~/imagens/AreaDoAluno.jpg"
                    OnClick="testeImageButton_Click" />&nbsp;</p>
            <p>
                <asp:LinkButton ID="ajudaLinkButton" runat="server" CausesValidation="False" OnClick="ajudaLinkButton_Click">Clique aqui para ajuda</asp:LinkButton>&nbsp;</p>
            <p>
                Digite o seu nome&nbsp;
                <asp:TextBox ID="nomeTextBox" runat="server"></asp:TextBox>
                <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="OK" Width="51px" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="nomeTextBox"
                    ErrorMessage="Digite o seu nome"></asp:RequiredFieldValidator></p>
            <p>
                <asp:Label ID="mensagemLabel" runat="server"></asp:Label>&nbsp;</p>
            <p>
                <asp:TextBox ID="TextBox1" runat="server" Height="109px" TextMode="MultiLine" Width="298px"></asp:TextBox>&nbsp;</p>
            <p>
                &nbsp;</p>
            <p>
               
               
                <uc1:Rodape ID="Rodape1" runat="server" />
                
               
                
                &nbsp;</p>
            <p>
                &nbsp;</p>
            <p>
                &nbsp;</p>
            <p>
                &nbsp;</p>
        </div>
      
    
    </div>
    </form>
</body>
</html>
