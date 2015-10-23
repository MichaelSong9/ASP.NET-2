<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>
            LOGIN</h1>
        <p>
            &nbsp;<asp:Login ID="Login1" runat="server" BackColor="#F7F6F3" BorderColor="#E6E2D8"
                BorderPadding="4" BorderStyle="Solid" BorderWidth="1px" FailureText="Nome ou Senha inválidos"
                Font-Names="Verdana" Font-Size="0.8em" ForeColor="#333333" Height="127px" LoginButtonText="Confirmar"
                PasswordLabelText="Senha:" RememberMeText="Lembrar Senha" TitleText="Formulário de Login"
                UserNameLabelText="Nome do usuário:" Width="301px">
                <TitleTextStyle BackColor="#5D7B9D" Font-Bold="True" Font-Size="0.9em" ForeColor="White" />
                <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
                <TextBoxStyle Font-Size="0.8em" />
                <LoginButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px"
                    Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284775" />
            </asp:Login>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            Nome<br />
            <asp:TextBox ID="nomeTextBox" runat="server"></asp:TextBox></p>
        <p>
            Senha<br />
            <asp:TextBox ID="senhaTextBox" runat="server"></asp:TextBox></p>
        <p>
            <asp:Button ID="ConfirmarButton" runat="server" OnClick="ConfirmarButton_Click" Text="Confirmar" />
            <br />
            <br />
            <asp:Label ID="mensagemLabel" runat="server"></asp:Label></p>
    
    </div>
    </form>
</body>
</html>
