Imports Microsoft.VisualBasic
Imports DataProtection

Public Class clDescriptografa
    Public Function Descrip(ByVal conn As String, ByVal banco As String) As String
        Dim dp As DataProtector = New DataProtector(DataProtector.Store.USE_MACHINE_STORE)
        Dim dataToDecrypt() As Byte
        dataToDecrypt = Convert.FromBase64String(conn)
        Dim connStr As String = Encoding.ASCII.GetString(dp.Decrypt(dataToDecrypt, Nothing))
        connStr = connStr & ";Data Source=" & banco
        Return connStr
    End Function
End Class
