Imports System
Imports System.Text
Imports System.Collections
Imports System.Data
Imports System.Data.OracleClient
Imports OrcaleServer20.ConexaoSQL20

Partial Class Usuario_Senha
    Inherits System.Web.UI.Page
    Private sConnectString As String = ConfigurationManager.ConnectionStrings("ConnectionString").ToString()
    Private st_script As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Page.Title = "Alteração de Senha"
    End Sub

    Protected Sub btn_MudarSenha_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_MudarSenha.Click
        If txt_SenhaAtual.Text <> "" And txt_NovaSenha.Text <> "" And txt_ConfirmarNovaSenha.Text <> "" Then
            If txt_NovaSenha.Text <> txt_ConfirmarNovaSenha.Text Then
                Me.Page.ClientScript.RegisterStartupScript(GetType(String), "", "<script language='JavaScript'>alert('Verifique a nova senha e sua confirmação, os dados não conferem.');</script>")
            Else
                If txt_SenhaAtual.Text = txt_NovaSenha.Text Then
                    Me.Page.ClientScript.RegisterStartupScript(GetType(String), "", "<script language='JavaScript'>alert('Senha Atual igual a Nova Senha. Digite outra Senha');</script>")
                Else
                    Dim oDr As OracleDataReader
                    Dim Parametro As String
                    Dim ValidarUsuario As New clUsuario
                    ValidarUsuario.ID_LOGIN_USUARIO = Session("Usuario")
                    ValidarUsuario.CD_SENHA = txt_SenhaAtual.Text
                    ValidarUsuario.OPER = "C"
                    oDr = ValidarUsuario.Validar(sConnectString)
                    While oDr.Read
                        Parametro = oDr.Item(0)
                    End While
                    oDr.Close()
                    If Parametro.Equals("") Or Parametro.Equals("0") Then
                        Me.Page.ClientScript.RegisterStartupScript(GetType(String), "", "<script language='JavaScript'>alert('Senha Atual Invalida');</script>")
                    Else
                        Try
                            Dim AlterarSenha As New clUsuario
                            AlterarSenha.ID_LOGIN_USUARIO = Session("Usuario")
                            AlterarSenha.CD_SENHA = txt_NovaSenha.Text
                            Try
                                AlterarSenha.Alterar(sConnectString)
                                Me.Page.ClientScript.RegisterStartupScript(GetType(String), "", "<script language='JavaScript'>alert('Senha alterada com sucesso.');</script>")
                            Catch ex As Exception
                                If Err.Number = 5 Then
                                    Me.Page.ClientScript.RegisterStartupScript(GetType(String), "", "<script language='JavaScript'>alert('Verifique os dados informados.');</script>")
                                End If
                            End Try
                        Catch ex As Exception
                            Me.Page.ClientScript.RegisterStartupScript(GetType(String), "", "<script language='JavaScript'>alert('Senha atual digitada não confere com senha cadastrada.');</script>")
                        End Try
                    End If
                End If
            End If
        Else
            Me.Page.ClientScript.RegisterStartupScript(GetType(String), "", "<script language='JavaScript'>alert('Campos devem ser Preenchidos');</script>")
        End If
    End Sub
End Class
