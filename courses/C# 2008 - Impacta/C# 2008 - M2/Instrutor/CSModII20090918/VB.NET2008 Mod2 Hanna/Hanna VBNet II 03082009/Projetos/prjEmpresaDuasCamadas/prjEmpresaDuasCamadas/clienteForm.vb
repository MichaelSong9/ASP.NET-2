Imports System.Data.SqlClient

Public Class clienteForm

    Private Sub procurarPorNomeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles procurarPorNomeButton.Click
        Dim nomeCli As String = _
        InputBox("Informe o nome para pesquisa", _
        "Buscar por Nome")

        If nomeCli.Trim() = "" Then Exit Sub

        Dim cn As New SqlConnection(Dados.StringDeConexao())

        Dim cmd As New SqlCommand
        cmd.Connection = cn
        cmd.CommandText = "pCliente_SelectPorNome"
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@nome", nomeCli)

        Dim dr As SqlDataReader

        Try
            cn.Open()
            dr = cmd.ExecuteReader()

            If dr.Read() Then
                codigoLabel.Text = dr("Codigo").ToString()
                nomeTextBox.Text = dr("Nome").ToString()
                enderecoTextBox.Text = dr("Endereco").ToString()
            Else
                MessageBox.Show("Nome não localizado")
                'TODO: LimparTela
            End If
            dr.Close()
            cn.Close()
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Alerta de Erro", _
            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub alterarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles alterarButton.Click
        If Not Geral.TestarVazio(codigoLabel) Then Exit Sub
        If Not Geral.TestarVazio(nomeTextBox) Then Exit Sub
        If Not Geral.TestarVazio(enderecoTextBox) Then Exit Sub

        Dim cn As New SqlConnection(Dados.StringDeConexao())

        Dim cmd As New SqlCommand
        cmd.Connection = cn
        cmd.CommandText = "pCliente_Update"
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@codigo", _
                codigoLabel.Text)
        cmd.Parameters.AddWithValue("@nome", _
                nomeTextBox.Text)
        cmd.Parameters.AddWithValue("@endereco", _
                enderecoTextBox.Text)

        Try
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()

            'Atualizar o Grid
            ClienteDataGridView.Rows.Clear()
            clienteForm_Load(Nothing, Nothing)

            MessageBox.Show("Operação concluída com sucesso")
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Alerta de Erro", _
            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub inserirButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles inserirButton.Click
        If Not Geral.TestarVazio(nomeTextBox) Then Exit Sub
        If Not Geral.TestarVazio(enderecoTextBox) Then Exit Sub

        Dim cn As New SqlConnection(Dados.StringDeConexao())

        Dim cmd As New SqlCommand
        cmd.Connection = cn
        cmd.CommandText = "pCliente_Insert"
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@nome", nomeTextBox.Text)
        cmd.Parameters.AddWithValue("@endereco", enderecoTextBox.Text)

        Dim codigoNovo As SqlParameter = _
                cmd.Parameters.Add("@codigo", _
                SqlDbType.Int, 0, "Codigo")
        codigoNovo.Direction = ParameterDirection.Output

        Try
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()

            codigoLabel.Text = codigoNovo.Value.ToString()

            'Atualizar o Grid
            ClienteDataGridView.Rows.Clear()
            clienteForm_Load(Nothing, Nothing)

            MessageBox.Show("Operação concluída com sucesso")
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Alerta de Erro", _
            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub excluirButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles excluirButton.Click
        If MessageBox.Show("Deseja meixmo excluir o registro?", _
        "Alerta de Exclusão", MessageBoxButtons.YesNo, _
        MessageBoxIcon.Question, _
        MessageBoxDefaultButton.Button2) = _
        Windows.Forms.DialogResult.No Then Exit Sub

        If Not Geral.TestarVazio(codigoLabel) Then Exit Sub

        Dim cn As New SqlConnection(Dados.StringDeConexao())

        Dim cmd As New SqlCommand
        cmd.Connection = cn
        cmd.CommandText = "pCliente_Delete"
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@codigo", codigoLabel.Text)
        Try
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()

            'Atualizar o Grid
            ClienteDataGridView.Rows.Clear()
            clienteForm_Load(Nothing, Nothing)

            MessageBox.Show("Operação concluída com sucesso")
            'TODO: LimparTela
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Alerta de Erro", _
            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub clienteForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Using cn As New SqlConnection(Dados.StringDeConexao())
            Dim cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandText = "pCliente_Select"
            cmd.CommandType = CommandType.StoredProcedure

            Dim dr As SqlDataReader
            Try
                cn.Open()
                dr = cmd.ExecuteReader()
                Do While dr.Read()
                    ClienteDataGridView.Rows.Add( _
                    dr("Codigo").ToString(), _
                    dr("Nome").ToString(), _
                    dr("Endereco").ToString())
                Loop
                dr.Close()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, "Alerta de Erro", _
                MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub ClienteDataGridView_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ClienteDataGridView.DoubleClick
        codigoLabel.Text = ClienteDataGridView.Rows( _
            ClienteDataGridView.CurrentCell.RowIndex). _
            Cells(0).Value.ToString()

        nomeTextBox.Text = ClienteDataGridView.Rows( _
            ClienteDataGridView.CurrentCell.RowIndex). _
            Cells(1).Value.ToString()

        enderecoTextBox.Text = ClienteDataGridView.Rows( _
            ClienteDataGridView.CurrentCell.RowIndex). _
            Cells(2).Value.ToString()
    End Sub
End Class
