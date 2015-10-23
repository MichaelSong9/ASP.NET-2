Public Class cpfForm
    Private Sub validarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles validarButton.Click
        Dim docCPF As New Documentos.CPF()

        resultadoLabel.Text = _
        docCPF.ValidarCPF(CaixaDeTexto1.Texto)
    End Sub
End Class
