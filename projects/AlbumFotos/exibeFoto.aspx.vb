
Partial Class exibeFoto
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim fotoid As Integer = Convert.ToInt32(Request.QueryString("fotoid"))

        If fotoid > 0 Then
            Dim p As Foto = FotoHelper.getFotoPorCodigo(fotoid)
            Try
                Response.Clear()
                Response.ContentType = "image/pjpeg"
                Response.BinaryWrite(p.FotoDados)
                Response.End()
            Catch
                lblmsg.text = "Não foi possível exibir imagem"
            End Try

        End If
    End Sub
End Class
