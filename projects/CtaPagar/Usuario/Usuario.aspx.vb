Imports System
Imports System.Text
Imports System.Collections
Imports System.Data
Imports System.Data.OracleClient
Imports ConexaoBanco.ConexaoBanco
Imports DataProtection
'Imports System.DirectoryServices

Partial Class usuario_Usuario
    Inherits System.Web.UI.Page
    'Private _path As String
    Private _filterAttribute As String
    Private sConnectString As String = ConfigurationManager.ConnectionStrings("ConnectionString").ToString()
    Private st_script As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Page.Title = "Usuario"
        cLogin.FindControl("UserName").Focus()
        lblNomeSistema.Text = "Contas a Pagar"
        If IsPostBack Then
            Session("Resolucao") = txtResolucao.Value
        End If
    End Sub

#Region "Autenticação pelo AD."
    'Protected Sub cLogin_Authenticate(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.AuthenticateEventArgs) Handles cLogin.Authenticate
    '    If Membership.ValidateUser(cLogin.UserName.ToString, cLogin.Password.ToString) Then
    '        Dim userData As String = "ApplicationSpecific data for this user."
    '        Dim isPersistent As Boolean = True
    '        Dim ticket As FormsAuthenticationTicket = New FormsAuthenticationTicket(1, cLogin.UserName.ToString, DateTime.Now, DateTime.Now.AddMinutes(30), isPersistent, userData, FormsAuthentication.FormsCookiePath)
    '        'Pega o Grupo do Usuario - Inicio
    '        Dim domainAndUsername As String = "CCL\" & cLogin.UserName.ToString
    '        Dim entry As DirectoryEntry = New DirectoryEntry(_path, domainAndUsername, cLogin.Password.ToString)
    '        Dim obj As Object = entry.NativeObject
    '        Dim search As DirectorySearcher = New DirectorySearcher(entry)
    '        search.Filter = "(SAMAccountName=" & cLogin.UserName.ToString & ")"
    '        search.PropertiesToLoad.Add("cn")
    '        Dim result As SearchResult = search.FindOne()
    '        'Update the new path to the user in the directory.
    '        _path = result.Path
    '        _filterAttribute = CType(result.Properties("cn")(0), String)
    '        Dim Grupos As String = GetGroups()
    '        'Pega o Grupo do Usuario - Fim
    '        Dim nTotGrupos As Integer = Grupos.Length
    '        Dim nLoop As Integer
    '        Dim Contador As Integer = 1
    '        Dim cNomedoGrupo As String = ""
    '        Dim Autorizado As Boolean = False
    '        For nLoop = 0 To nTotGrupos - 1
    '            If Mid(Grupos, Contador, 1) <> "|" Then
    '                cNomedoGrupo = cNomedoGrupo + Mid(Grupos, Contador, 1)
    '            Else
    '                'Inserir aqui o nome do grupo criado pelo Administrador, para acessar o sistema
    '                If cNomedoGrupo = "GGS-CCL-Intranet" Then
    '                    Autorizado = True
    '                    nLoop = nTotGrupos + 1
    '                Else
    '                    cNomedoGrupo = ""
    '                End If
    '            End If
    '            Contador = Contador + 1
    '        Next
    '        If Autorizado = True Then
    '            Session("BancodeDados") = CType(cLogin.FindControl("ddlBanco"), DropDownList).Text
    '            Session("Empresa") = CType(cLogin.FindControl("ddlEmpresa"), DropDownList).Text

    '            ' Encrypt the ticket.
    '            Dim encTicket As String = FormsAuthentication.Encrypt(ticket)
    '            ' Create the cookie.
    '            Response.Cookies.Add(New HttpCookie(FormsAuthentication.FormsCookieName, encTicket))
    '            ' Redirect back to original URL.
    '            Response.Redirect(FormsAuthentication.GetRedirectUrl(cLogin.UserName.ToString, isPersistent))
    '        End If
    '    End If
    'End Sub


    'Public Function GetGroups() As String
    '    Dim search As DirectorySearcher = New DirectorySearcher(_path)
    '    search.Filter = "(cn=" & _filterAttribute & ")"
    '    search.PropertiesToLoad.Add("memberOf")
    '    Dim groupNames As StringBuilder = New StringBuilder()

    '    Try
    '        Dim result As SearchResult = search.FindOne()
    '        Dim propertyCount As Integer = result.Properties("memberOf").Count

    '        Dim dn As String
    '        Dim equalsIndex, commaIndex

    '        Dim propertyCounter As Integer

    '        For propertyCounter = 0 To propertyCount - 1
    '            dn = CType(result.Properties("memberOf")(propertyCounter), String)

    '            equalsIndex = dn.IndexOf("=", 1)
    '            commaIndex = dn.IndexOf(",", 1)
    '            If (equalsIndex = -1) Then
    '                Return Nothing
    '            End If

    '            groupNames.Append(dn.Substring((equalsIndex + 1), (commaIndex - equalsIndex) - 1))
    '            groupNames.Append("|")
    '        Next

    '    Catch ex As Exception
    '        Throw New Exception("Error obtaining group names. " & ex.Message)
    '    End Try

    '    Return groupNames.ToString()
    'End Function
#End Region

    Protected Sub cLogin_Authenticate(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.AuthenticateEventArgs) Handles cLogin.Authenticate
        Dim oDr As OracleDataReader
        Dim Parametro As String
        Dim ValidarUsuario As New clUsuario
        ValidarUsuario.ID_LOGIN_USUARIO = cLogin.UserName.ToString
        ValidarUsuario.CD_SENHA = cLogin.Password.ToString
        ValidarUsuario.OPER = "I"

        Dim Cripta As New clDescriptografa
        sConnectString = Cripta.Descrip(sConnectString, CType(cLogin.FindControl("ddlBanco"), DropDownList).Text)

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
                    'FullScreen = "var winl = (screen.width - window.screen.width) / 2; var wint = (screen.height - window.screen.height) / 2; winprops = 'height='+(screen.height - 10)+',width='+(screen.width - 10)+',top='+wint+',left='+winl+',fullscreen""yes"",scrollbars=""yes"", resizable=""yes""'; {window.open('', '_parent'); window.opener.close('Usuario.aspx'); window.close();}; {window.open('../Pagina_Principal.aspx','Pagina',winprops); }"
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
