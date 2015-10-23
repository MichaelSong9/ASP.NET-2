<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ArrayListForm
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
        Me.arrayListButton = New System.Windows.Forms.Button
        Me.arrayListBox = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'arrayListButton
        '
        Me.arrayListButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.arrayListButton.Location = New System.Drawing.Point(12, 12)
        Me.arrayListButton.Name = "arrayListButton"
        Me.arrayListButton.Size = New System.Drawing.Size(91, 33)
        Me.arrayListButton.TabIndex = 0
        Me.arrayListButton.Text = "ArrayList"
        Me.arrayListButton.UseVisualStyleBackColor = True
        '
        'arrayListBox
        '
        Me.arrayListBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.arrayListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.arrayListBox.FormattingEnabled = True
        Me.arrayListBox.ItemHeight = 24
        Me.arrayListBox.Location = New System.Drawing.Point(109, 12)
        Me.arrayListBox.Name = "arrayListBox"
        Me.arrayListBox.Size = New System.Drawing.Size(290, 364)
        Me.arrayListBox.TabIndex = 1
        '
        'ArrayListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 414)
        Me.Controls.Add(Me.arrayListBox)
        Me.Controls.Add(Me.arrayListButton)
        Me.MinimumSize = New System.Drawing.Size(303, 252)
        Me.Name = "ArrayListForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ArrayList"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents arrayListButton As System.Windows.Forms.Button
    Friend WithEvents arrayListBox As System.Windows.Forms.ListBox

End Class
