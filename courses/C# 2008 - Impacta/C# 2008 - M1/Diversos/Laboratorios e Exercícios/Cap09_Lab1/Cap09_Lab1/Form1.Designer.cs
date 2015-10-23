namespace Cap09_Lab1
{
    partial class contasForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.novaContaGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.novaContaTextBox = new System.Windows.Forms.TextBox();
            this.novaContaButton = new System.Windows.Forms.Button();
            this.movimentacaoGroupBox = new System.Windows.Forms.GroupBox();
            this.depositoButton = new System.Windows.Forms.Button();
            this.retiradaButton = new System.Windows.Forms.Button();
            this.retiradaTextBox = new System.Windows.Forms.TextBox();
            this.depositoTextBox = new System.Windows.Forms.TextBox();
            this.contaAtualLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.saldoAtualLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.contasGroupBox = new System.Windows.Forms.GroupBox();
            this.contasListBox = new System.Windows.Forms.ListBox();
            this.novaContaGroupBox.SuspendLayout();
            this.movimentacaoGroupBox.SuspendLayout();
            this.contasGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // novaContaGroupBox
            // 
            this.novaContaGroupBox.Controls.Add(this.label1);
            this.novaContaGroupBox.Controls.Add(this.novaContaTextBox);
            this.novaContaGroupBox.Controls.Add(this.novaContaButton);
            this.novaContaGroupBox.Location = new System.Drawing.Point(17, 12);
            this.novaContaGroupBox.Name = "novaContaGroupBox";
            this.novaContaGroupBox.Size = new System.Drawing.Size(360, 84);
            this.novaContaGroupBox.TabIndex = 5;
            this.novaContaGroupBox.TabStop = false;
            this.novaContaGroupBox.Text = "Incluir conta corrente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // novaContaTextBox
            // 
            this.novaContaTextBox.Location = new System.Drawing.Point(92, 31);
            this.novaContaTextBox.Name = "novaContaTextBox";
            this.novaContaTextBox.Size = new System.Drawing.Size(162, 20);
            this.novaContaTextBox.TabIndex = 0;
            // 
            // novaContaButton
            // 
            this.novaContaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.novaContaButton.ForeColor = System.Drawing.Color.Blue;
            this.novaContaButton.Location = new System.Drawing.Point(260, 30);
            this.novaContaButton.Name = "novaContaButton";
            this.novaContaButton.Size = new System.Drawing.Size(75, 23);
            this.novaContaButton.TabIndex = 1;
            this.novaContaButton.Text = "Incluir";
            this.novaContaButton.UseVisualStyleBackColor = true;
            this.novaContaButton.Click += new System.EventHandler(this.novaContaButton_Click);
            // 
            // movimentacaoGroupBox
            // 
            this.movimentacaoGroupBox.Controls.Add(this.label7);
            this.movimentacaoGroupBox.Controls.Add(this.label6);
            this.movimentacaoGroupBox.Controls.Add(this.label5);
            this.movimentacaoGroupBox.Controls.Add(this.saldoAtualLabel);
            this.movimentacaoGroupBox.Controls.Add(this.label3);
            this.movimentacaoGroupBox.Controls.Add(this.contaAtualLabel);
            this.movimentacaoGroupBox.Controls.Add(this.depositoTextBox);
            this.movimentacaoGroupBox.Controls.Add(this.retiradaTextBox);
            this.movimentacaoGroupBox.Controls.Add(this.depositoButton);
            this.movimentacaoGroupBox.Controls.Add(this.retiradaButton);
            this.movimentacaoGroupBox.Location = new System.Drawing.Point(17, 119);
            this.movimentacaoGroupBox.Name = "movimentacaoGroupBox";
            this.movimentacaoGroupBox.Size = new System.Drawing.Size(360, 194);
            this.movimentacaoGroupBox.TabIndex = 6;
            this.movimentacaoGroupBox.TabStop = false;
            this.movimentacaoGroupBox.Text = "Movimentação";
            // 
            // depositoButton
            // 
            this.depositoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositoButton.ForeColor = System.Drawing.Color.Blue;
            this.depositoButton.Location = new System.Drawing.Point(260, 133);
            this.depositoButton.Name = "depositoButton";
            this.depositoButton.Size = new System.Drawing.Size(75, 23);
            this.depositoButton.TabIndex = 5;
            this.depositoButton.Text = "Ok";
            this.depositoButton.UseVisualStyleBackColor = true;
            this.depositoButton.Click += new System.EventHandler(this.depositoButton_Click);
            // 
            // retiradaButton
            // 
            this.retiradaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retiradaButton.ForeColor = System.Drawing.Color.Blue;
            this.retiradaButton.Location = new System.Drawing.Point(260, 92);
            this.retiradaButton.Name = "retiradaButton";
            this.retiradaButton.Size = new System.Drawing.Size(75, 23);
            this.retiradaButton.TabIndex = 3;
            this.retiradaButton.Text = "Ok";
            this.retiradaButton.UseVisualStyleBackColor = true;
            this.retiradaButton.Click += new System.EventHandler(this.retiradaButton_Click);
            // 
            // retiradaTextBox
            // 
            this.retiradaTextBox.Location = new System.Drawing.Point(90, 93);
            this.retiradaTextBox.Name = "retiradaTextBox";
            this.retiradaTextBox.Size = new System.Drawing.Size(162, 20);
            this.retiradaTextBox.TabIndex = 2;
            // 
            // depositoTextBox
            // 
            this.depositoTextBox.Location = new System.Drawing.Point(92, 134);
            this.depositoTextBox.Name = "depositoTextBox";
            this.depositoTextBox.Size = new System.Drawing.Size(162, 20);
            this.depositoTextBox.TabIndex = 4;
            // 
            // contaAtualLabel
            // 
            this.contaAtualLabel.AutoSize = true;
            this.contaAtualLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contaAtualLabel.Location = new System.Drawing.Point(90, 28);
            this.contaAtualLabel.Name = "contaAtualLabel";
            this.contaAtualLabel.Size = new System.Drawing.Size(0, 13);
            this.contaAtualLabel.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Conta:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // saldoAtualLabel
            // 
            this.saldoAtualLabel.AutoSize = true;
            this.saldoAtualLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saldoAtualLabel.Location = new System.Drawing.Point(90, 60);
            this.saldoAtualLabel.Name = "saldoAtualLabel";
            this.saldoAtualLabel.Size = new System.Drawing.Size(0, 13);
            this.saldoAtualLabel.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Saldo atual:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Depósito:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Retirada:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // contasGroupBox
            // 
            this.contasGroupBox.Controls.Add(this.contasListBox);
            this.contasGroupBox.Location = new System.Drawing.Point(386, 12);
            this.contasGroupBox.Name = "contasGroupBox";
            this.contasGroupBox.Size = new System.Drawing.Size(185, 301);
            this.contasGroupBox.TabIndex = 7;
            this.contasGroupBox.TabStop = false;
            this.contasGroupBox.Text = "Contas";
            // 
            // contasListBox
            // 
            this.contasListBox.FormattingEnabled = true;
            this.contasListBox.Location = new System.Drawing.Point(15, 27);
            this.contasListBox.Name = "contasListBox";
            this.contasListBox.Size = new System.Drawing.Size(153, 251);
            this.contasListBox.TabIndex = 6;
            this.contasListBox.TabStop = false;
            this.contasListBox.SelectedIndexChanged += new System.EventHandler(this.contasListBox_SelectedIndexChanged);
            // 
            // contasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 333);
            this.Controls.Add(this.contasGroupBox);
            this.Controls.Add(this.movimentacaoGroupBox);
            this.Controls.Add(this.novaContaGroupBox);
            this.Name = "contasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimentação de Contas";
            this.novaContaGroupBox.ResumeLayout(false);
            this.novaContaGroupBox.PerformLayout();
            this.movimentacaoGroupBox.ResumeLayout(false);
            this.movimentacaoGroupBox.PerformLayout();
            this.contasGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox novaContaGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox novaContaTextBox;
        private System.Windows.Forms.Button novaContaButton;
        private System.Windows.Forms.GroupBox movimentacaoGroupBox;
        private System.Windows.Forms.TextBox depositoTextBox;
        private System.Windows.Forms.TextBox retiradaTextBox;
        private System.Windows.Forms.Button depositoButton;
        private System.Windows.Forms.Button retiradaButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label saldoAtualLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label contaAtualLabel;
        private System.Windows.Forms.GroupBox contasGroupBox;
        private System.Windows.Forms.ListBox contasListBox;

    }
}

