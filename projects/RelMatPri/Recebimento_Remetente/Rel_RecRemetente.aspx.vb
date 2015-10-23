Imports System.Web
Imports System.Data

Partial Class Recebimento_Remetente_Rel_RecRemetente
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'txt_DataRecF.Attributes.Add("onkeydown", "if(event.which || event.keyCode){if ((event.which == 13) || (event.keyCode == 13)) {document.getElementById('" + imb_Imprimir.UniqueID + "').click();return false;}} else {return true}; ")
        'txt_DataRecI.Attributes.Add("onkeydown", "if(event.which || event.keyCode){if ((event.which == 13) || (event.keyCode == 13)) {document.getElementById('" + imb_Imprimir.UniqueID + "').click();return false;}} else {return true}; ")
    End Sub

    Protected Sub imb_Imprimir_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles imb_Imprimir.Click
        If Me.Page.IsValid = True Then
            Session("ddlLocalizacao") = ddl_Localizacao.SelectedValue
            Session("ddlRemetente") = ddl_Remetente.SelectedValue
            Session("ddlTipoDocumento") = ddl_TipoDocumento.SelectedValue
            Session("txtDataRecI") = txt_DataRecI.Text
            Session("txtDataRecF") = txt_DataRecF.Text

            Dim jscript As String = ""
            jscript += "<script language='JavaScript'>"
            jscript += "window.open('Rep_RecRemetente.aspx','PaginaExibida', 'resizable=no, scrollbars=yes, menubar=no, width=810, height=695, left= 5, top=5')"
            jscript += "</script>"
            ClientScript.RegisterClientScriptBlock([GetType](), "Cliente", jscript)
        End If
    End Sub
End Class
