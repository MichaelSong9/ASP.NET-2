Public Class cap04_Lab03Form
    'Definir variáveis e instanciar objetos
    Private ReadOnly caminhoXML As String = "C:\CadastroDeAlunos.XML"
    Private dsAluno As New DataSet()

    Private Function GerarXML() As DataSet
        'Cria a estrutura do XML
        Dim dtAluno As New DataTable("Aluno")

        Dim TipoString As Type = System.Type.GetType("System.String")

        dtAluno.Columns.Add("Matrícula", TipoString)
        dtAluno.Columns.Add("Nome", TipoString)
        dtAluno.Columns.Add("Idade", TipoString)
        dtAluno.Columns.Add("Série", TipoString)

        'Adiciona o DataTable ao DataSet
        dsAluno.Tables.Add(dtAluno)

        'Escreve o XML
        dsAluno.WriteXml(caminhoXML, XmlWriteMode.WriteSchema)

        Return dsAluno
    End Function

    Private Sub CarregarXML()
        Try
            dsAluno.ReadXml(caminhoXML)
        Catch ex As System.IO.FileNotFoundException
            'Caso o arquivo não exista, será gerado automaticamente
            dsAluno = GerarXML()
        End Try
    End Sub


    Private Sub gravarButton_Click(ByVal sender As System.Object, _
                                  ByVal e As System.EventArgs) Handles gravarButton.Click

        If dsAluno.HasChanges() Then
            dsAluno.WriteXml(caminhoXML, XmlWriteMode.WriteSchema)

            MessageBox.Show("Gravação concluída com sucesso", "Aviso", _
                MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub cap04_Lab03Form_Load(ByVal sender As System.Object, _
                                     ByVal e As System.EventArgs) Handles MyBase.Load
        CarregarXML()
        dgv.DataSource = dsAluno
        dgv.DataMember = dsAluno.Tables("Aluno").TableName
    End Sub

End Class
