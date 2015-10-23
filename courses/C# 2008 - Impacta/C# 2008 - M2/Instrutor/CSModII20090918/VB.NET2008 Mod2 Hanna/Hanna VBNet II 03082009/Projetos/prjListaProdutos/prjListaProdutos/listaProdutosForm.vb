Public Class listaProdutosForm

    Private Sub categoriaComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles categoriaComboBox.SelectedIndexChanged
        Dim lista As New ArrayList
        Dim dados(4) As String

        Try
            If System.IO.File.Exists("C:\Hanna VBNet II 03082009\Lista de Produtos.txt") Then
                Dim sr As New System.IO.StreamReader("C:\Hanna VBNet II 03082009\Lista de Produtos.txt")

                Do While Not sr.EndOfStream
                    dados = sr.ReadLine().Split(";")

                    If dados(4).ToUpper() = _
                    categoriaComboBox.Text.ToUpper() Then
                        lista.Add(dados(1))
                    End If
                Loop
                'TODO: Para fazer
                sr.Close()
                produtoListBox.DataSource = lista
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, _
            "Alerta de Erro - " & Err.Number, _
            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
