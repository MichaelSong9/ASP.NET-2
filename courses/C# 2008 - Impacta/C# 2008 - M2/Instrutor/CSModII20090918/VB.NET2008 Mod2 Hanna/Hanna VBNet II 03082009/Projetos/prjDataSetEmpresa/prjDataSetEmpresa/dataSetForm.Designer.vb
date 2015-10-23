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
        Me.editarGravarButton = New System.Windows.Forms.Button
        Me.dgvCliente = New System.Windows.Forms.DataGridView
        Me.registroLabel = New System.Windows.Forms.Label
        Me.nomeTextBox = New System.Windows.Forms.TextBox
        Me.exibirButton = New System.Windows.Forms.Button
        CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'editarGravarButton
        '
        Me.editarGravarButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editarGravarButton.Location = New System.Drawing.Point(12, 12)
        Me.editarGravarButton.Name = "editarGravarButton"
        Me.editarGravarButton.Size = New System.Drawing.Size(222, 35)
        Me.editarGravarButton.TabIndex = 0
        Me.editarGravarButton.Text = "&Editar"
        Me.editarGravarButton.UseVisualStyleBackColor = True
        '
        'dgvCliente
        '
        Me.dgvCliente.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCliente.Location = New System.Drawing.Point(12, 53)
        Me.dgvCliente.Name = "dgvCliente"
        Me.dgvCliente.Size = New System.Drawing.Size(626, 337)
        Me.dgvCliente.TabIndex = 1
        '
        'registroLabel
        '
        Me.registroLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.registroLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.registroLabel.Location = New System.Drawing.Point(540, 393)
        Me.registroLabel.Name = "registroLabel"
        Me.registroLabel.Size = New System.Drawing.Size(100, 15)
        Me.registroLabel.TabIndex = 2
        Me.registroLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'nomeTextBox
        '
        Me.nomeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nomeTextBox.Location = New System.Drawing.Point(240, 12)
        Me.nomeTextBox.Name = "nomeTextBox"
        Me.nomeTextBox.Size = New System.Drawing.Size(313, 35)
        Me.nomeTextBox.TabIndex = 3
        Me.nomeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'exibirButton
        '
        Me.exibirButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exibirButton.Location = New System.Drawing.Point(559, 12)
        Me.exibirButton.Name = "exibirButton"
        Me.exibirButton.Size = New System.Drawing.Size(79, 35)
        Me.exibirButton.TabIndex = 4
        Me.exibirButton.Text = "Exibir"
        Me.exibirButton.UseVisualStyleBackColor = True
        '
        'dataSetForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 416)
        Me.Controls.Add(Me.exibirButton)
        Me.Controls.Add(Me.nomeTextBox)
        Me.Controls.Add(Me.registroLabel)
        Me.Controls.Add(Me.dgvCliente)
        Me.Controls.Add(Me.editarGravarButton)
        Me.Name = "dataSetForm"
        Me.Text = "DataSet Empresa"
        CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents editarGravarButton As System.Windows.Forms.Button
    Friend WithEvents dgvCliente As System.Windows.Forms.DataGridView
    Friend WithEvents registroLabel As System.Windows.Forms.Label
    Friend WithEvents nomeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents exibirButton As System.Windows.Forms.Button

End Class
