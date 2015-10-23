Imports Microsoft.VisualBasic
Imports OrcaleServer20.ConexaoSQL20
Imports System.Data.OracleClient
Imports System.Data

Public Class clCentroCustos
    Public msgerro As String

    Private CENTRO_DE As String
    Private NOMECENTRO_DE As String
    Private CENTRO_PARA As String

    Public Property pID_CENTRO_DE() As String
        Get
            Return CENTRO_DE
        End Get
        Set(ByVal value As String)
            CENTRO_DE = value
        End Set
    End Property

    Public Property pNOMECENTRO_DE() As String
        Get
            Return NOMECENTRO_DE
        End Get
        Set(ByVal value As String)
            NOMECENTRO_DE = value
        End Set
    End Property

    Public Property pCENTRO_PARA() As String
        Get
            Return CENTRO_PARA
        End Get
        Set(ByVal value As String)
            CENTRO_PARA = value
        End Set
    End Property

    Public Function Incluir(ByVal conn As String)
        Dim Fields() As String = {"pID_CENTRO_DE", "pNOMECENTRO_DE", "pCENTRO_PARA"}
        Dim Param() As String = {CENTRO_DE.ToString(), NOMECENTRO_DE.ToString(), CENTRO_PARA.ToString()}
        Try
            Dim OConexao As clsOracleServer20 = New clsOracleServer20()
            OConexao.ExecutarOperacaoSemRetorno(conn, "PRC_DEPARA_CENTROCUSTO", Fields, Param)
        Catch ex As Exception
            msgerro = ex.Message.ToString()
            Return False
        End Try
        Return True
    End Function
End Class
