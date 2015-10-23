Imports System.Data.SqlClient

Public Class FuncionariosCap07

    Private Sub FuncionariosCap07_Load(ByVal sender As System.Object, _
                                ByVal e As System.EventArgs) Handles MyBase.Load
        'Mantém a cor do UserControl igual a cor do formulário
        Me.BackColor = Me.ParentForm.BackColor

        'Cria a ConnectionString
        Dim conexao As String = _
                "Integrated Security=SSPI;Persist Security Info=False;" & _
                "Initial Catalog=NorthWind;Data Source=.\sqlexpress"

        'Cria a instrucaoSQL 
        Dim instrucaoSQL As String = _
                "Select Firstname + ' ' + LastName as Funcionario " & _
                "From employees Order By 1"

        Dim da As New SqlDataAdapter(instrucaoSQL, conexao)

        Dim dados As New DataSet()

        da.Fill(dados)

        Dim tabelaProduto As DataTable = dados.Tables(0)

        funcionarioComboBox.Items.Clear()
        For Each registro As DataRow In tabelaProduto.Rows

            funcionarioComboBox.Items.Add(registro("Funcionario"))
        Next
    End Sub

    Private Sub funcionarioComboBox_SelectedIndexChanged( _
                ByVal sender As System.Object, ByVal e As System.EventArgs) _
                Handles funcionarioComboBox.SelectedIndexChanged

        Using cn As New SqlConnection("Integrated Security=SSPI;" & _
                                      "Persist Security Info=False;" & _
                                      "Initial Catalog=NorthWind;Data Source=.\sqlexpress")

            Using cmd As New SqlCommand("Select * From Employees " & _
                                        "Where Firstname + ' ' + LastName = '" + _
                                        funcionarioComboBox.Text + "'")

                cmd.Connection = cn
                Dim dr As SqlDataReader

                Try
                    cn.Open()
                    dr = cmd.ExecuteReader()

                    If dr.Read() Then

                        cargoTextBox.Text = dr("Title").ToString()

                        admissaoTextBox.Text = dr("HireDate").ToString().Substring(0, _
                                                                dr("HireDate").ToString().Length - 8)

                        nascimentoTextBox.Text = dr("BirthDate").ToString().Substring(0, _
                                                                dr("BirthDate").ToString().Length - 8)

                        observacaoTextBox.Text = dr("Notes").ToString()
                    End If
                    cn.Close()
                Catch ex As SqlException
                    Throw New Exception("Erro ao tentar recuperar os dados")
                End Try
            End Using
        End Using
    End Sub

    Public ReadOnly Property Funcionario() As String
        Get
            Return funcionarioComboBox.Text
        End Get
    End Property

    Public ReadOnly Property Cargo() As String
        Get
            Return cargoTextBox.Text
        End Get
    End Property
    Public ReadOnly Property Admissao() As String
        Get
            Return admissaoTextBox.Text
        End Get
    End Property
    Public ReadOnly Property Nascimento() As String
        Get
            Return nascimentoTextBox.Text
        End Get
    End Property
    Public ReadOnly Property Observacao() As String
        Get
            Return observacaoTextBox.Text
        End Get
    End Property
End Class
