Partial Class Pagina_Inicial
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Page.Title() = "Sistema de Relatorios - ADI"
        Dim FullScreen As String
        If Request.Browser.Browser = "IE" And Request.Browser.Version = "6.0" Then
            FullScreen = "var winl = window.showModalDialog('Usuario/Usuario.aspx','Pagina','dialogWidth=800px;dialogHeight=600px;dialogLeft='+((screen.width-800)/2)+'px;dialogTop='+(((screen.height-600)/2)+65)+'px;scroll=no;status=no;help=no'); {window.opener=''; window.close('');}"
        Else
            FullScreen = "var winl = window.showModalDialog('Usuario/Usuario.aspx','Pagina','dialogWidth=800px;dialogHeight=600px;dialogLeft='+((screen.width-800)/2)+'px;dialogTop='+(((screen.height-600)/2)+65)+'px;scroll=no;status=no;help=no'); {window.open('', '_parent'); window.opener=''; window.close('');}"
        End If
        Me.Page.ClientScript.RegisterClientScriptBlock(GetType(String), "", "<script language='JavaScript'>" + FullScreen + "</script>")
    End Sub
End Class
