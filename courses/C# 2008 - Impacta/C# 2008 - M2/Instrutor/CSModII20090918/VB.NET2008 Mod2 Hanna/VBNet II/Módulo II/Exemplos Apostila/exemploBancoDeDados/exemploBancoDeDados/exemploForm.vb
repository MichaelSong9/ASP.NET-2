Public Class exemploForm

    Private Sub exemploForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LojaSQLDataSet.Cliente' table. You can move, or remove it, as needed.
        Me.ClienteTableAdapter.Fill(Me.LojaSQLDataSet.Cliente)
        'TODO: This line of code loads data into the 'LojaSQLDataSet.Cliente' table. You can move, or remove it, as needed.
        Me.ClienteTableAdapter.Fill(Me.LojaSQLDataSet.Cliente)

    End Sub
End Class
