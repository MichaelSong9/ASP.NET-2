Imports System.Data.Linq

Public Class exemploForm
    Private Sub exemploButton_Click(ByVal sender As System.Object, _
                        ByVal e As System.EventArgs) Handles exemploButton.Click

        Dim cn As String = "Integrated Security=SSPI;" & _
                                    "Persist Security Info=False;" & _
                                    "Initial Catalog=NorthWind;" & _
                                    "Data Source=.\sqlexpress"

        Dim db = New NWind(cn)

        Dim prod = From p In db.Produtos _
                   Select p.ProductName _
                   Order By ProductName

        exemploListBox.DataSource = prod.ToList

    End Sub
End Class


'Objetos
'Dim Fotos = From f In New DirectoryInfo("C:\Fotos\2009_02").GetFiles() _
'                                      Where f.Extension.ToLower() = ".jpg" _
'                                      Order By f.Name _
'                                      Select f.Name, f.Extension

'        For Each foto In Fotos
'            exemploListBox.Items.Add(foto.Name)
'        Next

'Private Sub exemploForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
'    exemploListBox.Items.Add("1;jatobá;3,45;120")
'    exemploListBox.Items.Add("2;cajamanga;2,68;50")
'    exemploListBox.Items.Add("3;seriguela;2,45;12")
'    exemploListBox.Items.Add("4;pequí;2,80;150")
'    exemploListBox.Items.Add("5;pitomba;2,45;60")
'End Sub

'    Dim docXml As New XElement("Produtos")
'    Dim element As XElement = Nothing

'For I As Integer = 0 To exemploListBox.Items.Count - 1
'    Dim registro() = exemploListBox.Items(I).ToString().Split(";")

'    element = New XElement("Produto", New XComment("Atributos do produto " + registro(0)))

'    'Atributos   
'    element.SetAttributeValue("Nome", registro(1))
'    element.SetAttributeValue("Preço", registro(2))
'    element.SetAttributeValue("Estoque", registro(3))

'    'Adiciona elemento ao elemento root   
'    docXml.Add(element)
'Next

'docXml.Save("C:\ProdutosXML.xml")

'MessageBox.Show("Arquivo criado com sucesso", "Aviso")
