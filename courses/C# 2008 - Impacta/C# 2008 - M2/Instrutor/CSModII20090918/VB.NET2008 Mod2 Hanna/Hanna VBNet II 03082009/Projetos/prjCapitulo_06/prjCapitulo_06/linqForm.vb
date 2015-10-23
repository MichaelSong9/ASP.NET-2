Public Class linqForm

    Private Sub linqButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles linqButton.Click
        If fbd.ShowDialog() = Windows.Forms.DialogResult.OK Then

            Dim musicas = _
            From m In New System.IO.DirectoryInfo( _
            fbd.SelectedPath).GetFiles() _
            Where m.Extension.ToUpper() = ".MP3" _
            Select Musica = m.Name, Tamanho = m.Length _
            Order By Musica

            For Each m In musicas
                MessageBox.Show(m.Musica & vbCrLf & _
                m.Tamanho.ToString("n0"))
            Next

            dgv.Columns.Clear()
            dgv.Columns.Add("Musica", "Música")
            dgv.Columns.Add("Tamanho", "Tamanho")

            For Each m In musicas
                dgv.Rows.Add( _
                m.Musica.Substring(23).Replace(".mp3", ""), _
                m.Tamanho.ToString("n0"))
            Next
        End If
    End Sub

    Private Sub gravarXMLButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gravarXMLButton.Click
        If fbd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim musicas = _
            From m In New System.IO.DirectoryInfo( _
            fbd.SelectedPath).GetFiles() _
            Where m.Extension.ToUpper() = ".MP3" _
            Select Musica = _
            m.Name.Substring(23).Replace(".mp3", ""), _
            Tamanho = m.Length _
            Order By Musica Ascending

            Dim docXML As New XElement("MichaelJackson")
            Dim elemento As XElement = Nothing

            For Each m In musicas
                elemento = New XElement("Musica")
                elemento.SetAttributeValue( _
                "Nome", m.Musica)
                elemento.SetAttributeValue( _
                "Tamanho", m.Tamanho.ToString("n0"))

                docXML.Add(elemento)
            Next
            docXML.Save("C:\Musicas.xml")

            MessageBox.Show("OK")
        End If
    End Sub

End Class
