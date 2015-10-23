<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Autenticacao.aspx.cs" Inherits="Autenticacao" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>PgtoProdutores - Login</title>
    <link href="App_Themes/Estilo.css" rel="stylesheet" type="text/css" />
</head>
<body style="text-align: center">
    <form id="form1" runat="server">
        <div style="text-align: left">
            <br />
            <br />
            <br />
            <table>
                <tr>
                    <td style="width: 10px">
                    </td>
                    <td style="width: 491px">
        <asp:Panel ID="Panel1" runat="server" Direction="LeftToRight" Height="100px" HorizontalAlign="Left"
            Width="450px">
            <asp:Login ID="Login1" runat="server"
                CssClass="LoginControl" InstructionText="Digite seu usuário e senha para realizar a autenticação."
                OnAuthenticate="Login1_Authenticate" OnLoginError="Login1_LoginError" TitleText="Login - Pagamento de Produtores" BorderStyle="Solid" BorderWidth="2px" FailureText="Usuário ou senha inválidos. Verifique!" Width="322px">
                <TitleTextStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                <LayoutTemplate>
                    <table border="0" cellpadding="0">
                        <tr>
                            <td align="center" colspan="1" style="font-weight: bold; width: 677px; color: white;
                                background-color: #6b696b; text-align: left">
                            </td>
                            <td align="center" colspan="2" style="font-weight: bold; color: white; background-color: #6b696b;
                                text-align: left">
                            </td>
                        </tr>
                        <tr>
                            <td align="right" rowspan="6" style="width: 677px; text-align: left">
                                <asp:Image ID="Image1" runat="server" ImageUrl="~/App_Themes/images/ccl_login.jpg" />
                                <br />
                                <br />
                                <asp:Label ID="Label1" runat="server" Text="Pgto de Produtores" Width="150px"></asp:Label><br />
                                <br />
                                <br />
                                <br />
                                <br />
                            </td>
                            <td align="right" style="width: 70px; height: 42px; text-align: left">
                                <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">Usuário:</asp:Label></td>
                            <td style="width: 178px; height: 42px">
                                <asp:TextBox ID="UserName" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName"
                                    ErrorMessage="Informe o usuário" ToolTip="Informe o usuário" ValidationGroup="Login1">*</asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" style="width: 70px; text-align: left">
                                <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">Senha:</asp:Label></td>
                            <td style="width: 178px">
                                <asp:TextBox ID="Password" runat="server" TextMode="Password" Width="149px"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password"
                                    ErrorMessage="Informe a senha" ToolTip="Informe a senha" ValidationGroup="Login1">*</asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td align="center" colspan="2" style="color: red; height: 12px; text-align: left">
                                <asp:Literal ID="FailureText" runat="server" EnableViewState="False"></asp:Literal>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" colspan="2" style="height: 12px">
                                &nbsp;
                            </td>
                        </tr>
                        <tr>
                            <td align="right" colspan="2" style="text-align: center">
                                <asp:Button ID="LoginButton" runat="server" BackColor="White" BorderColor="#507CD1"
                                    BorderStyle="Solid" BorderWidth="1px" CommandName="Login" ForeColor="#284E98"
                                    Text="Acessar" ValidationGroup="Login1" Width="256px" /></td>
                        </tr>
                        <tr>
                            <td align="right" colspan="2">
                            </td>
                        </tr>
                    </table>
                </LayoutTemplate>
            </asp:Login>
            &nbsp;
        </asp:Panel>
                    </td>
                </tr>
            </table>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            &nbsp;</div>
    </form>
</body>
</html>
