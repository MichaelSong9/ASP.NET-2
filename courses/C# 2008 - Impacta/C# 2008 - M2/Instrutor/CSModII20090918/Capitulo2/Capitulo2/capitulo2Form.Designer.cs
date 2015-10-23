namespace Capitulo2
{
    partial class capitulo2Form
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
            this.exemploListBox = new System.Windows.Forms.ListBox();
            this.queueButton = new System.Windows.Forms.Button();
            this.hashtableButton = new System.Windows.Forms.Button();
            this.sortedListButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // stackButton
            // 
            this.stackButton.Location = new System.Drawing.Point(12, 12);
            this.stackButton.Name = "stackButton";
            this.stackButton.Size = new System.Drawing.Size(62, 23);
            this.stackButton.TabIndex = 0;
            this.stackButton.Text = "Stack";
            this.stackButton.UseVisualStyleBackColor = true;
            this.stackButton.Click += new System.EventHandler(this.stackButton_Click);
            // 
            // exemploListBox
            // 
            this.exemploListBox.FormattingEnabled = true;
            this.exemploListBox.Location = new System.Drawing.Point(12, 41);
            this.exemploListBox.Name = "exemploListBox";
            this.exemploListBox.Size = new System.Drawing.Size(286, 186);
            this.exemploListBox.TabIndex = 1;
            // 
            // queueButton
            // 
            this.queueButton.Location = new System.Drawing.Point(80, 12);
            this.queueButton.Name = "queueButton";
            this.queueButton.Size = new System.Drawing.Size(60, 23);
            this.queueButton.TabIndex = 2;
            this.queueButton.Text = "Queue";
            this.queueButton.UseVisualStyleBackColor = true;
            this.queueButton.Click += new System.EventHandler(this.queueButton_Click);
            // 
            // hashtableButton
            // 
            this.hashtableButton.Location = new System.Drawing.Point(146, 12);
            this.hashtableButton.Name = "hashtableButton";
            this.hashtableButton.Size = new System.Drawing.Size(73, 23);
            this.hashtableButton.TabIndex = 3;
            this.hashtableButton.Text = "Hashtable";
            this.hashtableButton.UseVisualStyleBackColor = true;
            this.hashtableButton.Click += new System.EventHandler(this.hashtableButton_Click);
            // 
            // sortedListButton
            // 
            this.sortedListButton.Location = new System.Drawing.Point(225, 12);
            this.sortedListButton.Name = "sortedListButton";
            this.sortedListButton.Size = new System.Drawing.Size(73, 23);
            this.sortedListButton.TabIndex = 4;
            this.sortedListButton.Text = "SortedList";
            this.sortedListButton.UseVisualStyleBackColor = true;
            this.sortedListButton.Click += new System.EventHandler(this.sortedListButton_Click);
            // 
            // capitulo2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 240);
            this.Controls.Add(this.sortedListButton);
            this.Controls.Add(this.hashtableButton);
            this.Controls.Add(this.queueButton);
            this.Controls.Add(this.exemploListBox);
            this.Controls.Add(this.stackButton);
            this.Name = "capitulo2Form";
            this.Text = "Capítulo 2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button stackButton;
        private System.Windows.Forms.ListBox exemploListBox;
        private System.Windows.Forms.Button queueButton;
        private System.Windows.Forms.Button hashtableButton;
        private System.Windows.Forms.Button sortedListButton;

    }
}

