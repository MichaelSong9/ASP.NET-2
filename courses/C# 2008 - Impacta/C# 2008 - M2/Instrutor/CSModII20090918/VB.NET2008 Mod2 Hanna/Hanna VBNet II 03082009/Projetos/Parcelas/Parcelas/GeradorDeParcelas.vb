Public Class GeradorDeParcelas
    Private nParcelas As Integer = 1

    Private Sub GeradorDeParcelas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        nParcelasLabel.Text = nParcelas.ToString()
    End Sub

    Private Sub Calcular(ByVal sender As Object, _
                ByVal e As EventArgs) Handles _
                aumentaButton.Click, _
                diminuiButton.Click
        If valorTextBox.Text.Trim() = "" Then Exit Sub
        If Not IsNumeric(valorTextBox.Text) Then
            valorTextBox.Focus()
            valorTextBox.SelectAll()
            Exit Sub
        End If

        If DirectCast(sender, Button).Text = "+" Then
            If nParcelas < 20 Then nParcelas += 1
        Else
            If nParcelas > 1 Then nParcelas -= 1
        End If
        nParcelasLabel.Text = nParcelas.ToString()

        valorParcelaLabel.Text = _
        Financial.Pmt(0.02, _
        Double.Parse(nParcelasLabel.Text), _
        -Double.Parse(valorTextBox.Text)).ToString("C2", _
        New System.Globalization.CultureInfo("es-es"))
    End Sub
End Class
