Imports System.Data.SqlClient

Public Class dadosForm

    Private Sub dadosForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cn As New SqlConnection
        cn.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Northwind;Data Source=.\SQLExpress"

        Dim instrucaoSQL As String = _
        "Select Distinct Country as Pais From Customers"

        Dim cmd As New SqlCommand
        cmd.Connection = cn
        cmd.CommandText = instrucaoSQL
        cmd.CommandType = CommandType.Text

        'Leitor de Dados
        Dim dr As SqlDataReader

        Try
            cn.Open()

            dr = cmd.ExecuteReader()

            Do While dr.Read()
                countryComboBox.Items.Add(dr("Pais"))
            Loop
            dr.Close()
            cn.Close()
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Alerta de Erro", _
            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub countryComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles countryComboBox.SelectedIndexChanged
        LimparTela()

        Dim cn As New SqlConnection
        'cn.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Northwind;Data Source=.\SQLExpress"
        cn.ConnectionString = Dados.StringDeConexao()

        Dim instrucaoSQL As String = _
        String.Format("Select CompanyName as " & _
"Cliente From Customers Where Country = '{0}' Order By 1", _
        countryComboBox.Text)

        Dim cmd As New SqlCommand
        cmd.Connection = cn
        cmd.CommandText = instrucaoSQL
        cmd.CommandType = CommandType.Text

        Dim dr As SqlDataReader

        Try
            cn.Open()
            dr = cmd.ExecuteReader()

            Do While dr.Read()
                customerListBox.Items.Add(dr("Cliente").ToString())
            Loop
            dr.Close()
            cn.Close()
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Alerta de Erro", _
            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub customerListBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles customerListBox.SelectedIndexChanged
        Dim cn As New SqlConnection(Dados.StringDeConexao())

        Dim instrucaoSQL As String = _
        String.Format( _
        "Select * From Customers Where CompanyName = '{0}'", _
        customerListBox.Text.Replace("'", "''"))

        Dim cmd As New SqlCommand(instrucaoSQL, cn)
        cmd.CommandType = CommandType.Text

        Dim dr As SqlDataReader

        Try
            cn.Open()

            dr = cmd.ExecuteReader()

            If dr.Read() Then
                customerIdTextBox.Text = dr("customerId").ToString()
                contactNameTextBox.Text = dr("contactName").ToString()
                contactTitleTextBox.Text = dr("contactTitle").ToString()
                addressTextBox.Text = dr("address").ToString()
                cityTextBox.Text = dr("city").ToString()
                regionTextBox.Text = dr("region").ToString()
                postalCodeTextBox.Text = dr("postalCode").ToString()
                phoneTextBox.Text = dr("phone").ToString()
                faxTextBox.Text = dr("fax").ToString()
            End If
            dr.Close()
            cn.Close()
        Catch ex As Exception

        End Try



    End Sub

    Private Sub LimparTela()
        For Each ctl As Control In Me.Controls

            If TypeOf ctl Is ListBox Then
                DirectCast(ctl, ListBox).Items.Clear()

            ElseIf TypeOf ctl Is TextBox Then
                ctl.Text = ""
            End If

        Next
    End Sub
End Class
