<%@ Page language="c#" Codebehind="Relatorio_Cont_Fornec_Leite.aspx.cs" AutoEventWireup="false" Inherits="RelCaptacao.Relatorio_Cont_Fornec_Leite" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Relatorio_Cont_Fornec_Leite</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="GridLayout" background="image/FUNDO_800_600.gif">
		<form id="Form1" method="post" runat="server">
			<asp:label id="Label1" style="Z-INDEX: 101; LEFT: 16px; POSITION: absolute; TOP: 16px" runat="server"
				Font-Size="X-Large" Font-Bold="True" ForeColor="#003B72" Height="32px" Width="664px">Relatório de Controle de Fornecimento de Leite</asp:label>
			<asp:DropDownList id="ddlAno" style="Z-INDEX: 109; LEFT: 200px; POSITION: absolute; TOP: 264px" runat="server"
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
			<asp:DropDownList id="ddlMes" style="Z-INDEX: 108; LEFT: 200px; POSITION: absolute; TOP: 208px" runat="server"
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
			</asp:DropDownList><asp:label id="Label5" style="Z-INDEX: 104; LEFT: 120px; POSITION: absolute; TOP: 168px" runat="server"
				Height="24px" Width="72px">Linha:</asp:label><asp:label id="Label2" style="Z-INDEX: 102; LEFT: 120px; POSITION: absolute; TOP: 120px" runat="server"
				Height="24px" Width="72px">Região:</asp:label><asp:dropdownlist id="ddlRegiao" style="Z-INDEX: 103; LEFT: 200px; POSITION: absolute; TOP: 120px"
				runat="server" Width="312px" AutoPostBack="True">
				<asp:ListItem Value="null" Selected="True">Selecione</asp:ListItem>
			</asp:dropdownlist>
			<asp:DropDownList id="ddlLinha" style="Z-INDEX: 105; LEFT: 200px; POSITION: absolute; TOP: 168px"
				runat="server" Width="312px">
				<asp:ListItem Value="null" Selected="True">Selecione</asp:ListItem>
			</asp:DropDownList>
			<asp:Label id="Label6" style="Z-INDEX: 106; LEFT: 120px; POSITION: absolute; TOP: 216px" runat="server">Mes:</asp:Label>
			<asp:Label id="Label7" style="Z-INDEX: 107; LEFT: 120px; POSITION: absolute; TOP: 264px" runat="server">Ano:</asp:Label>
			<asp:Button id="btRelatorio" style="Z-INDEX: 110; LEFT: 304px; POSITION: absolute; TOP: 320px"
				runat="server" Width="96px" Text="Relatório"></asp:Button></form>
	</body>
</HTML>
