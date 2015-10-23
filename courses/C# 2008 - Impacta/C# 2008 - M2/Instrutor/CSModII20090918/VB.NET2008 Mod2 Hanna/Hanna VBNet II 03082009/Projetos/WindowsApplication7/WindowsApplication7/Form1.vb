Imports System.Threading
Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim m1 As New Thread(AddressOf mensagem_1)
        Dim m2 As New Thread(AddressOf mensagem_2)

        m1.Start()
        Thread.Sleep(5000)
        m2.Start()

    End Sub

    Public Sub mensagem_1()
        For i As Integer = 0 To 5
            MessageBox.Show("Message 1")
        Next
    End Sub

    Public Sub mensagem_2()
        For i As Integer = 0 To 5
            MessageBox.Show("Message 2")
        Next
    End Sub
End Class
