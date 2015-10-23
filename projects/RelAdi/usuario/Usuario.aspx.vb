Imports System
Imports System.Text
Imports System.Collections
Imports System.DirectoryServices

Partial Class usuario_Usuario
    Inherits System.Web.UI.Page
    Private _path As String
    Private _filterAttribute As String


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Page.Title = "Usuario"
        cLogin.FindControl("UserName").Focus()
        lblNomeSistema.Text = "Relatórios de Matéria Prima"
    End Sub

    Protected Sub cLogin_Authenticate(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.AuthenticateEventArgs) Handles cLogin.Authenticate
        If Membership.ValidateUser(cLogin.UserName.ToString, cLogin.Password.ToString) Then
            Dim userData As String = "ApplicationSpecific data for this user."
            Dim isPersistent As Boolean = True
            Dim ticket As FormsAuthenticationTicket = New FormsAuthenticationTicket(1, cLogin.UserName.ToString, DateTime.Now, DateTime.Now.AddMinutes(30), isPersistent, userData, FormsAuthentication.FormsCookiePath)
            'Pega o Grupo do Usuario - Inicio
            Dim domainAndUsername As String = "CCL\" & cLogin.UserName.ToString
            Dim entry As DirectoryEntry = New DirectoryEntry(_path, domainAndUsername, cLogin.Password.ToString)
            Dim obj As Object = entry.NativeObject
            Dim search As DirectorySearcher = New DirectorySearcher(entry)
            search.Filter = "(SAMAccountName=" & cLogin.UserName.ToString & ")"
            search.PropertiesToLoad.Add("cn")
            Dim result As SearchResult = search.FindOne()
            'Update the new path to the user in the directory.
            _path = result.Path
            _filterAttribute = CType(result.Properties("cn")(0), String)
            Dim Grupos As String = GetGroups()
            'Pega o Grupo do Usuario - Fim
            Dim nTotGrupos As Integer = Grupos.Length
            Dim nLoop As Integer
            Dim Contador As Integer = 1
            Dim cNomedoGrupo As String = ""
            Dim Autorizado As Boolean = False
            For nLoop = 0 To nTotGrupos - 1
                If Mid(Grupos, Contador, 1) <> "|" Then
                    cNomedoGrupo = cNomedoGrupo + Mid(Grupos, Contador, 1)
                Else
                    'Inserir aqui o nome do grupo criado pelo Administrador, para acessar o sistema
                    If cNomedoGrupo = "GGS-CCL-Intranet" Then
                        Autorizado = True
                        nLoop = nTotGrupos + 1
                    Else
                        cNomedoGrupo = ""
                    End If
                End If
                Contador = Contador + 1
            Next
            If Autorizado = True Then
                Session("BancodeDados") = CType(cLogin.FindControl("ddlBanco"), DropDownList).Text
                Session("Empresa") = CType(cLogin.FindControl("ddlEmpresa"), DropDownList).Text
                ' Encrypt the ticket.
                Dim encTicket As String = FormsAuthentication.Encrypt(ticket)
                ' Create the cookie.
                Response.Cookies.Add(New HttpCookie(FormsAuthentication.FormsCookieName, encTicket))
                ' Redirect back to original URL.
                Response.Redirect(FormsAuthentication.GetRedirectUrl(cLogin.UserName.ToString, isPersistent))
            End If
        End If
    End Sub


    Public Function GetGroups() As String
        Dim search As DirectorySearcher = New DirectorySearcher(_path)
        search.Filter = "(cn=" & _filterAttribute & ")"
        search.PropertiesToLoad.Add("memberOf")
        Dim groupNames As StringBuilder = New StringBuilder()

        Try
            Dim result As SearchResult = search.FindOne()
            Dim propertyCount As Integer = result.Properties("memberOf").Count

            Dim dn As String
            Dim equalsIndex, commaIndex

            Dim propertyCounter As Integer

            For propertyCounter = 0 To propertyCount - 1
                dn = CType(result.Properties("memberOf")(propertyCounter), String)

                equalsIndex = dn.IndexOf("=", 1)
                commaIndex = dn.IndexOf(",", 1)
                If (equalsIndex = -1) Then
                    Return Nothing
                End If

                groupNames.Append(dn.Substring((equalsIndex + 1), (commaIndex - equalsIndex) - 1))
                groupNames.Append("|")
            Next

        Catch ex As Exception
            Throw New Exception("Error obtaining group names. " & ex.Message)
        End Try

        Return groupNames.ToString()
    End Function

End Class
