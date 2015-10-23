Public Class Form1
    Dim dsXML As New DataSet

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dsXML.ReadXml("C:\ArquivoXML.xml")
    End Sub

    Private Sub lerXmlButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lerXmlButton.Click
        For i As Integer = 0 To dsXML.Tables(0).Rows.Count - 1
            MessageBox.Show(dsXML.Tables(0).Rows(i).Item(0))
        Next
    End Sub

    Private Sub gravarXmlButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gravarXmlButton.Click
        Dim drNova As DataRow
        drNova = dsXML.Tables(0).NewRow
        drNova(0) = InputBox("Informe o nome")
        drNova(1) = InputBox("Informe a idade")
        dsXML.Tables(0).Rows.Add(drNova)

        If dsXML.HasChanges() Then
            dsXML.WriteXml("C:\ArquivoXML.xml", XmlWriteMode.WriteSchema)
        End If
    End Sub


End Class
