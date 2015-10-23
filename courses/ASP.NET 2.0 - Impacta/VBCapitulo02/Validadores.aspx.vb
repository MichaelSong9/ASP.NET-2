
Partial Class Validadores
    Inherits System.Web.UI.Page

    Protected Sub CustomValidator1_ServerValidate(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles CustomValidator1.ServerValidate
        If args.Value = "impacta" Then
            args.IsValid = False
        Else
            args.IsValid = True
        End If
    End Sub

    Protected Sub confirmarButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles confirmarButton.Click


        If Page.IsValid Then
            mensagemLabel.Text = "Formulário Processado"
        Else
            mensagemLabel.Text = "Essa página não é válida"
        End If
    End Sub
End Class
