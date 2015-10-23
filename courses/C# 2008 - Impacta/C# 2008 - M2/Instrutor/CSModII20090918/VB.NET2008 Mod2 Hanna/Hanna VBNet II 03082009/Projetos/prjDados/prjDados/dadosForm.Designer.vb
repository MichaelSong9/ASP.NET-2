<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dadosForm
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
        Me.countryComboBox = New System.Windows.Forms.ComboBox
        Me.customerListBox = New System.Windows.Forms.ListBox
        Me.customerIdTextBox = New System.Windows.Forms.TextBox
        Me.contactNameTextBox = New System.Windows.Forms.TextBox
        Me.contactTitleTextBox = New System.Windows.Forms.TextBox
        Me.addressTextBox = New System.Windows.Forms.TextBox
        Me.cityTextBox = New System.Windows.Forms.TextBox
        Me.regionTextBox = New System.Windows.Forms.TextBox
        Me.postalCodeTextBox = New System.Windows.Forms.TextBox
        Me.phoneTextBox = New System.Windows.Forms.TextBox
        Me.faxTextBox = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'countryComboBox
        '
        Me.countryComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.countryComboBox.FormattingEnabled = True
        Me.countryComboBox.Location = New System.Drawing.Point(12, 12)
        Me.countryComboBox.Name = "countryComboBox"
        Me.countryComboBox.Size = New System.Drawing.Size(400, 33)
        Me.countryComboBox.TabIndex = 0
        '
        'customerListBox
        '
        Me.customerListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.customerListBox.FormattingEnabled = True
        Me.customerListBox.ItemHeight = 25
        Me.customerListBox.Location = New System.Drawing.Point(12, 48)
        Me.customerListBox.Name = "customerListBox"
        Me.customerListBox.Size = New System.Drawing.Size(400, 354)
        Me.customerListBox.TabIndex = 1
        '
        'customerIdTextBox
        '
        Me.customerIdTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.customerIdTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.customerIdTextBox.Location = New System.Drawing.Point(418, 48)
        Me.customerIdTextBox.Name = "customerIdTextBox"
        Me.customerIdTextBox.ReadOnly = True
        Me.customerIdTextBox.Size = New System.Drawing.Size(117, 32)
        Me.customerIdTextBox.TabIndex = 2
        '
        'contactNameTextBox
        '
        Me.contactNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contactNameTextBox.Location = New System.Drawing.Point(418, 88)
        Me.contactNameTextBox.Name = "contactNameTextBox"
        Me.contactNameTextBox.Size = New System.Drawing.Size(271, 32)
        Me.contactNameTextBox.TabIndex = 3
        '
        'contactTitleTextBox
        '
        Me.contactTitleTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contactTitleTextBox.Location = New System.Drawing.Point(418, 128)
        Me.contactTitleTextBox.Name = "contactTitleTextBox"
        Me.contactTitleTextBox.Size = New System.Drawing.Size(271, 32)
        Me.contactTitleTextBox.TabIndex = 4
        '
        'addressTextBox
        '
        Me.addressTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addressTextBox.Location = New System.Drawing.Point(418, 168)
        Me.addressTextBox.Name = "addressTextBox"
        Me.addressTextBox.Size = New System.Drawing.Size(271, 32)
        Me.addressTextBox.TabIndex = 5
        '
        'cityTextBox
        '
        Me.cityTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cityTextBox.Location = New System.Drawing.Point(418, 208)
        Me.cityTextBox.Name = "cityTextBox"
        Me.cityTextBox.Size = New System.Drawing.Size(271, 32)
        Me.cityTextBox.TabIndex = 6
        '
        'regionTextBox
        '
        Me.regionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regionTextBox.Location = New System.Drawing.Point(418, 248)
        Me.regionTextBox.Name = "regionTextBox"
        Me.regionTextBox.Size = New System.Drawing.Size(271, 32)
        Me.regionTextBox.TabIndex = 7
        '
        'postalCodeTextBox
        '
        Me.postalCodeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.postalCodeTextBox.Location = New System.Drawing.Point(418, 288)
        Me.postalCodeTextBox.Name = "postalCodeTextBox"
        Me.postalCodeTextBox.Size = New System.Drawing.Size(271, 32)
        Me.postalCodeTextBox.TabIndex = 8
        '
        'phoneTextBox
        '
        Me.phoneTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phoneTextBox.Location = New System.Drawing.Point(418, 328)
        Me.phoneTextBox.Name = "phoneTextBox"
        Me.phoneTextBox.Size = New System.Drawing.Size(271, 32)
        Me.phoneTextBox.TabIndex = 9
        '
        'faxTextBox
        '
        Me.faxTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.faxTextBox.Location = New System.Drawing.Point(418, 368)
        Me.faxTextBox.Name = "faxTextBox"
        Me.faxTextBox.Size = New System.Drawing.Size(271, 32)
        Me.faxTextBox.TabIndex = 10
        '
        'dadosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 416)
        Me.Controls.Add(Me.faxTextBox)
        Me.Controls.Add(Me.phoneTextBox)
        Me.Controls.Add(Me.postalCodeTextBox)
        Me.Controls.Add(Me.regionTextBox)
        Me.Controls.Add(Me.cityTextBox)
        Me.Controls.Add(Me.addressTextBox)
        Me.Controls.Add(Me.contactTitleTextBox)
        Me.Controls.Add(Me.contactNameTextBox)
        Me.Controls.Add(Me.customerIdTextBox)
        Me.Controls.Add(Me.customerListBox)
        Me.Controls.Add(Me.countryComboBox)
        Me.MaximumSize = New System.Drawing.Size(710, 443)
        Me.MinimumSize = New System.Drawing.Size(710, 443)
        Me.Name = "dadosForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acesso a Dados"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents countryComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents customerListBox As System.Windows.Forms.ListBox
    Friend WithEvents customerIdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents contactNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents contactTitleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents addressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents cityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents regionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents postalCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents phoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents faxTextBox As System.Windows.Forms.TextBox

End Class
