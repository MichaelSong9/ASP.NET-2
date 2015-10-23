namespace Vetores
{
    partial class vetoresForm
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
            this.exemplo1Button = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.exemplo2Button = new System.Windows.Forms.Button();
            this.mediaButton = new System.Windows.Forms.Button();
            this.calcularSomaButton = new System.Windows.Forms.Button();
            this.media2Button = new System.Windows.Forms.Button();
            this.mostraButton = new System.Windows.Forms.Button();
            this.copyToButton = new System.Windows.Forms.Button();
            this.copyButton = new System.Windows.Forms.Button();
            this.cloneButton = new System.Windows.Forms.Button();
            this.arrayListButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exemplo1Button
            // 
            this.exemplo1Button.Location = new System.Drawing.Point(12, 11);
            this.exemplo1Button.Name = "exemplo1Button";
            this.exemplo1Button.Size = new System.Drawing.Size(75, 23);
            this.exemplo1Button.TabIndex = 0;
            this.exemplo1Button.Text = "Exemplo 1";
            this.exemplo1Button.UseVisualStyleBackColor = true;
            this.exemplo1Button.Click += new System.EventHandler(this.exemplo1Button_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 40);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(380, 199);
            this.listBox1.TabIndex = 1;
            // 
            // exemplo2Button
            // 
            this.exemplo2Button.Location = new System.Drawing.Point(93, 12);
            this.exemplo2Button.Name = "exemplo2Button";
            this.exemplo2Button.Size = new System.Drawing.Size(75, 23);
            this.exemplo2Button.TabIndex = 2;
            this.exemplo2Button.Text = "Exemplo 2";
            this.exemplo2Button.UseVisualStyleBackColor = true;
            this.exemplo2Button.Click += new System.EventHandler(this.exemplo2Button_Click);
            // 
            // mediaButton
            // 
            this.mediaButton.Location = new System.Drawing.Point(174, 12);
            this.mediaButton.Name = "mediaButton";
            this.mediaButton.Size = new System.Drawing.Size(106, 23);
            this.mediaButton.TabIndex = 3;
            this.mediaButton.Text = "Calcular Média";
            this.mediaButton.UseVisualStyleBackColor = true;
            this.mediaButton.Click += new System.EventHandler(this.mediaButton_Click);
            // 
            // calcularSomaButton
            // 
            this.calcularSomaButton.Location = new System.Drawing.Point(286, 12);
            this.calcularSomaButton.Name = "calcularSomaButton";
            this.calcularSomaButton.Size = new System.Drawing.Size(106, 23);
            this.calcularSomaButton.TabIndex = 4;
            this.calcularSomaButton.Text = "Calcular Soma";
            this.calcularSomaButton.UseVisualStyleBackColor = true;
            this.calcularSomaButton.Click += new System.EventHandler(this.calcularSomaButton_Click);
            // 
            // media2Button
            // 
            this.media2Button.Location = new System.Drawing.Point(398, 12);
            this.media2Button.Name = "media2Button";
            this.media2Button.Size = new System.Drawing.Size(106, 23);
            this.media2Button.TabIndex = 5;
            this.media2Button.Text = "Calcular Média 2";
            this.media2Button.UseVisualStyleBackColor = true;
            this.media2Button.Click += new System.EventHandler(this.media2Button_Click);
            // 
            // mostraButton
            // 
            this.mostraButton.Location = new System.Drawing.Point(398, 41);
            this.mostraButton.Name = "mostraButton";
            this.mostraButton.Size = new System.Drawing.Size(106, 23);
            this.mostraButton.TabIndex = 6;
            this.mostraButton.Text = "Mostra";
            this.mostraButton.UseVisualStyleBackColor = true;
            this.mostraButton.Click += new System.EventHandler(this.mostraButton_Click);
            // 
            // copyToButton
            // 
            this.copyToButton.Location = new System.Drawing.Point(398, 80);
            this.copyToButton.Name = "copyToButton";
            this.copyToButton.Size = new System.Drawing.Size(106, 23);
            this.copyToButton.TabIndex = 7;
            this.copyToButton.Text = "CopyTo";
            this.copyToButton.UseVisualStyleBackColor = true;
            this.copyToButton.Click += new System.EventHandler(this.copyToButton_Click);
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(398, 109);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(106, 23);
            this.copyButton.TabIndex = 8;
            this.copyButton.Text = "Copy";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // cloneButton
            // 
            this.cloneButton.Location = new System.Drawing.Point(398, 138);
            this.cloneButton.Name = "cloneButton";
            this.cloneButton.Size = new System.Drawing.Size(106, 23);
            this.cloneButton.TabIndex = 9;
            this.cloneButton.Text = "Clone";
            this.cloneButton.UseVisualStyleBackColor = true;
            this.cloneButton.Click += new System.EventHandler(this.cloneButton_Click);
            // 
            // arrayListButton
            // 
            this.arrayListButton.Location = new System.Drawing.Point(398, 167);
            this.arrayListButton.Name = "arrayListButton";
            this.arrayListButton.Size = new System.Drawing.Size(106, 23);
            this.arrayListButton.TabIndex = 10;
            this.arrayListButton.Text = "ArrayList";
            this.arrayListButton.UseVisualStyleBackColor = true;
            this.arrayListButton.Click += new System.EventHandler(this.arrayListButton_Click);
            // 
            // vetoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 273);
            this.Controls.Add(this.arrayListButton);
            this.Controls.Add(this.cloneButton);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.copyToButton);
            this.Controls.Add(this.mostraButton);
            this.Controls.Add(this.media2Button);
            this.Controls.Add(this.calcularSomaButton);
            this.Controls.Add(this.mediaButton);
            this.Controls.Add(this.exemplo2Button);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.exemplo1Button);
            this.Name = "vetoresForm";
            this.Text = "Vetores";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exemplo1Button;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button exemplo2Button;
        private System.Windows.Forms.Button mediaButton;
        private System.Windows.Forms.Button calcularSomaButton;
        private System.Windows.Forms.Button media2Button;
        private System.Windows.Forms.Button mostraButton;
        private System.Windows.Forms.Button copyToButton;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.Button cloneButton;
        private System.Windows.Forms.Button arrayListButton;
    }
}

