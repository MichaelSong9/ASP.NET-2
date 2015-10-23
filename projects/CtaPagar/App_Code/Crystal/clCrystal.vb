Imports Microsoft.VisualBasic
Imports CrystalDecisions.Shared
Imports System
Imports System.Data

Public Class clCrystal

    Inherits System.Web.UI.Page

    Public Function ConectaCrystal() As TableLogOnInfos
        Dim Infos As TableLogOnInfos = New TableLogOnInfos
        Dim Info As TableLogOnInfo = New TableLogOnInfo
        Dim Conn As ConnectionInfo = New ConnectionInfo
        Conn.ServerName = Session("BancodeDados")
        Conn.UserID = "dcf"
        Conn.Password = "dcf"
        Info.ConnectionInfo = Conn
        Infos.Add(Info)
        Return Infos
    End Function
End Class
