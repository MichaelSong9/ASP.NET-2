Imports System.IO

Public Class cepForm

    Private Sub gerarBaseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gerarBaseButton.Click
        Dim sr As New StreamReader("C:\CEP.txt")
        Dim sw As New StreamWriter("C:\CEPDelimitado.txt", True)
        Dim registro As String = ""
        Dim dados As String = ""

        Dim cep, logradouro, bairro, cidade, uf, tipo As String

        Do While Not sr.EndOfStream
            dados = sr.ReadLine()

            cep = dados.Substring(0, 8).Trim()
            logradouro = dados.Substring(8, 72).Trim()
            bairro = dados.Substring(80, 72).Trim()
            cidade = dados.Substring(152, 60).Trim()
            uf = dados.Substring(212, 2).Trim()
            tipo = dados.Substring(214, 30).Trim()

            registro = String.Format("{0};{1};{2};{3};{4};{5}", _
            cep, tipo, logradouro, bairro, cidade, uf)

            sw.WriteLine(registro)
        Loop
        sr.Close()
        sw.Close()

        MessageBox.Show("operação concluída")
        gerarBaseButton.Enabled = False
        'Todo: Testar  se o arquivo Delimitado já existe
    End Sub

    Private Sub cepTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cepTextBox.KeyPress
        Try
            If e.KeyChar = Chr(13) Then
                Dim nCep As String = Geral.TestarVazio(cepTextBox)

                Dim dados(5) As String
                Dim sr As New StreamReader("C:\CEPDelimitado.txt")

                Do While Not sr.EndOfStream
                    dados = sr.ReadLine().Split(";")
                    If dados(0) = nCep Then
                        viaTextBox.Text = dados(1)
                        logradouroTextBox.Text = dados(2)
                        bairroTextBox.Text = dados(3)
                        cidadeTextBox.Text = dados(4)
                        ufTextBox.Text = dados(5)

                        sr.Close()
                        Exit Sub
                    End If
                Loop
                sr.Close()
                MessageBox.Show("CEP não localizado")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Alerta de Erro", _
            MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub
End Class
