Imports System.Threading

Public Class threadsForm
    Private Sub threadsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles threadsButton.Click
        Dim m1 As New Thread(AddressOf Mensagem_1)
        Dim m2 As New Thread(AddressOf Mensagem_2)

        m1.Start()
        Thread.Sleep(5000)
        m2.Start()

    End Sub

    Public Sub Mensagem_1()
        For i As Integer = 0 To 5
            MessageBox.Show("Threads - " & _
            i.ToString(), "Mensagem 1")
        Next
    End Sub

    Public Sub Mensagem_2()
        For i As Integer = 0 To 5
            MessageBox.Show("Threads - " & _
            i.ToString(), "Mensagem 2")
        Next
    End Sub
End Class
