namespace prjGenerics
{
    partial class genericsForm
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
            this.carregarButton = new System.Windows.Forms.Button();
            this.descarregarButton = new System.Windows.Forms.Button();
            this.itensListBox = new System.Windows.Forms.ListBox();
            this.itemTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // carregarButton
            // 
            this.carregarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carregarButton.Location = new System.Drawing.Point(12, 12);
            this.carregarButton.Name = "carregarButton";
            this.carregarButton.Size = new System.Drawing.Size(121, 33);
            this.carregarButton.TabIndex = 0;
            this.carregarButton.Text = "Carregar";
            this.carregarButton.UseVisualStyleBackColor = true;
            this.carregarButton.Click += new System.EventHandler(this.carregarButton_Click);
            // 
            // descarregarButton
            // 
            this.descarregarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descarregarButton.Location = new System.Drawing.Point(12, 53);
            this.descarregarButton.Name = "descarregarButton";
            this.descarregarButton.Size = new System.Drawing.Size(121, 33);
            this.descarregarButton.TabIndex = 1;
            this.descarregarButton.Text = "Descarregar";
            this.descarregarButton.UseVisualStyleBackColor = true;
            this.descarregarButton.Click += new System.EventHandler(this.descarregarButton_Click);
            // 
            // itensListBox
            // 
            this.itensListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itensListBox.FormattingEnabled = true;
            this.itensListBox.ItemHeight = 20;
            this.itensListBox.Location = new System.Drawing.Point(150, 55);
            this.itensListBox.Name = "itensListBox";
            this.itensListBox.Size = new System.Drawing.Size(181, 184);
            this.itensListBox.TabIndex = 3;
            // 
            // itemTextBox
            // 
            this.itemTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemTextBox.Location = new System.Drawing.Point(150, 12);
            this.itemTextBox.Name = "itemTextBox";
            this.itemTextBox.Size = new System.Drawing.Size(181, 29);
            this.itemTextBox.TabIndex = 4;
            // 
            // genericsForm
            // 
            this.AcceptButton = this.carregarButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 251);
            this.Controls.Add(this.itemTextBox);
            this.Controls.Add(this.itensListBox);
            this.Controls.Add(this.descarregarButton);
            this.Controls.Add(this.carregarButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "genericsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generics";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button carregarButton;
        private System.Windows.Forms.Button descarregarButton;
        private System.Windows.Forms.ListBox itensListBox;
        private System.Windows.Forms.TextBox itemTextBox;
    }
}

