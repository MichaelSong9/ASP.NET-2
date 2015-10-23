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
        Me.Label1 = New System.Windows.Forms.Label
        Me.codigoLabel = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.nomeTextBox = New System.Windows.Forms.TextBox
        Me.enderecoTextBox = New System.Windows.Forms.TextBox
        Me.incluirButton = New System.Windows.Forms.Button
        Me.alterarButton = New System.Windows.Forms.Button
        Me.excluirButton = New System.Windows.Forms.Button
        Me.procurarPorNomeButton = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código:"
        '
        'codigoLabel
        '
        Me.codigoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.codigoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.codigoLabel.Location = New System.Drawing.Point(124, 11)
        Me.codigoLabel.Name = "codigoLabel"
        Me.codigoLabel.Size = New System.Drawing.Size(101, 32)
        Me.codigoLabel.TabIndex = 1
        Me.codigoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(41, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 26)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nome:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 26)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Endereço:"
        '
        'nomeTextBox
        '
        Me.nomeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nomeTextBox.Location = New System.Drawing.Point(125, 70)
        Me.nomeTextBox.Name = "nomeTextBox"
        Me.nomeTextBox.Size = New System.Drawing.Size(490, 32)
        Me.nomeTextBox.TabIndex = 3
        '
        'enderecoTextBox
        '
        Me.enderecoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enderecoTextBox.Location = New System.Drawing.Point(125, 129)
        Me.enderecoTextBox.Name = "enderecoTextBox"
        Me.enderecoTextBox.Size = New System.Drawing.Size(490, 32)
        Me.enderecoTextBox.TabIndex = 5
        '
        'incluirButton
        '
        Me.incluirButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.incluirButton.Location = New System.Drawing.Point(12, 192)
        Me.incluirButton.Name = "incluirButton"
        Me.incluirButton.Size = New System.Drawing.Size(125, 42)
        Me.incluirButton.TabIndex = 6
        Me.incluirButton.Text = "Incluir"
        Me.incluirButton.UseVisualStyleBackColor = True
        '
        'alterarButton
        '
        Me.alterarButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.alterarButton.Location = New System.Drawing.Point(143, 192)
        Me.alterarButton.Name = "alterarButton"
        Me.alterarButton.Size = New System.Drawing.Size(125, 42)
        Me.alterarButton.TabIndex = 7
        Me.alterarButton.Text = "Alterar"
        Me.alterarButton.UseVisualStyleBackColor = True
        '
        'excluirButton
        '
        Me.excluirButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.excluirButton.Location = New System.Drawing.Point(274, 192)
        Me.excluirButton.Name = "excluirButton"
        Me.excluirButton.Size = New System.Drawing.Size(125, 42)
        Me.excluirButton.TabIndex = 8
        Me.excluirButton.Text = "Excluir"
        Me.excluirButton.UseVisualStyleBackColor = True
        '
        'procurarPorNomeButton
        '
        Me.procurarPorNomeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.procurarPorNomeButton.Location = New System.Drawing.Point(405, 192)
        Me.procurarPorNomeButton.Name = "procurarPorNomeButton"
        Me.procurarPorNomeButton.Size = New System.Drawing.Size(210, 42)
        Me.procurarPorNomeButton.TabIndex = 9
        Me.procurarPorNomeButton.Text = "Procurar por Nome"
        Me.procurarPorNomeButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(12, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(603, 2)
        Me.Label2.TabIndex = 10
        '
        'clienteForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 249)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.procurarPorNomeButton)
        Me.Controls.Add(Me.excluirButton)
        Me.Controls.Add(Me.alterarButton)
        Me.Controls.Add(Me.incluirButton)
        Me.Controls.Add(Me.enderecoTextBox)
        Me.Controls.Add(Me.nomeTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.codigoLabel)
        Me.Controls.Add(Me.Label1)
        Me.MaximumSize = New System.Drawing.Size(636, 276)
        Me.MinimumSize = New System.Drawing.Size(636, 276)
        Me.Name = "clienteForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents codigoLabel As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents nomeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents enderecoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents incluirButton As System.Windows.Forms.Button
    Friend WithEvents alterarButton As System.Windows.Forms.Button
    Friend WithEvents excluirButton As System.Windows.Forms.Button
    Friend WithEvents procurarPorNomeButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
