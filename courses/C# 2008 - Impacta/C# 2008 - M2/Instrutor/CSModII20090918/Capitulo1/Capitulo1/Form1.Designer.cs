namespace Exemplo01Pag12
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
            this.exemploButton = new System.Windows.Forms.Button();
            this.exemploListBox = new System.Windows.Forms.ListBox();
            this.exemplo2Button = new System.Windows.Forms.Button();
            this.exemplo3Button = new System.Windows.Forms.Button();
            this.mediaButton = new System.Windows.Forms.Button();
            this.media2Button = new System.Windows.Forms.Button();
            this.listaButton = new System.Windows.Forms.Button();
            this.copyToButton = new System.Windows.Forms.Button();
            this.copyButton = new System.Windows.Forms.Button();
            this.cloneButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exemploButton
            // 
            this.exemploButton.Location = new System.Drawing.Point(12, 12);
            this.exemploButton.Name = "exemploButton";
            this.exemploButton.Size = new System.Drawing.Size(82, 27);
            this.exemploButton.TabIndex = 0;
            this.exemploButton.Text = "Exemplo";
            this.exemploButton.UseVisualStyleBackColor = true;
            this.exemploButton.Click += new System.EventHandler(this.exemploButton_Click);
            // 
            // exemploListBox
            // 
            this.exemploListBox.FormattingEnabled = true;
            this.exemploListBox.Location = new System.Drawing.Point(12, 45);
            this.exemploListBox.Name = "exemploListBox";
            this.exemploListBox.Size = new System.Drawing.Size(254, 186);
            this.exemploListBox.TabIndex = 1;
            // 
            // exemplo2Button
            // 
            this.exemplo2Button.Location = new System.Drawing.Point(100, 12);
            this.exemplo2Button.Name = "exemplo2Button";
            this.exemplo2Button.Size = new System.Drawing.Size(82, 27);
            this.exemplo2Button.TabIndex = 2;
            this.exemplo2Button.Text = "Exemplo 2";
            this.exemplo2Button.UseVisualStyleBackColor = true;
            this.exemplo2Button.Click += new System.EventHandler(this.exemplo2Button_Click);
            // 
            // exemplo3Button
            // 
            this.exemplo3Button.Location = new System.Drawing.Point(188, 12);
            this.exemplo3Button.Name = "exemplo3Button";
            this.exemplo3Button.Size = new System.Drawing.Size(82, 27);
            this.exemplo3Button.TabIndex = 3;
            this.exemplo3Button.Text = "Exemplo 3";
            this.exemplo3Button.UseVisualStyleBackColor = true;
            this.exemplo3Button.Click += new System.EventHandler(this.exemplo3Button_Click);
            // 
            // mediaButton
            // 
            this.mediaButton.Location = new System.Drawing.Point(276, 12);
            this.mediaButton.Name = "mediaButton";
            this.mediaButton.Size = new System.Drawing.Size(82, 27);
            this.mediaButton.TabIndex = 4;
            this.mediaButton.Text = "Média";
            this.mediaButton.UseVisualStyleBackColor = true;
            this.mediaButton.Click += new System.EventHandler(this.mediaButton_Click);
            // 
            // media2Button
            // 
            this.media2Button.Location = new System.Drawing.Point(276, 45);
            this.media2Button.Name = "media2Button";
            this.media2Button.Size = new System.Drawing.Size(82, 27);
            this.media2Button.TabIndex = 5;
            this.media2Button.Text = "Média 2";
            this.media2Button.UseVisualStyleBackColor = true;
            this.media2Button.Click += new System.EventHandler(this.media2Button_Click);
            // 
            // listaButton
            // 
            this.listaButton.Location = new System.Drawing.Point(276, 78);
            this.listaButton.Name = "listaButton";
            this.listaButton.Size = new System.Drawing.Size(82, 27);
            this.listaButton.TabIndex = 6;
            this.listaButton.Text = "Lista";
            this.listaButton.UseVisualStyleBackColor = true;
            this.listaButton.Click += new System.EventHandler(this.listaButton_Click);
            // 
            // copyToButton
            // 
            this.copyToButton.Location = new System.Drawing.Point(276, 111);
            this.copyToButton.Name = "copyToButton";
            this.copyToButton.Size = new System.Drawing.Size(82, 27);
            this.copyToButton.TabIndex = 7;
            this.copyToButton.Text = "CopyTo";
            this.copyToButton.UseVisualStyleBackColor = true;
            this.copyToButton.Click += new System.EventHandler(this.copyToButton_Click);
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(276, 144);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(82, 27);
            this.copyButton.TabIndex = 8;
            this.copyButton.Text = "Copy";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // cloneButton
            // 
            this.cloneButton.Location = new System.Drawing.Point(276, 177);
            this.cloneButton.Name = "cloneButton";
            this.cloneButton.Size = new System.Drawing.Size(82, 27);
            this.cloneButton.TabIndex = 9;
            this.cloneButton.Text = "Clone";
            this.cloneButton.UseVisualStyleBackColor = true;
            this.cloneButton.Click += new System.EventHandler(this.cloneButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 238);
            this.Controls.Add(this.cloneButton);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.copyToButton);
            this.Controls.Add(this.listaButton);
            this.Controls.Add(this.media2Button);
            this.Controls.Add(this.mediaButton);
            this.Controls.Add(this.exemplo3Button);
            this.Controls.Add(this.exemplo2Button);
            this.Controls.Add(this.exemploListBox);
            this.Controls.Add(this.exemploButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exemploButton;
        private System.Windows.Forms.ListBox exemploListBox;
        private System.Windows.Forms.Button exemplo2Button;
        private System.Windows.Forms.Button exemplo3Button;
        private System.Windows.Forms.Button mediaButton;
        private System.Windows.Forms.Button media2Button;
        private System.Windows.Forms.Button listaButton;
        private System.Windows.Forms.Button copyToButton;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.Button cloneButton;
    }
}

