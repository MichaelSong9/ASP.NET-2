Imports Microsoft.VisualBasic
Imports ConexaoBanco.ConexaoBanco
Imports System.Data.OracleClient
Imports System.Data

Public Class clNotaFiscal
    Public MsgErro As String
    Public NotaFiscal As String

    Public Property P_NotaFiscal() As String
        Get
            Return NotaFiscal
        End Get
        Set(ByVal value As String)
            NotaFiscal = value
        End Set
    End Property

    Public Function Consultar(ByVal CONN As String) As DataSet
        Dim Fields() As String = {"P_NOTAFISCAL"}
        Dim Param() As String = {NotaFiscal.ToString()}
        Dim oConexao As New clsOracleServer20
        Return oConexao.AbrirDataSet(CONN, "PR_ADI_SEL_NF", Fields, Param)
    End Function
End Class