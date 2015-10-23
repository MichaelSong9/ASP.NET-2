<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class exemploForm
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
        Me.exemploButton = New System.Windows.Forms.Button
        Me.exemploListBox = New System.Windows.Forms.ListBox
        Me.pesquisarTextBox = New System.Windows.Forms.TextBox
        Me.emailAtualLabel = New System.Windows.Forms.Label
        Me.novoEmailTextBox = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'exemploButton
        '
        Me.exemploButton.Location = New System.Drawing.Point(12, 12)
        Me.exemploButton.Name = "exemploButton"
        Me.exemploButton.Size = New System.Drawing.Size(75, 23)
        Me.exemploButton.TabIndex = 0
        Me.exemploButton.Text = "Exemplo"
        Me.exemploButton.UseVisualStyleBackColor = True
        '
        'exemploListBox
        '
        Me.exemploListBox.FormattingEnabled = True
        Me.exemploListBox.Location = New System.Drawing.Point(12, 134)
        Me.exemploListBox.Name = "exemploListBox"
        Me.exemploListBox.Size = New System.Drawing.Size(230, 95)
        Me.exemploListBox.TabIndex = 1
        '
        'pesquisarTextBox
        '
        Me.pesquisarTextBox.Location = New System.Drawing.Point(93, 14)
        Me.pesquisarTextBox.Name = "pesquisarTextBox"
        Me.pesquisarTextBox.Size = New System.Drawing.Size(149, 20)
        Me.pesquisarTextBox.TabIndex = 2
        Me.pesquisarTextBox.Text = "marilivia"
        Me.pesquisarTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'emailAtualLabel
        '
        Me.emailAtualLabel.Location = New System.Drawing.Point(93, 49)
        Me.emailAtualLabel.Name = "emailAtualLabel"
        Me.emailAtualLabel.Size = New System.Drawing.Size(149, 23)
        Me.emailAtualLabel.TabIndex = 3
        Me.emailAtualLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'novoEmailTextBox
        '
        Me.novoEmailTextBox.Location = New System.Drawing.Point(93, 85)
        Me.novoEmailTextBox.Name = "novoEmailTextBox"
        Me.novoEmailTextBox.Size = New System.Drawing.Size(149, 20)
        Me.novoEmailTextBox.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Email atual:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Novo email:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Registro alterado"
        '
        'exemploForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(254, 247)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.novoEmailTextBox)
        Me.Controls.Add(Me.emailAtualLabel)
        Me.Controls.Add(Me.pesquisarTextBox)
        Me.Controls.Add(Me.exemploListBox)
        Me.Controls.Add(Me.exemploButton)
        Me.Name = "exemploForm"
        Me.Text = "Exemplo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents exemploButton As System.Windows.Forms.Button
    Friend WithEvents exemploListBox As System.Windows.Forms.ListBox
    Friend WithEvents pesquisarTextBox As System.Windows.Forms.TextBox
    Friend WithEvents emailAtualLabel As System.Windows.Forms.Label
    Friend WithEvents novoEmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
