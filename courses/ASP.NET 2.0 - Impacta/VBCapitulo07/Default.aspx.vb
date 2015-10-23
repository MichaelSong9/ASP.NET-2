Imports System.Data
Imports System.Data.SqlClient

Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub clientesButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles clientesButton.Click

        If Cache("clientes") Is Nothing Then
            Dim sql As String = "Select * from Clientes"
            Dim conexao As String = "server=localhost\sqlexpress;" & _
                                                "database=curso;" & _
                                                "integrated security=true"
            Dim da As New SqlDataAdapter(sql, conexao)
            Dim ds As New DataSet

            da.Fill(ds)

            GridView1.DataSource = ds
            GridView1.DataBind()
            mensagemLabel.Text = "Dados lidos do sql server"
            Cache("clientes") = ds
        Else
            GridView1.DataSource = Cache("clientes")
            GridView1.DataBind()
            mensagemLabel.Text = "Dados lidos do cache"
        End If

    End Sub
End Class
