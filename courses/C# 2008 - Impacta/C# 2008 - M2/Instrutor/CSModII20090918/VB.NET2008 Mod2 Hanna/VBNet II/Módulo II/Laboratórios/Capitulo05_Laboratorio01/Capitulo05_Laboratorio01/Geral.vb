Imports System.Data.SqlClient

Public Class Geral
    Public Shared ReadOnly Property StringDeConexao() As String
        Get
            Return "Integrated Security=SSPI;Persist Security Info=False;" & _
                        "Initial Catalog=Oficina;Data Source=.\sqlexpress"
        End Get
    End Property

    Public Shared ReadOnly Property instrucaoSQL() As String
        Get
            Return "Select * From Veiculo order by Placa"
        End Get
    End Property

    Public Shared Function ListaDeVeiculos() As DataSet
        Dim da As New SqlDataAdapter(instrucaoSQL, StringDeConexao)

        Dim lista As New DataSet

        da.Fill(lista)
        lista.Tables(0).TableName = "Veiculos"

        Return lista
    End Function

End Class



