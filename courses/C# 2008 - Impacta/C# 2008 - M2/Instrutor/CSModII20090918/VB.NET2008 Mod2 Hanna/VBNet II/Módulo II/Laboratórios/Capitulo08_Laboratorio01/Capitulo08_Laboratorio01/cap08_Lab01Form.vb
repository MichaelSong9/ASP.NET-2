Imports System.Data.SqlClient

Public Class cap08_Lab01Form

    Public Sub Inserir()
        Dim cn As New SqlConnection()
        cn.ConnectionString = _
                    "Integrated Security=SSPI;Persist Security Info=False;" & _
                    "Initial Catalog=BackGround;Data Source=.\sqlexpress"

        Dim cmd As New SqlCommand()
        cmd.Connection = cn
        cmd.CommandText = "Insert Cliente values('NomeCliente')"
        cmd.CommandType = CommandType.Text

        Try
            cn.Open()
            For i As Integer = 0 To 10000 Step 1
                cmd.ExecuteNonQuery()
            Next
            cn.Close()
        Catch ex As SqlException
            MessageBox.Show("Erro ao conectar")
        End Try
    End Sub

    Private Sub inserirButton_Click(ByVal sender As System.Object, _
                                    ByVal e As System.EventArgs) Handles inserirButton.Click

        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub mensagemButton_Click(ByVal sender As System.Object, _
                                     ByVal e As System.EventArgs) Handles mensagemButton.Click

        MessageBox.Show("BackgroundWorker")
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, _
                                         ByVal e As System.ComponentModel.DoWorkEventArgs) _
                                         Handles BackgroundWorker1.DoWork

        Inserir()
    End Sub

End Class
