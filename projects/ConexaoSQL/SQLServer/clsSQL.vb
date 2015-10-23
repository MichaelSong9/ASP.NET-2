'Importa Namespaces contendo funcionalidades a serem utilizadas.
Imports System.Data
Imports System.Data.SqlClient
Imports System.Xml
Imports System.Text

Namespace ConexaoSQL

    '---------------------------------------------------------------------------------------------
    ' Nome...........: Conexao.clsSQLServer
    ' Descricao......: Servico de Registro de logs da aplica��o
    ' Atualiza��es...: [00] - 07/11/2003 - Vers�o Inicial - Autor: Emerson Felipe 
    '---------------------------------------------------------------------------------------------
    Public Class clsSQLServer

        '---------------------------------------------------------------------------------------------
        'Nome...........: AbrirConexao.
        'Descricao......: Receber par�metros de conex�o com banco de dados e retornar Conex�o aberta
        '                 com banco de dados.
        'Parametros.....: sXMLConnDB: XML contendo par�metros de Conex�o com banco de dados.
        ' Atualiza��es...: [00] - 07/11/2003 - Vers�o Inicial - Autor: Emerson Felipe 
        '---------------------------------------------------------------------------------------------
        'sStrConn	= "<?xml version='1.0' encoding='windows-1252'?><conexao server='cclsql' user='matprima' passwd='" & sSenhaCrip & "' usuarioapp='" & sCodUsuario & "' senha_cripto='S' />"
        'string strConn = "user id=matprima;data source=CCLSQL;persist security info=False;initial catalog=Materia_Prima;password=lilian";
        Public Function AbrirConexao(ByVal sXMLConnDB As XmlDocument) As SqlConnection

            'Vari�veis utilizadas na manipula��o do XML de entrada.
            Dim oXML As XmlDocument

            'Conex�o com banco de dados.
            Dim oConexao As SqlConnection

            'Connection String com banco de dados.
            Dim sConnString As New StringBuilder
            Try


                '***************************
                'Monta a Connection String.
                '***************************
                With oXML.DocumentElement.Attributes
                    sConnString.Append("Data Source=")
                    sConnString.Append(.GetNamedItem("dsn").Value.ToString())
                    sConnString.Append(";Initial Catalog=")
                    sConnString.Append(.GetNamedItem("db").Value.ToString())
                    sConnString.Append(";User id=")
                    sConnString.Append(.GetNamedItem("user").Value.ToString())
                    sConnString.Append(";Password=")
                    sConnString.Append(.GetNamedItem("passwd").Value.ToString())
                    sConnString.Append(";")
                End With

                '********************************
                'Abre conex�o com banco de dados.
                '********************************

                oConexao.Close()

                oConexao = New SqlConnection(sConnString.ToString())
                oConexao.Open()

                Return oConexao

            Catch oErroXML As XmlException
                Throw New Exception(LimpaString("Erro na interpreta��o do arquivo XML com par�metros para conex�o: " & oErroXML.Message.ToString), _
                                                oErroXML.InnerException)
            Catch oErroSQL As SqlException
                Throw New Exception(LimpaString("Erro na abertura da conex�o com banco de dados: " & oErroSQL.Message.ToString), _
                                                    oErroSQL.InnerException)
            Catch oErro As Exception
                Throw New Exception(LimpaString("Retorno-" & oErro.Message.ToString), _
                                                oErro.InnerException)
            End Try

        End Function

        '---------------------------------------------------------------------------------------------
        'Nome...........: AbrirConexao.
        'Descricao......: Receber par�metros de conex�o com banco de dados e retornar Conex�o aberta
        '                 com banco de dados.
        'Parametros.....: sConnDB: String contendo par�metros de Conex�o com banco de dados.
        ' Atualiza��es...: [00] - 07/11/2003 - Vers�o Inicial - Autor: Emerson Felipe 
        '---------------------------------------------------------------------------------------------
        Public Function AbrirConexao(ByVal sConnString As String) As SqlConnection

            'Conex�o com banco de dados.
            Dim oConexao As SqlConnection


            Try

                '********************************
                'Abre conex�o com banco de dados.
                '********************************
                oConexao = New SqlConnection(sConnString)

                oConexao.Open()


                Return oConexao

            Catch oErroSQL As SqlException
                Throw New Exception(LimpaString("Erro na abertura da conex�o com banco de dados: " & oErroSQL.Message.ToString), _
                                                oErroSQL.InnerException)
            Catch oErro As Exception
                Throw New Exception(LimpaString("Retorno-" & oErro.Message.ToString), _
                                                oErro.InnerException)
            End Try

        End Function
        '---------------------------------------------------------------------------------------------
        'Nome...........: AbrirDataReader.
        'Descricao......: Receber par�metros de conex�o com banco de dados e retornar DataReader contendo
        '                 dados retornados pelo comando SQL informado.
        'Parametros.....: sXMLConnDB: XML contendo par�metros de Conex�o com banco de dados.
        '                 sSQL: Comando SQL a ser executado.
        ' Atualiza��es...: [00] - 07/11/2003 - Vers�o Inicial - Autor: Emerson Felipe 
        '---------------------------------------------------------------------------------------------
        Public Function AbrirDataReader(ByVal sXMLConnDB As String, ByVal sSQL As String) As SqlDataReader

            'Objetos utilizados para leitura dos registros.
            Dim oCommand As New SqlCommand(sSQL)
            Dim oRetorno As SqlDataReader

            Try
                '***************************************
                'Inicializa objeto para execu��o do SQL.
                '***************************************
                'Abre conex�o com banco de dados.
                oCommand.Connection = AbrirConexao(sXMLConnDB)

                'Executa comando SQL.
                oRetorno = oCommand.ExecuteReader(CommandBehavior.CloseConnection)

                Return oRetorno

            Catch oErro As Exception
                'Verifica se conex�o com banco de dados est� ativa.
                If Not oCommand.Connection Is Nothing AndAlso oCommand.Connection.State = ConnectionState.Open Then
                    'Fecha conex�o com banco de dados.
                    oCommand.Connection.Close()
                End If

                'Retorna erro ocorrido.
                Throw New Exception(LimpaString(oErro.Message.ToString), oErro.InnerException)
            End Try

        End Function

        '---------------------------------------------------------------------------------------------
        'Nome...........: AbrirDataSet.
        'Descricao......: Receber par�metros de conex�o com banco de dados e retornar DataSet contendo
        '                 dados retornados pelo comando SQL informado.
        'Parametros.....: sXMLConnDB: XML contendo par�metros de Conex�o com banco de dados.
        '                 sSQL: Comando SQL a ser executado.
        ' Atualiza��es...: [00] - 07/11/2003 - Vers�o Inicial - Autor: Emerson Felipe 
        '---------------------------------------------------------------------------------------------
        Public Function AbrirDataSet(ByVal sXMLConnDB As String, ByVal sSQL As String) As DataSet

            'Objetos utilizados para leitura dos registros.
            Dim oConexao As SqlConnection
            Dim oCommand As SqlDataAdapter
            Dim oRetorno As New DataSet

            Try
                '***************************************
                'Inicializa objeto para execu��o do SQL.
                '***************************************
                'Abre conex�o com banco de dados.
                oConexao = AbrirConexao(sXMLConnDB)

                oCommand = New SqlDataAdapter(sSQL, oConexao)

                'Executa comando SQL e popula DataSet.
                oCommand.Fill(oRetorno)

                Return oRetorno

            Catch oErro As Exception
                'Verifica se conex�o com banco de dados est� ativa.
                If Not oConexao Is Nothing AndAlso oConexao.State = ConnectionState.Open Then
                    'Fecha conex�o com banco de dados.
                    oConexao.Close()
                End If

                'Retorna erro ocorrido.
                Throw New Exception(LimpaString(oErro.Message.ToString), oErro.InnerException)
            End Try

        End Function
        '---------------------------------------------------------------------------------------------
        'Nome...........: ExecutarOperacao.
        'Descricao......: Receber par�metros de conex�o com banco de dados e executar comando SQL informado.
        'Parametros.....: sXMLConnDB: XML contendo par�metros de Conex�o com banco de dados.
        '                 sSQL: Comando SQL a ser executado.
        ' Atualiza��es...: [00] - 07/11/2003 - Vers�o Inicial - Autor: Emerson Felipe 
        '---------------------------------------------------------------------------------------------
        Public Sub ExecutarOperacao(ByVal sXMLConnDB As String, ByVal sSQL As String)

            'Objetos utilizados para leitura dos registros.
            Dim oConexao As SqlConnection
            Dim oCommand As New SqlCommand(sSQL)

            Try
                '***************************************
                'Inicializa objeto para execu��o do SQL.
                '***************************************
                'Abre conex�o com banco de dados.
                oCommand.Connection = AbrirConexao(sXMLConnDB)

                'Executa comando SQL.
                oCommand.ExecuteNonQuery()
                oCommand.Dispose()

            Catch oErro As Exception
                'Verifica se conex�o com banco de dados est� ativa.
                If Not oCommand.Connection Is Nothing AndAlso oCommand.Connection.State = ConnectionState.Open Then
                    'Fecha conex�o com banco de dados.
                    oCommand.Connection.Close()
                End If

                'Retorna erro ocorrido.
                Throw New Exception(LimpaString(oErro.Message.ToString), oErro.InnerException)
            End Try

        End Sub
        '---------------------------------------------------------------------------------------------
        'Nome...........: ExecutarOperacao.
        'Descricao......: Receber par�metros de conex�o com banco de dados e executar comando SQL informado.
        'Parametros.....: sXMLConnDB: XML contendo par�metros de Conex�o com banco de dados.
        '                 sSQL: Comando SQL a ser executado.
        ' Atualiza��es...: [00] - 07/11/2003 - Vers�o Inicial - Autor: Emerson Felipe 
        '---------------------------------------------------------------------------------------------
        Public Function ExecutarOperacao(ByVal sXMLConnDB As String, ByVal sCommandText As String, ByVal strParamField As String(), ByVal strParamValue As String()) As SqlDataReader

            'Objetos utilizados para leitura dos registros.
            Dim oCommand As New SqlCommand
            Dim xArr As Integer
            Dim xMaxArr As Integer = strParamField.Length()


            Dim oADODBParameter As SqlParameter

            Try
                '***************************************
                'Inicializa objeto para execu��o do SQL.
                '***************************************
                'Abre conex�o com banco de dados.
                With oCommand
                    .Connection = AbrirConexao(sXMLConnDB)

                    .CommandType = CommandType.StoredProcedure
                    .CommandText = sCommandText

                    'Adiciona os parametros para executar o SQLCommand
                    If xMaxArr > 0 Then
                        For xArr = 0 To UBound(strParamField)
                            .Parameters.Add(strParamField(xArr), IIf(strParamValue(xArr) = "", DBNull.Value, strParamValue(xArr)))
                        Next xArr
                    End If

                    'Executa comando SQL.                    
                    Return .ExecuteReader(CommandBehavior.CloseConnection)

                End With

                If Not oCommand.Connection Is Nothing AndAlso oCommand.Connection.State = ConnectionState.Open Then
                    'Fecha conex�o com banco de dados.
                    oCommand.Connection.Close()
                    oCommand.Dispose()
                End If


            Catch oErro As Exception
                'Verifica se conex�o com banco de dados est� ativa.
                If Not oCommand.Connection Is Nothing AndAlso oCommand.Connection.State = ConnectionState.Open Then
                    'Fecha conex�o com banco de dados.
                    oCommand.Connection.Close()
                    oCommand.Dispose()
                End If

                'Retorna erro ocorrido.
                Throw New Exception(LimpaString(oErro.Message.ToString), oErro.InnerException)
            End Try

        End Function

        '---------------------------------------------------------------------------------------------
        'Nome...........: ExecutarOperacao.
        'Descricao......: Receber par�metros de conex�o com banco de dados e executar comando SQL informado.
        '                 M�todo utilizado para encapsular transa��o.
        'Parametros.....: sXMLConnDB: XML contendo par�metros de Conex�o com banco de dados.
        '                 sSQL: Comando SQL a ser executado.
        '                 oConexao: Conex�o utilizada para realizar transa��es.
        '                 oTransaction: Transa��o em que opera��o est� encapsulada.
        ' Atualiza��es...: [00] - 07/11/2003 - Vers�o Inicial - Autor: Emerson Felipe 
        '---------------------------------------------------------------------------------------------
        Public Function ExecutarOperacao(ByVal sXMLConnDB As String, ByVal sSQL As String, ByRef oConexao As SqlConnection, ByRef oTransaction As SqlTransaction, ByVal strParamField As String(), ByVal strParamValue As String()) As Object

            'Objetos utilizados para leitura dos registros.
            Dim oCommand As New SqlCommand(sSQL)
            Dim xArr As Integer
            Dim xMaxArr As Integer = strParamField.Length()

            Try
                '***************************************
                'Inicializa objeto para execu��o do SQL.
                '***************************************
                'Abre conex�o com banco de dados.
                With oCommand
                    .Connection = oConexao
                    .Transaction = oTransaction
                    .CommandText = sSQL
                    .CommandType = CommandType.StoredProcedure

                    'Verifica se foram informados par�metros.
                    If xMaxArr > 0 Then
                        For xArr = 0 To UBound(strParamField)
                            .Parameters.Add(strParamField(xArr), IIf(strParamValue(xArr) = "", DBNull.Value, strParamValue(xArr)))
                        Next xArr
                    End If

                    'Executa comando SQL.
                    Return .ExecuteScalar()

                End With

            Catch oErro As Exception

                'Retorna erro ocorrido.
                Throw New Exception(LimpaString(oErro.Message.ToString), oErro.InnerException)
            End Try

        End Function

        '---------------------------------------------------------------------------------------------
        'Nome...........: AbrirDataSet.
        'Descricao......: Receber par�metros de conex�o com banco de dados e retornar DataSet contendo
        '                 dados retornados pelo comando SQL informado.
        'Parametros.....: sXMLConnDB: XML contendo par�metros de Conex�o com banco de dados.
        '                 sSQL: Comando SQL a ser executado.
        ' Atualiza��es...: [00] - 07/11/2003 - Vers�o Inicial - Autor: Emerson Felipe 
        '---------------------------------------------------------------------------------------------
        Public Function AbrirDataSet(ByVal sXMLConnDB As String, ByVal sCommandText As String, ByVal strParamField As String(), ByVal strParamValue As String(), Optional ByVal sNomTabela As String = Nothing) As DataSet

            'Objetos utilizados para leitura dos registros.
            Dim oConexao As SqlConnection
            Dim oSQLAdapter As SqlDataAdapter
            Dim oCommand As SqlCommand
            Dim oRetorno As New DataSet
            Dim xArr As Integer
            Dim xMaxArr As Integer = strParamField.Length()

            Try
                '***************************************
                'Inicializa objeto para execu��o do SQL.
                '***************************************
                'Abre conex�o com banco de dados.
                oConexao = AbrirConexao(sXMLConnDB)
                oCommand = New SqlCommand
                With oCommand
                    .Connection = oConexao
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = sCommandText

                    'Adiciona os parametros para executar o SQLCommand
                    'Dim oColNavegador As IEnumerator = oColParameters.GetEnumerator
                    'oColNavegador.Reset()
                    'While oColNavegador.MoveNext
                    '.Parameters.Add(CType(oColNavegador.Current, SqlParameter))
                    'End While

                    If xMaxArr > 0 Then
                        For xArr = 0 To UBound(strParamField)
                            .Parameters.Add(strParamField(xArr), IIf(strParamValue(xArr) = "", DBNull.Value, strParamValue(xArr)))
                        Next xArr
                    End If

                End With


                oSQLAdapter = New SqlDataAdapter(oCommand)
                With oSQLAdapter
                    'Executa comando SQL e popula DataSet.
                    If IsNothing(sNomTabela) Then
                        .Fill(oRetorno)
                    Else
                        .Fill(oRetorno, sNomTabela)
                    End If

                End With

                Return oRetorno

            Catch oErro As Exception
                'Verifica se conex�o com banco de dados est� ativa.
                If Not oConexao Is Nothing AndAlso oConexao.State = ConnectionState.Open Then
                    'Fecha conex�o com banco de dados.
                    oConexao.Close()
                End If

                'Retorna erro ocorrido.
                Throw New XmlException(LimpaString(oErro.Message.ToString), oErro.InnerException)
            End Try

        End Function

        '---------------------------------------------------------------------------------------------
        'Nome...........: AbrirDataTable.
        'Descricao......: Receber par�metros de conex�o com banco de dados e retornar DataSet contendo
        '                 dados retornados pelo comando SQL informado.
        'Parametros.....: sXMLConnDB: XML contendo par�metros de Conex�o com banco de dados.
        '                 sSQL: Comando SQL a ser executado.
        ' Atualiza��es...: [00] - 28/09/2004 - Vers�o Inicial - Autor: Emerson Felipe 
        '---------------------------------------------------------------------------------------------
        Public Function AbrirDataTable(ByVal sXMLConnDB As String, ByVal sCommandText As String, ByVal strParamField As String(), ByVal strParamValue As String(), Optional ByVal sNomTabela As String = Nothing) As DataTable

            'Objetos utilizados para leitura dos registros.
            Dim oConexao As SqlConnection
            Dim oSQLAdapter As SqlDataAdapter
            Dim oCommand As SqlCommand
            Dim oRetorno As New DataTable
            Dim xArr As Integer
            Dim xMaxArr As Integer = strParamField.Length()

            Try
                '***************************************
                'Inicializa objeto para execu��o do SQL.
                '***************************************
                'Abre conex�o com banco de dados.
                oConexao = AbrirConexao(sXMLConnDB)
                oCommand = New SqlCommand
                With oCommand
                    .Connection = oConexao
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = sCommandText
                    'Adiciona os parametros para executar o SQLCommand

                    If xMaxArr > 0 Then
                        For xArr = 0 To UBound(strParamField)
                            .Parameters.Add(strParamField(xArr), IIf(strParamValue(xArr) = "", DBNull.Value, strParamValue(xArr)))
                        Next xArr
                    End If

                End With


                oSQLAdapter = New SqlDataAdapter(oCommand)
                With oSQLAdapter
                    'Executa comando SQL e popula DataSet.
                    If IsNothing(sNomTabela) Then
                        .Fill(oRetorno)
                    Else
                        .Fill(oRetorno)
                    End If

                End With

                Return oRetorno

            Catch oErro As Exception
                'Verifica se conex�o com banco de dados est� ativa.
                If Not oConexao Is Nothing AndAlso oConexao.State = ConnectionState.Open Then
                    'Fecha conex�o com banco de dados.
                    oConexao.Close()
                End If

                'Retorna erro ocorrido.
                Throw New XmlException(LimpaString(oErro.Message.ToString), oErro.InnerException)
            End Try

        End Function
        '---------------------------------------------------------------------------------------------
        'Nome...........: AbrirDataTable.
        'Descricao......: Receber par�metros de conex�o com banco de dados e retornar DataSet contendo
        '                 dados retornados pelo comando SQL informado.
        'Parametros.....: sXMLConnDB: XML contendo par�metros de Conex�o com banco de dados.
        '                 sSQL: Comando SQL a ser executado.
        ' Atualiza��es...: [00] - 28/09/2004 - Vers�o Inicial - Autor: Emerson Felipe 
        '---------------------------------------------------------------------------------------------
        Public Function AbrirDataTable(ByVal sXMLConnDB As String, ByVal sSQL As String) As DataTable

            'Objetos utilizados para leitura dos registros.
            Dim oConexao As SqlConnection
            Dim oCommand As SqlDataAdapter
            Dim oRetorno As New DataTable


            Try
                '***************************************
                'Inicializa objeto para execu��o do SQL.
                '***************************************
                'Abre conex�o com banco de dados.
                oConexao = AbrirConexao(sXMLConnDB)

                oCommand = New SqlDataAdapter(sSQL, oConexao)

                'Executa comando SQL e popula DataSet.
                oCommand.Fill(oRetorno)

                Return oRetorno

            Catch oErro As Exception
                'Verifica se conex�o com banco de dados est� ativa.
                If Not oConexao Is Nothing AndAlso oConexao.State = ConnectionState.Open Then
                    'Fecha conex�o com banco de dados.
                    oConexao.Close()
                End If

                'Retorna erro ocorrido.
                Throw New Exception(LimpaString(oErro.Message.ToString), oErro.InnerException)
            End Try

        End Function

        Public Function LimpaString(ByVal sString) As String
            Dim sRetorno As String = ""
            Dim Servidor As String = ""
            sRetorno = Replace(sString, ":", "")
            sRetorno = Replace(sRetorno, "'", "")
            sRetorno = Replace(sRetorno, "=", "")
            sRetorno = Replace(sRetorno, "&", "")
            sRetorno = Replace(sRetorno, ">", "")
            sRetorno = Replace(sRetorno, "<", "")
            'sRetorno = Replace(sRetorno, ".sServidor-" & System.Web.HttpContext.Current.Session("DataSource"), "")
            'sRetorno = sRetorno & "   .sServidor-" & System.Web.HttpContext.Current.Session("DataSource")
            Return sRetorno
        End Function

        Protected Overrides Sub Finalize()
            MyBase.Finalize()

        End Sub
    End Class

End Namespace

