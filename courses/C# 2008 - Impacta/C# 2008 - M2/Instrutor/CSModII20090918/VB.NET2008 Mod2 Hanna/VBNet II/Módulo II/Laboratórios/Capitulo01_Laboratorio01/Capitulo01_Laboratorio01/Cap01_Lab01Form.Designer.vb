<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cap01_Lab01Form
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
        Me.calculadoraButton = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'calculadoraButton
        '
        Me.calculadoraButton.Location = New System.Drawing.Point(12, 12)
        Me.calculadoraButton.Name = "calculadoraButton"
        Me.calculadoraButton.Size = New System.Drawing.Size(251, 48)
        Me.calculadoraButton.TabIndex = 0
        Me.calculadoraButton.Text = "Calculadora"
        Me.calculadoraButton.UseVisualStyleBackColor = True
        '
        'Cap01_Lab01Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(275, 72)
        Me.Controls.Add(Me.calculadoraButton)
        Me.Name = "Cap01_Lab01Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Capítulo 01 – Laboratório 01"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents calculadoraButton As System.Windows.Forms.Button

End Class
