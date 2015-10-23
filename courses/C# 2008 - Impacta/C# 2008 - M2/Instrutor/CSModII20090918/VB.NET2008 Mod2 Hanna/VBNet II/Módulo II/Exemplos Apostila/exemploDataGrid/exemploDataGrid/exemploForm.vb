Imports System.Data.SqlClient

Public Class exemploForm

    Private Sub exemploButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exemploButton.Click
        'Definir a string de conexão
        Dim stringDeConexao As String = _
            "Integrated Security=SSPI;Persist Security Info=False;" & _
            "Initial Catalog=LojaSQL;Data Source=.\sqlexpress"

        'Definir a instrução SQL que será executada
        Dim instrucaoSQL As String = "Select * From Cliente Order By 1"

        'Definir o DataSet
        Dim ds As New DataSet

        'Definir o DataAdapter
        Dim da As New SqlDataAdapter(instrucaoSQL, stringDeConexao)

        'Preencher o DataSet
        da.Fill(ds)

        'Auto ajustar as colunas do DataGridView
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        'Popular o DataGridView
        DataGridView1.DataSource = ds.Tables(0)

    End Sub

    Private Sub exemploForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LojaSQLDataSet.Cliente' table. You can move, or remove it, as needed.
        Me.ClienteTableAdapter.Fill(Me.LojaSQLDataSet.Cliente)

    End Sub
End Class
