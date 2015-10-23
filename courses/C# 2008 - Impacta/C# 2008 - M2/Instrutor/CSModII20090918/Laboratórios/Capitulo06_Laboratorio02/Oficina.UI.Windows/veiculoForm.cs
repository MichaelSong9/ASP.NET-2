using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.Common;
using Oficina.Modelos;
using Oficina.BLL;

namespace Oficina.UI.Windows
{
    public partial class veiculoForm : Form
    {
        public veiculoForm()
        {
            InitializeComponent();
        }

        private void LimparTela()
        {
            placaTextBox.Clear();
            modeloTextBox.Clear();
            corTextBox.Clear();
            anoTextBox.Clear();

            placaTextBox.Focus();
            placaTextBox.SelectAll();
        }

        private void inserirButton_Click(object sender, EventArgs e)
        {
            try
            {
                VeiculoInfo veiculo = new VeiculoInfo();
                
                veiculo.Placa = placaTextBox.Text;
                veiculo.Modelo = modeloTextBox.Text;
                veiculo.Cor = corTextBox.Text;
                veiculo.Ano = Convert.ToInt16(anoTextBox.Text);

                VeiculoBLL obj = new VeiculoBLL();
                obj.Incluir(veiculo);

                MessageBox.Show("Veículo cadastrado com sucesso", "Aviso", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Limpar a tela
                LimparTela();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta de Erro", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void procurarButton_Click(object sender, EventArgs e)
        {
            try
            {
                VeiculoBLL obj = new VeiculoBLL();
                DbDataReader dr = obj.PesquisarPorPlaca(placaTextBox.Text);

                if (dr.Read())
                {
                    modeloTextBox.Text = dr["modelo"].ToString();
                    corTextBox.Text = dr["cor"].ToString();
                    anoTextBox.Text = dr["ano"].ToString();

                    placaTextBox.Focus();
                    placaTextBox.SelectAll();
                }
                else
                {
                    modeloTextBox.Clear();
                    corTextBox.Clear();
                    anoTextBox.Clear();
                    placaTextBox.Focus();
                    placaTextBox.SelectAll();

                    MessageBox.Show("Veículo não cadastrado", "Alerta",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta de Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void alterarButton_Click(object sender, EventArgs e)
        {
            try
            {
                VeiculoInfo veiculo = new VeiculoInfo();

                veiculo.Placa = placaTextBox.Text;
                veiculo.Modelo = modeloTextBox.Text;
                veiculo.Cor = corTextBox.Text;
                veiculo.Ano = Convert.ToInt16(anoTextBox.Text);

                VeiculoBLL obj = new VeiculoBLL();
                obj.Alterar(veiculo);

                MessageBox.Show("Veículo alterado com sucesso", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                placaTextBox.Focus();
                placaTextBox.SelectAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta de Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void excluirButton_Click(object sender, EventArgs e)
        {
            DialogResult resposta = 
                MessageBox.Show("Deseja excluir este veículo?", "Alerta", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, 
                MessageBoxDefaultButton.Button2);

            if (resposta == DialogResult.No)
            {
                return;
            }

            try
            {
                VeiculoInfo veiculo = new VeiculoInfo();

                veiculo.Placa = placaTextBox.Text;
               
                VeiculoBLL obj = new VeiculoBLL();
                obj.Excluir(veiculo);

                MessageBox.Show("Veículo excluído com sucesso", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimparTela();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta de Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

               //Obs.: Erro 547 é conflito de chave estrangeira
            }
        }

    }
}
