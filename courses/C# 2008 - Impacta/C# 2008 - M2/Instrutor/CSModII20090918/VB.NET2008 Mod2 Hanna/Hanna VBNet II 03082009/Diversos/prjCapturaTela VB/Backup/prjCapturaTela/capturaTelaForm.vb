Public Class capturaTelaForm

    Private Sub fecharButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecharButton.Click
        Try
            Application.Exit()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub salvarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles salvarButton.Click
        Try
            sfd.Filter = "Arquivos jpg|*.jpg"
            sfd.FileName = "*.jpg"
            If sfd.ShowDialog() = Windows.Forms.DialogResult.OK Then
                imagemPictureBox.Image.Save(sfd.FileName)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub limparButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles limparButton.Click
        Try
            Clipboard.Clear()
            imagemPictureBox.Image = Nothing
            fundoForm.Refresh()
            salvarButton.Enabled = False
            Me.Text = "Seleção de Imagem"
        Catch ex As Exception

        End Try
    End Sub
End Class