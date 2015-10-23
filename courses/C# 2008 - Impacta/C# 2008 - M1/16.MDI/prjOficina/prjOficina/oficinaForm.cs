using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjOficina
{
    public partial class oficinaForm : Form
    {
        public oficinaForm()
        {
            InitializeComponent();
        }

        VeiculoInfo carro = new VeiculoInfo("c:\\teste.txt");
//        VeiculoInfo carro = new VeiculoInfo();

        private void gravarButton_Click(object sender, EventArgs e)
        {

            try
            {
                carro.Placa = Geral.TahVazio(placaTextBox);
                carro.Modelo = Geral.TahVazio(modeloTextBox);
                carro.Cor = Geral.TahVazio(corTextBox);
                carro.Ano = Geral.EhShort(anoTextBox);

                carro.Gravar();

                MessageBox.Show("Operação concluída com sucesso",
                    "Mensagem", MessageBoxButtons.OK,MessageBoxIcon.Information);

//                placaTextBox.Clear();
//                modeloTextBox.Clear();
//                corTextBox.Clear();
//                anoTextBox.Clear();

                Geral.LimparTela(this);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta de Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void sairButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void abrirButton_Click(object sender, EventArgs e)
        {
            try
            {
                carro.Abrir();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta de Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string[] x = System.IO.Directory.GetFiles("c:\\").ToArray();
            for (int i = 0; i < x.Length; i++)
            {
                listBox1.Items.Add(x[i].ToString());
            }
        }
    }
}
