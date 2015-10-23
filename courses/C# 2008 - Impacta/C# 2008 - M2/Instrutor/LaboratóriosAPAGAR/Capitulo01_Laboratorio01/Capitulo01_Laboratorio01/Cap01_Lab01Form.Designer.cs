namespace Capitulo01_Laboratorio01
{
    partial class Cap01_Lab01Form
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
            this.calculadoraButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calculadoraButton
            // 
            this.calculadoraButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.calculadoraButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculadoraButton.Location = new System.Drawing.Point(12, 12);
            this.calculadoraButton.Name = "calculadoraButton";
            this.calculadoraButton.Size = new System.Drawing.Size(317, 67);
            this.calculadoraButton.TabIndex = 0;
            this.calculadoraButton.Text = "Calculadora";
            this.calculadoraButton.UseVisualStyleBackColor = true;
            this.calculadoraButton.Click += new System.EventHandler(this.calculadoraButton_Click);
            // 
            // Cap01_Lab01Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 96);
            this.Controls.Add(this.calculadoraButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Cap01_Lab01Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capítulo 01 – Laboratório 01";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button calculadoraButton;
    }
}

