Imports System
Imports System.Collections
Imports System.Data
Imports System.Data.OracleClient
Imports ConexaoBanco.ConexaoBanco

Partial Class Exclusao_de_Movimento_Exclusao_De_Movimento
    Inherits System.Web.UI.Page
    Private sConnectString As String = ConfigurationManager.ConnectionStrings("ConnectionString").ToString()
    Private st_script As String

    Protected Sub imb_Excluir_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles imb_Excluir.Click
        Dim excluirDatas As New clExclusaoDeMovimento
        excluirDatas.DATRECI = txt_DataRecI.Text
        excluirDatas.DATRECF = txt_DataRecF.Text
        Try
            excluirDatas.excluir(sConnectString)
        Catch ex As Exception
            If Err.Number = 5 Then
            End If
        End Try
    End Sub
End Class
