
Partial Class admin_Default
    Inherits System.Web.UI.Page

    Protected Sub confirmarButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles confirmarButton.Click
        Profile.NomeCompleto = nomeTextBox.Text
        Profile.Idade = Convert.ToInt32(idadeTextBox.Text)
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Page_PreInit(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.PreInit

    End Sub
End Class
