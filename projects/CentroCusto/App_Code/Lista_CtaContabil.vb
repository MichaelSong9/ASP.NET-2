Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.OracleClient

<WebService(Namespace:="http://tempuri.org/")> _
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Class Lista_CtaContabil
    Inherits System.Web.Services.WebService
    Private sConnectString As String = ConfigurationManager.ConnectionStrings("ConnectionString1").ToString()

    <WebMethod()> _
     Public Function ReturnList(ByVal prefixText As String, ByVal count As Integer) As String()
        Dim items As New List(Of String)(count)
        Dim i As Integer
        Dim OConexao As New OracleConnection
        Dim oSelect As String
        Dim oAdapter As New OracleDataAdapter
        Dim oDtSet As DataSet
        Dim oCmd As New OracleCommand
        OConexao = New OracleConnection(sConnectString)
        oSelect = "SELECT CONTA ||'-'||NOMECONTA AS CONTACONTABIL FROM PLANOCTA1 WHERE CONTA LIKE '" + prefixText + "%'" + " AND ROWNUM < " + count.ToString
        oCmd.CommandType = CommandType.Text
        oCmd.CommandText = oSelect
        oCmd.Connection = OConexao
        oAdapter = New OracleDataAdapter(oCmd)
        oDtSet = New DataSet
        Try
            OConexao.Open()
            oAdapter.Fill(oDtSet, "PLANOCTA1")
            For i = 0 To oDtSet.Tables(0).Rows.Count - 1 Step i + 1
                items.Add(oDtSet.Tables(0).Rows(i)(0).ToString())
            Next
        Catch ex As Exception
            Dim erro As String = "ERRO"
        End Try
        Return items.ToArray()
    End Function

End Class
