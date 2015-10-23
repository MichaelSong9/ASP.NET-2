Imports System.Data.SqlClient

Public Class ComboConectaBanco

    Private _conexao As String = ""
    Public Property Conexao() As String
        Get
            Return _conexao
        End Get
        Set(ByVal value As String)
            _conexao = value
        End Set
    End Property

    Private _campo As String = ""
    Public Property Campo() As String
        Get
            Return _campo
        End Get
        Set(ByVal value As String)
            _campo = value
        End Set
    End Property

    Private _tabela As String = ""
    Public Property Tabela() As String
        Get
            Return _tabela
        End Get
        Set(ByVal value As String)
            _tabela = value
        End Set
    End Property

    Private Sub ComboConectaBanco_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Conexao.Trim() = "" Then Exit Sub
        If Tabela.Trim() = "" Then Exit Sub
        If Campo.Trim() = "" Then Exit Sub

        Dim cn As New SqlConnection(Conexao)
        Dim cmd As New SqlCommand( _
        String.Format("Select Distinct {0} From {1} Order By {0}", _
        Campo, Tabela), cn)
        cmd.CommandType = CommandType.Text

        Dim dr As SqlDataReader

        Try
            cn.Open()
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            Do While dr.Read()
                ComboBox1.Items.Add(dr(Campo))
            Loop
        Catch ex As SqlException
            Throw New Exception("Erro")
        End Try
    End Sub
End Class
