Imports System
Imports System.web
Imports System.Data

Partial Class Recebimento_SIF_Rel_RecSIF
    Inherits System.Web.UI.Page

    Protected Sub imb_Imprimir_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles imb_Imprimir.Click
        If Me.Page.IsValid = True Then

            Session("ddlLocalizacao") = ddl_Localizacao.SelectedValue
            Session("ddlTipoMP") = ddl_MP.SelectedValue
            Session("ddlCodPos") = ddl_CodPos.SelectedValue
            Session("ddlRemetente") = ddl_Remetente.SelectedValue
            Session("ddlTipoDocumento") = ddl_TipoDocumento.SelectedValue
            Session("txtDataRecI") = txt_DataRecI.Text
            Session("txtDataRecF") = txt_DataRecF.Text

            Dim jscript As String = ""
            jscript += "<script language='JavaScript'>"
            jscript += "window.open('Rep_RecSIF.aspx','PaginaExibida', 'resizable=no, scrollbars=yes, menubar=no, width=1024, height=695, left= 5, top=5')"
            jscript += "</script>"
            ClientScript.RegisterClientScriptBlock([GetType](), "Cliente", jscript)
        End If
    End Sub
End Class
