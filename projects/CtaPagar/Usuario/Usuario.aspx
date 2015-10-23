<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Usuario.aspx.vb" Inherits="usuario_Usuario" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Untitled Page</title>
    <link href="../App_Themes/CCL/CCL.css" rel="stylesheet" type="text/css" />
    <link id="Estilo" type="text/css" rel="stylesheet" runat="server" />

    <script language="javascript" type="text/javascript">
	    window.moveTo(0,0);
	    if (document.all) {
	        top.window.resizeTo(screen.availWidth,screen.availHeight);
	    }
	    else if (document.layers||document.getElementById) {
	        if (top.window.outerHeight<screen.availHeight||top.window.outerWidth<screen.availWidth){
	            top.window.outerHeight = screen.availHeight;
	            top.window.outerWidth = screen.availWidth;
   	        }
	    }
        function IMG1_onclick() {

        }
        
        function BuscaResolucao()
        {
            var res = window.screen.height+"x"+window.screen.width;
            document.getElementById('txtResolucao').value = res;        
        }  	
    </script>

</head>
<body onload="BuscaResolucao();">
    <form id="form1" runat="server">
    <div>
        <div style="text-align: center;">
            <div style="z-index: 103; left: 311px; width: 364px; position: absolute; top: 164px;
                height: 20px">
                <br />
                <asp:Login ID="cLogin" runat="server" Height="149px">
                    <LayoutTemplate>
                        <table border="0" cellpadding="1" cellspacing="0" style="border-collapse: collapse">
                            <tr>
                                <td style="width: 348px; height: 130px; text-align: center">
                                    <table border="0" cellpadding="0">
                                        <tr>
                                            <td align="right" style="width: 145px; height: 24px; text-align: right">
                                                <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName" Font-Bold="True"
                                                    Font-Names="Verdana" Font-Size="Small" ForeColor="#333399" Style="text-align: right">Usuário:</asp:Label>
                                            </td>
                                            <td style="height: 24px; text-align: left; width: 177px;">
                                                &nbsp;<asp:TextBox ID="UserName" runat="server" TabIndex="1" Width="145px"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName"
                                                    Style="text-align: right" ToolTip="Digite o usuário" ValidationGroup="cLogin">*</asp:RequiredFieldValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="right" style="width: 145px; text-align: right">
                                                <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password" Font-Bold="True"
                                                    Font-Names="Verdana" Font-Size="Small" ForeColor="#333399" Style="text-align: right">Senha:</asp:Label>
                                            </td>
                                            <td style="text-align: left; width: 177px;">
                                                &nbsp;<asp:TextBox ID="Password" runat="server" Style="text-align: left" TabIndex="2"
                                                    TextMode="Password" Width="145px"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password"
                                                    Style="text-align: right" ToolTip="Digite a senha" ValidationGroup="cLogin">*</asp:RequiredFieldValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td colspan="2" style="color: red">
                                                <asp:Literal ID="FailureText" runat="server" EnableViewState="False"></asp:Literal>&nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="center" colspan="1" style="width: 145px; height: 32px; text-align: right;">
                                                <asp:Label ID="lblBancoDados" runat="server" AssociatedControlID="ddlBanco" Font-Bold="True"
                                                    Font-Names="Verdana" Font-Size="Small" ForeColor="#333399" Style="text-align: left"
                                                    Width="137px">Banco de Dados:</asp:Label>
                                            </td>
                                            <td align="center" colspan="2" style="height: 32px; text-align: left">
                                                &nbsp;<asp:DropDownList ID="ddlBanco" runat="server" TabIndex="3" Width="153px">
                                                    <asp:ListItem>cf</asp:ListItem>
                                                    <asp:ListItem Value="cf_teste">cf_teste</asp:ListItem>
                                                </asp:DropDownList>
                                                <asp:RequiredFieldValidator ID="BcoDadosRequired" runat="server" ControlToValidate="ddlBanco"
                                                    SetFocusOnError="True" ToolTip="Selecione o Banco de Dados" ValidationGroup="cLogin">*</asp:RequiredFieldValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="right" colspan="1" style="width: 145px; height: 22px; text-align: right;">
                                                <asp:Label ID="lblFilial" runat="server" Font-Bold="True" Font-Names="Verdana" Font-Size="Small"
                                                    ForeColor="#333399" Text="Empresa:"></asp:Label>
                                            </td>
                                            <td align="right" colspan="2" style="height: 22px; text-align: left">
                                                &nbsp;<asp:DropDownList ID="ddlEmpresa" runat="server" TabIndex="4" Width="153px">
                                                    <asp:ListItem>CCL - SP</asp:ListItem>
                                                </asp:DropDownList>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="ddlEmpresa"
                                                    SetFocusOnError="True" ToolTip="Selecione a Empresa" ValidationGroup="cLogin">*</asp:RequiredFieldValidator>&nbsp;
                                            </td>
                                        </tr>
                                    </table>
                                    &nbsp;<br />
                                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp;
                                    &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;<asp:Button ID="btnAcessar" runat="server"
                                        BackColor="White" BorderColor="#507CD1" BorderStyle="Solid" BorderWidth="1px"
                                        CommandName="Login" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284E98"
                                        TabIndex="5" Text="Acessar" ValidationGroup="cLogin" OnClick="Page_Load" />
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 348px; height: 21px; text-align: center">
                                </td>
                            </tr>
                        </table>
                    </LayoutTemplate>
                </asp:Login>
            </div>
            <asp:Panel ID="Panel1" runat="server" Height="362px" Width="725px">
                <br />
                &nbsp;<br />
                <br />
                <div style="z-index: 104; left: 331px; width: 169px; position: absolute; top: 48px;
                    height: 100px">
                    <input id="txtResolucao" type="text" runat="server" visible="true" style="width: 1px;
                        background-color: transparent; visibility: hidden;" />
                </div>
                <br />
                <br />
                &nbsp;<br />
                <br />
                <br />
                <div style="z-index: 102; left: 119px; width: 552px; position: absolute; top: 156px;
                    height: 1px; background-color: #333399">
                </div>
                &nbsp;
                <div style="z-index: 101; left: 120px; width: 543px; position: absolute; top: 178px;
                    height: 181px; background-color: #f2f7fe; border-top-style: solid; border-top-color: #333399;
                    border-bottom: thin double; border-right-style: double; border-left-style: double;">
                    <br />
                    <div style="z-index: 103; left: 2px; width: 169px; position: absolute; top: 4px;
                        height: 53px">
                        <asp:Image ID="Image1" runat="server" ImageUrl="~/App_Themes/CCL/Imagens/logo_CCL800x600.gif" />
                    </div>
                    <br />
                    <div style="z-index: 102; left: 1px; width: 171px; position: absolute; top: 63px;
                        height: 56px">
                        <strong><span style="font-size: 12pt; color: #333399"><span style="font-size: 10pt">
                            <span style="font-size: 11pt">Bem vindo ao sistema
                                <br />
                            </span>
                            <asp:Label ID="lblNomeSistema" runat="server" Font-Bold="True" Font-Italic="True"
                                ForeColor="Red" Height="4px" Style="padding-top: 5px" Font-Size="Medium"></asp:Label></span></span></strong>
                    </div>
                </div>
                <br />
                <br />
                <br />
                &nbsp;</asp:Panel>
            &nbsp; &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </div>
    </div>
    </form>
</body>
</html>
