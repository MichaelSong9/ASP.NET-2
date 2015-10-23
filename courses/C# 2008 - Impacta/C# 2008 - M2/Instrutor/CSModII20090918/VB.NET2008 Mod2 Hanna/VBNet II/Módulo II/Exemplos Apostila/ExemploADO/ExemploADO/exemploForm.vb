Imports System.Data.SqlClient

Public Class exemploForm

    Private Sub exemploButton_Click(ByVal sender As System.Object, _
                        ByVal e As System.EventArgs) Handles exemploButton.Click

        'Cria a conexão
        Dim cn As New SqlConnection()
        cn.ConnectionString = "Integrated Security=SSPI;" & _
                                        "Persist Security Info=False;" & _
                                        "Initial Catalog=LojaSQL;" & _
                                        "Data Source=.\sqlexpress"

        'Cria o comando
        Dim cmd As New SqlCommand()

        'Associa o comando à conexão
        cmd.Connection = cn

        'Cria a instrução SQL para a inserção
        Dim instrucaoSQL As String = _
            String.Format("Select * from Cliente Where Nome Like '{0}%'", _
            pesquisaTextBox.Text)

        'Passa a instrução para o comando
        cmd.CommandText = instrucaoSQL

        'Especifica o tipo de comando
        cmd.CommandType = CommandType.Text

        'Cria o leitor de dados
        Dim dr As SqlDataReader

        Try
            'Abre a conexão
            cn.Open()
            MessageBox.Show("Conexão aberta", "Exemplo Conexão")

            'Executa o comando sem retorno de dados
            dr = cmd.ExecuteReader()

            If dr.Read() Then
                nomeTextBox.Text = dr("Nome").ToString()
                emailTextBox.Text = dr("Email").ToString()

                MessageBox.Show("Pesquisa concluída com sucesso", "Exemplo Conexão")
            Else
                MessageBox.Show("Nome não localizado", "Exemplo Conexão")
            End If

            'Fecha a conexão
            cn.Close()
            MessageBox.Show("Conexão fechada", "Exemplo Conexão")

        Catch ex As SqlException
            MessageBox.Show("Erro ao conectar", "Alerta de Erro nº " & ex.Number, _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
