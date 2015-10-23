Imports System.Data.SqlClient

Public Class transacaoForm

    Private Sub transacaoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles transacaoButton.Click
        Dim cn As New SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Empresa;Data Source=.\SQLExpress")

        Dim cmd1 As New SqlCommand(update1TextBox.Text, cn)
        cmd1.CommandType = CommandType.Text

        Dim cmd2 As New SqlCommand(update2TextBox.Text, cn)
        cmd2.CommandType = CommandType.Text

        cn.Open()

        Dim tx As SqlTransaction = cn.BeginTransaction()

        cmd1.Transaction = tx
        cmd2.Transaction = tx

        Try
            cmd1.ExecuteNonQuery()
            MessageBox.Show("UPDATE 1 - OK")

            cmd2.ExecuteNonQuery()
            MessageBox.Show("UPDATE 2 - OK")

            tx.Commit()
            MessageBox.Show("COMMIT - OK")
        Catch ex As Exception
            tx.Rollback()
            MessageBox.Show("ROLLBACK - OK")
        Finally
            cn.Close()
        End Try
    End Sub
End Class
