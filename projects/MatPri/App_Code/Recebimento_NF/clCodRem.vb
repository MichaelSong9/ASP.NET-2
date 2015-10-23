Imports Microsoft.VisualBasic
Imports ConexaoBanco.ConexaoBanco
Imports System.Data.OracleClient
Imports System.Data

Public Class clCodRem
    Public MsgErro As String
    Public CodRem As String

    Public Property P_CodRem() As String
        Get
            Return CodRem
        End Get
        Set(ByVal value As String)
            CodRem = value
        End Set
    End Property

    Public Function Consultar(ByVal CONN As String) As DataSet
        Dim Fields() As String = {"P_CODREM"}
        Dim Param() As String = {CodRem.ToString()}
        Dim oConexao As New clsOracleServer20
        Return oConexao.AbrirDataSet(CONN, "PR_ADI_SEL_CODREM", Fields, Param)
    End Function
End Class