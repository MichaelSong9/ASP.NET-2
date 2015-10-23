namespace Classes
{
    partial class frmClasses
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
            this.btnPessoa = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.btnParcial = new System.Windows.Forms.Button();
            this.lstParcial = new System.Windows.Forms.ListBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnProduto = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnLivro = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnExtensao = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPessoa
            // 
            this.btnPessoa.Location = new System.Drawing.Point(74, 59);
            this.btnPessoa.Name = "btnPessoa";
            this.btnPessoa.Size = new System.Drawing.Size(198, 23);
            this.btnPessoa.TabIndex = 2;
            this.btnPessoa.Text = "&Pessoa (Sobrecarga)";
            this.btnPessoa.UseVisualStyleBackColor = true;
            this.btnPessoa.Click += new System.EventHandler(this.btnPessoa_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(74, 7);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(198, 20);
            this.txtNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Idade:";
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(74, 33);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(198, 20);
            this.txtIdade.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(13, 101);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(0, 13);
            this.lblNome.TabIndex = 5;
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(19, 96);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(0, 13);
            this.lblIdade.TabIndex = 6;
            // 
            // btnParcial
            // 
            this.btnParcial.Location = new System.Drawing.Point(6, 3);
            this.btnParcial.Name = "btnParcial";
            this.btnParcial.Size = new System.Drawing.Size(266, 23);
            this.btnParcial.TabIndex = 7;
            this.btnParcial.Text = "Calculo - Partial Class";
            this.btnParcial.UseVisualStyleBackColor = true;
            this.btnParcial.Click += new System.EventHandler(this.btnParcial_Click);
            // 
            // lstParcial
            // 
            this.lstParcial.FormattingEnabled = true;
            this.lstParcial.Location = new System.Drawing.Point(6, 32);
            this.lstParcial.Name = "lstParcial";
            this.lstParcial.Size = new System.Drawing.Size(266, 95);
            this.lstParcial.TabIndex = 8;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 270);
            this.splitter1.TabIndex = 9;
            this.splitter1.TabStop = false;
            // 
            // btnProduto
            // 
            this.btnProduto.Location = new System.Drawing.Point(14, 6);
            this.btnProduto.Name = "btnProduto";
            this.btnProduto.Size = new System.Drawing.Size(129, 23);
            this.btnProduto.TabIndex = 10;
            this.btnProduto.Text = "Produto";
            this.btnProduto.UseVisualStyleBackColor = true;
            this.btnProduto.Click += new System.EventHandler(this.btnProduto_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCliente);
            this.panel1.Controls.Add(this.btnLivro);
            this.panel1.Controls.Add(this.btnProduto);
            this.panel1.Location = new System.Drawing.Point(306, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 110);
            this.panel1.TabIndex = 11;
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(13, 64);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(129, 23);
            this.btnCliente.TabIndex = 12;
            this.btnCliente.Text = "Cliente - Struct/Enum";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnLivro
            // 
            this.btnLivro.Location = new System.Drawing.Point(13, 35);
            this.btnLivro.Name = "btnLivro";
            this.btnLivro.Size = new System.Drawing.Size(129, 23);
            this.btnLivro.TabIndex = 11;
            this.btnLivro.Text = "Livro";
            this.btnLivro.UseVisualStyleBackColor = true;
            this.btnLivro.Click += new System.EventHandler(this.btnLivro_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnPessoa);
            this.panel2.Controls.Add(this.txtNome);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblIdade);
            this.panel2.Controls.Add(this.txtIdade);
            this.panel2.Location = new System.Drawing.Point(8, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 110);
            this.panel2.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lstParcial);
            this.panel3.Controls.Add(this.btnParcial);
            this.panel3.Location = new System.Drawing.Point(9, 120);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(292, 147);
            this.panel3.TabIndex = 13;
            // 
            // btnExtensao
            // 
            this.btnExtensao.Location = new System.Drawing.Point(9, 3);
            this.btnExtensao.Name = "btnExtensao";
            this.btnExtensao.Size = new System.Drawing.Size(140, 23);
            this.btnExtensao.TabIndex = 14;
            this.btnExtensao.Text = "Classe de &Extensão";
            this.btnExtensao.UseVisualStyleBackColor = true;
            this.btnExtensao.Click += new System.EventHandler(this.btnExtensao_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(8, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(140, 95);
            this.listBox1.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnExtensao);
            this.panel4.Controls.Add(this.listBox1);
            this.panel4.Location = new System.Drawing.Point(307, 120);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(158, 147);
            this.panel4.TabIndex = 17;
            // 
            // frmClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 270);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.lblNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmClasses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "6.Classes";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPessoa;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Button btnParcial;
        private System.Windows.Forms.ListBox lstParcial;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btnProduto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnLivro;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnExtensao;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel4;
    }
}