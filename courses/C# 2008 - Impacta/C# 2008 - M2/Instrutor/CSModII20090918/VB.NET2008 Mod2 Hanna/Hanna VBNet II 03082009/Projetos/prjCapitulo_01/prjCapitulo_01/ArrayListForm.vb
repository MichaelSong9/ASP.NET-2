Public Class ArrayListForm

    Private Sub arrayListButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles arrayListButton.Click
        'Definir um ArrayList
        Dim lista As New ArrayList

        'Acrescentar valores ao ArrayList
        lista.Add("jatobá")
        lista.Add("Atemoia")
        lista.Add("Pequí")
        lista.Add("Seriguela")

        'Exibir os dados na ListBox
        For i As Integer = 0 To lista.Count - 1 Step 1
            arrayListBox.Items.Add(i.ToString() & " - " _
                                   & lista(i))
        Next
        arrayListBox.Items.Add("------------------------")

        lista.Insert(2, "Açai")
        'Exibir os dados na ListBox
        For i As Integer = 0 To lista.Count - 1 Step 1
            arrayListBox.Items.Add(i.ToString() & " - " _
                                   & lista(i))
        Next
        arrayListBox.Items.Add("------------------------")

        lista.Remove("Açai")
        'Exibir os dados na ListBox
        For i As Integer = 0 To lista.Count - 1 Step 1
            arrayListBox.Items.Add(i.ToString() & " - " _
                                   & lista(i))
        Next
        arrayListBox.Items.Add("------------------------")

        lista.RemoveAt(2)
        'Exibir os dados na ListBox
        For i As Integer = 0 To lista.Count - 1 Step 1
            arrayListBox.Items.Add(i.ToString() & " - " _
                                   & lista(i))
        Next
        arrayListBox.Items.Add("------------------------")

        If lista.Contains("jatobá") Then
            arrayListBox.Items.Add("Já tem o item")
        Else
            arrayListBox.Items.Add("Não tem o item")
        End If
    End Sub
End Class
