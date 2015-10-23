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
        Me.TabTextBox1 = New MeusControles.TabTextBox
        Me.TabTextBox2 = New MeusControles.TabTextBox
        Me.TabTextBox3 = New MeusControles.TabTextBox
        Me.SuspendLayout()
        '
        'TabTextBox1
        '
        Me.TabTextBox1.Location = New System.Drawing.Point(10, 17)
        Me.TabTextBox1.Name = "TabTextBox1"
        Me.TabTextBox1.Size = New System.Drawing.Size(150, 22)
        Me.TabTextBox1.TabIndex = 0
        '
        'TabTextBox2
        '
        Me.TabTextBox2.Location = New System.Drawing.Point(10, 45)
        Me.TabTextBox2.Name = "TabTextBox2"
        Me.TabTextBox2.Size = New System.Drawing.Size(150, 22)
        Me.TabTextBox2.TabIndex = 1
        '
        'TabTextBox3
        '
        Me.TabTextBox3.Location = New System.Drawing.Point(10, 73)
        Me.TabTextBox3.Name = "TabTextBox3"
        Me.TabTextBox3.Size = New System.Drawing.Size(150, 22)
        Me.TabTextBox3.TabIndex = 2
        '
        'exemploForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(170, 109)
        Me.Controls.Add(Me.TabTextBox3)
        Me.Controls.Add(Me.TabTextBox2)
        Me.Controls.Add(Me.TabTextBox1)
        Me.Name = "exemploForm"
        Me.Text = "Exemplo"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabTextBox1 As MeusControles.TabTextBox
    Friend WithEvents TabTextBox2 As MeusControles.TabTextBox
    Friend WithEvents TabTextBox3 As MeusControles.TabTextBox

End Class
