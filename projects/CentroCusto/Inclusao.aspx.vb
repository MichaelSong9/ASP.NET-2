Partial Class Inclusao
    Inherits System.Web.UI.Page
    Private sConnectString As String = ConfigurationManager.ConnectionStrings("ConnectionString").ToString()

    Private Sub Pesquisar()
        If txtCentroCusto.Text <> "" Then

            Dim achou As Boolean = False
            Dim row As GridViewRow
            Dim Page As Integer = 0
            Dim TotalPage As Integer = GridView1.PageCount

            Me.GridView1.PageIndex() = Page
            While Page <= TotalPage
                For Each row In GridView1.Rows
                    If Trim(row.Cells(0).Text) = txtCentroCusto.Text Then
                        GridView1.SelectedIndex = row.RowIndex
                        achou = True
                        Exit For
                    End If

                Next

                If Not achou Then
                    Page += 1
                    Me.GridView1.PageIndex() = Page
                    Me.GridView1.Page.DataBind()

                Else
                    Me.GridView1.PageIndex() = Page
                    Me.GridView1.Page.DataBind()

                    Exit While
                End If
            End While
        End If
    End Sub

    Private Sub Inclui_Registro()
        Dim CentroCustos As New clCentroCustos
        Dim row As GridViewRow

        For Each row In GridView1.Rows
            Dim txtCentroPara As TextBox = CType(row.FindControl("txtCentroPara"), TextBox)
            Dim lblNom As Label = row.FindControl("lblNome")

            CentroCustos.pID_CENTRO_DE = Trim(row.Cells(0).Text)
            CentroCustos.pNOMECENTRO_DE = lblNom.Text

            If txtCentroPara.Text <> "" Then
                CentroCustos.pCENTRO_PARA = txtCentroPara.Text
                CentroCustos.Incluir(sConnectString)
            End If
        Next
        GridView1.DataBind()
    End Sub

    Protected Sub GridView1_PageIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.PageIndexChanged
        If Not Me.GridView1.SelectedRow Is Nothing Then
            GridView1.SelectedIndex = -1
        End If
        Inclui_Registro()
    End Sub

    Protected Sub imbPesquisar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
        Pesquisar()
    End Sub

    Protected Sub imbIncluir_Click1(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
        Inclui_Registro()
    End Sub

End Class


