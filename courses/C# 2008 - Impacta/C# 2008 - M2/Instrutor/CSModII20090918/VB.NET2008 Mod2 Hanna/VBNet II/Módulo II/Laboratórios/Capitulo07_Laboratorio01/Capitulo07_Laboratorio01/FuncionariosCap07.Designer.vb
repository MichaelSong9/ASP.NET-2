<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FuncionariosCap07
    Inherits System.Windows.Forms.UserControl

    'UserControl1 overrides dispose to clean up the component list.
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.funcionarioComboBox = New System.Windows.Forms.ComboBox
        Me.cargoTextBox = New System.Windows.Forms.TextBox
        Me.admissaoTextBox = New System.Windows.Forms.TextBox
        Me.nascimentoTextBox = New System.Windows.Forms.TextBox
        Me.observacaoTextBox = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Funcionário:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Cargo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "&Admissão:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "&Nascimento:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "&Observação:"
        '
        'funcionarioComboBox
        '
        Me.funcionarioComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.funcionarioComboBox.FormattingEnabled = True
        Me.funcionarioComboBox.Location = New System.Drawing.Point(90, 0)
        Me.funcionarioComboBox.Name = "funcionarioComboBox"
        Me.funcionarioComboBox.Size = New System.Drawing.Size(387, 21)
        Me.funcionarioComboBox.TabIndex = 1
        '
        'cargoTextBox
        '
        Me.cargoTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cargoTextBox.BackColor = System.Drawing.Color.White
        Me.cargoTextBox.Location = New System.Drawing.Point(90, 26)
        Me.cargoTextBox.Name = "cargoTextBox"
        Me.cargoTextBox.ReadOnly = True
        Me.cargoTextBox.Size = New System.Drawing.Size(387, 20)
        Me.cargoTextBox.TabIndex = 3
        '
        'admissaoTextBox
        '
        Me.admissaoTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.admissaoTextBox.BackColor = System.Drawing.Color.White
        Me.admissaoTextBox.Location = New System.Drawing.Point(90, 55)
        Me.admissaoTextBox.Name = "admissaoTextBox"
        Me.admissaoTextBox.ReadOnly = True
        Me.admissaoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.admissaoTextBox.TabIndex = 5
        Me.admissaoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'nascimentoTextBox
        '
        Me.nascimentoTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nascimentoTextBox.BackColor = System.Drawing.Color.White
        Me.nascimentoTextBox.Location = New System.Drawing.Point(90, 84)
        Me.nascimentoTextBox.Name = "nascimentoTextBox"
        Me.nascimentoTextBox.ReadOnly = True
        Me.nascimentoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.nascimentoTextBox.TabIndex = 7
        Me.nascimentoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'observacaoTextBox
        '
        Me.observacaoTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.observacaoTextBox.BackColor = System.Drawing.Color.White
        Me.observacaoTextBox.Location = New System.Drawing.Point(90, 113)
        Me.observacaoTextBox.Multiline = True
        Me.observacaoTextBox.Name = "observacaoTextBox"
        Me.observacaoTextBox.ReadOnly = True
        Me.observacaoTextBox.Size = New System.Drawing.Size(387, 144)
        Me.observacaoTextBox.TabIndex = 9
        '
        'FuncionariosCap07
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.observacaoTextBox)
        Me.Controls.Add(Me.nascimentoTextBox)
        Me.Controls.Add(Me.admissaoTextBox)
        Me.Controls.Add(Me.cargoTextBox)
        Me.Controls.Add(Me.funcionarioComboBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MinimumSize = New System.Drawing.Size(480, 260)
        Me.Name = "FuncionariosCap07"
        Me.Size = New System.Drawing.Size(480, 260)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents funcionarioComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents cargoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents admissaoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents nascimentoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents observacaoTextBox As System.Windows.Forms.TextBox

End Class
