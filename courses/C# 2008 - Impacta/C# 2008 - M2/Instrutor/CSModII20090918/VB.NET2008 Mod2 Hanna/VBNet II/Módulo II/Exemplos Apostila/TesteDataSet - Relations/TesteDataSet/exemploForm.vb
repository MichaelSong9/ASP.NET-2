Public Class exemploForm
    Dim dvCateg As DataView

    Private Sub Form1_Load(ByVal sender As System.Object, _
                           ByVal e As System.EventArgs) Handles MyBase.Load

        dvCateg = New DataView(Geral.ProdutosPorCategoria.Tables("Categoria"))
        dvCateg.Sort = "Nome_cat"

        exemploListBox.DisplayMember = "Nome_cat"
        exemploListBox.DataSource = dvCateg

        DataGridView1.AllowUserToAddRows = False
        DataGridView1.ReadOnly = True
        DataGridView1.AutoSizeColumnsMode = _
            DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub exemploListBox_SelectedIndexChanged(ByVal sender As System.Object, _
                                                ByVal e As System.EventArgs) _
                                                Handles exemploListBox.SelectedIndexChanged

        DataGridView1.DataSource = _
            dvCateg(exemploListBox.SelectedIndex).CreateChildView("Relacionamento")
    End Sub

End Class
