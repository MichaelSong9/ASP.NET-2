
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub DropDownList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DropDownList1.SelectedIndexChanged
        MultiView1.ActiveViewIndex = DropDownList1.SelectedIndex - 1

    End Sub
End Class
