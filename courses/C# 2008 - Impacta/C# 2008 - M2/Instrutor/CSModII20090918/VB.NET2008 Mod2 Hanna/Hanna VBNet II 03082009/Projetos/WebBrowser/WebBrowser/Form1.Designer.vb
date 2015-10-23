<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class wbForm
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
        Me.wb = New System.Windows.Forms.WebBrowser
        Me.enderecoTextBox = New System.Windows.Forms.TextBox
        Me.irButton = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'wb
        '
        Me.wb.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.wb.Location = New System.Drawing.Point(12, 37)
        Me.wb.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wb.Name = "wb"
        Me.wb.Size = New System.Drawing.Size(362, 269)
        Me.wb.TabIndex = 0
        '
        'enderecoTextBox
        '
        Me.enderecoTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.enderecoTextBox.Location = New System.Drawing.Point(12, 12)
        Me.enderecoTextBox.Name = "enderecoTextBox"
        Me.enderecoTextBox.Size = New System.Drawing.Size(281, 20)
        Me.enderecoTextBox.TabIndex = 1
        Me.enderecoTextBox.Text = "www.google.com"
        '
        'irButton
        '
        Me.irButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.irButton.Location = New System.Drawing.Point(299, 10)
        Me.irButton.Name = "irButton"
        Me.irButton.Size = New System.Drawing.Size(75, 23)
        Me.irButton.TabIndex = 2
        Me.irButton.Text = "Ir"
        Me.irButton.UseVisualStyleBackColor = True
        '
        'wbForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 318)
        Me.Controls.Add(Me.irButton)
        Me.Controls.Add(Me.enderecoTextBox)
        Me.Controls.Add(Me.wb)
        Me.Name = "wbForm"
        Me.Text = "Web Browser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents wb As System.Windows.Forms.WebBrowser
    Friend WithEvents enderecoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents irButton As System.Windows.Forms.Button

End Class
