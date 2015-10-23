Imports System
Imports System.Text
Imports System.Collections
Imports System.Data
Imports System.Data.OracleClient
Imports ConexaoBanco.ConexaoBanco
Imports DataProtection

Partial Class usuario_Usuario
    Inherits System.Web.UI.Page
    Private _filterAttribute As String
    Private sConnectString As String = ConfigurationManager.ConnectionStrings("ConnectionString").ToString()
    Private st_script As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Page.Title = "Secretaria Geral - Login"
        cLogin.FindControl("UserName").Focus()
        lblNomeSistema.Text = "Sistema - Secretaria Geral"
        If IsPostBack Then
            Session("Resolucao") = txtResolucao.Value
        End If
    End Sub

    Protected Sub cLogin_Authenticate(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.AuthenticateEventArgs) Handles cLogin.Authenticate
        Dim oDr As OracleDataReader
        Dim Parametro As String
        Dim ValidarUsuario As clUsuario = New clUsuario
        Dim Cripta As clDescriptografa = New clDescriptografa

        ValidarUsuario.ID_LOGIN_USUARIO = cLogin.UserName.ToString
        ValidarUsuario.CD_SENHA = cLogin.Password.ToString
        ValidarUsuario.OPER = "I"

        Dim banco As String = CType(cLogin.FindControl("ddlBanco"), DropDownList).Text
        sConnectString = Cripta.Descrip(sConnectString, banco)

        Try
            oDr = ValidarUsuario.Validar(sConnectString)
            While oDr.Read
                Parametro = oDr.Item(0)
            End While
            oDr.Close()
            If Parametro.Equals("") Or Parametro.Equals("0") Then
                Me.Page.ClientScript.RegisterStartupScript(GetType(String), "", "<script language='JavaScript'>alert('Usuario ou Senha Invalida');</script>")
            Else
                Parametro += ";" & cLogin.UserName.ToString()
                Page.Session.Add("Parametro", Parametro)
                Session("BancodeDados") = CType(cLogin.FindControl("ddlBanco"), DropDownList).Text
                Session("Empresa") = CType(cLogin.FindControl("ddlEmpresa"), DropDownList).Text
                Session("Usuario") = cLogin.UserName.ToString

                Dim FullScreen As String

                If txtResolucao.Value = "600x800" Then
                    ScriptManager.RegisterStartupScript(Page, Page.GetType, "JavaScript", "alert('Altere sua resolução de tela para 1024x768!!!');", True)
                ElseIf txtResolucao.Value = "768x1024" Then
                    FullScreen = "var winl = (screen.width - window.screen.width) / 2; var wint = (screen.height - window.screen.height) / 2; winprops = 'height='+(screen.height - 10)+',width='+(screen.width - 10)+',top='+wint+',left='+winl+',fullscreen""yes"",scrollbars=""yes"", resizable=""yes""'; {window.open('', '_parent'); window.opener.close('Usuario.aspx'); window.close();}; {window.open('../Pagina_Principal.aspx','Pagina',winprops); }"
                Else
                    FullScreen = "var winl = (1024 - window.screen.width) / 2; var wint = (768 - window.screen.height) / 2; winprops = 'height='+(768 - 10)+',width='+(1024 - 10)+',top='+wint+',left='+winl+',fullscreen""yes"",scrollbars=""yes"", resizable=""yes""'; {window.open('', '_parent'); window.opener.close('Usuario.aspx'); window.close();}; {window.open('../Pagina_Principal.aspx','Pagina',winprops); }"
                End If
                Me.Page.ClientScript.RegisterClientScriptBlock(GetType(String), "", "<script language='JavaScript'>" + FullScreen + "</script>")
            End If

        Catch ex As Exception
            If Err.Number = 5 Then
                Me.Page.ClientScript.RegisterStartupScript(GetType(String), "", "<script language='JavaScript'>alert('Usuário ou senha não conferem.');</script>")
            End If
        End Try
    End Sub
End Class
