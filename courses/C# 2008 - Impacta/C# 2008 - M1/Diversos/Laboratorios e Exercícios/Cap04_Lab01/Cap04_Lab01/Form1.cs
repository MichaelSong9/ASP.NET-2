using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cap04_Lab01
{
    public partial class cadastroForm : Form
    {
        public cadastroForm()
        {
            InitializeComponent();
        }

        private void gravarButton_Click(object sender, EventArgs e)
        {
            try
            {
                Funcionario obj = new Funcionario();
                
                obj.Nome=nomeTextBox.Text;
                obj.Idade=Convert.ToByte(idadeTextBox.Text);
                obj.Salario = Convert.ToDecimal(salarioTextBox.Text);
                obj.Cargo = cargoTextBox.Text;
                obj.DataAdmissao = Convert.ToDateTime(dataAdmissaoTextBox.Text);

                System.IO.StreamWriter sw = new System.IO.StreamWriter("C:\\dados.txt");

                sw.WriteLine("Dados do Funcionário");
                sw.WriteLine(obj.Nome);
                sw.WriteLine(obj.Idade + " anos");
                sw.WriteLine("Cargo: " + obj.Cargo);
                sw.WriteLine("Salário: " + obj.Salario.ToString("C"));
                sw.WriteLine("Admitido em " + obj.DataAdmissao.ToShortDateString());
                sw.WriteLine("-----------------------------------------------------");
                sw.Close();

                MessageBox.Show("Funcionário cadastrado", "RH",MessageBoxButtons.OK,MessageBoxIcon.Information);

                nomeTextBox.Text = "";
                idadeTextBox.Text = "";
                cargoTextBox.Text = "";
                salarioTextBox.Text = "";
                dataAdmissaoTextBox.Text = "";
                nomeTextBox.Focus();
            
            }
           catch (Exception ex)
           {
               MessageBox.Show("Erro: " + ex.Message);
           }
        }

        private void sairButton_Click(object sender, EventArgs e)
        {
            
            
            Application.Exit();
        }
    }
}