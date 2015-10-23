<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cepForm
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
        Me.cepTextBox = New System.Windows.Forms.TextBox
        Me.viaTextBox = New System.Windows.Forms.TextBox
        Me.logradouroTextBox = New System.Windows.Forms.TextBox
        Me.bairroTextBox = New System.Windows.Forms.TextBox
        Me.cidadeTextBox = New System.Windows.Forms.TextBox
        Me.ufTextBox = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.gerarBaseButton = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'cepTextBox
        '
        Me.cepTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cepTextBox.Location = New System.Drawing.Point(145, 14)
        Me.cepTextBox.Name = "cepTextBox"
        Me.cepTextBox.Size = New System.Drawing.Size(150, 32)
        Me.cepTextBox.TabIndex = 1
        Me.cepTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'viaTextBox
        '
        Me.viaTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.viaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viaTextBox.Location = New System.Drawing.Point(145, 46)
        Me.viaTextBox.Name = "viaTextBox"
        Me.viaTextBox.ReadOnly = True
        Me.viaTextBox.Size = New System.Drawing.Size(326, 32)
        Me.viaTextBox.TabIndex = 3
        '
        'logradouroTextBox
        '
        Me.logradouroTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.logradouroTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logradouroTextBox.Location = New System.Drawing.Point(145, 78)
        Me.logradouroTextBox.Name = "logradouroTextBox"
        Me.logradouroTextBox.ReadOnly = True
        Me.logradouroTextBox.Size = New System.Drawing.Size(326, 32)
        Me.logradouroTextBox.TabIndex = 5
        '
        'bairroTextBox
        '
        Me.bairroTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.bairroTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bairroTextBox.Location = New System.Drawing.Point(145, 110)
        Me.bairroTextBox.Name = "bairroTextBox"
        Me.bairroTextBox.ReadOnly = True
        Me.bairroTextBox.Size = New System.Drawing.Size(326, 32)
        Me.bairroTextBox.TabIndex = 7
        '
        'cidadeTextBox
        '
        Me.cidadeTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cidadeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cidadeTextBox.Location = New System.Drawing.Point(145, 142)
        Me.cidadeTextBox.Name = "cidadeTextBox"
        Me.cidadeTextBox.ReadOnly = True
        Me.cidadeTextBox.Size = New System.Drawing.Size(326, 32)
        Me.cidadeTextBox.TabIndex = 9
        '
        'ufTextBox
        '
        Me.ufTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ufTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ufTextBox.Location = New System.Drawing.Point(145, 174)
        Me.ufTextBox.Name = "ufTextBox"
        Me.ufTextBox.ReadOnly = True
        Me.ufTextBox.Size = New System.Drawing.Size(150, 32)
        Me.ufTextBox.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(75, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CEP:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 26)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tipo de Via:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 26)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Logradouro:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(63, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 26)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Bairro:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(52, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 26)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Cidade:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(92, 177)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 26)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "UF:"
        '
        'gerarBaseButton
        '
        Me.gerarBaseButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gerarBaseButton.Location = New System.Drawing.Point(17, 222)
        Me.gerarBaseButton.Name = "gerarBaseButton"
        Me.gerarBaseButton.Size = New System.Drawing.Size(454, 45)
        Me.gerarBaseButton.TabIndex = 12
        Me.gerarBaseButton.Text = "Gerar Base"
        Me.gerarBaseButton.UseVisualStyleBackColor = True
        '
        'cepForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 284)
        Me.Controls.Add(Me.gerarBaseButton)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ufTextBox)
        Me.Controls.Add(Me.cidadeTextBox)
        Me.Controls.Add(Me.bairroTextBox)
        Me.Controls.Add(Me.logradouroTextBox)
        Me.Controls.Add(Me.viaTextBox)
        Me.Controls.Add(Me.cepTextBox)
        Me.MinimumSize = New System.Drawing.Size(491, 246)
        Me.Name = "cepForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CEP"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cepTextBox As System.Windows.Forms.TextBox
    Friend WithEvents viaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents logradouroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents bairroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents cidadeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ufTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents gerarBaseButton As System.Windows.Forms.Button

End Class
