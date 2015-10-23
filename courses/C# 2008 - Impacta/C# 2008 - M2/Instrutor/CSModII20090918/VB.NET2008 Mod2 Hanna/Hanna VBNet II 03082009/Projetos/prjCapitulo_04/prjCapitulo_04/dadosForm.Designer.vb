<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dadosForm
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
        Me.conexaoButton = New System.Windows.Forms.Button
        Me.nomeTextBox = New System.Windows.Forms.TextBox
        Me.idadeTextBox = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.inserirButton = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'conexaoButton
        '
        Me.conexaoButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.conexaoButton.Location = New System.Drawing.Point(12, 96)
        Me.conexaoButton.Name = "conexaoButton"
        Me.conexaoButton.Size = New System.Drawing.Size(179, 47)
        Me.conexaoButton.TabIndex = 0
        Me.conexaoButton.Text = "Conexão"
        Me.conexaoButton.UseVisualStyleBackColor = True
        '
        'nomeTextBox
        '
        Me.nomeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nomeTextBox.Location = New System.Drawing.Point(117, 12)
        Me.nomeTextBox.Name = "nomeTextBox"
        Me.nomeTextBox.Size = New System.Drawing.Size(386, 32)
        Me.nomeTextBox.TabIndex = 1
        '
        'idadeTextBox
        '
        Me.idadeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idadeTextBox.Location = New System.Drawing.Point(117, 47)
        Me.idadeTextBox.Name = "idadeTextBox"
        Me.idadeTextBox.Size = New System.Drawing.Size(134, 32)
        Me.idadeTextBox.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 26)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nome:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 26)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Idade:"
        '
        'inserirButton
        '
        Me.inserirButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inserirButton.Location = New System.Drawing.Point(197, 96)
        Me.inserirButton.Name = "inserirButton"
        Me.inserirButton.Size = New System.Drawing.Size(179, 47)
        Me.inserirButton.TabIndex = 5
        Me.inserirButton.Text = "Inserir"
        Me.inserirButton.UseVisualStyleBackColor = True
        '
        'dadosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 155)
        Me.Controls.Add(Me.inserirButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.idadeTextBox)
        Me.Controls.Add(Me.nomeTextBox)
        Me.Controls.Add(Me.conexaoButton)
        Me.Name = "dadosForm"
        Me.Text = "Acesso a Dados"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents conexaoButton As System.Windows.Forms.Button
    Friend WithEvents nomeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents idadeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents inserirButton As System.Windows.Forms.Button

End Class
