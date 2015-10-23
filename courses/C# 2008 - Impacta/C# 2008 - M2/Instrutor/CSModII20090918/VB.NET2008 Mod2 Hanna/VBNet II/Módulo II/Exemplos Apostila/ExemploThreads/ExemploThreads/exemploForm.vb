'Diretiva
Imports System.Threading

Public Class exemploForm

    Public Sub Mensagem1()
        For i As Integer = 0 To 5 Step 1
            MessageBox.Show("Threads " + i.ToString(), "Mensagem 1")
        Next
    End Sub

    Public Sub Mensagem2()
        For i As Integer = 0 To 5 Step 1
            MessageBox.Show("Threads " + i.ToString(), "Mensagem 2")
        Next
    End Sub

    Private Sub exemploButton_Click(ByVal sender As System.Object, _
                                    ByVal e As System.EventArgs) Handles exemploButton.Click

        Dim msg1 As New Thread(AddressOf Mensagem1)
        Dim msg2 As New Thread(AddressOf Mensagem2)

        msg1.Start()
        msg2.Start()
    End Sub
End Class
