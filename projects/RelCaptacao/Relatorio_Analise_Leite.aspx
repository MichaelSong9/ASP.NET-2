<%@ Page language="c#" Codebehind="Relatorio_Analise_Leite.aspx.cs" AutoEventWireup="false" Inherits="RelCaptacao.Relatorio_Analise_Leite" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Relatorio_Coleta_Associada</title>
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
	<body background="image/FUNDO_800_600.gif" MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:label id="lblMsn" style="Z-INDEX: 112; LEFT: 328px; POSITION: absolute; TOP: 360px" runat="server"
				ForeColor="Red" Visible="False"></asp:label>
			<asp:DropDownList id="ddlAno" style="Z-INDEX: 118; LEFT: 408px; POSITION: absolute; TOP: 264px" runat="server"
				Width="72px">
				<asp:ListItem Value="null" Selected="True">Selecione</asp:ListItem>
				<asp:ListItem Value="2004">2004</asp:ListItem>
				<asp:ListItem Value="2005">2005</asp:ListItem>
				<asp:ListItem Value="2006">2006</asp:ListItem>
				<asp:ListItem Value="2007">2007</asp:ListItem>
				<asp:ListItem Value="2008">2008</asp:ListItem>
				<asp:ListItem Value="2009">2009</asp:ListItem>
				<asp:ListItem Value="2010">2010</asp:ListItem>
				<asp:ListItem Value="2011">2011</asp:ListItem>
				<asp:ListItem Value="2012">2012</asp:ListItem>
				<asp:ListItem Value="2013">2013</asp:ListItem>
				<asp:ListItem Value="2014">2014</asp:ListItem>
				<asp:ListItem Value="2015">2015</asp:ListItem>
				<asp:ListItem Value="2016">2016</asp:ListItem>
				<asp:ListItem Value="2017">2017</asp:ListItem>
				<asp:ListItem Value="2018">2018</asp:ListItem>
				<asp:ListItem Value="2019">2019</asp:ListItem>
				<asp:ListItem Value="2020">2020</asp:ListItem>
			</asp:DropDownList>
			<asp:DropDownList id="ddlMes" style="Z-INDEX: 117; LEFT: 240px; POSITION: absolute; TOP: 264px" runat="server"
				Width="72px">
				<asp:ListItem Value="null" Selected="True">Selecione</asp:ListItem>
				<asp:ListItem Value="01">Jan</asp:ListItem>
				<asp:ListItem Value="02">Fev</asp:ListItem>
				<asp:ListItem Value="03">Mar</asp:ListItem>
				<asp:ListItem Value="04">Abr</asp:ListItem>
				<asp:ListItem Value="05">Mai</asp:ListItem>
				<asp:ListItem Value="06">Jun</asp:ListItem>
				<asp:ListItem Value="07">Jul</asp:ListItem>
				<asp:ListItem Value="08">Ago</asp:ListItem>
				<asp:ListItem Value="09">Set</asp:ListItem>
				<asp:ListItem Value="10">Out</asp:ListItem>
				<asp:ListItem Value="11">Nov</asp:ListItem>
				<asp:ListItem Value="12">Dez</asp:ListItem>
			</asp:DropDownList><asp:label id="lblDtIni" style="Z-INDEX: 111; LEFT: 112px; POSITION: absolute; TOP: 263px"
				runat="server" Width="32px" Height="24px"> Mês:</asp:label><asp:label id="lblDtFim" style="Z-INDEX: 105; LEFT: 368px; POSITION: absolute; TOP: 263px"
				runat="server" Width="24px" Height="24px">Ano:</asp:label><asp:dropdownlist id="ddlProd" style="Z-INDEX: 110; LEFT: 240px; POSITION: absolute; TOP: 232px" tabIndex="5"
				runat="server" Width="288px">
				<asp:ListItem Value="null" Selected="True">Selecione</asp:ListItem>
			</asp:dropdownlist><asp:label id="lblProd" style="Z-INDEX: 109; LEFT: 112px; POSITION: absolute; TOP: 232px" runat="server"
				Width="80px" Height="24px">Produtor:</asp:label><asp:dropdownlist id="ddlRegiao" style="Z-INDEX: 100; LEFT: 240px; POSITION: absolute; TOP: 136px"
				runat="server" Width="288px" AutoPostBack="True">
				<asp:ListItem Value="null">Selecione</asp:ListItem>
			</asp:dropdownlist><asp:dropdownlist id="ddlCoop" style="Z-INDEX: 101; LEFT: 240px; POSITION: absolute; TOP: 168px" tabIndex="1"
				runat="server" Width="376px" AutoPostBack="True">
				<asp:ListItem Value="null" Selected="True">Selecione</asp:ListItem>
			</asp:dropdownlist><asp:label id="Label1" style="Z-INDEX: 102; LEFT: 40px; POSITION: absolute; TOP: 16px" runat="server"
				ForeColor="#003B72" Width="373px" Height="24px" Font-Size="X-Large" Font-Bold="True"> Relatório Análise de Leite</asp:label><asp:label id="lblRegiao" style="Z-INDEX: 103; LEFT: 112px; POSITION: absolute; TOP: 136px"
				runat="server" Width="48px" Height="24px">Região:</asp:label><asp:label id="lblCoop" style="Z-INDEX: 104; LEFT: 112px; POSITION: absolute; TOP: 168px" runat="server"
				Width="80px" Height="24px">Cooperativa:</asp:label><asp:label id="lblOrdProd" style="Z-INDEX: 106; LEFT: 112px; POSITION: absolute; TOP: 200px"
				runat="server" Width="128px" Height="24px"> Tipo de Ordenação:</asp:label><asp:button id="btRelatorio" style="Z-INDEX: 107; LEFT: 320px; POSITION: absolute; TOP: 328px"
				tabIndex="8" runat="server" Text="Relatório"></asp:button><asp:radiobutton id="rdNome" style="Z-INDEX: 113; LEFT: 248px; POSITION: absolute; TOP: 200px" tabIndex="2"
				runat="server" Visible="False" AutoPostBack="True" Text="Nome"></asp:radiobutton><asp:radiobutton id="rdMK" style="Z-INDEX: 114; LEFT: 360px; POSITION: absolute; TOP: 200px" tabIndex="3"
				runat="server" Visible="False" AutoPostBack="True" Text="Cód. MK"></asp:radiobutton><asp:radiobutton id="rdCap" style="Z-INDEX: 115; LEFT: 496px; POSITION: absolute; TOP: 200px" tabIndex="4"
				runat="server" Visible="False" AutoPostBack="True" Text="Cód. Captação"></asp:radiobutton><asp:button id="btAtuaAnal" style="Z-INDEX: 116; LEFT: 280px; POSITION: absolute; TOP: 304px"
				tabIndex="8" runat="server" Width="184px" Text="Atualizar Dados Analise"></asp:button></form>
	</body>
</HTML>
