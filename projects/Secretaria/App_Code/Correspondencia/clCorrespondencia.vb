Imports System
Imports System.Data
Imports System.Web
Imports Microsoft.VisualBasic
Imports System.Data.OracleClient
Imports ConexaoBanco.ConexaoBanco

Public Class clCorrespondencia
    Public MsgErro As String
    Private ds As DataSet
    Public data As String
    Public associada As String
    Public numero_pp As String
    Public tipo As String
    Public destino As String
    Public departamento As String
    Public nome As String
    Public remetente As String
    Public destinatario As String
    Public registro As String

    Public Property p_DATA() As String
        Get
            Return data
        End Get
        Set(ByVal value As String)
            data = value
        End Set
    End Property

    Public Property p_ASSOCIADA() As String
        Get
            Return associada
        End Get
        Set(ByVal value As String)
            associada = value
        End Set
    End Property

    Public Property p_NUMERO_PP() As String
        Get
            Return numero_pp
        End Get
        Set(ByVal value As String)
            numero_pp = value
        End Set
    End Property

    Public Property p_TIPO() As String
        Get
            Return tipo
        End Get
        Set(ByVal value As String)
            tipo = value
        End Set
    End Property

    Public Property p_DESTINO() As String
        Get
            Return destino
        End Get
        Set(ByVal value As String)
            destino = value
        End Set
    End Property

    Public Property p_DEPARTAMENTO() As String
        Get
            Return departamento
        End Get
        Set(ByVal value As String)
            departamento = value
        End Set
    End Property

    Public Property p_NOME() As String
        Get
            Return nome
        End Get
        Set(ByVal value As String)
            nome = value
        End Set
    End Property

    Public Property p_REMETENTE() As String
        Get
            Return remetente
        End Get
        Set(ByVal value As String)
            remetente = value
        End Set
    End Property

    Public Property p_DESTINATARIO() As String
        Get
            Return destinatario
        End Get
        Set(ByVal value As String)
            destinatario = value
        End Set
    End Property

    Public Property p_REGISTRO() As String
        Get
            Return registro
        End Get
        Set(ByVal value As String)
            registro = value
        End Set
    End Property

    Public Function PesquisarAssociada(ByVal Conn As String) As DataSet
        Dim Fields() As String = {"p_DATA", "p_ASSOCIADA", "p_NUMERO_PP", "p_TIPO", "p_DESTINO", "p_DEPARTAMENTO", "p_NOME"}
        Dim Param() As String = {data, associada, numero_pp, tipo, destino, departamento, nome}
        Dim oConexao As New clsOracleServer20
        'ds = oConexao.AbrirDataSet(Conn, "PRC_PESQUISAR_ASSOCIADA", Fields, Param)
        Return ds
    End Function

    Public Function PesquisarCorreio(ByVal Conn As String) As DataSet
        Dim Fields() As String = {"p_DATA", "p_REMETENTE", "p_TIPO", "p_DESTINATARIO", "p_DEPARTAMENTO", "p_NOME", "p_REGISTRO"}
        Dim Param() As String = {data, remetente, tipo, destinatario, departamento, nome, registro}
        Dim oConexao As New clsOracleServer20
        'ds = oConexao.AbrirDataSet(Conn, "PRC_PESQUISAR_CORREIO", Fields, Param)
        Return ds
    End Function
End Class