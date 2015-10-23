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
                throw new Exception ("Data inv�lida!");
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
                throw new Exception   ("N�mero incorreto");
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
                throw new Exception("N�mero incorreto");
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
                sw.WriteLine("Data de admiss�o: " + dataAdmissao.ToString("dd/MM/yyyy"));
                sw.WriteLine("Idade: " + idade);
                sw.WriteLine("Sal�rio: " + salario.ToString("C"));
                sw.WriteLine("----------------------------------------------");
            }
            catch
            {
                //n�o fa�o nada
            }
            finally 
            {
                
                //com erro ou n�o, fecha o arquivo
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
                    throw new Exception("Nome � obrigat�rio");

                }
                if (email=="")
                     throw new Exception("Email � obrigat�rio");

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