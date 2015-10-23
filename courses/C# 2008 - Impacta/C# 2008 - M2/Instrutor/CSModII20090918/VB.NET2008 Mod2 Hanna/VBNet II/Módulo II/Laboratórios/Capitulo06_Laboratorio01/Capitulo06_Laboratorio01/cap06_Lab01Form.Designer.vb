<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cap06_Lab01Form
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.clienteComboBox = New System.Windows.Forms.ComboBox
        Me.nPedidosLabel = New System.Windows.Forms.Label
        Me.dgv = New System.Windows.Forms.DataGridView
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'clienteComboBox
        '
        Me.clienteComboBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.clienteComboBox.FormattingEnabled = True
        Me.clienteComboBox.Location = New System.Drawing.Point(12, 12)
        Me.clienteComboBox.Name = "clienteComboBox"
        Me.clienteComboBox.Size = New System.Drawing.Size(365, 21)
        Me.clienteComboBox.TabIndex = 0
        '
        'nPedidosLabel
        '
        Me.nPedidosLabel.AutoSize = True
        Me.nPedidosLabel.Location = New System.Drawing.Point(397, 15)
        Me.nPedidosLabel.Name = "nPedidosLabel"
        Me.nPedidosLabel.Size = New System.Drawing.Size(81, 13)
        Me.nPedidosLabel.TabIndex = 1
        Me.nPedidosLabel.Text = "Nº de Pedidos: "
        '
        'dgv
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(12, 39)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(628, 417)
        Me.dgv.TabIndex = 2
        '
        'cap06_Lab01Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 468)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.nPedidosLabel)
        Me.Controls.Add(Me.clienteComboBox)
        Me.Name = "cap06_Lab01Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Capítulo 6 – Laboratório 1"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents clienteComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents nPedidosLabel As System.Windows.Forms.Label
    Friend WithEvents dgv As System.Windows.Forms.DataGridView

End Class
