Imports System
Imports System.Data
Imports System.Configuration
Imports System.Web
Imports ConexaoBanco.ConexaoBanco
Imports System.Text
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

''' <summary>
''' Summary description for Class1
''' </summary>
Public Class clsCrystal
    '
    ' TODO: Add constructor logic here

    Public Sub New()
    End Sub

    Public Sub New(ByVal ProcedureName As String, ByVal strConn As String, ByVal strParamField As String(), ByVal strParamValue As String(), ByVal FilePath As String, ByVal Tipo As String)
        ReportCrystal(ProcedureName, strConn, strParamField, strParamValue, FilePath)
    End Sub

    Public Sub ReportCrystal(ByVal ProcedureName As String, ByVal strConn As String, ByVal strParamField As String(), ByVal strParamValue As String(), ByVal FilePath As String)

        Dim Banco As New clsOracleServer20()
        Dim dt As DataTable = Banco.AbrirDataTable(strConn, ProcedureName, strParamField, strParamValue, "Retorno")
        Dim RelatorioFile As New CrystalDecisions.Shared.DiskFileDestinationOptions()
        RelatorioFile.DiskFileName = FilePath

        '
        ' *Para vc estar aqui vc deve ter criado na seguite sequencia
        ' 1 - Criado a Procedure com os dados
        ' 2 - Criado um Dataset e vinculalo a procedure
        ' 3 - Dar um Rebuild na Aplicação
        ' 4 - Gerar um novo Relatorio RPT
        ' 5 - Vincular este Relatorio ao DataSet Criado
        ' 6 - Dar um Rebuid na aplicação
        ' 7 - Montar a Passagem de parametros
        ' 8 - Perfeito pode continuar
        ' obs - o exemplo abaixo descreve os passos a serem tomados nesta classe
        '


        ' Copie até a palavra fim da cópia
        If ProcedureName = "PRC_PAG_REL_AUT_PAG" Then
            'Nome da Procedure do Relatório

            Dim rpt As New crRelPagTit()
            ' Nome do Rpt que vc criou
            ' não precisa alterar nada daqui pra baixo é só copiar até a palavra fim
            rpt.SetDataSource(dt)
            rpt.ExportOptions.ExportDestinationType = CrystalDecisions.[Shared].ExportDestinationType.DiskFile
            rpt.ExportOptions.ExportFormatType = CrystalDecisions.[Shared].ExportFormatType.PortableDocFormat
            rpt.ExportOptions.DestinationOptions = RelatorioFile
            rpt.Export()
            rpt.Close()
            rpt.Dispose()
        End If

    End Sub


    Public Sub ExcelCrystal(ByVal ProcedureName As String, ByVal strConn As String, ByVal strParamField As String(), ByVal strParamValue As String(), ByVal FilePath As String, ByVal FileLoad As String)
        Dim Banco As New clsOracleServer20()
        Dim dt As DataTable = Banco.AbrirDataTable(strConn, ProcedureName, strParamField, strParamValue, "Retorno")
        Dim RelatorioFile As New CrystalDecisions.Shared.DiskFileDestinationOptions()
        RelatorioFile.DiskFileName = FilePath

        '
        ' *Para vc estar aqui vc deve ter criado na seguite sequencia
        ' 1 - Criado a Procedure com os dados
        ' 2 - Criado um Dataset e vinculalo a procedure
        ' 3 - Dar um Rebuild na Aplicação
        ' 4 - Gerar um novo Relatorio RPT
        ' 5 - Vincular este Relatorio ao DataSet Criado
        ' 6 - Dar um Rebuid na aplicação
        ' 7 - Montar a Passagem de parametros
        ' 8 - Perfeito pode continuar
        ' obs - o exemplo abaixo descreve os passos a serem tomados nesta classe
        '


        ' Copie até a palavra fim da cópia
        If ProcedureName = "PRC_PAG_REL_AUT_PAG" Then
            'Nome da Procedure do Relatório

            Dim rpt As New crRelPagTit()
            ' Nome do Rpt que vc criou
            ' não precisa alterar nada daqui pra baixo é só copiar até a palavra fim

            Dim rptExcel As New ReportDocument()
            Dim strExportFile As String = FileLoad
            rptExcel.Load(FilePath)
            rptExcel.SetDataSource(dt)
            rptExcel.ExportOptions.ExportDestinationType = CrystalDecisions.[Shared].ExportDestinationType.DiskFile
            rptExcel.ExportOptions.ExportFormatType = CrystalDecisions.[Shared].ExportFormatType.Excel
            Dim objExcelOptions As New ExcelFormatOptions()
            objExcelOptions.ExcelUseConstantColumnWidth = False
            rptExcel.ExportOptions.FormatOptions = objExcelOptions
            Dim objOptions As New DiskFileDestinationOptions()
            objOptions.DiskFileName = strExportFile
            rptExcel.ExportOptions.DestinationOptions = objOptions
            rptExcel.Export()
            objOptions = Nothing
            rptExcel = Nothing
        End If
    End Sub
End Class

