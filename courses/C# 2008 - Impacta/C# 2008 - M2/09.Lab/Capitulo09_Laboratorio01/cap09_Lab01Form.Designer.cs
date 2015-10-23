namespace Capitulo09_Laboratorio01
{
    partial class cap09_Lab01Form
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
            this.inserirButton = new System.Windows.Forms.Button();
            this.mensagemButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // inserirButton
            // 
            this.inserirButton.Location = new System.Drawing.Point(12, 12);
            this.inserirButton.Name = "inserirButton";
            this.inserirButton.Size = new System.Drawing.Size(75, 23);
            this.inserirButton.TabIndex = 0;
            this.inserirButton.Text = "Inserir";
            this.inserirButton.UseVisualStyleBackColor = true;
            this.inserirButton.Click += new System.EventHandler(this.inserirButton_Click);
            // 
            // mensagemButton
            // 
            this.mensagemButton.Location = new System.Drawing.Point(93, 12);
            this.mensagemButton.Name = "mensagemButton";
            this.mensagemButton.Size = new System.Drawing.Size(75, 23);
            this.mensagemButton.TabIndex = 1;
            this.mensagemButton.Text = "Mensagem";
            this.mensagemButton.UseVisualStyleBackColor = true;
            this.mensagemButton.Click += new System.EventHandler(this.mensagemButton_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // cap09_Lab01Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 49);
            this.Controls.Add(this.mensagemButton);
            this.Controls.Add(this.inserirButton);
            this.Name = "cap09_Lab01Form";
            this.Text = "Capítulo 9 – Laboratório 1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button inserirButton;
        private System.Windows.Forms.Button mensagemButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

