Partial Class Rodape
    Inherits System.Web.UI.UserControl

    Public Property Mensagem() As String
        Get
            Return mensagemLabel.Text
        End Get
        Set(ByVal value As String)
            mensagemLabel.Text = value
        End Set
    End Property

End Class
