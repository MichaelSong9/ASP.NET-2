Public Class xBotao

    Public Event CliqueDoOutroBotao()

    Private Sub botaoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botaoButton.Click

        Dim resposta As DialogResult
        resposta = _
        MessageBox.Show("Deseja meixmo fechar?", _
        "Alerta", MessageBoxButtons.YesNo, _
        MessageBoxIcon.Question, _
        MessageBoxDefaultButton.Button2)

        If resposta = DialogResult.Yes Then
            Me.ParentForm.Close()
        End If
    End Sub

    Public Property TextoBotao() As String
        Get
            Return botaoButton.Text
        End Get
        Set(ByVal value As String)
            botaoButton.Text = value
        End Set
    End Property

    Public Property CorDaFonteDoBotao() As Color
        Get
            Return botaoButton.ForeColor
        End Get
        Set(ByVal value As Color)
            botaoButton.ForeColor = value
        End Set
    End Property

    Private Sub outroBotaoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles outroBotaoButton.Click
        RaiseEvent CliqueDoOutroBotao()
    End Sub
End Class
