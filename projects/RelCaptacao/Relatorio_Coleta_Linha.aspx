<%@ Page language="c#" Codebehind="Relatorio_Coleta_Linha.aspx.cs" AutoEventWireup="false" Inherits="RelCaptacao.Relatorio_Coleta_Linha" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Relatorio_Coleta_Linha</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
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
			<asp:TextBox id="txtDt" style="Z-INDEX: 101; LEFT: 176px; POSITION: absolute; TOP: 232px" runat="server"
				Width="88px" onKeyPress="javascript:FormataData(this);" MaxLength="10"></asp:TextBox>
			<asp:Label id="Label1" style="Z-INDEX: 102; LEFT: 24px; POSITION: absolute; TOP: 16px" runat="server"
				Font-Size="X-Large" Font-Bold="True" ForeColor="#003B72" Height="32px" Width="436px">Relatório de Coleta por Linhas</asp:Label>
			<asp:DropDownList id="ddlRegiao" style="Z-INDEX: 103; LEFT: 176px; POSITION: absolute; TOP: 136px"
				runat="server" Width="288px" AutoPostBack="True">
				<asp:ListItem Value="null" Selected="True">Selecione</asp:ListItem>
			</asp:DropDownList>
			<asp:DropDownList id="ddlLinha" style="Z-INDEX: 104; LEFT: 176px; POSITION: absolute; TOP: 184px"
				runat="server" Width="288px">
				<asp:ListItem Value="null" Selected="True">Selecione</asp:ListItem>
			</asp:DropDownList>
			<asp:Label id="Label2" style="Z-INDEX: 105; LEFT: 80px; POSITION: absolute; TOP: 136px" runat="server"
				Height="24px" Width="80px">Região:</asp:Label>
			<asp:Label id="Label3" style="Z-INDEX: 106; LEFT: 80px; POSITION: absolute; TOP: 184px" runat="server">Linha:</asp:Label>
			<asp:Label id="Label4" style="Z-INDEX: 107; LEFT: 80px; POSITION: absolute; TOP: 232px" runat="server">Data:</asp:Label>
			<asp:Button id="btRelatorio" style="Z-INDEX: 108; LEFT: 280px; POSITION: absolute; TOP: 288px"
				runat="server" Text="Relatório"></asp:Button></form>
	</body>
</HTML>
