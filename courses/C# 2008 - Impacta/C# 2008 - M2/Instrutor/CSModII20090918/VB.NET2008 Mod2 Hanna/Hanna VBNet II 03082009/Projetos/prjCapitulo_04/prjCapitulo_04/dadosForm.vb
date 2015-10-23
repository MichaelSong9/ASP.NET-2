'1 - Diretiva de acesso a dados
Imports System.Data.SqlClient

Public Class dadosForm

    Private Sub conexaoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles conexaoButton.Click
        '2 Definir o objeto de conexão
        Dim cn As New SqlConnection
        cn.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Northwind;Data Source=.\SQLExpress"

        Try
            cn.Open()
            MessageBox.Show("Conexão foi Aberta")

            cn.Close()
            MessageBox.Show("Conexão foi Fechada")
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Alerta de Erro de Conexão", _
            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Alerta de Erro", _
            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub inserirButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles inserirButton.Click
        If String.IsNullOrEmpty(nomeTextBox.Text.Trim()) Then
            MessageBox.Show("Informe um nome")
            nomeTextBox.Focus()
            nomeTextBox.SelectAll()
            Exit Sub
        End If

        If String.IsNullOrEmpty(idadeTextBox.Text.Trim()) Then
            MessageBox.Show("Informe a idade")
            idadeTextBox.Focus()
            idadeTextBox.SelectAll()
            Exit Sub
        End If

        '2 - Definir o objeto de conexão
        Dim cn As New SqlConnection
        cn.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Northwind;Data Source=.\SQLExpress"

        ' Definir a instrução SQL
        Dim instrucaoSQL As String = _
        String.Format("Insert Cliente Values('{0}',{1})", _
        nomeTextBox.Text, idadeTextBox.Text)

        '3 Definir um objeto Command
        Dim cmd As New SqlCommand
        cmd.Connection = cn
        cmd.CommandText = instrucaoSQL
        cmd.CommandType = CommandType.Text

        Try
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()

            MessageBox.Show("Operação concluída com sucesso", _
            "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Alerta de Erro de Conexão", _
            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class

'Classes Fundamentais
'   a.	Connection,
'   b.	Command
'   c.	DataReader

'2.	Objetos fundamentais
'a.	SQLConnection
'i.	    ConnectionString		    Parâmetros da Conexão
'ii.	    Open()			            Abre a conexão
'iii. 	Close()			            Fecha a conexão
'iv.    BeginTransaction()		Inicia uma transação

'b.	SQLCommand
'i.	    Connection			        Associa a conexão a ser utilizada
'ii.	    CommandText		        Instrução SQL / Nome Procedure
'iii.	    CommandType		    Tipo de Instrução (SQL / Procedure)
'iv.	Parameters			        Coleção de Parâmetros
'v.	    Transaction			        Inscreve command numa transação
'vi.	ExecuteNonReader()	INSERT, UPDATE, DELETE
'vii.    ExecuteScalar()		    Funções que retornam valor scalar
'viii.   ExecuteReader()		    SELECT

'   SABENDO ISSO, SE DESENVOLVE QUALQUER APLICAÇÃO
