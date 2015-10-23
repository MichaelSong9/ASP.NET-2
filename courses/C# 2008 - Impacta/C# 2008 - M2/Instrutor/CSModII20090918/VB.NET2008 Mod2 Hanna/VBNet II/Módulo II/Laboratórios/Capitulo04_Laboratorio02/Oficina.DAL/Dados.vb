Public Class Dados
    Public Shared Function StringDeConexao() As String
        Return "Integrated Security=SSPI;Persist Security Info=False;" & _
                    "Initial Catalog=Oficina;Data Source=.\sqlexpress"
    End Function
End Class
