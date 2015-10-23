namespace prjCalculadoraComEventos
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
            this.valor1TextBox = new System.Windows.Forms.TextBox();
            this.valor2TextBox = new System.Windows.Forms.TextBox();
            this.somaButton = new System.Windows.Forms.Button();
            this.subtraiButton = new System.Windows.Forms.Button();
            this.multiplicaButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.resultadoLabel = new System.Windows.Forms.Label();
            this.raizButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // valor1TextBox
            // 
            this.valor1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valor1TextBox.Location = new System.Drawing.Point(12, 12);
            this.valor1TextBox.Name = "valor1TextBox";
            this.valor1TextBox.Size = new System.Drawing.Size(100, 29);
            this.valor1TextBox.TabIndex = 0;
            this.valor1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // valor2TextBox
            // 
            this.valor2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valor2TextBox.Location = new System.Drawing.Point(157, 12);
            this.valor2TextBox.Name = "valor2TextBox";
            this.valor2TextBox.Size = new System.Drawing.Size(100, 29);
            this.valor2TextBox.TabIndex = 1;
            this.valor2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // somaButton
            // 
            this.somaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.somaButton.Location = new System.Drawing.Point(91, 47);
            this.somaButton.Name = "somaButton";
            this.somaButton.Size = new System.Drawing.Size(42, 26);
            this.somaButton.TabIndex = 2;
            this.somaButton.Text = "+";
            this.somaButton.UseVisualStyleBackColor = true;
            // 
            // subtraiButton
            // 
            this.subtraiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtraiButton.Location = new System.Drawing.Point(135, 47);
            this.subtraiButton.Name = "subtraiButton";
            this.subtraiButton.Size = new System.Drawing.Size(42, 26);
            this.subtraiButton.TabIndex = 3;
            this.subtraiButton.Text = "-";
            this.subtraiButton.UseVisualStyleBackColor = true;
            // 
            // multiplicaButton
            // 
            this.multiplicaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplicaButton.Location = new System.Drawing.Point(91, 79);
            this.multiplicaButton.Name = "multiplicaButton";
            this.multiplicaButton.Size = new System.Drawing.Size(42, 26);
            this.multiplicaButton.TabIndex = 4;
            this.multiplicaButton.Text = "*";
            this.multiplicaButton.UseVisualStyleBackColor = true;
            // 
            // divideButton
            // 
            this.divideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divideButton.Location = new System.Drawing.Point(135, 79);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(42, 26);
            this.divideButton.TabIndex = 5;
            this.divideButton.Text = "/";
            this.divideButton.UseVisualStyleBackColor = true;
            // 
            // resultadoLabel
            // 
            this.resultadoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultadoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultadoLabel.Location = new System.Drawing.Point(12, 144);
            this.resultadoLabel.Name = "resultadoLabel";
            this.resultadoLabel.Size = new System.Drawing.Size(245, 42);
            this.resultadoLabel.TabIndex = 6;
            this.resultadoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // raizButton
            // 
            this.raizButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raizButton.Location = new System.Drawing.Point(91, 111);
            this.raizButton.Name = "raizButton";
            this.raizButton.Size = new System.Drawing.Size(86, 23);
            this.raizButton.TabIndex = 7;
            this.raizButton.Text = "Raiz";
            this.raizButton.UseVisualStyleBackColor = true;
            // 
            // calculadoraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 202);
            this.Controls.Add(this.raizButton);
            this.Controls.Add(this.resultadoLabel);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.multiplicaButton);
            this.Controls.Add(this.subtraiButton);
            this.Controls.Add(this.somaButton);
            this.Controls.Add(this.valor2TextBox);
            this.Controls.Add(this.valor1TextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "calculadoraForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora com Eventos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox valor1TextBox;
        private System.Windows.Forms.TextBox valor2TextBox;
        private System.Windows.Forms.Button somaButton;
        private System.Windows.Forms.Button subtraiButton;
        private System.Windows.Forms.Button multiplicaButton;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Label resultadoLabel;
        private System.Windows.Forms.Button raizButton;
    }
}

