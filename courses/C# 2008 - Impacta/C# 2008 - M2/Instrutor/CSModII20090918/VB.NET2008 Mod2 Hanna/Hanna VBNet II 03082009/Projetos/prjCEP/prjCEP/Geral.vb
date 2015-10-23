Public Class Geral
    Public Shared Function TestarVazio(ByVal txt As TextBox) _
    As String
        If txt.Text.Trim() = "" Then
            txt.Focus()
            txt.SelectAll()
            Throw New Exception("Preencha o campo - " & _
            txt.Name.Replace("TextBox", "").ToUpper())
        End If
        Return txt.Text
    End Function
End Class
