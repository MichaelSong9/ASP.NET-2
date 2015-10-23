Imports System.Data
Partial Class MasterPage
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Page.Title() = "Contas a Pagar"
        lblNomeBanco.Text = Session("BancodeDados")
        lblEmpresa.Text = Session("Empresa")
        lblUsuario.Text = Session("Usuario")

        If Request.Browser.Browser = "IE" Then
            Estilo.Attributes.Add("href", "App_Themes/CCL/CCL.css")
            If Session("Resolucao") = "768x1024" Or Session("Resolucao") = "864x1152" Then
                Estilo.Attributes.Add("href", "App_Themes/CCL/IE-1024X768.css")
            ElseIf Session("Resolucao") = "600x800" Then
                'Estilo.Attributes.Add("href", "App_Themes/CCL/IE-800X600.css")
                ScriptManager.RegisterStartupScript(Page, Page.GetType, "JavaScript", "alert('Altere sua resolução de tela para 1024x768!!!');", True)
            End If
        End If
    End Sub
End Class

