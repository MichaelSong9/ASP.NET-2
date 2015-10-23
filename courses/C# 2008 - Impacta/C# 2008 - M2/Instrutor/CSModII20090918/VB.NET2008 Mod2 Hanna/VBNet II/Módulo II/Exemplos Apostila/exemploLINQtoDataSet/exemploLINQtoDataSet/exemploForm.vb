Imports System.Data.SqlClient

Public Class exemploForm
    Private Sub exemploButton_Click(ByVal sender As System.Object, _
                            ByVal e As System.EventArgs) Handles exemploButton.Click

        Dim stringConexao = "Integrated Security=SSPI;" & _
                                        "Persist Security Info=False;" & _
                                        "Initial Catalog=NorthWind;" & _
                                        "Data Source=.\sqlexpress"

        Dim instrucaoSQL = "Select * from Categories order by CategoryName"

        Dim cn As New SqlConnection(stringConexao)

        Dim da As New SqlDataAdapter(instrucaoSQL, cn)

        Dim ds As New DataSet()
        da.Fill(ds)

        Dim clientes = From c In ds.Tables(0) _
                        Select c.Field(Of String)("CategoryName")

        exemploListBox.DataSource = clientes.ToList
    End Sub
End Class
