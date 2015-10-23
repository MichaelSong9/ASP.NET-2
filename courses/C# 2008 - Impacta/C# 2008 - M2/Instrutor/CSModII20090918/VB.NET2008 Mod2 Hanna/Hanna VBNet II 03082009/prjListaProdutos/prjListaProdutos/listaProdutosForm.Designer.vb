<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listaProdutosForm
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
        Me.produtoListBox = New System.Windows.Forms.ListBox
        Me.categoriaComboBox = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'produtoListBox
        '
        Me.produtoListBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.produtoListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.produtoListBox.FormattingEnabled = True
        Me.produtoListBox.ItemHeight = 24
        Me.produtoListBox.Location = New System.Drawing.Point(12, 50)
        Me.produtoListBox.Name = "produtoListBox"
        Me.produtoListBox.Size = New System.Drawing.Size(231, 172)
        Me.produtoListBox.TabIndex = 0
        '
        'categoriaComboBox
        '
        Me.categoriaComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.categoriaComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.categoriaComboBox.FormattingEnabled = True
        Me.categoriaComboBox.Items.AddRange(New Object() {"Frutas", "Laticinios", "Eletro Eletronicos"})
        Me.categoriaComboBox.Location = New System.Drawing.Point(12, 12)
        Me.categoriaComboBox.Name = "categoriaComboBox"
        Me.categoriaComboBox.Size = New System.Drawing.Size(231, 32)
        Me.categoriaComboBox.TabIndex = 1
        '
        'listaProdutosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(255, 239)
        Me.Controls.Add(Me.categoriaComboBox)
        Me.Controls.Add(Me.produtoListBox)
        Me.MinimumSize = New System.Drawing.Size(263, 266)
        Me.Name = "listaProdutosForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Produtos"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents produtoListBox As System.Windows.Forms.ListBox
    Friend WithEvents categoriaComboBox As System.Windows.Forms.ComboBox

End Class
