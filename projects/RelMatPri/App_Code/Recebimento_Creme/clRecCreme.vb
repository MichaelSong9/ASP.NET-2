Imports Microsoft.VisualBasic
Imports OrcaleServer20.ConexaoSQL20
Imports System.Data.OracleClient
Imports System.Data

Public Class clRecCreme
    Public MsgErro As String
    Public CODLOC As String
    Public TIPOREM As String
    Public TIPOMP As String
    Public DATARECI As String
    Public DATARECF As String
    Public Property PCodLoc() As String
        Get
            Return CODLOC
        End Get
        Set(ByVal value As String)
            CODLOC = value
        End Set
    End Property
    Public Property PTipoRem() As String
        Get
            Return TIPOREM
        End Get
        Set(ByVal value As String)
            TIPOREM = value
        End Set
    End Property
    Public Property PTipoMp() As String
        Get
            Return TIPOMP
        End Get
        Set(ByVal value As String)
            TIPOMP = value
        End Set
    End Property
    Public Property PDataRecI() As String
        Get
            Return DATARECI
        End Get
        Set(ByVal value As String)
            DATARECI = value
        End Set
    End Property
    Public Property PDataRecF() As String
        Get
            Return DATARECF
        End Get
        Set(ByVal value As String)
            DATARECF = value
        End Set
    End Property
    Public Function Imprimir(ByVal Conn As String) As DataTable
        Dim Fields() As String = {"P_CODLOC", "P_TIPREM", "P_TIPOMP", "P_DATARECI", "P_DATARECF"}
        Dim Param() As String = {CODLOC.ToString(), TIPOREM.ToString(), TIPOMP.ToString(), DATARECI.ToString(), DATARECF.ToString()}
        Dim OConexao As clsOracleServer20 = New clsOracleServer20
        Return OConexao.AbrirDataTable(Conn, "PR_ADI_SEL_CREME", Fields, Param)
    End Function
End Class
