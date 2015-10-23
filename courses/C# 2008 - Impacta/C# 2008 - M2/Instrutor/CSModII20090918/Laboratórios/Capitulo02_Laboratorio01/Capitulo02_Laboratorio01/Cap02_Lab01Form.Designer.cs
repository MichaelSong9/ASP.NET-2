namespace Capitulo02_Laboratorio01
{
    partial class Cap02_Lab01Form
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
            this.empilharButton = new System.Windows.Forms.Button();
            this.removerButton = new System.Windows.Forms.Button();
            this.qtdeItensLabel = new System.Windows.Forms.Label();
            this.itemTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // empilharButton
            // 
            this.empilharButton.Location = new System.Drawing.Point(12, 12);
            this.empilharButton.Name = "empilharButton";
            this.empilharButton.Size = new System.Drawing.Size(112, 23);
            this.empilharButton.TabIndex = 1;
            this.empilharButton.Text = "Empilhar";
            this.empilharButton.UseVisualStyleBackColor = true;
            this.empilharButton.Click += new System.EventHandler(this.empilharButton_Click);
            // 
            // removerButton
            // 
            this.removerButton.Enabled = false;
            this.removerButton.Location = new System.Drawing.Point(144, 12);
            this.removerButton.Name = "removerButton";
            this.removerButton.Size = new System.Drawing.Size(112, 23);
            this.removerButton.TabIndex = 2;
            this.removerButton.Text = "Remover";
            this.removerButton.UseVisualStyleBackColor = true;
            this.removerButton.Click += new System.EventHandler(this.removerButton_Click);
            // 
            // qtdeItensLabel
            // 
            this.qtdeItensLabel.AutoSize = true;
            this.qtdeItensLabel.Location = new System.Drawing.Point(9, 65);
            this.qtdeItensLabel.Name = "qtdeItensLabel";
            this.qtdeItensLabel.Size = new System.Drawing.Size(112, 13);
            this.qtdeItensLabel.TabIndex = 3;
            this.qtdeItensLabel.Text = "Nº de itens na Pilha: 0";
            // 
            // itemTextBox
            // 
            this.itemTextBox.Location = new System.Drawing.Point(12, 41);
            this.itemTextBox.Name = "itemTextBox";
            this.itemTextBox.Size = new System.Drawing.Size(244, 20);
            this.itemTextBox.TabIndex = 0;
            // 
            // Cap02_Lab01Form
            // 
            this.AcceptButton = this.empilharButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 87);
            this.Controls.Add(this.itemTextBox);
            this.Controls.Add(this.qtdeItensLabel);
            this.Controls.Add(this.removerButton);
            this.Controls.Add(this.empilharButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Cap02_Lab01Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capítulo 02 – Laboratório 01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button empilharButton;
        private System.Windows.Forms.Button removerButton;
        private System.Windows.Forms.Label qtdeItensLabel;
        private System.Windows.Forms.TextBox itemTextBox;
    }
}