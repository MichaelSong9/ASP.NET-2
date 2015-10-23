Imports Oficina.Modelos
Imports System.Data.SqlClient

Public Class VeiculoDAL
    Public Sub Incluir(ByVal veiculo As VeiculoInfo)
        'Estabelecer a conexão
        Dim cn As New SqlConnection()
        cn.ConnectionString = Dados.StringDeConexao()

        'Definir o comando
        Dim cmd As New SqlCommand()
        cmd.Connection = cn
        cmd.CommandText = "spVeiculo_Ins"
        cmd.CommandType = CommandType.StoredProcedure

        'Passando os parâmetros para o comando
        cmd.Parameters.AddWithValue("@placa", veiculo.Placa)
        cmd.Parameters.AddWithValue("@modelo", veiculo.Modelo)
        cmd.Parameters.AddWithValue("@cor", veiculo.Cor)
        cmd.Parameters.AddWithValue("@ano", veiculo.Ano)

        'Executar
        Try
            'Abrir a conexão
            cn.Open()

            'Executar o comando
            cmd.ExecuteNonQuery()

            'Fechar a conexão
            cn.Close()
        Catch ex As SqlException
            Throw New Exception("Erro na Conexão - nº " & ex.Number)
        End Try
    End Sub

    'Este método retorna um DataReader
    Public Function PesquisarPorPlaca(ByVal PLACA As String) As SqlDataReader

        'Outra forma de instanciar o objeto cn
        Dim cn As New SqlConnection(Dados.StringDeConexao())

        'Outra forma de instanciar o objeto cmd
        Dim cmd As New SqlCommand("spVeiculo_SEL_Placa", cn)

        cmd.CommandType = CommandType.StoredProcedure

        'Passando os parâmetros da stored procedure
        cmd.Parameters.AddWithValue("@placa", PLACA)

        'Abrir a conexão
        cn.Open()

        'CommandBehavior.CloseConnection atribui ao cmd o 
        'comportamento de FECHAR a conexão após ter 
        'concluído a atribuição do DataReader
        Dim dr As SqlDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)

        'Retorna os dados
        Return dr
    End Function

    Public Sub Alterar(ByVal veiculo As VeiculoInfo)
        'Outra forma de instanciar o objeto cn
        Using cn As New SqlConnection(Dados.StringDeConexao())

            'Outra forma de instanciar o objeto cmd
            Using cmd As New SqlCommand("spVeiculo_UPD", cn)

                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.AddWithValue("@placa", veiculo.Placa)
                cmd.Parameters.AddWithValue("@modelo", veiculo.Modelo)
                cmd.Parameters.AddWithValue("@cor", veiculo.Cor)
                cmd.Parameters.AddWithValue("@ano", veiculo.Ano)

                Try
                    cn.Open()
                    cmd.ExecuteNonQuery()
                    cn.Close()
                Catch ex As SqlException
                    Throw New Exception("Erro na Conexão - nº " & ex.Number)
                End Try
            End Using
        End Using
    End Sub

    Public Sub Excluir(ByVal veiculo As VeiculoInfo)
        'Outra forma de instanciar o objeto cn
        Using cn As New SqlConnection(Dados.StringDeConexao())

            'Outra forma de instanciar o objeto cmd
            Using cmd As New SqlCommand("spVeiculo_Del", cn)

                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@placa", veiculo.Placa)

                Try
                    cn.Open()
                    cmd.ExecuteNonQuery()
                    cn.Close()
                Catch ex As SqlException
                    Throw New Exception("Erro na Conexão - nº " & ex.Number)
                End Try
            End Using
        End Using
    End Sub

End Class
