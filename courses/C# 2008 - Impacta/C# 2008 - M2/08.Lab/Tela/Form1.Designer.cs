namespace Tela
{
    partial class Form1
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
            this.funcionariosCap081.BackColor = System.Drawing.SystemColors.Control;
            this.funcionariosCap081.Location = new System.Drawing.Point(1, 0);
            this.funcionariosCap081.MinimumSize = new System.Drawing.Size(480, 260);
            this.funcionariosCap081.Name = "funcionariosCap081";
            this.funcionariosCap081.Size = new System.Drawing.Size(480, 260);
            this.funcionariosCap081.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 261);
            this.Controls.Add(this.funcionariosCap081);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserControl Utilizado";
            this.ResumeLayout(false);

        }

        #endregion

        private Capitulo08_Laboratorio01.FuncionariosCap08 funcionariosCap081;

    }
}

