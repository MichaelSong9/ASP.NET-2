Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Label1.Text = DateTime.Now.ToLongDateString()

        Label1.Text &= "<br />"

        Label1.Text &= Convert.ToDecimal(1000).ToString("C")
        


    End Sub
End Class
