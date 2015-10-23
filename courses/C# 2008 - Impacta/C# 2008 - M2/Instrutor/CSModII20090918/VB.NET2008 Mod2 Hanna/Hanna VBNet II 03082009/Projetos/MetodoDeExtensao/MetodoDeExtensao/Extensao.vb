Imports System.Runtime.CompilerServices
Imports System.Text.RegularExpressions

Module Extensao
    <Extension()> Public Function Moeda( _
    ByVal valor As Decimal, ByVal Pais As String) As String
        Dim cultura As String = ""

        Select Case Pais.ToUpper()
            Case "BRASIL"
                cultura = "pt-br"
            Case "INGLATERRA"
                cultura = "en-gb"
        End Select

        Return valor.ToString("C2", _
        New System.Globalization.CultureInfo(cultura))
    End Function

    <Extension()> Public Function ValidarEmail( _
    ByVal email As String) As Boolean
        If Not (Regex.IsMatch(email, _
        "^[a-z0-9\._\-]+\@+[a-z0-9\._\-]+\.[a-z]+$")) Then
            Return False
        End If
        Return True
    End Function
End Module
