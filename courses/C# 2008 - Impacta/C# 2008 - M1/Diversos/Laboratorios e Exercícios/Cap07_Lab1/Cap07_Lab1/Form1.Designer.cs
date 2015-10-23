namespace Cap07_Lab1
{
    partial class menuForm
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
            this.clientesButton = new System.Windows.Forms.Button();
            this.funcionariosButton = new System.Windows.Forms.Button();
            this.sairButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clientesButton
            // 
            this.clientesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientesButton.ForeColor = System.Drawing.Color.Blue;
            this.clientesButton.Location = new System.Drawing.Point(12, 12);
            this.clientesButton.Name = "clientesButton";
            this.clientesButton.Size = new System.Drawing.Size(245, 23);
            this.clientesButton.TabIndex = 0;
            this.clientesButton.Text = "Clientes";
            this.clientesButton.UseVisualStyleBackColor = true;
            this.clientesButton.Click += new System.EventHandler(this.clientesButton_Click);
            // 
            // funcionariosButton
            // 
            this.funcionariosButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.funcionariosButton.ForeColor = System.Drawing.Color.Blue;
            this.funcionariosButton.Location = new System.Drawing.Point(12, 41);
            this.funcionariosButton.Name = "funcionariosButton";
            this.funcionariosButton.Size = new System.Drawing.Size(245, 23);
            this.funcionariosButton.TabIndex = 1;
            this.funcionariosButton.Text = "Funcionários";
            this.funcionariosButton.UseVisualStyleBackColor = true;
            this.funcionariosButton.Click += new System.EventHandler(this.funcionariosButton_Click);
            // 
            // sairButton
            // 
            this.sairButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sairButton.ForeColor = System.Drawing.Color.Blue;
            this.sairButton.Location = new System.Drawing.Point(12, 70);
            this.sairButton.Name = "sairButton";
            this.sairButton.Size = new System.Drawing.Size(245, 23);
            this.sairButton.TabIndex = 2;
            this.sairButton.Text = "Sair";
            this.sairButton.UseVisualStyleBackColor = true;
            this.sairButton.Click += new System.EventHandler(this.sairButton_Click);
            // 
            // menuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 107);
            this.Controls.Add(this.sairButton);
            this.Controls.Add(this.funcionariosButton);
            this.Controls.Add(this.clientesButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "menuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button clientesButton;
        private System.Windows.Forms.Button funcionariosButton;
        private System.Windows.Forms.Button sairButton;
    }
}

