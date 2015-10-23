<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cap07_Lab01_Tela
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
        Me.FuncionariosCap071 = New Capitulo07_Laboratorio01.FuncionariosCap07
        Me.SuspendLayout()
        '
        'FuncionariosCap071
        '
        Me.FuncionariosCap071.BackColor = System.Drawing.SystemColors.Control
        Me.FuncionariosCap071.Location = New System.Drawing.Point(12, 12)
        Me.FuncionariosCap071.MinimumSize = New System.Drawing.Size(480, 260)
        Me.FuncionariosCap071.Name = "FuncionariosCap071"
        Me.FuncionariosCap071.Size = New System.Drawing.Size(480, 260)
        Me.FuncionariosCap071.TabIndex = 0
        '
        'Cap07_Lab01_Tela
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 285)
        Me.Controls.Add(Me.FuncionariosCap071)
        Me.Name = "Cap07_Lab01_Tela"
        Me.Text = "Capítulo 07 – Laboratório 01 - Tela"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FuncionariosCap071 As Capitulo07_Laboratorio01.FuncionariosCap07

End Class
