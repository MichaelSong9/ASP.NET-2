Imports Microsoft.VisualBasic
Imports OrcaleServer20.ConexaoSQL20
Imports System.Data.OracleClient
Imports System.Data

Public Class clRelAdi
    Public msgerro As String
    Private dtperiodoI As String
    Private dtperiodoF As String

    Public Property dt_periodoI() As String
        Get
            Return dtperiodoI
        End Get
        Set(ByVal value As String)
            dtperiodoI = value
        End Set
    End Property
    Public Property dt_periodoF() As String
        Get
            Return dtperiodoF
        End Get
        Set(ByVal value As String)
            dtperiodoF = value
        End Set
    End Property
    Public Function Consultar(ByVal conn As String) As DataTable
        Dim Fields() As String = {"P_PERIODOI", "P_PERIODOF"}
        Dim Param() As String = {dtperiodoI.ToString(), dtperiodoI.ToString()}
        Dim OConexao As clsOracleServer20 = New clsOracleServer20()
        Return OConexao.AbrirDataTable(conn, "PR_ADI_SEL_COMIGO", Fields, Param)
    End Function
End Class


