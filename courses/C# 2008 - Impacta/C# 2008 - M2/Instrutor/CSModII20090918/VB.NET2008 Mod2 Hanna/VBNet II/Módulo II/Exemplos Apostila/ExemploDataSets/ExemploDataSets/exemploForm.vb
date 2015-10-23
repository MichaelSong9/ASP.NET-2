Imports System.Data.SqlClient

Public Class exemploForm

    Private Sub exemploButton_Click(ByVal sender As System.Object, _
                                ByVal e As System.EventArgs) Handles exemploButton.Click

        'Definir a string de conexão
        Dim stringDeConexao As String = _
            "Integrated Security=SSPI;Persist Security Info=False;" & _
            "Initial Catalog=LojaSQL;Data Source=.\sqlexpress"

        'Definir a instrução SQL que será executada

        Dim instrucaoSQL As String = String.Format("Select * From Cliente Where Nome = '{0}' Order By 1", _
        pesquisarTextBox.Text)

        'Executar
        Try

            'Definir o DataAdapter
            Dim da As New SqlDataAdapter(instrucaoSQL, stringDeConexao)

            'Definir o DataSet
            Dim ds As New DataSet()

            'Preencher o DataSet a partir do DataAdapter
            da.Fill(ds)

            emailAtualLabel.Text = ds.Tables(0).Rows(0).Item("Email")
            ds.Tables(0).Rows(0).Item("Email") = novoEmailTextBox.Text

            Dim comBuilder As New SqlCommandBuilder(da)
            comBuilder.DataAdapter.Update(ds)

            'Popular o ListBox
            exemploListBox.Items.Clear()
            For Each registro As DataRow In ds.Tables(0).Rows
                exemploListBox.Items.Add("Nome: " & registro.Item("Nome").ToString().ToUpper())
                exemploListBox.Items.Add("Email: " & registro.Item("Email").ToString().ToUpper())
            Next

            'Confirmar a operação
            MessageBox.Show("Pesquisa concluída com sucesso", "Aviso", _
                MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Alerta de Erro", _
                MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class
