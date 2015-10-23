Public Class TabTextBox

    Private Sub TextBox1_KeyPress(ByVal sender As Object, _
                                 ByVal e As System.Windows.Forms.KeyPressEventArgs) _
                                 Handles TextBox1.KeyPress

        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{tab}")
        End If
    End Sub

End Class
