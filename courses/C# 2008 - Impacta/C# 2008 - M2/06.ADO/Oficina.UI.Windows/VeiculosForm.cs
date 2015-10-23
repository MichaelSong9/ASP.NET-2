using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oficina.Modelos;
using Oficina.BLL;

namespace Oficina.UI.Windows
{
    public partial class VeiculosForm : Form
    {
        //Limpar a Tela
        private void LimparTela()
        {
            placaTextBox.Clear();
            modeloTextBox.Clear();
            corTextBox.Clear();
            anoTextBox.Clear();
            placaTextBox.Focus();
        }

        public VeiculosForm()
        {
            InitializeComponent();
        }

        private void inserirButton_Click(object sender, EventArgs e)
        {
            try
            {
                var veiculo = new VeiculoInfo();
                veiculo.Ano = Convert.ToInt16(anoTextBox.Text);
                veiculo.Cor = corTextBox.Text;
                veiculo.Modelo = modeloTextBox.Text;
                veiculo.Placa = placaTextBox.Text;

                var obj = new VeiculoBLL();
                obj.Incluir(veiculo);
                MessageBox.Show("Veiculo cadastrado com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta de Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                {


                }

            }
        }

        private void VeiculosForm_Load(object sender, EventArgs e)
        {
            var obj = new VeiculoBLL();
            dataGridView1.DataSource=obj.Listagem();
        }

        private void procurarButton_Click(object sender, EventArgs e)
        {

        }
    }
}
