Public Class VeiculoInfo

    Private _placa As String
    Public Property Placa() As String
        Get
            Return _placa
        End Get
        Set(ByVal value As String)
            _placa = value
        End Set
    End Property


    Private _modelo As String
    Public Property Modelo() As String
        Get
            Return _modelo
        End Get
        Set(ByVal value As String)
            _modelo = value
        End Set
    End Property


    Private _cor As String
    Public Property Cor() As String
        Get
            Return _cor
        End Get
        Set(ByVal value As String)
            _cor = value
        End Set
    End Property


    Private _ano As Short
    Public Property Ano() As Short
        Get
            Return _ano
        End Get
        Set(ByVal value As Short)
            _ano = value
        End Set
    End Property

End Class
