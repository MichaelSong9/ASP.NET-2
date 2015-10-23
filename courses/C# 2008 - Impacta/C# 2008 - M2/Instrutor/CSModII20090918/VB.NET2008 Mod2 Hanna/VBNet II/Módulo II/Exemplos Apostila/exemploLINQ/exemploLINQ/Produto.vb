Imports System.Data.Linq.Mapping

<Table(Name:="Products")> Public Class Produto

    <Column(IsPrimarykey:=True)> Public ProductId As Integer

    Private _ProductName As String

    <Column(Storage:="_ProductName")> _
    Public Property ProductName() As String

        Get

            Return _ProductName

        End Get

        Set(ByVal value As String)

            _ProductName = value

        End Set

    End Property

    Private _unitsInStock As Short

    <Column(Storage:="_unitsInStock")> _
    Public Property UnitsInStock() As Short

        Get

            Return _unitsInStock

        End Get

        Set(ByVal value As Short)

            _unitsInStock = value

        End Set

    End Property
End Class


