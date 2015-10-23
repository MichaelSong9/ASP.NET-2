Imports System
Imports System.Data
Imports System.Web
Imports Microsoft.VisualBasic
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.OracleClient
Imports ConexaoBanco.ConexaoBanco
Imports clReportCrystal.clsCrystal

Public Class clEmail
    Public MsgErro As String
    Private ds As DataSet
    Public CODEMP_D_INI As String
    Public CODEMP_D_FIM As String
    Public EMISSAO_INI As String
    Public EMISSAO_FIM As String
    Public DATA_VENC_INI As String
    Public DATA_VENC_FIM As String
    Public DATA_LIQ_INI As String
    Public DATA_LIQ_FIM As String
    Public NUM_TIT_INI As String
    Public NUM_TIT_FIM As String
    Public TITULO As String
    Public TIT_DE As String
    Public TIT_ATE As String
    Public CORPO_CGC_INI As String
    Public CORPO_CGC_FIM As String
    Public CORPO_CGC As String
    Public CNPJ_DE As String
    Public CNPJ_ATE As String
    Public DET_CGC As String
    Public USUARIO As String
    Public STATUS As String
    Public CONDICAO As String
    Public EMAIL As String

    Public Property PUSUARIO() As String
        Get
            Return USUARIO
        End Get
        Set(ByVal value As String)
            USUARIO = value
        End Set
    End Property

    Public Property PCONDICAO() As String
        Get
            Return CONDICAO
        End Get
        Set(ByVal value As String)
            CONDICAO = value
        End Set
    End Property

    Public Property PEMAIL() As String
        Get
            Return EMAIL
        End Get
        Set(ByVal value As String)
            EMAIL = value
        End Set
    End Property


    Public Property PCODEMP_D_INI() As String
        Get
            Return CODEMP_D_INI
        End Get
        Set(ByVal value As String)
            CODEMP_D_INI = value
        End Set
    End Property

    Public Property PSTATUS() As String
        Get
            Return STATUS
        End Get
        Set(ByVal value As String)
            STATUS = value
        End Set
    End Property

    Public Property PCODEMP_D_FIM() As String
        Get
            Return CODEMP_D_FIM
        End Get
        Set(ByVal value As String)
            CODEMP_D_FIM = value
        End Set
    End Property

    Public Property PEMISSAO_INI() As String
        Get
            Return EMISSAO_INI
        End Get
        Set(ByVal value As String)
            EMISSAO_INI = value
        End Set
    End Property

    Public Property PEMISSAO_FIM() As String
        Get
            Return EMISSAO_FIM
        End Get
        Set(ByVal value As String)
            EMISSAO_FIM = value
        End Set
    End Property

    Public Property PDATA_VENC_INI() As String
        Get
            Return DATA_VENC_INI
        End Get
        Set(ByVal value As String)
            DATA_VENC_INI = value
        End Set
    End Property

    Public Property PNUM_TIT_INI() As String
        Get
            Return NUM_TIT_INI
        End Get
        Set(ByVal value As String)
            NUM_TIT_INI = value
        End Set
    End Property

    Public Property PNUM_TIT_FIM() As String
        Get
            Return NUM_TIT_FIM
        End Get
        Set(ByVal value As String)
            NUM_TIT_FIM = value
        End Set
    End Property

    Public Property PDATA_VENC_FIM() As String
        Get
            Return DATA_VENC_FIM
        End Get
        Set(ByVal value As String)
            DATA_VENC_FIM = value
        End Set
    End Property

    Public Property PDATA_LIQ_INI() As String
        Get
            Return DATA_LIQ_INI
        End Get
        Set(ByVal value As String)
            DATA_LIQ_INI = value
        End Set
    End Property

    Public Property PDATA_LIQ_FIM() As String
        Get
            Return DATA_LIQ_FIM
        End Get
        Set(ByVal value As String)
            DATA_LIQ_FIM = value
        End Set
    End Property

    Public Property PCORPO_CGC_INI() As String
        Get
            Return CORPO_CGC_INI
        End Get
        Set(ByVal value As String)
            CORPO_CGC_INI = value
        End Set
    End Property

    Public Property PCORPO_CGC_FIM() As String
        Get
            Return CORPO_CGC_FIM
        End Get
        Set(ByVal value As String)
            CORPO_CGC_FIM = value
        End Set
    End Property

    Public Property PCORPO_CGC() As String
        Get
            Return CORPO_CGC
        End Get
        Set(ByVal value As String)
            CORPO_CGC = value
        End Set
    End Property

    Public Property PDET_CGC() As String
        Get
            Return DET_CGC
        End Get
        Set(ByVal value As String)
            DET_CGC = value
        End Set
    End Property

    Public Property PTITULO() As String
        Get
            Return TITULO
        End Get
        Set(ByVal value As String)
            TITULO = value
        End Set
    End Property

    Public Property PTIT_DE() As String
        Get
            Return TIT_DE
        End Get
        Set(ByVal value As String)
            TIT_DE = value
        End Set
    End Property

    Public Property PTIT_ATE() As String
        Get
            Return TIT_ATE
        End Get
        Set(ByVal value As String)
            TIT_ATE = value
        End Set
    End Property

    Public Property PCNPJ_DE() As String
        Get
            Return CNPJ_DE
        End Get
        Set(ByVal value As String)
            CNPJ_DE = value
        End Set
    End Property

    Public Property PCNPJ_ATE() As String
        Get
            Return CNPJ_ATE
        End Get
        Set(ByVal value As String)
            CNPJ_ATE = value
        End Set
    End Property

    Public Function Pesquisar(ByVal Conn As String) As DataSet
        Dim Fields() As String = {"p_DATA_LIQ_INI", "p_DATA_LIQ_FIM", "p_CORPO_CGC_INI", "p_CORPO_CGC_FIM"}
        Dim Param() As String = {DATA_LIQ_INI, DATA_LIQ_FIM, CORPO_CGC_INI, CORPO_CGC_FIM}
        Dim oConexao As New clsOracleServer20
        ds = oConexao.AbrirDataSet(Conn, "PRC_PAG_EMAIL_SELECIONA", Fields, Param)
        Return ds
    End Function

    Public Function ConsultaTitulo(ByVal Conn As String) As DataSet
        Dim Fields() As String = {"p_DATA_LIQ_INI", "p_DATA_LIQ_FIM", "p_CORPO_CGC", "p_DET_CGC", "p_TITULO"}
        Dim Param() As String = {DATA_LIQ_INI, DATA_LIQ_FIM, CORPO_CGC, DET_CGC, TITULO}
        Dim oConexao As New clsOracleServer20
        ds = oConexao.AbrirDataSet(Conn, "PRC_PAG_CONS_TIT", Fields, Param)
        Return ds
    End Function

    Public Function GerarArquivo(ByVal conn As String, ByVal nomearq As String)
        Dim Fields() As String = {"p_DATA_LIQ_INI", "p_DATA_LIQ_FIM", "p_CNPJ_DE", "p_CNPJ_ATE", "p_CODEMP_D_INI", _
        "p_CODEMP_D_FIM", "p_EMISSAO_INI", "p_EMISSAO_FIM", "p_DATA_VENC_INI", "p_DATA_VENC_FIM", "p_NUM_TIT_INI", _
        "p_NUM_TIT_FIM", "p_DET_CGC", "p_USUARIO", "p_STATUS", "p_CONDICAO", "p_EMAIL"}

        Dim Param() As String = {DATA_LIQ_INI, DATA_LIQ_FIM, CNPJ_DE, CNPJ_ATE, CODEMP_D_INI, _
        CODEMP_D_FIM, EMISSAO_INI, EMISSAO_FIM, DATA_VENC_INI, DATA_VENC_FIM, NUM_TIT_INI, _
        NUM_TIT_FIM, DET_CGC, PUSUARIO, PSTATUS, PCONDICAO, PEMAIL}

        Dim sPathLocal = HttpContext.Current.Server.MapPath("Anexos\").ToString()
        Dim FilePath = sPathLocal + nomearq
        Dim crt As clReportCrystal.clsCrystal = New clReportCrystal.clsCrystal
        crt.ReportCrystal("PRC_PAG_REL_AUT_PAG", conn, Fields, Param, FilePath)
    End Function

    Public Function GerarRelatorio(ByVal conn As String, ByVal nomearq As String)
        Dim Fields() As String = {"p_DATA_LIQ_INI", "p_DATA_LIQ_FIM", "p_CNPJ_DE", "p_CNPJ_ATE", "p_CODEMP_D_INI", _
         "p_CODEMP_D_FIM", "p_EMISSAO_INI", "p_EMISSAO_FIM", "p_DATA_VENC_INI", "p_DATA_VENC_FIM", "p_NUM_TIT_INI", _
         "p_NUM_TIT_FIM", "p_DET_CGC", "p_USUARIO", "p_STATUS", "p_CONDICAO", "p_EMAIL"}

        Dim Param() As String = {DATA_LIQ_INI, DATA_LIQ_FIM, CNPJ_DE, CNPJ_ATE, CODEMP_D_INI, _
        CODEMP_D_FIM, EMISSAO_INI, EMISSAO_FIM, DATA_VENC_INI, DATA_VENC_FIM, NUM_TIT_INI, _
        NUM_TIT_FIM, DET_CGC, PUSUARIO, PSTATUS, PCONDICAO, PEMAIL}

        Dim sPathLocal = HttpContext.Current.Server.MapPath("Anexos\").ToString()
        Dim FilePath = sPathLocal + nomearq
        Dim crt As clReportCrystal.clsCrystal = New clReportCrystal.clsCrystal
        crt.ReportCrystal("PRC_PAG_REL_AUT_PAG", conn, Fields, Param, FilePath)
    End Function

    Public Function ConsultaHistorico(ByVal Conn As String) As DataSet
        Dim Fields() As String = {"p_DATA_LIQ_INI", "p_DATA_LIQ_FIM", "p_CNPJ_DE", "p_CNPJ_ATE", "p_TIT_DE", "p_TIT_ATE"}
        Dim Param() As String = {DATA_LIQ_INI, DATA_LIQ_FIM, CNPJ_DE, CNPJ_ATE, TIT_DE, TIT_ATE}
        Dim oConexao As New clsOracleServer20
        ds = oConexao.AbrirDataSet(Conn, "PRC_PAG_CONS_HIST", Fields, Param)
        Return ds
    End Function

    Public Function VisualizarRelatorio(ByVal Conn As String) As DataTable
        Dim Fields() As String = {"p_DATA_LIQ_INI", "p_DATA_LIQ_FIM", "p_CNPJ_DE", "p_CNPJ_ATE", "p_CODEMP_D_INI", _
         "p_CODEMP_D_FIM", "p_EMISSAO_INI", "p_EMISSAO_FIM", "p_DATA_VENC_INI", "p_DATA_VENC_FIM", "p_NUM_TIT_INI", _
         "p_NUM_TIT_FIM", "p_DET_CGC", "p_USUARIO", "p_STATUS", "p_CONDICAO", "p_EMAIL"}

        Dim Param() As String = {DATA_LIQ_INI, DATA_LIQ_FIM, CNPJ_DE, CNPJ_ATE, CODEMP_D_INI, _
        CODEMP_D_FIM, EMISSAO_INI, EMISSAO_FIM, DATA_VENC_INI, DATA_VENC_FIM, NUM_TIT_INI, _
        NUM_TIT_FIM, DET_CGC, PUSUARIO, PSTATUS, PCONDICAO, PEMAIL}

        Dim oConexao As New clsOracleServer20
        Return oConexao.AbrirDataTable(Conn, "PRC_PAG_REL_AUT_PAG", Fields, Param)
    End Function
End Class