
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub categoriaDropDownList_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles categoriaDropDownList.SelectedIndexChanged
        mensagemLabel.Text = "Ultima atualiza��o:" + DateTime.Now.ToString()
    End Sub
End Class
