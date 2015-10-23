<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class capturaTelaForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.imagemPictureBox = New System.Windows.Forms.PictureBox
        Me.limparButton = New System.Windows.Forms.Button
        Me.salvarButton = New System.Windows.Forms.Button
        Me.fecharButton = New System.Windows.Forms.Button
        Me.sfd = New System.Windows.Forms.SaveFileDialog
        CType(Me.imagemPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imagemPictureBox
        '
        Me.imagemPictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.imagemPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imagemPictureBox.Location = New System.Drawing.Point(12, 12)
        Me.imagemPictureBox.Name = "imagemPictureBox"
        Me.imagemPictureBox.Size = New System.Drawing.Size(216, 163)
        Me.imagemPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imagemPictureBox.TabIndex = 0
        Me.imagemPictureBox.TabStop = False
        '
        'limparButton
        '
        Me.limparButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.limparButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.limparButton.Location = New System.Drawing.Point(251, 12)
        Me.limparButton.Name = "limparButton"
        Me.limparButton.Size = New System.Drawing.Size(132, 28)
        Me.limparButton.TabIndex = 0
        Me.limparButton.Text = "&Limpar Clipboard"
        Me.limparButton.UseVisualStyleBackColor = True
        '
        'salvarButton
        '
        Me.salvarButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.salvarButton.Enabled = False
        Me.salvarButton.Location = New System.Drawing.Point(251, 55)
        Me.salvarButton.Name = "salvarButton"
        Me.salvarButton.Size = New System.Drawing.Size(132, 28)
        Me.salvarButton.TabIndex = 1
        Me.salvarButton.Text = "&Salvar"
        Me.salvarButton.UseVisualStyleBackColor = True
        '
        'fecharButton
        '
        Me.fecharButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fecharButton.Location = New System.Drawing.Point(251, 147)
        Me.fecharButton.Name = "fecharButton"
        Me.fecharButton.Size = New System.Drawing.Size(132, 28)
        Me.fecharButton.TabIndex = 2
        Me.fecharButton.Text = "&Fechar"
        Me.fecharButton.UseVisualStyleBackColor = True
        '
        'capturaTelaForm
        '
        Me.AcceptButton = Me.salvarButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.limparButton
        Me.ClientSize = New System.Drawing.Size(395, 187)
        Me.ControlBox = False
        Me.Controls.Add(Me.fecharButton)
        Me.Controls.Add(Me.salvarButton)
        Me.Controls.Add(Me.limparButton)
        Me.Controls.Add(Me.imagemPictureBox)
        Me.Name = "capturaTelaForm"
        Me.Text = "Seleção de imagem"
        Me.TopMost = True
        CType(Me.imagemPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents imagemPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents limparButton As System.Windows.Forms.Button
    Friend WithEvents salvarButton As System.Windows.Forms.Button
    Friend WithEvents fecharButton As System.Windows.Forms.Button
    Friend WithEvents sfd As System.Windows.Forms.SaveFileDialog
End Class
