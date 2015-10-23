
Partial Class Manutencao
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
                    If Trim(row.Cells(3).Text) = txtCentroCusto.Text Then
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

    Protected Sub imbPesquisar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles imbPesquisar.Click
        Pesquisar()
    End Sub

    Protected Sub GridView1_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GridView1.RowCommand
        If Not Me.GridView1.SelectedRow Is Nothing Then
            GridView1.SelectedIndex = -1
        End If
    End Sub

End Class
