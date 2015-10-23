<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cap04_Lab01Form
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
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.placaTextBox = New System.Windows.Forms.TextBox
        Me.modeloTextBox = New System.Windows.Forms.TextBox
        Me.corTextBox = New System.Windows.Forms.TextBox
        Me.anoTextBox = New System.Windows.Forms.TextBox
        Me.inserirButton = New System.Windows.Forms.Button
        Me.procurarButton = New System.Windows.Forms.Button
        Me.alterarButton = New System.Windows.Forms.Button
        Me.excluirButton = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&PLaca:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "&Modelo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "&Cor:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "&Ano:"
        '
        'placaTextBox
        '
        Me.placaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.placaTextBox.Location = New System.Drawing.Point(81, 12)
        Me.placaTextBox.Name = "placaTextBox"
        Me.placaTextBox.Size = New System.Drawing.Size(73, 22)
        Me.placaTextBox.TabIndex = 4
        '
        'modeloTextBox
        '
        Me.modeloTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modeloTextBox.Location = New System.Drawing.Point(81, 38)
        Me.modeloTextBox.Name = "modeloTextBox"
        Me.modeloTextBox.Size = New System.Drawing.Size(249, 22)
        Me.modeloTextBox.TabIndex = 5
        '
        'corTextBox
        '
        Me.corTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.corTextBox.Location = New System.Drawing.Point(81, 64)
        Me.corTextBox.Name = "corTextBox"
        Me.corTextBox.Size = New System.Drawing.Size(249, 22)
        Me.corTextBox.TabIndex = 6
        '
        'anoTextBox
        '
        Me.anoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.anoTextBox.Location = New System.Drawing.Point(81, 88)
        Me.anoTextBox.Name = "anoTextBox"
        Me.anoTextBox.Size = New System.Drawing.Size(73, 22)
        Me.anoTextBox.TabIndex = 7
        '
        'inserirButton
        '
        Me.inserirButton.Location = New System.Drawing.Point(93, 137)
        Me.inserirButton.Name = "inserirButton"
        Me.inserirButton.Size = New System.Drawing.Size(75, 23)
        Me.inserirButton.TabIndex = 8
        Me.inserirButton.Text = "&Inserir"
        Me.inserirButton.UseVisualStyleBackColor = True
        '
        'procurarButton
        '
        Me.procurarButton.Location = New System.Drawing.Point(12, 137)
        Me.procurarButton.Name = "procurarButton"
        Me.procurarButton.Size = New System.Drawing.Size(75, 23)
        Me.procurarButton.TabIndex = 9
        Me.procurarButton.Text = "&Procurar"
        Me.procurarButton.UseVisualStyleBackColor = True
        '
        'alterarButton
        '
        Me.alterarButton.Location = New System.Drawing.Point(174, 137)
        Me.alterarButton.Name = "alterarButton"
        Me.alterarButton.Size = New System.Drawing.Size(75, 23)
        Me.alterarButton.TabIndex = 10
        Me.alterarButton.Text = "Alte&rar"
        Me.alterarButton.UseVisualStyleBackColor = True
        '
        'excluirButton
        '
        Me.excluirButton.Location = New System.Drawing.Point(255, 137)
        Me.excluirButton.Name = "excluirButton"
        Me.excluirButton.Size = New System.Drawing.Size(75, 23)
        Me.excluirButton.TabIndex = 11
        Me.excluirButton.Text = "&Excluir"
        Me.excluirButton.UseVisualStyleBackColor = True
        '
        'cap04_Lab01Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 176)
        Me.Controls.Add(Me.excluirButton)
        Me.Controls.Add(Me.alterarButton)
        Me.Controls.Add(Me.procurarButton)
        Me.Controls.Add(Me.inserirButton)
        Me.Controls.Add(Me.anoTextBox)
        Me.Controls.Add(Me.corTextBox)
        Me.Controls.Add(Me.modeloTextBox)
        Me.Controls.Add(Me.placaTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "cap04_Lab01Form"
        Me.Text = "Capítulo 4 - Laboratório 2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents placaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents modeloTextBox As System.Windows.Forms.TextBox
    Friend WithEvents corTextBox As System.Windows.Forms.TextBox
    Friend WithEvents anoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents inserirButton As System.Windows.Forms.Button
    Friend WithEvents procurarButton As System.Windows.Forms.Button
    Friend WithEvents alterarButton As System.Windows.Forms.Button
    Friend WithEvents excluirButton As System.Windows.Forms.Button

End Class
