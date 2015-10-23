Imports prj13_FormataDLL

Public Class documentoForm
    Dim doc As New Documento

    Private Sub TextBox1_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.Enter
        TextBox1.Text = doc.RetirarFormato(TextBox1)
    End Sub

    Private Sub TextBox1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.Leave
        TextBox1.Text = doc.Formatar(TextBox1)
    End Sub

    Private Sub TextBox2_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.Enter
        TextBox2.Text = doc.Formatar(TextBox2)
    End Sub

    Private Sub TextBox2_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.Leave
        TextBox2.Text = doc.Formatar(TextBox2)
    End Sub
End Class
