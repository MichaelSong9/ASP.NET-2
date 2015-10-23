Public Class Geral
    Public Shared Function ProdutosPorCategoria() As DataSet
        Dim Loja As New DataSet

        Dim Categoria As New DataTable
        Categoria.Columns.Add("Codigo_cat", GetType(Integer))
        Categoria.Columns.Add("Nome_cat")

        Dim Produto As New DataTable
        Produto.Columns.Add("Codigo_prod", GetType(Integer))
        Produto.Columns.Add("Nome_prod")
        Produto.Columns.Add("Codigo_cat", GetType(Integer))

        Loja.Tables.Add(Categoria)
        Loja.Tables(0).TableName = "Categoria"

        Loja.Tables.Add(Produto)
        Loja.Tables(1).TableName = "Produto"

        Categoria.Rows.Add(1, "Laticícinios")
        Categoria.Rows.Add(2, "Achocolatados")
        Categoria.Rows.Add(3, "Cereais")
        Categoria.Rows.Add(4, "Matinais")
        Categoria.Rows.Add(5, "Carnes")
        Categoria.Rows.Add(6, "Guloseimas")

        Produto.Rows.Add(1, "Chocolatinho", 2)
        Produto.Rows.Add(2, "Queijo", 1)
        Produto.Rows.Add(3, "Granola", 3)

        'Relacionamento entre as tabelas
        Loja.Relations.Add("Relacionamento", _
                           Categoria.Columns("Codigo_cat"), _
                           Produto.Columns("Codigo_cat"))

        Return Loja
    End Function
End Class
