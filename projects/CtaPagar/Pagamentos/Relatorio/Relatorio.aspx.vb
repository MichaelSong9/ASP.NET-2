Imports System
Imports System.IO
Imports System.Web
Imports System.Data
Imports System.Threading
Imports System.Resources
Imports System.Globalization
Imports System.Configuration
Imports Microsoft.VisualBasic
Imports System.Data.OracleClient
Imports System.Web.Configuration
Imports ConexaoBanco.ConexaoBanco

Partial Class Pagamentos_Relatorio_Relatorio
    Inherits System.Web.UI.Page
    Private sConnectString As String = ConfigurationManager.ConnectionStrings("ConnectionString").ToString()
    Private dtReader As DataTable
    Private dtTable As DataTable
    Private ds As DataSet
    Public Shared arrArquivos As New ArrayList()
    Public seleciona As Boolean

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Page.Title = "Contas a Pagar"
        If IsPostBack = False Then
            txt_FornecedorDe.Focus()
        End If
    End Sub

    Protected Sub imbImprimir_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
        If txt_CNPJAte.Text = "" And txt_CNPJDe.Text = "" And txt_EmissaoAte.Text = "" And txt_EmissaoDe.Text = "" _
        And txt_FornecedorAte.Text = "" And txt_FornecedorDe.Text = "" And txt_LiquidacaoAte.Text = "" _
        And txt_LiquidacaoDe.Text = "" And txt_TituloAte.Text = "" And txt_TituloDe.Text = "" And txt_VencimentoAte.Text = "" _
        And txt_VencimentoDe.Text = "" Then
            ScriptManager.RegisterStartupScript(Page, Page.GetType, "JavaScript", "alert('Preencha algum campo antes de visualizar o arquivo!');", True)
        Else
            Dim sPathLocal = HttpContext.Current.Server.MapPath("Anexos").ToString()
            Dim Buscadados As New clEmail
            Dim Cripta As New clDescriptografa

            sConnectString = Cripta.Descrip(sConnectString, Session("BancodeDados"))
            Thread.CurrentThread.CurrentCulture = New CultureInfo("pt-BR")

            Dim emissao_de As String
            Dim emissao_ate As String
            Dim vencimento_de As String
            Dim vencimento_ate As String
            Dim liq_inicial As String
            Dim liq_final As String
            Dim data_inicial_param As String = "01-Jan-1996"
            Dim data_final_param As String = Date.Now.ToString("dd-MMM-yyyy", New CultureInfo("en-US").DateTimeFormat)

            If txt_EmissaoDe.Text <> "" Then
                emissao_de = Convert.ToDateTime(txt_EmissaoDe.Text).ToString("dd-MMM-yyyy", New CultureInfo("en-US").DateTimeFormat)
            Else
                emissao_de = data_inicial_param
            End If

            If txt_EmissaoAte.Text <> "" Then
                emissao_ate = Convert.ToDateTime(txt_EmissaoAte.Text).ToString("dd-MMM-yyyy", New CultureInfo("en-US").DateTimeFormat)
            Else
                emissao_ate = data_final_param
            End If

            If txt_VencimentoDe.Text <> "" Then
                vencimento_de = Convert.ToDateTime(txt_VencimentoDe.Text).ToString("dd-MMM-yyyy", New CultureInfo("en-US").DateTimeFormat)
            Else
                vencimento_de = data_inicial_param
            End If

            If txt_VencimentoAte.Text <> "" Then
                vencimento_ate = Convert.ToDateTime(txt_VencimentoAte.Text).ToString("dd-MMM-yyyy", New CultureInfo("en-US").DateTimeFormat)
            Else
                vencimento_ate = data_final_param
            End If

            If txt_LiquidacaoDe.Text <> "" Then
                liq_inicial = Convert.ToDateTime(txt_LiquidacaoDe.Text).ToString("dd-MMM-yyyy", New CultureInfo("en-US").DateTimeFormat)
            Else
                liq_inicial = data_inicial_param
            End If

            If txt_LiquidacaoAte.Text <> "" Then
                liq_final = Convert.ToDateTime(txt_LiquidacaoAte.Text).ToString("dd-MMM-yyyy", New CultureInfo("en-US").DateTimeFormat)
            Else
                liq_final = data_final_param
            End If

            If txt_CNPJDe.Text = "" Then
                txt_CNPJDe.Text = "00000000"
            End If

            If txt_CNPJAte.Text = "" Then
                txt_CNPJAte.Text = "99999999"
            End If

            If txt_FornecedorDe.Text = "" Then
                txt_FornecedorDe.Text = "0000000"
            End If

            If txt_FornecedorAte.Text = "" Then
                txt_FornecedorAte.Text = "9999999"
            End If

            If txt_TituloDe.Text = "" Then
                txt_TituloDe.Text = "00000000"
            End If

            If txt_TituloAte.Text = "" Then
                txt_TituloAte.Text = "ZZZZZZZZ"
            End If

            Session("DataLiqIni") = liq_inicial
            Session("DataLiqFim") = liq_final
            Session("CNPJDe") = txt_CNPJDe.Text
            Session("CNPJAte") = txt_CNPJAte.Text
            Session("CODEmpIni") = txt_FornecedorDe.Text
            Session("CODEmpFim") = txt_FornecedorAte.Text
            Session("EmissaoIni") = emissao_de
            Session("EmissaoAte") = emissao_ate
            Session("VencIni") = vencimento_de
            Session("VencFim") = vencimento_ate
            Session("NumTitIni") = txt_TituloDe.Text
            Session("NunTitFin") = txt_TituloAte.Text
            Session("DetCGC") = ""

            If rbStatus.SelectedValue = "V" Then
                Session("Status") = ""
            Else
                Session("Status") = rbStatus.SelectedValue
            End If

            Session("Condicao") = "R"
            Session("Email") = ""

            'Dim jscript As String = ""

            If Request.Browser.Browser = "IE" Then
                If Session("Resolucao") = "768x1024" Then
                    ScriptManager.RegisterStartupScript(Page, Page.GetType, "JavaScript", "window.open('Rep_Relatorio.aspx','PaginaExibida', 'resizable=no, scrollbars=yes, menubar=no, width=1005, height=695, left= 5, top=5');", True)
                ElseIf Session("Resolucao") = "600x800" Then
                    ScriptManager.RegisterStartupScript(Page, Page.GetType, "JavaScript", "window.open('Rep_Relatorio.aspx','PaginaExibida', 'resizable=no, scrollbars=yes, menubar=no, width=780, height=530, left= 5, top=5');", True)
                Else
                    ScriptManager.RegisterStartupScript(Page, Page.GetType, "JavaScript", "window.open('Rep_Relatorio.aspx','PaginaExibida', 'resizable=no, scrollbars=yes, menubar=no, width=1005, height=695, left= 5, top=5');", True)
                End If
            Else
                ScriptManager.RegisterStartupScript(Page, Page.GetType, "JavaScript", "window.open('Rep_Relatorio.aspx','PaginaExibida', 'resizable=no, scrollbars=yes, menubar=no, width=1005, height=695, left= 5, top=5');", True)
            End If

        End If
    End Sub
End Class