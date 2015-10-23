Imports Microsoft.VisualBasic
Imports ConexaoBanco.ConexaoBanco
Imports System.Data.OracleClient
Imports System.Data

Public Class clExclusaoDeMovimento
    Public MsgErro As String
    Public DATRECI As String
    Public DATRECF As String

    Public Property PDatRecI() As String
        Get
            Return DATRECI
        End Get
        Set(ByVal value As String)
            DATRECI = value
        End Set
    End Property
    Public Property PDatRecF() As String
        Get
            Return DATRECF
        End Get
        Set(ByVal value As String)
            DATRECF = value
        End Set
    End Property
    Public Function excluir(ByVal conn As String) As Boolean
        Dim Fields() As String = {"P_DATRECI", "P_DATRECF"}
        Dim Param() As String = {DATRECI.ToString(), DATRECF.ToString()}

        Try
            Dim OConexao As New clsOracleServer20
            OConexao.ExecutarOperacaoSemRetorno(conn, "PR_ADI_DEL_MPPCP", Fields, Param)
            Return True
        Catch e As OracleException
            MsgErro = e.Message.ToString()
            Return False
        End Try
    End Function
End Class
