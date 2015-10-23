<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cpfForm
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
        Me.CaixaDeTexto1 = New CaixaDeTexto.CaixaDeTexto
        Me.validarButton = New System.Windows.Forms.Button
        Me.resultadoLabel = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'CaixaDeTexto1
        '
        Me.CaixaDeTexto1.Location = New System.Drawing.Point(12, 12)
        Me.CaixaDeTexto1.Name = "CaixaDeTexto1"
        Me.CaixaDeTexto1.Size = New System.Drawing.Size(429, 46)
        Me.CaixaDeTexto1.TabIndex = 0
        Me.CaixaDeTexto1.Texto = ""
        '
        'validarButton
        '
        Me.validarButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.validarButton.Location = New System.Drawing.Point(12, 78)
        Me.validarButton.Name = "validarButton"
        Me.validarButton.Size = New System.Drawing.Size(428, 50)
        Me.validarButton.TabIndex = 1
        Me.validarButton.Text = "Validar"
        Me.validarButton.UseVisualStyleBackColor = True
        '
        'resultadoLabel
        '
        Me.resultadoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.resultadoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resultadoLabel.Location = New System.Drawing.Point(11, 146)
        Me.resultadoLabel.Name = "resultadoLabel"
        Me.resultadoLabel.Size = New System.Drawing.Size(429, 66)
        Me.resultadoLabel.TabIndex = 2
        Me.resultadoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cpfForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 221)
        Me.Controls.Add(Me.resultadoLabel)
        Me.Controls.Add(Me.validarButton)
        Me.Controls.Add(Me.CaixaDeTexto1)
        Me.Name = "cpfForm"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CaixaDeTexto1 As CaixaDeTexto.CaixaDeTexto
    Friend WithEvents validarButton As System.Windows.Forms.Button
    Friend WithEvents resultadoLabel As System.Windows.Forms.Label

End Class
