Imports System.Data.SqlClient

Partial Class Inclusao
    Inherits System.Web.UI.Page

    Protected Sub gravarButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles gravarButton.Click
        'Conexao
        Dim cn As New SqlConnection
        'cn.ConnectionString = "server=localhost\sqlexpress; database=curso; integrated security=true"
        cn.ConnectionString = ConfigurationManager.ConnectionStrings("cursoConnectionString1").ConnectionString

        'Comando
        Dim cmd As New SqlCommand()
        cmd.Connection = cn
        cmd.CommandText = "insert into clientes(nome, email) values(@nome,@email)"
        cmd.Parameters.AddWithValue("@nome", nomeTextBox.Text)
        cmd.Parameters.AddWithValue("@email", emailTextBox.Text)

        'Executar
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()

        mensagemLabel.Text = "O cliente foi incluído com sucesso"
    End Sub
End Class
