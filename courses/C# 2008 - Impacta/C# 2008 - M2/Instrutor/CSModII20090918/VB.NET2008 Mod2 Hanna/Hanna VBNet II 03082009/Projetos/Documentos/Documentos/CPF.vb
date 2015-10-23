Public Class CPF
    Public Function ValidarCPF(ByVal cpf As String) As String
        Dim soma As Integer
        Dim dv As String
        Dim resultado As String = ""

        If cpf.Length() <> 11 Then
            resultado = "INCONSISTÊNTE"
        Else
            For i As Integer = 8 To 0 Step -1
                soma += _
                Convert.ToInt32(cpf.Substring(i, 1)) * (i + 1)
            Next
            dv = (soma Mod 11 Mod 10).ToString()

            soma = 0
            For i As Integer = 9 To 1 Step -1
                soma += _
                Convert.ToInt32(cpf.Substring(i, 1)) * i
            Next
            dv &= (soma Mod 11 Mod 10).ToString()

            If dv = cpf.Substring(9, 2) Then
                resultado = "VÁLIDO"
            Else
                resultado = "NÃO VÁLIDO"
            End If
        End If
        Return resultado
    End Function
End Class
