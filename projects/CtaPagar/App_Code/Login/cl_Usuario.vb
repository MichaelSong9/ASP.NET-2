Imports Microsoft.VisualBasic
Imports ConexaoBanco.ConexaoBanco
Imports System.Data.OracleClient
Imports System.Data

Public Class cl_Usuario
    Public MsgErro As String
    Public cd_usuario As String

    Public Property Usuario() As String
        Get
            Return cd_usuario
        End Get
        Set(ByVal value As String)
            value = cd_usuario
        End Set
    End Property

    Public Function Validar(ByVal Conn As String) As OracleDataReader
        Dim Fields() As String = {"cd_usuario"}
        Dim Param() As String = {cd_usuario.ToString()}
        Dim OConexao As New clsOracleServer20
        Return OConexao.ExecutarOperacao(Conn, "PR_ADI_SEL_TB_SG_USUARIO", Fields, Param)
    End Function

    Public Function Alterar(ByVal conn As String) As Boolean
        Dim Fields As String() = {"P_ID_LOGIN_USUARIO"}
        Dim Param As String() = {cd_usuario.ToString()}
        Try
            Dim OConexao As New clsOracleServer20()
            OConexao.ExecutarOperacao(conn, "PR_ADI_UPD_TB_SG_USUARIO", Fields, Param)
            Return True
        Catch e As OracleException
            MsgErro = e.Message.ToString()
            Return False
        End Try
    End Function
End Class
