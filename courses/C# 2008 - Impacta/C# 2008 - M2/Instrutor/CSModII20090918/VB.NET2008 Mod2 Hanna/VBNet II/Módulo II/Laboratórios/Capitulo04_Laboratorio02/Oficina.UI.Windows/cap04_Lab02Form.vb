Imports Oficina.Modelos
Imports Oficina.BLL
Imports System.Data.Common

Public Class cap04_Lab02Form

    Private Sub LimparTela()
        For Each ctl As Control In Me.Controls
            If TypeOf ctl Is TextBox Then
                ctl.Text = ""
            End If
        Next
        placaTextBox.Focus()
    End Sub

    Private Sub inserirButton_Click(ByVal sender As System.Object, _
                            ByVal e As System.EventArgs) Handles inserirButton.Click

        Try
            Dim veiculo As New VeiculoInfo()

            veiculo.Placa = placaTextBox.Text
            veiculo.Modelo = modeloTextBox.Text
            veiculo.Cor = corTextBox.Text
            veiculo.Ano = Convert.ToInt16(anoTextBox.Text)

            Dim obj As New VeiculoBLL()
            obj.Incluir(veiculo)

            MessageBox.Show("Veículo cadastrado com sucesso", "Aviso", _
                MessageBoxButtons.OK, MessageBoxIcon.Information)

            'Limpar a tela
            LimparTela()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Alerta de Erro", _
                MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub procurarButton_Click(ByVal sender As System.Object, _
                            ByVal e As System.EventArgs) Handles procurarButton.Click

        Try
            Dim obj As New VeiculoBLL()
            Dim dr As DbDataReader = obj.PesquisarPorPlaca(placaTextBox.Text)

            If (dr.Read()) Then
                modeloTextBox.Text = dr("modelo").ToString()
                corTextBox.Text = dr("cor").ToString()
                anoTextBox.Text = dr("ano").ToString()

                placaTextBox.Focus()
                placaTextBox.SelectAll()
            Else
                LimparTela()

                MessageBox.Show("Veículo não cadastrado", "Alerta", _
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            dr.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Alerta de Erro", _
                    MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub alterarButton_Click(ByVal sender As System.Object, _
                            ByVal e As System.EventArgs) Handles alterarButton.Click

        Try
            Dim veiculo As New VeiculoInfo()

            veiculo.Placa = placaTextBox.Text
            veiculo.Modelo = modeloTextBox.Text
            veiculo.Cor = corTextBox.Text
            veiculo.Ano = Convert.ToInt16(anoTextBox.Text)

            Dim obj As New VeiculoBLL()
            obj.Alterar(veiculo)

            MessageBox.Show("Veículo alterado com sucesso", "Aviso", _
                MessageBoxButtons.OK, MessageBoxIcon.Information)

            placaTextBox.Focus()
            placaTextBox.SelectAll()

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Alerta de Erro", _
                MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub excluirButton_Click(ByVal sender As System.Object, _
                                ByVal e As System.EventArgs) Handles excluirButton.Click

        Dim resposta As DialogResult = _
                        MessageBox.Show("Deseja excluir este veículo?", "Alerta", _
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, _
                        MessageBoxDefaultButton.Button2)

        If resposta = DialogResult.No Then
            Exit Sub
        End If

        Try
            Dim veiculo As New VeiculoInfo()

            veiculo.Placa = placaTextBox.Text

            Dim obj As New VeiculoBLL()
            obj.Excluir(veiculo)

            MessageBox.Show("Veículo excluído com sucesso", "Aviso", _
                    MessageBoxButtons.OK, MessageBoxIcon.Information)

            LimparTela()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Alerta de Erro", _
                    MessageBoxButtons.OK, MessageBoxIcon.Error)

            'Obs.: Erro 547 é conflito de chave estrangeira
        End Try
    End Sub

End Class
