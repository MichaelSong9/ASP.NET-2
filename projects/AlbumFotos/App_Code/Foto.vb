Imports Microsoft.VisualBasic

Public Class Foto

    Private _fotoID As Integer
    Public Property FotoID() As Integer
        Get
            Return _fotoID
        End Get
        Set(ByVal value As Integer)
            _fotoID = value
        End Set
    End Property
    Private _titulo As String
    Public Property Titulo() As String
        Get
            Return _titulo
        End Get
        Set(ByVal value As String)
            _titulo = value
        End Set
    End Property
    Private _descricao As String
    Public Property Descricao() As String
        Get
            Return _descricao
        End Get
        Set(ByVal value As String)
            _descricao = value
        End Set
    End Property
    Private _fotoDados As Byte()
    Public Property FotoDados() As Byte()
        Get
            Return _fotoDados
        End Get
        Set(ByVal value As Byte())
            _fotoDados = value
        End Set
    End Property
End Class


