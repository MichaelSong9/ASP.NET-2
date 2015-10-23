namespace Capitulo08_Laboratorio01
{
    partial class FuncionariosCap08
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.admissaoTextBox = new System.Windows.Forms.TextBox();
            this.nascimentoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cargoTextBox = new System.Windows.Forms.TextBox();
            this.funcionarioComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.observacaoTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // admissaoTextBox
            // 
            this.admissaoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.admissaoTextBox.BackColor = System.Drawing.Color.White;
            this.admissaoTextBox.Location = new System.Drawing.Point(88, 56);
            this.admissaoTextBox.Name = "admissaoTextBox";
            this.admissaoTextBox.ReadOnly = true;
            this.admissaoTextBox.Size = new System.Drawing.Size(108, 20);
            this.admissaoTextBox.TabIndex = 5;
            this.admissaoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nascimentoTextBox
            // 
            this.nascimentoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.nascimentoTextBox.BackColor = System.Drawing.Color.White;
            this.nascimentoTextBox.Location = new System.Drawing.Point(88, 84);
            this.nascimentoTextBox.Name = "nascimentoTextBox";
            this.nascimentoTextBox.ReadOnly = true;
            this.nascimentoTextBox.Size = new System.Drawing.Size(108, 20);
            this.nascimentoTextBox.TabIndex = 7;
            this.nascimentoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Funcionário:";
            // 
            // cargoTextBox
            // 
            this.cargoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cargoTextBox.BackColor = System.Drawing.Color.White;
            this.cargoTextBox.Location = new System.Drawing.Point(88, 28);
            this.cargoTextBox.Name = "cargoTextBox";
            this.cargoTextBox.ReadOnly = true;
            this.cargoTextBox.Size = new System.Drawing.Size(385, 20);
            this.cargoTextBox.TabIndex = 3;
            // 
            // funcionarioComboBox
            // 
            this.funcionarioComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.funcionarioComboBox.FormattingEnabled = true;
            this.funcionarioComboBox.Location = new System.Drawing.Point(88, 0);
            this.funcionarioComboBox.Name = "funcionarioComboBox";
            this.funcionarioComboBox.Size = new System.Drawing.Size(385, 21);
            this.funcionarioComboBox.TabIndex = 1;
            this.funcionarioComboBox.SelectedIndexChanged += new System.EventHandler(this.funcionarioComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "&Cargo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "&Admissão:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "&Nascimento:";
            // 
            // observacaoTextBox
            // 
            this.observacaoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.observacaoTextBox.BackColor = System.Drawing.Color.White;
            this.observacaoTextBox.Location = new System.Drawing.Point(88, 110);
            this.observacaoTextBox.Multiline = true;
            this.observacaoTextBox.Name = "observacaoTextBox";
            this.observacaoTextBox.ReadOnly = true;
            this.observacaoTextBox.Size = new System.Drawing.Size(385, 147);
            this.observacaoTextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "&Observação:";
            // 
            // FuncionariosCap08
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.observacaoTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.funcionarioComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nascimentoTextBox);
            this.Controls.Add(this.admissaoTextBox);
            this.Controls.Add(this.cargoTextBox);
            this.MinimumSize = new System.Drawing.Size(480, 260);
            this.Name = "FuncionariosCap08";
            this.Size = new System.Drawing.Size(480, 260);
            this.Load += new System.EventHandler(this.FuncionariosCap08_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox admissaoTextBox;
        private System.Windows.Forms.TextBox nascimentoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cargoTextBox;
        private System.Windows.Forms.ComboBox funcionarioComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox observacaoTextBox;
        private System.Windows.Forms.Label label5;
    }
}
