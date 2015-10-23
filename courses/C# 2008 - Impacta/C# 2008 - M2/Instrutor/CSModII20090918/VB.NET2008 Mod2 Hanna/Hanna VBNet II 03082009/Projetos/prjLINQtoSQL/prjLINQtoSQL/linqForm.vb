Imports System.Text

Public Class linqForm
    Private Sub linqButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles linqButton.Click
        Dim StringDeConexao As New StringBuilder
        StringDeConexao.Append("Integrated Security=SSPI;")
        StringDeConexao.Append("Persist Security Info=False;")
        StringDeConexao.Append("Initial Catalog=NorthWind;")
        StringDeConexao.Append("Data Source=.\SQLExpress")

        Dim db = New NWind(StringDeConexao.ToString())

        Dim prods = From p In db.Produtos _
                    Where p.ProductName Like "?R*" _
                    Select p.ProductName _
                    Order By ProductName

        linqListBox.DataSource = prods.ToList()
    End Sub
End Class
