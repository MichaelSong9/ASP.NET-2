using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Capitulo06_Lab01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Veiculo carro = new Veiculo("C:\\Concessionaria.txt");

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo encerrar?", "Alerta",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (!ValidarDados())
            {
                return;
            }

            carro.Placa = txtPlaca.Text;
            carro.Modelo = txtModelo.Text;
            carro.Cor = txtCor.Text;
            carro.Ano = txtAno.Text;
            carro.Som = chkSom.Checked;
            carro.Ar = chkAr.Checked;

            carro.Gravar();

            MessageBox.Show("Operação concluída com sucesso!", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpar();
        }

        public bool ValidarDados()
        {
            if (txtPlaca.Text.Trim() == "")
            {
                MessageBox.Show("Informe a placa!", "Alerta", MessageBoxButtons.OK,
                                                             MessageBoxIcon.Exclamation);
                txtPlaca.Focus();
                txtPlaca.SelectAll();
                return false;
            }

            if (txtModelo.Text.Trim() == "")
            {
                MessageBox.Show("Informe o modelo!", "Alerta", MessageBoxButtons.OK,
                                                             MessageBoxIcon.Exclamation);
                txtModelo.Focus();
                txtModelo.SelectAll();
                return false;
            }

            if (txtCor.Text.Trim() == "")
            {
                MessageBox.Show("Informe a cor!", "Alerta", MessageBoxButtons.OK,
                                                             MessageBoxIcon.Exclamation);
                txtCor.Focus();
                txtCor.SelectAll();
                return false;
            }


            if (txtAno.Text.Trim() == "")
            {
                MessageBox.Show("Informe o ano!", "Alerta", MessageBoxButtons.OK,
                                                             MessageBoxIcon.Exclamation);
                txtAno.Focus();
                txtAno.SelectAll();
                return false;
            }
            return true;
        }

        private void Limpar()
        {
            txtPlaca.Clear();
            txtModelo.Clear();
            txtCor.Clear();
            txtAno.Clear();
            chkAr.Checked = false;
            chkSom.Checked = false;
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            carro.Abrir();
        }
    }
}
