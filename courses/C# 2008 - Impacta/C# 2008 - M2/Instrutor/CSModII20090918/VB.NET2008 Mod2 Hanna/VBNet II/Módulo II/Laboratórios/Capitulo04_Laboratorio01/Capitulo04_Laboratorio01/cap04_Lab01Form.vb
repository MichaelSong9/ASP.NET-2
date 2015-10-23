Imports System.Data.SqlClient

Public Class cap04_Lab01Form

    Private Sub LimparTela()

    End Sub

    Private Sub excluirButton_Click(ByVal sender As System.Object, _
                                ByVal e As System.EventArgs) Handles excluirButton.Click

        If MessageBox.Show("Deseja excluir este veículo?", "Alerta de Exclusão", _
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question, _
                           MessageBoxDefaultButton.Button2) = DialogResult.No Then
            Exit Sub
        End If

        'Estabelecer a conexão
        Dim cn As New SqlConnection()
        cn.ConnectionString = _
                "Integrated Security=SSPI;Persist Security Info=False;" & _
                "Initial Catalog=Oficina;Data Source=.\sqlexpress"

        'Definir o comando
        Dim cmd As New SqlCommand()
        cmd.Connection = cn

        'Definir a instrução SQL
        Dim instrucaoSQL As String = _
        String.Format("Delete Veiculo Where Placa = '{0}'", _
                            placaTextBox.Text)

        cmd.CommandText = instrucaoSQL
        cmd.CommandType = CommandType.Text

        'Executar()
        Try
            'Abrir a conexão
            cn.Open()

            'Executar o comando
            cmd.ExecuteNonQuery()

            'Limpar Tela
            LimparTela()

            'Confirmar a operação
            MessageBox.Show("Operação concluída com sucesso", "Aviso", _
                MessageBoxButtons.OK, MessageBoxIcon.Information)

            'Fechar a conexão
            cn.Close()
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Alerta de Erro - " & ex.Number, _
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub procurarButton_Click(ByVal sender As System.Object, _
                                ByVal e As System.EventArgs) Handles procurarButton.Click

        Dim cn As New SqlConnection()
        cn.ConnectionString = _
                    "Integrated Security=SSPI;Persist Security Info=False;" & _
                    "Initial Catalog=Oficina;Data Source=.\sqlexpress"

        'Definir o comando
        Dim cmd As New SqlCommand()
        cmd.Connection = cn

        'Definir a instrução SQL
        Dim instrucaoSQL As String = _
            String.Format("Select * From Veiculo Where Placa = '{0}'", _
                                placaTextBox.Text)

        cmd.CommandText = instrucaoSQL
        cmd.CommandType = CommandType.Text

        'Definir o DataReader
        Dim dr As SqlDataReader

        'Executar
        Try
            'Abrir a conexão
            cn.Open()

            'Executar o comando
            dr = cmd.ExecuteReader()

            If dr.Read() Then
                placaTextBox.Text = dr("placa").ToString()
                modeloTextBox.Text = dr("modelo").ToString()
                corTextBox.Text = dr("cor").ToString()
                anoTextBox.Text = dr("ano").ToString()

                placaTextBox.Focus()
                placaTextBox.SelectAll()

                'Confirmar a operação
                MessageBox.Show("Operação concluída com sucesso", "Aviso", _
                    MessageBoxButtons.OK, MessageBoxIcon.Information)

                'Fechar a conexão
                cn.Close()

            Else
                MessageBox.Show("Veículo não localizado", "Alerta", _
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Alerta de Erro - " & ex.Number, _
                             MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
