Public Class exemploForm

    Private Sub exemploButton_Click(ByVal sender As System.Object, _
                        ByVal e As System.EventArgs) Handles exemploButton.Click

        Using NWEntities As New NorthwindEntities()

            Dim clientes = NWEntities.Customers

            Dim consultaClientes = From cli In clientes _
                                   Select cli.CompanyName _
                                   Order By (CompanyName)

            exemploListBox.DataSource = consultaClientes.ToList()
        End Using
    End Sub

End Class
