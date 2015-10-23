Imports System.Windows.Forms

Public Class Documento
    Public Function Formatar(ByVal txt As TextBox) As String
        Dim doc As String

        If txt.Text.Length = 11 Then
            doc = String.Format("{0}.{1}.{2}-{3}", _
            txt.Text.Substring(0, 3), txt.Text.Substring(3, 3), _
            txt.Text.Substring(6, 3), txt.Text.Substring(9, 2))
        ElseIf txt.Text.Length = 14 Then
            doc = String.Format("{0}.{1}.{2}/{3}-{4}", _
            txt.Text.Substring(0, 2), txt.Text.Substring(2, 3), _
            txt.Text.Substring(5, 3), txt.Text.Substring(8, 4), _
            txt.Text.Substring(12, 2))
        Else
            doc = txt.Text
        End If

        Return doc
    End Function

    Public Function RetirarFormato(ByVal txt As TextBox) As String
        Dim doc As String

        doc = txt.Text.Replace(".", "").Replace("/", "").Replace("-", "")

        Return doc
    End Function

End Class
