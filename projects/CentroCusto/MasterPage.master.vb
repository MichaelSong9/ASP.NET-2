Imports System.Data
Partial Class MasterPage
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Page.Title() = "Centro de Custos"
        lblNomeBanco.Text = Session("BancodeDados")
        lblTitulo.Text = "Centro de Custos"
        lblEmpresa.Text = Session("Empresa")
    End Sub

    Protected Sub imbHome_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles imbHome.Click
        Response.Redirect("Pagina_Principal.aspx")
    End Sub
End Class

