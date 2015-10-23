<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class exemploForm
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
        Me.exemploButton = New System.Windows.Forms.Button
        Me.exemploListBox = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'exemploButton
        '
        Me.exemploButton.Location = New System.Drawing.Point(12, 12)
        Me.exemploButton.Name = "exemploButton"
        Me.exemploButton.Size = New System.Drawing.Size(75, 23)
        Me.exemploButton.TabIndex = 0
        Me.exemploButton.Text = "Exemplo"
        Me.exemploButton.UseVisualStyleBackColor = True
        '
        'exemploListBox
        '
        Me.exemploListBox.FormattingEnabled = True
        Me.exemploListBox.Location = New System.Drawing.Point(12, 41)
        Me.exemploListBox.Name = "exemploListBox"
        Me.exemploListBox.Size = New System.Drawing.Size(175, 186)
        Me.exemploListBox.TabIndex = 1
        '
        'exemploForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(199, 240)
        Me.Controls.Add(Me.exemploListBox)
        Me.Controls.Add(Me.exemploButton)
        Me.Name = "exemploForm"
        Me.Text = "Exemplo"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents exemploButton As System.Windows.Forms.Button
    Friend WithEvents exemploListBox As System.Windows.Forms.ListBox

End Class
