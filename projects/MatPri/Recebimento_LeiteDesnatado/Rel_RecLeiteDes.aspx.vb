Imports System.Web.UI.HtmlControls.HtmlGenericControl
Imports System.Data
Imports System.Data.OracleClient

Partial Class Recebimento_LeiteDesnatado_Rel_RecLeiteDes
    Inherits System.Web.UI.Page
    Private TipDoc(9) As String
    Private sConnectString As String = ConfigurationManager.ConnectionStrings("ConnectionString").ToString()

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ddl_CodRemetente.Items.Add(New ListItem("TODOS", 0))
    End Sub

    Protected Sub imb_Imprimir_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles imb_Imprimir.Click
        If Me.Page.IsValid = True Then
            If txt_DataRecI.Text = "" Or _
               txt_DataRecF.Text = "" Then
                Me.Page.ClientScript.RegisterStartupScript(GetType(String), "", "<script language='JavaScript'>alert('Faltam dados a serem preenchidos');</script>")
            Else
                TipDoc = Session("arrTipoDocumento")

                Session("ddlLocalizacao") = ddl_Localizacao.SelectedValue
                Session("ddlTipoRemetente") = ddl_TipoRemetente.SelectedValue
                Session("ddlTipoMP") = ddl_MP.SelectedValue
                Session("ddlCodRemetente") = ddl_CodRemetente.SelectedValue
                Session("txtTeorMGI") = txt_TeorMGI.Text
                Session("txtTeorMGF") = txt_TeorMGF.Text
                Session("txtDataRecI") = txt_DataRecI.Text
                Session("txtDataRecF") = txt_DataRecF.Text

                Dim jscript As String = ""
                jscript += "<script language='JavaScript'>"
                jscript += "window.open('Rep_RecLeiteDes.aspx','PaginaExibida', 'resizable=no, scrollbars=yes, menubar=no, width=1024, height=695, left= 5, top=5')"
                jscript += "</script>"
                ClientScript.RegisterClientScriptBlock([GetType](), "Cliente", jscript)
            End If
        End If
    End Sub

    Protected Sub RadioButton1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdlSelecione.CheckedChanged
        Dim jscript As String = ""
        jscript += "<script language='JavaScript'>"
        jscript += "window.open('../TipoDocumento.aspx','PaginaExibida', 'resizable=no, scrollbars=yes, menubar=no, width=200, height=325, left=350, top=250')"
        jscript += "</script>"
        ClientScript.RegisterClientScriptBlock([GetType](), "Cliente", jscript)
    End Sub

    Protected Sub RadioButton2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdlTodos.CheckedChanged
        Dim i As Integer
        For i = 0 To 9
            Select Case i
                Case 0
                    TipDoc(0) = "01"
                Case 1
                    TipDoc(1) = "02"
                Case 2
                    TipDoc(2) = "03"
                Case 3
                    TipDoc(3) = "04"
                Case 4
                    TipDoc(4) = "92"
                Case 5
                    TipDoc(5) = "94"
                Case 6
                    TipDoc(6) = "96"
                Case 7
                    TipDoc(7) = "97"
                Case 8
                    TipDoc(8) = "98"
                Case 9
                    TipDoc(9) = "99"
            End Select
        Next
        Session("arrTipoDocumento") = TipDoc
    End Sub

    Protected Sub imbCodRem_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles imbCodRem.Click
        Dim ds As DataSet
        If IsNothing(Session("CODREM")) Then
            Dim buscadados As New clCodRem
            buscadados.CodRem = "0"
            ds = buscadados.Consultar(sConnectString)

            If ds.Tables(0).Rows.Count > 0 Then
                Session("CODREM") = ds
            End If
        End If

        Try
            ds = CType(Session("CODREM"), DataSet)
            ddl_CodRemetente.Items.Clear()
            ddl_CodRemetente.Items.Add(New ListItem("TODOS", 0))

            Dim dr As DataRow
            For Each dr In ds.Tables(0).Rows
                ddl_CodRemetente.Items.Add(New ListItem(dr(1).ToString(), dr(0).ToString()))
            Next
            Me.ddl_CodRemetente.Focus()
        Catch ex As Exception
        End Try
    End Sub
End Class
