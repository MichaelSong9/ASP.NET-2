namespace Capitulo02_lab1
{
    partial class calculadoraForm
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
            this.numero1TextBox = new System.Windows.Forms.TextBox();
            this.numero2TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.somarButton = new System.Windows.Forms.Button();
            this.resultadoLabel = new System.Windows.Forms.Label();
            this.subtrairButton = new System.Windows.Forms.Button();
            this.dividirButton = new System.Windows.Forms.Button();
            this.multiplicarButton = new System.Windows.Forms.Button();
            this.sairButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numero1TextBox
            // 
            this.numero1TextBox.Location = new System.Drawing.Point(119, 12);
            this.numero1TextBox.Name = "numero1TextBox";
            this.numero1TextBox.Size = new System.Drawing.Size(100, 20);
            this.numero1TextBox.TabIndex = 0;
            this.numero1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numero2TextBox
            // 
            this.numero2TextBox.Location = new System.Drawing.Point(119, 47);
            this.numero2TextBox.Name = "numero2TextBox";
            this.numero2TextBox.Size = new System.Drawing.Size(100, 20);
            this.numero2TextBox.TabIndex = 1;
            this.numero2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numero 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numero 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Resultado";
            // 
            // somarButton
            // 
            this.somarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.somarButton.Location = new System.Drawing.Point(247, 12);
            this.somarButton.Name = "somarButton";
            this.somarButton.Size = new System.Drawing.Size(103, 24);
            this.somarButton.TabIndex = 6;
            this.somarButton.Text = "Somar";
            this.somarButton.UseVisualStyleBackColor = true;
            this.somarButton.Click += new System.EventHandler(this.somarButton_Click);
            // 
            // resultadoLabel
            // 
            this.resultadoLabel.AutoSize = true;
            this.resultadoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultadoLabel.Location = new System.Drawing.Point(142, 84);
            this.resultadoLabel.Name = "resultadoLabel";
            this.resultadoLabel.Size = new System.Drawing.Size(0, 13);
            this.resultadoLabel.TabIndex = 7;
            this.resultadoLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // subtrairButton
            // 
            this.subtrairButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtrairButton.Location = new System.Drawing.Point(247, 47);
            this.subtrairButton.Name = "subtrairButton";
            this.subtrairButton.Size = new System.Drawing.Size(103, 24);
            this.subtrairButton.TabIndex = 8;
            this.subtrairButton.Text = "Subtrair";
            this.subtrairButton.UseVisualStyleBackColor = true;
            this.subtrairButton.Click += new System.EventHandler(this.subtrairButton_Click);
            // 
            // dividirButton
            // 
            this.dividirButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividirButton.Location = new System.Drawing.Point(247, 119);
            this.dividirButton.Name = "dividirButton";
            this.dividirButton.Size = new System.Drawing.Size(103, 24);
            this.dividirButton.TabIndex = 10;
            this.dividirButton.Text = "Dividir";
            this.dividirButton.UseVisualStyleBackColor = true;
            this.dividirButton.Click += new System.EventHandler(this.dividirButton_Click);
            // 
            // multiplicarButton
            // 
            this.multiplicarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplicarButton.Location = new System.Drawing.Point(247, 84);
            this.multiplicarButton.Name = "multiplicarButton";
            this.multiplicarButton.Size = new System.Drawing.Size(103, 24);
            this.multiplicarButton.TabIndex = 9;
            this.multiplicarButton.Text = "Multiplicar";
            this.multiplicarButton.UseVisualStyleBackColor = true;
            this.multiplicarButton.Click += new System.EventHandler(this.multiplicarButton_Click);
            // 
            // sairButton
            // 
            this.sairButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sairButton.Location = new System.Drawing.Point(247, 159);
            this.sairButton.Name = "sairButton";
            this.sairButton.Size = new System.Drawing.Size(103, 24);
            this.sairButton.TabIndex = 11;
            this.sairButton.Text = "Sair";
            this.sairButton.UseVisualStyleBackColor = true;
            this.sairButton.Click += new System.EventHandler(this.sairButton_Click);
            // 
            // calculadoraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 200);
            this.Controls.Add(this.sairButton);
            this.Controls.Add(this.dividirButton);
            this.Controls.Add(this.multiplicarButton);
            this.Controls.Add(this.subtrairButton);
            this.Controls.Add(this.resultadoLabel);
            this.Controls.Add(this.somarButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numero2TextBox);
            this.Controls.Add(this.numero1TextBox);
            this.Name = "calculadoraForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numero1TextBox;
        private System.Windows.Forms.TextBox numero2TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button somarButton;
        private System.Windows.Forms.Label resultadoLabel;
        private System.Windows.Forms.Button subtrairButton;
        private System.Windows.Forms.Button dividirButton;
        private System.Windows.Forms.Button multiplicarButton;
        private System.Windows.Forms.Button sairButton;
    }
}

