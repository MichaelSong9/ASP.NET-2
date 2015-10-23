
Partial Class Pagina2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("nome") Is Nothing Then
            mensagemLabel.Text = "Voce não informou o seu nome"
        Else
            mensagemLabel.Text = "Boa Noite,  " & Session("nome")
        End If
    End Sub
End Class
