
Imports Microsoft.VisualBasic
Imports ConexaoBanco.ConexaoBanco
Imports System.Data.OracleClient
Imports System.Data

Public Class clUsuario
    Public MsgErro As String
    Public ID_LOGIN_USUARIO As String
    Public CD_SENHA As String
    Public OPER As String

    Public Property PID_LOGIN_USUARIO() As String
        Get
            Return ID_LOGIN_USUARIO
        End Get
        Set(ByVal value As String)
            ID_LOGIN_USUARIO = value
        End Set
    End Property

    Public Property PCD_SENHA() As String
        Get
            Return CD_SENHA
        End Get
        Set(ByVal value As String)
            CD_SENHA = value
        End Set
    End Property

    Public Property OPERA() As String
        Get
            Return OPER
        End Get
        Set(ByVal value As String)
            OPER = value
        End Set
    End Property

    Public Function Validar(ByVal Conn As String) As OracleDataReader
        Dim Fields As String() = {"p_login", "p_cd_sistema", "p_senha", "p_oper"}
        Dim Param As String() = {ID_LOGIN_USUARIO.ToString(), "6", CD_SENHA.ToString(), OPER.ToString()}
        Dim OConexao As New clsOracleServer20
        Return OConexao.ExecutarOperacao(Conn, "PR_SG_VALIDA_LOGIN", Fields, Param)
    End Function

    Public Function Alterar(ByVal Conn As String) As OracleDataReader
        Dim Fields As String() = {"P_ID_LOGIN_USUARIO", "P_CD_SENHA"}
        Dim Param As String() = {ID_LOGIN_USUARIO.ToString(), CD_SENHA.ToString()}
        Dim OConexao As New clsOracleServer20
        Return OConexao.ExecutarOperacao(Conn, "PR_UPD_SEN_TB_SG_USUARIO", Fields, Param)
    End Function
End Class