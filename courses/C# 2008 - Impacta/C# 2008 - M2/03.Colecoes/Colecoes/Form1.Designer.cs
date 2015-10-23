namespace Colecoes
{
    partial class frmColecoes
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
            this.btnStack = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnFila = new System.Windows.Forms.Button();
            this.btnHashtable = new System.Windows.Forms.Button();
            this.btnSortedList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStack
            // 
            this.btnStack.Location = new System.Drawing.Point(12, 13);
            this.btnStack.Name = "btnStack";
            this.btnStack.Size = new System.Drawing.Size(75, 23);
            this.btnStack.TabIndex = 0;
            this.btnStack.Text = "Pilha (Stack)";
            this.btnStack.UseVisualStyleBackColor = true;
            this.btnStack.Click += new System.EventHandler(this.btnStack_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 56);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(366, 160);
            this.listBox1.TabIndex = 1;
            // 
            // btnFila
            // 
            this.btnFila.Location = new System.Drawing.Point(102, 13);
            this.btnFila.Name = "btnFila";
            this.btnFila.Size = new System.Drawing.Size(75, 23);
            this.btnFila.TabIndex = 2;
            this.btnFila.Text = "Fila (Queue)";
            this.btnFila.UseVisualStyleBackColor = true;
            this.btnFila.Click += new System.EventHandler(this.btnFila_Click);
            // 
            // btnHashtable
            // 
            this.btnHashtable.Location = new System.Drawing.Point(197, 13);
            this.btnHashtable.Name = "btnHashtable";
            this.btnHashtable.Size = new System.Drawing.Size(75, 23);
            this.btnHashtable.TabIndex = 3;
            this.btnHashtable.Text = "Hashtable";
            this.btnHashtable.UseVisualStyleBackColor = true;
            this.btnHashtable.Click += new System.EventHandler(this.btnHashtable_Click);
            // 
            // btnSortedList
            // 
            this.btnSortedList.Location = new System.Drawing.Point(290, 13);
            this.btnSortedList.Name = "btnSortedList";
            this.btnSortedList.Size = new System.Drawing.Size(75, 23);
            this.btnSortedList.TabIndex = 4;
            this.btnSortedList.Text = "Sorted List";
            this.btnSortedList.UseVisualStyleBackColor = true;
            this.btnSortedList.Click += new System.EventHandler(this.btnSortedList_Click);
            // 
            // frmColecoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 224);
            this.Controls.Add(this.btnSortedList);
            this.Controls.Add(this.btnHashtable);
            this.Controls.Add(this.btnFila);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnStack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmColecoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coleções";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStack;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnFila;
        private System.Windows.Forms.Button btnHashtable;
        private System.Windows.Forms.Button btnSortedList;
    }
}

