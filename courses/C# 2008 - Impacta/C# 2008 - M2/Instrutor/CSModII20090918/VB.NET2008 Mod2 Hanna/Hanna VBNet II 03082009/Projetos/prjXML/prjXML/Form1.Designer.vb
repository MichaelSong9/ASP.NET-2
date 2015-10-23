<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lerXmlButton = New System.Windows.Forms.Button
        Me.gravarXmlButton = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lerXmlButton
        '
        Me.lerXmlButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lerXmlButton.Location = New System.Drawing.Point(12, 12)
        Me.lerXmlButton.Name = "lerXmlButton"
        Me.lerXmlButton.Size = New System.Drawing.Size(161, 43)
        Me.lerXmlButton.TabIndex = 0
        Me.lerXmlButton.Text = "Ler XML"
        Me.lerXmlButton.UseVisualStyleBackColor = True
        '
        'gravarXmlButton
        '
        Me.gravarXmlButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gravarXmlButton.Location = New System.Drawing.Point(12, 72)
        Me.gravarXmlButton.Name = "gravarXmlButton"
        Me.gravarXmlButton.Size = New System.Drawing.Size(161, 43)
        Me.gravarXmlButton.TabIndex = 1
        Me.gravarXmlButton.Text = "Gravar XML"
        Me.gravarXmlButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(186, 134)
        Me.Controls.Add(Me.gravarXmlButton)
        Me.Controls.Add(Me.lerXmlButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lerXmlButton As System.Windows.Forms.Button
    Friend WithEvents gravarXmlButton As System.Windows.Forms.Button

End Class
