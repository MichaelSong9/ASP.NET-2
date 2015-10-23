Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim numero As Decimal = 1268.79
        TextBox1.Text = numero.Moeda("inglaterra")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim email As String = TextBox2.Text

        MessageBox.Show(email.ValidarEmail().ToString())
    End Sub
End Class
