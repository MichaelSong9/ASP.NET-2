Imports System.Data.SqlClient

Public Class dataSetForm
    Dim ds As New DataSet
    Dim da As New SqlDataAdapter

    Private Sub dataSetForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim StringDeConexao As String = _
        "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Empresa;Data Source=.\SQLExpress"
        Dim instrucaoSQL As String = _
        "Select Codigo as Código, Nome as Cliente, Endereco as Endereço from Cliente Order by 1"

        da = New SqlDataAdapter(instrucaoSQL, _
                        StringDeConexao)
        da.Fill(ds)

        With dgvCliente
            .DataSource = ds.Tables(0)
            .ReadOnly = True
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AlternatingRowsDefaultCellStyle.BackColor = _
                    Color.FromArgb(100, 0, 250)
            .AlternatingRowsDefaultCellStyle.ForeColor = _
                Color.White
            .AutoSizeColumnsMode = _
                DataGridViewAutoSizeColumnsMode.Fill
            .Columns(0).Width = 50
            .Columns(0).DefaultCellStyle.Alignment = _
                DataGridViewContentAlignment.MiddleCenter
            registroLabel.Text = _
            String.Format("{0} registro(s)", .RowCount.ToString())
        End With
    End Sub

    Private Sub editarGravarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editarGravarButton.Click
        If editarGravarButton.Text = "&Editar" Then
            With dgvCliente
                .ReadOnly = False
                .Columns(0).ReadOnly = True
                .AllowUserToAddRows = True
                .AllowUserToDeleteRows = True
                .AlternatingRowsDefaultCellStyle.BackColor = _
                    Color.FromArgb(200, 200, 200)
                .AlternatingRowsDefaultCellStyle.ForeColor = _
                    Color.Black
                .Columns(0).Width = 50
            End With
            editarGravarButton.Text = "&Gravar"
        Else
            Dim dados As DataTable = dgvCliente.DataSource
            Dim cmdB As New SqlCommandBuilder(da)
            cmdB.DataAdapter.Update(dados)

            ds.Tables(0).Clear()
            da.Fill(ds.Tables(0))

            With dgvCliente
                .DataSource = ds.Tables(0)
                .ReadOnly = True
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .AlternatingRowsDefaultCellStyle.BackColor = _
                        Color.FromArgb(100, 0, 250)
                .AlternatingRowsDefaultCellStyle.ForeColor = _
                    Color.White
                .AutoSizeColumnsMode = _
                    DataGridViewAutoSizeColumnsMode.Fill
                .Columns(0).Width = 50
                .Columns(0).DefaultCellStyle.Alignment = _
                    DataGridViewContentAlignment.MiddleCenter
                registroLabel.Text = _
                String.Format("{0} registro(s)", .RowCount.ToString())
            End With
            editarGravarButton.Text = "&Editar"
        End If

        Dim cm As CurrencyManager = _
            dgvCliente.BindingContext(ds.Tables(0))
        cm.Position = dgvCliente.RowCount - 1
    End Sub

    Private Sub nomeTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nomeTextBox.TextChanged
        Dim dados As DataTable = dgvCliente.DataSource
        dados.DefaultView.RowFilter = _
        String.Format("Cliente Like '{0}%'", nomeTextBox.Text)

        dados.DefaultView.Sort = "Cliente"

        registroLabel.Text = _
        String.Format("{0} registro(s)", _
        dgvCliente.RowCount.ToString())
    End Sub

    Private Sub exibirButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exibirButton.Click
        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            Dim dados As String = _
            String.Format("Cliente: {0}{1}Endereço: {2}", _
            ds.Tables(0).Rows(i).Item(1).ToString(), _
            vbCrLf, _
            ds.Tables(0).Rows(i).Item(2).ToString())

            MessageBox.Show(dados, "Tabela Cliente")
        Next
    End Sub
End Class
