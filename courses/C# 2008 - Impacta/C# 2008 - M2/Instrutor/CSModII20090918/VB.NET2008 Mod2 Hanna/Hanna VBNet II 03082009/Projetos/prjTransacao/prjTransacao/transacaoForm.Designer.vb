<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class transacaoForm
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
        Me.transacaoButton = New System.Windows.Forms.Button
        Me.update1TextBox = New System.Windows.Forms.TextBox
        Me.update2TextBox = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'transacaoButton
        '
        Me.transacaoButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.transacaoButton.Location = New System.Drawing.Point(12, 12)
        Me.transacaoButton.Name = "transacaoButton"
        Me.transacaoButton.Size = New System.Drawing.Size(179, 130)
        Me.transacaoButton.TabIndex = 0
        Me.transacaoButton.Text = "Transação"
        Me.transacaoButton.UseVisualStyleBackColor = True
        '
        'update1TextBox
        '
        Me.update1TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.update1TextBox.Location = New System.Drawing.Point(197, 12)
        Me.update1TextBox.Multiline = True
        Me.update1TextBox.Name = "update1TextBox"
        Me.update1TextBox.Size = New System.Drawing.Size(413, 62)
        Me.update1TextBox.TabIndex = 1
        Me.update1TextBox.Text = "Update Cliente Set Endereco = 'Al Barão de Limeira' Where Codigo = 6"
        '
        'update2TextBox
        '
        Me.update2TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.update2TextBox.Location = New System.Drawing.Point(197, 80)
        Me.update2TextBox.Multiline = True
        Me.update2TextBox.Name = "update2TextBox"
        Me.update2TextBox.Size = New System.Drawing.Size(413, 62)
        Me.update2TextBox.TabIndex = 2
        Me.update2TextBox.Text = "Update Cliente Set Endereco = 'Al Barão de Limeira' Where Codigo = 7"
        '
        'transacaoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 158)
        Me.Controls.Add(Me.update2TextBox)
        Me.Controls.Add(Me.update1TextBox)
        Me.Controls.Add(Me.transacaoButton)
        Me.Name = "transacaoForm"
        Me.Text = "TRANSAÇÃO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents transacaoButton As System.Windows.Forms.Button
    Friend WithEvents update1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents update2TextBox As System.Windows.Forms.TextBox

End Class
