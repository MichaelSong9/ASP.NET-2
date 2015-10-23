namespace ExExtraAula01Extenso
{
    partial class extensoForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.numeroTextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.extensoLabel = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número:";
            // 
            // numeroTextBox
            // 
            this.numeroTextBox.Location = new System.Drawing.Point(65, 6);
            this.numeroTextBox.MaxLength = 2;
            this.numeroTextBox.Name = "numeroTextBox";
            this.numeroTextBox.Size = new System.Drawing.Size(78, 20);
            this.numeroTextBox.TabIndex = 1;
            this.numeroTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeroTextBox_KeyPress);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(155, 7);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(76, 31);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // extensoLabel
            // 
            this.extensoLabel.AutoSize = true;
            this.extensoLabel.Location = new System.Drawing.Point(12, 39);
            this.extensoLabel.Name = "extensoLabel";
            this.extensoLabel.Size = new System.Drawing.Size(70, 13);
            this.extensoLabel.TabIndex = 3;
            this.extensoLabel.Text = "extensoLabel";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(15, 66);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(216, 342);
            this.listBox1.TabIndex = 4;
            // 
            // extensoForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 420);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.extensoLabel);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.numeroTextBox);
            this.Controls.Add(this.label1);
            this.Name = "extensoForm";
            this.Text = "Extenso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numeroTextBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label extensoLabel;
        private System.Windows.Forms.ListBox listBox1;
    }
}

