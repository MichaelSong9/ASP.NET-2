<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Teste.aspx.vb" Inherits="Teste" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>
            Controle WIZARD</h1>
        <p>
            &nbsp;</p>
        <p>
            <asp:Wizard ID="Wizard1" runat="server" ActiveStepIndex="2" BackColor="#EFF3FB" BorderColor="#B5C7DE"
                BorderWidth="1px" FinishCompleteButtonText="Finalizar" FinishPreviousButtonText="Voltar"
                Font-Names="Verdana" Font-Size="0.8em" Height="204px" StartNextButtonText="Avançar >>"
                StepNextButtonText="Avançar" StepPreviousButtonText="Voltar">
                <StepNextButtonStyle Width="100px" />
                <StepStyle Font-Size="0.8em" ForeColor="#333333" Width="400px" />
                <SideBarStyle BackColor="#507CD1" Font-Size="0.9em" VerticalAlign="Top" Width="200px" />
                <NavigationButtonStyle BackColor="White" BorderColor="#507CD1" BorderStyle="Solid"
                    BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284E98" />
                <WizardSteps>
                    <asp:WizardStep runat="server" Title="Ficha de Cadastro">
                        <asp:Panel ID="Panel1" runat="server" Height="162px" Width="296px">
                            <br />
                            <br />
                            &nbsp; NOME &nbsp; &nbsp;<br />
                            &nbsp;
                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                            <br />
                            <br />
                            &nbsp; TELEFONE<br />
                            &nbsp;
                            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                        </asp:Panel>
                    </asp:WizardStep>
                    <asp:WizardStep runat="server" Title="Endere&#231;o Comercial">
                        <asp:Panel ID="Panel2" runat="server" Height="142px" Width="310px">
                            <br />
                            &nbsp;&nbsp;
                            <br />
                            &nbsp; &nbsp; ENDERECO<br />
                            &nbsp; &nbsp;
                            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                            <br />
                            <br />
                            &nbsp; &nbsp; CIDADE<br />
                            &nbsp; &nbsp;
                            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                        </asp:Panel>
                    </asp:WizardStep>
                    <asp:WizardStep runat="server" Title="Finalizar">
                        &nbsp; &nbsp; &nbsp;CLIQUE EM FINALIZAR PARA
                        <br />
                        &nbsp; &nbsp;&nbsp; COMPLETAR O CADASTRO</asp:WizardStep>
                </WizardSteps>
                <SideBarButtonStyle BackColor="#507CD1" Font-Names="Verdana" ForeColor="White" />
                <HeaderStyle BackColor="#284E98" BorderColor="#EFF3FB" BorderStyle="Solid" BorderWidth="2px"
                    Font-Bold="True" Font-Size="0.9em" ForeColor="White" HorizontalAlign="Center" />
                <StepPreviousButtonStyle Width="100px" />
            </asp:Wizard>
            &nbsp;</p>
    
    </div>
    </form>
</body>
</html>
