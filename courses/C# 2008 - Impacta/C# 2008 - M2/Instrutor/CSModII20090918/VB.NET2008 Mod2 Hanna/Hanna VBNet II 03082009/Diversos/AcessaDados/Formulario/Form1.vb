Imports BancoDeDados

Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim bd As New BancoDeDados.BancoDeDados

            Dim instrucaoSQL As String = "Insert Cliente values('Ueliton','Al Santos')"

            bd.ExecutarComando(instrucaoSQL)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro")
        End Try
    End Sub
End Class
