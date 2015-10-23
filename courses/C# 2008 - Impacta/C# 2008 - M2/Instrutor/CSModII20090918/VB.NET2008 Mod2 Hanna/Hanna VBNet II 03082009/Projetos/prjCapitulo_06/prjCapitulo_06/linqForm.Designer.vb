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
        Me.fbd = New System.Windows.Forms.FolderBrowserDialog
        Me.dgv = New System.Windows.Forms.DataGridView
        Me.gravarXMLButton = New System.Windows.Forms.Button
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'linqButton
        '
        Me.linqButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linqButton.Location = New System.Drawing.Point(12, 12)
        Me.linqButton.Name = "linqButton"
        Me.linqButton.Size = New System.Drawing.Size(209, 48)
        Me.linqButton.TabIndex = 0
        Me.linqButton.Text = "Músicas"
        Me.linqButton.UseVisualStyleBackColor = True
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(12, 66)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(491, 231)
        Me.dgv.TabIndex = 1
        '
        'gravarXMLButton
        '
        Me.gravarXMLButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gravarXMLButton.Location = New System.Drawing.Point(294, 12)
        Me.gravarXMLButton.Name = "gravarXMLButton"
        Me.gravarXMLButton.Size = New System.Drawing.Size(209, 48)
        Me.gravarXMLButton.TabIndex = 2
        Me.gravarXMLButton.Text = "Gravar XML"
        Me.gravarXMLButton.UseVisualStyleBackColor = True
        '
        'linqForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 309)
        Me.Controls.Add(Me.gravarXMLButton)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.linqButton)
        Me.Name = "linqForm"
        Me.Text = "LINQ"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents linqButton As System.Windows.Forms.Button
    Friend WithEvents fbd As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents gravarXMLButton As System.Windows.Forms.Button

End Class
