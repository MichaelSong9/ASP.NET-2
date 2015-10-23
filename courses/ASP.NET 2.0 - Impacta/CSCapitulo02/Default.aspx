<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Curso ASP.NET </h1>
        <h2>Capitulo 02 - Controles de Servidor</h2>
        <p>
            <asp:Panel ID="Panel1" runat="server" Height="170px" Width="355px">
                <br />
                &nbsp; Este é um painel<br />
                <br />
                &nbsp; Clique no botao OK:<br />
                <br />
                &nbsp;
                <asp:Button ID="Button1" runat="server" CausesValidation="False" OnClick="Button1_Click"
                    Text="OK" Width="67px" /></asp:Panel>
            &nbsp;</p>
        <p>
            <asp:Panel ID="Panel2" runat="server" Height="77px" Visible="False" Width="432px">
                <h2>
                    Obrigado pelo seu cadastro</h2>
                <p>
                    <asp:Button ID="Button2" runat="server" CausesValidation="False" OnClick="Button2_Click"
                        Text="Voltar" Width="67px" />&nbsp;</p>
            </asp:Panel>
            &nbsp;</p>
        <p>
            Escolha uma cidade
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"
                Width="182px">
                <asp:ListItem Value="10290">S&#227;o Paulo</asp:ListItem>
                <asp:ListItem Selected="True" Value="746237">Rio de janeiro</asp:ListItem>
            </asp:DropDownList></p>
        <p>
            <asp:ListBox ID="ListBox1" runat="server" Height="65px" SelectionMode="Multiple"
                Width="305px">
                <asp:ListItem>A</asp:ListItem>
                <asp:ListItem>B</asp:ListItem>
                <asp:ListItem>C</asp:ListItem>
                <asp:ListItem></asp:ListItem>
                <asp:ListItem></asp:ListItem>
            </asp:ListBox>&nbsp;</p>
        <p>
            <asp:CheckBoxList ID="CheckBoxList1" runat="server" RepeatColumns="3" Width="367px">
                <asp:ListItem>Sao paulo</asp:ListItem>
                <asp:ListItem>Rio de janeiro</asp:ListItem>
                <asp:ListItem>Santos</asp:ListItem>
                <asp:ListItem>AAAA</asp:ListItem>
                <asp:ListItem>BBBBB</asp:ListItem>
                <asp:ListItem>CCCCC</asp:ListItem>
            </asp:CheckBoxList>&nbsp;</p>
        <p>
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatColumns="2">
                <asp:ListItem>AAAAA</asp:ListItem>
                <asp:ListItem>BBBBBB</asp:ListItem>
                <asp:ListItem>CCCCCC</asp:ListItem>
                <asp:ListItem>DDDDD</asp:ListItem>
            </asp:RadioButtonList>&nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:ImageButton ID="testeImageButton" runat="server" CausesValidation="False" ImageUrl="~/imagens/AreaDoAluno.jpg"
                OnClick="testeImageButton_Click" />
        </p>
        <p>
            <asp:LinkButton ID="ajudaLinkButton" runat="server" CausesValidation="False" OnClick="ajudaLinkButton_Click">Clique aqui para ajuda</asp:LinkButton>
            &nbsp;&nbsp;
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="http://www.uol.com.br"
                Target="_blank">Clique aqui para noticias</asp:HyperLink></p>
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
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        
        
        
        
       
    
    </div>
    </form>
</body>
</html>
