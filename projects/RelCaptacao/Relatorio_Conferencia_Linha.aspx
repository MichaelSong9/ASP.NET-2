<%@ Page language="c#" Codebehind="Relatorio_Conferencia_Linha.aspx.cs" AutoEventWireup="false" Inherits="RelCaptacao.Relatorio_Conferencia_Linha" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Relatorio_Conferencia_Linha</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="GridLayout" background="image/FUNDO_800_600.gif">
		<form id="Form1" method="post" runat="server">
			<asp:Label id="Label1" style="Z-INDEX: 101; LEFT: 24px; POSITION: absolute; TOP: 16px" runat="server"
				Font-Size="X-Large" Font-Bold="True" ForeColor="#003B72" Height="32px" Width="480px">Relatório de Conferência de Linha</asp:Label>
			<asp:Label id="Label4" style="Z-INDEX: 108; LEFT: 80px; POSITION: absolute; TOP: 232px" runat="server">Linha Ate:</asp:Label>
			<asp:DropDownList id="ddlLinhaDe" style="Z-INDEX: 104; LEFT: 176px; POSITION: absolute; TOP: 184px"
				runat="server" Width="288px" AutoPostBack="True">
				<asp:ListItem Value="null" Selected="True">Selecione</asp:ListItem>
			</asp:DropDownList>
			<asp:DropDownList id="ddlRegiao" style="Z-INDEX: 102; LEFT: 176px; POSITION: absolute; TOP: 136px"
				runat="server" Width="288px" AutoPostBack="True">
				<asp:ListItem Value="null" Selected="True">Selecione</asp:ListItem>
			</asp:DropDownList>
			<asp:DropDownList id="ddlLinha" style="Z-INDEX: 103; LEFT: 176px; POSITION: absolute; TOP: 184px"
				runat="server" Width="288px">
				<asp:ListItem Value="null" Selected="True">Selecione</asp:ListItem>
			</asp:DropDownList>
			<asp:Label id="Label2" style="Z-INDEX: 105; LEFT: 80px; POSITION: absolute; TOP: 136px" runat="server"
				Height="24px" Width="80px">Região:</asp:Label>
			<asp:Label id="Label3" style="Z-INDEX: 106; LEFT: 80px; POSITION: absolute; TOP: 184px" runat="server">Linha De:</asp:Label>
			<asp:Button id="btRelatorio" style="Z-INDEX: 107; LEFT: 280px; POSITION: absolute; TOP: 288px"
				runat="server" Text="Relatório"></asp:Button>
			<asp:DropDownList id="ddlLinhaAte" style="Z-INDEX: 109; LEFT: 176px; POSITION: absolute; TOP: 232px"
				runat="server" Width="288px" AutoPostBack="True">
				<asp:ListItem Value="null" Selected="True">Selecione</asp:ListItem>
			</asp:DropDownList></form>
	</body>
</HTML>
