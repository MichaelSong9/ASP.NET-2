
Partial Class Recebimento_LeiteDesnatado_TipoDocumento
    Inherits System.Web.UI.Page
    Private TipDoc(9) As String
    Private sConnectString As String = ConfigurationManager.ConnectionStrings("ConnectionString").ToString()

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Page.Title = "Documentos"
    End Sub

    Protected Sub imbSalvar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles imbSalvar.Click
        Dim i As Integer
        For i = 0 To 9
            TipDoc(i) = "0"
        Next
        i = 0

        For i = 0 To chkTipoDocumento.Items.Count - 1
            Select Case i
                Case 0
                    If chkTipoDocumento.Items(i).Selected = True Then
                        TipDoc(0) = chkTipoDocumento.Items(i).Value
                    End If
                Case 1
                    If chkTipoDocumento.Items(i).Selected = True Then
                        TipDoc(1) = chkTipoDocumento.Items(i).Value
                    End If
                Case 2
                    If chkTipoDocumento.Items(i).Selected = True Then
                        TipDoc(2) = chkTipoDocumento.Items(i).Value
                    End If
                Case 3
                    If chkTipoDocumento.Items(i).Selected = True Then
                        TipDoc(3) = chkTipoDocumento.Items(i).Value
                    End If
                Case 4
                    If chkTipoDocumento.Items(i).Selected = True Then
                        TipDoc(4) = chkTipoDocumento.Items(i).Value
                    End If
                Case 5
                    If chkTipoDocumento.Items(i).Selected = True Then
                        TipDoc(5) = chkTipoDocumento.Items(i).Value
                    End If
                Case 6
                    If chkTipoDocumento.Items(i).Selected = True Then
                        TipDoc(6) = chkTipoDocumento.Items(i).Value
                    End If
                Case 7
                    If chkTipoDocumento.Items(i).Selected = True Then
                        TipDoc(7) = chkTipoDocumento.Items(i).Value
                    End If
                Case 8
                    If chkTipoDocumento.Items(i).Selected = True Then
                        TipDoc(8) = chkTipoDocumento.Items(i).Value
                    End If
                Case 9
                    If chkTipoDocumento.Items(i).Selected = True Then
                        TipDoc(9) = chkTipoDocumento.Items(i).Value
                    End If
            End Select
        Next
        Session("arrTipoDocumento") = TipDoc

        Dim jscript As String = ""
        jscript += "<script language='JavaScript'>"
        jscript += "window.close('TipoDocumento.aspx','PaginaExibida', 'resizable=no, scrollbars=yes, menubar=no, width=200, height=305, left=350, top=200')"
        jscript += "</script>"
        ClientScript.RegisterClientScriptBlock([GetType](), "Cliente", jscript)

    End Sub
End Class
