namespace Generico
{
    partial class genericoForm
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
            this.exemploListBox = new System.Windows.Forms.ListBox();
            this.genericoButton = new System.Windows.Forms.Button();
            this.listButton = new System.Windows.Forms.Button();
            this.classeGenericaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exemploListBox
            // 
            this.exemploListBox.FormattingEnabled = true;
            this.exemploListBox.ItemHeight = 24;
            this.exemploListBox.Location = new System.Drawing.Point(12, 64);
            this.exemploListBox.Name = "exemploListBox";
            this.exemploListBox.Size = new System.Drawing.Size(440, 220);
            this.exemploListBox.TabIndex = 3;
            // 
            // genericoButton
            // 
            this.genericoButton.Location = new System.Drawing.Point(12, 14);
            this.genericoButton.Name = "genericoButton";
            this.genericoButton.Size = new System.Drawing.Size(105, 44);
            this.genericoButton.TabIndex = 2;
            this.genericoButton.Text = "Genérico";
            this.genericoButton.UseVisualStyleBackColor = true;
            this.genericoButton.Click += new System.EventHandler(this.genericoButton_Click);
            // 
            // listButton
            // 
            this.listButton.Location = new System.Drawing.Point(123, 14);
            this.listButton.Name = "listButton";
            this.listButton.Size = new System.Drawing.Size(105, 44);
            this.listButton.TabIndex = 4;
            this.listButton.Text = "List";
            this.listButton.UseVisualStyleBackColor = true;
            this.listButton.Click += new System.EventHandler(this.listButton_Click);
            // 
            // classeGenericaButton
            // 
            this.classeGenericaButton.Location = new System.Drawing.Point(234, 14);
            this.classeGenericaButton.Name = "classeGenericaButton";
            this.classeGenericaButton.Size = new System.Drawing.Size(218, 44);
            this.classeGenericaButton.TabIndex = 5;
            this.classeGenericaButton.Text = "Classe Genérica";
            this.classeGenericaButton.UseVisualStyleBackColor = true;
            this.classeGenericaButton.Click += new System.EventHandler(this.classeGenericaButton_Click);
            // 
            // genericoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 309);
            this.Controls.Add(this.classeGenericaButton);
            this.Controls.Add(this.listButton);
            this.Controls.Add(this.exemploListBox);
            this.Controls.Add(this.genericoButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "genericoForm";
            this.Text = "Genéricos";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ListBox exemploListBox;
        internal System.Windows.Forms.Button genericoButton;
        internal System.Windows.Forms.Button listButton;
        internal System.Windows.Forms.Button classeGenericaButton;
    }
}

