namespace GarbageCollector
{
    partial class frmGarbageCollector
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
            this.btnDestructor = new System.Windows.Forms.Button();
            this.btnDispose = new System.Windows.Forms.Button();
            this.btnUsing = new System.Windows.Forms.Button();
            this.lsv = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnDestructor
            // 
            this.btnDestructor.Location = new System.Drawing.Point(3, 12);
            this.btnDestructor.Name = "btnDestructor";
            this.btnDestructor.Size = new System.Drawing.Size(75, 23);
            this.btnDestructor.TabIndex = 0;
            this.btnDestructor.Text = "&Destructor";
            this.btnDestructor.UseVisualStyleBackColor = true;
            this.btnDestructor.Click += new System.EventHandler(this.btnDestructor_Click);
            // 
            // btnDispose
            // 
            this.btnDispose.Location = new System.Drawing.Point(3, 50);
            this.btnDispose.Name = "btnDispose";
            this.btnDispose.Size = new System.Drawing.Size(75, 23);
            this.btnDispose.TabIndex = 1;
            this.btnDispose.Text = "D&ispose";
            this.btnDispose.UseVisualStyleBackColor = true;
            this.btnDispose.Click += new System.EventHandler(this.btnDispose_Click);
            // 
            // btnUsing
            // 
            this.btnUsing.Location = new System.Drawing.Point(3, 90);
            this.btnUsing.Name = "btnUsing";
            this.btnUsing.Size = new System.Drawing.Size(75, 23);
            this.btnUsing.TabIndex = 2;
            this.btnUsing.Text = "Using";
            this.btnUsing.UseVisualStyleBackColor = true;
            this.btnUsing.Click += new System.EventHandler(this.btnUsing_Click);
            // 
            // lsv
            // 
            this.lsv.FormattingEnabled = true;
            this.lsv.Location = new System.Drawing.Point(111, 12);
            this.lsv.Name = "lsv";
            this.lsv.Size = new System.Drawing.Size(192, 134);
            this.lsv.TabIndex = 3;
            // 
            // frmGarbageCollector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 154);
            this.Controls.Add(this.lsv);
            this.Controls.Add(this.btnUsing);
            this.Controls.Add(this.btnDispose);
            this.Controls.Add(this.btnDestructor);
            this.Name = "frmGarbageCollector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Garbage Collector";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDestructor;
        private System.Windows.Forms.Button btnDispose;
        private System.Windows.Forms.Button btnUsing;
        private System.Windows.Forms.ListBox lsv;
    }
}

