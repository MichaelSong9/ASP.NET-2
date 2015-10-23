Public Class Cap01_Lab01Form

    Private Sub calculadoraButton_Click(ByVal sender As System.Object, _
                            ByVal e As System.EventArgs) Handles calculadoraButton.Click

        Dim processos() As Process = Process.GetProcessesByName("calc")

        If processos.Length = 0 Then
            Process.Start("calc.exe")
        Else
            MessageBox.Show("A calculadora já está aberta", "Alerta", _
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

End Class
