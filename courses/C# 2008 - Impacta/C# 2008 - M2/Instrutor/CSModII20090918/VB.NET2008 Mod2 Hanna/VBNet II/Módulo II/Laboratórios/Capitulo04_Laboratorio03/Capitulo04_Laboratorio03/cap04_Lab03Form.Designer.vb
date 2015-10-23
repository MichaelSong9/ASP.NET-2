<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cap04_Lab03Form
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.gravarButton = New System.Windows.Forms.Button
        Me.dgv = New System.Windows.Forms.DataGridView
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gravarButton
        '
        Me.gravarButton.Location = New System.Drawing.Point(12, 12)
        Me.gravarButton.Name = "gravarButton"
        Me.gravarButton.Size = New System.Drawing.Size(75, 23)
        Me.gravarButton.TabIndex = 0
        Me.gravarButton.Text = "Gravar"
        Me.gravarButton.UseVisualStyleBackColor = True
        '
        'dgv
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(12, 41)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(502, 295)
        Me.dgv.TabIndex = 1
        '
        'cap04_Lab03Form
        '
        Me.AcceptButton = Me.gravarButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 348)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.gravarButton)
        Me.Name = "cap04_Lab03Form"
        Me.Text = "Capítulo 4 - Laboratório 3"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gravarButton As System.Windows.Forms.Button
    Friend WithEvents dgv As System.Windows.Forms.DataGridView

End Class
