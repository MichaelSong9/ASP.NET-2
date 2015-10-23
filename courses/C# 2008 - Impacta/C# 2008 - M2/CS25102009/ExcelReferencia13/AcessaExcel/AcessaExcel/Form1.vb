Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim xl As New Excel.Application

        With xl
            .Visible = True

            .Workbooks.Add()

            .Cells(3, 4) = TextBox1.Text


            .ActiveWorkbook.Close(False)
        End With

        xl = Nothing
    End Sub
End Class
