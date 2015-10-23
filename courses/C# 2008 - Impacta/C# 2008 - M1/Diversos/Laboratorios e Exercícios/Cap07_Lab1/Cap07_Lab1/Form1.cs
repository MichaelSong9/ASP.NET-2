using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cap07_Lab1
{
    public partial class menuForm : Form
    {
        public menuForm()
        {
            InitializeComponent();
        }

        private void clientesButton_Click(object sender, EventArgs e)
        {
            clientesForm formCli = new clientesForm();
            formCli.ShowDialog();
        }

        private void funcionariosButton_Click(object sender, EventArgs e)
        {
            funcionariosForm formFunc = new funcionariosForm();
            formFunc.ShowDialog();
        }

        private void sairButton_Click(object sender, EventArgs e)
        {
            DialogResult resposta = new DialogResult();
            resposta = MessageBox.Show("Deseja encerrar o sistema?", 
                "Finalizar sistema", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (resposta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}