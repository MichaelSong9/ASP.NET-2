<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xBotao
    Inherits System.Windows.Forms.UserControl

    'UserControl1 overrides dispose to clean up the component list.
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
        Me.botaoButton = New System.Windows.Forms.Button
        Me.outroBotaoButton = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'botaoButton
        '
        Me.botaoButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.botaoButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botaoButton.Location = New System.Drawing.Point(0, 3)
        Me.botaoButton.Name = "botaoButton"
        Me.botaoButton.Size = New System.Drawing.Size(155, 57)
        Me.botaoButton.TabIndex = 0
        Me.botaoButton.Text = "Botão"
        Me.botaoButton.UseVisualStyleBackColor = True
        '
        'outroBotaoButton
        '
        Me.outroBotaoButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.outroBotaoButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outroBotaoButton.Location = New System.Drawing.Point(0, 60)
        Me.outroBotaoButton.Name = "outroBotaoButton"
        Me.outroBotaoButton.Size = New System.Drawing.Size(155, 57)
        Me.outroBotaoButton.TabIndex = 1
        Me.outroBotaoButton.Text = "Outro Botão"
        Me.outroBotaoButton.UseVisualStyleBackColor = True
        '
        'xBotao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.outroBotaoButton)
        Me.Controls.Add(Me.botaoButton)
        Me.MinimumSize = New System.Drawing.Size(158, 119)
        Me.Name = "xBotao"
        Me.Size = New System.Drawing.Size(158, 119)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents botaoButton As System.Windows.Forms.Button
    Friend WithEvents outroBotaoButton As System.Windows.Forms.Button

End Class
