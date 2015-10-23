/*
 * Thiago Cordeiro Alves
 * 26-07-09
 * Impacta - Treinamento de C#2008 Modulo 1
 * Instrutor: Carlos Henrique
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MessageBoxes
{
    public partial class frmMessageBoxes : Form
    {
        public frmMessageBoxes()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bem vindo!", "Objetos - Bem Vindo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExibe_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == string.Empty)
            {
                MessageBox.Show("Digite seu nome!", "Objetos - Nome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
            }
            else
            {
                MessageBox.Show("Bem vindo, \n\n" + txtNome.Text.ToUpper() + "!", "Objetos - Bem vindo!", 
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Text = string.Empty;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            lblNomeDigitado.Text = txtNome.Text.ToUpper();
            lblNomeDigitado.Text = txtNome.Text.Trim();
        }

        private void frmObjetos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.TaskManagerClosing)
            {
                //esse metodo verifica qual foi a razão do fechamento do programa
                //nesse caso, especifiquei o task, mais pra deixar o exemplo
            }

            if (MessageBox.Show("Deseja sair do programa?", "Objetos - Sair", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}