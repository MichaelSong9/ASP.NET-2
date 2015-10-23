namespace prjObjetos
{
    partial class loopsForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.whileButton = new System.Windows.Forms.Button();
            this.doWhileButton = new System.Windows.Forms.Button();
            this.forButton = new System.Windows.Forms.Button();
            this.forEachButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(313, 243);
            this.textBox1.TabIndex = 0;
            this.textBox1.Tag = "1";
            // 
            // whileButton
            // 
            this.whileButton.Location = new System.Drawing.Point(331, 12);
            this.whileButton.Name = "whileButton";
            this.whileButton.Size = new System.Drawing.Size(192, 77);
            this.whileButton.TabIndex = 1;
            this.whileButton.Text = "While";
            this.whileButton.UseVisualStyleBackColor = true;
            this.whileButton.Click += new System.EventHandler(this.whileButton_Click);
            // 
            // doWhileButton
            // 
            this.doWhileButton.Location = new System.Drawing.Point(331, 95);
            this.doWhileButton.Name = "doWhileButton";
            this.doWhileButton.Size = new System.Drawing.Size(192, 77);
            this.doWhileButton.TabIndex = 2;
            this.doWhileButton.Text = "Do While";
            this.doWhileButton.UseVisualStyleBackColor = true;
            this.doWhileButton.Click += new System.EventHandler(this.doWhileButton_Click);
            // 
            // forButton
            // 
            this.forButton.Location = new System.Drawing.Point(331, 178);
            this.forButton.Name = "forButton";
            this.forButton.Size = new System.Drawing.Size(192, 77);
            this.forButton.TabIndex = 3;
            this.forButton.Text = "For";
            this.forButton.UseVisualStyleBackColor = true;
            this.forButton.Click += new System.EventHandler(this.forButton_Click);
            // 
            // forEachButton
            // 
            this.forEachButton.Location = new System.Drawing.Point(331, 261);
            this.forEachButton.Name = "forEachButton";
            this.forEachButton.Size = new System.Drawing.Size(192, 169);
            this.forEachButton.TabIndex = 4;
            this.forEachButton.Text = "ForEach";
            this.forEachButton.UseVisualStyleBackColor = true;
            this.forEachButton.Click += new System.EventHandler(this.forEachButton_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 261);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(313, 29);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 296);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(313, 29);
            this.textBox3.TabIndex = 6;
            this.textBox3.Tag = "1";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 331);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(313, 29);
            this.textBox4.TabIndex = 7;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(12, 366);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(313, 29);
            this.textBox5.TabIndex = 8;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(12, 401);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(313, 29);
            this.textBox6.TabIndex = 9;
            // 
            // loopsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 445);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.forEachButton);
            this.Controls.Add(this.forButton);
            this.Controls.Add(this.doWhileButton);
            this.Controls.Add(this.whileButton);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "loopsForm";
            this.Text = "loopsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button whileButton;
        private System.Windows.Forms.Button doWhileButton;
        private System.Windows.Forms.Button forButton;
        private System.Windows.Forms.Button forEachButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;

    }
}