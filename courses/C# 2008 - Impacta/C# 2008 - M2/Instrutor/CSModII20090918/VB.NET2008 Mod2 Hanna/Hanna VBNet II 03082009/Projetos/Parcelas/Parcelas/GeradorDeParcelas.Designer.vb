<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GeradorDeParcelas
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
        Me.valorTextBox = New System.Windows.Forms.TextBox
        Me.aumentaButton = New System.Windows.Forms.Button
        Me.diminuiButton = New System.Windows.Forms.Button
        Me.nParcelasLabel = New System.Windows.Forms.Label
        Me.valorParcelaLabel = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'valorTextBox
        '
        Me.valorTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.valorTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valorTextBox.Location = New System.Drawing.Point(3, 0)
        Me.valorTextBox.Multiline = True
        Me.valorTextBox.Name = "valorTextBox"
        Me.valorTextBox.Size = New System.Drawing.Size(276, 52)
        Me.valorTextBox.TabIndex = 0
        Me.valorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'aumentaButton
        '
        Me.aumentaButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.aumentaButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aumentaButton.Location = New System.Drawing.Point(282, 0)
        Me.aumentaButton.Name = "aumentaButton"
        Me.aumentaButton.Size = New System.Drawing.Size(75, 23)
        Me.aumentaButton.TabIndex = 1
        Me.aumentaButton.Text = "+"
        Me.aumentaButton.UseVisualStyleBackColor = True
        '
        'diminuiButton
        '
        Me.diminuiButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.diminuiButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.diminuiButton.Location = New System.Drawing.Point(282, 29)
        Me.diminuiButton.Name = "diminuiButton"
        Me.diminuiButton.Size = New System.Drawing.Size(75, 23)
        Me.diminuiButton.TabIndex = 2
        Me.diminuiButton.Text = "-"
        Me.diminuiButton.UseVisualStyleBackColor = True
        '
        'nParcelasLabel
        '
        Me.nParcelasLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nParcelasLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nParcelasLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nParcelasLabel.Location = New System.Drawing.Point(363, 0)
        Me.nParcelasLabel.Name = "nParcelasLabel"
        Me.nParcelasLabel.Size = New System.Drawing.Size(100, 52)
        Me.nParcelasLabel.TabIndex = 3
        Me.nParcelasLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'valorParcelaLabel
        '
        Me.valorParcelaLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.valorParcelaLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.valorParcelaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valorParcelaLabel.Location = New System.Drawing.Point(3, 63)
        Me.valorParcelaLabel.Name = "valorParcelaLabel"
        Me.valorParcelaLabel.Size = New System.Drawing.Size(460, 47)
        Me.valorParcelaLabel.TabIndex = 4
        Me.valorParcelaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GeradorDeParcelas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.valorParcelaLabel)
        Me.Controls.Add(Me.nParcelasLabel)
        Me.Controls.Add(Me.diminuiButton)
        Me.Controls.Add(Me.aumentaButton)
        Me.Controls.Add(Me.valorTextBox)
        Me.Name = "GeradorDeParcelas"
        Me.Size = New System.Drawing.Size(466, 113)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents valorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents aumentaButton As System.Windows.Forms.Button
    Friend WithEvents diminuiButton As System.Windows.Forms.Button
    Friend WithEvents nParcelasLabel As System.Windows.Forms.Label
    Friend WithEvents valorParcelaLabel As System.Windows.Forms.Label

End Class
