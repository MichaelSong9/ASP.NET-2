Imports Microsoft.VisualBasic
Imports ConexaoBanco.ConexaoBanco
Imports System.Data.OracleClient
Imports System.Data

Public Class clRecCreme
    Public MsgErro As String
    Public CODLOC As String
    Public TIPOREM As String
    Public TIPOMP As String
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
        Dim Fields() As String = {"P_CODLOC", "P_TIPREM", "P_TIPOMP", "P_TIPDOC01", "P_TIPDOC02", "P_TIPDOC03", "P_TIPDOC04", "P_TIPDOC05", "P_TIPDOC06", "P_TIPDOC07", "P_TIPDOC08", "P_TIPDOC09", "P_TIPDOC10", "P_DATARECI", "P_DATARECF"}
        Dim Param() As String = {CODLOC.ToString(), TIPOREM.ToString(), TIPOMP.ToString(), TIPDOC1.ToString(), TIPDOC2.ToString(), TIPDOC3.ToString(), TIPDOC4.ToString(), TIPDOC5.ToString(), TIPDOC6.ToString(), TIPDOC7.ToString(), TIPDOC8.ToString(), TIPDOC9.ToString(), TIPDOC10.ToString(), DATARECI.ToString(), DATARECF.ToString()}
        Dim OConexao As clsOracleServer20 = New clsOracleServer20
        Return OConexao.AbrirDataTable(Conn, "PR_ADI_SEL_CREME", Fields, Param)
    End Function
End Class
