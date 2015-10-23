Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Using nwEntities As New NorthwindEntities()
            Dim Produtcts = nwEntities.Products
            Dim crit As Integer = Convert.ToInt32(ComboBox1.SelectedItem)

            Dim consultaProdutos = From p In Produtcts Where p.UnitsInStock > crit Select p.ProductID, p.ProductName

            DataGridView1.DataSource = consultaProdutos.ToList()
        End Using
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For i As Integer = 1 To 500 Step 1
            ComboBox1.Items.Add(i.ToString())
        Next
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Button1_Click(Nothing, Nothing)
    End Sub
End Class
