Imports System.Data
Partial Class MasterPage
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Page.Title() = "Relatórios ADI"
        lblNomeBanco.Text = Session("BancodeDados")
        lblTitulo.Text = "Relatórios de Matéria Prima"
        lblEmpresa.Text = Session("Empresa")
        lblUsuario.Text = Session("Usuario")

        If Request.Browser.Browser = "IE" Then
            Estilo.Attributes.Add("href", "App_Themes/CCL/CCL.css")
            If Session("Resolucao") = "768x1024" Or Session("Resolucao") = "864x1152" Then
                Estilo.Attributes.Add("href", "App_Themes/CCL/IE-1024X768.css")
            ElseIf Session("Resolucao") = "600x800" Then
                Estilo.Attributes.Add("href", "App_Themes/CCL/IE-800X600.css")
            End If
        End If
    End Sub
End Class

