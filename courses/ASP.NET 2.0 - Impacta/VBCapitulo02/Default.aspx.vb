
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub okButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles okButton.Click
        mensagemLabel.Text = "Boa noite, " & nomeTextBox.Text
    End Sub

    Protected Sub testeImageButton_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles testeImageButton.Click
        mensagemLabel.Text = "Voce clicou na imagem na coordenada " & e.X & "," & e.Y

    End Sub

    Protected Sub ajudaLinkButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ajudaLinkButton.Click
        mensagemLabel.Text = "Voce clicou no link"
    End Sub
End Class
