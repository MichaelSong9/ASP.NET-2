Imports Microsoft.VisualBasic
Imports OrcaleServer20.ConexaoSQL20
Imports System.Data.OracleClient
Imports System.Data

Public Class clRecTeor
    Public MsgErro As String
    Public CODLOC As String
    Public TIPREM As String
    Public CODREM As String
    Public TIPDOC As String
    Public TIPDES As String
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

    Public Property PTipRem() As String
        Get
            Return TIPREM
        End Get
        Set(ByVal value As String)
            TIPREM = value
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

    Public Property PTipDoc() As String
        Get
            Return TIPDOC
        End Get
        Set(ByVal value As String)
            TIPDOC = value
        End Set
    End Property

    Public Property PTIPDES() As String
        Get
            Return TIPDES
        End Get
        Set(ByVal value As String)
            TIPDES = value
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
        Dim Fields() As String = {"P_CODLOC", "P_TIPREM", "P_CODREM", "P_TIPDOC", "P_TIPDES", "P_DATRECI", "P_DATRECF"}
        Dim Param() As String = {CODLOC.ToString(), TIPREM.ToString(), CODREM.ToString(), TIPDOC.ToString(), TIPDES.ToString(), DATRECI.ToString(), DATRECF.ToString()}
        Dim oConexao As New clsOracleServer20
        Return oConexao.AbrirDataTable(Conn, "PR_ADI_SEL_TEOR", Fields, Param)
    End Function
End Class
