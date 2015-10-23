Imports Microsoft.VisualBasic
Imports OrcaleServer20.ConexaoSQL20
Imports System.Data.OracleClient
Imports System.Data

Public Class clRecSIF
    Public MsgErro As String
    Public CODLOC As String
    Public TIPOMP As String
    Public CODPOS As String
    Public TIPDOC As String
    Public CODREM As String
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

    Public Property PTipoMP() As String
        Get
            Return TIPOMP
        End Get
        Set(ByVal value As String)
            TIPOMP = value
        End Set
    End Property

    Public Property PCodPos() As String
        Get
            Return CODPOS
        End Get
        Set(ByVal value As String)
            CODPOS = value
        End Set
    End Property

    Public Property PTipDoc() As String
        Get
            Return TIPDOC
        End Get
        Set(ByVal value As String)
            TIPDOC = value
        End Set
    End Property

    Public Property PCodRem() As String
        Get
            Return CODREM
        End Get
        Set(ByVal value As String)
            CODREM = value
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
        Dim Fields() As String = {"P_CodLoc", "P_TipoMP", "P_CodPos", "P_TipDoc", "P_CodRem", "P_DatRecI", "P_DatRecF"}
        Dim Param() As String = {CODLOC.ToString(), TIPOMP.ToString(), CODPOS.ToString(), TIPDOC.ToString(), CODREM.ToString(), DATRECI.ToString(), DATRECF.ToString()}
        Dim oConexao As clsOracleServer20 = New clsOracleServer20
        Return oConexao.AbrirDataTable(Conn, "PR_ADI_SEL_SIF", Fields, Param)
    End Function
End Class