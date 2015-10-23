Imports System
Imports System.IO
Imports System.Web
Imports System.Data
Imports System.Net.mail
Imports System.Threading
Imports System.Resources
Imports System.Globalization
Imports System.Configuration
Imports Microsoft.VisualBasic
Imports System.Data.OracleClient
Imports System.Web.Configuration
Imports ConexaoBanco.ConexaoBanco

Partial Class Pagamentos_Email_Email
    Inherits System.Web.UI.Page
    Private sConnectString As String = ConfigurationManager.ConnectionStrings("ConnectionString").ToString()
    Private dtReader As DataTable
    Private dtTable As DataTable
    Private ds As DataSet
    Public Shared arrEMail As New ArrayList()
    Public Shared arrArq As New ArrayList()
    Public Shared arrArquivos As New ArrayList()
    Public seleciona As Boolean

#Region "Page Load..."
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Page.Title = "Contas a Pagar"

        If IsPostBack = False Then
            txt_DataInicial.Focus()
        End If
    End Sub
#End Region

#Region "Sub - Chamar Modal do E-mail"
    Public Sub ChamarEmail()
        ModalPopupExtender1.Show()
        ModalPopupExtender1.X = 100
        ModalPopupExtender1.Y = 50
    End Sub
#End Region

#Region "Limpar ListBox de outros anexos"
    Public Sub LimparArquivo(ByVal condicao As Boolean)
        If ListBoxAnexos.SelectedIndex > -1 Then
            arrArquivos.Remove(ListBoxAnexos.SelectedValue)
            ListBoxAnexos.Items.Remove(ListBoxAnexos.SelectedValue)
            If condicao = True Then
                ChamarEmail()
            End If
        Else
            If condicao = True Then
                Dim cs As ClientScriptManager = Page.ClientScript
                cs.RegisterClientScriptBlock(Me.[GetType](), "Selecionar", "alert(Selecione um arquivo na lista!)", True)
                ChamarEmail()
            Else
                ListBoxAnexos.Items.Clear()
                arrArquivos.Clear()
            End If
        End If
    End Sub
#End Region

#Region "Excluir outro anexo"
    Protected Sub cmdExcluir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdExcluir.Click
        LimparArquivo(True)
    End Sub
#End Region

