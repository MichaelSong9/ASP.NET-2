Imports System.Data.OracleClient
Imports System.Xml
Imports System.Text
Imports System.Data

Namespace ConexaoBanco
    Public Class clsOracleServer20
        '---------------------------------------------------------------------------------------------
        'Nome...........: AbrirConexao.
        'Descricao......: Receber par�metros de conex�o com banco de dados e retornar Conex�o aberta
        '                 com banco de dados.
        'Parametros.....: sXMLConnDB: XML contendo par�metros de Conex�o com banco de dados.
        ' Atualiza��es...: [00] - 07/11/2003 - Vers�o Inicial - Autor: Emerson Felipe 
        '---------------------------------------------------------------------------------------------
        'sStrConn	= "<?xml version='1.0' encoding='windows-1252'?><conexao server='cclsql' user='matprima' passwd='" & sSenhaCrip & "' usuarioapp='" & sCodUsuario & "' senha_cripto='S' />"
        'string strConn = "user id=matprima;data source=CCLSQL;persist security info=False;initial catalog=Materia_Prima;password=lilian";
        Public Function AbrirConexao(ByVal sXMLConnDB As XmlDocument) As OracleConnection

            'Vari�veis utilizadas na manipula��o do XML de entrada.
            Dim oXML As XmlDocument

            'Conex�o com banco de dados.
            Dim oConexao As OracleConnection

            'Connection String com banco de dados.
            Dim sConnString As New OracleConnectionStringBuilder
            Try


                '***************************
                'Monta a Connection String.
                '***************************
                '   With oXML.DocumentElement.Attributes
                '    sConnString.Append("Data Source=")
                '    sConnString.Append(.GetNamedItem("dsn").Value.ToString())
                '    sConnString.Append(";Initial Catalog=")
                '    sConnString.Append(.GetNamedItem("db").Value.ToString())
                '    sConnString.Append(";User id=")
                '    sConnString.Append(.GetNamedItem("user").Value.ToString())
                '    sConnString.Append(";Password=")
                '    sConnString.Append(.GetNamedItem("passwd").Value.ToString())
                '    sConnString.Append(";")


                '       Dim builder As New System.Data. _ OracleClient.OracleConnectionStringBuilder builder("Data Source") = "OracleDemo" builder("Integrated Security") = True builder("User ID") = "Mary;NewValue=Bad" System.Diagnostics.Debug.WriteLine(builder.ConnectionString)
                '   End With

                '********************************
                'Abre conex�o com banco de dados.
                '********************************

                oConexao.Close()

                oConexao = New OracleConnection(sConnString.ToString())
                oConexao.Open()

                Return oConexao

            Catch oErroXML As XmlException
                Throw New Exception(LimpaString("Erro na interpreta��o do arquivo XML com par�metros para conex�o: " & oErroXML.Message.ToString), _
                                                oErroXML.InnerException)
            Catch oErroSQL As OracleException
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
        Public Function AbrirConexao(ByVal sConnString As String) As OracleConnection

            'Conex�o com banco de dados.
            Dim oConexao As OracleConnection


            Try

                '********************************
                'Abre conex�o com banco de dados.
                '********************************
                oConexao = New OracleConnection(sConnString)

                oConexao.Open()


                Return oConexao

            Catch oErroSQL As OracleException
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
        Public Function AbrirDataReader(ByVal sXMLConnDB As String, ByVal sSQL As String) As OracleDataReader

            'Objetos utilizados para leitura dos registros.
            Dim oCommand As New OracleCommand(sSQL)
            Dim oRetorno As OracleDataReader

            Try
                '***************************************
                'Inicializa objeto para execu��o do SQL.
                '***************************************
                'Abre conex�o com banco de dados.
                oCommand.Connection = AbrirConexao(sXMLConnDB)

                'Executa comando SQL.
                oRetorno = oCommand.ExecuteReader(CommandBehavior.CloseConnection)
                oCommand.Connection.Close()
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
            Dim oConexao As OracleConnection
            Dim oCommand As OracleDataAdapter
            Dim oRetorno As New DataSet

            Try
                '***************************************
                'Inicializa objeto para execu��o do SQL.
                '***************************************
                'Abre conex�o com banco de dados.
                oConexao = AbrirConexao(sXMLConnDB)

                oCommand = New OracleDataAdapter(sSQL, oConexao)

                'Executa comando SQL e popula DataSet.
                oCommand.Fill(oRetorno)
                oConexao.Close()

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
            Dim oConexao As OracleConnection
            Dim oCommand As New OracleCommand(sSQL)

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
        Public Function ExecutarOperacao(ByVal sXMLConnDB As String, ByVal sCommandText As String, ByVal strParamField As String(), ByVal strParamValue As String()) As OracleDataReader

            'Objetos utilizados para leitura dos registros.
            Dim oCommand As New OracleCommand
            Dim xArr As Integer
            Dim xMaxArr As Integer = strParamField.Length()
            Dim oADODBParameter As OracleParameter

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
                            ' .Parameters.Add(strParamField(xArr), IIf(strParamValue(xArr) = "", DBNull.Value, strParamValue(xArr)))
                            .Parameters.Add(New OracleParameter(strParamField(xArr), IIf(strParamValue(xArr) = "", DBNull.Value, strParamValue(xArr))))
                            '       .Parameters.AddWithValue("RETORNO", OracleType.Cursor).Direction = ParameterDirection.Output
                        Next xArr
                    End If

                    'Executa comando SQL.      
                    .Parameters.Add(New OracleParameter("RETORNO", OracleType.Cursor)).Direction = ParameterDirection.Output

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
        Public Function ExecutarOperacao(ByVal sXMLConnDB As String, ByVal sSQL As String, ByRef oConexao As OracleConnection, ByRef oTransaction As OracleTransaction, ByVal strParamField As String(), ByVal strParamValue As String()) As Object

            'Objetos utilizados para leitura dos registros.
            Dim oCommand As New OracleCommand(sSQL)
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

        Public Function ExecutarOperacaoSemRetorno(ByVal sXMLConnDB As String, ByVal sCommandText As String, ByVal strParamField As String(), ByVal strParamValue As String()) As OracleDataReader
            'Objetos utilizados para leitura dos registros.
            Dim oCommand As New OracleCommand
            Dim xArr As Integer
            Dim xMaxArr As Integer = strParamField.Length()
            Dim oADODBParameter As OracleParameter

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
                            ' .Parameters.Add(strParamField(xArr), IIf(strParamValue(xArr) = "", DBNull.Value, strParamValue(xArr)))
                            .Parameters.Add(New OracleParameter(strParamField(xArr), IIf(strParamValue(xArr) = "", DBNull.Value, strParamValue(xArr))))
                            '       .Parameters.AddWithValue("RETORNO", OracleType.Cursor).Direction = ParameterDirection.Output
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
        'Nome...........: AbrirDataSet.
        'Descricao......: Receber par�metros de conex�o com banco de dados e retornar DataSet contendo
        '                 dados retornados pelo comando SQL informado.
        'Parametros.....: sXMLConnDB: XML contendo par�metros de Conex�o com banco de dados.
        '                 sSQL: Comando SQL a ser executado.
        ' Atualiza��es...: [00] - 07/11/2003 - Vers�o Inicial - Autor: Emerson Felipe 
        '---------------------------------------------------------------------------------------------
        Public Function AbrirDataSet(ByVal sXMLConnDB As String, ByVal sCommandText As String, ByVal strParamField As String(), ByVal strParamValue As String(), Optional ByVal sNomTabela As String = Nothing) As DataSet

            'Objetos utilizados para leitura dos registros.
            Dim oConexao As OracleConnection
            Dim oSQLAdapter As OracleDataAdapter
            Dim oCommand As OracleCommand
            Dim oRetorno As New DataSet
            Dim xArr As Integer
            Dim xMaxArr As Integer = strParamField.Length()

            Try
                '***************************************
                'Inicializa objeto para execu��o do SQL.
                '***************************************
                'Abre conex�o com banco de dados.
                oConexao = AbrirConexao(sXMLConnDB)
                oCommand = New OracleCommand
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
                            .Parameters.Add(New OracleParameter(strParamField(xArr), IIf(strParamValue(xArr) = "", DBNull.Value, strParamValue(xArr))))
                        Next xArr
                    End If

                    .Parameters.Add(New OracleParameter("RETORNO", OracleType.Cursor)).Direction = ParameterDirection.Output

                End With


                oSQLAdapter = New OracleDataAdapter(oCommand)
                With oSQLAdapter
                    'Executa comando SQL e popula DataSet.
                    If IsNothing(sNomTabela) Then
                        .Fill(oRetorno)
                    Else
                        .Fill(oRetorno, sNomTabela)
                    End If

                End With
                oConexao.Close()
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
            Dim oConexao As OracleConnection
            Dim oSQLAdapter As OracleDataAdapter
            Dim oCommand As OracleCommand
            Dim oRetorno As New DataTable
            Dim xArr As Integer
            Dim xMaxArr As Integer = strParamField.Length()

            Try
                '***************************************
                'Inicializa objeto para execu��o do SQL.
                '***************************************
                'Abre conex�o com banco de dados.
                oConexao = AbrirConexao(sXMLConnDB)
                oCommand = New OracleCommand
                With oCommand
                    .Connection = oConexao
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = sCommandText
                    'Adiciona os parametros para executar o SQLCommand

                    If xMaxArr > 0 Then
                        For xArr = 0 To UBound(strParamField)
                            .Parameters.Add(New OracleParameter(strParamField(xArr), IIf(strParamValue(xArr) = "", DBNull.Value, strParamValue(xArr))))
                            '.Parameters.Add(strParamField(xArr), IIf(strParamValue(xArr) = "", DBNull.Value, strParamValue(xArr)))
                        Next xArr
                    End If

                    .Parameters.Add(New OracleParameter("RETORNO", OracleType.Cursor)).Direction = ParameterDirection.Output

                End With


                oSQLAdapter = New OracleDataAdapter(oCommand)
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
            Dim oConexao As OracleConnection
            Dim oCommand As OracleDataAdapter
            Dim oRetorno As New DataTable

            Try
                '***************************************
                'Inicializa objeto para execu��o do SQL.
                '***************************************
                'Abre conex�o com banco de dados.
                oConexao = AbrirConexao(sXMLConnDB)

                oCommand = New OracleDataAdapter(sSQL, oConexao)

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

