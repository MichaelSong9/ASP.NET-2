<%@ Page Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeFile="Relatorio.aspx.cs" Inherits="Relatorio" Title="Untitled Page" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=10.2.3600.0, Culture=neutral, PublicKeyToken=692fbea5521e1304"
    Namespace="CrystalDecisions.Web" TagPrefix="CR" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    <table>
        <tr>
            <td style="width: 78px; background-color: #f7f7f7">
                <asp:Label ID="Label5" runat="server" Text="Período"></asp:Label></td>
            <td style="width: 77px; background-color: #f7f7f7">
                <asp:DropDownList ID="ddlPeriodo" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlPeriodo_SelectedIndexChanged"
                    Width="350px">
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td style="width: 78px; background-color: #f7f7f7">
                <asp:Label ID="lblRegiao" runat="server" Text="Região"></asp:Label></td>
            <td style="width: 77px; background-color: #f7f7f7">
                <asp:DropDownList ID="ddlRegiao" runat="server" Width="350px" OnSelectedIndexChanged="ddlRegiao_SelectedIndexChanged" AutoPostBack="True">
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td style="width: 78px; background-color: #f7f7f7">
                <asp:Label ID="lblCooperativa" runat="server" Text="Cooperativa"></asp:Label></td>
            <td style="width: 77px; background-color: #f7f7f7">
                <asp:DropDownList ID="ddlCooperativa" runat="server" Width="350px" AutoPostBack="True" OnSelectedIndexChanged="ddlCooperativa_SelectedIndexChanged">
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td style="width: 78px; background-color: #f7f7f7">
                <asp:Label ID="Label2" runat="server" Text="Propriedade"></asp:Label></td>
            <td style="width: 77px; background-color: #f7f7f7">
                <asp:DropDownList ID="ddlPropriedade" runat="server" Width="350px" AutoPostBack="True">
                </asp:DropDownList></td>
        </tr>
    </table>
    <table>
        <tr>
            <td style="width: 76px; background-color: #f7f7f7">
                <asp:Label ID="lblDt_Inicio" runat="server" Text="Data Inicial"></asp:Label></td>
            <td style="width: 100px; background-color: #f7f7f7">
                <asp:TextBox ID="txtDataInicial" runat="server" Width="100px"></asp:TextBox></td>
            <td style="width: 242px; background-color: #f7f7f7">
                <asp:ImageButton ID="imbDataInicial" runat="server" ImageUrl="~/App_Themes/images/calendario.jpg" />
                <cc1:MaskedEditValidator ID="MaskedEditValidator1" runat="server" ControlExtender="MaskedEditExtender1"
                    ControlToValidate="txtDataInicial" ErrorMessage="*" InvalidValueBlurredMessage="*"
                    InvalidValueMessage="Data Inválida" SetFocusOnError="True"></cc1:MaskedEditValidator></td>
        </tr>
        <tr>
            <td style="width: 76px; background-color: #f7f7f7">
                <asp:Label ID="lblDt_Final" runat="server" Text="Data Final"></asp:Label></td>
            <td style="width: 100px; background-color: #f7f7f7">
                <asp:TextBox ID="txtDataFinal" runat="server" Width="100px"></asp:TextBox></td>
            <td style="width: 242px; background-color: #f7f7f7">
                <asp:ImageButton ID="imbDataFinal" runat="server" ImageUrl="~/App_Themes/images/calendario.jpg" />
                <cc1:MaskedEditValidator ID="MaskedEditValidator2" runat="server" ControlExtender="MaskedEditExtender1"
                    ControlToValidate="txtDataFinal" ErrorMessage="*" InvalidValueBlurredMessage="*"
                    InvalidValueMessage="Data Inválida" SetFocusOnError="True"></cc1:MaskedEditValidator></td>
        </tr>
        <tr>
            <td style="width: 76px; height: 6px; background-color: #f7f7f7">
                <asp:Label ID="Label3" runat="server" Text="Tipo"></asp:Label></td>
            <td colspan="2" style="height: 6px; background-color: #f7f7f7">
                <asp:RadioButtonList ID="rbTipoRelatorio" runat="server" Height="10px" RepeatDirection="Horizontal">
                    <asp:ListItem Value="A">Anal&#237;tico</asp:ListItem>
                    <asp:ListItem Value="S">Sint&#233;tico</asp:ListItem>
                </asp:RadioButtonList></td>
        </tr>
    </table>
    <br />
            <table>
                <tr>
                    <td style="width: 100px">
    <asp:Button ID="btnGerarRelatorio" runat="server" OnClick="btnGerarRelatorio_Click" Text="Criar Relatório"
        Width="160px" CausesValidation="True" /></td>
                    <td style="width: 100px">
    <asp:Button ID="btnLiberarPgto" runat="server" OnClick="btnLiberarPgto_Click" Text="Liberar Pagamento"
        Width="160px" /></td>
                </tr>
            </table>
    <div style="z-index: 101; left: 620px; width: 184px; position: absolute; top: 306px;
        height: 96px">
        <cc1:calendarextender id="CalendarExtender1" runat="server" format="dd/MM/yyyy" popupbuttonid="imbDataInicial"
            targetcontrolid="txtDataInicial">
        </cc1:calendarextender>
        <cc1:calendarextender id="CalendarExtender2" runat="server" format="dd/MM/yyyy" popupbuttonid="imbDataFinal"
            targetcontrolid="txtDataFinal">
        </cc1:calendarextender>
        <cc1:maskededitextender id="MaskedEditExtender1" runat="server" cultureampmplaceholder=""
            culturecurrencysymbolplaceholder="R$ " culturedateformat="DMY" culturedateplaceholder="/"
            culturedecimalplaceholder="," culturename="pt-BR" culturethousandsplaceholder="."
            culturetimeplaceholder=":" enabled="True" errortooltipenabled="True" mask="99/99/9999"
            masktype="Date" targetcontrolid="txtDataInicial">
        </cc1:maskededitextender>
        <cc1:maskededitextender id="MaskedEditExtender2" runat="server" cultureampmplaceholder=""
            culturecurrencysymbolplaceholder="R$ " culturedateformat="DMY" culturedateplaceholder="/"
            culturedecimalplaceholder="," culturename="pt-BR" culturethousandsplaceholder="."
            culturetimeplaceholder=":" enabled="True" errortooltipenabled="True" mask="99/99/9999"
            masktype="Date" targetcontrolid="txtDataFinal">
        </cc1:maskededitextender>
        <cc1:ConfirmButtonExtender 
          ID="cbe" 
          runat="server" 
          TargetControlID="btnLiberarPgto"
          ConfirmText="Deseja liberar os pagamentos?">
        </cc1:ConfirmButtonExtender>
    </div>
</asp:Content>