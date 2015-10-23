Public Class wbForm

    Private Sub irButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles irButton.Click
        wb.Navigate(enderecoTextBox.Text)
    End Sub

    Private Sub wbForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        irButton.PerformClick()
    End Sub

    Private Sub wb_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles wb.DocumentCompleted
        enderecoTextBox.Text = wb.Url.ToString()
    End Sub

    Private Sub enderecoTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles enderecoTextBox.KeyPress
        If e.KeyChar = Chr(13) Then
            irButton.PerformClick()

        End If
    End Sub
End Class
