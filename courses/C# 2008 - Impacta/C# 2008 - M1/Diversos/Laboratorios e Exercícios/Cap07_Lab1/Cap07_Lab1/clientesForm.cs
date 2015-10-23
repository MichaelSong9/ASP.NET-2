using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cap07_Lab1
{
    public partial class clientesForm : Form
    {
        public clientesForm()
        {
            InitializeComponent();
        }

        private void ObterDados(ClienteInfo cli)
        {
            cli.Nome = nomeTextBox.Text;
            cli.Email = emailTextBox.Text;
            cli.Telefone = telefoneTextBox.Text;
            // a data é convertida
            cli.ClienteDesde = Convert.ToDateTime(clienteDesdeTextBox.Text);
        }

        private void GravarDados(ClienteInfo cli)
        {
            System.IO.StreamWriter sw = new System.IO.StreamWriter(cli.NomeArquivo(),true);
            //aqui a data é formatada
            sw.WriteLine(cli.Nome + ";" +cli.Email + ";" + cli.Telefone + ";" + cli.ClienteDesde.ToShortDateString());
            sw.Close();
        }

        private void LimpaTela()
        {
            nomeTextBox.Clear();
            emailTextBox.Clear();
            telefoneTextBox.Clear();
            clienteDesdeTextBox.Clear();
            nomeTextBox.Focus();
        }
        private void sairButton_Click(object sender, EventArgs e)
        {
            DialogResult resposta = new DialogResult();
            resposta = MessageBox.Show("Deseja fechar o formulário?",
                "Finalizar formulário", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (resposta == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void gravarButton_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteInfo cliente = new ClienteInfo();
                ObterDados(cliente);
                GravarDados(cliente);
                MessageBox.Show("Dados gravados com sucesso");
                LimpaTela();
            }
            catch
            {
                MessageBox.Show("Erro no cadastramento de cliente \nTente novamente");
            }
        }
    }
}