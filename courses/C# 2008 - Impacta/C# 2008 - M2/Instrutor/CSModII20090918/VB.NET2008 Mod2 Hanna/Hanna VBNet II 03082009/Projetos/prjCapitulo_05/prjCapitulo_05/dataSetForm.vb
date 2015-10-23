Public Class dataSetForm
    Dim dsBanco As New DataSet
    Dim Pais As New DataTable
    Dim Cliente As New DataTable
    Dim dvPais As DataView

    Private Sub dataSetForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Construção do DataTable
        Pais.Columns.Add("CodigoPais", GetType(Integer))
        Pais.Columns.Add("NomePais")

        'Popular o DataTable
        Pais.Rows.Add(1, "Brasil")
        Pais.Rows.Add(2, "Itália")
        Pais.Rows.Add(3, "México")
        Pais.Rows.Add(4, "Turquia")

        'Associação do DataTable ao DataSet
        dsBanco.Tables.Add(Pais)
        dsBanco.Tables(0).TableName = "Pais"

        'DataGridView1.DataSource = dsBanco.Tables(0)

        'Construção do DataTable
        Cliente.Columns.Add("CodigoCli", GetType(Integer))
        Cliente.Columns.Add("NomeCli")
        Cliente.Columns.Add("CodigoPais", GetType(Integer))

        'Popular o DataTable
        Cliente.Rows.Add(1, "Joselito", 2)
        Cliente.Rows.Add(2, "Marilivia", 1)
        Cliente.Rows.Add(3, "Cesalpino", 3)
        Cliente.Rows.Add(4, "Adalfranklin", 1)
        Cliente.Rows.Add(5, "Ueliton", 3)
        Cliente.Rows.Add(6, "Geralcina", 2)
        Cliente.Rows.Add(7, "Godofredo", 4)
        Cliente.Rows.Add(8, "Mustafa", 3)

        'Associação do DataTable ao DataSet
        dsBanco.Tables.Add(Cliente)
        dsBanco.Tables(1).TableName = "Cliente"

        'DataGridView1.DataSource = dsBanco.Tables("Cliente")

        'Relacionar os dados
        dsBanco.Relations.Add("ClientePorPais", _
        Pais.Columns("CodigoPais"), Cliente.Columns("CodigoPais"))

        dvPais = New DataView(dsBanco.Tables("Pais"))
        dvPais.Sort = "NomePais"

        paisComboBox.DataSource = dvPais
        paisComboBox.DisplayMember = "NomePais"

    End Sub

    Private Sub paisComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles paisComboBox.SelectedIndexChanged
        Dim dvCliente As DataView = _
        dvPais(paisComboBox.SelectedIndex). _
        CreateChildView("ClientePorPais")

        dvCliente.Sort = "NomeCli"
        clienteListBox.DataSource = dvCliente
        clienteListBox.DisplayMember = "NomeCli"
    End Sub
End Class
