namespace Lab01Cap01
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.calculadoraButton = new System.Windows.Forms.Button();
            this.fecharCalculadoraButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // calculadoraButton
            // 
            this.calculadoraButton.Location = new System.Drawing.Point(12, 22);
            this.calculadoraButton.Name = "calculadoraButton";
            this.calculadoraButton.Size = new System.Drawing.Size(147, 37);
            this.calculadoraButton.TabIndex = 1;
            this.calculadoraButton.Text = "Calculadora";
            this.calculadoraButton.UseVisualStyleBackColor = true;
            this.calculadoraButton.Click += new System.EventHandler(this.calculadoraButton_Click);
            // 
            // fecharCalculadoraButton
            // 
            this.fecharCalculadoraButton.Location = new System.Drawing.Point(12, 65);
            this.fecharCalculadoraButton.Name = "fecharCalculadoraButton";
            this.fecharCalculadoraButton.Size = new System.Drawing.Size(147, 37);
            this.fecharCalculadoraButton.TabIndex = 2;
            this.fecharCalculadoraButton.Text = "Fechar Calculadora";
            this.fecharCalculadoraButton.UseVisualStyleBackColor = true;
            this.fecharCalculadoraButton.Click += new System.EventHandler(this.fecharCalculadoraButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.fecharCalculadoraButton);
            this.Controls.Add(this.calculadoraButton);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Cap 01 Lab 01";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button calculadoraButton;
        private System.Windows.Forms.Button fecharCalculadoraButton;
    }
}

