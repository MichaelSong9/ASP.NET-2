Public Class Geral
    Public Shared Function TestarVazio(ByVal txt As TextBox) _
    As Boolean
        If txt.Text.Trim() = "" Then
            txt.Focus()
            txt.SelectAll()
            MessageBox.Show("Preencha o campo - " & _
                txt.Name.Replace("TextBox", "").ToUpper(), _
                "Alerta", MessageBoxButtons.OK, _
                MessageBoxIcon.Exclamation)
            Return False
        End If
        Return True
    End Function

    Public Shared Function TestarVazio(ByVal lbl As Label) _
    As Boolean
        If lbl.Text.Trim() = "" Then
            MessageBox.Show("Código é obrigatório")
            Return False
        End If
        Return True
    End Function
End Class
