
Partial Class Login
    Inherits System.Web.UI.Page

    Protected Sub ConfirmarButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ConfirmarButton.Click
        If senhaTextBox.Text = "123" Then
            FormsAuthentication.RedirectFromLoginPage(nomeTextBox.Text, False)
        Else
            mensagemLabel.Text = "usu�rio ou senha inv�lida"
        End If
    End Sub
End Class
