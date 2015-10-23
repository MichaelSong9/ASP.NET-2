<%@ Page language="c#" Codebehind="Relatorio_Cadastro_Produtores.aspx.cs" AutoEventWireup="false" Inherits="RelCaptacao.Relatorio_Cadastro_de_Produtores" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Relatorio_Coleta_Associada</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<script>
	function FormataData( sData )
	{    var tam = sData.value.length;
		if (((event.keyCode) >= 44 ) && ((event.keyCode) <= 57 )) 
		{    event.keyCode;
			if ( ( tam == 2 ) || ( tam == 5 ) )
			{    sData.value = sData.value + "/";    }
		}
		else
		{    event.keyCode = 0;    }
	}
		</script>
	</HEAD>
	<body MS_POSITIONING="GridLayout" background="image/FUNDO_800_600.gif">
		<form id="Form1" method="post" runat="server">
			<asp:DropDownList id="ddlAtiv" style="Z-INDEX: 109; LEFT: 216px; POSITION: absolute; TOP: 200px" runat="server"
				Width="88px">
				<asp:ListItem Value="null" Selected="True">Selecione</asp:ListItem>
				<asp:ListItem Value="S">SIM</asp:ListItem>
				<asp:ListItem Value="N">NÃO</asp:ListItem>
				<asp:ListItem Value="A">AMBOS</asp:ListItem>
			</asp:DropDownList>
			<asp:DropDownList id="ddlOrd" style="Z-INDEX: 110; LEFT: 216px; POSITION: absolute; TOP: 232px" runat="server"
				Width="200px" AutoPostBack="True">
				<asp:ListItem Value="null" Selected="True">Selecione</asp:ListItem>
				<asp:ListItem Value="CODIGO DA CAPTACAO">CÓDIGO DA CAPTAÇÃO</asp:ListItem>
				<asp:ListItem Value="CODIGO DA COOPERATIVA">CÓDIGO DA COOPERATIVA</asp:ListItem>
				<asp:ListItem Value="NOME">NOME</asp:ListItem>
			</asp:DropDownList>
			<asp:Label id="lblAtiv" style="Z-INDEX: 107; LEFT: 96px; POSITION: absolute; TOP: 200px" runat="server"
				Width="64px" Height="24px">Atividade:</asp:Label>
			<asp:DropDownList id="ddlRegiao" style="Z-INDEX: 100; LEFT: 216px; POSITION: absolute; TOP: 136px"
				runat="server" Width="288px" AutoPostBack="True">
				<asp:ListItem Value="null">Selecione</asp:ListItem>
			</asp:DropDownList>
			<asp:DropDownList id="ddlCoop" style="Z-INDEX: 101; LEFT: 216px; POSITION: absolute; TOP: 168px" runat="server"
				Width="288px">
				<asp:ListItem Value="null" Selected="True">Selecione</asp:ListItem>
			</asp:DropDownList>
			<asp:Label id="Label1" style="Z-INDEX: 102; LEFT: 24px; POSITION: absolute; TOP: 16px" runat="server"
				Width="494px" Height="24px" ForeColor="#003B72" Font-Bold="True" Font-Size="X-Large"> Relatório Cadastro de Produtores</asp:Label>
			<asp:Label id="lblRegiao" style="Z-INDEX: 103; LEFT: 96px; POSITION: absolute; TOP: 136px"
				runat="server" Width="48px" Height="24px">Região:</asp:Label>
			<asp:Label id="lblCoop" style="Z-INDEX: 104; LEFT: 96px; POSITION: absolute; TOP: 168px" runat="server"
				Width="80px" Height="24px">Cooperativa:</asp:Label>
			<asp:Label id="lblOrd" style="Z-INDEX: 105; LEFT: 96px; POSITION: absolute; TOP: 232px" runat="server"
				Width="72px" Height="24px"> Ordenação:</asp:Label>
			<asp:Button id="btRelatorio" style="Z-INDEX: 106; LEFT: 320px; POSITION: absolute; TOP: 328px"
				runat="server" Text="Relatório"></asp:Button>
		</form>
	</body>
</HTML>
