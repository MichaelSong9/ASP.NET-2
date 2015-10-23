namespace Capitulo08_Laboratorio01_Tela
{
    partial class Cap08_Lab01_Tela
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
            this.funcionariosCap081 = new Capitulo08_Laboratorio01.FuncionariosCap08();
            this.SuspendLayout();
            // 
            // funcionariosCap081
            // 
            this.funcionariosCap081.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.funcionariosCap081.BackColor = System.Drawing.SystemColors.Control;
            this.funcionariosCap081.Location = new System.Drawing.Point(12, 12);
            this.funcionariosCap081.MinimumSize = new System.Drawing.Size(480, 260);
            this.funcionariosCap081.Name = "funcionariosCap081";
            this.funcionariosCap081.Size = new System.Drawing.Size(480, 260);
            this.funcionariosCap081.TabIndex = 0;
            // 
            // Cap08_Lab01_Tela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 283);
            this.Controls.Add(this.funcionariosCap081);
            this.Name = "Cap08_Lab01_Tela";
            this.Text = "Capítulo 08 - Laboratório 01 - Tela";
            this.ResumeLayout(false);

        }

        #endregion

        private Capitulo08_Laboratorio01.FuncionariosCap08 funcionariosCap081;
    }
}

