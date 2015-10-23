Imports System.Data.SqlClient

Public Class cap05_lab01Form
    'Permite navegar nos registros
    Dim cm As CurrencyManager

    Private Sub cap05_lab01Form_Load(ByVal sender As System.Object, _
                                    ByVal e As System.EventArgs) Handles MyBase.Load

        Dim ds As DataSet = Geral.ListaDeVeiculos

        dgv.DataSource = ds.Tables("Veiculos")
        dgv.ReadOnly = True
        dgv.AllowUserToAddRows = False
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.Yellow

        'Associa a navegação ao datagridview
        cm = Me.dgv.BindingContext(ds.Tables(0))
    End Sub

    Private Sub pesquisarTextBox_TextChanged(ByVal sender As System.Object, _
                                    ByVal e As System.EventArgs) Handles pesquisarTextBox.TextChanged

        Dim tabela As DataTable = dgv.DataSource

        'Aplica o filtro
        tabela.DefaultView.RowFilter = _
            String.Format("Placa like '%{0}%'", pesquisarTextBox.Text)

        'Classifica o resultado
        tabela.DefaultView.Sort = "Placa"
    End Sub

    Private Sub primeiroButton_Click(ByVal sender As System.Object, _
                                    ByVal e As System.EventArgs) Handles primeiroButton.Click

        cm.Position = 0
    End Sub

    Private Sub anteriorButton_Click(ByVal sender As System.Object, _
                                    ByVal e As System.EventArgs) Handles anteriorButton.Click

        cm.Position -= 1
    End Sub

    Private Sub proximoButton_Click(ByVal sender As System.Object, _
                                    ByVal e As System.EventArgs) Handles proximoButton.Click

        cm.Position += 1
    End Sub

    Private Sub ultimoButton_Click(ByVal sender As System.Object, _
                                   ByVal e As System.EventArgs) Handles ultimoButton.Click

        cm.Position = dgv.RowCount - 1
    End Sub

    Private Sub editarGravarButton_Click(ByVal sender As System.Object, _
                                    ByVal e As System.EventArgs) Handles editarGravarButton.Click
        Try
            If editarGravarButton.Text = "&Editar" Then
                dgv.AllowUserToAddRows = True
                dgv.ReadOnly = False
                dgv.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.Gray
                dgv.AlternatingRowsDefaultCellStyle.ForeColor = System.Drawing.Color.White

                editarGravarButton.Text = "&Gravar"
            Else
                Dim tabela As DataTable = dgv.DataSource
                Dim da As New SqlDataAdapter(Geral.instrucaoSQL, Geral.StringDeConexao)

                Dim comBuilder As New SqlCommandBuilder(da)
                comBuilder.DataAdapter.Update(tabela)

                dgv.AllowUserToAddRows = False
                dgv.ReadOnly = True
                dgv.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.Yellow
                dgv.AlternatingRowsDefaultCellStyle.ForeColor = System.Drawing.Color.Black

                editarGravarButton.Text = "&Editar"
            End If
        Catch ex As SqlException
            MessageBox.Show("Erro no acesso aos dados", "Alerta de Erro - nº " & ex.Number, _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
