
Partial Class Pagina_Inicial
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Page.Title() = ":: Relatorios ADI ::"
        Dim st_script As String
        st_script = "var winl = (screen.width - window.screen.width) / 2; var wint = (screen.height - window.screen.height) / 2; winprops = 'height='+(screen.height - 10 )+',width='+(screen.width - 10)+',top='+wint+',left='+winl+', fullscreen=no, toolbar=no, status=2, scrollbars=no, menubar=no, resizable=no, width=1024, height=695'; self.opener = self; self.close(); window.open('Pagina_Principal.aspx','Pagina_Principal',winprops);{ window.close(); }"
        Me.Page.ClientScript.RegisterClientScriptBlock(GetType(String), "", "<script language='JavaScript'>" + st_script + "</script>")
    End Sub
End Class
