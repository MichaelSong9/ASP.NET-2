Imports Empresa.Modelos
Imports Empresa.DAL
Imports System.Data.Common

Public Class ClienteBLL
    Public Function Incluir(ByVal cliente As ClienteInfo) As Integer
        If String.IsNullOrEmpty(cliente.Nome) Then
            Throw New Exception("Nome é obrigatório")
        ElseIf String.IsNullOrEmpty(cliente.Endereco) Then
            Throw New Exception("Endereço é obrigatório")
        End If

        Dim obj As New ClienteDAL
        Return obj.Incluir(cliente)
    End Function

    Public Function ProcurarPorNome(ByVal nomeCli As String) _
    As DbDataReader
        If String.IsNullOrEmpty(nomeCli.Trim()) Then
            Throw New Exception("Nome é obrigatório")
        End If

        Dim obj As New ClienteDAL
        Return obj.ProcurarPorNome(nomeCli)
    End Function

    Public Sub Alterar(ByVal cliente As ClienteInfo)
        If String.IsNullOrEmpty(cliente.Codigo.ToString()) Then
            Throw New Exception("Código é obrigatório")
        ElseIf String.IsNullOrEmpty(cliente.Nome.Trim()) Then
            Throw New Exception("Nome é obrigatório")
        ElseIf String.IsNullOrEmpty(cliente.Endereco.Trim()) Then
            Throw New Exception("Endereço é obrigatório")
        End If

        Dim obj As New ClienteDAL
        obj.Alterar(cliente)
    End Sub

    Public Sub Excluir(ByVal cliente As ClienteInfo)
        If String.IsNullOrEmpty(cliente.Codigo.ToString()) Then
            Throw New Exception("Código é obrigatório")
        End If

        Dim obj As New ClienteDAL
        obj.Excluir(cliente)
    End Sub
End Class
