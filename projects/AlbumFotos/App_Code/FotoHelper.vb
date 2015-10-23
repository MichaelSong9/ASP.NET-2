Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient


Public Class FotoHelper

    Shared sConexaoBD As String

    Shared Sub New()
        sConexaoBD = "Data Source=.\SQLEXPRESS;AttachDbFilename=C:\1aspn\AlbumFotos\App_Data\Album.mdf;Integrated Security=True;User Instance=True"
        'ConfigurationManager.ConnectionStrings("conexaoBD").ConnectionString
    End Sub

    Public Shared Function Inserir(ByVal f As Foto) As Integer

        'cria uma nova conexao e um objeto command
        Dim cnn As New SqlConnection(sConexaoBD)
        Dim cmd As New SqlCommand()

        'define a conexão e a string sql para incluir dados na tabela
        cmd.Connection = cnn
        cmd.CommandText = "INSERT INTO Fotos(titulo,descricao,foto) values(@titulo,@descricao,@foto)"

        'Define e obtem os valores dos parametros
        Dim titulo As New SqlParameter("@titulo", f.Titulo)
        Dim descricao As New SqlParameter("@descricao", f.Descricao)
        Dim foto As New SqlParameter("@foto", SqlDbType.VarBinary)
        foto.Value = f.FotoDados

        'inclui os valores dos parametros
        cmd.Parameters.Add(titulo)
        cmd.Parameters.Add(descricao)
        cmd.Parameters.Add(foto)

        'abre a conexão e executa a consulta SQL retornando um inteiro : 1 se bem sucedido -1 se houver erro
        cnn.Open()
        Dim i As Integer = cmd.ExecuteNonQuery()

        'fecha a conexão
        cnn.Close()

        'retorna o valor obtido na execução da consulta sql via 
        Return i

    End Function
    Public Shared Function Atualizar(ByVal f As Foto) As Integer
        'cria uma nova conexao e um objeto command
        Dim cnn As New SqlConnection(sConexaoBD)
        Dim cmd As New SqlCommand()

        'define a conexão e a string sql para incluir dados na tabela
        cmd.Connection = cnn
        cmd.CommandText = "UPDATE fotos SET titulo=@titulo,descricao= @descricao,foto=@foto where fotoid=@fotoid"

        'Define e obtem os valores dos parametros
        Dim titulo As New SqlParameter("@titulo", f.Titulo)
        Dim descricao As New SqlParameter("@descricao", f.Descricao)
        Dim foto As New SqlParameter("@foto", SqlDbType.VarBinary)
        foto.Value = f.FotoDados

        Dim fotoid As New SqlParameter("@fotoid", f.FotoID)

        'inclui os valores dos parametros
        cmd.Parameters.Add(titulo)
        cmd.Parameters.Add(descricao)
        cmd.Parameters.Add(foto)
        cmd.Parameters.Add(fotoid)

        'abre a conexão e executa a consulta SQL retornando um inteiro : 1 se bem sucedido -1 se houver erro
        cnn.Open()
        Dim i As Integer = cmd.ExecuteNonQuery()
        'fecha a conexão
        cnn.Close()
        'retorna o valor obtido na execução da consulta sql via 
        Return i
    End Function

    Public Shared Function Deletar(ByVal fotoid As Integer) As Integer

        'cria uma nova conexao e um objeto command
        Dim cnn As New SqlConnection(sConexaoBD)
        Dim cmd As New SqlCommand()

        'define a conexão e a string sql para incluir dados na tabela
        cmd.Connection = cnn
        cmd.CommandText = "DELETE FROM fotos where fotoid=@fotoid"

        'Define e obtem os valores dos parametros
        Dim codigo As New SqlParameter("@fotoid", fotoid)
        cmd.Parameters.Add(codigo)

        'abre a conexão e executa a consulta SQL retornando um inteiro : 1 se bem sucedido 
        cnn.Open()
        Dim i As Integer = cmd.ExecuteNonQuery()

        'fecha a conexão
        cnn.Close()

        'retorna o valor obtido na execução da consulta sql via 
        Return i
    End Function

    Public Shared Function getFotos() As List(Of Foto)
        'cria uma nova conexao e um objeto command
        Dim cnn As New SqlConnection(sConexaoBD)
        Dim cmd As New SqlCommand()

        'define uma variavel como uma lista de fotos
        '
        Dim fotos As New List(Of Foto)()
        Dim data As Byte() = New Byte(999) {}

        'defina a instrução SQL para selecionar as fotos pelo codigo
        cmd.CommandText = "select * from Fotos order by fotoid"
        cmd.Connection = cnn

        'abre a conexão e executa o comando
        cnn.Open()
        Dim reader As SqlDataReader = cmd.ExecuteReader()

        'percorre o datareader e preenche a lista de fotos a partir do objeto Foto
        While reader.Read()
            Dim p As New Foto()
            p.FotoID = reader.GetInt32(reader.GetOrdinal("FotoID"))
            p.Titulo = reader.GetString(reader.GetOrdinal("Titulo"))
            p.Descricao = reader.GetString(reader.GetOrdinal("Descricao"))
            p.FotoDados = DirectCast(reader.GetValue(reader.GetOrdinal("Foto")), Byte())
			
		    'p.FotoDados = CType(reader.GetValue(reader.GetOrdinal("Foto")), Byte())
			
			
            fotos.Add(p)
        End While

        'fecha a conexao e retorna as fotos
        cnn.Close()
        Return fotos
    End Function
    Public Shared Function getFotoPorCodigo(ByVal fotoid As Integer) As Foto

        Dim cnn As SqlConnection = New SqlConnection(sConexaoBD)
        Dim cmd As SqlCommand = New SqlCommand()
        Dim data() As Byte = New Byte(1000) {}

        cmd.CommandText = "select * from Fotos where FotoID= @fotoid"
        cmd.Connection = cnn

        Dim pId As SqlParameter = New SqlParameter("@fotoid", fotoid)
        cmd.Parameters.Add(pId)

        'abre a conexão e executa o comando
        cnn.Open()
        Dim reader As SqlDataReader = cmd.ExecuteReader()

        Dim p As Foto = New Foto()
        'percorre o datareader e preenche a lista de fotos a partir do objeto Foto
        While reader.Read()
            p.FotoID = reader.GetInt32(reader.GetOrdinal("FotoID"))
            p.Titulo = reader.GetString(reader.GetOrdinal("Titulo"))
            p.Descricao = reader.GetString(reader.GetOrdinal("Descricao"))
            p.FotoDados = CType(reader.GetValue(reader.GetOrdinal("Foto")), Byte())
        End While

        'fecha a conexao e retorna a foto
        cnn.Close()
        Return p
    End Function


End Class
