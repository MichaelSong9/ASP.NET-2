Imports System.Data.SqlClient

Public Class clienteForm
    Dim ds As New DataSet
    Dim da As New SqlDataAdapter
    Dim linha As Integer = 0

    Private Sub clienteForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim StringDeConexao As String = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Empresa;Data Source=.\SQLExpress"
        Dim instrucaoSQL As String = _
        "Select Codigo as Código, " & _
        "Nome as Cliente, Endereco as Endereço " & _
        "From Cliente Order By 1"

        da = New SqlDataAdapter(instrucaoSQL, StringDeConexao)
        da.Fill(ds)

        PreencheCampos()
    End Sub

    Private Sub PreencheCampos()
        codigoLabel.Text = _
            ds.Tables(0).Rows(linha).Item(0).ToString()
        nomeTextBox.Text = _
            ds.Tables(0).Rows(linha).Item(1).ToString()
        enderecoTextBox.Text = _
            ds.Tables(0).Rows(linha).Item(2).ToString()
    End Sub

    Private Sub primeiroButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles primeiroButton.Click
        linha = 0
        PreencheCampos()
    End Sub

    Private Sub ultimoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ultimoButton.Click
        linha = ds.Tables(0).Rows.Count - 1
        PreencheCampos()
    End Sub

    Private Sub anteriorButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles anteriorButton.Click
        If linha > 0 Then linha -= 1
        PreencheCampos()
    End Sub

    Private Sub proximoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles proximoButton.Click
        If linha < ds.Tables(0).Rows.Count - 1 Then linha += 1
        PreencheCampos()
    End Sub

    Private Sub DesabilitaBotoes()
        For Each ctl As Control In Me.Controls
            If TypeOf ctl Is Button AndAlso _
            ctl.Text <> "Gravar" Then
                ctl.Enabled = False
            End If
        Next
    End Sub

    Private Sub HabilitaBotoes()
        For Each ctl As Control In Me.Controls
            If TypeOf ctl Is Button Then
                ctl.Enabled = True
            End If
        Next
    End Sub

    Private Sub novoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles novoButton.Click
        If novoButton.Text = "Novo" Then
            codigoLabel.Text = ""
            nomeTextBox.Clear()
            nomeTextBox.ReadOnly = False
            enderecoTextBox.Clear()
            enderecoTextBox.ReadOnly = False

            novoButton.Text = "Gravar"

            DesabilitaBotoes()
            nomeTextBox.Focus()
        Else
            'TODO: Consistencia
            Dim drNova As DataRow
            drNova = ds.Tables(0).NewRow()
            drNova("Cliente") = nomeTextBox.Text
            drNova("Endereço") = enderecoTextBox.Text
            ds.Tables(0).Rows.Add(drNova)

            Dim cmdB As New SqlCommandBuilder(da)
            cmdB.DataAdapter.Update(ds.Tables(0))

            ds.Tables(0).Clear()
            da.Fill(ds.Tables(0))

            nomeTextBox.ReadOnly = True
            enderecoTextBox.ReadOnly = True

            novoButton.Text = "Novo"
            HabilitaBotoes()

            ultimoButton_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub editarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editarButton.Click
        If editarButton.Text = "Editar" Then
            nomeTextBox.ReadOnly = False
            enderecoTextBox.ReadOnly = False

            editarButton.Text = "Gravar"
            DesabilitaBotoes()
        Else
            ds.Tables(0).Rows(linha).BeginEdit()
            ds.Tables(0).Rows(linha).Item(1) = nomeTextBox.Text
            ds.Tables(0).Rows(linha).Item(2) = enderecoTextBox.Text
            ds.Tables(0).Rows(linha).EndEdit()

            Dim cmdB As New SqlCommandBuilder(da)
            cmdB.DataAdapter.Update(ds.Tables(0))

            nomeTextBox.ReadOnly = True
            enderecoTextBox.ReadOnly = True

            editarButton.Text = "Editar"
            HabilitaBotoes()
        End If
    End Sub

    Private Sub pesquisarCodigoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pesquisarCodigoButton.Click
        Dim cod As Integer = _
        Integer.Parse(InputBox("Informe o código"))

        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            If ds.Tables(0).Rows(i).Item(0) = cod Then
                linha = i
                PreencheCampos()
                Exit Sub
            End If
        Next
        MessageBox.Show("Código não localizado")
    End Sub
End Class
