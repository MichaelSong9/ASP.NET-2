Public Class cap06_Lab01Form
    Dim nwind As New NorthWindDataContext()

    Private Sub CarregarPedidos()

        Dim pedidos = From c In nwind.Customers _
                          Join p In nwind.Orders On _
                          c.CustomerID Equals p.CustomerID _
                          Where c.CompanyName = clienteComboBox.Text _
                          Select p.OrderID, p.OrderDate, p.RequiredDate

        dgv.DataSource = pedidos

        nPedidosLabel.Text = "Nº de Pedidos: " + pedidos.Count().ToString()
    End Sub

    Private Sub cap06_Lab01Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim clientes = From c In nwind.Customers _
                            Order By c.CompanyName _
                            Select c.CompanyName

        clienteComboBox.DataSource = clientes.ToList

        clienteComboBox.SelectedIndex = 0

        CarregarPedidos()
    End Sub

    Private Sub clienteComboBox_SelectedIndexChanged(ByVal sender As System.Object, _
                                ByVal e As System.EventArgs) Handles clienteComboBox.SelectedIndexChanged

        CarregarPedidos()
    End Sub

End Class
