<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false"
    CodeFile="Altera_Senha.aspx.vb" Inherits="usuario_Altera_Senha" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="DIV_PAGES" style="text-align: center">
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        &nbsp;<asp:Panel ID="Panel1" runat="server" CssClass="DIV_ALTSENHA">
            <asp:ChangePassword ID="cMudarSenha" runat="server" BackColor="#EFF3FB" BorderColor="#B5C7DE"
                BorderPadding="4" BorderStyle="Solid" BorderWidth="1px" CancelDestinationPageUrl="~/Pagina_Principal.aspx"
                ContinueDestinationPageUrl="~/Pagina_Principal.aspx" Font-Names="Verdana" Font-Size="0.8em"
                Height="114px" Width="327px">
                <CancelButtonStyle BackColor="White" BorderColor="#507CD1" BorderStyle="Solid" BorderWidth="1px"
                    Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284E98" />
                <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
                <PasswordHintStyle Font-Italic="True" ForeColor="#507CD1" />
                <ChangePasswordButtonStyle BackColor="White" BorderColor="#507CD1" BorderStyle="Solid"
                    BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284E98" />
                <ContinueButtonStyle BackColor="White" BorderColor="#507CD1" BorderStyle="Solid"
                    BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284E98" />
                <TitleTextStyle BackColor="#507CD1" Font-Bold="True" Font-Size="0.9em" ForeColor="White" />
                <TextBoxStyle Font-Size="0.8em" />
                <ChangePasswordTemplate>
                    <table border="0" cellpadding="4" cellspacing="0" style="border-collapse: collapse">
                        <tr>
                            <td style="height: 181px">
                                <table border="0" cellpadding="0" style="width: 309px; height: 161px">
                                    <tr>
                                        <td align="center" colspan="2" style="font-weight: bold; font-size: 0.9em; color: white;
                                            background-color: #507cd1">
                                            Altere Sua Senha
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="right" style="width: 179px">
                                            <asp:Label ID="CurrentPasswordLabel" runat="server" AssociatedControlID="CurrentPassword">Senha atual:</asp:Label>
                                        </td>
                                        <td style="width: 125px">
                                            <asp:TextBox ID="CurrentPassword" runat="server" Font-Size="0.8em" TextMode="Password"></asp:TextBox>&nbsp;
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="right" style="width: 179px">
                                            <asp:Label ID="NewPasswordLabel" runat="server" AssociatedControlID="NewPassword">Nova Senha:</asp:Label>
                                        </td>
                                        <td style="width: 125px">
                                            <asp:TextBox ID="NewPassword" runat="server" Font-Size="0.8em" TextMode="Password"></asp:TextBox>&nbsp;
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="right" style="width: 179px; height: 29px;">
                                            <asp:Label ID="ConfirmNewPasswordLabel" runat="server" AssociatedControlID="ConfirmNewPassword">Confirme a Nova Senha:</asp:Label>
                                        </td>
                                        <td style="width: 125px; height: 29px;">
                                            <asp:TextBox ID="ConfirmNewPassword" runat="server" Font-Size="0.8em" TextMode="Password"
                                                ToolTip="Confirme a nova senha"></asp:TextBox>&nbsp;
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="right" style="height: 35px; width: 179px;">
                                            <asp:Button ID="ChangePasswordPushButton" runat="server" BackColor="White" BorderColor="#507CD1"
                                                BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em"
                                                ForeColor="#284E98" OnClick="ChangePasswordPushButton_Click" Text="Mudar a Senha"
                                                ValidationGroup="ChangePassword1" />
                                        </td>
                                        <td style="height: 35px; width: 125px;">
                                            <asp:Button ID="CancelPushButton" runat="server" BackColor="White" BorderColor="#507CD1"
                                                BorderStyle="Solid" BorderWidth="1px" CausesValidation="False" CommandName="Cancel"
                                                Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284E98" Text="Cancelar" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </ChangePasswordTemplate>
            </asp:ChangePassword>
            <br />
        </asp:Panel>
    </div>
</asp:Content>
