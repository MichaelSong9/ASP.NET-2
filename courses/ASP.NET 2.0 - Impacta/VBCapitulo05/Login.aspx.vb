
Partial Class Login
    Inherits System.Web.UI.Page

    Protected Sub ConfirmarButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ConfirmarButton.Click
        If senhaTextBox.Text = "123" Then
            FormsAuthentication.RedirectFromLoginPage(nomeTextBox.Text, False)
        Else
            mensagemLabel.Text = "usuário ou senha inválida"
        End If
    End Sub
End Class
