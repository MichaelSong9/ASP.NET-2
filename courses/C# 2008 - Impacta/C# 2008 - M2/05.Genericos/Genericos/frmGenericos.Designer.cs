namespace Genericos
{
    partial class frmGenericos
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
            this.btnGenericos = new System.Windows.Forms.Button();
            this.listBoxExemplo = new System.Windows.Forms.ListBox();
            this.btnList = new System.Windows.Forms.Button();
            this.btnClasseGenerica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenericos
            // 
            this.btnGenericos.Location = new System.Drawing.Point(12, 6);
            this.btnGenericos.Name = "btnGenericos";
            this.btnGenericos.Size = new System.Drawing.Size(247, 23);
            this.btnGenericos.TabIndex = 0;
            this.btnGenericos.Text = "Genericos";
            this.btnGenericos.UseVisualStyleBackColor = true;
            this.btnGenericos.Click += new System.EventHandler(this.btnGenericos_Click);
            // 
            // listBoxExemplo
            // 
            this.listBoxExemplo.FormattingEnabled = true;
            this.listBoxExemplo.Location = new System.Drawing.Point(9, 93);
            this.listBoxExemplo.Name = "listBoxExemplo";
            this.listBoxExemplo.Size = new System.Drawing.Size(247, 95);
            this.listBoxExemplo.TabIndex = 1;
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(12, 35);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(247, 23);
            this.btnList.TabIndex = 2;
            this.btnList.Text = "<List>";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnClasseGenerica
            // 
            this.btnClasseGenerica.Location = new System.Drawing.Point(12, 64);
            this.btnClasseGenerica.Name = "btnClasseGenerica";
            this.btnClasseGenerica.Size = new System.Drawing.Size(247, 23);
            this.btnClasseGenerica.TabIndex = 3;
            this.btnClasseGenerica.Text = "Classe Generica";
            this.btnClasseGenerica.UseVisualStyleBackColor = true;
            this.btnClasseGenerica.Click += new System.EventHandler(this.btnClasseGenerica_Click);
            // 
            // frmGenericos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 195);
            this.Controls.Add(this.btnClasseGenerica);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.listBoxExemplo);
            this.Controls.Add(this.btnGenericos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmGenericos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Genericos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenericos;
        private System.Windows.Forms.ListBox listBoxExemplo;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnClasseGenerica;
    }
}

