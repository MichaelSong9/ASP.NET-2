namespace Vetores
{
    partial class frmVetores
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
            this.btnExemplo1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnMatriz = new System.Windows.Forms.Button();
            this.btnCalcularMedia = new System.Windows.Forms.Button();
            this.btnMostra = new System.Windows.Forms.Button();
            this.btnCopyTo = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnClone = new System.Windows.Forms.Button();
            this.btnArrayList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExemplo1
            // 
            this.btnExemplo1.Location = new System.Drawing.Point(4, 12);
            this.btnExemplo1.Name = "btnExemplo1";
            this.btnExemplo1.Size = new System.Drawing.Size(92, 23);
            this.btnExemplo1.TabIndex = 0;
            this.btnExemplo1.Text = "Vetor";
            this.btnExemplo1.UseVisualStyleBackColor = true;
            this.btnExemplo1.Click += new System.EventHandler(this.btnExemplo1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(114, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(330, 225);
            this.listBox1.TabIndex = 1;
            // 
            // btnMatriz
            // 
            this.btnMatriz.Location = new System.Drawing.Point(4, 41);
            this.btnMatriz.Name = "btnMatriz";
            this.btnMatriz.Size = new System.Drawing.Size(92, 23);
            this.btnMatriz.TabIndex = 1;
            this.btnMatriz.Text = "Matriz";
            this.btnMatriz.UseVisualStyleBackColor = true;
            this.btnMatriz.Click += new System.EventHandler(this.btnMatriz_Click);
            // 
            // btnCalcularMedia
            // 
            this.btnCalcularMedia.Location = new System.Drawing.Point(4, 70);
            this.btnCalcularMedia.Name = "btnCalcularMedia";
            this.btnCalcularMedia.Size = new System.Drawing.Size(92, 23);
            this.btnCalcularMedia.TabIndex = 2;
            this.btnCalcularMedia.Text = "Calcular Média";
            this.btnCalcularMedia.UseVisualStyleBackColor = true;
            this.btnCalcularMedia.Click += new System.EventHandler(this.btnCalcularMedia_Click);
            // 
            // btnMostra
            // 
            this.btnMostra.Location = new System.Drawing.Point(4, 99);
            this.btnMostra.Name = "btnMostra";
            this.btnMostra.Size = new System.Drawing.Size(92, 23);
            this.btnMostra.TabIndex = 3;
            this.btnMostra.Text = "Mostra";
            this.btnMostra.UseVisualStyleBackColor = true;
            // 
            // btnCopyTo
            // 
            this.btnCopyTo.Location = new System.Drawing.Point(4, 128);
            this.btnCopyTo.Name = "btnCopyTo";
            this.btnCopyTo.Size = new System.Drawing.Size(92, 23);
            this.btnCopyTo.TabIndex = 4;
            this.btnCopyTo.Text = "Copy To";
            this.btnCopyTo.UseVisualStyleBackColor = true;
            this.btnCopyTo.Click += new System.EventHandler(this.btnCopyTo_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(4, 157);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(92, 23);
            this.btnCopy.TabIndex = 5;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnClone
            // 
            this.btnClone.Location = new System.Drawing.Point(4, 186);
            this.btnClone.Name = "btnClone";
            this.btnClone.Size = new System.Drawing.Size(92, 23);
            this.btnClone.TabIndex = 6;
            this.btnClone.Text = "Clone";
            this.btnClone.UseVisualStyleBackColor = true;
            this.btnClone.Click += new System.EventHandler(this.btnClone_Click);
            // 
            // btnArrayList
            // 
            this.btnArrayList.Location = new System.Drawing.Point(4, 215);
            this.btnArrayList.Name = "btnArrayList";
            this.btnArrayList.Size = new System.Drawing.Size(92, 23);
            this.btnArrayList.TabIndex = 7;
            this.btnArrayList.Text = "ArrayList";
            this.btnArrayList.UseVisualStyleBackColor = true;
            this.btnArrayList.Click += new System.EventHandler(this.btnArrayList_Click);
            // 
            // frmVetores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 241);
            this.Controls.Add(this.btnArrayList);
            this.Controls.Add(this.btnClone);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnCopyTo);
            this.Controls.Add(this.btnMostra);
            this.Controls.Add(this.btnCalcularMedia);
            this.Controls.Add(this.btnMatriz);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnExemplo1);
            this.Name = "frmVetores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vetores";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExemplo1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnMatriz;
        private System.Windows.Forms.Button btnCalcularMedia;
        private System.Windows.Forms.Button btnMostra;
        private System.Windows.Forms.Button btnCopyTo;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnClone;
        private System.Windows.Forms.Button btnArrayList;
    }
}

