Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.Data

Public Class Clientes
    Private conexao As String = "server=localhost\sqlexpress;" & _
                                          "database=northwind;" & _
                                          "Integrated security=true;"

    Public Function ListaDePaises() As DataSet
        Dim da As New SqlDataAdapter("ListaDePaises", conexao)
        Dim ds As New DataSet
        da.Fill(ds)
        Return ds
    End Function

    Public Function ListaDeCidades(ByVal pais As String) As DataSet
        Dim da As New SqlDataAdapter("ListaDeCidades", conexao)
        da.SelectCommand.Parameters.AddWithValue("@pais", pais)
        da.SelectCommand.CommandType = CommandType.StoredProcedure

        Dim ds As New DataSet
        da.Fill(ds)
        Return ds
    End Function
    Public Function ListaDeClientes(ByVal pais As String, ByVal cidade As String) As DataSet
        Dim da As New SqlDataAdapter("ListaDeClientes", conexao)
        da.SelectCommand.Parameters.AddWithValue("@pais", pais)
        da.SelectCommand.Parameters.AddWithValue("@cidade", cidade)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        Dim ds As New DataSet
        da.Fill(ds)
        Return ds
    End Function

End Class
