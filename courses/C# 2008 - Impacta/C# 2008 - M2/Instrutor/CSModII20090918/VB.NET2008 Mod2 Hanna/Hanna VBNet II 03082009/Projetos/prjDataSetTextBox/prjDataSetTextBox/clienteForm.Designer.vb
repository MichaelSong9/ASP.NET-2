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
        Me.primeiroButton = New System.Windows.Forms.Button
        Me.anteriorButton = New System.Windows.Forms.Button
        Me.proximoButton = New System.Windows.Forms.Button
        Me.ultimoButton = New System.Windows.Forms.Button
        Me.novoButton = New System.Windows.Forms.Button
        Me.editarButton = New System.Windows.Forms.Button
        Me.pesquisarCodigoButton = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código:"
        '
        'codigoLabel
        '
        Me.codigoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.codigoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.codigoLabel.Location = New System.Drawing.Point(127, 13)
        Me.codigoLabel.Name = "codigoLabel"
        Me.codigoLabel.Size = New System.Drawing.Size(103, 29)
        Me.codigoLabel.TabIndex = 1
        Me.codigoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(44, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nome:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Endereço:"
        '
        'nomeTextBox
        '
        Me.nomeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nomeTextBox.Location = New System.Drawing.Point(127, 61)
        Me.nomeTextBox.Name = "nomeTextBox"
        Me.nomeTextBox.ReadOnly = True
        Me.nomeTextBox.Size = New System.Drawing.Size(315, 29)
        Me.nomeTextBox.TabIndex = 4
        '
        'enderecoTextBox
        '
        Me.enderecoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enderecoTextBox.Location = New System.Drawing.Point(127, 116)
        Me.enderecoTextBox.Name = "enderecoTextBox"
        Me.enderecoTextBox.ReadOnly = True
        Me.enderecoTextBox.Size = New System.Drawing.Size(315, 29)
        Me.enderecoTextBox.TabIndex = 5
        '
        'primeiroButton
        '
        Me.primeiroButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.primeiroButton.Location = New System.Drawing.Point(16, 182)
        Me.primeiroButton.Name = "primeiroButton"
        Me.primeiroButton.Size = New System.Drawing.Size(128, 34)
        Me.primeiroButton.TabIndex = 6
        Me.primeiroButton.Text = "Primeiro"
        Me.primeiroButton.UseVisualStyleBackColor = True
        '
        'anteriorButton
        '
        Me.anteriorButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.anteriorButton.Location = New System.Drawing.Point(170, 182)
        Me.anteriorButton.Name = "anteriorButton"
        Me.anteriorButton.Size = New System.Drawing.Size(128, 34)
        Me.anteriorButton.TabIndex = 7
        Me.anteriorButton.Text = "Anterior"
        Me.anteriorButton.UseVisualStyleBackColor = True
        '
        'proximoButton
        '
        Me.proximoButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.proximoButton.Location = New System.Drawing.Point(324, 182)
        Me.proximoButton.Name = "proximoButton"
        Me.proximoButton.Size = New System.Drawing.Size(128, 34)
        Me.proximoButton.TabIndex = 8
        Me.proximoButton.Text = "Próximo"
        Me.proximoButton.UseVisualStyleBackColor = True
        '
        'ultimoButton
        '
        Me.ultimoButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ultimoButton.Location = New System.Drawing.Point(478, 182)
        Me.ultimoButton.Name = "ultimoButton"
        Me.ultimoButton.Size = New System.Drawing.Size(128, 34)
        Me.ultimoButton.TabIndex = 9
        Me.ultimoButton.Text = "Último"
        Me.ultimoButton.UseVisualStyleBackColor = True
        '
        'novoButton
        '
        Me.novoButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.novoButton.Location = New System.Drawing.Point(478, 13)
        Me.novoButton.Name = "novoButton"
        Me.novoButton.Size = New System.Drawing.Size(128, 34)
        Me.novoButton.TabIndex = 10
        Me.novoButton.Text = "Novo"
        Me.novoButton.UseVisualStyleBackColor = True
        '
        'editarButton
        '
        Me.editarButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editarButton.Location = New System.Drawing.Point(478, 56)
        Me.editarButton.Name = "editarButton"
        Me.editarButton.Size = New System.Drawing.Size(128, 34)
        Me.editarButton.TabIndex = 11
        Me.editarButton.Text = "Editar"
        Me.editarButton.UseVisualStyleBackColor = True
        '
        'pesquisarCodigoButton
        '
        Me.pesquisarCodigoButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pesquisarCodigoButton.Location = New System.Drawing.Point(478, 96)
        Me.pesquisarCodigoButton.Name = "pesquisarCodigoButton"
        Me.pesquisarCodigoButton.Size = New System.Drawing.Size(128, 65)
        Me.pesquisarCodigoButton.TabIndex = 12
        Me.pesquisarCodigoButton.Text = "Pesquisar por Código"
        Me.pesquisarCodigoButton.UseVisualStyleBackColor = True
        '
        'clienteForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(623, 234)
        Me.Controls.Add(Me.pesquisarCodigoButton)
        Me.Controls.Add(Me.editarButton)
        Me.Controls.Add(Me.novoButton)
        Me.Controls.Add(Me.ultimoButton)
        Me.Controls.Add(Me.proximoButton)
        Me.Controls.Add(Me.anteriorButton)
        Me.Controls.Add(Me.primeiroButton)
        Me.Controls.Add(Me.enderecoTextBox)
        Me.Controls.Add(Me.nomeTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.codigoLabel)
        Me.Controls.Add(Me.Label1)
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
    Friend WithEvents primeiroButton As System.Windows.Forms.Button
    Friend WithEvents anteriorButton As System.Windows.Forms.Button
    Friend WithEvents proximoButton As System.Windows.Forms.Button
    Friend WithEvents ultimoButton As System.Windows.Forms.Button
    Friend WithEvents novoButton As System.Windows.Forms.Button
    Friend WithEvents editarButton As System.Windows.Forms.Button
    Friend WithEvents pesquisarCodigoButton As System.Windows.Forms.Button

End Class
