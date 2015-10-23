<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dataSetForm
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
        Me.clienteListBox = New System.Windows.Forms.ListBox
        Me.paisComboBox = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'clienteListBox
        '
        Me.clienteListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clienteListBox.FormattingEnabled = True
        Me.clienteListBox.ItemHeight = 24
        Me.clienteListBox.Location = New System.Drawing.Point(13, 12)
        Me.clienteListBox.Name = "clienteListBox"
        Me.clienteListBox.Size = New System.Drawing.Size(203, 268)
        Me.clienteListBox.TabIndex = 0
        '
        'paisComboBox
        '
        Me.paisComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paisComboBox.FormattingEnabled = True
        Me.paisComboBox.Location = New System.Drawing.Point(12, 289)
        Me.paisComboBox.Name = "paisComboBox"
        Me.paisComboBox.Size = New System.Drawing.Size(204, 32)
        Me.paisComboBox.TabIndex = 1
        '
        'dataSetForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(230, 335)
        Me.Controls.Add(Me.paisComboBox)
        Me.Controls.Add(Me.clienteListBox)
        Me.Name = "dataSetForm"
        Me.Text = "DataSet"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents clienteListBox As System.Windows.Forms.ListBox
    Friend WithEvents paisComboBox As System.Windows.Forms.ComboBox

End Class
