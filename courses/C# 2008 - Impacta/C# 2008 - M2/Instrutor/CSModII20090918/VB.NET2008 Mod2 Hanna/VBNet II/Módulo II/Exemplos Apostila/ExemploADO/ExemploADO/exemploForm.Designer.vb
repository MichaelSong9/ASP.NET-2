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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.nomeTextBox = New System.Windows.Forms.TextBox
        Me.emailTextBox = New System.Windows.Forms.TextBox
        Me.pesquisaTextBox = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nome:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Email:"
        '
        'nomeTextBox
        '
        Me.nomeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nomeTextBox.Location = New System.Drawing.Point(70, 61)
        Me.nomeTextBox.Name = "nomeTextBox"
        Me.nomeTextBox.Size = New System.Drawing.Size(245, 23)
        Me.nomeTextBox.TabIndex = 3
        '
        'emailTextBox
        '
        Me.emailTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailTextBox.Location = New System.Drawing.Point(70, 100)
        Me.emailTextBox.Name = "emailTextBox"
        Me.emailTextBox.Size = New System.Drawing.Size(245, 23)
        Me.emailTextBox.TabIndex = 4
        '
        'pesquisaTextBox
        '
        Me.pesquisaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pesquisaTextBox.Location = New System.Drawing.Point(178, 15)
        Me.pesquisaTextBox.Name = "pesquisaTextBox"
        Me.pesquisaTextBox.Size = New System.Drawing.Size(137, 23)
        Me.pesquisaTextBox.TabIndex = 5
        Me.pesquisaTextBox.Text = "joca"
        Me.pesquisaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(93, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Pesquisa:"
        '
        'exemploForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 137)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pesquisaTextBox)
        Me.Controls.Add(Me.emailTextBox)
        Me.Controls.Add(Me.nomeTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.exemploButton)
        Me.Name = "exemploForm"
        Me.Text = "Exemplo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents exemploButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nomeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents emailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents pesquisaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
