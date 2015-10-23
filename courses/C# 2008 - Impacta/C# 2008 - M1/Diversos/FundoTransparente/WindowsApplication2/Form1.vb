Public Class Form1

    Private Sub gravarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gravarButton.Click        
        'Declarar as variáveis
        Dim placa As String
        Dim carro As String
        Dim cor As String
        Dim ano As Short

        'Atribuição de valores as variáveis
        placa = InputBox("Informe a placa", "Entrada de dados").ToLower()
        carro = InputBox("Informe o carro", "Entrada de dados").ToLower()
        cor = InputBox("Informe a cor", "Entrada de dados").ToLower()
        ano = InputBox("Informe o ano", "Entrada de dados")

        'Instanciando objeto StreamWriter
        Dim sw As System.IO.StreamWriter = New System.IO.StreamWriter("C:\oficina.txt", False)
        sw.WriteLine(String.Format("{0};{1};{2};{3}", carro, cor, ano, placa))
        'sw.WriteLine("Carro:    " + carro)
        'sw.WriteLine("Placa:    " + placa)
        'sw.WriteLine("Cor   :   " + cor)
        'sw.WriteLine("Ano   :  " + ano.ToString())
        sw.Close()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lerButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lerButton.Click
        System.Diagnostics.Process.Start("c:\oficina.txt")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Close()
    End Sub
End Class
