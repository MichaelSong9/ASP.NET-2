<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cap05_lab01Form
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
        Me.dgv = New System.Windows.Forms.DataGridView
        Me.pesquisarTextBox = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.primeiroButton = New System.Windows.Forms.Button
        Me.anteriorButton = New System.Windows.Forms.Button
        Me.proximoButton = New System.Windows.Forms.Button
        Me.ultimoButton = New System.Windows.Forms.Button
        Me.editarGravarButton = New System.Windows.Forms.Button
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.dgv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(12, 41)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(705, 333)
        Me.dgv.TabIndex = 7
        '
        'pesquisarTextBox
        '
        Me.pesquisarTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.pesquisarTextBox.Location = New System.Drawing.Point(139, 14)
        Me.pesquisarTextBox.Name = "pesquisarTextBox"
        Me.pesquisarTextBox.Size = New System.Drawing.Size(108, 20)
        Me.pesquisarTextBox.TabIndex = 1
        Me.pesquisarTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pesquisar por Placa:"
        '
        'primeiroButton
        '
        Me.primeiroButton.Location = New System.Drawing.Point(253, 11)
        Me.primeiroButton.Name = "primeiroButton"
        Me.primeiroButton.Size = New System.Drawing.Size(75, 23)
        Me.primeiroButton.TabIndex = 2
        Me.primeiroButton.Text = "&Primeiro"
        Me.primeiroButton.UseVisualStyleBackColor = True
        '
        'anteriorButton
        '
        Me.anteriorButton.Location = New System.Drawing.Point(334, 11)
        Me.anteriorButton.Name = "anteriorButton"
        Me.anteriorButton.Size = New System.Drawing.Size(75, 23)
        Me.anteriorButton.TabIndex = 3
        Me.anteriorButton.Text = "&Anterior"
        Me.anteriorButton.UseVisualStyleBackColor = True
        '
        'proximoButton
        '
        Me.proximoButton.Location = New System.Drawing.Point(415, 11)
        Me.proximoButton.Name = "proximoButton"
        Me.proximoButton.Size = New System.Drawing.Size(75, 23)
        Me.proximoButton.TabIndex = 4
        Me.proximoButton.Text = "Pró&ximo"
        Me.proximoButton.UseVisualStyleBackColor = True
        '
        'ultimoButton
        '
        Me.ultimoButton.Location = New System.Drawing.Point(496, 11)
        Me.ultimoButton.Name = "ultimoButton"
        Me.ultimoButton.Size = New System.Drawing.Size(75, 23)
        Me.ultimoButton.TabIndex = 5
        Me.ultimoButton.Text = "Últi&mo"
        Me.ultimoButton.UseVisualStyleBackColor = True
        '
        'editarGravarButton
        '
        Me.editarGravarButton.Location = New System.Drawing.Point(577, 11)
        Me.editarGravarButton.Name = "editarGravarButton"
        Me.editarGravarButton.Size = New System.Drawing.Size(140, 23)
        Me.editarGravarButton.TabIndex = 6
        Me.editarGravarButton.Text = "&Editar"
        Me.editarGravarButton.UseVisualStyleBackColor = True
        '
        'cap05_lab01Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 385)
        Me.Controls.Add(Me.editarGravarButton)
        Me.Controls.Add(Me.ultimoButton)
        Me.Controls.Add(Me.proximoButton)
        Me.Controls.Add(Me.anteriorButton)
        Me.Controls.Add(Me.primeiroButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pesquisarTextBox)
        Me.Controls.Add(Me.dgv)
        Me.Name = "cap05_lab01Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Capítulo 5 - Laboratório 1"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents pesquisarTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents primeiroButton As System.Windows.Forms.Button
    Friend WithEvents anteriorButton As System.Windows.Forms.Button
    Friend WithEvents proximoButton As System.Windows.Forms.Button
    Friend WithEvents ultimoButton As System.Windows.Forms.Button
    Friend WithEvents editarGravarButton As System.Windows.Forms.Button

End Class
