<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class linqForm
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
        Me.linqButton = New System.Windows.Forms.Button
        Me.linqListBox = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'linqButton
        '
        Me.linqButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linqButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linqButton.Location = New System.Drawing.Point(12, 12)
        Me.linqButton.Name = "linqButton"
        Me.linqButton.Size = New System.Drawing.Size(306, 35)
        Me.linqButton.TabIndex = 0
        Me.linqButton.Text = "LINQ"
        Me.linqButton.UseVisualStyleBackColor = True
        '
        'linqListBox
        '
        Me.linqListBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linqListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linqListBox.FormattingEnabled = True
        Me.linqListBox.ItemHeight = 24
        Me.linqListBox.Location = New System.Drawing.Point(12, 53)
        Me.linqListBox.Name = "linqListBox"
        Me.linqListBox.Size = New System.Drawing.Size(306, 388)
        Me.linqListBox.TabIndex = 1
        '
        'linqForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 455)
        Me.Controls.Add(Me.linqListBox)
        Me.Controls.Add(Me.linqButton)
        Me.Name = "linqForm"
        Me.Text = "LINQ to SQL"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents linqButton As System.Windows.Forms.Button
    Friend WithEvents linqListBox As System.Windows.Forms.ListBox

End Class
