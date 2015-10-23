<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Validacao.aspx.cs" Inherits="Validacao" %>

<%@ Register Src="Rodape.ascx" TagName="Rodape" TagPrefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
     
     <script type="text/javascript">
         function ValidarNome(source, args)
         {
                if(args.Value=='maria')
               {
                  args.IsValid=false;
               } 
               else
               {
                  args.IsValid=true;
               }
         }
         
     </script>
    
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>
            Exemplos de Validacao</h2>
        <p>
            Digite o seu nome<br />
            <asp:TextBox ID="nomeTextBox" runat="server" Width="211px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="nomeTextBox"
                ErrorMessage="É necessário digitar o nome" SetFocusOnError="True" Display="Dynamic"></asp:RequiredFieldValidator>
            <asp:CustomValidator ID="CustomValidator1" runat="server" ClientValidationFunction="ValidarNome"
                ControlToValidate="nomeTextBox" ErrorMessage="Esse  nome já existe" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator><br />
            <br />
            Digite a sua Data de Nascimento<br />
            <asp:TextBox ID="dataTextBox" runat="server" Width="202px"></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="dataTextBox"
                Display="Dynamic" ErrorMessage="Data Inválida" Operator="DataTypeCheck" SetFocusOnError="True"
                Type="Date"></asp:CompareValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="dataTextBox"
                ErrorMessage="Digite a data"></asp:RequiredFieldValidator></p>
        <p>
            Salário pretendido<br />
            <asp:TextBox ID="salarioTextBox" runat="server"></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToValidate="salarioTextBox"
                ErrorMessage="Salário inválido" Operator="DataTypeCheck" Type="Currency"></asp:CompareValidator></p>
        <p>
            Comissao (%) &nbsp;(1 - 100)<br />
            <asp:TextBox ID="comissaoTextBox" runat="server" Width="133px"></asp:TextBox>
            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="comissaoTextBox"
                ErrorMessage="Digite um numero entre 1 e 100" MaximumValue="100" MinimumValue="1"
                Type="Integer"></asp:RangeValidator></p>
        <p>
            Digite seu email<br />
            <asp:TextBox ID="emailTextBox" runat="server" Width="203px"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="emailTextBox"
                ErrorMessage="Email Invalido" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator></p>
        <p>
            <asp:Button ID="confirmarButton" runat="server" Text="Confirmar" OnClick="confirmarButton_Click" />&nbsp;<asp:Label
                ID="mensagemLabel" runat="server"></asp:Label></p>
        <p>
            <uc1:Rodape ID="Rodape1" runat="server" Mensagem="Curso de ASP.NET" />
            &nbsp;</p>
    
    </div>
    </form>
</body>
</html>
