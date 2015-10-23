<%@ Register TagPrefix="cr" Namespace="CrystalDecisions.Web" Assembly="CrystalDecisions.Web, Version=9.1.5000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" %>
<%@ Page language="c#" Codebehind="Relatorio_Boletim_Captacao.aspx.cs" AutoEventWireup="false" Inherits="Relatorio_Captacao.WebForm1" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>WebForm1</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" style="Z-INDEX: 101; LEFT: 16px; WIDTH: 348px; POSITION: absolute; TOP: 16px; HEIGHT: 168px"
				cellSpacing="1" cellPadding="1" width="348" border="1">
				<TR>
					<TD></TD>
					<TD>
						<asp:Button id="Button1" runat="server" Width="136px" Text="Imprimir Relatório"></asp:Button></TD>
					<TD></TD>
				</TR>
				<TR>
					<TD></TD>
					<TD>
						<CR:CRYSTALREPORTVIEWER id="CrystalReportViewer1" runat="server" Height="50px" Width="350px"></CR:CRYSTALREPORTVIEWER></TD>
					<TD></TD>
				</TR>
				<TR>
					<TD></TD>
					<TD></TD>
					<TD></TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
