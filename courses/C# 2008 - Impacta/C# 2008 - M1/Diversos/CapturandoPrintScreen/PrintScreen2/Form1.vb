Public Class Form1
    Dim te As New TeclaBloqueadaEventArgs(Keys.PrintScreen)

    Private Sub TextBox1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyUp
        If e.KeyCode = te.Tecla Then MessageBox.Show("oo")
        If e.KeyCode = te.Tecla Then Clipboard.Clear()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PictureBox1.Image = Clipboard.GetImage()
    End Sub
End Class
