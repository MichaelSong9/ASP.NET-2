namespace PassagemParametros
{
    partial class frmTipos
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
            this.btnValor = new System.Windows.Forms.Button();
            this.btnReferencia = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnPassagemValor = new System.Windows.Forms.Button();
            this.btnPassagemReferencia = new System.Windows.Forms.Button();
            this.btnParametrosOutput = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnValor
            // 
            this.btnValor.Location = new System.Drawing.Point(12, 15);
            this.btnValor.Name = "btnValor";
            this.btnValor.Size = new System.Drawing.Size(136, 23);
            this.btnValor.TabIndex = 0;
            this.btnValor.Text = "&Valor";
            this.btnValor.UseVisualStyleBackColor = true;
            this.btnValor.Click += new System.EventHandler(this.btnValor_Click);
            // 
            // btnReferencia
            // 
            this.btnReferencia.Location = new System.Drawing.Point(12, 44);
            this.btnReferencia.Name = "btnReferencia";
            this.btnReferencia.Size = new System.Drawing.Size(136, 23);
            this.btnReferencia.TabIndex = 1;
            this.btnReferencia.Text = "Referência";
            this.btnReferencia.UseVisualStyleBackColor = true;
            this.btnReferencia.Click += new System.EventHandler(this.btnReferencia_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(164, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(196, 147);
            this.listBox1.TabIndex = 2;
            // 
            // btnPassagemValor
            // 
            this.btnPassagemValor.Location = new System.Drawing.Point(13, 73);
            this.btnPassagemValor.Name = "btnPassagemValor";
            this.btnPassagemValor.Size = new System.Drawing.Size(135, 23);
            this.btnPassagemValor.TabIndex = 3;
            this.btnPassagemValor.Text = "Passagem Valor";
            this.btnPassagemValor.UseVisualStyleBackColor = true;
            this.btnPassagemValor.Click += new System.EventHandler(this.btnPassagemValor_Click);
            // 
            // btnPassagemReferencia
            // 
            this.btnPassagemReferencia.Location = new System.Drawing.Point(13, 102);
            this.btnPassagemReferencia.Name = "btnPassagemReferencia";
            this.btnPassagemReferencia.Size = new System.Drawing.Size(135, 23);
            this.btnPassagemReferencia.TabIndex = 4;
            this.btnPassagemReferencia.Text = "Passagem Referência";
            this.btnPassagemReferencia.UseVisualStyleBackColor = true;
            this.btnPassagemReferencia.Click += new System.EventHandler(this.btnPassagemReferencia_Click);
            // 
            // btnParametrosOutput
            // 
            this.btnParametrosOutput.Location = new System.Drawing.Point(13, 136);
            this.btnParametrosOutput.Name = "btnParametrosOutput";
            this.btnParametrosOutput.Size = new System.Drawing.Size(135, 23);
            this.btnParametrosOutput.TabIndex = 5;
            this.btnParametrosOutput.Text = "Parametros Output";
            this.btnParametrosOutput.UseVisualStyleBackColor = true;
            this.btnParametrosOutput.Click += new System.EventHandler(this.btnParametrosOutput_Click);
            // 
            // frmTipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 205);
            this.Controls.Add(this.btnParametrosOutput);
            this.Controls.Add(this.btnPassagemReferencia);
            this.Controls.Add(this.btnPassagemValor);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnReferencia);
            this.Controls.Add(this.btnValor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmTipos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Passagem de parâmetro por valor e referência";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnValor;
        private System.Windows.Forms.Button btnReferencia;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnPassagemValor;
        private System.Windows.Forms.Button btnPassagemReferencia;
        private System.Windows.Forms.Button btnParametrosOutput;
    }
}

