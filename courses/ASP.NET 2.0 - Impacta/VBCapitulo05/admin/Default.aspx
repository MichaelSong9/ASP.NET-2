<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="admin_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>
            CURSO ASP.NET</h1>
        <p>
            BEM VINDO A ÁREA ADMINISTRATIVA DO SITE</p>
        <p>
            Atualizar o Cadastro</p>
        <p>
            Nome Completo:<br />
            <asp:TextBox ID="nomeTextBox" runat="server"></asp:TextBox></p>
        <p>
            Idade:<br />
            <asp:TextBox ID="idadeTextBox" runat="server"></asp:TextBox></p>
        <p>
            <asp:Button ID="confirmarButton" runat="server" Text="Confirmar" />&nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            Você está logado como&nbsp;
            <asp:LoginName ID="LoginName1" runat="server" />
        </p>
        <p>
            <asp:PasswordRecovery ID="PasswordRecovery1" runat="server" BackColor="#F7F6F3" BorderColor="#E6E2D8"
                BorderPadding="4" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana"
                Font-Size="0.8em">
                <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
                <SuccessTextStyle Font-Bold="True" ForeColor="#5D7B9D" />
                <TextBoxStyle Font-Size="0.8em" />
                <TitleTextStyle BackColor="#5D7B9D" Font-Bold="True" Font-Size="0.9em" ForeColor="White" />
                <SubmitButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid"
                    BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284775" />
            </asp:PasswordRecovery>
            &nbsp;</p>
        <p>
            Para Trocar a senha:</p>
        <p>
            <asp:ChangePassword ID="ChangePassword1" runat="server" BackColor="#F7F6F3" BorderColor="#E6E2D8"
                BorderPadding="4" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana"
                Font-Size="0.8em">
                <CancelButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid"
                    BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284775" />
                <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
                <PasswordHintStyle Font-Italic="True" ForeColor="#888888" />
                <ChangePasswordButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid"
                    BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284775" />
                <ContinueButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid"
                    BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284775" />
                <TitleTextStyle BackColor="#5D7B9D" Font-Bold="True" Font-Size="0.9em" ForeColor="White" />
                <TextBoxStyle Font-Size="0.8em" />
            </asp:ChangePassword>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            Para criar um&nbsp; novo usuario:</p>
        <p>
            <asp:CreateUserWizard ID="CreateUserWizard1" runat="server" BackColor="#F7F6F3" BorderColor="#E6E2D8"
                BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em"
                UserNameLabelText="Nome do usuário:">
                <WizardSteps>
                    <asp:CreateUserWizardStep runat="server">
                    </asp:CreateUserWizardStep>
                    <asp:CompleteWizardStep runat="server">
                    </asp:CompleteWizardStep>
                </WizardSteps>
                <SideBarStyle BackColor="#5D7B9D" BorderWidth="0px" Font-Size="0.9em" VerticalAlign="Top" />
                <TitleTextStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <SideBarButtonStyle BorderWidth="0px" Font-Names="Verdana" ForeColor="White" />
                <NavigationButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid"
                    BorderWidth="1px" Font-Names="Verdana" ForeColor="#284775" />
                <HeaderStyle BackColor="#5D7B9D" BorderStyle="Solid" Font-Bold="True" Font-Size="0.9em"
                    ForeColor="White" HorizontalAlign="Center" />
                <CreateUserButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid"
                    BorderWidth="1px" Font-Names="Verdana" ForeColor="#284775" />
                <ContinueButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid"
                    BorderWidth="1px" Font-Names="Verdana" ForeColor="#284775" />
                <StepStyle BorderWidth="0px" />
            </asp:CreateUserWizard>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default.aspx">Voltar </asp:HyperLink>&nbsp;</p>
    
    </div>
    </form>
</body>
</html>
