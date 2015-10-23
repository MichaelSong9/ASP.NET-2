<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div>
            <h1>
                Curso ASP.NET</h1>
            <p>
                &nbsp;</p>
            <p>
                <asp:LoginView ID="LoginView1" runat="server">
                    <LoggedInTemplate>
                        <asp:Panel ID="Panel2" runat="server" Height="102px" Width="437px">
                            <br />
                            <br />
                            &nbsp; &nbsp; &nbsp;
                Bem vindo ao site,&nbsp;
                            <asp:LoginName ID="LoginName1" runat="server" />
                        </asp:Panel>
                    </LoggedInTemplate>
                    <AnonymousTemplate>
                        <asp:Panel ID="Panel1" runat="server" Height="108px" Width="332px">
                            Bem vindo ao site.<br />
                            <br />
                            Para acesso a todo o conteudo, faça o login.</asp:Panel>
                    </AnonymousTemplate>
                </asp:LoginView>
                &nbsp;</p>
            <p>
                <asp:LoginStatus ID="LoginStatus1" runat="server" />
                &nbsp;</p>
            <p>
                &nbsp;</p>
            <p>
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/admin/Default.aspx">Clique aqui para acesso a área administrativa</asp:HyperLink>&nbsp;</p>
        </div>
    
    </div>
    </form>
</body>
</html>
