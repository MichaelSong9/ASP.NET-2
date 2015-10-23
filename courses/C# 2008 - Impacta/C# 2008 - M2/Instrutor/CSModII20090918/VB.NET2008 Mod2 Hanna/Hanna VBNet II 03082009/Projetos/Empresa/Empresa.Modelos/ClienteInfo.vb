Public Class ClienteInfo

    Private _codigo As Integer
    Public Property Codigo() As Integer
        Get
            Return _codigo
        End Get
        Set(ByVal value As Integer)
            _codigo = value
        End Set
    End Property

    Private _nome As String
    Public Property Nome() As String
        Get
            Return _nome
        End Get
        Set(ByVal value As String)
            _nome = value.Trim().ToUpper()
        End Set
    End Property

    Private _endereco As String
    Public Property Endereco() As String
        Get
            Return _endereco
        End Get
        Set(ByVal value As String)
            _endereco = value.Trim().ToUpper()
        End Set
    End Property

End Class
