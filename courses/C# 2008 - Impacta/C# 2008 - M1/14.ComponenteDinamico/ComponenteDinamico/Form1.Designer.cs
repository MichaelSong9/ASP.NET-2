namespace ComponenteDinamico
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
            this.btnCriarBotaoDinamico = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCriarBotaoDinamico
            // 
            this.btnCriarBotaoDinamico.Location = new System.Drawing.Point(168, 91);
            this.btnCriarBotaoDinamico.Name = "btnCriarBotaoDinamico";
            this.btnCriarBotaoDinamico.Size = new System.Drawing.Size(116, 24);
            this.btnCriarBotaoDinamico.TabIndex = 0;
            this.btnCriarBotaoDinamico.Text = "Criar Botão Dinamico";
            this.btnCriarBotaoDinamico.UseVisualStyleBackColor = true;
            this.btnCriarBotaoDinamico.Click += new System.EventHandler(this.btnCriarBotaoDinamico_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(316, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 24);
            this.button1.TabIndex = 1;
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(316, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 24);
            this.button2.TabIndex = 2;
            this.button2.Text = "?";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 230);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCriarBotaoDinamico);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Componentes Dinâmicos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCriarBotaoDinamico;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

