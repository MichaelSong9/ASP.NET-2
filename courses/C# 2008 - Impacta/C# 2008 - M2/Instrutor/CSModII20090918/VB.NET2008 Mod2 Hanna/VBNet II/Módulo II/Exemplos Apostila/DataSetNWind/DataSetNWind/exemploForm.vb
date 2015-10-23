Imports System.Data.SqlClient

Public Class exemploForm

    Private Sub exemploButton_Click(ByVal sender As System.Object, _
                            ByVal e As System.EventArgs) Handles exemploButton.Click

        'Definir a string de conexão
        Dim stringDeConexao As String = _
            "Integrated Security=SSPI;Persist Security Info=False;" & _
            "Initial Catalog=NorthWind;Data Source=.\sqlexpress"

        'Definir a instrução SQL que será executada
        Dim instrucaoSQL As New System.Text.StringBuilder
        instrucaoSQL.Append("Select CustomerId as Código, ")
        instrucaoSQL.Append("CompanyName as Cliente, ")
        instrucaoSQL.Append("ContactName as Contato, ")
        instrucaoSQL.Append("Phone as Telefone, ")
        instrucaoSQL.Append("Country as País ")
        instrucaoSQL.Append("From Customers ")
        instrucaoSQL.Append("Order by 2")

        'Definir o DataSet
        Dim ds As New DataSet

        'Definir o DataAdapter
        Dim da As New SqlDataAdapter(instrucaoSQL.ToString(), stringDeConexao)

        'Preencher o DataSet
        da.Fill(ds)

        'Auto ajustar as colunas do DataGridView
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        'Popular o DataGridView
        DataGridView1.DataSource = ds.Tables(0)
    End Sub

End Class
