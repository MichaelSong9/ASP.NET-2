Imports Oficina.Modelos
Imports Oficina.DAL
Imports System.Data.Common

Public Class VeiculoBLL
    Public Sub Incluir(ByVal veiculo As VeiculoInfo)
        If String.IsNullOrEmpty(veiculo.Placa) Then
            Throw New Exception("Informe a placa do veículo")

        ElseIf (String.IsNullOrEmpty(veiculo.Modelo)) Then
            Throw New Exception("Informe o modelo do veículo")

        ElseIf (String.IsNullOrEmpty(veiculo.Cor)) Then
            Throw New Exception("Informe a cor do veículo")

        ElseIf (String.IsNullOrEmpty(veiculo.Ano.ToString())) Then
            Throw New Exception("Informe o ano do veículo")

        End If
        Dim obj As New VeiculoDAL()
        obj.Incluir(veiculo)
    End Sub

    'Retorna um DataReader genérico que não depende do 
    'fabricante do servidor de dados
    Public Function PesquisarPorPlaca(ByVal placa As String) As DbDataReader

        If String.IsNullOrEmpty(placa) Then
            Throw New Exception("Informe uma placa")
        End If

        Dim obj As New VeiculoDAL()
        Return obj.PesquisarPorPlaca(placa)
    End Function

    Public Sub Alterar(ByVal veiculo As VeiculoInfo)
        If String.IsNullOrEmpty(veiculo.Placa) Then
            Throw New Exception("Informe a placa do veículo")

        ElseIf String.IsNullOrEmpty(veiculo.Modelo) Then
            Throw New Exception("Informe o modelo do veículo")

        ElseIf String.IsNullOrEmpty(veiculo.Cor) Then
            Throw New Exception("Informe a cor do veículo")

        ElseIf String.IsNullOrEmpty(veiculo.Ano.ToString()) Then
            Throw New Exception("Informe o ano do veículo")

        End If
        Dim obj As New VeiculoDAL()
        obj.Alterar(veiculo)
    End Sub

    Public Sub Excluir(ByVal veiculo As VeiculoInfo)
        If String.IsNullOrEmpty(veiculo.Placa) Then
            Throw New Exception("Informe a placa do veículo")

        End If
        Dim obj As New VeiculoDAL()
        obj.Excluir(veiculo)
    End Sub

End Class
