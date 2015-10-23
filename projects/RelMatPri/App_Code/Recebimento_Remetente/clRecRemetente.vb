Imports Microsoft.VisualBasic
Imports OrcaleServer20.ConexaoSQL20
Imports System.Data.OracleClient
Imports System.Data

Public Class clRecRemetente
    Public MsgErro As String
    Public CODLOC As String
    Public CODREM As String
    Public TIPDOC As String
    Public DATRECI As String
    Public DATRECF As String

    Public Property PCodLoc() As String
        Get
            Return CODLOC
        End Get
        Set(ByVal value As String)
            CODLOC = value
        End Set
    End Property
    Public Property PCODREM() As String
        Get
            Return CODREM
        End Get
        Set(ByVal value As String)
            CODREM = value
        End Set
    End Property
    Public Property PTIPDOC() As String
        Get
            Return TIPDOC
        End Get
        Set(ByVal value As String)
            TIPDOC = value
        End Set
    End Property
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
    Public Function Imprimir(ByVal Conn As String) As DataTable
        Dim Fields() As String = {"P_CODLOC", "P_CODREM", "P_TIPDOC", "P_DATRECI", "P_DATRECF"}
        Dim Param() As String = {CODLOC.ToString(), CODREM.ToString(), TIPDOC.ToString(), DATRECI.ToString(), DATRECF.ToString()}
        Dim OConexao As clsOracleServer20 = New clsOracleServer20
        Return OConexao.AbrirDataTable(Conn, "PR_ADI_SEL_REMET", Fields, Param)
    End Function
End Class