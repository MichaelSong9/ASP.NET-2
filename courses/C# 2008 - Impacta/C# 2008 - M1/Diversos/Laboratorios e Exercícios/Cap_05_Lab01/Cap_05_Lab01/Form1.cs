using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cap_05_Lab01
{
    public partial class cadastroForm : Form
    {
        public cadastroForm()
        {
            InitializeComponent();
        }

        private DateTime TextBoxParaData(TextBox txt)
        {
            try
            {
                return Convert.ToDateTime(txt.Text);
            }
            catch 
            {
                txt.Focus();
                txt.Select();
                throw new Exception ("Data inválida!");
            }
        }

        private int TextBoxParaInteiro(TextBox txt)
        {
            try
            {
                return Convert.ToInt32(txt.Text);
            }
            catch
            {
                txt.Focus();
                txt.Select();
                throw new Exception   ("Número incorreto");
            }
        }

        private decimal TextBoxParaDecimal(TextBox txt)
        {
            try
            {
                return Convert.ToDecimal(txt.Text);
            }
            catch
            {
                txt.Focus();
                txt.Select();
                throw new Exception("Número incorreto");
            }
        }

        private void Gravar(string nomeArquivo, string nome, string email,
                                    DateTime dataAdmissao, int idade, decimal salario)
        {
            System.IO.StreamWriter sw;
            sw = new System.IO.StreamWriter(nomeArquivo, true);

            try
            {
                sw.WriteLine("Nome: " + nome);
                sw.WriteLine("Email: " + email);
                sw.WriteLine("Data de admissão: " + dataAdmissao.ToString("dd/MM/yyyy"));
                sw.WriteLine("Idade: " + idade);
                sw.WriteLine("Salário: " + salario.ToString("C"));
                sw.WriteLine("----------------------------------------------");
            }
            catch
            {
                //não faço nada
            }
            finally 
            {
                
                //com erro ou não, fecha o arquivo
                sw.Close();
            }
        }

        private void gravarButton_Click(object sender, EventArgs e)
        {
            string nome, email;
            DateTime dataAdmissao;
            Decimal salario;
            int idade;

            try
            {
                nome=nomeTextBox.Text;
                email=emailTextBox.Text;
                dataAdmissao=TextBoxParaData(dataAdmissaoTextBox);
                salario=TextBoxParaDecimal(salarioTextBox);
                idade=TextBoxParaInteiro(idadeTextBox);

                if (nome == "")
                {
                    nomeTextBox.Focus();
                    nomeTextBox.Select();                    
                    throw new Exception("Nome é obrigatório");

                }
                if (email=="")
                     throw new Exception("Email é obrigatório");

                Gravar("C:\\cadastro.txt",nome,email,dataAdmissao,idade,salario);

                MessageBox.Show("Dados gravados com sucecsso");
            }
            catch(Exception ex)
            {
                MessageBox.Show( ex.Message);
            }
        }

        private void sairButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cadastroForm_KeyDown(object sender, KeyEventArgs e)
        {
            //Form f=(Form)sender;

            //if (e.KeyCode == Keys.Return)
            //    SelectNextControl(f.ActiveControl, true, false, true, true);
        }

        private void cadastroForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            Form f = (Form)sender;

            if (e.KeyChar == 13)
                SelectNextControl(f.ActiveControl, true, false, true, true);
        }
    }
}