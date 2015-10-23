using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cap07_Lab1
{
    public partial class funcionariosForm : Form
    {
        public funcionariosForm()
        {
            InitializeComponent();
        }

        private void ObterDados(FuncionarioInfo func)
        {
            func.Nome = nomeTextBox.Text;
            func.Email = emailTextBox.Text;
            func.Cargo = cargoTextBox.Text;
            func.Salario = Convert.ToDecimal(salarioTextBox.Text);
        }

        private void GravarDados(FuncionarioInfo func)
        {
            System.IO.StreamWriter sw = new System.IO.StreamWriter(func.NomeArquivo(),true);
            sw.WriteLine(func.Nome + ";" + func.Email + ";" + 
                func.Cargo + ";" + func.Salario.ToString());
            sw.Close();
        }

        private void LimpaTela()
        {
            nomeTextBox.Clear();
            emailTextBox.Clear();
            cargoTextBox.Clear();
            salarioTextBox.Clear();
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
            //try
            //{
            FuncionarioInfo funcionario = new FuncionarioInfo();
            ObterDados(funcionario);
            GravarDados(funcionario);
            MessageBox.Show("Funcionário cadastrado com sucesso");
            LimpaTela();
            //}
            //catch
            //{
            //    MessageBox.Show("Erro ao cadastrar funcionário \nTente novamente");
            //}
        }
    }
}