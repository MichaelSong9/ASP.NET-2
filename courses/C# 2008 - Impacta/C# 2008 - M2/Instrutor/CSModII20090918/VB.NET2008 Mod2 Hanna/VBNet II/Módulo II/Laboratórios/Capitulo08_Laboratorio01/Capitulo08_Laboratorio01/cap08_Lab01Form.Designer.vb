<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cap08_Lab01Form
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
        Me.inserirButton = New System.Windows.Forms.Button
        Me.mensagemButton = New System.Windows.Forms.Button
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        Me.SuspendLayout()
        '
        'inserirButton
        '
        Me.inserirButton.Location = New System.Drawing.Point(12, 12)
        Me.inserirButton.Name = "inserirButton"
        Me.inserirButton.Size = New System.Drawing.Size(75, 23)
        Me.inserirButton.TabIndex = 0
        Me.inserirButton.Text = "Inserir"
        Me.inserirButton.UseVisualStyleBackColor = True
        '
        'mensagemButton
        '
        Me.mensagemButton.Location = New System.Drawing.Point(93, 12)
        Me.mensagemButton.Name = "mensagemButton"
        Me.mensagemButton.Size = New System.Drawing.Size(75, 23)
        Me.mensagemButton.TabIndex = 1
        Me.mensagemButton.Text = "Mensagem"
        Me.mensagemButton.UseVisualStyleBackColor = True
        '
        'BackgroundWorker1
        '
        '
        'cap08_Lab01Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(262, 62)
        Me.Controls.Add(Me.mensagemButton)
        Me.Controls.Add(Me.inserirButton)
        Me.Name = "cap08_Lab01Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Capítulo 8 - Laboratório 1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents inserirButton As System.Windows.Forms.Button
    Friend WithEvents mensagemButton As System.Windows.Forms.Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker

End Class
