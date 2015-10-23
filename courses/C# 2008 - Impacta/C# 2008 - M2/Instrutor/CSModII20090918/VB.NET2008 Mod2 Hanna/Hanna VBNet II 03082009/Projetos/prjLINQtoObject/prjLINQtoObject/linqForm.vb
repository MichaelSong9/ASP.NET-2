Public Class linqForm

    Private Sub linqButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles linqButton.Click
        Dim cidades = From c In linqListBox.Items _
                      Where c.ToString().ToUpper() Like "*CHUVA" _
                      Select c _
                      Order By c

        For Each c In cidades
            MessageBox.Show(c)
        Next
    End Sub

    Private Sub linqForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With linqListBox
            .Items.Add("São Paulo")
            .Items.Add("Caraguatachuva")
            .Items.Add("Rio de Janeiro")
            .Items.Add("São Sebastião")
            .Items.Add("Ilha Bela")
            .Items.Add("Ubachuva")
            .Items.Add("São José dos Campos")
            .Items.Add("Bertioga")
            .Sorted = True
        End With
    End Sub
End Class
