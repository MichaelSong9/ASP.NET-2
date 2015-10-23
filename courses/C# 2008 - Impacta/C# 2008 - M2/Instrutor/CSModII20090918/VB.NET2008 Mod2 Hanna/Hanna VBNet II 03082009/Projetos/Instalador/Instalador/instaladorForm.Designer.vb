<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class instaladorForm
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
        Me.instaladorButton = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'instaladorButton
        '
        Me.instaladorButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.instaladorButton.Location = New System.Drawing.Point(12, 12)
        Me.instaladorButton.Name = "instaladorButton"
        Me.instaladorButton.Size = New System.Drawing.Size(436, 68)
        Me.instaladorButton.TabIndex = 0
        Me.instaladorButton.Text = "Instalador"
        Me.instaladorButton.UseVisualStyleBackColor = True
        '
        'instaladorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 94)
        Me.Controls.Add(Me.instaladorButton)
        Me.Name = "instaladorForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Instalador"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents instaladorButton As System.Windows.Forms.Button

End Class
