Public Class forEachForm

    Private Sub forEachButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles forEachButton.Click
        'Para cada controle dentro da coleção de controles do Formulário
        For Each controle As Control In Me.Controls

            'Se o tipo do controle é TextBox
            If TypeOf controle Is TextBox And _
            Convert.ToString(controle.Tag) <> "1" Then
                controle.Text = ""
            ElseIf TypeOf controle Is ComboBox Then
                DirectCast(controle, ComboBox).SelectedIndex = -1
            End If
        Next

        For Each controle As Control In Me.GroupBox1.Controls
            If TypeOf controle Is CheckBox Then
                DirectCast(controle, CheckBox).Checked = False
            End If
        Next
    End Sub

    Private Sub forEachForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        forEachButton.Tag = 5
        Me.Text = forEachButton.Tag.ToString()
    End Sub
End Class