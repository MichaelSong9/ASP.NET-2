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

Partial Class Pagamentos_Historico_Historico
    Inherits System.Web.UI.Page
    Private sConnectString As String = ConfigurationManager.ConnectionStrings("ConnectionString").ToString()
    Private dtReader As DataTable
    Private dtTable As DataTable
    Private ds As DataSet
    Public Shared arrArquivos As New ArrayList()
    Public seleciona As Boolean

#Region "Page Load..."
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Page.Title = "Contas a Pagar"

        If IsPostBack = False Then
            txt_DataInicial.Focus()
        End If
    End Sub
#End Region

#Region "Consultar Histórico"
    Protected Sub imbPesquisar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles imbPesquisar.Click
        If txt_DataInicial.Text = "" Or txt_DataFinal.Text = "" Then
            ScriptManager.RegisterStartupScript(Page, Page.GetType, "JavaScript", "alert('Selecione o intervalo de datas a ser processado!');", True)
        Else
            Dim data_inicial As Date = Convert.ToDateTime(txt_DataInicial.Text)
            Dim data_final As Date = Convert.ToDateTime(txt_DataFinal.Text)

            If data_final > System.DateTime.Now Then
                ScriptManager.RegisterStartupScript(Page, Page.GetType, "JavaScript", "alert('A data de pagamento final é maior que a data atual, verifique!');", True)
            Else
                If data_inicial > data_final Then
                    ScriptManager.RegisterStartupScript(Page, Page.GetType, "JavaScript", "alert('A data de pagamento inicial é maior que a data final, verifique!');", True)
                Else
                    If txt_CGCInicial.Text = "" Then
                        txt_CGCInicial.Text = "00000000"
                    End If
                    If txt_CGCFinal.Text = "" Then
                        txt_CGCFinal.Text = "99999999"
                    End If

                    If txt_TituloDe.Text = "" Then
                        txt_TituloDe.Text = "00000000"
                    End If
                    If txt_TituloAte.Text = "" Then
                        txt_TituloAte.Text = "ZZZZZZZZ"
                    End If

                    Session("dsHist") = ""
                    gridEmail.DataSource = ds
                    gridEmail.DataBind()

                    PesquisaHistorico(True)
                End If
            End If
        End If
    End Sub
#End Region

#Region "Consultar Título"
    Protected Sub gridEmail_RowEditing(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewEditEventArgs) Handles gridEmail.RowEditing
        Dim Buscadados As New clEmail
        Dim Cripta As New clDescriptografa
        sConnectString = Cripta.Descrip(sConnectString, Session("BancodeDados"))
        Thread.CurrentThread.CurrentCulture = New CultureInfo("pt-BR")

        Dim cgc As String = gridEmail.DataKeys(e.NewEditIndex).Value
        Dim det_cgc As String
        Dim corpo_cgc As String

        If Len(cgc) > 11 Then
            corpo_cgc = Mid(gridEmail.DataKeys(e.NewEditIndex).Value, 1, 8)
            det_cgc = Mid(gridEmail.DataKeys(e.NewEditIndex).Value, 9, 6)
        Else
            corpo_cgc = Mid(gridEmail.DataKeys(e.NewEditIndex).Value, 1, 8)
            det_cgc = ""
        End If

        Dim row As GridViewRow = gridEmail.Rows(e.NewEditIndex)
        Dim titulo As String = CType(row.FindControl("lblTitulo"), Label).Text

        Dim data_inicial As String = CType(row.FindControl("lblIntervaloDe"), Label).Text
        Dim data_final As String = CType(row.FindControl("lblIntervaloAte"), Label).Text

        data_inicial = Convert.ToDateTime(data_inicial).ToString("dd-MMM-yyyy", New CultureInfo("en-US").DateTimeFormat)
        data_final = Convert.ToDateTime(data_final).ToString("dd-MMM-yyyy", New CultureInfo("en-US").DateTimeFormat)

        Buscadados.PDATA_LIQ_INI = data_inicial
        Buscadados.PDATA_LIQ_FIM = data_final
        Buscadados.CORPO_CGC = corpo_cgc
        Buscadados.DET_CGC = det_cgc
        Buscadados.PTITULO = titulo
        ds = Buscadados.ConsultaTitulo(sConnectString)

        If ds.Tables(0).Rows.Count > 0 Then
            gridVisTit.DataSource = ds
            gridVisTit.DataBind()
            VisualizarGridModalPopupExtender.Show()
        Else
            Me.Page.ClientScript.RegisterStartupScript(GetType(String), "", "<script language='JavaScript'>alert('Dados não encontrados!');</script>")
        End If
    End Sub
#End Region

#Region "Paginação do GridEmail"
    Protected Sub gridEmail_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridEmail.SelectedIndexChanged
        PesquisaHistorico(False)
    End Sub
    Protected Sub gridEmail_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles gridEmail.PageIndexChanging
        gridEmail.PageIndex = e.NewPageIndex
        PesquisaHistorico(False)
    End Sub

    Protected Sub PesquisaHistorico(ByVal Condicao As Boolean)
        If Condicao Then
            Dim Buscadados As New clEmail
            Dim Cripta As New clDescriptografa

            sConnectString = Cripta.Descrip(sConnectString, Session("BancodeDados"))
            Thread.CurrentThread.CurrentCulture = New CultureInfo("pt-BR")

            Dim data_inicial As String = Convert.ToDateTime(txt_DataInicial.Text).ToString("dd/MMM/yyyy", New CultureInfo("en-US").DateTimeFormat)
            Dim data_final As String = Convert.ToDateTime(txt_DataFinal.Text).ToString("dd/MMM/yyyy", New CultureInfo("en-US").DateTimeFormat)

            Buscadados.PDATA_LIQ_INI = data_inicial
            Buscadados.PDATA_LIQ_FIM = data_final
            Buscadados.PCNPJ_DE = txt_CGCInicial.Text
            Buscadados.PCNPJ_ATE = txt_CGCFinal.Text
            Buscadados.PTIT_DE = txt_TituloDe.Text
            Buscadados.PTIT_ATE = txt_TituloAte.Text

            ds = Buscadados.ConsultaHistorico(sConnectString)

            If ds.Tables(0).Rows.Count > 0 Then
                Session("dsHist") = ds
            Else
                ScriptManager.RegisterStartupScript(Page, Page.GetType, "JavaScript", "alert('Dados não encontrados!');", True)
                Return
            End If
        End If

        ds = CType(Session("dsHist"), DataSet)

        If ds.Tables(0).Rows.Count > 0 Then
            gridEmail.DataSource = ds
            gridEmail.DataBind()
        Else
            Me.Page.ClientScript.RegisterStartupScript(GetType(String), "", "<script language='JavaScript'>alert('Dados não encontrados!');</script>")
        End If
    End Sub
#End Region

End Class