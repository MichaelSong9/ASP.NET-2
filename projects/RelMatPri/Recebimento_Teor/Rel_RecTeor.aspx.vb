Imports System.Web
Imports System.Data

Partial Class Recebimento_Teor_Rel_RecTeor
    Inherits System.Web.UI.Page

    Protected Sub imb_Imprimir_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles imb_Imprimir.Click
        If Me.Page.IsValid = True Then

            Session("ddlLocalizacao") = ddl_Localizacao.SelectedValue
            Session("ddlTipoRemetente") = ddl_TipoRemetente.SelectedValue
            Session("ddlCodRemetente") = ddl_CodRemetente.SelectedValue
            Session("ddlTipoDocumento") = ddl_TipoDocumento.SelectedValue
            Session("ddlDestinacao") = ddl_Destinacao.SelectedValue
            Session("txtDataRecI") = txt_DataRecI.Text
            Session("txtDataRecF") = txt_DataRecF.Text

            Dim jscript As String = ""
            jscript += "<script language='JavaScript'>"
            jscript += "window.open('Rep_RecTeor.aspx','PaginaExibida', 'resizable=no, scrollbars=yes, menubar=no, width=1024, height=695, left= 5, top=5')"
            jscript += "</script>"
            ClientScript.RegisterClientScriptBlock([GetType](), "Cliente", jscript)
        End If
    End Sub
End Class
