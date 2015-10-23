Imports System
Imports System.Text
Imports System.Collections
Imports System.Data
Imports System.Data.OracleClient
Imports ConexaoBanco.ConexaoBanco

Partial Class usuario_Altera_Senha
    Inherits System.Web.UI.Page
    Private sConnectString As String = ConfigurationManager.ConnectionStrings("ConnectionString").ToString()
    Private st_script As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Page.Title = "Alterar Senha"
    End Sub

    Protected Sub ChangePasswordPushButton_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        If cMudarSenha.CurrentPassword <> "" And cMudarSenha.NewPassword <> "" And cMudarSenha.ConfirmNewPassword <> "" Then
            If cMudarSenha.NewPassword <> cMudarSenha.ConfirmNewPassword Then
                Me.Page.ClientScript.RegisterStartupScript(GetType(String), "", "<script language='JavaScript'>alert('Verifique a nova senha e sua confirmação, os dados não conferem.');</script>")
            Else
                Dim ParamSenha As String = ""
                Dim AlterarSenha As New clAlteraSenha
                Dim Login As String

                Login = Mid(cMudarSenha.UserName, 5, 25)
                AlterarSenha.ID_LOGIN_USUARIO = Login
                AlterarSenha.CD_SENHA = cMudarSenha.NewPassword.ToString

                Try
                    AlterarSenha.atualizar(sConnectString)
                    Me.Page.ClientScript.RegisterStartupScript(GetType(String), "", "<script language='JavaScript'>alert('Senha alterada com sucesso.');</script>")
                Catch ex As Exception
                    If Err.Number = 5 Then
                        Me.Page.ClientScript.RegisterStartupScript(GetType(String), "", "<script language='JavaScript'>alert('Verifique os dados informados.');</script>")
                    End If
                End Try
            End If
        End If
    End Sub
End Class