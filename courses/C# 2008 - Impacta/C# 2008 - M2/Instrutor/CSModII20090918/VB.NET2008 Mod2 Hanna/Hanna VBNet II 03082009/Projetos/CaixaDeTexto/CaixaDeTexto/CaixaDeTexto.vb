Public Class CaixaDeTexto

    Private Sub TextBox1_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.Enter
        TextBox1.BackColor = Color.Yellow
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then SendKeys.Send("{tab}")

        If e.KeyChar >= Chr(48) AndAlso e.KeyChar <= Chr(57) _
        Or e.KeyChar = Chr(8) Then
        Else
            e.KeyChar = Chr(0)
        End If
    End Sub

    Private Sub TextBox1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.Leave
        TextBox1.BackColor = Color.White
    End Sub

    ''' <summary>
    ''' Lê e escreve o texto na TextBox
    ''' </summary>
    Public Property Texto() As String
        Get
            Return TextBox1.Text
        End Get
        Set(ByVal value As String)
            TextBox1.Text = value
        End Set
    End Property

End Class
