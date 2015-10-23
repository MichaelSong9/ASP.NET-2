using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cap09_Lab1
{
    public partial class contasForm : Form
    {
        
        public contasForm()
        {
            InitializeComponent();
        }

        private List<ContaCorrente> lista = new List<ContaCorrente>();
        private ContaCorrente contaAtual;

        private void novaContaButton_Click(object sender, EventArgs e)
        {
            ContaCorrente cc = new ContaCorrente(novaContaTextBox.Text);
            this.lista.Add(cc);
            contasListBox.Items.Add(cc);
            novaContaTextBox.Clear();
            contasListBox.SelectedItem = cc;
            novaContaTextBox.Focus();

            cc.SaldoBaixo += new EventHandler(cc_SaldoBaixo);
        }

        void cc_SaldoBaixo(object sender, EventArgs e)
        {
            MessageBox.Show("Atenção! Saldo baixo");
        }

        private void MostrarConta()
        {
            contaAtualLabel.Text = contaAtual.Nome;
            saldoAtualLabel.Text = contaAtual.Saldo.ToString("C");

            retiradaTextBox.Enabled = true;
            retiradaButton.Enabled = true;
            depositoTextBox.Enabled = true;
            depositoButton.Enabled = true;
            retiradaTextBox.Clear();
            depositoTextBox.Clear();
        }

        private void contasListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.contaAtual = lista[contasListBox.SelectedIndex];
            MostrarConta();
        }

        private void retiradaButton_Click(object sender, EventArgs e)
        {
            contaAtual.Retirar(decimal.Parse(this.retiradaTextBox.Text));
            MostrarConta();
        }

        private void depositoButton_Click(object sender, EventArgs e)
        {
            contaAtual.Depositar(decimal.Parse(this.depositoTextBox.Text));
            MostrarConta();
        }


        
    }
}