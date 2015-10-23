Imports System.Data.SqlClient

Public Class BancoDeDados
    Private Function StringDeConexao() As String
        Return "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Empresa;Data Source=.\SQLExpress"
    End Function

    Private Function AbrirConexao() As SqlConnection
        Dim cn As New SqlConnection(StringDeConexao())
        cn.Open()
        Return cn
    End Function

    Private Sub FecharConexao(ByVal cn As SqlConnection)
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
    End Sub

    Public Sub ExecutarComando(ByVal instrucaoSQL As String)
        Dim cn As New SqlConnection
        cn = AbrirConexao()

        Dim cmd As New SqlCommand
        cmd.Connection = cn
        cmd.CommandText = instrucaoSQL
        cmd.CommandType = CommandType.Text

        Try
            cmd.ExecuteNonQuery()
        Catch ex As SqlException
            Throw New Exception(ex.Message)
        Finally
            FecharConexao(cn)
        End Try
    End Sub
End Class
