
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        WebPartManager1.DisplayMode = _
                   WebPartManager1.DisplayModes("design")
    End Sub
End Class
