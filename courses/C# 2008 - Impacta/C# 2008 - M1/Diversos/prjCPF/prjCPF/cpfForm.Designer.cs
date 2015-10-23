namespace prjCPF
{
    partial class cpfForm
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
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.removerButton = new System.Windows.Forms.Button();
            this.cpfLabel = new System.Windows.Forms.Label();
            this.cpfTextBox = new System.Windows.Forms.TextBox();
            this.validarButton = new System.Windows.Forms.Button();
            this.botao1 = new prjBotao.Botao();
            this.SuspendLayout();
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeTextBox.Location = new System.Drawing.Point(12, 12);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(425, 26);
            this.nomeTextBox.TabIndex = 0;
            this.nomeTextBox.Text = "João Ipê da Conceição Brás";
            // 
            // removerButton
            // 
            this.removerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removerButton.Location = new System.Drawing.Point(443, 12);
            this.removerButton.Name = "removerButton";
            this.removerButton.Size = new System.Drawing.Size(170, 26);
            this.removerButton.TabIndex = 1;
            this.removerButton.Text = "Remover Acentos";
            this.removerButton.UseVisualStyleBackColor = true;
            this.removerButton.Click += new System.EventHandler(this.removerButton_Click);
            // 
            // cpfLabel
            // 
            this.cpfLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpfLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpfLabel.Location = new System.Drawing.Point(12, 103);
            this.cpfLabel.Name = "cpfLabel";
            this.cpfLabel.Size = new System.Drawing.Size(425, 51);
            this.cpfLabel.TabIndex = 2;
            this.cpfLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cpfTextBox
            // 
            this.cpfTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpfTextBox.Location = new System.Drawing.Point(12, 60);
            this.cpfTextBox.MaxLength = 11;
            this.cpfTextBox.Name = "cpfTextBox";
            this.cpfTextBox.Size = new System.Drawing.Size(425, 29);
            this.cpfTextBox.TabIndex = 3;
            this.cpfTextBox.Text = "11111111111";
            this.cpfTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // validarButton
            // 
            this.validarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validarButton.Location = new System.Drawing.Point(443, 60);
            this.validarButton.Name = "validarButton";
            this.validarButton.Size = new System.Drawing.Size(170, 94);
            this.validarButton.TabIndex = 4;
            this.validarButton.Text = "Validar";
            this.validarButton.UseVisualStyleBackColor = true;
            this.validarButton.Click += new System.EventHandler(this.validarButton_Click);
            // 
            // botao1
            // 
            this.botao1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao1.Location = new System.Drawing.Point(443, 173);
            this.botao1.Name = "botao1";
            this.botao1.Size = new System.Drawing.Size(170, 31);
            this.botao1.TabIndex = 5;
            this.botao1.TextoBotao = "&Fechar";
            // 
            // cpfForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 216);
            this.Controls.Add(this.botao1);
            this.Controls.Add(this.validarButton);
            this.Controls.Add(this.cpfTextBox);
            this.Controls.Add(this.cpfLabel);
            this.Controls.Add(this.removerButton);
            this.Controls.Add(this.nomeTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "cpfForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CPF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.Button removerButton;
        private System.Windows.Forms.Label cpfLabel;
        private System.Windows.Forms.TextBox cpfTextBox;
        private System.Windows.Forms.Button validarButton;
        private prjBotao.Botao botao1;
    }
}

