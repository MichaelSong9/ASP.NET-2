namespace Capitulo4
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
            this.genericoButton = new System.Windows.Forms.Button();
            this.exemploListBox = new System.Windows.Forms.ListBox();
            this.listButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.classeGenericaButton = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // genericoButton
            // 
            this.genericoButton.Location = new System.Drawing.Point(12, 12);
            this.genericoButton.Name = "genericoButton";
            this.genericoButton.Size = new System.Drawing.Size(75, 23);
            this.genericoButton.TabIndex = 0;
            this.genericoButton.Text = "Genérico";
            this.genericoButton.UseVisualStyleBackColor = true;
            this.genericoButton.Click += new System.EventHandler(this.genericoButton_Click);
            // 
            // exemploListBox
            // 
            this.exemploListBox.FormattingEnabled = true;
            this.exemploListBox.Location = new System.Drawing.Point(12, 41);
            this.exemploListBox.Name = "exemploListBox";
            this.exemploListBox.Size = new System.Drawing.Size(125, 56);
            this.exemploListBox.TabIndex = 1;
            // 
            // listButton
            // 
            this.listButton.Location = new System.Drawing.Point(163, 12);
            this.listButton.Name = "listButton";
            this.listButton.Size = new System.Drawing.Size(75, 23);
            this.listButton.TabIndex = 2;
            this.listButton.Text = "List";
            this.listButton.UseVisualStyleBackColor = true;
            this.listButton.Click += new System.EventHandler(this.listButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(163, 41);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(125, 56);
            this.listBox1.TabIndex = 3;
            // 
            // classeGenericaButton
            // 
            this.classeGenericaButton.Location = new System.Drawing.Point(300, 12);
            this.classeGenericaButton.Name = "classeGenericaButton";
            this.classeGenericaButton.Size = new System.Drawing.Size(125, 23);
            this.classeGenericaButton.TabIndex = 4;
            this.classeGenericaButton.Text = "Classe Genérica";
            this.classeGenericaButton.UseVisualStyleBackColor = true;
            this.classeGenericaButton.Click += new System.EventHandler(this.classeGenericaButton_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(300, 40);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(314, 56);
            this.listBox2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 105);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.classeGenericaButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.listButton);
            this.Controls.Add(this.exemploListBox);
            this.Controls.Add(this.genericoButton);
            this.Name = "Form1";
            this.Text = "Capítulo 4 - Genéricos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button genericoButton;
        private System.Windows.Forms.ListBox exemploListBox;
        private System.Windows.Forms.Button listButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button classeGenericaButton;
        private System.Windows.Forms.ListBox listBox2;
    }
}

