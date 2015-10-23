
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub confirmarButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles confirmarButton.Click
        'Gravar o nome do usuario na sessão
        Session("nome") = nomeTextBox.Text

        'Gravar o nome do usuario em Cookies
        Response.Cookies("nome").Value = nomeTextBox.Text
        Response.Cookies("nome").Expires = DateTime.Now.AddDays(1)

        'Gravar no View State
        If ViewState("contador") Is Nothing Then
            ViewState("contador") = 1
        Else
            ViewState("contador") += 1
        End If

        mensagemLabel.Text = "Os dados foram gravados com sucesso"
        mensagemLabel.Text &= "<br>Total de gravações:"
        mensagemLabel.Text &= ViewState("contador")





    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Se existe um Cookie chamado Nome, Coloca no textBox
        'Se o textBox estiver vazio
        If nomeTextBox.Text = "" Then
            If Not Request.Cookies("nome") Is Nothing Then
                nomeTextBox.Text = Request.Cookies("nome").Value
            End If
        End If
    End Sub
End Class
