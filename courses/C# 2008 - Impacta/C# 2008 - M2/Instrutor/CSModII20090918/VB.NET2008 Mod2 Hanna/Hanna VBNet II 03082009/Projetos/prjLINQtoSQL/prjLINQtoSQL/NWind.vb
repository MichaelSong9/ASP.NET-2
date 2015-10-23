Imports System.Data.Linq

Public Class NWind
    Inherits DataContext

    Public Sub New(ByVal connectionString As String)
        MyBase.New(connectionString)
    End Sub

    Public Produtos As Table(Of Produto)

End Class
