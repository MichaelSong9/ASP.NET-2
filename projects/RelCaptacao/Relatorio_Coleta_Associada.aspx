<%@ Page language="c#" Codebehind="Relatorio_Coleta_Associada.aspx.cs" AutoEventWireup="false" Inherits="RelCaptacao.Relatorio_Coleta_Associada" %>
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
			<asp:TextBox id="txtDtIni" style="Z-INDEX: 101; LEFT: 216px; POSITION: absolute; TOP: 200px"
				runat="server" Width="96px" onKeyPress="javascript:FormataData(this);" MaxLength="10"></asp:TextBox>
			<asp:DropDownList id="ddlRegiao" style="Z-INDEX: 102; LEFT: 216px; POSITION: absolute; TOP: 120px"
				runat="server" Width="288px" AutoPostBack="True">
				<asp:ListItem Value="null">Selecione</asp:ListItem>
			</asp:DropDownList>
			<asp:DropDownList id="ddlCoop" style="Z-INDEX: 103; LEFT: 216px; POSITION: absolute; TOP: 160px" runat="server"
				Width="288px">
				<asp:ListItem Value="null" Selected="True">Selecione</asp:ListItem>
			</asp:DropDownList>
			<asp:Label id="Label1" style="Z-INDEX: 104; LEFT: 24px; POSITION: absolute; TOP: 16px" runat="server"
				Width="494px" Height="24px" ForeColor="#003B72" Font-Bold="True" Font-Size="X-Large">Relatório de Coleta para Associadas</asp:Label>
			<asp:TextBox id="txtDtFim" style="Z-INDEX: 105; LEFT: 408px; POSITION: absolute; TOP: 200px"
				runat="server" Width="96px" onKeyPress="javascript:FormataData(this);" MaxLength="10"></asp:TextBox>
			<asp:Label id="Label2" style="Z-INDEX: 106; LEFT: 352px; POSITION: absolute; TOP: 200px" runat="server"
				Width="24px" Height="24px">Até</asp:Label>
			<asp:Label id="Label3" style="Z-INDEX: 107; LEFT: 96px; POSITION: absolute; TOP: 120px" runat="server"
				Width="112px" Height="24px">Região:</asp:Label>
			<asp:Label id="Label4" style="Z-INDEX: 108; LEFT: 96px; POSITION: absolute; TOP: 160px" runat="server"
				Width="96px" Height="24px">Cooperativa:</asp:Label>
			<asp:Label id="Label5" style="Z-INDEX: 109; LEFT: 96px; POSITION: absolute; TOP: 200px" runat="server"
				Width="104px" Height="24px">Período De:</asp:Label>
			<asp:Button id="btRelatorio" style="Z-INDEX: 110; LEFT: 320px; POSITION: absolute; TOP: 264px"
				runat="server" Text="Relatório"></asp:Button>
		</form>
	</body>
</HTML>
