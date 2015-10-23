Imports System.IO
Partial Class _Default
    Inherits System.Web.UI.Page

    Private Sub BindData()
        Dim photos As List(Of Foto) = FotoHelper.getFotos()
        DetailsView1.DataSource = photos
        DetailsView1.DataBind()
    End Sub
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            BindData()
            If DetailsView1.Rows.Count = 0 Then
                DetailsView1.ChangeMode(DetailsViewMode.Insert)
            End If
        End If
    End Sub

    Protected Sub DetailsView1_ItemDeleting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DetailsViewDeleteEventArgs) Handles DetailsView1.ItemDeleting
        Dim fotoid As Integer = Convert.ToInt32(DetailsView1.DataKey(0))
        FotoHelper.Deletar(fotoid)
        BindData()
    End Sub

    Protected Sub DetailsView1_ItemInserting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DetailsViewInsertEventArgs) Handles DetailsView1.ItemInserting
        Dim p As New Foto()

        Dim t1 As TextBox = DirectCast(DetailsView1.Rows(0).Cells(1).Controls(0), TextBox)
        Dim t2 As TextBox = DirectCast(DetailsView1.Rows(1).Cells(1).Controls(1), TextBox)
        Dim fu As FileUpload = DirectCast(DetailsView1.Rows(2).Cells(1).Controls(1), FileUpload)

        p.Titulo = t1.Text
        p.Descricao = t2.Text

        Dim imgdatastream As Stream = fu.PostedFile.InputStream
        Dim imgdatalen As Integer = fu.PostedFile.ContentLength
        Dim imgdata As Byte() = New Byte(imgdatalen - 1) {}
        Dim n As Integer = imgdatastream.Read(imgdata, 0, imgdatalen)

        p.FotoDados = imgdata

        FotoHelper.Inserir(p)
        BindData()
    End Sub

    Protected Sub DetailsView1_ItemUpdating(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DetailsViewUpdateEventArgs) Handles DetailsView1.ItemUpdating
        Dim p As New Foto()

        Dim t1 As TextBox = DirectCast(DetailsView1.Rows(0).Cells(1).Controls(0), TextBox)
        Dim t2 As TextBox = DirectCast(DetailsView1.Rows(1).Cells(1).Controls(1), TextBox)
        Dim fu As FileUpload = DirectCast(DetailsView1.Rows(2).Cells(1).Controls(1), FileUpload)

        p.FotoID = Convert.ToInt32(DetailsView1.DataKey(0))
        p.Titulo = t1.Text
        p.Descricao = t2.Text

        Dim imgdatastream As Stream = fu.PostedFile.InputStream
        Dim imgdatalen As Integer = fu.PostedFile.ContentLength
        Dim imgdata As Byte() = New Byte(imgdatalen - 1) {}
        Dim n As Integer = imgdatastream.Read(imgdata, 0, imgdatalen)

        p.FotoDados = imgdata

        FotoHelper.Atualizar(p)
        BindData()

    End Sub

    Protected Sub DetailsView1_ModeChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DetailsViewModeEventArgs) Handles DetailsView1.ModeChanging
        DetailsView1.ChangeMode(e.NewMode)
        BindData()
    End Sub

    Protected Sub DetailsView1_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DetailsViewPageEventArgs) Handles DetailsView1.PageIndexChanging
        DetailsView1.PageIndex = e.NewPageIndex
        BindData()
    End Sub

End Class
