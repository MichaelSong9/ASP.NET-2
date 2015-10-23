Public Class fundoForm
#Region "... Variáveis ..."
    'Declaração de variáveis
    Public xInicio, xFim, yInicio, yFim, altura, largura As Integer
    Public selecionando As Boolean
#End Region

    Private Sub fundoForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim limites As Rectangle
            Dim tela As Bitmap
            Dim g As Graphics

            'Captura os limites da tela
            limites = Screen.PrimaryScreen.Bounds

            'Atribui a imagem da tela  ao objeto tela
            tela = New Bitmap(limites.Width, limites.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb)

            g = Graphics.FromImage(tela)
            g.CopyFromScreen(limites.X, limites.Y, 0, 0, limites.Size, CopyPixelOperation.SourceCopy)

            Me.BackgroundImage = tela

            capturaTelaForm.Show()

        Catch ex As Exception
            MessageBox.Show("Erro ao tentar carregar o formulário", "Alerta de Erro", _
                MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub Selecionar()
        Try
            If xInicio > xFim OrElse yInicio > yFim Then
                selecionando = False

                MessageBox.Show("A seleção da imagem deve ser feita a partir " & _
                "do canto SUPERIOR ESQUERDO para o canto INFERIOR DIREITO", "Alerta", _
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            Dim g As Graphics
            g = Me.CreateGraphics()

            Dim traço As New Pen(Color.Red)
            traço.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot
            traço.Width = 2

            largura = xFim - xInicio
            altura = yFim - yInicio
            g.DrawRectangle(traço, xInicio, yInicio, largura, altura)

        Catch ex As Exception
            MessageBox.Show("Erro ao tentar selecionar a imagem", "Alerta de Erro", _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub fundoForm_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        Try
            selecionando = True

            Me.Refresh()

            xInicio = MousePosition.X
            yInicio = MousePosition.Y
        Catch ex As Exception

        End Try

    End Sub

    Private Sub fundoForm_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        Try
            xFim = MousePosition.X
            yFim = MousePosition.Y

            If selecionando Then
                Me.Refresh()
                Selecionar()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub fundoForm_MouseUp(ByVal sender As Object, _
                            ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        Try
            If selecionando Then
                selecionando = False
                'xFim = MousePosition.X
                'yFim = MousePosition.Y

                'Carregar a imagem
                Dim selecao As New Rectangle(xInicio, yInicio, largura, altura)
                Dim imagemSelecionada As New Bitmap(selecao.Width, selecao.Height, _
                    System.Drawing.Imaging.PixelFormat.Format32bppArgb)
                Dim g As Graphics = Graphics.FromImage(imagemSelecionada)
                g.CopyFromScreen(selecao.X, selecao.Y, 0, 0, selecao.Size, CopyPixelOperation.SourceCopy)

                capturaTelaForm.imagemPictureBox.Image = imagemSelecionada

                Clipboard.SetImage(imagemSelecionada)

                capturaTelaForm.Text = "Seleção de Imagem - Capturada pelo Clipboard"
                capturaTelaForm.salvarButton.Enabled = True
            End If
        Catch ex As Exception

        End Try
        
    End Sub
End Class
