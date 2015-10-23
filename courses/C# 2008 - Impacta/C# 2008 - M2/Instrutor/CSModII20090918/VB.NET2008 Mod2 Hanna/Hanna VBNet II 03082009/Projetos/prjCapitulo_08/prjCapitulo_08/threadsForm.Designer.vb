<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class threadsForm
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
        Me.threadsButton = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'threadsButton
        '
        Me.threadsButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.threadsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.threadsButton.Location = New System.Drawing.Point(12, 12)
        Me.threadsButton.Name = "threadsButton"
        Me.threadsButton.Size = New System.Drawing.Size(292, 73)
        Me.threadsButton.TabIndex = 0
        Me.threadsButton.Text = "Threads"
        Me.threadsButton.UseVisualStyleBackColor = True
        '
        'threadsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(316, 98)
        Me.Controls.Add(Me.threadsButton)
        Me.Name = "threadsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "THREADS"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents threadsButton As System.Windows.Forms.Button

End Class
