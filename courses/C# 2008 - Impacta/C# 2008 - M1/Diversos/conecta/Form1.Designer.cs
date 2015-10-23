namespace conecta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sqlTextBox = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.sql2TextBox = new System.Windows.Forms.TextBox();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.CarregaButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlTextBox
            // 
            this.sqlTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqlTextBox.Location = new System.Drawing.Point(0, 0);
            this.sqlTextBox.Multiline = true;
            this.sqlTextBox.Name = "sqlTextBox";
            this.sqlTextBox.Size = new System.Drawing.Size(492, 56);
            this.sqlTextBox.TabIndex = 0;
            this.sqlTextBox.Text = "Select * from Customers";
            // 
            // dgv
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(0, 62);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(492, 169);
            this.dgv.TabIndex = 1;
            // 
            // sql2TextBox
            // 
            this.sql2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sql2TextBox.Location = new System.Drawing.Point(0, 250);
            this.sql2TextBox.Multiline = true;
            this.sql2TextBox.Name = "sql2TextBox";
            this.sql2TextBox.Size = new System.Drawing.Size(492, 53);
            this.sql2TextBox.TabIndex = 2;
            this.sql2TextBox.Text = "Select * from Products";
            // 
            // dgv2
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgv2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Location = new System.Drawing.Point(0, 309);
            this.dgv2.Name = "dgv2";
            this.dgv2.Size = new System.Drawing.Size(492, 150);
            this.dgv2.TabIndex = 3;
            // 
            // CarregaButton
            // 
            this.CarregaButton.Location = new System.Drawing.Point(498, 0);
            this.CarregaButton.Name = "CarregaButton";
            this.CarregaButton.Size = new System.Drawing.Size(87, 23);
            this.CarregaButton.TabIndex = 4;
            this.CarregaButton.Text = "Carregar";
            this.CarregaButton.UseVisualStyleBackColor = true;
            this.CarregaButton.Click += new System.EventHandler(this.CarregaButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 471);
            this.Controls.Add(this.CarregaButton);
            this.Controls.Add(this.dgv2);
            this.Controls.Add(this.sql2TextBox);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.sqlTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sqlTextBox;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox sql2TextBox;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.Button CarregaButton;
    }
}

