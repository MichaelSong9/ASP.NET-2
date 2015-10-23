using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrimeiroProjeto
{
    public partial class frmPrimeiroPrograma : Form
    {
        public frmPrimeiroPrograma()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == string.Empty)
            {
                MessageBox.Show("Digite seu nome!", "Primeiro Programa");
            }
            else
            {
                MessageBox.Show("Bem vindo ao primeiro programa, " + txtNome.Text, "Primeiro Programa");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
