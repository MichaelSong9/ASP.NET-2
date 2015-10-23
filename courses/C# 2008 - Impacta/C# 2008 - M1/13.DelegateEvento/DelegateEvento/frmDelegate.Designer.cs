namespace DelegateEvento
{
    partial class frmDelegate
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
            this.btnDelegate = new System.Windows.Forms.Button();
            this.lsvResultado = new System.Windows.Forms.ListView();
            this.btnDelegateAnonimo = new System.Windows.Forms.Button();
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnEvento1 = new System.Windows.Forms.Button();
            this.btnEvento2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDelegate
            // 
            this.btnDelegate.Location = new System.Drawing.Point(12, 12);
            this.btnDelegate.Name = "btnDelegate";
            this.btnDelegate.Size = new System.Drawing.Size(102, 23);
            this.btnDelegate.TabIndex = 0;
            this.btnDelegate.Text = "&Delegate";
            this.btnDelegate.UseVisualStyleBackColor = true;
            this.btnDelegate.Click += new System.EventHandler(this.btnDelegate_Click);
            // 
            // lsvResultado
            // 
            this.lsvResultado.Location = new System.Drawing.Point(129, 12);
            this.lsvResultado.Name = "lsvResultado";
            this.lsvResultado.Size = new System.Drawing.Size(215, 183);
            this.lsvResultado.TabIndex = 1;
            this.lsvResultado.UseCompatibleStateImageBehavior = false;
            // 
            // btnDelegateAnonimo
            // 
            this.btnDelegateAnonimo.Location = new System.Drawing.Point(12, 41);
            this.btnDelegateAnonimo.Name = "btnDelegateAnonimo";
            this.btnDelegateAnonimo.Size = new System.Drawing.Size(102, 23);
            this.btnDelegateAnonimo.TabIndex = 2;
            this.btnDelegateAnonimo.Text = "&Anonimo";
            this.btnDelegateAnonimo.UseVisualStyleBackColor = true;
            this.btnDelegateAnonimo.Click += new System.EventHandler(this.btnDelegateAnonimo_Click);
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.Location = new System.Drawing.Point(12, 72);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(102, 23);
            this.btnSubtrair.TabIndex = 3;
            this.btnSubtrair.Text = "&Subtrair";
            this.btnSubtrair.UseVisualStyleBackColor = true;
            this.btnSubtrair.Click += new System.EventHandler(this.btnSubtrair_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.Location = new System.Drawing.Point(12, 101);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(102, 23);
            this.btnDividir.TabIndex = 4;
            this.btnDividir.Text = "&Dividir";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // btnEvento1
            // 
            this.btnEvento1.Location = new System.Drawing.Point(12, 130);
            this.btnEvento1.Name = "btnEvento1";
            this.btnEvento1.Size = new System.Drawing.Size(102, 23);
            this.btnEvento1.TabIndex = 5;
            this.btnEvento1.Text = "Evento1";
            this.btnEvento1.UseVisualStyleBackColor = true;
            this.btnEvento1.Click += new System.EventHandler(this.btnEvento1_Click);
            // 
            // btnEvento2
            // 
            this.btnEvento2.Location = new System.Drawing.Point(12, 159);
            this.btnEvento2.Name = "btnEvento2";
            this.btnEvento2.Size = new System.Drawing.Size(102, 23);
            this.btnEvento2.TabIndex = 6;
            this.btnEvento2.Text = "Evento2";
            this.btnEvento2.UseVisualStyleBackColor = true;
            this.btnEvento2.Click += new System.EventHandler(this.btnEvento2_Click);
            // 
            // frmDelegate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 203);
            this.Controls.Add(this.btnEvento2);
            this.Controls.Add(this.btnEvento1);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnSubtrair);
            this.Controls.Add(this.btnDelegateAnonimo);
            this.Controls.Add(this.lsvResultado);
            this.Controls.Add(this.btnDelegate);
            this.Name = "frmDelegate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delegates";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDelegate;
        private System.Windows.Forms.ListView lsvResultado;
        private System.Windows.Forms.Button btnDelegateAnonimo;
        private System.Windows.Forms.Button btnSubtrair;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnEvento1;
        private System.Windows.Forms.Button btnEvento2;
    }
}

