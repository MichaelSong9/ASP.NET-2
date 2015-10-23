Imports Empresa.Modelos
Imports Empresa.BLL
Imports System.Data.Common

Public Class clienteForm

    Private Sub incluirButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles incluirButton.Click
        Try
            Dim cliente As New ClienteInfo
            cliente.Nome = nomeTextBox.Text
            cliente.Endereco = enderecoTextBox.Text

            Dim obj As New ClienteBLL
            codigoLabel.Text = obj.Incluir(cliente).ToString()

            MessageBox.Show("Operação concluída com sucesso", _
            "Aviso", MessageBoxButtons.OK, _
            MessageBoxIcon.Information)

            'TODO: LimparTela
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Alerta de Erro", _
            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub procurarPorNomeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles procurarPorNomeButton.Click
        Try
            Dim nomeCli As String = _
            InputBox("Informe o nome", "Procurar por Nome")

            Dim obj As New ClienteBLL
            Dim dr As DbDataReader

            dr = obj.ProcurarPorNome(nomeCli)

            If dr.Read() Then
                codigoLabel.Text = dr("Codigo").ToString()
                nomeTextBox.Text = dr("Nome").ToString()
                enderecoTextBox.Text = dr("Endereco").ToString()
            Else
                MessageBox.Show("Nome não localizado", "Alerta", _
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                'TODO:LimparTela
            End If
            dr.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Alerta de Erro", _
            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub alterarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles alterarButton.Click
        Try
            Dim cliente As New ClienteInfo
            cliente.Codigo = Integer.Parse(codigoLabel.Text)
            cliente.Nome = nomeTextBox.Text
            cliente.Endereco = enderecoTextBox.Text

            Dim obj As New ClienteBLL
            obj.Alterar(cliente)

            MessageBox.Show("Operação concluída com sucesso", _
            "Aviso", MessageBoxButtons.OK, _
            MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Alerta de Erro", _
            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub excluirButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles excluirButton.Click
        Try
            Dim cliente As New ClienteInfo
            cliente.Codigo = Integer.Parse(codigoLabel.Text)

            Dim obj As New ClienteBLL
            obj.Excluir(cliente)

            MessageBox.Show("Operação concluída com sucesso", _
            "Aviso", MessageBoxButtons.OK, _
            MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Alerta de Erro", _
            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

End Class
