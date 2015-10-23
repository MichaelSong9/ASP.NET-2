Imports System.Data.SqlClient
Imports System.Data


Partial Class ConectandoDataReader
    Inherits System.Web.UI.Page

    Protected Sub clientesButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles clientesButton.Click
        'Criar a Conexao
        Dim cn As New SqlConnection()
        cn.ConnectionString = "Data Source=localhost\sqlexpress;Initial Catalog=curso;Integrated Security=True;"

        'Criar o comando
        Dim cmd As New SqlCommand
        cmd.CommandText = "Select Nome,Email From Clientes"
        cmd.Connection = cn

        'Declarar o DataSet (não instanciar)
        Dim dr As SqlDataReader

        'Abrir a conecao
        cn.Open()

        'Obter uma instancia do Leitor de dados
        dr = cmd.ExecuteReader()

        'Vincular a Grid
        gv.DataSource = dr
        gv.DataBind()

        'fechar
        dr.Close()
        cn.Close()




    End Sub

    Protected Sub clientesDataSetButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles clientesDataSetButton.Click
        'Criar um DataAdapter e DataSet
        Dim da As New SqlDataAdapter("Select * from Clientes", "Data Source=localhost\sqlexpress;Initial Catalog=curso;Integrated Security=True;")
        Dim ds As New DataSet

        'Preenchendo o DataSet
        da.Fill(ds)

        'Vincular a grid
        gv.DataSource = ds
        gv.DataBind()
    End Sub
End Class
