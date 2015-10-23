<%@ Page language="c#" Codebehind="Inicial.aspx.cs" AutoEventWireup="false" Inherits="RelCaptacao.WebForm1" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>WebForm1</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body background="image/FUNDO_800_600.gif" MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:label id="Label1" style="Z-INDEX: 100; LEFT: 24px; POSITION: absolute; TOP: 24px" runat="server"
				Width="472px" Font-Bold="True" Font-Size="X-Large" ForeColor="#003B72">Relatórios Administrativos</asp:label>
			<asp:radiobutton id="rdbRelContFornLeite" style="Z-INDEX: 105; LEFT: 72px; POSITION: absolute; TOP: 288px"
				runat="server" AutoPostBack="True" Text="Relatório de Controle de Fornecimento de Leite" Font-Italic="True"></asp:radiobutton>
			<asp:radiobutton id="rdbRelConfLinha" style="Z-INDEX: 104; LEFT: 72px; POSITION: absolute; TOP: 240px"
				runat="server" Text="Relatório de Conferência de Linha" AutoPostBack="True" Font-Italic="True"></asp:radiobutton><asp:radiobutton id="rdbRelColAss" style="Z-INDEX: 101; LEFT: 72px; POSITION: absolute; TOP: 144px"
				runat="server" AutoPostBack="True" Text="Relatório de Coleta para Associadas" Font-Italic="True"></asp:radiobutton><asp:radiobutton id="rdbRelColLinha" style="Z-INDEX: 102; LEFT: 72px; POSITION: absolute; TOP: 192px"
				runat="server" AutoPostBack="True" Text="Relatório de Coleta por Linha" Font-Italic="True"></asp:radiobutton></form>
	</body>
</HTML>
