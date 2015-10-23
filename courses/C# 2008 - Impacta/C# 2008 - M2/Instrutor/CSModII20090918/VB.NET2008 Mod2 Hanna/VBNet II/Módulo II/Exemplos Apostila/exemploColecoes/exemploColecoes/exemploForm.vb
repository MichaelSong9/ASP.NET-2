Public Class exemploForm

    Private Sub exemploButton_Click(ByVal sender As System.Object, _
                                ByVal e As System.EventArgs) Handles exemploButton.Click

        Dim lista As New ArrayList()

        lista.Add("jatobá")
        lista.Add("cajamanga")
        lista.Add("pequí")
        lista.Add("seriguela")
        lista.Add("pitomba")

        For Each item As String In lista
            exemploListBox.Items.Add(item)
        Next
        exemploListBox.Items.Add("TOTAL de ITENS: " & lista.Count.ToString())
        exemploListBox.Items.Add("----------------------------------")

        lista.Remove("seriguela")

        For Each item As String In lista
            exemploListBox.Items.Add(item)
        Next
        exemploListBox.Items.Add("TOTAL de ITENS: " & lista.Count.ToString())
        exemploListBox.Items.Add("----------------------------------")
    End Sub

End Class
