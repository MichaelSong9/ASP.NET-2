Imports Empresa.Modelos
Imports System.Data.SqlClient

Public Class ClienteDAL
    Public Function Incluir(ByVal cliente As ClienteInfo) As Integer
        Dim cn As New SqlConnection(Dados.StringDeConexao())
        Dim cmd As New SqlCommand("pCliente_Insert", cn)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@nome", cliente.Nome)
        cmd.Parameters.AddWithValue("@endereco", cliente.Endereco)

        Dim codigoNovo As SqlParameter = _
            cmd.Parameters.Add("@codigo", SqlDbType.Int, 0, "Codigo")
        codigoNovo.Direction = ParameterDirection.Output

        Try
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()

            Return Integer.Parse(codigoNovo.Value)
        Catch ex As SqlException
            Throw New Exception("Erro ao tentar incluir o cliente")
        End Try

    End Function

    Public Function ProcurarPorNome(ByVal nomeCli As String) _
    As SqlDataReader

        Dim cn As New SqlConnection(Dados.StringDeConexao())
        Dim cmd As New SqlCommand("pCliente_SelectPorNome", cn)

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@nome", nomeCli)

        Dim dr As SqlDataReader

        Try
            cn.Open()
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            Return dr
        Catch ex As SqlException
            Throw New Exception("Erro ao tentar procurar por nome")
        End Try

    End Function

    Public Sub Alterar(ByVal cliente As ClienteInfo)
        Using cn As New SqlConnection(Dados.StringDeConexao())
            Using cmd As New SqlCommand("pCliente_Update", cn)
                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.AddWithValue("@codigo", cliente.Codigo)
                cmd.Parameters.AddWithValue("@nome", cliente.Nome)
                cmd.Parameters.AddWithValue("@endereco", cliente.Endereco)

                Try
                    cn.Open()
                    cmd.ExecuteNonQuery()
                Catch ex As SqlException
                    Throw New Exception("Erro ao tentar alterar")
                End Try
            End Using
        End Using
    End Sub

    Public Sub Excluir(ByVal cliente As ClienteInfo)
        Using cn As New SqlConnection(Dados.StringDeConexao())
            Using cmd As New SqlCommand("pCliente_Delete", cn)
                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.AddWithValue("@codigo", cliente.Codigo)

                Try
                    cn.Open()
                    cmd.ExecuteNonQuery()
                Catch ex As SqlException
                    Throw New Exception("Erro ao tentar excluir")
                End Try
            End Using
        End Using
    End Sub

End Class
