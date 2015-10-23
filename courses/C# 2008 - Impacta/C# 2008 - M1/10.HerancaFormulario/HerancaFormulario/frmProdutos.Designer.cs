namespace HerancaFormulario
{
    partial class frmProdutos
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
            this.btnRecebe = new System.Windows.Forms.Button();
            this.txtRotulo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRecebe
            // 
            this.btnRecebe.Location = new System.Drawing.Point(133, 13);
            this.btnRecebe.Name = "btnRecebe";
            this.btnRecebe.Size = new System.Drawing.Size(136, 23);
            this.btnRecebe.TabIndex = 2;
            this.btnRecebe.Text = "Expor propriedade";
            this.btnRecebe.UseVisualStyleBackColor = true;
            this.btnRecebe.Click += new System.EventHandler(this.btnRecebe_Click);
            // 
            // txtRotulo
            // 
            this.txtRotulo.Location = new System.Drawing.Point(12, 13);
            this.txtRotulo.Name = "txtRotulo";
            this.txtRotulo.Size = new System.Drawing.Size(100, 20);
            this.txtRotulo.TabIndex = 3;
            // 
            // frmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(459, 151);
            this.Controls.Add(this.txtRotulo);
            this.Controls.Add(this.btnRecebe);
            this.CorFundoLabel = System.Drawing.SystemColors.Info;
            this.Name = "frmProdutos";
            this.Rotulo = "";
            this.Text = "Cadastro de Produtos";
            this.Load += new System.EventHandler(this.frmProdutos_Load);
            this.Controls.SetChildIndex(this.btnRecebe, 0);
            this.Controls.SetChildIndex(this.txtRotulo, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRecebe;
        private System.Windows.Forms.TextBox txtRotulo;
    }
}
