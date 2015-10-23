using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Capitulo05_Lab01
{
    public partial class frmCap05 : Form
    {
        public frmCap05()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCap05_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo encerrar? ", "Alerta",MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private bool ValidarDados()
        {
            if (txtNome.Text.Trim() == "")
            {
                MessageBox.Show("Informe o nome!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNome.Focus();
                txtNome.SelectAll();
                return false;
            }

            if (txtEndereco.Text.Trim() == "")
            {
                MessageBox.Show("Informe o endereço!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtEndereco.Focus();
                txtEndereco.SelectAll();
                return false;
            }

            if (txtCidade.Text.Trim() == "")
            {
                MessageBox.Show("Informe a cidade!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCidade.Focus();
                txtCidade.SelectAll();
                return false;
            }


            if (cboEstadoCivil.Text.Trim() == "")
            {
                MessageBox.Show("Informe o estado civil!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboEstadoCivil.Focus();
                SendKeys.Send("{F4}");
                return false;
            }

            return true;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (!ValidarDados())
            {
                return;
            }

            Cliente cli = new Cliente("C:\\CadastroCliente.txt");
            
            cli.Nome = Geral.RetirarAcentros(txtNome.Text);
            cli.Endereco = Geral.RetirarAcentros(txtEndereco.Text);
            cli.Cidade = Geral.RetirarAcentros(txtCidade.Text);
            cli.EstadoCivil = cboEstadoCivil.Text;

            cli.Gravar();

            MessageBox.Show("Operação concluída com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtNome.Clear();
            txtEndereco.Clear();
            txtCidade.Clear();
            cboEstadoCivil.SelectedIndex = -1;
            txtNome.Focus();
        }
    }
}
