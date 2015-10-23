Imports Microsoft.VisualBasic
Imports ConexaoBanco.ConexaoBanco
Imports System.Data.OracleClient
Imports System.Data

Public Class clPostoFiscal
    Public MsgErro As String
    Public PostoFiscal As String

    Public Property P_PostoFiscal() As String
        Get
            Return PostoFiscal
        End Get
        Set(ByVal value As String)
            PostoFiscal = value
        End Set
    End Property

    Public Function Consultar(ByVal CONN As String) As DataSet
        Dim Fields() As String = {"P_POSTOFISCAL"}
        Dim Param() As String = {PostoFiscal.ToString()}
        Dim oConexao As New clsOracleServer20
        Return oConexao.AbrirDataSet(CONN, "PR_ADI_SEL_POSTOFISCAL", Fields, Param)
    End Function
End Class
