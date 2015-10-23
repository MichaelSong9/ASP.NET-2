using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cap08_Lab1
{
    public partial class CadastroForm : Form
    {
        public CadastroForm()
        {
            InitializeComponent();
        }

        private void gravarButton_Click(object sender, EventArgs e)
        {
            TextoInfo obj = new TextoInfo(tituloTextbox.Text, textoTextbox.Text);

            obj.Gravar();

            MessageBox.Show("Arquivo gravado com sucesso");
        }

        private void lerButton_Click(object sender, EventArgs e)
        {
            try
            {
                TextoInfo obj = new TextoInfo(tituloTextbox.Text);
                textoTextbox.Text = obj.Ler();
            }
            catch
            {
                MessageBox.Show("Erro ao tentar ler o arquivo");
            }
        }

        private void LimparTela()
        {
            tituloTextbox.Clear();
            textoTextbox.Clear();
            tituloTextbox.Focus();
        }

        private void limparButton_Click(object sender, EventArgs e)
        {
            LimparTela();
        }
    }
}