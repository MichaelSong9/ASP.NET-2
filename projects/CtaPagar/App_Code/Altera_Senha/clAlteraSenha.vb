Imports Microsoft.VisualBasic
Imports ConexaoBanco.ConexaoBanco
Imports System.Data.OracleClient
Imports System.Data

Public Class clAlteraSenha
    Public MsgErro As String
    Public ID_LOGIN_USUARIO As String
    Public CD_SENHA As String

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

    Public Function atualizar(ByVal conn As String) As Boolean
        Dim Fields() As String = {"P_ID_LOGIN_USUARIO", "P_CD_SENHA"}
        Dim Param() As String = {ID_LOGIN_USUARIO.ToString(), CD_SENHA.ToString()}
        Try
            Dim OConexao As New clsOracleServer20
            OConexao.ExecutarOperacaoSemRetorno(conn, "PR_ADI_UPD_SEN_TB_SG_USUARIO", Fields, Param)
            Return True
        Catch e As OracleException
            MsgErro = e.Message.ToString()
            Return False
        End Try
    End Function
End Class