#Region "Anexar outro arquivo"
    Protected Sub cmdAnexarArquivo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAnexarArquivo.Click
        If Not FileUpload1.HasFile Then
            ScriptManager.RegisterStartupScript(Page, Page.GetType, "JavaScript", "alert('Selecione um arquivo para carregar!');", True)
            ChamarEmail()
            Return
        End If

        If FileUpload1.PostedFile.ContentLength > 100000 Then
            ScriptManager.RegisterStartupScript(Page, Page.GetType, "JavaScript", "alert('O tamanho do arquivo é maior que o tamanho permitido!');", True)
            ChamarEmail()
            Return
        Else
            arrArquivos.Add(FileUpload1)
            ListBoxAnexos.Items.Add(FileUpload1.PostedFile.FileName)
        End If

        Dim caminho As String = Server.MapPath("Anexos\")

        For Each iFile As FileUpload In arrArquivos
            iFile.PostedFile.SaveAs(caminho + Path.GetFileName(iFile.PostedFile.FileName))
            lblMensagem.Text = "O e-mail possui " + ListBoxAnexos.Items.Count.ToString() + " arquivo(s) anexado(s)"
        Next
        ChamarEmail()
    End Sub
#End Region

#Region "Pesquisar pagamentos"
    Protected Sub imbPesquisar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles imbPesquisar.Click
        Dim data_inicial As Date = Convert.ToDateTime(txt_DataInicial.Text)
        Dim data_final As Date = Convert.ToDateTime(txt_DataFinal.Text)

        If txt_DataInicial.Text = "" And txt_DataFinal.Text = "" Then
            ScriptManager.RegisterStartupScript(Page, Page.GetType, "JavaScript", "alert('Selecione o intervalo de datas a ser pesquisado!');", True)
        Else
            If data_final > System.DateTime.Now Then
                ScriptManager.RegisterStartupScript(Page, Page.GetType, "JavaScript", "alert('A data de pagamento final é maior que a data atual, verifique!');", True)
            Else
                If data_inicial > data_final Then
                    ScriptManager.RegisterStartupScript(Page, Page.GetType, "JavaScript", "alert('A data de pagamento inicial é maior que a data final, verifique!');", True)
                Else
                    Dim sPathLocal = HttpContext.Current.Server.MapPath("Anexos").ToString()
                    Try
                        Kill(sPathLocal + "\*.*")
                    Catch
                    End Try

                    If txt_CGCInicial.Text = "" Then
                        txt_CGCInicial.Text = "00000000"
                    End If

                    If txt_CGCFinal.Text = "" Then
                        txt_CGCFinal.Text = "99999999"
                    End If

                    Session("ds1") = ""
                    gridEmail.DataSource = ds
                    gridEmail.DataBind()

                    PesquisaHistorico(True)
                End If
            End If
        End If
    End Sub
#End Region

#Region "Enviar E-mail"
    Protected Sub imbEnviarEmail_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles imbEnviarEmail.Click

        Dim mail As New MailMessage()
        'mail.From = New MailAddress("thiago.alves@ccl.com.br")
        mail.From = New MailAddress(txtDe.Text)

        Dim smtp As New SmtpClient("cclmail.ccl.com.br")
        smtp.Credentials = New Net.NetworkCredential("ctapagar", "D3VeNd0")

        Dim email As String
        Dim nome_arquivo As String
        Dim sPathLocal As String = Server.MapPath("Anexos\")
        Dim FilePath As String

        Dim i As Integer = 0
        Dim perdidos As Integer = 0
        Dim enviados As Integer = 0
        Dim contador As Integer = 0

        mail.Subject = txtAssunto.Text
        mail.IsBodyHtml = True
        mail.Body = FreeTextBox1.Text
        mail.SubjectEncoding = Encoding.GetEncoding("ISO-8859-1")
        mail.BodyEncoding = Encoding.GetEncoding("ISO-8859-1")


        While i < gridEmail.Rows.Count
            Dim row As GridViewRow = gridEmail.Rows(i)
            Dim isCheckedEmail As Boolean = CType(row.FindControl("ItemEmailCheckBox"), CheckBox).Checked
            Dim isCheckedArq As Boolean = CType(row.FindControl("ItemAnexarCheckBox"), CheckBox).Checked

            mail.Attachments.Clear()
            mail.To.Clear()

            If isCheckedArq Then
                nome_arquivo = Trim(gridEmail.Rows(i).Cells(0).Text) + ".pdf"
                FilePath = sPathLocal + "\" + nome_arquivo
                mail.Attachments.Add(New Net.Mail.Attachment(FilePath))
            End If

            If isCheckedEmail Then
                For Each o As Object In ListBoxAnexos.Items
                    mail.Attachments.Add(New Net.Mail.Attachment(o.ToString))
                Next

                Try
                    email = Trim(CType(row.FindControl("lblEmail"), Label).Text)
                    'mail.To.Add(email)
                    mail.To.Add("hildeberto.coelho@ccl.com.br")

                    mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnSuccess
                    mail.Headers.Add("Disposition-Notification-To", "<ctapagar@ccl.com.br>")
                    smtp.Send(mail)

                    enviados += 1
                    ScriptManager.RegisterStartupScript(Page, Page.GetType, "JavaScript", "alert('E-mail(s) enviado(s) com sucesso!');", True)
                Catch smtpEx As SmtpException
                    ClientScript.RegisterStartupScript(Me.GetType(), "Erro!", String.Format("alert('{0}');", smtpEx.Message.Replace("'", "\'")), True)

                    mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure
                    mail.Headers.Add("Disposition-Notification-To", "<ctapagar@ccl.com.br>")
                    perdidos += 1

                Catch generalEx As Exception
                    ClientScript.RegisterStartupScript(Me.GetType(), "Erro!", String.Format("alert('{0}');", generalEx.Message.Replace("'", "\'")), True)
                    mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure
                    mail.Headers.Add("Disposition-Notification-To", "<ctapagar@ccl.com.br>")
                    perdidos += 1
                End Try
            End If
            i += 1
        End While
    End Sub
#End Region

#Region "Consultar Título"
    Protected Sub gridEmail_RowEditing(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewEditEventArgs) Handles gridEmail.RowEditing
        Dim Buscadados As New clEmail
        Dim Cripta As New clDescriptografa
        sConnectString = Cripta.Descrip(sConnectString, Session("BancodeDados"))
        Thread.CurrentThread.CurrentCulture = New CultureInfo("pt-BR")

        Dim data_inicial As String = Convert.ToDateTime(txt_DataInicial.Text).ToString("dd-MMM-yyyy", New CultureInfo("en-US").DateTimeFormat)
        Dim data_final As String = Convert.ToDateTime(txt_DataFinal.Text).ToString("dd-MMM-yyyy", New CultureInfo("en-US").DateTimeFormat)
        Dim cgc As String = gridEmail.DataKeys(e.NewEditIndex).Value
        Dim det_cgc As String
        Dim corpo_cgc As String

        If Len(cgc) > 11 Then
            corpo_cgc = Mid(gridEmail.DataKeys(e.NewEditIndex).Value, 1, 8)
            det_cgc = Mid(gridEmail.DataKeys(e.NewEditIndex).Value, 9, 6)
        Else
            corpo_cgc = gridEmail.DataKeys(e.NewEditIndex).Value
            det_cgc = ""
        End If

        Buscadados.PDATA_LIQ_INI = data_inicial
        Buscadados.PDATA_LIQ_FIM = data_final
        Buscadados.CORPO_CGC = corpo_cgc
        Buscadados.DET_CGC = det_cgc
        Buscadados.PTITULO = ""

        ds = Buscadados.ConsultaTitulo(sConnectString)

        If ds.Tables(0).Rows.Count > 0 Then
            gridVisTit.DataSource = ds
            gridVisTit.DataBind()
            gridVisTit.PageSize = 5

            VisualizarGridModalPopupExtender.Show()
        Else
            ScriptManager.RegisterStartupScript(Page, Page.GetType, "JavaScript", "alert('Dados não encontrados!');", True)
        End If
    End Sub
#End Region

#Region "Gerar Arquivo de Pagamento (PDF)"
    Protected Sub imbProcessar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles imbProcessar.Click
        If txt_DataInicial.Text = "" And txt_DataFinal.Text = "" And txt_CGCInicial.Text = "" And txt_CGCFinal.Text = "" Then
            ScriptManager.RegisterStartupScript(Page, Page.GetType, "JavaScript", "alert('Selecione o intervalo de datas a ser processado!');", True)
        Else
            Dim Cripta As New clDescriptografa
            sConnectString = Cripta.Descrip(sConnectString, Session("BancodeDados"))
            Thread.CurrentThread.CurrentCulture = New CultureInfo("pt-BR")

            Dim data_inicial As String = Convert.ToDateTime(txt_DataInicial.Text).ToString("dd-MMM-yyyy", New CultureInfo("en-US").DateTimeFormat)
            Dim data_final As String = Convert.ToDateTime(txt_DataFinal.Text).ToString("dd-MMM-yyyy", New CultureInfo("en-US").DateTimeFormat)
            Dim data_atual_param As String = Date.Now.ToString("dd-MMM-yyyy", New CultureInfo("en-US").DateTimeFormat)

            Dim Buscadados As New clEmail

            Dim i As Integer = 0
            Dim contador As Integer = 0

            While i < gridEmail.Rows.Count
                Dim row As GridViewRow = gridEmail.Rows(i)
                Dim isChecked As Boolean = CType(row.FindControl("ItemAnexarCheckBox"), CheckBox).Checked

                If isChecked Then
                    Dim cgc As String = "\" + Trim(gridEmail.Rows(i).Cells(0).Text) + ".pdf"
                    Dim det_cgc As String
                    Dim corpo_cgc As String
                    Dim email As String = CType(row.FindControl("lblEmail"), Label).Text

                    If Len(Trim(gridEmail.Rows(i).Cells(0).Text)) > 11 Then
                        corpo_cgc = Mid(gridEmail.Rows(i).Cells(0).Text, 1, 8)
                        det_cgc = Mid(gridEmail.Rows(i).Cells(0).Text, 9, 6)
                    Else
                        corpo_cgc = Mid(gridEmail.Rows(i).Cells(0).Text, 1, 8)
                        det_cgc = ""
                    End If

                    Buscadados.PDATA_LIQ_INI = data_inicial
                    Buscadados.PDATA_LIQ_FIM = data_final
                    Buscadados.PCNPJ_DE = corpo_cgc
                    Buscadados.PCNPJ_ATE = corpo_cgc
                    Buscadados.PCODEMP_D_INI = "0000000"
                    Buscadados.PCODEMP_D_FIM = "9999999"
                    Buscadados.PEMISSAO_INI = "01-Jan-1996"
                    Buscadados.PEMISSAO_FIM = data_atual_param
                    Buscadados.PDATA_VENC_INI = "01-Jan-1996"
                    Buscadados.PDATA_VENC_FIM = data_atual_param
                    Buscadados.PNUM_TIT_INI = "00000000"
                    Buscadados.PNUM_TIT_FIM = "ZZZZZZZZ"
                    Buscadados.DET_CGC = det_cgc
                    Buscadados.PUSUARIO = Session("Usuario")
                    Buscadados.PSTATUS = ""
                    Buscadados.PCONDICAO = "A"      'condição para gravar o log, A - arquivo.
                    Buscadados.PEMAIL = email

                    Buscadados.GerarArquivo(sConnectString, cgc)
                    contador += 1
                    txtProcessa.Text = True
                End If
                i += 1
            End While

            If contador = 0 Then
                ScriptManager.RegisterStartupScript(Page, Page.GetType, "JavaScript", "alert('Selecione um arquivo a ser processado!');", True)
            Else
                lblMensagem.Text = "Foram anexados(s) " + contador.ToString + " arquivo(s) de pagamento."
                ScriptManager.RegisterStartupScript(Page, Page.GetType, "JavaScript", "alert('Arquivo(s) de cobrança processado(s) com sucesso!');", True)

                i = 0

                Dim cont As Integer = 1
                While i < gridEmail.Rows.Count
                    Dim row As GridViewRow = gridEmail.Rows(i)
                    Dim chkArq As Boolean = CType(row.FindControl("ItemAnexarCheckBox"), CheckBox).Checked
                    Dim chkEmail As Boolean = CType(row.FindControl("ItemEmailCheckBox"), CheckBox).Checked

                    If chkArq Then
                        arrArq.Add(Trim(gridEmail.Rows(i).Cells(0).Text))
                        cont += 1
                    End If

                    If chkEmail Then
                        arrEMail.Add(Trim(gridEmail.Rows(i).Cells(0).Text))
                        cont += 1
                    End If

                    i += 1
                End While

                ds = CType(Session("ds1"), DataSet)
                gridEmail.DataSource = ds
                gridEmail.DataBind()

                i = 0

                While i < gridEmail.Rows.Count
                    Dim row As GridViewRow = gridEmail.Rows(i)
                    Dim cgc As String = Trim(gridEmail.Rows(i).Cells(0).Text)
                    Dim nLoop As Integer
                    Dim contArray As Integer = 0

                    Dim verificarArquivo As Boolean = False
                    Dim verificarEmail As Boolean = False

                    For nLoop = 1 To arrArq.Count
                        If arrArq.Item(contArray) = cgc Then
                            verificarArquivo = True
                            Exit For
                        End If
                        contArray += 1
                    Next

                    contArray = 0

                    For nLoop = 1 To arrEMail.Count
                        If arrEMail.Item(contArray) = cgc Then
                            verificarEmail = True
                            Exit For
                        End If
                        contArray += 1
                    Next

                    If verificarArquivo = True Then
                        CType(row.FindControl("ItemAnexarCheckBox"), CheckBox).Checked = True
                    End If

                    If verificarEmail = True Then
                        CType(row.FindControl("ItemEmailCheckBox"), CheckBox).Checked = True
                    End If
                    i += 1
                End While
            End If
        End If
    End Sub
#End Region

#Region "Abrir tela Novo E-mail"
    Protected Sub imbNovoEmail_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles imbNovoEmail.Click
        If txt_DataInicial.Text = "" And txt_DataFinal.Text = "" And txt_CGCInicial.Text = "" And txt_CGCFinal.Text = "" Then
            ScriptManager.RegisterStartupScript(Page, Page.GetType, "JavaScript", "alert('Selecione o intervalo de datas a ser processado!');", True)
        Else
            Dim i As Integer = 0
            Dim contador As Integer = 0
            txtPara.Text = ""
            While i < gridEmail.Rows.Count
                Dim row As GridViewRow = gridEmail.Rows(i)
                Dim isChecked As Boolean = CType(row.FindControl("ItemEmailCheckBox"), CheckBox).Checked

                If isChecked Then
                    Dim email As String = "'" + Trim(CType(row.FindControl("lblEmail"), Label).Text) + "'; "
                    txtPara.Text = txtPara.Text + email
                    contador += 1
                End If
                i += 1
            End While
            If contador = 0 Then
                ScriptManager.RegisterStartupScript(Page, Page.GetType, "JavaScript", "alert('Selecione um e-mail a ser enviado!');", True)
            Else
                FreeTextBox1.Text = "Segue em anexo o arquivo referente ao pagamento dos títulos de: " & txt_DataInicial.Text & " até: " & txt_DataFinal.Text
                LimparArquivo(False)
                ChamarEmail()
            End If
        End If
    End Sub
#End Region

#Region "Visualizar arquivo PDF"
    Protected Sub gridEmail_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles gridEmail.RowDataBound
        If e.Row.RowType = DataControlRowType.DataRow Then
            Dim sNomeArquivo As String = Trim(gridEmail.DataKeys(e.Row.RowIndex)(0).ToString()) & ".pdf"
            Dim sPathRel = HttpContext.Current.Server.MachineName.ToString
            Dim caminho As String = Server.MapPath("Anexos\") + sNomeArquivo

            Dim imbVisualizar As ImageButton = DirectCast(e.Row.FindControl("imbVisualizar"), ImageButton)
            Dim anexarCHK As CheckBox = DirectCast(e.Row.FindControl("ItemAnexarCheckBox"), CheckBox)
            Dim visualizar As ImageButton = DirectCast(e.Row.FindControl("imbVisualizar"), ImageButton)
            Dim email As Label = DirectCast(e.Row.FindControl("lblEmail"), Label)
            Dim selEmail As CheckBox = DirectCast(e.Row.FindControl("ItemEmailCheckBox"), CheckBox)

            If email.Text = "" Then
                anexarCHK.Enabled = False
                visualizar.Enabled = False
                selEmail.Enabled = False
            End If

            If File.Exists(caminho) = True Then
                imbVisualizar.Attributes.Add("onmouseover", "this.style.cursor='hand'")
                imbVisualizar.Attributes.Add("onclick", "javascript:window.open('http://" + sPathRel + "/CtaPagar/Pagamentos/Email/Anexos/" + sNomeArquivo + "','_blank');")
            Else
                imbVisualizar.Attributes.Add("onmouseover", "this.style.cursor='hand'")
                imbVisualizar.Attributes.Add("onclick", "javascript:alert('O arquivo ainda não foi processado!');")
            End If
        End If
    End Sub
#End Region

#Region "Paginação do GridEmail"
    Protected Sub gridEmail_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridEmail.SelectedIndexChanged
        PesquisaHistorico(False)
    End Sub
    Protected Sub gridEmail_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles gridEmail.PageIndexChanging
        gridEmail.PageIndex = e.NewPageIndex
        PesquisaHistorico(False)
    End Sub

    Protected Sub PesquisaHistorico(ByVal Condicao As Boolean)
        If Condicao Then
            Dim Buscadados As New clEmail
            Dim Cripta As New clDescriptografa

            sConnectString = Cripta.Descrip(sConnectString, Session("BancodeDados"))
            Thread.CurrentThread.CurrentCulture = New CultureInfo("pt-BR")

            Dim data_inicial As String = Convert.ToDateTime(txt_DataInicial.Text).ToString("dd-MMM-yyyy", New CultureInfo("en-US").DateTimeFormat)
            Dim data_final As String = Convert.ToDateTime(txt_DataFinal.Text).ToString("dd-MMM-yyyy", New CultureInfo("en-US").DateTimeFormat)
            Dim s_cgc_inicial As String = txt_CGCInicial.Text
            Dim s_cgc_final As String = txt_CGCFinal.Text

            Buscadados.PDATA_LIQ_INI = data_inicial
            Buscadados.PDATA_LIQ_FIM = data_final
            Buscadados.PCORPO_CGC_INI = s_cgc_inicial
            Buscadados.PCORPO_CGC_FIM = s_cgc_final

            ds = Buscadados.Pesquisar(sConnectString)

            If ds.Tables.Count > 0 Then
                Session("ds1") = ds
            Else
                ScriptManager.RegisterStartupScript(Page, Page.GetType, "JavaScript", "alert('Dados não encontrados!');", True)
            End If
        End If

        ds = CType(Session("ds1"), DataSet)

        If ds.Tables(0).Rows.Count > 0 Then
            gridEmail.DataSource = ds
            gridEmail.DataBind()
        Else
            ScriptManager.RegisterStartupScript(Page, Page.GetType, "JavaScript", "alert('Dados não encontrados!');", True)
        End If

    End Sub
#End Region

End Class