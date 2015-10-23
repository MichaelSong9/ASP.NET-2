namespace Capitulo3
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
            this.indexadorButton = new System.Windows.Forms.Button();
            this.exemploListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // indexadorButton
            // 
            this.indexadorButton.Location = new System.Drawing.Point(12, 12);
            this.indexadorButton.Name = "indexadorButton";
            this.indexadorButton.Size = new System.Drawing.Size(94, 31);
            this.indexadorButton.TabIndex = 0;
            this.indexadorButton.Text = "Indexador";
            this.indexadorButton.UseVisualStyleBackColor = true;
            this.indexadorButton.Click += new System.EventHandler(this.indexadorButton_Click);
            // 
            // exemploListBox
            // 
            this.exemploListBox.FormattingEnabled = true;
            this.exemploListBox.Location = new System.Drawing.Point(12, 49);
            this.exemploListBox.Name = "exemploListBox";
            this.exemploListBox.Size = new System.Drawing.Size(138, 134);
            this.exemploListBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 195);
            this.Controls.Add(this.exemploListBox);
            this.Controls.Add(this.indexadorButton);
            this.Name = "Form1";
            this.Text = "Capítulo 3 - Indexadores";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button indexadorButton;
        private System.Windows.Forms.ListBox exemploListBox;

    }
}

