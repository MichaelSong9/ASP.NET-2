namespace color
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
            this.corLabel = new System.Windows.Forms.Label();
            this.azulLabel = new System.Windows.Forms.Label();
            this.verdeLabel = new System.Windows.Forms.Label();
            this.vermelhoLabel = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.azulHScrollBar = new System.Windows.Forms.HScrollBar();
            this.verdeHScrollBar = new System.Windows.Forms.HScrollBar();
            this.vermelhoHScrollBar = new System.Windows.Forms.HScrollBar();
            this.SuspendLayout();
            // 
            // corLabel
            // 
            this.corLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.corLabel.Location = new System.Drawing.Point(177, 121);
            this.corLabel.Name = "corLabel";
            this.corLabel.Size = new System.Drawing.Size(284, 158);
            this.corLabel.TabIndex = 19;
            // 
            // azulLabel
            // 
            this.azulLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.azulLabel.Location = new System.Drawing.Point(194, 85);
            this.azulLabel.Name = "azulLabel";
            this.azulLabel.Size = new System.Drawing.Size(49, 16);
            this.azulLabel.TabIndex = 18;
            this.azulLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // verdeLabel
            // 
            this.verdeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.verdeLabel.Location = new System.Drawing.Point(194, 59);
            this.verdeLabel.Name = "verdeLabel";
            this.verdeLabel.Size = new System.Drawing.Size(49, 16);
            this.verdeLabel.TabIndex = 17;
            this.verdeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vermelhoLabel
            // 
            this.vermelhoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vermelhoLabel.Location = new System.Drawing.Point(194, 33);
            this.vermelhoLabel.Name = "vermelhoLabel";
            this.vermelhoLabel.Size = new System.Drawing.Size(49, 16);
            this.vermelhoLabel.TabIndex = 16;
            this.vermelhoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label3.Location = new System.Drawing.Point(177, 85);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(11, 16);
            this.Label3.TabIndex = 15;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.Green;
            this.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label2.Location = new System.Drawing.Point(177, 59);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(11, 16);
            this.Label2.TabIndex = 14;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Red;
            this.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label1.Location = new System.Drawing.Point(177, 33);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(11, 16);
            this.Label1.TabIndex = 13;
            // 
            // azulHScrollBar
            // 
            this.azulHScrollBar.LargeChange = 1;
            this.azulHScrollBar.Location = new System.Drawing.Point(246, 85);
            this.azulHScrollBar.Maximum = 255;
            this.azulHScrollBar.Name = "azulHScrollBar";
            this.azulHScrollBar.Size = new System.Drawing.Size(215, 16);
            this.azulHScrollBar.TabIndex = 12;
            this.azulHScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.PreencherCor);
            // 
            // verdeHScrollBar
            // 
            this.verdeHScrollBar.LargeChange = 1;
            this.verdeHScrollBar.Location = new System.Drawing.Point(246, 59);
            this.verdeHScrollBar.Maximum = 255;
            this.verdeHScrollBar.Name = "verdeHScrollBar";
            this.verdeHScrollBar.Size = new System.Drawing.Size(215, 16);
            this.verdeHScrollBar.TabIndex = 11;
            this.verdeHScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.PreencherCor);
            // 
            // vermelhoHScrollBar
            // 
            this.vermelhoHScrollBar.LargeChange = 1;
            this.vermelhoHScrollBar.Location = new System.Drawing.Point(246, 33);
            this.vermelhoHScrollBar.Maximum = 255;
            this.vermelhoHScrollBar.Name = "vermelhoHScrollBar";
            this.vermelhoHScrollBar.Size = new System.Drawing.Size(215, 16);
            this.vermelhoHScrollBar.TabIndex = 10;
            this.vermelhoHScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.PreencherCor);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 312);
            this.Controls.Add(this.corLabel);
            this.Controls.Add(this.azulLabel);
            this.Controls.Add(this.verdeLabel);
            this.Controls.Add(this.vermelhoLabel);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.azulHScrollBar);
            this.Controls.Add(this.verdeHScrollBar);
            this.Controls.Add(this.vermelhoHScrollBar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label corLabel;
        internal System.Windows.Forms.Label azulLabel;
        internal System.Windows.Forms.Label verdeLabel;
        internal System.Windows.Forms.Label vermelhoLabel;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.HScrollBar azulHScrollBar;
        internal System.Windows.Forms.HScrollBar verdeHScrollBar;
        internal System.Windows.Forms.HScrollBar vermelhoHScrollBar;
    }
}

