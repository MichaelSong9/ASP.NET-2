namespace Colecoes
{
    partial class colecoesForm
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
            this.stackButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.queueButton = new System.Windows.Forms.Button();
            this.hashtableButton = new System.Windows.Forms.Button();
            this.sortedListButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // stackButton
            // 
            this.stackButton.Location = new System.Drawing.Point(12, 12);
            this.stackButton.Name = "stackButton";
            this.stackButton.Size = new System.Drawing.Size(83, 36);
            this.stackButton.TabIndex = 0;
            this.stackButton.Text = "Stack";
            this.stackButton.UseVisualStyleBackColor = true;
            this.stackButton.Click += new System.EventHandler(this.stackButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 54);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(350, 212);
            this.listBox1.TabIndex = 1;
            // 
            // queueButton
            // 
            this.queueButton.Location = new System.Drawing.Point(101, 12);
            this.queueButton.Name = "queueButton";
            this.queueButton.Size = new System.Drawing.Size(83, 36);
            this.queueButton.TabIndex = 2;
            this.queueButton.Text = "Queue";
            this.queueButton.UseVisualStyleBackColor = true;
            this.queueButton.Click += new System.EventHandler(this.queueButton_Click);
            // 
            // hashtableButton
            // 
            this.hashtableButton.Location = new System.Drawing.Point(190, 12);
            this.hashtableButton.Name = "hashtableButton";
            this.hashtableButton.Size = new System.Drawing.Size(83, 36);
            this.hashtableButton.TabIndex = 3;
            this.hashtableButton.Text = "Hashtable";
            this.hashtableButton.UseVisualStyleBackColor = true;
            this.hashtableButton.Click += new System.EventHandler(this.hashtableButton_Click);
            // 
            // sortedListButton
            // 
            this.sortedListButton.Location = new System.Drawing.Point(279, 12);
            this.sortedListButton.Name = "sortedListButton";
            this.sortedListButton.Size = new System.Drawing.Size(83, 36);
            this.sortedListButton.TabIndex = 4;
            this.sortedListButton.Text = "SortedList";
            this.sortedListButton.UseVisualStyleBackColor = true;
            this.sortedListButton.Click += new System.EventHandler(this.sortedListButton_Click);
            // 
            // colecoesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 273);
            this.Controls.Add(this.sortedListButton);
            this.Controls.Add(this.hashtableButton);
            this.Controls.Add(this.queueButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.stackButton);
            this.Name = "colecoesForm";
            this.Text = "Coleções";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button stackButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button queueButton;
        private System.Windows.Forms.Button hashtableButton;
        private System.Windows.Forms.Button sortedListButton;
    }
}

