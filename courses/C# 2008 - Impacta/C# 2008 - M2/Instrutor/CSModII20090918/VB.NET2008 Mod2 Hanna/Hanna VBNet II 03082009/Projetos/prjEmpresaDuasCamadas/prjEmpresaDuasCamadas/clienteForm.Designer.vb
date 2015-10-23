<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class clienteForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label1 = New System.Windows.Forms.Label
        Me.codigoLabel = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.nomeTextBox = New System.Windows.Forms.TextBox
        Me.enderecoTextBox = New System.Windows.Forms.TextBox
        Me.inserirButton = New System.Windows.Forms.Button
        Me.alterarButton = New System.Windows.Forms.Button
        Me.excluirButton = New System.Windows.Forms.Button
        Me.procurarPorNomeButton = New System.Windows.Forms.Button
        Me.ClienteDataGridView = New System.Windows.Forms.DataGridView
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nome = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Endereco = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.ClienteDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código:"
        '
        'codigoLabel
        '
        Me.codigoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.codigoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.codigoLabel.Location = New System.Drawing.Point(137, 14)
        Me.codigoLabel.Name = "codigoLabel"
        Me.codigoLabel.Size = New System.Drawing.Size(90, 32)
        Me.codigoLabel.TabIndex = 1
        Me.codigoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(46, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 26)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nome:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 26)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Endereço:"
        '
        'nomeTextBox
        '
        Me.nomeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nomeTextBox.Location = New System.Drawing.Point(137, 61)
        Me.nomeTextBox.Name = "nomeTextBox"
        Me.nomeTextBox.Size = New System.Drawing.Size(442, 32)
        Me.nomeTextBox.TabIndex = 3
        '
        'enderecoTextBox
        '
        Me.enderecoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enderecoTextBox.Location = New System.Drawing.Point(137, 103)
        Me.enderecoTextBox.Name = "enderecoTextBox"
        Me.enderecoTextBox.Size = New System.Drawing.Size(442, 32)
        Me.enderecoTextBox.TabIndex = 5
        '
        'inserirButton
        '
        Me.inserirButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inserirButton.Location = New System.Drawing.Point(17, 157)
        Me.inserirButton.Name = "inserirButton"
        Me.inserirButton.Size = New System.Drawing.Size(100, 35)
        Me.inserirButton.TabIndex = 6
        Me.inserirButton.Text = "Inserir"
        Me.inserirButton.UseVisualStyleBackColor = True
        '
        'alterarButton
        '
        Me.alterarButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.alterarButton.Location = New System.Drawing.Point(127, 157)
        Me.alterarButton.Name = "alterarButton"
        Me.alterarButton.Size = New System.Drawing.Size(100, 35)
        Me.alterarButton.TabIndex = 7
        Me.alterarButton.Text = "Alterar"
        Me.alterarButton.UseVisualStyleBackColor = True
        '
        'excluirButton
        '
        Me.excluirButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.excluirButton.Location = New System.Drawing.Point(237, 157)
        Me.excluirButton.Name = "excluirButton"
        Me.excluirButton.Size = New System.Drawing.Size(100, 35)
        Me.excluirButton.TabIndex = 8
        Me.excluirButton.Text = "Excluir"
        Me.excluirButton.UseVisualStyleBackColor = True
        '
        'procurarPorNomeButton
        '
        Me.procurarPorNomeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.procurarPorNomeButton.Location = New System.Drawing.Point(347, 157)
        Me.procurarPorNomeButton.Name = "procurarPorNomeButton"
        Me.procurarPorNomeButton.Size = New System.Drawing.Size(230, 35)
        Me.procurarPorNomeButton.TabIndex = 9
        Me.procurarPorNomeButton.Text = "Procurar por Nome"
        Me.procurarPorNomeButton.UseVisualStyleBackColor = True
        '
        'ClienteDataGridView
        '
        Me.ClienteDataGridView.AllowUserToAddRows = False
        Me.ClienteDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClienteDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ClienteDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ClienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClienteDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Nome, Me.Endereco})
        Me.ClienteDataGridView.Location = New System.Drawing.Point(17, 213)
        Me.ClienteDataGridView.Name = "ClienteDataGridView"
        Me.ClienteDataGridView.Size = New System.Drawing.Size(560, 293)
        Me.ClienteDataGridView.TabIndex = 10
        '
        'Codigo
        '
        Me.Codigo.FillWeight = 45.68528!
        Me.Codigo.HeaderText = "Código"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        '
        'Nome
        '
        Me.Nome.FillWeight = 127.1574!
        Me.Nome.HeaderText = "Nome"
        Me.Nome.Name = "Nome"
        Me.Nome.ReadOnly = True
        '
        'Endereco
        '
        Me.Endereco.FillWeight = 127.1574!
        Me.Endereco.HeaderText = "Endereço"
        Me.Endereco.Name = "Endereco"
        Me.Endereco.ReadOnly = True
        '
        'clienteForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 518)
        Me.Controls.Add(Me.ClienteDataGridView)
        Me.Controls.Add(Me.procurarPorNomeButton)
        Me.Controls.Add(Me.excluirButton)
        Me.Controls.Add(Me.alterarButton)
        Me.Controls.Add(Me.inserirButton)
        Me.Controls.Add(Me.enderecoTextBox)
        Me.Controls.Add(Me.nomeTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.codigoLabel)
        Me.Controls.Add(Me.Label1)
        Me.MaximumSize = New System.Drawing.Size(604, 545)
        Me.MinimumSize = New System.Drawing.Size(604, 238)
        Me.Name = "clienteForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cliente"
        CType(Me.ClienteDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents codigoLabel As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents nomeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents enderecoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents inserirButton As System.Windows.Forms.Button
    Friend WithEvents alterarButton As System.Windows.Forms.Button
    Friend WithEvents excluirButton As System.Windows.Forms.Button
    Friend WithEvents procurarPorNomeButton As System.Windows.Forms.Button
    Friend WithEvents ClienteDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nome As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Endereco As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
