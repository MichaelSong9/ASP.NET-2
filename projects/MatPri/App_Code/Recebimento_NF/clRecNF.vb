Imports Microsoft.VisualBasic
Imports ConexaoBanco.ConexaoBanco
Imports System.Data.OracleClient
Imports System.Data

Public Class clRecNF
    Public MsgErro As String
    Public CODLOC As String
    Public TIPREM As String
    Public CODREM As String
    Public TIPDOC1 As String
    Public TIPDOC2 As String
    Public TIPDOC3 As String
    Public TIPDOC4 As String
    Public TIPDOC5 As String
    Public TIPDOC6 As String
    Public TIPDOC7 As String
    Public TIPDOC8 As String
    Public TIPDOC9 As String
    Public TIPDOC10 As String
    Public NUMNFR As String
    Public NUMDOCI As String
    Public NUMDOCF As String
    Public CODPOS As String
    Public DATRECI As String
    Public DATRECF As String

    Public Property PCODLOC() As String
        Get
            Return CODLOC
        End Get
        Set(ByVal value As String)
            CODLOC = value
        End Set
    End Property

    Public Property PTIPREM() As String
        Get
            Return TIPREM
        End Get
        Set(ByVal value As String)
            TIPREM = value
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

    Public Property PTipDoc1() As String
        Get
            Return TIPDOC1
        End Get
        Set(ByVal value As String)
            TIPDOC1 = value
        End Set
    End Property

    Public Property PTipDoc2() As String
        Get
            Return TIPDOC2
        End Get
        Set(ByVal value As String)
            TIPDOC2 = value
        End Set
    End Property

    Public Property PTipDoc3() As String
        Get
            Return TIPDOC3
        End Get
        Set(ByVal value As String)
            TIPDOC3 = value
        End Set
    End Property

    Public Property PTipDoc4() As String
        Get
            Return TIPDOC4
        End Get
        Set(ByVal value As String)
            TIPDOC4 = value
        End Set
    End Property

    Public Property PTipDoc5() As String
        Get
            Return TIPDOC5
        End Get
        Set(ByVal value As String)
            TIPDOC5 = value
        End Set
    End Property

    Public Property PTipDoc6() As String
        Get
            Return TIPDOC6
        End Get
        Set(ByVal value As String)
            TIPDOC6 = value
        End Set
    End Property

    Public Property PTipDoc7() As String
        Get
            Return TIPDOC7
        End Get
        Set(ByVal value As String)
            TIPDOC7 = value
        End Set
    End Property

    Public Property PTipDoc8() As String
        Get
            Return TIPDOC8
        End Get
        Set(ByVal value As String)
            TIPDOC8 = value
        End Set
    End Property

    Public Property PTipDoc9() As String
        Get
            Return TIPDOC9
        End Get
        Set(ByVal value As String)
            TIPDOC9 = value
        End Set
    End Property

    Public Property PTipDoc10() As String
        Get
            Return TIPDOC10
        End Get
        Set(ByVal value As String)
            TIPDOC10 = value
        End Set
    End Property

    Public Property PNUMNFR() As String
        Get
            Return NUMNFR
        End Get
        Set(ByVal value As String)
            NUMNFR = value
        End Set
    End Property

    Public Property PNUMDOCI() As String
        Get
            Return NUMDOCI
        End Get
        Set(ByVal value As String)
            NUMDOCI = value
        End Set
    End Property

    Public Property PNUMDOCF() As String
        Get
            Return NUMDOCF
        End Get
        Set(ByVal value As String)
            NUMDOCF = value
        End Set
    End Property

    Public Property PCODPOS() As String
        Get
            Return CODPOS
        End Get
        Set(ByVal value As String)
            CODPOS = value
        End Set
    End Property

    Public Property PDATRECI() As String
        Get
            Return DATRECI
        End Get
        Set(ByVal value As String)
            DATRECI = value
        End Set
    End Property

    Public Property PDATRECF() As String
        Get
            Return DATRECF
        End Get
        Set(ByVal value As String)
            DATRECF = value
        End Set
    End Property

    Public Function Imprimir(ByVal CONN As String) As DataTable
        Dim Fields() As String = {"P_CODLOC", "P_TIPREM", "P_CODREM", "P_TIPDOC01", "P_TIPDOC02", "P_TIPDOC03", "P_TIPDOC04", "P_TIPDOC05", "P_TIPDOC06", "P_TIPDOC07", "P_TIPDOC08", "P_TIPDOC09", "P_TIPDOC10", "P_NUMNFR", "P_NUMDOCI", "P_NUMDOCF", "P_CODPOS", "P_DATRECI", "P_DATRECF"}
        Dim Param() As String = {CODLOC.ToString(), TIPREM.ToString(), CODREM.ToString(), TIPDOC1.ToString(), TIPDOC2.ToString(), TIPDOC3.ToString(), TIPDOC4.ToString(), TIPDOC5.ToString(), TIPDOC6.ToString(), TIPDOC7.ToString(), TIPDOC8.ToString(), TIPDOC9.ToString(), TIPDOC10.ToString(), NUMNFR.ToString(), NUMDOCI.ToString(), NUMDOCF.ToString(), CODPOS.ToString(), DATRECI.ToString(), DATRECF.ToString()}
        Dim oConexao As New clsOracleServer20
        Return oConexao.AbrirDataTable(CONN, "PR_ADI_SEL_LEINF", Fields, Param)
    End Function
End Class