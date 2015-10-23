namespace prjIndexador
{
    partial class indexadorForm
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
            this.siglaComboBox = new System.Windows.Forms.ComboBox();
            this.estadoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // siglaComboBox
            // 
            this.siglaComboBox.FormattingEnabled = true;
            this.siglaComboBox.Location = new System.Drawing.Point(12, 12);
            this.siglaComboBox.Name = "siglaComboBox";
            this.siglaComboBox.Size = new System.Drawing.Size(121, 21);
            this.siglaComboBox.TabIndex = 0;
            this.siglaComboBox.TextChanged += new System.EventHandler(this.siglaComboBox_TextChanged);
            // 
            // estadoLabel
            // 
            this.estadoLabel.AutoSize = true;
            this.estadoLabel.Location = new System.Drawing.Point(139, 15);
            this.estadoLabel.Name = "estadoLabel";
            this.estadoLabel.Size = new System.Drawing.Size(0, 13);
            this.estadoLabel.TabIndex = 1;
            // 
            // indexadorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 73);
            this.Controls.Add(this.estadoLabel);
            this.Controls.Add(this.siglaComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "indexadorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Indexador";
            this.Load += new System.EventHandler(this.indexadorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox siglaComboBox;
        private System.Windows.Forms.Label estadoLabel;
    }
}

